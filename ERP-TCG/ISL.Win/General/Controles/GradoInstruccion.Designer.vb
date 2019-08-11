<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradoInstruccion
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.cboGradoInstruccion = New ISL.Controles.ComboMaestros(Me.components)
        Me.etiGradoInstruccion = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.cboGradoInstruccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboGradoInstruccion
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboGradoInstruccion.Appearance = Appearance1
        Me.cboGradoInstruccion.DisplayMember = "Nombre"
        Me.cboGradoInstruccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGradoInstruccion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboGradoInstruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGradoInstruccion.ForeColor = System.Drawing.Color.Black
        Me.cboGradoInstruccion.Location = New System.Drawing.Point(118, 3)
        Me.cboGradoInstruccion.Name = "cboGradoInstruccion"
        Me.cboGradoInstruccion.Size = New System.Drawing.Size(384, 21)
        Me.cboGradoInstruccion.TabIndex = 3
        Me.cboGradoInstruccion.ValueMember = "Id"
        '
        'etiGradoInstruccion
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.etiGradoInstruccion.Appearance = Appearance2
        Me.etiGradoInstruccion.AutoSize = True
        Me.etiGradoInstruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGradoInstruccion.ForeColor = System.Drawing.Color.Black
        Me.etiGradoInstruccion.Location = New System.Drawing.Point(6, 7)
        Me.etiGradoInstruccion.Name = "etiGradoInstruccion"
        Me.etiGradoInstruccion.Size = New System.Drawing.Size(106, 14)
        Me.etiGradoInstruccion.TabIndex = 2
        Me.etiGradoInstruccion.Text = "Grado de Instrucción"
        '
        'GradoInstruccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboGradoInstruccion)
        Me.Controls.Add(Me.etiGradoInstruccion)
        Me.Name = "GradoInstruccion"
        Me.Size = New System.Drawing.Size(505, 28)
        CType(Me.cboGradoInstruccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboGradoInstruccion As ISL.Controles.ComboMaestros
    Friend WithEvents etiGradoInstruccion As ISL.Controles.Etiqueta

End Class
