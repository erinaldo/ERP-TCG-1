<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Onomasticos
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
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSaludo = New System.Windows.Forms.TextBox
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.opcFormato1 = New System.Windows.Forms.RadioButton
        Me.opcFormato2 = New System.Windows.Forms.RadioButton
        Me.opcFormato3 = New System.Windows.Forms.RadioButton
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.opcDelDia = New System.Windows.Forms.RadioButton
        Me.Meses1 = New ISL.Win.Meses
        Me.opcPorMes = New System.Windows.Forms.RadioButton
        Me.opcTodos = New System.Windows.Forms.RadioButton
        Me.numDiasAntes = New ISL.Controles.NumeroEntero(Me.components)
        Me.etiDias = New ISL.Controles.Etiqueta(Me.components)
        Me.etiProximosDias = New ISL.Controles.Etiqueta(Me.components)
        Me.etiVerificarFechaNacimiento = New ISL.Controles.Etiqueta(Me.components)
        Me.etiEnElDia = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresVerificarFechaNacimiento = New ISL.Controles.Colores(Me.components)
        Me.ColoresDelDia = New ISL.Controles.Colores(Me.components)
        Me.ColoresFaltanDias = New ISL.Controles.Colores(Me.components)
        Me.agrTituloGrilla = New ISL.Controles.Agrupacion(Me.components)
        Me.spcOnomastico = New System.Windows.Forms.SplitContainer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.griOnomasticos = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.GenerarArchivoPowerPointDeSaludoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnviarEmailDeSaludoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnMostrarOcultar = New ISL.Controles.Boton(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkTexto3D = New System.Windows.Forms.CheckBox
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.numDiasAntes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresVerificarFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresDelDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresFaltanDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrTituloGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTituloGrilla.SuspendLayout()
        Me.spcOnomastico.Panel1.SuspendLayout()
        Me.spcOnomastico.Panel2.SuspendLayout()
        Me.spcOnomastico.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.griOnomasticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.chkTexto3D)
        Me.Agrupacion1.Controls.Add(Me.Label1)
        Me.Agrupacion1.Controls.Add(Me.txtSaludo)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion1.Controls.Add(Me.numDiasAntes)
        Me.Agrupacion1.Controls.Add(Me.etiDias)
        Me.Agrupacion1.Controls.Add(Me.etiProximosDias)
        Me.Agrupacion1.Controls.Add(Me.etiVerificarFechaNacimiento)
        Me.Agrupacion1.Controls.Add(Me.etiEnElDia)
        Me.Agrupacion1.Controls.Add(Me.ColoresVerificarFechaNacimiento)
        Me.Agrupacion1.Controls.Add(Me.ColoresDelDia)
        Me.Agrupacion1.Controls.Add(Me.ColoresFaltanDias)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1025, 91)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "Información para agrupar"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(645, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Texto de la diapositiva"
        '
        'txtSaludo
        '
        Me.txtSaludo.Location = New System.Drawing.Point(645, 45)
        Me.txtSaludo.Multiline = True
        Me.txtSaludo.Name = "txtSaludo"
        Me.txtSaludo.Size = New System.Drawing.Size(351, 38)
        Me.txtSaludo.TabIndex = 14
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.opcFormato1)
        Me.Agrupacion3.Controls.Add(Me.opcFormato2)
        Me.Agrupacion3.Controls.Add(Me.opcFormato3)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(202, 18)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(200, 71)
        Me.Agrupacion3.TabIndex = 13
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'opcFormato1
        '
        Me.opcFormato1.AutoSize = True
        Me.opcFormato1.Checked = True
        Me.opcFormato1.Location = New System.Drawing.Point(5, 4)
        Me.opcFormato1.Name = "opcFormato1"
        Me.opcFormato1.Size = New System.Drawing.Size(92, 17)
        Me.opcFormato1.TabIndex = 0
        Me.opcFormato1.TabStop = True
        Me.opcFormato1.Text = "Formato Nro.1"
        Me.opcFormato1.UseVisualStyleBackColor = True
        '
        'opcFormato2
        '
        Me.opcFormato2.AutoSize = True
        Me.opcFormato2.Location = New System.Drawing.Point(5, 26)
        Me.opcFormato2.Name = "opcFormato2"
        Me.opcFormato2.Size = New System.Drawing.Size(92, 17)
        Me.opcFormato2.TabIndex = 1
        Me.opcFormato2.Text = "Formato Nro.2"
        Me.opcFormato2.UseVisualStyleBackColor = True
        '
        'opcFormato3
        '
        Me.opcFormato3.AutoSize = True
        Me.opcFormato3.Location = New System.Drawing.Point(6, 47)
        Me.opcFormato3.Name = "opcFormato3"
        Me.opcFormato3.Size = New System.Drawing.Size(92, 17)
        Me.opcFormato3.TabIndex = 2
        Me.opcFormato3.Text = "Formato Nro.3"
        Me.opcFormato3.UseVisualStyleBackColor = True
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.opcDelDia)
        Me.Agrupacion2.Controls.Add(Me.Meses1)
        Me.Agrupacion2.Controls.Add(Me.opcPorMes)
        Me.Agrupacion2.Controls.Add(Me.opcTodos)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(2, 18)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(200, 71)
        Me.Agrupacion2.TabIndex = 11
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'opcDelDia
        '
        Me.opcDelDia.AutoSize = True
        Me.opcDelDia.Checked = True
        Me.opcDelDia.Location = New System.Drawing.Point(5, 3)
        Me.opcDelDia.Name = "opcDelDia"
        Me.opcDelDia.Size = New System.Drawing.Size(60, 17)
        Me.opcDelDia.TabIndex = 0
        Me.opcDelDia.TabStop = True
        Me.opcDelDia.Text = "Del día"
        Me.opcDelDia.UseVisualStyleBackColor = True
        '
        'Meses1
        '
        Me.Meses1.Id = Nothing
        Me.Meses1.Location = New System.Drawing.Point(22, 23)
        Me.Meses1.Name = "Meses1"
        Me.Meses1.Nombre = Nothing
        Me.Meses1.Size = New System.Drawing.Size(160, 22)
        Me.Meses1.TabIndex = 10
        Me.Meses1.Texto = "Mes"
        '
        'opcPorMes
        '
        Me.opcPorMes.AutoSize = True
        Me.opcPorMes.Location = New System.Drawing.Point(5, 26)
        Me.opcPorMes.Name = "opcPorMes"
        Me.opcPorMes.Size = New System.Drawing.Size(14, 13)
        Me.opcPorMes.TabIndex = 1
        Me.opcPorMes.UseVisualStyleBackColor = True
        '
        'opcTodos
        '
        Me.opcTodos.AutoSize = True
        Me.opcTodos.Location = New System.Drawing.Point(6, 47)
        Me.opcTodos.Name = "opcTodos"
        Me.opcTodos.Size = New System.Drawing.Size(55, 17)
        Me.opcTodos.TabIndex = 2
        Me.opcTodos.Text = "Todos"
        Me.opcTodos.UseVisualStyleBackColor = True
        '
        'numDiasAntes
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.numDiasAntes.Appearance = Appearance12
        Me.numDiasAntes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numDiasAntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDiasAntes.ForeColor = System.Drawing.Color.Black
        Me.numDiasAntes.FormatString = ""
        Me.numDiasAntes.Location = New System.Drawing.Point(513, 43)
        Me.numDiasAntes.MaskInput = "nn"
        Me.numDiasAntes.MaxValue = 30
        Me.numDiasAntes.MinValue = 1
        Me.numDiasAntes.Name = "numDiasAntes"
        Me.numDiasAntes.Size = New System.Drawing.Size(41, 21)
        Me.numDiasAntes.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numDiasAntes.TabIndex = 9
        Me.numDiasAntes.Value = 1
        '
        'etiDias
        '
        Me.etiDias.AutoSize = True
        Me.etiDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDias.ForeColor = System.Drawing.Color.Black
        Me.etiDias.Location = New System.Drawing.Point(560, 47)
        Me.etiDias.Name = "etiDias"
        Me.etiDias.Size = New System.Drawing.Size(32, 14)
        Me.etiDias.TabIndex = 8
        Me.etiDias.Text = "día(s)"
        '
        'etiProximosDias
        '
        Me.etiProximosDias.AutoSize = True
        Me.etiProximosDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiProximosDias.ForeColor = System.Drawing.Color.Black
        Me.etiProximosDias.Location = New System.Drawing.Point(474, 47)
        Me.etiProximosDias.Name = "etiProximosDias"
        Me.etiProximosDias.Size = New System.Drawing.Size(35, 14)
        Me.etiProximosDias.TabIndex = 8
        Me.etiProximosDias.Text = "Faltan"
        '
        'etiVerificarFechaNacimiento
        '
        Me.etiVerificarFechaNacimiento.AutoSize = True
        Me.etiVerificarFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiVerificarFechaNacimiento.ForeColor = System.Drawing.Color.Black
        Me.etiVerificarFechaNacimiento.Location = New System.Drawing.Point(474, 69)
        Me.etiVerificarFechaNacimiento.Name = "etiVerificarFechaNacimiento"
        Me.etiVerificarFechaNacimiento.Size = New System.Drawing.Size(106, 14)
        Me.etiVerificarFechaNacimiento.TabIndex = 8
        Me.etiVerificarFechaNacimiento.Text = "Fechas para verificar"
        Me.ToolTip1.SetToolTip(Me.etiVerificarFechaNacimiento, "Fecha de nacimiento al parecer con algún dato erróneo, especialmente el año de na" & _
                "cimiento")
        '
        'etiEnElDia
        '
        Me.etiEnElDia.AutoSize = True
        Me.etiEnElDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnElDia.ForeColor = System.Drawing.Color.Black
        Me.etiEnElDia.Location = New System.Drawing.Point(474, 26)
        Me.etiEnElDia.Name = "etiEnElDia"
        Me.etiEnElDia.Size = New System.Drawing.Size(104, 14)
        Me.etiEnElDia.TabIndex = 8
        Me.etiEnElDia.Text = "Onomásticos del día"
        '
        'ColoresVerificarFechaNacimiento
        '
        Me.ColoresVerificarFechaNacimiento.Color = System.Drawing.Color.LightCoral
        Me.ColoresVerificarFechaNacimiento.Location = New System.Drawing.Point(423, 65)
        Me.ColoresVerificarFechaNacimiento.Name = "ColoresVerificarFechaNacimiento"
        Me.ColoresVerificarFechaNacimiento.Size = New System.Drawing.Size(44, 21)
        Me.ColoresVerificarFechaNacimiento.TabIndex = 7
        Me.ColoresVerificarFechaNacimiento.Text = "LightCoral"
        '
        'ColoresDelDia
        '
        Me.ColoresDelDia.Color = System.Drawing.Color.LightGreen
        Me.ColoresDelDia.Location = New System.Drawing.Point(423, 21)
        Me.ColoresDelDia.Name = "ColoresDelDia"
        Me.ColoresDelDia.Size = New System.Drawing.Size(44, 21)
        Me.ColoresDelDia.TabIndex = 0
        Me.ColoresDelDia.Text = "LightGreen"
        '
        'ColoresFaltanDias
        '
        Me.ColoresFaltanDias.Color = System.Drawing.Color.Khaki
        Me.ColoresFaltanDias.Location = New System.Drawing.Point(423, 43)
        Me.ColoresFaltanDias.Name = "ColoresFaltanDias"
        Me.ColoresFaltanDias.Size = New System.Drawing.Size(44, 21)
        Me.ColoresFaltanDias.TabIndex = 5
        Me.ColoresFaltanDias.Text = "Khaki"
        '
        'agrTituloGrilla
        '
        Me.agrTituloGrilla.Controls.Add(Me.spcOnomastico)
        Me.agrTituloGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTituloGrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTituloGrilla.ForeColor = System.Drawing.Color.Black
        Me.agrTituloGrilla.Location = New System.Drawing.Point(0, 91)
        Me.agrTituloGrilla.Name = "agrTituloGrilla"
        Me.agrTituloGrilla.Size = New System.Drawing.Size(1025, 355)
        Me.agrTituloGrilla.TabIndex = 1
        Me.agrTituloGrilla.Text = "Información del personal"
        Me.agrTituloGrilla.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'spcOnomastico
        '
        Me.spcOnomastico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcOnomastico.Location = New System.Drawing.Point(2, 18)
        Me.spcOnomastico.Name = "spcOnomastico"
        '
        'spcOnomastico.Panel1
        '
        Me.spcOnomastico.Panel1.Controls.Add(Me.Panel2)
        Me.spcOnomastico.Panel1.Controls.Add(Me.Panel1)
        '
        'spcOnomastico.Panel2
        '
        Me.spcOnomastico.Panel2.Controls.Add(Me.PictureBox1)
        Me.spcOnomastico.Size = New System.Drawing.Size(1021, 335)
        Me.spcOnomastico.SplitterDistance = 687
        Me.spcOnomastico.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.griOnomasticos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(671, 335)
        Me.Panel2.TabIndex = 2
        '
        'griOnomasticos
        '
        Me.griOnomasticos.ContextMenuStrip = Me.MenuContextual1
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOnomasticos.DisplayLayout.Appearance = Appearance2
        Me.griOnomasticos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOnomasticos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.griOnomasticos.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOnomasticos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.griOnomasticos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOnomasticos.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.griOnomasticos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOnomasticos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOnomasticos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOnomasticos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOnomasticos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance11.TextHAlignAsString = "Center"
        Me.griOnomasticos.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.griOnomasticos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griOnomasticos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOnomasticos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOnomasticos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griOnomasticos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.griOnomasticos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOnomasticos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOnomasticos.Location = New System.Drawing.Point(0, 0)
        Me.griOnomasticos.Name = "griOnomasticos"
        Me.griOnomasticos.Size = New System.Drawing.Size(671, 335)
        Me.griOnomasticos.TabIndex = 0
        Me.griOnomasticos.Text = "Información de onomásticos del personal"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarArchivoPowerPointDeSaludoToolStripMenuItem, Me.EnviarEmailDeSaludoToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(257, 48)
        '
        'GenerarArchivoPowerPointDeSaludoToolStripMenuItem
        '
        Me.GenerarArchivoPowerPointDeSaludoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.pp7
        Me.GenerarArchivoPowerPointDeSaludoToolStripMenuItem.Name = "GenerarArchivoPowerPointDeSaludoToolStripMenuItem"
        Me.GenerarArchivoPowerPointDeSaludoToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.GenerarArchivoPowerPointDeSaludoToolStripMenuItem.Text = "Generar archivo PowerPoint de saludo"
        '
        'EnviarEmailDeSaludoToolStripMenuItem
        '
        Me.EnviarEmailDeSaludoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.accounting_mail
        Me.EnviarEmailDeSaludoToolStripMenuItem.Name = "EnviarEmailDeSaludoToolStripMenuItem"
        Me.EnviarEmailDeSaludoToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.EnviarEmailDeSaludoToolStripMenuItem.Text = "Enviar Email de saludo"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnMostrarOcultar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(671, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 335)
        Me.Panel1.TabIndex = 1
        '
        'btnMostrarOcultar
        '
        Me.btnMostrarOcultar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMostrarOcultar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnMostrarOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrarOcultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarOcultar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnMostrarOcultar.Location = New System.Drawing.Point(1, 74)
        Me.btnMostrarOcultar.Name = "btnMostrarOcultar"
        Me.btnMostrarOcultar.Size = New System.Drawing.Size(15, 183)
        Me.btnMostrarOcultar.TabIndex = 3
        Me.btnMostrarOcultar.Text = "<>"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Location = New System.Drawing.Point(50, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 270)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje del sistema"
        '
        'chkTexto3D
        '
        Me.chkTexto3D.AutoSize = True
        Me.chkTexto3D.Checked = True
        Me.chkTexto3D.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTexto3D.Location = New System.Drawing.Point(819, 25)
        Me.chkTexto3D.Name = "chkTexto3D"
        Me.chkTexto3D.Size = New System.Drawing.Size(70, 17)
        Me.chkTexto3D.TabIndex = 16
        Me.chkTexto3D.Text = "Texto 3D"
        Me.ToolTip1.SetToolTip(Me.chkTexto3D, "Seleccione si desea que el texto se muestre en formato 3D")
        Me.chkTexto3D.UseVisualStyleBackColor = True
        '
        'frm_Onomasticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1025, 446)
        Me.Controls.Add(Me.agrTituloGrilla)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_Onomasticos"
        Me.Text = "Onomásticos del Personal"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.numDiasAntes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresVerificarFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresDelDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresFaltanDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrTituloGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTituloGrilla.ResumeLayout(False)
        Me.spcOnomastico.Panel1.ResumeLayout(False)
        Me.spcOnomastico.Panel2.ResumeLayout(False)
        Me.spcOnomastico.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.griOnomasticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents agrTituloGrilla As ISL.Controles.Agrupacion
    Friend WithEvents opcPorMes As System.Windows.Forms.RadioButton
    Friend WithEvents opcTodos As System.Windows.Forms.RadioButton
    Friend WithEvents griOnomasticos As ISL.Controles.Grilla
    Friend WithEvents numDiasAntes As ISL.Controles.NumeroEntero
    Friend WithEvents etiEnElDia As ISL.Controles.Etiqueta
    Friend WithEvents ColoresDelDia As ISL.Controles.Colores
    Friend WithEvents ColoresFaltanDias As ISL.Controles.Colores
    Friend WithEvents etiDias As ISL.Controles.Etiqueta
    Friend WithEvents etiProximosDias As ISL.Controles.Etiqueta
    Friend WithEvents etiVerificarFechaNacimiento As ISL.Controles.Etiqueta
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ColoresVerificarFechaNacimiento As ISL.Controles.Colores
    Friend WithEvents spcOnomastico As System.Windows.Forms.SplitContainer
    Friend WithEvents btnMostrarOcultar As ISL.Controles.Boton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents GenerarArchivoPowerPointDeSaludoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarEmailDeSaludoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcDelDia As System.Windows.Forms.RadioButton
    Friend WithEvents Meses1 As ISL.Win.Meses
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents opcFormato1 As System.Windows.Forms.RadioButton
    Friend WithEvents opcFormato2 As System.Windows.Forms.RadioButton
    Friend WithEvents opcFormato3 As System.Windows.Forms.RadioButton
    Friend WithEvents txtSaludo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkTexto3D As System.Windows.Forms.CheckBox

End Class
