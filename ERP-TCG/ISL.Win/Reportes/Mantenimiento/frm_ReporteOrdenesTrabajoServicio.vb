Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.UltraChart.Shared.Styles

Public Class frm_ReporteOrdenesTrabajoServicio
    Inherits ISL.Win.frm_MenuPadre

#Region "clase"
    Class CustomMergedCellEvaluator
        Implements Infragistics.Win.UltraWinGrid.IMergedCellEvaluator

        Function ShouldCellsBeMerged(ByVal row1 As UltraGridRow, ByVal row2 As UltraGridRow, ByVal column As UltraGridColumn) As Boolean Implements IMergedCellEvaluator.ShouldCellsBeMerged
            Dim band As Boolean = False
            Dim IdOT1, IdOT2 As String
            Dim Id1, Id2 As String
            Dim Fec1, Fec2 As Date
            IdOT1 = DirectCast(row1.GetCellValue("IdOT"), String)
            IdOT2 = DirectCast(row2.GetCellValue("IdOT"), String)
            If IdOT1 = IdOT2 Then
                Select Case column.Key
                    Case "Marca"
                        Id1 = DirectCast(row1.GetCellValue("Marca"), String)
                        Id2 = DirectCast(row2.GetCellValue("Marca"), String)
                        If Id1 = Id2 Then band = True
                    Case "Placa"
                        Id1 = DirectCast(row1.GetCellValue("Placa"), String)
                        Id2 = DirectCast(row2.GetCellValue("Placa"), String)
                        If Id1 = Id2 Then band = True
                    Case "TipoMantenimiento"
                        Id1 = DirectCast(row1.GetCellValue("TipoMantenimiento"), String)
                        Id2 = DirectCast(row2.GetCellValue("TipoMantenimiento"), String)
                        If Id1 = Id2 Then band = True
                    Case "Mantenimiento"
                        Id1 = DirectCast(row1.GetCellValue("Mantenimiento"), String)
                        Id2 = DirectCast(row2.GetCellValue("Mantenimiento"), String)
                        If Id1 = Id2 Then band = True
                    Case "Servicio"
                        Id1 = DirectCast(row1.GetCellValue("Servicio"), String)
                        Id2 = DirectCast(row2.GetCellValue("Servicio"), String)
                        If Id1 = Id2 Then band = True
                    Case "Proveedor"
                        Id1 = DirectCast(row1.GetCellValue("Proveedor"), String)
                        Id2 = DirectCast(row2.GetCellValue("Proveedor"), String)
                        If Id1 = Id2 Then band = True
                    Case "NroOC"
                        Id1 = DirectCast(row1.GetCellValue("NroOC"), String)
                        Id2 = DirectCast(row2.GetCellValue("NroOC"), String)
                        If Id1 = Id2 Then band = True
                    Case "TipoDoc"
                        Id1 = DirectCast(row1.GetCellValue("TipoDoc"), String)
                        Id2 = DirectCast(row2.GetCellValue("TipoDoc"), String)
                        If Id1 = Id2 Then band = True
                    Case "TipoDoc"
                        Id1 = DirectCast(row1.GetCellValue("TipoDoc"), String)
                        Id2 = DirectCast(row2.GetCellValue("TipoDoc"), String)
                        If Id1 = Id2 Then band = True
                    Case "FechaDoc"
                        Fec1 = DirectCast(row1.GetCellValue("FechaDoc"), Date)
                        Fec2 = DirectCast(row2.GetCellValue("FechaDoc"), Date)
                        If Fec1 = Fec2 Then band = True
                    Case "NroDoc"
                        Id1 = DirectCast(row1.GetCellValue("NroDoc"), String)
                        Id2 = DirectCast(row2.GetCellValue("NroDoc"), String)
                        If Id1 = Id2 Then band = True
                    Case "TipoMoneda"
                        Id1 = DirectCast(row1.GetCellValue("TipoMoneda"), String)
                        Id2 = DirectCast(row2.GetCellValue("TipoMoneda"), String)
                        If Id1 = Id2 Then band = True
                    Case "Glosa"
                        Id1 = DirectCast(row1.GetCellValue("Glosa"), String)
                        Id2 = DirectCast(row2.GetCellValue("Glosa"), String)
                        If Id1 = Id2 Then band = True
                    Case Else
                        band = True
                End Select
            End If
            Return band
            'End If
        End Function
    End Class

#End Region

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteOrdenesTrabajoServicio = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteOrdenesTrabajoServicio()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeReporteOTS As e_ReporteOTServicio
    Dim olReporteOTS As l_OrdenTrabajo_Servicio
    Dim leReporteOTS As List(Of e_ReporteOTServicio)
    Dim leGrafico As List(Of e_ReporteOTServicio)

    Dim oeServicio As e_Servicio
    Dim olServicio As l_Servicio
    Dim leServicio As List(Of e_Servicio)

    Dim oeEquipo As e_Equipo
    Dim olEquipo As l_Equipo
    Dim leEquipo As List(Of e_Equipo)

    Dim oeProveedor As e_Proveedor
    Dim olProveedor As l_Proveedor
    Dim leProveedor As List(Of e_Proveedor)

    Dim oeMarca As e_Marca
    Dim olMarca As l_Marca
    Dim leMarca As List(Of e_Marca)

    Dim oeTipoMantenimiento As e_TipoMantenimiento
    Dim olTipoMantenimiento As l_TipoMantenimiento
    Dim leTipoMantenimiento As List(Of e_TipoMantenimiento)

    Dim oeMantenimiento As e_Mantenimiento
    Dim olMantenimiento As l_Mantenimiento
    Dim leMantenimiento As List(Of e_Mantenimiento)

    Dim IdServicio, IdEquipo, IdProveedor, IdMarca, IdTipoMantenimiento, IdMantenimiento As String
    Dim bandServ, bandEquipo, bandProv, bandMarca, bandTipMan, bandMant As Boolean

    Dim dt As New DataTable

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeReporteOTS = New e_ReporteOTServicio
            leReporteOTS = New List(Of e_ReporteOTServicio)
            ValidarFechaDesde_Hasta(fecDesde, fecHasta)
            oeReporteOTS.TipoOperacion = String.Empty
            oeReporteOTS.FechaInicio = fecDesde.Value.Date
            oeReporteOTS.FechaFin = fecHasta.Value.Date
            CargarFiltros()
            oeReporteOTS.IdTipoMantenimiento = IdTipoMantenimiento
            oeReporteOTS.IdMantenimiento = IdMantenimiento
            oeReporteOTS.IdServicio = IdServicio
            oeReporteOTS.IdMarca = IdMarca
            oeReporteOTS.IdEquipo = IdEquipo
            oeReporteOTS.IdProveedor = IdProveedor
            leReporteOTS = olReporteOTS.ListarReporte(oeReporteOTS)
            CargarReporteOTServicio(leReporteOTS)
            If griDatos.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                ficDatos.Tabs(1).Enabled = True
                GeneraGrafico()
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                ficDatos.Tabs(1).Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Exportar_Excel(griDatos)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteOrdenesTrabajoServicio_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If griDatos.Rows.Count > 0 Then
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Else
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ReporteOrdenesTrabajoServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, agrBusqueda.Name)
            leReporteOTS = New List(Of e_ReporteOTServicio)
            olReporteOTS = New l_OrdenTrabajo_Servicio
            fecHasta.Value = Date.Now.Date
            fecDesde.Value = DateAdd(DateInterval.Day, -7, Date.Now.Date)
            CargarCombos()
            leReporteOTS = New List(Of e_ReporteOTServicio)
            CargarReporteOTServicio(leReporteOTS)
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            ficDatos.Tabs(1).Enabled = False
            fecDesde.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ReporteOrdenServicio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteOrdenesTrabajoServicio_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griTipoMantenimiento_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTipoMantenimiento.CellChange
        griTipoMantenimiento.UpdateData()
    End Sub

    Private Sub griMantenimiento_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMantenimiento.CellChange
        griMantenimiento.UpdateData()
    End Sub

    Private Sub griServicio_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griServicio.CellChange
        griServicio.UpdateData()
    End Sub

    Private Sub griMarca_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMarca.CellChange
        griMarca.UpdateData()
    End Sub

    Private Sub griEquipo_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griEquipo.CellChange
        griEquipo.UpdateData()
    End Sub

    Private Sub griProveedor_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griProveedor.CellChange
        griProveedor.UpdateData()
    End Sub

    Private Sub griDatos_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griDatos.InitializeLayout
        e.Layout.Bands(0).Columns("NroOT").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("FechaProgramacion").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Estado").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Marca").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Placa").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("TipoMantenimiento").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Mantenimiento").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Servicio").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Proveedor").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("NroOC").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("TipoDoc").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("FecDoc").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("NroDoc").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("TipoMoneda").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Glosa").MergedCellStyle = MergedCellStyle.Always
        For Each col As UltraGridColumn In griDatos.DisplayLayout.Bands(0).Columns
            If col.Key <> "IdOT" Then e.Layout.Bands(0).Columns(col.Key).MergedCellEvaluator = New CustomMergedCellEvaluator()
        Next
    End Sub

    Private Sub griTipoMantenimiento_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griTipoMantenimiento.AfterHeaderCheckStateChanged
        griTipoMantenimiento.UpdateData()
        Dim chkTipoMant As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandTipMan = IIf(chkTipoMant.ToString = "Checked", False, True)
    End Sub

    Private Sub griMantenimiento_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griMantenimiento.AfterHeaderCheckStateChanged
        griMantenimiento.UpdateData()
        Dim chkMant As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandMant = IIf(chkMant.ToString = "Checked", False, True)
    End Sub

    Private Sub griServicio_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griServicio.AfterHeaderCheckStateChanged
        griServicio.UpdateData()
        Dim chkServ As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandServ = IIf(chkServ.ToString = "Checked", False, True)
    End Sub

    Private Sub griMarca_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griMarca.AfterHeaderCheckStateChanged
        griMarca.UpdateData()
        Dim chkMarca As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandMarca = IIf(chkMarca.ToString = "Checked", False, True)
    End Sub

    Private Sub griEquipo_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griEquipo.AfterHeaderCheckStateChanged
        griEquipo.UpdateData()
        Dim chkEquipo As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandEquipo = IIf(chkEquipo.ToString = "Checked", False, True)
    End Sub

    Private Sub griProveedor_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griProveedor.AfterHeaderCheckStateChanged
        griProveedor.UpdateData()
        Dim chkProv As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandProv = IIf(chkProv.ToString = "Checked", False, True)
    End Sub

    Private Sub cboFila_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFila.ValueChanged
        If cboFila.SelectedIndex > -1 Then GeneraGrafico()
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            oeServicio = New e_Servicio
            olServicio = New l_Servicio
            leServicio = New List(Of e_Servicio)
            oeServicio.TipoOperacion = String.Empty
            oeServicio.Activo = True
            leServicio = olServicio.Listar(oeServicio)
            CargarServicios(leServicio)

            oeEquipo = New e_Equipo
            olEquipo = New l_Equipo
            leEquipo = New List(Of e_Equipo)
            oeEquipo.TipoOperacion = String.Empty
            oeEquipo.Activo = True
            leEquipo = olEquipo.Listar(oeEquipo)
            CargarEquipo(leEquipo)

            oeProveedor = New e_Proveedor
            olProveedor = New l_Proveedor
            leProveedor = New List(Of e_Proveedor)
            oeProveedor.TipoOperacion = String.Empty
            oeProveedor.Activo = True
            leProveedor = olProveedor.Listar(oeProveedor)
            CargarProveedor(leProveedor)

            oeMarca = New e_Marca
            olMarca = New l_Marca
            leMarca = New List(Of e_Marca)
            oeMarca.TipoMarca = 1
            oeMarca.Activo = True
            leMarca = olMarca.Listar(oeMarca)
            CargarMarca(leMarca)

            oeTipoMantenimiento = New e_TipoMantenimiento
            olTipoMantenimiento = New l_TipoMantenimiento
            leTipoMantenimiento = New List(Of e_TipoMantenimiento)
            oeTipoMantenimiento.TipoOperacion = String.Empty
            oeTipoMantenimiento.Activo = True
            leTipoMantenimiento = olTipoMantenimiento.Listar(oeTipoMantenimiento)
            CargarTipoMantenimiento(leTipoMantenimiento)

            oeMantenimiento = New e_Mantenimiento
            olMantenimiento = New l_Mantenimiento
            leMantenimiento = New List(Of e_Mantenimiento)
            oeMantenimiento.TipoOperacion = String.Empty
            oeMantenimiento.Activo = True
            leMantenimiento = olMantenimiento.Listar(oeMantenimiento)
            CargarMantenimiento(leMantenimiento)

            cboFila.Items.Clear()
            cboFila.Items.Add(0, "TipoMantenimiento")
            cboFila.Items.Add(1, "Mantenimiento")
            cboFila.Items.Add(2, "Servicio")
            cboFila.Items.Add(3, "Marca")
            cboFila.Items.Add(4, "Placa")
            cboFila.Items.Add(5, "Proveedor")
            cboFila.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarServicios(ByVal leServ As List(Of e_Servicio))
        Try
            With griServicio
                .DataSource = leServ
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Codigo" Or Col.Key = "Nombre" Or Col.Key = "Seleccion" Then
                        Col.Hidden = False
                        If Col.Key = "Seleccion" Then
                            Col.CellClickAction = CellClickAction.Edit
                        Else
                            Col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Else
                        Col.Hidden = True
                    End If
                Next
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Right
                .DisplayLayout.Bands(0).Columns("Seleccion").SetHeaderCheckedState(.Rows, True)
                .DisplayLayout.Bands(0).Columns("Seleccion").Width = 50
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarEquipo(ByVal leEqui As List(Of e_Equipo))
        Try
            With griEquipo
                .ResetDisplayLayout()
                .DataSource = leEqui
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Right
                .DisplayLayout.Bands(0).Columns("Selec").Width = 50
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Codigo" Or Col.Key = "Nombre" Or Col.Key = "Selec" Then
                        Col.Hidden = False
                        If Col.Key = "Selec" Then
                            Col.CellClickAction = CellClickAction.Edit
                        Else
                            Col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Else
                        Col.Hidden = True
                    End If
                Next
                .DisplayLayout.Bands(0).Columns("Selec").SetHeaderCheckedState(.Rows, True)
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarProveedor(ByVal leProv As List(Of e_Proveedor))
        Try
            With griProveedor
                .DataSource = leProv
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "NroDocumento" Or Col.Key = "Nombre" Or Col.Key = "Seleccion" Then
                        Col.Hidden = False
                        If Col.Key = "Seleccion" Then
                            Col.CellClickAction = CellClickAction.Edit
                        Else
                            Col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Else
                        Col.Hidden = True
                    End If
                Next
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Right
                .DisplayLayout.Bands(0).Columns("Seleccion").SetHeaderCheckedState(.Rows, True)
                .DisplayLayout.Bands(0).Columns("NroDocumento").Header.Caption = "RUC"
                .DisplayLayout.Bands(0).Columns("Seleccion").Width = 50
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarMarca(ByVal leMarc As List(Of e_Marca))
        Try
            With griMarca
                .ResetDisplayLayout()
                .DataSource = leMarc
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Right
                .DisplayLayout.Bands(0).Columns("Selec").Width = 50
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Codigo" Or Col.Key = "Nombre" Or Col.Key = "Selec" Then
                        Col.Hidden = False
                        If Col.Key = "Selec" Then
                            Col.CellClickAction = CellClickAction.Edit
                        Else
                            Col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Else
                        Col.Hidden = True
                    End If
                Next
                .DisplayLayout.Bands(0).Columns("Selec").SetHeaderCheckedState(.Rows, True)
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTipoMantenimiento(ByVal leTipM As List(Of e_TipoMantenimiento))
        Try
            With griTipoMantenimiento
                .ResetDisplayLayout()
                .DataSource = leTipM
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Right
                .DisplayLayout.Bands(0).Columns("Selec").Width = 50
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Codigo" Or Col.Key = "Nombre" Or Col.Key = "Selec" Then
                        Col.Hidden = False
                        If Col.Key = "Selec" Then
                            Col.CellClickAction = CellClickAction.Edit
                        Else
                            Col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Else
                        Col.Hidden = True
                    End If
                Next
                .DisplayLayout.Bands(0).Columns("Selec").SetHeaderCheckedState(.Rows, True)
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarMantenimiento(ByVal leMant As List(Of e_Mantenimiento))
        Try
            With griMantenimiento
                .ResetDisplayLayout()
                .DataSource = leMant
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Right
                .DisplayLayout.Bands(0).Columns("Selec").Width = 50
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Codigo" Or Col.Key = "Nombre" Or Col.Key = "Selec" Then
                        Col.Hidden = False
                        If Col.Key = "Selec" Then
                            Col.CellClickAction = CellClickAction.Edit
                        Else
                            Col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Else
                        Col.Hidden = True
                    End If
                Next
                .DisplayLayout.Bands(0).Columns("Selec").SetHeaderCheckedState(.Rows, True)
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarReporteOTServicio(ByVal leReportOTS As List(Of e_ReporteOTServicio))
        With griDatos

            .DataSource = leReportOTS

            .DisplayLayout.Bands(0).Columns("IdOT").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdServ").Hidden = True

            .DisplayLayout.Bands(0).Columns("NroOT").Header.VisiblePosition = 0
            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.VisiblePosition = 1
            .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 2
            .DisplayLayout.Bands(0).Columns("Marca").Header.VisiblePosition = 3
            .DisplayLayout.Bands(0).Columns("Placa").Header.VisiblePosition = 4
            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").Header.VisiblePosition = 5
            .DisplayLayout.Bands(0).Columns("Mantenimiento").Header.VisiblePosition = 6
            .DisplayLayout.Bands(0).Columns("Servicio").Header.VisiblePosition = 7
            .DisplayLayout.Bands(0).Columns("Proveedor").Header.VisiblePosition = 8
            .DisplayLayout.Bands(0).Columns("CostoOTS").Header.VisiblePosition = 9

            .DisplayLayout.Bands(0).Columns("NroOT").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("FechaProgramacion").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Estado").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Mantenimiento").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Servicio").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Placa").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Marca").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Proveedor").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("NroOC").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("TipoDoc").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("FecDoc").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("NroDoc").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("TipoMoneda").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Glosa").CellAppearance.TextVAlign = VAlign.Middle

            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Width = 60
            .DisplayLayout.Bands(0).Columns("Estado").Width = 75
            .DisplayLayout.Bands(0).Columns("Marca").Width = 100
            .DisplayLayout.Bands(0).Columns("Placa").Width = 60
            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").Width = 80
            .DisplayLayout.Bands(0).Columns("Mantenimiento").Width = 150
            .DisplayLayout.Bands(0).Columns("Servicio").Width = 150
            .DisplayLayout.Bands(0).Columns("Proveedor").Width = 150
            .DisplayLayout.Bands(0).Columns("TipoDoc").Width = 120
            .DisplayLayout.Bands(0).Columns("FecDoc").Width = 60
            .DisplayLayout.Bands(0).Columns("TipoMoneda").Width = 60
            .DisplayLayout.Bands(0).Columns("NroDoc").Width = 100

            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.Caption = "Fecha Prog."
            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").Header.Caption = "Tipo Mant."
            .DisplayLayout.Bands(0).Columns("TipoMoneda").Header.Caption = "T.M."

            .DisplayLayout.Bands(0).Columns("CostoOTS").Style = ColumnStyle.Double

            .DisplayLayout.Bands(0).Columns("CostoOTS").CellAppearance.TextHAlign = HAlign.Right

            .DisplayLayout.UseFixedHeaders = True
            .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
            .DisplayLayout.Bands(0).Columns("NroOT").Header.Fixed = True
            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.Fixed = True
            .DisplayLayout.Bands(0).Columns("Estado").Header.Fixed = True
            .DisplayLayout.Bands(0).Columns("Marca").Header.Fixed = True
            .DisplayLayout.Bands(0).Columns("Placa").Header.Fixed = True

            .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
            .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
            .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
            .DisplayLayout.Override.FilterUIProvider = Filtro1
            .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
            .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            .DisplayLayout.MaxColScrollRegions = 1
            .DisplayLayout.MaxRowScrollRegions = 1
        End With
        CalcularTotales(griDatos, "CostoOTS")
    End Sub

    Private Sub CargarFiltros()
        IdTipoMantenimiento = ""
        If bandTipMan Then
            For Each Fila In griTipoMantenimiento.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Selec").Value = True)
                IdTipoMantenimiento = IdTipoMantenimiento & "'" & Fila.Cells("Id").Value & "',"
            Next
            If IdTipoMantenimiento.Trim <> "" Then IdTipoMantenimiento = IdTipoMantenimiento.Substring(0, IdTipoMantenimiento.Length - 1)
        End If
        IdMantenimiento = ""
        If bandMant Then
            For Each Fila In griMantenimiento.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Selec").Value = True)
                IdMantenimiento = IdMantenimiento & "'" & Fila.Cells("Id").Value & "',"
            Next
            If IdMantenimiento.Trim <> "" Then IdMantenimiento = IdMantenimiento.Substring(0, IdMantenimiento.Length - 1)
        End If
        IdServicio = ""
        If bandServ Then
            For Each Fila In griServicio.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Seleccion").Value = True)
                IdServicio = IdServicio & "'" & Fila.Cells("Id").Value & "',"
            Next
            If IdServicio.Trim <> "" Then IdServicio = IdServicio.Substring(0, IdServicio.Length - 1)
        End If
        IdMarca = ""
        If bandMarca Then
            For Each Fila In griMarca.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Selec").Value = True)
                IdMarca = IdMarca & "'" & Fila.Cells("Id").Value & "',"
            Next
            If IdMarca.Trim <> "" Then IdMarca = IdMarca.Substring(0, IdMarca.Length - 1)
        End If
        IdEquipo = ""
        If bandEquipo Then
            For Each Fila In griEquipo.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Selec").Value = True)
                IdEquipo = IdEquipo & "'" & Fila.Cells("Id").Value & "',"
            Next
            If IdEquipo.Trim <> "" Then IdEquipo = IdEquipo.Substring(0, IdEquipo.Length - 1)
        End If
        IdProveedor = ""
        If bandProv Then
            For Each Fila In griProveedor.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Seleccion").Value = True)
                IdProveedor = IdProveedor & "'" & Fila.Cells("Id").Value & "',"
            Next
            If IdProveedor.Trim <> "" Then IdProveedor = IdProveedor.Substring(0, IdProveedor.Length - 1)
        End If
    End Sub

    Private Sub GeneraGrafico()
        Try
            CapturaDatos()
            dt = New Data.DataTable
            dt.Columns.Add("Mantenimiento", System.Type.GetType("System.String"))
            dt.Columns.Add("Costo", System.Type.GetType("System.Decimal"))
            LlenarDatos()
            'dt.Rows.Add("2005", -100)
            'dt.Rows.Add("2006", 160)
            'dt.Rows.Add("2007", -250)
            'dt.Rows.Add("2008", 500)
            'dt.Rows.Add("2009", -860)
            'dt.Rows.Add("2010", 600)
            'graServicio.Axis.X.RangeMin = 0
            'graServicio.Axis.X.RangeMax = 500
            'graServicio.Axis.Y.RangeMin = 0
            'graServicio.Axis.Y.NumericAxisType = 
            graServicio.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:#,###,##0.00>"
            graServicio.Axis.Y.RangeMin = 0
            graServicio.Axis.X.ScrollScale.Visible = True
            graServicio.Axis.X.ScrollScale.Height = 15
            graServicio.Axis.X.ScrollScale.Scale() = 0.5

            graServicio.Tooltips.Font = New Font("Arial", 10, FontStyle.Regular)
            graServicio.Tooltips.Format = TooltipStyle.LabelPlusDataValue
            graServicio.Tooltips.FormatString = "<ITEM_LABEL>: S/. <DATA_VALUE:#,###,##0.00>"
            graServicio.Data.ZeroAligned = True
            graServicio.Data.DataSource = dt
            graServicio.ChartType = ChartType.ColumnChart
            graServicio.Data.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CapturaDatos()

        Dim id As String = String.Empty
        Dim leObjetoAux As New List(Of e_ReporteOTServicio)
        leGrafico = New List(Of e_ReporteOTServicio)

        Select Case cboFila.SelectedIndex
            Case 0
                leObjetoAux = leReporteOTS.OrderBy(Function(item) item.TipoMantenimiento).ToList
                For Each oeMant In leObjetoAux
                    If id <> oeMant.TipoMantenimiento Then
                        id = oeMant.TipoMantenimiento
                        oeReporteOTS = New e_ReporteOTServicio
                        oeReporteOTS.TipoMantenimiento = oeMant.TipoMantenimiento
                        oeReporteOTS.CostoOTS = leObjetoAux.Where(Function(item) item.TipoMantenimiento = id).Sum(Function(item) item.CostoOTS)
                        leGrafico.Add(oeReporteOTS)
                    End If
                Next
            Case 1
                leObjetoAux = leReporteOTS.OrderBy(Function(item) item.Mantenimiento).ToList
                For Each oeMant In leObjetoAux
                    If id <> oeMant.Mantenimiento Then
                        id = oeMant.Mantenimiento
                        oeReporteOTS = New e_ReporteOTServicio
                        oeReporteOTS.Mantenimiento = oeMant.Mantenimiento
                        oeReporteOTS.CostoOTS = leObjetoAux.Where(Function(item) item.Mantenimiento = id).Sum(Function(item) item.CostoOTS)
                        leGrafico.Add(oeReporteOTS)
                    End If
                Next
            Case 2
                leObjetoAux = leReporteOTS.OrderBy(Function(item) item.Servicio).ToList
                For Each oeMant In leObjetoAux
                    If id <> oeMant.Servicio Then
                        id = oeMant.Servicio
                        oeReporteOTS = New e_ReporteOTServicio
                        oeReporteOTS.Servicio = oeMant.Servicio
                        oeReporteOTS.CostoOTS = leObjetoAux.Where(Function(item) item.Servicio = id).Sum(Function(item) item.CostoOTS)
                        leGrafico.Add(oeReporteOTS)
                    End If
                Next
            Case 3
                leObjetoAux = leReporteOTS.OrderBy(Function(item) item.Marca).ToList
                For Each oeMant In leObjetoAux
                    If id <> oeMant.Marca Then
                        id = oeMant.Marca
                        oeReporteOTS = New e_ReporteOTServicio
                        oeReporteOTS.Marca = oeMant.Marca
                        oeReporteOTS.CostoOTS = leObjetoAux.Where(Function(item) item.Marca = id).Sum(Function(item) item.CostoOTS)
                        leGrafico.Add(oeReporteOTS)
                    End If
                Next
            Case 4
                leObjetoAux = leReporteOTS.OrderBy(Function(item) item.Placa).ToList
                For Each oeMant In leObjetoAux
                    If id <> oeMant.Placa Then
                        id = oeMant.Placa
                        oeReporteOTS = New e_ReporteOTServicio
                        oeReporteOTS.Placa = oeMant.Placa
                        oeReporteOTS.CostoOTS = leObjetoAux.Where(Function(item) item.Placa = id).Sum(Function(item) item.CostoOTS)
                        leGrafico.Add(oeReporteOTS)
                    End If
                Next
            Case 5
                leObjetoAux = leReporteOTS.OrderBy(Function(item) item.Proveedor).ToList
                For Each oeMant In leObjetoAux
                    If id <> oeMant.Proveedor Then
                        id = oeMant.Proveedor
                        oeReporteOTS = New e_ReporteOTServicio
                        oeReporteOTS.Proveedor = oeMant.Proveedor
                        oeReporteOTS.CostoOTS = leObjetoAux.Where(Function(item) item.Proveedor = id).Sum(Function(item) item.CostoOTS)
                        leGrafico.Add(oeReporteOTS)
                    End If
                Next
        End Select

    End Sub

    Private Sub LlenarDatos()
        Select Case cboFila.SelectedIndex
            Case 0
                'Dim leObj As New List(Of Object)
                'For Each fila As Data.DataRow In dt.Rows
                '    Dim obj As Object() = {fila.Item("").ToString, fila.Item("")}
                '    leObj.Add(obj)
                'Next
                'leObj(0)(0).ToString 
                For Each oerep In leGrafico.OrderByDescending(Function(item) item.CostoOTS).ToList
                    dt.Rows.Add(oerep.TipoMantenimiento, oerep.CostoOTS)
                Next
            Case 1
                For Each oerep In leGrafico.OrderByDescending(Function(item) item.CostoOTS).ToList
                    dt.Rows.Add(oerep.Mantenimiento, oerep.CostoOTS)
                Next
            Case 2
                For Each oerep In leGrafico.OrderByDescending(Function(item) item.CostoOTS).ToList
                    dt.Rows.Add(oerep.Servicio, oerep.CostoOTS)
                Next
            Case 3
                For Each oerep In leGrafico.OrderByDescending(Function(item) item.CostoOTS).ToList
                    dt.Rows.Add(oerep.Marca, oerep.CostoOTS)
                Next
            Case 4
                For Each oerep In leGrafico.OrderByDescending(Function(item) item.CostoOTS).ToList
                    dt.Rows.Add(oerep.Placa, oerep.CostoOTS)
                Next
            Case 5
                For Each oerep In leGrafico.OrderByDescending(Function(item) item.CostoOTS).ToList
                    dt.Rows.Add(oerep.Proveedor, oerep.CostoOTS)
                Next
        End Select

    End Sub

#End Region

End Class