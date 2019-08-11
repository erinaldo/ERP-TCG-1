<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConciliacionBancaria
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroBoucher")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMonedaCtaBan")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMedioPago")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodoConcilia")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMN")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalME")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoGasto")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlujoCaja")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroBoucher")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMonedaCtaBan")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMedioPago")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodoConcilia")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalMN")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalME")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoGasto")
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.gridMovimientoBancarios = New ISL.Controles.Grilla(Me.components)
        Me.OrigenDatos1 = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Año1 = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecSaldoFinal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecSaldoInicial = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTotalCheck = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCtaBancaria = New ISL.Controles.Combo(Me.components)
        Me.chkConciliado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.gridMovimientoBancarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrigenDatos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.Año1.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecSaldoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecSaldoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTotalCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkConciliado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridMovimientoBancarios
        '
        Me.gridMovimientoBancarios.DataSource = Me.OrigenDatos1
        Appearance1.TextVAlignAsString = "Middle"
        Me.gridMovimientoBancarios.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.Caption = "Flujo Caja"
        UltraGridColumn2.Header.VisiblePosition = 5
        UltraGridColumn2.Width = 158
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.Caption = "NroVoucher"
        UltraGridColumn3.Header.VisiblePosition = 4
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.Caption = "Cuenta bancaria"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 91
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 7
        UltraGridColumn5.Width = 97
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.Caption = "Medio Pago"
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn6.Width = 195
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 12
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.VisiblePosition = 11
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.VisiblePosition = 13
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance2
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Format = "#,##0.00"
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.Width = 95
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance3
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Format = "#,##0.00"
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.Width = 99
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn13.Header.VisiblePosition = 6
        UltraGridColumn13.Width = 170
        Appearance4.TextHAlignAsString = "Center"
        Appearance4.TextVAlignAsString = "Middle"
        UltraGridColumn17.CellAppearance = Appearance4
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn17.DefaultCellValue = "False"
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn17.Header.Appearance = Appearance5
        UltraGridColumn17.Header.Caption = "Sel."
        UltraGridColumn17.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None
        UltraGridColumn17.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn17.Width = 60
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Width = 204
        UltraGridColumn14.Header.VisiblePosition = 16
        UltraGridColumn14.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn16, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn17, UltraGridColumn15, UltraGridColumn14})
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.gridMovimientoBancarios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridMovimientoBancarios.DisplayLayout.MaxColScrollRegions = 1
        Me.gridMovimientoBancarios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridMovimientoBancarios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridMovimientoBancarios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridMovimientoBancarios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridMovimientoBancarios.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridMovimientoBancarios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridMovimientoBancarios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridMovimientoBancarios.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridMovimientoBancarios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridMovimientoBancarios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridMovimientoBancarios.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridMovimientoBancarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridMovimientoBancarios.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridMovimientoBancarios.Location = New System.Drawing.Point(0, 94)
        Me.gridMovimientoBancarios.Name = "gridMovimientoBancarios"
        Me.gridMovimientoBancarios.Size = New System.Drawing.Size(1147, 328)
        Me.gridMovimientoBancarios.TabIndex = 11
        Me.gridMovimientoBancarios.Text = "Movimientos Bancarios"
        '
        'OrigenDatos1
        '
        UltraDataColumn15.DataType = GetType(Boolean)
        Me.OrigenDatos1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.chkConciliado)
        Me.Agrupacion1.Controls.Add(Me.UltraGroupBox1)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion1.Controls.Add(Me.DecSaldoFinal)
        Me.Agrupacion1.Controls.Add(Me.DecSaldoInicial)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion1.Controls.Add(Me.DecTotalCheck)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion1.Controls.Add(Me.cboCtaBancaria)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1147, 94)
        Me.Agrupacion1.TabIndex = 10
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.ParallelSolid
        Me.UltraGroupBox1.Controls.Add(Me.Año1)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta1)
        Me.UltraGroupBox1.Controls.Add(Me.cboMes)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta2)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(615, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(243, 67)
        Me.UltraGroupBox1.TabIndex = 265
        Me.UltraGroupBox1.Text = "Periodo de Conciliación"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Año1
        '
        Me.Año1.Año = 2016
        Me.Año1.Controls.Add(Me.numAño)
        Me.Año1.Location = New System.Drawing.Point(70, 35)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(54, 23)
        Me.Año1.TabIndex = 254
        '
        'numAño
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance7
        Me.numAño.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAño.ForeColor = System.Drawing.Color.Black
        Me.numAño.FormatString = ""
        Me.numAño.Location = New System.Drawing.Point(1, 0)
        Me.numAño.MaskInput = "nnnn"
        Me.numAño.MaxValue = 2020
        Me.numAño.MinValue = 2000
        Me.numAño.Name = "numAño"
        Me.numAño.NullText = "0"
        Me.numAño.Size = New System.Drawing.Size(52, 21)
        Me.numAño.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAño.TabIndex = 0
        Me.numAño.Value = 2012
        '
        'Etiqueta1
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance8
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(15, 35)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta1.TabIndex = 256
        Me.Etiqueta1.Text = "Ejercicio:"
        '
        'cboMes
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance9
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(162, 34)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(67, 22)
        Me.cboMes.TabIndex = 255
        Me.cboMes.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance10
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(130, 36)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(27, 15)
        Me.Etiqueta2.TabIndex = 257
        Me.Etiqueta2.Text = "Mes:"
        '
        'Etiqueta5
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance11
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(415, 56)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(60, 15)
        Me.Etiqueta5.TabIndex = 263
        Me.Etiqueta5.Text = "Saldo Final:"
        '
        'Etiqueta3
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance12
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(21, 56)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta3.TabIndex = 259
        Me.Etiqueta3.Text = "Saldo Inicial:"
        '
        'DecSaldoFinal
        '
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.DecSaldoFinal.Appearance = Appearance13
        Me.DecSaldoFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DecSaldoFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecSaldoFinal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecSaldoFinal.ForeColor = System.Drawing.Color.Black
        Me.DecSaldoFinal.Location = New System.Drawing.Point(483, 52)
        Me.DecSaldoFinal.MaskInput = "{double:-12.4}"
        Me.DecSaldoFinal.Name = "DecSaldoFinal"
        Me.DecSaldoFinal.NullText = "0.00"
        Me.DecSaldoFinal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecSaldoFinal.Size = New System.Drawing.Size(126, 22)
        Me.DecSaldoFinal.TabIndex = 262
        '
        'DecSaldoInicial
        '
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.DecSaldoInicial.Appearance = Appearance14
        Me.DecSaldoInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DecSaldoInicial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecSaldoInicial.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecSaldoInicial.ForeColor = System.Drawing.Color.Black
        Me.DecSaldoInicial.Location = New System.Drawing.Point(93, 52)
        Me.DecSaldoInicial.MaskInput = "{double:-12.4}"
        Me.DecSaldoInicial.Name = "DecSaldoInicial"
        Me.DecSaldoInicial.NullText = "0.00"
        Me.DecSaldoInicial.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecSaldoInicial.Size = New System.Drawing.Size(126, 22)
        Me.DecSaldoInicial.TabIndex = 258
        '
        'Etiqueta4
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance15
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(225, 56)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta4.TabIndex = 261
        Me.Etiqueta4.Text = "A conciliar:"
        '
        'DecTotalCheck
        '
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.DecTotalCheck.Appearance = Appearance16
        Me.DecTotalCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DecTotalCheck.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalCheck.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalCheck.ForeColor = System.Drawing.Color.Black
        Me.DecTotalCheck.Location = New System.Drawing.Point(289, 52)
        Me.DecTotalCheck.MaskInput = "{double:-12.4}"
        Me.DecTotalCheck.Name = "DecTotalCheck"
        Me.DecTotalCheck.NullText = "0.00"
        Me.DecTotalCheck.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalCheck.Size = New System.Drawing.Size(120, 22)
        Me.DecTotalCheck.TabIndex = 260
        '
        'Etiqueta23
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance17
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta23.Location = New System.Drawing.Point(16, 26)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(69, 15)
        Me.Etiqueta23.TabIndex = 252
        Me.Etiqueta23.Text = "Cta Bancaria:"
        '
        'cboCtaBancaria
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaBancaria.Appearance = Appearance18
        Me.cboCtaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCtaBancaria.DropDownListWidth = 400
        Me.cboCtaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaBancaria.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaBancaria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaBancaria.Location = New System.Drawing.Point(93, 22)
        Me.cboCtaBancaria.Name = "cboCtaBancaria"
        Me.cboCtaBancaria.Size = New System.Drawing.Size(382, 22)
        Me.cboCtaBancaria.TabIndex = 249
        Me.cboCtaBancaria.ValueMember = "Id"
        '
        'chkConciliado
        '
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.chkConciliado.Appearance = Appearance6
        Me.chkConciliado.AutoSize = True
        Me.chkConciliado.BackColor = System.Drawing.Color.Transparent
        Me.chkConciliado.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkConciliado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkConciliado.Location = New System.Drawing.Point(483, 26)
        Me.chkConciliado.Name = "chkConciliado"
        Me.chkConciliado.Size = New System.Drawing.Size(95, 18)
        Me.chkConciliado.TabIndex = 266
        Me.chkConciliado.Text = "Ver Conciliados"
        '
        'frm_ConciliacionBancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1147, 422)
        Me.Controls.Add(Me.gridMovimientoBancarios)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_ConciliacionBancaria"
        Me.Text = "Conciliacion Bancaria"
        CType(Me.gridMovimientoBancarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrigenDatos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.Año1.ResumeLayout(False)
        Me.Año1.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecSaldoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecSaldoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTotalCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkConciliado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridMovimientoBancarios As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents cboCtaBancaria As ISL.Controles.Combo
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents OrigenDatos1 As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents DecSaldoInicial As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents DecSaldoFinal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents DecTotalCheck As ISL.Controles.NumeroDecimal
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkConciliado As Infragistics.Win.UltraWinEditors.UltraCheckEditor

End Class
