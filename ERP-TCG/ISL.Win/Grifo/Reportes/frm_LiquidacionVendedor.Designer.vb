<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_LiquidacionVendedor
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.VISOR = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btn_Cargar_LiquidacionVendedor = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.cmb_Turno = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.cmb_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.VISOR)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1134, 427)
        '
        'VISOR
        '
        Me.VISOR.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Cabecera"
        ReportDataSource1.Value = Nothing
        ReportDataSource2.Name = "Detalle"
        ReportDataSource2.Value = Nothing
        Me.VISOR.LocalReport.DataSources.Add(ReportDataSource1)
        Me.VISOR.LocalReport.DataSources.Add(ReportDataSource2)
        Me.VISOR.LocalReport.ReportEmbeddedResource = "ISL.Win.rpt_CierreCompleto.rdlc"
        Me.VISOR.Location = New System.Drawing.Point(0, 60)
        Me.VISOR.Name = "VISOR"
        Me.VISOR.Size = New System.Drawing.Size(1134, 367)
        Me.VISOR.TabIndex = 3
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
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1134, 60)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "Filtros para Reporte"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
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
        Me.dtp_FechaInicio.Size = New System.Drawing.Size(88, 21)
        Me.dtp_FechaInicio.TabIndex = 338
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(1136, 450)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Liquidacion de Vendedor"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        Me.UltraTabControl1.Visible = False
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1134, 427)
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
        'dtp_FechaFinal
        '
        Me.dtp_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFinal.Location = New System.Drawing.Point(1035, 27)
        Me.dtp_FechaFinal.Name = "dtp_FechaFinal"
        Me.dtp_FechaFinal.Size = New System.Drawing.Size(88, 21)
        Me.dtp_FechaFinal.TabIndex = 344
        Me.dtp_FechaFinal.Visible = False
        '
        'cmb_Turno
        '
        Me.cmb_Turno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmb_Turno.DisplayMember = "Nombre"
        Me.cmb_Turno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_Turno.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cmb_Turno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Turno.Location = New System.Drawing.Point(266, 27)
        Me.cmb_Turno.Name = "cmb_Turno"
        Me.cmb_Turno.Size = New System.Drawing.Size(154, 23)
        Me.cmb_Turno.TabIndex = 345
        Me.cmb_Turno.ValueMember = "Id"
        '
        'frm_LiquidacionVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 450)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Name = "frm_LiquidacionVendedor"
        Me.Text = "Reportes"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.cmb_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_Cargar_LiquidacionVendedor As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaInicio As DateTimePicker
    Friend WithEvents VISOR As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaFinal As DateTimePicker
    Friend WithEvents cmb_Turno As Infragistics.Win.UltraWinGrid.UltraCombo
End Class
