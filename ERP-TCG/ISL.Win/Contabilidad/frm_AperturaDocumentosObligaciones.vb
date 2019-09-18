Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_AperturaDocumentosObligaciones
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    Private dt As DataTable
    Private IdMonedaConsulta As String
    Private TipoConsulta As String
    Dim olDocumento As New l_MovimientoDocumento
    Private oeAsientoModel As e_AsientoModelo, oeAsientoModGan As e_AsientoModelo, oeAsientoModPer As e_AsientoModelo
    Private olAsientoModel As l_AsientoModelo, leAsientoModel As List(Of e_AsientoModelo)
    Private oeReferencia As e_AsientoModelo_Referencia, olReferencia As l_AsientoModelo_Referencia, leReferencia As List(Of e_AsientoModelo_Referencia)
    Private oeApertura As e_AjusteTC, leApertura As List(Of e_AjusteTC), olApertura As l_Asiento
    Private oeCtaCble As e_CuentaContable, olCtaCble As l_CuentaContable, leCtaCbleCierre As List(Of e_CuentaContable), leCtaCbleApertura As List(Of e_CuentaContable)
    Private DTReferencia As Data.DataTable, dtAux As Data.DataTable

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            leAsientoModel = New List(Of e_AsientoModelo)
            If Not DecTC.Value > 0 Then Throw New Exception("Ingrese Tipo de Cambio de Cierre")
            Dim _NroSel = grid_Apertura.Rows.Where(Function(it) it.Cells("Seleccion").Value = True).Count
            If _NroSel = 0 Then Throw New Exception("¡Seleccione los Registros que Desee Guardar!")
            Dim oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
            Dim ls_IdPeriodoCierre As String = "", ls_IdPeriodoApertura As String = ""
            If optMoneda.CheckedIndex = 1 Then
                'Obtener Periodo de Cierre
                oePeriodo.Ejercicio = Año1.Año : oePeriodo.Mes = 12
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                If oePeriodo Is Nothing Or oePeriodo.Id.Trim = String.Empty Then Throw New Exception("No Existe el Periodo: 12/" & (Año1.Año).ToString)
                ls_IdPeriodoCierre = oePeriodo.Id.Trim
                ' Cargar Cuentas Contables de Cierre
                oeCtaCble = New e_CuentaContable : olCtaCble = New l_CuentaContable : leCtaCbleCierre = New List(Of e_CuentaContable)
                oeCtaCble.Activo = True : oeCtaCble.Movimiento = 1 : oeCtaCble.Ejercicio = Año1.Año
                leCtaCbleCierre = olCtaCble.Listar(oeCtaCble)
            End If
            'Obtener Periodo de Apertura
            oePeriodo = New e_Periodo
            oePeriodo.Ejercicio = Año1.Año + 1 : oePeriodo.Mes = 1
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If oePeriodo Is Nothing Or oePeriodo.Id.Trim = String.Empty Then Throw New Exception("No Existe el Periodo: 01/" & (Año1.Año + 1).ToString)
            ls_IdPeriodoApertura = oePeriodo.Id.Trim
            ' Cargar Cuentas Contables de Apertura
            oeCtaCble = New e_CuentaContable : olCtaCble = New l_CuentaContable : leCtaCbleApertura = New List(Of e_CuentaContable)
            oeCtaCble.Activo = True : oeCtaCble.Movimiento = 1 : oeCtaCble.Ejercicio = Año1.Año + 1
            leCtaCbleApertura = olCtaCble.Listar(oeCtaCble)
            'Filtra DtReferencia
            dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            Dim _MontoAux As Double = 0
            cadSQL = "TipoRef1 = 4 AND Ref1 = '"
            Select Case optMoneda.CheckedIndex
                Case 0 : cadSQL = cadSQL & "SOLES" & "'"
                Case 1 : cadSQL = cadSQL & "DOLARES" & "'"
            End Select
            cadSQL = cadSQL & " AND TipoRef2 = 11 AND Ref2 = '"
            Select Case opcCtaCte.CheckedIndex
                Case 0 : cadSQL = cadSQL & "COBRO" & "'"
                Case 1 : cadSQL = cadSQL & "PAGO" & "'"
                Case 2 : cadSQL = cadSQL & "OBLIGACION" & "'"
            End Select
            _rwAux = DTReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
            dtAux = _rwAux.CopyToDataTable
            'Obtiene Asiento Modelo por Referencia de Apertura 
            Dim ls_IdAsientoGan As String
            oeAsientoModel = New e_AsientoModelo : olAsientoModel = New l_AsientoModelo
            oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModel.Ejercicio = Año1.Año + 1
            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
            If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
            oeAsientoModel.TipoCambio = DecTC.Value : oeAsientoModel.UsuarioCreacion = gUsuarioSGI.Id : oeAsientoModel.IdPeriodo = ls_IdPeriodoApertura
            oeAsientoModel.FechaMov = gf_InicioFinMes("P", Año1.Año + 1, 1) : oeAsientoModel.IndVinculado = False
            ls_IdAsientoGan = oeAsientoModel.IdVinculado.Trim
            Dim ls_CuentaApertura As String = "", ls_IdCuentaApertura As String = ""
            leApertura = New List(Of e_AjusteTC)
            For Each Fil In grid_Apertura.Rows.Where(Function(it) it.Cells("Seleccion").Value = True).OrderBy(Function(it) it.Cells("Cuenta").Value)
                oeApertura = New e_AjusteTC
                oeApertura.IdAsientoModelo = oeAsientoModel.Id
                oeApertura.IdMovimientoDocumento = Fil.Cells("Id").Value : oeApertura.Cuenta = Fil.Cells("Cuenta").Value
                If ls_CuentaApertura <> oeApertura.Cuenta Then
                    ls_CuentaApertura = oeApertura.Cuenta
                    Dim _leAuxAper = leCtaCbleApertura.Where(Function(it) it.Cuenta = oeApertura.Cuenta).ToList
                    If _leAuxAper.Count > 0 Then ls_IdCuentaApertura = _leAuxAper(0).Id
                End If
                oeApertura.IdCuentaContable = ls_IdCuentaApertura
                oeApertura.Glosa = Fil.Cells("Nombre").Value & " " & Fil.Cells("TipoDocAbrev").Value & "/" & Fil.Cells("Serie").Value & Fil.Cells("Numero").Value
                _MontoAux = IIf(optMoneda.CheckedIndex = 0, Fil.Cells("SaldoMN").Value, Fil.Cells("SaldoME").Value)
                'If OpcCtaCte.CheckedIndex = 0 Then
                If _MontoAux > 0 Then
                    oeApertura.Debe = Math.Abs(_MontoAux) : oeApertura.Haber = 0
                Else
                    oeApertura.Debe = 0 : oeApertura.Haber = Math.Abs(_MontoAux)
                End If
                'Else
                '    If _MontoAux > 0 Then
                '        oeApertura.Debe = 0 : oeApertura.Haber = Math.Abs(_MontoAux)
                '    Else
                '        oeApertura.Debe = Math.Abs(_MontoAux) : oeApertura.Haber = 0
                '    End If
                'End If
                leApertura.Add(oeApertura)
            Next
            leAsientoModel.Add(oeAsientoModel)
            If optMoneda.CheckedIndex = 1 Then
                'Obtiene Asiento Modelo de Ganancia
                Dim ls_IdAsientoPer As String
                oeAsientoModGan = New e_AsientoModelo : olAsientoModel = New l_AsientoModelo
                oeAsientoModGan.TipoOperacion = "" : oeAsientoModGan.Activo = True : oeAsientoModGan.Id = ls_IdAsientoGan
                oeAsientoModGan.Ejercicio = Año1.Año
                oeAsientoModGan = olAsientoModel.Obtener(oeAsientoModGan)
                If oeAsientoModGan.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                oeAsientoModGan.TipoCambio = DecTC.Value : oeAsientoModGan.UsuarioCreacion = gUsuarioSGI.Id
                oeAsientoModGan.IdPeriodo = ls_IdPeriodoCierre
                oeAsientoModGan.FechaMov = gf_InicioFinMes("F", Año1.Año, 12)
                oeAsientoModGan.IndVinculado = True
                ls_IdAsientoPer = oeAsientoModGan.IdVinculado
                'Obtiene Asiento Modelo de Perdida
                oeAsientoModPer = New e_AsientoModelo : olAsientoModel = New l_AsientoModelo
                oeAsientoModPer.TipoOperacion = "" : oeAsientoModPer.Activo = True : oeAsientoModPer.Id = ls_IdAsientoPer
                oeAsientoModPer.Ejercicio = Año1.Año
                oeAsientoModPer = olAsientoModel.Obtener(oeAsientoModPer)
                If oeAsientoModPer.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                oeAsientoModPer.TipoCambio = DecTC.Value : oeAsientoModPer.UsuarioCreacion = gUsuarioSGI.Id
                oeAsientoModPer.IdPeriodo = ls_IdPeriodoCierre
                oeAsientoModPer.FechaMov = gf_InicioFinMes("F", Año1.Año, 12)
                oeAsientoModPer.IndVinculado = True
                'Obtiene Diferencia por Tipo Cambio de Cierre
                Dim ls_CuentaCierre As String = "", ls_IdCuentaCierre As String = ""
                Dim ln_SaldoTC As Double = 0, ln_Saldo As Double, ln_DifSaldo As Double = 0
                For Each Fil In grid_Apertura.Rows.Where(Function(it) it.Cells("Seleccion").Value = True).OrderBy(Function(it) it.Cells("Cuenta").Value)
                    ln_SaldoTC = 0 : ln_Saldo = 0 : ln_DifSaldo = 0
                    oeApertura = New e_AjusteTC
                    oeApertura.IdMovimientoDocumento = Fil.Cells("Id").Value : oeApertura.Cuenta = Fil.Cells("Cuenta").Value
                    If ls_CuentaCierre <> oeApertura.Cuenta Then
                        ls_CuentaCierre = oeApertura.Cuenta
                        Dim _leAuxCier = leCtaCbleCierre.Where(Function(it) it.Cuenta = oeApertura.Cuenta).ToList
                        If _leAuxCier.Count > 0 Then ls_IdCuentaCierre = _leAuxCier(0).Id
                    End If
                    oeApertura.IdCuentaContable = ls_IdCuentaCierre
                    oeApertura.Glosa = "AJUSTE TC " & Fil.Cells("TipoDocAbrev").Value & "/" & Fil.Cells("Serie").Value & Fil.Cells("Numero").Value & " " & Fil.Cells("Nombre").Value
                    ln_Saldo = Fil.Cells("SaldoME").Value * Fil.Cells("TipoCambio").Value : ln_SaldoTC = Fil.Cells("SaldoME").Value * DecTC.Value
                    ln_DifSaldo = Math.Abs(ln_Saldo) - Math.Abs(ln_SaldoTC)
                    'If OpcCtaCte.CheckedIndex = 0 Then
                    If ln_Saldo > 0 Then
                        oeApertura.Debe = IIf(ln_DifSaldo > 0, 0, Math.Abs(ln_DifSaldo)) : oeApertura.Haber = IIf(ln_DifSaldo > 0, Math.Abs(ln_DifSaldo), 0)
                    Else
                        oeApertura.Debe = IIf(ln_DifSaldo > 0, Math.Abs(ln_DifSaldo), 0) : oeApertura.Haber = IIf(ln_DifSaldo > 0, 0, Math.Abs(ln_DifSaldo))
                    End If
                    'Else
                    '    If ln_Saldo > 0 Then
                    '        oeApertura.Debe = IIf(ln_DifSaldo > 0, Math.Abs(ln_DifSaldo), 0) : oeApertura.Haber = IIf(ln_DifSaldo > 0, 0, Math.Abs(ln_DifSaldo))
                    '    Else
                    '        oeApertura.Debe = IIf(ln_DifSaldo > 0, 0, Math.Abs(ln_DifSaldo)) : oeApertura.Haber = IIf(ln_DifSaldo > 0, Math.Abs(ln_DifSaldo), 0)
                    '    End If
                    'End If
                    oeApertura.IdAsientoModelo = IIf(oeApertura.Haber > 0, ls_IdAsientoPer, ls_IdAsientoGan)
                    leApertura.Add(oeApertura)
                Next
                leAsientoModel.Add(oeAsientoModGan)
                leAsientoModel.Add(oeAsientoModPer)
            End If
            Dim lb_Obli As Boolean = False
            If opcCtaCte.CheckedIndex = 2 Then lb_Obli = True
            'Guardar Informacion
            olApertura = New l_Asiento
            If olApertura.GuardarApertura(leAsientoModel, leApertura, lb_Obli, gs_PrefijoIdSucursal) Then
                mensajeEmergente.Confirmacion("¡Se Guardaron los Datos Correctamente!", True)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficDatos.ActiveTab.Index = 0 Then
                If grid_Apertura.Rows.Count = 0 Then Throw New Exception("No hay ninguna fila para exportar al Excel")
                Exportar_Excel(grid_Apertura)
            ElseIf ficDatos.ActiveTab.Index = 1 Then
                If griDetalle.Rows.Count = 0 Then Throw New Exception("No hay ninguna fila para exportar al Excel")
                Exportar_Excel(griDetalle)
            End If

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Inicialización del formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_AperturaDocumentosObligaciones = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_AperturaDocumentosObligaciones()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Métodos"

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Espere1.Visible = True
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            TipoConsulta = ""
            Dim olMovimientoDoc As New l_MovimientoDocumento
            If optMoneda.CheckedIndex = -1 Then Throw New Exception("Seleccione una opcion de las monedas")
            IdMonedaConsulta = IIf(optMoneda.CheckedIndex = 0, "1CH01", "1CH02")
            If opcCtaCte.CheckedIndex = 0 Then ' clientes
                TipoConsulta = "Clientes"
                Dt = olMovimientoDoc.CuentasxCobrarxPeriodo(Año1.Año, 12, "A", IdMonedaConsulta)
            ElseIf opcCtaCte.CheckedIndex = 1 Then 'provedores
                TipoConsulta = "Proveedores"
                Dt = olMovimientoDoc.CuentasxPagarxPeriodo(Año1.Año, 12, "B", IdMonedaConsulta)
            ElseIf opcCtaCte.CheckedIndex = 2 Then 'obligaciones
                TipoConsulta = "Obligacion"
                Dt = olMovimientoDoc.CuentasxPagarxPeriodo(Año1.Año, 12, "F", IdMonedaConsulta)
            Else
                Throw New Exception("Seleccione una opcion de Clientes, Proveedores , Obligaciones")
            End If
            grid_Apertura.DataSource = Dt
            grid_Apertura.DataBind()
            grid_Apertura.DisplayLayout.Bands(0).Columns("Seleccion").Style = ColumnStyle.CheckBox
            CalcularTotales(grid_Apertura, "SaldoMN", "SaldoME")
            Calcular_Importes()
            Espere1.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True) : Espere1.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : Espere1.Visible = False
        End Try
    End Sub

    Private Sub Calcular_Importes()
        Try
            If grid_Apertura.Rows.Count > 0 Then
                Dim _MontoDebe As Double = 0, _MontoHaber As Double = 0
                ndTotalDebeSol.Value = 0 : ndTotaHaberSol.Value = 0
                If optMoneda.CheckedIndex = 0 Then
                    If opcCtaCte.CheckedIndex = 0 Then
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.Cells("SaldoMN").Value > 0)
                            _MontoDebe = _MontoDebe + Fil.Cells("SaldoMN").Value
                        Next
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.Cells("SaldoMN").Value < 0)
                            _MontoHaber = _MontoHaber + Fil.Cells("SaldoMN").Value
                        Next
                    Else
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.Cells("SaldoMN").Value < 0)
                            _MontoDebe = _MontoDebe + Fil.Cells("SaldoMN").Value
                        Next
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.Cells("SaldoMN").Value > 0)
                            _MontoHaber = _MontoHaber + Fil.Cells("SaldoMN").Value
                        Next
                    End If
                Else
                    If opcCtaCte.CheckedIndex = 0 Then
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.Cells("SaldoME").Value > 0)
                            _MontoDebe = _MontoDebe + Fil.Cells("SaldoME").Value
                        Next
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.Cells("SaldoME").Value < 0)
                            _MontoHaber = _MontoHaber + Fil.Cells("SaldoME").Value
                        Next
                    Else
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.Cells("SaldoME").Value < 0)
                            _MontoDebe = _MontoDebe + Fil.Cells("SaldoME").Value
                        Next
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.Cells("SaldoME").Value > 0)
                            _MontoHaber = _MontoHaber + Fil.Cells("SaldoME").Value
                        Next
                    End If
                End If
                ndTotalDebeSol.Value = Math.Abs(_MontoDebe) : ndTotaHaberSol.Value = Math.Abs(_MontoHaber)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAsiento()
        'Cargar Asiento Modelo Referencia
        oeReferencia = New e_AsientoModelo_Referencia : olReferencia = New l_AsientoModelo_Referencia : leReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        leReferencia = olReferencia.Listar(oeReferencia)
        'Cargar DT Referencia
        DTReferencia = GeneraDTRef(leReferencia)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_AperturaDocumentosObligaciones_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_AperturaDocumentosObligaciones_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_AperturaDocumentosObligaciones_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_AperturaDocumentosObligaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'opcCtaCte.Items(0).CheckState = CheckState.Checked
            'Opciones1.Items(0).CheckState = CheckState.Checked
            CargarAsiento()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_Apertura_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Apertura.CellChange
        Try
            grid_Apertura.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_Apertura_AfterRowFilterChanged(sender As Object, e As AfterRowFilterChangedEventArgs) Handles grid_Apertura.AfterRowFilterChanged
        Try
            agrDatosFiltros.Visible = False : ndDebeFiltro.Value = 0 : ndHaberFiltro.Value = 0
            Dim _NroFiltros = grid_Apertura.Rows.Where(Function(it) it.IsFilteredOut = False).Count
            If _NroFiltros > 0 AndAlso _NroFiltros < grid_Apertura.Rows.Count Then
                Dim _MontoDebe As Double = 0, _MontoHaber As Double = 0
                agrDatosFiltros.Visible = True
                If optMoneda.CheckedIndex = 0 Then
                    If opcCtaCte.CheckedIndex = 0 Then
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.IsFilteredOut = False And it.Cells("SaldoMN").Value > 0)
                            _MontoDebe = _MontoDebe + Fil.Cells("SaldoMN").Value
                        Next
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.IsFilteredOut = False And it.Cells("SaldoMN").Value < 0)
                            _MontoHaber = _MontoHaber + Fil.Cells("SaldoMN").Value
                        Next
                    Else
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.IsFilteredOut = False And it.Cells("SaldoMN").Value < 0)
                            _MontoDebe = _MontoDebe + Fil.Cells("SaldoMN").Value
                        Next
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.IsFilteredOut = False And it.Cells("SaldoMN").Value > 0)
                            _MontoHaber = _MontoHaber + Fil.Cells("SaldoMN").Value
                        Next
                    End If
                Else
                    If opcCtaCte.CheckedIndex = 0 Then
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.IsFilteredOut = False And it.Cells("SaldoME").Value > 0)
                            _MontoDebe = _MontoDebe + Fil.Cells("SaldoME").Value
                        Next
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.IsFilteredOut = False And it.Cells("SaldoME").Value < 0)
                            _MontoHaber = _MontoHaber + Fil.Cells("SaldoME").Value
                        Next
                    Else
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.IsFilteredOut = False And it.Cells("SaldoME").Value < 0)
                            _MontoDebe = _MontoDebe + Fil.Cells("SaldoME").Value
                        Next
                        For Each Fil In grid_Apertura.Rows.Where(Function(it) it.IsFilteredOut = False And it.Cells("SaldoME").Value > 0)
                            _MontoHaber = _MontoHaber + Fil.Cells("SaldoME").Value
                        Next
                    End If
                End If
                ndDebeFiltro.Value = Math.Abs(_MontoDebe) : ndHaberFiltro.Value = Math.Abs(_MontoHaber)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Apertura_DoubleClick(sender As Object, e As EventArgs) Handles grid_Apertura.DoubleClick
        Try
            If grid_Apertura.Selected.Rows.Count = 0 Then Throw New Exception("Seleccione un Registro.")
            Dim oeMovDoc As New e_MovimientoDocumento
            Select Case opcCtaCte.CheckedIndex
                Case 0 : oeMovDoc.TipoOperacion = IIf(optMoneda.CheckedIndex = 0, "1", "2")
                Case 1 : oeMovDoc.TipoOperacion = IIf(optMoneda.CheckedIndex = 0, "3", "4")
                Case 2 : oeMovDoc.TipoOperacion = IIf(optMoneda.CheckedIndex = 0, "5", "6")
            End Select
            oeMovDoc.Ejercicio = Año1.Año : oeMovDoc.Mes = 12
            oeMovDoc.Id = grid_Apertura.ActiveRow.Cells("Id").Value
            oeMovDoc.IdCuentaContable = grid_Apertura.ActiveRow.Cells("Cuenta").Value
            griDetalle.DataSource = olDocumento.AperturaDetalle(oeMovDoc)

            ndDebeDet.Value = 0 : ndHaberDet.Value = 0 : ndSaldoDet.Value = 0
            griDetalle.ResetDisplayLayout()
            ConfiguraGrilla(griDetalle, "Tahoma", True, UIElementBorderStyle.Default)
            OcultarColumna(griDetalle, True, "Id", "IdAsientoMovimiento")
            OcultarColumna(griDetalle, True, "Id", "IdAsiento")
            FormatoColumna(griDetalle, "#,##0.000", ColumnStyle.Double, HAlign.Right, "TipoCambio")
            FormatoColumna(griDetalle, "#,##0.00", ColumnStyle.Double, HAlign.Right, "DebeMN", "DebeME", "HaberMN", "HaberME")
            CalcularTotales(griDetalle, "DebeMN", "DebeME", "HaberMN", "HaberME")
            griDetalle.DisplayLayout.Bands(0).Columns("TipoCambio").Header.Caption = "T.C."
            griDetalle.DisplayLayout.Bands(0).Columns("Cuenta").Width = 60
            griDetalle.DisplayLayout.Bands(0).Columns("Periodo").Width = 60
            griDetalle.DisplayLayout.Bands(0).Columns("TipoAsiento").Width = 75
            griDetalle.DisplayLayout.Bands(0).Columns("NroAsiento").Width = 70
            griDetalle.DisplayLayout.Bands(0).Columns("NroAsiento").CellClickAction = CellClickAction.EditAndSelectText
            griDetalle.DisplayLayout.Bands(0).Columns("Glosa").Width = 350
            griDetalle.DisplayLayout.Bands(0).Columns("TipoCambio").Width = 50
            griDetalle.DisplayLayout.Bands(0).Columns("Usuario").Width = 220
            MostrarTabs(1, ficDatos, 1)
            If griDetalle.Rows.Count > 0 Then
                If grid_Apertura.ActiveRow.Cells("IdMoneda").Value = "1CH02" Then
                    ndDebeDet.Value = griDetalle.Rows.Sum(Function(it) CDbl(it.Cells("DebeME").Value))
                    ndHaberDet.Value = griDetalle.Rows.Sum(Function(it) CDbl(it.Cells("HaberME").Value))
                    ndSaldoDet.Value = ndDebeDet.Value - ndHaberDet.Value
                Else
                    ndDebeDet.Value = griDetalle.Rows.Sum(Function(it) CDbl(it.Cells("DebeMN").Value))
                    ndHaberDet.Value = griDetalle.Rows.Sum(Function(it) CDbl(it.Cells("HaberMN").Value))
                    ndSaldoDet.Value = ndDebeDet.Value - ndHaberDet.Value
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnRetornar_Click(sender As Object, e As EventArgs) Handles btnRetornar.Click
        MostrarTabs(0, ficDatos, 0)
    End Sub

#End Region

End Class