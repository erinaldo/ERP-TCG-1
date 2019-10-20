'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop

Public Class frm_CreditoHipotecario

    Private Shared instancia As frm_CreditoHipotecario = Nothing

#Region "Inicializacion de Formulario"

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_CreditoHipotecario()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeContratoFin As New e_ContratoFinanciero, olContratoFin As New l_ContratoFinanciero
    Private oeCuota As New e_ObligacionFin, leCuota As New List(Of e_ObligacionFin)
    'Private oeObligacionFinanciera As New e_ObligacionFinanciera, olObligacionFinanciera As New l_ObligacionFinanciera
    Private oeTipoObligacion As New e_TipoDocumento, olTipoObligacion As New l_TipoDocumento, leTipoObligacion As New List(Of e_TipoDocumento)
    ' Private leCuotaObligacion As New List(Of e_ObligacionFinanciera)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private oeCtaCtble As New e_CuentaContable, leCtaBancaria As New List(Of e_CuentaBancaria)
    Private dsCredHipo As DataSet, relationContratoObligFin As DataRelation
    Dim Año As Integer = 0
    Private IdCreditoHipotecario As String, IdCtaCtble As String

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, TabCredito, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ListarObligacion()
            If GridObligacion.Rows.Count = 0 Then
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCreditoHipotecario() Then
                mensajeEmergente.Confirmacion("Se registro correctamente", True)
                Inicializar()
                Consultar(True)
                MostrarTabs(0, TabCredito)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Consultar(True)
            MostrarTabs(0, TabCredito, 1)
            TabCredito.Tabs(1).Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If EliminarCredito() Then
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If GridObligacion.Rows.Count > 0 Then
                Exportar_Excel(GridObligacion)
            Else
                Throw New Exception("No existen filas a exportar.")
            End If
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CreditoHipotecario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CreditoHipotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CuentaBancaria()
            MedioPago()
            LlenarMoneda()
            LlenaBanco()
            LlenaFlujoCaja()
            CargarAsientoModel()
            LlenarTipoObligacion()
            DtpFechaEmisionFiltro.Value = PrimerDiaAño()
            DtpFechaEmisionFinalFiltro.Value = Date.Now
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_CreditoHipotecario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If TabCredito.Tabs(0).Active = True Then
                If GridObligacion.Rows.Count = 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
                End If
            ElseIf TabCredito.Tabs(1).Active = True Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub BancoFecha_Validated(sender As Object, e As EventArgs) Handles BancoFecha.Validated
        Try
            If BancoFecha.Value > Date.Now Then
                BancoFecha.Value = Date.Now
                DecTC.Value = TipoCambio(BancoFecha.Value, False)(0)
                Throw New Exception("La fecha no puede ser mayor a la actual")
            Else
                If Year(BancoFecha.Value) <> Año Then Año = Year(BancoFecha.Value)
            End If
            DecTC.Value = TipoCambio(BancoFecha.Value, False)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub optGlosa_CheckedChanged(sender As Object, e As EventArgs) Handles optGlosa.CheckedChanged
        Try
            If optGlosa.Checked = True Then
                TxtGlosaObligacion.Value = TxtGlosaBanco.Value
                TxtGlosaObligacion.Enabled = False
            Else
                TxtGlosaObligacion.Value = TxtGlosaBanco.Value
                TxtGlosaObligacion.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            AgregarCuota()
            InicializarCuota()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ndCapitalCuota_ValueChanged(sender As Object, e As EventArgs) Handles ndCapitalCuota.ValueChanged
        Try
            ndTotalCuota.Value = CDec(ndCapitalCuota.Value) + CDec(ndInteresCuota.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ndInteresCuota_ValueChanged(sender As Object, e As EventArgs) Handles ndInteresCuota.ValueChanged
        Try
            ndTotalCuota.Value = CDec(ndCapitalCuota.Value) + CDec(ndInteresCuota.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub TxtGlosaBanco_ValueChanged(sender As Object, e As EventArgs) Handles TxtGlosaBanco.ValueChanged
        TxtGlosaObligacion.Value = TxtGlosaBanco.Value
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitarToolStripMenuItem.Click
        Try
            'If gridCuotas.ActiveRow.Selected = True Then
            '    Dim oeObli As New e_ObligacionFinanciera
            '    oeObli.Activo = True
            '    oeObli.Codigo = gridCuotas.ActiveRow.Cells("Codigo").Value.ToString
            '    oeObli.MontoMN = gridCuotas.ActiveRow.Cells("MontoMN").Value.ToString
            '    oeObli.MontoME = gridCuotas.ActiveRow.Cells("MontoME").Value.ToString
            '    oeObli.IdTipoObligacion = "1CH000000077"
            '    leCuotaObligacion.Remove(oeObli)
            '    CalcularTotales(gridCuotas, "MontoMN", "MontoME", "Saldo")
            '    gridCuotas.DataSource = leCuotaObligacion
            '    gridCuotas.DataBind()
            'Else
            '    Throw New Exception("Seleccione una fila válida.")
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboBanco_ValueChanged(sender As Object, e As EventArgs) Handles cboBanco.ValueChanged
        Try
            If cboBanco.SelectedIndex <> -1 Then
                TxtGlosaBanco.Value = "OBLIGACION FIN. CREDITO HIPOTECARIO " + cboBanco.Text
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CboMoneda_ValueChanged(sender As Object, e As EventArgs) Handles CboMoneda.ValueChanged
        Try
            If CboMoneda.SelectedIndex > -1 Then
                Dim _leCtBan = leCtaBancaria.Where(Function(it) it.IdMoneda = CboMoneda.Value).ToList
                LlenarCombo(cboCuentaBancariaOrigen, "BancoCuenta", _leCtBan, -1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            If CboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione moneda")
            If DecTC.Value = 0.0 Then Throw New Exception("El tipo de cambio no puede ser 0.0")
            If ndTasaInteresBanco.Value = 0 Then Throw New Exception("Ingrese la tasa de interés.")
            If Trim(TxtGlosaBanco.Value) = "" Then Throw New Exception("Ingrese la glosa")
            If leCuota.Where(Function(it) it.Activo).Count > 0 Then Throw New Exception("El credito hipotecario no debe tener cuotas.")
            Dim PathFilePTRA As String = ""
            ofdCreditoHipo = CargaDatosOpenFileDialog()
            If ofdCreditoHipo.ShowDialog = Windows.Forms.DialogResult.OK Then
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                PathFilePTRA = ofdCreditoHipo.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                leCuota = New List(Of e_ObligacionFin)
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        oeCuota = New e_ObligacionFin
                        oeCuota.TipoOperacion = "I" : oeCuota.Activo = True
                        oeCuota.Usuario = gUsuarioSGI.Id : oeCuota.MacLocal = MacPCLocal()
                        With oeCuota
                            .NroVencimiento = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value).Trim
                            .FechaVencimiento = CDate(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value).Trim)
                            .MontoMN = IIf(CboMoneda.Text = "SOLES", objWorkSheet.Cells(ln_Fila + 1, 4).Value, objWorkSheet.Cells(ln_Fila + 1, 4).Value * DecTC.Value)
                            .MontoME = IIf(CboMoneda.Text = "SOLES", objWorkSheet.Cells(ln_Fila + 1, 4).Value / DecTC.Value, objWorkSheet.Cells(ln_Fila + 1, 4).Value)
                            .MontoCapital = objWorkSheet.Cells(ln_Fila + 1, 4).Value
                            .MontoInteres = objWorkSheet.Cells(ln_Fila + 1, 5).Value
                            .Saldo = oeCuota.Total
                        End With
                        oeCuota.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leCuota.Add(oeCuota)
                    Else
                        Exit For
                    End If
                Next
                gridCuotas.DataSource = leCuota : gridCuotas.DataBind()
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close() : objXls.Quit()
                End If
                ofdCreditoHipo.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
                mensajeEmergente.Problema("¡El cronograma de pagos se importo con exito!", True)
            Else
                ofdCreditoHipo.Dispose()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub ListarObligacion()
        Try
            Cursor.Current = Cursors.WaitCursor
            oeContratoFin = New e_ContratoFinanciero
            oeContratoFin.TipoOperacion = "C" : oeContratoFin.Activo = True
            ValidarFechaDesde_Hasta(DtpFechaEmisionFiltro, DtpFechaEmisionFiltro)
            oeContratoFin.FechaEmision = DtpFechaEmisionFiltro.Value : oeContratoFin.FechaVencimiento = DtpFechaEmisionFinalFiltro.Value
            dsCredHipo = olContratoFin.ListarDS(oeContratoFin)
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) CONTRATOS
            'Tabla(1) OBLIGACIONES
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim IdContrato As DataColumn = dsCredHipo.Tables(0).Columns("Id")
            Dim IdObligFin As DataColumn = dsCredHipo.Tables(1).Columns("IdContratoFinanciero")
            relationContratoObligFin = New DataRelation("FK_Relacion", IdContrato, IdObligFin, False)
            dsCredHipo.Relations.Add(relationContratoObligFin)
            dsCredHipo.AcceptChanges()
            GridObligacion.DataSource = dsCredHipo
            With GridObligacion.DisplayLayout
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
            GridObligacion.DataBind()
        End Try
    End Sub

    Private Sub Inicializar()
        BancoFecha.Value = Date.Now()
        DecTC.Value = TipoCambio(BancoFecha.Value, False)(0)
        CboMoneda.Value = -1
        cboBanco.SelectedIndex = -1
        cboCuentaBancariaOrigen.SelectedIndex = -1
        cboMedioPago.SelectedIndex = -1
        cboFlujoGasto.SelectedIndex = -1
        TxtNumeroOperacionBanco.Value = String.Empty
        ndTotalBanco.Value = 0.0
        ndTasaInteresBanco.Value = 0.0
        ndComision.Value = 0.0
        TxtGlosaBanco.Value = "OBLIGACION FIN. CRÉDITO HIPOTECARIO"
        leCuota = New List(Of e_ObligacionFin)
        CargarCuotas(leCuota)
        InicializarCuota()
        BancoFecha.Focus()
    End Sub

    Private Sub InicializarCuota()
        txtNumeroCuota.Value = gridCuotas.Rows.Count + 1
        ndCapitalCuota.Value = 0.0
        ndInteresCuota.Value = 0.0
        ndTotalCuota.Value = 0.0
        dtpFechaVencimientoCuota.Value = Date.Now.Date.AddMonths(gridCuotas.Rows.Count)
        TxtGlosaObligacion.Value = "OBLIGACION FIN. CRÉDITO HIPOTECARIO"
        optGlosa.Checked = True
        ndCapitalCuota.Focus()
    End Sub

    Private Sub CuentaBancaria()
        Try
            Dim oeCtaBancaria As New e_CuentaBancaria
            Dim olCtaBancaria As New l_CuentaBancaria
            oeCtaBancaria.Activo = True
            oeCtaBancaria.Ejercicio = Year(BancoFecha.Value)
            oeCtaBancaria.TipoOperacion = "C"
            leCtaBancaria.Clear()
            leCtaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarMoneda()
        Try
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            With CboMoneda
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leMoneda
            End With
            GridObligacion.DisplayLayout.ValueLists.Add("IdMoneda")
            With GridObligacion.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Nombre", GridObligacion, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MedioPago()
        Try
            Dim oeMedioPago As New e_MedioPago
            Dim olMedioPago As New l_MedioPago
            Dim leMedioPago As New List(Of e_MedioPago)
            oeMedioPago.Activo = True
            leMedioPago.AddRange(olMedioPago.Listar(oeMedioPago))
            With cboMedioPago
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leMedioPago
            End With
            cboMedioPago.SelectedIndex = -1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaBanco()
        Try
            Dim oeProveedor As New e_Proveedor
            Dim olProveedor As New l_Proveedor
            Dim leBanco As New List(Of e_Proveedor)
            oeProveedor.Activo = True
            oeProveedor.TipoOperacion = "4"
            leBanco.AddRange(olProveedor.Listar(oeProveedor))
            With cboBanco
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leBanco
            End With
            GridObligacion.DisplayLayout.ValueLists.Add("IdEmpresaBanco")
            With GridObligacion.DisplayLayout.ValueLists("IdEmpresaBanco").ValueListItems
                .Clear()
                For Each oeTD As e_Proveedor In leBanco
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdEmpresaBanco", "Nombre", GridObligacion, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaFlujoCaja()
        Try
            Dim oeFlujoCaja As New e_FlujoCaja
            Dim olFlujoCaja As New l_FlujoCaja
            LlenarCombo(cboFlujoGasto, "Nombre", olFlujoCaja.Listar(oeFlujoCaja), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAsientoModel()
        oeAsientoModel = New e_AsientoModelo
        oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
        leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
    End Sub

    Private Sub AgregarCuota()
        Try
            If CboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione moneda")
            If DecTC.Value = 0.0 Then Throw New Exception("El tipo de cambio no puede ser 0.0")
            If ndCapitalCuota.Value = 0 Then Throw New Exception("El capital no puede ser 0.0")
            If ndTasaInteresBanco.Value = 0 Then Throw New Exception("Ingrese la tasa de interés.")
            If Trim(TxtGlosaObligacion.Value) = "" Then Throw New Exception("Ingrese la glosa")
            If leCuota.Where(Function(i) i.NroVencimiento = Trim(txtNumeroCuota.Value)).Count > 0 Then
                Throw New Exception("Este numero de cuota ya fue ingresado.")
            Else
                oeCuota = New e_ObligacionFin
                oeCuota.TipoOperacion = "I"
                oeCuota.Activo = True
                oeCuota.NroVencimiento = Trim(txtNumeroCuota.Value)
                oeCuota.FechaVencimiento = dtpFechaVencimientoCuota.Value
                oeCuota.MontoMN = IIf(CboMoneda.Text = "SOLES", ndCapitalCuota.Value, ndCapitalCuota.Value * DecTC.Value)
                oeCuota.MontoME = IIf(CboMoneda.Text = "SOLES", ndCapitalCuota.Value / DecTC.Value, ndCapitalCuota.Value)
                oeCuota.MontoCapital = ndCapitalCuota.Value
                oeCuota.MontoInteres = ndInteresCuota.Value
                oeCuota.Saldo = oeCuota.Total
                oeCuota.Usuario = gUsuarioSGI.Id
                oeCuota.MacLocal = MacPCLocal()
                oeCuota.PrefijoID = gs_PrefijoIdSucursal '@0001
                leCuota.Add(oeCuota)
                gridCuotas.DataSource = leCuota
                gridCuotas.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function GuardarCreditoHipotecario()
        Try
            If CboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione una moneda válida.")
            If DecTC.Value = 0 Then Throw New Exception("Tipo de cambio no puede ser 0.0")
            If cboBanco.Enabled = True And cboBanco.SelectedIndex = -1 Then Throw New Exception("Seleccione un banco.")
            If cboCuentaBancariaOrigen.Enabled = True And cboCuentaBancariaOrigen.SelectedIndex = -1 Then Throw New Exception("Seleccione una cuenta bancaria.")
            IdCtaCtble = String.Empty
            'Obtener Periodo
            oePeriodo = New e_Periodo
            oePeriodo = ObtenerPeriodo(CDate(BancoFecha.Value))
            oeContratoFin = New e_ContratoFinanciero
            oeContratoFin.IdPeriodo = oePeriodo.Id
            'Obtiene Asiento Modelo por Moneda
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.Equivale = 1 : oeAsientoModel.IdMoneda = CboMoneda.Value
            If leAsientoModel.Contains(oeAsientoModel) Then
                oeAsientoModel = leAsientoModel.Item(leAsientoModel.IndexOf(oeAsientoModel))
                oeAsientoModel.TipoOperacion = ""
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count > 0 Then
                    Dim _leDetAux = oeAsientoModel.leDetalle.Where(Function(it) it.Cuenta.Contains(gCCTOFecFeddCredHipo)).ToList
                    If _leDetAux.Count > 0 Then IdCtaCtble = _leDetAux(0).IdCuentaContable
                    For Each oeOFAux In leCuota
                        oeOFAux.IdCuentaContable = IdCtaCtble
                        oeOFAux.PrefijoID = gs_PrefijoIdSucursal '@0001
                    Next
                End If
            Else
                Throw New Exception("No Existe Configuracion Contable")
            End If
            'Cargar Movimiento Caja Banco
            oeContratoFin.oeMovCajaBanco = New e_MovimientoCajaBanco
            oeContratoFin.oeMovCajaBanco.IdCuentaBancaria = cboCuentaBancariaOrigen.Value
            oeContratoFin.oeMovCajaBanco.IdFlujoCaja = cboFlujoGasto.Value
            oeContratoFin.oeMovCajaBanco.IdMedioPago = cboMedioPago.Value
            'Cargar Contrato Financiero
            oeContratoFin.Codigo = TxtNumeroOperacionBanco.Text
            oeContratoFin.Usuario = gUsuarioSGI.Id
            oeContratoFin.TipoOperacion = "I"
            oeContratoFin.FechaEmision = BancoFecha.Value
            oeContratoFin.Glosa = TxtGlosaBanco.Text
            oeContratoFin.IdEmpresaBanco = cboBanco.Value
            oeContratoFin.IdMoneda = CboMoneda.Value
            oeContratoFin.IdTipoDocumento = IdCreditoHipotecario
            oeContratoFin.TasaInteres = ndTasaInteresBanco.Value
            oeContratoFin.TipoCambio = DecTC.Value
            oeContratoFin.Capital = ndTotalBanco.Value
            oeContratoFin.MontoMN = leCuota.Sum(Function(it) it.MontoMN)
            oeContratoFin.MontoME = leCuota.Sum(Function(it) it.MontoME)
            oeContratoFin.NroCuotas = leCuota.Count
            oeContratoFin.lstObligacionesFin = leCuota
            oeContratoFin.NombreBanco = cboBanco.Text
            oeContratoFin.Comision = ndComision.Value
            oeContratoFin.PrefijoID = gs_PrefijoIdSucursal '@0001
            Return olContratoFin.GuardarCreditoHipotecario(oeContratoFin, oeAsientoModel)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LlenarTipoObligacion()
        oeTipoObligacion = New e_TipoDocumento
        oeTipoObligacion.Activo = True : oeTipoObligacion.TipoOperacion = "I"
        leTipoObligacion = olTipoObligacion.Listar(oeTipoObligacion)
        IdCreditoHipotecario = leTipoObligacion.Where(Function(it) it.Nombre = gTOCreditoHipotecario)(0).Id
    End Sub

    Private Function EliminarCredito()
        Try
            If GridObligacion.ActiveRow.Selected() = True Then
                Throw New Exception("No se puede eliminar, comuníquese con Sistemas.")
            Else
                Throw New Exception("Seleccione una fila válida")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarCuotas(ByVal leCtas As List(Of e_ObligacionFin))
        Try
            With gridCuotas
                .ResetDisplayLayout()
                .DataSource = leCtas
                ConfiguraGrilla(gridCuotas, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna2(gridCuotas, False, "NroVencimiento", "FechaVencimiento", "MontoCapital", "MontoInteres", "MontoMN", "MontoME", "Total", "Saldo")
                .DisplayLayout.Bands(0).Columns("NroVencimiento").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("MontoCapital").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("MontoMN").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("MontoME").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("MontoInteres").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("NroVencimiento").Header.Caption = "NroCuota"
                FormatoColumna(gridCuotas, "#,##0.00", ColumnStyle.Double, HAlign.Right, "MontoCapital", "MontoInteres", "MontoMN", "MontoME", "Total", "Saldo")
                ColorFondoColumna(gridCuotas, Color.LightBlue, "MontoMN", "MontoME")
                CalcularTotales(gridCuotas, "MontoCapital", "Total", "Saldo")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class