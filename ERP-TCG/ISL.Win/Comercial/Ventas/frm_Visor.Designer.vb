<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Visor
    Inherits System.Windows.Forms.Form

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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.upbImagen = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.SuspendLayout()
        '
        'upbImagen
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Me.upbImagen.Appearance = Appearance3
        Me.upbImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.upbImagen.BorderShadowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.upbImagen.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.upbImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.upbImagen.ImageTransparentColor = System.Drawing.Color.White
        Me.upbImagen.Location = New System.Drawing.Point(0, 0)
        Me.upbImagen.Name = "upbImagen"
        Me.upbImagen.Size = New System.Drawing.Size(675, 519)
        Me.upbImagen.TabIndex = 380
        '
        'frm_Visor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 519)
        Me.Controls.Add(Me.upbImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_Visor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Documento"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents upbImagen As Infragistics.Win.UltraWinEditors.UltraPictureBox

End Class
