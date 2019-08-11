<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SubFamiliaMaterial
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCtbleExistencias")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbleExistencias")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejercicio")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCtaCtbleExistencias")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCtbleCompras")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCtbleConsumo")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbleCompras")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbleConsumo")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdItemGasto")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ItemGasto")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCtaCtbleExistencias")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbleExistencias")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejercicio")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCtaCtbleExistencias")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCtaCtbleCompras")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCtaCtbleConsumo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbleCompras")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbleConsumo")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdItemGasto")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ItemGasto")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SubFamiliaMaterial))
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrLista = New ISL.Controles.Agrupacion(Me.components)
        Me.griSubFamiliaMaterial = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odSubFamiliaMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.griCtaSubFam = New ISL.Controles.Grilla(Me.components)
        Me.odCtaCtbleSubFam = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboItemGasto = New ISL.Controles.Combo(Me.components)
        Me.txtCtaConsumo = New ISL.Controles.Texto(Me.components)
        Me.txtCtaCompra = New ISL.Controles.Texto(Me.components)
        Me.cboCtaConsumo = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboCtaCompra = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboCtaCtble = New ISL.Controles.Combo(Me.components)
        Me.txtCuenta = New ISL.Controles.Texto(Me.components)
        Me.btnQuitarCC = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnAgregarCC = New Infragistics.Win.Misc.UltraButton()
        Me.agrMantenimiento = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFamiliaMaterial = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtId = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficSubFamiliaMaterial = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrLista.SuspendLayout()
        CType(Me.griSubFamiliaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odSubFamiliaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.griCtaSubFam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCtaCtbleSubFam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaCtble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMantenimiento.SuspendLayout()
        CType(Me.cboFamiliaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficSubFamiliaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficSubFamiliaMaterial.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrLista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1242, 513)
        '
        'agrLista
        '
        Me.agrLista.Controls.Add(Me.griSubFamiliaMaterial)
        Me.agrLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrLista.Location = New System.Drawing.Point(0, 0)
        Me.agrLista.Name = "agrLista"
        Me.agrLista.Size = New System.Drawing.Size(1242, 513)
        Me.agrLista.TabIndex = 1
        Me.agrLista.Text = "Total de SubFamilias de Material:"
        Me.agrLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griSubFamiliaMaterial
        '
        Me.griSubFamiliaMaterial.ContextMenuStrip = Me.MenuContextual1
        Me.griSubFamiliaMaterial.DataSource = Me.odSubFamiliaMaterial
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn2.CellAppearance = Appearance1
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 64
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 287
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Width = 250
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.griSubFamiliaMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griSubFamiliaMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griSubFamiliaMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griSubFamiliaMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griSubFamiliaMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griSubFamiliaMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griSubFamiliaMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griSubFamiliaMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griSubFamiliaMaterial.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griSubFamiliaMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griSubFamiliaMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griSubFamiliaMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griSubFamiliaMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griSubFamiliaMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griSubFamiliaMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griSubFamiliaMaterial.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griSubFamiliaMaterial.Location = New System.Drawing.Point(3, 17)
        Me.griSubFamiliaMaterial.Name = "griSubFamiliaMaterial"
        Me.griSubFamiliaMaterial.Size = New System.Drawing.Size(1236, 493)
        Me.griSubFamiliaMaterial.TabIndex = 0
        Me.griSubFamiliaMaterial.Text = "Listado de SubFamilia de Material"
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Sub Familia de Material o artículo"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar la Sub Familia de Material seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la Sub Familia de Material seleccionada"
        '
        'odSubFamiliaMaterial
        '
        UltraDataColumn5.DataType = GetType(Boolean)
        Me.odSubFamiliaMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl2.Controls.Add(Me.agrMantenimiento)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1242, 513)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 153)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1242, 360)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.griCtaSubFam)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(3, 200)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1236, 157)
        Me.Agrupacion3.TabIndex = 1
        Me.Agrupacion3.Text = "Detalle"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griCtaSubFam
        '
        Me.griCtaSubFam.DataSource = Me.odCtaCtbleSubFam
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 2
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 5
        UltraGridColumn11.Width = 344
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Width = 76
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn14.Header.VisiblePosition = 8
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 9
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 10
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 11
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 6
        UltraGridColumn19.Header.VisiblePosition = 7
        UltraGridColumn20.Header.VisiblePosition = 12
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 13
        UltraGridColumn21.Width = 404
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        UltraGridBand2.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griCtaSubFam.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griCtaSubFam.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griCtaSubFam.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griCtaSubFam.DisplayLayout.MaxColScrollRegions = 1
        Me.griCtaSubFam.DisplayLayout.MaxRowScrollRegions = 1
        Me.griCtaSubFam.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griCtaSubFam.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCtaSubFam.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCtaSubFam.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance2.BorderColor = System.Drawing.Color.Silver
        Me.griCtaSubFam.DisplayLayout.Override.CellAppearance = Appearance2
        Me.griCtaSubFam.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griCtaSubFam.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCtaSubFam.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griCtaSubFam.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance3.BorderColor = System.Drawing.Color.Silver
        Me.griCtaSubFam.DisplayLayout.Override.RowAppearance = Appearance3
        Me.griCtaSubFam.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCtaSubFam.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCtaSubFam.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griCtaSubFam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCtaSubFam.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCtaSubFam.Location = New System.Drawing.Point(3, 17)
        Me.griCtaSubFam.Name = "griCtaSubFam"
        Me.griCtaSubFam.Size = New System.Drawing.Size(1230, 137)
        Me.griCtaSubFam.TabIndex = 235
        '
        'odCtaCtbleSubFam
        '
        UltraDataColumn12.DataType = GetType(Short)
        UltraDataColumn14.DataType = GetType(Boolean)
        Me.odCtaCtbleSubFam.Band.Columns.AddRange(New Object() {UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21})
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion2.Controls.Add(Me.cboItemGasto)
        Me.Agrupacion2.Controls.Add(Me.txtCtaConsumo)
        Me.Agrupacion2.Controls.Add(Me.txtCtaCompra)
        Me.Agrupacion2.Controls.Add(Me.cboCtaConsumo)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel4)
        Me.Agrupacion2.Controls.Add(Me.cboCtaCompra)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion2.Controls.Add(Me.cboCtaCtble)
        Me.Agrupacion2.Controls.Add(Me.txtCuenta)
        Me.Agrupacion2.Controls.Add(Me.btnQuitarCC)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion2.Controls.Add(Me.btnAgregarCC)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(3, 3)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1236, 197)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "CuentaContable"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(55, 135)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 15)
        Me.UltraLabel2.TabIndex = 270
        Me.UltraLabel2.Text = "Item Gasto:"
        '
        'cboItemGasto
        '
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.Appearance = Appearance5
        Me.cboItemGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboItemGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboItemGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboItemGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemGasto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.Location = New System.Drawing.Point(124, 131)
        Me.cboItemGasto.Name = "cboItemGasto"
        Me.cboItemGasto.Size = New System.Drawing.Size(529, 22)
        Me.cboItemGasto.TabIndex = 269
        Me.cboItemGasto.ValueMember = "Id"
        '
        'txtCtaConsumo
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCtaConsumo.Appearance = Appearance6
        Me.txtCtaConsumo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaConsumo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCtaConsumo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaConsumo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCtaConsumo.Location = New System.Drawing.Point(249, 95)
        Me.txtCtaConsumo.MaxLength = 100
        Me.txtCtaConsumo.Name = "txtCtaConsumo"
        Me.txtCtaConsumo.ReadOnly = True
        Me.txtCtaConsumo.Size = New System.Drawing.Size(404, 22)
        Me.txtCtaConsumo.TabIndex = 268
        '
        'txtCtaCompra
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCtaCompra.Appearance = Appearance7
        Me.txtCtaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCtaCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCtaCompra.Location = New System.Drawing.Point(249, 59)
        Me.txtCtaCompra.MaxLength = 100
        Me.txtCtaCompra.Name = "txtCtaCompra"
        Me.txtCtaCompra.ReadOnly = True
        Me.txtCtaCompra.Size = New System.Drawing.Size(404, 22)
        Me.txtCtaCompra.TabIndex = 267
        '
        'cboCtaConsumo
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaConsumo.Appearance = Appearance8
        Me.cboCtaConsumo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaConsumo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaConsumo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaConsumo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaConsumo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaConsumo.Location = New System.Drawing.Point(124, 95)
        Me.cboCtaConsumo.Name = "cboCtaConsumo"
        Me.cboCtaConsumo.Size = New System.Drawing.Size(119, 22)
        Me.cboCtaConsumo.TabIndex = 266
        Me.cboCtaConsumo.ValueMember = "Id"
        '
        'UltraLabel4
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance9
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(23, 99)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(93, 15)
        Me.UltraLabel4.TabIndex = 265
        Me.UltraLabel4.Text = "Cuenta Consumo:"
        '
        'cboCtaCompra
        '
        Appearance10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaCompra.Appearance = Appearance10
        Me.cboCtaCompra.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaCompra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaCompra.Location = New System.Drawing.Point(124, 59)
        Me.cboCtaCompra.Name = "cboCtaCompra"
        Me.cboCtaCompra.Size = New System.Drawing.Size(119, 22)
        Me.cboCtaCompra.TabIndex = 264
        Me.cboCtaCompra.ValueMember = "Id"
        '
        'UltraLabel3
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance11
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(31, 63)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(86, 15)
        Me.UltraLabel3.TabIndex = 263
        Me.UltraLabel3.Text = "Cuenta Compra:"
        '
        'cboCtaCtble
        '
        Appearance12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaCtble.Appearance = Appearance12
        Me.cboCtaCtble.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaCtble.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaCtble.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaCtble.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaCtble.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaCtble.Location = New System.Drawing.Point(124, 26)
        Me.cboCtaCtble.Name = "cboCtaCtble"
        Me.cboCtaCtble.Size = New System.Drawing.Size(119, 22)
        Me.cboCtaCtble.TabIndex = 262
        Me.cboCtaCtble.ValueMember = "Id"
        '
        'txtCuenta
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCuenta.Appearance = Appearance13
        Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCuenta.Location = New System.Drawing.Point(249, 26)
        Me.txtCuenta.MaxLength = 100
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(404, 22)
        Me.txtCuenta.TabIndex = 261
        '
        'btnQuitarCC
        '
        Appearance14.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Appearance14.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance14.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnQuitarCC.Appearance = Appearance14
        Me.btnQuitarCC.ImageList = Me.imagenes
        Me.btnQuitarCC.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnQuitarCC.Location = New System.Drawing.Point(84, 162)
        Me.btnQuitarCC.Name = "btnQuitarCC"
        Me.btnQuitarCC.Size = New System.Drawing.Size(34, 29)
        Me.btnQuitarCC.TabIndex = 260
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
        'UltraLabel1
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance15
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(14, 30)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(101, 15)
        Me.UltraLabel1.TabIndex = 258
        Me.UltraLabel1.Text = "Cuenta Existencias:"
        '
        'btnAgregarCC
        '
        Appearance16.Image = "add.ico"
        Appearance16.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance16.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnAgregarCC.Appearance = Appearance16
        Me.btnAgregarCC.ImageList = Me.imagenes
        Me.btnAgregarCC.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarCC.Location = New System.Drawing.Point(43, 162)
        Me.btnAgregarCC.Name = "btnAgregarCC"
        Me.btnAgregarCC.Size = New System.Drawing.Size(35, 29)
        Me.btnAgregarCC.TabIndex = 257
        '
        'agrMantenimiento
        '
        Me.agrMantenimiento.Controls.Add(Me.Etiqueta4)
        Me.agrMantenimiento.Controls.Add(Me.cboFamiliaMaterial)
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
        Me.agrMantenimiento.Size = New System.Drawing.Size(1242, 153)
        Me.agrMantenimiento.TabIndex = 0
        Me.agrMantenimiento.Text = "Dato"
        Me.agrMantenimiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta4
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance17
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta4.Location = New System.Drawing.Point(47, 105)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta4.TabIndex = 12
        Me.Etiqueta4.Text = "Familia:"
        '
        'cboFamiliaMaterial
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFamiliaMaterial.Appearance = Appearance18
        Me.cboFamiliaMaterial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboFamiliaMaterial.DisplayMember = "Nombre"
        Me.cboFamiliaMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFamiliaMaterial.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFamiliaMaterial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFamiliaMaterial.ImageList = Me.imagenes
        Me.cboFamiliaMaterial.Location = New System.Drawing.Point(95, 102)
        Me.cboFamiliaMaterial.Name = "cboFamiliaMaterial"
        Me.cboFamiliaMaterial.Size = New System.Drawing.Size(348, 22)
        Me.cboFamiliaMaterial.TabIndex = 4
        Me.cboFamiliaMaterial.ValueMember = "Id"
        '
        'txtId
        '
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(11, 25)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(20, 21)
        Me.txtId.TabIndex = 10
        Me.txtId.Visible = False
        '
        'txtCodigo
        '
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance19
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtCodigo.Location = New System.Drawing.Point(95, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(90, 22)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Tag = "0"
        '
        'Etiqueta1
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance20
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(48, 29)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta1.TabIndex = 8
        Me.Etiqueta1.Text = "Código:"
        '
        'verActivo
        '
        Me.verActivo.BackColor = System.Drawing.Color.Transparent
        Me.verActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(95, 129)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(120, 20)
        Me.verActivo.TabIndex = 5
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtAbreviatura
        '
        Appearance21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance21
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtAbreviatura.Location = New System.Drawing.Point(95, 74)
        Me.txtAbreviatura.MaxLength = 10
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(90, 22)
        Me.txtAbreviatura.TabIndex = 3
        '
        'txtNombre
        '
        Appearance22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance22
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtNombre.Location = New System.Drawing.Point(95, 50)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(253, 22)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Tag = "0"
        '
        'Etiqueta3
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance23
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta3.Location = New System.Drawing.Point(25, 78)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(64, 15)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Abreviatura:"
        '
        'Etiqueta2
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance24
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(43, 54)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Nombre:"
        '
        'ficSubFamiliaMaterial
        '
        Me.ficSubFamiliaMaterial.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficSubFamiliaMaterial.Controls.Add(Me.UltraTabPageControl1)
        Me.ficSubFamiliaMaterial.Controls.Add(Me.UltraTabPageControl2)
        Me.ficSubFamiliaMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficSubFamiliaMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficSubFamiliaMaterial.Location = New System.Drawing.Point(0, 0)
        Me.ficSubFamiliaMaterial.Name = "ficSubFamiliaMaterial"
        Me.ficSubFamiliaMaterial.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficSubFamiliaMaterial.Size = New System.Drawing.Size(1244, 536)
        Me.ficSubFamiliaMaterial.TabIndex = 2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficSubFamiliaMaterial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficSubFamiliaMaterial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1242, 513)
        '
        'frm_SubFamiliaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1244, 536)
        Me.Controls.Add(Me.ficSubFamiliaMaterial)
        Me.Name = "frm_SubFamiliaMaterial"
        Me.Text = "SubFamilia de Material"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrLista.ResumeLayout(False)
        CType(Me.griSubFamiliaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odSubFamiliaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.griCtaSubFam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCtaCtbleSubFam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaCtble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMantenimiento.ResumeLayout(False)
        Me.agrMantenimiento.PerformLayout()
        CType(Me.cboFamiliaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficSubFamiliaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficSubFamiliaMaterial.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficSubFamiliaMaterial As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrLista As ISL.Controles.Agrupacion
    Friend WithEvents griSubFamiliaMaterial As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrMantenimiento As ISL.Controles.Agrupacion
    Friend WithEvents txtId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents cboFamiliaMaterial As ISL.Controles.ComboMaestros
    Friend WithEvents odSubFamiliaMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents griCtaSubFam As ISL.Controles.Grilla
    Friend WithEvents btnQuitarCC As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAgregarCC As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtCuenta As ISL.Controles.Texto
    Friend WithEvents odCtaCtbleSubFam As ISL.Controles.OrigenDatos
    Friend WithEvents cboCtaCtble As ISL.Controles.Combo
    Friend WithEvents txtCtaConsumo As ISL.Controles.Texto
    Friend WithEvents txtCtaCompra As ISL.Controles.Texto
    Friend WithEvents cboCtaConsumo As ISL.Controles.Combo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCtaCompra As ISL.Controles.Combo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboItemGasto As ISL.Controles.Combo
    Friend WithEvents filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
End Class
