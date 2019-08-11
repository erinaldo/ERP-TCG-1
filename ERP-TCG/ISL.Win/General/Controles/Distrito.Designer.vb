<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Distrito
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
        Me.etiDistrito = New ISL.Controles.Etiqueta(Me.components)
        Me.cboDistrito = New ISL.Controles.ComboMaestros(Me.components)
        CType(Me.cboDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'etiDistrito
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.etiDistrito.Appearance = Appearance1
        Me.etiDistrito.AutoSize = True
        Me.etiDistrito.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDistrito.ForeColor = System.Drawing.Color.Black
        Me.etiDistrito.Location = New System.Drawing.Point(4, 5)
        Me.etiDistrito.Name = "etiDistrito"
        Me.etiDistrito.Size = New System.Drawing.Size(43, 15)
        Me.etiDistrito.TabIndex = 3
        Me.etiDistrito.Text = "Distrito:"
        '
        'cboDistrito
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboDistrito.Appearance = Appearance2
        Me.cboDistrito.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboDistrito.DisplayMember = "Nombre"
        Me.cboDistrito.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboDistrito.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDistrito.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrito.ForeColor = System.Drawing.Color.Black
        Me.cboDistrito.Location = New System.Drawing.Point(51, 2)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(266, 22)
        Me.cboDistrito.TabIndex = 2
        Me.cboDistrito.ValueMember = "Id"
        '
        'Distrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.etiDistrito)
        Me.Controls.Add(Me.cboDistrito)
        Me.Name = "Distrito"
        Me.Size = New System.Drawing.Size(320, 26)
        CType(Me.cboDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents etiDistrito As ISL.Controles.Etiqueta
    Friend WithEvents cboDistrito As ISL.Controles.ComboMaestros

End Class
