<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Flete
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCheque")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobrado")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCobro")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorCobro")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorCobro")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorriente")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Asociado")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCheque")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cobrado")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCobro")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajadorCobro")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TrabajadorCobro")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorriente")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Asociado")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.verAdelanto = New ISL.Controles.Chequear(Me.components)
        Me.agrCheque = New ISL.Controles.Agrupacion(Me.components)
        Me.cboBanco = New ISL.Controles.Combo(Me.components)
        Me.fecFechaCheque = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNumeroCheque = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.verCheque = New ISL.Controles.Chequear(Me.components)
        Me.agrCargar = New ISL.Controles.Agrupacion(Me.components)
        Me.etiSaldoCarga = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.fecFechaCarga = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.decImporteCarga = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.expCheque = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griChequexCobrar = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextualCheque = New ISL.Controles.MenuContextual(Me.components)
        Me.mnuConsultarCheque = New System.Windows.Forms.ToolStripMenuItem()
        Me.ordChequexCobrar = New ISL.Controles.OrigenDatos(Me.components)
        Me.expCobro = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.etiSaldoFlete = New ISL.Controles.Etiqueta(Me.components)
        Me.verChequePorCobrar = New ISL.Controles.Chequear(Me.components)
        Me.decImporteCobro = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosaCobro = New ISL.Controles.Texto(Me.components)
        Me.verExtornoCobro = New ISL.Controles.Chequear(Me.components)
        Me.fecFechaCobro = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDetalleCargarCobrar = New ISL.Controles.Agrupacion(Me.components)
        Me.GriMovimientoFleteGlobal = New ISL.Controles.Grilla(Me.components)
        Me.agrFleteCarga = New ISL.Controles.Agrupacion(Me.components)
        Me.agrDerechaCargar_Cobrar = New ISL.Controles.Agrupacion(Me.components)
        Me.ficCargar_Cobrar = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrViaje = New ISL.Controles.Agrupacion(Me.components)
        Me.ficCargaFlete = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage9 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiEstadoAsociado = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFechaViajeAsociado = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRutaCarga = New ISL.Controles.Etiqueta(Me.components)
        Me.eti = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFecha = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRutaAsociada = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajadorFlete = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSaldoViaje = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboViaje = New ISL.Controles.Combo(Me.components)
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cboAdm = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOperaciones = New ISL.Controles.Agrupacion(Me.components)
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.expOperacionDetalle = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griViajeDetalle = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual = New ISL.Controles.MenuContextual(Me.components)
        Me.MnuCargar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Filtro = New ISL.Controles.Filtro(Me.components)
        Me.expCuentaFlete = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.agr1 = New ISL.Controles.Agrupacion(Me.components)
        Me.agr2 = New ISL.Controles.Agrupacion(Me.components)
        Me.griMovimientoFlete = New ISL.Controles.Grilla(Me.components)
        Me.MenuExtornar = New ISL.Controles.MenuContextual(Me.components)
        Me.MnuExtornar = New System.Windows.Forms.ToolStripMenuItem()
        Me.agrSaldoFlete = New ISL.Controles.Agrupacion(Me.components)
        Me.decSaldoPorDepositar = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta39 = New ISL.Controles.Etiqueta(Me.components)
        Me.decFleteDepositado = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decTotalCargado = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.decMontoFlete = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSaldoFlete = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiSaldo = New ISL.Controles.Etiqueta(Me.components)
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.EtiCargado = New ISL.Controles.Etiqueta(Me.components)
        Me.verBuscarOtros = New ISL.Controles.Chequear(Me.components)
        Me.verContraEntrega = New ISL.Controles.Chequear(Me.components)
        Me.colorCargado = New ISL.Controles.Colores(Me.components)
        Me.verBuscarFecha = New ISL.Controles.Chequear(Me.components)
        Me.agrBuscarFecha = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.agrBuscarOtros = New ISL.Controles.Agrupacion(Me.components)
        Me.cboCentro = New ISL.Controles.Combo(Me.components)
        Me.etiCentro = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViaje = New ISL.Controles.Texto(Me.components)
        Me.txtOperacion = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboPlaca = New ISL.Controles.Combo(Me.components)
        Me.cboCarga = New ISL.Controles.Combo(Me.components)
        Me.etiViaje = New Infragistics.Win.Misc.UltraLabel()
        Me.cboCliente = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.etiTrabajadorCuenta = New ISL.Controles.Etiqueta(Me.components)
        Me.etitracto = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.exgruViaje = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ficMovimientoFlete = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ficOperacion = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Texto1 = New ISL.Controles.Texto(Me.components)
        Me.Fecha3 = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDecimal1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.ficDetalleGrupo = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage6 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabSharedControlsPage8 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.verAdelanto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrCheque.SuspendLayout()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrCargar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrCargar.SuspendLayout()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImporteCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.expCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expCheque.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.griChequexCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextualCheque.SuspendLayout()
        CType(Me.ordChequexCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expCobro.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout()
        CType(Me.verChequePorCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImporteCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosaCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verExtornoCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDetalleCargarCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalleCargarCobrar.SuspendLayout()
        CType(Me.GriMovimientoFleteGlobal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrFleteCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFleteCarga.SuspendLayout()
        CType(Me.agrDerechaCargar_Cobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDerechaCargar_Cobrar.SuspendLayout()
        CType(Me.ficCargar_Cobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCargar_Cobrar.SuspendLayout()
        CType(Me.agrViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrViaje.SuspendLayout()
        CType(Me.ficCargaFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCargaFlete.SuspendLayout()
        Me.UltraTabPageControl13.SuspendLayout()
        CType(Me.cboTrabajadorFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldoViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl14.SuspendLayout()
        CType(Me.cboAdm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOperaciones.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expOperacionDetalle.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griViajeDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual.SuspendLayout()
        CType(Me.expCuentaFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expCuentaFlete.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.agr1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agr1.SuspendLayout()
        CType(Me.agr2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agr2.SuspendLayout()
        CType(Me.griMovimientoFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuExtornar.SuspendLayout()
        CType(Me.agrSaldoFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrSaldoFlete.SuspendLayout()
        CType(Me.decSaldoPorDepositar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decFleteDepositado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalCargado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldoFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.verBuscarOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verContraEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCargado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verBuscarFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBuscarFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBuscarFecha.SuspendLayout()
        CType(Me.agrBuscarOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBuscarOtros.SuspendLayout()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruViaje.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.ficMovimientoFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMovimientoFlete.SuspendLayout()
        CType(Me.ficOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOperacion.SuspendLayout()
        CType(Me.Texto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDetalleGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.verAdelanto)
        Me.UltraTabPageControl6.Controls.Add(Me.agrCheque)
        Me.UltraTabPageControl6.Controls.Add(Me.verCheque)
        Me.UltraTabPageControl6.Controls.Add(Me.agrCargar)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(862, 206)
        '
        'verAdelanto
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.verAdelanto.Appearance = Appearance1
        Me.verAdelanto.BackColor = System.Drawing.Color.Transparent
        Me.verAdelanto.BackColorInternal = System.Drawing.Color.Transparent
        Me.verAdelanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verAdelanto.ForeColor = System.Drawing.Color.Black
        Me.verAdelanto.Location = New System.Drawing.Point(3, 3)
        Me.verAdelanto.Name = "verAdelanto"
        Me.verAdelanto.Size = New System.Drawing.Size(79, 20)
        Me.verAdelanto.TabIndex = 0
        Me.verAdelanto.Text = "Adelanto"
        '
        'agrCheque
        '
        Me.agrCheque.Controls.Add(Me.cboBanco)
        Me.agrCheque.Controls.Add(Me.fecFechaCheque)
        Me.agrCheque.Controls.Add(Me.Etiqueta17)
        Me.agrCheque.Controls.Add(Me.txtNumeroCheque)
        Me.agrCheque.Controls.Add(Me.Etiqueta14)
        Me.agrCheque.Controls.Add(Me.Etiqueta10)
        Me.agrCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCheque.ForeColor = System.Drawing.Color.Black
        Me.agrCheque.Location = New System.Drawing.Point(88, 109)
        Me.agrCheque.Name = "agrCheque"
        Me.agrCheque.Size = New System.Drawing.Size(425, 79)
        Me.agrCheque.TabIndex = 3
        Me.agrCheque.Text = "Datos Cheque"
        Me.agrCheque.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboBanco
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboBanco.Appearance = Appearance2
        Me.cboBanco.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.ForeColor = System.Drawing.Color.Black
        Me.cboBanco.Location = New System.Drawing.Point(57, 22)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(349, 21)
        Me.cboBanco.TabIndex = 1
        Me.cboBanco.ValueMember = "Id"
        '
        'fecFechaCheque
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.fecFechaCheque.Appearance = Appearance3
        Me.fecFechaCheque.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaCheque.ForeColor = System.Drawing.Color.Black
        Me.fecFechaCheque.Location = New System.Drawing.Point(296, 49)
        Me.fecFechaCheque.Name = "fecFechaCheque"
        Me.fecFechaCheque.Size = New System.Drawing.Size(110, 21)
        Me.fecFechaCheque.TabIndex = 5
        '
        'Etiqueta17
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance4
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(223, 53)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta17.TabIndex = 4
        Me.Etiqueta17.Text = "Fecha Cobro"
        '
        'txtNumeroCheque
        '
        Me.txtNumeroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCheque.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCheque.Location = New System.Drawing.Point(57, 49)
        Me.txtNumeroCheque.Name = "txtNumeroCheque"
        Me.txtNumeroCheque.Size = New System.Drawing.Size(160, 21)
        Me.txtNumeroCheque.TabIndex = 3
        '
        'Etiqueta14
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance5
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(16, 26)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta14.TabIndex = 0
        Me.Etiqueta14.Text = "Banco"
        '
        'Etiqueta10
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance6
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(8, 53)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta10.TabIndex = 2
        Me.Etiqueta10.Text = "Cheque"
        '
        'verCheque
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.BackColor2 = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.verCheque.Appearance = Appearance7
        Me.verCheque.BackColor = System.Drawing.Color.Transparent
        Me.verCheque.BackColorInternal = System.Drawing.Color.Transparent
        Me.verCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verCheque.ForeColor = System.Drawing.Color.Black
        Me.verCheque.Location = New System.Drawing.Point(3, 107)
        Me.verCheque.Name = "verCheque"
        Me.verCheque.Size = New System.Drawing.Size(79, 20)
        Me.verCheque.TabIndex = 2
        Me.verCheque.Text = "Documento"
        '
        'agrCargar
        '
        Me.agrCargar.Controls.Add(Me.etiSaldoCarga)
        Me.agrCargar.Controls.Add(Me.Etiqueta30)
        Me.agrCargar.Controls.Add(Me.Etiqueta11)
        Me.agrCargar.Controls.Add(Me.txtGlosa)
        Me.agrCargar.Controls.Add(Me.fecFechaCarga)
        Me.agrCargar.Controls.Add(Me.Etiqueta12)
        Me.agrCargar.Controls.Add(Me.Etiqueta21)
        Me.agrCargar.Controls.Add(Me.decImporteCarga)
        Me.agrCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCargar.ForeColor = System.Drawing.Color.Black
        Me.agrCargar.Location = New System.Drawing.Point(88, 4)
        Me.agrCargar.Name = "agrCargar"
        Me.agrCargar.Size = New System.Drawing.Size(425, 99)
        Me.agrCargar.TabIndex = 1
        Me.agrCargar.Text = "Cargar"
        Me.agrCargar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'etiSaldoCarga
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.etiSaldoCarga.Appearance = Appearance8
        Me.etiSaldoCarga.AutoSize = True
        Me.etiSaldoCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSaldoCarga.ForeColor = System.Drawing.Color.Black
        Me.etiSaldoCarga.Location = New System.Drawing.Point(169, 25)
        Me.etiSaldoCarga.Name = "etiSaldoCarga"
        Me.etiSaldoCarga.Size = New System.Drawing.Size(10, 14)
        Me.etiSaldoCarga.TabIndex = 3
        Me.etiSaldoCarga.Text = "0"
        '
        'Etiqueta30
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance9
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta30.Location = New System.Drawing.Point(151, 25)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(17, 14)
        Me.Etiqueta30.TabIndex = 2
        Me.Etiqueta30.Text = "S/."
        '
        'Etiqueta11
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance10
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(23, 50)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta11.TabIndex = 6
        Me.Etiqueta11.Text = "Glosa"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtGlosa.Location = New System.Drawing.Point(62, 48)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(330, 45)
        Me.txtGlosa.TabIndex = 7
        '
        'fecFechaCarga
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.fecFechaCarga.Appearance = Appearance11
        Me.fecFechaCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaCarga.ForeColor = System.Drawing.Color.Black
        Me.fecFechaCarga.Location = New System.Drawing.Point(245, 21)
        Me.fecFechaCarga.Name = "fecFechaCarga"
        Me.fecFechaCarga.Size = New System.Drawing.Size(98, 21)
        Me.fecFechaCarga.TabIndex = 5
        '
        'Etiqueta12
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance12
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(204, 25)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta12.TabIndex = 4
        Me.Etiqueta12.Text = "Fecha"
        '
        'Etiqueta21
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance13
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(15, 25)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta21.TabIndex = 0
        Me.Etiqueta21.Text = "Importe"
        '
        'decImporteCarga
        '
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.decImporteCarga.Appearance = Appearance14
        Me.decImporteCarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decImporteCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImporteCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImporteCarga.ForeColor = System.Drawing.Color.Black
        Me.decImporteCarga.Location = New System.Drawing.Point(62, 21)
        Me.decImporteCarga.MaskInput = "{double:9.4}"
        Me.decImporteCarga.Name = "decImporteCarga"
        Me.decImporteCarga.NullText = "0.00"
        Me.decImporteCarga.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImporteCarga.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decImporteCarga.Size = New System.Drawing.Size(83, 21)
        Me.decImporteCarga.TabIndex = 1
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.expCheque)
        Me.UltraTabPageControl8.Controls.Add(Me.expCobro)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(862, 206)
        '
        'expCheque
        '
        Me.expCheque.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.expCheque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.expCheque.ExpandedSize = New System.Drawing.Size(547, 206)
        Me.expCheque.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.expCheque.Location = New System.Drawing.Point(315, 0)
        Me.expCheque.Name = "expCheque"
        Me.expCheque.Size = New System.Drawing.Size(547, 206)
        Me.expCheque.TabIndex = 1
        Me.expCheque.Text = "Cheque Por Cobrar"
        Me.expCheque.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.griChequexCobrar)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(524, 200)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'griChequexCobrar
        '
        Me.griChequexCobrar.ContextMenuStrip = Me.MenuContextualCheque
        Me.griChequexCobrar.DataSource = Me.ordChequexCobrar
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 4
        UltraGridColumn3.Width = 199
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.Width = 195
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.Width = 244
        UltraGridColumn13.Header.VisiblePosition = 15
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridColumn14.Width = 285
        UltraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn15.Header.VisiblePosition = 12
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Header.VisiblePosition = 14
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        UltraGridBand1.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griChequexCobrar.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griChequexCobrar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griChequexCobrar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griChequexCobrar.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griChequexCobrar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griChequexCobrar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griChequexCobrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griChequexCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.griChequexCobrar.Location = New System.Drawing.Point(0, 0)
        Me.griChequexCobrar.Name = "griChequexCobrar"
        Me.griChequexCobrar.Size = New System.Drawing.Size(524, 200)
        Me.griChequexCobrar.TabIndex = 0
        '
        'MenuContextualCheque
        '
        Me.MenuContextualCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextualCheque.ForeColor = System.Drawing.Color.Black
        Me.MenuContextualCheque.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultarCheque})
        Me.MenuContextualCheque.Name = "MenuContextual"
        Me.MenuContextualCheque.Size = New System.Drawing.Size(119, 26)
        '
        'mnuConsultarCheque
        '
        Me.mnuConsultarCheque.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.mnuConsultarCheque.Name = "mnuConsultarCheque"
        Me.mnuConsultarCheque.Size = New System.Drawing.Size(118, 22)
        Me.mnuConsultarCheque.Text = "Consultar"
        '
        'ordChequexCobrar
        '
        UltraDataColumn5.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Boolean)
        UltraDataColumn10.DataType = GetType(Date)
        UltraDataColumn17.DataType = GetType(Boolean)
        Me.ordChequexCobrar.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'expCobro
        '
        Me.expCobro.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.expCobro.Dock = System.Windows.Forms.DockStyle.Left
        Me.expCobro.ExpandedSize = New System.Drawing.Size(315, 206)
        Me.expCobro.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.expCobro.Location = New System.Drawing.Point(0, 0)
        Me.expCobro.Name = "expCobro"
        Me.expCobro.Size = New System.Drawing.Size(315, 206)
        Me.expCobro.TabIndex = 0
        Me.expCobro.Text = "Datos Cobrar"
        Me.expCobro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.etiSaldoFlete)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.verChequePorCobrar)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.decImporteCobro)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Etiqueta24)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtGlosaCobro)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.verExtornoCobro)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.fecFechaCobro)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Etiqueta28)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Etiqueta25)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Etiqueta22)
        Me.UltraExpandableGroupBoxPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(292, 200)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        '
        'etiSaldoFlete
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.etiSaldoFlete.Appearance = Appearance15
        Me.etiSaldoFlete.AutoSize = True
        Me.etiSaldoFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSaldoFlete.ForeColor = System.Drawing.Color.Black
        Me.etiSaldoFlete.Location = New System.Drawing.Point(190, 29)
        Me.etiSaldoFlete.Name = "etiSaldoFlete"
        Me.etiSaldoFlete.Size = New System.Drawing.Size(10, 14)
        Me.etiSaldoFlete.TabIndex = 4
        Me.etiSaldoFlete.Text = "0"
        '
        'verChequePorCobrar
        '
        Me.verChequePorCobrar.BackColor = System.Drawing.Color.Transparent
        Me.verChequePorCobrar.BackColorInternal = System.Drawing.Color.Transparent
        Me.verChequePorCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verChequePorCobrar.ForeColor = System.Drawing.Color.Black
        Me.verChequePorCobrar.Location = New System.Drawing.Point(64, 0)
        Me.verChequePorCobrar.Name = "verChequePorCobrar"
        Me.verChequePorCobrar.Size = New System.Drawing.Size(115, 20)
        Me.verChequePorCobrar.TabIndex = 0
        Me.verChequePorCobrar.Text = "Cobrar Cheque"
        '
        'decImporteCobro
        '
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.decImporteCobro.Appearance = Appearance16
        Me.decImporteCobro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decImporteCobro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImporteCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImporteCobro.ForeColor = System.Drawing.Color.Black
        Me.decImporteCobro.Location = New System.Drawing.Point(64, 25)
        Me.decImporteCobro.MaskInput = "{double:9.4}"
        Me.decImporteCobro.Name = "decImporteCobro"
        Me.decImporteCobro.NullText = "0.00"
        Me.decImporteCobro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImporteCobro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decImporteCobro.Size = New System.Drawing.Size(100, 21)
        Me.decImporteCobro.TabIndex = 2
        '
        'Etiqueta24
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta24.Appearance = Appearance17
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(23, 52)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta24.TabIndex = 5
        Me.Etiqueta24.Text = "Fecha"
        '
        'txtGlosaCobro
        '
        Me.txtGlosaCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaCobro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtGlosaCobro.Location = New System.Drawing.Point(64, 79)
        Me.txtGlosaCobro.Multiline = True
        Me.txtGlosaCobro.Name = "txtGlosaCobro"
        Me.txtGlosaCobro.Size = New System.Drawing.Size(225, 103)
        Me.txtGlosaCobro.TabIndex = 8
        '
        'verExtornoCobro
        '
        Me.verExtornoCobro.BackColor = System.Drawing.Color.Transparent
        Me.verExtornoCobro.BackColorInternal = System.Drawing.Color.Transparent
        Me.verExtornoCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verExtornoCobro.ForeColor = System.Drawing.Color.Black
        Me.verExtornoCobro.Location = New System.Drawing.Point(64, 181)
        Me.verExtornoCobro.Name = "verExtornoCobro"
        Me.verExtornoCobro.Size = New System.Drawing.Size(62, 20)
        Me.verExtornoCobro.TabIndex = 9
        Me.verExtornoCobro.Text = "Extorno"
        '
        'fecFechaCobro
        '
        Appearance18.ForeColor = System.Drawing.Color.Black
        Me.fecFechaCobro.Appearance = Appearance18
        Me.fecFechaCobro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaCobro.ForeColor = System.Drawing.Color.Black
        Me.fecFechaCobro.Location = New System.Drawing.Point(64, 52)
        Me.fecFechaCobro.Name = "fecFechaCobro"
        Me.fecFechaCobro.Size = New System.Drawing.Size(100, 21)
        Me.fecFechaCobro.TabIndex = 6
        '
        'Etiqueta28
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta28.Appearance = Appearance19
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(170, 29)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(17, 14)
        Me.Etiqueta28.TabIndex = 3
        Me.Etiqueta28.Text = "S/."
        '
        'Etiqueta25
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta25.Appearance = Appearance20
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(17, 25)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta25.TabIndex = 1
        Me.Etiqueta25.Text = "Importe"
        '
        'Etiqueta22
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta22.Appearance = Appearance21
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(25, 81)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta22.TabIndex = 7
        Me.Etiqueta22.Text = "Glosa"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDetalleCargarCobrar)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1255, 542)
        '
        'agrDetalleCargarCobrar
        '
        Me.agrDetalleCargarCobrar.Controls.Add(Me.GriMovimientoFleteGlobal)
        Me.agrDetalleCargarCobrar.Controls.Add(Me.agrFleteCarga)
        Me.agrDetalleCargarCobrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalleCargarCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetalleCargarCobrar.ForeColor = System.Drawing.Color.Black
        Me.agrDetalleCargarCobrar.Location = New System.Drawing.Point(0, 0)
        Me.agrDetalleCargarCobrar.Name = "agrDetalleCargarCobrar"
        Me.agrDetalleCargarCobrar.Size = New System.Drawing.Size(1255, 542)
        Me.agrDetalleCargarCobrar.TabIndex = 0
        Me.agrDetalleCargarCobrar.Text = "Cargar Flete"
        Me.agrDetalleCargarCobrar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'GriMovimientoFleteGlobal
        '
        Me.GriMovimientoFleteGlobal.DisplayLayout.MaxColScrollRegions = 1
        Me.GriMovimientoFleteGlobal.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.GriMovimientoFleteGlobal.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GriMovimientoFleteGlobal.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GriMovimientoFleteGlobal.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GriMovimientoFleteGlobal.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GriMovimientoFleteGlobal.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GriMovimientoFleteGlobal.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GriMovimientoFleteGlobal.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GriMovimientoFleteGlobal.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.GriMovimientoFleteGlobal.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.GriMovimientoFleteGlobal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GriMovimientoFleteGlobal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GriMovimientoFleteGlobal.Location = New System.Drawing.Point(3, 253)
        Me.GriMovimientoFleteGlobal.Name = "GriMovimientoFleteGlobal"
        Me.GriMovimientoFleteGlobal.Size = New System.Drawing.Size(1249, 286)
        Me.GriMovimientoFleteGlobal.TabIndex = 1
        Me.GriMovimientoFleteGlobal.Tag = ""
        '
        'agrFleteCarga
        '
        Me.agrFleteCarga.Controls.Add(Me.agrDerechaCargar_Cobrar)
        Me.agrFleteCarga.Controls.Add(Me.agrViaje)
        Me.agrFleteCarga.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrFleteCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFleteCarga.ForeColor = System.Drawing.Color.Black
        Me.agrFleteCarga.Location = New System.Drawing.Point(3, 16)
        Me.agrFleteCarga.Name = "agrFleteCarga"
        Me.agrFleteCarga.Size = New System.Drawing.Size(1249, 237)
        Me.agrFleteCarga.TabIndex = 0
        Me.agrFleteCarga.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'agrDerechaCargar_Cobrar
        '
        Me.agrDerechaCargar_Cobrar.Controls.Add(Me.ficCargar_Cobrar)
        Me.agrDerechaCargar_Cobrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDerechaCargar_Cobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDerechaCargar_Cobrar.ForeColor = System.Drawing.Color.Black
        Me.agrDerechaCargar_Cobrar.Location = New System.Drawing.Point(379, 2)
        Me.agrDerechaCargar_Cobrar.Name = "agrDerechaCargar_Cobrar"
        Me.agrDerechaCargar_Cobrar.Size = New System.Drawing.Size(868, 233)
        Me.agrDerechaCargar_Cobrar.TabIndex = 1
        Me.agrDerechaCargar_Cobrar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ficCargar_Cobrar
        '
        Me.ficCargar_Cobrar.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.ficCargar_Cobrar.Controls.Add(Me.UltraTabPageControl6)
        Me.ficCargar_Cobrar.Controls.Add(Me.UltraTabPageControl8)
        Me.ficCargar_Cobrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCargar_Cobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficCargar_Cobrar.Location = New System.Drawing.Point(2, 2)
        Me.ficCargar_Cobrar.Name = "ficCargar_Cobrar"
        Me.ficCargar_Cobrar.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.ficCargar_Cobrar.Size = New System.Drawing.Size(864, 229)
        Me.ficCargar_Cobrar.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficCargar_Cobrar.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl6
        UltraTab1.Text = "Datos Cargar"
        UltraTab2.TabPage = Me.UltraTabPageControl8
        UltraTab2.Text = "Datos Cobrar"
        UltraTab2.Visible = False
        Me.ficCargar_Cobrar.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficCargar_Cobrar.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(862, 206)
        '
        'agrViaje
        '
        Me.agrViaje.Controls.Add(Me.ficCargaFlete)
        Me.agrViaje.Dock = System.Windows.Forms.DockStyle.Left
        Me.agrViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrViaje.ForeColor = System.Drawing.Color.Black
        Me.agrViaje.Location = New System.Drawing.Point(2, 2)
        Me.agrViaje.Name = "agrViaje"
        Me.agrViaje.Size = New System.Drawing.Size(377, 233)
        Me.agrViaje.TabIndex = 0
        Me.agrViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficCargaFlete
        '
        Me.ficCargaFlete.Controls.Add(Me.UltraTabSharedControlsPage9)
        Me.ficCargaFlete.Controls.Add(Me.UltraTabPageControl13)
        Me.ficCargaFlete.Controls.Add(Me.UltraTabPageControl14)
        Me.ficCargaFlete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCargaFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficCargaFlete.Location = New System.Drawing.Point(3, 3)
        Me.ficCargaFlete.Name = "ficCargaFlete"
        Me.ficCargaFlete.SharedControlsPage = Me.UltraTabSharedControlsPage9
        Me.ficCargaFlete.Size = New System.Drawing.Size(371, 227)
        Me.ficCargaFlete.TabIndex = 0
        UltraTab5.TabPage = Me.UltraTabPageControl13
        UltraTab5.Text = "Viaje Asociado"
        UltraTab14.TabPage = Me.UltraTabPageControl14
        UltraTab14.Text = "Administrativo"
        Me.ficCargaFlete.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab14})
        Me.ficCargaFlete.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage9
        '
        Me.UltraTabSharedControlsPage9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage9.Name = "UltraTabSharedControlsPage9"
        Me.UltraTabSharedControlsPage9.Size = New System.Drawing.Size(369, 204)
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.Etiqueta20)
        Me.UltraTabPageControl13.Controls.Add(Me.etiEstadoAsociado)
        Me.UltraTabPageControl13.Controls.Add(Me.etiFechaViajeAsociado)
        Me.UltraTabPageControl13.Controls.Add(Me.etiRutaCarga)
        Me.UltraTabPageControl13.Controls.Add(Me.eti)
        Me.UltraTabPageControl13.Controls.Add(Me.etiFecha)
        Me.UltraTabPageControl13.Controls.Add(Me.etiRutaAsociada)
        Me.UltraTabPageControl13.Controls.Add(Me.Etiqueta9)
        Me.UltraTabPageControl13.Controls.Add(Me.cboTrabajadorFlete)
        Me.UltraTabPageControl13.Controls.Add(Me.Etiqueta23)
        Me.UltraTabPageControl13.Controls.Add(Me.decSaldoViaje)
        Me.UltraTabPageControl13.Controls.Add(Me.cboViaje)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(369, 204)
        '
        'Etiqueta20
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance22
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(15, 30)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(29, 14)
        Me.Etiqueta20.TabIndex = 2
        Me.Etiqueta20.Text = "Viaje"
        '
        'etiEstadoAsociado
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.etiEstadoAsociado.Appearance = Appearance23
        Me.etiEstadoAsociado.AutoSize = True
        Me.etiEstadoAsociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEstadoAsociado.ForeColor = System.Drawing.Color.Black
        Me.etiEstadoAsociado.Location = New System.Drawing.Point(53, 123)
        Me.etiEstadoAsociado.Name = "etiEstadoAsociado"
        Me.etiEstadoAsociado.Size = New System.Drawing.Size(0, 0)
        Me.etiEstadoAsociado.TabIndex = 9
        '
        'etiFechaViajeAsociado
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.etiFechaViajeAsociado.Appearance = Appearance24
        Me.etiFechaViajeAsociado.AutoSize = True
        Me.etiFechaViajeAsociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaViajeAsociado.ForeColor = System.Drawing.Color.Black
        Me.etiFechaViajeAsociado.Location = New System.Drawing.Point(53, 96)
        Me.etiFechaViajeAsociado.Name = "etiFechaViajeAsociado"
        Me.etiFechaViajeAsociado.Size = New System.Drawing.Size(0, 0)
        Me.etiFechaViajeAsociado.TabIndex = 7
        '
        'etiRutaCarga
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.etiRutaCarga.Appearance = Appearance25
        Me.etiRutaCarga.AutoSize = True
        Me.etiRutaCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRutaCarga.ForeColor = System.Drawing.Color.Black
        Me.etiRutaCarga.Location = New System.Drawing.Point(50, 68)
        Me.etiRutaCarga.Name = "etiRutaCarga"
        Me.etiRutaCarga.Size = New System.Drawing.Size(0, 0)
        Me.etiRutaCarga.TabIndex = 5
        '
        'eti
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.eti.Appearance = Appearance26
        Me.eti.AutoSize = True
        Me.eti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eti.ForeColor = System.Drawing.Color.Black
        Me.eti.Location = New System.Drawing.Point(6, 123)
        Me.eti.Name = "eti"
        Me.eti.Size = New System.Drawing.Size(38, 14)
        Me.eti.TabIndex = 8
        Me.eti.Text = "Estado"
        '
        'etiFecha
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.etiFecha.Appearance = Appearance27
        Me.etiFecha.AutoSize = True
        Me.etiFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFecha.ForeColor = System.Drawing.Color.Black
        Me.etiFecha.Location = New System.Drawing.Point(9, 96)
        Me.etiFecha.Name = "etiFecha"
        Me.etiFecha.Size = New System.Drawing.Size(35, 14)
        Me.etiFecha.TabIndex = 6
        Me.etiFecha.Text = "Fecha"
        '
        'etiRutaAsociada
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.etiRutaAsociada.Appearance = Appearance28
        Me.etiRutaAsociada.AutoSize = True
        Me.etiRutaAsociada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRutaAsociada.ForeColor = System.Drawing.Color.Black
        Me.etiRutaAsociada.Location = New System.Drawing.Point(17, 68)
        Me.etiRutaAsociada.Name = "etiRutaAsociada"
        Me.etiRutaAsociada.Size = New System.Drawing.Size(27, 14)
        Me.etiRutaAsociada.TabIndex = 4
        Me.etiRutaAsociada.Text = "Ruta"
        '
        'Etiqueta9
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance29
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(12, 168)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta9.TabIndex = 10
        Me.Etiqueta9.Text = "Saldo"
        '
        'cboTrabajadorFlete
        '
        Appearance30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajadorFlete.Appearance = Appearance30
        Me.cboTrabajadorFlete.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajadorFlete.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadorFlete.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajadorFlete.Location = New System.Drawing.Point(50, 3)
        Me.cboTrabajadorFlete.Name = "cboTrabajadorFlete"
        Me.cboTrabajadorFlete.Size = New System.Drawing.Size(246, 21)
        Me.cboTrabajadorFlete.TabIndex = 1
        Me.cboTrabajadorFlete.ValueMember = "Id"
        '
        'Etiqueta23
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance31
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(12, 7)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta23.TabIndex = 0
        Me.Etiqueta23.Text = "Piloto"
        '
        'decSaldoViaje
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.decSaldoViaje.Appearance = Appearance32
        Me.decSaldoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldoViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldoViaje.ForeColor = System.Drawing.Color.Black
        Me.decSaldoViaje.Location = New System.Drawing.Point(50, 166)
        Me.decSaldoViaje.MaskInput = "{double:9.4}"
        Me.decSaldoViaje.Name = "decSaldoViaje"
        Me.decSaldoViaje.NullText = "0.00"
        Me.decSaldoViaje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldoViaje.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldoViaje.ReadOnly = True
        Me.decSaldoViaje.Size = New System.Drawing.Size(114, 21)
        Me.decSaldoViaje.TabIndex = 11
        '
        'cboViaje
        '
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.cboViaje.Appearance = Appearance33
        Me.cboViaje.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboViaje.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboViaje.ForeColor = System.Drawing.Color.Black
        Me.cboViaje.Location = New System.Drawing.Point(50, 30)
        Me.cboViaje.Name = "cboViaje"
        Me.cboViaje.Size = New System.Drawing.Size(202, 21)
        Me.cboViaje.TabIndex = 3
        Me.cboViaje.ValueMember = "Id"
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.cboAdm)
        Me.UltraTabPageControl14.Controls.Add(Me.Etiqueta3)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(369, 204)
        '
        'cboAdm
        '
        Appearance34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAdm.Appearance = Appearance34
        Me.cboAdm.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAdm.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAdm.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdm.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAdm.Location = New System.Drawing.Point(62, 5)
        Me.cboAdm.Name = "cboAdm"
        Me.cboAdm.Size = New System.Drawing.Size(304, 21)
        Me.cboAdm.TabIndex = 1
        Me.cboAdm.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance35
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(3, 8)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Cta. Adm."
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrOperaciones)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1261, 569)
        '
        'agrOperaciones
        '
        Me.agrOperaciones.Controls.Add(Me.griLista)
        Me.agrOperaciones.Controls.Add(Me.expOperacionDetalle)
        Me.agrOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOperaciones.ForeColor = System.Drawing.Color.Black
        Me.agrOperaciones.Location = New System.Drawing.Point(0, 131)
        Me.agrOperaciones.Name = "agrOperaciones"
        Me.agrOperaciones.Size = New System.Drawing.Size(1261, 438)
        Me.agrOperaciones.TabIndex = 1
        Me.agrOperaciones.Text = "Operaciones"
        Me.agrOperaciones.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griLista
        '
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(3, 16)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1255, 178)
        Me.griLista.TabIndex = 0
        Me.griLista.Tag = ""
        '
        'expOperacionDetalle
        '
        Me.expOperacionDetalle.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.expOperacionDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.expOperacionDetalle.ExpandedSize = New System.Drawing.Size(1255, 241)
        Me.expOperacionDetalle.Location = New System.Drawing.Point(3, 194)
        Me.expOperacionDetalle.Name = "expOperacionDetalle"
        Me.expOperacionDetalle.Size = New System.Drawing.Size(1255, 241)
        Me.expOperacionDetalle.TabIndex = 1
        Me.expOperacionDetalle.Text = "Operaciones - Detalles "
        Me.expOperacionDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griViajeDetalle)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.expCuentaFlete)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1249, 218)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'griViajeDetalle
        '
        Me.griViajeDetalle.ContextMenuStrip = Me.MenuContextual
        Me.griViajeDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajeDetalle.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajeDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajeDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajeDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajeDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajeDetalle.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.griViajeDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajeDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajeDetalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajeDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajeDetalle.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajeDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajeDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajeDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajeDetalle.Location = New System.Drawing.Point(0, 0)
        Me.griViajeDetalle.Name = "griViajeDetalle"
        Me.griViajeDetalle.Size = New System.Drawing.Size(769, 218)
        Me.griViajeDetalle.TabIndex = 0
        Me.griViajeDetalle.Tag = ""
        '
        'MenuContextual
        '
        Me.MenuContextual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCargar})
        Me.MenuContextual.Name = "MenuContextual"
        Me.MenuContextual.Size = New System.Drawing.Size(106, 26)
        '
        'MnuCargar
        '
        Me.MnuCargar.Name = "MnuCargar"
        Me.MnuCargar.Size = New System.Drawing.Size(105, 22)
        Me.MnuCargar.Text = "Cargar"
        '
        'Filtro
        '
        Me.Filtro.MenuSettings.RightAlignedMenus = True
        Me.Filtro.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'expCuentaFlete
        '
        Me.expCuentaFlete.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.expCuentaFlete.Dock = System.Windows.Forms.DockStyle.Right
        Me.expCuentaFlete.ExpandedSize = New System.Drawing.Size(480, 218)
        Me.expCuentaFlete.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightOnBorder
        Me.expCuentaFlete.Location = New System.Drawing.Point(769, 0)
        Me.expCuentaFlete.Name = "expCuentaFlete"
        Me.expCuentaFlete.Size = New System.Drawing.Size(480, 218)
        Me.expCuentaFlete.TabIndex = 0
        Me.expCuentaFlete.Text = "Movimientos Flete"
        Me.expCuentaFlete.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.agr1)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(457, 212)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'agr1
        '
        Me.agr1.Controls.Add(Me.agr2)
        Me.agr1.Controls.Add(Me.agrSaldoFlete)
        Me.agr1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agr1.ForeColor = System.Drawing.Color.Black
        Me.agr1.Location = New System.Drawing.Point(0, 0)
        Me.agr1.Name = "agr1"
        Me.agr1.Size = New System.Drawing.Size(457, 212)
        Me.agr1.TabIndex = 0
        Me.agr1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'agr2
        '
        Me.agr2.Controls.Add(Me.griMovimientoFlete)
        Me.agr2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agr2.ForeColor = System.Drawing.Color.Black
        Me.agr2.Location = New System.Drawing.Point(2, 2)
        Me.agr2.Name = "agr2"
        Me.agr2.Size = New System.Drawing.Size(453, 152)
        Me.agr2.TabIndex = 0
        Me.agr2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griMovimientoFlete
        '
        Me.griMovimientoFlete.ContextMenuStrip = Me.MenuExtornar
        Me.griMovimientoFlete.DisplayLayout.MaxColScrollRegions = 1
        Me.griMovimientoFlete.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griMovimientoFlete.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimientoFlete.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMovimientoFlete.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMovimientoFlete.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMovimientoFlete.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMovimientoFlete.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMovimientoFlete.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMovimientoFlete.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griMovimientoFlete.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griMovimientoFlete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovimientoFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMovimientoFlete.Location = New System.Drawing.Point(2, 2)
        Me.griMovimientoFlete.Name = "griMovimientoFlete"
        Me.griMovimientoFlete.Size = New System.Drawing.Size(449, 148)
        Me.griMovimientoFlete.TabIndex = 0
        Me.griMovimientoFlete.Tag = ""
        '
        'MenuExtornar
        '
        Me.MenuExtornar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuExtornar.ForeColor = System.Drawing.Color.Black
        Me.MenuExtornar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuExtornar})
        Me.MenuExtornar.Name = "MenuExtornar"
        Me.MenuExtornar.Size = New System.Drawing.Size(145, 26)
        '
        'MnuExtornar
        '
        Me.MnuExtornar.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.MnuExtornar.Name = "MnuExtornar"
        Me.MnuExtornar.Size = New System.Drawing.Size(144, 22)
        Me.MnuExtornar.Text = "Extornar Carga"
        '
        'agrSaldoFlete
        '
        Me.agrSaldoFlete.Controls.Add(Me.decSaldoPorDepositar)
        Me.agrSaldoFlete.Controls.Add(Me.Etiqueta39)
        Me.agrSaldoFlete.Controls.Add(Me.decFleteDepositado)
        Me.agrSaldoFlete.Controls.Add(Me.decTotalCargado)
        Me.agrSaldoFlete.Controls.Add(Me.Etiqueta29)
        Me.agrSaldoFlete.Controls.Add(Me.decMontoFlete)
        Me.agrSaldoFlete.Controls.Add(Me.Etiqueta27)
        Me.agrSaldoFlete.Controls.Add(Me.decSaldoFlete)
        Me.agrSaldoFlete.Controls.Add(Me.Etiqueta26)
        Me.agrSaldoFlete.Controls.Add(Me.etiSaldo)
        Me.agrSaldoFlete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.agrSaldoFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrSaldoFlete.ForeColor = System.Drawing.Color.Black
        Me.agrSaldoFlete.Location = New System.Drawing.Point(2, 154)
        Me.agrSaldoFlete.Name = "agrSaldoFlete"
        Me.agrSaldoFlete.Size = New System.Drawing.Size(453, 56)
        Me.agrSaldoFlete.TabIndex = 1
        Me.agrSaldoFlete.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decSaldoPorDepositar
        '
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.decSaldoPorDepositar.Appearance = Appearance36
        Me.decSaldoPorDepositar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decSaldoPorDepositar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldoPorDepositar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldoPorDepositar.ForeColor = System.Drawing.Color.Black
        Me.decSaldoPorDepositar.Location = New System.Drawing.Point(373, 4)
        Me.decSaldoPorDepositar.MaskInput = "{double:9.4}"
        Me.decSaldoPorDepositar.Name = "decSaldoPorDepositar"
        Me.decSaldoPorDepositar.NullText = "0.00"
        Me.decSaldoPorDepositar.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldoPorDepositar.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldoPorDepositar.ReadOnly = True
        Me.decSaldoPorDepositar.Size = New System.Drawing.Size(72, 21)
        Me.decSaldoPorDepositar.TabIndex = 4
        '
        'Etiqueta39
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta39.Appearance = Appearance37
        Me.Etiqueta39.AutoSize = True
        Me.Etiqueta39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Etiqueta39.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta39.Location = New System.Drawing.Point(294, 9)
        Me.Etiqueta39.Name = "Etiqueta39"
        Me.Etiqueta39.Size = New System.Drawing.Size(77, 14)
        Me.Etiqueta39.TabIndex = 5
        Me.Etiqueta39.Text = "Por Depositar:"
        '
        'decFleteDepositado
        '
        Appearance38.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance38.ForeColor = System.Drawing.Color.Black
        Me.decFleteDepositado.Appearance = Appearance38
        Me.decFleteDepositado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decFleteDepositado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decFleteDepositado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decFleteDepositado.ForeColor = System.Drawing.Color.Black
        Me.decFleteDepositado.Location = New System.Drawing.Point(214, 30)
        Me.decFleteDepositado.MaskInput = "{double:9.4}"
        Me.decFleteDepositado.Name = "decFleteDepositado"
        Me.decFleteDepositado.NullText = "0.00"
        Me.decFleteDepositado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decFleteDepositado.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decFleteDepositado.ReadOnly = True
        Me.decFleteDepositado.Size = New System.Drawing.Size(72, 21)
        Me.decFleteDepositado.TabIndex = 9
        '
        'decTotalCargado
        '
        Appearance39.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance39.ForeColor = System.Drawing.Color.Black
        Me.decTotalCargado.Appearance = Appearance39
        Me.decTotalCargado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decTotalCargado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalCargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalCargado.ForeColor = System.Drawing.Color.Black
        Me.decTotalCargado.Location = New System.Drawing.Point(69, 30)
        Me.decTotalCargado.MaskInput = "{double:9.4}"
        Me.decTotalCargado.Name = "decTotalCargado"
        Me.decTotalCargado.NullText = "0.00"
        Me.decTotalCargado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalCargado.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decTotalCargado.ReadOnly = True
        Me.decTotalCargado.Size = New System.Drawing.Size(72, 21)
        Me.decTotalCargado.TabIndex = 7
        '
        'Etiqueta29
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance40
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Etiqueta29.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta29.Location = New System.Drawing.Point(147, 35)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta29.TabIndex = 8
        Me.Etiqueta29.Text = "Depositado:"
        '
        'decMontoFlete
        '
        Appearance41.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance41.ForeColor = System.Drawing.Color.Black
        Me.decMontoFlete.Appearance = Appearance41
        Me.decMontoFlete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decMontoFlete.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoFlete.ForeColor = System.Drawing.Color.Black
        Me.decMontoFlete.Location = New System.Drawing.Point(69, 4)
        Me.decMontoFlete.MaskInput = "{double:9.4}"
        Me.decMontoFlete.Name = "decMontoFlete"
        Me.decMontoFlete.NullText = "0.00"
        Me.decMontoFlete.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoFlete.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decMontoFlete.ReadOnly = True
        Me.decMontoFlete.Size = New System.Drawing.Size(72, 21)
        Me.decMontoFlete.TabIndex = 1
        '
        'Etiqueta27
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance42
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(6, 35)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(51, 14)
        Me.Etiqueta27.TabIndex = 6
        Me.Etiqueta27.Text = "Cargado:"
        '
        'decSaldoFlete
        '
        Appearance43.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.decSaldoFlete.Appearance = Appearance43
        Me.decSaldoFlete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decSaldoFlete.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldoFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldoFlete.ForeColor = System.Drawing.Color.Black
        Me.decSaldoFlete.Location = New System.Drawing.Point(214, 4)
        Me.decSaldoFlete.MaskInput = "{double:9.4}"
        Me.decSaldoFlete.Name = "decSaldoFlete"
        Me.decSaldoFlete.NullText = "0.00"
        Me.decSaldoFlete.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldoFlete.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldoFlete.ReadOnly = True
        Me.decSaldoFlete.Size = New System.Drawing.Size(72, 21)
        Me.decSaldoFlete.TabIndex = 3
        '
        'Etiqueta26
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance44
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(6, 9)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta26.TabIndex = 0
        Me.Etiqueta26.Text = "Flete:"
        '
        'etiSaldo
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.etiSaldo.Appearance = Appearance45
        Me.etiSaldo.AutoSize = True
        Me.etiSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.etiSaldo.ForeColor = System.Drawing.Color.Black
        Me.etiSaldo.Location = New System.Drawing.Point(146, 10)
        Me.etiSaldo.Name = "etiSaldo"
        Me.etiSaldo.Size = New System.Drawing.Size(63, 14)
        Me.etiSaldo.TabIndex = 2
        Me.etiSaldo.Text = "Por Cargar:"
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.EtiCargado)
        Me.agrBusqueda.Controls.Add(Me.verBuscarOtros)
        Me.agrBusqueda.Controls.Add(Me.verContraEntrega)
        Me.agrBusqueda.Controls.Add(Me.colorCargado)
        Me.agrBusqueda.Controls.Add(Me.verBuscarFecha)
        Me.agrBusqueda.Controls.Add(Me.agrBuscarFecha)
        Me.agrBusqueda.Controls.Add(Me.agrBuscarOtros)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1261, 131)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Busqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'EtiCargado
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Me.EtiCargado.Appearance = Appearance46
        Me.EtiCargado.AutoSize = True
        Me.EtiCargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiCargado.ForeColor = System.Drawing.Color.Black
        Me.EtiCargado.Location = New System.Drawing.Point(128, 96)
        Me.EtiCargado.Name = "EtiCargado"
        Me.EtiCargado.Size = New System.Drawing.Size(46, 14)
        Me.EtiCargado.TabIndex = 3
        Me.EtiCargado.Text = "Cargado"
        '
        'verBuscarOtros
        '
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.verBuscarOtros.Appearance = Appearance47
        Me.verBuscarOtros.BackColor = System.Drawing.Color.Transparent
        Me.verBuscarOtros.BackColorInternal = System.Drawing.Color.Transparent
        Me.verBuscarOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verBuscarOtros.ForeColor = System.Drawing.Color.Black
        Me.verBuscarOtros.Location = New System.Drawing.Point(176, 19)
        Me.verBuscarOtros.Name = "verBuscarOtros"
        Me.verBuscarOtros.Size = New System.Drawing.Size(42, 20)
        Me.verBuscarOtros.TabIndex = 4
        Me.verBuscarOtros.Text = "Por:"
        '
        'verContraEntrega
        '
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.verContraEntrega.Appearance = Appearance48
        Me.verContraEntrega.BackColor = System.Drawing.Color.Transparent
        Me.verContraEntrega.BackColorInternal = System.Drawing.Color.Transparent
        Me.verContraEntrega.Checked = True
        Me.verContraEntrega.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verContraEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verContraEntrega.ForeColor = System.Drawing.Color.Black
        Me.verContraEntrega.Location = New System.Drawing.Point(846, 32)
        Me.verContraEntrega.Name = "verContraEntrega"
        Me.verContraEntrega.Size = New System.Drawing.Size(99, 20)
        Me.verContraEntrega.TabIndex = 6
        Me.verContraEntrega.Text = "Contra Entrega"
        '
        'colorCargado
        '
        Me.colorCargado.Location = New System.Drawing.Point(79, 93)
        Me.colorCargado.Name = "colorCargado"
        Me.colorCargado.Size = New System.Drawing.Size(44, 21)
        Me.colorCargado.TabIndex = 2
        Me.colorCargado.Text = "Control"
        '
        'verBuscarFecha
        '
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.verBuscarFecha.Appearance = Appearance49
        Me.verBuscarFecha.BackColor = System.Drawing.Color.Transparent
        Me.verBuscarFecha.BackColorInternal = System.Drawing.Color.Transparent
        Me.verBuscarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verBuscarFecha.ForeColor = System.Drawing.Color.Black
        Me.verBuscarFecha.Location = New System.Drawing.Point(4, 19)
        Me.verBuscarFecha.Name = "verBuscarFecha"
        Me.verBuscarFecha.Size = New System.Drawing.Size(55, 20)
        Me.verBuscarFecha.TabIndex = 0
        Me.verBuscarFecha.Text = "Fecha:"
        '
        'agrBuscarFecha
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Me.agrBuscarFecha.Appearance = Appearance50
        Me.agrBuscarFecha.Controls.Add(Me.Etiqueta51)
        Me.agrBuscarFecha.Controls.Add(Me.Etiqueta50)
        Me.agrBuscarFecha.Controls.Add(Me.fecDesde)
        Me.agrBuscarFecha.Controls.Add(Me.fecHasta)
        Me.agrBuscarFecha.Enabled = False
        Me.agrBuscarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBuscarFecha.ForeColor = System.Drawing.Color.Black
        Me.agrBuscarFecha.Location = New System.Drawing.Point(13, 28)
        Me.agrBuscarFecha.Name = "agrBuscarFecha"
        Me.agrBuscarFecha.Size = New System.Drawing.Size(161, 59)
        Me.agrBuscarFecha.TabIndex = 1
        Me.agrBuscarFecha.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'Etiqueta51
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta51.Appearance = Appearance51
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(7, 36)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta51.TabIndex = 2
        Me.Etiqueta51.Text = "Hasta:"
        '
        'Etiqueta50
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta50.Appearance = Appearance52
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
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(52, 35)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(85, 20)
        Me.fecHasta.TabIndex = 3
        '
        'agrBuscarOtros
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Me.agrBuscarOtros.Appearance = Appearance53
        Me.agrBuscarOtros.Controls.Add(Me.cboCentro)
        Me.agrBuscarOtros.Controls.Add(Me.etiCentro)
        Me.agrBuscarOtros.Controls.Add(Me.txtViaje)
        Me.agrBuscarOtros.Controls.Add(Me.txtOperacion)
        Me.agrBuscarOtros.Controls.Add(Me.UltraLabel1)
        Me.agrBuscarOtros.Controls.Add(Me.cboPlaca)
        Me.agrBuscarOtros.Controls.Add(Me.cboCarga)
        Me.agrBuscarOtros.Controls.Add(Me.etiViaje)
        Me.agrBuscarOtros.Controls.Add(Me.cboCliente)
        Me.agrBuscarOtros.Controls.Add(Me.Etiqueta2)
        Me.agrBuscarOtros.Controls.Add(Me.cboTrabajador)
        Me.agrBuscarOtros.Controls.Add(Me.UltraLabel2)
        Me.agrBuscarOtros.Controls.Add(Me.etiTrabajadorCuenta)
        Me.agrBuscarOtros.Controls.Add(Me.etitracto)
        Me.agrBuscarOtros.Enabled = False
        Me.agrBuscarOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBuscarOtros.ForeColor = System.Drawing.Color.Black
        Me.agrBuscarOtros.Location = New System.Drawing.Point(185, 28)
        Me.agrBuscarOtros.Name = "agrBuscarOtros"
        Me.agrBuscarOtros.Size = New System.Drawing.Size(655, 95)
        Me.agrBuscarOtros.TabIndex = 5
        Me.agrBuscarOtros.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'cboCentro
        '
        Appearance54.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance54
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentro.DisplayMember = ""
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(532, 25)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(117, 21)
        Me.cboCentro.TabIndex = 7
        Me.cboCentro.ValueMember = "Abreviatura"
        '
        'etiCentro
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Appearance55.TextVAlignAsString = "Middle"
        Me.etiCentro.Appearance = Appearance55
        Me.etiCentro.AutoSize = True
        Me.etiCentro.Location = New System.Drawing.Point(534, 10)
        Me.etiCentro.Name = "etiCentro"
        Me.etiCentro.Size = New System.Drawing.Size(40, 14)
        Me.etiCentro.TabIndex = 6
        Me.etiCentro.Text = "Centro:"
        '
        'txtViaje
        '
        Me.txtViaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViaje.Location = New System.Drawing.Point(17, 65)
        Me.txtViaje.MaxLength = 15
        Me.txtViaje.Name = "txtViaje"
        Me.txtViaje.Size = New System.Drawing.Size(100, 21)
        Me.txtViaje.TabIndex = 9
        '
        'txtOperacion
        '
        Me.txtOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperacion.Location = New System.Drawing.Point(16, 25)
        Me.txtOperacion.MaxLength = 15
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.Size = New System.Drawing.Size(100, 21)
        Me.txtOperacion.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Appearance56.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance56
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(19, 49)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel1.TabIndex = 8
        Me.UltraLabel1.Text = "Viaje:"
        '
        'cboPlaca
        '
        Appearance57.ForeColor = System.Drawing.Color.Black
        Me.cboPlaca.Appearance = Appearance57
        Me.cboPlaca.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboPlaca.DisplayMember = ""
        Me.cboPlaca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPlaca.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlaca.ForeColor = System.Drawing.Color.Black
        Me.cboPlaca.Location = New System.Drawing.Point(409, 65)
        Me.cboPlaca.Name = "cboPlaca"
        Me.cboPlaca.Size = New System.Drawing.Size(117, 21)
        Me.cboPlaca.TabIndex = 13
        Me.cboPlaca.ValueMember = "Id"
        '
        'cboCarga
        '
        Appearance58.ForeColor = System.Drawing.Color.Black
        Me.cboCarga.Appearance = Appearance58
        Me.cboCarga.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCarga.DisplayMember = ""
        Me.cboCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCarga.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarga.ForeColor = System.Drawing.Color.Black
        Me.cboCarga.Location = New System.Drawing.Point(408, 25)
        Me.cboCarga.Name = "cboCarga"
        Me.cboCarga.Size = New System.Drawing.Size(117, 21)
        Me.cboCarga.TabIndex = 5
        Me.cboCarga.ValueMember = "Id"
        '
        'etiViaje
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Appearance59.TextVAlignAsString = "Middle"
        Me.etiViaje.Appearance = Appearance59
        Me.etiViaje.AutoSize = True
        Me.etiViaje.Location = New System.Drawing.Point(17, 10)
        Me.etiViaje.Name = "etiViaje"
        Me.etiViaje.Size = New System.Drawing.Size(58, 14)
        Me.etiViaje.TabIndex = 0
        Me.etiViaje.Text = "Operación:"
        '
        'cboCliente
        '
        Appearance60.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCliente.Appearance = Appearance60
        Me.cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCliente.Location = New System.Drawing.Point(123, 65)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(280, 21)
        Me.cboCliente.TabIndex = 11
        Me.cboCliente.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance61
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(129, 49)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta2.TabIndex = 10
        Me.Etiqueta2.Text = "Cliente:"
        '
        'cboTrabajador
        '
        Appearance62.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Appearance = Appearance62
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Location = New System.Drawing.Point(122, 25)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(280, 21)
        Me.cboTrabajador.TabIndex = 3
        Me.cboTrabajador.ValueMember = "Id"
        '
        'UltraLabel2
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Appearance63.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance63
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(410, 49)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(35, 14)
        Me.UltraLabel2.TabIndex = 12
        Me.UltraLabel2.Text = "Placa:"
        '
        'etiTrabajadorCuenta
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Me.etiTrabajadorCuenta.Appearance = Appearance64
        Me.etiTrabajadorCuenta.AutoSize = True
        Me.etiTrabajadorCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajadorCuenta.ForeColor = System.Drawing.Color.Black
        Me.etiTrabajadorCuenta.Location = New System.Drawing.Point(129, 10)
        Me.etiTrabajadorCuenta.Name = "etiTrabajadorCuenta"
        Me.etiTrabajadorCuenta.Size = New System.Drawing.Size(35, 14)
        Me.etiTrabajadorCuenta.TabIndex = 2
        Me.etiTrabajadorCuenta.Text = "Piloto:"
        '
        'etitracto
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Appearance65.TextVAlignAsString = "Middle"
        Me.etitracto.Appearance = Appearance65
        Me.etitracto.AutoSize = True
        Me.etitracto.Location = New System.Drawing.Point(408, 10)
        Me.etitracto.Name = "etitracto"
        Me.etitracto.Size = New System.Drawing.Size(37, 14)
        Me.etitracto.TabIndex = 4
        Me.etitracto.Text = "Carga:"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.exgruViaje)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1261, 569)
        '
        'exgruViaje
        '
        Me.exgruViaje.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.exgruViaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.exgruViaje.ExpandedSize = New System.Drawing.Size(1261, 569)
        Me.exgruViaje.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.exgruViaje.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.exgruViaje.Location = New System.Drawing.Point(0, 0)
        Me.exgruViaje.Name = "exgruViaje"
        Me.exgruViaje.Size = New System.Drawing.Size(1261, 569)
        Me.exgruViaje.TabIndex = 0
        Me.exgruViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ficMovimientoFlete)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(2, 2)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1257, 565)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'ficMovimientoFlete
        '
        Me.ficMovimientoFlete.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficMovimientoFlete.Controls.Add(Me.UltraTabPageControl2)
        Me.ficMovimientoFlete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMovimientoFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMovimientoFlete.Location = New System.Drawing.Point(0, 0)
        Me.ficMovimientoFlete.Name = "ficMovimientoFlete"
        Me.ficMovimientoFlete.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficMovimientoFlete.Size = New System.Drawing.Size(1257, 565)
        Me.ficMovimientoFlete.TabIndex = 0
        UltraTab7.TabPage = Me.UltraTabPageControl2
        UltraTab7.Text = "Movimiento Flete"
        Me.ficMovimientoFlete.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7})
        Me.ficMovimientoFlete.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1255, 542)
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1111, 356)
        '
        'ficOperacion
        '
        Me.ficOperacion.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOperacion.Controls.Add(Me.UltraTabPageControl7)
        Me.ficOperacion.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficOperacion.Location = New System.Drawing.Point(0, 0)
        Me.ficOperacion.Name = "ficOperacion"
        Me.ficOperacion.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOperacion.Size = New System.Drawing.Size(1263, 592)
        Me.ficOperacion.TabIndex = 0
        UltraTab4.Key = "Lista"
        UltraTab4.TabPage = Me.UltraTabPageControl7
        UltraTab4.Text = "Lista"
        UltraTab10.Key = "Mantenimiento"
        UltraTab10.TabPage = Me.UltraTabPageControl1
        UltraTab10.Text = "Mantenimiento"
        Me.ficOperacion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab10})
        Me.ficOperacion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1261, 569)
        '
        'UltraToolTipManager
        '
        Me.UltraToolTipManager.ContainingControl = Me
        Me.UltraToolTipManager.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager.ToolTipTitle = "Mensaje del Sistema"
        '
        'Etiqueta15
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta15.Appearance = Appearance66
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(15, 46)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta15.TabIndex = 110
        Me.Etiqueta15.Text = "Glosa"
        '
        'Texto1
        '
        Me.Texto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Texto1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Texto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Texto1.Location = New System.Drawing.Point(57, 41)
        Me.Texto1.Multiline = True
        Me.Texto1.Name = "Texto1"
        Me.Texto1.Size = New System.Drawing.Size(302, 59)
        Me.Texto1.TabIndex = 2
        '
        'Fecha3
        '
        Appearance67.ForeColor = System.Drawing.Color.Black
        Me.Fecha3.Appearance = Appearance67
        Me.Fecha3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha3.ForeColor = System.Drawing.Color.Black
        Me.Fecha3.Location = New System.Drawing.Point(249, 19)
        Me.Fecha3.Name = "Fecha3"
        Me.Fecha3.Size = New System.Drawing.Size(110, 21)
        Me.Fecha3.TabIndex = 1
        '
        'Etiqueta18
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta18.Appearance = Appearance68
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(208, 24)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta18.TabIndex = 109
        Me.Etiqueta18.Text = "Fecha"
        '
        'Etiqueta19
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta19.Appearance = Appearance69
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(9, 20)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta19.TabIndex = 104
        Me.Etiqueta19.Text = "Importe"
        '
        'NumeroDecimal1
        '
        Appearance70.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance70.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal1.Appearance = Appearance70
        Me.NumeroDecimal1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NumeroDecimal1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal1.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal1.Location = New System.Drawing.Point(57, 19)
        Me.NumeroDecimal1.MaskInput = "{double:9.4}"
        Me.NumeroDecimal1.Name = "NumeroDecimal1"
        Me.NumeroDecimal1.NullText = "0.00"
        Me.NumeroDecimal1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.NumeroDecimal1.Size = New System.Drawing.Size(100, 21)
        Me.NumeroDecimal1.TabIndex = 0
        '
        'ficDetalleGrupo
        '
        Me.ficDetalleGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetalleGrupo.Location = New System.Drawing.Point(0, 0)
        Me.ficDetalleGrupo.Name = "ficDetalleGrupo"
        Me.ficDetalleGrupo.SharedControlsPage = Me.UltraTabSharedControlsPage6
        Me.ficDetalleGrupo.Size = New System.Drawing.Size(200, 100)
        Me.ficDetalleGrupo.TabIndex = 0
        Me.ficDetalleGrupo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage6
        '
        Me.UltraTabSharedControlsPage6.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage6.Name = "UltraTabSharedControlsPage6"
        Me.UltraTabSharedControlsPage6.Size = New System.Drawing.Size(198, 79)
        '
        'UltraTabSharedControlsPage8
        '
        Me.UltraTabSharedControlsPage8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage8.Name = "UltraTabSharedControlsPage8"
        Me.UltraTabSharedControlsPage8.Size = New System.Drawing.Size(1105, 449)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(433, 262)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 4
        Me.ugb_Espera.Visible = False
        '
        'frm_Flete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 592)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficOperacion)
        Me.Name = "frm_Flete"
        Me.Text = "Movimiento Flete"
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.verAdelanto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrCheque.ResumeLayout(False)
        Me.agrCheque.PerformLayout()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrCargar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrCargar.ResumeLayout(False)
        Me.agrCargar.PerformLayout()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decImporteCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.expCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expCheque.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        CType(Me.griChequexCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextualCheque.ResumeLayout(False)
        CType(Me.ordChequexCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expCobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expCobro.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.PerformLayout()
        CType(Me.verChequePorCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decImporteCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosaCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verExtornoCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaCobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDetalleCargarCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalleCargarCobrar.ResumeLayout(False)
        CType(Me.GriMovimientoFleteGlobal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrFleteCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFleteCarga.ResumeLayout(False)
        CType(Me.agrDerechaCargar_Cobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDerechaCargar_Cobrar.ResumeLayout(False)
        CType(Me.ficCargar_Cobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCargar_Cobrar.ResumeLayout(False)
        CType(Me.agrViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrViaje.ResumeLayout(False)
        CType(Me.ficCargaFlete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCargaFlete.ResumeLayout(False)
        Me.UltraTabPageControl13.ResumeLayout(False)
        Me.UltraTabPageControl13.PerformLayout()
        CType(Me.cboTrabajadorFlete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldoViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl14.ResumeLayout(False)
        Me.UltraTabPageControl14.PerformLayout()
        CType(Me.cboAdm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOperaciones.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expOperacionDetalle.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griViajeDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual.ResumeLayout(False)
        CType(Me.expCuentaFlete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expCuentaFlete.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        CType(Me.agr1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agr1.ResumeLayout(False)
        CType(Me.agr2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agr2.ResumeLayout(False)
        CType(Me.griMovimientoFlete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuExtornar.ResumeLayout(False)
        CType(Me.agrSaldoFlete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrSaldoFlete.ResumeLayout(False)
        Me.agrSaldoFlete.PerformLayout()
        CType(Me.decSaldoPorDepositar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decFleteDepositado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalCargado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoFlete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldoFlete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.verBuscarOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verContraEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCargado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verBuscarFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBuscarFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBuscarFecha.ResumeLayout(False)
        Me.agrBuscarFecha.PerformLayout()
        CType(Me.agrBuscarOtros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBuscarOtros.ResumeLayout(False)
        Me.agrBuscarOtros.PerformLayout()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruViaje.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.ficMovimientoFlete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMovimientoFlete.ResumeLayout(False)
        CType(Me.ficOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOperacion.ResumeLayout(False)
        CType(Me.Texto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDetalleGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficOperacion As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents exgruViaje As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents ficMovimientoFlete As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDetalleCargarCobrar As ISL.Controles.Agrupacion
    Friend WithEvents MenuContextual As ISL.Controles.MenuContextual
    Friend WithEvents UltraToolTipManager As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents Filtro As ISL.Controles.Filtro
    Friend WithEvents expCuentaFlete As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griMovimientoFlete As ISL.Controles.Grilla
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents fecFechaCarga As ISL.Controles.Fecha
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents decImporteCarga As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents agrCargar As ISL.Controles.Agrupacion
    Friend WithEvents verAdelanto As ISL.Controles.Chequear
    Friend WithEvents agrCheque As ISL.Controles.Agrupacion
    Friend WithEvents verCheque As ISL.Controles.Chequear
    Friend WithEvents fecFechaCheque As ISL.Controles.Fecha
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents txtNumeroCheque As ISL.Controles.Texto
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents agrFleteCarga As ISL.Controles.Agrupacion
    Friend WithEvents GriMovimientoFleteGlobal As ISL.Controles.Grilla
    Friend WithEvents cboBanco As ISL.Controles.Combo
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents agrDerechaCargar_Cobrar As ISL.Controles.Agrupacion
    Friend WithEvents ficCargar_Cobrar As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents verExtornoCobro As ISL.Controles.Chequear
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosaCobro As ISL.Controles.Texto
    Friend WithEvents fecFechaCobro As ISL.Controles.Fecha
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents decImporteCobro As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Texto1 As ISL.Controles.Texto
    Friend WithEvents Fecha3 As ISL.Controles.Fecha
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents NumeroDecimal1 As ISL.Controles.NumeroDecimal
    Friend WithEvents griChequexCobrar As ISL.Controles.Grilla
    Friend WithEvents ordChequexCobrar As ISL.Controles.OrigenDatos
    Friend WithEvents expCheque As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents expCobro As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents verChequePorCobrar As ISL.Controles.Chequear
    Friend WithEvents MenuContextualCheque As ISL.Controles.MenuContextual
    Friend WithEvents mnuConsultarCheque As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrSaldoFlete As ISL.Controles.Agrupacion
    Friend WithEvents etiSaldo As ISL.Controles.Etiqueta
    Friend WithEvents decSaldoFlete As ISL.Controles.NumeroDecimal
    Friend WithEvents agr1 As ISL.Controles.Agrupacion
    Friend WithEvents agr2 As ISL.Controles.Agrupacion
    Friend WithEvents decMontoFlete As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents decTotalCargado As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents etiSaldoFlete As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents etiSaldoCarga As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents decFleteDepositado As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents ficDetalleGrupo As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage6 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabSharedControlsPage8 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents decSaldoPorDepositar As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta39 As ISL.Controles.Etiqueta
    Friend WithEvents MenuExtornar As ISL.Controles.MenuContextual
    Friend WithEvents MnuExtornar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrBuscarFecha As ISL.Controles.Agrupacion
    Friend WithEvents verBuscarFecha As ISL.Controles.Chequear
    Friend WithEvents agrBuscarOtros As ISL.Controles.Agrupacion
    Friend WithEvents verBuscarOtros As ISL.Controles.Chequear
    Friend WithEvents txtViaje As ISL.Controles.Texto
    Friend WithEvents txtOperacion As ISL.Controles.Texto
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCarga As ISL.Controles.Combo
    Friend WithEvents etiViaje As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCliente As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents etiTrabajadorCuenta As ISL.Controles.Etiqueta
    Friend WithEvents etitracto As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verContraEntrega As ISL.Controles.Chequear
    Friend WithEvents cboPlaca As ISL.Controles.Combo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents agrOperaciones As ISL.Controles.Agrupacion
    Friend WithEvents griViajeDetalle As ISL.Controles.Grilla
    Friend WithEvents expOperacionDetalle As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents colorCargado As ISL.Controles.Colores
    Friend WithEvents EtiCargado As ISL.Controles.Etiqueta
    Friend WithEvents cboCentro As ISL.Controles.Combo
    Friend WithEvents etiCentro As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents MnuCargar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrViaje As ISL.Controles.Agrupacion
    Friend WithEvents ficCargaFlete As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage9 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents etiEstadoAsociado As ISL.Controles.Etiqueta
    Friend WithEvents etiFechaViajeAsociado As ISL.Controles.Etiqueta
    Friend WithEvents etiRutaCarga As ISL.Controles.Etiqueta
    Friend WithEvents eti As ISL.Controles.Etiqueta
    Friend WithEvents etiFecha As ISL.Controles.Etiqueta
    Friend WithEvents etiRutaAsociada As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajadorFlete As ISL.Controles.Combo
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents decSaldoViaje As ISL.Controles.NumeroDecimal
    Friend WithEvents cboViaje As ISL.Controles.Combo
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cboAdm As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
