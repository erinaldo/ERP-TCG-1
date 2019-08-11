<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Distrito
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modificado")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrDistritos = New ISL.Controles.Agrupacion(Me.components)
        Me.griDistrito = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Provincia1 = New ISL.Win.Provincia
        Me.etiProvincia = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProvincia = New ISL.Controles.ComboMaestros(Me.components)
        Me.Departamento1 = New ISL.Win.Departamento
        Me.etiDepartamento = New ISL.Controles.Etiqueta(Me.components)
        Me.cboDepartamento = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ComboMaestros1 = New ISL.Controles.ComboMaestros(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrDatosDistrito = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtId = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.ficDistrito = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrDistritos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDistritos.SuspendLayout()
        CType(Me.griDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.Provincia1.SuspendLayout()
        CType(Me.cboProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Departamento1.SuspendLayout()
        CType(Me.cboDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboMaestros1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.agrDatosDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosDistrito.SuspendLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDistrito.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrDistritos)
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(792, 390)
        '
        'agrDistritos
        '
        Me.agrDistritos.Controls.Add(Me.griDistrito)
        Me.agrDistritos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDistritos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDistritos.ForeColor = System.Drawing.Color.Black
        Me.agrDistritos.Location = New System.Drawing.Point(0, 82)
        Me.agrDistritos.Name = "agrDistritos"
        Me.agrDistritos.Size = New System.Drawing.Size(792, 308)
        Me.agrDistritos.TabIndex = 5
        Me.agrDistritos.Text = "Lista de Distritos"
        Me.agrDistritos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griDistrito
        '
        Me.griDistrito.ContextMenuStrip = Me.MenuContextual1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 390
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.griDistrito.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDistrito.DisplayLayout.MaxColScrollRegions = 1
        Me.griDistrito.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDistrito.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDistrito.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDistrito.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDistrito.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDistrito.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDistrito.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDistrito.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDistrito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDistrito.Location = New System.Drawing.Point(2, 18)
        Me.griDistrito.Name = "griDistrito"
        Me.griDistrito.Size = New System.Drawing.Size(788, 288)
        Me.griDistrito.TabIndex = 1
        Me.griDistrito.Text = "Listado de Distritos"
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Distrito"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Distrito seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Distrito seleccionado"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Provincia1)
        Me.Agrupacion1.Controls.Add(Me.Departamento1)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(792, 82)
        Me.Agrupacion1.TabIndex = 4
        Me.Agrupacion1.Text = "Selección de datos básicos"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Provincia1
        '
        Me.Provincia1.Codigo = Nothing
        Me.Provincia1.CodigoDepartamento = Nothing
        Me.Provincia1.Controls.Add(Me.etiProvincia)
        Me.Provincia1.Controls.Add(Me.cboProvincia)
        Me.Provincia1.Id = Nothing
        Me.Provincia1.Location = New System.Drawing.Point(24, 48)
        Me.Provincia1.Name = "Provincia1"
        Me.Provincia1.Nombre = Nothing
        Me.Provincia1.Size = New System.Drawing.Size(351, 21)
        Me.Provincia1.TabIndex = 5
        '
        'etiProvincia
        '
        Me.etiProvincia.AutoSize = True
        Me.etiProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiProvincia.ForeColor = System.Drawing.Color.Black
        Me.etiProvincia.Location = New System.Drawing.Point(4, 4)
        Me.etiProvincia.Name = "etiProvincia"
        Me.etiProvincia.Size = New System.Drawing.Size(49, 14)
        Me.etiProvincia.TabIndex = 1
        Me.etiProvincia.Text = "Provincia"
        '
        'cboProvincia
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboProvincia.Appearance = Appearance4
        Me.cboProvincia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProvincia.DisplayMember = "Nombre"
        Me.cboProvincia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProvincia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.ForeColor = System.Drawing.Color.Black
        Me.cboProvincia.Location = New System.Drawing.Point(84, 0)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(266, 21)
        Me.cboProvincia.TabIndex = 0
        Me.cboProvincia.ValueMember = "Id"
        '
        'Departamento1
        '
        Me.Departamento1.Codigo = Nothing
        Me.Departamento1.Controls.Add(Me.etiDepartamento)
        Me.Departamento1.Controls.Add(Me.cboDepartamento)
        Me.Departamento1.Controls.Add(Me.Etiqueta1)
        Me.Departamento1.Controls.Add(Me.ComboMaestros1)
        Me.Departamento1.Id = Nothing
        Me.Departamento1.Location = New System.Drawing.Point(24, 21)
        Me.Departamento1.Name = "Departamento1"
        Me.Departamento1.Nombre = Nothing
        Me.Departamento1.Size = New System.Drawing.Size(357, 24)
        Me.Departamento1.TabIndex = 4
        '
        'etiDepartamento
        '
        Me.etiDepartamento.AutoSize = True
        Me.etiDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDepartamento.ForeColor = System.Drawing.Color.Black
        Me.etiDepartamento.Location = New System.Drawing.Point(4, 4)
        Me.etiDepartamento.Name = "etiDepartamento"
        Me.etiDepartamento.Size = New System.Drawing.Size(74, 14)
        Me.etiDepartamento.TabIndex = 1
        Me.etiDepartamento.Text = "Departamento"
        '
        'cboDepartamento
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.cboDepartamento.Appearance = Appearance5
        Me.cboDepartamento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboDepartamento.DisplayMember = "Nombre"
        Me.cboDepartamento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDepartamento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartamento.ForeColor = System.Drawing.Color.Black
        Me.cboDepartamento.Location = New System.Drawing.Point(84, 0)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(266, 21)
        Me.cboDepartamento.TabIndex = 0
        Me.cboDepartamento.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(4, 4)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(74, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Departamento"
        '
        'ComboMaestros1
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.ComboMaestros1.Appearance = Appearance2
        Me.ComboMaestros1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.ComboMaestros1.DisplayMember = "Nombre"
        Me.ComboMaestros1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ComboMaestros1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ComboMaestros1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMaestros1.ForeColor = System.Drawing.Color.Black
        Me.ComboMaestros1.Location = New System.Drawing.Point(84, 0)
        Me.ComboMaestros1.Name = "ComboMaestros1"
        Me.ComboMaestros1.Size = New System.Drawing.Size(266, 21)
        Me.ComboMaestros1.TabIndex = 0
        Me.ComboMaestros1.ValueMember = "Id"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.agrDatosDistrito)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(792, 390)
        '
        'agrDatosDistrito
        '
        Me.agrDatosDistrito.Controls.Add(Me.txtCodigo)
        Me.agrDatosDistrito.Controls.Add(Me.verActivo)
        Me.agrDatosDistrito.Controls.Add(Me.txtNombre)
        Me.agrDatosDistrito.Controls.Add(Me.txtId)
        Me.agrDatosDistrito.Controls.Add(Me.UltraLabel22)
        Me.agrDatosDistrito.Controls.Add(Me.UltraLabel4)
        Me.agrDatosDistrito.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatosDistrito.Location = New System.Drawing.Point(0, 0)
        Me.agrDatosDistrito.Name = "agrDatosDistrito"
        Me.agrDatosDistrito.Size = New System.Drawing.Size(792, 178)
        Me.agrDatosDistrito.TabIndex = 0
        Me.agrDatosDistrito.Text = "Datos"
        Me.agrDatosDistrito.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtCodigo
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance1
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(96, 25)
        Me.txtCodigo.MaxLength = 15
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(90, 21)
        Me.txtCodigo.TabIndex = 2
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(96, 113)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 9
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtNombre
        '
        Appearance27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance27
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(96, 52)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(253, 21)
        Me.txtNombre.TabIndex = 4
        '
        'txtId
        '
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(11, 25)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(20, 21)
        Me.txtId.TabIndex = 0
        Me.txtId.Visible = False
        '
        'UltraLabel22
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Appearance3.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance3
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(42, 54)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel22.TabIndex = 3
        Me.UltraLabel22.Text = "Nombre:"
        '
        'UltraLabel4
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Appearance45.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance45
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(47, 29)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 1
        Me.UltraLabel4.Text = "Código:"
        '
        'ficDistrito
        '
        Me.ficDistrito.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDistrito.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDistrito.Controls.Add(Me.utpDetalle)
        Me.ficDistrito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDistrito.Location = New System.Drawing.Point(0, 0)
        Me.ficDistrito.Name = "ficDistrito"
        Me.ficDistrito.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDistrito.Size = New System.Drawing.Size(794, 413)
        Me.ficDistrito.TabIndex = 4
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficDistrito.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficDistrito.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(792, 390)
        '
        'frm_Distrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 413)
        Me.Controls.Add(Me.ficDistrito)
        Me.Name = "frm_Distrito"
        Me.Text = "Ubicación geográfica - distritos"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrDistritos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDistritos.ResumeLayout(False)
        CType(Me.griDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Provincia1.ResumeLayout(False)
        Me.Provincia1.PerformLayout()
        CType(Me.cboProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Departamento1.ResumeLayout(False)
        Me.Departamento1.PerformLayout()
        CType(Me.cboDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboMaestros1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.agrDatosDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosDistrito.ResumeLayout(False)
        Me.agrDatosDistrito.PerformLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDistrito.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficDistrito As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatosDistrito As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrDistritos As ISL.Controles.Agrupacion
    Friend WithEvents griDistrito As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Provincia1 As ISL.Win.Provincia
    Friend WithEvents etiProvincia As ISL.Controles.Etiqueta
    Friend WithEvents cboProvincia As ISL.Controles.ComboMaestros
    Friend WithEvents Departamento1 As ISL.Win.Departamento
    Friend WithEvents etiDepartamento As ISL.Controles.Etiqueta
    Friend WithEvents cboDepartamento As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ComboMaestros1 As ISL.Controles.ComboMaestros

End Class
