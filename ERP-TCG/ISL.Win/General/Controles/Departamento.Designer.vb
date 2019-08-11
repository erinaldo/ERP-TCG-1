<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Departamento
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
        Me.cboDepartamento = New ISL.Controles.ComboMaestros(Me.components)
        Me.etiDepartamento = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.cboDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDepartamento
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboDepartamento.Appearance = Appearance1
        Me.cboDepartamento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboDepartamento.DisplayMember = "Nombre"
        Me.cboDepartamento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboDepartamento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDepartamento.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartamento.ForeColor = System.Drawing.Color.Black
        Me.cboDepartamento.Location = New System.Drawing.Point(83, 1)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(266, 22)
        Me.cboDepartamento.TabIndex = 0
        Me.cboDepartamento.ValueMember = "Id"
        '
        'etiDepartamento
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.etiDepartamento.Appearance = Appearance2
        Me.etiDepartamento.AutoSize = True
        Me.etiDepartamento.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDepartamento.ForeColor = System.Drawing.Color.Black
        Me.etiDepartamento.Location = New System.Drawing.Point(3, 5)
        Me.etiDepartamento.Name = "etiDepartamento"
        Me.etiDepartamento.Size = New System.Drawing.Size(77, 15)
        Me.etiDepartamento.TabIndex = 1
        Me.etiDepartamento.Text = "Departamento:"
        '
        'Departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.etiDepartamento)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Name = "Departamento"
        Me.Size = New System.Drawing.Size(350, 24)
        CType(Me.cboDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDepartamento As ISL.Controles.ComboMaestros
    Friend WithEvents etiDepartamento As ISL.Controles.Etiqueta

End Class
