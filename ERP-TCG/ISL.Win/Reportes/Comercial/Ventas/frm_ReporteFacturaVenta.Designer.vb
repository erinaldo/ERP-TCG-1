<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteFacturaVenta
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.FacturaVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsFacturaVenta = New ISL.Win.dsFacturaVenta()
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.rptFacturaVenta = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griComplemento = New ISL.Controles.Grilla(Me.components)
        Me.mnuComplemento = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ficFactura = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.VistaPreviaPrint = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.GrillaPrint = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        CType(Me.FacturaVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griComplemento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuComplemento.SuspendLayout()
        CType(Me.ficFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficFactura.SuspendLayout()
        Me.SuspendLayout()
        '
        'FacturaVentaBindingSource
        '
        Me.FacturaVentaBindingSource.DataMember = "FacturaVenta"
        Me.FacturaVentaBindingSource.DataSource = Me.dsFacturaVenta
        '
        'dsFacturaVenta
        '
        Me.dsFacturaVenta.DataSetName = "dsFacturaVenta"
        Me.dsFacturaVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataMember = "DetalleFactura"
        Me.DetalleFacturaBindingSource.DataSource = Me.dsFacturaVenta
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.rptFacturaVenta)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(770, 479)
        '
        'rptFacturaVenta
        '
        Me.rptFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsFacturaVenta_FacturaVenta"
        ReportDataSource1.Value = Me.FacturaVentaBindingSource
        ReportDataSource2.Name = "dsFacturaVenta_DetalleFactura"
        ReportDataSource2.Value = Me.DetalleFacturaBindingSource
        Me.rptFacturaVenta.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptFacturaVenta.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rptFacturaVenta.LocalReport.ReportEmbeddedResource = "ISL.Win.rptFacturaVenta.rdlc"
        Me.rptFacturaVenta.Location = New System.Drawing.Point(0, 0)
        Me.rptFacturaVenta.Name = "rptFacturaVenta"
        Me.rptFacturaVenta.Size = New System.Drawing.Size(770, 479)
        Me.rptFacturaVenta.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griComplemento)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(770, 479)
        '
        'griComplemento
        '
        Me.griComplemento.ContextMenuStrip = Me.mnuComplemento
        Me.griComplemento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griComplemento.Location = New System.Drawing.Point(0, 0)
        Me.griComplemento.Name = "griComplemento"
        Me.griComplemento.Size = New System.Drawing.Size(770, 479)
        Me.griComplemento.TabIndex = 0
        Me.griComplemento.Text = "Grilla1"
        '
        'mnuComplemento
        '
        Me.mnuComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuComplemento.ForeColor = System.Drawing.Color.Black
        Me.mnuComplemento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiImprimir, Me.tsmiExportar})
        Me.mnuComplemento.Name = "mnuComplemento"
        Me.mnuComplemento.Size = New System.Drawing.Size(149, 48)
        '
        'tsmiImprimir
        '
        Me.tsmiImprimir.Name = "tsmiImprimir"
        Me.tsmiImprimir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsmiImprimir.Size = New System.Drawing.Size(148, 22)
        Me.tsmiImprimir.Text = "Imprimir"
        '
        'tsmiExportar
        '
        Me.tsmiExportar.Name = "tsmiExportar"
        Me.tsmiExportar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.tsmiExportar.Size = New System.Drawing.Size(148, 22)
        Me.tsmiExportar.Text = "Exportar"
        '
        'ficFactura
        '
        Me.ficFactura.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficFactura.Controls.Add(Me.UltraTabPageControl1)
        Me.ficFactura.Controls.Add(Me.UltraTabPageControl2)
        Me.ficFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficFactura.Location = New System.Drawing.Point(0, 0)
        Me.ficFactura.Name = "ficFactura"
        Me.ficFactura.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficFactura.Size = New System.Drawing.Size(772, 502)
        Me.ficFactura.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Datos"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Complemento"
        Me.ficFactura.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficFactura.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(770, 479)
        '
        'VistaPreviaPrint
        '
        Me.VistaPreviaPrint.Name = "VistaPreviaPrint"
        Me.VistaPreviaPrint.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.WindowsVista
        '
        'GrillaPrint
        '
        Me.GrillaPrint.Grid = Me.griComplemento
        '
        'frm_ReporteFacturaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 502)
        Me.Controls.Add(Me.ficFactura)
        Me.Name = "frm_ReporteFacturaVenta"
        Me.Text = "Factura de Venta"
        CType(Me.FacturaVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griComplemento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuComplemento.ResumeLayout(False)
        CType(Me.ficFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficFactura.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficFactura As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents rptFacturaVenta As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents griComplemento As ISL.Controles.Grilla
    Friend WithEvents FacturaVentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsFacturaVenta As ISL.Win.dsFacturaVenta
    Friend WithEvents DetalleFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents mnuComplemento As ISL.Controles.MenuContextual
    Friend WithEvents tsmiImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VistaPreviaPrint As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents GrillaPrint As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents tsmiExportar As System.Windows.Forms.ToolStripMenuItem
End Class
