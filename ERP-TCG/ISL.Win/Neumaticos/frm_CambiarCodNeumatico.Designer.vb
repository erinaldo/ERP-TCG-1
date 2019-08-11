<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CambiarCodNeumatico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CambiarCodNeumatico))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.gb_AsigConfGraf = New System.Windows.Forms.GroupBox()
        Me.txtCodNuevo = New ISL.Controles.Texto(Me.components)
        Me.txtCodActual = New ISL.Controles.Texto(Me.components)
        Me.lbl_NroLlantasRepuesto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_AsigConfGraf.SuspendLayout()
        CType(Me.txtCodNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.CausesValidation = False
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(241, 96)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 31)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(123, 96)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(112, 31)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'gb_AsigConfGraf
        '
        Me.gb_AsigConfGraf.Controls.Add(Me.txtCodNuevo)
        Me.gb_AsigConfGraf.Controls.Add(Me.txtCodActual)
        Me.gb_AsigConfGraf.Controls.Add(Me.lbl_NroLlantasRepuesto)
        Me.gb_AsigConfGraf.Controls.Add(Me.Label1)
        Me.gb_AsigConfGraf.Location = New System.Drawing.Point(4, 6)
        Me.gb_AsigConfGraf.Name = "gb_AsigConfGraf"
        Me.gb_AsigConfGraf.Size = New System.Drawing.Size(339, 83)
        Me.gb_AsigConfGraf.TabIndex = 0
        Me.gb_AsigConfGraf.TabStop = False
        Me.gb_AsigConfGraf.Text = "Neumatico:"
        '
        'txtCodNuevo
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodNuevo.Appearance = Appearance1
        Me.txtCodNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodNuevo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodNuevo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodNuevo.Location = New System.Drawing.Point(173, 48)
        Me.txtCodNuevo.MaxLength = 8
        Me.txtCodNuevo.Name = "txtCodNuevo"
        Me.txtCodNuevo.Size = New System.Drawing.Size(109, 21)
        Me.txtCodNuevo.TabIndex = 3
        '
        'txtCodActual
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodActual.Appearance = Appearance2
        Me.txtCodActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodActual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodActual.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodActual.Location = New System.Drawing.Point(173, 16)
        Me.txtCodActual.MaxLength = 100
        Me.txtCodActual.Name = "txtCodActual"
        Me.txtCodActual.ReadOnly = True
        Me.txtCodActual.Size = New System.Drawing.Size(109, 21)
        Me.txtCodActual.TabIndex = 1
        '
        'lbl_NroLlantasRepuesto
        '
        Me.lbl_NroLlantasRepuesto.AutoSize = True
        Me.lbl_NroLlantasRepuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroLlantasRepuesto.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_NroLlantasRepuesto.Location = New System.Drawing.Point(53, 48)
        Me.lbl_NroLlantasRepuesto.Name = "lbl_NroLlantasRepuesto"
        Me.lbl_NroLlantasRepuesto.Size = New System.Drawing.Size(100, 15)
        Me.lbl_NroLlantasRepuesto.TabIndex = 2
        Me.lbl_NroLlantasRepuesto.Text = "Nuevo Codigo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(54, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Actual:"
        '
        'frm_CambiarCodNeumatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(347, 134)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.gb_AsigConfGraf)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CambiarCodNeumatico"
        Me.Text = "Cambiar Codigo Neumatico"
        Me.gb_AsigConfGraf.ResumeLayout(False)
        Me.gb_AsigConfGraf.PerformLayout()
        CType(Me.txtCodNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents gb_AsigConfGraf As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_NroLlantasRepuesto As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodNuevo As ISL.Controles.Texto
    Friend WithEvents txtCodActual As ISL.Controles.Texto

End Class
