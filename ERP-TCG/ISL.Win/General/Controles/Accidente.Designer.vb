<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accidente
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
        Me.cboTipoAccidente = New ISL.Controles.ComboMaestros(Me.components)
        Me.etiTipoAccidente = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.cboTipoAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTipoAccidente
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboTipoAccidente.Appearance = Appearance1
        Me.cboTipoAccidente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoAccidente.DisplayMember = "Nombre"
        Me.cboTipoAccidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoAccidente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoAccidente.ForeColor = System.Drawing.Color.Black
        Me.cboTipoAccidente.Location = New System.Drawing.Point(101, 3)
        Me.cboTipoAccidente.Name = "cboTipoAccidente"
        Me.cboTipoAccidente.Size = New System.Drawing.Size(208, 21)
        Me.cboTipoAccidente.TabIndex = 0
        Me.cboTipoAccidente.ValueMember = "Id"
        '
        'etiTipoAccidente
        '
        Me.etiTipoAccidente.AutoSize = True
        Me.etiTipoAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTipoAccidente.ForeColor = System.Drawing.Color.Black
        Me.etiTipoAccidente.Location = New System.Drawing.Point(4, 6)
        Me.etiTipoAccidente.Name = "etiTipoAccidente"
        Me.etiTipoAccidente.Size = New System.Drawing.Size(91, 14)
        Me.etiTipoAccidente.TabIndex = 1
        Me.etiTipoAccidente.Text = "Tipo de accidente"
        '
        'Accidente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.etiTipoAccidente)
        Me.Controls.Add(Me.cboTipoAccidente)
        Me.Name = "Accidente"
        Me.Size = New System.Drawing.Size(314, 27)
        CType(Me.cboTipoAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTipoAccidente As ISL.Controles.ComboMaestros
    Friend WithEvents etiTipoAccidente As ISL.Controles.Etiqueta

End Class
