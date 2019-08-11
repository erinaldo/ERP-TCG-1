<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rptNotaCredito
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
        Me.rvNotaCredito = New Microsoft.Reporting.WinForms.ReportViewer
        Me.dsDetalleDoc = New ISL.Win.dsDetalleDoc
        Me.dtDetalleDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsDetalleDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDetalleDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvNotaCredito
        '
        Me.rvNotaCredito.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsDetalleDoc_dtDetalleDoc"
        ReportDataSource1.Value = Me.dtDetalleDocBindingSource
        Me.rvNotaCredito.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvNotaCredito.LocalReport.ReportEmbeddedResource = "ISL.Win.rptNotaCredito.rdlc"
        Me.rvNotaCredito.Location = New System.Drawing.Point(0, 0)
        Me.rvNotaCredito.Name = "rvNotaCredito"
        Me.rvNotaCredito.Size = New System.Drawing.Size(760, 535)
        Me.rvNotaCredito.TabIndex = 0
        '
        'dsDetalleDoc
        '
        Me.dsDetalleDoc.DataSetName = "dsDetalleDoc"
        Me.dsDetalleDoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtDetalleDocBindingSource
        '
        Me.dtDetalleDocBindingSource.DataMember = "dtDetalleDoc"
        Me.dtDetalleDocBindingSource.DataSource = Me.dsDetalleDoc
        '
        'frm_NotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 535)
        Me.Controls.Add(Me.rvNotaCredito)
        Me.Name = "frm_NotaCredito"
        Me.Text = "frm_NotaCredito"
        CType(Me.dsDetalleDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDetalleDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvNotaCredito As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtDetalleDocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsDetalleDoc As ISL.Win.dsDetalleDoc
End Class
