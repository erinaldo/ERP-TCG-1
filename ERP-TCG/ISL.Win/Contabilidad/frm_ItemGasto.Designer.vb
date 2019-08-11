<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ItemGasto
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejercicio")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTablaContableDet")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejercicio")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTablaContableDet")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ItemGasto))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdItemGasto")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejercicio")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdItemGasto")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejercicio")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
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
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.MenuCabecera = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdLista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraExpandableGroupBox17 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel10 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorBloque = New ISL.Controles.Colores(Me.components)
        Me.AñoLista = New ISL.Win.Año()
        Me.Etiqueta93 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griCuentaItemGasto = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdCuentaItemGasto = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuenta = New ISL.Controles.ComboMaestros(Me.components)
        Me.numEjercicio = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnAgregarCg = New Infragistics.Win.Misc.UltraButton()
        Me.cboGastoFuncion = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.tcItemGasto = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuCabecera.SuspendLayout()
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox17.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel10.SuspendLayout()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griCuentaItemGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdCuentaItemGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.numEjercicio.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGastoFuncion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcItemGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcItemGasto.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griLista)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraExpandableGroupBox17)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1021, 438)
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.MenuCabecera
        Me.griLista.DataSource = Me.ogdLista
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn2.Header.VisiblePosition = 3
        UltraGridColumn2.Width = 400
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.Hidden = True
        Appearance1.Image = 3
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.CellAppearance = Appearance1
        Appearance2.Image = 1
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.CellButtonAppearance = Appearance2
        UltraGridColumn9.Header.Caption = "Guardar"
        UltraGridColumn9.Header.VisiblePosition = 6
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn9.Width = 40
        UltraGridColumn10.Header.VisiblePosition = 2
        UltraGridColumn10.Width = 75
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Width = 75
        UltraGridColumn5.Header.Caption = "Gasto Funcion"
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 150
        UltraGridColumn4.Header.VisiblePosition = 7
        UltraGridColumn4.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 8
        UltraGridColumn6.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn3, UltraGridColumn5, UltraGridColumn4, UltraGridColumn6})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.TemplateAddRowPrompt = "Click aqui para agregar un nuevo registro..."
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.ImageList = Me.imagenes
        Me.griLista.Location = New System.Drawing.Point(0, 60)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1021, 378)
        Me.griLista.TabIndex = 341
        '
        'MenuCabecera
        '
        Me.MenuCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuCabecera.ForeColor = System.Drawing.Color.Black
        Me.MenuCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuCabecera.Name = "MenuContextual1"
        Me.MenuCabecera.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Flujo de Caja"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar  el flujo de caja seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el flujo de caja seleccionado"
        '
        'ogdLista
        '
        UltraDataColumn3.DataType = GetType(Boolean)
        Me.ogdLista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
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
        Me.imagenes.Images.SetKeyName(5, "del.ico")
        Me.imagenes.Images.SetKeyName(6, "")
        Me.imagenes.Images.SetKeyName(7, "")
        Me.imagenes.Images.SetKeyName(8, "")
        Me.imagenes.Images.SetKeyName(9, "")
        Me.imagenes.Images.SetKeyName(10, "")
        Me.imagenes.Images.SetKeyName(11, "add.ico")
        '
        'UltraExpandableGroupBox17
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox17.ContentAreaAppearance = Appearance3
        Me.UltraExpandableGroupBox17.Controls.Add(Me.UltraExpandableGroupBoxPanel10)
        Me.UltraExpandableGroupBox17.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox17.ExpandedSize = New System.Drawing.Size(1021, 60)
        Me.UltraExpandableGroupBox17.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox17.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox17.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox17.Name = "UltraExpandableGroupBox17"
        Me.UltraExpandableGroupBox17.Size = New System.Drawing.Size(1021, 60)
        Me.UltraExpandableGroupBox17.TabIndex = 340
        Me.UltraExpandableGroupBox17.Text = "Filtro de Busqueda"
        Me.UltraExpandableGroupBox17.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel10
        '
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.Etiqueta45)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.ColorBloque)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.AñoLista)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.Etiqueta93)
        Me.UltraExpandableGroupBoxPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel10.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel10.Name = "UltraExpandableGroupBoxPanel10"
        Me.UltraExpandableGroupBoxPanel10.Size = New System.Drawing.Size(1015, 37)
        Me.UltraExpandableGroupBoxPanel10.TabIndex = 0
        '
        'Etiqueta45
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta45.Appearance = Appearance4
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(184, 9)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(74, 15)
        Me.Etiqueta45.TabIndex = 364
        Me.Etiqueta45.Text = "Actualizado:"
        '
        'ColorBloque
        '
        Me.ColorBloque.Color = System.Drawing.Color.Cyan
        Me.ColorBloque.Location = New System.Drawing.Point(264, 6)
        Me.ColorBloque.Name = "ColorBloque"
        Me.ColorBloque.Size = New System.Drawing.Size(44, 22)
        Me.ColorBloque.TabIndex = 365
        Me.ColorBloque.Text = "Cyan"
        '
        'AñoLista
        '
        Me.AñoLista.Año = 2017
        Me.AñoLista.AutoSize = True
        Me.AñoLista.Location = New System.Drawing.Point(92, 6)
        Me.AñoLista.Name = "AñoLista"
        Me.AñoLista.Size = New System.Drawing.Size(75, 24)
        Me.AñoLista.TabIndex = 363
        '
        'Etiqueta93
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta93.Appearance = Appearance5
        Me.Etiqueta93.AutoSize = True
        Me.Etiqueta93.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta93.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta93.Location = New System.Drawing.Point(29, 9)
        Me.Etiqueta93.Name = "Etiqueta93"
        Me.Etiqueta93.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta93.TabIndex = 317
        Me.Etiqueta93.Text = "Ejercicio:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griCuentaItemGasto)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1021, 438)
        '
        'griCuentaItemGasto
        '
        Me.griCuentaItemGasto.DataSource = Me.ogdCuentaItemGasto
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griCuentaItemGasto.DisplayLayout.Appearance = Appearance6
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Width = 115
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 4
        UltraGridColumn16.Width = 100
        UltraGridColumn17.Header.VisiblePosition = 5
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 360
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.griCuentaItemGasto.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griCuentaItemGasto.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griCuentaItemGasto.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griCuentaItemGasto.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griCuentaItemGasto.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.griCuentaItemGasto.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griCuentaItemGasto.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.griCuentaItemGasto.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griCuentaItemGasto.DisplayLayout.GroupByBox.Hidden = True
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griCuentaItemGasto.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.griCuentaItemGasto.DisplayLayout.MaxColScrollRegions = 1
        Me.griCuentaItemGasto.DisplayLayout.MaxRowScrollRegions = 1
        Me.griCuentaItemGasto.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griCuentaItemGasto.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCuentaItemGasto.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griCuentaItemGasto.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griCuentaItemGasto.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griCuentaItemGasto.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCuentaItemGasto.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griCuentaItemGasto.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griCuentaItemGasto.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCuentaItemGasto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCuentaItemGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCuentaItemGasto.Location = New System.Drawing.Point(0, 138)
        Me.griCuentaItemGasto.Name = "griCuentaItemGasto"
        Me.griCuentaItemGasto.Size = New System.Drawing.Size(1021, 300)
        Me.griCuentaItemGasto.TabIndex = 303
        '
        'ogdCuentaItemGasto
        '
        Me.ogdCuentaItemGasto.Band.Columns.AddRange(New Object() {UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion1)
        Me.Agrupacion2.Controls.Add(Me.cboGastoFuncion)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.txtNombre)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1021, 138)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta3
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance10
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(9, 39)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(89, 15)
        Me.Etiqueta3.TabIndex = 342
        Me.Etiqueta3.Text = "Gasto Funcion:"
        '
        'Agrupacion1
        '
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance11
        Me.Agrupacion1.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion1.Controls.Add(Me.cboCuenta)
        Me.Agrupacion1.Controls.Add(Me.numEjercicio)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.btnAgregarCg)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(3, 73)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1015, 62)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "CUENTA ITEM GASTO X EJERCICIO"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta10
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance12
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(138, 33)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta10.TabIndex = 302
        Me.Etiqueta10.Text = "Cuenta:"
        '
        'cboCuenta
        '
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.cboCuenta.Appearance = Appearance13
        Me.cboCuenta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCuenta.DisplayMember = "Nombre"
        Me.cboCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuenta.ForeColor = System.Drawing.Color.Black
        Me.cboCuenta.Location = New System.Drawing.Point(193, 29)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(100, 21)
        Me.cboCuenta.TabIndex = 301
        Me.cboCuenta.ValueMember = "Id"
        '
        'numEjercicio
        '
        Me.numEjercicio.Año = 2017
        Me.numEjercicio.AutoSize = True
        Me.numEjercicio.Controls.Add(Me.numAño)
        Me.numEjercicio.Controls.Add(Me.NumeroEntero1)
        Me.numEjercicio.Controls.Add(Me.NumeroEntero2)
        Me.numEjercicio.Location = New System.Drawing.Point(72, 29)
        Me.numEjercicio.Name = "numEjercicio"
        Me.numEjercicio.Size = New System.Drawing.Size(60, 24)
        Me.numEjercicio.TabIndex = 300
        '
        'numAño
        '
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance14
        Me.numAño.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAño.ForeColor = System.Drawing.Color.Black
        Me.numAño.FormatString = ""
        Me.numAño.Location = New System.Drawing.Point(1, 0)
        Me.numAño.MaskInput = "nnnn"
        Me.numAño.MaxValue = 2020
        Me.numAño.MinValue = 2000
        Me.numAño.Name = "numAño"
        Me.numAño.NullText = "0"
        Me.numAño.Size = New System.Drawing.Size(52, 21)
        Me.numAño.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAño.TabIndex = 0
        Me.numAño.Value = 2014
        '
        'NumeroEntero1
        '
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance15
        Me.NumeroEntero1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero1.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.FormatString = ""
        Me.NumeroEntero1.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero1.MaskInput = "nnnn"
        Me.NumeroEntero1.MaxValue = 2020
        Me.NumeroEntero1.MinValue = 2000
        Me.NumeroEntero1.Name = "NumeroEntero1"
        Me.NumeroEntero1.NullText = "0"
        Me.NumeroEntero1.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero1.TabIndex = 0
        Me.NumeroEntero1.Value = 2013
        '
        'NumeroEntero2
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.Appearance = Appearance16
        Me.NumeroEntero2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero2.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.FormatString = ""
        Me.NumeroEntero2.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero2.MaskInput = "nnnn"
        Me.NumeroEntero2.MaxValue = 2020
        Me.NumeroEntero2.MinValue = 2000
        Me.NumeroEntero2.Name = "NumeroEntero2"
        Me.NumeroEntero2.NullText = "0"
        Me.NumeroEntero2.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero2.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero2.TabIndex = 0
        Me.NumeroEntero2.Value = 2012
        '
        'Etiqueta1
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance17
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(10, 33)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta1.TabIndex = 299
        Me.Etiqueta1.Text = "Ejercicio:"
        '
        'btnAgregarCg
        '
        Appearance18.Image = "add.ico"
        Me.btnAgregarCg.Appearance = Appearance18
        Me.btnAgregarCg.ImageList = Me.imagenes
        Me.btnAgregarCg.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarCg.Location = New System.Drawing.Point(299, 24)
        Me.btnAgregarCg.Name = "btnAgregarCg"
        Me.btnAgregarCg.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarCg.TabIndex = 228
        '
        'cboGastoFuncion
        '
        Me.cboGastoFuncion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboGastoFuncion.DisplayLayout.Appearance = Appearance19
        Me.cboGastoFuncion.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboGastoFuncion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.BorderColor = System.Drawing.SystemColors.Window
        Me.cboGastoFuncion.DisplayLayout.GroupByBox.Appearance = Appearance20
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboGastoFuncion.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance21
        Me.cboGastoFuncion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance22.BackColor2 = System.Drawing.SystemColors.Control
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboGastoFuncion.DisplayLayout.GroupByBox.PromptAppearance = Appearance22
        Me.cboGastoFuncion.DisplayLayout.MaxColScrollRegions = 1
        Me.cboGastoFuncion.DisplayLayout.MaxRowScrollRegions = 1
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboGastoFuncion.DisplayLayout.Override.ActiveCellAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.SystemColors.Window
        Me.cboGastoFuncion.DisplayLayout.Override.CardAreaAppearance = Appearance24
        Me.cboGastoFuncion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboGastoFuncion.DisplayLayout.Override.CellPadding = 0
        Me.cboGastoFuncion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Appearance25.BackColor = System.Drawing.SystemColors.Control
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.cboGastoFuncion.DisplayLayout.Override.GroupByRowAppearance = Appearance25
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboGastoFuncion.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
        Me.cboGastoFuncion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboGastoFuncion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboGastoFuncion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboGastoFuncion.DisplayMember = "Nombre"
        Me.cboGastoFuncion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboGastoFuncion.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboGastoFuncion.Location = New System.Drawing.Point(104, 38)
        Me.cboGastoFuncion.Name = "cboGastoFuncion"
        Me.cboGastoFuncion.Size = New System.Drawing.Size(250, 23)
        Me.cboGastoFuncion.TabIndex = 341
        Me.cboGastoFuncion.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance27
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(26, 15)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(72, 15)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Item Gasto:"
        '
        'txtNombre
        '
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Appearance = Appearance28
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(104, 11)
        Me.txtNombre.MaxLength = 3000
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(400, 21)
        Me.txtNombre.TabIndex = 0
        '
        'tcItemGasto
        '
        Me.tcItemGasto.Controls.Add(Me.UltraTabPageControl1)
        Me.tcItemGasto.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcItemGasto.Controls.Add(Me.UltraTabPageControl2)
        Me.tcItemGasto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcItemGasto.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcItemGasto.Location = New System.Drawing.Point(0, 0)
        Me.tcItemGasto.Name = "tcItemGasto"
        Me.tcItemGasto.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcItemGasto.Size = New System.Drawing.Size(1023, 461)
        Me.tcItemGasto.TabIndex = 2
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcItemGasto.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcItemGasto.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1021, 438)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(313, 196)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 4
        Me.ugb_Espera.Visible = False
        '
        'frm_ItemGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1023, 461)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.tcItemGasto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ItemGasto"
        Me.Text = "Item Gasto"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuCabecera.ResumeLayout(False)
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox17.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel10.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel10.PerformLayout()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griCuentaItemGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdCuentaItemGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.numEjercicio.ResumeLayout(False)
        Me.numEjercicio.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGastoFuncion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcItemGasto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcItemGasto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdLista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tcItemGasto As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents MenuCabecera As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnAgregarCg As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ogdCuentaItemGasto As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuenta As ISL.Controles.ComboMaestros
    Friend WithEvents numEjercicio As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero2 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents griCuentaItemGasto As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents UltraExpandableGroupBox17 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel10 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents AñoLista As ISL.Win.Año
    Friend WithEvents Etiqueta93 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents cboGastoFuncion As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents ColorBloque As ISL.Controles.Colores

End Class
