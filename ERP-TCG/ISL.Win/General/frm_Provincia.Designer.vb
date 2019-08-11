<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Provincia
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modificado")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Departamento1 = New ISL.Win.Departamento
        Me.agrProvincias = New ISL.Controles.Agrupacion(Me.components)
        Me.griProvincia = New ISL.Controles.Grilla(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrDatosProvincia = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtId = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.ficProvincia = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrProvincias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProvincias.SuspendLayout()
        CType(Me.griProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.agrDatosProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosProvincia.SuspendLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficProvincia.SuspendLayout()
        Me.MenuContextual1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Departamento1)
        Me.UltraTabPageControl7.Controls.Add(Me.agrProvincias)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(804, 503)
        '
        'Departamento1
        '
        Me.Departamento1.Codigo = Nothing
        Me.Departamento1.Id = Nothing
        Me.Departamento1.Location = New System.Drawing.Point(11, 13)
        Me.Departamento1.Name = "Departamento1"
        Me.Departamento1.Nombre = Nothing
        Me.Departamento1.Size = New System.Drawing.Size(357, 24)
        Me.Departamento1.TabIndex = 2
        '
        'agrProvincias
        '
        Me.agrProvincias.Controls.Add(Me.griProvincia)
        Me.agrProvincias.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.agrProvincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProvincias.ForeColor = System.Drawing.Color.Black
        Me.agrProvincias.Location = New System.Drawing.Point(0, 43)
        Me.agrProvincias.Name = "agrProvincias"
        Me.agrProvincias.Size = New System.Drawing.Size(804, 460)
        Me.agrProvincias.TabIndex = 1
        Me.agrProvincias.Text = "Lista de Provincias"
        Me.agrProvincias.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griProvincia
        '
        Me.griProvincia.ContextMenuStrip = Me.MenuContextual1
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
        Me.griProvincia.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griProvincia.DisplayLayout.MaxColScrollRegions = 1
        Me.griProvincia.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProvincia.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griProvincia.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griProvincia.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griProvincia.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griProvincia.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griProvincia.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griProvincia.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProvincia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griProvincia.Location = New System.Drawing.Point(2, 18)
        Me.griProvincia.Name = "griProvincia"
        Me.griProvincia.Size = New System.Drawing.Size(800, 440)
        Me.griProvincia.TabIndex = 1
        Me.griProvincia.Text = "Listado de Provincias"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.agrDatosProvincia)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(804, 503)
        '
        'agrDatosProvincia
        '
        Me.agrDatosProvincia.Controls.Add(Me.txtCodigo)
        Me.agrDatosProvincia.Controls.Add(Me.verActivo)
        Me.agrDatosProvincia.Controls.Add(Me.txtNombre)
        Me.agrDatosProvincia.Controls.Add(Me.txtId)
        Me.agrDatosProvincia.Controls.Add(Me.UltraLabel22)
        Me.agrDatosProvincia.Controls.Add(Me.UltraLabel4)
        Me.agrDatosProvincia.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatosProvincia.Location = New System.Drawing.Point(0, 0)
        Me.agrDatosProvincia.Name = "agrDatosProvincia"
        Me.agrDatosProvincia.Size = New System.Drawing.Size(804, 178)
        Me.agrDatosProvincia.TabIndex = 0
        Me.agrDatosProvincia.Text = "Datos"
        Me.agrDatosProvincia.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
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
        'ficProvincia
        '
        Me.ficProvincia.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficProvincia.Controls.Add(Me.UltraTabPageControl7)
        Me.ficProvincia.Controls.Add(Me.utpDetalle)
        Me.ficProvincia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficProvincia.Location = New System.Drawing.Point(0, 0)
        Me.ficProvincia.Name = "ficProvincia"
        Me.ficProvincia.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficProvincia.Size = New System.Drawing.Size(806, 526)
        Me.ficProvincia.TabIndex = 3
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficProvincia.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficProvincia.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(804, 503)
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nueva Provincia"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar la Provincia seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la Provincia seleccionada"
        '
        'frm_Provincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(806, 526)
        Me.Controls.Add(Me.ficProvincia)
        Me.Name = "frm_Provincia"
        Me.Text = "Ubicación geográfica - Provincias"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrProvincias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProvincias.ResumeLayout(False)
        CType(Me.griProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.agrDatosProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosProvincia.ResumeLayout(False)
        Me.agrDatosProvincia.PerformLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficProvincia.ResumeLayout(False)
        Me.MenuContextual1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficProvincia As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrProvincias As ISL.Controles.Agrupacion
    Friend WithEvents griProvincia As ISL.Controles.Grilla
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatosProvincia As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Departamento1 As ISL.Win.Departamento
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem


End Class
