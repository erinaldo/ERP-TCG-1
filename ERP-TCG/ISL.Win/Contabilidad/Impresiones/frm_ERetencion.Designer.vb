<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ERetencion
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
        Me.svcReporte = New Stimulsoft.Report.Viewer.StiViewerControl()
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
        Me.svcReporte.Size = New System.Drawing.Size(827, 372)
        Me.svcReporte.TabIndex = 0
        '
        'frm_ERetencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 372)
        Me.Controls.Add(Me.svcReporte)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ERetencion"
        Me.Text = "frm_ERetencion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents svcReporte As Stimulsoft.Report.Viewer.StiViewerControl
End Class
