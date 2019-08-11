<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ubigeo
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
        Me.Departamento1 = New ISL.Win.Departamento()
        Me.Provincia1 = New ISL.Win.Provincia()
        Me.Distrito1 = New ISL.Win.Distrito()
        Me.SuspendLayout()
        '
        'Departamento1
        '
        Me.Departamento1.BackColor = System.Drawing.Color.Transparent
        Me.Departamento1.Codigo = Nothing
        Me.Departamento1.Id = Nothing
        Me.Departamento1.Location = New System.Drawing.Point(2, 3)
        Me.Departamento1.Name = "Departamento1"
        Me.Departamento1.Nombre = Nothing
        Me.Departamento1.Size = New System.Drawing.Size(357, 24)
        Me.Departamento1.TabIndex = 0
        '
        'Provincia1
        '
        Me.Provincia1.BackColor = System.Drawing.Color.Transparent
        Me.Provincia1.Codigo = Nothing
        Me.Provincia1.CodigoDepartamento = Nothing
        Me.Provincia1.Id = Nothing
        Me.Provincia1.Location = New System.Drawing.Point(25, 27)
        Me.Provincia1.Name = "Provincia1"
        Me.Provincia1.Nombre = Nothing
        Me.Provincia1.Size = New System.Drawing.Size(335, 32)
        Me.Provincia1.TabIndex = 1
        '
        'Distrito1
        '
        Me.Distrito1.BackColor = System.Drawing.Color.Transparent
        Me.Distrito1.Codigo = Nothing
        Me.Distrito1.CodigoDepartamento = Nothing
        Me.Distrito1.CodigoProvincia = Nothing
        Me.Distrito1.ForeColor = System.Drawing.Color.Navy
        Me.Distrito1.Id = Nothing
        Me.Distrito1.Location = New System.Drawing.Point(34, 54)
        Me.Distrito1.Name = "Distrito1"
        Me.Distrito1.Nombre = Nothing
        Me.Distrito1.Size = New System.Drawing.Size(323, 24)
        Me.Distrito1.TabIndex = 2
        '
        'Ubigeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Distrito1)
        Me.Controls.Add(Me.Provincia1)
        Me.Controls.Add(Me.Departamento1)
        Me.Name = "Ubigeo"
        Me.Size = New System.Drawing.Size(355, 82)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Departamento1 As ISL.Win.Departamento
    Friend WithEvents Provincia1 As ISL.Win.Provincia
    Friend WithEvents Distrito1 As ISL.Win.Distrito

End Class
