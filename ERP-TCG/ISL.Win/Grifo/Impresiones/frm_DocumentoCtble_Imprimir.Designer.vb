<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DocumentoCtble_Imprimir
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
        Me.components = New System.ComponentModel.Container()
        Me.svcReporte = New Stimulsoft.Report.Viewer.StiViewerControl()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'svcReporte
        '
        Me.svcReporte.AllowDrop = True
        Me.svcReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.svcReporte.Location = New System.Drawing.Point(0, 0)
        Me.svcReporte.Name = "svcReporte"
        Me.svcReporte.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.Continuous
        Me.svcReporte.Report = Nothing
        Me.svcReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.svcReporte.ShowZoom = True
        Me.svcReporte.Size = New System.Drawing.Size(1152, 450)
        Me.svcReporte.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(583, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 2
        '
        'frm_DocumentoCtble_Imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.svcReporte)
        Me.Name = "frm_DocumentoCtble_Imprimir"
        Me.Text = "frm_DocumentoCtble_Imprimir"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents svcReporte As Stimulsoft.Report.Viewer.StiViewerControl
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents BindingSource3 As BindingSource
End Class
