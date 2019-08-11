<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrabajadorDisponible
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
        Me.lblDisponible = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblDisponible
        '
        Me.lblDisponible.AutoSize = True
        Me.lblDisponible.BackColor = System.Drawing.Color.GreenYellow
        Me.lblDisponible.Location = New System.Drawing.Point(4, 4)
        Me.lblDisponible.Name = "lblDisponible"
        Me.lblDisponible.Size = New System.Drawing.Size(110, 13)
        Me.lblDisponible.TabIndex = 0
        Me.lblDisponible.Text = "Trabajador Disponible"
        '
        'TrabajadorDisponible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.lblDisponible)
        Me.Name = "TrabajadorDisponible"
        Me.Size = New System.Drawing.Size(117, 17)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisponible As System.Windows.Forms.Label

End Class
