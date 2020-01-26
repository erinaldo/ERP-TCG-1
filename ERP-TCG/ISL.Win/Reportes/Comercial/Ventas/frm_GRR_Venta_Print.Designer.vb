<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GRR_Venta_Print
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.rv_Grr_Venta = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rv_Grr_Venta
        '
        Me.rv_Grr_Venta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_Grr_Venta.Location = New System.Drawing.Point(0, 0)
        Me.rv_Grr_Venta.Name = "rv_Grr_Venta"
        Me.rv_Grr_Venta.ShowParameterPrompts = False
        Me.rv_Grr_Venta.Size = New System.Drawing.Size(800, 450)
        Me.rv_Grr_Venta.TabIndex = 0
        '
        'frm_GRR_Venta_Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rv_Grr_Venta)
        Me.Name = "frm_GRR_Venta_Print"
        Me.Text = "frm_GRR_Venta_Print"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rv_Grr_Venta As Microsoft.Reporting.WinForms.ReportViewer
End Class
