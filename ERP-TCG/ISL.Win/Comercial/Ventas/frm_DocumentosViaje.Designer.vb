<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DocumentosViaje
    Inherits System.Windows.Forms.Form

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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remitente")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destinatario")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TC")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubContrata")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaSub")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DocumentosViaje))
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Remitente")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destinatario")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TC")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubContrata")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaSub")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcular")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemandaDetalle")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasCarga")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasDescarga")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargar")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descarga")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPesoTnDescarga")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoCarga")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstiba", 1)
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstibaDescarga", 2)
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete", 3)
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgvConsolidado", 4)
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoEfectivoDeposito", 5)
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoConsolidado", 6)
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteFinal", 7)
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado", 8)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteCalcular")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemandaDetalle")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasCarga")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasDescarga")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cargar")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descarga")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPesoTnDescarga")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoCarga")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
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
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDocumentosViaje = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuGrt = New ISL.Controles.MenuContextual(Me.components)
        Me.EliminarGrt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdDocumentosViaje = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.exgruOperacion = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griViajeDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdOperacionDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.exgruViaje = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecViaje = New ISL.Controles.Fecha(Me.components)
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViajeEscala = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdOperacionDetalle = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdSeguimiento = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeCopiloto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigoViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeCarreta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel36 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigoOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeTracto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajePiloto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ficDemanda = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griDocumentosViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuGrt.SuspendLayout()
        CType(Me.ogdDocumentosViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruOperacion.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griViajeDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruViaje.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.fecViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeCopiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajePiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDemanda.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griDocumentosViaje)
        Me.UltraTabPageControl7.Controls.Add(Me.exgruOperacion)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(882, 539)
        '
        'griDocumentosViaje
        '
        Me.griDocumentosViaje.ContextMenuStrip = Me.MenuGrt
        Me.griDocumentosViaje.DataSource = Me.ogdDocumentosViaje
        Appearance1.BackColor = System.Drawing.Color.White
        Me.griDocumentosViaje.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 100
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 125
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 35
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 70
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 200
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 200
        UltraGridColumn8.Header.Caption = "F.Emision"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn8.Width = 60
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 50
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance2
        UltraGridColumn10.Format = "#0.000"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.MaskInput = "{LOC} n.nnn"
        UltraGridColumn10.Width = 40
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance3
        UltraGridColumn11.Format = "#,###,###,##0.00"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.MaskInput = "{LOC} n,nnn,nnn.nn"
        UltraGridColumn11.Width = 80
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance4
        UltraGridColumn12.Format = "#,###,###,##0.00"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.MaskInput = "{LOC} n,nnn,nnn.nn"
        UltraGridColumn12.Width = 60
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance5
        UltraGridColumn13.Format = "#,###,###,##0.00"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.MaskInput = "{LOC} n,nnn,nnn.nn"
        UltraGridColumn13.Width = 100
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Width = 100
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Width = 200
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Width = 100
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        Me.griDocumentosViaje.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDocumentosViaje.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griDocumentosViaje.DisplayLayout.GroupByBox.Hidden = True
        Me.griDocumentosViaje.DisplayLayout.MaxColScrollRegions = 1
        Me.griDocumentosViaje.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDocumentosViaje.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griDocumentosViaje.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDocumentosViaje.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDocumentosViaje.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDocumentosViaje.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDocumentosViaje.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griDocumentosViaje.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDocumentosViaje.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDocumentosViaje.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griDocumentosViaje.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDocumentosViaje.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDocumentosViaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDocumentosViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDocumentosViaje.Location = New System.Drawing.Point(0, 150)
        Me.griDocumentosViaje.Name = "griDocumentosViaje"
        Me.griDocumentosViaje.Size = New System.Drawing.Size(882, 389)
        Me.griDocumentosViaje.TabIndex = 0
        Me.griDocumentosViaje.Text = "DOCUMENTOS DE VIAJE"
        '
        'MenuGrt
        '
        Me.MenuGrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuGrt.ForeColor = System.Drawing.Color.Black
        Me.MenuGrt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarGrt})
        Me.MenuGrt.Name = "MenuContextual1"
        Me.MenuGrt.Size = New System.Drawing.Size(111, 26)
        '
        'EliminarGrt
        '
        Me.EliminarGrt.Image = CType(resources.GetObject("EliminarGrt.Image"), System.Drawing.Image)
        Me.EliminarGrt.Name = "EliminarGrt"
        Me.EliminarGrt.Size = New System.Drawing.Size(110, 22)
        Me.EliminarGrt.Text = "Eliminar"
        '
        'ogdDocumentosViaje
        '
        Me.ogdDocumentosViaje.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'exgruOperacion
        '
        Me.exgruOperacion.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.BackColor2 = System.Drawing.Color.White
        Me.exgruOperacion.ContentAreaAppearance = Appearance6
        Me.exgruOperacion.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.exgruOperacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruOperacion.ExpandedSize = New System.Drawing.Size(882, 150)
        Me.exgruOperacion.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruOperacion.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.exgruOperacion.Location = New System.Drawing.Point(0, 0)
        Me.exgruOperacion.Name = "exgruOperacion"
        Me.exgruOperacion.Size = New System.Drawing.Size(882, 150)
        Me.exgruOperacion.TabIndex = 4
        Me.exgruOperacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griViajeDetalle)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.exgruViaje)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 18)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(876, 129)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'griViajeDetalle
        '
        Me.griViajeDetalle.DataSource = Me.ogdOperacionDetalle
        Appearance7.BackColor = System.Drawing.Color.White
        Me.griViajeDetalle.DisplayLayout.Appearance = Appearance7
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 19
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(238, 0)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Width = 200
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Width = 100
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance8
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn22.Header.VisiblePosition = 6
        UltraGridColumn22.MaskInput = "{double:5.3}"
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(93, 0)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Width = 54
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance9
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn23.Header.VisiblePosition = 9
        UltraGridColumn23.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(93, 0)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Width = 71
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.Header.VisiblePosition = 10
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Width = 48
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.Header.Caption = "Cont.Ent."
        UltraGridColumn25.Header.VisiblePosition = 13
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Width = 45
        UltraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn26.Header.VisiblePosition = 5
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn26.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Width = 150
        UltraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn27.CellAppearance = Appearance10
        UltraGridColumn27.Header.VisiblePosition = 8
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn27.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn27.Width = 40
        UltraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance11.BackColor = System.Drawing.Color.LemonChiffon
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn28.CellAppearance = Appearance11
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn28.Format = "#,###,##0.00"
        UltraGridColumn28.Header.VisiblePosition = 12
        UltraGridColumn28.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.Width = 88
        UltraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn29.Header.VisiblePosition = 14
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(210, 0)
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Width = 200
        UltraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance12.BackColor = System.Drawing.Color.LemonChiffon
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn30.CellAppearance = Appearance12
        UltraGridColumn30.Format = "#,##0.00"
        UltraGridColumn30.Header.VisiblePosition = 15
        UltraGridColumn30.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Width = 66
        UltraGridColumn31.Header.VisiblePosition = 16
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 17
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 18
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 20
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 21
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(126, 0)
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.Width = 150
        UltraGridColumn36.Header.VisiblePosition = 22
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(126, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.Width = 150
        UltraGridColumn37.Header.Caption = "I.Igv"
        UltraGridColumn37.Header.VisiblePosition = 11
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Width = 25
        UltraGridColumn38.Header.VisiblePosition = 23
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.MaskInput = "{double:2.4}"
        UltraGridColumn39.Header.VisiblePosition = 24
        UltraGridColumn39.Hidden = True
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn40.CellAppearance = Appearance13
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn40.Header.Caption = "Peso TM Carga"
        UltraGridColumn40.Header.VisiblePosition = 25
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.MaskInput = "{double:2.4}"
        UltraGridColumn40.Width = 72
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance14
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn41.Format = ""
        UltraGridColumn41.Header.Caption = "TM. Desc."
        UltraGridColumn41.Header.VisiblePosition = 7
        UltraGridColumn41.MaskInput = "{double:2.4}"
        UltraGridColumn41.Width = 50
        UltraGridColumn42.Header.VisiblePosition = 26
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn43.Header.VisiblePosition = 27
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn43.Width = 50
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn44.Header.VisiblePosition = 28
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn44.Width = 50
        UltraGridColumn45.Header.VisiblePosition = 29
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn46.Header.VisiblePosition = 2
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn46.Width = 20
        UltraGridColumn47.Header.VisiblePosition = 30
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 31
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 32
        UltraGridColumn50.Header.VisiblePosition = 33
        UltraGridColumn51.Header.VisiblePosition = 34
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 35
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 36
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 37
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 38
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 39
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 40
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 41
        UltraGridColumn58.Hidden = True
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn59.CellAppearance = Appearance15
        UltraGridColumn59.Format = "###,##0.000"
        UltraGridColumn59.Header.VisiblePosition = 42
        UltraGridColumn59.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59})
        UltraGridBand2.SummaryFooterCaption = ""
        Me.griViajeDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griViajeDetalle.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griViajeDetalle.DisplayLayout.GroupByBox.Hidden = True
        Me.griViajeDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajeDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViajeDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griViajeDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajeDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajeDetalle.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griViajeDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajeDetalle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajeDetalle.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajeDetalle.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griViajeDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griViajeDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajeDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajeDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajeDetalle.Location = New System.Drawing.Point(0, 50)
        Me.griViajeDetalle.Name = "griViajeDetalle"
        Me.griViajeDetalle.Size = New System.Drawing.Size(876, 79)
        Me.griViajeDetalle.TabIndex = 4
        Me.griViajeDetalle.Tag = ""
        '
        'ogdOperacionDetalle
        '
        UltraDataColumn22.DataType = GetType(Double)
        UltraDataColumn23.DataType = GetType(Double)
        UltraDataColumn24.DataType = GetType(Boolean)
        UltraDataColumn25.DataType = GetType(Boolean)
        UltraDataColumn28.DataType = GetType(Double)
        UltraDataColumn29.DataType = GetType(Object)
        UltraDataColumn30.DataType = GetType(Double)
        UltraDataColumn37.DataType = GetType(Boolean)
        Me.ogdOperacionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50})
        '
        'exgruViaje
        '
        Me.exgruViaje.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.BackColor2 = System.Drawing.Color.White
        Me.exgruViaje.ContentAreaAppearance = Appearance16
        Me.exgruViaje.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.exgruViaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruViaje.ExpandedSize = New System.Drawing.Size(876, 50)
        Me.exgruViaje.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.exgruViaje.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.exgruViaje.Location = New System.Drawing.Point(0, 0)
        Me.exgruViaje.Name = "exgruViaje"
        Me.exgruViaje.Size = New System.Drawing.Size(876, 50)
        Me.exgruViaje.TabIndex = 3
        Me.exgruViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel21)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.fecViaje)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel20)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeEscala)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdOperacionDetalle)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdSeguimiento)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdOperacion)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdViaje)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeCopiloto)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel17)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel9)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtCodigoViaje)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeCarreta)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel36)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel10)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtCodigoOperacion)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeTracto)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajePiloto)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel6)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(870, 44)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'UltraLabel21
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Appearance17.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance17
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(301, 7)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel21.TabIndex = 5
        Me.UltraLabel21.Text = "Fecha:"
        '
        'fecViaje
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecViaje.Appearance = Appearance18
        Me.fecViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecViaje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecViaje.Location = New System.Drawing.Point(343, 3)
        Me.fecViaje.Name = "fecViaje"
        Me.fecViaje.Size = New System.Drawing.Size(80, 21)
        Me.fecViaje.TabIndex = 6
        '
        'UltraLabel20
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance19
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(299, 30)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel20.TabIndex = 20
        Me.UltraLabel20.Text = "Escala:"
        '
        'txtViajeEscala
        '
        Me.txtViajeEscala.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeEscala.Location = New System.Drawing.Point(343, 26)
        Me.txtViajeEscala.Name = "txtViajeEscala"
        Me.txtViajeEscala.ReadOnly = True
        Me.txtViajeEscala.Size = New System.Drawing.Size(200, 21)
        Me.txtViajeEscala.TabIndex = 21
        '
        'txtIdOperacionDetalle
        '
        Me.txtIdOperacionDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacionDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacionDetalle.Location = New System.Drawing.Point(854, 26)
        Me.txtIdOperacionDetalle.Name = "txtIdOperacionDetalle"
        Me.txtIdOperacionDetalle.ReadOnly = True
        Me.txtIdOperacionDetalle.Size = New System.Drawing.Size(22, 21)
        Me.txtIdOperacionDetalle.TabIndex = 15
        Me.txtIdOperacionDetalle.Visible = False
        '
        'txtIdSeguimiento
        '
        Me.txtIdSeguimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSeguimiento.Location = New System.Drawing.Point(904, 26)
        Me.txtIdSeguimiento.Name = "txtIdSeguimiento"
        Me.txtIdSeguimiento.ReadOnly = True
        Me.txtIdSeguimiento.Size = New System.Drawing.Size(21, 21)
        Me.txtIdSeguimiento.TabIndex = 14
        Me.txtIdSeguimiento.Visible = False
        '
        'txtIdOperacion
        '
        Me.txtIdOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacion.Location = New System.Drawing.Point(881, 26)
        Me.txtIdOperacion.Name = "txtIdOperacion"
        Me.txtIdOperacion.ReadOnly = True
        Me.txtIdOperacion.Size = New System.Drawing.Size(21, 21)
        Me.txtIdOperacion.TabIndex = 13
        Me.txtIdOperacion.Visible = False
        '
        'txtIdViaje
        '
        Me.txtIdViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdViaje.Location = New System.Drawing.Point(6, 26)
        Me.txtIdViaje.Name = "txtIdViaje"
        Me.txtIdViaje.ReadOnly = True
        Me.txtIdViaje.Size = New System.Drawing.Size(21, 21)
        Me.txtIdViaje.TabIndex = 2
        Me.txtIdViaje.Visible = False
        '
        'txtViajeCopiloto
        '
        Me.txtViajeCopiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCopiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeCopiloto.Location = New System.Drawing.Point(601, 26)
        Me.txtViajeCopiloto.Name = "txtViajeCopiloto"
        Me.txtViajeCopiloto.ReadOnly = True
        Me.txtViajeCopiloto.Size = New System.Drawing.Size(250, 21)
        Me.txtViajeCopiloto.TabIndex = 1
        '
        'UltraLabel17
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance20
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(548, 30)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel17.TabIndex = 0
        Me.UltraLabel17.Text = "CoPiloto:"
        '
        'UltraLabel3
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Appearance21.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance21
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(28, 30)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel3.TabIndex = 3
        Me.UltraLabel3.Text = "Viaje:"
        '
        'UltraLabel9
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance22
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(177, 30)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel9.TabIndex = 11
        Me.UltraLabel9.Text = "Carreta:"
        '
        'txtCodigoViaje
        '
        Me.txtCodigoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoViaje.Location = New System.Drawing.Point(64, 26)
        Me.txtCodigoViaje.Name = "txtCodigoViaje"
        Me.txtCodigoViaje.ReadOnly = True
        Me.txtCodigoViaje.Size = New System.Drawing.Size(110, 21)
        Me.txtCodigoViaje.TabIndex = 7
        '
        'txtViajeCarreta
        '
        Me.txtViajeCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeCarreta.Location = New System.Drawing.Point(225, 26)
        Me.txtViajeCarreta.Name = "txtViajeCarreta"
        Me.txtViajeCarreta.ReadOnly = True
        Me.txtViajeCarreta.Size = New System.Drawing.Size(70, 21)
        Me.txtViajeCarreta.TabIndex = 12
        '
        'UltraLabel36
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Appearance23.TextVAlignAsString = "Middle"
        Me.UltraLabel36.Appearance = Appearance23
        Me.UltraLabel36.AutoSize = True
        Me.UltraLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel36.Location = New System.Drawing.Point(1, 7)
        Me.UltraLabel36.Name = "UltraLabel36"
        Me.UltraLabel36.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel36.TabIndex = 0
        Me.UltraLabel36.Text = "Operacion:"
        '
        'UltraLabel10
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Appearance24.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance24
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(183, 7)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel10.TabIndex = 9
        Me.UltraLabel10.Text = "Tracto:"
        '
        'txtCodigoOperacion
        '
        Me.txtCodigoOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoOperacion.Location = New System.Drawing.Point(64, 3)
        Me.txtCodigoOperacion.Name = "txtCodigoOperacion"
        Me.txtCodigoOperacion.ReadOnly = True
        Me.txtCodigoOperacion.Size = New System.Drawing.Size(110, 21)
        Me.txtCodigoOperacion.TabIndex = 8
        '
        'txtViajeTracto
        '
        Me.txtViajeTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeTracto.Location = New System.Drawing.Point(225, 3)
        Me.txtViajeTracto.Name = "txtViajeTracto"
        Me.txtViajeTracto.ReadOnly = True
        Me.txtViajeTracto.Size = New System.Drawing.Size(70, 21)
        Me.txtViajeTracto.TabIndex = 10
        '
        'txtViajePiloto
        '
        Me.txtViajePiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajePiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajePiloto.Location = New System.Drawing.Point(601, 3)
        Me.txtViajePiloto.Name = "txtViajePiloto"
        Me.txtViajePiloto.ReadOnly = True
        Me.txtViajePiloto.Size = New System.Drawing.Size(250, 21)
        Me.txtViajePiloto.TabIndex = 23
        '
        'UltraLabel6
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance25
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(561, 7)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel6.TabIndex = 22
        Me.UltraLabel6.Text = "Piloto:"
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(882, 539)
        '
        'ficDemanda
        '
        Me.ficDemanda.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDemanda.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDemanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDemanda.Location = New System.Drawing.Point(0, 0)
        Me.ficDemanda.Name = "ficDemanda"
        Me.ficDemanda.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDemanda.Size = New System.Drawing.Size(884, 562)
        Me.ficDemanda.TabIndex = 1
        UltraTab6.Key = "Lista"
        UltraTab6.TabPage = Me.UltraTabPageControl7
        UltraTab6.Text = "Lista"
        Me.ficDemanda.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6})
        Me.ficDemanda.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(244, 247)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 7
        Me.ugb_Espera.Visible = False
        '
        'frm_DocumentosViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 562)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficDemanda)
        Me.Name = "frm_DocumentosViaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos Viaje"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griDocumentosViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuGrt.ResumeLayout(False)
        CType(Me.ogdDocumentosViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruOperacion.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griViajeDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruViaje.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.fecViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeCopiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajePiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDemanda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ogdDocumentosViaje As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griDocumentosViaje As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents exgruViaje As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecViaje As ISL.Controles.Fecha
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeEscala As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdOperacionDetalle As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdSeguimiento As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeCopiloto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigoViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeCarreta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel36 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigoOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeTracto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajePiloto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents ficDemanda As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ogdOperacionDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents exgruOperacion As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griViajeDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents MenuGrt As ISL.Controles.MenuContextual
    Friend WithEvents EliminarGrt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
