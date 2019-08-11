<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoVehiculo
    Inherits ISL.Win.frm_MenuPadre

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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Motriz")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculoOrigen")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorFuncional")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTipoVehiculo")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndSunarp")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Motriz")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculoOrigen")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorFuncional")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTipoVehiculo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndSunarp")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TipoVehiculo))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdTipoVehiculo = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.agrTotalModeloVehiculo = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorBloque = New ISL.Controles.Colores(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.verIndSunarp = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verIndTipoVehiculo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verIndFuncional = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.verCarga = New ISL.Controles.Chequear(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.txtId = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.verTipoVehiculoOrigen = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.cboTipoVehiculoOrigen = New ISL.Controles.ComboMaestros(Me.components)
        Me.verMotriz = New ISL.Controles.Chequear(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.tcTipoVehiculo = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.ogdTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrTotalModeloVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalModeloVehiculo.SuspendLayout()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.verIndSunarp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndFuncional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTipoVehiculoOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoVehiculoOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verMotriz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcTipoVehiculo.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griLista)
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalModeloVehiculo)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(914, 438)
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.MenuContextual1
        Me.griLista.DataSource = Me.ogdTipoVehiculo
        UltraGridColumn14.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Hidden = True
        Appearance1.Image = 3
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn15.CellAppearance = Appearance1
        Appearance2.Image = 1
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn15.CellButtonAppearance = Appearance2
        UltraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn15.Header.Caption = "Guardar"
        UltraGridColumn15.Header.VisiblePosition = 12
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn15.Width = 35
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Width = 280
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn18.Header.VisiblePosition = 4
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn18.Width = 46
        UltraGridColumn19.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn19.Header.VisiblePosition = 7
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 207
        UltraGridColumn20.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn20.Header.VisiblePosition = 8
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn21.Header.Caption = "Tipo Vehiculo Origen"
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Width = 243
        UltraGridColumn22.Header.VisiblePosition = 9
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn23.Width = 44
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn24.Header.Caption = "Funcional"
        UltraGridColumn24.Header.VisiblePosition = 6
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn24.Width = 60
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn25.Header.Caption = "T. Veh. Empresa"
        UltraGridColumn25.Header.VisiblePosition = 10
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn25.Width = 75
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn26.Header.Caption = "T. Veh. Sunarp"
        UltraGridColumn26.Header.VisiblePosition = 11
        UltraGridColumn26.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn26.Width = 84
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance3.TextHAlignAsString = "Left"
        Me.griLista.DisplayLayout.CaptionAppearance = Appearance3
        Me.griLista.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.ImageList = Me.imagenes
        Me.griLista.Location = New System.Drawing.Point(0, 54)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(914, 384)
        Me.griLista.TabIndex = 235
        Me.griLista.Tag = ""
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Tipo de Vehículo"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Tipo de Vehículo seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Tipo de Vehículo seleccionado"
        '
        'ogdTipoVehiculo
        '
        UltraDataColumn5.DataType = GetType(Byte)
        UltraDataColumn7.DataType = GetType(Byte)
        UltraDataColumn13.DefaultValue = "False"
        Me.ogdTipoVehiculo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "")
        Me.imagenes.Images.SetKeyName(1, "")
        Me.imagenes.Images.SetKeyName(2, "")
        Me.imagenes.Images.SetKeyName(3, "")
        Me.imagenes.Images.SetKeyName(4, "")
        Me.imagenes.Images.SetKeyName(5, "")
        Me.imagenes.Images.SetKeyName(6, "")
        Me.imagenes.Images.SetKeyName(7, "")
        Me.imagenes.Images.SetKeyName(8, "")
        Me.imagenes.Images.SetKeyName(9, "")
        Me.imagenes.Images.SetKeyName(10, "")
        Me.imagenes.Images.SetKeyName(11, "add.ico")
        Me.imagenes.Images.SetKeyName(12, "06_calculator.ico")
        Me.imagenes.Images.SetKeyName(13, "Consultar.ico")
        Me.imagenes.Images.SetKeyName(14, "266.png")
        '
        'agrTotalModeloVehiculo
        '
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.White
        Me.agrTotalModeloVehiculo.ContentAreaAppearance = Appearance4
        Me.agrTotalModeloVehiculo.Controls.Add(Me.Etiqueta26)
        Me.agrTotalModeloVehiculo.Controls.Add(Me.ColorBloque)
        Me.agrTotalModeloVehiculo.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrTotalModeloVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalModeloVehiculo.ForeColor = System.Drawing.Color.Black
        Me.agrTotalModeloVehiculo.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalModeloVehiculo.Name = "agrTotalModeloVehiculo"
        Me.agrTotalModeloVehiculo.Size = New System.Drawing.Size(914, 54)
        Me.agrTotalModeloVehiculo.TabIndex = 234
        Me.agrTotalModeloVehiculo.Text = "Total Registros:"
        Me.agrTotalModeloVehiculo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta26
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance5
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(7, 24)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta26.TabIndex = 40
        Me.Etiqueta26.Text = "Actualizado:"
        '
        'ColorBloque
        '
        Me.ColorBloque.Color = System.Drawing.Color.Cyan
        Me.ColorBloque.Location = New System.Drawing.Point(77, 19)
        Me.ColorBloque.Name = "ColorBloque"
        Me.ColorBloque.Size = New System.Drawing.Size(44, 21)
        Me.ColorBloque.TabIndex = 39
        Me.ColorBloque.Text = "Cyan"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(914, 438)
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verIndSunarp)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verIndTipoVehiculo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verIndFuncional)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtNombre)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verCarga)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtCodigo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtId)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.Etiqueta5)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.Etiqueta4)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.Etiqueta3)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.Etiqueta2)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verTipoVehiculoOrigen)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.Etiqueta1)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtDescripcion)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboTipoVehiculoOrigen)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verMotriz)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtAbreviatura)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(914, 438)
        Me.Gb_DatoGeneralDemanda.TabIndex = 100
        Me.Gb_DatoGeneralDemanda.Text = "Datos"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'verIndSunarp
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.verIndSunarp.Appearance = Appearance6
        Me.verIndSunarp.AutoSize = True
        Me.verIndSunarp.BackColor = System.Drawing.Color.Transparent
        Me.verIndSunarp.BackColorInternal = System.Drawing.Color.Transparent
        Me.verIndSunarp.Location = New System.Drawing.Point(77, 72)
        Me.verIndSunarp.Name = "verIndSunarp"
        Me.verIndSunarp.Size = New System.Drawing.Size(133, 17)
        Me.verIndSunarp.TabIndex = 3
        Me.verIndSunarp.Text = "Tipo Vehiculo Sunarp"
        '
        'verIndTipoVehiculo
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.verIndTipoVehiculo.Appearance = Appearance7
        Me.verIndTipoVehiculo.AutoSize = True
        Me.verIndTipoVehiculo.BackColor = System.Drawing.Color.Transparent
        Me.verIndTipoVehiculo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verIndTipoVehiculo.Location = New System.Drawing.Point(77, 53)
        Me.verIndTipoVehiculo.Name = "verIndTipoVehiculo"
        Me.verIndTipoVehiculo.Size = New System.Drawing.Size(143, 17)
        Me.verIndTipoVehiculo.TabIndex = 2
        Me.verIndTipoVehiculo.Text = "Tipo Vehiculo Empresa"
        '
        'verIndFuncional
        '
        Me.verIndFuncional.AutoSize = True
        Me.verIndFuncional.BackColor = System.Drawing.Color.Transparent
        Me.verIndFuncional.BackColorInternal = System.Drawing.Color.Transparent
        Me.verIndFuncional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIndFuncional.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verIndFuncional.Location = New System.Drawing.Point(77, 129)
        Me.verIndFuncional.Name = "verIndFuncional"
        Me.verIndFuncional.Size = New System.Drawing.Size(108, 17)
        Me.verIndFuncional.TabIndex = 6
        Me.verIndFuncional.Text = "Modelo Funcional"
        '
        'txtNombre
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance8
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(77, 149)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(300, 21)
        Me.txtNombre.TabIndex = 7
        '
        'verCarga
        '
        Me.verCarga.AutoSize = True
        Me.verCarga.BackColor = System.Drawing.Color.Transparent
        Me.verCarga.BackColorInternal = System.Drawing.Color.Transparent
        Me.verCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verCarga.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verCarga.Location = New System.Drawing.Point(77, 110)
        Me.verCarga.Name = "verCarga"
        Me.verCarga.Size = New System.Drawing.Size(51, 17)
        Me.verCarga.TabIndex = 5
        Me.verCarga.Text = "Carga"
        '
        'txtCodigo
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance9
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(77, 26)
        Me.txtCodigo.MaxLength = 15
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TabStop = False
        '
        'txtId
        '
        Appearance10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.Appearance = Appearance10
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.Location = New System.Drawing.Point(11, 26)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(16, 21)
        Me.txtId.TabIndex = 127
        Me.txtId.Visible = False
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(7, 225)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta5.TabIndex = 126
        Me.Etiqueta5.Text = "Descripción:"
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(10, 203)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta4.TabIndex = 125
        Me.Etiqueta4.Text = "Abreviatura:"
        '
        'Etiqueta3
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance11
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(27, 153)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta3.TabIndex = 124
        Me.Etiqueta3.Text = "Nombre:"
        '
        'Etiqueta2
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance12
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(31, 30)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(42, 14)
        Me.Etiqueta2.TabIndex = 123
        Me.Etiqueta2.Text = "Código:"
        '
        'verTipoVehiculoOrigen
        '
        Me.verTipoVehiculoOrigen.AutoSize = True
        Me.verTipoVehiculoOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verTipoVehiculoOrigen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verTipoVehiculoOrigen.Location = New System.Drawing.Point(77, 178)
        Me.verTipoVehiculoOrigen.Name = "verTipoVehiculoOrigen"
        Me.verTipoVehiculoOrigen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verTipoVehiculoOrigen.Size = New System.Drawing.Size(14, 13)
        Me.verTipoVehiculoOrigen.TabIndex = 8
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(6, 177)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(66, 14)
        Me.Etiqueta1.TabIndex = 121
        Me.Etiqueta1.Text = "T. V. Origen:"
        '
        'txtDescripcion
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Appearance = Appearance13
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Location = New System.Drawing.Point(77, 222)
        Me.txtDescripcion.MaxLength = 500
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion.Size = New System.Drawing.Size(300, 50)
        Me.txtDescripcion.TabIndex = 10
        '
        'cboTipoVehiculoOrigen
        '
        Appearance14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoVehiculoOrigen.Appearance = Appearance14
        Me.cboTipoVehiculoOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoVehiculoOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoVehiculoOrigen.DisplayMember = "Nombre"
        Me.cboTipoVehiculoOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoVehiculoOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVehiculoOrigen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoVehiculoOrigen.Location = New System.Drawing.Point(96, 174)
        Me.cboTipoVehiculoOrigen.Name = "cboTipoVehiculoOrigen"
        Me.cboTipoVehiculoOrigen.Size = New System.Drawing.Size(200, 21)
        Me.cboTipoVehiculoOrigen.TabIndex = 8
        Me.cboTipoVehiculoOrigen.ValueMember = "Id"
        '
        'verMotriz
        '
        Me.verMotriz.AutoSize = True
        Me.verMotriz.BackColor = System.Drawing.Color.Transparent
        Me.verMotriz.BackColorInternal = System.Drawing.Color.Transparent
        Me.verMotriz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verMotriz.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verMotriz.Location = New System.Drawing.Point(77, 91)
        Me.verMotriz.Name = "verMotriz"
        Me.verMotriz.Size = New System.Drawing.Size(51, 17)
        Me.verMotriz.TabIndex = 4
        Me.verMotriz.Text = "Motriz"
        '
        'txtAbreviatura
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance15
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Location = New System.Drawing.Point(77, 199)
        Me.txtAbreviatura.MaxLength = 10
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAbreviatura.Size = New System.Drawing.Size(200, 21)
        Me.txtAbreviatura.TabIndex = 9
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(310, 246)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(400, 70)
        Me.ugb_Espera.TabIndex = 7
        Me.ugb_Espera.Visible = False
        '
        'tcTipoVehiculo
        '
        Me.tcTipoVehiculo.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcTipoVehiculo.Controls.Add(Me.UltraTabPageControl7)
        Me.tcTipoVehiculo.Controls.Add(Me.utpDetalle)
        Me.tcTipoVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTipoVehiculo.Location = New System.Drawing.Point(0, 0)
        Me.tcTipoVehiculo.Name = "tcTipoVehiculo"
        Me.tcTipoVehiculo.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcTipoVehiculo.Size = New System.Drawing.Size(916, 461)
        Me.tcTipoVehiculo.TabIndex = 2
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.tcTipoVehiculo.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcTipoVehiculo.TabStop = False
        Me.tcTipoVehiculo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(914, 438)
        '
        'frm_TipoVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(916, 461)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.tcTipoVehiculo)
        Me.KeyPreview = True
        Me.Name = "frm_TipoVehiculo"
        Me.ShowInTaskbar = False
        Me.Text = "Tipo Vehiculo"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.ogdTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrTotalModeloVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalModeloVehiculo.ResumeLayout(False)
        Me.agrTotalModeloVehiculo.PerformLayout()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.verIndSunarp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndFuncional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTipoVehiculoOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoVehiculoOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verMotriz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcTipoVehiculo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcTipoVehiculo As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents verMotriz As ISL.Controles.Chequear
    Friend WithEvents cboTipoVehiculoOrigen As ISL.Controles.ComboMaestros
    Friend WithEvents ogdTipoVehiculo As ISL.Controles.OrigenDatos
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents verTipoVehiculoOrigen As ISL.Controles.Chequear
    Friend WithEvents txtId As ISL.Controles.Texto
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta

    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents verCarga As ISL.Controles.Chequear
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents verIndFuncional As ISL.Controles.Chequear
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents verIndSunarp As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verIndTipoVehiculo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents agrTotalModeloVehiculo As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents ColorBloque As ISL.Controles.Colores
    Friend WithEvents griLista As Infragistics.Win.UltraWinGrid.UltraGrid

End Class
