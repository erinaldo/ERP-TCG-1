'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_BuscarDocumento

#Region "Instancia"

    'Public Sub New(ByVal ln_TipoOpe As Integer, _leDscto As List(Of e_Prestamo), _leCuota As List(Of e_PrestamoDetalle), _
    '               ByVal ln_MontoPago As Double, ByVal ld_FecPeriodo As Date, ByVal ln_Doble As Integer, _
    '               ByVal ln_Adelanto As Integer, ls_IdTrabajador As String)
    '    ' Llamada necesaria para el diseñador.
    '    InitializeComponent()
    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    '    TipoOpe = ln_TipoOpe : MontoPago = ln_MontoPago : FecPeriodo = ld_FecPeriodo : IdTrabajador = ls_IdTrabajador
    '    IndDoble = ln_Doble : leDscto = _leDscto : leCuota = _leCuota : IndAdelanto = ln_Adelanto
    'End Sub

    Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#End Region

#Region "Declaracion de Variables"

    Public mensajeEmergente As New c_Alertas
    Private oeMovimientoDoc As New e_MovimientoDocumento, olMovimientoDoc As New l_MovimientoDocumento, leMovimientoDoc As New List(Of e_MovimientoDocumento)
    Private oeTipoDoc As New e_TipoDocumento, olTipoDoc As New l_TipoDocumento, leTipoDoc As New List(Of e_TipoDocumento), leTipoDocBus As New List(Of e_TipoDocumento)
    Private oeObligacionesFinancieras As New e_ObligacionFin, olObligacionesFinancieras As New l_ObligacionFinanciera
    Public oeOrdenTrabajo As e_OrdenTrabajo
    Private olOrdenTrabajo As New l_OrdenTrabajo

    Public oeDocumento As New e_MovimientoDocumento
    'Public oeObligacion As New e_ObligacionFinanciera
    Public oeObligacionFin As New e_ObligacionFin
    Public strIndServicioMaterial As String = ""
#End Region

#Region "Eventos"

    Private Sub frm_BuscarDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If IndCuentaCP = 0 Then
                tabLista.Tabs(0).Enabled = False
                tabLista.Tabs(2).Enabled = False
                tabLista.Tabs(1).Enabled = True
                tabLista.Tabs(1).Selected = True
            ElseIf IndCuentaCP = 1 OrElse IndCuentaCP = 2 Then
                tabLista.Tabs(0).Selected = True
                tabLista.Tabs(0).Enabled = True
                tabLista.Tabs(1).Enabled = False
                tabLista.Tabs(2).Enabled = False
            Else
                tabLista.Tabs(2).Selected = True
                tabLista.Tabs(2).Enabled = True
                tabLista.Tabs(0).Enabled = False
                tabLista.Tabs(1).Enabled = False
            End If
            CargarCombos()
            CargarObliFinan(New List(Of e_ObligacionFin))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnBuscarDoc_Click(sender As Object, e As EventArgs) Handles btnBuscarDoc.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If IndCuentaCP = 1 Or IndCuentaCP = 2 Then
                oeMovimientoDoc = New e_MovimientoDocumento
                If rbDatosAdicionales.Checked Then
                    oeMovimientoDoc.IdTipoDocumento = cmbTipoDoc.Value
                    oeMovimientoDoc.IdClienteProveedor = cmbEmpresa.Value
                    oeMovimientoDoc.FechaInicio = rfFechaDesde.Value
                    oeMovimientoDoc.FechaFinal = rfFechaHasta.Value
                ElseIf rbNroDoc.Checked Then
                    oeMovimientoDoc.Serie = txtSerie.Text.Trim
                    oeMovimientoDoc.Numero = txtNumero.Text.Trim
                End If
                oeMovimientoDoc.IndCompraVenta = IndCuentaCP
                oeMovimientoDoc.IndServicioMaterial = strIndServicioMaterial
                oeMovimientoDoc.TipoOperacion = "BDT"
                leMovimientoDoc = olMovimientoDoc.ListarDocumentosPorCompras(oeMovimientoDoc)
                gridDocumentos.DataSource = leMovimientoDoc
            ElseIf IndCuentaCP = 3 Then
                'Orden de Trabajo
                oeOrdenTrabajo = New e_OrdenTrabajo
                oeOrdenTrabajo.Activo = True
                oeOrdenTrabajo.TipoOperacion = ""
                oeOrdenTrabajo.FechaProgramacionIni = Date.Parse("01/01/1901").Date
                oeOrdenTrabajo.FechaProgramacionFin = Date.Parse("01/01/1901").Date
                oeOrdenTrabajo.FechaIngresoTaller = Date.Parse("01/01/1901").Date
                oeOrdenTrabajo.FechaInicioTrabajo = Date.Parse("01/01/1901").Date
                oeOrdenTrabajo.FechaFinTrabajo = Date.Parse("01/01/1901").Date
                oeOrdenTrabajo.FechaCreacion = Date.Parse("01/01/1901").Date
                oeOrdenTrabajo.NroOT = If(rbNroDoc.Checked, txtNumero.Text.Trim(), "")
                oeOrdenTrabajo.IdEstadoOT = ""
                oeOrdenTrabajo.IdEquipo = ""
                oeOrdenTrabajo.IdMantenimiento = ""
                oeOrdenTrabajo.IdTipoMantenimiento = ""
                oeOrdenTrabajo.IndicadorTipo = ""
                oeOrdenTrabajo.PrefijoCentro = ""
                If rbDatosAdicionales.Checked Then
                    oeOrdenTrabajo.FechaProgramacionIni = rfFechaDesde.Value
                    oeOrdenTrabajo.FechaProgramacionFin = rfFechaHasta.Value
                End If
                griOrdenTrabajo.DataSource = olOrdenTrabajo.Listar(oeOrdenTrabajo)
            Else
                oeObligacionesFinancieras = New e_ObligacionFin
                oeObligacionesFinancieras.TipoOperacion = "F"
                If rbDatosAdicionales.Checked Then
                    oeObligacionesFinancieras.IdTipoObligacion = cmbTipoDoc.Value
                    oeObligacionesFinancieras.Banco = cmbEmpresa.Value
                    oeObligacionesFinancieras.FechaInicio = rfFechaDesde.Value
                    oeObligacionesFinancieras.FechaVencimiento = rfFechaHasta.Value
                ElseIf rbNroDoc.Checked Then
                    oeObligacionesFinancieras.NroVencimiento = txtNumero.Text.Trim
                End If
                If oeObligacionesFinancieras.IdTipoObligacion = "1CH000000067" Then
                    oeObligacionesFinancieras.FechaInicio = Date.Parse("01/01/1901")
                    oeObligacionesFinancieras.FechaVencimiento = Date.Parse("01/01/1901")
                    oeObligacionesFinancieras.Saldo = 1
                End If
                griObligaciones.DataSource = olObligacionesFinancieras.Listar2(oeObligacionesFinancieras)
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cmbEmpresa_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cmbEmpresa.InitializeLayout
        InicializarComboMaestro(cmbEmpresa)
    End Sub

    Private Sub cmbEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbEmpresa.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarProveedores(cmbEmpresa, "0", False)
        End If
    End Sub

    Private Sub cmbEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEmpresa.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cmbEmpresa.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub rbNroDoc_CheckedChanged(sender As Object, e As EventArgs) Handles rbNroDoc.CheckedChanged
        gbNroDoc.Enabled = rbNroDoc.Checked
        cmbEmpresa.Value = Nothing
        cmbTipoDoc.SelectedIndex = -1
        txtSerie.Focus()
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(sender As Object, e As EventArgs) Handles rbDatosAdicionales.CheckedChanged
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        If Not String.IsNullOrEmpty(txtSerie.Text) Then txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
    End Sub

    Private Sub txtNumero_Validated(sender As Object, e As EventArgs) Handles txtNumero.Validated
        If Not String.IsNullOrEmpty(txtNumero.Text) Then
            If IndCuentaCP <> 0 Then
                txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click, gridDocumentos.DoubleClick, griObligaciones.DoubleClick
        Try
            If tabLista.Tabs(0).Selected Then
                If gridDocumentos.Selected.Rows.Count > 0 Then
                    oeDocumento = New e_MovimientoDocumento
                    oeDocumento = gridDocumentos.ActiveRow.ListObject
                    oeDocumento.Activo = True
                    oeDocumento.TipoOperacion = ""
                    oeDocumento.Mac_PC_Local = MacPCLocal()
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    Throw New Exception("No hay Datos para Guardar")
                End If
            ElseIf tabLista.Tabs(1).Selected Then
                If griObligaciones.Selected.Rows.Count > 0 Then
                    oeObligacionFin = New e_ObligacionFin
                    oeObligacionFin = griObligaciones.ActiveRow.ListObject
                    oeObligacionFin.MacLocal = MacPCLocal()
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    Throw New Exception("No hay Datos para Guardar")
                End If
            Else
                If griOrdenTrabajo.Selected.Rows.Count > 0 Then
                    oeOrdenTrabajo = New e_OrdenTrabajo
                    oeOrdenTrabajo.Id = griOrdenTrabajo.ActiveRow.Cells("Id").Value.ToString()
                    oeOrdenTrabajo.NroOT = griOrdenTrabajo.ActiveRow.Cells("NroOT").Value.ToString()
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    Throw New Exception("No hay Datos para Guardar")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            oeTipoDoc = New e_TipoDocumento
            If IndCuentaCP = 0 Then
                oeTipoDoc.TipoOperacion = "0"
            Else
                oeTipoDoc.TipoOperacion = "S"
            End If
            oeTipoDoc.Activo = 1
            leTipoDoc = olTipoDoc.Listar(oeTipoDoc)
            LlenarCombo(cmbTipoDoc, "Nombre", leTipoDoc, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarComboMaestro(ByVal combo As Infragistics.Win.UltraWinGrid.UltraCombo)
        combo.ValueMember = "Id"
        combo.DisplayMember = "Nombre"
        With combo.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Email").Hidden = True
            .Columns("Seleccion").Hidden = True
            .Columns("Contacto").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("NroDocumento").Header.Caption = "N° RUC"
            .Columns("NroDocumento").Width = 50
            .Columns("Nombre").Width = 150
        End With
    End Sub

    Private Sub CargarObliFinan(leObliFin As List(Of e_ObligacionFin))
        Try
            With griObligaciones
                .ResetDisplayLayout()
                .DataSource = leObliFin
                OcultarColumna(griObligaciones, True, "Id", "IdContrato", "IndPeriodoGracia", "MontoMN", "MontoME", "MontoInteresMoratorio", _
                               "MontoInteresDscto", "MontoInteresContable", "DiasFinMes", "DiasProximaCuota", "IndInteresMensual", "Glosa", "Cuo", _
                               "Usuario", "FechaCreacion", "UsuarioModifica", "FechaModifica", "MacLocal", "Activo", "FechaInicio", "MontoCuota", _
                               "IdCuentaContable", "MontoOperar", "MontoInteres", "Comision", "IGV", "Portes", "Gastos", "MontoCapital", "ITF")
                FormatoColumna(griObligaciones, "#,##0.00", ColumnStyle.Double, HAlign.Right, "MontoInteres", "Comision", "Gastos", "Portes", _
                               "IGV", "Saldo", "MontoCapital", "Total")
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("NroContrato").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NroVencimiento").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("NroVencimiento").Width = 65
                .DisplayLayout.Bands(0).Columns("Banco").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Banco").Width = 250
                .DisplayLayout.Bands(0).Columns("IdTipoObligacion").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("IdMoneda").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("MontoCapital").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("MontoInteres").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Comision").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("IGV").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("Portes").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("Gastos").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.Caption = "Fec. Venc."
                .DisplayLayout.Bands(0).Columns("NroVencimiento").Header.Caption = "Nro Cuota"
                .DisplayLayout.Bands(0).Columns("IdTipoObligacion").Header.Caption = "Tipo Oblig."
                .DisplayLayout.Bands(0).Columns("IdMoneda").Header.Caption = "Moneda"
                .DisplayLayout.Bands(0).Columns("MontoCapital").Header.Caption = "Capital"
                .DisplayLayout.Bands(0).Columns("MontoInteres").Header.Caption = "Interes"
                CalcularTotales(griObligaciones, "Total", "Saldo")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class