<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_DocumentoCtble_Imprimir
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BSO1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSO2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISOR = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.BSO1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSO2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VISOR
        '
        Me.VISOR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VISOR.LocalReport.ReportEmbeddedResource = "ISL.Win.rpt_DocumentoCtble_Termica.rdlc"
        Me.VISOR.Location = New System.Drawing.Point(0, 0)
        Me.VISOR.Name = "VISOR"
        Me.VISOR.Size = New System.Drawing.Size(984, 661)
        Me.VISOR.TabIndex = 2
        Me.VISOR.ZoomPercent = 90
        '
        'frm_DocumentoCtble_Imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.VISOR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_DocumentoCtble_Imprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_DocumentoCtble_Imprimir"
        CType(Me.BSO1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSO2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BSO1 As BindingSource
    Friend WithEvents BSO2 As BindingSource
    Friend WithEvents VISOR As Microsoft.Reporting.WinForms.ReportViewer
End Class
