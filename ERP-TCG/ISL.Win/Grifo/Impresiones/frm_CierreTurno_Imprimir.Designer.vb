<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CierreTurno_Imprimir
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.e_CierreTurnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.e_CierreTurno_DetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.VISOR_CierreParcial = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tab_Reportes = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.BSO1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSO2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISOR_CierreCompleto = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.e_CierreTurnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_CierreTurno_DetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.tab_Reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Reportes.SuspendLayout()
        CType(Me.BSO1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSO2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'e_CierreTurnoBindingSource
        '
        Me.e_CierreTurnoBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_CierreTurno)
        '
        'e_CierreTurno_DetalleBindingSource
        '
        Me.e_CierreTurno_DetalleBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_CierreTurno_Detalle)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.VISOR_CierreParcial)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(798, 427)
        '
        'VISOR_CierreParcial
        '
        Me.VISOR_CierreParcial.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Cabecera"
        ReportDataSource1.Value = Me.e_CierreTurnoBindingSource
        ReportDataSource2.Name = "Detalle"
        ReportDataSource2.Value = Me.e_CierreTurno_DetalleBindingSource
        Me.VISOR_CierreParcial.LocalReport.DataSources.Add(ReportDataSource1)
        Me.VISOR_CierreParcial.LocalReport.DataSources.Add(ReportDataSource2)
        Me.VISOR_CierreParcial.LocalReport.ReportEmbeddedResource = "ISL.Win.rpt_CierreParcial.rdlc"
        Me.VISOR_CierreParcial.Location = New System.Drawing.Point(0, 0)
        Me.VISOR_CierreParcial.Name = "VISOR_CierreParcial"
        Me.VISOR_CierreParcial.Size = New System.Drawing.Size(798, 427)
        Me.VISOR_CierreParcial.TabIndex = 2
        Me.VISOR_CierreParcial.ZoomPercent = 90
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.VISOR_CierreCompleto)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(798, 427)
        '
        'tab_Reportes
        '
        Me.tab_Reportes.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tab_Reportes.Controls.Add(Me.UltraTabPageControl1)
        Me.tab_Reportes.Controls.Add(Me.UltraTabPageControl2)
        Me.tab_Reportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_Reportes.Location = New System.Drawing.Point(0, 0)
        Me.tab_Reportes.Name = "tab_Reportes"
        Me.tab_Reportes.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tab_Reportes.Size = New System.Drawing.Size(800, 450)
        Me.tab_Reportes.TabIndex = 4
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Cierre Parcial"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Cierre Completo"
        Me.tab_Reportes.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tab_Reportes.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(798, 427)
        '
        'BSO1
        '
        Me.BSO1.DataSource = GetType(ERP.EntidadesWCF.e_CierreTurno)
        '
        'BSO2
        '
        Me.BSO2.DataSource = GetType(ERP.EntidadesWCF.e_CierreTurno_Detalle)
        '
        'VISOR_CierreCompleto
        '
        Me.VISOR_CierreCompleto.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "Cabecera"
        ReportDataSource3.Value = Me.e_CierreTurnoBindingSource
        ReportDataSource4.Name = "Detalle"
        ReportDataSource4.Value = Me.e_CierreTurno_DetalleBindingSource
        Me.VISOR_CierreCompleto.LocalReport.DataSources.Add(ReportDataSource3)
        Me.VISOR_CierreCompleto.LocalReport.DataSources.Add(ReportDataSource4)
        Me.VISOR_CierreCompleto.LocalReport.ReportEmbeddedResource = "ISL.Win.rpt_CierreCompleto.rdlc"
        Me.VISOR_CierreCompleto.Location = New System.Drawing.Point(0, 0)
        Me.VISOR_CierreCompleto.Name = "VISOR_CierreCompleto"
        Me.VISOR_CierreCompleto.Size = New System.Drawing.Size(798, 427)
        Me.VISOR_CierreCompleto.TabIndex = 3
        Me.VISOR_CierreCompleto.ZoomPercent = 90
        '
        'frm_CierreTurno_Imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tab_Reportes)
        Me.Name = "frm_CierreTurno_Imprimir"
        Me.Text = "frm_CierreTurno_Imprimir"
        CType(Me.e_CierreTurnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_CierreTurno_DetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.tab_Reportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Reportes.ResumeLayout(False)
        CType(Me.BSO1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSO2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_Reportes As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents VISOR_CierreParcial As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents BSO1 As BindingSource
    Friend WithEvents BSO2 As BindingSource
    Friend WithEvents e_CierreTurnoBindingSource As BindingSource
    Friend WithEvents e_CierreTurno_DetalleBindingSource As BindingSource
    Friend WithEvents VISOR_CierreCompleto As Microsoft.Reporting.WinForms.ReportViewer
End Class
