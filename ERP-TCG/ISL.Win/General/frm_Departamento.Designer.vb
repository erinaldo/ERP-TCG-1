<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Departamento
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modificado")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrDepartamentos = New ISL.Controles.Agrupacion(Me.components)
        Me.griDepartamento = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrigenDatos1 = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtId = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.ficDepartamento = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDepartamentos.SuspendLayout()
        CType(Me.griDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.OrigenDatos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDepartamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrDepartamentos)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(968, 599)
        '
        'agrDepartamentos
        '
        Me.agrDepartamentos.Controls.Add(Me.griDepartamento)
        Me.agrDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDepartamentos.ForeColor = System.Drawing.Color.Black
        Me.agrDepartamentos.Location = New System.Drawing.Point(0, 0)
        Me.agrDepartamentos.Name = "agrDepartamentos"
        Me.agrDepartamentos.Size = New System.Drawing.Size(968, 599)
        Me.agrDepartamentos.TabIndex = 1
        Me.agrDepartamentos.Text = "Lista de Departamentos"
        Me.agrDepartamentos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griDepartamento
        '
        Me.griDepartamento.ContextMenuStrip = Me.MenuContextual1
        Me.griDepartamento.DataSource = Me.OrigenDatos1
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
        Me.griDepartamento.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDepartamento.DisplayLayout.MaxColScrollRegions = 1
        Me.griDepartamento.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDepartamento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDepartamento.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDepartamento.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDepartamento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDepartamento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDepartamento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDepartamento.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDepartamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDepartamento.Location = New System.Drawing.Point(2, 18)
        Me.griDepartamento.Name = "griDepartamento"
        Me.griDepartamento.Size = New System.Drawing.Size(964, 579)
        Me.griDepartamento.TabIndex = 1
        Me.griDepartamento.Text = "Listado de Departamentos"
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Departamento"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Departamento seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Departamento seleccionado"
        '
        'OrigenDatos1
        '
        Me.OrigenDatos1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(968, 599)
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtCodigo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verActivo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtNombre)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtId)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel22)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel4)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(968, 128)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
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
        Me.verActivo.Location = New System.Drawing.Point(96, 77)
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
        Me.txtNombre.Location = New System.Drawing.Point(96, 50)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(382, 21)
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
        Me.UltraLabel22.Location = New System.Drawing.Point(42, 52)
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
        'ficDepartamento
        '
        Me.ficDepartamento.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDepartamento.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDepartamento.Controls.Add(Me.utpDetalle)
        Me.ficDepartamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDepartamento.Location = New System.Drawing.Point(0, 0)
        Me.ficDepartamento.Name = "ficDepartamento"
        Me.ficDepartamento.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDepartamento.Size = New System.Drawing.Size(970, 622)
        Me.ficDepartamento.TabIndex = 2
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficDepartamento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficDepartamento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(968, 599)
        '
        'frm_Departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 622)
        Me.Controls.Add(Me.ficDepartamento)
        Me.Name = "frm_Departamento"
        Me.Text = "Ubicación geográfica - Departamentos"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDepartamentos.ResumeLayout(False)
        CType(Me.griDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.OrigenDatos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDepartamento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficDepartamento As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents OrigenDatos1 As ISL.Controles.OrigenDatos
    Friend WithEvents agrDepartamentos As ISL.Controles.Agrupacion
    Friend WithEvents griDepartamento As ISL.Controles.Grilla
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem


End Class
