<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sexo
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.etiSexo = New ISL.Controles.Etiqueta(Me.components)
        Me.opcMasculino = New System.Windows.Forms.RadioButton()
        Me.opcFemenino = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'etiSexo
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.etiSexo.Appearance = Appearance1
        Me.etiSexo.AutoSize = True
        Me.etiSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSexo.ForeColor = System.Drawing.Color.Black
        Me.etiSexo.Location = New System.Drawing.Point(4, 4)
        Me.etiSexo.Name = "etiSexo"
        Me.etiSexo.Size = New System.Drawing.Size(29, 14)
        Me.etiSexo.TabIndex = 1
        Me.etiSexo.Text = "Sexo"
        '
        'opcMasculino
        '
        Me.opcMasculino.AutoSize = True
        Me.opcMasculino.Checked = True
        Me.opcMasculino.Location = New System.Drawing.Point(52, 4)
        Me.opcMasculino.Name = "opcMasculino"
        Me.opcMasculino.Size = New System.Drawing.Size(73, 17)
        Me.opcMasculino.TabIndex = 3
        Me.opcMasculino.TabStop = True
        Me.opcMasculino.Text = "Masculino"
        Me.opcMasculino.UseVisualStyleBackColor = True
        '
        'opcFemenino
        '
        Me.opcFemenino.AutoSize = True
        Me.opcFemenino.Location = New System.Drawing.Point(131, 3)
        Me.opcFemenino.Name = "opcFemenino"
        Me.opcFemenino.Size = New System.Drawing.Size(71, 17)
        Me.opcFemenino.TabIndex = 4
        Me.opcFemenino.Text = "Femenino"
        Me.opcFemenino.UseVisualStyleBackColor = True
        '
        'Sexo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.opcFemenino)
        Me.Controls.Add(Me.opcMasculino)
        Me.Controls.Add(Me.etiSexo)
        Me.Name = "Sexo"
        Me.Size = New System.Drawing.Size(204, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents etiSexo As ISL.Controles.Etiqueta
    Friend WithEvents opcMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents opcFemenino As System.Windows.Forms.RadioButton

End Class
