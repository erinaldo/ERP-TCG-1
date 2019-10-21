<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteOrdenesTrabajoMaterial
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTipoMantenimiento = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griMantenimiento = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griEquipo = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griMaterial = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griReporteOTMaterial = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.graMaterial = New ISL.Controles.Grafico(Me.components)
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Ficha2 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficDatos = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.cbOTGold = New System.Windows.Forms.CheckBox()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griTipoMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griReporteOTMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.graMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.Ficha2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha2.SuspendLayout()
        CType(Me.ficDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griTipoMantenimiento)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(551, 141)
        '
        'griTipoMantenimiento
        '
        Me.griTipoMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTipoMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTipoMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.griTipoMantenimiento.Name = "griTipoMantenimiento"
        Me.griTipoMantenimiento.Size = New System.Drawing.Size(551, 141)
        Me.griTipoMantenimiento.TabIndex = 0
        Me.griTipoMantenimiento.TabStop = False
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griMantenimiento)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(551, 141)
        '
        'griMantenimiento
        '
        Me.griMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.griMantenimiento.Name = "griMantenimiento"
        Me.griMantenimiento.Size = New System.Drawing.Size(551, 141)
        Me.griMantenimiento.TabIndex = 0
        Me.griMantenimiento.TabStop = False
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griEquipo)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(551, 141)
        '
        'griEquipo
        '
        Me.griEquipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griEquipo.Location = New System.Drawing.Point(0, 0)
        Me.griEquipo.Name = "griEquipo"
        Me.griEquipo.Size = New System.Drawing.Size(551, 141)
        Me.griEquipo.TabIndex = 0
        Me.griEquipo.TabStop = False
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griMaterial)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(551, 141)
        '
        'griMaterial
        '
        Me.griMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMaterial.Location = New System.Drawing.Point(0, 0)
        Me.griMaterial.Name = "griMaterial"
        Me.griMaterial.Size = New System.Drawing.Size(551, 141)
        Me.griMaterial.TabIndex = 0
        Me.griMaterial.TabStop = False
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griReporteOTMaterial)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(842, 315)
        '
        'griReporteOTMaterial
        '
        Me.griReporteOTMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griReporteOTMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griReporteOTMaterial.Location = New System.Drawing.Point(0, 0)
        Me.griReporteOTMaterial.Name = "griReporteOTMaterial"
        Me.griReporteOTMaterial.Size = New System.Drawing.Size(842, 315)
        Me.griReporteOTMaterial.TabIndex = 0
        Me.griReporteOTMaterial.TabStop = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.graMaterial)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(842, 315)
        '
        'graMaterial
        '
        Me.graMaterial.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement1.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement1.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.graMaterial.Axis.PE = PaintElement1
        Me.graMaterial.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graMaterial.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graMaterial.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graMaterial.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMaterial.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMaterial.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.X.MajorGridLines.Visible = True
        Me.graMaterial.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMaterial.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.X.MinorGridLines.Visible = False
        Me.graMaterial.Axis.X.Visible = True
        Me.graMaterial.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graMaterial.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graMaterial.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graMaterial.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMaterial.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.X2.Labels.Visible = False
        Me.graMaterial.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMaterial.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.X2.MajorGridLines.Visible = True
        Me.graMaterial.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMaterial.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.X2.MinorGridLines.Visible = False
        Me.graMaterial.Axis.X2.Visible = False
        Me.graMaterial.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graMaterial.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graMaterial.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMaterial.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graMaterial.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMaterial.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.Y.MajorGridLines.Visible = True
        Me.graMaterial.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMaterial.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.Y.MinorGridLines.Visible = False
        Me.graMaterial.Axis.Y.Visible = True
        Me.graMaterial.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graMaterial.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graMaterial.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMaterial.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graMaterial.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Y2.Labels.Visible = False
        Me.graMaterial.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMaterial.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.Y2.MajorGridLines.Visible = True
        Me.graMaterial.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMaterial.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.Y2.MinorGridLines.Visible = False
        Me.graMaterial.Axis.Y2.Visible = False
        Me.graMaterial.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graMaterial.Axis.Z.Labels.ItemFormatString = ""
        Me.graMaterial.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMaterial.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMaterial.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMaterial.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.Z.MajorGridLines.Visible = True
        Me.graMaterial.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMaterial.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.Z.MinorGridLines.Visible = False
        Me.graMaterial.Axis.Z.Visible = False
        Me.graMaterial.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graMaterial.Axis.Z2.Labels.ItemFormatString = ""
        Me.graMaterial.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMaterial.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graMaterial.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graMaterial.Axis.Z2.Labels.Visible = False
        Me.graMaterial.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graMaterial.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.Z2.MajorGridLines.Visible = True
        Me.graMaterial.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graMaterial.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graMaterial.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graMaterial.Axis.Z2.MinorGridLines.Visible = False
        Me.graMaterial.Axis.Z2.Visible = False
        Me.graMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.graMaterial.ColorModel.AlphaLevel = CType(150, Byte)
        Me.graMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graMaterial.Location = New System.Drawing.Point(0, 0)
        Me.graMaterial.Name = "graMaterial"
        Me.graMaterial.Size = New System.Drawing.Size(842, 315)
        Me.graMaterial.TabIndex = 2
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.ExpandedSize = New System.Drawing.Size(844, 200)
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(844, 200)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.TabStop = False
        Me.agrBusqueda.Text = "Datos de Búsqueda:"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cbOTGold)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Ficha2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.fecHasta)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.fecDesde)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta1)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(838, 177)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'Ficha2
        '
        Me.Ficha2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.Ficha2.Controls.Add(Me.UltraTabPageControl3)
        Me.Ficha2.Controls.Add(Me.UltraTabPageControl4)
        Me.Ficha2.Controls.Add(Me.UltraTabPageControl5)
        Me.Ficha2.Controls.Add(Me.UltraTabPageControl6)
        Me.Ficha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha2.Location = New System.Drawing.Point(150, 8)
        Me.Ficha2.Name = "Ficha2"
        Me.Ficha2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.Ficha2.Size = New System.Drawing.Size(553, 164)
        Me.Ficha2.TabIndex = 4
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "TipoMantenimiento"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Mantenimiento"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Equipo"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Material"
        Me.Ficha2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab5, UltraTab6})
        Me.Ficha2.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(551, 141)
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(52, 34)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(92, 21)
        Me.fecHasta.TabIndex = 3
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(52, 8)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(92, 21)
        Me.fecDesde.TabIndex = 1
        '
        'Etiqueta2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance1
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(10, 36)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Hasta:"
        '
        'Etiqueta1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance2
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(7, 11)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Desde:"
        '
        'ficDatos
        '
        Me.ficDatos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDatos.Controls.Add(Me.UltraTabPageControl1)
        Me.ficDatos.Controls.Add(Me.UltraTabPageControl2)
        Me.ficDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDatos.Location = New System.Drawing.Point(0, 200)
        Me.ficDatos.Name = "ficDatos"
        Me.ficDatos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDatos.Size = New System.Drawing.Size(844, 338)
        Me.ficDatos.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista por Orden Trabajo"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Gráfico"
        Me.ficDatos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficDatos.TabStop = False
        Me.ficDatos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(842, 315)
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(224, 235)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 2
        Me.ugb_Espera.Visible = False
        '
        'cbOTGold
        '
        Me.cbOTGold.AutoSize = True
        Me.cbOTGold.BackColor = System.Drawing.Color.Transparent
        Me.cbOTGold.ForeColor = System.Drawing.Color.Navy
        Me.cbOTGold.Location = New System.Drawing.Point(52, 61)
        Me.cbOTGold.Name = "cbOTGold"
        Me.cbOTGold.Size = New System.Drawing.Size(88, 17)
        Me.cbOTGold.TabIndex = 5
        Me.cbOTGold.Text = "OT GoldMack"
        Me.cbOTGold.UseVisualStyleBackColor = False
        '
        'frm_ReporteOrdenesTrabajoMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 538)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficDatos)
        Me.Controls.Add(Me.agrBusqueda)
        Me.Name = "frm_ReporteOrdenesTrabajoMaterial"
        Me.Text = "Reporte Consumo Material"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griTipoMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griReporteOTMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.graMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.Ficha2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha2.ResumeLayout(False)
        CType(Me.ficDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDatos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ficDatos As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griReporteOTMaterial As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Ficha2 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griTipoMantenimiento As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griMantenimiento As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griEquipo As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griMaterial As ISL.Controles.Grilla
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents graMaterial As ISL.Controles.Grafico
    Friend WithEvents cbOTGold As System.Windows.Forms.CheckBox
End Class
