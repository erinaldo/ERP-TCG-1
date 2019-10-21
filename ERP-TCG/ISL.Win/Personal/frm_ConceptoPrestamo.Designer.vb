<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConceptoPrestamo
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
        Me.components = New System.ComponentModel.Container
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.griConceptoPrestamo = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrComplemento = New ISL.Controles.Agrupacion(Me.components)
        Me.griConceptoSancion = New ISL.Controles.Grilla(Me.components)
        Me.mnuConceptoSancion = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiAgregar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiQuitar = New System.Windows.Forms.ToolStripMenuItem
        Me.agrConceptoSancion = New Infragistics.Win.Misc.UltraExpandableGroupBox
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.cboArea = New ISL.Controles.Combo(Me.components)
        Me.txtNombreSanc = New ISL.Controles.Texto(Me.components)
        Me.txtCodigoSanc = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.agrDatos = New ISL.Controles.Agrupacion(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficConceptoPrestamo = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griConceptoPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrComplemento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrComplemento.SuspendLayout()
        CType(Me.griConceptoSancion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuConceptoSancion.SuspendLayout()
        CType(Me.agrConceptoSancion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrConceptoSancion.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreSanc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoSanc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficConceptoPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficConceptoPrestamo.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griConceptoPrestamo)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(832, 436)
        '
        'griConceptoPrestamo
        '
        Me.griConceptoPrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griConceptoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griConceptoPrestamo.Location = New System.Drawing.Point(0, 0)
        Me.griConceptoPrestamo.Name = "griConceptoPrestamo"
        Me.griConceptoPrestamo.Size = New System.Drawing.Size(832, 436)
        Me.griConceptoPrestamo.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrComplemento)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(832, 436)
        '
        'agrComplemento
        '
        Me.agrComplemento.Controls.Add(Me.griConceptoSancion)
        Me.agrComplemento.Controls.Add(Me.agrConceptoSancion)
        Me.agrComplemento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrComplemento.ForeColor = System.Drawing.Color.Black
        Me.agrComplemento.Location = New System.Drawing.Point(0, 99)
        Me.agrComplemento.Name = "agrComplemento"
        Me.agrComplemento.Size = New System.Drawing.Size(832, 337)
        Me.agrComplemento.TabIndex = 1
        Me.agrComplemento.Text = "Complemento"
        Me.agrComplemento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griConceptoSancion
        '
        Me.griConceptoSancion.ContextMenuStrip = Me.mnuConceptoSancion
        Me.griConceptoSancion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griConceptoSancion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griConceptoSancion.Location = New System.Drawing.Point(295, 18)
        Me.griConceptoSancion.Name = "griConceptoSancion"
        Me.griConceptoSancion.Size = New System.Drawing.Size(535, 317)
        Me.griConceptoSancion.TabIndex = 1
        '
        'mnuConceptoSancion
        '
        Me.mnuConceptoSancion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuConceptoSancion.ForeColor = System.Drawing.Color.Black
        Me.mnuConceptoSancion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAgregar, Me.tsmiEditar, Me.tsmiQuitar})
        Me.mnuConceptoSancion.Name = "mnuConceptoSancion"
        Me.mnuConceptoSancion.Size = New System.Drawing.Size(112, 70)
        '
        'tsmiAgregar
        '
        Me.tsmiAgregar.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsmiAgregar.Name = "tsmiAgregar"
        Me.tsmiAgregar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiAgregar.Text = "Agregar"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = Global.ISL.Win.My.Resources.Resources.Information
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiEditar.Text = "Editar"
        '
        'tsmiQuitar
        '
        Me.tsmiQuitar.Image = Global.ISL.Win.My.Resources.Resources.SymbolRestricted
        Me.tsmiQuitar.Name = "tsmiQuitar"
        Me.tsmiQuitar.Size = New System.Drawing.Size(111, 22)
        Me.tsmiQuitar.Text = "Quitar"
        '
        'agrConceptoSancion
        '
        Me.agrConceptoSancion.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Far
        Me.agrConceptoSancion.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.agrConceptoSancion.Dock = System.Windows.Forms.DockStyle.Left
        Me.agrConceptoSancion.ExpandedSize = New System.Drawing.Size(293, 317)
        Me.agrConceptoSancion.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.agrConceptoSancion.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.agrConceptoSancion.Location = New System.Drawing.Point(2, 18)
        Me.agrConceptoSancion.Name = "agrConceptoSancion"
        Me.agrConceptoSancion.Size = New System.Drawing.Size(293, 317)
        Me.agrConceptoSancion.TabIndex = 0
        Me.agrConceptoSancion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnCancelar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnAceptar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboArea)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtNombreSanc)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtCodigoSanc)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta5)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta3)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(0, 2)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(291, 313)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'btnCancelar
        '
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        Me.btnCancelar.Appearance = Appearance3
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnCancelar.Location = New System.Drawing.Point(149, 173)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 33)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnAceptar.Appearance = Appearance2
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnAceptar.Location = New System.Drawing.Point(57, 173)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(86, 33)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        '
        'cboArea
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Appearance = Appearance1
        Me.cboArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Location = New System.Drawing.Point(18, 133)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(258, 21)
        Me.cboArea.TabIndex = 5
        Me.cboArea.ValueMember = "Id"
        '
        'txtNombreSanc
        '
        Me.txtNombreSanc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreSanc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombreSanc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSanc.Location = New System.Drawing.Point(18, 86)
        Me.txtNombreSanc.MaxLength = 150
        Me.txtNombreSanc.Name = "txtNombreSanc"
        Me.txtNombreSanc.Size = New System.Drawing.Size(258, 21)
        Me.txtNombreSanc.TabIndex = 4
        '
        'txtCodigoSanc
        '
        Me.txtCodigoSanc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoSanc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoSanc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoSanc.Location = New System.Drawing.Point(18, 39)
        Me.txtCodigoSanc.MaxLength = 6
        Me.txtCodigoSanc.Name = "txtCodigoSanc"
        Me.txtCodigoSanc.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigoSanc.TabIndex = 3
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(18, 113)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Area:"
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(18, 66)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta4.TabIndex = 1
        Me.Etiqueta4.Text = "Nombre:"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(18, 19)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(42, 14)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Codigo:"
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.txtNombre)
        Me.agrDatos.Controls.Add(Me.txtCodigo)
        Me.agrDatos.Controls.Add(Me.Etiqueta2)
        Me.agrDatos.Controls.Add(Me.Etiqueta1)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.ForeColor = System.Drawing.Color.Black
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(832, 99)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.Text = "Datos:"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(70, 61)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(335, 21)
        Me.txtNombre.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(70, 32)
        Me.txtCodigo.MaxLength = 6
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 2
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(21, 65)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta2.TabIndex = 1
        Me.Etiqueta2.Text = "Nombre"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(25, 36)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Codigo"
        '
        'ficConceptoPrestamo
        '
        Me.ficConceptoPrestamo.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficConceptoPrestamo.Controls.Add(Me.UltraTabPageControl1)
        Me.ficConceptoPrestamo.Controls.Add(Me.UltraTabPageControl2)
        Me.ficConceptoPrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficConceptoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficConceptoPrestamo.Location = New System.Drawing.Point(0, 0)
        Me.ficConceptoPrestamo.Name = "ficConceptoPrestamo"
        Me.ficConceptoPrestamo.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficConceptoPrestamo.Size = New System.Drawing.Size(834, 459)
        Me.ficConceptoPrestamo.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficConceptoPrestamo.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficConceptoPrestamo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(832, 436)
        '
        'frm_ConceptoPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 459)
        Me.Controls.Add(Me.ficConceptoPrestamo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ConceptoPrestamo"
        Me.Text = "Concepto Prestamo"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griConceptoPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrComplemento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrComplemento.ResumeLayout(False)
        CType(Me.griConceptoSancion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuConceptoSancion.ResumeLayout(False)
        CType(Me.agrConceptoSancion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrConceptoSancion.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreSanc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoSanc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.agrDatos.PerformLayout()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficConceptoPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficConceptoPrestamo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficConceptoPrestamo As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griConceptoPrestamo As ISL.Controles.Grilla
    Friend WithEvents agrDatos As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents agrComplemento As ISL.Controles.Agrupacion
    Friend WithEvents griConceptoSancion As ISL.Controles.Grilla
    Friend WithEvents agrConceptoSancion As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents cboArea As ISL.Controles.Combo
    Friend WithEvents txtNombreSanc As ISL.Controles.Texto
    Friend WithEvents txtCodigoSanc As ISL.Controles.Texto
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents mnuConceptoSancion As ISL.Controles.MenuContextual
    Friend WithEvents tsmiAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiQuitar As System.Windows.Forms.ToolStripMenuItem
End Class
