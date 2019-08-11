<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoDocumento
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
        Me.cboTipoDocumento = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumento.Location = New System.Drawing.Point(108, 1)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(343, 21)
        Me.cboTipoDocumento.TabIndex = 0
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(4, 4)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(98, 14)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Tipo de documento"
        '
        'TipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Etiqueta1)
        Me.Controls.Add(Me.cboTipoDocumento)
        Me.Name = "TipoDocumento"
        Me.Size = New System.Drawing.Size(457, 26)
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTipoDocumento As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta

End Class
