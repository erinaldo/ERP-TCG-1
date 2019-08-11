<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadoCivil
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
        Me.etiEstadoCivil = New ISL.Controles.Etiqueta(Me.components)
        Me.cboEstadoCivil = New ISL.Controles.ComboMaestros(Me.components)
        CType(Me.cboEstadoCivil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'etiEstadoCivil
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.etiEstadoCivil.Appearance = Appearance1
        Me.etiEstadoCivil.AutoSize = True
        Me.etiEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEstadoCivil.ForeColor = System.Drawing.Color.Black
        Me.etiEstadoCivil.Location = New System.Drawing.Point(3, 8)
        Me.etiEstadoCivil.Name = "etiEstadoCivil"
        Me.etiEstadoCivil.Size = New System.Drawing.Size(59, 14)
        Me.etiEstadoCivil.TabIndex = 0
        Me.etiEstadoCivil.Text = "EstadoCivil"
        '
        'cboEstadoCivil
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoCivil.Appearance = Appearance2
        Me.cboEstadoCivil.DisplayMember = "Nombre"
        Me.cboEstadoCivil.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoCivil.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoCivil.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoCivil.Location = New System.Drawing.Point(70, 4)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(144, 21)
        Me.cboEstadoCivil.TabIndex = 1
        Me.cboEstadoCivil.ValueMember = "Id"
        '
        'EstadoCivil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboEstadoCivil)
        Me.Controls.Add(Me.etiEstadoCivil)
        Me.Name = "EstadoCivil"
        Me.Size = New System.Drawing.Size(219, 31)
        CType(Me.cboEstadoCivil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents etiEstadoCivil As ISL.Controles.Etiqueta
    Friend WithEvents cboEstadoCivil As ISL.Controles.ComboMaestros

End Class
