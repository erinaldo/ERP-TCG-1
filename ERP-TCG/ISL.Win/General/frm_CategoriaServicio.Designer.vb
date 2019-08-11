<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CategoriaServicio
    Inherits Win.frm_MenuPadre

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaContable")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdItemGasto")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ItemGasto")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejercicio")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCuentaContable")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaServicio")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaContable")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdItemGasto")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ItemGasto")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejercicio")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCuentaContable")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoriaServicio")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.odCategoriaServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.odCtaCtbleCatServ = New ISL.Controles.OrigenDatos(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tcCategoriaServicio = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalCategoriaServicio = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_CategoriaServicio = New ISL.Controles.Grilla(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griCtaCatServ = New ISL.Controles.Grilla(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboItemGasto = New ISL.Controles.Combo(Me.components)
        Me.txtCtaCmp = New ISL.Controles.Texto(Me.components)
        Me.cboCtaCmp = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnQuitarCC = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregarCC = New Infragistics.Win.Misc.UltraButton()
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.odCategoriaServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCtaCtbleCatServ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.tcCategoriaServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcCategoriaServicio.SuspendLayout()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrTotalCategoriaServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalCategoriaServicio.SuspendLayout()
        CType(Me.grid_CategoriaServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.griCtaCatServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaCmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaCmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'odCategoriaServicio
        '
        UltraDataColumn5.DataType = GetType(Boolean)
        Me.odCategoriaServicio.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'odCtaCtbleCatServ
        '
        UltraDataColumn12.DataType = GetType(Short)
        UltraDataColumn13.DataType = GetType(Boolean)
        Me.odCtaCtbleCatServ.Band.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva categoría de servicios"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar la categoría de servicios seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la categoría de servicios seleccionada"
        '
        'tcCategoriaServicio
        '
        Me.tcCategoriaServicio.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcCategoriaServicio.Controls.Add(Me.UltraTabPageControl7)
        Me.tcCategoriaServicio.Controls.Add(Me.utpDetalle)
        Me.tcCategoriaServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcCategoriaServicio.Location = New System.Drawing.Point(0, 0)
        Me.tcCategoriaServicio.Name = "tcCategoriaServicio"
        Me.tcCategoriaServicio.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcCategoriaServicio.Size = New System.Drawing.Size(1120, 390)
        Me.tcCategoriaServicio.TabIndex = 3
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.tcCategoriaServicio.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcCategoriaServicio.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1118, 367)
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalCategoriaServicio)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1118, 367)
        '
        'agrTotalCategoriaServicio
        '
        Me.agrTotalCategoriaServicio.Controls.Add(Me.grid_CategoriaServicio)
        Me.agrTotalCategoriaServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTotalCategoriaServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalCategoriaServicio.ForeColor = System.Drawing.Color.Black
        Me.agrTotalCategoriaServicio.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalCategoriaServicio.Name = "agrTotalCategoriaServicio"
        Me.agrTotalCategoriaServicio.Size = New System.Drawing.Size(1118, 367)
        Me.agrTotalCategoriaServicio.TabIndex = 1
        Me.agrTotalCategoriaServicio.Text = "Total de Categorias de Servicio:"
        Me.agrTotalCategoriaServicio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grid_CategoriaServicio
        '
        Me.grid_CategoriaServicio.DataSource = Me.odCategoriaServicio
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Width = 434
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.Width = 113
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 5
        UltraGridColumn15.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn15})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_CategoriaServicio.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_CategoriaServicio.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_CategoriaServicio.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_CategoriaServicio.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_CategoriaServicio.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Me.grid_CategoriaServicio.DisplayLayout.Override.CellAppearance = Appearance1
        Me.grid_CategoriaServicio.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_CategoriaServicio.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_CategoriaServicio.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_CategoriaServicio.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_CategoriaServicio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance2.BorderColor = System.Drawing.Color.Silver
        Me.grid_CategoriaServicio.DisplayLayout.Override.RowAppearance = Appearance2
        Me.grid_CategoriaServicio.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_CategoriaServicio.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_CategoriaServicio.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grid_CategoriaServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_CategoriaServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_CategoriaServicio.Location = New System.Drawing.Point(3, 16)
        Me.grid_CategoriaServicio.Name = "grid_CategoriaServicio"
        Me.grid_CategoriaServicio.Size = New System.Drawing.Size(1112, 348)
        Me.grid_CategoriaServicio.TabIndex = 237
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.UltraGroupBox1)
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1118, 367)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 156)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1118, 211)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "Cuenta Contable"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.griCtaCatServ)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(3, 87)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1112, 121)
        Me.UltraGroupBox3.TabIndex = 1
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griCtaCatServ
        '
        Me.griCtaCatServ.DataSource = Me.odCtaCtbleCatServ
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 4
        UltraGridColumn18.Width = 376
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 7
        UltraGridColumn20.Width = 404
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance3
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.MaskInput = "nnnn"
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn21.Width = 68
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.Hidden = True
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance4
        UltraGridColumn23.Header.Caption = "NroCtaCtble"
        UltraGridColumn23.Header.VisiblePosition = 3
        UltraGridColumn23.Width = 89
        UltraGridColumn30.Header.VisiblePosition = 8
        UltraGridColumn30.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn30})
        UltraGridBand2.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griCtaCatServ.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griCtaCatServ.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griCtaCatServ.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griCtaCatServ.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCtaCatServ.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCtaCatServ.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance5.BorderColor = System.Drawing.Color.Silver
        Me.griCtaCatServ.DisplayLayout.Override.CellAppearance = Appearance5
        Me.griCtaCatServ.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griCtaCatServ.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCtaCatServ.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griCtaCatServ.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BorderColor = System.Drawing.Color.Silver
        Me.griCtaCatServ.DisplayLayout.Override.RowAppearance = Appearance6
        Me.griCtaCatServ.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCtaCatServ.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCtaCatServ.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griCtaCatServ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCtaCatServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCtaCatServ.Location = New System.Drawing.Point(3, 3)
        Me.griCtaCatServ.Name = "griCtaCatServ"
        Me.griCtaCatServ.Size = New System.Drawing.Size(1106, 115)
        Me.griCtaCatServ.TabIndex = 236
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox2.Controls.Add(Me.cboItemGasto)
        Me.UltraGroupBox2.Controls.Add(Me.txtCtaCmp)
        Me.UltraGroupBox2.Controls.Add(Me.cboCtaCmp)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox2.Controls.Add(Me.btnQuitarCC)
        Me.UltraGroupBox2.Controls.Add(Me.btnAgregarCC)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(3, 16)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1112, 71)
        Me.UltraGroupBox2.TabIndex = 0
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel2
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(11, 42)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel2.TabIndex = 277
        Me.UltraLabel2.Text = "Item Gasto:"
        '
        'cboItemGasto
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.Appearance = Appearance8
        Me.cboItemGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboItemGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboItemGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboItemGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemGasto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.Location = New System.Drawing.Point(80, 38)
        Me.cboItemGasto.Name = "cboItemGasto"
        Me.cboItemGasto.Size = New System.Drawing.Size(529, 21)
        Me.cboItemGasto.TabIndex = 276
        Me.cboItemGasto.ValueMember = "Id"
        '
        'txtCtaCmp
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCtaCmp.Appearance = Appearance9
        Me.txtCtaCmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaCmp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCtaCmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCmp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCtaCmp.Location = New System.Drawing.Point(205, 11)
        Me.txtCtaCmp.MaxLength = 100
        Me.txtCtaCmp.Name = "txtCtaCmp"
        Me.txtCtaCmp.ReadOnly = True
        Me.txtCtaCmp.Size = New System.Drawing.Size(404, 21)
        Me.txtCtaCmp.TabIndex = 275
        '
        'cboCtaCmp
        '
        Appearance10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaCmp.Appearance = Appearance10
        Me.cboCtaCmp.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaCmp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaCmp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaCmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaCmp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaCmp.Location = New System.Drawing.Point(80, 11)
        Me.cboCtaCmp.Name = "cboCtaCmp"
        Me.cboCtaCmp.Size = New System.Drawing.Size(119, 21)
        Me.cboCtaCmp.TabIndex = 274
        Me.cboCtaCmp.ValueMember = "Id"
        '
        'UltraLabel3
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance11
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(30, 15)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel3.TabIndex = 273
        Me.UltraLabel3.Text = "Cuenta:"
        '
        'btnQuitarCC
        '
        Appearance12.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Appearance12.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance12.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnQuitarCC.Appearance = Appearance12
        Me.btnQuitarCC.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnQuitarCC.Location = New System.Drawing.Point(656, 20)
        Me.btnQuitarCC.Name = "btnQuitarCC"
        Me.btnQuitarCC.Size = New System.Drawing.Size(34, 29)
        Me.btnQuitarCC.TabIndex = 272
        '
        'btnAgregarCC
        '
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Appearance13.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance13.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnAgregarCC.Appearance = Appearance13
        Me.btnAgregarCC.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarCC.Location = New System.Drawing.Point(615, 20)
        Me.btnAgregarCC.Name = "btnAgregarCC"
        Me.btnAgregarCC.Size = New System.Drawing.Size(35, 29)
        Me.btnAgregarCC.TabIndex = 271
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel1)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtDescripcion)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtCodigo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verActivo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtNombre)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel22)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel4)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(1118, 156)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel1
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance14
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(24, 81)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel1.TabIndex = 11
        Me.UltraLabel1.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Appearance = Appearance15
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Location = New System.Drawing.Point(96, 79)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(352, 73)
        Me.txtDescripcion.TabIndex = 10
        '
        'txtCodigo
        '
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance16
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(96, 25)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(90, 21)
        Me.txtCodigo.TabIndex = 2
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(96, 158)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 9
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtNombre
        '
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance17
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(96, 52)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(352, 21)
        Me.txtNombre.TabIndex = 4
        '
        'UltraLabel22
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance18
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(43, 52)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel22.TabIndex = 3
        Me.UltraLabel22.Text = "Nombre:"
        '
        'UltraLabel4
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance19
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(48, 27)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 1
        Me.UltraLabel4.Text = "Código:"
        '
        'frm_CategoriaServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1120, 390)
        Me.Controls.Add(Me.tcCategoriaServicio)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CategoriaServicio"
        Me.Text = "Categoria Servicios"
        CType(Me.odCategoriaServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCtaCtbleCatServ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.tcCategoriaServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcCategoriaServicio.ResumeLayout(False)
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrTotalCategoriaServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalCategoriaServicio.ResumeLayout(False)
        CType(Me.grid_CategoriaServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.griCtaCatServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaCmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaCmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcCategoriaServicio As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTotalCategoriaServicio As ISL.Controles.Agrupacion
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odCategoriaServicio As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griCtaCatServ As ISL.Controles.Grilla
    Friend WithEvents grid_CategoriaServicio As ISL.Controles.Grilla
    Friend WithEvents odCtaCtbleCatServ As ISL.Controles.OrigenDatos
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboItemGasto As ISL.Controles.Combo
    Friend WithEvents txtCtaCmp As ISL.Controles.Texto
    Friend WithEvents cboCtaCmp As ISL.Controles.Combo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnQuitarCC As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregarCC As Infragistics.Win.Misc.UltraButton


End Class
