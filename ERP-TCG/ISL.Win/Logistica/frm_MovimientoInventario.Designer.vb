<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MovimientoInventario
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimientoInventario")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDevolucion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMovimientoInventario")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDevolucion")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MovimientoInventario))
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrLista = New ISL.Controles.Agrupacion(Me.components)
        Me.griMovimientoInventario = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odMovimientoInventario = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrMantenimiento = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoMovimientoInventario = New ISL.Controles.ComboMaestros(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.txtId = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficMovimientoInventario = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrLista.SuspendLayout()
        CType(Me.griMovimientoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odMovimientoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMantenimiento.SuspendLayout()
        CType(Me.cboTipoMovimientoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficMovimientoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMovimientoInventario.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrLista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(967, 486)
        '
        'agrLista
        '
        Me.agrLista.Controls.Add(Me.griMovimientoInventario)
        Me.agrLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrLista.Location = New System.Drawing.Point(0, 0)
        Me.agrLista.Name = "agrLista"
        Me.agrLista.Size = New System.Drawing.Size(967, 486)
        Me.agrLista.TabIndex = 0
        Me.agrLista.Text = "Total de Movimientos de Inventario:"
        Me.agrLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griMovimientoInventario
        '
        Me.griMovimientoInventario.ContextMenuStrip = Me.MenuContextual1
        Me.griMovimientoInventario.DataSource = Me.odMovimientoInventario
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 113
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 443
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 88
        UltraGridColumn6.Header.Caption = "Tipo Movimiento Inventario"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 277
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 80
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.griMovimientoInventario.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griMovimientoInventario.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimientoInventario.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMovimientoInventario.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Me.griMovimientoInventario.DisplayLayout.Override.CellAppearance = Appearance1
        Me.griMovimientoInventario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMovimientoInventario.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMovimientoInventario.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griMovimientoInventario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMovimientoInventario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance2.BorderColor = System.Drawing.Color.Silver
        Me.griMovimientoInventario.DisplayLayout.Override.RowAppearance = Appearance2
        Me.griMovimientoInventario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMovimientoInventario.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griMovimientoInventario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimientoInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovimientoInventario.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMovimientoInventario.Location = New System.Drawing.Point(3, 17)
        Me.griMovimientoInventario.Name = "griMovimientoInventario"
        Me.griMovimientoInventario.Size = New System.Drawing.Size(961, 466)
        Me.griMovimientoInventario.TabIndex = 0
        Me.griMovimientoInventario.Text = "Listado de Movimiento de Inventario"
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Movimiento de Inventario"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Movimiento de Inventario seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Movimiento de Inventario seleccionado"
        '
        'odMovimientoInventario
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn8.DataType = GetType(Boolean)
        UltraDataColumn9.DataType = GetType(Boolean)
        Me.odMovimientoInventario.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrMantenimiento)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(967, 486)
        '
        'agrMantenimiento
        '
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta4)
        Me.agrMantenimiento.Controls.Add(Me.cboTipoMovimientoInventario)
        Me.agrMantenimiento.Controls.Add(Me.txtId)
        Me.agrMantenimiento.Controls.Add(Me.txtCodigo)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta1)
        Me.agrMantenimiento.Controls.Add(Me.verActivo)
        Me.agrMantenimiento.Controls.Add(Me.txtAbreviatura)
        Me.agrMantenimiento.Controls.Add(Me.txtNombre)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta3)
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta2)
        Me.agrMantenimiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMantenimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.agrMantenimiento.Name = "agrMantenimiento"
        Me.agrMantenimiento.Size = New System.Drawing.Size(967, 162)
        Me.agrMantenimiento.TabIndex = 0
        Me.agrMantenimiento.Text = "Dato"
        Me.agrMantenimiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta4
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance3
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta4.Location = New System.Drawing.Point(13, 105)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(172, 15)
        Me.Etiqueta4.TabIndex = 7
        Me.Etiqueta4.Text = "Tipo de Movimiento de Inventario:"
        '
        'cboTipoMovimientoInventario
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoMovimientoInventario.Appearance = Appearance4
        Appearance5.Image = 7
        EditorButton1.Appearance = Appearance5
        Me.cboTipoMovimientoInventario.ButtonsRight.Add(EditorButton1)
        Me.cboTipoMovimientoInventario.DisplayMember = "Nombre"
        Me.cboTipoMovimientoInventario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoMovimientoInventario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoMovimientoInventario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMovimientoInventario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoMovimientoInventario.ImageList = Me.imagenes
        Me.cboTipoMovimientoInventario.Location = New System.Drawing.Point(191, 102)
        Me.cboTipoMovimientoInventario.Name = "cboTipoMovimientoInventario"
        Me.cboTipoMovimientoInventario.Size = New System.Drawing.Size(315, 22)
        Me.cboTipoMovimientoInventario.TabIndex = 8
        Me.cboTipoMovimientoInventario.ValueMember = "Id"
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
        '
        'txtId
        '
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(11, 25)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(20, 21)
        Me.txtId.TabIndex = 0
        Me.txtId.Visible = False
        '
        'txtCodigo
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance6
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtCodigo.Location = New System.Drawing.Point(191, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(90, 22)
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.Tag = "0"
        '
        'Etiqueta1
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance7
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(144, 29)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Código:"
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.BackColor = System.Drawing.Color.Transparent
        Me.verActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(191, 127)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 9
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtAbreviatura
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance8
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtAbreviatura.Location = New System.Drawing.Point(191, 76)
        Me.txtAbreviatura.MaxLength = 10
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(90, 22)
        Me.txtAbreviatura.TabIndex = 6
        '
        'txtNombre
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance9
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtNombre.Location = New System.Drawing.Point(191, 50)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(253, 22)
        Me.txtNombre.TabIndex = 4
        Me.txtNombre.Tag = "0"
        '
        'Etiqueta3
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance10
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta3.Location = New System.Drawing.Point(121, 80)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(64, 15)
        Me.Etiqueta3.TabIndex = 5
        Me.Etiqueta3.Text = "Abreviatura:"
        '
        'Etiqueta2
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance11
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(139, 54)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Nombre:"
        '
        'ficMovimientoInventario
        '
        Me.ficMovimientoInventario.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficMovimientoInventario.Controls.Add(Me.UltraTabPageControl1)
        Me.ficMovimientoInventario.Controls.Add(Me.UltraTabPageControl2)
        Me.ficMovimientoInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMovimientoInventario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMovimientoInventario.Location = New System.Drawing.Point(0, 0)
        Me.ficMovimientoInventario.Name = "ficMovimientoInventario"
        Me.ficMovimientoInventario.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficMovimientoInventario.Size = New System.Drawing.Size(969, 509)
        Me.ficMovimientoInventario.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficMovimientoInventario.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficMovimientoInventario.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(967, 486)
        '
        'frm_MovimientoInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(969, 509)
        Me.Controls.Add(Me.ficMovimientoInventario)
        Me.Name = "frm_MovimientoInventario"
        Me.Text = "Movimiento Inventario"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrLista.ResumeLayout(False)
        CType(Me.griMovimientoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odMovimientoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMantenimiento.ResumeLayout(False)
        Me.agrMantenimiento.PerformLayout()
        CType(Me.cboTipoMovimientoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficMovimientoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMovimientoInventario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficMovimientoInventario As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrLista As ISL.Controles.Agrupacion
    Friend WithEvents griMovimientoInventario As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrMantenimiento As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoMovimientoInventario As ISL.Controles.ComboMaestros
    Friend WithEvents txtId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents odMovimientoInventario As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
End Class
