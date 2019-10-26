<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReportesPlanilla
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
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Espere2 = New ISL.Win.Espere()
        Me.gridReporteFinal = New ISL.Controles.Grilla(Me.components)
        Me.mcPlanilla = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiEnviar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiProvisionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiExportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiImportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlameRem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGenerarBoletas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGenerarAFPnet = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReporteFinal = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridBanco = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griResumen = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griResumenConcepto = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griNuevosIngresos = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griIngresosConceptos = New ISL.Controles.Grilla(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ficPlanilla = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.cboPeriodo = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.gridReporteFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcPlanilla.SuspendLayout()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.gridBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griResumenConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griNuevosIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griIngresosConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficPlanilla.SuspendLayout()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.cboPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Espere2)
        Me.UltraTabPageControl7.Controls.Add(Me.gridReporteFinal)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1130, 345)
        '
        'Espere2
        '
        Me.Espere2.Location = New System.Drawing.Point(367, 138)
        Me.Espere2.Name = "Espere2"
        Me.Espere2.Size = New System.Drawing.Size(397, 68)
        Me.Espere2.TabIndex = 10
        Me.Espere2.Visible = False
        '
        'gridReporteFinal
        '
        Me.gridReporteFinal.ContextMenuStrip = Me.mcPlanilla
        Me.gridReporteFinal.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridReporteFinal.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridReporteFinal.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridReporteFinal.DisplayLayout.MaxColScrollRegions = 1
        Me.gridReporteFinal.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridReporteFinal.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridReporteFinal.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridReporteFinal.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gridReporteFinal.DisplayLayout.Override.CellPadding = 0
        Me.gridReporteFinal.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridReporteFinal.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.gridReporteFinal.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridReporteFinal.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridReporteFinal.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridReporteFinal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridReporteFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridReporteFinal.Location = New System.Drawing.Point(0, 0)
        Me.gridReporteFinal.Name = "gridReporteFinal"
        Me.gridReporteFinal.Size = New System.Drawing.Size(1130, 345)
        Me.gridReporteFinal.TabIndex = 2
        '
        'mcPlanilla
        '
        Me.mcPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcPlanilla.ForeColor = System.Drawing.Color.Black
        Me.mcPlanilla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiEditar, Me.tsmiEliminar, Me.ToolStripSeparator1, Me.tsmiEnviar, Me.tsmiProvisionar, Me.ToolStripSeparator2, Me.tsmiExportar, Me.tsmiImportar, Me.ToolStripSeparator3, Me.PlameRem, Me.tsmiGenerarBoletas, Me.tsmiGenerarAFPnet, Me.tsmiReporteFinal})
        Me.mcPlanilla.Name = "mcPlanilla"
        Me.mcPlanilla.Size = New System.Drawing.Size(153, 264)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(152, 22)
        Me.tsmiNuevo.Text = "Nuevo"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(152, 22)
        Me.tsmiEditar.Text = "Editar"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(152, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'tsmiEnviar
        '
        Me.tsmiEnviar.Image = Global.ISL.Win.My.Resources.Resources.Siguiente
        Me.tsmiEnviar.Name = "tsmiEnviar"
        Me.tsmiEnviar.Size = New System.Drawing.Size(152, 22)
        Me.tsmiEnviar.Text = "Enviar"
        '
        'tsmiProvisionar
        '
        Me.tsmiProvisionar.Name = "tsmiProvisionar"
        Me.tsmiProvisionar.Size = New System.Drawing.Size(152, 22)
        Me.tsmiProvisionar.Text = "Provisionar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'tsmiExportar
        '
        Me.tsmiExportar.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.tsmiExportar.Name = "tsmiExportar"
        Me.tsmiExportar.Size = New System.Drawing.Size(152, 22)
        Me.tsmiExportar.Text = "Exportar"
        '
        'tsmiImportar
        '
        Me.tsmiImportar.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.tsmiImportar.Name = "tsmiImportar"
        Me.tsmiImportar.Size = New System.Drawing.Size(152, 22)
        Me.tsmiImportar.Text = "Importar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'PlameRem
        '
        Me.PlameRem.Image = Global.ISL.Win.My.Resources.Resources.content_reorder
        Me.PlameRem.Name = "PlameRem"
        Me.PlameRem.Size = New System.Drawing.Size(152, 22)
        Me.PlameRem.Text = "PlameRem"
        '
        'tsmiGenerarBoletas
        '
        Me.tsmiGenerarBoletas.Image = Global.ISL.Win.My.Resources.Resources.invoice
        Me.tsmiGenerarBoletas.Name = "tsmiGenerarBoletas"
        Me.tsmiGenerarBoletas.Size = New System.Drawing.Size(152, 22)
        Me.tsmiGenerarBoletas.Text = "Generar Boletas"
        '
        'tsmiGenerarAFPnet
        '
        Me.tsmiGenerarAFPnet.Image = Global.ISL.Win.My.Resources.Resources.movpersonal
        Me.tsmiGenerarAFPnet.Name = "tsmiGenerarAFPnet"
        Me.tsmiGenerarAFPnet.Size = New System.Drawing.Size(152, 22)
        Me.tsmiGenerarAFPnet.Text = "GenerarAPF Net"
        '
        'tsmiReporteFinal
        '
        Me.tsmiReporteFinal.Image = Global.ISL.Win.My.Resources.Resources.kspread
        Me.tsmiReporteFinal.Name = "tsmiReporteFinal"
        Me.tsmiReporteFinal.Size = New System.Drawing.Size(152, 22)
        Me.tsmiReporteFinal.Text = "ReporteFinal"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.gridBanco)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1130, 345)
        '
        'gridBanco
        '
        Me.gridBanco.ContextMenuStrip = Me.mcPlanilla
        Me.gridBanco.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridBanco.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridBanco.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridBanco.DisplayLayout.MaxColScrollRegions = 1
        Me.gridBanco.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridBanco.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridBanco.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridBanco.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gridBanco.DisplayLayout.Override.CellPadding = 0
        Me.gridBanco.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridBanco.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.gridBanco.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridBanco.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridBanco.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridBanco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridBanco.Location = New System.Drawing.Point(0, 0)
        Me.gridBanco.Name = "gridBanco"
        Me.gridBanco.Size = New System.Drawing.Size(1130, 345)
        Me.gridBanco.TabIndex = 3
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griResumen)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1130, 345)
        '
        'griResumen
        '
        Me.griResumen.ContextMenuStrip = Me.mcPlanilla
        Me.griResumen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griResumen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griResumen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griResumen.DisplayLayout.MaxColScrollRegions = 1
        Me.griResumen.DisplayLayout.MaxRowScrollRegions = 1
        Me.griResumen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griResumen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griResumen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griResumen.DisplayLayout.Override.CellPadding = 0
        Me.griResumen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griResumen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griResumen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griResumen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griResumen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griResumen.Location = New System.Drawing.Point(0, 0)
        Me.griResumen.Name = "griResumen"
        Me.griResumen.Size = New System.Drawing.Size(1130, 345)
        Me.griResumen.TabIndex = 3
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griResumenConcepto)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1130, 345)
        '
        'griResumenConcepto
        '
        Me.griResumenConcepto.ContextMenuStrip = Me.mcPlanilla
        Me.griResumenConcepto.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griResumenConcepto.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griResumenConcepto.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griResumenConcepto.DisplayLayout.MaxColScrollRegions = 1
        Me.griResumenConcepto.DisplayLayout.MaxRowScrollRegions = 1
        Me.griResumenConcepto.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griResumenConcepto.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griResumenConcepto.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griResumenConcepto.DisplayLayout.Override.CellPadding = 0
        Me.griResumenConcepto.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griResumenConcepto.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griResumenConcepto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griResumenConcepto.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griResumenConcepto.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griResumenConcepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griResumenConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griResumenConcepto.Location = New System.Drawing.Point(0, 0)
        Me.griResumenConcepto.Name = "griResumenConcepto"
        Me.griResumenConcepto.Size = New System.Drawing.Size(1130, 345)
        Me.griResumenConcepto.TabIndex = 3
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griNuevosIngresos)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1130, 345)
        '
        'griNuevosIngresos
        '
        Me.griNuevosIngresos.ContextMenuStrip = Me.mcPlanilla
        Me.griNuevosIngresos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griNuevosIngresos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griNuevosIngresos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griNuevosIngresos.DisplayLayout.MaxColScrollRegions = 1
        Me.griNuevosIngresos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griNuevosIngresos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griNuevosIngresos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griNuevosIngresos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griNuevosIngresos.DisplayLayout.Override.CellPadding = 0
        Me.griNuevosIngresos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griNuevosIngresos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griNuevosIngresos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griNuevosIngresos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griNuevosIngresos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griNuevosIngresos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griNuevosIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griNuevosIngresos.Location = New System.Drawing.Point(0, 0)
        Me.griNuevosIngresos.Name = "griNuevosIngresos"
        Me.griNuevosIngresos.Size = New System.Drawing.Size(1130, 345)
        Me.griNuevosIngresos.TabIndex = 4
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griIngresosConceptos)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1130, 345)
        '
        'griIngresosConceptos
        '
        Me.griIngresosConceptos.ContextMenuStrip = Me.mcPlanilla
        Me.griIngresosConceptos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griIngresosConceptos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griIngresosConceptos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griIngresosConceptos.DisplayLayout.MaxColScrollRegions = 1
        Me.griIngresosConceptos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griIngresosConceptos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griIngresosConceptos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griIngresosConceptos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griIngresosConceptos.DisplayLayout.Override.CellPadding = 0
        Me.griIngresosConceptos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griIngresosConceptos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griIngresosConceptos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griIngresosConceptos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griIngresosConceptos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griIngresosConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griIngresosConceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griIngresosConceptos.Location = New System.Drawing.Point(0, 0)
        Me.griIngresosConceptos.Name = "griIngresosConceptos"
        Me.griIngresosConceptos.Size = New System.Drawing.Size(1130, 345)
        Me.griIngresosConceptos.TabIndex = 5
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ficPlanilla
        '
        Me.ficPlanilla.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficPlanilla.Controls.Add(Me.UltraTabPageControl7)
        Me.ficPlanilla.Controls.Add(Me.UltraTabPageControl8)
        Me.ficPlanilla.Controls.Add(Me.UltraTabPageControl1)
        Me.ficPlanilla.Controls.Add(Me.UltraTabPageControl2)
        Me.ficPlanilla.Controls.Add(Me.UltraTabPageControl3)
        Me.ficPlanilla.Controls.Add(Me.UltraTabPageControl4)
        Me.ficPlanilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficPlanilla.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficPlanilla.Location = New System.Drawing.Point(0, 55)
        Me.ficPlanilla.Name = "ficPlanilla"
        Me.ficPlanilla.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficPlanilla.Size = New System.Drawing.Size(1132, 368)
        Me.ficPlanilla.TabIndex = 2
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "PlanillaGeneral"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "Banco"
        UltraTab9.TabPage = Me.UltraTabPageControl1
        UltraTab9.Text = "Resumen"
        UltraTab1.TabPage = Me.UltraTabPageControl2
        UltraTab1.Text = "ResumenConcepto"
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "NuevosIngresos"
        UltraTab3.TabPage = Me.UltraTabPageControl4
        UltraTab3.Text = "IngresosConceptos"
        Me.ficPlanilla.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7, UltraTab8, UltraTab9, UltraTab1, UltraTab2, UltraTab3})
        Me.ficPlanilla.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1130, 345)
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.cboPeriodo)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta9)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1132, 55)
        Me.agrBusqueda.TabIndex = 1
        Me.agrBusqueda.Text = "Datos Búsqueda:"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboPeriodo
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboPeriodo.Appearance = Appearance1
        Me.cboPeriodo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPeriodo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodo.ForeColor = System.Drawing.Color.Black
        Me.cboPeriodo.Location = New System.Drawing.Point(90, 20)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(114, 22)
        Me.cboPeriodo.TabIndex = 13
        Me.cboPeriodo.ValueMember = "Id"
        '
        'Etiqueta9
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance2
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(40, 24)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta9.TabIndex = 12
        Me.Etiqueta9.Text = "Periodo:"
        '
        'frm_ReportesPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 423)
        Me.Controls.Add(Me.ficPlanilla)
        Me.Controls.Add(Me.agrBusqueda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ReportesPlanilla"
        Me.Text = "Registro Planilla"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.gridReporteFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcPlanilla.ResumeLayout(False)
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.gridBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griResumenConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griNuevosIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griIngresosConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficPlanilla.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.cboPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mcPlanilla As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiExportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiImportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiEnviar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiProvisionar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PlameRem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tsmiGenerarBoletas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiGenerarAFPnet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiReporteFinal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents cboPeriodo As ISL.Controles.Combo
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents ficPlanilla As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridReporteFinal As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridBanco As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griResumen As ISL.Controles.Grilla
    Friend WithEvents Espere2 As ISL.Win.Espere
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griResumenConcepto As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griNuevosIngresos As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griIngresosConceptos As ISL.Controles.Grilla
End Class
