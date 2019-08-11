<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ImprimeCobroPagoAnticipo
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
        Me.CobroPagoAnticipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsAnticipoCobroPago = New ISL.Win.dsAnticipoCobroPago()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.CobroPagoAnticipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsAnticipoCobroPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CobroPagoAnticipoBindingSource
        '
        Me.CobroPagoAnticipoBindingSource.DataMember = "CobroPagoAnticipo"
        Me.CobroPagoAnticipoBindingSource.DataSource = Me.dsAnticipoCobroPago
        '
        'dsAnticipoCobroPago
        '
        Me.dsAnticipoCobroPago.DataSetName = "dsAnticipoCobroPago"
        Me.dsAnticipoCobroPago.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsAnticipoCobroPago_CobroPagoAnticipo"
        ReportDataSource1.Value = Me.CobroPagoAnticipoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ISL.Win.CobroPagoAnticipo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(949, 548)
        Me.ReportViewer1.TabIndex = 0
        '
        'frm_ImprimeCobroPagoAnticipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 548)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_ImprimeCobroPagoAnticipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir"
        CType(Me.CobroPagoAnticipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsAnticipoCobroPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CobroPagoAnticipoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsAnticipoCobroPago As ISL.Win.dsAnticipoCobroPago
End Class
