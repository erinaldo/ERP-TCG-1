<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CpeFacturacion
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
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CpeFacturacion))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugPendientes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugEnviar = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mDescargarXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.mImprimirPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mDescargarCDR = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugResumen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugEnviados = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugEnviarBaja = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugBaja = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugTicket = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugEnviarPC = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.espFacturacion = New ISL.Win.Espere()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.SdGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.upGrillas = New Infragistics.Win.Misc.UltraPanel()
        Me.utcFichaDocumentos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.tsp_Principal_Filtro = New System.Windows.Forms.ToolStrip()
        Me.Tsb_Env_Filtro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsb_Consultar_Filtro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tsd_FactElectronico = New System.Windows.Forms.ToolStripDropDownButton()
        Me.XMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargaZIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarCDRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvioACorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsb_Exportar_Filtro = New System.Windows.Forms.ToolStripButton()
        Me.ugbAgrupacion = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucpGenerado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucpAceptado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucpProceso = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucpRechazado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.Ugb_Filtros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmbSerie = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.cmb_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.chk_Validacion = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.dtp_FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.rbResumen = New System.Windows.Forms.RadioButton()
        Me.bwCpe = New System.ComponentModel.BackgroundWorker()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ugPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugEnviar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.ugResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.ugEnviados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.ugEnviarBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.ugBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.ugTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.ugEnviarPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.upGrillas.ClientArea.SuspendLayout()
        Me.upGrillas.SuspendLayout()
        CType(Me.utcFichaDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcFichaDocumentos.SuspendLayout()
        Me.tsp_Principal_Filtro.SuspendLayout()
        CType(Me.ugbAgrupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbAgrupacion.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ucpGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucpAceptado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucpProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucpRechazado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ugb_Filtros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ugb_Filtros.SuspendLayout()
        CType(Me.cmbSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_Validacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ugPendientes)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1352, 338)
        '
        'ugPendientes
        '
        Me.ugPendientes.DisplayLayout.MaxColScrollRegions = 1
        Me.ugPendientes.DisplayLayout.MaxRowScrollRegions = 1
        Me.ugPendientes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugPendientes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugPendientes.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.ugPendientes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugPendientes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugPendientes.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ugPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugPendientes.Location = New System.Drawing.Point(0, 0)
        Me.ugPendientes.Name = "ugPendientes"
        Me.ugPendientes.Size = New System.Drawing.Size(1352, 338)
        Me.ugPendientes.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugEnviar)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1352, 338)
        '
        'ugEnviar
        '
        Me.ugEnviar.ContextMenuStrip = Me.MenuDetalle
        Me.ugEnviar.DisplayLayout.MaxColScrollRegions = 1
        Me.ugEnviar.DisplayLayout.MaxRowScrollRegions = 1
        Me.ugEnviar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugEnviar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugEnviar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.ugEnviar.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugEnviar.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugEnviar.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ugEnviar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugEnviar.Location = New System.Drawing.Point(0, 0)
        Me.ugEnviar.Name = "ugEnviar"
        Me.ugEnviar.Size = New System.Drawing.Size(1352, 338)
        Me.ugEnviar.TabIndex = 1
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mDescargarXML, Me.mImprimirPDF, Me.mDescargarCDR})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(185, 82)
        '
        'mDescargarXML
        '
        Me.mDescargarXML.Image = Global.ISL.Win.My.Resources.Resources.if_application_xml_28904
        Me.mDescargarXML.Name = "mDescargarXML"
        Me.mDescargarXML.Size = New System.Drawing.Size(184, 26)
        Me.mDescargarXML.Text = "Descargar XML"
        '
        'mImprimirPDF
        '
        Me.mImprimirPDF.Image = Global.ISL.Win.My.Resources.Resources.if_pdf_272699
        Me.mImprimirPDF.Name = "mImprimirPDF"
        Me.mImprimirPDF.Size = New System.Drawing.Size(184, 26)
        Me.mImprimirPDF.Text = "Imprimir Comprobante"
        '
        'mDescargarCDR
        '
        Me.mDescargarCDR.Image = Global.ISL.Win.My.Resources.Resources.if_30_1933170
        Me.mDescargarCDR.Name = "mDescargarCDR"
        Me.mDescargarCDR.Size = New System.Drawing.Size(184, 26)
        Me.mDescargarCDR.Text = "Descargar CDR"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.ugResumen)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1352, 338)
        '
        'ugResumen
        '
        Me.ugResumen.ContextMenuStrip = Me.MenuDetalle
        Me.ugResumen.DisplayLayout.MaxColScrollRegions = 1
        Me.ugResumen.DisplayLayout.MaxRowScrollRegions = 1
        Me.ugResumen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugResumen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugResumen.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.ugResumen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugResumen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugResumen.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ugResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugResumen.Location = New System.Drawing.Point(0, 0)
        Me.ugResumen.Name = "ugResumen"
        Me.ugResumen.Size = New System.Drawing.Size(1352, 338)
        Me.ugResumen.TabIndex = 2
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ugEnviados)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1352, 338)
        '
        'ugEnviados
        '
        Me.ugEnviados.ContextMenuStrip = Me.MenuDetalle
        Me.ugEnviados.DisplayLayout.MaxColScrollRegions = 1
        Me.ugEnviados.DisplayLayout.MaxRowScrollRegions = 1
        Me.ugEnviados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugEnviados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugEnviados.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.ugEnviados.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugEnviados.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugEnviados.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ugEnviados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugEnviados.Location = New System.Drawing.Point(0, 0)
        Me.ugEnviados.Name = "ugEnviados"
        Me.ugEnviados.Size = New System.Drawing.Size(1352, 338)
        Me.ugEnviados.TabIndex = 2
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.ugEnviarBaja)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1352, 338)
        '
        'ugEnviarBaja
        '
        Me.ugEnviarBaja.ContextMenuStrip = Me.MenuDetalle
        Me.ugEnviarBaja.DisplayLayout.MaxColScrollRegions = 1
        Me.ugEnviarBaja.DisplayLayout.MaxRowScrollRegions = 1
        Me.ugEnviarBaja.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugEnviarBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugEnviarBaja.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.ugEnviarBaja.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugEnviarBaja.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugEnviarBaja.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ugEnviarBaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugEnviarBaja.Location = New System.Drawing.Point(0, 0)
        Me.ugEnviarBaja.Name = "ugEnviarBaja"
        Me.ugEnviarBaja.Size = New System.Drawing.Size(1352, 338)
        Me.ugEnviarBaja.TabIndex = 1
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.ugBaja)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1352, 338)
        '
        'ugBaja
        '
        Me.ugBaja.ContextMenuStrip = Me.MenuDetalle
        Me.ugBaja.DisplayLayout.MaxColScrollRegions = 1
        Me.ugBaja.DisplayLayout.MaxRowScrollRegions = 1
        Me.ugBaja.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugBaja.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.ugBaja.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.ugBaja.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugBaja.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugBaja.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ugBaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugBaja.Location = New System.Drawing.Point(0, 0)
        Me.ugBaja.Name = "ugBaja"
        Me.ugBaja.Size = New System.Drawing.Size(1352, 338)
        Me.ugBaja.TabIndex = 2
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.ugTicket)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1352, 338)
        '
        'ugTicket
        '
        Me.ugTicket.ContextMenuStrip = Me.MenuDetalle
        Me.ugTicket.DisplayLayout.MaxColScrollRegions = 1
        Me.ugTicket.DisplayLayout.MaxRowScrollRegions = 1
        Me.ugTicket.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugTicket.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugTicket.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.ugTicket.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.ugTicket.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugTicket.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugTicket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugTicket.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugTicket.Location = New System.Drawing.Point(0, 0)
        Me.ugTicket.Name = "ugTicket"
        Me.ugTicket.Size = New System.Drawing.Size(1352, 338)
        Me.ugTicket.TabIndex = 1
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.ugEnviarPC)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1352, 338)
        '
        'ugEnviarPC
        '
        Me.ugEnviarPC.DisplayLayout.MaxColScrollRegions = 1
        Me.ugEnviarPC.DisplayLayout.MaxRowScrollRegions = 1
        Me.ugEnviarPC.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugEnviarPC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugEnviarPC.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.ugEnviarPC.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugEnviarPC.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugEnviarPC.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ugEnviarPC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugEnviarPC.Location = New System.Drawing.Point(0, 0)
        Me.ugEnviarPC.Name = "ugEnviarPC"
        Me.ugEnviarPC.Size = New System.Drawing.Size(1352, 338)
        Me.ugEnviarPC.TabIndex = 3
        '
        'espFacturacion
        '
        Me.espFacturacion.AutoSize = True
        Me.espFacturacion.BackColor = System.Drawing.Color.White
        Me.espFacturacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.espFacturacion.Location = New System.Drawing.Point(343, 234)
        Me.espFacturacion.Name = "espFacturacion"
        Me.espFacturacion.Size = New System.Drawing.Size(462, 69)
        Me.espFacturacion.TabIndex = 148
        Me.espFacturacion.Visible = False
        '
        'upGrillas
        '
        '
        'upGrillas.ClientArea
        '
        Me.upGrillas.ClientArea.Controls.Add(Me.utcFichaDocumentos)
        Me.upGrillas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.upGrillas.Location = New System.Drawing.Point(0, 121)
        Me.upGrillas.Name = "upGrillas"
        Me.upGrillas.Size = New System.Drawing.Size(1356, 361)
        Me.upGrillas.TabIndex = 127
        '
        'utcFichaDocumentos
        '
        Me.utcFichaDocumentos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utcFichaDocumentos.Controls.Add(Me.UltraTabPageControl1)
        Me.utcFichaDocumentos.Controls.Add(Me.UltraTabPageControl2)
        Me.utcFichaDocumentos.Controls.Add(Me.UltraTabPageControl3)
        Me.utcFichaDocumentos.Controls.Add(Me.UltraTabPageControl4)
        Me.utcFichaDocumentos.Controls.Add(Me.UltraTabPageControl5)
        Me.utcFichaDocumentos.Controls.Add(Me.UltraTabPageControl6)
        Me.utcFichaDocumentos.Controls.Add(Me.UltraTabPageControl7)
        Me.utcFichaDocumentos.Controls.Add(Me.UltraTabPageControl8)
        Me.utcFichaDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcFichaDocumentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.utcFichaDocumentos.Location = New System.Drawing.Point(0, 0)
        Me.utcFichaDocumentos.Name = "utcFichaDocumentos"
        Me.utcFichaDocumentos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utcFichaDocumentos.Size = New System.Drawing.Size(1356, 361)
        Me.utcFichaDocumentos.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.utcFichaDocumentos.TabIndex = 126
        UltraTab8.TabPage = Me.UltraTabPageControl1
        UltraTab8.Text = "Documentos Pendientes"
        UltraTab9.TabPage = Me.UltraTabPageControl2
        UltraTab9.Text = "Documentos a Informar"
        UltraTab1.TabPage = Me.UltraTabPageControl8
        UltraTab1.Text = "Resumen Diario"
        UltraTab10.TabPage = Me.UltraTabPageControl3
        UltraTab10.Text = "Documentos Informados"
        UltraTab11.TabPage = Me.UltraTabPageControl4
        UltraTab11.Text = "Comunicación de Baja"
        UltraTab12.TabPage = Me.UltraTabPageControl5
        UltraTab12.Text = "Documentos Anulados"
        UltraTab13.TabPage = Me.UltraTabPageControl6
        UltraTab13.Text = "Ticket"
        UltraTab14.TabPage = Me.UltraTabPageControl7
        UltraTab14.Text = "Enviar Doc. a Portal De Consultas"
        Me.utcFichaDocumentos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab8, UltraTab9, UltraTab1, UltraTab10, UltraTab11, UltraTab12, UltraTab13, UltraTab14})
        Me.utcFichaDocumentos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1352, 338)
        '
        'tsp_Principal_Filtro
        '
        Me.tsp_Principal_Filtro.AutoSize = False
        Me.tsp_Principal_Filtro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsp_Principal_Filtro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsb_Env_Filtro, Me.ToolStripSeparator2, Me.tsb_Consultar_Filtro, Me.ToolStripSeparator4, Me.Tsd_FactElectronico, Me.tsb_Exportar_Filtro})
        Me.tsp_Principal_Filtro.Location = New System.Drawing.Point(0, 90)
        Me.tsp_Principal_Filtro.Name = "tsp_Principal_Filtro"
        Me.tsp_Principal_Filtro.Size = New System.Drawing.Size(1356, 31)
        Me.tsp_Principal_Filtro.TabIndex = 125
        Me.tsp_Principal_Filtro.Text = "ToolStrip1"
        '
        'Tsb_Env_Filtro
        '
        Me.Tsb_Env_Filtro.Image = CType(resources.GetObject("Tsb_Env_Filtro.Image"), System.Drawing.Image)
        Me.Tsb_Env_Filtro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tsb_Env_Filtro.Name = "Tsb_Env_Filtro"
        Me.Tsb_Env_Filtro.Size = New System.Drawing.Size(57, 28)
        Me.Tsb_Env_Filtro.Text = "Enviar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'tsb_Consultar_Filtro
        '
        Me.tsb_Consultar_Filtro.Image = CType(resources.GetObject("tsb_Consultar_Filtro.Image"), System.Drawing.Image)
        Me.tsb_Consultar_Filtro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Consultar_Filtro.Name = "tsb_Consultar_Filtro"
        Me.tsb_Consultar_Filtro.Size = New System.Drawing.Size(73, 28)
        Me.tsb_Consultar_Filtro.Text = "Consultar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'Tsd_FactElectronico
        '
        Me.Tsd_FactElectronico.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XMLToolStripMenuItem, Me.PDFToolStripMenuItem, Me.DescargaZIPToolStripMenuItem, Me.DescargarCDRToolStripMenuItem, Me.EnvioACorreoToolStripMenuItem})
        Me.Tsd_FactElectronico.Image = CType(resources.GetObject("Tsd_FactElectronico.Image"), System.Drawing.Image)
        Me.Tsd_FactElectronico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tsd_FactElectronico.Name = "Tsd_FactElectronico"
        Me.Tsd_FactElectronico.Size = New System.Drawing.Size(88, 28)
        Me.Tsd_FactElectronico.Text = "Electrónico"
        '
        'XMLToolStripMenuItem
        '
        Me.XMLToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.if_document_text_settings_103330
        Me.XMLToolStripMenuItem.Name = "XMLToolStripMenuItem"
        Me.XMLToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.XMLToolStripMenuItem.Text = "Generar XML"
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.if_pdf_272699
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PDFToolStripMenuItem.Text = "Imprimir Comprobante"
        '
        'DescargaZIPToolStripMenuItem
        '
        Me.DescargaZIPToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.if_application_xml_28904
        Me.DescargaZIPToolStripMenuItem.Name = "DescargaZIPToolStripMenuItem"
        Me.DescargaZIPToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DescargaZIPToolStripMenuItem.Text = "Descarga XML"
        '
        'DescargarCDRToolStripMenuItem
        '
        Me.DescargarCDRToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.if_30_1933170
        Me.DescargarCDRToolStripMenuItem.Name = "DescargarCDRToolStripMenuItem"
        Me.DescargarCDRToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DescargarCDRToolStripMenuItem.Text = "Descargar CDR"
        '
        'EnvioACorreoToolStripMenuItem
        '
        Me.EnvioACorreoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.if_mail_reply_all_118782
        Me.EnvioACorreoToolStripMenuItem.Name = "EnvioACorreoToolStripMenuItem"
        Me.EnvioACorreoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnvioACorreoToolStripMenuItem.Text = "Envio a Correo"
        Me.EnvioACorreoToolStripMenuItem.Visible = False
        '
        'tsb_Exportar_Filtro
        '
        Me.tsb_Exportar_Filtro.Image = CType(resources.GetObject("tsb_Exportar_Filtro.Image"), System.Drawing.Image)
        Me.tsb_Exportar_Filtro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Exportar_Filtro.Name = "tsb_Exportar_Filtro"
        Me.tsb_Exportar_Filtro.Size = New System.Drawing.Size(69, 28)
        Me.tsb_Exportar_Filtro.Text = "Exportar"
        '
        'ugbAgrupacion
        '
        Me.ugbAgrupacion.Controls.Add(Me.UltraGroupBox1)
        Me.ugbAgrupacion.Controls.Add(Me.Ugb_Filtros)
        Me.ugbAgrupacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.ugbAgrupacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.ugbAgrupacion.Location = New System.Drawing.Point(0, 0)
        Me.ugbAgrupacion.Name = "ugbAgrupacion"
        Me.ugbAgrupacion.Size = New System.Drawing.Size(1356, 90)
        Me.ugbAgrupacion.TabIndex = 43
        Me.ugbAgrupacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox1.Appearance = Appearance1
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.ucpGenerado)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.ucpAceptado)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.ucpProceso)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.ucpRechazado)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(465, 6)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(467, 76)
        Me.UltraGroupBox1.TabIndex = 393
        Me.UltraGroupBox1.Text = "Estados"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(64, 21)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(384, 15)
        Me.UltraLabel3.TabIndex = 392
        Me.UltraLabel3.Text = "No se envió a Contab. / No se informó a Sunat / No se comunicó como baja"
        '
        'ucpGenerado
        '
        Me.ucpGenerado.Color = System.Drawing.Color.White
        Me.ucpGenerado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ucpGenerado.Location = New System.Drawing.Point(16, 18)
        Me.ucpGenerado.Name = "ucpGenerado"
        Me.ucpGenerado.ReadOnly = True
        Me.ucpGenerado.Size = New System.Drawing.Size(44, 22)
        Me.ucpGenerado.TabIndex = 5
        Me.ucpGenerado.Text = "White"
        '
        'UltraLabel4
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance3
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(64, 49)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel4.TabIndex = 392
        Me.UltraLabel4.Text = "En Proceso"
        '
        'ucpAceptado
        '
        Me.ucpAceptado.Color = System.Drawing.Color.PaleGreen
        Me.ucpAceptado.Location = New System.Drawing.Point(149, 46)
        Me.ucpAceptado.Name = "ucpAceptado"
        Me.ucpAceptado.ReadOnly = True
        Me.ucpAceptado.Size = New System.Drawing.Size(44, 22)
        Me.ucpAceptado.TabIndex = 5
        Me.ucpAceptado.Text = "PaleGreen"
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(196, 49)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(51, 15)
        Me.UltraLabel1.TabIndex = 392
        Me.UltraLabel1.Text = "Aceptado"
        '
        'ucpProceso
        '
        Me.ucpProceso.Color = System.Drawing.Color.LightSteelBlue
        Me.ucpProceso.Location = New System.Drawing.Point(16, 46)
        Me.ucpProceso.Name = "ucpProceso"
        Me.ucpProceso.ReadOnly = True
        Me.ucpProceso.Size = New System.Drawing.Size(44, 22)
        Me.ucpProceso.TabIndex = 5
        Me.ucpProceso.Text = "LightSteelBlue"
        '
        'UltraLabel2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(337, 49)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(58, 15)
        Me.UltraLabel2.TabIndex = 393
        Me.UltraLabel2.Text = "Rechazado"
        '
        'ucpRechazado
        '
        Me.ucpRechazado.Color = System.Drawing.Color.LightCoral
        Me.ucpRechazado.Location = New System.Drawing.Point(287, 46)
        Me.ucpRechazado.Name = "ucpRechazado"
        Me.ucpRechazado.ReadOnly = True
        Me.ucpRechazado.Size = New System.Drawing.Size(44, 22)
        Me.ucpRechazado.TabIndex = 3
        Me.ucpRechazado.Text = "LightCoral"
        '
        'Ugb_Filtros
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.Ugb_Filtros.Appearance = Appearance6
        Me.Ugb_Filtros.Controls.Add(Me.cmbSerie)
        Me.Ugb_Filtros.Controls.Add(Me.Label1)
        Me.Ugb_Filtros.Controls.Add(Me.dtp_FechaHasta)
        Me.Ugb_Filtros.Controls.Add(Me.cmb_TipoDoc)
        Me.Ugb_Filtros.Controls.Add(Me.lblHasta)
        Me.Ugb_Filtros.Controls.Add(Me.chk_Validacion)
        Me.Ugb_Filtros.Controls.Add(Me.dtp_FechaDesde)
        Me.Ugb_Filtros.Controls.Add(Me.lblTipoDoc)
        Me.Ugb_Filtros.Controls.Add(Me.lblDesde)
        Me.Ugb_Filtros.Controls.Add(Me.rbResumen)
        Me.Ugb_Filtros.Location = New System.Drawing.Point(6, 6)
        Me.Ugb_Filtros.Name = "Ugb_Filtros"
        Me.Ugb_Filtros.Size = New System.Drawing.Size(453, 76)
        Me.Ugb_Filtros.TabIndex = 392
        Me.Ugb_Filtros.Text = "Filtros"
        Me.Ugb_Filtros.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'cmbSerie
        '
        Me.cmbSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cmbSerie.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSerie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSerie.Location = New System.Drawing.Point(359, 17)
        Me.cmbSerie.Name = "cmbSerie"
        Me.cmbSerie.Size = New System.Drawing.Size(70, 23)
        Me.cmbSerie.TabIndex = 397
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(318, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 396
        Me.Label1.Text = "Serie:"
        '
        'dtp_FechaHasta
        '
        Me.dtp_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaHasta.Location = New System.Drawing.Point(206, 42)
        Me.dtp_FechaHasta.Name = "dtp_FechaHasta"
        Me.dtp_FechaHasta.Size = New System.Drawing.Size(82, 21)
        Me.dtp_FechaHasta.TabIndex = 1
        '
        'cmb_TipoDoc
        '
        Me.cmb_TipoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cmb_TipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_TipoDoc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoDoc.Location = New System.Drawing.Point(65, 14)
        Me.cmb_TipoDoc.Name = "cmb_TipoDoc"
        Me.cmb_TipoDoc.Size = New System.Drawing.Size(223, 23)
        Me.cmb_TipoDoc.TabIndex = 395
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.BackColor = System.Drawing.Color.Transparent
        Me.lblHasta.Location = New System.Drawing.Point(160, 46)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(39, 13)
        Me.lblHasta.TabIndex = 148
        Me.lblHasta.Text = "Hasta:"
        '
        'chk_Validacion
        '
        Me.chk_Validacion.Checked = True
        Me.chk_Validacion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Validacion.Enabled = False
        Me.chk_Validacion.Location = New System.Drawing.Point(317, 43)
        Me.chk_Validacion.Name = "chk_Validacion"
        Me.chk_Validacion.Size = New System.Drawing.Size(112, 20)
        Me.chk_Validacion.TabIndex = 147
        Me.chk_Validacion.Text = "Validar correlativo"
        '
        'dtp_FechaDesde
        '
        Me.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDesde.Location = New System.Drawing.Point(65, 42)
        Me.dtp_FechaDesde.Name = "dtp_FechaDesde"
        Me.dtp_FechaDesde.Size = New System.Drawing.Size(77, 21)
        Me.dtp_FechaDesde.TabIndex = 0
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoDoc.Location = New System.Drawing.Point(6, 18)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(56, 13)
        Me.lblTipoDoc.TabIndex = 60
        Me.lblTipoDoc.Text = "Tipo Doc.:"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.BackColor = System.Drawing.Color.Transparent
        Me.lblDesde.Location = New System.Drawing.Point(9, 47)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(41, 13)
        Me.lblDesde.TabIndex = 47
        Me.lblDesde.Text = "Desde:"
        '
        'rbResumen
        '
        Me.rbResumen.AutoSize = True
        Me.rbResumen.BackColor = System.Drawing.Color.Transparent
        Me.rbResumen.Checked = True
        Me.rbResumen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbResumen.ForeColor = System.Drawing.Color.IndianRed
        Me.rbResumen.Location = New System.Drawing.Point(163, 44)
        Me.rbResumen.Name = "rbResumen"
        Me.rbResumen.Size = New System.Drawing.Size(98, 17)
        Me.rbResumen.TabIndex = 391
        Me.rbResumen.TabStop = True
        Me.rbResumen.Text = "Resumen Diario"
        Me.rbResumen.UseVisualStyleBackColor = False
        Me.rbResumen.Visible = False
        '
        'bwCpe
        '
        Me.bwCpe.WorkerSupportsCancellation = True
        '
        'frm_CpeFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 482)
        Me.Controls.Add(Me.espFacturacion)
        Me.Controls.Add(Me.upGrillas)
        Me.Controls.Add(Me.tsp_Principal_Filtro)
        Me.Controls.Add(Me.ugbAgrupacion)
        Me.Name = "frm_CpeFacturacion"
        Me.Text = "Comprobante de Pago Electrónico (CPE)"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ugPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugEnviar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.ugResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.ugEnviados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.ugEnviarBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.ugBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.ugTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.ugEnviarPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.upGrillas.ClientArea.ResumeLayout(False)
        Me.upGrillas.ResumeLayout(False)
        CType(Me.utcFichaDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcFichaDocumentos.ResumeLayout(False)
        Me.tsp_Principal_Filtro.ResumeLayout(False)
        Me.tsp_Principal_Filtro.PerformLayout()
        CType(Me.ugbAgrupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbAgrupacion.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.ucpGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucpAceptado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucpProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucpRechazado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ugb_Filtros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ugb_Filtros.ResumeLayout(False)
        Me.Ugb_Filtros.PerformLayout()
        CType(Me.cmbSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_Validacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugbAgrupacion As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Ugb_Filtros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chk_Validacion As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dtp_FechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucpGenerado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents ucpRechazado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents ucpProceso As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents ucpAceptado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents tsp_Principal_Filtro As System.Windows.Forms.ToolStrip
    Friend WithEvents Tsb_Env_Filtro As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb_Consultar_Filtro As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tsd_FactElectronico As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents XMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescargaZIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents utcFichaDocumentos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugPendientes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugEnviar As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugEnviados As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugEnviarBaja As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugBaja As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugTicket As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugEnviarPC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents espFacturacion As ISL.Win.Espere
    Friend WithEvents upGrillas As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents tsb_Exportar_Filtro As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmb_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents SdGuardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mDescargarXML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mImprimirPDF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnvioACorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rbResumen As System.Windows.Forms.RadioButton
    Friend WithEvents DescargarCDRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mDescargarCDR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbSerie As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bwCpe As System.ComponentModel.BackgroundWorker
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugResumen As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
