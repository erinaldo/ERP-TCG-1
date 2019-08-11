<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Servicio
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
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoriaServicio")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CategoriaServicio")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidad")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidad")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ItemGasto")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaDebe")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaHaber")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaServicio")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CategoriaServicio")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidad")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidad")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ItemGasto")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaDebe")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaHaber")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdServicio")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContableHaber")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaHaber")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContableDebe")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaDebe")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejercicio")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdServicio")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContableHaber")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaHaber")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContableDebe")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaDebe")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejercicio")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Servicio))
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaServicios = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_Servicios = New ISL.Controles.Grilla(Me.components)
        Me.odServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grServCtaCtble = New ISL.Controles.Grilla(Me.components)
        Me.odServCtaCtble = New ISL.Controles.OrigenDatos(Me.components)
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.agrCuentasContables = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboItemGasto = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtCuentaHaber = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCuentaDebe = New ISL.Controles.Texto(Me.components)
        Me.Año = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero3 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero4 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero5 = New ISL.Controles.NumeroEntero(Me.components)
        Me.cboCuentaHaber = New ISL.Controles.Combo(Me.components)
        Me.btn_AddTipoCompra = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.cboCuentaDebe = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndPrecio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbCategoriaServicio = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tcServicio = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrListaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaServicios.SuspendLayout()
        CType(Me.grid_Servicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.grServCtaCtble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odServCtaCtble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.agrCuentasContables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrCuentasContables.SuspendLayout()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaHaber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaDebe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Año.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_ec032c62_34eb_4049_9cdb_33879397313b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaHaber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaDebe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategoriaServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.tcServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrListaServicios)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1022, 430)
        '
        'agrListaServicios
        '
        Me.agrListaServicios.Controls.Add(Me.grid_Servicios)
        Me.agrListaServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListaServicios.ForeColor = System.Drawing.Color.Black
        Me.agrListaServicios.Location = New System.Drawing.Point(0, 0)
        Me.agrListaServicios.Name = "agrListaServicios"
        Me.agrListaServicios.Size = New System.Drawing.Size(1022, 430)
        Me.agrListaServicios.TabIndex = 1
        Me.agrListaServicios.Text = "Total de Servicios:"
        Me.agrListaServicios.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grid_Servicios
        '
        Me.grid_Servicios.DataSource = Me.odServicio
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Width = 450
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.grid_Servicios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_Servicios.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Servicios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Servicios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Servicios.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_Servicios.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_Servicios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_Servicios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Servicios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Servicios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Servicios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_Servicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Servicios.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Servicios.Location = New System.Drawing.Point(3, 16)
        Me.grid_Servicios.Name = "grid_Servicios"
        Me.grid_Servicios.Size = New System.Drawing.Size(1016, 411)
        Me.grid_Servicios.TabIndex = 4
        Me.grid_Servicios.Text = "Listado de Servicios"
        '
        'odServicio
        '
        UltraDataColumn9.DataType = GetType(Boolean)
        Me.odServicio.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.grServCtaCtble)
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1022, 430)
        '
        'grServCtaCtble
        '
        Me.grServCtaCtble.DataSource = Me.odServCtaCtble
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn24.Header.VisiblePosition = 6
        UltraGridColumn25.Header.VisiblePosition = 7
        UltraGridColumn25.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25})
        UltraGridBand2.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grServCtaCtble.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grServCtaCtble.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grServCtaCtble.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grServCtaCtble.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grServCtaCtble.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grServCtaCtble.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grServCtaCtble.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grServCtaCtble.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grServCtaCtble.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grServCtaCtble.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grServCtaCtble.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grServCtaCtble.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grServCtaCtble.Location = New System.Drawing.Point(0, 214)
        Me.grServCtaCtble.Name = "grServCtaCtble"
        Me.grServCtaCtble.Size = New System.Drawing.Size(1022, 216)
        Me.grServCtaCtble.TabIndex = 236
        '
        'odServCtaCtble
        '
        Me.odServCtaCtble.Band.Columns.AddRange(New Object() {UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25})
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.agrCuentasContables)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.ndPrecio)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel3)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel2)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cmbCategoriaServicio)
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
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(1022, 214)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos:"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'agrCuentasContables
        '
        Me.agrCuentasContables.Controls.Add(Me.UltraLabel7)
        Me.agrCuentasContables.Controls.Add(Me.cboItemGasto)
        Me.agrCuentasContables.Controls.Add(Me.txtCuentaHaber)
        Me.agrCuentasContables.Controls.Add(Me.UltraLabel8)
        Me.agrCuentasContables.Controls.Add(Me.txtCuentaDebe)
        Me.agrCuentasContables.Controls.Add(Me.Año)
        Me.agrCuentasContables.Controls.Add(Me.cboCuentaHaber)
        Me.agrCuentasContables.Controls.Add(Me.btn_AddTipoCompra)
        Me.agrCuentasContables.Controls.Add(Me.cboCuentaDebe)
        Me.agrCuentasContables.Controls.Add(Me.UltraLabel6)
        Me.agrCuentasContables.Controls.Add(Me.UltraLabel5)
        Me.agrCuentasContables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCuentasContables.ForeColor = System.Drawing.Color.Black
        Me.agrCuentasContables.Location = New System.Drawing.Point(479, 25)
        Me.agrCuentasContables.Name = "agrCuentasContables"
        Me.agrCuentasContables.Size = New System.Drawing.Size(486, 146)
        Me.agrCuentasContables.TabIndex = 50
        Me.agrCuentasContables.Text = "Cuentas Contables"
        Me.agrCuentasContables.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel7
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance1
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(31, 118)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel7.TabIndex = 56
        Me.UltraLabel7.Text = "Item Gasto:"
        '
        'cboItemGasto
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.Appearance = Appearance2
        Me.cboItemGasto.DisplayMember = "Nombre"
        Me.cboItemGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboItemGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboItemGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemGasto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.Location = New System.Drawing.Point(99, 114)
        Me.cboItemGasto.Name = "cboItemGasto"
        Me.cboItemGasto.Size = New System.Drawing.Size(372, 21)
        Me.cboItemGasto.TabIndex = 8
        Me.cboItemGasto.ValueMember = "Id"
        '
        'txtCuentaHaber
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.txtCuentaHaber.Appearance = Appearance3
        Me.txtCuentaHaber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaHaber.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuentaHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaHaber.ForeColor = System.Drawing.Color.Black
        Me.txtCuentaHaber.Location = New System.Drawing.Point(204, 85)
        Me.txtCuentaHaber.MaxLength = 3000
        Me.txtCuentaHaber.Name = "txtCuentaHaber"
        Me.txtCuentaHaber.ReadOnly = True
        Me.txtCuentaHaber.Size = New System.Drawing.Size(267, 21)
        Me.txtCuentaHaber.TabIndex = 237
        Me.txtCuentaHaber.TabStop = False
        '
        'UltraLabel8
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance4
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(41, 29)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel8.TabIndex = 235
        Me.UltraLabel8.Text = "Ejericicio:"
        '
        'txtCuentaDebe
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.txtCuentaDebe.Appearance = Appearance5
        Me.txtCuentaDebe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaDebe.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuentaDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaDebe.ForeColor = System.Drawing.Color.Black
        Me.txtCuentaDebe.Location = New System.Drawing.Point(204, 54)
        Me.txtCuentaDebe.MaxLength = 3000
        Me.txtCuentaDebe.Name = "txtCuentaDebe"
        Me.txtCuentaDebe.ReadOnly = True
        Me.txtCuentaDebe.Size = New System.Drawing.Size(267, 21)
        Me.txtCuentaDebe.TabIndex = 7
        Me.txtCuentaDebe.TabStop = False
        '
        'Año
        '
        Me.Año.Año = 2014
        Me.Año.Controls.Add(Me.numAño)
        Me.Año.Controls.Add(Me.NumeroEntero1)
        Me.Año.Controls.Add(Me.object_ec032c62_34eb_4049_9cdb_33879397313b)
        Me.Año.Controls.Add(Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b)
        Me.Año.Controls.Add(Me.NumeroEntero3)
        Me.Año.Controls.Add(Me.NumeroEntero4)
        Me.Año.Controls.Add(Me.NumeroEntero5)
        Me.Año.Location = New System.Drawing.Point(99, 22)
        Me.Año.Name = "Año"
        Me.Año.Size = New System.Drawing.Size(54, 23)
        Me.Año.TabIndex = 5
        '
        'numAño
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance6
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
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance7
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
        Me.NumeroEntero1.Value = 2012
        '
        'object_ec032c62_34eb_4049_9cdb_33879397313b
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Appearance = Appearance8
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.ForeColor = System.Drawing.Color.Black
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.FormatString = ""
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Location = New System.Drawing.Point(1, 0)
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.MaskInput = "nnnn"
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.MaxValue = 2020
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.MinValue = 2000
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Name = "object_ec032c62_34eb_4049_9cdb_33879397313b"
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.NullText = "0"
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Size = New System.Drawing.Size(52, 21)
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.TabIndex = 0
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b.Value = 2012
        '
        'object_1747ffef_29a8_4267_84e6_e88591c0ec4b
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Appearance = Appearance9
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.ForeColor = System.Drawing.Color.Black
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.FormatString = ""
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Location = New System.Drawing.Point(1, 0)
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.MaskInput = "nnnn"
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.MaxValue = 2020
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.MinValue = 2000
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Name = "object_1747ffef_29a8_4267_84e6_e88591c0ec4b"
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.NullText = "0"
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Size = New System.Drawing.Size(52, 21)
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.TabIndex = 0
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b.Value = 2012
        '
        'NumeroEntero3
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.Appearance = Appearance10
        Me.NumeroEntero3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero3.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.FormatString = ""
        Me.NumeroEntero3.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero3.MaskInput = "nnnn"
        Me.NumeroEntero3.MaxValue = 2020
        Me.NumeroEntero3.MinValue = 2000
        Me.NumeroEntero3.Name = "NumeroEntero3"
        Me.NumeroEntero3.NullText = "0"
        Me.NumeroEntero3.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero3.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero3.TabIndex = 0
        Me.NumeroEntero3.Value = 2012
        '
        'NumeroEntero4
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.Appearance = Appearance11
        Me.NumeroEntero4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero4.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.FormatString = ""
        Me.NumeroEntero4.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero4.MaskInput = "nnnn"
        Me.NumeroEntero4.MaxValue = 2020
        Me.NumeroEntero4.MinValue = 2000
        Me.NumeroEntero4.Name = "NumeroEntero4"
        Me.NumeroEntero4.NullText = "0"
        Me.NumeroEntero4.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero4.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero4.TabIndex = 0
        Me.NumeroEntero4.Value = 2012
        '
        'NumeroEntero5
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.Appearance = Appearance12
        Me.NumeroEntero5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero5.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.FormatString = ""
        Me.NumeroEntero5.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero5.MaskInput = "nnnn"
        Me.NumeroEntero5.MaxValue = 2020
        Me.NumeroEntero5.MinValue = 2000
        Me.NumeroEntero5.Name = "NumeroEntero5"
        Me.NumeroEntero5.NullText = "0"
        Me.NumeroEntero5.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero5.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero5.TabIndex = 0
        Me.NumeroEntero5.Value = 2012
        '
        'cboCuentaHaber
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaHaber.Appearance = Appearance13
        Me.cboCuentaHaber.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaHaber.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaHaber.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaHaber.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaHaber.Location = New System.Drawing.Point(99, 85)
        Me.cboCuentaHaber.Name = "cboCuentaHaber"
        Me.cboCuentaHaber.Size = New System.Drawing.Size(82, 21)
        Me.cboCuentaHaber.TabIndex = 7
        Me.cboCuentaHaber.ValueMember = "Id"
        '
        'btn_AddTipoCompra
        '
        Appearance14.Image = "add.ico"
        Me.btn_AddTipoCompra.Appearance = Appearance14
        Me.btn_AddTipoCompra.ImageList = Me.imagenes
        Me.btn_AddTipoCompra.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_AddTipoCompra.Location = New System.Drawing.Point(204, 21)
        Me.btn_AddTipoCompra.Name = "btn_AddTipoCompra"
        Me.btn_AddTipoCompra.Size = New System.Drawing.Size(30, 30)
        Me.btn_AddTipoCompra.TabIndex = 232
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
        'cboCuentaDebe
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaDebe.Appearance = Appearance15
        Me.cboCuentaDebe.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaDebe.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaDebe.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaDebe.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaDebe.Location = New System.Drawing.Point(99, 54)
        Me.cboCuentaDebe.Name = "cboCuentaDebe"
        Me.cboCuentaDebe.Size = New System.Drawing.Size(82, 21)
        Me.cboCuentaDebe.TabIndex = 6
        Me.cboCuentaDebe.ValueMember = "Id"
        '
        'UltraLabel6
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance16
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(16, 89)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(78, 14)
        Me.UltraLabel6.TabIndex = 52
        Me.UltraLabel6.Text = "Cuenta Haber:"
        '
        'UltraLabel5
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Appearance17.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance17
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(20, 58)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel5.TabIndex = 51
        Me.UltraLabel5.Text = "Cuenta Debe:"
        '
        'ndPrecio
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndPrecio.Appearance = Appearance18
        Me.ndPrecio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndPrecio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndPrecio.Location = New System.Drawing.Point(96, 106)
        Me.ndPrecio.Name = "ndPrecio"
        Me.ndPrecio.NullText = "0.00"
        Me.ndPrecio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndPrecio.Size = New System.Drawing.Size(100, 21)
        Me.ndPrecio.TabIndex = 3
        '
        'UltraLabel3
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance19
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(48, 108)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel3.TabIndex = 48
        Me.UltraLabel3.Text = "Precio:"
        '
        'UltraLabel2
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance20
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(35, 54)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel2.TabIndex = 46
        Me.UltraLabel2.Text = "Categoría:"
        '
        'cmbCategoriaServicio
        '
        Appearance21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbCategoriaServicio.Appearance = Appearance21
        Me.cmbCategoriaServicio.DisplayMember = "Nombre"
        Me.cmbCategoriaServicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbCategoriaServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoriaServicio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbCategoriaServicio.Location = New System.Drawing.Point(96, 52)
        Me.cmbCategoriaServicio.Name = "cmbCategoriaServicio"
        Me.cmbCategoriaServicio.Size = New System.Drawing.Size(352, 21)
        Me.cmbCategoriaServicio.TabIndex = 1
        Me.cmbCategoriaServicio.ValueMember = "Id"
        '
        'UltraLabel1
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance22
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(24, 133)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel1.TabIndex = 11
        Me.UltraLabel1.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Appearance23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Appearance = Appearance23
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Location = New System.Drawing.Point(96, 133)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(352, 46)
        Me.txtDescripcion.TabIndex = 4
        '
        'txtCodigo
        '
        Appearance24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance24
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(96, 25)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(90, 21)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TabStop = False
        '
        'verActivo
        '
        Me.verActivo.BackColor = System.Drawing.Color.Transparent
        Me.verActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(96, 185)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 9
        Me.verActivo.TabStop = False
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtNombre
        '
        Appearance25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance25
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(96, 79)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(352, 21)
        Me.txtNombre.TabIndex = 2
        '
        'UltraLabel22
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Appearance26.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance26
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(43, 81)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel22.TabIndex = 3
        Me.UltraLabel22.Text = "Nombre:"
        '
        'UltraLabel4
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Appearance27.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance27
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(48, 27)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 1
        Me.UltraLabel4.Text = "Código:"
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Material o artículo"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Material seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Material seleccionado"
        '
        'tcServicio
        '
        Me.tcServicio.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcServicio.Controls.Add(Me.UltraTabPageControl7)
        Me.tcServicio.Controls.Add(Me.utpDetalle)
        Me.tcServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcServicio.Location = New System.Drawing.Point(0, 0)
        Me.tcServicio.Name = "tcServicio"
        Me.tcServicio.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcServicio.Size = New System.Drawing.Size(1024, 453)
        Me.tcServicio.TabIndex = 4
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.tcServicio.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcServicio.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1022, 430)
        '
        'frm_Servicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1024, 453)
        Me.Controls.Add(Me.tcServicio)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Servicio"
        Me.Text = "Servicios"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrListaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaServicios.ResumeLayout(False)
        CType(Me.grid_Servicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.grServCtaCtble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odServCtaCtble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.agrCuentasContables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrCuentasContables.ResumeLayout(False)
        Me.agrCuentasContables.PerformLayout()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaHaber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaDebe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Año.ResumeLayout(False)
        Me.Año.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_ec032c62_34eb_4049_9cdb_33879397313b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaHaber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaDebe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategoriaServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.tcServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcServicio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcServicio As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaServicios As ISL.Controles.Agrupacion
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbCategoriaServicio As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndPrecio As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odServicio As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrCuentasContables As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboItemGasto As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grid_Servicios As ISL.Controles.Grilla
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Año As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents object_ec032c62_34eb_4049_9cdb_33879397313b As ISL.Controles.NumeroEntero
    Friend WithEvents object_1747ffef_29a8_4267_84e6_e88591c0ec4b As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero3 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero4 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero5 As ISL.Controles.NumeroEntero
    Friend WithEvents btn_AddTipoCompra As Infragistics.Win.Misc.UltraButton
    Friend WithEvents odServCtaCtble As ISL.Controles.OrigenDatos
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents grServCtaCtble As ISL.Controles.Grilla
    Friend WithEvents txtCuentaHaber As ISL.Controles.Texto
    Friend WithEvents txtCuentaDebe As ISL.Controles.Texto
    Friend WithEvents cboCuentaHaber As ISL.Controles.Combo
    Friend WithEvents cboCuentaDebe As ISL.Controles.Combo

End Class
