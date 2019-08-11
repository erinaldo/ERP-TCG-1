<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListaIngresosSalidas
    Inherits ISL.Win.frm_MenuPadre

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidad")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorUnitario")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidad")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Unidad")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Unidad")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorUnitario")
        Dim PaintElement1 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement()
        Dim PieChartAppearance1 As Infragistics.UltraChart.Resources.Appearance.PieChartAppearance = New Infragistics.UltraChart.Resources.Appearance.PieChartAppearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griIS = New ISL.Controles.Grilla(Me.components)
        Me.mcDetalle = New ISL.Controles.MenuContextual(Me.components)
        Me.GraficoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odIS = New ISL.Controles.OrigenDatos(Me.components)
        Me.UE_Grafico = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.agr_Grafico = New ISL.Controles.Agrupacion(Me.components)
        Me.graDatos = New ISL.Controles.Grafico(Me.components)
        Me.agrupacion = New ISL.Controles.Agrupacion(Me.components)
        Me.MesesFin = New ISL.Win.Meses()
        Me.MesesInicio = New ISL.Win.Meses()
        Me.etifechaTipo = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.chk_Rango = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Anio = New ISL.Win.Año()
        Me.cboAlmacen = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipo = New ISL.Controles.ComboMaestros(Me.components)
        Me.ficIngresosSalidas = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcDetalle.SuspendLayout()
        CType(Me.odIS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UE_Grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UE_Grafico.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.agr_Grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agr_Grafico.SuspendLayout()
        CType(Me.graDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrupacion.SuspendLayout()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_Rango, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficIngresosSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficIngresosSalidas.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Controls.Add(Me.agrupacion)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(961, 596)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.griIS)
        Me.Agrupacion1.Controls.Add(Me.UE_Grafico)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 77)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(961, 519)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griIS
        '
        Me.griIS.ContextMenuStrip = Me.mcDetalle
        Me.griIS.DataSource = Me.odIS
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Codigo / Nº Orden"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 108
        UltraGridColumn3.Header.Caption = "Material / Proveedor"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 182
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.Caption = "Uni. Med."
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.Caption = "Fecha"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.Caption = "Valor Unit."
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Width = 89
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Width = 182
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn14.Header.VisiblePosition = 5
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        UltraGridBand2.Header.Caption = ""
        Me.griIS.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griIS.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griIS.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griIS.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Me.griIS.DisplayLayout.Override.CellAppearance = Appearance1
        Me.griIS.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griIS.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griIS.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griIS.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griIS.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance2.BorderColor = System.Drawing.Color.Silver
        Me.griIS.DisplayLayout.Override.RowAppearance = Appearance2
        Me.griIS.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griIS.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griIS.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griIS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griIS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griIS.Location = New System.Drawing.Point(2, 2)
        Me.griIS.Name = "griIS"
        Me.griIS.Size = New System.Drawing.Size(957, 489)
        Me.griIS.TabIndex = 0
        Me.griIS.Text = "Listado Ingresos / Salidas"
        '
        'mcDetalle
        '
        Me.mcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcDetalle.ForeColor = System.Drawing.Color.Black
        Me.mcDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GraficoToolStripMenuItem})
        Me.mcDetalle.Name = "MenuContextual1"
        Me.mcDetalle.Size = New System.Drawing.Size(128, 26)
        '
        'GraficoToolStripMenuItem
        '
        Me.GraficoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.lupa
        Me.GraficoToolStripMenuItem.Name = "GraficoToolStripMenuItem"
        Me.GraficoToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.GraficoToolStripMenuItem.Text = "Ver Grafico"
        '
        'odIS
        '
        Me.odIS.AllowAdd = False
        Me.odIS.AllowDelete = False
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        Me.odIS.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        Me.odIS.Band.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'UE_Grafico
        '
        Me.UE_Grafico.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UE_Grafico.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UE_Grafico.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UE_Grafico.Expanded = False
        Me.UE_Grafico.ExpandedSize = New System.Drawing.Size(957, 340)
        Me.UE_Grafico.Location = New System.Drawing.Point(2, 491)
        Me.UE_Grafico.Name = "UE_Grafico"
        Me.UE_Grafico.Size = New System.Drawing.Size(957, 26)
        Me.UE_Grafico.TabIndex = 7
        Me.UE_Grafico.Text = "Grafico"
        Me.UE_Grafico.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.agr_Grafico)
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(953, 316)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel2.Visible = False
        '
        'agr_Grafico
        '
        Me.agr_Grafico.Controls.Add(Me.graDatos)
        Me.agr_Grafico.Dock = System.Windows.Forms.DockStyle.Left
        Me.agr_Grafico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agr_Grafico.ForeColor = System.Drawing.Color.Black
        Me.agr_Grafico.Location = New System.Drawing.Point(0, 0)
        Me.agr_Grafico.Name = "agr_Grafico"
        Me.agr_Grafico.Size = New System.Drawing.Size(622, 316)
        Me.agr_Grafico.TabIndex = 1
        Me.agr_Grafico.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        '			'Grafico' properties's serialization: Since 'ChartType' changes the way axes look,
        '			'ChartType' must be persisted ahead of any Axes change made in design time.
        '		
        Me.graDatos.ChartType = Infragistics.UltraChart.[Shared].Styles.ChartType.PieChart3D
        '
        'graDatos
        '
        Me.graDatos.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        PaintElement1.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement1.Fill = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.graDatos.Axis.PE = PaintElement1
        Me.graDatos.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graDatos.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graDatos.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.X.Labels.SeriesLabels.FormatString = ""
        Me.graDatos.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graDatos.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graDatos.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.X.MajorGridLines.Visible = True
        Me.graDatos.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graDatos.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.X.MinorGridLines.Visible = False
        Me.graDatos.Axis.X.Visible = False
        Me.graDatos.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graDatos.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graDatos.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.X2.Labels.SeriesLabels.FormatString = ""
        Me.graDatos.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graDatos.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.X2.Labels.Visible = False
        Me.graDatos.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graDatos.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.X2.MajorGridLines.Visible = True
        Me.graDatos.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graDatos.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.X2.MinorGridLines.Visible = False
        Me.graDatos.Axis.X2.Visible = False
        Me.graDatos.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graDatos.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graDatos.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.Y.Labels.SeriesLabels.FormatString = ""
        Me.graDatos.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graDatos.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graDatos.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.Y.MajorGridLines.Visible = True
        Me.graDatos.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graDatos.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.Y.MinorGridLines.Visible = False
        Me.graDatos.Axis.Y.Visible = False
        Me.graDatos.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graDatos.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graDatos.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.Y2.Labels.SeriesLabels.FormatString = ""
        Me.graDatos.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graDatos.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.Y2.Labels.Visible = False
        Me.graDatos.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graDatos.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.Y2.MajorGridLines.Visible = True
        Me.graDatos.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graDatos.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.Y2.MinorGridLines.Visible = False
        Me.graDatos.Axis.Y2.Visible = False
        Me.graDatos.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graDatos.Axis.Z.Labels.ItemFormatString = ""
        Me.graDatos.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graDatos.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graDatos.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.Z.MajorGridLines.Visible = True
        Me.graDatos.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graDatos.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.Z.MinorGridLines.Visible = False
        Me.graDatos.Axis.Z.Visible = False
        Me.graDatos.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graDatos.Axis.Z2.Labels.ItemFormatString = ""
        Me.graDatos.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graDatos.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graDatos.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graDatos.Axis.Z2.Labels.Visible = False
        Me.graDatos.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graDatos.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.Z2.MajorGridLines.Visible = True
        Me.graDatos.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graDatos.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graDatos.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graDatos.Axis.Z2.MinorGridLines.Visible = False
        Me.graDatos.Axis.Z2.Visible = False
        Me.graDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.graDatos.ColorModel.AlphaLevel = CType(255, Byte)
        Me.graDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graDatos.Location = New System.Drawing.Point(3, 3)
        Me.graDatos.Name = "graDatos"
        PieChartAppearance1.Labels.FormatString = "<ITEM_LABEL> : <DATA_VALUE:#0.00>"
        Me.graDatos.PieChart3D = PieChartAppearance1
        Me.graDatos.Size = New System.Drawing.Size(616, 310)
        Me.graDatos.TabIndex = 1
        '
        'agrupacion
        '
        Me.agrupacion.Controls.Add(Me.MesesFin)
        Me.agrupacion.Controls.Add(Me.MesesInicio)
        Me.agrupacion.Controls.Add(Me.etifechaTipo)
        Me.agrupacion.Controls.Add(Me.Etiqueta4)
        Me.agrupacion.Controls.Add(Me.cboCentro)
        Me.agrupacion.Controls.Add(Me.chk_Rango)
        Me.agrupacion.Controls.Add(Me.Etiqueta2)
        Me.agrupacion.Controls.Add(Me.Anio)
        Me.agrupacion.Controls.Add(Me.cboAlmacen)
        Me.agrupacion.Controls.Add(Me.Etiqueta3)
        Me.agrupacion.Controls.Add(Me.Etiqueta1)
        Me.agrupacion.Controls.Add(Me.cboTipo)
        Me.agrupacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrupacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrupacion.Location = New System.Drawing.Point(0, 0)
        Me.agrupacion.Name = "agrupacion"
        Me.agrupacion.Size = New System.Drawing.Size(961, 77)
        Me.agrupacion.TabIndex = 0
        Me.agrupacion.Text = "Filtros"
        Me.agrupacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'MesesFin
        '
        Me.MesesFin.BackColor = System.Drawing.Color.Transparent
        Me.MesesFin.Id = Nothing
        Me.MesesFin.Location = New System.Drawing.Point(600, 48)
        Me.MesesFin.Name = "MesesFin"
        Me.MesesFin.Nombre = Nothing
        Me.MesesFin.Size = New System.Drawing.Size(130, 22)
        Me.MesesFin.TabIndex = 11
        Me.MesesFin.Texto = ""
        '
        'MesesInicio
        '
        Me.MesesInicio.BackColor = System.Drawing.Color.Transparent
        Me.MesesInicio.Id = Nothing
        Me.MesesInicio.Location = New System.Drawing.Point(439, 49)
        Me.MesesInicio.Name = "MesesInicio"
        Me.MesesInicio.Nombre = Nothing
        Me.MesesInicio.Size = New System.Drawing.Size(128, 22)
        Me.MesesInicio.TabIndex = 9
        Me.MesesInicio.Texto = ""
        '
        'etifechaTipo
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.etifechaTipo.Appearance = Appearance3
        Me.etifechaTipo.AutoSize = True
        Me.etifechaTipo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etifechaTipo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etifechaTipo.Location = New System.Drawing.Point(38, 26)
        Me.etifechaTipo.Name = "etifechaTipo"
        Me.etifechaTipo.Size = New System.Drawing.Size(32, 15)
        Me.etifechaTipo.TabIndex = 0
        Me.etifechaTipo.Text = "Tipo :"
        '
        'Etiqueta4
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance4
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(581, 54)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(13, 15)
        Me.Etiqueta4.TabIndex = 10
        Me.Etiqueta4.Text = "Al"
        '
        'cboCentro
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance5
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(246, 24)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(115, 21)
        Me.cboCentro.TabIndex = 3
        Me.cboCentro.ValueMember = "Id"
        '
        'chk_Rango
        '
        Me.chk_Rango.BackColor = System.Drawing.Color.Transparent
        Me.chk_Rango.BackColorInternal = System.Drawing.Color.Transparent
        Me.chk_Rango.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Rango.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chk_Rango.Location = New System.Drawing.Point(372, 51)
        Me.chk_Rango.Name = "chk_Rango"
        Me.chk_Rango.Size = New System.Drawing.Size(70, 20)
        Me.chk_Rango.TabIndex = 8
        Me.chk_Rango.Text = "Rango de "
        '
        'Etiqueta2
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Appearance = Appearance6
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(197, 26)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Centro :"
        '
        'Anio
        '
        Me.Anio.Año = 2015
        Me.Anio.Location = New System.Drawing.Point(396, 23)
        Me.Anio.Name = "Anio"
        Me.Anio.Size = New System.Drawing.Size(55, 22)
        Me.Anio.TabIndex = 7
        '
        'cboAlmacen
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Appearance = Appearance7
        Me.cboAlmacen.DisplayMember = "Nombre"
        Me.cboAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAlmacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Location = New System.Drawing.Point(72, 49)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(289, 21)
        Me.cboAlmacen.TabIndex = 5
        Me.cboAlmacen.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance8
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(367, 26)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(23, 15)
        Me.Etiqueta3.TabIndex = 6
        Me.Etiqueta3.Text = "Año"
        '
        'Etiqueta1
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Appearance = Appearance9
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(18, 50)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta1.TabIndex = 4
        Me.Etiqueta1.Text = "Almacén :"
        '
        'cboTipo
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.cboTipo.Appearance = Appearance10
        Me.cboTipo.DisplayMember = "Nombre"
        Me.cboTipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.ForeColor = System.Drawing.Color.Black
        Me.cboTipo.Location = New System.Drawing.Point(72, 24)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(109, 21)
        Me.cboTipo.TabIndex = 1
        Me.cboTipo.ValueMember = "Id"
        '
        'ficIngresosSalidas
        '
        Me.ficIngresosSalidas.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficIngresosSalidas.Controls.Add(Me.UltraTabPageControl1)
        Me.ficIngresosSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficIngresosSalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficIngresosSalidas.Location = New System.Drawing.Point(0, 0)
        Me.ficIngresosSalidas.Name = "ficIngresosSalidas"
        Me.ficIngresosSalidas.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficIngresosSalidas.Size = New System.Drawing.Size(963, 619)
        Me.ficIngresosSalidas.TabIndex = 0
        UltraTab5.TabPage = Me.UltraTabPageControl1
        UltraTab5.Text = "Lista"
        Me.ficIngresosSalidas.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5})
        Me.ficIngresosSalidas.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(961, 596)
        '
        'frm_ListaIngresosSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 619)
        Me.Controls.Add(Me.ficIngresosSalidas)
        Me.Name = "frm_ListaIngresosSalidas"
        Me.Text = "Ingresos / Salidas "
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcDetalle.ResumeLayout(False)
        CType(Me.odIS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UE_Grafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UE_Grafico.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.agr_Grafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agr_Grafico.ResumeLayout(False)
        CType(Me.graDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrupacion.ResumeLayout(False)
        Me.agrupacion.PerformLayout()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_Rango, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficIngresosSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficIngresosSalidas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficIngresosSalidas As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrupacion As ISL.Controles.Agrupacion
    Friend WithEvents odIS As ISL.Controles.OrigenDatos
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents griIS As ISL.Controles.Grilla
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents etifechaTipo As ISL.Controles.Etiqueta
    Friend WithEvents cboAlmacen As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents cboTipo As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents chk_Rango As ISL.Controles.Chequear
    Friend WithEvents Anio As ISL.Win.Año
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents UE_Grafico As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents agr_Grafico As ISL.Controles.Agrupacion
    Friend WithEvents MesesFin As ISL.Win.Meses
    Friend WithEvents MesesInicio As ISL.Win.Meses
    Private WithEvents graDatos As ISL.Controles.Grafico
    Friend WithEvents mcDetalle As ISL.Controles.MenuContextual
    Friend WithEvents GraficoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
End Class
