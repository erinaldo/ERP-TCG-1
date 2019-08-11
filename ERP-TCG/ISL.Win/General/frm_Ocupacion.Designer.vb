<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ocupacion
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrGillaOcupacion = New ISL.Controles.Agrupacion(Me.components)
        Me.griOcupacion = New ISL.Controles.Grilla(Me.components)
        Me.mcOcupacion = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiExportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOcupacion = New ISL.Controles.Agrupacion(Me.components)
        Me.cboOcuSunat = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAreaBase = New ISL.Controles.Combo(Me.components)
        Me.etiAreaBase = New ISL.Controles.Etiqueta(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ficOcupacion = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrGillaOcupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrGillaOcupacion.SuspendLayout()
        CType(Me.griOcupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcOcupacion.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrOcupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOcupacion.SuspendLayout()
        CType(Me.cboOcuSunat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAreaBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficOcupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOcupacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.AutoScroll = True
        Me.UltraTabPageControl1.Controls.Add(Me.agrGillaOcupacion)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(950, 435)
        '
        'agrGillaOcupacion
        '
        Me.agrGillaOcupacion.Controls.Add(Me.griOcupacion)
        Me.agrGillaOcupacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrGillaOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrGillaOcupacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrGillaOcupacion.Location = New System.Drawing.Point(0, 0)
        Me.agrGillaOcupacion.Name = "agrGillaOcupacion"
        Me.agrGillaOcupacion.Size = New System.Drawing.Size(950, 435)
        Me.agrGillaOcupacion.TabIndex = 0
        Me.agrGillaOcupacion.Text = "Lista de Ocupacion"
        Me.agrGillaOcupacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griOcupacion
        '
        Me.griOcupacion.ContextMenuStrip = Me.mcOcupacion
        Me.griOcupacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOcupacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOcupacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOcupacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griOcupacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOcupacion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOcupacion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griOcupacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOcupacion.Location = New System.Drawing.Point(2, 18)
        Me.griOcupacion.Name = "griOcupacion"
        Me.griOcupacion.Size = New System.Drawing.Size(946, 415)
        Me.griOcupacion.TabIndex = 0
        Me.griOcupacion.Text = "Listado de Ocupaciones"
        '
        'mcOcupacion
        '
        Me.mcOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcOcupacion.ForeColor = System.Drawing.Color.Black
        Me.mcOcupacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiEditar, Me.tsmiEliminar, Me.ToolStripSeparator1, Me.tsmiExportar})
        Me.mcOcupacion.Name = "MenuContextual1"
        Me.mcOcupacion.Size = New System.Drawing.Size(114, 98)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(113, 22)
        Me.tsmiNuevo.Text = "Nuevo"
        Me.tsmiNuevo.ToolTipText = "Insertar una nueva ocupación"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiEditar.Text = "Editar"
        Me.tsmiEditar.ToolTipText = "Actualizar o modificar la ocupación seleccionada"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        Me.tsmiEliminar.ToolTipText = "Eliminar la ocupación seleccionada"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(110, 6)
        '
        'tsmiExportar
        '
        Me.tsmiExportar.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.tsmiExportar.Name = "tsmiExportar"
        Me.tsmiExportar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiExportar.Text = "Exportar"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.AutoScroll = True
        Me.UltraTabPageControl2.Controls.Add(Me.agrOcupacion)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(950, 435)
        '
        'agrOcupacion
        '
        Me.agrOcupacion.Controls.Add(Me.cboOcuSunat)
        Me.agrOcupacion.Controls.Add(Me.Etiqueta1)
        Me.agrOcupacion.Controls.Add(Me.cboAreaBase)
        Me.agrOcupacion.Controls.Add(Me.etiAreaBase)
        Me.agrOcupacion.Controls.Add(Me.verActivo)
        Me.agrOcupacion.Controls.Add(Me.txtNombre)
        Me.agrOcupacion.Controls.Add(Me.txtCodigo)
        Me.agrOcupacion.Controls.Add(Me.etiNombre)
        Me.agrOcupacion.Controls.Add(Me.etiCodigo)
        Me.agrOcupacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOcupacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOcupacion.Location = New System.Drawing.Point(0, 0)
        Me.agrOcupacion.Name = "agrOcupacion"
        Me.agrOcupacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.agrOcupacion.Size = New System.Drawing.Size(950, 190)
        Me.agrOcupacion.TabIndex = 0
        Me.agrOcupacion.Text = "Datos"
        Me.agrOcupacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboOcuSunat
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboOcuSunat.Appearance = Appearance1
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboOcuSunat.DisplayLayout.Appearance = Appearance2
        Me.cboOcuSunat.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboOcuSunat.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.cboOcuSunat.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboOcuSunat.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.cboOcuSunat.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboOcuSunat.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.cboOcuSunat.DisplayLayout.MaxColScrollRegions = 1
        Me.cboOcuSunat.DisplayLayout.MaxRowScrollRegions = 1
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboOcuSunat.DisplayLayout.Override.ActiveCellAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboOcuSunat.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.cboOcuSunat.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboOcuSunat.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.cboOcuSunat.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboOcuSunat.DisplayLayout.Override.CellAppearance = Appearance9
        Me.cboOcuSunat.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboOcuSunat.DisplayLayout.Override.CellPadding = 0
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.cboOcuSunat.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance11.TextHAlignAsString = "Left"
        Me.cboOcuSunat.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.cboOcuSunat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboOcuSunat.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.cboOcuSunat.DisplayLayout.Override.RowAppearance = Appearance12
        Me.cboOcuSunat.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboOcuSunat.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.cboOcuSunat.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboOcuSunat.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboOcuSunat.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboOcuSunat.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOcuSunat.Location = New System.Drawing.Point(122, 95)
        Me.cboOcuSunat.Name = "cboOcuSunat"
        Me.cboOcuSunat.Size = New System.Drawing.Size(415, 22)
        Me.cboOcuSunat.TabIndex = 10
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(25, 99)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(91, 14)
        Me.Etiqueta1.TabIndex = 9
        Me.Etiqueta1.Text = "Ocupacion Sunat:"
        '
        'cboAreaBase
        '
        Appearance14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAreaBase.Appearance = Appearance14
        Me.cboAreaBase.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAreaBase.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAreaBase.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAreaBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAreaBase.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAreaBase.Location = New System.Drawing.Point(122, 123)
        Me.cboAreaBase.Name = "cboAreaBase"
        Me.cboAreaBase.Size = New System.Drawing.Size(298, 21)
        Me.cboAreaBase.TabIndex = 4
        Me.cboAreaBase.ValueMember = "Id"
        '
        'etiAreaBase
        '
        Me.etiAreaBase.AutoSize = True
        Me.etiAreaBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAreaBase.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiAreaBase.Location = New System.Drawing.Point(58, 126)
        Me.etiAreaBase.Name = "etiAreaBase"
        Me.etiAreaBase.Size = New System.Drawing.Size(58, 14)
        Me.etiAreaBase.TabIndex = 7
        Me.etiAreaBase.Text = "Area Base:"
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(122, 150)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 5
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtNombre
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance15
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(122, 68)
        Me.txtNombre.MaxLength = 250
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(415, 21)
        Me.txtNombre.TabIndex = 3
        '
        'txtCodigo
        '
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance16
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(122, 41)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 2
        '
        'etiNombre
        '
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(70, 72)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(46, 14)
        Me.etiNombre.TabIndex = 1
        Me.etiNombre.Text = "Nombre:"
        '
        'etiCodigo
        '
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigo.Location = New System.Drawing.Point(74, 45)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(42, 14)
        Me.etiCodigo.TabIndex = 0
        Me.etiCodigo.Text = "Codigo:"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'ficOcupacion
        '
        Me.ficOcupacion.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOcupacion.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOcupacion.Controls.Add(Me.UltraTabPageControl2)
        Me.ficOcupacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficOcupacion.Location = New System.Drawing.Point(0, 0)
        Me.ficOcupacion.Name = "ficOcupacion"
        Me.ficOcupacion.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOcupacion.Size = New System.Drawing.Size(952, 458)
        Me.ficOcupacion.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Lista"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Mantenimiento"
        Me.ficOcupacion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.ficOcupacion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(950, 435)
        '
        'frm_Ocupacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 458)
        Me.Controls.Add(Me.ficOcupacion)
        Me.Name = "frm_Ocupacion"
        Me.Text = "Ocupación"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrGillaOcupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrGillaOcupacion.ResumeLayout(False)
        CType(Me.griOcupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcOcupacion.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrOcupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOcupacion.ResumeLayout(False)
        Me.agrOcupacion.PerformLayout()
        CType(Me.cboOcuSunat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAreaBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficOcupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOcupacion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficOcupacion As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrGillaOcupacion As ISL.Controles.Agrupacion
    Friend WithEvents griOcupacion As ISL.Controles.Grilla
    Friend WithEvents agrOcupacion As ISL.Controles.Agrupacion
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents etiAreaBase As ISL.Controles.Etiqueta
    Friend WithEvents cboAreaBase As ISL.Controles.Combo
    Friend WithEvents mcOcupacion As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents cboOcuSunat As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiExportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
End Class
