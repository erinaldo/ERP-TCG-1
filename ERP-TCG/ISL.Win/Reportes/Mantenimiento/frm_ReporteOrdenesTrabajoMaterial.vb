Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.UltraChart.Shared.Styles

Public Class frm_ReporteOrdenesTrabajoMaterial
    Inherits ISL.Win.frm_MenuPadre

#Region "clase"

    Class CustomMergedCellEvaluator

        Implements Infragistics.Win.UltraWinGrid.IMergedCellEvaluator

        Function ShouldCellsBeMerged(ByVal row1 As UltraGridRow, ByVal row2 As UltraGridRow, ByVal column As UltraGridColumn) As Boolean Implements IMergedCellEvaluator.ShouldCellsBeMerged
            Dim band As Boolean = False
            Dim IdTM1, IdTM2 As String
            Dim IdEq1, IdEq2 As String
            Dim Id1, Id2 As String
            Dim Fecha1, Fecha2 As Date
            IdTM1 = DirectCast(row1.GetCellValue("IdTipoMant"), String)
            IdTM2 = DirectCast(row2.GetCellValue("IdTipoMant"), String)
            If IdTM1 = IdTM2 Then
                Select Case column.Key
                    Case "Mantenimiento"
                        Id1 = DirectCast(row1.GetCellValue("Mantenimiento"), String)
                        Id2 = DirectCast(row2.GetCellValue("Mantenimiento"), String)
                        If Id1 = Id2 Then band = True
                    Case "Equipo"
                        Id1 = DirectCast(row1.GetCellValue("Equipo"), String)
                        Id2 = DirectCast(row2.GetCellValue("Equipo"), String)
                        If Id1 = Id2 Then band = True
                    Case "TipoVehiculo"
                        IdEq1 = DirectCast(row1.GetCellValue("Equipo"), String)
                        IdEq2 = DirectCast(row2.GetCellValue("Equipo"), String)
                        If IdEq1 = IdEq2 Then
                            Id1 = DirectCast(row1.GetCellValue("TipoVehiculo"), String)
                            Id2 = DirectCast(row2.GetCellValue("TipoVehiculo"), String)
                            If Id1 = Id2 Then band = True
                        End If
                    Case "Flota"
                        IdEq1 = DirectCast(row1.GetCellValue("Equipo"), String)
                        IdEq2 = DirectCast(row2.GetCellValue("Equipo"), String)
                        If IdEq1 = IdEq2 Then
                            Id1 = DirectCast(row1.GetCellValue("Flota"), String)
                            Id2 = DirectCast(row2.GetCellValue("Flota"), String)
                            If Id1 = Id2 Then band = True
                        End If
                    Case "CodigoMat"
                        IdEq1 = DirectCast(row1.GetCellValue("Equipo"), String)
                        IdEq2 = DirectCast(row2.GetCellValue("Equipo"), String)
                        If IdEq1 = IdEq2 Then
                            Id1 = DirectCast(row1.GetCellValue("CodigoMat"), String)
                            Id2 = DirectCast(row2.GetCellValue("CodigoMat"), String)
                            If Id1 = Id2 Then band = True
                        End If
                    Case "Material"
                        IdEq1 = DirectCast(row1.GetCellValue("Equipo"), String)
                        IdEq2 = DirectCast(row2.GetCellValue("Equipo"), String)
                        If IdEq1 = IdEq2 Then
                            Id1 = DirectCast(row1.GetCellValue("Material"), String)
                            Id2 = DirectCast(row2.GetCellValue("Material"), String)
                            If Id1 = Id2 Then band = True
                        End If
                    Case "NroOT"
                        IdEq1 = DirectCast(row1.GetCellValue("Equipo"), String)
                        IdEq2 = DirectCast(row2.GetCellValue("Equipo"), String)
                        If IdEq1 = IdEq2 Then
                            Id1 = DirectCast(row1.GetCellValue("NroOT"), String)
                            Id2 = DirectCast(row2.GetCellValue("NroOT"), String)
                            If Id1 = Id2 Then band = True
                        End If
                    Case "KmOT"
                        IdEq1 = DirectCast(row1.GetCellValue("NroOT"), String)
                        IdEq2 = DirectCast(row2.GetCellValue("NroOT"), String)
                        If IdEq1 = IdEq2 Then
                            Id1 = DirectCast(row1.GetCellValue("KmOT"), Double)
                            Id2 = DirectCast(row2.GetCellValue("KmOT"), Double)
                            If Id1 = Id2 Then band = True
                        End If
                    Case "FechaProgramacion"
                        IdEq1 = DirectCast(row1.GetCellValue("NroOT"), String)
                        IdEq2 = DirectCast(row2.GetCellValue("NroOT"), String)
                        If IdEq1 = IdEq2 Then
                            Fecha1 = DirectCast(row1.GetCellValue("FechaProgramacion"), Date)
                            Fecha2 = DirectCast(row2.GetCellValue("FechaProgramacion"), Date)
                            If Fecha1 = Fecha2 Then band = True
                        End If
                    Case "FechaInicioTrabajo"
                        IdEq1 = DirectCast(row1.GetCellValue("NroOT"), String)
                        IdEq2 = DirectCast(row2.GetCellValue("NroOT"), String)
                        If IdEq1 = IdEq2 Then
                            Fecha1 = DirectCast(row1.GetCellValue("FechaInicioTrabajo"), Date)
                            Fecha2 = DirectCast(row2.GetCellValue("FechaInicioTrabajo"), Date)
                            If Fecha1 = Fecha2 Then band = True
                        End If
                    Case "FechaPedido"
                        IdEq1 = DirectCast(row1.GetCellValue("NroOT"), String)
                        IdEq2 = DirectCast(row2.GetCellValue("NroOT"), String)
                        If IdEq1 = IdEq2 Then
                            Fecha1 = DirectCast(row1.GetCellValue("FechaPedido"), Date)
                            Fecha2 = DirectCast(row2.GetCellValue("FechaPedido"), Date)
                            If Fecha1 = Fecha2 Then band = True
                        End If
                    Case "Estado"
                        IdEq1 = DirectCast(row1.GetCellValue("NroOT"), String)
                        IdEq2 = DirectCast(row2.GetCellValue("NroOT"), String)
                        If IdEq1 = IdEq2 Then
                            Id1 = DirectCast(row1.GetCellValue("Estado"), String)
                            Id2 = DirectCast(row2.GetCellValue("Estado"), String)
                            If Id1 = Id2 Then band = True
                        End If
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

    Private Shared instancia As frm_ReporteOrdenesTrabajoMaterial = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteOrdenesTrabajoMaterial()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeReporteOTM As New e_ReporteOTMaterial, olReporteOTM As New l_OrdenTrabajoMaterial
    Private leReporteOTM As New List(Of e_ReporteOTMaterial), leGrafico As New List(Of e_ReporteOTMaterial)
    Private oeMaterial As New e_Material, olMaterial As New l_Material, leMaterial As New List(Of e_Material)
    Private oeEquipo As New e_Equipo, olEquipo As New l_Equipo, leEquipo As New List(Of e_Equipo)
    Private oeMarca As New e_Marca, olMarca As New l_Marca, leMarca As New List(Of e_Marca)
    Private oeTipoMantenimiento As New e_TipoMantenimiento, olTipoMantenimiento As New l_TipoMantenimiento, leTipoMantenimiento As New List(Of e_TipoMantenimiento)
    Private oeMantenimiento As New e_Mantenimiento, olMantenimiento As New l_Mantenimiento, leMantenimiento As New List(Of e_Mantenimiento)
    Private IdMaterial, IdEquipo, IdMarca, IdTipoMantenimiento, IdMantenimiento As String
    Private dt As New DataTable
    Private bandTipoMant, bandMant, bandEquipo, bandMaterial As Boolean

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeReporteOTM = New e_ReporteOTMaterial
            ValidarFechaDesde_Hasta(fecDesde, fecHasta)
            oeReporteOTM.TipoOperacion = String.Empty
            oeReporteOTM.FechaInicio = fecDesde.Value.Date
            oeReporteOTM.FechaFin = fecHasta.Value.Date
            CargarFiltros()
            oeReporteOTM.IdTipoMantenimiento = IdTipoMantenimiento
            oeReporteOTM.IdMantenimiento = IdMantenimiento
            oeReporteOTM.IdMaterial = IdMaterial
            oeReporteOTM.Tipo = IIf(cbOTGold.Checked, 2, 1)
            'oeReporteOTM.IdMarca = IdMarca
            oeReporteOTM.IdEquipo = IdEquipo
            leReporteOTM = olReporteOTM.ListarReporte(oeReporteOTM)
            CargarReporteOTMaterial(leReporteOTM)
            If griReporteOTMaterial.Rows.Count > 0 Then
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
            Exportar_Excel(griReporteOTMaterial)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteOrdenesTrabajoMaterial_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If griReporteOTMaterial.Rows.Count > 0 Then
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Else
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ReporteOrdenesTrabajoMaterial_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteOrdenesTrabajoMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            fecHasta.Value = Date.Now.Date
            fecDesde.Value = DateAdd(DateInterval.Day, -7, Date.Now.Date)
            CargarCombos()
            leReporteOTM = New List(Of e_ReporteOTMaterial)
            CargarReporteOTMaterial(leReporteOTM)
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            ficDatos.Tabs(1).Enabled = False
            fecDesde.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTipoMantenimiento_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTipoMantenimiento.CellChange
        griTipoMantenimiento.UpdateData()
    End Sub

    Private Sub griMantenimiento_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMantenimiento.CellChange
        griMantenimiento.UpdateData()
    End Sub

    Private Sub griEquipo_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griEquipo.CellChange
        griEquipo.UpdateData()
    End Sub

    Private Sub griMaterial_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMaterial.CellChange
        griMaterial.UpdateData()
    End Sub

    Private Sub griTipoMantenimiento_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griTipoMantenimiento.AfterHeaderCheckStateChanged
        griTipoMantenimiento.UpdateData()
        Dim chkTipoMant As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandTipoMant = IIf(chkTipoMant.ToString = "Checked", False, True)
    End Sub

    Private Sub griMantenimiento_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griMantenimiento.AfterHeaderCheckStateChanged
        griMantenimiento.UpdateData()
        Dim chkMant As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandMant = IIf(chkMant.ToString = "Checked", False, True)
    End Sub

    Private Sub griEquipo_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griEquipo.AfterHeaderCheckStateChanged
        griEquipo.UpdateData()
        Dim chkEquipo As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandEquipo = IIf(chkEquipo.ToString = "Checked", False, True)
    End Sub

    Private Sub griMaterial_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griMaterial.AfterHeaderCheckStateChanged
        griMaterial.UpdateData()
        Dim chkMaterial As CheckState = e.Column.GetHeaderCheckedState(e.Rows)
        bandMaterial = IIf(chkMaterial.ToString = "Checked", False, True)
    End Sub

    Private Sub griReporteOTMaterial_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griReporteOTMaterial.InitializeLayout
        e.Layout.Bands(0).Columns("TipoMantenimiento").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Mantenimiento").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Equipo").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("TipoVehiculo").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Flota").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("NroOT").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("FechaProgramacion").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("FechaInicioTrabajo").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("FechaPedido").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Estado").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("CodigoMat").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Material").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("KmOT").MergedCellStyle = MergedCellStyle.Always
        For Each col As UltraGridColumn In griReporteOTMaterial.DisplayLayout.Bands(0).Columns
            If col.Key <> "IdTipoMant" Then e.Layout.Bands(0).Columns(col.Key).MergedCellEvaluator = New CustomMergedCellEvaluator()
        Next
    End Sub

    Private Sub frm_ReporteOrdenesTrabajoMaterial_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()

        Try

            oeMaterial = New e_Material
            olMaterial = New l_Material
            oeMaterial.TipoOperacion = "G"
            oeMaterial.Activo = True
            leMaterial = olMaterial.Listar(oeMaterial)
            CargarMaterial(leMaterial)

            oeEquipo = New e_Equipo
            oeEquipo.TipoOperacion = String.Empty
            oeEquipo.Activo = True
            leEquipo = olEquipo.Listar(oeEquipo)
            CargarEquipo(leEquipo)

            oeTipoMantenimiento = New e_TipoMantenimiento
            oeTipoMantenimiento.TipoOperacion = String.Empty
            oeTipoMantenimiento.Activo = True
            leTipoMantenimiento = olTipoMantenimiento.Listar(oeTipoMantenimiento)
            CargarTipoMantenimiento(leTipoMantenimiento)

            oeMantenimiento = New e_Mantenimiento
            oeMantenimiento.TipoOperacion = String.Empty
            oeMantenimiento.Activo = True
            leMantenimiento = olMantenimiento.Listar(oeMantenimiento)
            CargarMantenimiento(leMantenimiento)

            'cboFila.Items.Clear()
            'cboFila.Items.Add(0, "TipoMantenimiento")
            'cboFila.Items.Add(1, "Mantenimiento")
            'cboFila.Items.Add(2, "Servicio")
            'cboFila.Items.Add(3, "Marca")
            'cboFila.Items.Add(4, "Placa")
            'cboFila.Items.Add(5, "Proveedor")
            'cboFila.SelectedIndex = 0

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarMaterial(ByVal leMat As List(Of e_Material))
        Try
            With griMaterial
                .DataSource = leMat
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

    'Private Sub CargarMarca(ByVal leMarc As List(Of e_Marca))
    '    Try
    '        With griMarca
    '            .ResetDisplayLayout()
    '            .DataSource = leMarc
    '            .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
    '            .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
    '            .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
    '            .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
    '            .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
    '            .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Right
    '            .DisplayLayout.Bands(0).Columns("Selec").Width = 50
    '            For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
    '                If Col.Key = "Codigo" Or Col.Key = "Nombre" Or Col.Key = "Selec" Then
    '                    Col.Hidden = False
    '                    If Col.Key = "Selec" Then
    '                        Col.CellClickAction = CellClickAction.Edit
    '                    Else
    '                        Col.CellClickAction = CellClickAction.RowSelect
    '                    End If
    '                Else
    '                    Col.Hidden = True
    '                End If
    '            Next
    '            .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
    '            .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
    '            .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
    '            .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
    '            .DisplayLayout.Override.FilterUIProvider = Filtro1
    '            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
    '            .DisplayLayout.MaxColScrollRegions = 1
    '            .DisplayLayout.MaxRowScrollRegions = 1
    '        End With
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

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

    Private Sub CargarReporteOTMaterial(ByVal leReportOTM As List(Of e_ReporteOTMaterial))
        With griReporteOTMaterial
            .DataSource = leReportOTM

            .DisplayLayout.Bands(0).Columns("IdTipoMant").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdMat").Hidden = True

            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Mantenimiento").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Equipo").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("TipoVehiculo").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Flota").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("NroOT").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("FechaProgramacion").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("FechaInicioTrabajo").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("FechaPedido").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Estado").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("CodigoMat").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("Material").CellAppearance.TextVAlign = VAlign.Middle
            .DisplayLayout.Bands(0).Columns("KmOT").CellAppearance.TextVAlign = VAlign.Middle

            .DisplayLayout.Bands(0).Columns("KmOT").Format = "#,###,###,####0.00"

            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").Width = 75
            .DisplayLayout.Bands(0).Columns("TipoVehiculo").Width = 120
            .DisplayLayout.Bands(0).Columns("Mantenimiento").Width = 180
            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Width = 55
            .DisplayLayout.Bands(0).Columns("FechaInicioTrabajo").Width = 55
            .DisplayLayout.Bands(0).Columns("Equipo").Width = 55
            .DisplayLayout.Bands(0).Columns("CodigoMat").Width = 55
            .DisplayLayout.Bands(0).Columns("Material").Width = 230

            .DisplayLayout.Bands(0).Columns("FechaProgramacion").Header.Caption = "Fecha Prog."
            .DisplayLayout.Bands(0).Columns("FechaInicioTrabajo").Header.Caption = "Fecha Inicio"
            .DisplayLayout.Bands(0).Columns("TipoMantenimiento").Header.Caption = "Tipo Mant."
            .DisplayLayout.Bands(0).Columns("CantidadMat").Header.Caption = "Cant. Pedido"
            .DisplayLayout.Bands(0).Columns("CantidadReal").Header.Caption = "Cant. Entregado"

            .DisplayLayout.Bands(0).Columns("CantidadMat").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("CantidadReal").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("KmOT").Style = ColumnStyle.Double

            .DisplayLayout.Bands(0).Columns("CantidadMat").CellAppearance.TextHAlign = HAlign.Right
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").CellAppearance.TextHAlign = HAlign.Right
            .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right
            .DisplayLayout.Bands(0).Columns("CantidadReal").CellAppearance.TextHAlign = HAlign.Right
            .DisplayLayout.Bands(0).Columns("KmOT").CellAppearance.TextHAlign = HAlign.Right

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
        CalcularTotales(griReporteOTMaterial, "Importe")
    End Sub

    Private Sub CargarFiltros()
        IdTipoMantenimiento = ""
        If bandTipoMant Then
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
        IdMaterial = ""
        If bandMaterial Then
            For Each Fila In griMaterial.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Seleccion").Value = True)
                IdMaterial = IdMaterial & "'" & Fila.Cells("Id").Value & "',"
            Next
            If IdMaterial.Trim <> "" Then IdMaterial = IdMaterial.Substring(0, IdMaterial.Length - 1)
        End If
        IdEquipo = ""
        If bandEquipo Then
            For Each Fila In griEquipo.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Selec").Value = True)
                IdEquipo = IdEquipo & "'" & Fila.Cells("Id").Value & "',"
            Next
            If IdEquipo.Trim <> "" Then IdEquipo = IdEquipo.Substring(0, IdEquipo.Length - 1)
        End If
    End Sub

    Private Sub GeneraGrafico()
        Try
            CapturaDatos()
            dt = New Data.DataTable
            dt.Columns.Add("UnidadAsignada", System.Type.GetType("System.String"))
            dt.Columns.Add("Costo", System.Type.GetType("System.Decimal"))
            LlenarDatos()
            'graServicio.Axis.Y.NumericAxisType = 
            graMaterial.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:#,###,##0.00>"
            graMaterial.Axis.Y.RangeMin = 0

            'graMaterial.Axis.X.ScrollScale.Visible = True
            graMaterial.Axis.X.ScrollScale.Height = 10
            graMaterial.Axis.X.ScrollScale.Width = 10
            graMaterial.Axis.X.ScrollScale.Scale() = 0.5

            'graMaterial.Axis.X.Labels = 

            graMaterial.Tooltips.Font = New Font("Arial", 10, FontStyle.Regular)
            graMaterial.Tooltips.Format = TooltipStyle.LabelPlusDataValue
            graMaterial.Tooltips.FormatString = "<ITEM_LABEL>: S/. <DATA_VALUE:#,###,##0.00>"

            graMaterial.Data.ZeroAligned = True
            graMaterial.Data.DataSource = dt
            graMaterial.ChartType = ChartType.ColumnChart
            graMaterial.Data.DataBind()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarDatos()
        For Each oerep In leGrafico.OrderByDescending(Function(item) item.Importe).ToList
            dt.Rows.Add(oerep.Flota, oerep.Importe)
        Next
    End Sub

    Private Sub CapturaDatos()
        Dim id As String = String.Empty
        Dim leObjetoAux As New List(Of e_ReporteOTMaterial)
        leGrafico = New List(Of e_ReporteOTMaterial)
        leObjetoAux = leReporteOTM.OrderBy(Function(item) item.Flota).ToList
        For Each oeMant In leObjetoAux
            If id <> oeMant.Flota Then
                id = oeMant.Flota
                oeReporteOTM = New e_ReporteOTMaterial
                oeReporteOTM.Flota = oeMant.Flota
                oeReporteOTM.Importe = leObjetoAux.Where(Function(item) item.Flota = id).Sum(Function(item) item.Importe)
                leGrafico.Add(oeReporteOTM)
            End If
        Next
    End Sub

#End Region

End Class