<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RetencionElectronica
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_RetencionImpresa", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocRet")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotContigencia")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieRet")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroRet")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRet")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RucPro")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocPro")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegRet")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TasaRet")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpTotRet")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpTotPag")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocRel")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDocRel")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocRel")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmidoc")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDoc")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MonedaDoc")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVoucher")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpPago")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MonedaPago")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpRetenido")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRetencion")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpTotalPagar")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MonExtranjera")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTC")
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
        Me.filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.uds = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griRetDet = New ISL.Controles.Grilla(Me.components)
        Me.ERetencionImpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.Lote = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.btnGenArchivo = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRazonSocialAdq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRucAdq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.uds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.griRetDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERetencionImpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.Lote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazonSocialAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem1.Text = "Quitar"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.griRetDet)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 103)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1052, 292)
        Me.UltraGroupBox2.TabIndex = 3
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griRetDet
        '
        Me.griRetDet.ContextMenuStrip = Me.ContextMenuStrip1
        Me.griRetDet.DataSource = Me.ERetencionImpresaBindingSource
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.Caption = "MotContigencia[1]"
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn30.Header.Caption = "SerieRet[2]"
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.Width = 56
        UltraGridColumn31.Header.Caption = "NumeroRet[3]"
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn32.Header.Caption = "FechaRet[4]"
        UltraGridColumn32.Header.VisiblePosition = 5
        UltraGridColumn33.Header.Caption = "RucPro[5]"
        UltraGridColumn33.Header.VisiblePosition = 6
        UltraGridColumn34.Header.Caption = "TipoDocPro[6]"
        UltraGridColumn34.Header.VisiblePosition = 7
        UltraGridColumn35.Header.Caption = "RazonSocial[7]"
        UltraGridColumn35.Header.VisiblePosition = 8
        UltraGridColumn36.Header.Caption = "RegRet[8]"
        UltraGridColumn36.Header.VisiblePosition = 9
        UltraGridColumn36.MaskInput = ""
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn37.CellAppearance = Appearance1
        UltraGridColumn37.Header.Caption = "TasaRet[9]"
        UltraGridColumn37.Header.VisiblePosition = 10
        UltraGridColumn37.MaskInput = "{double:9.2}"
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn38.CellAppearance = Appearance2
        UltraGridColumn38.Header.Caption = "ImpTotRet[10]"
        UltraGridColumn38.Header.VisiblePosition = 11
        UltraGridColumn38.MaskInput = "{double:9.2}"
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn39.CellAppearance = Appearance3
        UltraGridColumn39.Header.Caption = "ImpTotPag[11]"
        UltraGridColumn39.Header.VisiblePosition = 12
        UltraGridColumn39.MaskInput = "{double:9.2}"
        UltraGridColumn40.Header.Caption = "TipoDocRel[12]"
        UltraGridColumn40.Header.VisiblePosition = 13
        UltraGridColumn41.Header.Caption = "SerieDocRel[13]"
        UltraGridColumn41.Header.VisiblePosition = 14
        UltraGridColumn42.Header.Caption = "NumeroDocRel[14]"
        UltraGridColumn42.Header.VisiblePosition = 15
        UltraGridColumn43.Header.Caption = "FechaEmidoc[15]"
        UltraGridColumn43.Header.VisiblePosition = 16
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn44.CellAppearance = Appearance4
        UltraGridColumn44.Header.Caption = "TotalDoc[16]"
        UltraGridColumn44.Header.VisiblePosition = 17
        UltraGridColumn44.MaskInput = "{double:9.2}"
        UltraGridColumn45.Header.Caption = "MonedaDoc[17]"
        UltraGridColumn45.Header.VisiblePosition = 18
        UltraGridColumn46.Header.Caption = "FechaPago[18]"
        UltraGridColumn46.Header.VisiblePosition = 25
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.Caption = "NroVoucher[19]"
        UltraGridColumn47.Header.VisiblePosition = 19
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn48.CellAppearance = Appearance5
        UltraGridColumn48.Header.Caption = "ImpPago[20]"
        UltraGridColumn48.Header.VisiblePosition = 20
        UltraGridColumn48.MaskInput = "{double:9.2}"
        UltraGridColumn49.Header.Caption = "MonedaPago[21]"
        UltraGridColumn49.Header.VisiblePosition = 21
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn50.CellAppearance = Appearance6
        UltraGridColumn50.Header.Caption = "ImpRetenido[22]"
        UltraGridColumn50.Header.VisiblePosition = 22
        UltraGridColumn50.MaskInput = "{double:9.2}"
        UltraGridColumn51.Header.Caption = "FechaRetencion[23]"
        UltraGridColumn51.Header.VisiblePosition = 23
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn52.CellAppearance = Appearance7
        UltraGridColumn52.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn52.Header.Caption = "ImpTotalPagar[24]"
        UltraGridColumn52.Header.VisiblePosition = 24
        UltraGridColumn52.MaskInput = "{double:9.2}"
        UltraGridColumn53.Header.Caption = "MonExtranjera[25]"
        UltraGridColumn53.Header.VisiblePosition = 26
        UltraGridColumn54.Header.Caption = "TipoCambio[26]"
        UltraGridColumn54.Header.VisiblePosition = 27
        UltraGridColumn55.Header.Caption = "FechaTC[27]"
        UltraGridColumn55.Header.VisiblePosition = 28
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55})
        Me.griRetDet.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griRetDet.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance8.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.BorderColor = System.Drawing.SystemColors.Window
        Me.griRetDet.DisplayLayout.GroupByBox.Appearance = Appearance8
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griRetDet.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance9
        Me.griRetDet.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griRetDet.DisplayLayout.GroupByBox.Hidden = True
        Appearance10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance10.BackColor2 = System.Drawing.SystemColors.Control
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griRetDet.DisplayLayout.GroupByBox.PromptAppearance = Appearance10
        Me.griRetDet.DisplayLayout.MaxColScrollRegions = 1
        Me.griRetDet.DisplayLayout.MaxRowScrollRegions = 1
        Me.griRetDet.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griRetDet.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griRetDet.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griRetDet.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.griRetDet.DisplayLayout.Override.CellAppearance = Appearance11
        Me.griRetDet.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griRetDet.DisplayLayout.Override.CellPadding = 0
        Me.griRetDet.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griRetDet.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griRetDet.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griRetDet.DisplayLayout.Override.GroupByRowAppearance = Appearance12
        Appearance13.TextHAlignAsString = "Left"
        Me.griRetDet.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.griRetDet.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance14.BorderColor = System.Drawing.Color.Silver
        Me.griRetDet.DisplayLayout.Override.RowAppearance = Appearance14
        Me.griRetDet.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griRetDet.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griRetDet.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griRetDet.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griRetDet.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griRetDet.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griRetDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griRetDet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griRetDet.Location = New System.Drawing.Point(3, 3)
        Me.griRetDet.Name = "griRetDet"
        Me.griRetDet.Size = New System.Drawing.Size(1046, 286)
        Me.griRetDet.TabIndex = 3
        Me.griRetDet.TabStop = False
        Me.griRetDet.Text = "Grilla1"
        '
        'ERetencionImpresaBindingSource
        '
        Me.ERetencionImpresaBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_RetencionImpresa)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.Lote)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.UltraGroupBox1.Controls.Add(Me.btnGuardar)
        Me.UltraGroupBox1.Controls.Add(Me.btnGenArchivo)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.txtRazonSocialAdq)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.txtRucAdq)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1052, 103)
        Me.UltraGroupBox1.TabIndex = 2
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel5
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance15
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(214, 45)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(45, 15)
        Me.UltraLabel5.TabIndex = 30
        Me.UltraLabel5.Text = "Archivo:"
        '
        'Lote
        '
        Me.Lote.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.Lote.Location = New System.Drawing.Point(265, 41)
        Me.Lote.MaxLength = 2
        Me.Lote.Name = "Lote"
        Me.Lote.Size = New System.Drawing.Size(43, 22)
        Me.Lote.TabIndex = 29
        '
        'UltraLabel4
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance16
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(38, 45)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel4.TabIndex = 28
        Me.UltraLabel4.Text = "Fecha:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(82, 42)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker2.TabIndex = 26
        '
        'btnGuardar
        '
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Appearance17.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardar.Appearance = Appearance17
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(188, 71)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 26)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        '
        'btnGenArchivo
        '
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.btnGenArchivo.Appearance = Appearance18
        Me.btnGenArchivo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenArchivo.Location = New System.Drawing.Point(82, 71)
        Me.btnGenArchivo.Name = "btnGenArchivo"
        Me.btnGenArchivo.Size = New System.Drawing.Size(100, 26)
        Me.btnGenArchivo.TabIndex = 23
        Me.btnGenArchivo.Text = "Gen. Arch."
        '
        'UltraLabel2
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance19
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(188, 17)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(71, 15)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "Razon Social:"
        '
        'txtRazonSocialAdq
        '
        Me.txtRazonSocialAdq.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRazonSocialAdq.Location = New System.Drawing.Point(265, 13)
        Me.txtRazonSocialAdq.Name = "txtRazonSocialAdq"
        Me.txtRazonSocialAdq.ReadOnly = True
        Me.txtRazonSocialAdq.Size = New System.Drawing.Size(278, 22)
        Me.txtRazonSocialAdq.TabIndex = 2
        '
        'UltraLabel1
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance20
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(47, 17)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(29, 15)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "RUC:"
        '
        'txtRucAdq
        '
        Me.txtRucAdq.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRucAdq.Location = New System.Drawing.Point(82, 13)
        Me.txtRucAdq.Name = "txtRucAdq"
        Me.txtRucAdq.ReadOnly = True
        Me.txtRucAdq.Size = New System.Drawing.Size(100, 22)
        Me.txtRucAdq.TabIndex = 0
        '
        'frm_RetencionElectronica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 395)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "frm_RetencionElectronica"
        Me.Text = "RetencionElectronica"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.uds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.griRetDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERetencionImpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.Lote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazonSocialAdq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucAdq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents uds As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ERetencionImpresaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGenArchivo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRazonSocialAdq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRucAdq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griRetDet As ISL.Controles.Grilla
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Lote As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
