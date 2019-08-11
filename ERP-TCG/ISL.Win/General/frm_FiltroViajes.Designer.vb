<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FiltroViajes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FiltroViajes))
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoComplejoOrigen")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaOrigen")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoCargaOrigen")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImpresionGuiaOrigen")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaAproximadaDestino")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoDestino")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescargaDestino")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoDescargaDestino")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTercero")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn353 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn354 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn355 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn356 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn377 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn378 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn379 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn380 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn381 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn382 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn383 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn384 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
        Dim UltraGridColumn393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno", 1)
        Dim UltraGridColumn394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion", 2)
        Dim UltraGridColumn395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica", 3)
        Dim UltraGridColumn396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla", 4)
        Dim UltraGridColumn397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion", 5)
        Dim UltraGridColumn398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro", 6)
        Dim UltraGridColumn399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga", 7)
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
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.ogdDisponibleVehiculos = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griDisponibleVehiculo = New ISL.Controles.Grilla(Me.components)
        Me.UltraExpandableGroupBox7 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel15 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAdvertencia = New ISL.Controles.Colores(Me.components)
        Me.ColorTracto = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCarreta = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCopiloto = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAyudante = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorPiloto = New ISL.Controles.Colores(Me.components)
        Me.grupoTipoVehiculo = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorParihueleroD = New ISL.Controles.Colores(Me.components)
        Me.ColorMediaBarandaD = New ISL.Controles.Colores(Me.components)
        Me.ColorPlataformaD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion20M3D = New ISL.Controles.Colores(Me.components)
        Me.ColorCamion40M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCaliceraD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta43 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTolvaVolteoD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta42 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion30M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta41 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion65M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta40 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorContenedorD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta39 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorVolqueteD = New ISL.Controles.Colores(Me.components)
        Me.ColorGraneleroD = New ISL.Controles.Colores(Me.components)
        Me.ColorCamionetaD = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgonD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta38 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFurgonLargoD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta37 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel59 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnConsultarDisponibles = New Infragistics.Win.Misc.UltraButton()
        Me.verPilotoLista = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboPilotoLista = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTractoLista = New ISL.Controles.Combo(Me.components)
        Me.cboZona = New ISL.Controles.ComboMaestros(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        CType(Me.ogdDisponibleVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaRegistro.SuspendLayout()
        CType(Me.griDisponibleVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox7.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel15.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.ColorAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCopiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAyudante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoTipoVehiculo.SuspendLayout()
        CType(Me.ColorParihueleroD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorMediaBarandaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPlataformaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion20M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion40M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCaliceraD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTolvaVolteoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion30M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion65M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorContenedorD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVolqueteD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGraneleroD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamionetaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgonD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgonLargoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox4.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel12.SuspendLayout()
        CType(Me.verPilotoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPilotoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboZona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.imagenes.Images.SetKeyName(12, "06_calculator.ico")
        Me.imagenes.Images.SetKeyName(13, "Consultar.ico")
        Me.imagenes.Images.SetKeyName(14, "266.png")
        '
        'ogdDisponibleVehiculos
        '
        Me.ogdDisponibleVehiculos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71})
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.griDisponibleVehiculo)
        Me.agrListaRegistro.Controls.Add(Me.UltraExpandableGroupBox7)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 95)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(999, 382)
        Me.agrListaRegistro.TabIndex = 16
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDisponibleVehiculo
        '
        Me.griDisponibleVehiculo.DataSource = Me.ogdDisponibleVehiculos
        UltraGridColumn1.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn1.GroupByMode = Infragistics.Win.UltraWinGrid.GroupByMode.Value
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn2.GroupByMode = Infragistics.Win.UltraWinGrid.GroupByMode.Value
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Width = 109
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Viaje"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Width = 87
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "ORIGEN"
        UltraGridColumn6.Header.VisiblePosition = 11
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Width = 100
        UltraGridColumn7.Header.VisiblePosition = 13
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.Caption = "Disponible En"
        UltraGridColumn8.Header.VisiblePosition = 12
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Width = 100
        UltraGridColumn9.Header.VisiblePosition = 14
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 15
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Width = 124
        UltraGridColumn11.Header.Caption = "V.VACIO"
        UltraGridColumn11.Header.VisiblePosition = 28
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn11.Width = 50
        UltraGridColumn12.Header.VisiblePosition = 16
        UltraGridColumn12.Hidden = True
        Appearance1.Image = 7
        UltraGridColumn13.CellAppearance = Appearance1
        Appearance2.Image = 3
        UltraGridColumn13.CellButtonAppearance = Appearance2
        UltraGridColumn13.Header.Caption = "PILOTO"
        UltraGridColumn13.Header.VisiblePosition = 7
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn13.Width = 200
        UltraGridColumn14.Header.VisiblePosition = 23
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 8
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Width = 212
        UltraGridColumn16.Header.VisiblePosition = 24
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 33
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 223
        UltraGridColumn18.Header.VisiblePosition = 25
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.Caption = "TRACTO"
        UltraGridColumn19.Header.VisiblePosition = 9
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Width = 50
        UltraGridColumn20.Header.VisiblePosition = 26
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.Caption = "CARRETA"
        UltraGridColumn21.Header.VisiblePosition = 10
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Width = 50
        UltraGridColumn22.Header.VisiblePosition = 29
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 27
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.Caption = "ESTADO"
        UltraGridColumn24.Header.VisiblePosition = 17
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Width = 80
        UltraGridColumn25.Header.VisiblePosition = 6
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Width = 66
        UltraGridColumn26.Header.VisiblePosition = 30
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 31
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn28.Header.Caption = "SELECT"
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn28.Width = 35
        UltraGridColumn29.Header.VisiblePosition = 32
        UltraGridColumn29.Hidden = True
        UltraGridColumn350.Header.Caption = "TIPO VEHICULO"
        UltraGridColumn350.Header.VisiblePosition = 21
        UltraGridColumn350.Width = 100
        UltraGridColumn351.Header.VisiblePosition = 34
        UltraGridColumn351.Hidden = True
        UltraGridColumn352.Header.VisiblePosition = 35
        UltraGridColumn352.Hidden = True
        UltraGridColumn353.Header.VisiblePosition = 36
        UltraGridColumn353.Hidden = True
        UltraGridColumn354.Header.VisiblePosition = 37
        UltraGridColumn354.Hidden = True
        UltraGridColumn355.Header.Caption = "CLIENTE"
        UltraGridColumn355.Header.VisiblePosition = 18
        UltraGridColumn355.Width = 200
        Appearance3.Image = 3
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn356.CellAppearance = Appearance3
        Appearance4.Image = 1
        UltraGridColumn356.CellButtonAppearance = Appearance4
        UltraGridColumn356.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn356.Header.Caption = "COMENTARIO / OBSERVACION"
        UltraGridColumn356.Header.VisiblePosition = 53
        UltraGridColumn356.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn356.Width = 300
        UltraGridColumn357.Header.VisiblePosition = 38
        UltraGridColumn357.Hidden = True
        UltraGridColumn358.Header.VisiblePosition = 39
        UltraGridColumn358.Hidden = True
        UltraGridColumn359.Header.VisiblePosition = 40
        UltraGridColumn359.Hidden = True
        UltraGridColumn360.Header.Caption = "LLEGADAORIGEN"
        UltraGridColumn360.Header.VisiblePosition = 41
        UltraGridColumn360.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn360.Width = 100
        UltraGridColumn361.Header.Caption = "SALIDAORIGEN"
        UltraGridColumn361.Header.VisiblePosition = 42
        UltraGridColumn361.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn361.Width = 70
        UltraGridColumn362.Header.Caption = "LLEGADADESTINO"
        UltraGridColumn362.Header.VisiblePosition = 43
        UltraGridColumn362.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn362.Width = 70
        UltraGridColumn363.Header.Caption = "SALIDADESTINO"
        UltraGridColumn363.Header.VisiblePosition = 44
        UltraGridColumn363.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn363.Width = 70
        UltraGridColumn364.Header.Caption = "FLOTA"
        UltraGridColumn364.Header.VisiblePosition = 72
        UltraGridColumn364.Width = 100
        UltraGridColumn365.Header.Caption = "Bloque"
        UltraGridColumn365.Header.VisiblePosition = 22
        UltraGridColumn365.Hidden = True
        UltraGridColumn365.Width = 35
        UltraGridColumn366.Header.Caption = "TN"
        UltraGridColumn366.Header.VisiblePosition = 20
        UltraGridColumn366.Width = 35
        UltraGridColumn367.Header.Caption = "ZONA"
        UltraGridColumn367.Header.VisiblePosition = 54
        UltraGridColumn367.Width = 80
        UltraGridColumn368.Header.Caption = "CARGA MATERIAL"
        UltraGridColumn368.Header.VisiblePosition = 19
        UltraGridColumn369.Header.VisiblePosition = 45
        UltraGridColumn369.Hidden = True
        UltraGridColumn369.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn369.Width = 50
        UltraGridColumn370.Header.VisiblePosition = 46
        UltraGridColumn370.Hidden = True
        UltraGridColumn371.Header.VisiblePosition = 47
        UltraGridColumn371.Hidden = True
        UltraGridColumn372.Header.VisiblePosition = 48
        UltraGridColumn372.Hidden = True
        UltraGridColumn373.Header.VisiblePosition = 49
        UltraGridColumn373.Hidden = True
        UltraGridColumn374.Header.VisiblePosition = 50
        UltraGridColumn374.Hidden = True
        UltraGridColumn375.Header.VisiblePosition = 51
        UltraGridColumn375.Hidden = True
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn376.CellAppearance = Appearance5
        UltraGridColumn376.Header.Caption = "CAPACIDAD"
        UltraGridColumn376.Header.VisiblePosition = 52
        UltraGridColumn376.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn376.Width = 51
        UltraGridColumn377.Header.VisiblePosition = 55
        UltraGridColumn377.Hidden = True
        UltraGridColumn378.Header.VisiblePosition = 56
        UltraGridColumn378.Hidden = True
        UltraGridColumn379.Header.VisiblePosition = 57
        UltraGridColumn379.Hidden = True
        UltraGridColumn380.Header.VisiblePosition = 58
        UltraGridColumn380.Hidden = True
        UltraGridColumn381.Header.VisiblePosition = 59
        UltraGridColumn381.Hidden = True
        UltraGridColumn382.Header.VisiblePosition = 60
        UltraGridColumn382.Hidden = True
        UltraGridColumn383.Header.VisiblePosition = 61
        UltraGridColumn383.Hidden = True
        UltraGridColumn384.Header.VisiblePosition = 62
        UltraGridColumn384.Hidden = True
        UltraGridColumn385.Header.VisiblePosition = 63
        UltraGridColumn385.Hidden = True
        UltraGridColumn386.Header.VisiblePosition = 64
        UltraGridColumn386.Hidden = True
        UltraGridColumn387.Header.VisiblePosition = 65
        UltraGridColumn387.Hidden = True
        UltraGridColumn388.Header.VisiblePosition = 66
        UltraGridColumn388.Hidden = True
        UltraGridColumn389.Header.VisiblePosition = 67
        UltraGridColumn389.Hidden = True
        UltraGridColumn390.Header.VisiblePosition = 69
        UltraGridColumn390.Hidden = True
        UltraGridColumn391.Header.VisiblePosition = 70
        UltraGridColumn391.Hidden = True
        UltraGridColumn392.Header.VisiblePosition = 68
        UltraGridColumn392.Hidden = True
        UltraGridColumn393.Header.VisiblePosition = 71
        UltraGridColumn393.Hidden = True
        UltraGridColumn393.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn394.Header.VisiblePosition = 73
        UltraGridColumn394.Hidden = True
        UltraGridColumn395.Header.VisiblePosition = 74
        UltraGridColumn395.Hidden = True
        UltraGridColumn396.Header.VisiblePosition = 75
        UltraGridColumn396.Hidden = True
        UltraGridColumn397.Header.VisiblePosition = 76
        UltraGridColumn397.Hidden = True
        UltraGridColumn398.Header.VisiblePosition = 77
        UltraGridColumn398.Hidden = True
        UltraGridColumn399.Header.VisiblePosition = 78
        UltraGridColumn399.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn350, UltraGridColumn351, UltraGridColumn352, UltraGridColumn353, UltraGridColumn354, UltraGridColumn355, UltraGridColumn356, UltraGridColumn357, UltraGridColumn358, UltraGridColumn359, UltraGridColumn360, UltraGridColumn361, UltraGridColumn362, UltraGridColumn363, UltraGridColumn364, UltraGridColumn365, UltraGridColumn366, UltraGridColumn367, UltraGridColumn368, UltraGridColumn369, UltraGridColumn370, UltraGridColumn371, UltraGridColumn372, UltraGridColumn373, UltraGridColumn374, UltraGridColumn375, UltraGridColumn376, UltraGridColumn377, UltraGridColumn378, UltraGridColumn379, UltraGridColumn380, UltraGridColumn381, UltraGridColumn382, UltraGridColumn383, UltraGridColumn384, UltraGridColumn385, UltraGridColumn386, UltraGridColumn387, UltraGridColumn388, UltraGridColumn389, UltraGridColumn390, UltraGridColumn391, UltraGridColumn392, UltraGridColumn393, UltraGridColumn394, UltraGridColumn395, UltraGridColumn396, UltraGridColumn397, UltraGridColumn398, UltraGridColumn399})
        UltraGridBand1.GroupHeadersVisible = False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDisponibleVehiculo.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDisponibleVehiculo.DisplayLayout.MaxColScrollRegions = 1
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDisponibleVehiculo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDisponibleVehiculo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDisponibleVehiculo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDisponibleVehiculo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDisponibleVehiculo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDisponibleVehiculo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDisponibleVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDisponibleVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDisponibleVehiculo.ImageList = Me.imagenes
        Me.griDisponibleVehiculo.Location = New System.Drawing.Point(3, 27)
        Me.griDisponibleVehiculo.Name = "griDisponibleVehiculo"
        Me.griDisponibleVehiculo.Size = New System.Drawing.Size(993, 352)
        Me.griDisponibleVehiculo.TabIndex = 77
        Me.griDisponibleVehiculo.Tag = ""
        '
        'UltraExpandableGroupBox7
        '
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox7.ContentAreaAppearance = Appearance6
        Me.UltraExpandableGroupBox7.Controls.Add(Me.UltraExpandableGroupBoxPanel15)
        Me.UltraExpandableGroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox7.Expanded = False
        Me.UltraExpandableGroupBox7.ExpandedSize = New System.Drawing.Size(993, 120)
        Me.UltraExpandableGroupBox7.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBox7.Name = "UltraExpandableGroupBox7"
        Me.UltraExpandableGroupBox7.Size = New System.Drawing.Size(993, 24)
        Me.UltraExpandableGroupBox7.TabIndex = 19
        Me.UltraExpandableGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel15
        '
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.Panel1)
        Me.UltraExpandableGroupBoxPanel15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel15.Name = "UltraExpandableGroupBoxPanel15"
        Me.UltraExpandableGroupBoxPanel15.Size = New System.Drawing.Size(987, 99)
        Me.UltraExpandableGroupBoxPanel15.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel15.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Agrupacion1)
        Me.Panel1.Controls.Add(Me.grupoTipoVehiculo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 99)
        Me.Panel1.TabIndex = 0
        '
        'Agrupacion1
        '
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance7
        Me.Agrupacion1.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion1.Controls.Add(Me.ColorAdvertencia)
        Me.Agrupacion1.Controls.Add(Me.ColorTracto)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion1.Controls.Add(Me.ColorCarreta)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta19)
        Me.Agrupacion1.Controls.Add(Me.ColorCopiloto)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion1.Controls.Add(Me.ColorAyudante)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion1.Controls.Add(Me.ColorPiloto)
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(497, 12)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(343, 73)
        Me.Agrupacion1.TabIndex = 104
        Me.Agrupacion1.Text = "Disponibilidad"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta15
        '
        Appearance8.BackColor = System.Drawing.Color.White
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance8
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(10, 26)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta15.TabIndex = 16
        Me.Etiqueta15.Text = "Advertencia:"
        '
        'ColorAdvertencia
        '
        Me.ColorAdvertencia.Color = System.Drawing.Color.Red
        Me.ColorAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAdvertencia.Location = New System.Drawing.Point(77, 24)
        Me.ColorAdvertencia.Name = "ColorAdvertencia"
        Me.ColorAdvertencia.Size = New System.Drawing.Size(44, 19)
        Me.ColorAdvertencia.TabIndex = 17
        Me.ColorAdvertencia.Text = "Red"
        '
        'ColorTracto
        '
        Me.ColorTracto.Color = System.Drawing.Color.DarkCyan
        Me.ColorTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTracto.Location = New System.Drawing.Point(290, 24)
        Me.ColorTracto.Name = "ColorTracto"
        Me.ColorTracto.Size = New System.Drawing.Size(44, 19)
        Me.ColorTracto.TabIndex = 21
        Me.ColorTracto.Text = "DarkCyan"
        '
        'Etiqueta16
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance9
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(245, 46)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta16.TabIndex = 26
        Me.Etiqueta16.Text = "Carreta:"
        '
        'ColorCarreta
        '
        Me.ColorCarreta.Color = System.Drawing.Color.Blue
        Me.ColorCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCarreta.Location = New System.Drawing.Point(290, 44)
        Me.ColorCarreta.Name = "ColorCarreta"
        Me.ColorCarreta.Size = New System.Drawing.Size(44, 19)
        Me.ColorCarreta.TabIndex = 27
        Me.ColorCarreta.Text = "Blue"
        '
        'Etiqueta19
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance10
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(250, 26)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta19.TabIndex = 24
        Me.Etiqueta19.Text = "Tracto:"
        '
        'ColorCopiloto
        '
        Me.ColorCopiloto.Color = System.Drawing.Color.Yellow
        Me.ColorCopiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCopiloto.Location = New System.Drawing.Point(190, 24)
        Me.ColorCopiloto.Name = "ColorCopiloto"
        Me.ColorCopiloto.Size = New System.Drawing.Size(44, 19)
        Me.ColorCopiloto.TabIndex = 19
        Me.ColorCopiloto.Text = "Yellow"
        '
        'Etiqueta17
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance11
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(141, 27)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta17.TabIndex = 18
        Me.Etiqueta17.Text = "Copiloto:"
        '
        'ColorAyudante
        '
        Me.ColorAyudante.Color = System.Drawing.Color.Lime
        Me.ColorAyudante.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAyudante.Location = New System.Drawing.Point(190, 44)
        Me.ColorAyudante.Name = "ColorAyudante"
        Me.ColorAyudante.Size = New System.Drawing.Size(44, 19)
        Me.ColorAyudante.TabIndex = 20
        Me.ColorAyudante.Text = "Lime"
        '
        'Etiqueta18
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance12
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(135, 46)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta18.TabIndex = 25
        Me.Etiqueta18.Text = "Ayudante:"
        '
        'Etiqueta14
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance13
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(41, 46)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta14.TabIndex = 22
        Me.Etiqueta14.Text = "Piloto:"
        '
        'ColorPiloto
        '
        Me.ColorPiloto.Color = System.Drawing.Color.Orange
        Me.ColorPiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPiloto.Location = New System.Drawing.Point(77, 44)
        Me.ColorPiloto.Name = "ColorPiloto"
        Me.ColorPiloto.Size = New System.Drawing.Size(44, 19)
        Me.ColorPiloto.TabIndex = 23
        Me.ColorPiloto.Text = "Orange"
        '
        'grupoTipoVehiculo
        '
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.BackColor2 = System.Drawing.Color.White
        Me.grupoTipoVehiculo.ContentAreaAppearance = Appearance14
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta1)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta36)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorParihueleroD)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorMediaBarandaD)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorPlataformaD)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta46)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion20M3D)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion40M3D)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta2)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCaliceraD)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta8)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta43)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorTolvaVolteoD)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta42)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta33)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion30M3D)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta34)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta41)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion65M3D)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta40)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorContenedorD)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta39)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta35)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorVolqueteD)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorGraneleroD)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamionetaD)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorFurgonD)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta38)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorFurgonLargoD)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta37)
        Me.grupoTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoTipoVehiculo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoTipoVehiculo.Location = New System.Drawing.Point(6, 4)
        Me.grupoTipoVehiculo.Name = "grupoTipoVehiculo"
        Me.grupoTipoVehiculo.Size = New System.Drawing.Size(486, 92)
        Me.grupoTipoVehiculo.TabIndex = 9
        Me.grupoTipoVehiculo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta1
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance15
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(267, 29)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta1.TabIndex = 102
        Me.Etiqueta1.Text = "Parihuelero:"
        '
        'Etiqueta36
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta36.Appearance = Appearance16
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta36.Location = New System.Drawing.Point(18, 9)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta36.TabIndex = 74
        Me.Etiqueta36.Text = "Plataforma:"
        '
        'ColorParihueleroD
        '
        Me.ColorParihueleroD.Color = System.Drawing.Color.PaleGreen
        Me.ColorParihueleroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorParihueleroD.Location = New System.Drawing.Point(333, 27)
        Me.ColorParihueleroD.Name = "ColorParihueleroD"
        Me.ColorParihueleroD.Size = New System.Drawing.Size(44, 19)
        Me.ColorParihueleroD.TabIndex = 103
        Me.ColorParihueleroD.Text = "PaleGreen"
        '
        'ColorMediaBarandaD
        '
        Me.ColorMediaBarandaD.Color = System.Drawing.Color.Orange
        Me.ColorMediaBarandaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorMediaBarandaD.Location = New System.Drawing.Point(333, 6)
        Me.ColorMediaBarandaD.Name = "ColorMediaBarandaD"
        Me.ColorMediaBarandaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorMediaBarandaD.TabIndex = 101
        Me.ColorMediaBarandaD.Text = "Orange"
        '
        'ColorPlataformaD
        '
        Me.ColorPlataformaD.Color = System.Drawing.Color.Coral
        Me.ColorPlataformaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPlataformaD.Location = New System.Drawing.Point(80, 6)
        Me.ColorPlataformaD.Name = "ColorPlataformaD"
        Me.ColorPlataformaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorPlataformaD.TabIndex = 75
        Me.ColorPlataformaD.Text = "Coral"
        '
        'Etiqueta46
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta46.Appearance = Appearance17
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta46.Location = New System.Drawing.Point(392, 26)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta46.TabIndex = 92
        Me.Etiqueta46.Text = "30 M3:"
        '
        'ColorCamion20M3D
        '
        Me.ColorCamion20M3D.Color = System.Drawing.Color.PaleTurquoise
        Me.ColorCamion20M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion20M3D.Location = New System.Drawing.Point(432, 4)
        Me.ColorCamion20M3D.Name = "ColorCamion20M3D"
        Me.ColorCamion20M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion20M3D.TabIndex = 91
        Me.ColorCamion20M3D.Text = "PaleTurquoise"
        '
        'ColorCamion40M3D
        '
        Me.ColorCamion40M3D.Color = System.Drawing.Color.Violet
        Me.ColorCamion40M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion40M3D.Location = New System.Drawing.Point(432, 46)
        Me.ColorCamion40M3D.Name = "ColorCamion40M3D"
        Me.ColorCamion40M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion40M3D.TabIndex = 95
        Me.ColorCamion40M3D.Text = "Violet"
        '
        'Etiqueta2
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance18
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(18, 50)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta2.TabIndex = 88
        Me.Etiqueta2.Text = "Camioneta:"
        '
        'ColorCaliceraD
        '
        Me.ColorCaliceraD.Color = System.Drawing.Color.DarkKhaki
        Me.ColorCaliceraD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCaliceraD.Location = New System.Drawing.Point(333, 48)
        Me.ColorCaliceraD.Name = "ColorCaliceraD"
        Me.ColorCaliceraD.Size = New System.Drawing.Size(44, 19)
        Me.ColorCaliceraD.TabIndex = 81
        Me.ColorCaliceraD.Text = "DarkKhaki"
        '
        'Etiqueta8
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance19
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(157, 8)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta8.TabIndex = 78
        Me.Etiqueta8.Text = "Furgon:"
        '
        'Etiqueta43
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta43.Appearance = Appearance20
        Me.Etiqueta43.AutoSize = True
        Me.Etiqueta43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta43.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta43.Location = New System.Drawing.Point(282, 50)
        Me.Etiqueta43.Name = "Etiqueta43"
        Me.Etiqueta43.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta43.TabIndex = 80
        Me.Etiqueta43.Text = "Calicera:"
        '
        'ColorTolvaVolteoD
        '
        Me.ColorTolvaVolteoD.Color = System.Drawing.Color.RosyBrown
        Me.ColorTolvaVolteoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTolvaVolteoD.Location = New System.Drawing.Point(80, 66)
        Me.ColorTolvaVolteoD.Name = "ColorTolvaVolteoD"
        Me.ColorTolvaVolteoD.Size = New System.Drawing.Size(44, 19)
        Me.ColorTolvaVolteoD.TabIndex = 85
        Me.ColorTolvaVolteoD.Text = "RosyBrown"
        '
        'Etiqueta42
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta42.Appearance = Appearance21
        Me.Etiqueta42.AutoSize = True
        Me.Etiqueta42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta42.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta42.Location = New System.Drawing.Point(13, 29)
        Me.Etiqueta42.Name = "Etiqueta42"
        Me.Etiqueta42.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta42.TabIndex = 98
        Me.Etiqueta42.Text = "Contenedor:"
        '
        'Etiqueta33
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta33.Appearance = Appearance22
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta33.Location = New System.Drawing.Point(149, 28)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta33.TabIndex = 76
        Me.Etiqueta33.Text = "Volquete:"
        '
        'ColorCamion30M3D
        '
        Me.ColorCamion30M3D.Color = System.Drawing.Color.DeepSkyBlue
        Me.ColorCamion30M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion30M3D.Location = New System.Drawing.Point(432, 25)
        Me.ColorCamion30M3D.Name = "ColorCamion30M3D"
        Me.ColorCamion30M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion30M3D.TabIndex = 93
        Me.ColorCamion30M3D.Text = "DeepSkyBlue"
        '
        'Etiqueta34
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta34.Appearance = Appearance23
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta34.Location = New System.Drawing.Point(143, 70)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta34.TabIndex = 82
        Me.Etiqueta34.Text = "Granelero:"
        '
        'Etiqueta41
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta41.Appearance = Appearance24
        Me.Etiqueta41.AutoSize = True
        Me.Etiqueta41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta41.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta41.Location = New System.Drawing.Point(392, 47)
        Me.Etiqueta41.Name = "Etiqueta41"
        Me.Etiqueta41.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta41.TabIndex = 94
        Me.Etiqueta41.Text = "40 M3:"
        '
        'ColorCamion65M3D
        '
        Me.ColorCamion65M3D.Color = System.Drawing.Color.MediumSpringGreen
        Me.ColorCamion65M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion65M3D.Location = New System.Drawing.Point(432, 67)
        Me.ColorCamion65M3D.Name = "ColorCamion65M3D"
        Me.ColorCamion65M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion65M3D.TabIndex = 97
        Me.ColorCamion65M3D.Text = "MediumSpringGreen"
        '
        'Etiqueta40
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta40.Appearance = Appearance25
        Me.Etiqueta40.AutoSize = True
        Me.Etiqueta40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta40.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta40.Location = New System.Drawing.Point(253, 9)
        Me.Etiqueta40.Name = "Etiqueta40"
        Me.Etiqueta40.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta40.TabIndex = 100
        Me.Etiqueta40.Text = "MediaBaranda:"
        '
        'ColorContenedorD
        '
        Me.ColorContenedorD.Color = System.Drawing.Color.OliveDrab
        Me.ColorContenedorD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorContenedorD.Location = New System.Drawing.Point(80, 26)
        Me.ColorContenedorD.Name = "ColorContenedorD"
        Me.ColorContenedorD.Size = New System.Drawing.Size(44, 19)
        Me.ColorContenedorD.TabIndex = 87
        Me.ColorContenedorD.Text = "OliveDrab"
        '
        'Etiqueta39
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta39.Appearance = Appearance26
        Me.Etiqueta39.AutoSize = True
        Me.Etiqueta39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta39.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta39.Location = New System.Drawing.Point(127, 49)
        Me.Etiqueta39.Name = "Etiqueta39"
        Me.Etiqueta39.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta39.TabIndex = 86
        Me.Etiqueta39.Text = "Furgon Largo:"
        '
        'Etiqueta35
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta35.Appearance = Appearance27
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta35.Location = New System.Drawing.Point(392, 7)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta35.TabIndex = 90
        Me.Etiqueta35.Text = "20 M3:"
        '
        'ColorVolqueteD
        '
        Me.ColorVolqueteD.Color = System.Drawing.Color.Peru
        Me.ColorVolqueteD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorVolqueteD.Location = New System.Drawing.Point(202, 26)
        Me.ColorVolqueteD.Name = "ColorVolqueteD"
        Me.ColorVolqueteD.Size = New System.Drawing.Size(44, 19)
        Me.ColorVolqueteD.TabIndex = 77
        Me.ColorVolqueteD.Text = "Peru"
        '
        'ColorGraneleroD
        '
        Me.ColorGraneleroD.Color = System.Drawing.Color.YellowGreen
        Me.ColorGraneleroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorGraneleroD.Location = New System.Drawing.Point(202, 66)
        Me.ColorGraneleroD.Name = "ColorGraneleroD"
        Me.ColorGraneleroD.Size = New System.Drawing.Size(44, 19)
        Me.ColorGraneleroD.TabIndex = 83
        Me.ColorGraneleroD.Text = "YellowGreen"
        '
        'ColorCamionetaD
        '
        Me.ColorCamionetaD.Color = System.Drawing.Color.LightSeaGreen
        Me.ColorCamionetaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamionetaD.Location = New System.Drawing.Point(80, 46)
        Me.ColorCamionetaD.Name = "ColorCamionetaD"
        Me.ColorCamionetaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamionetaD.TabIndex = 89
        Me.ColorCamionetaD.Text = "LightSeaGreen"
        '
        'ColorFurgonD
        '
        Me.ColorFurgonD.Color = System.Drawing.Color.Gold
        Me.ColorFurgonD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonD.Location = New System.Drawing.Point(202, 6)
        Me.ColorFurgonD.Name = "ColorFurgonD"
        Me.ColorFurgonD.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonD.TabIndex = 79
        Me.ColorFurgonD.Text = "Gold"
        '
        'Etiqueta38
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta38.Appearance = Appearance28
        Me.Etiqueta38.AutoSize = True
        Me.Etiqueta38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta38.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta38.Location = New System.Drawing.Point(392, 71)
        Me.Etiqueta38.Name = "Etiqueta38"
        Me.Etiqueta38.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta38.TabIndex = 96
        Me.Etiqueta38.Text = "65 M3:"
        '
        'ColorFurgonLargoD
        '
        Me.ColorFurgonLargoD.Color = System.Drawing.Color.PeachPuff
        Me.ColorFurgonLargoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonLargoD.Location = New System.Drawing.Point(202, 46)
        Me.ColorFurgonLargoD.Name = "ColorFurgonLargoD"
        Me.ColorFurgonLargoD.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonLargoD.TabIndex = 99
        Me.ColorFurgonLargoD.Text = "PeachPuff"
        '
        'Etiqueta37
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta37.Appearance = Appearance29
        Me.Etiqueta37.AutoSize = True
        Me.Etiqueta37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta37.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta37.Location = New System.Drawing.Point(10, 68)
        Me.Etiqueta37.Name = "Etiqueta37"
        Me.Etiqueta37.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta37.TabIndex = 84
        Me.Etiqueta37.Text = "Tolva Volteo:"
        '
        'UltraExpandableGroupBox4
        '
        Appearance30.BackColor = System.Drawing.Color.White
        Appearance30.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox4.ContentAreaAppearance = Appearance30
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.UltraExpandableGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(999, 95)
        Me.UltraExpandableGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(999, 95)
        Me.UltraExpandableGroupBox4.TabIndex = 20
        Me.UltraExpandableGroupBox4.Text = "Busqueda"
        Me.UltraExpandableGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel12
        '
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraLabel26)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraLabel59)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.btnConsultarDisponibles)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.verPilotoLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboPilotoLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraGroupBox13)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboTractoLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboZona)
        Me.UltraExpandableGroupBoxPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel12.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel12.Name = "UltraExpandableGroupBoxPanel12"
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(993, 72)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        '
        'UltraLabel26
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Appearance31.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance31
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Location = New System.Drawing.Point(349, 15)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel26.TabIndex = 19
        Me.UltraLabel26.Text = "Tracto:"
        '
        'UltraLabel59
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.TextVAlignAsString = "Middle"
        Me.UltraLabel59.Appearance = Appearance32
        Me.UltraLabel59.AutoSize = True
        Me.UltraLabel59.Location = New System.Drawing.Point(186, 15)
        Me.UltraLabel59.Name = "UltraLabel59"
        Me.UltraLabel59.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel59.TabIndex = 18
        Me.UltraLabel59.Text = "Zona:"
        '
        'btnConsultarDisponibles
        '
        Appearance33.Image = "266.png"
        Appearance33.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance33.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnConsultarDisponibles.Appearance = Appearance33
        Me.btnConsultarDisponibles.ImageList = Me.imagenes
        Me.btnConsultarDisponibles.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnConsultarDisponibles.Location = New System.Drawing.Point(485, 11)
        Me.btnConsultarDisponibles.Name = "btnConsultarDisponibles"
        Me.btnConsultarDisponibles.Size = New System.Drawing.Size(40, 30)
        Me.btnConsultarDisponibles.TabIndex = 17
        '
        'verPilotoLista
        '
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.verPilotoLista.Appearance = Appearance34
        Me.verPilotoLista.AutoSize = True
        Me.verPilotoLista.Location = New System.Drawing.Point(166, 41)
        Me.verPilotoLista.Name = "verPilotoLista"
        Me.verPilotoLista.Size = New System.Drawing.Size(53, 17)
        Me.verPilotoLista.TabIndex = 16
        Me.verPilotoLista.Text = "Piloto:"
        '
        'cboPilotoLista
        '
        Appearance35.ForeColor = System.Drawing.Color.Black
        Me.cboPilotoLista.Appearance = Appearance35
        Me.cboPilotoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPilotoLista.DisplayMember = "Nombre"
        Me.cboPilotoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPilotoLista.Enabled = False
        Me.cboPilotoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPilotoLista.ForeColor = System.Drawing.Color.Black
        Me.cboPilotoLista.ImageList = Me.imagenes
        Me.cboPilotoLista.Location = New System.Drawing.Point(228, 36)
        Me.cboPilotoLista.Name = "cboPilotoLista"
        Me.cboPilotoLista.Size = New System.Drawing.Size(251, 21)
        Me.cboPilotoLista.TabIndex = 15
        Me.cboPilotoLista.ValueMember = "Id"
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel39)
        Me.UltraGroupBox13.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel41)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(3, 6)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(150, 60)
        Me.UltraGroupBox13.TabIndex = 0
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecHasta
        '
        Me.fecHasta.DateTime = New Date(2014, 8, 15, 0, 0, 0, 0)
        Me.fecHasta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecHasta.Location = New System.Drawing.Point(50, 32)
        Me.fecHasta.MaskInput = ""
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(90, 21)
        Me.fecHasta.TabIndex = 3
        Me.fecHasta.Value = New Date(2014, 8, 15, 0, 0, 0, 0)
        '
        'UltraLabel39
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Appearance36.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance36
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel39.Location = New System.Drawing.Point(9, 36)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel39.TabIndex = 2
        Me.UltraLabel39.Text = "Hasta:"
        '
        'fecDesde
        '
        Me.fecDesde.DateTime = New Date(2014, 8, 15, 0, 0, 0, 0)
        Me.fecDesde.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDesde.Location = New System.Drawing.Point(50, 9)
        Me.fecDesde.MaskInput = ""
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(90, 21)
        Me.fecDesde.TabIndex = 1
        Me.fecDesde.Value = New Date(2014, 8, 15, 0, 0, 0, 0)
        '
        'UltraLabel41
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Appearance37.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance37
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(6, 13)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel41.TabIndex = 0
        Me.UltraLabel41.Text = "Desde:"
        '
        'cboTractoLista
        '
        Appearance38.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Appearance = Appearance38
        Me.cboTractoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoLista.DisplayMember = ""
        Me.cboTractoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoLista.Enabled = False
        Me.cboTractoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoLista.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Location = New System.Drawing.Point(394, 11)
        Me.cboTractoLista.Name = "cboTractoLista"
        Me.cboTractoLista.Size = New System.Drawing.Size(85, 21)
        Me.cboTractoLista.TabIndex = 10
        Me.cboTractoLista.ValueMember = "Id"
        '
        'cboZona
        '
        Appearance39.ForeColor = System.Drawing.Color.Black
        Me.cboZona.Appearance = Appearance39
        Me.cboZona.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboZona.DisplayMember = "Nombre"
        Me.cboZona.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboZona.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZona.ForeColor = System.Drawing.Color.Black
        Me.cboZona.Location = New System.Drawing.Point(228, 11)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.Size = New System.Drawing.Size(100, 21)
        Me.cboZona.TabIndex = 6
        Me.cboZona.ValueMember = "Id"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(294, 278)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 14
        Me.ugb_Espera.Visible = False
        '
        'frm_FiltroViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(999, 477)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.agrListaRegistro)
        Me.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.Name = "frm_FiltroViajes"
        Me.Text = "Filtro de viajes"
        CType(Me.ogdDisponibleVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaRegistro.ResumeLayout(False)
        CType(Me.griDisponibleVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox7.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel15.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.ColorAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCopiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAyudante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoTipoVehiculo.ResumeLayout(False)
        Me.grupoTipoVehiculo.PerformLayout()
        CType(Me.ColorParihueleroD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorMediaBarandaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPlataformaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion20M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion40M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCaliceraD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTolvaVolteoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion30M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion65M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorContenedorD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVolqueteD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGraneleroD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamionetaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgonD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgonLargoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.PerformLayout()
        CType(Me.verPilotoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPilotoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        Me.UltraGroupBox13.PerformLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboZona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents ogdDisponibleVehiculos As ISL.Controles.OrigenDatos
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraExpandableGroupBox7 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel15 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grupoTipoVehiculo As ISL.Controles.Agrupacion
    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents verPilotoLista As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboPilotoLista As ISL.Controles.ComboMaestros
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTractoLista As ISL.Controles.Combo
    Friend WithEvents cboZona As ISL.Controles.ComboMaestros
    Friend WithEvents btnConsultarDisponibles As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griDisponibleVehiculo As ISL.Controles.Grilla
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents ColorParihueleroD As ISL.Controles.Colores
    Friend WithEvents ColorMediaBarandaD As ISL.Controles.Colores
    Friend WithEvents ColorPlataformaD As ISL.Controles.Colores
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion20M3D As ISL.Controles.Colores
    Friend WithEvents ColorCamion40M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCaliceraD As ISL.Controles.Colores
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta43 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTolvaVolteoD As ISL.Controles.Colores
    Friend WithEvents Etiqueta42 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion30M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta41 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion65M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta40 As ISL.Controles.Etiqueta
    Friend WithEvents ColorContenedorD As ISL.Controles.Colores
    Friend WithEvents Etiqueta39 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents ColorVolqueteD As ISL.Controles.Colores
    Friend WithEvents ColorGraneleroD As ISL.Controles.Colores
    Friend WithEvents ColorCamionetaD As ISL.Controles.Colores
    Friend WithEvents ColorFurgonD As ISL.Controles.Colores
    Friend WithEvents Etiqueta38 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFurgonLargoD As ISL.Controles.Colores
    Friend WithEvents Etiqueta37 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAdvertencia As ISL.Controles.Colores
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents ColorPiloto As ISL.Controles.Colores
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAyudante As ISL.Controles.Colores
    Friend WithEvents ColorCopiloto As ISL.Controles.Colores
    Friend WithEvents ColorCarreta As ISL.Controles.Colores
    Friend WithEvents ColorTracto As ISL.Controles.Colores
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel59 As Infragistics.Win.Misc.UltraLabel

End Class
