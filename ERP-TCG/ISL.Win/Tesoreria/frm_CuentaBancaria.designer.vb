<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CuentaBancaria
    Inherits frm_MenuPadre

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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreBanco")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCuenta")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreMoneda")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoInicial")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ContactoTelefono")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TasaActiva")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TasaPasiva")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LineaCredito")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreBanco")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroCuenta")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreMoneda")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoInicial")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Contacto")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ContactoTelefono")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TasaActiva")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TasaPasiva")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LineaCredito")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroCorrelativo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalCuentaBancaria = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaCuentaBancaria = New ISL.Controles.Grilla(Me.components)
        Me.ogdCuentaBancaria = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.entNumeroCorrelativo = New ISL.Controles.NumeroEntero(Me.components)
        Me.txtContactoTelefono = New ISL.Controles.Texto(Me.components)
        Me.txtContacto = New ISL.Controles.Texto(Me.components)
        Me.decLineaCredito = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decTasaPasiva = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decTasaActiva = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecSaldoInicial = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboBanco = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtNumeroCuenta = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.tcCuentaBancaria = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrTotalCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalCuentaBancaria.SuspendLayout()
        CType(Me.griListaCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.entNumeroCorrelativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactoTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decLineaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTasaPasiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTasaActiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecSaldoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcCuentaBancaria.SuspendLayout()
        Me.MenuContextual1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalCuentaBancaria)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1026, 479)
        '
        'agrTotalCuentaBancaria
        '
        Me.agrTotalCuentaBancaria.Controls.Add(Me.griListaCuentaBancaria)
        Me.agrTotalCuentaBancaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTotalCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalCuentaBancaria.ForeColor = System.Drawing.Color.Black
        Me.agrTotalCuentaBancaria.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalCuentaBancaria.Name = "agrTotalCuentaBancaria"
        Me.agrTotalCuentaBancaria.Size = New System.Drawing.Size(1026, 479)
        Me.agrTotalCuentaBancaria.TabIndex = 0
        Me.agrTotalCuentaBancaria.Text = "Total Cuenta Bancaria"
        Me.agrTotalCuentaBancaria.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaCuentaBancaria
        '
        Me.griListaCuentaBancaria.DataSource = Me.ogdCuentaBancaria
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.Caption = "Banco"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 399
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.Caption = "Nº Cuenta"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Width = 284
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.Caption = "Mon."
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 113
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 90
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.Caption = "Contacto Telefono"
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.Caption = "Tasa Activa"
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 91
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Header.Caption = "Tasa Pasiva"
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.Caption = "Linea Credito"
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn13.Header.Caption = "Nº Correlativo"
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 85
        UltraGridColumn14.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.griListaCuentaBancaria.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaCuentaBancaria.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaCuentaBancaria.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaCuentaBancaria.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaCuentaBancaria.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaCuentaBancaria.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaCuentaBancaria.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaCuentaBancaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaCuentaBancaria.Location = New System.Drawing.Point(3, 16)
        Me.griListaCuentaBancaria.Name = "griListaCuentaBancaria"
        Me.griListaCuentaBancaria.Size = New System.Drawing.Size(1020, 460)
        Me.griListaCuentaBancaria.TabIndex = 0
        Me.griListaCuentaBancaria.Text = "Información de Cuenta Bancaria"
        '
        'ogdCuentaBancaria
        '
        UltraDataColumn1.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn2.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn3.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn4.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn5.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn6.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn7.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn8.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn9.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn10.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn11.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn12.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn13.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn14.DataType = GetType(Boolean)
        UltraDataColumn14.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        Me.ogdCuentaBancaria.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        Me.ogdCuentaBancaria.Band.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1026, 479)
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.entNumeroCorrelativo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtContactoTelefono)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtContacto)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.decLineaCredito)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.decTasaPasiva)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.decTasaActiva)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.DecSaldoInicial)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboMoneda)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboBanco)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtNumeroCuenta)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel13)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel12)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel9)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verActivo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel11)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel8)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel10)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel3)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel2)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel1)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel4)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(1026, 297)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'entNumeroCorrelativo
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.entNumeroCorrelativo.Appearance = Appearance1
        Me.entNumeroCorrelativo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.entNumeroCorrelativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entNumeroCorrelativo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.entNumeroCorrelativo.Location = New System.Drawing.Point(135, 262)
        Me.entNumeroCorrelativo.Name = "entNumeroCorrelativo"
        Me.entNumeroCorrelativo.NullText = "0"
        Me.entNumeroCorrelativo.Size = New System.Drawing.Size(201, 21)
        Me.entNumeroCorrelativo.TabIndex = 19
        '
        'txtContactoTelefono
        '
        Appearance2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtContactoTelefono.Appearance = Appearance2
        Me.txtContactoTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactoTelefono.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtContactoTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactoTelefono.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtContactoTelefono.Location = New System.Drawing.Point(135, 152)
        Me.txtContactoTelefono.MaxLength = 12
        Me.txtContactoTelefono.Name = "txtContactoTelefono"
        Me.txtContactoTelefono.Size = New System.Drawing.Size(202, 21)
        Me.txtContactoTelefono.TabIndex = 11
        '
        'txtContacto
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtContacto.Appearance = Appearance3
        Me.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtContacto.Location = New System.Drawing.Point(135, 125)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(202, 21)
        Me.txtContacto.TabIndex = 9
        '
        'decLineaCredito
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decLineaCredito.Appearance = Appearance4
        Me.decLineaCredito.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decLineaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decLineaCredito.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decLineaCredito.Location = New System.Drawing.Point(134, 233)
        Me.decLineaCredito.Name = "decLineaCredito"
        Me.decLineaCredito.NullText = "0.00"
        Me.decLineaCredito.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decLineaCredito.Size = New System.Drawing.Size(202, 21)
        Me.decLineaCredito.TabIndex = 17
        '
        'decTasaPasiva
        '
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTasaPasiva.Appearance = Appearance5
        Me.decTasaPasiva.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTasaPasiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTasaPasiva.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTasaPasiva.Location = New System.Drawing.Point(135, 206)
        Me.decTasaPasiva.Name = "decTasaPasiva"
        Me.decTasaPasiva.NullText = "0.00"
        Me.decTasaPasiva.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTasaPasiva.Size = New System.Drawing.Size(202, 21)
        Me.decTasaPasiva.TabIndex = 15
        '
        'decTasaActiva
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTasaActiva.Appearance = Appearance6
        Me.decTasaActiva.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTasaActiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTasaActiva.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTasaActiva.Location = New System.Drawing.Point(135, 179)
        Me.decTasaActiva.Name = "decTasaActiva"
        Me.decTasaActiva.NullText = "0.00"
        Me.decTasaActiva.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTasaActiva.Size = New System.Drawing.Size(202, 21)
        Me.decTasaActiva.TabIndex = 13
        '
        'DecSaldoInicial
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecSaldoInicial.Appearance = Appearance7
        Me.DecSaldoInicial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecSaldoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecSaldoInicial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecSaldoInicial.Location = New System.Drawing.Point(135, 101)
        Me.DecSaldoInicial.Name = "DecSaldoInicial"
        Me.DecSaldoInicial.NullText = "0.00"
        Me.DecSaldoInicial.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecSaldoInicial.Size = New System.Drawing.Size(202, 21)
        Me.DecSaldoInicial.TabIndex = 7
        '
        'cboMoneda
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance8
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(135, 74)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(202, 21)
        Me.cboMoneda.TabIndex = 5
        Me.cboMoneda.ValueMember = "Id"
        '
        'cboBanco
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBanco.Appearance = Appearance9
        Me.cboBanco.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboBanco.DisplayMember = "Nombre"
        Me.cboBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBanco.Location = New System.Drawing.Point(135, 22)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(202, 21)
        Me.cboBanco.TabIndex = 1
        Me.cboBanco.ValueMember = "Id"
        '
        'txtNumeroCuenta
        '
        Appearance10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroCuenta.Appearance = Appearance10
        Me.txtNumeroCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCuenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(135, 47)
        Me.txtNumeroCuenta.MaxLength = 16
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(202, 21)
        Me.txtNumeroCuenta.TabIndex = 3
        '
        'UltraLabel13
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance11
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(23, 266)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(106, 14)
        Me.UltraLabel13.TabIndex = 18
        Me.UltraLabel13.Text = "Numero Correlativo:"
        '
        'UltraLabel12
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance12
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(53, 237)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(75, 14)
        Me.UltraLabel12.TabIndex = 16
        Me.UltraLabel12.Text = "Linea Crédito:"
        '
        'UltraLabel9
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance13
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(29, 156)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(100, 14)
        Me.UltraLabel9.TabIndex = 10
        Me.UltraLabel9.Text = "Contacto Teléfono:"
        '
        'verActivo
        '
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(148, 306)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 20
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'UltraLabel11
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance14
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(59, 210)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel11.TabIndex = 14
        Me.UltraLabel11.Text = "Tasa Pasiva:"
        '
        'UltraLabel8
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance15
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(76, 129)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel8.TabIndex = 8
        Me.UltraLabel8.Text = "Contacto:"
        '
        'UltraLabel10
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance16
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(63, 183)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel10.TabIndex = 12
        Me.UltraLabel10.Text = "Tasa Activa:"
        '
        'UltraLabel3
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Appearance17.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance17
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(60, 105)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(69, 14)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "Saldo Inicial:"
        '
        'UltraLabel2
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance18
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(81, 78)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Moneda:"
        '
        'UltraLabel1
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance19
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(42, 51)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(87, 14)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Numero Cuenta:"
        '
        'UltraLabel4
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance20
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(90, 26)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Banco:"
        '
        'tcCuentaBancaria
        '
        Me.tcCuentaBancaria.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcCuentaBancaria.Controls.Add(Me.UltraTabPageControl7)
        Me.tcCuentaBancaria.Controls.Add(Me.utpDetalle)
        Me.tcCuentaBancaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcCuentaBancaria.Location = New System.Drawing.Point(0, 0)
        Me.tcCuentaBancaria.Name = "tcCuentaBancaria"
        Me.tcCuentaBancaria.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcCuentaBancaria.Size = New System.Drawing.Size(1028, 502)
        Me.tcCuentaBancaria.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.tcCuentaBancaria.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcCuentaBancaria.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1026, 479)
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Cuenta Bancaria"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar la Cuenta Bancaria seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la Cuenta Bancaria seleccionada"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje del sistema"
        '
        'frm_CuentaBancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 502)
        Me.ContextMenuStrip = Me.MenuContextual1
        Me.Controls.Add(Me.tcCuentaBancaria)
        Me.Name = "frm_CuentaBancaria"
        Me.Text = "Cuenta Bancaria"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrTotalCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalCuentaBancaria.ResumeLayout(False)
        CType(Me.griListaCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.entNumeroCorrelativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactoTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decLineaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTasaPasiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTasaActiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecSaldoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcCuentaBancaria.ResumeLayout(False)
        Me.MenuContextual1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcCuentaBancaria As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdCuentaBancaria As ISL.Controles.OrigenDatos
    Friend WithEvents txtNumeroCuenta As ISL.Controles.Texto
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents cboBanco As ISL.Controles.ComboMaestros
    Friend WithEvents DecSaldoInicial As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtContactoTelefono As ISL.Controles.Texto
    Friend WithEvents txtContacto As ISL.Controles.Texto
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decLineaCredito As ISL.Controles.NumeroDecimal
    Friend WithEvents decTasaPasiva As ISL.Controles.NumeroDecimal
    Friend WithEvents decTasaActiva As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents entNumeroCorrelativo As ISL.Controles.NumeroEntero
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents agrTotalCuentaBancaria As ISL.Controles.Agrupacion
    Friend WithEvents griListaCuentaBancaria As ISL.Controles.Grilla
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
