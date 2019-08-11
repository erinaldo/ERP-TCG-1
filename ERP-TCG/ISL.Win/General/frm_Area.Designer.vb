<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Area
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaAreas = New ISL.Controles.Agrupacion(Me.components)
        Me.griArea = New ISL.Controles.Grilla(Me.components)
        Me.mcArea = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiExportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrArea = New ISL.Controles.Agrupacion(Me.components)
        Me.chkGerencia = New ISL.Controles.Chequear(Me.components)
        Me.cboGerencia = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboArea = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.chkSeccion = New ISL.Controles.Chequear(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.etiAbreviatura = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCodigo = New ISL.Controles.Etiqueta(Me.components)
        Me.ficArea = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrListaAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaAreas.SuspendLayout()
        CType(Me.griArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcArea.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrArea.SuspendLayout()
        CType(Me.chkGerencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGerencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrListaAreas)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(730, 412)
        '
        'agrListaAreas
        '
        Me.agrListaAreas.Controls.Add(Me.griArea)
        Me.agrListaAreas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListaAreas.ForeColor = System.Drawing.Color.Black
        Me.agrListaAreas.Location = New System.Drawing.Point(0, 0)
        Me.agrListaAreas.Name = "agrListaAreas"
        Me.agrListaAreas.Size = New System.Drawing.Size(730, 412)
        Me.agrListaAreas.TabIndex = 1
        Me.agrListaAreas.Text = "Lista de áreas"
        Me.agrListaAreas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griArea
        '
        Me.griArea.ContextMenuStrip = Me.mcArea
        Me.griArea.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griArea.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griArea.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griArea.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griArea.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griArea.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griArea.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griArea.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griArea.Location = New System.Drawing.Point(2, 18)
        Me.griArea.Name = "griArea"
        Me.griArea.Size = New System.Drawing.Size(726, 392)
        Me.griArea.TabIndex = 1
        Me.griArea.Text = "Información de áreas"
        '
        'mcArea
        '
        Me.mcArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcArea.ForeColor = System.Drawing.Color.Black
        Me.mcArea.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiEditar, Me.tsmiEliminar, Me.ToolStripSeparator1, Me.tsmiExportar})
        Me.mcArea.Name = "MenuContextual1"
        Me.mcArea.Size = New System.Drawing.Size(114, 98)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(113, 22)
        Me.tsmiNuevo.Text = "Nuevo"
        Me.tsmiNuevo.ToolTipText = "Insertar una nueva área"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiEditar.Text = "Editar"
        Me.tsmiEditar.ToolTipText = "Actualizar o modificar el área seleccionada"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(113, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        Me.tsmiEliminar.ToolTipText = "Eliminar el área seleccionada"
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
        Me.UltraTabPageControl2.Controls.Add(Me.agrArea)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(730, 412)
        '
        'agrArea
        '
        Me.agrArea.Controls.Add(Me.chkGerencia)
        Me.agrArea.Controls.Add(Me.cboGerencia)
        Me.agrArea.Controls.Add(Me.Etiqueta2)
        Me.agrArea.Controls.Add(Me.cboArea)
        Me.agrArea.Controls.Add(Me.Etiqueta1)
        Me.agrArea.Controls.Add(Me.chkSeccion)
        Me.agrArea.Controls.Add(Me.verActivo)
        Me.agrArea.Controls.Add(Me.txtAbreviatura)
        Me.agrArea.Controls.Add(Me.txtNombre)
        Me.agrArea.Controls.Add(Me.txtCodigo)
        Me.agrArea.Controls.Add(Me.etiAbreviatura)
        Me.agrArea.Controls.Add(Me.etiNombre)
        Me.agrArea.Controls.Add(Me.etiCodigo)
        Me.agrArea.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrArea.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrArea.Location = New System.Drawing.Point(0, 0)
        Me.agrArea.Name = "agrArea"
        Me.agrArea.Size = New System.Drawing.Size(730, 207)
        Me.agrArea.TabIndex = 1
        Me.agrArea.Text = "Datos:"
        Me.agrArea.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'chkGerencia
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.chkGerencia.Appearance = Appearance1
        Me.chkGerencia.AutoSize = True
        Me.chkGerencia.BackColor = System.Drawing.Color.Transparent
        Me.chkGerencia.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkGerencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGerencia.ForeColor = System.Drawing.Color.Black
        Me.chkGerencia.Location = New System.Drawing.Point(287, 39)
        Me.chkGerencia.Name = "chkGerencia"
        Me.chkGerencia.Size = New System.Drawing.Size(84, 17)
        Me.chkGerencia.TabIndex = 12
        Me.chkGerencia.Text = "Es Gerencia"
        '
        'cboGerencia
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboGerencia.Appearance = Appearance2
        Me.cboGerencia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGerencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGerencia.ForeColor = System.Drawing.Color.Black
        Me.cboGerencia.Location = New System.Drawing.Point(107, 146)
        Me.cboGerencia.Name = "cboGerencia"
        Me.cboGerencia.Size = New System.Drawing.Size(349, 21)
        Me.cboGerencia.TabIndex = 11
        Me.cboGerencia.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance3
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(49, 150)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta2.TabIndex = 10
        Me.Etiqueta2.Text = "Gerencia:"
        '
        'cboArea
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Appearance = Appearance4
        Me.cboArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Location = New System.Drawing.Point(107, 119)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(349, 21)
        Me.cboArea.TabIndex = 9
        Me.cboArea.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance5
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(35, 123)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta1.TabIndex = 8
        Me.Etiqueta1.Text = "Pertenece a:"
        '
        'chkSeccion
        '
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.chkSeccion.Appearance = Appearance6
        Me.chkSeccion.AutoSize = True
        Me.chkSeccion.BackColor = System.Drawing.Color.Transparent
        Me.chkSeccion.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeccion.ForeColor = System.Drawing.Color.Black
        Me.chkSeccion.Location = New System.Drawing.Point(287, 93)
        Me.chkSeccion.Name = "chkSeccion"
        Me.chkSeccion.Size = New System.Drawing.Size(62, 17)
        Me.chkSeccion.TabIndex = 7
        Me.chkSeccion.Text = "Sección"
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(107, 173)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 6
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'txtAbreviatura
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance7
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Location = New System.Drawing.Point(107, 92)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(174, 21)
        Me.txtAbreviatura.TabIndex = 5
        '
        'txtNombre
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance8
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
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance9
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
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.etiAbreviatura.Appearance = Appearance10
        Me.etiAbreviatura.AutoSize = True
        Me.etiAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiAbreviatura.Location = New System.Drawing.Point(38, 96)
        Me.etiAbreviatura.Name = "etiAbreviatura"
        Me.etiAbreviatura.Size = New System.Drawing.Size(66, 14)
        Me.etiAbreviatura.TabIndex = 2
        Me.etiAbreviatura.Text = "Abreviatura:"
        '
        'etiNombre
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.etiNombre.Appearance = Appearance11
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(55, 69)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(48, 14)
        Me.etiNombre.TabIndex = 1
        Me.etiNombre.Text = "Nombre:"
        '
        'etiCodigo
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.etiCodigo.Appearance = Appearance12
        Me.etiCodigo.AutoSize = True
        Me.etiCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCodigo.Location = New System.Drawing.Point(59, 42)
        Me.etiCodigo.Name = "etiCodigo"
        Me.etiCodigo.Size = New System.Drawing.Size(44, 14)
        Me.etiCodigo.TabIndex = 0
        Me.etiCodigo.Text = "Código:"
        '
        'ficArea
        '
        Me.ficArea.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficArea.Controls.Add(Me.UltraTabPageControl1)
        Me.ficArea.Controls.Add(Me.UltraTabPageControl2)
        Me.ficArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficArea.Location = New System.Drawing.Point(0, 0)
        Me.ficArea.Name = "ficArea"
        Me.ficArea.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficArea.Size = New System.Drawing.Size(732, 435)
        Me.ficArea.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficArea.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficArea.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(730, 412)
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_Area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 435)
        Me.Controls.Add(Me.ficArea)
        Me.Name = "frm_Area"
        Me.Text = "Area"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrListaAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaAreas.ResumeLayout(False)
        CType(Me.griArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcArea.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrArea.ResumeLayout(False)
        Me.agrArea.PerformLayout()
        CType(Me.chkGerencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGerencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficArea.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficArea As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrArea As ISL.Controles.Agrupacion
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents etiAbreviatura As ISL.Controles.Etiqueta
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiCodigo As ISL.Controles.Etiqueta

    Friend WithEvents agrListaAreas As ISL.Controles.Agrupacion
    Friend WithEvents griArea As ISL.Controles.Grilla
    Friend WithEvents mcArea As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboArea As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents chkSeccion As ISL.Controles.Chequear
    Friend WithEvents tsmiExportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents chkGerencia As ISL.Controles.Chequear
    Friend WithEvents cboGerencia As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta

End Class
