<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteFondoFijo
    Inherits frm_MenuPadre

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
        Dim PaintElement1 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.agrFondoFijo = New ISL.Controles.Agrupacion(Me.components)
        Me.agrDetalleFondoFijo = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetalle = New ISL.Controles.Grilla(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.graFondoFijo = New ISL.Controles.Grafico(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griMovimientoFondoFijo = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiCajaDiario = New System.Windows.Forms.ToolStripMenuItem()
        Me.agrTotales = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.decIngresos = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decEgresos = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.lblMaximo = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.agrFondoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFondoFijo.SuspendLayout()
        CType(Me.agrDetalleFondoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalleFondoFijo.SuspendLayout()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.graFondoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griMovimientoFondoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.agrTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotales.SuspendLayout()
        CType(Me.decIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'agrFondoFijo
        '
        Me.agrFondoFijo.Controls.Add(Me.agrDetalleFondoFijo)
        Me.agrFondoFijo.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.agrFondoFijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrFondoFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFondoFijo.ForeColor = System.Drawing.Color.Black
        Me.agrFondoFijo.Location = New System.Drawing.Point(0, 0)
        Me.agrFondoFijo.Name = "agrFondoFijo"
        Me.agrFondoFijo.Size = New System.Drawing.Size(1348, 733)
        Me.agrFondoFijo.TabIndex = 0
        Me.agrFondoFijo.Text = "Fondo Fijo"
        Me.agrFondoFijo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'agrDetalleFondoFijo
        '
        Me.agrDetalleFondoFijo.Controls.Add(Me.griDetalle)
        Me.agrDetalleFondoFijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalleFondoFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetalleFondoFijo.ForeColor = System.Drawing.Color.Black
        Me.agrDetalleFondoFijo.Location = New System.Drawing.Point(3, 438)
        Me.agrDetalleFondoFijo.Name = "agrDetalleFondoFijo"
        Me.agrDetalleFondoFijo.Size = New System.Drawing.Size(1342, 292)
        Me.agrDetalleFondoFijo.TabIndex = 1
        Me.agrDetalleFondoFijo.Text = "Detalle Fondo Fijo"
        Me.agrDetalleFondoFijo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetalle
        '
        Me.griDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.griDetalle.Location = New System.Drawing.Point(3, 16)
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(1336, 273)
        Me.griDetalle.TabIndex = 1
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(1342, 422)
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(1342, 422)
        Me.UltraExpandableGroupBox1.TabIndex = 0
        Me.UltraExpandableGroupBox1.Text = "Movimiento Fondo Fijo"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Agrupacion2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Agrupacion1)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 25)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1336, 394)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.graFondoFijo)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(349, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(987, 394)
        Me.Agrupacion2.TabIndex = 9
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        '			'Grafico' properties's serialization: Since 'ChartType' changes the way axes look,
        '			'ChartType' must be persisted ahead of any Axes change made in design time.
        '		
        Me.graFondoFijo.ChartType = Infragistics.UltraChart.[Shared].Styles.ChartType.PieChart3D
        '
        'graFondoFijo
        '
        Me.graFondoFijo.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement1.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement1.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.graFondoFijo.Axis.PE = PaintElement1
        Me.graFondoFijo.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graFondoFijo.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graFondoFijo.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.X.Labels.SeriesLabels.FormatString = ""
        Me.graFondoFijo.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graFondoFijo.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graFondoFijo.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.X.MajorGridLines.Visible = True
        Me.graFondoFijo.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graFondoFijo.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.X.MinorGridLines.Visible = False
        Me.graFondoFijo.Axis.X.Visible = False
        Me.graFondoFijo.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graFondoFijo.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graFondoFijo.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.X2.Labels.SeriesLabels.FormatString = ""
        Me.graFondoFijo.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graFondoFijo.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.X2.Labels.Visible = False
        Me.graFondoFijo.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graFondoFijo.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.X2.MajorGridLines.Visible = True
        Me.graFondoFijo.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graFondoFijo.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.X2.MinorGridLines.Visible = False
        Me.graFondoFijo.Axis.X2.Visible = False
        Me.graFondoFijo.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graFondoFijo.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graFondoFijo.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.Y.Labels.SeriesLabels.FormatString = ""
        Me.graFondoFijo.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graFondoFijo.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graFondoFijo.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.Y.MajorGridLines.Visible = True
        Me.graFondoFijo.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graFondoFijo.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.Y.MinorGridLines.Visible = False
        Me.graFondoFijo.Axis.Y.Visible = False
        Me.graFondoFijo.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graFondoFijo.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graFondoFijo.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.Y2.Labels.SeriesLabels.FormatString = ""
        Me.graFondoFijo.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graFondoFijo.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.Y2.Labels.Visible = False
        Me.graFondoFijo.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graFondoFijo.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.Y2.MajorGridLines.Visible = True
        Me.graFondoFijo.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graFondoFijo.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.Y2.MinorGridLines.Visible = False
        Me.graFondoFijo.Axis.Y2.Visible = False
        Me.graFondoFijo.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graFondoFijo.Axis.Z.Labels.ItemFormatString = ""
        Me.graFondoFijo.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graFondoFijo.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graFondoFijo.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.Z.MajorGridLines.Visible = True
        Me.graFondoFijo.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graFondoFijo.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.Z.MinorGridLines.Visible = False
        Me.graFondoFijo.Axis.Z.Visible = False
        Me.graFondoFijo.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graFondoFijo.Axis.Z2.Labels.ItemFormatString = ""
        Me.graFondoFijo.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graFondoFijo.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graFondoFijo.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graFondoFijo.Axis.Z2.Labels.Visible = False
        Me.graFondoFijo.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graFondoFijo.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.Z2.MajorGridLines.Visible = True
        Me.graFondoFijo.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graFondoFijo.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graFondoFijo.Axis.Z2.MinorGridLines.Visible = False
        Me.graFondoFijo.Axis.Z2.Visible = False
        Me.graFondoFijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.graFondoFijo.ColorModel.AlphaLevel = CType(255, Byte)
        Me.graFondoFijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graFondoFijo.Location = New System.Drawing.Point(2, 2)
        Me.graFondoFijo.Name = "graFondoFijo"
        Me.graFondoFijo.Size = New System.Drawing.Size(983, 390)
        Me.graFondoFijo.TabIndex = 0
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.lblMaximo)
        Me.Agrupacion1.Controls.Add(Me.griMovimientoFondoFijo)
        Me.Agrupacion1.Controls.Add(Me.agrTotales)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(349, 394)
        Me.Agrupacion1.TabIndex = 8
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griMovimientoFondoFijo
        '
        Me.griMovimientoFondoFijo.ContextMenuStrip = Me.MenuContextual1
        Me.griMovimientoFondoFijo.DisplayLayout.MaxColScrollRegions = 1
        Me.griMovimientoFondoFijo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimientoFondoFijo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griMovimientoFondoFijo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMovimientoFondoFijo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMovimientoFondoFijo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMovimientoFondoFijo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMovimientoFondoFijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovimientoFondoFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griMovimientoFondoFijo.Location = New System.Drawing.Point(2, 2)
        Me.griMovimientoFondoFijo.Name = "griMovimientoFondoFijo"
        Me.griMovimientoFondoFijo.Size = New System.Drawing.Size(345, 316)
        Me.griMovimientoFondoFijo.TabIndex = 7
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCajaDiario})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 26)
        '
        'tsmiCajaDiario
        '
        Me.tsmiCajaDiario.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.tsmiCajaDiario.Name = "tsmiCajaDiario"
        Me.tsmiCajaDiario.Size = New System.Drawing.Size(120, 22)
        Me.tsmiCajaDiario.Text = "Ver Diario"
        '
        'agrTotales
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.White
        Me.agrTotales.ContentAreaAppearance = Appearance2
        Me.agrTotales.Controls.Add(Me.Etiqueta3)
        Me.agrTotales.Controls.Add(Me.Etiqueta2)
        Me.agrTotales.Controls.Add(Me.Etiqueta1)
        Me.agrTotales.Controls.Add(Me.decIngresos)
        Me.agrTotales.Controls.Add(Me.decEgresos)
        Me.agrTotales.Controls.Add(Me.decSaldo)
        Me.agrTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.agrTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotales.ForeColor = System.Drawing.Color.Black
        Me.agrTotales.Location = New System.Drawing.Point(2, 318)
        Me.agrTotales.Name = "agrTotales"
        Me.agrTotales.Size = New System.Drawing.Size(345, 74)
        Me.agrTotales.TabIndex = 6
        Me.agrTotales.Text = "Totales"
        Me.agrTotales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance3
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(192, 53)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta3.TabIndex = 1
        Me.Etiqueta3.Text = "Saldo:"
        '
        'Etiqueta2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance4
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(179, 27)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Egresos:"
        '
        'Etiqueta1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance5
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(5, 25)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Ingresos:"
        '
        'decIngresos
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.decIngresos.Appearance = Appearance6
        Me.decIngresos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decIngresos.ForeColor = System.Drawing.Color.Black
        Me.decIngresos.Location = New System.Drawing.Point(57, 21)
        Me.decIngresos.MaskInput = "{double:9.4}"
        Me.decIngresos.Name = "decIngresos"
        Me.decIngresos.NullText = "0.00"
        Me.decIngresos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decIngresos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decIngresos.ReadOnly = True
        Me.decIngresos.Size = New System.Drawing.Size(110, 24)
        Me.decIngresos.TabIndex = 0
        '
        'decEgresos
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.decEgresos.Appearance = Appearance7
        Me.decEgresos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decEgresos.ForeColor = System.Drawing.Color.Black
        Me.decEgresos.Location = New System.Drawing.Point(229, 21)
        Me.decEgresos.MaskInput = "{double:9.4}"
        Me.decEgresos.Name = "decEgresos"
        Me.decEgresos.NullText = "0.00"
        Me.decEgresos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decEgresos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decEgresos.ReadOnly = True
        Me.decEgresos.Size = New System.Drawing.Size(110, 24)
        Me.decEgresos.TabIndex = 0
        '
        'decSaldo
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Appearance = Appearance8
        Me.decSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldo.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Location = New System.Drawing.Point(229, 47)
        Me.decSaldo.MaskInput = "{double:-9.4}"
        Me.decSaldo.Name = "decSaldo"
        Me.decSaldo.NullText = "0.00"
        Me.decSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldo.ReadOnly = True
        Me.decSaldo.Size = New System.Drawing.Size(110, 24)
        Me.decSaldo.TabIndex = 0
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(317, 339)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(394, 68)
        Me.ugb_Espera.TabIndex = 9
        Me.ugb_Espera.Visible = False
        '
        'lblMaximo
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        Me.lblMaximo.Appearance = Appearance1
        Me.lblMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblMaximo.Location = New System.Drawing.Point(3, 292)
        Me.lblMaximo.Name = "lblMaximo"
        Me.lblMaximo.Size = New System.Drawing.Size(344, 24)
        Me.lblMaximo.TabIndex = 1
        Me.lblMaximo.Text = "IMPORTE MÁXIMO EN CAJA GENERAL: S/. 485,000.00"
        '
        'frm_ReporteFondoFijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.agrFondoFijo)
        Me.Name = "frm_ReporteFondoFijo"
        Me.Text = "Reporte Fondo Fijo"
        CType(Me.agrFondoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFondoFijo.ResumeLayout(False)
        CType(Me.agrDetalleFondoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalleFondoFijo.ResumeLayout(False)
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.graFondoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griMovimientoFondoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.agrTotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotales.ResumeLayout(False)
        Me.agrTotales.PerformLayout()
        CType(Me.decIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrFondoFijo As ISL.Controles.Agrupacion
    Friend WithEvents agrDetalleFondoFijo As ISL.Controles.Agrupacion
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiCajaDiario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents griMovimientoFondoFijo As ISL.Controles.Grilla
    Friend WithEvents agrTotales As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents decIngresos As ISL.Controles.NumeroDecimal
    Friend WithEvents decEgresos As ISL.Controles.NumeroDecimal
    Friend WithEvents decSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents graFondoFijo As ISL.Controles.Grafico
    Friend WithEvents griDetalle As ISL.Controles.Grilla
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents lblMaximo As Infragistics.Win.Misc.UltraLabel
End Class
