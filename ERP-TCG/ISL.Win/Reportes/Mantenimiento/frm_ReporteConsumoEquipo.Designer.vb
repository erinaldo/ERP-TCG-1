<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteConsumoEquipo
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
        Me.components = New System.ComponentModel.Container
        Dim PaintElement1 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement
        Dim PaintElement2 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement
        Dim PaintElement3 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.graGeneral = New ISL.Controles.Grafico(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.graEquipo = New ISL.Controles.Grafico(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.graMatServ = New ISL.Controles.Grafico(Me.components)
        Me.agrSuperior = New Infragistics.Win.Misc.UltraExpandableGroupBox
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.ficGrafico = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.agrDatosBusqueda = New Infragistics.Win.Misc.UltraExpandableGroupBox
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.optEquipo = New ISL.Controles.Opciones(Me.components)
        Me.griAlmacenes = New ISL.Controles.Grilla(Me.components)
        Me.fecPeriodo = New System.Windows.Forms.DateTimePicker
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCentro = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.griConsumo = New ISL.Controles.Grilla(Me.components)
        Me.griDetalle = New ISL.Controles.Grilla(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.graGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.graEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.graMatServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrSuperior.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.ficGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficGrafico.SuspendLayout()
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBusqueda.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.optEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.griConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.graGeneral)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(454, 246)
        '
        'graGeneral
        '
        Me.graGeneral.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement1.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement1.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.graGeneral.Axis.PE = PaintElement1
        Me.graGeneral.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graGeneral.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graGeneral.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graGeneral.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graGeneral.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graGeneral.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.X.MajorGridLines.Visible = True
        Me.graGeneral.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graGeneral.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.X.MinorGridLines.Visible = False
        Me.graGeneral.Axis.X.Visible = True
        Me.graGeneral.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graGeneral.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graGeneral.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graGeneral.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graGeneral.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.X2.Labels.Visible = False
        Me.graGeneral.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graGeneral.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.X2.MajorGridLines.Visible = True
        Me.graGeneral.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graGeneral.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.X2.MinorGridLines.Visible = False
        Me.graGeneral.Axis.X2.Visible = False
        Me.graGeneral.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graGeneral.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graGeneral.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graGeneral.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graGeneral.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graGeneral.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.Y.MajorGridLines.Visible = True
        Me.graGeneral.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graGeneral.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.Y.MinorGridLines.Visible = False
        Me.graGeneral.Axis.Y.Visible = True
        Me.graGeneral.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graGeneral.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graGeneral.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graGeneral.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graGeneral.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Y2.Labels.Visible = False
        Me.graGeneral.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graGeneral.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.Y2.MajorGridLines.Visible = True
        Me.graGeneral.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graGeneral.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.Y2.MinorGridLines.Visible = False
        Me.graGeneral.Axis.Y2.Visible = False
        Me.graGeneral.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graGeneral.Axis.Z.Labels.ItemFormatString = ""
        Me.graGeneral.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graGeneral.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graGeneral.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graGeneral.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.Z.MajorGridLines.Visible = True
        Me.graGeneral.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graGeneral.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.Z.MinorGridLines.Visible = False
        Me.graGeneral.Axis.Z.Visible = False
        Me.graGeneral.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graGeneral.Axis.Z2.Labels.ItemFormatString = ""
        Me.graGeneral.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graGeneral.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graGeneral.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graGeneral.Axis.Z2.Labels.Visible = False
        Me.graGeneral.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graGeneral.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.Z2.MajorGridLines.Visible = True
        Me.graGeneral.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graGeneral.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graGeneral.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graGeneral.Axis.Z2.MinorGridLines.Visible = False
        Me.graGeneral.Axis.Z2.Visible = False
        Me.graGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.graGeneral.ColorModel.AlphaLevel = CType(150, Byte)
        Me.graGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graGeneral.Location = New System.Drawing.Point(0, 0)
        Me.graGeneral.Name = "graGeneral"
        Me.graGeneral.Size = New System.Drawing.Size(454, 246)
        Me.graGeneral.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.graEquipo)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(454, 246)
        '
        'graEquipo
        '
        Me.graEquipo.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement2.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement2.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.graEquipo.Axis.PE = PaintElement2
        Me.graEquipo.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graEquipo.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graEquipo.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graEquipo.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEquipo.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEquipo.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.X.MajorGridLines.Visible = True
        Me.graEquipo.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEquipo.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.X.MinorGridLines.Visible = False
        Me.graEquipo.Axis.X.Visible = True
        Me.graEquipo.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graEquipo.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graEquipo.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graEquipo.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEquipo.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.X2.Labels.Visible = False
        Me.graEquipo.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEquipo.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.X2.MajorGridLines.Visible = True
        Me.graEquipo.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEquipo.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.X2.MinorGridLines.Visible = False
        Me.graEquipo.Axis.X2.Visible = False
        Me.graEquipo.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graEquipo.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graEquipo.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEquipo.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graEquipo.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEquipo.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.Y.MajorGridLines.Visible = True
        Me.graEquipo.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEquipo.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.Y.MinorGridLines.Visible = False
        Me.graEquipo.Axis.Y.Visible = True
        Me.graEquipo.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graEquipo.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graEquipo.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEquipo.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graEquipo.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Y2.Labels.Visible = False
        Me.graEquipo.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEquipo.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.Y2.MajorGridLines.Visible = True
        Me.graEquipo.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEquipo.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.Y2.MinorGridLines.Visible = False
        Me.graEquipo.Axis.Y2.Visible = False
        Me.graEquipo.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graEquipo.Axis.Z.Labels.ItemFormatString = ""
        Me.graEquipo.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEquipo.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEquipo.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEquipo.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.Z.MajorGridLines.Visible = True
        Me.graEquipo.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEquipo.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.Z.MinorGridLines.Visible = False
        Me.graEquipo.Axis.Z.Visible = False
        Me.graEquipo.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graEquipo.Axis.Z2.Labels.ItemFormatString = ""
        Me.graEquipo.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEquipo.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEquipo.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEquipo.Axis.Z2.Labels.Visible = False
        Me.graEquipo.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEquipo.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.Z2.MajorGridLines.Visible = True
        Me.graEquipo.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEquipo.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEquipo.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEquipo.Axis.Z2.MinorGridLines.Visible = False
        Me.graEquipo.Axis.Z2.Visible = False
        Me.graEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.graEquipo.ColorModel.AlphaLevel = CType(150, Byte)
        Me.graEquipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graEquipo.Location = New System.Drawing.Point(0, 0)
        Me.graEquipo.Name = "graEquipo"
        Me.graEquipo.Size = New System.Drawing.Size(454, 246)
        Me.graEquipo.TabIndex = 0
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.graMatServ)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(454, 246)
        '
        'graMatServ
        '
        Me.graMatServ.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement3.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement3.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.graMatServ.Axis.PE = PaintElement3
        Me.graMatServ.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graMatServ.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graMatServ.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graMatServ.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMatServ.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMatServ.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.X.MajorGridLines.Visible = True
        Me.graMatServ.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMatServ.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.X.MinorGridLines.Visible = False
        Me.graMatServ.Axis.X.Visible = True
        Me.graMatServ.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graMatServ.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graMatServ.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graMatServ.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMatServ.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.X2.Labels.Visible = False
        Me.graMatServ.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMatServ.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.X2.MajorGridLines.Visible = True
        Me.graMatServ.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMatServ.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.X2.MinorGridLines.Visible = False
        Me.graMatServ.Axis.X2.Visible = False
        Me.graMatServ.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graMatServ.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graMatServ.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMatServ.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graMatServ.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMatServ.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.Y.MajorGridLines.Visible = True
        Me.graMatServ.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMatServ.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.Y.MinorGridLines.Visible = False
        Me.graMatServ.Axis.Y.Visible = True
        Me.graMatServ.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graMatServ.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graMatServ.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMatServ.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graMatServ.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Y2.Labels.Visible = False
        Me.graMatServ.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMatServ.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.Y2.MajorGridLines.Visible = True
        Me.graMatServ.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMatServ.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.Y2.MinorGridLines.Visible = False
        Me.graMatServ.Axis.Y2.Visible = False
        Me.graMatServ.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graMatServ.Axis.Z.Labels.ItemFormatString = ""
        Me.graMatServ.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMatServ.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMatServ.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMatServ.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.Z.MajorGridLines.Visible = True
        Me.graMatServ.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMatServ.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.Z.MinorGridLines.Visible = False
        Me.graMatServ.Axis.Z.Visible = False
        Me.graMatServ.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graMatServ.Axis.Z2.Labels.ItemFormatString = ""
        Me.graMatServ.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMatServ.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMatServ.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMatServ.Axis.Z2.Labels.Visible = False
        Me.graMatServ.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMatServ.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.Z2.MajorGridLines.Visible = True
        Me.graMatServ.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMatServ.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMatServ.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMatServ.Axis.Z2.MinorGridLines.Visible = False
        Me.graMatServ.Axis.Z2.Visible = False
        Me.graMatServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.graMatServ.ColorModel.AlphaLevel = CType(150, Byte)
        Me.graMatServ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graMatServ.Location = New System.Drawing.Point(0, 0)
        Me.graMatServ.Name = "graMatServ"
        Me.graMatServ.Size = New System.Drawing.Size(454, 246)
        Me.graMatServ.TabIndex = 0
        '
        'agrSuperior
        '
        Me.agrSuperior.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.agrSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrSuperior.ExpandedSize = New System.Drawing.Size(928, 293)
        Me.agrSuperior.Location = New System.Drawing.Point(0, 0)
        Me.agrSuperior.Name = "agrSuperior"
        Me.agrSuperior.Size = New System.Drawing.Size(928, 293)
        Me.agrSuperior.TabIndex = 0
        Me.agrSuperior.Text = "Filtros / Gráficos"
        Me.agrSuperior.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ficGrafico)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.agrDatosBusqueda)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 22)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(924, 269)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'ficGrafico
        '
        Me.ficGrafico.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficGrafico.Controls.Add(Me.UltraTabPageControl1)
        Me.ficGrafico.Controls.Add(Me.UltraTabPageControl2)
        Me.ficGrafico.Controls.Add(Me.UltraTabPageControl3)
        Me.ficGrafico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficGrafico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficGrafico.Location = New System.Drawing.Point(468, 0)
        Me.ficGrafico.Name = "ficGrafico"
        Me.ficGrafico.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficGrafico.Size = New System.Drawing.Size(456, 269)
        Me.ficGrafico.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Consumo General"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Consumo por Equipo"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Consumo por Material/Servicio"
        Me.ficGrafico.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficGrafico.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(454, 246)
        '
        'agrDatosBusqueda
        '
        Me.agrDatosBusqueda.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Far
        Me.agrDatosBusqueda.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.agrDatosBusqueda.Dock = System.Windows.Forms.DockStyle.Left
        Me.agrDatosBusqueda.ExpandedSize = New System.Drawing.Size(468, 269)
        Me.agrDatosBusqueda.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.agrDatosBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrDatosBusqueda.Name = "agrDatosBusqueda"
        Me.agrDatosBusqueda.Size = New System.Drawing.Size(468, 269)
        Me.agrDatosBusqueda.TabIndex = 0
        Me.agrDatosBusqueda.Text = "Datos de Búsqueda"
        Me.agrDatosBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.optEquipo)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.griAlmacenes)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.fecPeriodo)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta2)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cboCentro)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta1)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(22, 2)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(444, 265)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'optEquipo
        '
        Me.optEquipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optEquipo.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "Todos"
        ValueListItem4.DataValue = "ValueListItem3"
        ValueListItem4.DisplayText = "Vehiculo"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "Trabajador"
        ValueListItem3.DataValue = "ValueListItem2"
        ValueListItem3.DisplayText = "Area"
        Me.optEquipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem4, ValueListItem2, ValueListItem3})
        Me.optEquipo.ItemSpacingHorizontal = 30
        Me.optEquipo.ItemSpacingVertical = 10
        Me.optEquipo.Location = New System.Drawing.Point(14, 216)
        Me.optEquipo.Name = "optEquipo"
        Me.optEquipo.Size = New System.Drawing.Size(410, 28)
        Me.optEquipo.TabIndex = 5
        '
        'griAlmacenes
        '
        Me.griAlmacenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlmacenes.Location = New System.Drawing.Point(14, 34)
        Me.griAlmacenes.Name = "griAlmacenes"
        Me.griAlmacenes.Size = New System.Drawing.Size(410, 176)
        Me.griAlmacenes.TabIndex = 4
        Me.griAlmacenes.Text = "Almacenes"
        '
        'fecPeriodo
        '
        Me.fecPeriodo.CustomFormat = "MMMM/yyyy"
        Me.fecPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecPeriodo.Location = New System.Drawing.Point(288, 7)
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.ShowUpDown = True
        Me.fecPeriodo.Size = New System.Drawing.Size(136, 20)
        Me.fecPeriodo.TabIndex = 3
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(237, 11)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Periodo:"
        '
        'cboCentro
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance1
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(60, 7)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(171, 21)
        Me.cboCentro.TabIndex = 1
        Me.cboCentro.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(14, 11)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Centro:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 293)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.griConsumo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.griDetalle)
        Me.SplitContainer1.Size = New System.Drawing.Size(928, 215)
        Me.SplitContainer1.SplitterDistance = 406
        Me.SplitContainer1.TabIndex = 1
        '
        'griConsumo
        '
        Me.griConsumo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griConsumo.Location = New System.Drawing.Point(0, 0)
        Me.griConsumo.Name = "griConsumo"
        Me.griConsumo.Size = New System.Drawing.Size(406, 215)
        Me.griConsumo.TabIndex = 0
        Me.griConsumo.Text = "Consumo por Equipo"
        '
        'griDetalle
        '
        Me.griDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalle.Location = New System.Drawing.Point(0, 0)
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(518, 215)
        Me.griDetalle.TabIndex = 0
        Me.griDetalle.Text = "Consumo por Ordenes de Trabajo"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_ReporteConsumoEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 508)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.agrSuperior)
        Me.Name = "frm_ReporteConsumoEquipo"
        Me.Text = "Reporte de Consumo por Equipo"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.graGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.graEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.graMatServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrSuperior.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.ficGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficGrafico.ResumeLayout(False)
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBusqueda.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.optEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.griConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrSuperior As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ficGrafico As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatosBusqueda As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cboCentro As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents griDetalle As ISL.Controles.Grilla
    Friend WithEvents griAlmacenes As ISL.Controles.Grilla
    Friend WithEvents fecPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents optEquipo As ISL.Controles.Opciones
    Friend WithEvents griConsumo As ISL.Controles.Grilla
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents graGeneral As ISL.Controles.Grafico
    Friend WithEvents graEquipo As ISL.Controles.Grafico
    Friend WithEvents graMatServ As ISL.Controles.Grafico
End Class
