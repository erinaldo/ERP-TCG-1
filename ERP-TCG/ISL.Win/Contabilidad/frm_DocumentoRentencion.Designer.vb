<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DocumentoRentencion
    Inherits Win.frm_MenuPadre

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.dtImprimirRetencionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsImprimirRetencion = New ISL.Win.dsImprimirRetencion
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrCentroCosto = New ISL.Controles.Agrupacion(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ficCentroCosto = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        CType(Me.dtImprimirRetencionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsImprimirRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrCentroCosto.SuspendLayout()
        Me.utpDetalle.SuspendLayout()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ficCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCentroCosto.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtImprimirRetencionBindingSource
        '
        Me.dtImprimirRetencionBindingSource.DataMember = "dtImprimirRetencion"
        Me.dtImprimirRetencionBindingSource.DataSource = Me.dsImprimirRetencion
        '
        'dsImprimirRetencion
        '
        Me.dsImprimirRetencion.DataSetName = "dsImprimirRetencion"
        Me.dsImprimirRetencion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrCentroCosto)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(908, 523)
        '
        'agrCentroCosto
        '
        Me.agrCentroCosto.Controls.Add(Me.ReportViewer1)
        Me.agrCentroCosto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCentroCosto.ForeColor = System.Drawing.Color.Black
        Me.agrCentroCosto.Location = New System.Drawing.Point(0, 0)
        Me.agrCentroCosto.Name = "agrCentroCosto"
        Me.agrCentroCosto.Size = New System.Drawing.Size(908, 523)
        Me.agrCentroCosto.TabIndex = 2
        Me.agrCentroCosto.Text = "PROVEEDOR:"
        Me.agrCentroCosto.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsImprimirRetencion_dtImprimirRetencion"
        ReportDataSource1.Value = Me.dtImprimirRetencionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ISL.Win.ImprimirRetencion.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 18)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(904, 503)
        Me.ReportViewer1.TabIndex = 0
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(908, 523)
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.ReportViewer2)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(908, 523)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "SUNAT"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "dsImprimirRetencion_dtImprimirRetencion"
        ReportDataSource2.Value = Me.dtImprimirRetencionBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "ISL.Win.ImprimirRetencion.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(2, 18)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(904, 503)
        Me.ReportViewer2.TabIndex = 0
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(908, 523)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.ReportViewer3)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(908, 523)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "EMISOR"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "dsImprimirRetencion_dtImprimirRetencion"
        ReportDataSource3.Value = Me.dtImprimirRetencionBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "ISL.Win.ImprimirRetencion.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(2, 18)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(904, 503)
        Me.ReportViewer3.TabIndex = 0
        '
        'ficCentroCosto
        '
        Me.ficCentroCosto.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficCentroCosto.Controls.Add(Me.UltraTabPageControl7)
        Me.ficCentroCosto.Controls.Add(Me.utpDetalle)
        Me.ficCentroCosto.Controls.Add(Me.UltraTabPageControl1)
        Me.ficCentroCosto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCentroCosto.Location = New System.Drawing.Point(0, 0)
        Me.ficCentroCosto.Name = "ficCentroCosto"
        Me.ficCentroCosto.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficCentroCosto.Size = New System.Drawing.Size(910, 546)
        Me.ficCentroCosto.TabIndex = 4
        UltraTab1.Key = "PROVEEDOR"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "PROVEEDOR"
        UltraTab2.Key = "SUNAT"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "SUNAT"
        UltraTab3.Key = "EMISOR"
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "EMISOR"
        Me.ficCentroCosto.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficCentroCosto.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(908, 523)
        '
        'frm_DocumentoRentencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(910, 546)
        Me.Controls.Add(Me.ficCentroCosto)
        Me.Name = "frm_DocumentoRentencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documento Rentencion"
        CType(Me.dtImprimirRetencionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsImprimirRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrCentroCosto.ResumeLayout(False)
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.ficCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCentroCosto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtImprimirRetencionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsImprimirRetencion As ISL.Win.dsImprimirRetencion
    Friend WithEvents ficCentroCosto As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrCentroCosto As ISL.Controles.Agrupacion
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer

End Class
