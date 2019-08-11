<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReportePrestamo
    Inherits ISL.Win.frm_MenuPadre

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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.MovPrestamoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsMovPrestamo = New ISL.Win.dsMovPrestamo()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.btnFilas = New System.Windows.Forms.Button()
        Me.griReportePrestamo = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.rptResumen = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.fecPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.optReporte = New ISL.Controles.Opciones(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ficListado = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.MovPrestamoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsMovPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griReportePrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.optReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficListado.SuspendLayout()
        Me.SuspendLayout()
        '
        'MovPrestamoBindingSource
        '
        Me.MovPrestamoBindingSource.DataMember = "MovPrestamo"
        Me.MovPrestamoBindingSource.DataSource = Me.dsMovPrestamo
        '
        'dsMovPrestamo
        '
        Me.dsMovPrestamo.DataSetName = "dsMovPrestamo"
        Me.dsMovPrestamo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.btnFilas)
        Me.UltraTabPageControl1.Controls.Add(Me.griReportePrestamo)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(874, 305)
        '
        'btnFilas
        '
        Me.btnFilas.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilas.Location = New System.Drawing.Point(4, 2)
        Me.btnFilas.Name = "btnFilas"
        Me.btnFilas.Size = New System.Drawing.Size(27, 15)
        Me.btnFilas.TabIndex = 2
        Me.btnFilas.Text = "*"
        Me.btnFilas.UseVisualStyleBackColor = True
        '
        'griReportePrestamo
        '
        Me.griReportePrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griReportePrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griReportePrestamo.Location = New System.Drawing.Point(0, 0)
        Me.griReportePrestamo.Name = "griReportePrestamo"
        Me.griReportePrestamo.Size = New System.Drawing.Size(874, 305)
        Me.griReportePrestamo.TabIndex = 1
        Me.griReportePrestamo.Text = "_"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.rptResumen)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(874, 305)
        '
        'rptResumen
        '
        Me.rptResumen.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsMovPrestamo_MovPrestamo"
        ReportDataSource1.Value = Me.MovPrestamoBindingSource
        Me.rptResumen.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptResumen.LocalReport.ReportEmbeddedResource = "ISL.Win.MovimientoPrestamo.rdlc"
        Me.rptResumen.Location = New System.Drawing.Point(0, 0)
        Me.rptResumen.Name = "rptResumen"
        Me.rptResumen.Size = New System.Drawing.Size(874, 305)
        Me.rptResumen.TabIndex = 0
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrBusqueda.Controls.Add(Me.fecHasta)
        Me.agrBusqueda.Controls.Add(Me.fecDesde)
        Me.agrBusqueda.Controls.Add(Me.fecPeriodo)
        Me.agrBusqueda.Controls.Add(Me.optReporte)
        Me.agrBusqueda.Controls.Add(Me.cboTrabajador)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(876, 106)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Text = "Datos de Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Etiqueta2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance1
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(533, 77)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta2.TabIndex = 6
        Me.Etiqueta2.Text = "Hasta:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(574, 74)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(84, 20)
        Me.fecHasta.TabIndex = 5
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(443, 74)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(84, 20)
        Me.fecDesde.TabIndex = 4
        '
        'fecPeriodo
        '
        Me.fecPeriodo.CustomFormat = "MMMM/yyyy"
        Me.fecPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecPeriodo.Location = New System.Drawing.Point(443, 48)
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.Size = New System.Drawing.Size(126, 20)
        Me.fecPeriodo.TabIndex = 3
        '
        'optReporte
        '
        Me.optReporte.BackColor = System.Drawing.Color.Transparent
        Me.optReporte.BackColorInternal = System.Drawing.Color.Transparent
        Me.optReporte.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optReporte.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "Saldo Pendientes"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "Ejecutado por mes"
        ValueListItem3.DataValue = "ValueListItem2"
        ValueListItem3.DisplayText = "Descuentos Desde:"
        Me.optReporte.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.optReporte.ItemSpacingVertical = 10
        Me.optReporte.Location = New System.Drawing.Point(318, 24)
        Me.optReporte.Name = "optReporte"
        Me.optReporte.Size = New System.Drawing.Size(119, 69)
        Me.optReporte.TabIndex = 2
        '
        'cboTrabajador
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance2
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(74, 30)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(238, 21)
        Me.cboTrabajador.TabIndex = 1
        Me.cboTrabajador.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(11, 34)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Trabajador"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'ficListado
        '
        Me.ficListado.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficListado.Controls.Add(Me.UltraTabPageControl1)
        Me.ficListado.Controls.Add(Me.UltraTabPageControl2)
        Me.ficListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficListado.Location = New System.Drawing.Point(0, 106)
        Me.ficListado.Name = "ficListado"
        Me.ficListado.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficListado.Size = New System.Drawing.Size(876, 328)
        Me.ficListado.TabIndex = 3
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Resumen"
        Me.ficListado.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficListado.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(874, 305)
        '
        'frm_ReportePrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 434)
        Me.Controls.Add(Me.ficListado)
        Me.Controls.Add(Me.agrBusqueda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ReportePrestamo"
        Me.Text = "Reporte de Prestamo a Trabajador"
        CType(Me.MovPrestamoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsMovPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griReportePrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.optReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficListado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents griReportePrestamo As ISL.Controles.Grilla
    Friend WithEvents optReporte As ISL.Controles.Opciones
    Friend WithEvents fecPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFilas As System.Windows.Forms.Button
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents ficListado As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents rptResumen As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MovPrestamoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsMovPrestamo As ISL.Win.dsMovPrestamo
End Class
