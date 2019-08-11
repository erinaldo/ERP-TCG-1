<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TarjetaPropiedad
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Certificadora")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAdquisicion")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmpresaPropietaria")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigencia")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Certificadora")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAdquisicion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EmpresaPropietaria")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigencia")
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
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid_ListadoTarjetaP = New ISL.Controles.Grilla(Me.components)
        Me.dsListadoDocumentos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.CmbFilTracto = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.TxtGlosaTP = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel55 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtTituloTP = New ISL.Controles.Texto(Me.components)
        Me.TxtPartidaTP = New ISL.Controles.Texto(Me.components)
        Me.dtp_FechaAdquisicionTP = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaEmisionTP = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel56 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel57 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel58 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel59 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel70 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel69 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel68 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtRuedasTP = New ISL.Controles.Texto(Me.components)
        Me.TxtEjesTP = New ISL.Controles.Texto(Me.components)
        Me.TxtFRTP = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel67 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel66 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel65 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtPotenciaTP = New ISL.Controles.Texto(Me.components)
        Me.TxtCombustibleTP = New ISL.Controles.Texto(Me.components)
        Me.TxtCarroceriaTP = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel64 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtMotorTP = New ISL.Controles.Texto(Me.components)
        Me.TxtSerieTP = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel63 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel42 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel43 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtAñoModTP = New ISL.Controles.Texto(Me.components)
        Me.TxtAñoFabTP = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel44 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel45 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel46 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtAltoTP = New ISL.Controles.Texto(Me.components)
        Me.TxtAnchoTP = New ISL.Controles.Texto(Me.components)
        Me.TxtLargoTP = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel47 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel48 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel49 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtPBrutoTP = New ISL.Controles.Texto(Me.components)
        Me.TxtCUtilTP = New ISL.Controles.Texto(Me.components)
        Me.TxtPNetoTP = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel50 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel51 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel52 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtMarcaTP = New ISL.Controles.Texto(Me.components)
        Me.TxtModeloTP = New ISL.Controles.Texto(Me.components)
        Me.TxtClaseTP = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel62 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel53 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtEmpPropietariaTP = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel54 = New Infragistics.Win.Misc.UltraLabel()
        Me.CmbPlacaTP = New ISL.Controles.ComboMaestros(Me.components)
        Me.tc_DocumentosVehiculares = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Grid_ListadoTarjetaP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsListadoDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.CmbFilTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.TxtGlosaTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTituloTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPartidaTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.TxtRuedasTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEjesTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFRTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPotenciaTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCombustibleTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCarroceriaTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMotorTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSerieTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAñoModTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAñoFabTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAltoTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAnchoTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLargoTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPBrutoTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCUtilTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPNetoTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMarcaTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtModeloTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtClaseTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmpPropietariaTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbPlacaTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tc_DocumentosVehiculares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_DocumentosVehiculares.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Grid_ListadoTarjetaP)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1070, 463)
        '
        'Grid_ListadoTarjetaP
        '
        Me.Grid_ListadoTarjetaP.DataSource = Me.dsListadoDocumentos
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.Caption = "Tipo de Documento"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 153
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.Caption = "Empresa Certificadora"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 246
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance1
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.Caption = "F. Emision"
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance2
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.Caption = "F. Vencimiento"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn12.CellAppearance = Appearance3
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.VisiblePosition = 7
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance4
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Width = 113
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance5
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Width = 90
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.Caption = "Empresa Propietaria"
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Width = 236
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.Caption = "Estado de V."
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Width = 124
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn11.CellAppearance = Appearance6
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 105
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn12, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.Grid_ListadoTarjetaP.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid_ListadoTarjetaP.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_ListadoTarjetaP.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.Grid_ListadoTarjetaP.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_ListadoTarjetaP.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_ListadoTarjetaP.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_ListadoTarjetaP.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_ListadoTarjetaP.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_ListadoTarjetaP.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_ListadoTarjetaP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_ListadoTarjetaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_ListadoTarjetaP.Location = New System.Drawing.Point(0, 90)
        Me.Grid_ListadoTarjetaP.Name = "Grid_ListadoTarjetaP"
        Me.Grid_ListadoTarjetaP.Size = New System.Drawing.Size(1070, 373)
        Me.Grid_ListadoTarjetaP.TabIndex = 336
        '
        'dsListadoDocumentos
        '
        Me.dsListadoDocumentos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1070, 90)
        Me.Agrupacion1.TabIndex = 3
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance7
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(208, 68)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(208, 68)
        Me.UltraExpandableGroupBox1.TabIndex = 28
        Me.UltraExpandableGroupBox1.Text = "Filtros:"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.CmbFilTracto)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(202, 49)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'Etiqueta4
        '
        Appearance8.BackColor = System.Drawing.Color.White
        Me.Etiqueta4.Appearance = Appearance8
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(3, 22)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(94, 14)
        Me.Etiqueta4.TabIndex = 11
        Me.Etiqueta4.Text = "Filtrar por Tractos:"
        '
        'CmbFilTracto
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.CmbFilTracto.Appearance = Appearance9
        Me.CmbFilTracto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CmbFilTracto.DisplayMember = "Placa"
        Me.CmbFilTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.CmbFilTracto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CmbFilTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFilTracto.ForeColor = System.Drawing.Color.Black
        Me.CmbFilTracto.Location = New System.Drawing.Point(103, 18)
        Me.CmbFilTracto.Name = "CmbFilTracto"
        Me.CmbFilTracto.Size = New System.Drawing.Size(94, 21)
        Me.CmbFilTracto.TabIndex = 10
        Me.CmbFilTracto.ValueMember = "Id"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraPanel1)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1070, 463)
        '
        'UltraPanel1
        '
        Appearance10.BackColor = System.Drawing.Color.White
        Me.UltraPanel1.Appearance = Appearance10
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraGroupBox1)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(1070, 341)
        Me.UltraPanel1.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.TxtGlosaTP)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel55)
        Me.UltraGroupBox1.Controls.Add(Me.TxtTituloTP)
        Me.UltraGroupBox1.Controls.Add(Me.TxtPartidaTP)
        Me.UltraGroupBox1.Controls.Add(Me.dtp_FechaAdquisicionTP)
        Me.UltraGroupBox1.Controls.Add(Me.dtp_FechaEmisionTP)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel56)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel57)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel58)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel59)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox8)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1070, 341)
        Me.UltraGroupBox1.TabIndex = 3
        Me.UltraGroupBox1.Text = "Detalle de la tarjeta de Propiedad"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'TxtGlosaTP
        '
        Appearance11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtGlosaTP.Appearance = Appearance11
        Me.TxtGlosaTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGlosaTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtGlosaTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGlosaTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtGlosaTP.Location = New System.Drawing.Point(667, 82)
        Me.TxtGlosaTP.MaxLength = 100
        Me.TxtGlosaTP.Multiline = True
        Me.TxtGlosaTP.Name = "TxtGlosaTP"
        Me.TxtGlosaTP.Size = New System.Drawing.Size(376, 53)
        Me.TxtGlosaTP.TabIndex = 361
        '
        'UltraLabel55
        '
        Me.UltraLabel55.Location = New System.Drawing.Point(14, 120)
        Me.UltraLabel55.Name = "UltraLabel55"
        Me.UltraLabel55.Size = New System.Drawing.Size(120, 15)
        Me.UltraLabel55.TabIndex = 360
        Me.UltraLabel55.Text = "Título:"
        '
        'TxtTituloTP
        '
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtTituloTP.Appearance = Appearance12
        Me.TxtTituloTP.BackColor = System.Drawing.Color.White
        Me.TxtTituloTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTituloTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtTituloTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTituloTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtTituloTP.Location = New System.Drawing.Point(140, 113)
        Me.TxtTituloTP.MaxLength = 100
        Me.TxtTituloTP.Name = "TxtTituloTP"
        Me.TxtTituloTP.Size = New System.Drawing.Size(122, 21)
        Me.TxtTituloTP.TabIndex = 359
        '
        'TxtPartidaTP
        '
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPartidaTP.Appearance = Appearance13
        Me.TxtPartidaTP.BackColor = System.Drawing.Color.White
        Me.TxtPartidaTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPartidaTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtPartidaTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPartidaTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPartidaTP.Location = New System.Drawing.Point(140, 82)
        Me.TxtPartidaTP.MaxLength = 100
        Me.TxtPartidaTP.Name = "TxtPartidaTP"
        Me.TxtPartidaTP.Size = New System.Drawing.Size(122, 21)
        Me.TxtPartidaTP.TabIndex = 358
        '
        'dtp_FechaAdquisicionTP
        '
        Me.dtp_FechaAdquisicionTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaAdquisicionTP.Location = New System.Drawing.Point(447, 82)
        Me.dtp_FechaAdquisicionTP.Name = "dtp_FechaAdquisicionTP"
        Me.dtp_FechaAdquisicionTP.Size = New System.Drawing.Size(122, 20)
        Me.dtp_FechaAdquisicionTP.TabIndex = 356
        '
        'dtp_FechaEmisionTP
        '
        Me.dtp_FechaEmisionTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaEmisionTP.Location = New System.Drawing.Point(447, 115)
        Me.dtp_FechaEmisionTP.Name = "dtp_FechaEmisionTP"
        Me.dtp_FechaEmisionTP.Size = New System.Drawing.Size(122, 20)
        Me.dtp_FechaEmisionTP.TabIndex = 355
        '
        'UltraLabel56
        '
        Me.UltraLabel56.Location = New System.Drawing.Point(14, 86)
        Me.UltraLabel56.Name = "UltraLabel56"
        Me.UltraLabel56.Size = New System.Drawing.Size(120, 15)
        Me.UltraLabel56.TabIndex = 354
        Me.UltraLabel56.Text = "N° de Partida registral:"
        '
        'UltraLabel57
        '
        Me.UltraLabel57.Location = New System.Drawing.Point(321, 86)
        Me.UltraLabel57.Name = "UltraLabel57"
        Me.UltraLabel57.Size = New System.Drawing.Size(120, 17)
        Me.UltraLabel57.TabIndex = 353
        Me.UltraLabel57.Text = "Fecha de Adquisición:"
        '
        'UltraLabel58
        '
        Me.UltraLabel58.Location = New System.Drawing.Point(321, 119)
        Me.UltraLabel58.Name = "UltraLabel58"
        Me.UltraLabel58.Size = New System.Drawing.Size(120, 17)
        Me.UltraLabel58.TabIndex = 352
        Me.UltraLabel58.Text = "Fecha de expedición:"
        '
        'UltraLabel59
        '
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel59.Appearance = Appearance14
        Me.UltraLabel59.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel59.Location = New System.Drawing.Point(421, 30)
        Me.UltraLabel59.Name = "UltraLabel59"
        Me.UltraLabel59.Size = New System.Drawing.Size(315, 30)
        Me.UltraLabel59.TabIndex = 351
        Me.UltraLabel59.Text = "TARJETA DE IDENTIFICACIÓN VEHICULAR"
        '
        'UltraGroupBox8
        '
        Appearance15.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance15.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Me.UltraGroupBox8.Appearance = Appearance15
        Me.UltraGroupBox8.Controls.Add(Me.UltraGroupBox7)
        Me.UltraGroupBox8.Controls.Add(Me.UltraLabel62)
        Me.UltraGroupBox8.Controls.Add(Me.UltraLabel53)
        Me.UltraGroupBox8.Controls.Add(Me.TxtEmpPropietariaTP)
        Me.UltraGroupBox8.Controls.Add(Me.UltraLabel54)
        Me.UltraGroupBox8.Controls.Add(Me.CmbPlacaTP)
        Me.UltraGroupBox8.Location = New System.Drawing.Point(12, 150)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(1039, 179)
        Me.UltraGroupBox8.TabIndex = 357
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraGroupBox7
        '
        Appearance16.BackColor = System.Drawing.Color.White
        Me.UltraGroupBox7.Appearance = Appearance16
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel70)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel69)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel68)
        Me.UltraGroupBox7.Controls.Add(Me.TxtRuedasTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtEjesTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtFRTP)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel67)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel66)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel65)
        Me.UltraGroupBox7.Controls.Add(Me.TxtPotenciaTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtCombustibleTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtCarroceriaTP)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel64)
        Me.UltraGroupBox7.Controls.Add(Me.TxtMotorTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtSerieTP)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel63)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel42)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel43)
        Me.UltraGroupBox7.Controls.Add(Me.TxtAñoModTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtAñoFabTP)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel44)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel45)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel46)
        Me.UltraGroupBox7.Controls.Add(Me.TxtAltoTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtAnchoTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtLargoTP)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel47)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel48)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel49)
        Me.UltraGroupBox7.Controls.Add(Me.TxtPBrutoTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtCUtilTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtPNetoTP)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel50)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel51)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel52)
        Me.UltraGroupBox7.Controls.Add(Me.TxtMarcaTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtModeloTP)
        Me.UltraGroupBox7.Controls.Add(Me.TxtClaseTP)
        Me.UltraGroupBox7.Location = New System.Drawing.Point(7, 34)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(1022, 137)
        Me.UltraGroupBox7.TabIndex = 348
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraLabel70
        '
        Me.UltraLabel70.Location = New System.Drawing.Point(712, 107)
        Me.UltraLabel70.Name = "UltraLabel70"
        Me.UltraLabel70.Size = New System.Drawing.Size(48, 17)
        Me.UltraLabel70.TabIndex = 383
        Me.UltraLabel70.Text = "Ruedas:"
        '
        'UltraLabel69
        '
        Me.UltraLabel69.Location = New System.Drawing.Point(504, 104)
        Me.UltraLabel69.Name = "UltraLabel69"
        Me.UltraLabel69.Size = New System.Drawing.Size(65, 17)
        Me.UltraLabel69.TabIndex = 382
        Me.UltraLabel69.Text = "Ejes:"
        '
        'UltraLabel68
        '
        Me.UltraLabel68.Location = New System.Drawing.Point(875, 79)
        Me.UltraLabel68.Name = "UltraLabel68"
        Me.UltraLabel68.Size = New System.Drawing.Size(76, 15)
        Me.UltraLabel68.TabIndex = 381
        Me.UltraLabel68.Text = "F.R.:"
        '
        'TxtRuedasTP
        '
        Appearance17.BackColor = System.Drawing.Color.White
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtRuedasTP.Appearance = Appearance17
        Me.TxtRuedasTP.BackColor = System.Drawing.Color.White
        Me.TxtRuedasTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRuedasTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtRuedasTP.Enabled = False
        Me.TxtRuedasTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRuedasTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtRuedasTP.Location = New System.Drawing.Point(766, 100)
        Me.TxtRuedasTP.MaxLength = 100
        Me.TxtRuedasTP.Name = "TxtRuedasTP"
        Me.TxtRuedasTP.Size = New System.Drawing.Size(50, 21)
        Me.TxtRuedasTP.TabIndex = 380
        '
        'TxtEjesTP
        '
        Appearance18.BackColor = System.Drawing.Color.White
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtEjesTP.Appearance = Appearance18
        Me.TxtEjesTP.BackColor = System.Drawing.Color.White
        Me.TxtEjesTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEjesTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtEjesTP.Enabled = False
        Me.TxtEjesTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEjesTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtEjesTP.Location = New System.Drawing.Point(596, 100)
        Me.TxtEjesTP.MaxLength = 100
        Me.TxtEjesTP.Name = "TxtEjesTP"
        Me.TxtEjesTP.Size = New System.Drawing.Size(51, 21)
        Me.TxtEjesTP.TabIndex = 379
        '
        'TxtFRTP
        '
        Appearance19.BackColor = System.Drawing.Color.White
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtFRTP.Appearance = Appearance19
        Me.TxtFRTP.BackColor = System.Drawing.Color.White
        Me.TxtFRTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFRTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtFRTP.Enabled = False
        Me.TxtFRTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFRTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtFRTP.Location = New System.Drawing.Point(957, 73)
        Me.TxtFRTP.MaxLength = 100
        Me.TxtFRTP.Name = "TxtFRTP"
        Me.TxtFRTP.Size = New System.Drawing.Size(52, 21)
        Me.TxtFRTP.TabIndex = 378
        '
        'UltraLabel67
        '
        Me.UltraLabel67.Location = New System.Drawing.Point(13, 107)
        Me.UltraLabel67.Name = "UltraLabel67"
        Me.UltraLabel67.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel67.TabIndex = 377
        Me.UltraLabel67.Text = "Potencia:"
        '
        'UltraLabel66
        '
        Me.UltraLabel66.Location = New System.Drawing.Point(13, 80)
        Me.UltraLabel66.Name = "UltraLabel66"
        Me.UltraLabel66.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel66.TabIndex = 376
        Me.UltraLabel66.Text = "Combustible:"
        '
        'UltraLabel65
        '
        Me.UltraLabel65.Location = New System.Drawing.Point(13, 53)
        Me.UltraLabel65.Name = "UltraLabel65"
        Me.UltraLabel65.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel65.TabIndex = 375
        Me.UltraLabel65.Text = "Carrocería:"
        '
        'TxtPotenciaTP
        '
        Appearance20.BackColor = System.Drawing.Color.White
        Appearance20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPotenciaTP.Appearance = Appearance20
        Me.TxtPotenciaTP.BackColor = System.Drawing.Color.White
        Me.TxtPotenciaTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPotenciaTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtPotenciaTP.Enabled = False
        Me.TxtPotenciaTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPotenciaTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPotenciaTP.Location = New System.Drawing.Point(88, 100)
        Me.TxtPotenciaTP.MaxLength = 100
        Me.TxtPotenciaTP.Name = "TxtPotenciaTP"
        Me.TxtPotenciaTP.Size = New System.Drawing.Size(119, 21)
        Me.TxtPotenciaTP.TabIndex = 374
        '
        'TxtCombustibleTP
        '
        Appearance21.BackColor = System.Drawing.Color.White
        Appearance21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCombustibleTP.Appearance = Appearance21
        Me.TxtCombustibleTP.BackColor = System.Drawing.Color.White
        Me.TxtCombustibleTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCombustibleTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtCombustibleTP.Enabled = False
        Me.TxtCombustibleTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCombustibleTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCombustibleTP.Location = New System.Drawing.Point(88, 73)
        Me.TxtCombustibleTP.MaxLength = 100
        Me.TxtCombustibleTP.Name = "TxtCombustibleTP"
        Me.TxtCombustibleTP.Size = New System.Drawing.Size(119, 21)
        Me.TxtCombustibleTP.TabIndex = 373
        '
        'TxtCarroceriaTP
        '
        Appearance22.BackColor = System.Drawing.Color.White
        Appearance22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCarroceriaTP.Appearance = Appearance22
        Me.TxtCarroceriaTP.BackColor = System.Drawing.Color.White
        Me.TxtCarroceriaTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCarroceriaTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtCarroceriaTP.Enabled = False
        Me.TxtCarroceriaTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCarroceriaTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCarroceriaTP.Location = New System.Drawing.Point(88, 46)
        Me.TxtCarroceriaTP.MaxLength = 100
        Me.TxtCarroceriaTP.Name = "TxtCarroceriaTP"
        Me.TxtCarroceriaTP.Size = New System.Drawing.Size(119, 21)
        Me.TxtCarroceriaTP.TabIndex = 372
        '
        'UltraLabel64
        '
        Me.UltraLabel64.Location = New System.Drawing.Point(13, 26)
        Me.UltraLabel64.Name = "UltraLabel64"
        Me.UltraLabel64.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel64.TabIndex = 371
        Me.UltraLabel64.Text = "Motor:"
        '
        'TxtMotorTP
        '
        Appearance23.BackColor = System.Drawing.Color.White
        Appearance23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMotorTP.Appearance = Appearance23
        Me.TxtMotorTP.BackColor = System.Drawing.Color.White
        Me.TxtMotorTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMotorTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtMotorTP.Enabled = False
        Me.TxtMotorTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMotorTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMotorTP.Location = New System.Drawing.Point(88, 19)
        Me.TxtMotorTP.MaxLength = 100
        Me.TxtMotorTP.Name = "TxtMotorTP"
        Me.TxtMotorTP.Size = New System.Drawing.Size(119, 21)
        Me.TxtMotorTP.TabIndex = 370
        '
        'TxtSerieTP
        '
        Appearance24.BackColor = System.Drawing.Color.White
        Appearance24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtSerieTP.Appearance = Appearance24
        Me.TxtSerieTP.BackColor = System.Drawing.Color.White
        Me.TxtSerieTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSerieTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtSerieTP.Enabled = False
        Me.TxtSerieTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSerieTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtSerieTP.Location = New System.Drawing.Point(336, 100)
        Me.TxtSerieTP.MaxLength = 100
        Me.TxtSerieTP.Name = "TxtSerieTP"
        Me.TxtSerieTP.Size = New System.Drawing.Size(119, 21)
        Me.TxtSerieTP.TabIndex = 369
        '
        'UltraLabel63
        '
        Me.UltraLabel63.Location = New System.Drawing.Point(261, 107)
        Me.UltraLabel63.Name = "UltraLabel63"
        Me.UltraLabel63.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel63.TabIndex = 368
        Me.UltraLabel63.Text = "Serie Chasis:"
        '
        'UltraLabel42
        '
        Me.UltraLabel42.Location = New System.Drawing.Point(875, 50)
        Me.UltraLabel42.Name = "UltraLabel42"
        Me.UltraLabel42.Size = New System.Drawing.Size(76, 15)
        Me.UltraLabel42.TabIndex = 367
        Me.UltraLabel42.Text = "Año de Mod.:"
        '
        'UltraLabel43
        '
        Me.UltraLabel43.Location = New System.Drawing.Point(875, 23)
        Me.UltraLabel43.Name = "UltraLabel43"
        Me.UltraLabel43.Size = New System.Drawing.Size(76, 17)
        Me.UltraLabel43.TabIndex = 366
        Me.UltraLabel43.Text = "Año de fabr.:"
        '
        'TxtAñoModTP
        '
        Appearance25.BackColor = System.Drawing.Color.White
        Appearance25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAñoModTP.Appearance = Appearance25
        Me.TxtAñoModTP.BackColor = System.Drawing.Color.White
        Me.TxtAñoModTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAñoModTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtAñoModTP.Enabled = False
        Me.TxtAñoModTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAñoModTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAñoModTP.Location = New System.Drawing.Point(957, 46)
        Me.TxtAñoModTP.MaxLength = 100
        Me.TxtAñoModTP.Name = "TxtAñoModTP"
        Me.TxtAñoModTP.Size = New System.Drawing.Size(52, 21)
        Me.TxtAñoModTP.TabIndex = 365
        '
        'TxtAñoFabTP
        '
        Appearance26.BackColor = System.Drawing.Color.White
        Appearance26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAñoFabTP.Appearance = Appearance26
        Me.TxtAñoFabTP.BackColor = System.Drawing.Color.White
        Me.TxtAñoFabTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAñoFabTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtAñoFabTP.Enabled = False
        Me.TxtAñoFabTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAñoFabTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAñoFabTP.Location = New System.Drawing.Point(957, 19)
        Me.TxtAñoFabTP.MaxLength = 100
        Me.TxtAñoFabTP.Name = "TxtAñoFabTP"
        Me.TxtAñoFabTP.Size = New System.Drawing.Size(52, 21)
        Me.TxtAñoFabTP.TabIndex = 364
        '
        'UltraLabel44
        '
        Me.UltraLabel44.Location = New System.Drawing.Point(712, 50)
        Me.UltraLabel44.Name = "UltraLabel44"
        Me.UltraLabel44.Size = New System.Drawing.Size(48, 17)
        Me.UltraLabel44.TabIndex = 363
        Me.UltraLabel44.Text = "Alto:"
        '
        'UltraLabel45
        '
        Me.UltraLabel45.Location = New System.Drawing.Point(712, 79)
        Me.UltraLabel45.Name = "UltraLabel45"
        Me.UltraLabel45.Size = New System.Drawing.Size(48, 17)
        Me.UltraLabel45.TabIndex = 362
        Me.UltraLabel45.Text = "Ancho:"
        '
        'UltraLabel46
        '
        Me.UltraLabel46.Location = New System.Drawing.Point(712, 23)
        Me.UltraLabel46.Name = "UltraLabel46"
        Me.UltraLabel46.Size = New System.Drawing.Size(48, 17)
        Me.UltraLabel46.TabIndex = 361
        Me.UltraLabel46.Text = "Largo:"
        '
        'TxtAltoTP
        '
        Appearance27.BackColor = System.Drawing.Color.White
        Appearance27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAltoTP.Appearance = Appearance27
        Me.TxtAltoTP.BackColor = System.Drawing.Color.White
        Me.TxtAltoTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAltoTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtAltoTP.Enabled = False
        Me.TxtAltoTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAltoTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAltoTP.Location = New System.Drawing.Point(766, 46)
        Me.TxtAltoTP.MaxLength = 100
        Me.TxtAltoTP.Name = "TxtAltoTP"
        Me.TxtAltoTP.Size = New System.Drawing.Size(50, 21)
        Me.TxtAltoTP.TabIndex = 360
        '
        'TxtAnchoTP
        '
        Appearance28.BackColor = System.Drawing.Color.White
        Appearance28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAnchoTP.Appearance = Appearance28
        Me.TxtAnchoTP.BackColor = System.Drawing.Color.White
        Me.TxtAnchoTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAnchoTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtAnchoTP.Enabled = False
        Me.TxtAnchoTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAnchoTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAnchoTP.Location = New System.Drawing.Point(766, 73)
        Me.TxtAnchoTP.MaxLength = 100
        Me.TxtAnchoTP.Name = "TxtAnchoTP"
        Me.TxtAnchoTP.Size = New System.Drawing.Size(50, 21)
        Me.TxtAnchoTP.TabIndex = 359
        '
        'TxtLargoTP
        '
        Appearance29.BackColor = System.Drawing.Color.White
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtLargoTP.Appearance = Appearance29
        Me.TxtLargoTP.BackColor = System.Drawing.Color.White
        Me.TxtLargoTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLargoTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtLargoTP.Enabled = False
        Me.TxtLargoTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLargoTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtLargoTP.Location = New System.Drawing.Point(766, 19)
        Me.TxtLargoTP.MaxLength = 100
        Me.TxtLargoTP.Name = "TxtLargoTP"
        Me.TxtLargoTP.Size = New System.Drawing.Size(50, 21)
        Me.TxtLargoTP.TabIndex = 358
        '
        'UltraLabel47
        '
        Me.UltraLabel47.Location = New System.Drawing.Point(504, 23)
        Me.UltraLabel47.Name = "UltraLabel47"
        Me.UltraLabel47.Size = New System.Drawing.Size(87, 17)
        Me.UltraLabel47.TabIndex = 357
        Me.UltraLabel47.Text = "Peso bruto(Kg)"
        '
        'UltraLabel48
        '
        Me.UltraLabel48.Location = New System.Drawing.Point(504, 53)
        Me.UltraLabel48.Name = "UltraLabel48"
        Me.UltraLabel48.Size = New System.Drawing.Size(77, 17)
        Me.UltraLabel48.TabIndex = 356
        Me.UltraLabel48.Text = "Carga Útil(Kg)"
        '
        'UltraLabel49
        '
        Me.UltraLabel49.Location = New System.Drawing.Point(504, 80)
        Me.UltraLabel49.Name = "UltraLabel49"
        Me.UltraLabel49.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel49.TabIndex = 355
        Me.UltraLabel49.Text = "Peso Neto:"
        '
        'TxtPBrutoTP
        '
        Appearance30.BackColor = System.Drawing.Color.White
        Appearance30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPBrutoTP.Appearance = Appearance30
        Me.TxtPBrutoTP.BackColor = System.Drawing.Color.White
        Me.TxtPBrutoTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPBrutoTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtPBrutoTP.Enabled = False
        Me.TxtPBrutoTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPBrutoTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPBrutoTP.Location = New System.Drawing.Point(596, 19)
        Me.TxtPBrutoTP.MaxLength = 100
        Me.TxtPBrutoTP.Name = "TxtPBrutoTP"
        Me.TxtPBrutoTP.Size = New System.Drawing.Size(51, 21)
        Me.TxtPBrutoTP.TabIndex = 354
        '
        'TxtCUtilTP
        '
        Appearance31.BackColor = System.Drawing.Color.White
        Appearance31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCUtilTP.Appearance = Appearance31
        Me.TxtCUtilTP.BackColor = System.Drawing.Color.White
        Me.TxtCUtilTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCUtilTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtCUtilTP.Enabled = False
        Me.TxtCUtilTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCUtilTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCUtilTP.Location = New System.Drawing.Point(596, 46)
        Me.TxtCUtilTP.MaxLength = 100
        Me.TxtCUtilTP.Name = "TxtCUtilTP"
        Me.TxtCUtilTP.Size = New System.Drawing.Size(51, 21)
        Me.TxtCUtilTP.TabIndex = 353
        '
        'TxtPNetoTP
        '
        Appearance32.BackColor = System.Drawing.Color.White
        Appearance32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPNetoTP.Appearance = Appearance32
        Me.TxtPNetoTP.BackColor = System.Drawing.Color.White
        Me.TxtPNetoTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPNetoTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtPNetoTP.Enabled = False
        Me.TxtPNetoTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPNetoTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPNetoTP.Location = New System.Drawing.Point(596, 73)
        Me.TxtPNetoTP.MaxLength = 100
        Me.TxtPNetoTP.Name = "TxtPNetoTP"
        Me.TxtPNetoTP.Size = New System.Drawing.Size(51, 21)
        Me.TxtPNetoTP.TabIndex = 352
        '
        'UltraLabel50
        '
        Me.UltraLabel50.Location = New System.Drawing.Point(261, 80)
        Me.UltraLabel50.Name = "UltraLabel50"
        Me.UltraLabel50.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel50.TabIndex = 351
        Me.UltraLabel50.Text = "Marca:"
        '
        'UltraLabel51
        '
        Me.UltraLabel51.Location = New System.Drawing.Point(261, 50)
        Me.UltraLabel51.Name = "UltraLabel51"
        Me.UltraLabel51.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel51.TabIndex = 350
        Me.UltraLabel51.Text = "Modelo:"
        '
        'UltraLabel52
        '
        Me.UltraLabel52.Location = New System.Drawing.Point(261, 23)
        Me.UltraLabel52.Name = "UltraLabel52"
        Me.UltraLabel52.Size = New System.Drawing.Size(48, 17)
        Me.UltraLabel52.TabIndex = 349
        Me.UltraLabel52.Text = "Clase:"
        '
        'TxtMarcaTP
        '
        Appearance33.BackColor = System.Drawing.Color.White
        Appearance33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMarcaTP.Appearance = Appearance33
        Me.TxtMarcaTP.BackColor = System.Drawing.Color.White
        Me.TxtMarcaTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMarcaTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtMarcaTP.Enabled = False
        Me.TxtMarcaTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarcaTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMarcaTP.Location = New System.Drawing.Point(336, 73)
        Me.TxtMarcaTP.MaxLength = 100
        Me.TxtMarcaTP.Name = "TxtMarcaTP"
        Me.TxtMarcaTP.Size = New System.Drawing.Size(119, 21)
        Me.TxtMarcaTP.TabIndex = 348
        '
        'TxtModeloTP
        '
        Appearance34.BackColor = System.Drawing.Color.White
        Appearance34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtModeloTP.Appearance = Appearance34
        Me.TxtModeloTP.BackColor = System.Drawing.Color.White
        Me.TxtModeloTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtModeloTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtModeloTP.Enabled = False
        Me.TxtModeloTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtModeloTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtModeloTP.Location = New System.Drawing.Point(336, 46)
        Me.TxtModeloTP.MaxLength = 100
        Me.TxtModeloTP.Name = "TxtModeloTP"
        Me.TxtModeloTP.Size = New System.Drawing.Size(119, 21)
        Me.TxtModeloTP.TabIndex = 347
        '
        'TxtClaseTP
        '
        Appearance35.BackColor = System.Drawing.Color.White
        Appearance35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtClaseTP.Appearance = Appearance35
        Me.TxtClaseTP.BackColor = System.Drawing.Color.White
        Me.TxtClaseTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtClaseTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtClaseTP.Enabled = False
        Me.TxtClaseTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClaseTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtClaseTP.Location = New System.Drawing.Point(336, 19)
        Me.TxtClaseTP.MaxLength = 100
        Me.TxtClaseTP.Name = "TxtClaseTP"
        Me.TxtClaseTP.Size = New System.Drawing.Size(119, 21)
        Me.TxtClaseTP.TabIndex = 346
        '
        'UltraLabel62
        '
        Me.UltraLabel62.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel62.Location = New System.Drawing.Point(7, 11)
        Me.UltraLabel62.Name = "UltraLabel62"
        Me.UltraLabel62.Size = New System.Drawing.Size(152, 18)
        Me.UltraLabel62.TabIndex = 350
        Me.UltraLabel62.Text = "DATOS DEL VEHÍCULO:"
        '
        'UltraLabel53
        '
        Me.UltraLabel53.Location = New System.Drawing.Point(474, 11)
        Me.UltraLabel53.Name = "UltraLabel53"
        Me.UltraLabel53.Size = New System.Drawing.Size(115, 14)
        Me.UltraLabel53.TabIndex = 349
        Me.UltraLabel53.Text = "Empresa Propietaria:"
        '
        'TxtEmpPropietariaTP
        '
        Appearance36.BackColor = System.Drawing.Color.White
        Appearance36.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance36.TextHAlignAsString = "Center"
        Me.TxtEmpPropietariaTP.Appearance = Appearance36
        Me.TxtEmpPropietariaTP.BackColor = System.Drawing.Color.White
        Me.TxtEmpPropietariaTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmpPropietariaTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtEmpPropietariaTP.Enabled = False
        Me.TxtEmpPropietariaTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpPropietariaTP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtEmpPropietariaTP.Location = New System.Drawing.Point(596, 7)
        Me.TxtEmpPropietariaTP.MaxLength = 100
        Me.TxtEmpPropietariaTP.Name = "TxtEmpPropietariaTP"
        Me.TxtEmpPropietariaTP.Size = New System.Drawing.Size(433, 21)
        Me.TxtEmpPropietariaTP.TabIndex = 349
        Me.TxtEmpPropietariaTP.Text = "NO DISPONIBLE"
        '
        'UltraLabel54
        '
        Me.UltraLabel54.Location = New System.Drawing.Point(211, 11)
        Me.UltraLabel54.Name = "UltraLabel54"
        Me.UltraLabel54.Size = New System.Drawing.Size(93, 16)
        Me.UltraLabel54.TabIndex = 12
        Me.UltraLabel54.Text = "Placa de rodaje:"
        '
        'CmbPlacaTP
        '
        Appearance37.ForeColor = System.Drawing.Color.Black
        Me.CmbPlacaTP.Appearance = Appearance37
        Me.CmbPlacaTP.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CmbPlacaTP.DisplayMember = "Placa"
        Me.CmbPlacaTP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CmbPlacaTP.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CmbPlacaTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPlacaTP.ForeColor = System.Drawing.Color.Black
        Me.CmbPlacaTP.Location = New System.Drawing.Point(310, 7)
        Me.CmbPlacaTP.Name = "CmbPlacaTP"
        Me.CmbPlacaTP.Size = New System.Drawing.Size(81, 21)
        Me.CmbPlacaTP.TabIndex = 11
        Me.CmbPlacaTP.ValueMember = "Id"
        '
        'tc_DocumentosVehiculares
        '
        Me.tc_DocumentosVehiculares.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tc_DocumentosVehiculares.Controls.Add(Me.UltraTabPageControl1)
        Me.tc_DocumentosVehiculares.Controls.Add(Me.UltraTabPageControl2)
        Me.tc_DocumentosVehiculares.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_DocumentosVehiculares.Location = New System.Drawing.Point(0, 0)
        Me.tc_DocumentosVehiculares.Name = "tc_DocumentosVehiculares"
        Me.tc_DocumentosVehiculares.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tc_DocumentosVehiculares.Size = New System.Drawing.Size(1072, 486)
        Me.tc_DocumentosVehiculares.TabIndex = 2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tc_DocumentosVehiculares.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tc_DocumentosVehiculares.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1070, 463)
        '
        'frm_TarjetaPropiedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 486)
        Me.Controls.Add(Me.tc_DocumentosVehiculares)
        Me.Name = "frm_TarjetaPropiedad"
        Me.Text = "Tarjetas de Propiedad"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Grid_ListadoTarjetaP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsListadoDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.CmbFilTracto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.TxtGlosaTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTituloTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPartidaTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        Me.UltraGroupBox8.PerformLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        Me.UltraGroupBox7.PerformLayout()
        CType(Me.TxtRuedasTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEjesTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFRTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPotenciaTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCombustibleTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCarroceriaTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMotorTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSerieTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAñoModTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAñoFabTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAltoTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAnchoTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLargoTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPBrutoTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCUtilTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPNetoTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMarcaTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtModeloTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtClaseTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmpPropietariaTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbPlacaTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tc_DocumentosVehiculares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_DocumentosVehiculares.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tc_DocumentosVehiculares As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grid_ListadoTarjetaP As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents CmbFilTracto As ISL.Controles.ComboMaestros
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents TxtGlosaTP As ISL.Controles.Texto
    Friend WithEvents UltraLabel55 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtTituloTP As ISL.Controles.Texto
    Friend WithEvents TxtPartidaTP As ISL.Controles.Texto
    Friend WithEvents dtp_FechaAdquisicionTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaEmisionTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel56 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel57 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel58 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel59 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel70 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel69 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel68 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtRuedasTP As ISL.Controles.Texto
    Friend WithEvents TxtEjesTP As ISL.Controles.Texto
    Friend WithEvents TxtFRTP As ISL.Controles.Texto
    Friend WithEvents UltraLabel67 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel66 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel65 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtPotenciaTP As ISL.Controles.Texto
    Friend WithEvents TxtCombustibleTP As ISL.Controles.Texto
    Friend WithEvents TxtCarroceriaTP As ISL.Controles.Texto
    Friend WithEvents UltraLabel64 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtMotorTP As ISL.Controles.Texto
    Friend WithEvents TxtSerieTP As ISL.Controles.Texto
    Friend WithEvents UltraLabel63 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel42 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel43 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtAñoModTP As ISL.Controles.Texto
    Friend WithEvents TxtAñoFabTP As ISL.Controles.Texto
    Friend WithEvents UltraLabel44 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel45 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel46 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtAltoTP As ISL.Controles.Texto
    Friend WithEvents TxtAnchoTP As ISL.Controles.Texto
    Friend WithEvents TxtLargoTP As ISL.Controles.Texto
    Friend WithEvents UltraLabel47 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel48 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel49 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtPBrutoTP As ISL.Controles.Texto
    Friend WithEvents TxtCUtilTP As ISL.Controles.Texto
    Friend WithEvents TxtPNetoTP As ISL.Controles.Texto
    Friend WithEvents UltraLabel50 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel51 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel52 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtMarcaTP As ISL.Controles.Texto
    Friend WithEvents TxtModeloTP As ISL.Controles.Texto
    Friend WithEvents TxtClaseTP As ISL.Controles.Texto
    Friend WithEvents UltraLabel62 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel53 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtEmpPropietariaTP As ISL.Controles.Texto
    Friend WithEvents UltraLabel54 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CmbPlacaTP As ISL.Controles.ComboMaestros
    Friend WithEvents dsListadoDocumentos As Infragistics.Win.UltraWinDataSource.UltraDataSource
End Class
