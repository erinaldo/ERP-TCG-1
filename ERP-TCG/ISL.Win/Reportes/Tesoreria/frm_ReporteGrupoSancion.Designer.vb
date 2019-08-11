<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteGrupoSancion
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
        Me.rptGrupoSancion = New Microsoft.Reporting.WinForms.ReportViewer
        Me.dsDetalleGrupoSancion = New ISL.Win.dsDetalleGrupoSancion
        CType(Me.dsDetalleGrupoSancion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptGrupoSancion
        '
        Me.rptGrupoSancion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptGrupoSancion.LocalReport.ReportEmbeddedResource = "ISL.Win.rptGrupoSancionDetalle.rdlc"
        Me.rptGrupoSancion.Location = New System.Drawing.Point(0, 0)
        Me.rptGrupoSancion.Name = "rptGrupoSancion"
        Me.rptGrupoSancion.Size = New System.Drawing.Size(602, 380)
        Me.rptGrupoSancion.TabIndex = 0
        '
        'dsDetalleGrupoSancion
        '
        Me.dsDetalleGrupoSancion.DataSetName = "dsDetalleGrupoSancion"
        Me.dsDetalleGrupoSancion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frm_ReporteGrupoSancion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 380)
        Me.Controls.Add(Me.rptGrupoSancion)
        Me.Name = "frm_ReporteGrupoSancion"
        Me.Text = "Detalle de Grupo Sanciones"
        CType(Me.dsDetalleGrupoSancion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptGrupoSancion As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dsDetalleGrupoSancion As ISL.Win.dsDetalleGrupoSancion
End Class
