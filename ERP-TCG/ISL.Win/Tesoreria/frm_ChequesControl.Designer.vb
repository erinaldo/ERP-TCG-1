<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChequesControl
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaBancaria")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaBancaria")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdChequesControl")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Inicial")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Final")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngreso")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdResponsable")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCaja")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnulado")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTerminado")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Correlativo")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Talonario")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdChequesControl")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Inicial")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Final")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIngreso")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdResponsable")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCaja")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnulado")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTerminado")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Correlativo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Talonario")
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
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.odChequesControl = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.numStockTalonarios = New ISL.Controles.NumeroEntero(Me.components)
        Me.ColorStockTalonarios = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTalonarios = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odChequesTalonarios = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.exgruDetalle = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnQuitar = New Infragistics.Win.Misc.UltraButton()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtTalonario = New ISL.Controles.Texto(Me.components)
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtStockGuias = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtStockTalonarios = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.exgruDisponibleNo = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ColorStock = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAnulado = New ISL.Controles.Colores(Me.components)
        Me.ColorEnUso = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTerminado = New ISL.Controles.Colores(Me.components)
        Me.txtObservacionTalanario = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel37 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtFinal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.verAnulado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verTerminado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtInicial = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboCuentaBancaria = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficControlCheques = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaRegistro.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odChequesControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.numStockTalonarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorStockTalonarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.griTalonarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odChequesTalonarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruDetalle.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.txtTalonario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout()
        CType(Me.exgruDisponibleNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruDisponibleNo.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.ColorStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEnUso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTerminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacionTalanario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTerminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficControlCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficControlCheques.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrListaRegistro)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1140, 422)
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.griLista)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 53)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(1140, 369)
        Me.agrListaRegistro.TabIndex = 1
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista Cuentas Bancarias"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griLista
        '
        Me.griLista.DataSource = Me.odChequesControl
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 210
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Width = 231
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 118
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(3, 17)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1134, 349)
        Me.griLista.TabIndex = 0
        Me.griLista.Tag = ""
        '
        'odChequesControl
        '
        Me.odChequesControl.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Controls.Add(Me.numStockTalonarios)
        Me.agrBusqueda.Controls.Add(Me.ColorStockTalonarios)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta3)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1140, 53)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance1
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(20, 33)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Talonarios"
        '
        'numStockTalonarios
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.numStockTalonarios.Appearance = Appearance2
        Me.numStockTalonarios.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numStockTalonarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numStockTalonarios.ForeColor = System.Drawing.Color.Black
        Me.numStockTalonarios.FormatString = ""
        Me.numStockTalonarios.Location = New System.Drawing.Point(89, 23)
        Me.numStockTalonarios.MaskInput = "nn"
        Me.numStockTalonarios.MaxValue = 30
        Me.numStockTalonarios.MinValue = 1
        Me.numStockTalonarios.Name = "numStockTalonarios"
        Me.numStockTalonarios.NullText = "1"
        Me.numStockTalonarios.Size = New System.Drawing.Size(41, 21)
        Me.numStockTalonarios.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numStockTalonarios.TabIndex = 3
        Me.numStockTalonarios.Value = 1
        '
        'ColorStockTalonarios
        '
        Me.ColorStockTalonarios.Color = System.Drawing.Color.Cyan
        Me.ColorStockTalonarios.Location = New System.Drawing.Point(136, 23)
        Me.ColorStockTalonarios.Name = "ColorStockTalonarios"
        Me.ColorStockTalonarios.Size = New System.Drawing.Size(43, 22)
        Me.ColorStockTalonarios.TabIndex = 4
        Me.ColorStockTalonarios.Text = "Cyan"
        '
        'Etiqueta3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance3
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(20, 19)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Stock"
        '
        'Etiqueta2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance4
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(74, 21)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(15, 21)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "<"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.griTalonarios)
        Me.utpDetalle.Controls.Add(Me.exgruDetalle)
        Me.utpDetalle.Controls.Add(Me.agrDatoGeneral)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1140, 422)
        '
        'griTalonarios
        '
        Me.griTalonarios.DataSource = Me.odChequesTalonarios
        Appearance5.BackColor = System.Drawing.Color.White
        Me.griTalonarios.DisplayLayout.Appearance = Appearance5
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Hidden = True
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance6
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn11.Header.Appearance = Appearance7
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Width = 80
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance8
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Width = 80
        UltraGridColumn13.Header.Caption = "F. Ingreso"
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn13.Width = 90
        UltraGridColumn14.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn14.Header.VisiblePosition = 12
        UltraGridColumn14.Width = 211
        UltraGridColumn15.Header.VisiblePosition = 9
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.Caption = "Responsable"
        UltraGridColumn16.Header.VisiblePosition = 10
        UltraGridColumn16.Width = 290
        UltraGridColumn17.Header.Caption = "Caja"
        UltraGridColumn17.Header.VisiblePosition = 11
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn18.Header.Caption = "Anulado"
        UltraGridColumn18.Header.VisiblePosition = 5
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn19.Header.Caption = "Terminado"
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridColumn20.Header.VisiblePosition = 13
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 14
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        UltraGridBand2.SummaryFooterCaption = "Totales:"
        Me.griTalonarios.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griTalonarios.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griTalonarios.DisplayLayout.GroupByBox.Hidden = True
        Me.griTalonarios.DisplayLayout.MaxColScrollRegions = 1
        Me.griTalonarios.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTalonarios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTalonarios.DisplayLayout.Override.CellPadding = 2
        Me.griTalonarios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTalonarios.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTalonarios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.TextHAlignAsString = "Left"
        Me.griTalonarios.DisplayLayout.Override.HeaderAppearance = Appearance9
        Me.griTalonarios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTalonarios.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance10.TextVAlignAsString = "Middle"
        Me.griTalonarios.DisplayLayout.Override.RowAppearance = Appearance10
        Me.griTalonarios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTalonarios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTalonarios.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griTalonarios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTalonarios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTalonarios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTalonarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTalonarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTalonarios.Location = New System.Drawing.Point(0, 130)
        Me.griTalonarios.Name = "griTalonarios"
        Me.griTalonarios.Size = New System.Drawing.Size(1140, 292)
        Me.griTalonarios.TabIndex = 2
        Me.griTalonarios.Tag = ""
        '
        'odChequesTalonarios
        '
        UltraDataColumn18.DataType = GetType(Boolean)
        UltraDataColumn19.DataType = GetType(Boolean)
        Me.odChequesTalonarios.Band.Columns.AddRange(New Object() {UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23})
        '
        'exgruDetalle
        '
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.BackColor2 = System.Drawing.Color.White
        Me.exgruDetalle.ContentAreaAppearance = Appearance11
        Me.exgruDetalle.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.exgruDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruDetalle.ExpandedSize = New System.Drawing.Size(1140, 75)
        Me.exgruDetalle.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.exgruDetalle.Location = New System.Drawing.Point(0, 55)
        Me.exgruDetalle.Name = "exgruDetalle"
        Me.exgruDetalle.Size = New System.Drawing.Size(1140, 75)
        Me.exgruDetalle.TabIndex = 1
        Me.exgruDetalle.TabStop = False
        Me.exgruDetalle.Text = "Talonarios"
        Me.exgruDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnQuitar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.dtpFechaIngreso)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtTalonario)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.exgruDisponibleNo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtObservacionTalanario)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel37)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtFinal)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.verAnulado)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.verTerminado)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnAgregar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel12)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtInicial)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 25)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1134, 47)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraLabel2
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance12
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(383, 31)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel2.TabIndex = 11
        Me.UltraLabel2.Text = "Observacion:"
        '
        'btnQuitar
        '
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnQuitar.Appearance = Appearance13
        Me.btnQuitar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnQuitar.Location = New System.Drawing.Point(702, 15)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(30, 30)
        Me.btnQuitar.TabIndex = 13
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(209, 4)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(105, 21)
        Me.dtpFechaIngreso.TabIndex = 5
        '
        'UltraLabel4
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance14
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(350, 7)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel4.TabIndex = 8
        Me.UltraLabel4.Text = "Talonario:"
        '
        'txtTalonario
        '
        Appearance15.BackColor = System.Drawing.Color.SpringGreen
        Me.txtTalonario.Appearance = Appearance15
        Me.txtTalonario.BackColor = System.Drawing.Color.SpringGreen
        Me.txtTalonario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTalonario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTalonario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTalonario.Location = New System.Drawing.Point(411, 2)
        Me.txtTalonario.MaxLength = 2
        Me.txtTalonario.Name = "txtTalonario"
        Me.txtTalonario.Size = New System.Drawing.Size(43, 21)
        Me.txtTalonario.TabIndex = 9
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance16
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox2.Expanded = False
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(140, 47)
        Me.UltraExpandableGroupBox2.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(874, 0)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(20, 47)
        Me.UltraExpandableGroupBox2.TabIndex = 14
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtStockGuias)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel5)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtStockTalonarios)
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(115, 42)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel5.Visible = False
        '
        'txtStockGuias
        '
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance17.FontData.BoldAsString = "True"
        Appearance17.TextHAlignAsString = "Right"
        Me.txtStockGuias.Appearance = Appearance17
        Me.txtStockGuias.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtStockGuias.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.txtStockGuias.InputMask = "nnnnn"
        Me.txtStockGuias.Location = New System.Drawing.Point(3, 20)
        Me.txtStockGuias.Name = "txtStockGuias"
        Me.txtStockGuias.NonAutoSizeHeight = 20
        Me.txtStockGuias.NullText = "1"
        Me.txtStockGuias.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtStockGuias.ReadOnly = True
        Me.txtStockGuias.Size = New System.Drawing.Size(50, 20)
        Me.txtStockGuias.TabIndex = 1
        Me.txtStockGuias.Text = "1"
        '
        'UltraLabel5
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance18
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(58, 3)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel5.TabIndex = 2
        Me.UltraLabel5.Text = "Stock Ts."
        '
        'UltraLabel1
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance19
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(2, 3)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Stock Chs."
        '
        'txtStockTalonarios
        '
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance20.FontData.BoldAsString = "True"
        Appearance20.TextHAlignAsString = "Right"
        Me.txtStockTalonarios.Appearance = Appearance20
        Me.txtStockTalonarios.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtStockTalonarios.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.txtStockTalonarios.InputMask = "nnnnn"
        Me.txtStockTalonarios.Location = New System.Drawing.Point(60, 20)
        Me.txtStockTalonarios.Name = "txtStockTalonarios"
        Me.txtStockTalonarios.NonAutoSizeHeight = 20
        Me.txtStockTalonarios.NullText = "1"
        Me.txtStockTalonarios.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtStockTalonarios.ReadOnly = True
        Me.txtStockTalonarios.Size = New System.Drawing.Size(50, 20)
        Me.txtStockTalonarios.TabIndex = 3
        Me.txtStockTalonarios.Text = "1"
        '
        'exgruDisponibleNo
        '
        Me.exgruDisponibleNo.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance21.BackColor = System.Drawing.Color.White
        Appearance21.BackColor2 = System.Drawing.Color.White
        Me.exgruDisponibleNo.ContentAreaAppearance = Appearance21
        Me.exgruDisponibleNo.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.exgruDisponibleNo.Dock = System.Windows.Forms.DockStyle.Right
        Me.exgruDisponibleNo.ExpandedSize = New System.Drawing.Size(240, 47)
        Me.exgruDisponibleNo.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruDisponibleNo.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exgruDisponibleNo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.exgruDisponibleNo.Location = New System.Drawing.Point(894, 0)
        Me.exgruDisponibleNo.Name = "exgruDisponibleNo"
        Me.exgruDisponibleNo.Size = New System.Drawing.Size(240, 47)
        Me.exgruDisponibleNo.TabIndex = 15
        Me.exgruDisponibleNo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorStock)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta7)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorAnulado)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorEnUso)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta17)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta14)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta15)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorTerminado)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(22, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(215, 41)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'ColorStock
        '
        Me.ColorStock.Color = System.Drawing.Color.Gold
        Me.ColorStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorStock.Location = New System.Drawing.Point(166, 22)
        Me.ColorStock.Name = "ColorStock"
        Me.ColorStock.Size = New System.Drawing.Size(43, 19)
        Me.ColorStock.TabIndex = 7
        Me.ColorStock.Text = "Gold"
        '
        'Etiqueta7
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance22
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(127, 25)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta7.TabIndex = 5
        Me.Etiqueta7.Text = "Stock:"
        '
        'ColorAnulado
        '
        Me.ColorAnulado.Color = System.Drawing.Color.IndianRed
        Me.ColorAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAnulado.Location = New System.Drawing.Point(67, 22)
        Me.ColorAnulado.Name = "ColorAnulado"
        Me.ColorAnulado.Size = New System.Drawing.Size(43, 19)
        Me.ColorAnulado.TabIndex = 3
        Me.ColorAnulado.Text = "IndianRed"
        '
        'ColorEnUso
        '
        Me.ColorEnUso.Color = System.Drawing.Color.LimeGreen
        Me.ColorEnUso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorEnUso.Location = New System.Drawing.Point(166, 1)
        Me.ColorEnUso.Name = "ColorEnUso"
        Me.ColorEnUso.Size = New System.Drawing.Size(43, 19)
        Me.ColorEnUso.TabIndex = 6
        Me.ColorEnUso.Text = "LimeGreen"
        '
        'Etiqueta17
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance23
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(119, 4)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta17.TabIndex = 4
        Me.Etiqueta17.Text = "En Uso:"
        '
        'Etiqueta14
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance24
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(15, 25)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta14.TabIndex = 1
        Me.Etiqueta14.Text = "Anulado:"
        '
        'Etiqueta15
        '
        Appearance25.BackColor = System.Drawing.Color.White
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance25
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(2, 3)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta15.TabIndex = 0
        Me.Etiqueta15.Text = "Terminado:"
        '
        'ColorTerminado
        '
        Me.ColorTerminado.Color = System.Drawing.Color.MediumPurple
        Me.ColorTerminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTerminado.Location = New System.Drawing.Point(67, 1)
        Me.ColorTerminado.Name = "ColorTerminado"
        Me.ColorTerminado.Size = New System.Drawing.Size(43, 19)
        Me.ColorTerminado.TabIndex = 2
        Me.ColorTerminado.Text = "MediumPurple"
        '
        'txtObservacionTalanario
        '
        Me.txtObservacionTalanario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionTalanario.Location = New System.Drawing.Point(460, 4)
        Me.txtObservacionTalanario.MaxLength = 500
        Me.txtObservacionTalanario.Multiline = True
        Me.txtObservacionTalanario.Name = "txtObservacionTalanario"
        Me.txtObservacionTalanario.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionTalanario.Size = New System.Drawing.Size(200, 40)
        Me.txtObservacionTalanario.TabIndex = 10
        '
        'UltraLabel37
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Appearance26.TextVAlignAsString = "Middle"
        Me.UltraLabel37.Appearance = Appearance26
        Me.UltraLabel37.AutoSize = True
        Me.UltraLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel37.Location = New System.Drawing.Point(132, 7)
        Me.UltraLabel37.Name = "UltraLabel37"
        Me.UltraLabel37.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel37.TabIndex = 4
        Me.UltraLabel37.Text = "F. Ingreso:"
        '
        'txtFinal
        '
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance27.TextHAlignAsString = "Right"
        Me.txtFinal.Appearance = Appearance27
        Me.txtFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFinal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.txtFinal.InputMask = "nnnnnnnnn"
        Me.txtFinal.Location = New System.Drawing.Point(46, 25)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.NonAutoSizeHeight = 20
        Me.txtFinal.NullText = "50"
        Me.txtFinal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFinal.Size = New System.Drawing.Size(80, 21)
        Me.txtFinal.TabIndex = 3
        Me.txtFinal.Text = "50"
        '
        'verAnulado
        '
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.verAnulado.Appearance = Appearance28
        Me.verAnulado.AutoSize = True
        Me.verAnulado.Location = New System.Drawing.Point(132, 27)
        Me.verAnulado.Name = "verAnulado"
        Me.verAnulado.Size = New System.Drawing.Size(63, 18)
        Me.verAnulado.TabIndex = 6
        Me.verAnulado.TabStop = False
        Me.verAnulado.Text = "Anulado"
        '
        'verTerminado
        '
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.verTerminado.Appearance = Appearance29
        Me.verTerminado.AutoSize = True
        Me.verTerminado.Location = New System.Drawing.Point(209, 27)
        Me.verTerminado.Name = "verTerminado"
        Me.verTerminado.Size = New System.Drawing.Size(75, 18)
        Me.verTerminado.TabIndex = 7
        Me.verTerminado.TabStop = False
        Me.verTerminado.Text = "Terminado"
        '
        'UltraLabel3
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Appearance30.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance30
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(10, 28)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(32, 15)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Final:"
        '
        'btnAgregar
        '
        Appearance31.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.btnAgregar.Appearance = Appearance31
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(666, 15)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregar.TabIndex = 12
        '
        'UltraLabel12
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance32
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(6, 6)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel12.TabIndex = 0
        Me.UltraLabel12.Text = "Inicial:"
        '
        'txtInicial
        '
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance33.TextHAlignAsString = "Right"
        Me.txtInicial.Appearance = Appearance33
        Me.txtInicial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtInicial.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.txtInicial.InputMask = "nnnnnnnnn"
        Me.txtInicial.Location = New System.Drawing.Point(46, 3)
        Me.txtInicial.Name = "txtInicial"
        Me.txtInicial.NonAutoSizeHeight = 20
        Me.txtInicial.NullText = "1"
        Me.txtInicial.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtInicial.Size = New System.Drawing.Size(80, 21)
        Me.txtInicial.TabIndex = 1
        Me.txtInicial.Text = "1"
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.cboCuentaBancaria)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta4)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(1140, 55)
        Me.agrDatoGeneral.TabIndex = 0
        Me.agrDatoGeneral.Text = "Dato General"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboCuentaBancaria
        '
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Appearance = Appearance34
        Me.cboCuentaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaBancaria.DropDownListWidth = 400
        Me.cboCuentaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancaria.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Location = New System.Drawing.Point(83, 25)
        Me.cboCuentaBancaria.Name = "cboCuentaBancaria"
        Me.cboCuentaBancaria.Size = New System.Drawing.Size(352, 21)
        Me.cboCuentaBancaria.TabIndex = 1
        Me.cboCuentaBancaria.ValueMember = "Id"
        '
        'Etiqueta4
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance35
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(6, 27)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Cta Bancaria:"
        '
        'ficControlCheques
        '
        Me.ficControlCheques.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficControlCheques.Controls.Add(Me.UltraTabPageControl7)
        Me.ficControlCheques.Controls.Add(Me.utpDetalle)
        Me.ficControlCheques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficControlCheques.Location = New System.Drawing.Point(0, 0)
        Me.ficControlCheques.Name = "ficControlCheques"
        Me.ficControlCheques.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficControlCheques.Size = New System.Drawing.Size(1142, 445)
        Me.ficControlCheques.TabIndex = 0
        UltraTab6.Key = "Lista"
        UltraTab6.TabPage = Me.UltraTabPageControl7
        UltraTab6.Text = "Lista"
        UltraTab7.Key = "Mantenimiento"
        UltraTab7.TabPage = Me.utpDetalle
        UltraTab7.Text = "Mantenimiento"
        Me.ficControlCheques.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7})
        Me.ficControlCheques.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1140, 422)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(373, 188)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 1
        Me.ugb_Espera.Visible = False
        '
        'frm_ChequesControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 445)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficControlCheques)
        Me.Name = "frm_ChequesControl"
        Me.Text = "Control de Cheques"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaRegistro.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odChequesControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.numStockTalonarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorStockTalonarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.griTalonarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odChequesTalonarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruDetalle.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.txtTalonario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.PerformLayout()
        CType(Me.exgruDisponibleNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruDisponibleNo.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        CType(Me.ColorStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEnUso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTerminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacionTalanario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTerminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        Me.agrDatoGeneral.PerformLayout()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficControlCheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficControlCheques.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficControlCheques As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents numStockTalonarios As ISL.Controles.NumeroEntero
    Friend WithEvents ColorStockTalonarios As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents exgruDetalle As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtStockGuias As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtStockTalonarios As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents exgruDisponibleNo As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ColorStock As ISL.Controles.Colores
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAnulado As ISL.Controles.Colores
    Friend WithEvents ColorEnUso As ISL.Controles.Colores
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTerminado As ISL.Controles.Colores
    Friend WithEvents txtObservacionTalanario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtFinal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents verAnulado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verTerminado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtInicial As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboCuentaBancaria As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTalonario As ISL.Controles.Texto
    Friend WithEvents odChequesControl As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents odChequesTalonarios As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griTalonarios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnQuitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
End Class
