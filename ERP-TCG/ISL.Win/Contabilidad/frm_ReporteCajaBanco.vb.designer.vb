<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteCajaBanco
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
        Me.components = New System.ComponentModel.Container()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlujoCaja")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroBoucher")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMedioPago")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodoConcilia")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalMN")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalME")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Selecciona")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoGasto")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMonedaCtaBan")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroBoucher")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMedioPago")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodoConcilia")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMN")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalME")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Selecciona")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoGasto")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMonedaCtaBan")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
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
        Me.OrigenDatos1 = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.gridMovimientoBancarios = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaContable = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecSaldoFinal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecSaldoInicial = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCtaBancaria = New ISL.Controles.Combo(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.AppStylistRuntime1 = New Infragistics.Win.AppStyling.Runtime.AppStylistRuntime(Me.components)
        CType(Me.OrigenDatos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMovimientoBancarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecSaldoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecSaldoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrigenDatos1
        '
        UltraDataColumn14.DefaultValue = "False"
        UltraDataColumn17.DataType = GetType(Boolean)
        Me.OrigenDatos1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'gridMovimientoBancarios
        '
        Me.gridMovimientoBancarios.DataSource = Me.OrigenDatos1
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Header.Caption = "Flujo Caja"
        UltraGridColumn16.Header.VisiblePosition = 4
        UltraGridColumn16.Width = 224
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn17.Header.Caption = "NroVoucher"
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn17.Width = 75
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn18.Header.Caption = "Cuenta bancaria"
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.Width = 264
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn19.Header.VisiblePosition = 9
        UltraGridColumn19.Width = 90
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn20.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn20.Header.Caption = "Medio Pago"
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn20.Width = 171
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn21.Header.VisiblePosition = 10
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 12
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn23.Header.VisiblePosition = 11
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn24.Header.VisiblePosition = 13
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance1
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn25.Format = "#,##0.00"
        UltraGridColumn25.Header.VisiblePosition = 7
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn25.Width = 90
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn26.CellAppearance = Appearance2
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn26.Format = "#,##0.00"
        UltraGridColumn26.Header.VisiblePosition = 8
        UltraGridColumn26.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn26.Width = 90
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn27.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn27.Header.VisiblePosition = 6
        UltraGridColumn27.Width = 250
        UltraGridColumn28.Header.VisiblePosition = 14
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn28.Width = 74
        UltraGridColumn1.Header.VisiblePosition = 5
        UltraGridColumn1.Width = 257
        UltraGridColumn2.Header.VisiblePosition = 15
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 16
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 17
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.gridMovimientoBancarios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridMovimientoBancarios.DisplayLayout.MaxColScrollRegions = 1
        Me.gridMovimientoBancarios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridMovimientoBancarios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridMovimientoBancarios.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridMovimientoBancarios.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridMovimientoBancarios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridMovimientoBancarios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridMovimientoBancarios.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridMovimientoBancarios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridMovimientoBancarios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridMovimientoBancarios.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridMovimientoBancarios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridMovimientoBancarios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridMovimientoBancarios.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridMovimientoBancarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridMovimientoBancarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridMovimientoBancarios.Location = New System.Drawing.Point(0, 86)
        Me.gridMovimientoBancarios.Name = "gridMovimientoBancarios"
        Me.gridMovimientoBancarios.Size = New System.Drawing.Size(1147, 336)
        Me.gridMovimientoBancarios.TabIndex = 1
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.dtpFechaHasta)
        Me.Agrupacion1.Controls.Add(Me.dtpFechaDesde)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion1.Controls.Add(Me.cboMoneda)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion1.Controls.Add(Me.cboCuentaContable)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion1.Controls.Add(Me.DecSaldoFinal)
        Me.Agrupacion1.Controls.Add(Me.DecSaldoInicial)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion1.Controls.Add(Me.cboCtaBancaria)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1147, 86)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(102, 59)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaHasta.TabIndex = 9
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(8, 59)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaDesde.TabIndex = 7
        '
        'Etiqueta6
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance3
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(646, 5)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta6.TabIndex = 4
        Me.Etiqueta6.Text = "Moneda:"
        '
        'cboMoneda
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance4
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownListWidth = 400
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(646, 19)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.ReadOnly = True
        Me.cboMoneda.Size = New System.Drawing.Size(95, 21)
        Me.cboMoneda.TabIndex = 5
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta4
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance5
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(8, 5)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Cta Ctble:"
        '
        'cboCuentaContable
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Appearance = Appearance6
        Me.cboCuentaContable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaContable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaContable.DropDownListWidth = 400
        Me.cboCuentaContable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaContable.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Location = New System.Drawing.Point(6, 19)
        Me.cboCuentaContable.Name = "cboCuentaContable"
        Me.cboCuentaContable.Size = New System.Drawing.Size(314, 21)
        Me.cboCuentaContable.TabIndex = 1
        Me.cboCuentaContable.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance7
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(102, 46)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta2.TabIndex = 8
        Me.Etiqueta2.Text = "Fec Fin:"
        '
        'Etiqueta1
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance8
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(11, 46)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta1.TabIndex = 6
        Me.Etiqueta1.Text = "Fec Inicio:"
        '
        'Etiqueta5
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance9
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(327, 44)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta5.TabIndex = 12
        Me.Etiqueta5.Text = "Saldo Final:"
        '
        'Etiqueta3
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance10
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(193, 44)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(66, 14)
        Me.Etiqueta3.TabIndex = 10
        Me.Etiqueta3.Text = "Saldo Inicial:"
        '
        'DecSaldoFinal
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.DecSaldoFinal.Appearance = Appearance11
        Me.DecSaldoFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecSaldoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecSaldoFinal.ForeColor = System.Drawing.Color.Black
        Me.DecSaldoFinal.Location = New System.Drawing.Point(326, 59)
        Me.DecSaldoFinal.MaskInput = "{double:-12.4}"
        Me.DecSaldoFinal.Name = "DecSaldoFinal"
        Me.DecSaldoFinal.NullText = "0.00"
        Me.DecSaldoFinal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecSaldoFinal.Size = New System.Drawing.Size(131, 21)
        Me.DecSaldoFinal.TabIndex = 13
        Me.DecSaldoFinal.TabStop = False
        '
        'DecSaldoInicial
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.DecSaldoInicial.Appearance = Appearance12
        Me.DecSaldoInicial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecSaldoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecSaldoInicial.ForeColor = System.Drawing.Color.Black
        Me.DecSaldoInicial.Location = New System.Drawing.Point(192, 59)
        Me.DecSaldoInicial.MaskInput = "{double:-12.4}"
        Me.DecSaldoInicial.Name = "DecSaldoInicial"
        Me.DecSaldoInicial.NullText = "0.00"
        Me.DecSaldoInicial.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecSaldoInicial.Size = New System.Drawing.Size(128, 21)
        Me.DecSaldoInicial.TabIndex = 11
        Me.DecSaldoInicial.TabStop = False
        '
        'Etiqueta23
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta23.Appearance = Appearance13
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta23.Location = New System.Drawing.Point(326, 5)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta23.TabIndex = 2
        Me.Etiqueta23.Text = "Cta Bancaria:"
        '
        'cboCtaBancaria
        '
        Appearance14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaBancaria.Appearance = Appearance14
        Me.cboCtaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaBancaria.DropDownListWidth = 400
        Me.cboCtaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaBancaria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaBancaria.Location = New System.Drawing.Point(326, 19)
        Me.cboCtaBancaria.Name = "cboCtaBancaria"
        Me.cboCtaBancaria.Size = New System.Drawing.Size(314, 21)
        Me.cboCtaBancaria.TabIndex = 3
        Me.cboCtaBancaria.ValueMember = "Id"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(375, 177)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 2
        Me.ugb_Espera.Visible = False
        '
        'frm_ReporteCajaBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1147, 422)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.gridMovimientoBancarios)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_ReporteCajaBanco"
        Me.Text = "Reporte Caja"
        CType(Me.OrigenDatos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMovimientoBancarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecSaldoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecSaldoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridMovimientoBancarios As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents cboCtaBancaria As ISL.Controles.Combo
    Friend WithEvents OrigenDatos1 As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents DecSaldoInicial As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents DecSaldoFinal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaContable As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents AppStylistRuntime1 As Infragistics.Win.AppStyling.Runtime.AppStylistRuntime
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker

End Class
