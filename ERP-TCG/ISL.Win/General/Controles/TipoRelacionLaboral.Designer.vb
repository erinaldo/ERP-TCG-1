<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoRelacionLaboral
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.cboTipoRelacionLaboral = New ISL.Controles.ComboMaestros(Me.components)
        Me.etiTipoRelacionLaboral = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.cboTipoRelacionLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTipoRelacionLaboral
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboTipoRelacionLaboral.Appearance = Appearance1
        Me.cboTipoRelacionLaboral.DisplayMember = "Nombre"
        Me.cboTipoRelacionLaboral.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoRelacionLaboral.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoRelacionLaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoRelacionLaboral.ForeColor = System.Drawing.Color.Black
        Me.cboTipoRelacionLaboral.Location = New System.Drawing.Point(129, 3)
        Me.cboTipoRelacionLaboral.Name = "cboTipoRelacionLaboral"
        Me.cboTipoRelacionLaboral.Size = New System.Drawing.Size(264, 21)
        Me.cboTipoRelacionLaboral.TabIndex = 3
        Me.cboTipoRelacionLaboral.ValueMember = "Id"
        '
        'etiTipoRelacionLaboral
        '
        Me.etiTipoRelacionLaboral.AutoSize = True
        Me.etiTipoRelacionLaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTipoRelacionLaboral.ForeColor = System.Drawing.Color.Black
        Me.etiTipoRelacionLaboral.Location = New System.Drawing.Point(10, 7)
        Me.etiTipoRelacionLaboral.Name = "etiTipoRelacionLaboral"
        Me.etiTipoRelacionLaboral.Size = New System.Drawing.Size(110, 14)
        Me.etiTipoRelacionLaboral.TabIndex = 2
        Me.etiTipoRelacionLaboral.Text = "Tipo Relación laboral:"
        '
        'TipoRelacionLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboTipoRelacionLaboral)
        Me.Controls.Add(Me.etiTipoRelacionLaboral)
        Me.Name = "TipoRelacionLaboral"
        Me.Size = New System.Drawing.Size(397, 27)
        CType(Me.cboTipoRelacionLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTipoRelacionLaboral As ISL.Controles.ComboMaestros
    Friend WithEvents etiTipoRelacionLaboral As ISL.Controles.Etiqueta

End Class
