<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TransferenciasBancarias
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroBoucher")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMedioPago")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodoConcilia")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMN")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalME")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMonedaCtaBan")
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
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMonedaCtaBan")
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
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridMovimientoBancarios = New ISL.Controles.Grilla(Me.components)
        Me.OrigenDatos1 = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.fecFin = New System.Windows.Forms.DateTimePicker()
        Me.fecInicio = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCtaBancaria = New ISL.Controles.Combo(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDetalleAnalisis = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetalleAdjunto = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.etiValidaDatos = New ISL.Controles.Etiqueta(Me.components)
        Me.btnValidarDatos = New ISL.Controles.Boton(Me.components)
        Me.btnQuitarDatos = New ISL.Controles.Boton(Me.components)
        Me.btnImportar = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.agrDescuento = New ISL.Controles.Agrupacion(Me.components)
        Me.txtGlosaDscto = New ISL.Controles.Texto(Me.components)
        Me.nroCuotaDscto = New ISL.Controles.Numero(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.Espere1 = New ISL.Win.Espere()
        Me.btnCobroDeuda = New ISL.Controles.Boton(Me.components)
        Me.chkCargaMasiva = New ISL.Controles.Chequear(Me.components)
        Me.chkDsctoPlanilla = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFlujoCaja = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCheque = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndDolares = New ISL.Controles.NumeroDecimal(Me.components)
        Me.ndSoles = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboTrabajadorDestino = New ISL.Controles.Combo(Me.components)
        Me.cboTrabajadorOrigen = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMedioPago = New ISL.Controles.Combo(Me.components)
        Me.cboCuentaBancariaOrigen = New ISL.Controles.Combo(Me.components)
        Me.cboTipoMovimiento = New ISL.Controles.Combo(Me.components)
        Me.etiCtaBanOrigen = New ISL.Controles.Etiqueta(Me.components)
        Me.fecTransf = New System.Windows.Forms.DateTimePicker()
        Me.cboCuentaCtbleOrigen = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiOrigen = New ISL.Controles.Etiqueta(Me.components)
        Me.chkReposicionCajaChica = New System.Windows.Forms.CheckBox()
        Me.cboCuentaBancariaDestino = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCtaBanDestino = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.cboCuentaCtbleDestino = New ISL.Controles.Combo(Me.components)
        Me.etiDestino = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiImporte = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.DecImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.tcTransferenciaBancaria = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.gridMovimientoBancarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrigenDatos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.cboCtaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDetalleAnalisis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalleAnalisis.SuspendLayout()
        CType(Me.griDetalleAdjunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.agrDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDescuento.SuspendLayout()
        CType(Me.txtGlosaDscto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nroCuotaDscto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.chkCargaMasiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDsctoPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndDolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndSoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadorDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadorOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedioPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancariaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaCtbleOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancariaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaCtbleDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcTransferenciaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcTransferenciaBancaria.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.gridMovimientoBancarios)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(924, 468)
        '
        'gridMovimientoBancarios
        '
        Me.gridMovimientoBancarios.DataSource = Me.OrigenDatos1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.Caption = "Flujo Caja"
        UltraGridColumn2.Header.VisiblePosition = 4
        UltraGridColumn2.Width = 195
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.Caption = "Cuenta bancaria"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.Caption = "Medio Pago"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Width = 201
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 10
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 7
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridMovimientoBancarios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridMovimientoBancarios.DisplayLayout.MaxColScrollRegions = 1
        Me.gridMovimientoBancarios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridMovimientoBancarios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
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
        Me.gridMovimientoBancarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridMovimientoBancarios.Location = New System.Drawing.Point(0, 42)
        Me.gridMovimientoBancarios.Name = "gridMovimientoBancarios"
        Me.gridMovimientoBancarios.Size = New System.Drawing.Size(924, 426)
        Me.gridMovimientoBancarios.TabIndex = 1
        Me.gridMovimientoBancarios.Text = "Movimientos Bancarios"
        '
        'OrigenDatos1
        '
        Me.OrigenDatos1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion1.Controls.Add(Me.cboCtaBancaria)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(924, 42)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.fecFin)
        Me.Agrupacion3.Controls.Add(Me.fecInicio)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(7, 6)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(324, 30)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecFin
        '
        Me.fecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFin.Location = New System.Drawing.Point(224, 5)
        Me.fecFin.Name = "fecFin"
        Me.fecFin.Size = New System.Drawing.Size(90, 20)
        Me.fecFin.TabIndex = 3
        '
        'fecInicio
        '
        Me.fecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicio.Location = New System.Drawing.Point(74, 5)
        Me.fecInicio.Name = "fecInicio"
        Me.fecInicio.Size = New System.Drawing.Size(90, 20)
        Me.fecInicio.TabIndex = 1
        '
        'Etiqueta11
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance1
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(170, 8)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(48, 14)
        Me.Etiqueta11.TabIndex = 2
        Me.Etiqueta11.Text = "Fec. Fin:"
        '
        'Etiqueta8
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance2
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(8, 8)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta8.TabIndex = 0
        Me.Etiqueta8.Text = "Fec. Inicio:"
        '
        'Etiqueta23
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance3
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta23.Location = New System.Drawing.Point(338, 15)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(73, 14)
        Me.Etiqueta23.TabIndex = 1
        Me.Etiqueta23.Text = "Cta Bancaria:"
        '
        'cboCtaBancaria
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaBancaria.Appearance = Appearance4
        Me.cboCtaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaBancaria.DropDownListWidth = 400
        Me.cboCtaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaBancaria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaBancaria.Location = New System.Drawing.Point(414, 10)
        Me.cboCtaBancaria.Name = "cboCtaBancaria"
        Me.cboCtaBancaria.Size = New System.Drawing.Size(247, 21)
        Me.cboCtaBancaria.TabIndex = 2
        Me.cboCtaBancaria.ValueMember = "Id"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDetalleAnalisis)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(924, 468)
        '
        'agrDetalleAnalisis
        '
        Me.agrDetalleAnalisis.Controls.Add(Me.griDetalleAdjunto)
        Me.agrDetalleAnalisis.Controls.Add(Me.Agrupacion5)
        Me.agrDetalleAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalleAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetalleAnalisis.ForeColor = System.Drawing.Color.Black
        Me.agrDetalleAnalisis.Location = New System.Drawing.Point(0, 292)
        Me.agrDetalleAnalisis.Name = "agrDetalleAnalisis"
        Me.agrDetalleAnalisis.Size = New System.Drawing.Size(924, 176)
        Me.agrDetalleAnalisis.TabIndex = 1
        Me.agrDetalleAnalisis.Text = "Detalle Adjunto"
        Me.agrDetalleAnalisis.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetalleAdjunto
        '
        Me.griDetalleAdjunto.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleAdjunto.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleAdjunto.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleAdjunto.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDetalleAdjunto.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetalleAdjunto.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetalleAdjunto.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDetalleAdjunto.DisplayLayout.Override.CellPadding = 0
        Me.griDetalleAdjunto.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleAdjunto.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.griDetalleAdjunto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalleAdjunto.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalleAdjunto.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleAdjunto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleAdjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleAdjunto.Location = New System.Drawing.Point(3, 55)
        Me.griDetalleAdjunto.Name = "griDetalleAdjunto"
        Me.griDetalleAdjunto.Size = New System.Drawing.Size(918, 118)
        Me.griDetalleAdjunto.TabIndex = 2
        Me.griDetalleAdjunto.Text = "Grilla1"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.etiValidaDatos)
        Me.Agrupacion5.Controls.Add(Me.btnValidarDatos)
        Me.Agrupacion5.Controls.Add(Me.btnQuitarDatos)
        Me.Agrupacion5.Controls.Add(Me.btnImportar)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(3, 16)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(918, 39)
        Me.Agrupacion5.TabIndex = 1
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'etiValidaDatos
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.etiValidaDatos.Appearance = Appearance5
        Me.etiValidaDatos.AutoSize = True
        Me.etiValidaDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiValidaDatos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiValidaDatos.Location = New System.Drawing.Point(319, 13)
        Me.etiValidaDatos.Name = "etiValidaDatos"
        Me.etiValidaDatos.Size = New System.Drawing.Size(56, 14)
        Me.etiValidaDatos.TabIndex = 3
        Me.etiValidaDatos.Text = "Resultado"
        '
        'btnValidarDatos
        '
        Appearance6.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.btnValidarDatos.Appearance = Appearance6
        Me.btnValidarDatos.AutoSize = True
        Me.btnValidarDatos.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnValidarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValidarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnValidarDatos.Location = New System.Drawing.Point(217, 7)
        Me.btnValidarDatos.Name = "btnValidarDatos"
        Me.btnValidarDatos.Size = New System.Drawing.Size(96, 26)
        Me.btnValidarDatos.TabIndex = 2
        Me.btnValidarDatos.Text = "Validar Datos"
        '
        'btnQuitarDatos
        '
        Appearance7.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.btnQuitarDatos.Appearance = Appearance7
        Me.btnQuitarDatos.AutoSize = True
        Me.btnQuitarDatos.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnQuitarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuitarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnQuitarDatos.Location = New System.Drawing.Point(119, 7)
        Me.btnQuitarDatos.Name = "btnQuitarDatos"
        Me.btnQuitarDatos.Size = New System.Drawing.Size(92, 26)
        Me.btnQuitarDatos.TabIndex = 1
        Me.btnQuitarDatos.Text = "Quitar Datos"
        '
        'btnImportar
        '
        Appearance8.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.btnImportar.Appearance = Appearance8
        Me.btnImportar.AutoSize = True
        Me.btnImportar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.ForeColor = System.Drawing.Color.Black
        Me.btnImportar.Location = New System.Drawing.Point(12, 7)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(103, 26)
        Me.btnImportar.TabIndex = 0
        Me.btnImportar.Text = "Importar Datos"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.agrDescuento)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion4)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(924, 292)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'agrDescuento
        '
        Me.agrDescuento.Controls.Add(Me.txtGlosaDscto)
        Me.agrDescuento.Controls.Add(Me.nroCuotaDscto)
        Me.agrDescuento.Controls.Add(Me.Etiqueta4)
        Me.agrDescuento.Controls.Add(Me.Etiqueta3)
        Me.agrDescuento.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDescuento.ForeColor = System.Drawing.Color.Black
        Me.agrDescuento.Location = New System.Drawing.Point(601, 172)
        Me.agrDescuento.Name = "agrDescuento"
        Me.agrDescuento.Size = New System.Drawing.Size(311, 110)
        Me.agrDescuento.TabIndex = 1
        Me.agrDescuento.Text = "Datos de Descuento:"
        Me.agrDescuento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtGlosaDscto
        '
        Me.txtGlosaDscto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaDscto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaDscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaDscto.Location = New System.Drawing.Point(57, 48)
        Me.txtGlosaDscto.Multiline = True
        Me.txtGlosaDscto.Name = "txtGlosaDscto"
        Me.txtGlosaDscto.Size = New System.Drawing.Size(245, 53)
        Me.txtGlosaDscto.TabIndex = 3
        '
        'nroCuotaDscto
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.nroCuotaDscto.Appearance = Appearance9
        Me.nroCuotaDscto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nroCuotaDscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroCuotaDscto.ForeColor = System.Drawing.Color.Black
        Me.nroCuotaDscto.Location = New System.Drawing.Point(57, 21)
        Me.nroCuotaDscto.MaskInput = "nnnn"
        Me.nroCuotaDscto.MaxValue = 100
        Me.nroCuotaDscto.MinValue = 1
        Me.nroCuotaDscto.Name = "nroCuotaDscto"
        Me.nroCuotaDscto.Size = New System.Drawing.Size(78, 21)
        Me.nroCuotaDscto.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.nroCuotaDscto.TabIndex = 1
        '
        'Etiqueta4
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance10
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(14, 50)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta4.TabIndex = 2
        Me.Etiqueta4.Text = "Glosa:"
        '
        'Etiqueta3
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance11
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(8, 24)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Cuotas:"
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.Espere1)
        Me.Agrupacion4.Controls.Add(Me.btnCobroDeuda)
        Me.Agrupacion4.Controls.Add(Me.chkCargaMasiva)
        Me.Agrupacion4.Controls.Add(Me.chkDsctoPlanilla)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion4.Controls.Add(Me.cboFlujoCaja)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion4.Controls.Add(Me.txtCheque)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion4.Controls.Add(Me.ndDolares)
        Me.Agrupacion4.Controls.Add(Me.ndSoles)
        Me.Agrupacion4.Controls.Add(Me.cboTrabajadorDestino)
        Me.Agrupacion4.Controls.Add(Me.cboTrabajadorOrigen)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion4.Controls.Add(Me.cboMedioPago)
        Me.Agrupacion4.Controls.Add(Me.cboCuentaBancariaOrigen)
        Me.Agrupacion4.Controls.Add(Me.cboTipoMovimiento)
        Me.Agrupacion4.Controls.Add(Me.etiCtaBanOrigen)
        Me.Agrupacion4.Controls.Add(Me.fecTransf)
        Me.Agrupacion4.Controls.Add(Me.cboCuentaCtbleOrigen)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion4.Controls.Add(Me.etiOrigen)
        Me.Agrupacion4.Controls.Add(Me.chkReposicionCajaChica)
        Me.Agrupacion4.Controls.Add(Me.cboCuentaBancariaDestino)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion4.Controls.Add(Me.etiCtaBanDestino)
        Me.Agrupacion4.Controls.Add(Me.txtGlosa)
        Me.Agrupacion4.Controls.Add(Me.cboCuentaCtbleDestino)
        Me.Agrupacion4.Controls.Add(Me.etiDestino)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion4.Controls.Add(Me.EtiImporte)
        Me.Agrupacion4.Controls.Add(Me.cboMoneda)
        Me.Agrupacion4.Controls.Add(Me.DecImporte)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion4.Controls.Add(Me.DecTC)
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(8, 9)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(587, 274)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.Text = "Datos de Transferencia:"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Espere1
        '
        Me.Espere1.Location = New System.Drawing.Point(280, 184)
        Me.Espere1.Name = "Espere1"
        Me.Espere1.Size = New System.Drawing.Size(458, 67)
        Me.Espere1.TabIndex = 1
        Me.Espere1.Visible = False
        '
        'btnCobroDeuda
        '
        Appearance12.Image = Global.ISL.Win.My.Resources.Resources.Purse
        Me.btnCobroDeuda.Appearance = Appearance12
        Me.btnCobroDeuda.AutoSize = True
        Me.btnCobroDeuda.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCobroDeuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCobroDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobroDeuda.ForeColor = System.Drawing.Color.Black
        Me.btnCobroDeuda.Location = New System.Drawing.Point(392, 118)
        Me.btnCobroDeuda.Name = "btnCobroDeuda"
        Me.btnCobroDeuda.Size = New System.Drawing.Size(95, 26)
        Me.btnCobroDeuda.TabIndex = 17
        Me.btnCobroDeuda.Text = "Cobrar Dscto"
        '
        'chkCargaMasiva
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.FontData.BoldAsString = "True"
        Appearance13.FontData.Name = "Tahoma"
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.chkCargaMasiva.Appearance = Appearance13
        Me.chkCargaMasiva.AutoSize = True
        Me.chkCargaMasiva.BackColor = System.Drawing.Color.Transparent
        Me.chkCargaMasiva.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkCargaMasiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCargaMasiva.ForeColor = System.Drawing.Color.Black
        Me.chkCargaMasiva.Location = New System.Drawing.Point(435, 163)
        Me.chkCargaMasiva.Name = "chkCargaMasiva"
        Me.chkCargaMasiva.Size = New System.Drawing.Size(95, 18)
        Me.chkCargaMasiva.TabIndex = 24
        Me.chkCargaMasiva.Text = "Carga Masiva"
        '
        'chkDsctoPlanilla
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.FontData.BoldAsString = "True"
        Appearance14.FontData.Name = "Tahoma"
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.chkDsctoPlanilla.Appearance = Appearance14
        Me.chkDsctoPlanilla.AutoSize = True
        Me.chkDsctoPlanilla.BackColor = System.Drawing.Color.Transparent
        Me.chkDsctoPlanilla.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkDsctoPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDsctoPlanilla.ForeColor = System.Drawing.Color.Black
        Me.chkDsctoPlanilla.Location = New System.Drawing.Point(391, 163)
        Me.chkDsctoPlanilla.Name = "chkDsctoPlanilla"
        Me.chkDsctoPlanilla.Size = New System.Drawing.Size(145, 18)
        Me.chkDsctoPlanilla.TabIndex = 23
        Me.chkDsctoPlanilla.Text = "Descuento por Planilla"
        '
        'Etiqueta2
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance15
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(464, 187)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta2.TabIndex = 31
        Me.Etiqueta2.Text = "Dolares"
        '
        'Etiqueta13
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance16
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(313, 61)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(63, 15)
        Me.Etiqueta13.TabIndex = 10
        Me.Etiqueta13.Text = "Flujo Caja:"
        '
        'cboFlujoCaja
        '
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFlujoCaja.Appearance = Appearance17
        Me.cboFlujoCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboFlujoCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlujoCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlujoCaja.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoCaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFlujoCaja.Location = New System.Drawing.Point(313, 77)
        Me.cboFlujoCaja.Name = "cboFlujoCaja"
        Me.cboFlujoCaja.Size = New System.Drawing.Size(265, 22)
        Me.cboFlujoCaja.TabIndex = 11
        Me.cboFlujoCaja.ValueMember = "Id"
        '
        'Etiqueta9
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance18
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(6, 187)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(138, 15)
        Me.Etiqueta9.TabIndex = 25
        Me.Etiqueta9.Text = "Nro Operacion / Cheque"
        '
        'txtCheque
        '
        Me.txtCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheque.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCheque.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(6, 203)
        Me.txtCheque.MaxLength = 20
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(197, 22)
        Me.txtCheque.TabIndex = 26
        '
        'Etiqueta1
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance19
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(347, 187)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta1.TabIndex = 29
        Me.Etiqueta1.Text = "Soles"
        '
        'ndDolares
        '
        Appearance20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndDolares.Appearance = Appearance20
        Me.ndDolares.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndDolares.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndDolares.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndDolares.Location = New System.Drawing.Point(464, 203)
        Me.ndDolares.MaskInput = "{double:16.4}"
        Me.ndDolares.Name = "ndDolares"
        Me.ndDolares.NullText = "0.00"
        Me.ndDolares.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndDolares.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ndDolares.ReadOnly = True
        Me.ndDolares.Size = New System.Drawing.Size(116, 22)
        Me.ndDolares.TabIndex = 32
        '
        'ndSoles
        '
        Appearance21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndSoles.Appearance = Appearance21
        Me.ndSoles.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndSoles.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndSoles.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndSoles.Location = New System.Drawing.Point(345, 203)
        Me.ndSoles.MaskInput = "{double:16.4}"
        Me.ndSoles.Name = "ndSoles"
        Me.ndSoles.NullText = "0.00"
        Me.ndSoles.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndSoles.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ndSoles.ReadOnly = True
        Me.ndSoles.Size = New System.Drawing.Size(113, 22)
        Me.ndSoles.TabIndex = 30
        '
        'cboTrabajadorDestino
        '
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadorDestino.Appearance = Appearance22
        Me.cboTrabajadorDestino.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboTrabajadorDestino.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboTrabajadorDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTrabajadorDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorDestino.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadorDestino.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadorDestino.Location = New System.Drawing.Point(14, 161)
        Me.cboTrabajadorDestino.Name = "cboTrabajadorDestino"
        Me.cboTrabajadorDestino.Size = New System.Drawing.Size(371, 22)
        Me.cboTrabajadorDestino.TabIndex = 20
        Me.cboTrabajadorDestino.ValueMember = "Id"
        '
        'cboTrabajadorOrigen
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadorOrigen.Appearance = Appearance23
        Me.cboTrabajadorOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboTrabajadorOrigen.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboTrabajadorOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTrabajadorOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorOrigen.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadorOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadorOrigen.Location = New System.Drawing.Point(14, 121)
        Me.cboTrabajadorOrigen.Name = "cboTrabajadorOrigen"
        Me.cboTrabajadorOrigen.Size = New System.Drawing.Size(371, 22)
        Me.cboTrabajadorOrigen.TabIndex = 14
        Me.cboTrabajadorOrigen.ValueMember = "Id"
        '
        'Etiqueta22
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta22.Appearance = Appearance24
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta22.Location = New System.Drawing.Point(6, 19)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(89, 15)
        Me.Etiqueta22.TabIndex = 0
        Me.Etiqueta22.Text = "Medio de Pago:"
        '
        'cboMedioPago
        '
        Appearance25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMedioPago.Appearance = Appearance25
        Me.cboMedioPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMedioPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMedioPago.DropDownListWidth = 400
        Me.cboMedioPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMedioPago.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedioPago.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMedioPago.Location = New System.Drawing.Point(6, 35)
        Me.cboMedioPago.Name = "cboMedioPago"
        Me.cboMedioPago.Size = New System.Drawing.Size(265, 22)
        Me.cboMedioPago.TabIndex = 1
        Me.cboMedioPago.ValueMember = "Id"
        '
        'cboCuentaBancariaOrigen
        '
        Appearance26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaBancariaOrigen.Appearance = Appearance26
        Me.cboCuentaBancariaOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaBancariaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaBancariaOrigen.DropDownListWidth = 400
        Me.cboCuentaBancariaOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancariaOrigen.Enabled = False
        Me.cboCuentaBancariaOrigen.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancariaOrigen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaBancariaOrigen.Location = New System.Drawing.Point(280, 121)
        Me.cboCuentaBancariaOrigen.Name = "cboCuentaBancariaOrigen"
        Me.cboCuentaBancariaOrigen.Size = New System.Drawing.Size(300, 22)
        Me.cboCuentaBancariaOrigen.TabIndex = 16
        Me.cboCuentaBancariaOrigen.ValueMember = "Id"
        '
        'cboTipoMovimiento
        '
        Appearance27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoMovimiento.Appearance = Appearance27
        Me.cboTipoMovimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoMovimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoMovimiento.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMovimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoMovimiento.Location = New System.Drawing.Point(277, 35)
        Me.cboTipoMovimiento.Name = "cboTipoMovimiento"
        Me.cboTipoMovimiento.Size = New System.Drawing.Size(303, 22)
        Me.cboTipoMovimiento.TabIndex = 3
        Me.cboTipoMovimiento.ValueMember = "Id"
        '
        'etiCtaBanOrigen
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Me.etiCtaBanOrigen.Appearance = Appearance28
        Me.etiCtaBanOrigen.AutoSize = True
        Me.etiCtaBanOrigen.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCtaBanOrigen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCtaBanOrigen.Location = New System.Drawing.Point(280, 105)
        Me.etiCtaBanOrigen.Name = "etiCtaBanOrigen"
        Me.etiCtaBanOrigen.Size = New System.Drawing.Size(118, 15)
        Me.etiCtaBanOrigen.TabIndex = 15
        Me.etiCtaBanOrigen.Text = "Cta Bancaria Origen:"
        '
        'fecTransf
        '
        Me.fecTransf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecTransf.Location = New System.Drawing.Point(4, 78)
        Me.fecTransf.Name = "fecTransf"
        Me.fecTransf.Size = New System.Drawing.Size(89, 20)
        Me.fecTransf.TabIndex = 5
        '
        'cboCuentaCtbleOrigen
        '
        Appearance29.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaCtbleOrigen.Appearance = Appearance29
        Me.cboCuentaCtbleOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaCtbleOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaCtbleOrigen.DropDownListWidth = 300
        Me.cboCuentaCtbleOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaCtbleOrigen.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaCtbleOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaCtbleOrigen.Location = New System.Drawing.Point(6, 121)
        Me.cboCuentaCtbleOrigen.Name = "cboCuentaCtbleOrigen"
        Me.cboCuentaCtbleOrigen.Size = New System.Drawing.Size(265, 22)
        Me.cboCuentaCtbleOrigen.TabIndex = 13
        Me.cboCuentaCtbleOrigen.ValueMember = "Id"
        '
        'Etiqueta12
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance30
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(277, 19)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(100, 15)
        Me.Etiqueta12.TabIndex = 2
        Me.Etiqueta12.Text = "Tipo Movimiento:"
        '
        'etiOrigen
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Me.etiOrigen.Appearance = Appearance31
        Me.etiOrigen.AutoSize = True
        Me.etiOrigen.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiOrigen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiOrigen.Location = New System.Drawing.Point(6, 105)
        Me.etiOrigen.Name = "etiOrigen"
        Me.etiOrigen.Size = New System.Drawing.Size(140, 15)
        Me.etiOrigen.TabIndex = 12
        Me.etiOrigen.Text = "Cuenta Contable Origen:"
        '
        'chkReposicionCajaChica
        '
        Me.chkReposicionCajaChica.AutoSize = True
        Me.chkReposicionCajaChica.BackColor = System.Drawing.Color.Transparent
        Me.chkReposicionCajaChica.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReposicionCajaChica.ForeColor = System.Drawing.Color.Navy
        Me.chkReposicionCajaChica.Location = New System.Drawing.Point(383, 245)
        Me.chkReposicionCajaChica.Name = "chkReposicionCajaChica"
        Me.chkReposicionCajaChica.Size = New System.Drawing.Size(165, 17)
        Me.chkReposicionCajaChica.TabIndex = 35
        Me.chkReposicionCajaChica.Text = "Reposicion de Caja Chica"
        Me.chkReposicionCajaChica.UseVisualStyleBackColor = False
        '
        'cboCuentaBancariaDestino
        '
        Appearance32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaBancariaDestino.Appearance = Appearance32
        Me.cboCuentaBancariaDestino.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaBancariaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaBancariaDestino.DropDownListWidth = 400
        Me.cboCuentaBancariaDestino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancariaDestino.Enabled = False
        Me.cboCuentaBancariaDestino.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancariaDestino.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaBancariaDestino.Location = New System.Drawing.Point(280, 161)
        Me.cboCuentaBancariaDestino.Name = "cboCuentaBancariaDestino"
        Me.cboCuentaBancariaDestino.Size = New System.Drawing.Size(300, 22)
        Me.cboCuentaBancariaDestino.TabIndex = 22
        Me.cboCuentaBancariaDestino.ValueMember = "Id"
        '
        'Etiqueta10
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance33
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(6, 226)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(91, 15)
        Me.Etiqueta10.TabIndex = 33
        Me.Etiqueta10.Text = "Glosa(opcional)"
        '
        'etiCtaBanDestino
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.etiCtaBanDestino.Appearance = Appearance34
        Me.etiCtaBanDestino.AutoSize = True
        Me.etiCtaBanDestino.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCtaBanDestino.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiCtaBanDestino.Location = New System.Drawing.Point(280, 145)
        Me.etiCtaBanDestino.Name = "etiCtaBanDestino"
        Me.etiCtaBanDestino.Size = New System.Drawing.Size(123, 15)
        Me.etiCtaBanDestino.TabIndex = 21
        Me.etiCtaBanDestino.Text = "Cta Bancaria Destino:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(5, 242)
        Me.txtGlosa.MaxLength = 150
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(372, 22)
        Me.txtGlosa.TabIndex = 34
        '
        'cboCuentaCtbleDestino
        '
        Appearance35.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaCtbleDestino.Appearance = Appearance35
        Me.cboCuentaCtbleDestino.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaCtbleDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaCtbleDestino.DropDownListWidth = 300
        Me.cboCuentaCtbleDestino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaCtbleDestino.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaCtbleDestino.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaCtbleDestino.Location = New System.Drawing.Point(6, 161)
        Me.cboCuentaCtbleDestino.Name = "cboCuentaCtbleDestino"
        Me.cboCuentaCtbleDestino.Size = New System.Drawing.Size(265, 22)
        Me.cboCuentaCtbleDestino.TabIndex = 19
        Me.cboCuentaCtbleDestino.ValueMember = "Id"
        '
        'etiDestino
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Me.etiDestino.Appearance = Appearance36
        Me.etiDestino.AutoSize = True
        Me.etiDestino.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDestino.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiDestino.Location = New System.Drawing.Point(6, 145)
        Me.etiDestino.Name = "etiDestino"
        Me.etiDestino.Size = New System.Drawing.Size(145, 15)
        Me.etiDestino.TabIndex = 18
        Me.etiDestino.Text = "Cuenta Contable Destino:"
        '
        'Etiqueta5
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance37
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(6, 62)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta5.TabIndex = 4
        Me.Etiqueta5.Text = "Fecha:"
        '
        'EtiImporte
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Me.EtiImporte.Appearance = Appearance38
        Me.EtiImporte.AutoSize = True
        Me.EtiImporte.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporte.ForeColor = System.Drawing.Color.MidnightBlue
        Me.EtiImporte.Location = New System.Drawing.Point(209, 187)
        Me.EtiImporte.Name = "EtiImporte"
        Me.EtiImporte.Size = New System.Drawing.Size(49, 15)
        Me.EtiImporte.TabIndex = 27
        Me.EtiImporte.Text = "Importe"
        '
        'cboMoneda
        '
        Appearance39.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance39
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(207, 77)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(100, 22)
        Me.cboMoneda.TabIndex = 9
        Me.cboMoneda.ValueMember = "Id"
        '
        'DecImporte
        '
        Appearance40.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecImporte.Appearance = Appearance40
        Me.DecImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecImporte.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecImporte.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecImporte.Location = New System.Drawing.Point(209, 203)
        Me.DecImporte.MaskInput = "{double:16.4}"
        Me.DecImporte.Name = "DecImporte"
        Me.DecImporte.NullText = "0.00"
        Me.DecImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecImporte.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecImporte.Size = New System.Drawing.Size(130, 22)
        Me.DecImporte.TabIndex = 28
        '
        'Etiqueta7
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance41
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(207, 62)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta7.TabIndex = 8
        Me.Etiqueta7.Text = "Moneda:"
        '
        'Etiqueta6
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance42
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(101, 62)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(76, 15)
        Me.Etiqueta6.TabIndex = 6
        Me.Etiqueta6.Text = "Tipo Cambio:"
        '
        'DecTC
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance43
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.FormatString = ""
        Me.DecTC.Location = New System.Drawing.Point(101, 77)
        Me.DecTC.MaskInput = "{double:6.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecTC.Size = New System.Drawing.Size(100, 22)
        Me.DecTC.TabIndex = 7
        '
        'tcTransferenciaBancaria
        '
        Me.tcTransferenciaBancaria.Controls.Add(Me.UltraTabPageControl1)
        Me.tcTransferenciaBancaria.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcTransferenciaBancaria.Controls.Add(Me.UltraTabPageControl2)
        Me.tcTransferenciaBancaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTransferenciaBancaria.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcTransferenciaBancaria.Location = New System.Drawing.Point(0, 0)
        Me.tcTransferenciaBancaria.Name = "tcTransferenciaBancaria"
        Me.tcTransferenciaBancaria.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcTransferenciaBancaria.Size = New System.Drawing.Size(926, 491)
        Me.tcTransferenciaBancaria.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcTransferenciaBancaria.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcTransferenciaBancaria.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(924, 468)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_TransferenciasBancarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(926, 491)
        Me.Controls.Add(Me.tcTransferenciaBancaria)
        Me.Name = "frm_TransferenciasBancarias"
        Me.Text = "Transferencias Bancarias"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.gridMovimientoBancarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrigenDatos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.cboCtaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDetalleAnalisis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalleAnalisis.ResumeLayout(False)
        CType(Me.griDetalleAdjunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.agrDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDescuento.ResumeLayout(False)
        Me.agrDescuento.PerformLayout()
        CType(Me.txtGlosaDscto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nroCuotaDscto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.chkCargaMasiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDsctoPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndDolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndSoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadorDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadorOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedioPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancariaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaCtbleOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancariaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaCtbleDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcTransferenciaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcTransferenciaBancaria.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents gridMovimientoBancarios As ISL.Controles.Grilla
    Friend WithEvents OrigenDatos1 As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents cboCtaBancaria As ISL.Controles.Combo
    Friend WithEvents tcTransferenciaBancaria As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents cboMedioPago As ISL.Controles.Combo
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents etiCtaBanOrigen As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaBancariaOrigen As ISL.Controles.Combo
    Friend WithEvents etiOrigen As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaCtbleOrigen As ISL.Controles.Combo
    Friend WithEvents etiDestino As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaCtbleDestino As ISL.Controles.Combo
    Friend WithEvents etiCtaBanDestino As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaBancariaDestino As ISL.Controles.Combo
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents EtiImporte As ISL.Controles.Etiqueta
    Friend WithEvents DecImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents txtCheque As ISL.Controles.Texto
    Friend WithEvents chkReposicionCajaChica As System.Windows.Forms.CheckBox
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents fecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents fecTransf As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents cboFlujoCaja As ISL.Controles.Combo
    Friend WithEvents cboTipoMovimiento As ISL.Controles.Combo
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents cboTrabajadorDestino As ISL.Controles.Combo
    Friend WithEvents cboTrabajadorOrigen As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ndDolares As ISL.Controles.NumeroDecimal
    Friend WithEvents ndSoles As ISL.Controles.NumeroDecimal
    Friend WithEvents chkDsctoPlanilla As ISL.Controles.Chequear
    Friend WithEvents agrDescuento As ISL.Controles.Agrupacion
    Friend WithEvents txtGlosaDscto As ISL.Controles.Texto
    Friend WithEvents nroCuotaDscto As ISL.Controles.Numero
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents agrDetalleAnalisis As ISL.Controles.Agrupacion
    Friend WithEvents griDetalleAdjunto As ISL.Controles.Grilla
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents btnQuitarDatos As ISL.Controles.Boton
    Friend WithEvents btnImportar As ISL.Controles.Boton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnValidarDatos As ISL.Controles.Boton
    Friend WithEvents etiValidaDatos As ISL.Controles.Etiqueta
    Friend WithEvents chkCargaMasiva As ISL.Controles.Chequear
    Friend WithEvents btnCobroDeuda As ISL.Controles.Boton
    Friend WithEvents Espere1 As ISL.Win.Espere

End Class
