<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_LiquidacionVendedor_Imprimir
    Inherits frm_MenuPadre

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.VISOR = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmb_Turno = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.dtp_FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.btn_Cargar_LiquidacionVendedor = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.bso_Documento = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSO1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSO2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.e_LiqVen_VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.e_LiqVen_ResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.e_LiqVen_DepositosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.cmb_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bso_Documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSO1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSO2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.e_LiqVen_VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_LiqVen_ResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_LiqVen_DepositosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.VISOR)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(982, 638)
        '
        'VISOR
        '
        Me.VISOR.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DTS1"
        ReportDataSource1.Value = Me.e_LiqVen_VentasBindingSource
        ReportDataSource2.Name = "DTS2"
        ReportDataSource2.Value = Me.e_LiqVen_ResumenBindingSource
        ReportDataSource3.Name = "DTS3"
        ReportDataSource3.Value = Me.e_LiqVen_DepositosBindingSource
        Me.VISOR.LocalReport.DataSources.Add(ReportDataSource1)
        Me.VISOR.LocalReport.DataSources.Add(ReportDataSource2)
        Me.VISOR.LocalReport.DataSources.Add(ReportDataSource3)
        Me.VISOR.LocalReport.ReportEmbeddedResource = "ISL.Win.rpt_LiquidacionVendedor.rdlc"
        Me.VISOR.Location = New System.Drawing.Point(0, 60)
        Me.VISOR.Name = "VISOR"
        Me.VISOR.Size = New System.Drawing.Size(982, 578)
        Me.VISOR.TabIndex = 2
        Me.VISOR.ZoomPercent = 90
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.cmb_Turno)
        Me.UltraGroupBox2.Controls.Add(Me.dtp_FechaFinal)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox2.Controls.Add(Me.btn_Cargar_LiquidacionVendedor)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox2.Controls.Add(Me.dtp_FechaInicio)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(982, 60)
        Me.UltraGroupBox2.TabIndex = 3
        Me.UltraGroupBox2.Text = "Filtros para Reporte"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmb_Turno
        '
        Me.cmb_Turno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmb_Turno.DisplayMember = "Nombre"
        Me.cmb_Turno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_Turno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Turno.Location = New System.Drawing.Point(266, 27)
        Me.cmb_Turno.Name = "cmb_Turno"
        Me.cmb_Turno.Size = New System.Drawing.Size(154, 23)
        Me.cmb_Turno.TabIndex = 345
        Me.cmb_Turno.ValueMember = "Id"
        '
        'dtp_FechaFinal
        '
        Me.dtp_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFinal.Location = New System.Drawing.Point(1035, 27)
        Me.dtp_FechaFinal.Name = "dtp_FechaFinal"
        Me.dtp_FechaFinal.Size = New System.Drawing.Size(88, 18)
        Me.dtp_FechaFinal.TabIndex = 344
        Me.dtp_FechaFinal.Visible = False
        '
        'UltraLabel13
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance1
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(222, 30)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel13.TabIndex = 343
        Me.UltraLabel13.Text = "Turno:"
        '
        'btn_Cargar_LiquidacionVendedor
        '
        Me.btn_Cargar_LiquidacionVendedor.Location = New System.Drawing.Point(464, 25)
        Me.btn_Cargar_LiquidacionVendedor.Name = "btn_Cargar_LiquidacionVendedor"
        Me.btn_Cargar_LiquidacionVendedor.Size = New System.Drawing.Size(199, 23)
        Me.btn_Cargar_LiquidacionVendedor.TabIndex = 340
        Me.btn_Cargar_LiquidacionVendedor.Text = "Ver Liquidacion de Vendedor"
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(11, 30)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(94, 15)
        Me.UltraLabel1.TabIndex = 339
        Me.UltraLabel1.Text = "Rango de Fechas:"
        '
        'dtp_FechaInicio
        '
        Me.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicio.Location = New System.Drawing.Point(111, 27)
        Me.dtp_FechaInicio.Name = "dtp_FechaInicio"
        Me.dtp_FechaInicio.Size = New System.Drawing.Size(88, 18)
        Me.dtp_FechaInicio.TabIndex = 338
        '
        'bso_Documento
        '
        Me.bso_Documento.DataSource = GetType(ERP.EntidadesWCF.e_MovimientoDocumento)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(984, 661)
        Me.UltraTabControl1.TabIndex = 3
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Liquidacion de Vendedor"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(982, 638)
        '
        'e_LiqVen_VentasBindingSource
        '
        Me.e_LiqVen_VentasBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_LiqVen_Ventas)
        '
        'e_LiqVen_ResumenBindingSource
        '
        Me.e_LiqVen_ResumenBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_LiqVen_Resumen)
        '
        'e_LiqVen_DepositosBindingSource
        '
        Me.e_LiqVen_DepositosBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_LiqVen_Depositos)
        '
        'frm_LiquidacionVendedor_Imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_LiquidacionVendedor_Imprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_DocumentoCtble_Imprimir"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.cmb_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bso_Documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSO1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSO2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.e_LiqVen_VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_LiqVen_ResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_LiqVen_DepositosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BSO1 As BindingSource
    Friend WithEvents BSO2 As BindingSource
    Friend WithEvents VISOR As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents bso_Documento As BindingSource
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cmb_Turno As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dtp_FechaFinal As DateTimePicker
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_Cargar_LiquidacionVendedor As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaInicio As DateTimePicker
    Friend WithEvents e_LiqVen_VentasBindingSource As BindingSource
    Friend WithEvents e_LiqVen_ResumenBindingSource As BindingSource
    Friend WithEvents e_LiqVen_DepositosBindingSource As BindingSource
End Class
