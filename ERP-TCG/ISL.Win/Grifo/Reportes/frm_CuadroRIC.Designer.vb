<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_CuadroRIC
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial")
        Dim UltraGridColumn408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn409 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn410 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn411 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn412 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn413 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn414 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn415 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn416 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn417 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn418 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn419 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn420 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn421 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn422 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn423 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn424 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn425 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn426 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn427 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn428 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim UltraGridColumn429 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaAlterna")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.e_CierreTurnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.e_CierreTurno_DetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.udg_CuadroRIC = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaFin_RIC = New System.Windows.Forms.DateTimePicker()
        Me.cboProducto = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.btn_Consultar_RIC = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaInicial_RIC = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.VISOR = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btn_Cargar_CierreCompleto = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaCierre = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.e_CierreTurnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_CierreTurno_DetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.udg_CuadroRIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cboProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
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
        Me.UltraTabPageControl1.Controls.Add(Me.udg_CuadroRIC)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1134, 427)
        '
        'udg_CuadroRIC
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_CuadroRIC.DisplayLayout.Appearance = Appearance1
        UltraGridColumn394.Header.VisiblePosition = 0
        UltraGridColumn394.Hidden = True
        UltraGridColumn395.Header.VisiblePosition = 1
        UltraGridColumn395.Hidden = True
        UltraGridColumn396.Header.VisiblePosition = 2
        UltraGridColumn396.Hidden = True
        UltraGridColumn397.Header.VisiblePosition = 3
        UltraGridColumn397.Hidden = True
        UltraGridColumn398.Header.VisiblePosition = 6
        UltraGridColumn398.Hidden = True
        UltraGridColumn398.Width = 211
        UltraGridColumn399.Header.VisiblePosition = 7
        UltraGridColumn399.Hidden = True
        UltraGridColumn400.Header.VisiblePosition = 8
        UltraGridColumn400.Hidden = True
        UltraGridColumn401.Header.VisiblePosition = 15
        UltraGridColumn401.Hidden = True
        UltraGridColumn401.Width = 149
        UltraGridColumn402.Header.VisiblePosition = 10
        UltraGridColumn402.Hidden = True
        UltraGridColumn403.Header.VisiblePosition = 9
        UltraGridColumn403.Hidden = True
        UltraGridColumn403.Width = 65
        UltraGridColumn404.Header.VisiblePosition = 11
        UltraGridColumn404.Hidden = True
        UltraGridColumn405.Header.VisiblePosition = 18
        UltraGridColumn405.Hidden = True
        UltraGridColumn405.Width = 231
        UltraGridColumn406.Header.VisiblePosition = 5
        UltraGridColumn406.Hidden = True
        UltraGridColumn407.Header.VisiblePosition = 4
        UltraGridColumn407.Hidden = True
        UltraGridColumn407.Width = 114
        UltraGridColumn408.Header.VisiblePosition = 17
        UltraGridColumn408.Width = 248
        UltraGridColumn409.Header.VisiblePosition = 19
        UltraGridColumn409.Hidden = True
        UltraGridColumn410.Header.VisiblePosition = 27
        UltraGridColumn410.Hidden = True
        UltraGridColumn411.Header.VisiblePosition = 20
        UltraGridColumn411.Hidden = True
        UltraGridColumn411.MaskInput = "{double:9.3}"
        UltraGridColumn412.Header.VisiblePosition = 28
        UltraGridColumn412.Hidden = True
        UltraGridColumn412.MaskInput = "{double:9.3}"
        UltraGridColumn413.Header.Caption = "TipoCompra"
        UltraGridColumn413.Header.VisiblePosition = 21
        UltraGridColumn413.Hidden = True
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn414.CellAppearance = Appearance2
        UltraGridColumn414.Format = "#,###,###,##0.00"
        UltraGridColumn414.Header.VisiblePosition = 12
        UltraGridColumn414.Hidden = True
        UltraGridColumn414.MaskInput = "{double:9.2}"
        UltraGridColumn414.Width = 73
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn415.CellAppearance = Appearance3
        UltraGridColumn415.Format = "#,###,###,##0.00"
        UltraGridColumn415.Header.VisiblePosition = 13
        UltraGridColumn415.Hidden = True
        UltraGridColumn415.MaskInput = "{double:9.2}"
        UltraGridColumn415.Width = 73
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn416.CellAppearance = Appearance4
        UltraGridColumn416.Format = "#,###,###,##0.00"
        UltraGridColumn416.Header.VisiblePosition = 14
        UltraGridColumn416.Hidden = True
        UltraGridColumn416.MaskInput = "{double:9.2}"
        UltraGridColumn416.Width = 74
        UltraGridColumn417.Header.VisiblePosition = 22
        UltraGridColumn417.Hidden = True
        UltraGridColumn418.Header.VisiblePosition = 23
        UltraGridColumn418.Hidden = True
        UltraGridColumn419.Header.VisiblePosition = 24
        UltraGridColumn419.Hidden = True
        UltraGridColumn420.Header.VisiblePosition = 25
        UltraGridColumn420.Hidden = True
        UltraGridColumn421.Header.VisiblePosition = 26
        UltraGridColumn421.Hidden = True
        UltraGridColumn422.Header.VisiblePosition = 16
        UltraGridColumn422.Hidden = True
        UltraGridColumn422.Width = 104
        UltraGridColumn423.Header.VisiblePosition = 29
        UltraGridColumn423.Hidden = True
        UltraGridColumn424.Header.VisiblePosition = 30
        UltraGridColumn424.Hidden = True
        UltraGridColumn425.Header.VisiblePosition = 31
        UltraGridColumn425.Hidden = True
        UltraGridColumn426.Header.VisiblePosition = 32
        UltraGridColumn426.Hidden = True
        UltraGridColumn427.Header.VisiblePosition = 33
        UltraGridColumn427.Hidden = True
        UltraGridColumn428.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn428.Header.Caption = "Vendedor"
        UltraGridColumn428.Header.VisiblePosition = 34
        UltraGridColumn428.Hidden = True
        UltraGridColumn428.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn428.Width = 258
        UltraGridColumn429.Header.VisiblePosition = 35
        UltraGridColumn429.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn394, UltraGridColumn395, UltraGridColumn396, UltraGridColumn397, UltraGridColumn398, UltraGridColumn399, UltraGridColumn400, UltraGridColumn401, UltraGridColumn402, UltraGridColumn403, UltraGridColumn404, UltraGridColumn405, UltraGridColumn406, UltraGridColumn407, UltraGridColumn408, UltraGridColumn409, UltraGridColumn410, UltraGridColumn411, UltraGridColumn412, UltraGridColumn413, UltraGridColumn414, UltraGridColumn415, UltraGridColumn416, UltraGridColumn417, UltraGridColumn418, UltraGridColumn419, UltraGridColumn420, UltraGridColumn421, UltraGridColumn422, UltraGridColumn423, UltraGridColumn424, UltraGridColumn425, UltraGridColumn426, UltraGridColumn427, UltraGridColumn428, UltraGridColumn429})
        Me.udg_CuadroRIC.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.udg_CuadroRIC.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_CuadroRIC.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_CuadroRIC.DisplayLayout.GroupByBox.Appearance = Appearance5
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_CuadroRIC.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
        Me.udg_CuadroRIC.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_CuadroRIC.DisplayLayout.GroupByBox.Hidden = True
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance7.BackColor2 = System.Drawing.SystemColors.Control
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_CuadroRIC.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
        Me.udg_CuadroRIC.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_CuadroRIC.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_CuadroRIC.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_CuadroRIC.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_CuadroRIC.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_CuadroRIC.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_CuadroRIC.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_CuadroRIC.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_CuadroRIC.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_CuadroRIC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Me.udg_CuadroRIC.DisplayLayout.Override.RowAppearance = Appearance8
        Me.udg_CuadroRIC.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_CuadroRIC.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_CuadroRIC.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_CuadroRIC.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_CuadroRIC.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_CuadroRIC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_CuadroRIC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_CuadroRIC.Location = New System.Drawing.Point(0, 66)
        Me.udg_CuadroRIC.Name = "udg_CuadroRIC"
        Me.udg_CuadroRIC.Size = New System.Drawing.Size(1134, 361)
        Me.udg_CuadroRIC.TabIndex = 2
        Me.udg_CuadroRIC.Text = "Grilla2"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.dtp_FechaFin_RIC)
        Me.UltraGroupBox1.Controls.Add(Me.cboProducto)
        Me.UltraGroupBox1.Controls.Add(Me.btn_Consultar_RIC)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel15)
        Me.UltraGroupBox1.Controls.Add(Me.dtp_FechaInicial_RIC)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1134, 66)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Filtros para Reporte"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel2
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance9
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(298, 30)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(69, 15)
        Me.UltraLabel2.TabIndex = 343
        Me.UltraLabel2.Text = "Combustible:"
        '
        'dtp_FechaFin_RIC
        '
        Me.dtp_FechaFin_RIC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFin_RIC.Location = New System.Drawing.Point(196, 26)
        Me.dtp_FechaFin_RIC.Name = "dtp_FechaFin_RIC"
        Me.dtp_FechaFin_RIC.Size = New System.Drawing.Size(88, 21)
        Me.dtp_FechaFin_RIC.TabIndex = 342
        '
        'cboProducto
        '
        Me.cboProducto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboProducto.ButtonsRight.Add(EditorButton1)
        Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProducto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProducto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.Location = New System.Drawing.Point(373, 26)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(232, 22)
        Me.cboProducto.TabIndex = 341
        '
        'btn_Consultar_RIC
        '
        Me.btn_Consultar_RIC.Location = New System.Drawing.Point(634, 27)
        Me.btn_Consultar_RIC.Name = "btn_Consultar_RIC"
        Me.btn_Consultar_RIC.Size = New System.Drawing.Size(153, 23)
        Me.btn_Consultar_RIC.TabIndex = 340
        Me.btn_Consultar_RIC.Text = "Actualizar Cuadro RIC"
        '
        'UltraLabel15
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance10
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(12, 30)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(84, 15)
        Me.UltraLabel15.TabIndex = 339
        Me.UltraLabel15.Text = "Fecha de Corte:"
        '
        'dtp_FechaInicial_RIC
        '
        Me.dtp_FechaInicial_RIC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicial_RIC.Location = New System.Drawing.Point(102, 26)
        Me.dtp_FechaInicial_RIC.Name = "dtp_FechaInicial_RIC"
        Me.dtp_FechaInicial_RIC.Size = New System.Drawing.Size(88, 21)
        Me.dtp_FechaInicial_RIC.TabIndex = 338
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.VISOR)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1134, 427)
        '
        'VISOR
        '
        Me.VISOR.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Cabecera"
        ReportDataSource1.Value = Me.e_CierreTurnoBindingSource
        ReportDataSource2.Name = "Detalle"
        ReportDataSource2.Value = Me.e_CierreTurno_DetalleBindingSource
        Me.VISOR.LocalReport.DataSources.Add(ReportDataSource1)
        Me.VISOR.LocalReport.DataSources.Add(ReportDataSource2)
        Me.VISOR.LocalReport.ReportEmbeddedResource = "ISL.Win.rpt_CierreCompleto.rdlc"
        Me.VISOR.Location = New System.Drawing.Point(0, 66)
        Me.VISOR.Name = "VISOR"
        Me.VISOR.Size = New System.Drawing.Size(1134, 361)
        Me.VISOR.TabIndex = 3
        Me.VISOR.ZoomPercent = 90
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.btn_Cargar_CierreCompleto)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox2.Controls.Add(Me.dtp_FechaCierre)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1134, 66)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "Filtros para Reporte"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btn_Cargar_CierreCompleto
        '
        Me.btn_Cargar_CierreCompleto.Location = New System.Drawing.Point(205, 27)
        Me.btn_Cargar_CierreCompleto.Name = "btn_Cargar_CierreCompleto"
        Me.btn_Cargar_CierreCompleto.Size = New System.Drawing.Size(153, 23)
        Me.btn_Cargar_CierreCompleto.TabIndex = 340
        Me.btn_Cargar_CierreCompleto.Text = "Cargar Cierre Completo"
        '
        'UltraLabel1
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance11
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 30)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(86, 15)
        Me.UltraLabel1.TabIndex = 339
        Me.UltraLabel1.Text = "Fecha de Cierre:"
        '
        'dtp_FechaCierre
        '
        Me.dtp_FechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaCierre.Location = New System.Drawing.Point(102, 30)
        Me.dtp_FechaCierre.Name = "dtp_FechaCierre"
        Me.dtp_FechaCierre.Size = New System.Drawing.Size(88, 21)
        Me.dtp_FechaCierre.TabIndex = 338
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(1136, 450)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Cuadro RIC"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Cierre Completo"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        Me.UltraTabControl1.Visible = False
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1134, 427)
        '
        'frm_Reporte_RIC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 450)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Name = "frm_Reporte_RIC"
        Me.Text = "Reportes"
        CType(Me.e_CierreTurnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_CierreTurno_DetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.udg_CuadroRIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cboProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents udg_CuadroRIC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btn_Consultar_RIC As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaInicial_RIC As DateTimePicker
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_Cargar_CierreCompleto As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaCierre As DateTimePicker
    Friend WithEvents VISOR As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents e_CierreTurnoBindingSource As BindingSource
    Friend WithEvents e_CierreTurno_DetalleBindingSource As BindingSource
    Friend WithEvents dtp_FechaFin_RIC As DateTimePicker
    Friend WithEvents cboProducto As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
End Class
