<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_KMMack
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_KmMack", -1)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoKm")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_KmMackDet", -1)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdKmMack")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Equipo")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmInicial")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmFinal")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTotal")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griKmMack = New ISL.Controles.Grilla(Me.components)
        Me.EKmMackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griKmMackDet = New ISL.Controles.Grilla(Me.components)
        Me.EKmMackDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtNumero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtSerie = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.numTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.numTC = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.numCostoxKm = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtEstado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCodigo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficKmMack = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Grilla1 = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.griKmMack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EKmMackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.griKmMackDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EKmMackDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCostoxKm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficKmMack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficKmMack.SuspendLayout()
        CType(Me.Grilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(968, 444)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.griKmMack)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 51)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(968, 393)
        Me.UltraGroupBox4.TabIndex = 1
        Me.UltraGroupBox4.Text = "Listado"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griKmMack
        '
        Me.griKmMack.DataSource = Me.EKmMackBindingSource
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn25.Header.VisiblePosition = 0
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 1
        UltraGridColumn27.Header.VisiblePosition = 2
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 3
        UltraGridColumn29.Header.VisiblePosition = 4
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn30.CellAppearance = Appearance1
        UltraGridColumn30.Format = "#,###,###,##0.0000"
        UltraGridColumn30.Header.VisiblePosition = 5
        UltraGridColumn30.MaskInput = "{double:9.4}"
        UltraGridColumn30.Width = 91
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance2
        UltraGridColumn31.Format = "#,###,###,##0.0000"
        UltraGridColumn31.Header.VisiblePosition = 6
        UltraGridColumn31.MaskInput = "{double:9.4}"
        UltraGridColumn31.Width = 84
        UltraGridColumn32.Header.VisiblePosition = 8
        UltraGridColumn32.Width = 41
        UltraGridColumn33.Header.VisiblePosition = 9
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn34.CellAppearance = Appearance3
        UltraGridColumn34.Format = "#,###,###,##0.0000"
        UltraGridColumn34.Header.VisiblePosition = 11
        UltraGridColumn34.MaskInput = "{double:9.4}"
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn35.Header.VisiblePosition = 7
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn36.Header.VisiblePosition = 10
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn37.Header.VisiblePosition = 12
        UltraGridColumn37.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37})
        Me.griKmMack.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griKmMack.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.BorderColor = System.Drawing.SystemColors.Window
        Me.griKmMack.DisplayLayout.GroupByBox.Appearance = Appearance4
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griKmMack.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
        Me.griKmMack.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griKmMack.DisplayLayout.GroupByBox.Hidden = True
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griKmMack.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
        Me.griKmMack.DisplayLayout.MaxColScrollRegions = 1
        Me.griKmMack.DisplayLayout.MaxRowScrollRegions = 1
        Me.griKmMack.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griKmMack.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griKmMack.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BorderColor = System.Drawing.Color.Silver
        Me.griKmMack.DisplayLayout.Override.CellAppearance = Appearance7
        Me.griKmMack.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griKmMack.DisplayLayout.Override.CellPadding = 0
        Me.griKmMack.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griKmMack.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griKmMack.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griKmMack.DisplayLayout.Override.GroupByRowAppearance = Appearance8
        Appearance9.TextHAlignAsString = "Left"
        Me.griKmMack.DisplayLayout.Override.HeaderAppearance = Appearance9
        Me.griKmMack.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance10.BorderColor = System.Drawing.Color.Silver
        Me.griKmMack.DisplayLayout.Override.RowAppearance = Appearance10
        Me.griKmMack.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griKmMack.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griKmMack.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griKmMack.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griKmMack.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griKmMack.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griKmMack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griKmMack.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griKmMack.Location = New System.Drawing.Point(3, 17)
        Me.griKmMack.Name = "griKmMack"
        Me.griKmMack.Size = New System.Drawing.Size(962, 373)
        Me.griKmMack.TabIndex = 1
        Me.griKmMack.TabStop = False
        Me.griKmMack.Text = "Grilla1"
        '
        'EKmMackBindingSource
        '
        Me.EKmMackBindingSource.DataSource = GetType(ISL.EntidadesWCF.e_KmMack)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta9)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta8)
        Me.UltraGroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.UltraGroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(968, 51)
        Me.UltraGroupBox3.TabIndex = 0
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta9
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance11
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(189, 19)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta9.TabIndex = 4
        Me.Etiqueta9.Text = "Hasta:"
        '
        'Etiqueta8
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance12
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(21, 19)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta8.TabIndex = 3
        Me.Etiqueta8.Text = "Desde:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(232, 17)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(106, 21)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(66, 17)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 21)
        Me.DateTimePicker1.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(968, 444)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.griKmMackDet)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 95)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(968, 349)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griKmMackDet
        '
        Me.griKmMackDet.DataSource = Me.EKmMackDetBindingSource
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn38.Header.VisiblePosition = 0
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn39.Header.VisiblePosition = 1
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.Header.VisiblePosition = 2
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn41.Header.VisiblePosition = 3
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance13
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn42.Format = "#,###,###,##0.0000"
        UltraGridColumn42.Header.VisiblePosition = 4
        UltraGridColumn42.MaskInput = "{double:9.4}"
        UltraGridColumn42.Width = 100
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn43.CellAppearance = Appearance14
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn43.Format = "#,###,###,##0.0000"
        UltraGridColumn43.Header.VisiblePosition = 5
        UltraGridColumn43.MaskInput = "{double:9.4}"
        UltraGridColumn43.Width = 100
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance15.FontData.BoldAsString = "True"
        Appearance15.ForeColor = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn44.CellAppearance = Appearance15
        UltraGridColumn44.Format = "#,###,###,##0.0000"
        UltraGridColumn44.Header.VisiblePosition = 7
        UltraGridColumn44.MaskInput = "{double:-9.4}"
        UltraGridColumn44.Width = 100
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance16
        UltraGridColumn45.Format = "#,###,###,##0.0000"
        UltraGridColumn45.Header.VisiblePosition = 9
        UltraGridColumn45.MaskInput = "{double:9.4}"
        UltraGridColumn45.Width = 100
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn46.Header.VisiblePosition = 6
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn47.Header.VisiblePosition = 8
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn48.Header.VisiblePosition = 10
        UltraGridColumn48.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48})
        Me.griKmMackDet.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griKmMackDet.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance17.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.BorderColor = System.Drawing.SystemColors.Window
        Me.griKmMackDet.DisplayLayout.GroupByBox.Appearance = Appearance17
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griKmMackDet.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance18
        Me.griKmMackDet.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griKmMackDet.DisplayLayout.GroupByBox.Hidden = True
        Appearance19.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance19.BackColor2 = System.Drawing.SystemColors.Control
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griKmMackDet.DisplayLayout.GroupByBox.PromptAppearance = Appearance19
        Me.griKmMackDet.DisplayLayout.MaxColScrollRegions = 1
        Me.griKmMackDet.DisplayLayout.MaxRowScrollRegions = 1
        Me.griKmMackDet.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griKmMackDet.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griKmMackDet.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griKmMackDet.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Me.griKmMackDet.DisplayLayout.Override.CellAppearance = Appearance20
        Me.griKmMackDet.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griKmMackDet.DisplayLayout.Override.CellPadding = 0
        Me.griKmMackDet.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griKmMackDet.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griKmMackDet.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.griKmMackDet.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.griKmMackDet.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.griKmMackDet.DisplayLayout.Override.RowAppearance = Appearance23
        Me.griKmMackDet.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griKmMackDet.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griKmMackDet.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griKmMackDet.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griKmMackDet.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griKmMackDet.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griKmMackDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griKmMackDet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griKmMackDet.Location = New System.Drawing.Point(3, 3)
        Me.griKmMackDet.Name = "griKmMackDet"
        Me.griKmMackDet.Size = New System.Drawing.Size(962, 343)
        Me.griKmMackDet.TabIndex = 0
        Me.griKmMackDet.TabStop = False
        Me.griKmMackDet.Text = "Grilla1"
        '
        'EKmMackDetBindingSource
        '
        Me.EKmMackDetBindingSource.DataSource = GetType(ISL.EntidadesWCF.e_KmMackDet)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txtNumero)
        Me.UltraGroupBox1.Controls.Add(Me.txtSerie)
        Me.UltraGroupBox1.Controls.Add(Me.numTotal)
        Me.UltraGroupBox1.Controls.Add(Me.numTC)
        Me.UltraGroupBox1.Controls.Add(Me.numCostoxKm)
        Me.UltraGroupBox1.Controls.Add(Me.dtpFecha)
        Me.UltraGroupBox1.Controls.Add(Me.txtEstado)
        Me.UltraGroupBox1.Controls.Add(Me.txtCodigo)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta7)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta6)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta5)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta4)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta3)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta2)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta1)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta20)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(968, 95)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtNumero
        '
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Location = New System.Drawing.Point(276, 65)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(123, 22)
        Me.txtNumero.TabIndex = 15
        '
        'txtSerie
        '
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Location = New System.Drawing.Point(93, 65)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(66, 22)
        Me.txtSerie.TabIndex = 13
        '
        'numTotal
        '
        Me.numTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTotal.Location = New System.Drawing.Point(449, 38)
        Me.numTotal.MaskInput = "{double:9.4}"
        Me.numTotal.Name = "numTotal"
        Me.numTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTotal.ReadOnly = True
        Me.numTotal.Size = New System.Drawing.Size(100, 22)
        Me.numTotal.TabIndex = 11
        '
        'numTC
        '
        Me.numTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTC.Location = New System.Drawing.Point(276, 38)
        Me.numTC.MaskInput = "{double:4.3}"
        Me.numTC.Name = "numTC"
        Me.numTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTC.Size = New System.Drawing.Size(60, 22)
        Me.numTC.TabIndex = 9
        '
        'numCostoxKm
        '
        Me.numCostoxKm.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCostoxKm.Location = New System.Drawing.Point(93, 38)
        Me.numCostoxKm.MaskInput = "{double:9.4}"
        Me.numCostoxKm.Name = "numCostoxKm"
        Me.numCostoxKm.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numCostoxKm.Size = New System.Drawing.Size(100, 22)
        Me.numCostoxKm.TabIndex = 7
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(449, 11)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(102, 21)
        Me.dtpFecha.TabIndex = 5
        '
        'txtEstado
        '
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Location = New System.Drawing.Point(276, 11)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(123, 22)
        Me.txtEstado.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Location = New System.Drawing.Point(93, 11)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'Etiqueta7
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance24
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(228, 15)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta7.TabIndex = 2
        Me.Etiqueta7.Text = "Estado:"
        '
        'Etiqueta6
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance25
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(54, 69)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta6.TabIndex = 12
        Me.Etiqueta6.Text = "Serie:"
        '
        'Etiqueta5
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance26
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(222, 69)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta5.TabIndex = 14
        Me.Etiqueta5.Text = "Numero:"
        '
        'Etiqueta4
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance27
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(199, 42)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(71, 15)
        Me.Etiqueta4.TabIndex = 8
        Me.Etiqueta4.Text = "Tipo Cambio:"
        '
        'Etiqueta3
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance28
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(410, 42)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta3.TabIndex = 10
        Me.Etiqueta3.Text = "Total:"
        '
        'Etiqueta2
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance29
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(405, 15)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta2.TabIndex = 4
        Me.Etiqueta2.Text = "Fecha:"
        '
        'Etiqueta1
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance30
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(23, 42)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(64, 15)
        Me.Etiqueta1.TabIndex = 6
        Me.Etiqueta1.Text = "Costo x KM:"
        '
        'Etiqueta20
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta20.Appearance = Appearance31
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta20.Location = New System.Drawing.Point(45, 15)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta20.TabIndex = 0
        Me.Etiqueta20.Text = "Codigo:"
        '
        'ficKmMack
        '
        Me.ficKmMack.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficKmMack.Controls.Add(Me.UltraTabPageControl1)
        Me.ficKmMack.Controls.Add(Me.UltraTabPageControl2)
        Me.ficKmMack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficKmMack.Location = New System.Drawing.Point(0, 0)
        Me.ficKmMack.Name = "ficKmMack"
        Me.ficKmMack.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficKmMack.Size = New System.Drawing.Size(970, 467)
        Me.ficKmMack.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficKmMack.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficKmMack.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(968, 444)
        '
        'Grilla1
        '
        Me.Grilla1.DataSource = Me.EKmMackBindingSource
        Me.Grilla1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance32.BorderColor = System.Drawing.SystemColors.Window
        Me.Grilla1.DisplayLayout.GroupByBox.Appearance = Appearance32
        Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grilla1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance33
        Me.Grilla1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.Grilla1.DisplayLayout.GroupByBox.Hidden = True
        Appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance34.BackColor2 = System.Drawing.SystemColors.Control
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grilla1.DisplayLayout.GroupByBox.PromptAppearance = Appearance34
        Me.Grilla1.DisplayLayout.MaxColScrollRegions = 1
        Me.Grilla1.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grilla1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.Grilla1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.Grilla1.DisplayLayout.Override.CellAppearance = Appearance35
        Me.Grilla1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grilla1.DisplayLayout.Override.CellPadding = 0
        Me.Grilla1.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grilla1.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.Grilla1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.Grilla1.DisplayLayout.Override.GroupByRowAppearance = Appearance36
        Appearance37.TextHAlignAsString = "Left"
        Me.Grilla1.DisplayLayout.Override.HeaderAppearance = Appearance37
        Me.Grilla1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Me.Grilla1.DisplayLayout.Override.RowAppearance = Appearance38
        Me.Grilla1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grilla1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.Grilla1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.Grilla1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grilla1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grilla1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.Grilla1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla1.Location = New System.Drawing.Point(0, 0)
        Me.Grilla1.Name = "Grilla1"
        Me.Grilla1.Size = New System.Drawing.Size(968, 444)
        Me.Grilla1.TabIndex = 1
        Me.Grilla1.TabStop = False
        Me.Grilla1.Text = "Grilla1"
        '
        'frm_KMMack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 467)
        Me.Controls.Add(Me.ficKmMack)
        Me.Name = "frm_KMMack"
        Me.Text = "Km Mack"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.griKmMack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EKmMackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.griKmMackDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EKmMackDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCostoxKm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficKmMack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficKmMack.ResumeLayout(False)
        CType(Me.Grilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficKmMack As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents griKmMackDet As ISL.Controles.Grilla
    Friend WithEvents filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtSerie As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents numTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents numTC As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents numCostoxKm As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEstado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCodigo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents EKmMackDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EKmMackBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Grilla1 As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents griKmMack As ISL.Controles.Grilla
End Class
