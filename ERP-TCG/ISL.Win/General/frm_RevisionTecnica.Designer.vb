<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RevisionTecnica
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
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmpresaPropietaria")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigencia")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAdquisicion")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Certificadora")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EmpresaPropietaria")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigencia")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAdquisicion")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumentoVehicular")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Calificacion")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumentoVehicular")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Calificacion")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
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
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid_ListadoRevisionT = New ISL.Controles.Grilla(Me.components)
        Me.dsListadoDocumentos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.CmbFilTracto = New ISL.Controles.ComboMaestros(Me.components)
        Me.chk_Vigentes = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.expVencer = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.numDias = New ISL.Controles.Numero(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorVencimiento = New ISL.Controles.Colores(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grid_RevisionTecnica = New ISL.Controles.Grilla(Me.components)
        Me.dsRevisionTecnica = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtCalificacion = New ISL.Controles.Texto(Me.components)
        Me.txtGlosaRevision = New ISL.Controles.Texto(Me.components)
        Me.TxtCodigo = New ISL.Controles.Texto(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.AyudaResultado = New Infragistics.Win.Misc.UltraLabel()
        Me.AyudaTipo = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEmpresa = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.CmbTracto = New ISL.Controles.ComboMaestros(Me.components)
        Me.TxtNroRuedas = New ISL.Controles.Texto(Me.components)
        Me.TxtNroEjes = New ISL.Controles.Texto(Me.components)
        Me.TxtMotor = New ISL.Controles.Texto(Me.components)
        Me.TxtSerie = New ISL.Controles.Texto(Me.components)
        Me.TxtAñoFabri = New ISL.Controles.Texto(Me.components)
        Me.TxtModelo = New ISL.Controles.Texto(Me.components)
        Me.TxtMarca = New ISL.Controles.Texto(Me.components)
        Me.TxtCategoria = New ISL.Controles.Texto(Me.components)
        Me.TxtPlaca = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaProxima = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtResultado = New ISL.Controles.Texto(Me.components)
        Me.dtp_FEmision = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNroCertificado = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNroInspeccion = New ISL.Controles.Texto(Me.components)
        Me.c = New Infragistics.Win.Misc.UltraLabel()
        Me.txtTipoInspeccion = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.tc_DocumentosVehiculares = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ToolTipAyudaTipo = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.ToolTipAyudaResultado = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Grid_ListadoRevisionT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsListadoDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.CmbFilTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_Vigentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expVencer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expVencer.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.numDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.grid_RevisionTecnica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRevisionTecnica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.TxtCalificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosaRevision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cboEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.CmbTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNroRuedas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNroEjes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMotor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAñoFabri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroCertificado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroInspeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoInspeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tc_DocumentosVehiculares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_DocumentosVehiculares.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Grid_ListadoRevisionT)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1233, 466)
        '
        'Grid_ListadoRevisionT
        '
        Me.Grid_ListadoRevisionT.DataSource = Me.dsListadoDocumentos
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
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance2
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.Caption = "F. Vencimiento"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance3
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Width = 113
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance4
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Width = 90
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.Caption = "Empresa Propietaria"
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Width = 236
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.Caption = "Estado de V."
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Width = 124
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn11.CellAppearance = Appearance5
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Header.VisiblePosition = 7
        UltraGridColumn11.Width = 105
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn18.Header.VisiblePosition = 11
        UltraGridColumn18.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn18})
        Me.Grid_ListadoRevisionT.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grid_ListadoRevisionT.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_ListadoRevisionT.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.Grid_ListadoRevisionT.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_ListadoRevisionT.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_ListadoRevisionT.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_ListadoRevisionT.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_ListadoRevisionT.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_ListadoRevisionT.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_ListadoRevisionT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_ListadoRevisionT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_ListadoRevisionT.Location = New System.Drawing.Point(0, 90)
        Me.Grid_ListadoRevisionT.Name = "Grid_ListadoRevisionT"
        Me.Grid_ListadoRevisionT.Size = New System.Drawing.Size(1233, 376)
        Me.Grid_ListadoRevisionT.TabIndex = 336
        '
        'dsListadoDocumentos
        '
        Me.dsListadoDocumentos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Agrupacion1.Controls.Add(Me.expVencer)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1233, 90)
        Me.Agrupacion1.TabIndex = 3
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance6
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(402, 68)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(402, 68)
        Me.UltraExpandableGroupBox1.TabIndex = 28
        Me.UltraExpandableGroupBox1.Text = "Filtros:"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.CmbFilTracto)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.chk_Vigentes)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(396, 49)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'Etiqueta4
        '
        Appearance7.BackColor = System.Drawing.Color.White
        Me.Etiqueta4.Appearance = Appearance7
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(194, 22)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(94, 14)
        Me.Etiqueta4.TabIndex = 11
        Me.Etiqueta4.Text = "Filtrar por Tractos:"
        '
        'CmbFilTracto
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.CmbFilTracto.Appearance = Appearance8
        Me.CmbFilTracto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CmbFilTracto.DisplayMember = "Placa"
        Me.CmbFilTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.CmbFilTracto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CmbFilTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFilTracto.ForeColor = System.Drawing.Color.Black
        Me.CmbFilTracto.Location = New System.Drawing.Point(294, 18)
        Me.CmbFilTracto.Name = "CmbFilTracto"
        Me.CmbFilTracto.Size = New System.Drawing.Size(94, 21)
        Me.CmbFilTracto.TabIndex = 10
        Me.CmbFilTracto.ValueMember = "Id"
        '
        'chk_Vigentes
        '
        Appearance9.BackColor = System.Drawing.Color.Gainsboro
        Me.chk_Vigentes.Appearance = Appearance9
        Me.chk_Vigentes.BackColor = System.Drawing.Color.Gainsboro
        Me.chk_Vigentes.BackColorInternal = System.Drawing.Color.Transparent
        Me.chk_Vigentes.Checked = True
        Me.chk_Vigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Vigentes.Location = New System.Drawing.Point(14, 19)
        Me.chk_Vigentes.Name = "chk_Vigentes"
        Me.chk_Vigentes.Size = New System.Drawing.Size(133, 20)
        Me.chk_Vigentes.TabIndex = 0
        Me.chk_Vigentes.Text = "Mostrar solo vigentes"
        '
        'expVencer
        '
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.expVencer.ContentAreaAppearance = Appearance10
        Me.expVencer.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.expVencer.ExpandedSize = New System.Drawing.Size(255, 68)
        Me.expVencer.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.expVencer.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.expVencer.Location = New System.Drawing.Point(428, 12)
        Me.expVencer.Name = "expVencer"
        Me.expVencer.Size = New System.Drawing.Size(255, 68)
        Me.expVencer.TabIndex = 27
        Me.expVencer.Text = "Por vencer"
        Me.expVencer.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.numDias)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta1)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta51)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorVencimiento)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(249, 49)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'numDias
        '
        Appearance11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numDias.Appearance = Appearance11
        Me.numDias.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDias.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numDias.Location = New System.Drawing.Point(97, 15)
        Me.numDias.MaskInput = "nnn"
        Me.numDias.Name = "numDias"
        Me.numDias.NullText = "0"
        Me.numDias.Size = New System.Drawing.Size(52, 21)
        Me.numDias.TabIndex = 38
        Me.numDias.Value = 45
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(155, 22)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(24, 14)
        Me.Etiqueta1.TabIndex = 9
        Me.Etiqueta1.Text = "días"
        '
        'Etiqueta51
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta51.Appearance = Appearance12
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(19, 22)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(72, 14)
        Me.Etiqueta51.TabIndex = 8
        Me.Etiqueta51.Text = "Por vencer en"
        '
        'ColorVencimiento
        '
        Me.ColorVencimiento.Color = System.Drawing.Color.LightCoral
        Me.ColorVencimiento.Location = New System.Drawing.Point(185, 15)
        Me.ColorVencimiento.Name = "ColorVencimiento"
        Me.ColorVencimiento.Size = New System.Drawing.Size(44, 21)
        Me.ColorVencimiento.TabIndex = 7
        Me.ColorVencimiento.Text = "LightCoral"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraPanel1)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1233, 466)
        '
        'UltraPanel1
        '
        Appearance13.BackColor = System.Drawing.Color.White
        Me.UltraPanel1.Appearance = Appearance13
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraGroupBox2)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraGroupBox1)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(1233, 466)
        Me.UltraPanel1.TabIndex = 0
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.grid_RevisionTecnica)
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 269)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1233, 197)
        Me.UltraGroupBox2.TabIndex = 2
        Me.UltraGroupBox2.Text = "Detalle de Revisión Técnica"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grid_RevisionTecnica
        '
        Me.grid_RevisionTecnica.DataSource = Me.dsRevisionTecnica
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn13.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn14.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Width = 102
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn15.Width = 718
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Header.VisiblePosition = 4
        UltraGridColumn16.Width = 137
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn17.Header.VisiblePosition = 5
        UltraGridColumn17.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.grid_RevisionTecnica.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid_RevisionTecnica.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_RevisionTecnica.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.grid_RevisionTecnica.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_RevisionTecnica.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_RevisionTecnica.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_RevisionTecnica.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_RevisionTecnica.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_RevisionTecnica.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_RevisionTecnica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_RevisionTecnica.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_RevisionTecnica.Location = New System.Drawing.Point(2, 65)
        Me.grid_RevisionTecnica.Name = "grid_RevisionTecnica"
        Me.grid_RevisionTecnica.Size = New System.Drawing.Size(1229, 130)
        Me.grid_RevisionTecnica.TabIndex = 335
        '
        'dsRevisionTecnica
        '
        Me.dsRevisionTecnica.Band.Columns.AddRange(New Object() {UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'UltraGroupBox4
        '
        Appearance14.BackColor = System.Drawing.Color.White
        Me.UltraGroupBox4.Appearance = Appearance14
        Me.UltraGroupBox4.Controls.Add(Me.UltraButton2)
        Me.UltraGroupBox4.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel20)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel19)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel18)
        Me.UltraGroupBox4.Controls.Add(Me.TxtCalificacion)
        Me.UltraGroupBox4.Controls.Add(Me.txtGlosaRevision)
        Me.UltraGroupBox4.Controls.Add(Me.TxtCodigo)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(2, 18)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1229, 47)
        Me.UltraGroupBox4.TabIndex = 334
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraButton2
        '
        Appearance15.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Me.UltraButton2.Appearance = Appearance15
        Me.UltraButton2.Location = New System.Drawing.Point(913, 11)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(25, 24)
        Me.UltraButton2.TabIndex = 340
        '
        'UltraButton1
        '
        Appearance16.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.UltraButton1.Appearance = Appearance16
        Me.UltraButton1.Location = New System.Drawing.Point(882, 11)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(25, 24)
        Me.UltraButton1.TabIndex = 90
        '
        'UltraLabel20
        '
        Me.UltraLabel20.Location = New System.Drawing.Point(632, 18)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(71, 16)
        Me.UltraLabel20.TabIndex = 339
        Me.UltraLabel20.Text = "Calificación:"
        '
        'UltraLabel19
        '
        Me.UltraLabel19.Location = New System.Drawing.Point(190, 15)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(71, 16)
        Me.UltraLabel19.TabIndex = 338
        Me.UltraLabel19.Text = "Descripción:"
        '
        'UltraLabel18
        '
        Me.UltraLabel18.Location = New System.Drawing.Point(8, 15)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(56, 17)
        Me.UltraLabel18.TabIndex = 337
        Me.UltraLabel18.Text = "Código:"
        '
        'TxtCalificacion
        '
        Appearance17.BackColor = System.Drawing.Color.White
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCalificacion.Appearance = Appearance17
        Me.TxtCalificacion.BackColor = System.Drawing.Color.White
        Me.TxtCalificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCalificacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtCalificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCalificacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCalificacion.Location = New System.Drawing.Point(720, 13)
        Me.TxtCalificacion.MaxLength = 100
        Me.TxtCalificacion.Name = "TxtCalificacion"
        Me.TxtCalificacion.Size = New System.Drawing.Size(140, 21)
        Me.TxtCalificacion.TabIndex = 80
        '
        'txtGlosaRevision
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosaRevision.Appearance = Appearance18
        Me.txtGlosaRevision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaRevision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaRevision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaRevision.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosaRevision.Location = New System.Drawing.Point(267, 11)
        Me.txtGlosaRevision.MaxLength = 100
        Me.txtGlosaRevision.Multiline = True
        Me.txtGlosaRevision.Name = "txtGlosaRevision"
        Me.txtGlosaRevision.Size = New System.Drawing.Size(359, 23)
        Me.txtGlosaRevision.TabIndex = 70
        '
        'TxtCodigo
        '
        Appearance19.BackColor = System.Drawing.Color.White
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCodigo.Appearance = Appearance19
        Me.TxtCodigo.BackColor = System.Drawing.Color.White
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCodigo.Location = New System.Drawing.Point(70, 11)
        Me.TxtCodigo.MaxLength = 100
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(104, 21)
        Me.TxtCodigo.TabIndex = 60
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.AyudaResultado)
        Me.UltraGroupBox1.Controls.Add(Me.AyudaTipo)
        Me.UltraGroupBox1.Controls.Add(Me.cboEmpresa)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.dtp_FechaProxima)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.TxtResultado)
        Me.UltraGroupBox1.Controls.Add(Me.dtp_FEmision)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.txtNroCertificado)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.txtNroInspeccion)
        Me.UltraGroupBox1.Controls.Add(Me.c)
        Me.UltraGroupBox1.Controls.Add(Me.txtTipoInspeccion)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1233, 269)
        Me.UltraGroupBox1.TabIndex = 3
        Me.UltraGroupBox1.Text = "Detalle de Revisión Técnica"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'AyudaResultado
        '
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.AyudaResultado.Appearance = Appearance20
        Me.AyudaResultado.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.AyudaResultado.Location = New System.Drawing.Point(304, 197)
        Me.AyudaResultado.Name = "AyudaResultado"
        Me.AyudaResultado.Size = New System.Drawing.Size(11, 21)
        Me.AyudaResultado.TabIndex = 479
        Me.AyudaResultado.Text = "?"
        '
        'AyudaTipo
        '
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.AyudaTipo.Appearance = Appearance21
        Me.AyudaTipo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.AyudaTipo.Location = New System.Drawing.Point(496, 90)
        Me.AyudaTipo.Name = "AyudaTipo"
        Me.AyudaTipo.Size = New System.Drawing.Size(11, 21)
        Me.AyudaTipo.TabIndex = 478
        Me.AyudaTipo.Text = "?"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEmpresa.DisplayMember = "Nombre"
        Me.cboEmpresa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpresa.Location = New System.Drawing.Point(170, 61)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(337, 22)
        Me.cboEmpresa.TabIndex = 1
        Me.cboEmpresa.ValueMember = "Id"
        '
        'UltraLabel21
        '
        Me.UltraLabel21.Location = New System.Drawing.Point(359, 120)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(49, 13)
        Me.UltraLabel21.TabIndex = 361
        Me.UltraLabel21.Text = "Glosa:"
        '
        'TxtDescripcion
        '
        Appearance22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtDescripcion.Appearance = Appearance22
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtDescripcion.Location = New System.Drawing.Point(359, 136)
        Me.TxtDescripcion.MaxLength = 100
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(148, 109)
        Me.TxtDescripcion.TabIndex = 40
        '
        'UltraLabel17
        '
        Me.UltraLabel17.Location = New System.Drawing.Point(16, 66)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(134, 17)
        Me.UltraLabel17.TabIndex = 359
        Me.UltraLabel17.Text = "Empresa Emisora:"
        '
        'UltraGroupBox3
        '
        Appearance23.BackColor = System.Drawing.Color.White
        Me.UltraGroupBox3.Appearance = Appearance23
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox5)
        Me.UltraGroupBox3.Controls.Add(Me.TxtNroRuedas)
        Me.UltraGroupBox3.Controls.Add(Me.TxtNroEjes)
        Me.UltraGroupBox3.Controls.Add(Me.TxtMotor)
        Me.UltraGroupBox3.Controls.Add(Me.TxtSerie)
        Me.UltraGroupBox3.Controls.Add(Me.TxtAñoFabri)
        Me.UltraGroupBox3.Controls.Add(Me.TxtModelo)
        Me.UltraGroupBox3.Controls.Add(Me.TxtMarca)
        Me.UltraGroupBox3.Controls.Add(Me.TxtCategoria)
        Me.UltraGroupBox3.Controls.Add(Me.TxtPlaca)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel15)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(545, 57)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(418, 188)
        Me.UltraGroupBox3.TabIndex = 357
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel16)
        Me.UltraGroupBox5.Controls.Add(Me.CmbTracto)
        Me.UltraGroupBox5.Location = New System.Drawing.Point(13, 7)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(393, 36)
        Me.UltraGroupBox5.TabIndex = 344
        '
        'UltraLabel16
        '
        Me.UltraLabel16.Location = New System.Drawing.Point(18, 12)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(163, 18)
        Me.UltraLabel16.TabIndex = 12
        Me.UltraLabel16.Text = "Características del vehículo:"
        '
        'CmbTracto
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.CmbTracto.Appearance = Appearance24
        Me.CmbTracto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CmbTracto.DisplayMember = "Placa"
        Me.CmbTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CmbTracto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CmbTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTracto.ForeColor = System.Drawing.Color.Black
        Me.CmbTracto.Location = New System.Drawing.Point(204, 8)
        Me.CmbTracto.Name = "CmbTracto"
        Me.CmbTracto.Size = New System.Drawing.Size(183, 21)
        Me.CmbTracto.TabIndex = 50
        Me.CmbTracto.ValueMember = "Id"
        '
        'TxtNroRuedas
        '
        Appearance25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtNroRuedas.Appearance = Appearance25
        Me.TxtNroRuedas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNroRuedas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtNroRuedas.Enabled = False
        Me.TxtNroRuedas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroRuedas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtNroRuedas.Location = New System.Drawing.Point(291, 130)
        Me.TxtNroRuedas.MaxLength = 100
        Me.TxtNroRuedas.Name = "TxtNroRuedas"
        Me.TxtNroRuedas.Size = New System.Drawing.Size(109, 21)
        Me.TxtNroRuedas.TabIndex = 297
        '
        'TxtNroEjes
        '
        Appearance26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtNroEjes.Appearance = Appearance26
        Me.TxtNroEjes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNroEjes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtNroEjes.Enabled = False
        Me.TxtNroEjes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroEjes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtNroEjes.Location = New System.Drawing.Point(291, 102)
        Me.TxtNroEjes.MaxLength = 100
        Me.TxtNroEjes.Name = "TxtNroEjes"
        Me.TxtNroEjes.Size = New System.Drawing.Size(109, 21)
        Me.TxtNroEjes.TabIndex = 296
        '
        'TxtMotor
        '
        Appearance27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMotor.Appearance = Appearance27
        Me.TxtMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMotor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtMotor.Enabled = False
        Me.TxtMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMotor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMotor.Location = New System.Drawing.Point(291, 75)
        Me.TxtMotor.MaxLength = 100
        Me.TxtMotor.Name = "TxtMotor"
        Me.TxtMotor.Size = New System.Drawing.Size(109, 21)
        Me.TxtMotor.TabIndex = 295
        '
        'TxtSerie
        '
        Appearance28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtSerie.Appearance = Appearance28
        Me.TxtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtSerie.Enabled = False
        Me.TxtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSerie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtSerie.Location = New System.Drawing.Point(291, 48)
        Me.TxtSerie.MaxLength = 100
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(109, 21)
        Me.TxtSerie.TabIndex = 294
        '
        'TxtAñoFabri
        '
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAñoFabri.Appearance = Appearance29
        Me.TxtAñoFabri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAñoFabri.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtAñoFabri.Enabled = False
        Me.TxtAñoFabri.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAñoFabri.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtAñoFabri.Location = New System.Drawing.Point(85, 157)
        Me.TxtAñoFabri.MaxLength = 100
        Me.TxtAñoFabri.Name = "TxtAñoFabri"
        Me.TxtAñoFabri.Size = New System.Drawing.Size(109, 21)
        Me.TxtAñoFabri.TabIndex = 293
        '
        'TxtModelo
        '
        Appearance30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtModelo.Appearance = Appearance30
        Me.TxtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtModelo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtModelo.Enabled = False
        Me.TxtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtModelo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtModelo.Location = New System.Drawing.Point(85, 130)
        Me.TxtModelo.MaxLength = 100
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(109, 21)
        Me.TxtModelo.TabIndex = 292
        '
        'TxtMarca
        '
        Appearance31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMarca.Appearance = Appearance31
        Me.TxtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMarca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtMarca.Enabled = False
        Me.TxtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtMarca.Location = New System.Drawing.Point(85, 102)
        Me.TxtMarca.MaxLength = 100
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(109, 21)
        Me.TxtMarca.TabIndex = 291
        '
        'TxtCategoria
        '
        Appearance32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCategoria.Appearance = Appearance32
        Me.TxtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCategoria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtCategoria.Enabled = False
        Me.TxtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCategoria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCategoria.Location = New System.Drawing.Point(85, 75)
        Me.TxtCategoria.MaxLength = 100
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(109, 21)
        Me.TxtCategoria.TabIndex = 290
        '
        'TxtPlaca
        '
        Appearance33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPlaca.Appearance = Appearance33
        Me.TxtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPlaca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtPlaca.Enabled = False
        Me.TxtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlaca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPlaca.Location = New System.Drawing.Point(85, 48)
        Me.TxtPlaca.MaxLength = 100
        Me.TxtPlaca.Name = "TxtPlaca"
        Me.TxtPlaca.Size = New System.Drawing.Size(109, 21)
        Me.TxtPlaca.TabIndex = 289
        '
        'UltraLabel13
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel13.Appearance = Appearance34
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(223, 134)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(72, 14)
        Me.UltraLabel13.TabIndex = 21
        Me.UltraLabel13.Text = "9.N° Ruedas:"
        '
        'UltraLabel12
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel12.Appearance = Appearance35
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(223, 106)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel12.TabIndex = 20
        Me.UltraLabel12.Text = "8. N°Ejes:"
        '
        'UltraLabel11
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel11.Appearance = Appearance36
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(223, 79)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel11.TabIndex = 19
        Me.UltraLabel11.Text = "7. N° Motor:"
        '
        'UltraLabel10
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel10.Appearance = Appearance37
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(223, 52)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel10.TabIndex = 18
        Me.UltraLabel10.Text = "6. N° Serie:"
        '
        'UltraLabel9
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel9.Appearance = Appearance38
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(13, 161)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel9.TabIndex = 17
        Me.UltraLabel9.Text = "5. Año fabr.:"
        '
        'UltraLabel8
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel8.Appearance = Appearance39
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(13, 134)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(57, 14)
        Me.UltraLabel8.TabIndex = 16
        Me.UltraLabel8.Text = "4. Modelo:"
        '
        'UltraLabel7
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel7.Appearance = Appearance40
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(13, 106)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel7.TabIndex = 15
        Me.UltraLabel7.Text = "3. Marca:"
        '
        'UltraLabel14
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel14.Appearance = Appearance41
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(13, 79)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(69, 14)
        Me.UltraLabel14.TabIndex = 14
        Me.UltraLabel14.Text = "2. Categoria:"
        '
        'UltraLabel15
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel15.Appearance = Appearance42
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(13, 52)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel15.TabIndex = 13
        Me.UltraLabel15.Text = "1. Placa:"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(16, 231)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(134, 14)
        Me.UltraLabel6.TabIndex = 356
        Me.UltraLabel6.Text = "Fec. Prox./Venc.  Insp.:"
        '
        'dtp_FechaProxima
        '
        Me.dtp_FechaProxima.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaProxima.Location = New System.Drawing.Point(170, 225)
        Me.dtp_FechaProxima.Name = "dtp_FechaProxima"
        Me.dtp_FechaProxima.Size = New System.Drawing.Size(145, 20)
        Me.dtp_FechaProxima.TabIndex = 30
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(16, 201)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(146, 17)
        Me.UltraLabel4.TabIndex = 352
        Me.UltraLabel4.Text = "Resultado de Inspección:"
        '
        'TxtResultado
        '
        Appearance43.BackColor = System.Drawing.Color.White
        Appearance43.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtResultado.Appearance = Appearance43
        Me.TxtResultado.BackColor = System.Drawing.Color.White
        Me.TxtResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtResultado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtResultado.Location = New System.Drawing.Point(170, 197)
        Me.TxtResultado.MaxLength = 100
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(131, 21)
        Me.TxtResultado.TabIndex = 20
        '
        'dtp_FEmision
        '
        Me.dtp_FEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FEmision.Location = New System.Drawing.Point(170, 117)
        Me.dtp_FEmision.Name = "dtp_FEmision"
        Me.dtp_FEmision.Size = New System.Drawing.Size(145, 20)
        Me.dtp_FEmision.TabIndex = 3
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 121)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(134, 16)
        Me.UltraLabel2.TabIndex = 349
        Me.UltraLabel2.Text = "Fecha de Inspección:"
        '
        'txtNroCertificado
        '
        Appearance44.BackColor = System.Drawing.Color.White
        Appearance44.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroCertificado.Appearance = Appearance44
        Me.txtNroCertificado.BackColor = System.Drawing.Color.White
        Me.txtNroCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroCertificado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroCertificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroCertificado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroCertificado.Location = New System.Drawing.Point(170, 170)
        Me.txtNroCertificado.MaxLength = 100
        Me.txtNroCertificado.Name = "txtNroCertificado"
        Me.txtNroCertificado.Size = New System.Drawing.Size(145, 21)
        Me.txtNroCertificado.TabIndex = 10
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel3.Location = New System.Drawing.Point(16, 175)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(134, 16)
        Me.UltraLabel3.TabIndex = 347
        Me.UltraLabel3.Text = "CERTIFICADO N°:"
        '
        'txtNroInspeccion
        '
        Appearance45.BackColor = System.Drawing.Color.White
        Appearance45.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroInspeccion.Appearance = Appearance45
        Me.txtNroInspeccion.BackColor = System.Drawing.Color.White
        Me.txtNroInspeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroInspeccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroInspeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroInspeccion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroInspeccion.Location = New System.Drawing.Point(170, 143)
        Me.txtNroInspeccion.MaxLength = 100
        Me.txtNroInspeccion.Name = "txtNroInspeccion"
        Me.txtNroInspeccion.Size = New System.Drawing.Size(145, 21)
        Me.txtNroInspeccion.TabIndex = 4
        '
        'c
        '
        Me.c.Location = New System.Drawing.Point(16, 148)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(134, 16)
        Me.c.TabIndex = 345
        Me.c.Text = "Informe de Inspección N°:"
        '
        'txtTipoInspeccion
        '
        Appearance46.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Appearance46.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoInspeccion.Appearance = Appearance46
        Me.txtTipoInspeccion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtTipoInspeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoInspeccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoInspeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoInspeccion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoInspeccion.Location = New System.Drawing.Point(170, 90)
        Me.txtTipoInspeccion.MaxLength = 100
        Me.txtTipoInspeccion.Name = "txtTipoInspeccion"
        Me.txtTipoInspeccion.Size = New System.Drawing.Size(323, 21)
        Me.txtTipoInspeccion.TabIndex = 2
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(16, 94)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(134, 17)
        Me.UltraLabel1.TabIndex = 343
        Me.UltraLabel1.Text = "Tipo de Inspección:"
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
        Me.tc_DocumentosVehiculares.Size = New System.Drawing.Size(1235, 489)
        Me.tc_DocumentosVehiculares.TabIndex = 1
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
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1233, 466)
        '
        'ToolTipAyudaTipo
        '
        Me.ToolTipAyudaTipo.ContainingControl = Me
        '
        'ToolTipAyudaResultado
        '
        Me.ToolTipAyudaResultado.ContainingControl = Me
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'frm_RevisionTecnica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 489)
        Me.Controls.Add(Me.tc_DocumentosVehiculares)
        Me.Name = "frm_RevisionTecnica"
        Me.Text = "Revisiones Técnicas"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Grid_ListadoRevisionT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsListadoDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.CmbFilTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_Vigentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expVencer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expVencer.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.numDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.grid_RevisionTecnica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRevisionTecnica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.TxtCalificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosaRevision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cboEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.UltraGroupBox5.PerformLayout()
        CType(Me.CmbTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNroRuedas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNroEjes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMotor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAñoFabri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroCertificado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroInspeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoInspeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tc_DocumentosVehiculares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_DocumentosVehiculares.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tc_DocumentosVehiculares As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grid_ListadoRevisionT As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents chk_Vigentes As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents expVencer As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents numDias As ISL.Controles.Numero
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents ColorVencimiento As ISL.Controles.Colores
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents grid_RevisionTecnica As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtCalificacion As ISL.Controles.Texto
    Friend WithEvents txtGlosaRevision As ISL.Controles.Texto
    Friend WithEvents TxtCodigo As ISL.Controles.Texto
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtDescripcion As ISL.Controles.Texto
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CmbTracto As ISL.Controles.ComboMaestros
    Friend WithEvents TxtNroRuedas As ISL.Controles.Texto
    Friend WithEvents TxtNroEjes As ISL.Controles.Texto
    Friend WithEvents TxtMotor As ISL.Controles.Texto
    Friend WithEvents TxtSerie As ISL.Controles.Texto
    Friend WithEvents TxtAñoFabri As ISL.Controles.Texto
    Friend WithEvents TxtModelo As ISL.Controles.Texto
    Friend WithEvents TxtMarca As ISL.Controles.Texto
    Friend WithEvents TxtCategoria As ISL.Controles.Texto
    Friend WithEvents TxtPlaca As ISL.Controles.Texto
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaProxima As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtResultado As ISL.Controles.Texto
    Friend WithEvents dtp_FEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNroCertificado As ISL.Controles.Texto
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNroInspeccion As ISL.Controles.Texto
    Friend WithEvents c As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTipoInspeccion As ISL.Controles.Texto
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboEmpresa As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents AyudaTipo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents AyudaResultado As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolTipAyudaTipo As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents ToolTipAyudaResultado As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents dsRevisionTecnica As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents CmbFilTracto As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents dsListadoDocumentos As Infragistics.Win.UltraWinDataSource.UltraDataSource
End Class
