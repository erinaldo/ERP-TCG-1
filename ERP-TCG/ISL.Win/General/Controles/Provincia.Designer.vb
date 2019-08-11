<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Provincia
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
        Me.cboProvincia = New ISL.Controles.ComboMaestros(Me.components)
        Me.etiProvincia = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.cboProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboProvincia
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboProvincia.Appearance = Appearance1
        Me.cboProvincia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProvincia.DisplayMember = "Nombre"
        Me.cboProvincia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboProvincia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProvincia.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.ForeColor = System.Drawing.Color.Black
        Me.cboProvincia.Location = New System.Drawing.Point(60, 3)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(266, 22)
        Me.cboProvincia.TabIndex = 0
        Me.cboProvincia.ValueMember = "Id"
        '
        'etiProvincia
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.etiProvincia.Appearance = Appearance2
        Me.etiProvincia.AutoSize = True
        Me.etiProvincia.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiProvincia.ForeColor = System.Drawing.Color.Black
        Me.etiProvincia.Location = New System.Drawing.Point(3, 7)
        Me.etiProvincia.Name = "etiProvincia"
        Me.etiProvincia.Size = New System.Drawing.Size(51, 15)
        Me.etiProvincia.TabIndex = 1
        Me.etiProvincia.Text = "Provincia:"
        '
        'Provincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.etiProvincia)
        Me.Controls.Add(Me.cboProvincia)
        Me.Name = "Provincia"
        Me.Size = New System.Drawing.Size(330, 28)
        CType(Me.cboProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboProvincia As ISL.Controles.ComboMaestros
    Friend WithEvents etiProvincia As ISL.Controles.Etiqueta

End Class
