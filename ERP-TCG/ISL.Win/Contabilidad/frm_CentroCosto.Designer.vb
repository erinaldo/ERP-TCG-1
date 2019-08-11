<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CentroCosto
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndActivoFijo")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDiario")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompra")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVenta")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndActivoFijo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDiario")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompra")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndVenta")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescripcionDetallada")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescripcionDetallada")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CentroCosto))
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
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.odCentroCosto = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrCentroCosto = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.verCompraBusca = New ISL.Controles.Chequear(Me.components)
        Me.verActivoFijoBusca = New ISL.Controles.Chequear(Me.components)
        Me.verDiarioBusca = New ISL.Controles.Chequear(Me.components)
        Me.verVentaBusca = New ISL.Controles.Chequear(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griUbicaciones = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdCentroCostoUbicaciones = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDescripcionUbicacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombreUbicacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnAgregarU = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.gruIndicadores = New Infragistics.Win.Misc.UltraGroupBox()
        Me.verIndCompra = New ISL.Controles.Chequear(Me.components)
        Me.verIndActivoFijo = New ISL.Controles.Chequear(Me.components)
        Me.verIndDiario = New ISL.Controles.Chequear(Me.components)
        Me.verIndVenta = New ISL.Controles.Chequear(Me.components)
        Me.txtDescripcionVehiculo = New ISL.Controles.Texto(Me.components)
        Me.verVehiculo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboVehiculo = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtId = New ISL.Controles.Texto(Me.components)
        Me.cboArea = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.ficCentroCosto = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.odCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrCentroCosto.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.verCompraBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivoFijoBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verDiarioBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verVentaBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.griUbicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdCentroCostoUbicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txtDescripcionUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.gruIndicadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruIndicadores.SuspendLayout()
        CType(Me.verIndCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCentroCosto.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griLista)
        Me.UltraTabPageControl7.Controls.Add(Me.agrCentroCosto)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(982, 438)
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.odCentroCosto
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griLista.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 300
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 100
        UltraGridColumn8.Header.Caption = "Area"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 150
        UltraGridColumn9.Header.Caption = "Vehiculo"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 50
        UltraGridColumn10.Header.Caption = "SedeEmpresa"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 100
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn11.Width = 50
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn12.Width = 50
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn13.Width = 50
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn14.Width = 50
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn7, UltraGridColumn5, UltraGridColumn6})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.griLista.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.griLista.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.MaxRowScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance5.TextHAlignAsString = "Left"
        Me.griLista.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(0, 100)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(982, 338)
        Me.griLista.TabIndex = 0
        Me.griLista.Text = "Información de centros de costo"
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Insert, Me.Update, Me.Delete})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(121, 70)
        '
        'Insert
        '
        Me.Insert.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(120, 22)
        Me.Insert.Text = "Nuevo"
        Me.Insert.ToolTipText = "Insertar una nueva Pre-Demanda"
        '
        'Update
        '
        Me.Update.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(120, 22)
        Me.Update.Text = "Actualizar"
        Me.Update.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'Delete
        '
        Me.Delete.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(120, 22)
        Me.Delete.Text = "Eliminar"
        Me.Delete.ToolTipText = "Eliminar la Pre-Demanda seleccionada"
        '
        'odCentroCosto
        '
        Me.odCentroCosto.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrCentroCosto
        '
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.BackColor2 = System.Drawing.Color.White
        Me.agrCentroCosto.ContentAreaAppearance = Appearance6
        Me.agrCentroCosto.Controls.Add(Me.UltraGroupBox2)
        Me.agrCentroCosto.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCentroCosto.ForeColor = System.Drawing.Color.Black
        Me.agrCentroCosto.Location = New System.Drawing.Point(0, 0)
        Me.agrCentroCosto.Name = "agrCentroCosto"
        Me.agrCentroCosto.Size = New System.Drawing.Size(982, 100)
        Me.agrCentroCosto.TabIndex = 2
        Me.agrCentroCosto.Text = "Centros de costo :"
        Me.agrCentroCosto.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox2
        '
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance7
        Me.UltraGroupBox2.Controls.Add(Me.verCompraBusca)
        Me.UltraGroupBox2.Controls.Add(Me.verActivoFijoBusca)
        Me.UltraGroupBox2.Controls.Add(Me.verDiarioBusca)
        Me.UltraGroupBox2.Controls.Add(Me.verVentaBusca)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox2.Location = New System.Drawing.Point(3, 16)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(150, 81)
        Me.UltraGroupBox2.TabIndex = 314
        Me.UltraGroupBox2.Text = "INDICADORES"
        '
        'verCompraBusca
        '
        Me.verCompraBusca.AutoSize = True
        Me.verCompraBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verCompraBusca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verCompraBusca.Location = New System.Drawing.Point(85, 22)
        Me.verCompraBusca.Name = "verCompraBusca"
        Me.verCompraBusca.Size = New System.Drawing.Size(60, 17)
        Me.verCompraBusca.TabIndex = 292
        Me.verCompraBusca.Text = "Compra"
        '
        'verActivoFijoBusca
        '
        Me.verActivoFijoBusca.AutoSize = True
        Me.verActivoFijoBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivoFijoBusca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivoFijoBusca.Location = New System.Drawing.Point(7, 22)
        Me.verActivoFijoBusca.Name = "verActivoFijoBusca"
        Me.verActivoFijoBusca.Size = New System.Drawing.Size(72, 17)
        Me.verActivoFijoBusca.TabIndex = 290
        Me.verActivoFijoBusca.Text = "Activo Fijo"
        '
        'verDiarioBusca
        '
        Me.verDiarioBusca.AutoSize = True
        Me.verDiarioBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verDiarioBusca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verDiarioBusca.Location = New System.Drawing.Point(7, 41)
        Me.verDiarioBusca.Name = "verDiarioBusca"
        Me.verDiarioBusca.Size = New System.Drawing.Size(50, 17)
        Me.verDiarioBusca.TabIndex = 291
        Me.verDiarioBusca.Text = "Diario"
        '
        'verVentaBusca
        '
        Me.verVentaBusca.AutoSize = True
        Me.verVentaBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verVentaBusca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verVentaBusca.Location = New System.Drawing.Point(85, 41)
        Me.verVentaBusca.Name = "verVentaBusca"
        Me.verVentaBusca.Size = New System.Drawing.Size(50, 17)
        Me.verVentaBusca.TabIndex = 293
        Me.verVentaBusca.Text = "Venta"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.griUbicaciones)
        Me.utpDetalle.Controls.Add(Me.UltraGroupBox1)
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(982, 438)
        '
        'griUbicaciones
        '
        Me.griUbicaciones.DataSource = Me.ogdCentroCostoUbicaciones
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Appearance8.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griUbicaciones.DisplayLayout.Appearance = Appearance8
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn39.Width = 339
        UltraGridColumn40.Header.VisiblePosition = 3
        UltraGridColumn40.Width = 500
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41})
        Me.griUbicaciones.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griUbicaciones.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griUbicaciones.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.griUbicaciones.DisplayLayout.GroupByBox.Appearance = Appearance9
        Appearance10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griUbicaciones.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance10
        Me.griUbicaciones.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griUbicaciones.DisplayLayout.GroupByBox.Hidden = True
        Appearance11.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance11.BackColor2 = System.Drawing.SystemColors.Control
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griUbicaciones.DisplayLayout.GroupByBox.PromptAppearance = Appearance11
        Me.griUbicaciones.DisplayLayout.MaxColScrollRegions = 1
        Me.griUbicaciones.DisplayLayout.MaxRowScrollRegions = 1
        Me.griUbicaciones.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griUbicaciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griUbicaciones.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griUbicaciones.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griUbicaciones.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griUbicaciones.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griUbicaciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griUbicaciones.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griUbicaciones.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griUbicaciones.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griUbicaciones.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griUbicaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griUbicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griUbicaciones.Location = New System.Drawing.Point(0, 250)
        Me.griUbicaciones.Name = "griUbicaciones"
        Me.griUbicaciones.Size = New System.Drawing.Size(982, 188)
        Me.griUbicaciones.TabIndex = 304
        '
        'ogdCentroCostoUbicaciones
        '
        Me.ogdCentroCostoUbicaciones.Band.Columns.AddRange(New Object() {UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19})
        '
        'UltraGroupBox1
        '
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance12
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.txtDescripcionUbicacion)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.txtNombreUbicacion)
        Me.UltraGroupBox1.Controls.Add(Me.btnAgregarU)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 150)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(982, 100)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "Ubicaciones Centro Costo"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel3
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance13
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(6, 50)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel3.TabIndex = 330
        Me.UltraLabel3.Text = "Descripcion:"
        '
        'txtDescripcionUbicacion
        '
        Me.txtDescripcionUbicacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDescripcionUbicacion.Location = New System.Drawing.Point(75, 48)
        Me.txtDescripcionUbicacion.Multiline = True
        Me.txtDescripcionUbicacion.Name = "txtDescripcionUbicacion"
        Me.txtDescripcionUbicacion.Size = New System.Drawing.Size(300, 45)
        Me.txtDescripcionUbicacion.TabIndex = 329
        '
        'UltraLabel2
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance14
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(27, 27)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel2.TabIndex = 328
        Me.UltraLabel2.Text = "Nombre:"
        '
        'txtNombreUbicacion
        '
        Me.txtNombreUbicacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNombreUbicacion.Location = New System.Drawing.Point(75, 25)
        Me.txtNombreUbicacion.Name = "txtNombreUbicacion"
        Me.txtNombreUbicacion.Size = New System.Drawing.Size(350, 21)
        Me.txtNombreUbicacion.TabIndex = 327
        '
        'btnAgregarU
        '
        Appearance15.Image = "add.ico"
        Me.btnAgregarU.Appearance = Appearance15
        Me.btnAgregarU.ImageList = Me.imagenes
        Me.btnAgregarU.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarU.Location = New System.Drawing.Point(395, 63)
        Me.btnAgregarU.Name = "btnAgregarU"
        Me.btnAgregarU.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarU.TabIndex = 326
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
        'Gb_DatoGeneralDemanda
        '
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.BackColor2 = System.Drawing.Color.White
        Me.Gb_DatoGeneralDemanda.ContentAreaAppearance = Appearance16
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.gruIndicadores)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtDescripcionVehiculo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verVehiculo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboVehiculo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboCentro)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel6)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtCodigo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel4)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtId)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboArea)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel1)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtAbreviatura)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel5)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtNombre)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel22)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(982, 150)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos Generales"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gruIndicadores
        '
        Appearance17.BackColor = System.Drawing.Color.White
        Appearance17.BackColor2 = System.Drawing.Color.White
        Me.gruIndicadores.ContentAreaAppearance = Appearance17
        Me.gruIndicadores.Controls.Add(Me.verIndCompra)
        Me.gruIndicadores.Controls.Add(Me.verIndActivoFijo)
        Me.gruIndicadores.Controls.Add(Me.verIndDiario)
        Me.gruIndicadores.Controls.Add(Me.verIndVenta)
        Me.gruIndicadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gruIndicadores.Location = New System.Drawing.Point(493, 40)
        Me.gruIndicadores.Name = "gruIndicadores"
        Me.gruIndicadores.Size = New System.Drawing.Size(100, 100)
        Me.gruIndicadores.TabIndex = 313
        Me.gruIndicadores.Text = "INDICADORES"
        Me.gruIndicadores.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verIndCompra
        '
        Me.verIndCompra.AutoSize = True
        Me.verIndCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIndCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verIndCompra.Location = New System.Drawing.Point(8, 59)
        Me.verIndCompra.Name = "verIndCompra"
        Me.verIndCompra.Size = New System.Drawing.Size(60, 17)
        Me.verIndCompra.TabIndex = 292
        Me.verIndCompra.Text = "Compra"
        '
        'verIndActivoFijo
        '
        Me.verIndActivoFijo.AutoSize = True
        Me.verIndActivoFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIndActivoFijo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verIndActivoFijo.Location = New System.Drawing.Point(8, 21)
        Me.verIndActivoFijo.Name = "verIndActivoFijo"
        Me.verIndActivoFijo.Size = New System.Drawing.Size(72, 17)
        Me.verIndActivoFijo.TabIndex = 290
        Me.verIndActivoFijo.Text = "Activo Fijo"
        '
        'verIndDiario
        '
        Me.verIndDiario.AutoSize = True
        Me.verIndDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIndDiario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verIndDiario.Location = New System.Drawing.Point(8, 40)
        Me.verIndDiario.Name = "verIndDiario"
        Me.verIndDiario.Size = New System.Drawing.Size(50, 17)
        Me.verIndDiario.TabIndex = 291
        Me.verIndDiario.Text = "Diario"
        '
        'verIndVenta
        '
        Me.verIndVenta.AutoSize = True
        Me.verIndVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIndVenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verIndVenta.Location = New System.Drawing.Point(8, 78)
        Me.verIndVenta.Name = "verIndVenta"
        Me.verIndVenta.Size = New System.Drawing.Size(50, 17)
        Me.verIndVenta.TabIndex = 293
        Me.verIndVenta.Text = "Venta"
        '
        'txtDescripcionVehiculo
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcionVehiculo.Appearance = Appearance18
        Me.txtDescripcionVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcionVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionVehiculo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcionVehiculo.Location = New System.Drawing.Point(190, 117)
        Me.txtDescripcionVehiculo.MaxLength = 50
        Me.txtDescripcionVehiculo.Name = "txtDescripcionVehiculo"
        Me.txtDescripcionVehiculo.Size = New System.Drawing.Size(295, 21)
        Me.txtDescripcionVehiculo.TabIndex = 312
        '
        'verVehiculo
        '
        Me.verVehiculo.AutoSize = True
        Me.verVehiculo.Location = New System.Drawing.Point(11, 118)
        Me.verVehiculo.Name = "verVehiculo"
        Me.verVehiculo.Size = New System.Drawing.Size(70, 17)
        Me.verVehiculo.TabIndex = 311
        Me.verVehiculo.Text = "Vehiculo:"
        '
        'cboVehiculo
        '
        Me.cboVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboVehiculo.DisplayLayout.Appearance = Appearance19
        Me.cboVehiculo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboVehiculo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.BorderColor = System.Drawing.SystemColors.Window
        Me.cboVehiculo.DisplayLayout.GroupByBox.Appearance = Appearance20
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboVehiculo.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance21
        Me.cboVehiculo.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance22.BackColor2 = System.Drawing.SystemColors.Control
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboVehiculo.DisplayLayout.GroupByBox.PromptAppearance = Appearance22
        Me.cboVehiculo.DisplayLayout.MaxColScrollRegions = 1
        Me.cboVehiculo.DisplayLayout.MaxRowScrollRegions = 1
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboVehiculo.DisplayLayout.Override.ActiveCellAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.SystemColors.Window
        Me.cboVehiculo.DisplayLayout.Override.CardAreaAppearance = Appearance24
        Me.cboVehiculo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboVehiculo.DisplayLayout.Override.CellPadding = 0
        Me.cboVehiculo.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Appearance25.BackColor = System.Drawing.SystemColors.Control
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.cboVehiculo.DisplayLayout.Override.GroupByRowAppearance = Appearance25
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboVehiculo.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
        Me.cboVehiculo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboVehiculo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboVehiculo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboVehiculo.DisplayMember = "Nombre"
        Me.cboVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboVehiculo.Enabled = False
        Me.cboVehiculo.Location = New System.Drawing.Point(84, 116)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(100, 22)
        Me.cboVehiculo.TabIndex = 310
        Me.cboVehiculo.ValueMember = "Id"
        '
        'cboCentro
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance27
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(334, 24)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(150, 21)
        Me.cboCentro.TabIndex = 298
        Me.cboCentro.ValueMember = "Descripcion"
        '
        'UltraLabel6
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Appearance28.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance28
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(254, 26)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(82, 14)
        Me.UltraLabel6.TabIndex = 297
        Me.UltraLabel6.Text = "Sede Empresa:"
        '
        'txtCodigo
        '
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance29
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(84, 24)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 296
        '
        'UltraLabel4
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Appearance30.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance30
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(40, 26)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 295
        Me.UltraLabel4.Text = "Codigo:"
        '
        'txtId
        '
        Appearance31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.Appearance = Appearance31
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.Location = New System.Drawing.Point(184, 24)
        Me.txtId.MaxLength = 50
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(50, 21)
        Me.txtId.TabIndex = 294
        Me.txtId.Visible = False
        '
        'cboArea
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Appearance = Appearance32
        Me.cboArea.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboArea.DisplayMember = "Nombre"
        Me.cboArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboArea.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.ImageList = Me.imagenes
        Me.cboArea.Location = New System.Drawing.Point(84, 93)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(250, 21)
        Me.cboArea.TabIndex = 22
        Me.cboArea.ValueMember = "Id"
        '
        'UltraLabel1
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Appearance33.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance33
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(52, 95)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel1.TabIndex = 21
        Me.UltraLabel1.Text = "Área:"
        '
        'txtAbreviatura
        '
        Appearance34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance34
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Location = New System.Drawing.Point(84, 70)
        Me.txtAbreviatura.MaxLength = 50
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(150, 21)
        Me.txtAbreviatura.TabIndex = 6
        '
        'UltraLabel5
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance35
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(18, 72)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel5.TabIndex = 5
        Me.UltraLabel5.Text = "Abreviatura:"
        '
        'txtNombre
        '
        Appearance36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance36
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(84, 47)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(400, 21)
        Me.txtNombre.TabIndex = 4
        '
        'UltraLabel22
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Appearance37.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance37
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(36, 50)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel22.TabIndex = 3
        Me.UltraLabel22.Text = "Nombre:"
        '
        'ficCentroCosto
        '
        Me.ficCentroCosto.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficCentroCosto.Controls.Add(Me.UltraTabPageControl7)
        Me.ficCentroCosto.Controls.Add(Me.utpDetalle)
        Me.ficCentroCosto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCentroCosto.Location = New System.Drawing.Point(0, 0)
        Me.ficCentroCosto.Name = "ficCentroCosto"
        Me.ficCentroCosto.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficCentroCosto.Size = New System.Drawing.Size(984, 461)
        Me.ficCentroCosto.TabIndex = 3
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficCentroCosto.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficCentroCosto.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(982, 438)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(294, 196)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 9
        Me.ugb_Espera.Visible = False
        '
        'frm_CentroCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficCentroCosto)
        Me.Name = "frm_CentroCosto"
        Me.Text = "Centro de costo"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.odCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrCentroCosto.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.verCompraBusca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivoFijoBusca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verDiarioBusca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verVentaBusca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.griUbicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdCentroCostoUbicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txtDescripcionUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.gruIndicadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruIndicadores.ResumeLayout(False)
        Me.gruIndicadores.PerformLayout()
        CType(Me.verIndCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndActivoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCentroCosto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficCentroCosto As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrCentroCosto As ISL.Controles.Agrupacion
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odCentroCosto As ISL.Controles.OrigenDatos
    Friend WithEvents griLista As ISL.Controles.Grilla

    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents cboArea As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents verIndVenta As ISL.Controles.Chequear
    Friend WithEvents verIndCompra As ISL.Controles.Chequear
    Friend WithEvents verIndDiario As ISL.Controles.Chequear
    Friend WithEvents verIndActivoFijo As ISL.Controles.Chequear
    Friend WithEvents griUbicaciones As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ogdCentroCostoUbicaciones As ISL.Controles.OrigenDatos
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnAgregarU As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDescripcionUbicacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNombreUbicacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtId As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents verVehiculo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboVehiculo As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtDescripcionVehiculo As ISL.Controles.Texto
    Private WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents verCompraBusca As ISL.Controles.Chequear
    Friend WithEvents verActivoFijoBusca As ISL.Controles.Chequear
    Friend WithEvents verDiarioBusca As ISL.Controles.Chequear
    Friend WithEvents verVentaBusca As ISL.Controles.Chequear
    Friend WithEvents gruIndicadores As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugb_Espera As ISL.Win.Espere

End Class
