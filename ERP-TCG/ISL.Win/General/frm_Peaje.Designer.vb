<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Peaje
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeaje")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadEjes")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculoTarifa")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeaje")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadEjes")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculoTarifa")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lugar")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPagoIda")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPagoRetorno")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Empresa")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Lugar")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPagoIda")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPagoRetorno")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.cmbTipoVehiculoTarifa = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTarifaPeaje = New ISL.Controles.Grilla(Me.components)
        Me.udsTarifaPeaje = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.tspTarifa = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarTarifa = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarTarifa = New System.Windows.Forms.ToolStripButton()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uneMontoTarifa = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtGlosaTarifa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabListaPeaje = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griPeaje = New ISL.Controles.Grilla(Me.components)
        Me.udsPeaje = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmbEmpresaFiltro = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreFiltro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabMantPeaje = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ficTarifaPeaje = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtCodigo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkPagoRetorno = New System.Windows.Forms.CheckBox()
        Me.chkPagoIda = New System.Windows.Forms.CheckBox()
        Me.cmbLugar = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbEmpresa = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUbicacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FicPeaje = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.cmbTipoVehiculoTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griTarifaPeaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsTarifaPeaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspTarifa.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.uneMontoTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosaTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabListaPeaje.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.griPeaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsPeaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.cmbEmpresaFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMantPeaje.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.ficTarifaPeaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficTarifaPeaje.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FicPeaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FicPeaje.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTipoVehiculoTarifa
        '
        Me.cmbTipoVehiculoTarifa.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cmbTipoVehiculoTarifa.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cmbTipoVehiculoTarifa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbTipoVehiculoTarifa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoVehiculoTarifa.DropDownListWidth = -1
        Me.cmbTipoVehiculoTarifa.Location = New System.Drawing.Point(55, 19)
        Me.cmbTipoVehiculoTarifa.Name = "cmbTipoVehiculoTarifa"
        Me.cmbTipoVehiculoTarifa.Size = New System.Drawing.Size(272, 22)
        Me.cmbTipoVehiculoTarifa.TabIndex = 0
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griTarifaPeaje)
        Me.UltraTabPageControl3.Controls.Add(Me.tspTarifa)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1074, 309)
        '
        'griTarifaPeaje
        '
        Me.griTarifaPeaje.DataSource = Me.udsTarifaPeaje
        Appearance1.BackColor = System.Drawing.Color.White
        Me.griTarifaPeaje.DisplayLayout.Appearance = Appearance1
        UltraGridColumn247.Header.VisiblePosition = 0
        UltraGridColumn247.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 1
        UltraGridColumn22.Hidden = True
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance2
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn23.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn23.Header.VisiblePosition = 3
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.MaskInput = "nn"
        UltraGridColumn23.Width = 73
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn24.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn24.EditorComponent = Me.cmbTipoVehiculoTarifa
        UltraGridColumn24.Header.Caption = "Nombre"
        UltraGridColumn24.Header.VisiblePosition = 2
        UltraGridColumn24.Width = 234
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance3
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn25.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn25.Format = "###,##0.00"
        UltraGridColumn25.Header.Caption = "Monto (S/.)"
        UltraGridColumn25.Header.VisiblePosition = 4
        UltraGridColumn25.MaskInput = "{currency:4.2}"
        UltraGridColumn25.Width = 65
        UltraGridColumn253.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn253.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn253.Header.VisiblePosition = 6
        UltraGridColumn253.Width = 363
        UltraGridColumn255.Header.VisiblePosition = 7
        UltraGridColumn255.Hidden = True
        UltraGridColumn256.Header.VisiblePosition = 8
        UltraGridColumn256.Hidden = True
        UltraGridColumn257.Header.VisiblePosition = 9
        UltraGridColumn257.Hidden = True
        UltraGridColumn258.Header.VisiblePosition = 10
        UltraGridColumn258.Hidden = True
        UltraGridColumn259.Header.VisiblePosition = 5
        UltraGridColumn259.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn247, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn253, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259})
        Me.griTarifaPeaje.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griTarifaPeaje.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTarifaPeaje.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griTarifaPeaje.DisplayLayout.GroupByBox.Hidden = True
        Me.griTarifaPeaje.DisplayLayout.MaxColScrollRegions = 1
        Me.griTarifaPeaje.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifaPeaje.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.griTarifaPeaje.DisplayLayout.Override.CellPadding = 0
        Me.griTarifaPeaje.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTarifaPeaje.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griTarifaPeaje.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTarifaPeaje.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance4.TextHAlignAsString = "Left"
        Me.griTarifaPeaje.DisplayLayout.Override.HeaderAppearance = Appearance4
        Me.griTarifaPeaje.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTarifaPeaje.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance5.TextVAlignAsString = "Middle"
        Me.griTarifaPeaje.DisplayLayout.Override.RowAppearance = Appearance5
        Me.griTarifaPeaje.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTarifaPeaje.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTarifaPeaje.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTarifaPeaje.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTarifaPeaje.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTarifaPeaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTarifaPeaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTarifaPeaje.Location = New System.Drawing.Point(0, 99)
        Me.griTarifaPeaje.Name = "griTarifaPeaje"
        Me.griTarifaPeaje.Size = New System.Drawing.Size(1074, 210)
        Me.griTarifaPeaje.TabIndex = 6
        Me.griTarifaPeaje.Tag = ""
        '
        'udsTarifaPeaje
        '
        UltraDataColumn3.DataType = GetType(Long)
        UltraDataColumn5.DataType = GetType(Decimal)
        UltraDataColumn8.DataType = GetType(Date)
        UltraDataColumn10.DataType = GetType(Date)
        UltraDataColumn11.DataType = GetType(Boolean)
        Me.udsTarifaPeaje.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'tspTarifa
        '
        Me.tspTarifa.BackColor = System.Drawing.SystemColors.Window
        Me.tspTarifa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarTarifa, Me.tsbQuitarTarifa})
        Me.tspTarifa.Location = New System.Drawing.Point(0, 74)
        Me.tspTarifa.Name = "tspTarifa"
        Me.tspTarifa.Size = New System.Drawing.Size(1074, 25)
        Me.tspTarifa.TabIndex = 3
        Me.tspTarifa.Text = "ToolStrip1"
        '
        'tsbAgregarTarifa
        '
        Me.tsbAgregarTarifa.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregarTarifa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarTarifa.Name = "tsbAgregarTarifa"
        Me.tsbAgregarTarifa.Size = New System.Drawing.Size(95, 22)
        Me.tsbAgregarTarifa.Text = "Agregar (Ins)"
        '
        'tsbQuitarTarifa
        '
        Me.tsbQuitarTarifa.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsbQuitarTarifa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarTarifa.Name = "tsbQuitarTarifa"
        Me.tsbQuitarTarifa.Size = New System.Drawing.Size(88, 22)
        Me.tsbQuitarTarifa.Text = "Quitar (Del)"
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.cmbTipoVehiculoTarifa)
        Me.UltraGroupBox5.Controls.Add(Me.uneMontoTarifa)
        Me.UltraGroupBox5.Controls.Add(Me.txtGlosaTarifa)
        Me.UltraGroupBox5.Controls.Add(Me.Label11)
        Me.UltraGroupBox5.Controls.Add(Me.Label10)
        Me.UltraGroupBox5.Controls.Add(Me.Label8)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(1074, 74)
        Me.UltraGroupBox5.TabIndex = 2
        Me.UltraGroupBox5.Text = "Datos Tarifa"
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'uneMontoTarifa
        '
        Me.uneMontoTarifa.FormatProvider = New System.Globalization.CultureInfo("es-PE")
        Me.uneMontoTarifa.Location = New System.Drawing.Point(447, 19)
        Me.uneMontoTarifa.MaskInput = "S/. nnn.nn"
        Me.uneMontoTarifa.Name = "uneMontoTarifa"
        Me.uneMontoTarifa.NullText = "0.00"
        Me.uneMontoTarifa.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.uneMontoTarifa.Size = New System.Drawing.Size(100, 22)
        Me.uneMontoTarifa.TabIndex = 1
        Me.uneMontoTarifa.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        '
        'txtGlosaTarifa
        '
        Me.txtGlosaTarifa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaTarifa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaTarifa.Location = New System.Drawing.Point(55, 46)
        Me.txtGlosaTarifa.Name = "txtGlosaTarifa"
        Me.txtGlosaTarifa.Size = New System.Drawing.Size(492, 22)
        Me.txtGlosaTarifa.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(16, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Glosa:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(407, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Monto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(7, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Nombre:"
        '
        'tabListaPeaje
        '
        Me.tabListaPeaje.Controls.Add(Me.UltraGroupBox1)
        Me.tabListaPeaje.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabListaPeaje.Name = "tabListaPeaje"
        Me.tabListaPeaje.Size = New System.Drawing.Size(1082, 538)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.griPeaje)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1082, 538)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPeaje
        '
        Me.griPeaje.DataSource = Me.udsPeaje
        Appearance6.BackColor = System.Drawing.Color.White
        Me.griPeaje.DisplayLayout.Appearance = Appearance6
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Width = 82
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Width = 190
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 4
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.Width = 154
        UltraGridColumn2.Header.VisiblePosition = 6
        UltraGridColumn2.Width = 244
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 133
        UltraGridColumn3.Header.VisiblePosition = 7
        UltraGridColumn3.Width = 230
        UltraGridColumn20.Header.Caption = "PagoIda"
        UltraGridColumn20.Header.VisiblePosition = 8
        UltraGridColumn20.Width = 50
        UltraGridColumn21.Header.Caption = "PagoRetorno"
        UltraGridColumn21.Header.VisiblePosition = 9
        UltraGridColumn21.Width = 70
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 11
        UltraGridColumn7.Width = 315
        UltraGridColumn9.Header.VisiblePosition = 12
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 13
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 14
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 15
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 10
        UltraGridColumn13.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn2, UltraGridColumn19, UltraGridColumn3, UltraGridColumn20, UltraGridColumn21, UltraGridColumn7, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.griPeaje.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griPeaje.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPeaje.DisplayLayout.GroupByBox.Hidden = True
        Me.griPeaje.DisplayLayout.MaxColScrollRegions = 1
        Me.griPeaje.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPeaje.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPeaje.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPeaje.DisplayLayout.Override.CellPadding = 0
        Me.griPeaje.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPeaje.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griPeaje.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griPeaje.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance7.TextHAlignAsString = "Left"
        Me.griPeaje.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.griPeaje.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griPeaje.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance8.TextVAlignAsString = "Middle"
        Me.griPeaje.DisplayLayout.Override.RowAppearance = Appearance8
        Me.griPeaje.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPeaje.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griPeaje.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griPeaje.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPeaje.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPeaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPeaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPeaje.Location = New System.Drawing.Point(3, 52)
        Me.griPeaje.Name = "griPeaje"
        Me.griPeaje.Size = New System.Drawing.Size(1076, 483)
        Me.griPeaje.TabIndex = 6
        Me.griPeaje.Tag = ""
        '
        'udsPeaje
        '
        UltraDataColumn20.DataType = GetType(Boolean)
        UltraDataColumn21.DataType = GetType(Boolean)
        UltraDataColumn24.DataType = GetType(Date)
        UltraDataColumn26.DataType = GetType(Date)
        UltraDataColumn27.DataType = GetType(Boolean)
        Me.udsPeaje.Band.Columns.AddRange(New Object() {UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27})
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.cmbEmpresaFiltro)
        Me.UltraGroupBox3.Controls.Add(Me.Label7)
        Me.UltraGroupBox3.Controls.Add(Me.txtNombreFiltro)
        Me.UltraGroupBox3.Controls.Add(Me.Label6)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1076, 49)
        Me.UltraGroupBox3.TabIndex = 0
        Me.UltraGroupBox3.Text = "Filtros"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmbEmpresaFiltro
        '
        Me.cmbEmpresaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbEmpresaFiltro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbEmpresaFiltro.DropDownListWidth = -1
        Me.cmbEmpresaFiltro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbEmpresaFiltro.Location = New System.Drawing.Point(285, 19)
        Me.cmbEmpresaFiltro.Name = "cmbEmpresaFiltro"
        Me.cmbEmpresaFiltro.Size = New System.Drawing.Size(264, 22)
        Me.cmbEmpresaFiltro.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(233, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Empresa:"
        '
        'txtNombreFiltro
        '
        Me.txtNombreFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreFiltro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombreFiltro.Location = New System.Drawing.Point(59, 19)
        Me.txtNombreFiltro.Name = "txtNombreFiltro"
        Me.txtNombreFiltro.Size = New System.Drawing.Size(167, 22)
        Me.txtNombreFiltro.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(11, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Nombre:"
        '
        'tabMantPeaje
        '
        Me.tabMantPeaje.Controls.Add(Me.UltraGroupBox2)
        Me.tabMantPeaje.Location = New System.Drawing.Point(1, 22)
        Me.tabMantPeaje.Name = "tabMantPeaje"
        Me.tabMantPeaje.Size = New System.Drawing.Size(1082, 538)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.ficTarifaPeaje)
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1082, 538)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficTarifaPeaje
        '
        Me.ficTarifaPeaje.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficTarifaPeaje.Controls.Add(Me.UltraTabPageControl3)
        Me.ficTarifaPeaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficTarifaPeaje.Location = New System.Drawing.Point(3, 203)
        Me.ficTarifaPeaje.Name = "ficTarifaPeaje"
        Me.ficTarifaPeaje.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficTarifaPeaje.Size = New System.Drawing.Size(1076, 332)
        Me.ficTarifaPeaje.TabIndex = 2
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Tarifas"
        Me.ficTarifaPeaje.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3})
        Me.ficTarifaPeaje.TabStop = False
        Me.ficTarifaPeaje.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1074, 309)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.txtCodigo)
        Me.UltraGroupBox4.Controls.Add(Me.Label12)
        Me.UltraGroupBox4.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox4.Controls.Add(Me.Label5)
        Me.UltraGroupBox4.Controls.Add(Me.chkPagoRetorno)
        Me.UltraGroupBox4.Controls.Add(Me.chkPagoIda)
        Me.UltraGroupBox4.Controls.Add(Me.cmbLugar)
        Me.UltraGroupBox4.Controls.Add(Me.Label4)
        Me.UltraGroupBox4.Controls.Add(Me.cmbEmpresa)
        Me.UltraGroupBox4.Controls.Add(Me.Label3)
        Me.UltraGroupBox4.Controls.Add(Me.txtUbicacion)
        Me.UltraGroupBox4.Controls.Add(Me.Label2)
        Me.UltraGroupBox4.Controls.Add(Me.txtNombre)
        Me.UltraGroupBox4.Controls.Add(Me.Label1)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1076, 200)
        Me.UltraGroupBox4.TabIndex = 1
        Me.UltraGroupBox4.Text = "Datos Peaje"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Location = New System.Drawing.Point(65, 20)
        Me.txtCodigo.MaxLength = 3
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(40, 22)
        Me.txtCodigo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(17, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Codigo:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Location = New System.Drawing.Point(65, 156)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(340, 37)
        Me.txtGlosa.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(24, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Glosa:"
        '
        'chkPagoRetorno
        '
        Me.chkPagoRetorno.AutoSize = True
        Me.chkPagoRetorno.BackColor = System.Drawing.Color.Transparent
        Me.chkPagoRetorno.Location = New System.Drawing.Point(313, 50)
        Me.chkPagoRetorno.Name = "chkPagoRetorno"
        Me.chkPagoRetorno.Size = New System.Drawing.Size(92, 17)
        Me.chkPagoRetorno.TabIndex = 3
        Me.chkPagoRetorno.Text = "Pago Retorno"
        Me.chkPagoRetorno.UseVisualStyleBackColor = False
        '
        'chkPagoIda
        '
        Me.chkPagoIda.AutoSize = True
        Me.chkPagoIda.BackColor = System.Drawing.Color.Transparent
        Me.chkPagoIda.Location = New System.Drawing.Point(238, 50)
        Me.chkPagoIda.Name = "chkPagoIda"
        Me.chkPagoIda.Size = New System.Drawing.Size(69, 17)
        Me.chkPagoIda.TabIndex = 2
        Me.chkPagoIda.Text = "Pago Ida"
        Me.chkPagoIda.UseVisualStyleBackColor = False
        '
        'cmbLugar
        '
        Me.cmbLugar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cmbLugar.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cmbLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbLugar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbLugar.DropDownListWidth = -1
        Me.cmbLugar.Location = New System.Drawing.Point(65, 102)
        Me.cmbLugar.Name = "cmbLugar"
        Me.cmbLugar.Size = New System.Drawing.Size(340, 22)
        Me.cmbLugar.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(23, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Lugar:"
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cmbEmpresa.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cmbEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbEmpresa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbEmpresa.DropDownListWidth = -1
        Me.cmbEmpresa.Location = New System.Drawing.Point(65, 75)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(340, 22)
        Me.cmbEmpresa.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Empresa:"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtUbicacion.Location = New System.Drawing.Point(65, 129)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(340, 22)
        Me.txtUbicacion.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(5, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ubicacion:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Location = New System.Drawing.Point(65, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(167, 22)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'FicPeaje
        '
        Me.FicPeaje.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.FicPeaje.Controls.Add(Me.tabListaPeaje)
        Me.FicPeaje.Controls.Add(Me.tabMantPeaje)
        Me.FicPeaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FicPeaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FicPeaje.Location = New System.Drawing.Point(0, 0)
        Me.FicPeaje.Name = "FicPeaje"
        Me.FicPeaje.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.FicPeaje.Size = New System.Drawing.Size(1084, 561)
        Me.FicPeaje.TabIndex = 0
        UltraTab1.TabPage = Me.tabListaPeaje
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.tabMantPeaje
        UltraTab2.Text = "Mantenimiento"
        Me.FicPeaje.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.FicPeaje.TabStop = False
        Me.FicPeaje.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1082, 538)
        '
        'frm_Peaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.FicPeaje)
        Me.KeyPreview = True
        Me.Name = "frm_Peaje"
        Me.Text = "Peaje"
        CType(Me.cmbTipoVehiculoTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.griTarifaPeaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsTarifaPeaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspTarifa.ResumeLayout(False)
        Me.tspTarifa.PerformLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.UltraGroupBox5.PerformLayout()
        CType(Me.uneMontoTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosaTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabListaPeaje.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.griPeaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsPeaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.cmbEmpresaFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMantPeaje.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.ficTarifaPeaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficTarifaPeaje.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FicPeaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FicPeaje.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FicPeaje As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tabListaPeaje As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents tabMantPeaje As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkPagoRetorno As System.Windows.Forms.CheckBox
    Friend WithEvents chkPagoIda As System.Windows.Forms.CheckBox
    Friend WithEvents cmbLugar As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbEmpresa As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUbicacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbEmpresaFiltro As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNombreFiltro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ficTarifaPeaje As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tspTarifa As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarTarifa As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitarTarifa As System.Windows.Forms.ToolStripButton
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtGlosaTarifa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents griPeaje As ISL.Controles.Grilla
    Friend WithEvents griTarifaPeaje As ISL.Controles.Grilla
    Friend WithEvents udsPeaje As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents udsTarifaPeaje As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents uneMontoTarifa As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtCodigo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoVehiculoTarifa As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
