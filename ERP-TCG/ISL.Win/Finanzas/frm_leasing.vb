'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Leasing
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    Private oeContratoLeasing As New e_ContratoFinanciero, olContratoLeasing As New l_ContratoFinanciero
    Private oeCuotaLeasing As New e_ObligacionFin, olCuotaLeasing As New l_ObligacionFinanciera
    Private lstCuotaLeasing As New List(Of e_ObligacionFin)
    Private WithEvents oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento, oeCuentaBancaria As New e_CuentaBancaria
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeTipoObligacion As New e_TipoDocumento, olTipoObligacion As New l_TipoDocumento, leTipoObligacion As New List(Of e_TipoDocumento)
    Private oeMoneda As New e_Moneda, olMoneda As New l_Moneda
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, olProveedor As New l_Proveedor
    Private dsLeasing As DataSet, relationContratoObligFin As DataRelation
    Private _opeLeasing As String = "", _acl As String = "", IdLeasing As String, IdCtaCtble As String

#End Region

#Region "Instancia"

    Private Shared instancia As frm_Leasing = Nothing
    Private Shared Operacion As String

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Leasing
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            If tcLeasing.Tabs(0).Selected Then
                ListarLeasing()
                If grid_Leasing.Rows.Count > 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            ElseIf tcLeasing.Tabs(1).Selected Then
                ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If tcLeasing.Tabs(0).Selected Then
                    MostrarTabs(1, tcLeasing, 1)
                    ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 0)
                    Operacion = "Nuevo"
                End If
                Inicializar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarLeasing() Then
                ListarLeasing()
                MostrarTabs(0, tcLeasing)
                ControlBoton(1, 1, 0, 0, 0, 1, 0, 0, 1)
            Else
                ControlBoton(1, 0, 0, 1, 1, 0, 1, 1, 1)
                Operacion = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            'Consultar(True) 'activa desactiva botonera
            MostrarTabs(0, tcLeasing, 0)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Operacion = ""
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'With gridLeasing
            '    ValidarGrilla(gridLeasing, "Obligacion")
            '    If Not .ActiveRow Is Nothing AndAlso .ActiveRow.Cells("Id").Value.ToString <> "" Then
            '        oeObligacion.Id = .ActiveRow.Cells("Id").Value
            '        oeObligacion = olObligacion.Obtener(oeObligacion)
            '        If oeObligacion.Activo Then
            '            If MessageBox.Show("Esta seguro de eliminar la Obligacion: " & _
            '                 .ActiveRow.Cells("codigo").Value.ToString & " ?", "Mensaje del Sistema", _
            '                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            '                oeObligacion.TipoOperacion = "X"
            '                oeObligacion.Codigo = "LEASING"
            '                olObligacion.Eliminar(oeObligacion)
            '                Consultar(True)
            '            End If
            '        Else
            '            Throw New Exception("La informacion  se encuentra eliminada.")
            '        End If
            '    Else
            '        Throw New Exception("Seleccione una Fila!")
            '    End If
            'End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If grid_Leasing.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Leasing)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Function GuardarLeasing() As Boolean
        Try
            Espere1.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            IdCtaCtble = String.Empty
            ValidarCombo(cboMoneda, "Moneda")
            ValidarCombo(cboBanco, "Banco")
            If lstCuotaLeasing.Count = 0 Then Throw New Exception("Ingrese Cuotas")
            'Obtener Periodo
            oePeriodo = New e_Periodo
            oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
            oeContratoLeasing.IdPeriodo = oePeriodo.Id
            'Obtiene Asiento Modelo por Moneda
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.Equivale = 1 : oeAsientoModel.IdMoneda = cboMoneda.Value
            If leAsientoModel.Contains(oeAsientoModel) Then
                oeAsientoModel = leAsientoModel.Item(leAsientoModel.IndexOf(oeAsientoModel))
                oeAsientoModel.TipoOperacion = ""
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count > 0 Then
                    Dim _leDetAux = oeAsientoModel.leDetalle.Where(Function(it) it.Cuenta.Contains(gCCTOLeasing)).ToList
                    If _leDetAux.Count > 0 Then IdCtaCtble = _leDetAux(0).IdCuentaContable
                End If
            Else
                Throw New Exception("No Existe Configuracion Contable")
            End If
            ' Cargar Datos de Contrato Financiero
            oeContratoLeasing.Codigo = txtNroContrato.Text
            oeContratoLeasing.Usuario = gUsuarioSGI.Id
            oeContratoLeasing.TipoOperacion = "I"
            oeContratoLeasing.FechaEmision = fecEmision.Value
            oeContratoLeasing.Glosa = txt_Glosa.Text
            oeContratoLeasing.IdEmpresaBanco = cboBanco.Value
            oeContratoLeasing.IdMoneda = cboMoneda.Value
            oeContratoLeasing.IdTipoDocumento = IdLeasing
            oeContratoLeasing.TasaInteres = decTasaInteres.Value
            oeContratoLeasing.TipoCambio = DecTC.Value
            oeContratoLeasing.MontoMN = lstCuotaLeasing.Sum(Function(it) it.MontoMN)
            oeContratoLeasing.MontoME = lstCuotaLeasing.Sum(Function(it) it.MontoME)
            oeContratoLeasing.NroCuotas = lstCuotaLeasing.Count
            oeContratoLeasing.lstObligacionesFin = ObtieneDetGen(lstCuotaLeasing)
            oeContratoLeasing.NombreBanco = cboBanco.Text
            oeContratoLeasing.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olContratoLeasing.Guardar(oeContratoLeasing, oeAsientoModel) Then
                Espere1.Visible = False
                mensajeEmergente.Confirmacion("Se registró Correctamente", True)
                LimpiarControles()
                Return True
            End If
        Catch ex As Exception
            Espere1.Visible = False
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            Espere1.Visible = False
        End Try
    End Function

    Private Sub LimpiarControles()
        Try
            txt_Glosa.Text = ""
            cboBanco.SelectedIndex = -1
            cboMoneda.SelectedIndex = 0
            lstCuotaLeasing.Clear()
            grid_Cuotas.DataBind()
            txtNroContrato.Text = ""
            DecMontoAmortizacion.Value = 0
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ListarLeasing()
        Try
            Cursor.Current = Cursors.WaitCursor

            oeContratoLeasing = New e_ContratoFinanciero
            oeContratoLeasing.TipoOperacion = "L" : oeContratoLeasing.Activo = True
            ValidarFechaDesde_Hasta(fecInicio, fecFin)
            oeContratoLeasing.FechaEmision = fecInicio.Value : oeContratoLeasing.FechaVencimiento = fecFin.Value
            oeContratoLeasing.IdTipoDocumento = IdLeasing
            dsLeasing = olContratoLeasing.ListarDS(oeContratoLeasing)

            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) CONTRATOS
            'Tabla(1) OBLIGACIONES
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim IdContrato As DataColumn = dsLeasing.Tables(0).Columns("Id")
            Dim IdObligFin As DataColumn = dsLeasing.Tables(1).Columns("IdContratoFinanciero")
            relationContratoObligFin = New DataRelation("FK_Relacion", IdContrato, IdObligFin, False)
            dsLeasing.Relations.Add(relationContratoObligFin)
            dsLeasing.AcceptChanges()
            grid_Leasing.DataSource = dsLeasing
            With grid_Leasing.DisplayLayout
                '.Bands(1).ColHeadersVisible = False
                .Bands(0).Columns("FechaEmision").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Bands(1).Columns("Id").Hidden = True
                .Bands(1).Columns("IdContratoFinanciero").Hidden = True
                .Bands(1).Columns("Activo").Hidden = True
                .Bands(1).Columns("Glosa").Hidden = True
                .Bands(0).Columns("TotalMontoMN").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(0).Columns("TotalMontoME").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(0).Columns("TasaInteres").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoMN").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoMN").Format = "#,##0.00"
                .Bands(1).Columns("MontoMN").Header.Caption = "Capital MN"
                .Bands(1).Columns("MontoME").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoME").Format = "#,##0.00"
                .Bands(1).Columns("MontoME").Header.Caption = "Capital ME"
                .Bands(1).Columns("Saldo").Format = "#,##0.00"
                .Bands(1).Columns("Saldo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("Saldo").Header.VisiblePosition = 11
                .Bands(1).Columns("MontoInteresCompensatorio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoInteresCompensatorio").Format = "#,##0.00"
                .Bands(1).Columns("MontoInteresCompensatorio").Header.Caption = "Interes Comp."
                .Bands(1).Columns("MontoInteresCompensatorio").Header.VisiblePosition = 8
                .Bands(1).Columns("MontoInteresMoratorio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoInteresMoratorio").Format = "#,##0.00"
                .Bands(1).Columns("MontoInteresMoratorio").Header.Caption = "Interes Mor."
                .Bands(1).Columns("MontoInteresMoratorio").Header.VisiblePosition = 12
                .Bands(1).Columns("MontoDsctoInteres").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoDsctoInteres").Header.Caption = "Dscto. Interes"
                .Bands(1).Columns("Comision").Format = "#,##0.00"
                .Bands(1).Columns("Comision").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("Comision").Header.VisiblePosition = 9
                .Bands(1).Columns("Gastos").Format = "#,##0.00"
                .Bands(1).Columns("Gastos").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("Gastos").Header.VisiblePosition = 10
                .Bands(1).Columns("FechaVencimiento").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Bands(1).Columns("FechaVencimiento").Header.Caption = "Fec. Vencimiento"
                .Bands(1).Columns("Codigo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Bands(1).Columns("Codigo").Width = 60
                .Bands(1).Columns("Codigo").Header.Caption = "Nro"
            End With
        Catch ex As Exception
            Throw ex
        Finally
            grid_Leasing.DataBind()
        End Try
    End Sub

    Private Sub LlenarBanco()
        Try
            Dim oeProveedor As New e_Proveedor

            Dim leProveedor As New List(Of e_Proveedor)
            oeProveedor.Activo = True
            oeProveedor.TipoOperacion = "4"

            leProveedor.AddRange(olProveedor.Listar(oeProveedor))
            '--------------------- para llenar combo en grilla gridventas   
            grid_Leasing.DisplayLayout.ValueLists.Add("IdEmpresaBanco")
            With grid_Leasing.DisplayLayout.ValueLists("IdEmpresaBanco").ValueListItems
                .Clear()
                For Each oeTD As e_Proveedor In leProveedor
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdEmpresaBanco", "Nombre", grid_Leasing, True)
            '--------------------------------------
            With cboBanco
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leProveedor
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            txtNroContrato.Text = ""
            cboBanco.SelectedIndex = -1
            fecEmision.Value = Date.Now
            DecTC.Value = TipoCambio(fecEmision.Value)(0)
            cboMoneda.SelectedIndex = 0
            decTasaInteres.Value = 0
            decTasaMensual.Value = 0
            decPortes.Value = 0
            txt_Glosa.Text = String.Empty
            lstCuotaLeasing.Clear()
            grid_Cuotas.DataBind()
            grid_Cuotas.DataSource = lstCuotaLeasing
            InicializarDetalle()
            txtNroContrato.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaMoneda()
        oeMoneda = New e_Moneda
        Dim leMoneda As New List(Of e_Moneda)
        Try
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '-- para llenar combo en grilla    
            grid_Leasing.DisplayLayout.ValueLists.Add("IdMoneda")
            With grid_Leasing.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Nombre", grid_Leasing, True)
            '-------------------------------
            With cboMoneda
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leMoneda
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            LlenarBanco()
            LlenaMoneda()
            LlenarTipoObligacion()
            CargarAsientoModel()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDetalleLeasing()
        Try
            'If gridCuotas.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            'ValidarGrilla(gridCuotas, "Documentos x Rendir agregados")
            'If gridCuotas.ActiveRow Is Nothing Then Throw New Exception("Seleccione una fila")
            'If Not gridCuotas.ActiveRow.ListObject Is Nothing AndAlso gridCuotas.ActiveRow.Cells("Monto").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            ''inicialializo mi objeto
            'oeLeasing = New e_ObligacionAyudaDetalle
            ''---Obtengo O CAPTURO objeto de la grilla 
            'oeLeasing = gridCuotas.ActiveRow.ListObject
            ''----------------------
            'With leLeasingAgregado
            '    '-----remuevo o elimino de mi lista de objetos
            '    .Remove(oeLeasing)
            '    '-------------------
            'End With
            'mostrar_totalesLeasing()
            'gridCuotas.DataBind()
            'gridCuotas.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        grid_Cuotas.DataBind()
    End Sub

    Private Function ValidarAgregarDetalleLeasing() As Boolean
        Try
            l_FuncionesGenerales.ValidarNumeroDecimal(DecTC.Value, "Tipo de Cambio")
            'l_FuncionesGenerales.ValidarNumeroDecimal(DecTotalLeasing.Value, "Total Leasing")
            l_FuncionesGenerales.ValidarNumeroDecimal(decTasaInteres.Value, "Tasa de interes")
            'l_FuncionesGenerales.ValidarNumeroDecimal(DecMontoInteresLeasing.Value, "Monto de Interes")
            If Date.Parse(fecEmision.Value).Date > Date.Parse(FecVencimiento.Value).Date Then Throw New Exception("La fecha de emision es mayor a la fecha de vencimiento de la obligacion")
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub CargarAsientoModel()
        oeAsientoModel = New e_AsientoModelo
        oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
        leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
    End Sub

    Private Sub LlenarTipoObligacion()
        oeTipoObligacion = New e_TipoDocumento
        oeTipoObligacion.Activo = True : oeTipoObligacion.TipoOperacion = "I"
        leTipoObligacion = olTipoObligacion.Listar(oeTipoObligacion)
        IdLeasing = leTipoObligacion.Where(Function(it) it.Nombre = gTOLeasing)(0).Id
    End Sub

    Private Sub InicializarDetalle()
        txtNroVencimiento.Text = String.Empty
        FecVencimiento.Value = Date.Now.Date
        DecMontoAmortizacion.Value = 0
        DecMontoInteres.Value = 0
        decComision.Value = 0
        txtNroVencimiento.Focus()
    End Sub

    Private Function ObtieneDetGen(leCuota As List(Of e_ObligacionFin)) As List(Of e_ObligacionFin)
        Try
            Dim _leObli As New List(Of e_ObligacionFin)
            Dim _pos As Integer = 0, _mesx As Integer = 0, _mesy As Integer = 0, _mesz As Integer = 0, _nmes As Integer = 0
            Dim _aniox As Integer = 0, _anioy As Integer = 0, _ini As Integer = 0, _fin As Integer = 0
            Dim _band As Boolean = False
            For Each oeCuota In leCuota
                _mesx = 0 : _mesy = 0 : _ini = 0
                _pos = _pos + 1
                oeCuota.IdCuentaContable = IdCtaCtble
                If _pos = leCuota.Count Then
                    oeCuota.DiasProximaCuota = DateDiff(DateInterval.Day, oeCuota.FechaVencimiento, oeCuota.FechaVencimiento)
                    oeCuota.MontoInteresContable = 0
                Else
                    oeCuota.DiasProximaCuota = DateDiff(DateInterval.Day, oeCuota.FechaVencimiento, leCuota(_pos).FechaVencimiento)
                    oeCuota.MontoInteresContable = leCuota(_pos).MontoInteres
                    _aniox = oeCuota.FechaVencimiento.Year : _anioy = leCuota(_pos).FechaVencimiento.Year
                    _mesx = oeCuota.FechaVencimiento.Month + 1 : _mesy = leCuota(_pos).FechaVencimiento.Month
                    ' Evalua si existen Periodo de Gracia.
                    If _mesx = 13 Then
                        If _mesy > 1 Then _ini = 1 : _fin = _mesy - 1
                    Else
                        If _aniox = _anioy Then
                            If _mesx < _mesy Then _ini = _mesx : _fin = _mesy - 1
                        Else
                            _band = True : _mesz = 12 - oeCuota.FechaVencimiento.Month : _ini = 1 : _fin = _mesy - 1 + _mesz
                        End If
                    End If
                    If _ini > 0 Then ' Creacion de Registros de Periodo de Gracia por Mes.
                        For nro = _ini To _fin
                            oeCuotaLeasing = New e_ObligacionFin
                            oeCuotaLeasing.TipoOperacion = "I"
                            oeCuotaLeasing.IndPeriodoGracia = 1
                            oeCuotaLeasing.MontoInteresContable = leCuota(_pos).MontoInteres
                            oeCuotaLeasing.DiasProximaCuota = oeCuota.DiasProximaCuota
                            oeCuotaLeasing.MacLocal = MacPCLocal() : oeCuotaLeasing.Usuario = gUsuarioSGI.Id
                            oeCuotaLeasing.IdCuentaContable = IdCtaCtble
                            If _band Then ' Periodo de Gracia con años diferentes
                                _nmes = oeCuota.FechaVencimiento.Month + nro
                                If _nmes > 12 Then
                                    oeCuotaLeasing.FechaVencimiento = Convert.ToDateTime("01/" & (_nmes - 12).ToString & "/" & _anioy.ToString)
                                Else
                                    oeCuotaLeasing.FechaVencimiento = Convert.ToDateTime("01/" & _nmes.ToString & "/" & _aniox.ToString)
                                End If
                            Else ' Perido de Gracia en el mismo año
                                oeCuotaLeasing.FechaVencimiento = Convert.ToDateTime("01/" & nro.ToString & "/" & _anioy.ToString)
                            End If
                            _leObli.Add(oeCuotaLeasing)
                        Next
                    End If
                End If
            Next
            _leObli.AddRange(leCuota)
            Return _leObli.OrderBy(Function(it) it.FechaVencimiento).ToList
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_Leasing_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 0)
        Else
            ControlBoton(1, 1, 0, 0, 0, 1, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Leasing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenarCombos()
            fecInicio.Value = DateAdd(DateInterval.Day, -30, Date.Now) : fecFin.Value = Date.Now.Date
            ControlBoton(0, 1, 0, 0, 0, 1, 0, 0, 1)
            MostrarTabs(0, tcLeasing)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Leasing_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub FecFecha_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecEmision.Validated
        Try
            DecTC.Value = TipoCambio(fecEmision.Value)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub DtFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecEmision.ValueChanged
        'oeObligacion.FechaEmision = FecEmision.Value
    End Sub

    Private Sub CboBanco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBanco.ValueChanged
        'oeObligacion.IdEmpresaBanco = cboBanco.Value
        'oeObligacion._NombreBanco = cboBanco.Text
    End Sub

    Private Sub CboTipoMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        'oeObligacion.IdMoneda = cboMoneda.Value
    End Sub

    Private Sub txt_Glosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Glosa.ValueChanged
        'oeObligacion.Glosa = txt_Glosa.Text
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        QuitarDetalleLeasing()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If DecTC.Value = 0 Then Throw New Exception("Ingrese Tipo de Cambio")
            oeCuotaLeasing = New e_ObligacionFin
            With oeCuotaLeasing
                .TipoOperacion = "I"
                .NroVencimiento = txtNroVencimiento.Text
                .IndPeriodoGracia = 0
                .FechaVencimiento = FecVencimiento.Value
                .MontoCapital = DecMontoAmortizacion.Value
                .MontoMN = IIf(cboMoneda.Text = "SOLES", DecMontoAmortizacion.Value, DecMontoAmortizacion.Value * DecTC.Value)
                .MontoME = IIf(cboMoneda.Text = "SOLES", DecMontoAmortizacion.Value / DecTC.Value, DecMontoAmortizacion.Value)
                .MontoInteres = DecMontoInteres.Value
                .Comision = decComision.Value
                .Portes = decPortes.Value
                .IGV = decIGV.Value
                .Saldo = .Total
                .MacLocal = MacPCLocal()
                .Usuario = gUsuarioSGI.Id
            End With
            lstCuotaLeasing.Add(oeCuotaLeasing)
            grid_Cuotas.DataBind()
            InicializarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If DecTC.Value = 0 Then DecTC.Focus()
        End Try
        grid_Cuotas.DataBind()
    End Sub

    Private Sub DecTasaInteresFactory_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles decTasaInteres.Validated
        decTasaMensual.Value = (-1 + ((1 + decTasaInteres.Value / 100) ^ (1 / 12))) * 100
        DecMontoInteres.Value = decMontoInicial.Value * decTasaMensual.Value / 100
    End Sub

    Private Sub DecMontoAmortizacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecMontoAmortizacion.ValueChanged
        decMontoCuota.Value = CDec(DecMontoAmortizacion.Value) + CDec(DecMontoInteres.Value)
        decTotalCuota.Value = decMontoCuota.Value + decIGV.Value + decComision.Value + decPortes.Value
    End Sub

    Private Sub DecMontoInteres_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecMontoInteres.ValueChanged
        decMontoCuota.Value = CDec(DecMontoAmortizacion.Value) + CDec(DecMontoInteres.Value)
    End Sub

    Private Sub decPortes_ValueChanged(sender As Object, e As EventArgs) Handles decPortes.ValueChanged
        decIGV.Value = (decMontoCuota.Value + decPortes.Value + decComision.Value) * 0.18
        'decMontoCuota.Value = DecMontoAmortizacion.Value + DecMontoInteres.Value + decPortes.Value
        decTotalCuota.Value = decMontoCuota.Value + decIGV.Value + decComision.Value + decPortes.Value
    End Sub

    Private Sub ndMontoCuota_ValueChanged(sender As Object, e As EventArgs) Handles decMontoCuota.ValueChanged
        Dim num As Double = decMontoCuota.Value + decPortes.Value + decComision.Value
        decIGV.Value = (decMontoCuota.Value + decPortes.Value + decComision.Value) * 0.18
        decTotalCuota.Value = decMontoCuota.Value + decIGV.Value + decComision.Value + decPortes.Value
    End Sub

    Private Sub decComision_ValueChanged(sender As Object, e As EventArgs) Handles decComision.ValueChanged
        decIGV.Value = (decMontoCuota.Value + decPortes.Value + decComision.Value) * 0.18
        decTotalCuota.Value = decMontoCuota.Value + decIGV.Value + decComision.Value + decPortes.Value
    End Sub

    Private Sub CalcFactory_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'DecTasaInteresLeasing.Value = CalcFactory.Text
        DecMontoInteres.Value = CDec(decTasaInteres.Value) * CDec(DecMontoAmortizacion.Value) / 100
    End Sub

    Private Sub GridLeasingAgregados_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles grid_Cuotas.AfterRowUpdate
        'Try
        '    Dim obj As New e_ObligacionAyudaDetalle
        '    obj = gridCuotas.ActiveRow.ListObject
        '    obj.MontoCapital = obj.Total - obj.MontoInteres
        '    'GridLeasingAgregados.DataBind()
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try
    End Sub

    Private Sub GridLeasingAgregados_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Cuotas.CellChange
        Try
            grid_Cuotas.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub GridLeasingAgregados_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_Cuotas.Validated
        Try
            'Dim obj As New e_ObligacionAyudaDetalle
            'obj = GridLeasingAgregados.ActiveRow.ListObject
            'obj.Monto = obj.Total - obj.MontoInteres
            'GridLeasingAgregados.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

    End Sub

#End Region

End Class