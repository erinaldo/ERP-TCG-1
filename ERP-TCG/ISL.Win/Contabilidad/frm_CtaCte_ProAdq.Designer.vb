<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CtaCte_ProAdq
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
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCliPro")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEmpresa")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Empresa")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCliPro")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoEmpresa")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griCtaCte_ProAdq = New ISL.Controles.Grilla(Me.components)
        Me.uds_CtaCte = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.rb_Proveedor = New System.Windows.Forms.RadioButton()
        Me.rb_Adquiriente = New System.Windows.Forms.RadioButton()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCuenta = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkRuc = New ISL.Controles.Chequear(Me.components)
        Me.cboProAdq = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ficCtaCte = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.griCtaCte_ProAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_CtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCtaCte.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(703, 411)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.griCtaCte_ProAdq)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(703, 411)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griCtaCte_ProAdq
        '
        Me.griCtaCte_ProAdq.DataSource = Me.uds_CtaCte
        UltraGridColumn96.Header.VisiblePosition = 0
        UltraGridColumn96.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 339
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 121
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 104
        UltraGridColumn125.Header.VisiblePosition = 7
        UltraGridColumn125.Hidden = True
        UltraGridColumn124.Header.VisiblePosition = 6
        UltraGridColumn126.Header.VisiblePosition = 8
        UltraGridColumn126.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn96, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn125, UltraGridColumn124, UltraGridColumn126})
        Me.griCtaCte_ProAdq.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griCtaCte_ProAdq.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance1.BorderColor = System.Drawing.SystemColors.Window
        Me.griCtaCte_ProAdq.DisplayLayout.GroupByBox.Appearance = Appearance1
        Appearance2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griCtaCte_ProAdq.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance2
        Me.griCtaCte_ProAdq.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griCtaCte_ProAdq.DisplayLayout.GroupByBox.Hidden = True
        Appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance3.BackColor2 = System.Drawing.SystemColors.Control
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griCtaCte_ProAdq.DisplayLayout.GroupByBox.PromptAppearance = Appearance3
        Me.griCtaCte_ProAdq.DisplayLayout.MaxColScrollRegions = 1
        Me.griCtaCte_ProAdq.DisplayLayout.MaxRowScrollRegions = 1
        Me.griCtaCte_ProAdq.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCtaCte_ProAdq.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griCtaCte_ProAdq.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCtaCte_ProAdq.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance4.BorderColor = System.Drawing.Color.Silver
        Me.griCtaCte_ProAdq.DisplayLayout.Override.CellAppearance = Appearance4
        Me.griCtaCte_ProAdq.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griCtaCte_ProAdq.DisplayLayout.Override.CellPadding = 0
        Me.griCtaCte_ProAdq.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCtaCte_ProAdq.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griCtaCte_ProAdq.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griCtaCte_ProAdq.DisplayLayout.Override.GroupByRowAppearance = Appearance5
        Appearance6.TextHAlignAsString = "Left"
        Me.griCtaCte_ProAdq.DisplayLayout.Override.HeaderAppearance = Appearance6
        Me.griCtaCte_ProAdq.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance7.BorderColor = System.Drawing.Color.Silver
        Me.griCtaCte_ProAdq.DisplayLayout.Override.RowAppearance = Appearance7
        Me.griCtaCte_ProAdq.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCtaCte_ProAdq.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griCtaCte_ProAdq.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griCtaCte_ProAdq.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griCtaCte_ProAdq.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCtaCte_ProAdq.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griCtaCte_ProAdq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCtaCte_ProAdq.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCtaCte_ProAdq.Location = New System.Drawing.Point(3, 3)
        Me.griCtaCte_ProAdq.Name = "griCtaCte_ProAdq"
        Me.griCtaCte_ProAdq.Size = New System.Drawing.Size(697, 405)
        Me.griCtaCte_ProAdq.TabIndex = 0
        Me.griCtaCte_ProAdq.TabStop = False
        Me.griCtaCte_ProAdq.Text = "Grilla1"
        '
        'uds_CtaCte
        '
        UltraDataColumn8.DataType = GetType(Date)
        Me.uds_CtaCte.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(703, 411)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.rb_Proveedor)
        Me.UltraGroupBox3.Controls.Add(Me.rb_Adquiriente)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox3.Controls.Add(Me.txtCuenta)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox3.Controls.Add(Me.chkRuc)
        Me.UltraGroupBox3.Controls.Add(Me.cboProAdq)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(703, 118)
        Me.UltraGroupBox3.TabIndex = 0
        Me.UltraGroupBox3.Text = "Datos"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rb_Proveedor
        '
        Me.rb_Proveedor.AutoSize = True
        Me.rb_Proveedor.BackColor = System.Drawing.Color.Transparent
        Me.rb_Proveedor.ForeColor = System.Drawing.Color.Navy
        Me.rb_Proveedor.Location = New System.Drawing.Point(80, 26)
        Me.rb_Proveedor.Name = "rb_Proveedor"
        Me.rb_Proveedor.Size = New System.Drawing.Size(75, 17)
        Me.rb_Proveedor.TabIndex = 1
        Me.rb_Proveedor.TabStop = True
        Me.rb_Proveedor.Text = "Proveedor"
        Me.rb_Proveedor.UseVisualStyleBackColor = False
        '
        'rb_Adquiriente
        '
        Me.rb_Adquiriente.AutoSize = True
        Me.rb_Adquiriente.BackColor = System.Drawing.Color.Transparent
        Me.rb_Adquiriente.ForeColor = System.Drawing.Color.Navy
        Me.rb_Adquiriente.Location = New System.Drawing.Point(175, 26)
        Me.rb_Adquiriente.Name = "rb_Adquiriente"
        Me.rb_Adquiriente.Size = New System.Drawing.Size(80, 17)
        Me.rb_Adquiriente.TabIndex = 2
        Me.rb_Adquiriente.TabStop = True
        Me.rb_Adquiriente.Text = "Adquiriente"
        Me.rb_Adquiriente.UseVisualStyleBackColor = False
        '
        'UltraLabel2
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance8
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(44, 28)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(30, 15)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Tipo:"
        '
        'txtCuenta
        '
        Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(80, 78)
        Me.txtCuenta.MaxLength = 11
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(102, 21)
        Me.txtCuenta.TabIndex = 7
        '
        'UltraLabel1
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(23, 53)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(51, 15)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Empresa:"
        '
        'UltraLabel8
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance10
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(31, 82)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(43, 15)
        Me.UltraLabel8.TabIndex = 6
        Me.UltraLabel8.Text = "Cuenta:"
        '
        'chkRuc
        '
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.chkRuc.Appearance = Appearance11
        Me.chkRuc.BackColor = System.Drawing.Color.Transparent
        Me.chkRuc.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRuc.ForeColor = System.Drawing.Color.Black
        Me.chkRuc.Location = New System.Drawing.Point(417, 50)
        Me.chkRuc.Name = "chkRuc"
        Me.chkRuc.Size = New System.Drawing.Size(44, 20)
        Me.chkRuc.TabIndex = 5
        Me.chkRuc.Text = "Ruc"
        '
        'cboProAdq
        '
        Me.cboProAdq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProAdq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProAdq.CheckedListSettings.ListSeparator = ","
        Me.cboProAdq.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboProAdq.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboProAdq.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProAdq.DropDownWidth = 400
        Me.cboProAdq.Location = New System.Drawing.Point(80, 49)
        Me.cboProAdq.Name = "cboProAdq"
        Me.cboProAdq.Size = New System.Drawing.Size(331, 23)
        Me.cboProAdq.TabIndex = 4
        '
        'ficCtaCte
        '
        Me.ficCtaCte.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficCtaCte.Controls.Add(Me.UltraTabPageControl1)
        Me.ficCtaCte.Controls.Add(Me.UltraTabPageControl2)
        Me.ficCtaCte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCtaCte.Location = New System.Drawing.Point(0, 0)
        Me.ficCtaCte.Name = "ficCtaCte"
        Me.ficCtaCte.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficCtaCte.Size = New System.Drawing.Size(705, 434)
        Me.ficCtaCte.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficCtaCte.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficCtaCte.TabStop = False
        Me.ficCtaCte.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(703, 411)
        '
        'frm_CtaCte_ProAdq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 434)
        Me.Controls.Add(Me.ficCtaCte)
        Me.Name = "frm_CtaCte_ProAdq"
        Me.Text = "Cuenta Corriente"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.griCtaCte_ProAdq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_CtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProAdq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCtaCte.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficCtaCte As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griCtaCte_ProAdq As ISL.Controles.Grilla
    Friend WithEvents filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents uds_CtaCte As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents chkRuc As ISL.Controles.Chequear
    Private WithEvents cboProAdq As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCuenta As ISL.Controles.Texto
    Friend WithEvents rb_Proveedor As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Adquiriente As System.Windows.Forms.RadioButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
End Class
