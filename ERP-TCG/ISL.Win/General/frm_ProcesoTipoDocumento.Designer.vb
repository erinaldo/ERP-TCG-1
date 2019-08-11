<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProcesoTipoDocumento
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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.griConceptosGenerales = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrListaProcesosExistentes = New ISL.Controles.Agrupacion(Me.components)
        Me.griProcesosVinculados = New ISL.Controles.Grilla(Me.components)
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboProceso = New ISL.Controles.ComboMaestros(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.ficConceptosGenerales = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griConceptosGenerales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        Me.utpDetalle.SuspendLayout()
        CType(Me.agrListaProcesosExistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaProcesosExistentes.SuspendLayout()
        CType(Me.griProcesosVinculados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficConceptosGenerales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficConceptosGenerales.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griConceptosGenerales)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(777, 434)
        '
        'griConceptosGenerales
        '
        Me.griConceptosGenerales.ContextMenuStrip = Me.MenuContextual1
        Me.griConceptosGenerales.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griConceptosGenerales.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griConceptosGenerales.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griConceptosGenerales.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griConceptosGenerales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griConceptosGenerales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griConceptosGenerales.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griConceptosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griConceptosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griConceptosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.griConceptosGenerales.Name = "griConceptosGenerales"
        Me.griConceptosGenerales.Size = New System.Drawing.Size(777, 434)
        Me.griConceptosGenerales.TabIndex = 1
        Me.griConceptosGenerales.Text = "Información de Tipos de documentos asociados a procesos"
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Proceso de Negocio"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Proceso de Negocio seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Proceso de Negocio seleccionado"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.agrListaProcesosExistentes)
        Me.utpDetalle.Controls.Add(Me.agrProcesoNegocio)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(777, 434)
        '
        'agrListaProcesosExistentes
        '
        Me.agrListaProcesosExistentes.Controls.Add(Me.griProcesosVinculados)
        Me.agrListaProcesosExistentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaProcesosExistentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListaProcesosExistentes.ForeColor = System.Drawing.Color.Black
        Me.agrListaProcesosExistentes.Location = New System.Drawing.Point(0, 130)
        Me.agrListaProcesosExistentes.Name = "agrListaProcesosExistentes"
        Me.agrListaProcesosExistentes.Size = New System.Drawing.Size(777, 304)
        Me.agrListaProcesosExistentes.TabIndex = 1
        Me.agrListaProcesosExistentes.Text = "Lista de documentos ya vinculados a "
        Me.agrListaProcesosExistentes.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griProcesosVinculados
        '
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griProcesosVinculados.DisplayLayout.Appearance = Appearance5
        Me.griProcesosVinculados.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griProcesosVinculados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.BorderColor = System.Drawing.SystemColors.Window
        Me.griProcesosVinculados.DisplayLayout.GroupByBox.Appearance = Appearance6
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griProcesosVinculados.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance7
        Me.griProcesosVinculados.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance8.BackColor2 = System.Drawing.SystemColors.Control
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griProcesosVinculados.DisplayLayout.GroupByBox.PromptAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Appearance9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griProcesosVinculados.DisplayLayout.Override.ActiveCellAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.SystemColors.Highlight
        Appearance10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griProcesosVinculados.DisplayLayout.Override.ActiveRowAppearance = Appearance10
        Me.griProcesosVinculados.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProcesosVinculados.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Me.griProcesosVinculados.DisplayLayout.Override.CardAreaAppearance = Appearance11
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Appearance12.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griProcesosVinculados.DisplayLayout.Override.CellAppearance = Appearance12
        Me.griProcesosVinculados.DisplayLayout.Override.CellPadding = 0
        Me.griProcesosVinculados.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griProcesosVinculados.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance13.BackColor = System.Drawing.SystemColors.Control
        Appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance13.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance13.BorderColor = System.Drawing.SystemColors.Window
        Me.griProcesosVinculados.DisplayLayout.Override.GroupByRowAppearance = Appearance13
        Me.griProcesosVinculados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Me.griProcesosVinculados.DisplayLayout.Override.RowAppearance = Appearance15
        Me.griProcesosVinculados.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griProcesosVinculados.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griProcesosVinculados.DisplayLayout.Override.TemplateAddRowAppearance = Appearance16
        Me.griProcesosVinculados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProcesosVinculados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griProcesosVinculados.Location = New System.Drawing.Point(2, 18)
        Me.griProcesosVinculados.Name = "griProcesosVinculados"
        Me.griProcesosVinculados.Size = New System.Drawing.Size(773, 284)
        Me.griProcesosVinculados.TabIndex = 0
        Me.griProcesosVinculados.Text = "Grilla1"
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.cboTipoDocumento)
        Me.agrProcesoNegocio.Controls.Add(Me.cboProceso)
        Me.agrProcesoNegocio.Controls.Add(Me.verActivo)
        Me.agrProcesoNegocio.Controls.Add(Me.etiNombre)
        Me.agrProcesoNegocio.Controls.Add(Me.etiCodigo)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(777, 130)
        Me.agrProcesoNegocio.TabIndex = 0
        Me.agrProcesoNegocio.Text = "Datos"
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboTipoDocumento
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance2
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoDocumento.DisplayMember = "Nombre"
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(153, 64)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(586, 21)
        Me.cboTipoDocumento.TabIndex = 11
        Me.cboTipoDocumento.ValueMember = "Id"
        '
        'cboProceso
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboProceso.Appearance = Appearance1
        Me.cboProceso.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProceso.DisplayMember = "Nombre"
        Me.cboProceso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProceso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProceso.ForeColor = System.Drawing.Color.Black
        Me.cboProceso.Location = New System.Drawing.Point(153, 36)
        Me.cboProceso.Name = "cboProceso"
        Me.cboProceso.Size = New System.Drawing.Size(351, 21)
        Me.cboProceso.TabIndex = 10
        Me.cboProceso.ValueMember = "Id"
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(153, 91)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 9
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'etiNombre
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Appearance3.TextVAlignAsString = "Middle"
        Me.etiNombre.Appearance = Appearance3
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(43, 68)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(104, 14)
        Me.etiNombre.TabIndex = 3
        Me.etiNombre.Text = "Tipo de documento:"
        '
        'etiCodigo
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Appearance45.TextVAlignAsString = "Middle"
        Me.etiCodigo.Appearance = Appearance45
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigo.Location = New System.Drawing.Point(98, 40)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(49, 14)
        Me.etiCodigo.TabIndex = 1
        Me.etiCodigo.Text = "Proceso:"
        '
        'ficConceptosGenerales
        '
        Me.ficConceptosGenerales.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficConceptosGenerales.Controls.Add(Me.UltraTabPageControl7)
        Me.ficConceptosGenerales.Controls.Add(Me.utpDetalle)
        Me.ficConceptosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficConceptosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficConceptosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.ficConceptosGenerales.Name = "ficConceptosGenerales"
        Me.ficConceptosGenerales.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficConceptosGenerales.Size = New System.Drawing.Size(779, 457)
        Me.ficConceptosGenerales.TabIndex = 4
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficConceptosGenerales.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficConceptosGenerales.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(777, 434)
        '
        'frm_ProcesoTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(779, 457)
        Me.Controls.Add(Me.ficConceptosGenerales)
        Me.Name = "frm_ProcesoTipoDocumento"
        Me.Text = "Documentos asociados a procesos"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griConceptosGenerales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.agrListaProcesosExistentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaProcesosExistentes.ResumeLayout(False)
        CType(Me.griProcesosVinculados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficConceptosGenerales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficConceptosGenerales.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficConceptosGenerales As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griConceptosGenerales As ISL.Controles.Grilla
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboTipoDocumento As ISL.Controles.ComboMaestros
    Friend WithEvents cboProceso As ISL.Controles.ComboMaestros
    Friend WithEvents agrListaProcesosExistentes As ISL.Controles.Agrupacion
    Friend WithEvents griProcesosVinculados As ISL.Controles.Grilla

End Class
