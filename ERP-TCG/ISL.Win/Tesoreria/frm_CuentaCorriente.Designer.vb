<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CuentaCorriente
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
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreMoneda")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCuenta")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalCargo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalAbono")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejercicio")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreMoneda")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCuenta")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalCargo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalAbono")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejercicio")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorriente")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCuenta")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargo")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abono")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioLiquida")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLiquida")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Liquidado")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Movimiento")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorriente")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCuenta")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cargo")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abono")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioLiquida")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaLiquida")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Liquidado")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Movimiento")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdReferencia")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CuentaCorriente))
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaCuentaCorriente = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.orgCuentaCorriente = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrTotalCuentaCorriente = New ISL.Controles.Agrupacion(Me.components)
        Me.opcListaCC = New ISL.Controles.Opciones(Me.components)
        Me.verEjercicio = New ISL.Controles.Chequear(Me.components)
        Me.AñoEjercicio = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griSaldoCC = New ISL.Controles.Grilla(Me.components)
        Me.ogdSaldoCC = New ISL.Controles.OrigenDatos(Me.components)
        Me.Gb_DatoGeneralCuentaTrabajador = New Infragistics.Win.Misc.UltraGroupBox()
        Me.decEjercicio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.decTotalAbono = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.decTotalCargo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboCliente = New ISL.Controles.ComboMaestros(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraLabel34 = New Infragistics.Win.Misc.UltraLabel()
        Me.opcTipo = New ISL.Controles.Opciones(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.decSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtNumeroCuentaCorriente = New ISL.Controles.Texto(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.lblcodigo = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.mcPrestamos = New ISL.Controles.MenuContextual(Me.components)
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.ficCuentaCorriente = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griListaCuentaCorriente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.orgCuentaCorriente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrTotalCuentaCorriente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalCuentaCorriente.SuspendLayout()
        CType(Me.opcListaCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AñoEjercicio.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.griSaldoCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdSaldoCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gb_DatoGeneralCuentaTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralCuentaTrabajador.SuspendLayout()
        CType(Me.decEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalAbono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opcTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroCuentaCorriente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcPrestamos.SuspendLayout()
        CType(Me.ficCuentaCorriente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCuentaCorriente.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griListaCuentaCorriente)
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalCuentaCorriente)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(982, 438)
        '
        'griListaCuentaCorriente
        '
        Me.griListaCuentaCorriente.ContextMenuStrip = Me.MenuContextual1
        Me.griListaCuentaCorriente.DataSource = Me.orgCuentaCorriente
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn19.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.Width = 99
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance1.TextVAlignAsString = "Middle"
        UltraGridColumn21.CellAppearance = Appearance1
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn21.Header.Caption = "Trabajador/Empresa"
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn21.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn21.Width = 300
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.Hidden = True
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn23.CellAppearance = Appearance2
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn23.Header.Caption = "Moneda"
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.Width = 53
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn24.CellAppearance = Appearance3
        UltraGridColumn24.Header.VisiblePosition = 11
        UltraGridColumn24.MaskInput = ""
        UltraGridColumn24.Width = 100
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn25.Header.VisiblePosition = 12
        UltraGridColumn25.Width = 300
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn26.Header.VisiblePosition = 6
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn27.Header.VisiblePosition = 7
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.Width = 84
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn28.Header.VisiblePosition = 8
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 9
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 10
        UltraGridColumn30.Width = 150
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance4
        UltraGridColumn31.Header.VisiblePosition = 13
        UltraGridColumn31.MaskInput = ""
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn32.CellAppearance = Appearance5
        UltraGridColumn32.Header.VisiblePosition = 14
        UltraGridColumn32.MaskInput = ""
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn33.CellAppearance = Appearance6
        UltraGridColumn33.Header.VisiblePosition = 15
        UltraGridColumn33.MaskInput = "nnnn"
        UltraGridColumn33.Width = 40
        UltraGridColumn34.Header.VisiblePosition = 16
        UltraGridColumn34.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34})
        Me.griListaCuentaCorriente.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaCuentaCorriente.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaCuentaCorriente.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaCuentaCorriente.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaCuentaCorriente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaCuentaCorriente.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaCuentaCorriente.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaCuentaCorriente.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaCuentaCorriente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaCuentaCorriente.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaCuentaCorriente.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaCuentaCorriente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaCuentaCorriente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaCuentaCorriente.Location = New System.Drawing.Point(0, 100)
        Me.griListaCuentaCorriente.Name = "griListaCuentaCorriente"
        Me.griListaCuentaCorriente.Size = New System.Drawing.Size(982, 338)
        Me.griListaCuentaCorriente.TabIndex = 1
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
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Cuenta Corriente"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar  la Cuenta Corriente seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la Cuenta Corriente seleccionada"
        '
        'orgCuentaCorriente
        '
        UltraDataColumn4.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn6.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn7.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn8.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn11.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        Me.orgCuentaCorriente.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrTotalCuentaCorriente
        '
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.agrTotalCuentaCorriente.ContentAreaAppearance = Appearance7
        Me.agrTotalCuentaCorriente.Controls.Add(Me.opcListaCC)
        Me.agrTotalCuentaCorriente.Controls.Add(Me.verEjercicio)
        Me.agrTotalCuentaCorriente.Controls.Add(Me.AñoEjercicio)
        Me.agrTotalCuentaCorriente.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrTotalCuentaCorriente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalCuentaCorriente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrTotalCuentaCorriente.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalCuentaCorriente.Name = "agrTotalCuentaCorriente"
        Me.agrTotalCuentaCorriente.Size = New System.Drawing.Size(982, 100)
        Me.agrTotalCuentaCorriente.TabIndex = 0
        Me.agrTotalCuentaCorriente.Text = "Total de Cuentas Corriente"
        Me.agrTotalCuentaCorriente.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'opcListaCC
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.opcListaCC.Appearance = Appearance8
        Me.opcListaCC.BackColor = System.Drawing.Color.Transparent
        Me.opcListaCC.BackColorInternal = System.Drawing.Color.Transparent
        Me.opcListaCC.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.opcListaCC.CheckedIndex = 4
        Me.opcListaCC.Dock = System.Windows.Forms.DockStyle.Left
        Me.opcListaCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcListaCC.ForeColor = System.Drawing.Color.Black
        ValueListItem12.DataValue = "Default Item"
        ValueListItem12.DisplayText = "Personal"
        ValueListItem13.DataValue = "ValueListItem1"
        ValueListItem13.DisplayText = "Administrativo"
        ValueListItem2.DataValue = "2"
        ValueListItem2.DisplayText = "Transferencia"
        ValueListItem1.DataValue = "3"
        ValueListItem1.DisplayText = "Empresa"
        ValueListItem3.DataValue = "4"
        ValueListItem3.DisplayText = "TODOS"
        Me.opcListaCC.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem12, ValueListItem13, ValueListItem2, ValueListItem1, ValueListItem3})
        Me.opcListaCC.ItemSpacingVertical = 5
        Me.opcListaCC.Location = New System.Drawing.Point(3, 16)
        Me.opcListaCC.Name = "opcListaCC"
        Me.opcListaCC.Size = New System.Drawing.Size(185, 81)
        Me.opcListaCC.TabIndex = 0
        Me.opcListaCC.Text = "TODOS"
        '
        'verEjercicio
        '
        Me.verEjercicio.AutoSize = True
        Me.verEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verEjercicio.ForeColor = System.Drawing.Color.Black
        Me.verEjercicio.Location = New System.Drawing.Point(194, 19)
        Me.verEjercicio.Name = "verEjercicio"
        Me.verEjercicio.Size = New System.Drawing.Size(63, 17)
        Me.verEjercicio.TabIndex = 1
        Me.verEjercicio.Text = "Ejercicio"
        '
        'AñoEjercicio
        '
        Me.AñoEjercicio.Año = 2015
        Me.AñoEjercicio.AutoSize = True
        Me.AñoEjercicio.Controls.Add(Me.numAño)
        Me.AñoEjercicio.Controls.Add(Me.NumeroEntero1)
        Me.AñoEjercicio.Controls.Add(Me.NumeroEntero2)
        Me.AñoEjercicio.Location = New System.Drawing.Point(201, 42)
        Me.AñoEjercicio.Name = "AñoEjercicio"
        Me.AñoEjercicio.Size = New System.Drawing.Size(56, 24)
        Me.AñoEjercicio.TabIndex = 6
        '
        'numAño
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance9
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
        Me.numAño.Value = 2013
        '
        'NumeroEntero1
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance10
        Me.NumeroEntero1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero1.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.FormatString = ""
        Me.NumeroEntero1.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero1.MaskInput = "nnnn"
        Me.NumeroEntero1.MaxValue = 2020
        Me.NumeroEntero1.MinValue = 2000
        Me.NumeroEntero1.Name = "NumeroEntero1"
        Me.NumeroEntero1.NullText = "0"
        Me.NumeroEntero1.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero1.TabIndex = 0
        Me.NumeroEntero1.Value = 2011
        '
        'NumeroEntero2
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.Appearance = Appearance11
        Me.NumeroEntero2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero2.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.FormatString = ""
        Me.NumeroEntero2.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero2.MaskInput = "nnnn"
        Me.NumeroEntero2.MaxValue = 2020
        Me.NumeroEntero2.MinValue = 2000
        Me.NumeroEntero2.Name = "NumeroEntero2"
        Me.NumeroEntero2.NullText = "0"
        Me.NumeroEntero2.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero2.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero2.TabIndex = 0
        Me.NumeroEntero2.Value = 2011
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.griSaldoCC)
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralCuentaTrabajador)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(982, 438)
        '
        'griSaldoCC
        '
        Me.griSaldoCC.ContextMenuStrip = Me.MenuContextual1
        Me.griSaldoCC.DataSource = Me.ogdSaldoCC
        UltraGridColumn35.Header.Caption = "Serie"
        UltraGridColumn35.Header.VisiblePosition = 13
        UltraGridColumn35.Width = 40
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 2
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 3
        UltraGridColumn39.Hidden = True
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn40.CellAppearance = Appearance12
        UltraGridColumn40.Header.VisiblePosition = 4
        UltraGridColumn40.MaskInput = ""
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance13
        UltraGridColumn41.Header.VisiblePosition = 5
        UltraGridColumn41.MaskInput = ""
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance14
        UltraGridColumn42.Header.VisiblePosition = 6
        UltraGridColumn42.MaskInput = ""
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn43.CellAppearance = Appearance15
        UltraGridColumn43.Header.VisiblePosition = 7
        UltraGridColumn43.MaskInput = ""
        UltraGridColumn44.Header.VisiblePosition = 8
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 15
        UltraGridColumn45.Width = 200
        UltraGridColumn46.Header.VisiblePosition = 16
        UltraGridColumn46.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn46.Width = 90
        UltraGridColumn47.Header.VisiblePosition = 9
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 10
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 11
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 12
        UltraGridColumn51.Header.Caption = "Numero"
        UltraGridColumn51.Header.VisiblePosition = 14
        UltraGridColumn51.Width = 70
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51})
        Me.griSaldoCC.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griSaldoCC.DisplayLayout.MaxColScrollRegions = 1
        Me.griSaldoCC.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griSaldoCC.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griSaldoCC.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griSaldoCC.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griSaldoCC.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griSaldoCC.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griSaldoCC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griSaldoCC.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griSaldoCC.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griSaldoCC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griSaldoCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griSaldoCC.Location = New System.Drawing.Point(0, 150)
        Me.griSaldoCC.Name = "griSaldoCC"
        Me.griSaldoCC.Size = New System.Drawing.Size(982, 288)
        Me.griSaldoCC.TabIndex = 1
        '
        'ogdSaldoCC
        '
        Me.ogdSaldoCC.Band.Columns.AddRange(New Object() {UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34})
        '
        'Gb_DatoGeneralCuentaTrabajador
        '
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.BackColor2 = System.Drawing.Color.White
        Me.Gb_DatoGeneralCuentaTrabajador.ContentAreaAppearance = Appearance16
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.decEjercicio)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel11)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.decTotalAbono)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel10)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.decTotalCargo)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel9)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboCliente)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel34)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.opcTipo)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboTrabajador)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboMoneda)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.decSaldo)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.txtNumeroCuentaCorriente)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.txtGlosa)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.lblcodigo)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel2)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel4)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel5)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel1)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel22)
        Me.Gb_DatoGeneralCuentaTrabajador.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralCuentaTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralCuentaTrabajador.Name = "Gb_DatoGeneralCuentaTrabajador"
        Me.Gb_DatoGeneralCuentaTrabajador.Size = New System.Drawing.Size(982, 150)
        Me.Gb_DatoGeneralCuentaTrabajador.TabIndex = 0
        Me.Gb_DatoGeneralCuentaTrabajador.Text = "Datos Generales"
        Me.Gb_DatoGeneralCuentaTrabajador.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decEjercicio
        '
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decEjercicio.Appearance = Appearance17
        Me.decEjercicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decEjercicio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decEjercicio.Location = New System.Drawing.Point(386, 24)
        Me.decEjercicio.MaskInput = "nnnn"
        Me.decEjercicio.Name = "decEjercicio"
        Me.decEjercicio.NullText = "2013"
        Me.decEjercicio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decEjercicio.Size = New System.Drawing.Size(40, 21)
        Me.decEjercicio.TabIndex = 3
        '
        'UltraLabel11
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance18
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(332, 28)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel11.TabIndex = 2
        Me.UltraLabel11.Text = "Ejercicio:"
        '
        'decTotalAbono
        '
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTotalAbono.Appearance = Appearance19
        Me.decTotalAbono.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalAbono.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTotalAbono.Location = New System.Drawing.Point(502, 73)
        Me.decTotalAbono.MaskInput = "{LOC}-nn,nnn,nnn.nn"
        Me.decTotalAbono.Name = "decTotalAbono"
        Me.decTotalAbono.NullText = "0.00"
        Me.decTotalAbono.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalAbono.Size = New System.Drawing.Size(100, 21)
        Me.decTotalAbono.TabIndex = 17
        '
        'UltraLabel10
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance20
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(432, 77)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel10.TabIndex = 16
        Me.UltraLabel10.Text = "Total Abono:"
        '
        'decTotalCargo
        '
        Appearance21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTotalCargo.Appearance = Appearance21
        Me.decTotalCargo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalCargo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTotalCargo.Location = New System.Drawing.Point(502, 50)
        Me.decTotalCargo.MaskInput = "{LOC}-nn,nnn,nnn.nn"
        Me.decTotalCargo.Name = "decTotalCargo"
        Me.decTotalCargo.NullText = "0.00"
        Me.decTotalCargo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalCargo.Size = New System.Drawing.Size(100, 21)
        Me.decTotalCargo.TabIndex = 15
        '
        'UltraLabel9
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance22
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(433, 54)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel9.TabIndex = 14
        Me.UltraLabel9.Text = "Total Cargo:"
        '
        'cboCliente
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Appearance = Appearance23
        Me.cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.ImageList = Me.imagenes
        Me.cboCliente.Location = New System.Drawing.Point(76, 96)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(350, 21)
        Me.cboCliente.TabIndex = 9
        Me.cboCliente.ValueMember = "Id"
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "")
        Me.imagenes.Images.SetKeyName(1, "")
        Me.imagenes.Images.SetKeyName(2, "")
        Me.imagenes.Images.SetKeyName(3, "")
        Me.imagenes.Images.SetKeyName(4, "")
        Me.imagenes.Images.SetKeyName(5, "")
        Me.imagenes.Images.SetKeyName(6, "")
        Me.imagenes.Images.SetKeyName(7, "")
        Me.imagenes.Images.SetKeyName(8, "")
        Me.imagenes.Images.SetKeyName(9, "")
        Me.imagenes.Images.SetKeyName(10, "")
        Me.imagenes.Images.SetKeyName(11, "add.ico")
        '
        'UltraLabel34
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Appearance24.TextVAlignAsString = "Middle"
        Me.UltraLabel34.Appearance = Appearance24
        Me.UltraLabel34.AutoSize = True
        Me.UltraLabel34.Location = New System.Drawing.Point(30, 100)
        Me.UltraLabel34.Name = "UltraLabel34"
        Me.UltraLabel34.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel34.TabIndex = 8
        Me.UltraLabel34.Text = "Cliente:"
        '
        'opcTipo
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.opcTipo.Appearance = Appearance25
        Me.opcTipo.BackColor = System.Drawing.Color.Transparent
        Me.opcTipo.BackColorInternal = System.Drawing.Color.Transparent
        Me.opcTipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.opcTipo.CheckedIndex = 0
        Me.opcTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcTipo.ForeColor = System.Drawing.Color.Black
        ValueListItem4.DataValue = "Default Item"
        ValueListItem4.DisplayText = "Personal"
        ValueListItem5.DataValue = "ValueListItem1"
        ValueListItem5.DisplayText = "Administrativo"
        ValueListItem6.DataValue = "2"
        ValueListItem6.DisplayText = "Transferencia"
        ValueListItem7.DataValue = "3"
        ValueListItem7.DisplayText = "Empresa"
        Me.opcTipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem4, ValueListItem5, ValueListItem6, ValueListItem7})
        Me.opcTipo.ItemSpacingVertical = 5
        Me.opcTipo.Location = New System.Drawing.Point(76, 47)
        Me.opcTipo.Name = "opcTipo"
        Me.opcTipo.Size = New System.Drawing.Size(350, 24)
        Me.opcTipo.TabIndex = 5
        Me.opcTipo.Text = "Personal"
        '
        'cboTrabajador
        '
        Appearance26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Appearance = Appearance26
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Location = New System.Drawing.Point(76, 73)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(350, 21)
        Me.cboTrabajador.TabIndex = 7
        Me.cboTrabajador.ValueMember = "Id"
        '
        'cboMoneda
        '
        Appearance27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance27
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(502, 27)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(100, 21)
        Me.cboMoneda.TabIndex = 13
        Me.cboMoneda.ValueMember = "Id"
        '
        'decSaldo
        '
        Appearance28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decSaldo.Appearance = Appearance28
        Me.decSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decSaldo.Location = New System.Drawing.Point(502, 96)
        Me.decSaldo.MaskInput = "{LOC}-nn,nnn,nnn.nn"
        Me.decSaldo.Name = "decSaldo"
        Me.decSaldo.NullText = "0.00"
        Me.decSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldo.Size = New System.Drawing.Size(100, 21)
        Me.decSaldo.TabIndex = 19
        '
        'txtNumeroCuentaCorriente
        '
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroCuentaCorriente.Appearance = Appearance29
        Me.txtNumeroCuentaCorriente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCuentaCorriente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroCuentaCorriente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCuentaCorriente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroCuentaCorriente.Location = New System.Drawing.Point(76, 24)
        Me.txtNumeroCuentaCorriente.MaxLength = 10
        Me.txtNumeroCuentaCorriente.Name = "txtNumeroCuentaCorriente"
        Me.txtNumeroCuentaCorriente.ReadOnly = True
        Me.txtNumeroCuentaCorriente.Size = New System.Drawing.Size(100, 21)
        Me.txtNumeroCuentaCorriente.TabIndex = 1
        Me.txtNumeroCuentaCorriente.Visible = False
        '
        'txtGlosa
        '
        Appearance30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance30
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Location = New System.Drawing.Point(76, 120)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(526, 21)
        Me.txtGlosa.TabIndex = 11
        '
        'lblcodigo
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Appearance31.TextVAlignAsString = "Middle"
        Me.lblcodigo.Appearance = Appearance31
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(31, 28)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblcodigo.TabIndex = 0
        Me.lblcodigo.Text = "Codigo:"
        Me.lblcodigo.Visible = False
        '
        'UltraLabel2
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance32
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(463, 100)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel2.TabIndex = 18
        Me.UltraLabel2.Text = "Saldo:"
        '
        'UltraLabel4
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Appearance33.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance33
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(6, 54)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(69, 14)
        Me.UltraLabel4.TabIndex = 4
        Me.UltraLabel4.Text = "Tipo Cuenta:"
        '
        'UltraLabel5
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Appearance34.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance34
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(36, 124)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel5.TabIndex = 10
        Me.UltraLabel5.Text = "Glosa:"
        '
        'UltraLabel1
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance35
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 77)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel1.TabIndex = 6
        Me.UltraLabel1.Text = "Trabajador:"
        '
        'UltraLabel22
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Appearance36.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance36
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(452, 31)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel22.TabIndex = 12
        Me.UltraLabel22.Text = "Moneda:"
        '
        'mcPrestamos
        '
        Me.mcPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcPrestamos.ForeColor = System.Drawing.Color.Black
        Me.mcPrestamos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.QuitarToolStripMenuItem})
        Me.mcPrestamos.Name = "mcPrestamos"
        Me.mcPrestamos.Size = New System.Drawing.Size(118, 92)
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ConsultarToolStripMenuItem.Text = "Mostrar"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Actualizar
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1255, 226)
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje del sistema"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(294, 196)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 1
        Me.ugb_Espera.Visible = False
        '
        'ficCuentaCorriente
        '
        Me.ficCuentaCorriente.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficCuentaCorriente.Controls.Add(Me.UltraTabPageControl7)
        Me.ficCuentaCorriente.Controls.Add(Me.utpDetalle)
        Me.ficCuentaCorriente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCuentaCorriente.Location = New System.Drawing.Point(0, 0)
        Me.ficCuentaCorriente.Name = "ficCuentaCorriente"
        Me.ficCuentaCorriente.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficCuentaCorriente.Size = New System.Drawing.Size(984, 461)
        Me.ficCuentaCorriente.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficCuentaCorriente.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficCuentaCorriente.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(982, 438)
        '
        'frm_CuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.ContextMenuStrip = Me.MenuContextual1
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficCuentaCorriente)
        Me.Name = "frm_CuentaCorriente"
        Me.Text = "Cuenta Corriente"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griListaCuentaCorriente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.orgCuentaCorriente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrTotalCuentaCorriente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalCuentaCorriente.ResumeLayout(False)
        Me.agrTotalCuentaCorriente.PerformLayout()
        CType(Me.opcListaCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AñoEjercicio.ResumeLayout(False)
        Me.AñoEjercicio.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.griSaldoCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdSaldoCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gb_DatoGeneralCuentaTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralCuentaTrabajador.ResumeLayout(False)
        Me.Gb_DatoGeneralCuentaTrabajador.PerformLayout()
        CType(Me.decEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalAbono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opcTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroCuentaCorriente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcPrestamos.ResumeLayout(False)
        CType(Me.ficCuentaCorriente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCuentaCorriente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficCuentaCorriente As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents orgCuentaCorriente As ISL.Controles.OrigenDatos
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaCuentaCorriente As ISL.Controles.Grilla
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralCuentaTrabajador As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents decSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents txtNumeroCuentaCorriente As ISL.Controles.Texto
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents lblcodigo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents agrTotalCuentaCorriente As ISL.Controles.Agrupacion
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mcPrestamos As ISL.Controles.MenuContextual
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcTipo As ISL.Controles.Opciones
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCliente As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel34 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents decTotalAbono As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decTotalCargo As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decEjercicio As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents AñoEjercicio As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero2 As ISL.Controles.NumeroEntero
    Friend WithEvents verEjercicio As ISL.Controles.Chequear
    Friend WithEvents opcListaCC As ISL.Controles.Opciones
    Friend WithEvents griSaldoCC As ISL.Controles.Grilla
    Friend WithEvents ogdSaldoCC As ISL.Controles.OrigenDatos

End Class
