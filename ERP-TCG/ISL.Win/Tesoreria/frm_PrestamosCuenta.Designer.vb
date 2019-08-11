<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PrestamosCuenta
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Egreso")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Autoriza")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConceptoIngresos")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioAutoriza")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngEgr")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Concepto")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ingreso")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Egreso")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Voucher")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Autoriza")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConceptoIngresos")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioAutoriza")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIngEgr")
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griPrestamosCuenta = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odPrestamosCuenta = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrOperaciones = New ISL.Controles.Agrupacion(Me.components)
        Me.cboCentroL = New ISL.Controles.Combo(Me.components)
        Me.etiCentro = New ISL.Controles.Etiqueta(Me.components)
        Me.decSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.verBuscarFecha = New ISL.Controles.Chequear(Me.components)
        Me.agrBuscarFecha = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.etiTotalChequeEgreso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTotalCheque = New ISL.Controles.Etiqueta(Me.components)
        Me.etiDifDepositada = New ISL.Controles.Etiqueta(Me.components)
        Me.decDifDepositada = New ISL.Controles.NumeroDecimal(Me.components)
        Me.EtiImporteDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaBancaria = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtVoucher = New ISL.Controles.Texto(Me.components)
        Me.rbEgreso = New System.Windows.Forms.RadioButton()
        Me.rbIngreso = New System.Windows.Forms.RadioButton()
        Me.etiVoucher = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajadores = New ISL.Controles.Combo(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha1 = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiConcepto = New ISL.Controles.Etiqueta(Me.components)
        Me.cboConcepto = New ISL.Controles.Combo(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ficPrestamosCuenta = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griPrestamosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odPrestamosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOperaciones.SuspendLayout()
        CType(Me.cboCentroL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verBuscarFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBuscarFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBuscarFecha.SuspendLayout()
        Me.utpDetalle.SuspendLayout()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.decDifDepositada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficPrestamosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficPrestamosCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl7.Controls.Add(Me.agrOperaciones)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1203, 385)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.griPrestamosCuenta)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 81)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1203, 304)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "Lista"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPrestamosCuenta
        '
        Me.griPrestamosCuenta.ContextMenuStrip = Me.MenuContextual1
        Me.griPrestamosCuenta.DataSource = Me.odPrestamosCuenta
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 329
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance1
        UltraGridColumn4.Format = "#,###,###,##0.00"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance2
        UltraGridColumn5.Format = "#,###,###,##0.00"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance3
        UltraGridColumn6.Format = "#,###,###,##0.00"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 200
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 298
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.griPrestamosCuenta.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griPrestamosCuenta.DisplayLayout.MaxColScrollRegions = 1
        Me.griPrestamosCuenta.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPrestamosCuenta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPrestamosCuenta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPrestamosCuenta.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPrestamosCuenta.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griPrestamosCuenta.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griPrestamosCuenta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griPrestamosCuenta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPrestamosCuenta.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPrestamosCuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPrestamosCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPrestamosCuenta.Location = New System.Drawing.Point(3, 16)
        Me.griPrestamosCuenta.Name = "griPrestamosCuenta"
        Me.griPrestamosCuenta.Size = New System.Drawing.Size(1197, 285)
        Me.griPrestamosCuenta.TabIndex = 0
        Me.griPrestamosCuenta.Text = "Prestamos Cuenta"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.EgresosToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.CierreCuentaToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(139, 92)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.InsertarToolStripMenuItem.Text = "Ingreso"
        Me.InsertarToolStripMenuItem.ToolTipText = "Ingresos"
        '
        'EgresosToolStripMenuItem
        '
        Me.EgresosToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Actualizar
        Me.EgresosToolStripMenuItem.Name = "EgresosToolStripMenuItem"
        Me.EgresosToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EgresosToolStripMenuItem.Text = "Egresos"
        Me.EgresosToolStripMenuItem.ToolTipText = "Egreso"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'CierreCuentaToolStripMenuItem
        '
        Me.CierreCuentaToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.CierreCuentaToolStripMenuItem.Name = "CierreCuentaToolStripMenuItem"
        Me.CierreCuentaToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CierreCuentaToolStripMenuItem.Text = "Cierre Cuenta"
        '
        'odPrestamosCuenta
        '
        UltraDataColumn3.DataType = GetType(Date)
        UltraDataColumn4.DataType = GetType(Double)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        Me.odPrestamosCuenta.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrOperaciones
        '
        Me.agrOperaciones.Controls.Add(Me.cboCentroL)
        Me.agrOperaciones.Controls.Add(Me.etiCentro)
        Me.agrOperaciones.Controls.Add(Me.decSaldo)
        Me.agrOperaciones.Controls.Add(Me.Etiqueta5)
        Me.agrOperaciones.Controls.Add(Me.verBuscarFecha)
        Me.agrOperaciones.Controls.Add(Me.agrBuscarFecha)
        Me.agrOperaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOperaciones.ForeColor = System.Drawing.Color.Black
        Me.agrOperaciones.Location = New System.Drawing.Point(0, 0)
        Me.agrOperaciones.Name = "agrOperaciones"
        Me.agrOperaciones.Size = New System.Drawing.Size(1203, 81)
        Me.agrOperaciones.TabIndex = 0
        Me.agrOperaciones.Text = "Rango de Fechas"
        Me.agrOperaciones.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboCentroL
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroL.Appearance = Appearance4
        Me.cboCentroL.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentroL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroL.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroL.Location = New System.Drawing.Point(368, 39)
        Me.cboCentroL.Name = "cboCentroL"
        Me.cboCentroL.Size = New System.Drawing.Size(144, 21)
        Me.cboCentroL.TabIndex = 3
        Me.cboCentroL.ValueMember = "Id"
        '
        'etiCentro
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.etiCentro.Appearance = Appearance5
        Me.etiCentro.AutoSize = True
        Me.etiCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCentro.ForeColor = System.Drawing.Color.Black
        Me.etiCentro.Location = New System.Drawing.Point(323, 40)
        Me.etiCentro.Name = "etiCentro"
        Me.etiCentro.Size = New System.Drawing.Size(40, 14)
        Me.etiCentro.TabIndex = 2
        Me.etiCentro.Text = "Centro:"
        '
        'decSaldo
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Appearance = Appearance6
        Me.decSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldo.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Location = New System.Drawing.Point(566, 38)
        Me.decSaldo.Name = "decSaldo"
        Me.decSaldo.NullText = "0.00"
        Me.decSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldo.Size = New System.Drawing.Size(100, 21)
        Me.decSaldo.TabIndex = 5
        '
        'Etiqueta5
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance7
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(526, 40)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta5.TabIndex = 4
        Me.Etiqueta5.Text = "Saldo:"
        '
        'verBuscarFecha
        '
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.verBuscarFecha.Appearance = Appearance8
        Me.verBuscarFecha.BackColor = System.Drawing.Color.Transparent
        Me.verBuscarFecha.BackColorInternal = System.Drawing.Color.Transparent
        Me.verBuscarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verBuscarFecha.ForeColor = System.Drawing.Color.Black
        Me.verBuscarFecha.Location = New System.Drawing.Point(14, 23)
        Me.verBuscarFecha.Name = "verBuscarFecha"
        Me.verBuscarFecha.Size = New System.Drawing.Size(55, 20)
        Me.verBuscarFecha.TabIndex = 0
        Me.verBuscarFecha.Text = "Fecha:"
        '
        'agrBuscarFecha
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.agrBuscarFecha.Appearance = Appearance9
        Me.agrBuscarFecha.Controls.Add(Me.Etiqueta6)
        Me.agrBuscarFecha.Controls.Add(Me.fecHasta)
        Me.agrBuscarFecha.Controls.Add(Me.Etiqueta50)
        Me.agrBuscarFecha.Controls.Add(Me.fecDesde)
        Me.agrBuscarFecha.Enabled = False
        Me.agrBuscarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBuscarFecha.ForeColor = System.Drawing.Color.Black
        Me.agrBuscarFecha.Location = New System.Drawing.Point(23, 32)
        Me.agrBuscarFecha.Name = "agrBuscarFecha"
        Me.agrBuscarFecha.Size = New System.Drawing.Size(293, 40)
        Me.agrBuscarFecha.TabIndex = 1
        Me.agrBuscarFecha.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'Etiqueta6
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance10
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(154, 10)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta6.TabIndex = 2
        Me.Etiqueta6.Text = "Hasta:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(196, 8)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(85, 20)
        Me.fecHasta.TabIndex = 3
        '
        'Etiqueta50
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta50.Appearance = Appearance11
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta50.Location = New System.Drawing.Point(7, 10)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta50.TabIndex = 0
        Me.Etiqueta50.Text = "Desde:"
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(52, 8)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(85, 20)
        Me.fecDesde.TabIndex = 1
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.agrProcesoNegocio)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1203, 385)
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.etiTotalChequeEgreso)
        Me.agrProcesoNegocio.Controls.Add(Me.etiTotalCheque)
        Me.agrProcesoNegocio.Controls.Add(Me.etiDifDepositada)
        Me.agrProcesoNegocio.Controls.Add(Me.decDifDepositada)
        Me.agrProcesoNegocio.Controls.Add(Me.EtiImporteDolares)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta9)
        Me.agrProcesoNegocio.Controls.Add(Me.DecTC)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta7)
        Me.agrProcesoNegocio.Controls.Add(Me.cboCuentaBancaria)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta11)
        Me.agrProcesoNegocio.Controls.Add(Me.txtVoucher)
        Me.agrProcesoNegocio.Controls.Add(Me.rbEgreso)
        Me.agrProcesoNegocio.Controls.Add(Me.rbIngreso)
        Me.agrProcesoNegocio.Controls.Add(Me.etiVoucher)
        Me.agrProcesoNegocio.Controls.Add(Me.etiTrabajador)
        Me.agrProcesoNegocio.Controls.Add(Me.cboTrabajadores)
        Me.agrProcesoNegocio.Controls.Add(Me.txtGlosa)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta3)
        Me.agrProcesoNegocio.Controls.Add(Me.Fecha1)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta2)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta1)
        Me.agrProcesoNegocio.Controls.Add(Me.txtImporte)
        Me.agrProcesoNegocio.Controls.Add(Me.etiConcepto)
        Me.agrProcesoNegocio.Controls.Add(Me.cboConcepto)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(1203, 285)
        Me.agrProcesoNegocio.TabIndex = 0
        Me.agrProcesoNegocio.Text = "Datos"
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'etiTotalChequeEgreso
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.etiTotalChequeEgreso.Appearance = Appearance12
        Me.etiTotalChequeEgreso.AutoSize = True
        Me.etiTotalChequeEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotalChequeEgreso.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTotalChequeEgreso.Location = New System.Drawing.Point(376, 108)
        Me.etiTotalChequeEgreso.Name = "etiTotalChequeEgreso"
        Me.etiTotalChequeEgreso.Size = New System.Drawing.Size(32, 14)
        Me.etiTotalChequeEgreso.TabIndex = 10
        Me.etiTotalChequeEgreso.Text = "Total:"
        '
        'etiTotalCheque
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.etiTotalCheque.Appearance = Appearance13
        Me.etiTotalCheque.AutoSize = True
        Me.etiTotalCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotalCheque.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTotalCheque.Location = New System.Drawing.Point(425, 108)
        Me.etiTotalCheque.Name = "etiTotalCheque"
        Me.etiTotalCheque.Size = New System.Drawing.Size(46, 14)
        Me.etiTotalCheque.TabIndex = 11
        Me.etiTotalCheque.Text = "MONTO"
        '
        'etiDifDepositada
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.etiDifDepositada.Appearance = Appearance14
        Me.etiDifDepositada.AutoSize = True
        Me.etiDifDepositada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDifDepositada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiDifDepositada.Location = New System.Drawing.Point(198, 109)
        Me.etiDifDepositada.Name = "etiDifDepositada"
        Me.etiDifDepositada.Size = New System.Drawing.Size(82, 14)
        Me.etiDifDepositada.TabIndex = 8
        Me.etiDifDepositada.Text = "Dif. Depositada:"
        Me.etiDifDepositada.Visible = False
        '
        'decDifDepositada
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decDifDepositada.Appearance = Appearance15
        Me.decDifDepositada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decDifDepositada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decDifDepositada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decDifDepositada.Location = New System.Drawing.Point(284, 107)
        Me.decDifDepositada.Name = "decDifDepositada"
        Me.decDifDepositada.NullText = "0.00"
        Me.decDifDepositada.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decDifDepositada.Size = New System.Drawing.Size(86, 21)
        Me.decDifDepositada.TabIndex = 9
        Me.decDifDepositada.Visible = False
        '
        'EtiImporteDolares
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.EtiImporteDolares.Appearance = Appearance16
        Me.EtiImporteDolares.AutoSize = True
        Me.EtiImporteDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteDolares.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteDolares.Location = New System.Drawing.Point(366, 227)
        Me.EtiImporteDolares.Name = "EtiImporteDolares"
        Me.EtiImporteDolares.Size = New System.Drawing.Size(11, 14)
        Me.EtiImporteDolares.TabIndex = 21
        Me.EtiImporteDolares.Text = "0"
        '
        'Etiqueta9
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance17
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(302, 227)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta9.TabIndex = 20
        Me.Etiqueta9.Text = "Importe $.:"
        '
        'DecTC
        '
        Appearance18.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance18
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(222, 225)
        Me.DecTC.MaskInput = "{double:6.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.Size = New System.Drawing.Size(73, 21)
        Me.DecTC.TabIndex = 19
        '
        'Etiqueta7
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance19
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(185, 228)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta7.TabIndex = 18
        Me.Etiqueta7.Text = "T.C. :"
        '
        'cboCuentaBancaria
        '
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Appearance = Appearance20
        Me.cboCuentaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaBancaria.DropDownListWidth = 600
        Me.cboCuentaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancaria.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Location = New System.Drawing.Point(90, 53)
        Me.cboCuentaBancaria.Name = "cboCuentaBancaria"
        Me.cboCuentaBancaria.Size = New System.Drawing.Size(352, 21)
        Me.cboCuentaBancaria.TabIndex = 3
        Me.cboCuentaBancaria.ValueMember = "Id"
        '
        'Etiqueta11
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance21
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(34, 53)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta11.TabIndex = 2
        Me.Etiqueta11.Text = "Cta Banc:"
        '
        'txtVoucher
        '
        Me.txtVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVoucher.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucher.Location = New System.Drawing.Point(90, 199)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(100, 21)
        Me.txtVoucher.TabIndex = 15
        '
        'rbEgreso
        '
        Me.rbEgreso.AutoSize = True
        Me.rbEgreso.BackColor = System.Drawing.Color.Transparent
        Me.rbEgreso.Location = New System.Drawing.Point(157, 28)
        Me.rbEgreso.Name = "rbEgreso"
        Me.rbEgreso.Size = New System.Drawing.Size(58, 17)
        Me.rbEgreso.TabIndex = 1
        Me.rbEgreso.Text = "Egreso"
        Me.rbEgreso.UseVisualStyleBackColor = False
        '
        'rbIngreso
        '
        Me.rbIngreso.AutoSize = True
        Me.rbIngreso.BackColor = System.Drawing.Color.Transparent
        Me.rbIngreso.Checked = True
        Me.rbIngreso.Location = New System.Drawing.Point(91, 28)
        Me.rbIngreso.Name = "rbIngreso"
        Me.rbIngreso.Size = New System.Drawing.Size(60, 17)
        Me.rbIngreso.TabIndex = 0
        Me.rbIngreso.TabStop = True
        Me.rbIngreso.Text = "Ingreso"
        Me.rbIngreso.UseVisualStyleBackColor = False
        '
        'etiVoucher
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.etiVoucher.Appearance = Appearance22
        Me.etiVoucher.AutoSize = True
        Me.etiVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiVoucher.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiVoucher.Location = New System.Drawing.Point(28, 201)
        Me.etiVoucher.Name = "etiVoucher"
        Me.etiVoucher.Size = New System.Drawing.Size(58, 14)
        Me.etiVoucher.TabIndex = 14
        Me.etiVoucher.Text = "Operacion:"
        '
        'etiTrabajador
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.etiTrabajador.Appearance = Appearance23
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTrabajador.Location = New System.Drawing.Point(35, 254)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(47, 14)
        Me.etiTrabajador.TabIndex = 22
        Me.etiTrabajador.Text = "Autoriza:"
        '
        'cboTrabajadores
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Appearance = Appearance24
        Me.cboTrabajadores.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajadores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadores.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Location = New System.Drawing.Point(90, 252)
        Me.cboTrabajadores.Name = "cboTrabajadores"
        Me.cboTrabajadores.Size = New System.Drawing.Size(352, 21)
        Me.cboTrabajadores.TabIndex = 23
        Me.cboTrabajadores.ValueMember = "Id"
        '
        'txtGlosa
        '
        Appearance25.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Appearance = Appearance25
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Location = New System.Drawing.Point(90, 134)
        Me.txtGlosa.MaxLength = 3000
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(301, 60)
        Me.txtGlosa.TabIndex = 13
        '
        'Etiqueta3
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance26
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(44, 228)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta3.TabIndex = 16
        Me.Etiqueta3.Text = "Fecha:"
        '
        'Fecha1
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.Fecha1.Appearance = Appearance27
        Me.Fecha1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha1.ForeColor = System.Drawing.Color.Black
        Me.Fecha1.Location = New System.Drawing.Point(90, 226)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(90, 21)
        Me.Fecha1.TabIndex = 17
        '
        'Etiqueta2
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance28
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(46, 136)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta2.TabIndex = 12
        Me.Etiqueta2.Text = "Glosa:"
        '
        'Etiqueta1
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance29
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(38, 109)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta1.TabIndex = 6
        Me.Etiqueta1.Text = "Importe:"
        '
        'txtImporte
        '
        Appearance30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtImporte.Appearance = Appearance30
        Me.txtImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtImporte.Location = New System.Drawing.Point(90, 107)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.NullText = "0.00"
        Me.txtImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtImporte.Size = New System.Drawing.Size(86, 21)
        Me.txtImporte.TabIndex = 7
        '
        'etiConcepto
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.etiConcepto.Appearance = Appearance31
        Me.etiConcepto.AutoSize = True
        Me.etiConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.etiConcepto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiConcepto.Location = New System.Drawing.Point(28, 82)
        Me.etiConcepto.Name = "etiConcepto"
        Me.etiConcepto.Size = New System.Drawing.Size(54, 14)
        Me.etiConcepto.TabIndex = 4
        Me.etiConcepto.Text = "Concepto:"
        '
        'cboConcepto
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.cboConcepto.Appearance = Appearance32
        Me.cboConcepto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboConcepto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboConcepto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboConcepto.Enabled = False
        Me.cboConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConcepto.ForeColor = System.Drawing.Color.Black
        Me.cboConcepto.Location = New System.Drawing.Point(90, 80)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(352, 21)
        Me.cboConcepto.TabIndex = 5
        Me.cboConcepto.ValueMember = "Id"
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1203, 385)
        '
        'ficPrestamosCuenta
        '
        Me.ficPrestamosCuenta.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficPrestamosCuenta.Controls.Add(Me.UltraTabPageControl7)
        Me.ficPrestamosCuenta.Controls.Add(Me.utpDetalle)
        Me.ficPrestamosCuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficPrestamosCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficPrestamosCuenta.Location = New System.Drawing.Point(0, 0)
        Me.ficPrestamosCuenta.Name = "ficPrestamosCuenta"
        Me.ficPrestamosCuenta.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficPrestamosCuenta.Size = New System.Drawing.Size(1205, 408)
        Me.ficPrestamosCuenta.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficPrestamosCuenta.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficPrestamosCuenta.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'frm_PrestamosCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 408)
        Me.Controls.Add(Me.ficPrestamosCuenta)
        Me.Name = "frm_PrestamosCuenta"
        Me.Text = "Prestamos Cuenta"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griPrestamosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odPrestamosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOperaciones.ResumeLayout(False)
        Me.agrOperaciones.PerformLayout()
        CType(Me.cboCentroL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verBuscarFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBuscarFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBuscarFecha.ResumeLayout(False)
        Me.agrBuscarFecha.PerformLayout()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.decDifDepositada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficPrestamosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficPrestamosCuenta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents odPrestamosCuenta As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EgresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Fecha1 As ISL.Controles.Fecha
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents etiConcepto As ISL.Controles.Etiqueta
    Friend WithEvents cboConcepto As ISL.Controles.Combo
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents ficPrestamosCuenta As ISL.Controles.Ficha
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajadores As ISL.Controles.Combo
    Friend WithEvents agrOperaciones As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents griPrestamosCuenta As ISL.Controles.Grilla
    Friend WithEvents verBuscarFecha As ISL.Controles.Chequear
    Friend WithEvents agrBuscarFecha As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiVoucher As ISL.Controles.Etiqueta
    Friend WithEvents rbEgreso As System.Windows.Forms.RadioButton
    Friend WithEvents rbIngreso As System.Windows.Forms.RadioButton
    Friend WithEvents txtVoucher As ISL.Controles.Texto
    Friend WithEvents decSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCuentaBancaria As ISL.Controles.Combo
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents EtiImporteDolares As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents etiTotalCheque As ISL.Controles.Etiqueta
    Friend WithEvents etiDifDepositada As ISL.Controles.Etiqueta
    Friend WithEvents decDifDepositada As ISL.Controles.NumeroDecimal
    Friend WithEvents etiTotalChequeEgreso As ISL.Controles.Etiqueta
    Friend WithEvents cboCentroL As ISL.Controles.Combo
    Friend WithEvents etiCentro As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
