<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoCompra
    Inherits ISL.Win.frm_MenuPadre

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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTablaContableDet")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta60")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable60")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta61")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable61")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejercicio")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTablaContableDet")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta60")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable60")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta61")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable61")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejercicio")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTabla")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto1")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto2")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto3")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor1")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor2")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor3")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Logico1")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Logico2")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Logico3")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTabla")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto1")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto2")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto3")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor1")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor2")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor3")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Logico1")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Logico2")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Logico3")
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TipoCompra))
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
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grTipoCompra = New ISL.Controles.Grilla(Me.components)
        Me.odTipoCompra = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.grTablaCtbleDet = New ISL.Controles.Grilla(Me.components)
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.odTablaCtbleDet = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tc_DetalleTipoCompra = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtCuenta61 = New ISL.Controles.Texto(Me.components)
        Me.txtCuenta60 = New ISL.Controles.Texto(Me.components)
        Me.btn_DelTipoCompra = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.cboCuenta61 = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.btn_AddTipoCompra = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Año = New ISL.Win.Año()
        Me.object_ec032c62_34eb_4049_9cdb_33879397313b = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero3 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero4 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero5 = New ISL.Controles.NumeroEntero(Me.components)
        Me.cboCuenta60 = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCuenta = New ISL.Controles.Texto(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.tc_TipoCompra = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.grTipoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odTipoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.grTablaCtbleDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.odTablaCtbleDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.tc_DetalleTipoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_DetalleTipoCompra.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.txtCuenta61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuenta61, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Año.SuspendLayout()
        CType(Me.object_ec032c62_34eb_4049_9cdb_33879397313b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuenta60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tc_TipoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_TipoCompra.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.grTipoCompra)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(844, 380)
        '
        'grTipoCompra
        '
        Me.grTipoCompra.DataSource = Me.odTipoCompra
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grTipoCompra.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grTipoCompra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grTipoCompra.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grTipoCompra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grTipoCompra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grTipoCompra.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grTipoCompra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grTipoCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grTipoCompra.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grTipoCompra.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grTipoCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grTipoCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grTipoCompra.Location = New System.Drawing.Point(0, 0)
        Me.grTipoCompra.Name = "grTipoCompra"
        Me.grTipoCompra.Size = New System.Drawing.Size(844, 380)
        Me.grTipoCompra.TabIndex = 237
        '
        'odTipoCompra
        '
        Me.odTipoCompra.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(844, 380)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(846, 550)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.grTablaCtbleDet)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(846, 550)
        Me.Agrupacion1.TabIndex = 2
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grTablaCtbleDet
        '
        Me.grTablaCtbleDet.ContextMenuStrip = Me.MenuDetalle
        Me.grTablaCtbleDet.DataSource = Me.odTablaCtbleDet
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn12.Width = 450
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 5
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 6
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 7
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 8
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 9
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 10
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 11
        UltraGridColumn21.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        Me.grTablaCtbleDet.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grTablaCtbleDet.DisplayLayout.MaxColScrollRegions = 1
        Me.grTablaCtbleDet.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grTablaCtbleDet.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grTablaCtbleDet.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grTablaCtbleDet.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grTablaCtbleDet.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grTablaCtbleDet.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grTablaCtbleDet.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grTablaCtbleDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grTablaCtbleDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grTablaCtbleDet.Location = New System.Drawing.Point(2, 2)
        Me.grTablaCtbleDet.Name = "grTablaCtbleDet"
        Me.grTablaCtbleDet.Size = New System.Drawing.Size(842, 546)
        Me.grTablaCtbleDet.TabIndex = 3
        Me.grTablaCtbleDet.Text = "Información sobre Tipo Compra"
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.mnuEliminar})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(122, 56)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Size = New System.Drawing.Size(121, 26)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'odTablaCtbleDet
        '
        Me.odTablaCtbleDet.Band.Columns.AddRange(New Object() {UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.tc_DetalleTipoCompra)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(846, 550)
        '
        'tc_DetalleTipoCompra
        '
        Me.tc_DetalleTipoCompra.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tc_DetalleTipoCompra.Controls.Add(Me.UltraTabPageControl3)
        Me.tc_DetalleTipoCompra.Controls.Add(Me.UltraTabPageControl4)
        Me.tc_DetalleTipoCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_DetalleTipoCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_DetalleTipoCompra.Location = New System.Drawing.Point(0, 147)
        Me.tc_DetalleTipoCompra.Name = "tc_DetalleTipoCompra"
        Me.tc_DetalleTipoCompra.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tc_DetalleTipoCompra.Size = New System.Drawing.Size(846, 403)
        Me.tc_DetalleTipoCompra.TabIndex = 231
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Tipo Compra"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Asociacion"
        Me.tc_DetalleTipoCompra.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.tc_DetalleTipoCompra.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(844, 380)
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.txtCuenta61)
        Me.Agrupacion3.Controls.Add(Me.txtCuenta60)
        Me.Agrupacion3.Controls.Add(Me.btn_DelTipoCompra)
        Me.Agrupacion3.Controls.Add(Me.cboCuenta61)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion3.Controls.Add(Me.btn_AddTipoCompra)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion3.Controls.Add(Me.Año)
        Me.Agrupacion3.Controls.Add(Me.cboCuenta60)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion3.Controls.Add(Me.txtCuenta)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 57)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(846, 90)
        Me.Agrupacion3.TabIndex = 230
        Me.Agrupacion3.Text = "Tipo Compra Detalle"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtCuenta61
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.txtCuenta61.Appearance = Appearance1
        Me.txtCuenta61.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta61.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuenta61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta61.ForeColor = System.Drawing.Color.Black
        Me.txtCuenta61.Location = New System.Drawing.Point(438, 57)
        Me.txtCuenta61.MaxLength = 3000
        Me.txtCuenta61.Name = "txtCuenta61"
        Me.txtCuenta61.ReadOnly = True
        Me.txtCuenta61.Size = New System.Drawing.Size(301, 21)
        Me.txtCuenta61.TabIndex = 233
        '
        'txtCuenta60
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.txtCuenta60.Appearance = Appearance2
        Me.txtCuenta60.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta60.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuenta60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta60.ForeColor = System.Drawing.Color.Black
        Me.txtCuenta60.Location = New System.Drawing.Point(438, 27)
        Me.txtCuenta60.MaxLength = 3000
        Me.txtCuenta60.Name = "txtCuenta60"
        Me.txtCuenta60.ReadOnly = True
        Me.txtCuenta60.Size = New System.Drawing.Size(301, 21)
        Me.txtCuenta60.TabIndex = 232
        '
        'btn_DelTipoCompra
        '
        Appearance3.Image = "del.ico"
        Me.btn_DelTipoCompra.Appearance = Appearance3
        Me.btn_DelTipoCompra.ImageList = Me.imagenes
        Me.btn_DelTipoCompra.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_DelTipoCompra.Location = New System.Drawing.Point(745, 54)
        Me.btn_DelTipoCompra.Name = "btn_DelTipoCompra"
        Me.btn_DelTipoCompra.Size = New System.Drawing.Size(30, 30)
        Me.btn_DelTipoCompra.TabIndex = 231
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
        'cboCuenta61
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuenta61.Appearance = Appearance4
        Me.cboCuenta61.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuenta61.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuenta61.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuenta61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuenta61.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuenta61.Location = New System.Drawing.Point(316, 57)
        Me.cboCuenta61.Name = "cboCuenta61"
        Me.cboCuenta61.Size = New System.Drawing.Size(116, 21)
        Me.cboCuenta61.TabIndex = 230
        Me.cboCuenta61.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance5
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(253, 61)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(56, 14)
        Me.Etiqueta1.TabIndex = 229
        Me.Etiqueta1.Text = "Cuenta61:"
        '
        'btn_AddTipoCompra
        '
        Appearance6.Image = "add.ico"
        Me.btn_AddTipoCompra.Appearance = Appearance6
        Me.btn_AddTipoCompra.ImageList = Me.imagenes
        Me.btn_AddTipoCompra.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_AddTipoCompra.Location = New System.Drawing.Point(745, 21)
        Me.btn_AddTipoCompra.Name = "btn_AddTipoCompra"
        Me.btn_AddTipoCompra.Size = New System.Drawing.Size(30, 30)
        Me.btn_AddTipoCompra.TabIndex = 228
        '
        'Etiqueta3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance7
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(14, 31)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta3.TabIndex = 227
        Me.Etiqueta3.Text = "Ejercicio:"
        '
        'Año
        '
        Me.Año.Año = 2014
        Me.Año.Controls.Add(Me.object_ec032c62_34eb_4049_9cdb_33879397313b)
        Me.Año.Controls.Add(Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b)
        Me.Año.Controls.Add(Me.NumeroEntero3)
        Me.Año.Controls.Add(Me.NumeroEntero4)
        Me.Año.Controls.Add(Me.NumeroEntero5)
        Me.Año.Location = New System.Drawing.Point(68, 27)
        Me.Año.Name = "Año"
        Me.Año.Size = New System.Drawing.Size(54, 23)
        Me.Año.TabIndex = 226
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
        'cboCuenta60
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuenta60.Appearance = Appearance13
        Me.cboCuenta60.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuenta60.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuenta60.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuenta60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuenta60.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuenta60.Location = New System.Drawing.Point(316, 27)
        Me.cboCuenta60.Name = "cboCuenta60"
        Me.cboCuenta60.Size = New System.Drawing.Size(116, 21)
        Me.cboCuenta60.TabIndex = 222
        Me.cboCuenta60.ValueMember = "Id"
        '
        'Etiqueta4
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance14
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(253, 31)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(56, 14)
        Me.Etiqueta4.TabIndex = 221
        Me.Etiqueta4.Text = "Cuenta60:"
        '
        'Etiqueta5
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance15
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(18, 61)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta5.TabIndex = 1
        Me.Etiqueta5.Text = "Cuenta:"
        '
        'txtCuenta
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.txtCuenta.Appearance = Appearance16
        Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.Black
        Me.txtCuenta.Location = New System.Drawing.Point(68, 57)
        Me.txtCuenta.MaxLength = 3000
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(151, 21)
        Me.txtCuenta.TabIndex = 0
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.txtNombre)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(846, 57)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta2
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance17
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(6, 23)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Nombre:"
        '
        'txtNombre
        '
        Appearance18.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Appearance = Appearance18
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(68, 21)
        Me.txtNombre.MaxLength = 3000
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(466, 21)
        Me.txtNombre.TabIndex = 0
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(846, 550)
        '
        'tc_TipoCompra
        '
        Me.tc_TipoCompra.Controls.Add(Me.UltraTabPageControl1)
        Me.tc_TipoCompra.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tc_TipoCompra.Controls.Add(Me.UltraTabPageControl2)
        Me.tc_TipoCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_TipoCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_TipoCompra.Location = New System.Drawing.Point(0, 0)
        Me.tc_TipoCompra.Name = "tc_TipoCompra"
        Me.tc_TipoCompra.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tc_TipoCompra.Size = New System.Drawing.Size(848, 573)
        Me.tc_TipoCompra.TabIndex = 3
        UltraTab5.Key = "Lista"
        UltraTab5.TabPage = Me.UltraTabPageControl1
        UltraTab5.Text = "Lista"
        UltraTab6.Key = "Mantenimiento"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "Mantenimiento"
        Me.tc_TipoCompra.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        Me.tc_TipoCompra.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'frm_TipoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 573)
        Me.Controls.Add(Me.tc_TipoCompra)
        Me.Name = "frm_TipoCompra"
        Me.Text = "Tipo Compra"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.grTipoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odTipoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.grTablaCtbleDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.odTablaCtbleDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.tc_DetalleTipoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_DetalleTipoCompra.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.txtCuenta61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuenta61, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Año.ResumeLayout(False)
        Me.Año.PerformLayout()
        CType(Me.object_ec032c62_34eb_4049_9cdb_33879397313b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_1747ffef_29a8_4267_84e6_e88591c0ec4b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuenta60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tc_TipoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_TipoCompra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents odTipoCompra As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odTablaCtbleDet As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents cboCuenta61 As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents btn_AddTipoCompra As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Año As ISL.Win.Año
    Friend WithEvents object_ec032c62_34eb_4049_9cdb_33879397313b As ISL.Controles.NumeroEntero
    Friend WithEvents object_1747ffef_29a8_4267_84e6_e88591c0ec4b As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero3 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero4 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero5 As ISL.Controles.NumeroEntero
    Friend WithEvents cboCuenta60 As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents txtCuenta As ISL.Controles.Texto
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents grTablaCtbleDet As ISL.Controles.Grilla
    Friend WithEvents tc_TipoCompra As ISL.Controles.Ficha
    Friend WithEvents tc_DetalleTipoCompra As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grTipoCompra As ISL.Controles.Grilla
    Friend WithEvents btn_DelTipoCompra As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtCuenta60 As ISL.Controles.Texto
    Friend WithEvents txtCuenta61 As ISL.Controles.Texto
End Class
