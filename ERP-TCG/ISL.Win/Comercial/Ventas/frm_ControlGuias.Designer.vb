<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ControlGuias
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaAntigua")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Correlativo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaActual")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockGuias")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockTalonarios")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlacaAntigua")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Correlativo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlacaActual")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockGuias")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockTalonarios")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ControlGuias))
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo10 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Trabajador / Vehiculos No Disponible", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo9 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("No Disponibles", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGuiasControl")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Inicial")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Final")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngreso")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Anulado")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Terminado")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGuiasControl")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Inicial")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Final")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIngreso")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Anulado")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Terminado")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Trabajador / Vehiculos No Disponible", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("No Disponibles", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo7 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Trabajador / Vehiculos No Disponible", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo6 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("No Disponibles", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el copiloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el copiloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo8 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Fecha de Inicio del Viaje - Salida de Planta", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
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
        Dim UltraToolTipInfo14 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("No Disponibles", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo11 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el copiloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo12 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo13 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el copiloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdLista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.numStockTalonarios = New ISL.Controles.NumeroEntero(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ColorStockTalonarios = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTalonarios = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdGuiasTalonarios = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.exgruDetalle = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtStockGuias = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtStockTalonarios = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.exgruDisponibleNo = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ColorStock = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAnulado = New ISL.Controles.Colores(Me.components)
        Me.ColorEnUso = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTerminado = New ISL.Controles.Colores(Me.components)
        Me.txtObservacionTalanario = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel37 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecIngreso = New ISL.Controles.Fecha(Me.components)
        Me.txtFinal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.verAnulado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verTerminado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtInicial = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtCorrelativo = New ISL.Controles.Texto(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTracto = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel38 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtId = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtObservacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Colores7 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores8 = New ISL.Controles.Colores(Me.components)
        Me.Colores9 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores10 = New ISL.Controles.Colores(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ficControlGuias = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaRegistro.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.numStockTalonarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        CType(Me.ColorStockTalonarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.griTalonarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdGuiasTalonarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruDetalle.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout()
        CType(Me.exgruDisponibleNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruDisponibleNo.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.ColorStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEnUso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTerminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacionTalanario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTerminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.txtCorrelativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.Colores7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficControlGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficControlGuias.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrListaRegistro)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(982, 539)
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.griLista)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 80)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(982, 459)
        Me.agrListaRegistro.TabIndex = 1
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista Registro"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.ogdLista
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 85
        UltraGridColumn2.Header.VisiblePosition = 3
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 75
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 80
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance1
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.Width = 60
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance2
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.Width = 100
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Width = 500
        UltraGridColumn7.Header.VisiblePosition = 11
        UltraGridColumn7.Width = 159
        UltraGridColumn8.Header.VisiblePosition = 12
        UltraGridColumn8.Width = 188
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn10.Width = 80
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance3
        UltraGridColumn11.Header.Caption = "Stock G."
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn11.Width = 50
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance4
        UltraGridColumn12.Header.Caption = "Stock T."
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.Width = 50
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.ImageList = Me.imagenes
        Me.griLista.Location = New System.Drawing.Point(2, 18)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(978, 439)
        Me.griLista.TabIndex = 0
        Me.griLista.Tag = ""
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Insert, Me.Update, Me.Delete})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(121, 70)
        '
        'Insert
        '
        Me.Insert.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(120, 22)
        Me.Insert.Text = "Nuevo"
        Me.Insert.ToolTipText = "Insertar una nueva Pre-Demanda"
        '
        'Update
        '
        Me.Update.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(120, 22)
        Me.Update.Text = "Actualizar"
        Me.Update.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'Delete
        '
        Me.Delete.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(120, 22)
        Me.Delete.Text = "Eliminar"
        Me.Delete.ToolTipText = "Eliminar la Pre-Demanda seleccionada"
        '
        'ogdLista
        '
        Me.ogdLista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
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
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Controls.Add(Me.numStockTalonarios)
        Me.agrBusqueda.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.agrBusqueda.Controls.Add(Me.ColorStockTalonarios)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta3)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(982, 80)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(5, 49)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta1.TabIndex = 50
        Me.Etiqueta1.Text = "Talonarios"
        Me.ToolTip1.SetToolTip(Me.Etiqueta1, "Color de fondo para las demandas generadas")
        '
        'numStockTalonarios
        '
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.numStockTalonarios.Appearance = Appearance5
        Me.numStockTalonarios.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numStockTalonarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numStockTalonarios.ForeColor = System.Drawing.Color.Black
        Me.numStockTalonarios.FormatString = ""
        Me.numStockTalonarios.Location = New System.Drawing.Point(75, 37)
        Me.numStockTalonarios.MaskInput = "nn"
        Me.numStockTalonarios.MaxValue = 30
        Me.numStockTalonarios.MinValue = 1
        Me.numStockTalonarios.Name = "numStockTalonarios"
        Me.numStockTalonarios.NullText = "1"
        Me.numStockTalonarios.Size = New System.Drawing.Size(41, 21)
        Me.numStockTalonarios.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numStockTalonarios.TabIndex = 15
        Me.numStockTalonarios.Value = 1
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance6
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox1.Expanded = False
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(400, 60)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(959, 18)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(21, 60)
        Me.UltraExpandableGroupBox1.TabIndex = 49
        UltraToolTipInfo10.ToolTipText = "Trabajador / Vehiculos No Disponible"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBox1, UltraToolTipInfo10)
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(367, 54)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        UltraToolTipInfo9.ToolTipText = "No Disponibles"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBoxPanel2, UltraToolTipInfo9)
        Me.UltraExpandableGroupBoxPanel2.Visible = False
        '
        'ColorStockTalonarios
        '
        Me.ColorStockTalonarios.Location = New System.Drawing.Point(122, 37)
        Me.ColorStockTalonarios.Name = "ColorStockTalonarios"
        Me.ColorStockTalonarios.Size = New System.Drawing.Size(43, 21)
        Me.ColorStockTalonarios.TabIndex = 17
        Me.ColorStockTalonarios.Text = "Control"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(5, 35)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta3.TabIndex = 14
        Me.Etiqueta3.Text = "Stock"
        Me.ToolTip1.SetToolTip(Me.Etiqueta3, "Color de fondo para las demandas generadas")
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(59, 37)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(15, 21)
        Me.Etiqueta2.TabIndex = 51
        Me.Etiqueta2.Text = "<"
        Me.ToolTip1.SetToolTip(Me.Etiqueta2, "Color de fondo para las demandas generadas")
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.griTalonarios)
        Me.utpDetalle.Controls.Add(Me.exgruDetalle)
        Me.utpDetalle.Controls.Add(Me.agrDatoGeneral)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(982, 539)
        '
        'griTalonarios
        '
        Me.griTalonarios.DataSource = Me.ogdGuiasTalonarios
        Appearance7.BackColor = System.Drawing.Color.White
        Me.griTalonarios.DisplayLayout.Appearance = Appearance7
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.Hidden = True
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance8
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn16.Header.Appearance = Appearance9
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Width = 80
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance10
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn17.Width = 80
        UltraGridColumn18.Header.Caption = "F. Ingreso"
        UltraGridColumn18.Header.VisiblePosition = 4
        UltraGridColumn18.Width = 90
        UltraGridColumn19.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn19.Header.Appearance = Appearance11
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn19.Width = 50
        UltraGridColumn20.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn20.Header.VisiblePosition = 6
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn20.Width = 60
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn21.Width = 500
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridColumn22.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        UltraGridBand2.SummaryFooterCaption = "Totales:"
        Me.griTalonarios.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griTalonarios.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griTalonarios.DisplayLayout.GroupByBox.Hidden = True
        Me.griTalonarios.DisplayLayout.MaxColScrollRegions = 1
        Me.griTalonarios.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTalonarios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTalonarios.DisplayLayout.Override.CellPadding = 2
        Me.griTalonarios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTalonarios.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTalonarios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance12.TextHAlignAsString = "Left"
        Me.griTalonarios.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.griTalonarios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTalonarios.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance13.TextVAlignAsString = "Middle"
        Me.griTalonarios.DisplayLayout.Override.RowAppearance = Appearance13
        Me.griTalonarios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTalonarios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTalonarios.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griTalonarios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTalonarios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTalonarios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTalonarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTalonarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTalonarios.Location = New System.Drawing.Point(0, 130)
        Me.griTalonarios.Name = "griTalonarios"
        Me.griTalonarios.Size = New System.Drawing.Size(982, 409)
        Me.griTalonarios.TabIndex = 3
        Me.griTalonarios.Tag = ""
        '
        'ogdGuiasTalonarios
        '
        Me.ogdGuiasTalonarios.Band.Columns.AddRange(New Object() {UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22})
        '
        'exgruDetalle
        '
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.BackColor2 = System.Drawing.Color.White
        Me.exgruDetalle.ContentAreaAppearance = Appearance14
        Me.exgruDetalle.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.exgruDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruDetalle.ExpandedSize = New System.Drawing.Size(982, 75)
        Me.exgruDetalle.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.exgruDetalle.Location = New System.Drawing.Point(0, 55)
        Me.exgruDetalle.Name = "exgruDetalle"
        Me.exgruDetalle.Size = New System.Drawing.Size(982, 75)
        Me.exgruDetalle.TabIndex = 2
        Me.exgruDetalle.Text = "Talonarios"
        Me.exgruDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.exgruDisponibleNo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtObservacionTalanario)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel37)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.fecIngreso)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtFinal)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.verAnulado)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.verTerminado)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnAgregar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel12)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtInicial)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 25)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(976, 47)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance15.BackColor = System.Drawing.Color.White
        Appearance15.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance15
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(140, 47)
        Me.UltraExpandableGroupBox2.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(596, 0)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(140, 47)
        Me.UltraExpandableGroupBox2.TabIndex = 53
        UltraToolTipInfo2.ToolTipText = "Trabajador / Vehiculos No Disponible"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBox2, UltraToolTipInfo2)
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtStockGuias)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel5)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtStockTalonarios)
        Me.UltraExpandableGroupBoxPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(23, 3)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(114, 41)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        UltraToolTipInfo1.ToolTipText = "No Disponibles"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBoxPanel5, UltraToolTipInfo1)
        '
        'txtStockGuias
        '
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance16.FontData.BoldAsString = "True"
        Appearance16.TextHAlignAsString = "Right"
        Me.txtStockGuias.Appearance = Appearance16
        Me.txtStockGuias.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtStockGuias.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.txtStockGuias.InputMask = "nnnnn"
        Me.txtStockGuias.Location = New System.Drawing.Point(3, 20)
        Me.txtStockGuias.Name = "txtStockGuias"
        Me.txtStockGuias.NonAutoSizeHeight = 20
        Me.txtStockGuias.NullText = "1"
        Me.txtStockGuias.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtStockGuias.ReadOnly = True
        Me.txtStockGuias.Size = New System.Drawing.Size(50, 20)
        Me.txtStockGuias.TabIndex = 49
        Me.txtStockGuias.Text = "1"
        '
        'UltraLabel5
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Appearance17.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance17
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(58, 3)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel5.TabIndex = 52
        Me.UltraLabel5.Text = "Stock Ts."
        '
        'UltraLabel1
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance18
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(2, 3)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel1.TabIndex = 51
        Me.UltraLabel1.Text = "Stock Gs."
        '
        'txtStockTalonarios
        '
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.TextHAlignAsString = "Right"
        Me.txtStockTalonarios.Appearance = Appearance19
        Me.txtStockTalonarios.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtStockTalonarios.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.txtStockTalonarios.InputMask = "nnnnn"
        Me.txtStockTalonarios.Location = New System.Drawing.Point(60, 20)
        Me.txtStockTalonarios.Name = "txtStockTalonarios"
        Me.txtStockTalonarios.NonAutoSizeHeight = 20
        Me.txtStockTalonarios.NullText = "1"
        Me.txtStockTalonarios.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtStockTalonarios.ReadOnly = True
        Me.txtStockTalonarios.Size = New System.Drawing.Size(50, 20)
        Me.txtStockTalonarios.TabIndex = 50
        Me.txtStockTalonarios.Text = "1"
        '
        'exgruDisponibleNo
        '
        Me.exgruDisponibleNo.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance20.BackColor = System.Drawing.Color.White
        Appearance20.BackColor2 = System.Drawing.Color.White
        Me.exgruDisponibleNo.ContentAreaAppearance = Appearance20
        Me.exgruDisponibleNo.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.exgruDisponibleNo.Dock = System.Windows.Forms.DockStyle.Right
        Me.exgruDisponibleNo.ExpandedSize = New System.Drawing.Size(240, 47)
        Me.exgruDisponibleNo.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruDisponibleNo.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exgruDisponibleNo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.exgruDisponibleNo.Location = New System.Drawing.Point(736, 0)
        Me.exgruDisponibleNo.Name = "exgruDisponibleNo"
        Me.exgruDisponibleNo.Size = New System.Drawing.Size(240, 47)
        Me.exgruDisponibleNo.TabIndex = 48
        UltraToolTipInfo7.ToolTipText = "Trabajador / Vehiculos No Disponible"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.exgruDisponibleNo, UltraToolTipInfo7)
        Me.exgruDisponibleNo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorStock)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta7)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorAnulado)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorEnUso)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta17)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta14)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta15)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorTerminado)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(23, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(214, 41)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        UltraToolTipInfo6.ToolTipText = "No Disponibles"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBoxPanel3, UltraToolTipInfo6)
        '
        'ColorStock
        '
        Me.ColorStock.Color = System.Drawing.Color.Yellow
        Me.ColorStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorStock.Location = New System.Drawing.Point(166, 22)
        Me.ColorStock.Name = "ColorStock"
        Me.ColorStock.Size = New System.Drawing.Size(43, 19)
        Me.ColorStock.TabIndex = 9
        Me.ColorStock.Text = "Yellow"
        UltraToolTipInfo3.ToolTipText = "Color que especifica si el copiloto no se encuentra disponible para el viaje"
        UltraToolTipInfo3.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorStock, UltraToolTipInfo3)
        '
        'Etiqueta7
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance21
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(127, 25)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta7.TabIndex = 8
        Me.Etiqueta7.Text = "Stock:"
        '
        'ColorAnulado
        '
        Me.ColorAnulado.Color = System.Drawing.Color.Red
        Me.ColorAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAnulado.Location = New System.Drawing.Point(67, 22)
        Me.ColorAnulado.Name = "ColorAnulado"
        Me.ColorAnulado.Size = New System.Drawing.Size(43, 19)
        Me.ColorAnulado.TabIndex = 1
        Me.ColorAnulado.Text = "Red"
        UltraToolTipInfo4.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo4.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorAnulado, UltraToolTipInfo4)
        '
        'ColorEnUso
        '
        Me.ColorEnUso.Color = System.Drawing.Color.Cyan
        Me.ColorEnUso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorEnUso.Location = New System.Drawing.Point(166, 1)
        Me.ColorEnUso.Name = "ColorEnUso"
        Me.ColorEnUso.Size = New System.Drawing.Size(43, 19)
        Me.ColorEnUso.TabIndex = 3
        Me.ColorEnUso.Text = "Cyan"
        UltraToolTipInfo5.ToolTipText = "Color que especifica si el copiloto no se encuentra disponible para el viaje"
        UltraToolTipInfo5.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorEnUso, UltraToolTipInfo5)
        '
        'Etiqueta17
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance22
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(119, 4)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta17.TabIndex = 2
        Me.Etiqueta17.Text = "En Uso:"
        '
        'Etiqueta14
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance23
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(15, 25)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta14.TabIndex = 0
        Me.Etiqueta14.Text = "Anulado:"
        '
        'Etiqueta15
        '
        Appearance24.BackColor = System.Drawing.Color.White
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance24
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(2, 3)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta15.TabIndex = 6
        Me.Etiqueta15.Text = "Terminado:"
        '
        'ColorTerminado
        '
        Me.ColorTerminado.Color = System.Drawing.Color.Lime
        Me.ColorTerminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTerminado.Location = New System.Drawing.Point(67, 1)
        Me.ColorTerminado.Name = "ColorTerminado"
        Me.ColorTerminado.Size = New System.Drawing.Size(43, 19)
        Me.ColorTerminado.TabIndex = 7
        Me.ColorTerminado.Text = "Lime"
        '
        'txtObservacionTalanario
        '
        Me.txtObservacionTalanario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionTalanario.Location = New System.Drawing.Point(290, 4)
        Me.txtObservacionTalanario.MaxLength = 500
        Me.txtObservacionTalanario.Multiline = True
        Me.txtObservacionTalanario.Name = "txtObservacionTalanario"
        Me.txtObservacionTalanario.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionTalanario.Size = New System.Drawing.Size(200, 40)
        Me.txtObservacionTalanario.TabIndex = 26
        '
        'UltraLabel37
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextVAlignAsString = "Middle"
        Me.UltraLabel37.Appearance = Appearance25
        Me.UltraLabel37.AutoSize = True
        Me.UltraLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel37.Location = New System.Drawing.Point(132, 7)
        Me.UltraLabel37.Name = "UltraLabel37"
        Me.UltraLabel37.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel37.TabIndex = 24
        Me.UltraLabel37.Text = "F. Ingreso:"
        '
        'fecIngreso
        '
        Appearance26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecIngreso.Appearance = Appearance26
        Me.fecIngreso.DateTime = New Date(2015, 5, 21, 0, 0, 0, 0)
        Me.fecIngreso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecIngreso.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecIngreso.Location = New System.Drawing.Point(194, 3)
        Me.fecIngreso.Name = "fecIngreso"
        Me.fecIngreso.Size = New System.Drawing.Size(90, 21)
        Me.fecIngreso.TabIndex = 25
        UltraToolTipInfo8.ToolTipText = "Fecha de Inicio del Viaje - Salida de Planta"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.fecIngreso, UltraToolTipInfo8)
        Me.fecIngreso.Value = New Date(2015, 5, 21, 0, 0, 0, 0)
        '
        'txtFinal
        '
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance27.TextHAlignAsString = "Right"
        Me.txtFinal.Appearance = Appearance27
        Me.txtFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFinal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.txtFinal.InputMask = "nnnnnnnnn"
        Me.txtFinal.Location = New System.Drawing.Point(46, 25)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.NonAutoSizeHeight = 20
        Me.txtFinal.NullText = "50"
        Me.txtFinal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFinal.Size = New System.Drawing.Size(80, 20)
        Me.txtFinal.TabIndex = 23
        Me.txtFinal.Text = "50"
        '
        'verAnulado
        '
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.verAnulado.Appearance = Appearance28
        Me.verAnulado.AutoSize = True
        Me.verAnulado.Location = New System.Drawing.Point(132, 27)
        Me.verAnulado.Name = "verAnulado"
        Me.verAnulado.Size = New System.Drawing.Size(63, 17)
        Me.verAnulado.TabIndex = 1
        Me.verAnulado.Text = "Anulado"
        '
        'verTerminado
        '
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.verTerminado.Appearance = Appearance29
        Me.verTerminado.AutoSize = True
        Me.verTerminado.Location = New System.Drawing.Point(209, 27)
        Me.verTerminado.Name = "verTerminado"
        Me.verTerminado.Size = New System.Drawing.Size(75, 17)
        Me.verTerminado.TabIndex = 0
        Me.verTerminado.Text = "Terminado"
        '
        'UltraLabel3
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Appearance30.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance30
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(10, 28)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel3.TabIndex = 22
        Me.UltraLabel3.Text = "Final:"
        '
        'btnAgregar
        '
        Appearance31.Image = "add.ico"
        Me.btnAgregar.Appearance = Appearance31
        Me.btnAgregar.ImageList = Me.imagenes
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(495, 13)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregar.TabIndex = 20
        '
        'UltraLabel12
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance32
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(6, 6)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel12.TabIndex = 8
        Me.UltraLabel12.Text = "Inicial:"
        '
        'txtInicial
        '
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance33.TextHAlignAsString = "Right"
        Me.txtInicial.Appearance = Appearance33
        Me.txtInicial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtInicial.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.txtInicial.InputMask = "nnnnnnnnn"
        Me.txtInicial.Location = New System.Drawing.Point(46, 3)
        Me.txtInicial.Name = "txtInicial"
        Me.txtInicial.NonAutoSizeHeight = 20
        Me.txtInicial.NullText = "1"
        Me.txtInicial.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtInicial.Size = New System.Drawing.Size(80, 20)
        Me.txtInicial.TabIndex = 9
        Me.txtInicial.Text = "1"
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.txtCorrelativo)
        Me.agrDatoGeneral.Controls.Add(Me.txtSerie)
        Me.agrDatoGeneral.Controls.Add(Me.UltraLabel2)
        Me.agrDatoGeneral.Controls.Add(Me.cboTracto)
        Me.agrDatoGeneral.Controls.Add(Me.UltraLabel38)
        Me.agrDatoGeneral.Controls.Add(Me.txtId)
        Me.agrDatoGeneral.Controls.Add(Me.txtObservacion)
        Me.agrDatoGeneral.Controls.Add(Me.UltraLabel4)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(982, 55)
        Me.agrDatoGeneral.TabIndex = 0
        Me.agrDatoGeneral.Text = "Dato General"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtCorrelativo
        '
        Appearance34.BackColor = System.Drawing.Color.LemonChiffon
        Appearance34.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance34.TextHAlignAsString = "Right"
        Me.txtCorrelativo.Appearance = Appearance34
        Me.txtCorrelativo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCorrelativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorrelativo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCorrelativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrelativo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCorrelativo.Location = New System.Drawing.Point(312, 26)
        Me.txtCorrelativo.MaxLength = 10
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(80, 21)
        Me.txtCorrelativo.TabIndex = 24
        '
        'txtSerie
        '
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance35.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance35.TextHAlignAsString = "Right"
        Me.txtSerie.Appearance = Appearance35
        Me.txtSerie.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerie.Location = New System.Drawing.Point(197, 26)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(40, 21)
        Me.txtSerie.TabIndex = 23
        '
        'UltraLabel2
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Appearance36.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance36
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(247, 30)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel2.TabIndex = 19
        Me.UltraLabel2.Text = "Correlativo:"
        '
        'cboTracto
        '
        Appearance37.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.Appearance = Appearance37
        Me.cboTracto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTracto.DisplayMember = ""
        Me.cboTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTracto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTracto.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.ImageList = Me.imagenes
        Me.cboTracto.Location = New System.Drawing.Point(61, 26)
        Me.cboTracto.Name = "cboTracto"
        Me.cboTracto.Size = New System.Drawing.Size(90, 21)
        Me.cboTracto.TabIndex = 18
        Me.cboTracto.ValueMember = "Id"
        '
        'UltraLabel38
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Appearance38.TextVAlignAsString = "Middle"
        Me.UltraLabel38.Appearance = Appearance38
        Me.UltraLabel38.AutoSize = True
        Me.UltraLabel38.Location = New System.Drawing.Point(7, 30)
        Me.UltraLabel38.Name = "UltraLabel38"
        Me.UltraLabel38.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel38.TabIndex = 17
        Me.UltraLabel38.Text = "Vehiculo:"
        '
        'txtId
        '
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(6, 26)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(20, 21)
        Me.txtId.TabIndex = 0
        Me.txtId.Visible = False
        '
        'txtObservacion
        '
        Me.txtObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacion.Location = New System.Drawing.Point(401, 21)
        Me.txtObservacion.MaxLength = 500
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(300, 30)
        Me.txtObservacion.TabIndex = 12
        '
        'UltraLabel4
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Appearance39.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance39
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(160, 30)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel4.TabIndex = 1
        Me.UltraLabel4.Text = "Serie:"
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Colores7)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta8)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Colores8)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Colores9)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta9)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta10)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta11)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Colores10)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(23, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(224, 41)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        UltraToolTipInfo14.ToolTipText = "No Disponibles"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBoxPanel4, UltraToolTipInfo14)
        '
        'Colores7
        '
        Me.Colores7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores7.Location = New System.Drawing.Point(168, 22)
        Me.Colores7.Name = "Colores7"
        Me.Colores7.Size = New System.Drawing.Size(43, 19)
        Me.Colores7.TabIndex = 9
        Me.Colores7.Text = "Control"
        UltraToolTipInfo11.ToolTipText = "Color que especifica si el copiloto no se encuentra disponible para el viaje"
        UltraToolTipInfo11.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.Colores7, UltraToolTipInfo11)
        '
        'Etiqueta8
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance40
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(129, 25)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta8.TabIndex = 8
        Me.Etiqueta8.Text = "Stock:"
        '
        'Colores8
        '
        Me.Colores8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores8.Location = New System.Drawing.Point(67, 22)
        Me.Colores8.Name = "Colores8"
        Me.Colores8.Size = New System.Drawing.Size(43, 19)
        Me.Colores8.TabIndex = 1
        Me.Colores8.Text = "Control"
        UltraToolTipInfo12.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo12.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.Colores8, UltraToolTipInfo12)
        '
        'Colores9
        '
        Me.Colores9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores9.Location = New System.Drawing.Point(168, 1)
        Me.Colores9.Name = "Colores9"
        Me.Colores9.Size = New System.Drawing.Size(43, 19)
        Me.Colores9.TabIndex = 3
        Me.Colores9.Text = "Control"
        UltraToolTipInfo13.ToolTipText = "Color que especifica si el copiloto no se encuentra disponible para el viaje"
        UltraToolTipInfo13.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.Colores9, UltraToolTipInfo13)
        '
        'Etiqueta9
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance41
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(121, 4)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta9.TabIndex = 2
        Me.Etiqueta9.Text = "En Uso:"
        '
        'Etiqueta10
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance42
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(15, 25)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta10.TabIndex = 0
        Me.Etiqueta10.Text = "Anulado:"
        '
        'Etiqueta11
        '
        Appearance43.BackColor = System.Drawing.Color.White
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance43
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(2, 3)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta11.TabIndex = 6
        Me.Etiqueta11.Text = "Terminado:"
        '
        'Colores10
        '
        Me.Colores10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores10.Location = New System.Drawing.Point(67, 1)
        Me.Colores10.Name = "Colores10"
        Me.Colores10.Size = New System.Drawing.Size(43, 19)
        Me.Colores10.TabIndex = 7
        Me.Colores10.Text = "Control"
        '
        'ficControlGuias
        '
        Me.ficControlGuias.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficControlGuias.Controls.Add(Me.UltraTabPageControl7)
        Me.ficControlGuias.Controls.Add(Me.utpDetalle)
        Me.ficControlGuias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficControlGuias.Location = New System.Drawing.Point(0, 0)
        Me.ficControlGuias.Name = "ficControlGuias"
        Me.ficControlGuias.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficControlGuias.Size = New System.Drawing.Size(984, 562)
        Me.ficControlGuias.TabIndex = 1
        UltraTab6.Key = "Lista"
        UltraTab6.TabPage = Me.UltraTabPageControl7
        UltraTab6.Text = "Lista"
        UltraTab7.Key = "Mantenimiento"
        UltraTab7.TabPage = Me.utpDetalle
        UltraTab7.Text = "Mantenimiento"
        Me.ficControlGuias.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7})
        Me.ficControlGuias.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(982, 539)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(294, 247)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 6
        Me.ugb_Espera.Visible = False
        '
        'frm_ControlGuias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficControlGuias)
        Me.Name = "frm_ControlGuias"
        Me.Text = "Control de Guias"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaRegistro.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.numStockTalonarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        CType(Me.ColorStockTalonarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.griTalonarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdGuiasTalonarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruDetalle.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.PerformLayout()
        CType(Me.exgruDisponibleNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruDisponibleNo.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        CType(Me.ColorStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEnUso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTerminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacionTalanario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTerminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        Me.agrDatoGeneral.PerformLayout()
        CType(Me.txtCorrelativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.Colores7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficControlGuias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficControlGuias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Shadows WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Shadows WithEvents Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ficControlGuias As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtObservacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTracto As ISL.Controles.Combo
    Friend WithEvents UltraLabel38 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents exgruDetalle As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents verTerminado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verAnulado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtInicial As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtFinal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecIngreso As ISL.Controles.Fecha
    Friend WithEvents txtObservacionTalanario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents griTalonarios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents exgruDisponibleNo As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ColorAnulado As ISL.Controles.Colores
    Friend WithEvents ColorEnUso As ISL.Controles.Colores
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTerminado As ISL.Controles.Colores
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ogdLista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdGuiasTalonarios As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents txtCorrelativo As ISL.Controles.Texto
    Friend WithEvents ColorStock As ISL.Controles.Colores
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents txtStockTalonarios As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtStockGuias As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Colores7 As ISL.Controles.Colores
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Colores8 As ISL.Controles.Colores
    Friend WithEvents Colores9 As ISL.Controles.Colores
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Colores10 As ISL.Controles.Colores
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents numStockTalonarios As ISL.Controles.NumeroEntero
    Friend WithEvents ColorStockTalonarios As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
End Class
