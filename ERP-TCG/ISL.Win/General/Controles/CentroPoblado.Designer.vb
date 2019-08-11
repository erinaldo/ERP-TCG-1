<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CentroPoblado
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
        Me.components = New System.ComponentModel.Container
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.cboCentroPoblado = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.cboCentroPoblado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCentroPoblado
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboCentroPoblado.Appearance = Appearance2
        Me.cboCentroPoblado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentroPoblado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroPoblado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroPoblado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroPoblado.ForeColor = System.Drawing.Color.Black
        Me.cboCentroPoblado.Location = New System.Drawing.Point(88, 3)
        Me.cboCentroPoblado.Name = "cboCentroPoblado"
        Me.cboCentroPoblado.Size = New System.Drawing.Size(266, 21)
        Me.cboCentroPoblado.TabIndex = 0
        Me.cboCentroPoblado.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(8, 8)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(79, 14)
        Me.Etiqueta1.TabIndex = 5
        Me.Etiqueta1.Text = "Centro poblado"
        '
        'CentroPoblado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Etiqueta1)
        Me.Controls.Add(Me.cboCentroPoblado)
        Me.Name = "CentroPoblado"
        Me.Size = New System.Drawing.Size(362, 25)
        CType(Me.cboCentroPoblado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCentroPoblado As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta

End Class
