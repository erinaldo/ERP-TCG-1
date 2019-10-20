'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Pagares
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    'Private oeObligacion As New e_ObligacionFinanciera, olObligacion As New l_ObligacionFinanciera
    Private leTipoObli As New List(Of e_ObligacionFinanciera)
    Private WithEvents oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento
    'Private leLeasingAgregado As New List(Of e_ObligacionAyudaDetalle)
    'Private oeLeasing As New e_ObligacionAyudaDetalle
    Private oeCuentaBancaria As New e_CuentaBancaria, leCuentaBancaria As New List(Of e_CuentaBancaria)
    Private oeContratoLeasing As New e_ContratoFinanciero, olContratoLeasing As New l_ContratoFinanciero
    Private oeCuotaLeasing As New e_ObligacionFin, olCuotaLeasing As New l_ObligacionFinanciera
    Private lstCuotaLeasing As New List(Of e_ObligacionFin), oeCuotaOblig As e_ObligacionFin
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeReferencia As New e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, leReferencia As New List(Of e_AsientoModelo_Referencia)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, leEmpresa As New List(Of e_Empresa)
    Private oeTipoDoc As New e_TipoDocumento, olTipoDoc As New l_TipoDocumento
    Private leTipoDoc As New List(Of e_TipoDocumento), leTipoDocBus As New List(Of e_TipoDocumento)
    Private oeProveedor As New e_Proveedor, olProveedor As New l_Proveedor, leProveedor As New List(Of e_Proveedor)
    Private DTReferencia As Data.DataTable, dtAux As Data.DataTable, dsPagare As DataSet
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private relationContratoObligFin As DataRelation
    Private IdTipoEmp As String = String.Empty, IdCtaCtble As String = String.Empty

#End Region

#Region "Instancia"

    Private Shared instancia As frm_Pagares = Nothing
    Private Shared Operacion As String

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Pagares
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            If tcLeasing.Tabs(0).Selected = True Then
                ListaPagare()
                If GridPagares.Rows.Count > 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            ElseIf tcLeasing.Tabs(1).Selected = True Then
                ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        If tcLeasing.Tabs(0).Selected = True Then
            MostrarTabs(1, tcLeasing, 1)
            ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 0)
            Operacion = "Nuevo"
        End If
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarPagares() Then
                ControlBoton(1, 1, 0, 0, 0, 1, 0, 0, 1)
                MostrarTabs(0, tcLeasing)
                ListaPagare()
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
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, tcLeasing, 0)
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                Operacion = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'With GridPagares
            '    ValidarGrilla(GridPagares, "Obligacion")
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
            mensajeEmergente.Problema(ex.Message)
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

            If GridPagares.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(GridPagares)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Function GuardarPagares() As Boolean
        Try
            Espere1.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidarCombo(CboTipoObligacionGuardar, "Tipo de Obligacion Financiera")
            ValidarCombo(CboBanco, "Banco")
            ValidarCombo(CboMoneda, "Moneda")
            ValidarCombo(CboCtaBancaria, "Cuenta Bancaria")
            IdCtaCtble = String.Empty
            'Obtener Periodo
            oePeriodo = New e_Periodo
            oePeriodo = ObtenerPeriodo(CDate(FecFecha.Value))
            oeContratoLeasing.IdPeriodo = oePeriodo.Id
            'Filtra DtReferencia
            dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & CboMoneda.Value & "' AND TipoRef2 = 7 AND IdRef2 = '" & IdTipoEmp & "'"
            _rwAux = DTReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
            dtAux = _rwAux.CopyToDataTable
            'Obtiene Asiento Modelo por Referencia
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
            oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModel.Ejercicio = CDate(FecFecha.Value).Year
            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
            If oeAsientoModel.leDetalle.Count > 0 Then
                Dim _leDetAux As New List(Of e_DetalleAsientoModelo)
                Dim _CtaAux As String = String.Empty
                If IdTipoEmp = "1CH000000003" Then
                    _CtaAux = IIf(CboTipoObligacionGuardar.SelectedIndex = 0, gCCTOPagareBanco, gCCTOPrestamoBanco)
                    For Each oeAMDet In oeAsientoModel.leDetalle.Where(Function(it) it.Repetir = 1).ToList
                        If Microsoft.VisualBasic.Left(oeAMDet.Cuenta, 4) = _CtaAux Then
                            oeAMDet.Repetir = 1
                        Else
                            oeAMDet.Repetir = 0
                        End If
                    Next
                Else
                    _CtaAux = gCCTOPagarePrestamoNoBanco
                End If
                _leDetAux = oeAsientoModel.leDetalle.Where(Function(it) it.Cuenta.Contains(_CtaAux)).ToList
                If _leDetAux.Count > 0 Then IdCtaCtble = _leDetAux(0).IdCuentaContable
                For Each oeOFAux In lstCuotaLeasing
                    oeOFAux.IdCuentaContable = IdCtaCtble
                Next
            Else
                Throw New Exception("No Existe Configuracion Contable")
            End If
            'Obtener Flujo Caja y Medio de Pago
            If oeAsientoModel.leDMReferencia.Count = 0 Then Throw New Exception("No Se Han Configurado el Flujo de Caja y el Medio de Pago")
            Dim _leRefDM = oeAsientoModel.leDMReferencia.OrderBy(Function(it) it.TipoReferencia).ToList
            oeContratoLeasing.oeMovCajaBanco = New e_MovimientoCajaBanco
            oeContratoLeasing.oeMovCajaBanco.IdFlujoCaja = _leRefDM(0).IdReferencia
            oeContratoLeasing.oeMovCajaBanco.IdMedioPago = _leRefDM(1).IdReferencia
            oeContratoLeasing.oeMovCajaBanco.IdCuentaBancaria = CboCtaBancaria.Value
            'Llenar Contrato
            oeContratoLeasing.Codigo = txtNroContrato.Text.Trim
            oeContratoLeasing.Usuario = gUsuarioSGI.Id
            oeContratoLeasing.TipoOperacion = "I"
            oeContratoLeasing.FechaEmision = FecFecha.Value
            oeContratoLeasing.Glosa = txt_Glosa.Text
            oeContratoLeasing.IdEmpresaBanco = CboBanco.Value
            oeContratoLeasing.IdMoneda = CboMoneda.Value
            oeContratoLeasing.IdTipoDocumento = CboTipoObligacionGuardar.Value
            oeContratoLeasing.TasaInteres = ndTasaAnual.Value
            oeContratoLeasing.TipoCambio = DecTC.Value
            oeContratoLeasing.MontoMN = IIf(CboMoneda.Text = "SOLES", ndCapitalContrato.Value, Math.Round(ndCapitalContrato.Value * DecTC.Value, 2))
            oeContratoLeasing.MontoME = IIf(CboMoneda.Text = "SOLES", Math.Round(ndCapitalContrato.Value / DecTC.Value, 2), ndCapitalContrato.Value)
            oeContratoLeasing.NroCuotas = lstCuotaLeasing.Count
            oeContratoLeasing.Usuario = gUsuarioSGI.Id
            oeContratoLeasing.Comision = DecComision.Value
            oeContratoLeasing.lstObligacionesFin = lstCuotaLeasing
            oeContratoLeasing.NombreBanco = CboBanco.Text
            oeContratoLeasing.Capital = ndCapitalContrato.Value
            'Guardar Contrato Financiero
            oeContratoLeasing.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olContratoLeasing.GuardarPagare(oeContratoLeasing, oeAsientoModel) Then
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
            CboBanco.SelectedIndex = -1
            CboCtaBancaria.SelectedIndex = -1
            CboMoneda.SelectedIndex = 0
            'leLeasingAgregado.Clear()
            lstCuotaLeasing.Clear()
            GridPagaresAgregados.DataBind()
            txtNroContrato.Text = ""
            ndCapitalCuota.Value = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ListaPagare()
        Try
            Cursor.Current = Cursors.WaitCursor
            oeContratoLeasing = New e_ContratoFinanciero
            oeContratoLeasing.TipoOperacion = "P"
            oeContratoLeasing.Activo = True
            oeContratoLeasing.FechaEmision = FecDesde.Value
            oeContratoLeasing.FechaVencimiento = FecHasta.Value
            oeContratoLeasing.IdTipoDocumento = CboTipoObligacionListar.Value
            dsPagare = olContratoLeasing.ListarDS(oeContratoLeasing)
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) CONTRATOS
            'Tabla(1) OBLIGACIONES
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim IdContrato As DataColumn = dsPagare.Tables(0).Columns("Id")
            Dim IdObligFin As DataColumn = dsPagare.Tables(1).Columns("IdContratoFinanciero")
            relationContratoObligFin = New DataRelation("FK_Relacion", IdContrato, IdObligFin, False)
            dsPagare.Relations.Add(relationContratoObligFin)
            dsPagare.AcceptChanges()
            GridPagares.DataSource = dsPagare
            With GridPagares.DisplayLayout
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
                '.Bands(1).Columns("MontoInteresCompensatorio").Header.VisiblePosition = 8
                .Bands(1).Columns("MontoInteresMoratorio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoInteresMoratorio").Format = "#,##0.00"
                .Bands(1).Columns("MontoInteresMoratorio").Header.Caption = "Interes Mor."
                '.Bands(1).Columns("MontoInteresMoratorio").Header.VisiblePosition = 12
                .Bands(1).Columns("MontoDsctoInteres").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoDsctoInteres").Header.Caption = "Dscto. Interes"
                .Bands(1).Columns("Comision").Format = "#,##0.00"
                .Bands(1).Columns("Comision").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Bands(1).Columns("Comision").Header.VisiblePosition = 9
                .Bands(1).Columns("Gastos").Format = "#,##0.00"
                .Bands(1).Columns("Gastos").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Bands(1).Columns("Gastos").Header.VisiblePosition = 10
                .Bands(1).Columns("FechaVencimiento").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Bands(1).Columns("FechaVencimiento").Header.Caption = "Fec. Vencimiento"
                .Bands(1).Columns("Codigo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Bands(1).Columns("Codigo").Width = 60
                .Bands(1).Columns("Codigo").Header.Caption = "Nro"
            End With
        Catch ex As Exception
            Throw ex
        Finally
            GridPagares.DataBind()
        End Try
    End Sub

    Private Sub LlenarBanco()
        oeProveedor = New e_Proveedor
        oeProveedor.Activo = True
        oeProveedor.TipoOperacion = "4"
        leProveedor.AddRange(olProveedor.Listar(oeProveedor))
        '--------------------- para llenar combo en grilla gridventas   
        GridPagares.DisplayLayout.ValueLists.Add("IdEmpresaBanco")
        With GridPagares.DisplayLayout.ValueLists("IdEmpresaBanco").ValueListItems
            .Clear()
            For Each oeTD As e_Proveedor In leProveedor
                .Add(oeTD.Id, oeTD.Nombre)
            Next
        End With
        CrearComboGrid3("IdEmpresaBanco", "Nombre", GridPagares, True)
        '--------------------------------------
        With CboBanco
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = leProveedor
        End With
    End Sub

    Private Sub LlenaCuentaBancaria()
        Dim oeCtaBancaria As New e_CuentaBancaria
        Dim olCtaBancaria As New l_CuentaBancaria
        Try
            oeCtaBancaria.Id = oeCtaBancaria.Id 'Relacionada con Cuenta Contale
            oeCtaBancaria.Activo = True
            'LlenarCombo(CboCtaBancaria, "BancoCuenta", olCtaBancaria.Listar(oeCtaBancaria), -1)
            leCuentaBancaria = olCtaBancaria.Listar(oeCtaBancaria)
        Catch ex As Exception
            Throw ex
        Finally
            oeCtaBancaria = Nothing
            olCtaBancaria = Nothing
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            CboTipoObligacionGuardar.SelectedIndex = -1
            txtNroContrato.Text = String.Empty
            FecFecha.Value = Date.Now
            fecVencimiento.Value = Date.Now
            CboBanco.SelectedIndex = -1
            CboMoneda.SelectedIndex = -1
            DecTC.Value = TipoCambio(FecFecha.Value)(0)
            CboCtaBancaria.SelectedIndex = -1
            ndCapitalContrato.Value = 0
            ndInteresContrato.Value = 0
            DecComision.Value = 0
            ndTasaAnual.Value = 0
            ndTotalContrato.Value = 0
            ndTotalSoles.Value = 0
            ndTotalDolares.Value = 0
            numCuotas.Value = 1
            GridPagaresAgregados.DataBind()
            CalcularTotales(GridPagaresAgregados, "MontoCapital", "MontoInteres", "Total")
            InicializaCuota()
            CboTipoObligacionGuardar.Focus()
            IdTipoEmp = String.Empty
            btnAgregar.Enabled = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaMoneda()
        Dim oeMoneda As New e_Moneda
        Dim olMoneda As New l_Moneda
        Dim leMoneda As New List(Of e_Moneda)
        Try
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            GridPagares.DisplayLayout.ValueLists.Add("IdMoneda")
            With GridPagares.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Nombre", GridPagares, True)
            '-------------------------------
            With CboMoneda
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
            LlenaCuentaBancaria()
            CargarEmpresa()
            LlenarBanco()
            LlenaMoneda()
            CargarTipoDoc()
            LlenaTipoDocumentoFacotoryFEDD()
            CargarAsiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaTipoDocumentoFacotoryFEDD()
        Try
            '--------------------- para llenar combo en grilla    
            GridPagares.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With GridPagares.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", GridPagares, True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub mostrar_totalesLeasing()
    '    Try
    '        Dim importe As Double = 0
    '        Dim Monto As Double = 0
    '        For Each obj As e_ObligacionAyudaDetalle In leLeasingAgregado
    '            importe = importe + obj.MontoCapital
    '            Monto = Monto + obj.MontoInteres
    '        Next
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message)
    '    End Try
    'End Sub

    Private Sub QuitarDetalleLeasing()
        Try
            If GridPagaresAgregados.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            ValidarGrilla(GridPagaresAgregados, "Documentos x Rendir agregados")
            If GridPagaresAgregados.ActiveRow Is Nothing Then Throw New Exception("Seleccione una fila")
            If Not GridPagaresAgregados.ActiveRow.ListObject Is Nothing AndAlso GridPagaresAgregados.ActiveRow.Cells("Monto").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            oeCuotaOblig = New e_ObligacionFin
            oeCuotaOblig = GridPagaresAgregados.ActiveRow.ListObject
            lstCuotaLeasing.Remove(oeCuotaOblig)
            GridPagaresAgregados.DataBind()
            GridPagaresAgregados.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        GridPagaresAgregados.DataBind()
    End Sub

    Private Function ValidarAgregarDetalleLeasing() As Boolean
        Try
            If Trim(txtNroContrato.Value) = "" Then Throw New Exception("Ingrese un Código.")
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            l_FuncionesGenerales.ValidarNumero(ndCapitalCuota.Value, "Total Leasing")
            If ndTasaAnual.Value = 0 Then Throw New Exception("Ingrese la tasa de interes.")
            l_FuncionesGenerales.ValidarNumero(ndInteresCuota.Value, "Monto de Interes")
            If Date.Parse(FecFecha.Value).Date > Date.Parse(FecVencimientoCuota.Value).Date Then Throw New Exception("La fecha de emision es mayor a la fecha de vencimiento de la obligacion")
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub Calcular_Importes()
        ndTotalContrato.Value = ndCapitalContrato.Value + ndInteresContrato.Value
        ndTotalSoles.Value = IIf(CboMoneda.Text = "SOLES", ndTotalContrato.Value, ndTotalContrato.Value * DecTC.Value)
        ndTotalDolares.Value = IIf(CboMoneda.Text = "SOLES", ndTotalContrato.Value / DecTC.Value, ndTotalContrato.Value)
    End Sub

    Private Sub InicializaCuota()
        txtCuota.Text = GridPagaresAgregados.Rows.Count + 1
        FecVencimientoCuota.Value = Date.Now.Date.AddMonths(GridPagaresAgregados.Rows.Count)
        ndCapitalCuota.Value = 0
        ndInteresCuota.Value = 0
        ndTotalCuota.Value = 0
        ndCapitalCuota.Focus()
    End Sub

    Private Sub CargarAsiento()
        'Cargar Asiento Modelo Referencia
        oeReferencia = New e_AsientoModelo_Referencia
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        leReferencia = olReferencia.Listar(oeReferencia)
        'Cargar DT Referencia
        If leReferencia.Count > 0 Then
            DTReferencia = GeneraDTRef(leReferencia)
        End If

    End Sub

    Private Sub CargarEmpresa()
        oeEmpresa = New e_Empresa
        oeEmpresa.TipoOperacion = String.Empty : oeEmpresa.Activo = True
        leEmpresa = olEmpresa.Listar(oeEmpresa)
    End Sub

    Private Sub CargarTipoDoc()
        oeTipoDoc = New e_TipoDocumento
        oeTipoDoc.TipoOperacion = "I" : oeTipoDoc.Activo = True
        leTipoDoc = olTipoDoc.Listar(oeTipoDoc).Where(Function(it) it.Nombre = "PAGARE" Or it.Nombre = "PRESTAMO").ToList
        oeTipoDoc = New e_TipoDocumento
        oeTipoDoc.Nombre = "[ TODOS ]"
        leTipoDocBus.Add(oeTipoDoc)
        leTipoDocBus.AddRange(leTipoDoc)
        LlenarCombo(CboTipoObligacionListar, "Nombre", leTipoDocBus, 0)
        LlenarCombo(CboTipoObligacionGuardar, "Nombre", leTipoDoc, -1)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Pagares_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If tcLeasing.SelectedTab.Index = 1 Then
            ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 0)
        Else
            ControlBoton(1, 1, 0, 0, 0, 1, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Pagares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'GridPagares.DataSource = leTipoObli
            GridPagaresAgregados.DataSource = lstCuotaLeasing
            LlenarCombos()
            ControlBoton(0, 1, 0, 0, 0, 1, 0, 0, 1)
            FecDesde.Value = DateAdd(DateInterval.Day, -30, Date.Now)
            FecHasta.Value = Date.Now.Date
            MostrarTabs(0, tcLeasing)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Pagares_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub FecFecha_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecFecha.Validated
        Try
            DecTC.Value = TipoCambio(FecFecha.Value)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CboBanco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBanco.ValueChanged
        Try
            If CboBanco.SelectedIndex > -1 Then
                If CboTipoObligacionGuardar.SelectedIndex = -1 Then Throw New Exception("Seleccione Tipo Obligacion")
                oeProveedor = New e_Proveedor
                oeProveedor = CboBanco.Items(CboBanco.SelectedIndex).ListObject
                IdTipoEmp = oeProveedor.IdTipoEmpresa
                DecComision.Value = 0
                DecComision.ReadOnly = IIf(IdTipoEmp = "1CH000000003", False, True)
                'oeObligacion.IdEmpresaBanco = CboBanco.Value
                'oeObligacion._NombreBanco = CboBanco.Text
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If CboTipoObligacionGuardar.SelectedIndex = -1 Then CboBanco.SelectedIndex = -1 : CboTipoObligacionGuardar.Focus()
        End Try
    End Sub

    Private Sub CboTipoMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMoneda.ValueChanged
        Try
            If CboMoneda.SelectedIndex > -1 Then
                'oeObligacion.IdMoneda = CboMoneda.Value
                Dim leAux = leCuentaBancaria.Where(Function(it) it.IdMoneda = CboMoneda.Value).ToList
                LlenarCombo(CboCtaBancaria, "BancoCuenta", leAux, -1)
            Else
                CboCtaBancaria.DataSource = New List(Of e_CuentaBancaria)
                CboCtaBancaria.SelectedIndex = -1
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If DecTC.Value = 0 Then Throw New Exception("Ingrese Tipo de Cambio")
            oeCuotaOblig = New e_ObligacionFin
            With oeCuotaOblig
                .NroVencimiento = txtCuota.Text.Trim
                .FechaVencimiento = FecVencimientoCuota.Value
                .MontoCapital = ndCapitalCuota.Value
                .MontoMN = IIf(CboMoneda.Text = "SOLES", .MontoCapital, .MontoCapital * DecTC.Value)
                .MontoME = IIf(CboMoneda.Text = "SOLES", .MontoCapital / DecTC.Value, .MontoCapital)
                .MontoInteres = ndInteresCuota.Value
                .Comision = DecComision.Value
                .Total = ndTotalCuota.Value
                .Saldo = .Total
            End With
            lstCuotaLeasing.Add(oeCuotaOblig)
            GridPagaresAgregados.DataBind()
            InicializaCuota()
            If numCuotas.ReadOnly And GridPagaresAgregados.Rows.Count = 1 Then
                btnAgregar.Enabled = False
            Else
                btnAgregar.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        GridPagaresAgregados.DataBind()
    End Sub

    Private Sub DecTotalFactory_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCapitalCuota.ValueChanged
        'lblTotalFactory.Text = Math.Round(DecTotalLeasing.Value + decMontoInteres.Value + DecComision.Value, 2)
        ndTotalCuota.Value = ndCapitalCuota.Value + ndInteresCuota.Value + DecComision.Value
    End Sub

    Private Sub DecMontoInteresFactory_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndInteresCuota.ValueChanged
        'lblTotalFactory.Text = Math.Round(DecTotalLeasing.Value + decMontoInteres.Value + DecComision.Value, 2)
        ndTotalCuota.Value = ndCapitalCuota.Value + ndInteresCuota.Value + DecComision.Value
    End Sub

    Private Sub CboCtaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCtaBancaria.ValueChanged
        Try
            If CboCtaBancaria.SelectedIndex > 0 Then
                If CboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione Moneda")
                'oeObligacion.IdCuentaBancaria = CboCtaBancaria.Value
                Dim i As Integer = CboCtaBancaria.SelectedIndex
                If i >= 0 Then
                    oeCuentaBancaria = New e_CuentaBancaria
                    oeCuentaBancaria = CboCtaBancaria.Items(i).ListObject
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If CboMoneda.SelectedIndex = -1 Then CboCtaBancaria.SelectedIndex = -1 : CboMoneda.Focus()
        End Try
    End Sub

    Private Sub DecComision_ValueChanged(sender As Object, e As EventArgs) Handles DecComision.ValueChanged
        'lblTotalFactory.Text = Math.Round(DecTotalLeasing.Value + decMontoInteres.Value + DecComision.Value, 2)
        Try
            If DecComision.Value > 0 Then
                If ndCapitalContrato.Value = 0 Then Throw New Exception("Ingrese Monto de Capital")
                ndTotalCuota.Value = ndCapitalCuota.Value + ndInteresCuota.Value + DecComision.Value
                Calcular_Importes()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If ndCapitalContrato.Value = 0 Then DecComision.Value = 0 : ndCapitalContrato.Focus()
        End Try
    End Sub

    Private Sub DecTasaInteresLeasing_ValueChanged(sender As Object, e As EventArgs) Handles ndTasaAnual.ValueChanged
        'decMontoInteres.Value = CalculoInteres(FecFecha.Value, FecVencimientoLeasing.Value, DecTasaInteresLeasing.Value, DecTotalLeasing.Value)
        Try
            If ndTasaAnual.Value > 0 Then
                If ndCapitalContrato.Value = 0 Then Throw New Exception("Ingrese Monto de Capital")
                ndInteresContrato.Value = CalculoInteres(FecFecha.Value, fecVencimiento.Value, ndTasaAnual.Value, ndCapitalContrato.Value)
                ndTasaMensual.Value = Math.Round(((1 + ndTasaAnual.Value) ^ (1 / 12) - 1), 4)
                Calcular_Importes()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If ndCapitalContrato.Value = 0 Then ndTasaAnual.Value = 0 : ndCapitalContrato.Focus()
        End Try
    End Sub

    Private Sub txtCodigoBancoLeasing_ValueChanged(sender As Object, e As EventArgs) Handles txtNroContrato.ValueChanged
        Try
            If txtNroContrato.Text.Trim <> "" Then
                If CboTipoObligacionGuardar.SelectedIndex = -1 Then Throw New Exception("Elija Tipo de Obligacion")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If CboTipoObligacionGuardar.SelectedIndex = -1 Then txtNroContrato.Text = String.Empty : CboTipoObligacionGuardar.Focus()
        End Try
    End Sub

    Private Sub ndCapitalContrato_ValueChanged(sender As Object, e As EventArgs) Handles ndCapitalContrato.ValueChanged
        Try
            If ndCapitalContrato.Value > 0 Then
                If CboCtaBancaria.SelectedIndex = -1 Then Throw New Exception("Seleccione Cuenta Bancaria")
                If DecTC.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
                ndCapitalCuota.Value = IIf(CboTipoObligacionGuardar.Text = gTOPagare, ndCapitalContrato.Value, 0)
                Calcular_Importes()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If CboCtaBancaria.SelectedIndex = -1 Then ndCapitalContrato.Value = 0 : CboCtaBancaria.Focus()
            If DecTC.Value = 0 Then ndCapitalContrato.Value = 0 : DecTC.Focus()
        End Try
    End Sub

    Private Sub CboTipoObligacionGuardar_ValueChanged(sender As Object, e As EventArgs) Handles CboTipoObligacionGuardar.ValueChanged
        numCuotas.Value = 1 : DecComision.Value = 0
        numCuotas.ReadOnly = IIf(CboTipoObligacionGuardar.Text = gTOPagare, True, False)
        DecComision.ReadOnly = IIf(CboTipoObligacionGuardar.Text = gTOPagare, False, True)
    End Sub

    Private Sub fecVencimiento_ValueChanged(sender As Object, e As EventArgs) Handles fecVencimiento.ValueChanged
        If CboTipoObligacionGuardar.Text = gTOPagare Then FecVencimientoCuota.Value = fecVencimiento.Value
    End Sub

    Private Sub ndInteresContrato_ValueChanged(sender As Object, e As EventArgs) Handles ndInteresContrato.ValueChanged
        ndInteresCuota.Value = IIf(CboTipoObligacionGuardar.Text = gTOPagare, ndInteresContrato.Value, 0)
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        QuitarDetalleLeasing()
        If numCuotas.ReadOnly And GridPagaresAgregados.Rows.Count = 1 Then
            btnAgregar.Enabled = False
        Else
            btnAgregar.Enabled = True
        End If
    End Sub

#End Region

End Class
