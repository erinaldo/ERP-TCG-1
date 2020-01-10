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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.e_MovimientoDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.e_DetalleDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.e_MovimientoDocumento_ImpresionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_MovimientoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_DetalleDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_MovimientoDocumento_ImpresionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DocumentoCtble"
        ReportDataSource1.Value = Me.e_MovimientoDocumentoBindingSource
        ReportDataSource2.Name = "DocumentoCtble_Detalle"
        ReportDataSource2.Value = Me.e_DetalleDocumentoBindingSource
        ReportDataSource3.Name = "DocumentoCtble_Impresion"
        ReportDataSource3.Value = Me.e_MovimientoDocumento_ImpresionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ISL.Win.rpt_DocumentoCtble_Termica.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1152, 450)
        Me.ReportViewer1.TabIndex = 2
        '
        'e_MovimientoDocumentoBindingSource
        '
        Me.e_MovimientoDocumentoBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_MovimientoDocumento)
        '
        'e_DetalleDocumentoBindingSource
        '
        Me.e_DetalleDocumentoBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_DetalleDocumento)
        '
        'e_MovimientoDocumento_ImpresionBindingSource
        '
        Me.e_MovimientoDocumento_ImpresionBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_MovimientoDocumento_Impresion)
        '
        'frm_DocumentoCtble_Imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_DocumentoCtble_Imprimir"
        Me.Text = "frm_DocumentoCtble_Imprimir"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_MovimientoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_DetalleDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_MovimientoDocumento_ImpresionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents BindingSource3 As BindingSource
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents e_MovimientoDocumentoBindingSource As BindingSource
    Friend WithEvents e_DetalleDocumentoBindingSource As BindingSource
    Friend WithEvents e_MovimientoDocumento_ImpresionBindingSource As BindingSource
End Class
