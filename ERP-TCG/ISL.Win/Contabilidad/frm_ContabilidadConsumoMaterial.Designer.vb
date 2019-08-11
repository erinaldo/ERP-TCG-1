<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ContabilidadConsumoMaterial
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrifo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccion")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrifo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDireccion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable61")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta61")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Equipo")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMotriz")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoFuncion")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbrevGasto")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gasto")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable61")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta61")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Equipo")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndMotriz")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoFuncion")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbrevGasto")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gasto")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrFiltro = New ISL.Controles.Agrupacion(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.griListaSubAlmacen = New ISL.Controles.Grilla(Me.components)
        Me.odSubAlmacen = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.gbDatosAdicionales = New System.Windows.Forms.GroupBox()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.Año1 = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAlmacen = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.gridConsumo = New ISL.Controles.Grilla(Me.components)
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabSharedControlsPage1_Fill_Panel = New System.Windows.Forms.Panel()
        Me.UltraToolbarsDockArea11 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea12 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea9 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea10 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.ficInventario = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Ficha1 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFiltro.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.griListaSubAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odSubAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Año1.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.gridConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrFiltro)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTabSharedControlsPage1_Fill_Panel)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea11)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea12)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea9)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea10)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1190, 513)
        '
        'agrFiltro
        '
        Me.agrFiltro.Controls.Add(Me.SplitContainer1)
        Me.agrFiltro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFiltro.ForeColor = System.Drawing.Color.Black
        Me.agrFiltro.Location = New System.Drawing.Point(0, 0)
        Me.agrFiltro.Name = "agrFiltro"
        Me.agrFiltro.Size = New System.Drawing.Size(1190, 513)
        Me.agrFiltro.TabIndex = 0
        Me.agrFiltro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbDatosAdicionales)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Agrupacion1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1186, 509)
        Me.SplitContainer1.SplitterDistance = 165
        Me.SplitContainer1.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.griListaSubAlmacen)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(359, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(825, 163)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'griListaSubAlmacen
        '
        Me.griListaSubAlmacen.DataSource = Me.odSubAlmacen
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 249
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 12
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Width = 319
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn13.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.griListaSubAlmacen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaSubAlmacen.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaSubAlmacen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaSubAlmacen.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaSubAlmacen.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaSubAlmacen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaSubAlmacen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaSubAlmacen.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaSubAlmacen.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griListaSubAlmacen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaSubAlmacen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaSubAlmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaSubAlmacen.Location = New System.Drawing.Point(3, 16)
        Me.griListaSubAlmacen.Name = "griListaSubAlmacen"
        Me.griListaSubAlmacen.Size = New System.Drawing.Size(819, 144)
        Me.griListaSubAlmacen.TabIndex = 3
        Me.griListaSubAlmacen.Text = "Sub Almacenes:"
        '
        'odSubAlmacen
        '
        Me.odSubAlmacen.AllowAdd = False
        Me.odSubAlmacen.AllowDelete = False
        UltraDataColumn2.DataType = GetType(Boolean)
        UltraDataColumn11.DataType = GetType(Boolean)
        Me.odSubAlmacen.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta7)
        Me.gbDatosAdicionales.Controls.Add(Me.cboMes)
        Me.gbDatosAdicionales.Controls.Add(Me.Año1)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta8)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta13)
        Me.gbDatosAdicionales.Controls.Add(Me.cboAlmacen)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta5)
        Me.gbDatosAdicionales.Controls.Add(Me.cboCentro)
        Me.gbDatosAdicionales.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(0, 0)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(359, 163)
        Me.gbDatosAdicionales.TabIndex = 2
        Me.gbDatosAdicionales.TabStop = False
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(128, 73)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(26, 14)
        Me.Etiqueta7.TabIndex = 13
        Me.Etiqueta7.Text = "Mes"
        '
        'cboMes
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance1
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(157, 69)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(47, 21)
        Me.cboMes.TabIndex = 12
        Me.cboMes.ValueMember = "Id"
        '
        'Año1
        '
        Me.Año1.Año = 2015
        Me.Año1.Controls.Add(Me.numAño)
        Me.Año1.Controls.Add(Me.NumeroEntero1)
        Me.Año1.Controls.Add(Me.NumeroEntero2)
        Me.Año1.Location = New System.Drawing.Point(68, 69)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(54, 23)
        Me.Año1.TabIndex = 11
        '
        'numAño
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance2
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
        Me.numAño.Value = 2012
        '
        'NumeroEntero1
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance3
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
        Me.NumeroEntero1.Value = 2011
        '
        'NumeroEntero2
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.Appearance = Appearance4
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
        Me.NumeroEntero2.Value = 2011
        '
        'Etiqueta8
        '
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(14, 72)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta8.TabIndex = 10
        Me.Etiqueta8.Text = "Ejercicio"
        '
        'Etiqueta13
        '
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(15, 46)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta13.TabIndex = 9
        Me.Etiqueta13.Text = "Almacen"
        '
        'cboAlmacen
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Appearance = Appearance5
        Me.cboAlmacen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboAlmacen.DisplayMember = "Nombre"
        Me.cboAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAlmacen.DropDownListWidth = 280
        Me.cboAlmacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Location = New System.Drawing.Point(68, 42)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(275, 21)
        Me.cboAlmacen.TabIndex = 8
        Me.cboAlmacen.ValueMember = "Id"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(25, 19)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta5.TabIndex = 7
        Me.Etiqueta5.Text = "Centro"
        '
        'cboCentro
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance6
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownListWidth = 180
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(68, 15)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(94, 21)
        Me.cboCentro.TabIndex = 6
        Me.cboCentro.ValueMember = "Id"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.gridConsumo)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1184, 338)
        Me.Agrupacion1.TabIndex = 2
        Me.Agrupacion1.Text = "Consumo de Almacen:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gridConsumo
        '
        Me.gridConsumo.DataSource = Me.UltraDataSource1
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn18.Header.VisiblePosition = 4
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.Width = 113
        UltraGridColumn20.Header.VisiblePosition = 6
        UltraGridColumn20.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance7
        UltraGridColumn21.Format = "#,##0.00"
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn21.MaskInput = "{double:9.4}"
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 9
        UltraGridColumn24.Header.VisiblePosition = 10
        UltraGridColumn24.Width = 202
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24})
        UltraGridBand2.SummaryFooterCaption = "Total"
        Me.gridConsumo.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridConsumo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridConsumo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridConsumo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridConsumo.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridConsumo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridConsumo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridConsumo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridConsumo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridConsumo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridConsumo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridConsumo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridConsumo.Location = New System.Drawing.Point(3, 16)
        Me.gridConsumo.Name = "gridConsumo"
        Me.gridConsumo.Size = New System.Drawing.Size(1178, 319)
        Me.gridConsumo.TabIndex = 4
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.AllowAdd = False
        Me.UltraDataSource1.AllowDelete = False
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        '
        'UltraTabSharedControlsPage1_Fill_Panel
        '
        Me.UltraTabSharedControlsPage1_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.UltraTabSharedControlsPage1_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabSharedControlsPage1_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabSharedControlsPage1_Fill_Panel.Name = "UltraTabSharedControlsPage1_Fill_Panel"
        Me.UltraTabSharedControlsPage1_Fill_Panel.Size = New System.Drawing.Size(1190, 513)
        Me.UltraTabSharedControlsPage1_Fill_Panel.TabIndex = 0
        '
        'UltraToolbarsDockArea11
        '
        Me.UltraToolbarsDockArea11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea11.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea11.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea11.Name = "UltraToolbarsDockArea11"
        Me.UltraToolbarsDockArea11.Size = New System.Drawing.Size(0, 513)
        '
        'UltraToolbarsDockArea12
        '
        Me.UltraToolbarsDockArea12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea12.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea12.Location = New System.Drawing.Point(1190, 0)
        Me.UltraToolbarsDockArea12.Name = "UltraToolbarsDockArea12"
        Me.UltraToolbarsDockArea12.Size = New System.Drawing.Size(0, 513)
        '
        'UltraToolbarsDockArea9
        '
        Me.UltraToolbarsDockArea9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea9.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea9.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea9.Name = "UltraToolbarsDockArea9"
        Me.UltraToolbarsDockArea9.Size = New System.Drawing.Size(1190, 0)
        '
        'UltraToolbarsDockArea10
        '
        Me.UltraToolbarsDockArea10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea10.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea10.Location = New System.Drawing.Point(0, 513)
        Me.UltraToolbarsDockArea10.Name = "UltraToolbarsDockArea10"
        Me.UltraToolbarsDockArea10.Size = New System.Drawing.Size(1190, 0)
        '
        'ficInventario
        '
        Me.ficInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficInventario.Location = New System.Drawing.Point(0, 0)
        Me.ficInventario.Name = "ficInventario"
        Me.ficInventario.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficInventario.Size = New System.Drawing.Size(200, 100)
        Me.ficInventario.TabIndex = 0
        Me.ficInventario.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(198, 79)
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1190, 513)
        '
        'Ficha1
        '
        Me.Ficha1.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl1)
        Me.Ficha1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ficha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha1.Location = New System.Drawing.Point(0, 0)
        Me.Ficha1.Name = "Ficha1"
        Me.Ficha1.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.Ficha1.Size = New System.Drawing.Size(1192, 536)
        Me.Ficha1.TabIndex = 12
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Inventario"
        Me.Ficha1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        Me.Ficha1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'frm_ContabilidadConsumoMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1192, 536)
        Me.Controls.Add(Me.Ficha1)
        Me.Name = "frm_ContabilidadConsumoMaterial"
        Me.Text = "Consumo Material"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFiltro.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.griListaSubAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odSubAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Año1.ResumeLayout(False)
        Me.Año1.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.gridConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficInventario As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents odSubAlmacen As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrFiltro As ISL.Controles.Agrupacion
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents griListaSubAlmacen As ISL.Controles.Grilla
    Friend WithEvents gbDatosAdicionales As System.Windows.Forms.GroupBox
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero2 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents cboAlmacen As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabSharedControlsPage1_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents UltraToolbarsDockArea11 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea12 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea9 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea10 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents Ficha1 As ISL.Controles.Ficha
    Friend WithEvents gridConsumo As ISL.Controles.Grilla
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Filtro1 As ISL.Controles.Filtro

End Class
