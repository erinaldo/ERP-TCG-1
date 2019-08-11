<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteInformeDetrac
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.rptDetalleInforme = New Microsoft.Reporting.WinForms.ReportViewer
        Me.dsInformeDetracDet = New ISL.Win.dsInformeDetracDet
        Me.DetalleInformeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsInformeDetracDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleInformeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptDetalleInforme
        '
        Me.rptDetalleInforme.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsInformeDetracDet_DetalleInforme"
        ReportDataSource1.Value = Me.DetalleInformeBindingSource
        Me.rptDetalleInforme.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptDetalleInforme.LocalReport.ReportEmbeddedResource = "ISL.Win.rptInformeDetrac.rdlc"
        Me.rptDetalleInforme.Location = New System.Drawing.Point(0, 0)
        Me.rptDetalleInforme.Name = "rptDetalleInforme"
        Me.rptDetalleInforme.Size = New System.Drawing.Size(698, 457)
        Me.rptDetalleInforme.TabIndex = 0
        '
        'dsInformeDetracDet
        '
        Me.dsInformeDetracDet.DataSetName = "dsInformeDetracDet"
        Me.dsInformeDetracDet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleInformeBindingSource
        '
        Me.DetalleInformeBindingSource.DataMember = "DetalleInforme"
        Me.DetalleInformeBindingSource.DataSource = Me.dsInformeDetracDet
        '
        'frm_ReporteInformeDetrac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 457)
        Me.Controls.Add(Me.rptDetalleInforme)
        Me.Name = "frm_ReporteInformeDetrac"
        Me.Text = "Reporte de Informe de Detraccion"
        CType(Me.dsInformeDetracDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleInformeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptDetalleInforme As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DetalleInformeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsInformeDetracDet As ISL.Win.dsInformeDetracDet
End Class
