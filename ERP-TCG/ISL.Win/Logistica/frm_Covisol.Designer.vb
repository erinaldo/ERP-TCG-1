<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Covisol
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
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroTarjeta")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Entrada")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Salida")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroTarjeta")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Entrada")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Salida")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroTarjeta")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ticket")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaHasta")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lugar")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresado")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGuardado")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoOperacion")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreLugar")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaISL")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroTarjeta")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ticket")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaHasta")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Lugar")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIngresado")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGuardado")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoOperacion")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreLugar")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlacaISL")
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.tabSaldos = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griSaldoTarjeta = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udsSaldos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTarjetaRecargar = New ISL.Controles.Colores(Me.components)
        Me.txtTarjetaFiltroSaldo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabMovimientos = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griMovimientos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udsTarjetaMovimiento = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.colorPendiente = New ISL.Controles.Colores(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.colorRegistrado = New ISL.Controles.Colores(Me.components)
        Me.txtNroTarjetaFiltro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.ficPrincipal = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.tabSaldos.SuspendLayout()
        CType(Me.griSaldoTarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.ColorTarjetaRecargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTarjetaFiltroSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMovimientos.SuspendLayout()
        CType(Me.griMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsTarjetaMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.colorPendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorRegistrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroTarjetaFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabSaldos
        '
        Me.tabSaldos.Controls.Add(Me.griSaldoTarjeta)
        Me.tabSaldos.Controls.Add(Me.UltraGroupBox3)
        Me.tabSaldos.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabSaldos.Name = "tabSaldos"
        Me.tabSaldos.Size = New System.Drawing.Size(1082, 538)
        '
        'griSaldoTarjeta
        '
        Me.griSaldoTarjeta.DataSource = Me.udsSaldos
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Width = 136
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance1
        UltraGridColumn6.Format = "###,##0.00"
        UltraGridColumn6.Header.Caption = "Entrada (S/.)"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Width = 89
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance2
        UltraGridColumn7.Format = "###,##0.00"
        UltraGridColumn7.Header.Caption = "Salida (S/.)"
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn7.Width = 91
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Width = 91
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance3
        UltraGridColumn18.Format = "###,###,##0.00"
        UltraGridColumn18.Header.Caption = "Saldo (S/.)"
        UltraGridColumn18.Header.VisiblePosition = 4
        UltraGridColumn18.Width = 92
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn18})
        Me.griSaldoTarjeta.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griSaldoTarjeta.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griSaldoTarjeta.DisplayLayout.MaxColScrollRegions = 1
        Me.griSaldoTarjeta.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griSaldoTarjeta.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griSaldoTarjeta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griSaldoTarjeta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griSaldoTarjeta.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griSaldoTarjeta.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griSaldoTarjeta.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griSaldoTarjeta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griSaldoTarjeta.DisplayLayout.Override.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Never
        Me.griSaldoTarjeta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griSaldoTarjeta.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griSaldoTarjeta.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griSaldoTarjeta.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griSaldoTarjeta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griSaldoTarjeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griSaldoTarjeta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griSaldoTarjeta.Location = New System.Drawing.Point(0, 55)
        Me.griSaldoTarjeta.Name = "griSaldoTarjeta"
        Me.griSaldoTarjeta.Size = New System.Drawing.Size(1082, 483)
        Me.griSaldoTarjeta.TabIndex = 2
        Me.griSaldoTarjeta.TabStop = False
        Me.griSaldoTarjeta.Tag = ""
        '
        'udsSaldos
        '
        UltraDataColumn2.DataType = GetType(Decimal)
        UltraDataColumn3.DataType = GetType(Decimal)
        UltraDataColumn5.DataType = GetType(Decimal)
        Me.udsSaldos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5})
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox4)
        Me.UltraGroupBox3.Controls.Add(Me.txtTarjetaFiltroSaldo)
        Me.UltraGroupBox3.Controls.Add(Me.Label4)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1082, 55)
        Me.UltraGroupBox3.TabIndex = 1
        Me.UltraGroupBox3.Text = "Filtros"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.Etiqueta6)
        Me.UltraGroupBox4.Controls.Add(Me.ColorTarjetaRecargar)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(298, 5)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(200, 46)
        Me.UltraGroupBox4.TabIndex = 8
        Me.UltraGroupBox4.Text = "Tarjetas por Recargar"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta6
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Appearance = Appearance4
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(29, 20)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(101, 15)
        Me.Etiqueta6.TabIndex = 6
        Me.Etiqueta6.Text = "Saldo <= a S/.500:"
        '
        'ColorTarjetaRecargar
        '
        Me.ColorTarjetaRecargar.DefaultColor = System.Drawing.Color.LightBlue
        Me.ColorTarjetaRecargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTarjetaRecargar.Location = New System.Drawing.Point(130, 18)
        Me.ColorTarjetaRecargar.Name = "ColorTarjetaRecargar"
        Me.ColorTarjetaRecargar.Size = New System.Drawing.Size(46, 19)
        Me.ColorTarjetaRecargar.TabIndex = 7
        Me.ColorTarjetaRecargar.Text = "LightBlue"
        '
        'txtTarjetaFiltroSaldo
        '
        Me.txtTarjetaFiltroSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTarjetaFiltroSaldo.Location = New System.Drawing.Point(79, 17)
        Me.txtTarjetaFiltroSaldo.Name = "txtTarjetaFiltroSaldo"
        Me.txtTarjetaFiltroSaldo.Size = New System.Drawing.Size(170, 22)
        Me.txtTarjetaFiltroSaldo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(15, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nro Tarjeta:"
        '
        'tabMovimientos
        '
        Me.tabMovimientos.Controls.Add(Me.griMovimientos)
        Me.tabMovimientos.Controls.Add(Me.UltraGroupBox2)
        Me.tabMovimientos.Location = New System.Drawing.Point(1, 22)
        Me.tabMovimientos.Name = "tabMovimientos"
        Me.tabMovimientos.Size = New System.Drawing.Size(1082, 538)
        '
        'griMovimientos
        '
        Me.griMovimientos.DataSource = Me.udsTarjetaMovimiento
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Width = 132
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Width = 92
        UltraGridColumn13.Format = "dd/MM/yyyy hh:mm:ss tt"
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Width = 147
        UltraGridColumn14.Header.VisiblePosition = 5
        UltraGridColumn14.Hidden = True
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn15.CellAppearance = Appearance5
        UltraGridColumn15.Format = "###,##0.00"
        UltraGridColumn15.Header.VisiblePosition = 6
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn19.CellAppearance = Appearance6
        UltraGridColumn19.Format = "###,##0.00"
        UltraGridColumn19.Header.VisiblePosition = 7
        UltraGridColumn16.Header.VisiblePosition = 8
        UltraGridColumn16.Width = 49
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.Width = 86
        UltraGridColumn35.Header.Caption = "Placa Web"
        UltraGridColumn35.Header.VisiblePosition = 10
        UltraGridColumn35.Width = 77
        UltraGridColumn36.Header.Caption = "Asignado Viaje"
        UltraGridColumn36.Header.VisiblePosition = 13
        UltraGridColumn37.Header.Caption = "Registrado"
        UltraGridColumn37.Header.VisiblePosition = 12
        UltraGridColumn38.Header.VisiblePosition = 14
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 15
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 16
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 17
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 18
        UltraGridColumn42.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 19
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 20
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 21
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 222
        UltraGridColumn4.Header.Caption = "Placa ISL"
        UltraGridColumn4.Header.VisiblePosition = 11
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn19, UltraGridColumn16, UltraGridColumn17, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.griMovimientos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griMovimientos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMovimientos.DisplayLayout.MaxColScrollRegions = 1
        Me.griMovimientos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griMovimientos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimientos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griMovimientos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMovimientos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMovimientos.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griMovimientos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMovimientos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMovimientos.DisplayLayout.Override.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Never
        Me.griMovimientos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMovimientos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMovimientos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griMovimientos.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griMovimientos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovimientos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMovimientos.Location = New System.Drawing.Point(0, 57)
        Me.griMovimientos.Name = "griMovimientos"
        Me.griMovimientos.Size = New System.Drawing.Size(1082, 481)
        Me.griMovimientos.TabIndex = 3
        Me.griMovimientos.TabStop = False
        Me.griMovimientos.Tag = ""
        '
        'udsTarjetaMovimiento
        '
        UltraDataColumn10.DataType = GetType(Date)
        UltraDataColumn11.DataType = GetType(Date)
        UltraDataColumn12.DataType = GetType(Decimal)
        UltraDataColumn13.DataType = GetType(Decimal)
        UltraDataColumn17.DataType = GetType(Boolean)
        UltraDataColumn18.DataType = GetType(Boolean)
        UltraDataColumn20.DataType = GetType(Date)
        UltraDataColumn22.DataType = GetType(Date)
        UltraDataColumn23.DataType = GetType(Boolean)
        Me.udsTarjetaMovimiento.Band.Columns.AddRange(New Object() {UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27})
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraGroupBox2.Controls.Add(Me.txtNroTarjetaFiltro)
        Me.UltraGroupBox2.Controls.Add(Me.Label3)
        Me.UltraGroupBox2.Controls.Add(Me.Label2)
        Me.UltraGroupBox2.Controls.Add(Me.Label1)
        Me.UltraGroupBox2.Controls.Add(Me.dtpHasta)
        Me.UltraGroupBox2.Controls.Add(Me.dtpDesde)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1082, 57)
        Me.UltraGroupBox2.TabIndex = 0
        Me.UltraGroupBox2.Text = "Filtros"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Label6)
        Me.UltraGroupBox1.Controls.Add(Me.colorPendiente)
        Me.UltraGroupBox1.Controls.Add(Me.Label5)
        Me.UltraGroupBox1.Controls.Add(Me.colorRegistrado)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(566, 3)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(238, 48)
        Me.UltraGroupBox1.TabIndex = 6
        Me.UltraGroupBox1.Text = "Estados"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(118, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Pendiente:"
        '
        'colorPendiente
        '
        Me.colorPendiente.Color = System.Drawing.Color.LightGreen
        Me.colorPendiente.Location = New System.Drawing.Point(178, 17)
        Me.colorPendiente.Name = "colorPendiente"
        Me.colorPendiente.Size = New System.Drawing.Size(46, 22)
        Me.colorPendiente.TabIndex = 15
        Me.colorPendiente.Text = "LightGreen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Registrado:"
        '
        'colorRegistrado
        '
        Me.colorRegistrado.Location = New System.Drawing.Point(69, 17)
        Me.colorRegistrado.Name = "colorRegistrado"
        Me.colorRegistrado.Size = New System.Drawing.Size(46, 22)
        Me.colorRegistrado.TabIndex = 13
        Me.colorRegistrado.Text = "Control"
        '
        'txtNroTarjetaFiltro
        '
        Me.txtNroTarjetaFiltro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroTarjetaFiltro.Location = New System.Drawing.Point(384, 20)
        Me.txtNroTarjetaFiltro.MaxLength = 16
        Me.txtNroTarjetaFiltro.Name = "txtNroTarjetaFiltro"
        Me.txtNroTarjetaFiltro.Size = New System.Drawing.Size(170, 22)
        Me.txtNroTarjetaFiltro.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(320, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nro Tarjeta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(148, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(187, 21)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(98, 21)
        Me.dtpHasta.TabIndex = 1
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(48, 21)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(98, 21)
        Me.dtpDesde.TabIndex = 0
        '
        'ficPrincipal
        '
        Me.ficPrincipal.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficPrincipal.Controls.Add(Me.tabSaldos)
        Me.ficPrincipal.Controls.Add(Me.tabMovimientos)
        Me.ficPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ficPrincipal.Name = "ficPrincipal"
        Me.ficPrincipal.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficPrincipal.Size = New System.Drawing.Size(1084, 561)
        Me.ficPrincipal.TabIndex = 3
        UltraTab2.TabPage = Me.tabSaldos
        UltraTab2.Text = "Saldo Tarjeta"
        UltraTab3.TabPage = Me.tabMovimientos
        UltraTab3.Text = "Movimientos Tarjeta"
        Me.ficPrincipal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab3})
        Me.ficPrincipal.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1082, 538)
        '
        'frm_Covisol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.ficPrincipal)
        Me.Name = "frm_Covisol"
        Me.Text = "Servicio Web Covisol"
        Me.tabSaldos.ResumeLayout(False)
        CType(Me.griSaldoTarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.ColorTarjetaRecargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTarjetaFiltroSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMovimientos.ResumeLayout(False)
        CType(Me.griMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsTarjetaMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.colorPendiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorRegistrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroTarjetaFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNroTarjetaFiltro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents griSaldoTarjeta As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents ficPrincipal As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tabSaldos As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtTarjetaFiltroSaldo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tabMovimientos As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griMovimientos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents colorPendiente As ISL.Controles.Colores
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents colorRegistrado As ISL.Controles.Colores
    Friend WithEvents udsTarjetaMovimiento As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents udsSaldos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTarjetaRecargar As ISL.Controles.Colores
End Class
