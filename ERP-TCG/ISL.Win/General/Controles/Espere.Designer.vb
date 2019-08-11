<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Espere
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
        Me.ugb_Espera = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ugb_Espera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Espera.SuspendLayout()
        Me.SuspendLayout()
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Controls.Add(Me.Button1)
        Me.ugb_Espera.Controls.Add(Me.Label1)
        Me.ugb_Espera.Controls.Add(Me.Label2)
        Me.ugb_Espera.Location = New System.Drawing.Point(3, 3)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(387, 62)
        Me.ugb_Espera.TabIndex = 401
        Me.ugb_Espera.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.ISL.Win.My.Resources.Resources.wait
        Me.Button1.Location = New System.Drawing.Point(7, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 49)
        Me.Button1.TabIndex = 394
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(76, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 16)
        Me.Label1.TabIndex = 393
        Me.Label1.Text = "El sistema está procesando la información."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(110, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 16)
        Me.Label2.TabIndex = 393
        Me.Label2.Text = "Espere un momento por favor"
        '
        'Espere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ugb_Espera)
        Me.Name = "Espere"
        Me.Size = New System.Drawing.Size(393, 67)
        CType(Me.ugb_Espera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Espera.ResumeLayout(False)
        Me.ugb_Espera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ugb_Espera As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
