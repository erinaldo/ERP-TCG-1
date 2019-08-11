<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SituacionAdministrativa
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaSituacionAdministrativas = New ISL.Controles.Agrupacion(Me.components)
        Me.griSituacionAdministrativa = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrSituacionAdministrativa = New ISL.Controles.Agrupacion(Me.components)
        Me.txtCodigoPlame = New ISL.Controles.Texto(Me.components)
        Me.lblcodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.verAcumulaVacaciones = New ISL.Controles.Chequear(Me.components)
        Me.verRemunerado = New ISL.Controles.Chequear(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.etiAbreviatura = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.ficSituacionAdministrativa = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.cboTipo = New ISL.Controles.ComboMaestros(Me.components)
        Me.etiSituacionAdministrativa = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrListaSituacionAdministrativas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaSituacionAdministrativas.SuspendLayout()
        CType(Me.griSituacionAdministrativa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrSituacionAdministrativa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrSituacionAdministrativa.SuspendLayout()
        CType(Me.txtCodigoPlame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verAcumulaVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verRemunerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficSituacionAdministrativa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficSituacionAdministrativa.SuspendLayout()
        CType(Me.cboTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrListaSituacionAdministrativas)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(580, 384)
        '
        'agrListaSituacionAdministrativas
        '
        Me.agrListaSituacionAdministrativas.Controls.Add(Me.griSituacionAdministrativa)
        Me.agrListaSituacionAdministrativas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaSituacionAdministrativas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListaSituacionAdministrativas.ForeColor = System.Drawing.Color.Black
        Me.agrListaSituacionAdministrativas.Location = New System.Drawing.Point(0, 0)
        Me.agrListaSituacionAdministrativas.Name = "agrListaSituacionAdministrativas"
        Me.agrListaSituacionAdministrativas.Size = New System.Drawing.Size(580, 384)
        Me.agrListaSituacionAdministrativas.TabIndex = 1
        Me.agrListaSituacionAdministrativas.Text = "Lista de Situaciones Administrativas"
        Me.agrListaSituacionAdministrativas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griSituacionAdministrativa
        '
        Me.griSituacionAdministrativa.ContextMenuStrip = Me.MenuContextual1
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 371
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 147
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griSituacionAdministrativa.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griSituacionAdministrativa.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griSituacionAdministrativa.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griSituacionAdministrativa.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griSituacionAdministrativa.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griSituacionAdministrativa.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griSituacionAdministrativa.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griSituacionAdministrativa.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griSituacionAdministrativa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griSituacionAdministrativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griSituacionAdministrativa.Location = New System.Drawing.Point(2, 18)
        Me.griSituacionAdministrativa.Name = "griSituacionAdministrativa"
        Me.griSituacionAdministrativa.Size = New System.Drawing.Size(576, 364)
        Me.griSituacionAdministrativa.TabIndex = 1
        Me.griSituacionAdministrativa.Text = "Información de Situaciones Administrativas"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Situación Administrativa"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar la Situación Administrativa seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la Situación Administrativa seleccionada"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrSituacionAdministrativa)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(580, 384)
        '
        'agrSituacionAdministrativa
        '
        Me.agrSituacionAdministrativa.Controls.Add(Me.cboTipo)
        Me.agrSituacionAdministrativa.Controls.Add(Me.etiSituacionAdministrativa)
        Me.agrSituacionAdministrativa.Controls.Add(Me.txtCodigoPlame)
        Me.agrSituacionAdministrativa.Controls.Add(Me.lblcodigo)
        Me.agrSituacionAdministrativa.Controls.Add(Me.verAcumulaVacaciones)
        Me.agrSituacionAdministrativa.Controls.Add(Me.verRemunerado)
        Me.agrSituacionAdministrativa.Controls.Add(Me.verActivo)
        Me.agrSituacionAdministrativa.Controls.Add(Me.txtAbreviatura)
        Me.agrSituacionAdministrativa.Controls.Add(Me.txtNombre)
        Me.agrSituacionAdministrativa.Controls.Add(Me.txtCodigo)
        Me.agrSituacionAdministrativa.Controls.Add(Me.etiAbreviatura)
        Me.agrSituacionAdministrativa.Controls.Add(Me.etiNombre)
        Me.agrSituacionAdministrativa.Controls.Add(Me.etiCodigo)
        Me.agrSituacionAdministrativa.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrSituacionAdministrativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrSituacionAdministrativa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrSituacionAdministrativa.Location = New System.Drawing.Point(0, 0)
        Me.agrSituacionAdministrativa.Name = "agrSituacionAdministrativa"
        Me.agrSituacionAdministrativa.Size = New System.Drawing.Size(580, 234)
        Me.agrSituacionAdministrativa.TabIndex = 1
        Me.agrSituacionAdministrativa.Text = "Datos:"
        Me.agrSituacionAdministrativa.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtCodigoPlame
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoPlame.Appearance = Appearance2
        Me.txtCodigoPlame.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoPlame.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoPlame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoPlame.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoPlame.Location = New System.Drawing.Point(107, 118)
        Me.txtCodigoPlame.Name = "txtCodigoPlame"
        Me.txtCodigoPlame.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigoPlame.TabIndex = 10
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblcodigo.Location = New System.Drawing.Point(28, 122)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(73, 14)
        Me.lblcodigo.TabIndex = 9
        Me.lblcodigo.Text = "CodigoPlame:"
        '
        'verAcumulaVacaciones
        '
        Me.verAcumulaVacaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verAcumulaVacaciones.ForeColor = System.Drawing.Color.Black
        Me.verAcumulaVacaciones.Location = New System.Drawing.Point(107, 172)
        Me.verAcumulaVacaciones.Name = "verAcumulaVacaciones"
        Me.verAcumulaVacaciones.Size = New System.Drawing.Size(211, 20)
        Me.verAcumulaVacaciones.TabIndex = 8
        Me.verAcumulaVacaciones.Text = "Descontar de vacaciones"
        '
        'verRemunerado
        '
        Me.verRemunerado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verRemunerado.ForeColor = System.Drawing.Color.Black
        Me.verRemunerado.Location = New System.Drawing.Point(107, 145)
        Me.verRemunerado.Name = "verRemunerado"
        Me.verRemunerado.Size = New System.Drawing.Size(211, 20)
        Me.verRemunerado.TabIndex = 7
        Me.verRemunerado.Text = "Situación Remunerada"
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(107, 198)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 6
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtAbreviatura
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance3
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Location = New System.Drawing.Point(107, 92)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(156, 21)
        Me.txtAbreviatura.TabIndex = 5
        '
        'txtNombre
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance4
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(107, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(349, 21)
        Me.txtNombre.TabIndex = 4
        '
        'txtCodigo
        '
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance5
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(107, 38)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 3
        '
        'etiAbreviatura
        '
        Me.etiAbreviatura.AutoSize = True
        Me.etiAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiAbreviatura.Location = New System.Drawing.Point(38, 96)
        Me.etiAbreviatura.Name = "etiAbreviatura"
        Me.etiAbreviatura.Size = New System.Drawing.Size(63, 14)
        Me.etiAbreviatura.TabIndex = 2
        Me.etiAbreviatura.Text = "Abreviatura:"
        '
        'etiNombre
        '
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(55, 69)
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
        Me.etiCodigo.Location = New System.Drawing.Point(59, 42)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(42, 14)
        Me.etiCodigo.TabIndex = 0
        Me.etiCodigo.Text = "Código:"
        '
        'ficSituacionAdministrativa
        '
        Me.ficSituacionAdministrativa.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficSituacionAdministrativa.Controls.Add(Me.UltraTabPageControl1)
        Me.ficSituacionAdministrativa.Controls.Add(Me.UltraTabPageControl2)
        Me.ficSituacionAdministrativa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficSituacionAdministrativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficSituacionAdministrativa.Location = New System.Drawing.Point(0, 0)
        Me.ficSituacionAdministrativa.Name = "ficSituacionAdministrativa"
        Me.ficSituacionAdministrativa.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficSituacionAdministrativa.Size = New System.Drawing.Size(582, 407)
        Me.ficSituacionAdministrativa.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficSituacionAdministrativa.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficSituacionAdministrativa.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(580, 384)
        '
        'cboTipo
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboTipo.Appearance = Appearance1
        Me.cboTipo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipo.DisplayMember = "Nombre"
        Me.cboTipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.ForeColor = System.Drawing.Color.Black
        Me.cboTipo.Location = New System.Drawing.Point(269, 38)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(187, 21)
        Me.cboTipo.TabIndex = 13
        Me.cboTipo.ValueMember = "Id"
        '
        'etiSituacionAdministrativa
        '
        Me.etiSituacionAdministrativa.AutoSize = True
        Me.etiSituacionAdministrativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSituacionAdministrativa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiSituacionAdministrativa.Location = New System.Drawing.Point(234, 42)
        Me.etiSituacionAdministrativa.Name = "etiSituacionAdministrativa"
        Me.etiSituacionAdministrativa.Size = New System.Drawing.Size(29, 14)
        Me.etiSituacionAdministrativa.TabIndex = 12
        Me.etiSituacionAdministrativa.Text = "Tipo:"
        '
        'frm_SituacionAdministrativa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(582, 407)
        Me.Controls.Add(Me.ficSituacionAdministrativa)
        Me.Name = "frm_SituacionAdministrativa"
        Me.Text = "Gestión de Situaciones Administrativas"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrListaSituacionAdministrativas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaSituacionAdministrativas.ResumeLayout(False)
        CType(Me.griSituacionAdministrativa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrSituacionAdministrativa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrSituacionAdministrativa.ResumeLayout(False)
        Me.agrSituacionAdministrativa.PerformLayout()
        CType(Me.txtCodigoPlame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verAcumulaVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verRemunerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficSituacionAdministrativa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficSituacionAdministrativa.ResumeLayout(False)
        CType(Me.cboTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficSituacionAdministrativa As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaSituacionAdministrativas As ISL.Controles.Agrupacion
    Friend WithEvents griSituacionAdministrativa As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrSituacionAdministrativa As ISL.Controles.Agrupacion
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents etiAbreviatura As ISL.Controles.Etiqueta
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents verAcumulaVacaciones As ISL.Controles.Chequear
    Friend WithEvents verRemunerado As ISL.Controles.Chequear
    Friend WithEvents txtCodigoPlame As ISL.Controles.Texto
    Friend WithEvents lblcodigo As ISL.Controles.Etiqueta
    Friend WithEvents cboTipo As ISL.Controles.ComboMaestros
    Friend WithEvents etiSituacionAdministrativa As ISL.Controles.Etiqueta

End Class
