<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReciboPorHonorario
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
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrRH = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaReciboHonorario = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual2 = New ISL.Controles.MenuContextual(Me.components)
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarTesoreriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odReciboPorHonorario = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.cmdEnviaTesoreria = New ISL.Controles.Boton(Me.components)
        Me.agrFiltro = New ISL.Controles.Agrupacion(Me.components)
        Me.rbNroDoc = New System.Windows.Forms.RadioButton()
        Me.rbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.etiEnviado = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.ColoresEnviado = New ISL.Controles.Colores(Me.components)
        Me.gbDatosAdicionales = New System.Windows.Forms.GroupBox()
        Me.rfReciboPorHonorarioHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfReciboPorHonorarioDesde = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboEstadoRecibo = New ISL.Controles.ComboMaestros(Me.components)
        Me.gbOI = New System.Windows.Forms.GroupBox()
        Me.txtNumeroI = New ISL.Controles.Texto(Me.components)
        Me.txtSerieI = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea4 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.decTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.chkRuc = New ISL.Controles.Chequear(Me.components)
        Me.cboProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.verImpuestoRenta = New ISL.Controles.Chequear(Me.components)
        Me.txtProveedor = New ISL.Controles.Texto(Me.components)
        Me.decSubTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.decImpRenta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecRecHonorario = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtEstado = New ISL.Controles.Texto(Me.components)
        Me.etiEstado = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtTipoDoc = New ISL.Controles.Texto(Me.components)
        Me.etiNroOrden = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraToolbarsDockArea11 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea12 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea9 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea10 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.ficReciboH = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrRH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrRH.SuspendLayout()
        CType(Me.griListaReciboHonorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual2.SuspendLayout()
        CType(Me.odReciboPorHonorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFiltro.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresEnviado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.cboEstadoRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOI.SuspendLayout()
        CType(Me.txtNumeroI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verImpuestoRenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImpRenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecRecHonorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficReciboH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficReciboH.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrRH)
        Me.UltraTabPageControl1.Controls.Add(Me.agrFiltro)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1087, 401)
        '
        'agrRH
        '
        Me.agrRH.Controls.Add(Me.griListaReciboHonorario)
        Me.agrRH.Controls.Add(Me.agrMenuLista)
        Me.agrRH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrRH.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrRH.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrRH.Location = New System.Drawing.Point(0, 101)
        Me.agrRH.Name = "agrRH"
        Me.agrRH.Size = New System.Drawing.Size(1087, 300)
        Me.agrRH.TabIndex = 1
        Me.agrRH.Text = "Listado:"
        Me.agrRH.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaReciboHonorario
        '
        Me.griListaReciboHonorario.ContextMenuStrip = Me.MenuContextual2
        Me.griListaReciboHonorario.DataSource = Me.odReciboPorHonorario
        UltraGridColumn35.Header.VisiblePosition = 19
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.Caption = "Nro. Documento"
        UltraGridColumn37.Header.VisiblePosition = 12
        UltraGridColumn37.Width = 127
        UltraGridColumn38.Header.VisiblePosition = 2
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.Width = 91
        UltraGridColumn39.Header.VisiblePosition = 3
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.Width = 96
        UltraGridColumn40.Header.Caption = "Fecha"
        UltraGridColumn40.Header.VisiblePosition = 1
        UltraGridColumn40.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn40.Width = 167
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 5
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 6
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 7
        UltraGridColumn44.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance1
        UltraGridColumn45.Header.VisiblePosition = 28
        UltraGridColumn45.MaskInput = "{double:9.4}"
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn45.Width = 93
        UltraGridColumn46.Header.VisiblePosition = 8
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 9
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 10
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.Caption = "Proveedor"
        UltraGridColumn49.Header.VisiblePosition = 11
        UltraGridColumn49.Width = 289
        UltraGridColumn50.Header.VisiblePosition = 14
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 15
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 16
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 17
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 18
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 20
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 21
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 22
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 23
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 13
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 24
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 25
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 26
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 27
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.Caption = "Estado"
        UltraGridColumn64.Header.VisiblePosition = 29
        UltraGridColumn64.Width = 108
        UltraGridColumn65.Header.VisiblePosition = 30
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 31
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 32
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 33
        UltraGridColumn68.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 34
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 35
        UltraGridColumn2.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn1, UltraGridColumn2})
        Me.griListaReciboHonorario.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaReciboHonorario.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaReciboHonorario.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaReciboHonorario.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaReciboHonorario.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaReciboHonorario.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance2.BorderColor = System.Drawing.Color.Silver
        Me.griListaReciboHonorario.DisplayLayout.Override.CellAppearance = Appearance2
        Me.griListaReciboHonorario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaReciboHonorario.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaReciboHonorario.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaReciboHonorario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaReciboHonorario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance3.BorderColor = System.Drawing.Color.Silver
        Me.griListaReciboHonorario.DisplayLayout.Override.RowAppearance = Appearance3
        Me.griListaReciboHonorario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaReciboHonorario.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griListaReciboHonorario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaReciboHonorario.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaReciboHonorario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaReciboHonorario.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaReciboHonorario.Location = New System.Drawing.Point(3, 47)
        Me.griListaReciboHonorario.Name = "griListaReciboHonorario"
        Me.griListaReciboHonorario.Size = New System.Drawing.Size(1081, 250)
        Me.griListaReciboHonorario.TabIndex = 1
        '
        'MenuContextual2
        '
        Me.MenuContextual2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual2.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.ActualizarToolStripMenuItem2, Me.EliminarToolStripMenuItem3, Me.EnviarTesoreriaToolStripMenuItem})
        Me.MenuContextual2.Name = "MenuContextual1"
        Me.MenuContextual2.Size = New System.Drawing.Size(162, 92)
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        Me.NuevoToolStripMenuItem1.ToolTipText = "Insertar un nuevo Requerimiento"
        '
        'ActualizarToolStripMenuItem2
        '
        Me.ActualizarToolStripMenuItem2.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem2.Name = "ActualizarToolStripMenuItem2"
        Me.ActualizarToolStripMenuItem2.Size = New System.Drawing.Size(161, 22)
        Me.ActualizarToolStripMenuItem2.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem2.ToolTipText = "Actualizar o modificar el Requerimiento seleccionado"
        '
        'EliminarToolStripMenuItem3
        '
        Me.EliminarToolStripMenuItem3.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem3.Name = "EliminarToolStripMenuItem3"
        Me.EliminarToolStripMenuItem3.Size = New System.Drawing.Size(161, 22)
        Me.EliminarToolStripMenuItem3.Text = "Eliminar"
        Me.EliminarToolStripMenuItem3.ToolTipText = "Eliminar el Requerimiento seleccionado"
        '
        'EnviarTesoreriaToolStripMenuItem
        '
        Me.EnviarTesoreriaToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.EnviarTesoreriaToolStripMenuItem.Name = "EnviarTesoreriaToolStripMenuItem"
        Me.EnviarTesoreriaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.EnviarTesoreriaToolStripMenuItem.Text = "Enviar Documento"
        Me.EnviarTesoreriaToolStripMenuItem.ToolTipText = "Enviar a Tesoreria"
        '
        'odReciboPorHonorario
        '
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn36.DataType = GetType(Boolean)
        Me.odReciboPorHonorario.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.cmdEnviaTesoreria)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 17)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1081, 30)
        Me.agrMenuLista.TabIndex = 0
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmdEnviaTesoreria
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance4.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.cmdEnviaTesoreria.Appearance = Appearance4
        Me.cmdEnviaTesoreria.BackColorInternal = System.Drawing.Color.Transparent
        Me.cmdEnviaTesoreria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdEnviaTesoreria.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdEnviaTesoreria.Enabled = False
        Me.cmdEnviaTesoreria.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnviaTesoreria.ForeColor = System.Drawing.Color.Black
        Me.cmdEnviaTesoreria.Location = New System.Drawing.Point(3, 3)
        Me.cmdEnviaTesoreria.Name = "cmdEnviaTesoreria"
        Me.cmdEnviaTesoreria.Size = New System.Drawing.Size(90, 24)
        Me.cmdEnviaTesoreria.TabIndex = 0
        Me.cmdEnviaTesoreria.Text = "Enviar Doc."
        Me.cmdEnviaTesoreria.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'agrFiltro
        '
        Me.agrFiltro.Controls.Add(Me.rbNroDoc)
        Me.agrFiltro.Controls.Add(Me.rbDatosAdicionales)
        Me.agrFiltro.Controls.Add(Me.Agrupacion7)
        Me.agrFiltro.Controls.Add(Me.gbDatosAdicionales)
        Me.agrFiltro.Controls.Add(Me.gbOI)
        Me.agrFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrFiltro.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFiltro.ForeColor = System.Drawing.Color.Black
        Me.agrFiltro.Location = New System.Drawing.Point(0, 0)
        Me.agrFiltro.Name = "agrFiltro"
        Me.agrFiltro.Size = New System.Drawing.Size(1087, 101)
        Me.agrFiltro.TabIndex = 0
        Me.agrFiltro.Text = "Filtros:"
        Me.agrFiltro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rbNroDoc
        '
        Me.rbNroDoc.AutoSize = True
        Me.rbNroDoc.BackColor = System.Drawing.Color.Transparent
        Me.rbNroDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNroDoc.ForeColor = System.Drawing.Color.Navy
        Me.rbNroDoc.Location = New System.Drawing.Point(349, 18)
        Me.rbNroDoc.Name = "rbNroDoc"
        Me.rbNroDoc.Size = New System.Drawing.Size(79, 17)
        Me.rbNroDoc.TabIndex = 3
        Me.rbNroDoc.TabStop = True
        Me.rbNroDoc.Text = "N° Recibo :"
        Me.rbNroDoc.UseVisualStyleBackColor = False
        '
        'rbDatosAdicionales
        '
        Me.rbDatosAdicionales.AutoSize = True
        Me.rbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rbDatosAdicionales.Checked = True
        Me.rbDatosAdicionales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDatosAdicionales.ForeColor = System.Drawing.Color.Navy
        Me.rbDatosAdicionales.Location = New System.Drawing.Point(21, 20)
        Me.rbDatosAdicionales.Name = "rbDatosAdicionales"
        Me.rbDatosAdicionales.Size = New System.Drawing.Size(116, 17)
        Me.rbDatosAdicionales.TabIndex = 1
        Me.rbDatosAdicionales.TabStop = True
        Me.rbDatosAdicionales.Text = "Datos Adicionales :"
        Me.rbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.etiGenerada)
        Me.Agrupacion7.Controls.Add(Me.etiEnviado)
        Me.Agrupacion7.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion7.Controls.Add(Me.ColoresEnviado)
        Me.Agrupacion7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion7.Location = New System.Drawing.Point(534, 23)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(141, 66)
        Me.Agrupacion7.TabIndex = 4
        Me.Agrupacion7.Text = "Estados"
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'etiGenerada
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance5
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(11, 22)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(51, 15)
        Me.etiGenerada.TabIndex = 0
        Me.etiGenerada.Text = "Generado"
        '
        'etiEnviado
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnviado.Appearance = Appearance6
        Me.etiEnviado.AutoSize = True
        Me.etiEnviado.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnviado.ForeColor = System.Drawing.Color.Black
        Me.etiEnviado.Location = New System.Drawing.Point(86, 22)
        Me.etiEnviado.Name = "etiEnviado"
        Me.etiEnviado.Size = New System.Drawing.Size(42, 15)
        Me.etiEnviado.TabIndex = 2
        Me.etiEnviado.Text = "Enviado"
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Color = System.Drawing.Color.White
        Me.ColoresGenerado.Location = New System.Drawing.Point(15, 39)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 22)
        Me.ColoresGenerado.TabIndex = 1
        Me.ColoresGenerado.Text = "White"
        '
        'ColoresEnviado
        '
        Me.ColoresEnviado.Location = New System.Drawing.Point(84, 39)
        Me.ColoresEnviado.Name = "ColoresEnviado"
        Me.ColoresEnviado.Size = New System.Drawing.Size(43, 22)
        Me.ColoresEnviado.TabIndex = 3
        Me.ColoresEnviado.Text = "Control"
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.gbDatosAdicionales.Controls.Add(Me.rfReciboPorHonorarioHasta)
        Me.gbDatosAdicionales.Controls.Add(Me.rfReciboPorHonorarioDesde)
        Me.gbDatosAdicionales.Controls.Add(Me.UltraLabel25)
        Me.gbDatosAdicionales.Controls.Add(Me.UltraLabel24)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta7)
        Me.gbDatosAdicionales.Controls.Add(Me.cboEstadoRecibo)
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(6, 23)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(324, 76)
        Me.gbDatosAdicionales.TabIndex = 0
        Me.gbDatosAdicionales.TabStop = False
        '
        'rfReciboPorHonorarioHasta
        '
        Me.rfReciboPorHonorarioHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfReciboPorHonorarioHasta.Location = New System.Drawing.Point(217, 21)
        Me.rfReciboPorHonorarioHasta.Name = "rfReciboPorHonorarioHasta"
        Me.rfReciboPorHonorarioHasta.Size = New System.Drawing.Size(93, 20)
        Me.rfReciboPorHonorarioHasta.TabIndex = 3
        '
        'rfReciboPorHonorarioDesde
        '
        Me.rfReciboPorHonorarioDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfReciboPorHonorarioDesde.Location = New System.Drawing.Point(79, 21)
        Me.rfReciboPorHonorarioDesde.Name = "rfReciboPorHonorarioDesde"
        Me.rfReciboPorHonorarioDesde.Size = New System.Drawing.Size(95, 20)
        Me.rfReciboPorHonorarioDesde.TabIndex = 1
        '
        'UltraLabel25
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance7
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(180, 25)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel25.TabIndex = 2
        Me.UltraLabel25.Text = "Hasta:"
        '
        'UltraLabel24
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance8
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(38, 23)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel24.TabIndex = 0
        Me.UltraLabel24.Text = "Desde:"
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(35, 51)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta7.TabIndex = 4
        Me.Etiqueta7.Text = "Estado:"
        '
        'cboEstadoRecibo
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoRecibo.Appearance = Appearance9
        Me.cboEstadoRecibo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoRecibo.DisplayMember = "Nombre"
        Me.cboEstadoRecibo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoRecibo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoRecibo.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoRecibo.Location = New System.Drawing.Point(79, 47)
        Me.cboEstadoRecibo.Name = "cboEstadoRecibo"
        Me.cboEstadoRecibo.Size = New System.Drawing.Size(136, 21)
        Me.cboEstadoRecibo.TabIndex = 5
        Me.cboEstadoRecibo.ValueMember = "Id"
        '
        'gbOI
        '
        Me.gbOI.BackColor = System.Drawing.Color.Transparent
        Me.gbOI.Controls.Add(Me.txtNumeroI)
        Me.gbOI.Controls.Add(Me.txtSerieI)
        Me.gbOI.Enabled = False
        Me.gbOI.Location = New System.Drawing.Point(336, 22)
        Me.gbOI.Name = "gbOI"
        Me.gbOI.Size = New System.Drawing.Size(192, 76)
        Me.gbOI.TabIndex = 2
        Me.gbOI.TabStop = False
        '
        'txtNumeroI
        '
        Appearance10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroI.Appearance = Appearance10
        Me.txtNumeroI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroI.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroI.Location = New System.Drawing.Point(81, 24)
        Me.txtNumeroI.MaxLength = 10
        Me.txtNumeroI.Name = "txtNumeroI"
        Me.txtNumeroI.Size = New System.Drawing.Size(103, 21)
        Me.txtNumeroI.TabIndex = 1
        '
        'txtSerieI
        '
        Appearance11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerieI.Appearance = Appearance11
        Me.txtSerieI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieI.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerieI.Location = New System.Drawing.Point(28, 24)
        Me.txtSerieI.MaxLength = 4
        Me.txtSerieI.Name = "txtSerieI"
        Me.txtSerieI.Size = New System.Drawing.Size(47, 21)
        Me.txtSerieI.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea2)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea3)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea4)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatoGeneral)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea11)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea12)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea9)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea10)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1087, 401)
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1087, 0)
        '
        'UltraToolbarsDockArea2
        '
        Me.UltraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea2.Location = New System.Drawing.Point(0, 401)
        Me.UltraToolbarsDockArea2.Name = "UltraToolbarsDockArea2"
        Me.UltraToolbarsDockArea2.Size = New System.Drawing.Size(1087, 0)
        '
        'UltraToolbarsDockArea3
        '
        Me.UltraToolbarsDockArea3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea3.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea3.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea3.Name = "UltraToolbarsDockArea3"
        Me.UltraToolbarsDockArea3.Size = New System.Drawing.Size(0, 401)
        '
        'UltraToolbarsDockArea4
        '
        Me.UltraToolbarsDockArea4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea4.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea4.Location = New System.Drawing.Point(1087, 0)
        Me.UltraToolbarsDockArea4.Name = "UltraToolbarsDockArea4"
        Me.UltraToolbarsDockArea4.Size = New System.Drawing.Size(0, 401)
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.decTC)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta3)
        Me.agrDatoGeneral.Controls.Add(Me.chkRuc)
        Me.agrDatoGeneral.Controls.Add(Me.cboProveedor)
        Me.agrDatoGeneral.Controls.Add(Me.verImpuestoRenta)
        Me.agrDatoGeneral.Controls.Add(Me.txtProveedor)
        Me.agrDatoGeneral.Controls.Add(Me.decSubTotal)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta5)
        Me.agrDatoGeneral.Controls.Add(Me.decImpRenta)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta1)
        Me.agrDatoGeneral.Controls.Add(Me.txtSerie)
        Me.agrDatoGeneral.Controls.Add(Me.txtNumero)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta2)
        Me.agrDatoGeneral.Controls.Add(Me.fecRecHonorario)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta16)
        Me.agrDatoGeneral.Controls.Add(Me.txtEstado)
        Me.agrDatoGeneral.Controls.Add(Me.etiEstado)
        Me.agrDatoGeneral.Controls.Add(Me.cboMoneda)
        Me.agrDatoGeneral.Controls.Add(Me.txtTipoDoc)
        Me.agrDatoGeneral.Controls.Add(Me.etiNroOrden)
        Me.agrDatoGeneral.Controls.Add(Me.txtGlosa)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta13)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta12)
        Me.agrDatoGeneral.Controls.Add(Me.decTotal)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta11)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta4)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(1087, 401)
        Me.agrDatoGeneral.TabIndex = 0
        Me.agrDatoGeneral.Text = "Datos Generales"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decTC
        '
        Appearance12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTC.Appearance = Appearance12
        Me.decTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTC.Location = New System.Drawing.Point(83, 278)
        Me.decTC.MaskInput = "{double:3.3}"
        Me.decTC.Name = "decTC"
        Me.decTC.NullText = "0.00"
        Me.decTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTC.Size = New System.Drawing.Size(56, 21)
        Me.decTC.TabIndex = 19
        '
        'Etiqueta3
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance13
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(46, 282)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta3.TabIndex = 18
        Me.Etiqueta3.Text = "T.C. :"
        '
        'chkRuc
        '
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.chkRuc.Appearance = Appearance14
        Me.chkRuc.BackColor = System.Drawing.Color.Transparent
        Me.chkRuc.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRuc.ForeColor = System.Drawing.Color.Black
        Me.chkRuc.Location = New System.Drawing.Point(330, 28)
        Me.chkRuc.Name = "chkRuc"
        Me.chkRuc.Size = New System.Drawing.Size(44, 20)
        Me.chkRuc.TabIndex = 2
        Me.chkRuc.Text = "Ruc"
        '
        'cboProveedor
        '
        Me.cboProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedor.CheckedListSettings.ListSeparator = ","
        Me.cboProveedor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedor.DropDownWidth = 400
        Me.cboProveedor.Location = New System.Drawing.Point(83, 25)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(243, 23)
        Me.cboProveedor.TabIndex = 1
        '
        'verImpuestoRenta
        '
        Me.verImpuestoRenta.BackColor = System.Drawing.Color.Transparent
        Me.verImpuestoRenta.BackColorInternal = System.Drawing.Color.Transparent
        Me.verImpuestoRenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verImpuestoRenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verImpuestoRenta.Location = New System.Drawing.Point(179, 306)
        Me.verImpuestoRenta.Name = "verImpuestoRenta"
        Me.verImpuestoRenta.Size = New System.Drawing.Size(102, 20)
        Me.verImpuestoRenta.TabIndex = 22
        Me.verImpuestoRenta.Text = "Impuesto Renta:"
        '
        'txtProveedor
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtProveedor.Appearance = Appearance15
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtProveedor.Location = New System.Drawing.Point(83, 52)
        Me.txtProveedor.MaxLength = 200
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(290, 21)
        Me.txtProveedor.TabIndex = 4
        Me.txtProveedor.TabStop = False
        Me.txtProveedor.Tag = ""
        Me.txtProveedor.Text = "INDUAMERICA SERVICIOS LOGISTICOS S.A.C."
        '
        'decSubTotal
        '
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decSubTotal.Appearance = Appearance16
        Me.decSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSubTotal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decSubTotal.Location = New System.Drawing.Point(287, 278)
        Me.decSubTotal.Name = "decSubTotal"
        Me.decSubTotal.NullText = "0.00"
        Me.decSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotal.Size = New System.Drawing.Size(86, 21)
        Me.decSubTotal.TabIndex = 21
        '
        'Etiqueta5
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance17
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(224, 282)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta5.TabIndex = 20
        Me.Etiqueta5.Text = "Sub Total :"
        '
        'decImpRenta
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decImpRenta.Appearance = Appearance18
        Me.decImpRenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImpRenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImpRenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decImpRenta.Location = New System.Drawing.Point(287, 305)
        Me.decImpRenta.Name = "decImpRenta"
        Me.decImpRenta.NullText = "0.00"
        Me.decImpRenta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImpRenta.Size = New System.Drawing.Size(86, 21)
        Me.decImpRenta.TabIndex = 23
        '
        'Etiqueta1
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance19
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(14, 111)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(63, 15)
        Me.Etiqueta1.TabIndex = 7
        Me.Etiqueta1.Text = "Documento:"
        '
        'txtSerie
        '
        Appearance20.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance20.TextHAlignAsString = "Right"
        Me.txtSerie.Appearance = Appearance20
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerie.Location = New System.Drawing.Point(83, 107)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(42, 21)
        Me.txtSerie.TabIndex = 8
        '
        'txtNumero
        '
        Appearance21.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance21.TextHAlignAsString = "Right"
        Me.txtNumero.Appearance = Appearance21
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumero.Location = New System.Drawing.Point(131, 107)
        Me.txtNumero.MaxLength = 7
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(93, 21)
        Me.txtNumero.TabIndex = 9
        '
        'Etiqueta2
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance22
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(230, 111)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta2.TabIndex = 10
        Me.Etiqueta2.Text = "Fecha:"
        '
        'fecRecHonorario
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.fecRecHonorario.Appearance = Appearance23
        Me.fecRecHonorario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecRecHonorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecRecHonorario.ForeColor = System.Drawing.Color.Black
        Me.fecRecHonorario.Location = New System.Drawing.Point(272, 107)
        Me.fecRecHonorario.Name = "fecRecHonorario"
        Me.fecRecHonorario.Size = New System.Drawing.Size(101, 21)
        Me.fecRecHonorario.TabIndex = 11
        '
        'Etiqueta16
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta16.Appearance = Appearance24
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(17, 31)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(60, 15)
        Me.Etiqueta16.TabIndex = 0
        Me.Etiqueta16.Text = "Proveedor :"
        '
        'txtEstado
        '
        Appearance25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEstado.Appearance = Appearance25
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEstado.Location = New System.Drawing.Point(239, 133)
        Me.txtEstado.MaxLength = 200
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(134, 21)
        Me.txtEstado.TabIndex = 15
        Me.txtEstado.TabStop = False
        Me.txtEstado.Text = "GENERADA"
        '
        'etiEstado
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Me.etiEstado.Appearance = Appearance26
        Me.etiEstado.AutoSize = True
        Me.etiEstado.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEstado.Location = New System.Drawing.Point(193, 137)
        Me.etiEstado.Name = "etiEstado"
        Me.etiEstado.Size = New System.Drawing.Size(40, 15)
        Me.etiEstado.TabIndex = 14
        Me.etiEstado.Text = "Estado:"
        '
        'cboMoneda
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance27
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(83, 133)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.ReadOnly = True
        Me.cboMoneda.Size = New System.Drawing.Size(90, 21)
        Me.cboMoneda.TabIndex = 13
        Me.cboMoneda.ValueMember = "Id"
        '
        'txtTipoDoc
        '
        Appearance28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoDoc.Appearance = Appearance28
        Me.txtTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoDoc.Location = New System.Drawing.Point(83, 80)
        Me.txtTipoDoc.MaxLength = 200
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.ReadOnly = True
        Me.txtTipoDoc.Size = New System.Drawing.Size(290, 21)
        Me.txtTipoDoc.TabIndex = 6
        Me.txtTipoDoc.TabStop = False
        Me.txtTipoDoc.Text = "RECIBO POR HONORARIO"
        '
        'etiNroOrden
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.etiNroOrden.Appearance = Appearance29
        Me.etiNroOrden.AutoSize = True
        Me.etiNroOrden.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNroOrden.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNroOrden.Location = New System.Drawing.Point(23, 84)
        Me.etiNroOrden.Name = "etiNroOrden"
        Me.etiNroOrden.Size = New System.Drawing.Size(54, 15)
        Me.etiNroOrden.TabIndex = 5
        Me.etiNroOrden.Text = "Tipo Doc :"
        '
        'txtGlosa
        '
        Appearance30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance30
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtGlosa.Location = New System.Drawing.Point(83, 161)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(290, 111)
        Me.txtGlosa.TabIndex = 17
        Me.txtGlosa.Tag = "0"
        '
        'Etiqueta13
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance31
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(43, 163)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta13.TabIndex = 16
        Me.Etiqueta13.Text = "Glosa:"
        '
        'Etiqueta12
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance32
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(31, 135)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta12.TabIndex = 12
        Me.Etiqueta12.Text = "Moneda:"
        '
        'decTotal
        '
        Appearance33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTotal.Appearance = Appearance33
        Me.decTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTotal.Location = New System.Drawing.Point(287, 332)
        Me.decTotal.Name = "decTotal"
        Me.decTotal.NullText = "0.00"
        Me.decTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotal.Size = New System.Drawing.Size(86, 21)
        Me.decTotal.TabIndex = 25
        '
        'Etiqueta11
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance34
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(212, 336)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(69, 15)
        Me.Etiqueta11.TabIndex = 24
        Me.Etiqueta11.Text = "Total Monto :"
        '
        'Etiqueta4
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance35
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(24, 56)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(53, 15)
        Me.Etiqueta4.TabIndex = 3
        Me.Etiqueta4.Text = "Empresa :"
        '
        'UltraToolbarsDockArea11
        '
        Me.UltraToolbarsDockArea11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea11.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea11.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea11.Name = "UltraToolbarsDockArea11"
        Me.UltraToolbarsDockArea11.Size = New System.Drawing.Size(0, 401)
        '
        'UltraToolbarsDockArea12
        '
        Me.UltraToolbarsDockArea12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea12.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea12.Location = New System.Drawing.Point(1087, 0)
        Me.UltraToolbarsDockArea12.Name = "UltraToolbarsDockArea12"
        Me.UltraToolbarsDockArea12.Size = New System.Drawing.Size(0, 401)
        '
        'UltraToolbarsDockArea9
        '
        Me.UltraToolbarsDockArea9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea9.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea9.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea9.Name = "UltraToolbarsDockArea9"
        Me.UltraToolbarsDockArea9.Size = New System.Drawing.Size(1087, 0)
        '
        'UltraToolbarsDockArea10
        '
        Me.UltraToolbarsDockArea10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea10.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea10.Location = New System.Drawing.Point(0, 401)
        Me.UltraToolbarsDockArea10.Name = "UltraToolbarsDockArea10"
        Me.UltraToolbarsDockArea10.Size = New System.Drawing.Size(1087, 0)
        '
        'ficReciboH
        '
        Me.ficReciboH.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficReciboH.Controls.Add(Me.UltraTabPageControl1)
        Me.ficReciboH.Controls.Add(Me.UltraTabPageControl2)
        Me.ficReciboH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficReciboH.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficReciboH.Location = New System.Drawing.Point(0, 0)
        Me.ficReciboH.Name = "ficReciboH"
        Me.ficReciboH.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficReciboH.Size = New System.Drawing.Size(1089, 424)
        Me.ficReciboH.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Mantenimiento"
        Me.ficReciboH.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab4})
        Me.ficReciboH.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1087, 401)
        '
        'frm_ReciboPorHonorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1089, 424)
        Me.Controls.Add(Me.ficReciboH)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ReciboPorHonorario"
        Me.Text = "Recibo Por Honorario"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrRH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrRH.ResumeLayout(False)
        CType(Me.griListaReciboHonorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual2.ResumeLayout(False)
        CType(Me.odReciboPorHonorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFiltro.ResumeLayout(False)
        Me.agrFiltro.PerformLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresEnviado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.cboEstadoRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOI.ResumeLayout(False)
        Me.gbOI.PerformLayout()
        CType(Me.txtNumeroI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        Me.agrDatoGeneral.PerformLayout()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verImpuestoRenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decImpRenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecRecHonorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficReciboH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficReciboH.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficReciboH As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraToolbarsDockArea11 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea12 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea9 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea10 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrFiltro As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea4 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents txtEstado As ISL.Controles.Texto
    Friend WithEvents etiEstado As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents txtTipoDoc As ISL.Controles.Texto
    Friend WithEvents etiNroOrden As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents decTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents fecRecHonorario As ISL.Controles.Fecha
    Friend WithEvents decSubTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents decImpRenta As ISL.Controles.NumeroDecimal
    Friend WithEvents odReciboPorHonorario As ISL.Controles.OrigenDatos
    Friend WithEvents txtProveedor As ISL.Controles.Texto
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents gbOI As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerieI As ISL.Controles.Texto
    Friend WithEvents gbDatosAdicionales As System.Windows.Forms.GroupBox
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstadoRecibo As ISL.Controles.ComboMaestros
    Friend WithEvents txtNumeroI As ISL.Controles.Texto
    Friend WithEvents agrRH As ISL.Controles.Agrupacion
    Friend WithEvents griListaReciboHonorario As ISL.Controles.Grilla
    Friend WithEvents verImpuestoRenta As ISL.Controles.Chequear
    Friend WithEvents rfReciboPorHonorarioHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfReciboPorHonorarioDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ColoresEnviado As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents etiEnviado As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents chkRuc As ISL.Controles.Chequear
    Private WithEvents cboProveedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents rbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents rbNroDoc As System.Windows.Forms.RadioButton
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents cmdEnviaTesoreria As ISL.Controles.Boton
    Friend WithEvents MenuContextual2 As ISL.Controles.MenuContextual
    Friend WithEvents NuevoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarTesoreriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents decTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta

End Class
