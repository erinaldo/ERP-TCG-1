<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Seguimiento
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
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
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
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
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCarga")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Produccion")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPlanilla")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTercero")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Seguimiento))
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn419 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn420 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn421 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn422 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGuiaTransportista")
        Dim UltraGridColumn423 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn424 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn425 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn426 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn427 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGuiaTransportista")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaTransportista")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn428 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn429 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSeguimiento")
        Dim UltraGridColumn430 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn431 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn432 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRemitente")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn433 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionLugarPartida")
        Dim UltraGridColumn434 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinatario")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn435 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionLugarLlegada")
        Dim UltraGridColumn436 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMotivoDocumentoTraslado")
        Dim UltraGridColumn437 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn438 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn439 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn440 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn441 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn442 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn443 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn444 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtConfirmada")
        Dim UltraGridColumn445 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubSerie")
        Dim UltraGridColumn446 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubNumero")
        Dim UltraGridColumn447 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubContrata")
        Dim UltraGridColumn448 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionDetalle")
        Dim UltraGridColumn449 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Incidencia")
        Dim UltraGridColumn450 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn451 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumentos")
        Dim UltraGridColumn452 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remitente")
        Dim UltraGridColumn453 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destinatario")
        Dim UltraGridColumn454 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn455 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtPerdido")
        Dim UltraGridColumn456 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSeguimiento")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRemitente")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDireccionLugarPartida")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestinatario")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDireccionLugarLlegada")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMotivoDocumentoTraslado")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturado")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGrtConfirmada")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubSerie")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubNumero")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubContrata")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacionDetalle")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Incidencia")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDocumentos")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Remitente")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destinatario")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGrtPerdido")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo17 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Ingrese Glosa de GRR", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance230 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance231 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance232 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance233 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance234 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance235 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance236 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance237 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance238 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance239 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance240 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance241 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance242 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance243 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance244 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance245 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance246 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance247 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn457 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn458 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSeguimiento")
        Dim UltraGridColumn459 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGuiaTransportista")
        Dim UltraGridColumn460 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn461 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMotivoTrasladoInterrumpido", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn462 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn463 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn464 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn465 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSeguimiento")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGuiaTransportista")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaTransportista")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMotivoTrasladoInterrumpido")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn466 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn467 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn468 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn469 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn470 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn471 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn472 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcular")
        Dim UltraGridColumn482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemandaDetalle")
        Dim UltraGridColumn484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasCarga")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasDescarga")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargar")
        Dim UltraGridColumn492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descarga")
        Dim UltraGridColumn493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPesoTnDescarga")
        Dim UltraGridColumn494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoCarga")
        Dim UltraGridColumn497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteFinal")
        Dim UltraGridColumn500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgvConsolidado")
        Dim UltraGridColumn502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FalsoFlete")
        Dim UltraGridColumn503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoConsolidado")
        Dim UltraGridColumn504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoEfectivoDeposito", 0)
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("F", Infragistics.Win.UltraWinGrid.SummaryType.Formula, "sum( [Flete] )", "Flete", 11, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Flete", 11, True)
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("C", Infragistics.Win.UltraWinGrid.SummaryType.Formula, "sum( [Comision]  )", "Comision", 13, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Comision", 13, True)
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteCalcular")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemandaDetalle")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasCarga")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasDescarga")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cargar")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descarga")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPesoTnDescarga")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoCarga")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClienteFinal")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgvConsolidado")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FalsoFlete")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MotivoConsolidado")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Enviar Correo a Supervisores", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Hora de Inicio del Viaje - Salida de Planta", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo6 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Fecha de Inicio del Viaje - Salida de Planta", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo7 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Ingrese Incidencia / Falla Identificado de OP", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo8 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Hora de Inicio del Viaje - Salida de Planta", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo9 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Fecha de Inicio del Viaje - Salida de Planta", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo10 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Cliente de la Carga Transportada", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo11 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Enviar Correo a Supervisores", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo12 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Ingrese Observacion de viaje", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo13 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Tienda del Cliente segun Destino de Viaje", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo14 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Estados", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo15 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Estados", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn505 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn506 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn507 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn508 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn509 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn510 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2")
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", 1)
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataBand2 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn416 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn417 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn418 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Estado de un Viaje", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Tipo Vehiculo (Modelo Funcional)", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
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
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione Tracto para el Filtro en el Listado de Viajes", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo16 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione Tracto para el Filtro en el Listado de Viajes", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGuiaTransportista")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaTransportista")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoCarga")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdComisionista")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn193 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn194 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn195 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuario")
        Dim UltraDataColumn196 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn197 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn198 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.tapViajes = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventoViaje = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguimientoMonitoreo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguimientoRapido = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemProgramado = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdListaSeguimiento = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.tapAlertaViajes = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAlertaViajes = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griGuiaRemitente = New ISL.Controles.Grilla(Me.components)
        Me.MenuGuiaRemitente = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Quitar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdGuiaRemitente = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griGuiaTransportista = New ISL.Controles.Grilla(Me.components)
        Me.MenuGuiaTransportista = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Interrumpir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdGuiaTransportista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraExpandableGroupBox5 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtGrtCantidad = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtGrtPT = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.fecEmisionGrt = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.cboPuntoLlegada = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboPuntoPartida = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel47 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboRemitente = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel48 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboDestinatario = New ISL.Controles.ComboMaestros(Me.components)
        Me.fecEmisionGrr = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGrt = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGrr = New ISL.Controles.Texto(Me.components)
        Me.txtRangoGrr = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajeInterrumpido = New ISL.Controles.Grilla(Me.components)
        Me.ogdGuiaTransportistaInterrumpido = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecPartidaViajeInterrumpido = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel44 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtIdGuiaTransportista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtGuiaTransportista = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel43 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboMotivoTrasladoInterrumpido = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel42 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGlosaInterrumpido = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnAgregarInterrumpido = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajeDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdOperacionDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel9 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnCorreoFalla = New ISL.Controles.Boton(Me.components)
        Me.hFalla = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecFalla = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtGlosaFalla = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.verIndFallaOP = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verClienteConf = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verPilotoConf = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verTractoConf = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verCarretaConf = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.verCopilotoConf = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtViajeRuta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.verViajeRetorno = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtViajePiloto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeCarreta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.verViajeVacio = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViajeCodigo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.hViaje = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecViaje = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeTracto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViajeEstado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grupoEnviarCorreo = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnEnviarCorreo = New ISL.Controles.Boton(Me.components)
        Me.txtObservacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboLugarTienda = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViajeEscala = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.grupoMarca01 = New ISL.Controles.Agrupacion(Me.components)
        Me.grupoLlegada = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnLlegadaDestino = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecLlegadaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.hLlegadaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.verLlegadaDestino = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.exGroupMarca = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.exGroupMarcaDentro = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnCargaOrigen = New Infragistics.Win.Misc.UltraButton()
        Me.fecCargaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecDescargaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnDescargaDestino = New Infragistics.Win.Misc.UltraButton()
        Me.verTerminoDescargaDestino = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.hDescargaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.hTerminoDescargaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.hCargaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnTerminoDescargaDestino = New Infragistics.Win.Misc.UltraButton()
        Me.verDescargaDestino = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.fecTerminoDescargaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.verCargaOrigen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel45 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl = New Infragistics.Win.Misc.UltraLabel()
        Me.fecTerminoCargaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.verTerminoCargaOrigen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnTerminoCargaOrigen = New Infragistics.Win.Misc.UltraButton()
        Me.hTerminoCargaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lbOrigen = New Infragistics.Win.Misc.UltraLabel()
        Me.lbDestino = New Infragistics.Win.Misc.UltraLabel()
        Me.verLlegadaOrigen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verSalidaOrigen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verSalidaDestino = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.hSalidaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.hSalidaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.hLlegadaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnSalidaOrigen = New Infragistics.Win.Misc.UltraButton()
        Me.btnSalidaDestino = New Infragistics.Win.Misc.UltraButton()
        Me.btnLlegadaOrigen = New Infragistics.Win.Misc.UltraButton()
        Me.fecSalidaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblSalidaDestino = New Infragistics.Win.Misc.UltraLabel()
        Me.fecSalidaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecLlegadaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtIdOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeId = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdTracto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtSeguimientoId = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdCarreta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.grupoMarca02 = New ISL.Controles.Agrupacion(Me.components)
        Me.grupoLlegadaE = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnLlegadaAproximadaDestinoE = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecLlegadaAproximadaDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.verLlegadaAproximadaDestinoE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.hLlegadaAproximadaDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.exGroupMarcaE = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.exGroupMarcaEDentro = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.verLlegadaDestinoE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.fecIngresoComplejoOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.hLlegadaDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel34 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnLlegadaDestinoE = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel33 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecLlegadaDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecCargaOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel40 = New Infragistics.Win.Misc.UltraLabel()
        Me.verIngresoDestinoE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.verTerminoDescargaDestinoE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.fecTerminoCargaOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.verDescargaDestinoE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecImpresionGuiaOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnIngresoComplejoOrigenE = New Infragistics.Win.Misc.UltraButton()
        Me.hIngresoDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnImpresionGuiaOrigenE = New Infragistics.Win.Misc.UltraButton()
        Me.btnTerminoCargaOrigenE = New Infragistics.Win.Misc.UltraButton()
        Me.hTerminoDescargaDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnCargaOrigenE = New Infragistics.Win.Misc.UltraButton()
        Me.hDescargaDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.hTerminoCargaOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.hImpresionGuiaOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnIngresoDestinoE = New Infragistics.Win.Misc.UltraButton()
        Me.hCargaOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnDescargaDestinoE = New Infragistics.Win.Misc.UltraButton()
        Me.hIngresoComplejoOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnTerminoDescargaDestinoE = New Infragistics.Win.Misc.UltraButton()
        Me.verTerminoCargaOrigenE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verImpresionGuiaOrigenE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verCargaOrigenE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verIngresoComplejoOrigenE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.fecTerminoDescargaDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel37 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecIngresoDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecDescargaDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel38 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbOrigenE = New Infragistics.Win.Misc.UltraLabel()
        Me.lbDestinoE = New Infragistics.Win.Misc.UltraLabel()
        Me.verSalidaDestinoE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.hSalidaDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnSalidaDestinoE = New Infragistics.Win.Misc.UltraButton()
        Me.fecSalidaDestinoE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblSalidaDestinoE = New Infragistics.Win.Misc.UltraLabel()
        Me.verLlegadaOrigenE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verSalidaOrigenE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.hSalidaOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.hLlegadaOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnSalidaOrigenE = New Infragistics.Win.Misc.UltraButton()
        Me.btnLlegadaOrigenE = New Infragistics.Win.Misc.UltraButton()
        Me.fecSalidaOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecLlegadaOrigenE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel35 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListadoTanqueo = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuCombustible = New ISL.Controles.MenuContextual(Me.components)
        Me.Nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Actualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.odRegistroConsCombustible = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.gridImportar = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabListado = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.gruopExpanUnidadesSinReportar = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel8 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.gridUnidadesSinReportar = New ISL.Controles.Grilla(Me.components)
        Me.ogdUnidadesSinReportar = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraExpandableGroupBox7 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel15 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.numOPSinReportar = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.btnSinReportarUnidades = New Infragistics.Win.Misc.UltraButton()
        Me.grupoEstado = New ISL.Controles.Agrupacion(Me.components)
        Me.ColorFin = New ISL.Controles.Colores(Me.components)
        Me.ColorProgramado = New ISL.Controles.Colores(Me.components)
        Me.ColorCarga = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTransito = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorDescarga = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.grupoTipoVehiculo = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorParihuelero = New ISL.Controles.Colores(Me.components)
        Me.ColorPlataforma = New ISL.Controles.Colores(Me.components)
        Me.ColorCamion20M3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTolvaVolteo = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion65M3 = New ISL.Controles.Colores(Me.components)
        Me.ColorContenedor = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta222 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorGranelero = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgon = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgonLargo = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamioneta = New ISL.Controles.Colores(Me.components)
        Me.ColorVolquete = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion30M3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCalicera = New ISL.Controles.Colores(Me.components)
        Me.ColorCamion40M3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorMediaBaranda = New ISL.Controles.Colores(Me.components)
        Me.colorCambio = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.cboTractoLista = New ISL.Controles.Combo(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.verTracto = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel46 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabGuias = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExpandableGroupBox10 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtCantidad = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtPesoToneladas = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.verKmTractoValida = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtKmTractoDestino = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtKmTractoOrigen = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblKmTractoDestino = New Infragistics.Win.Misc.UltraLabel()
        Me.lblKmTractoOrigen = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtHorasTractoDestino = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtHorasTractoOrigen = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblHrTractoDestino = New Infragistics.Win.Misc.UltraLabel()
        Me.lblHrTractoOrigen = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtKmCarretaDestino = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtKmCarretaOrigen = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblKmCarretaDestino = New Infragistics.Win.Misc.UltraLabel()
        Me.lblKmCarretaOrigen = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraExpandableGroupBox9 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabImportar = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraExpandableGroupBox11 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel11 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.btnBuscarImportar = New Infragistics.Win.Misc.UltraButton()
        Me.btnImportar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTractoImportar = New ISL.Controles.Combo(Me.components)
        Me.cboCentroImportar = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.ogdGuiaTransportistaDetalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ogdDemandaRapida = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ficDemanda = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tapViajes.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.ogdListaSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tapAlertaViajes.SuspendLayout()
        CType(Me.griAlertaViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griGuiaRemitente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuGuiaRemitente.SuspendLayout()
        CType(Me.ogdGuiaRemitente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox3.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griGuiaTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuGuiaTransportista.SuspendLayout()
        CType(Me.ogdGuiaTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox5.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecEmisionGrt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPuntoLlegada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPuntoPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRemitente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDestinatario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecEmisionGrr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRangoGrr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griViajeInterrumpido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdGuiaTransportistaInterrumpido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.fecPartidaViajeInterrumpido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdGuiaTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGuiaTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMotivoTrasladoInterrumpido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosaInterrumpido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griViajeDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox6.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel9.SuspendLayout()
        CType(Me.hFalla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFalla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosaFalla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndFallaOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verClienteConf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verPilotoConf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTractoConf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCarretaConf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCopilotoConf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verViajeRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajePiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verViajeVacio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.grupoEnviarCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoEnviarCorreo.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLugarTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoMarca01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoMarca01.SuspendLayout()
        CType(Me.grupoLlegada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoLlegada.SuspendLayout()
        CType(Me.fecLlegadaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hLlegadaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verLlegadaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exGroupMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exGroupMarca.SuspendLayout()
        Me.exGroupMarcaDentro.SuspendLayout()
        CType(Me.fecCargaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDescargaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTerminoDescargaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hDescargaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hTerminoDescargaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hCargaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verDescargaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecTerminoDescargaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCargaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecTerminoCargaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTerminoCargaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hTerminoCargaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verLlegadaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verSalidaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verSalidaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hSalidaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hSalidaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hLlegadaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecSalidaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecSalidaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecLlegadaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeguimientoId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoMarca02, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoMarca02.SuspendLayout()
        CType(Me.grupoLlegadaE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoLlegadaE.SuspendLayout()
        CType(Me.fecLlegadaAproximadaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verLlegadaAproximadaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hLlegadaAproximadaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exGroupMarcaE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exGroupMarcaE.SuspendLayout()
        Me.exGroupMarcaEDentro.SuspendLayout()
        CType(Me.verLlegadaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecIngresoComplejoOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hLlegadaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecLlegadaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecCargaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIngresoDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTerminoDescargaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecTerminoCargaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verDescargaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecImpresionGuiaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hIngresoDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hTerminoDescargaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hDescargaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hTerminoCargaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hImpresionGuiaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hCargaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hIngresoComplejoOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTerminoCargaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verImpresionGuiaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCargaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIngresoComplejoOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecTerminoDescargaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecIngresoDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDescargaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verSalidaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hSalidaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecSalidaDestinoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verLlegadaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verSalidaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hSalidaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hLlegadaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecSalidaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecLlegadaOrigenE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griListadoTanqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuCombustible.SuspendLayout()
        CType(Me.odRegistroConsCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.gridImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.tabListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabListado.SuspendLayout()
        CType(Me.gruopExpanUnidadesSinReportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruopExpanUnidadesSinReportar.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel8.SuspendLayout()
        CType(Me.gridUnidadesSinReportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdUnidadesSinReportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox7.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel15.SuspendLayout()
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoEstado.SuspendLayout()
        CType(Me.ColorFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorProgramado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTransito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorDescarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoTipoVehiculo.SuspendLayout()
        CType(Me.ColorParihuelero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPlataforma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion20M3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTolvaVolteo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion65M3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGranelero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgonLargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamioneta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVolquete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion30M3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCalicera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion40M3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorMediaBaranda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox4.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel12.SuspendLayout()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.tabGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGuias.SuspendLayout()
        CType(Me.UltraExpandableGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox10.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.verKmTractoValida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.UltraExpandableGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox9.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.tabImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImportar.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraExpandableGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox11.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel11.SuspendLayout()
        CType(Me.cboTractoImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentroImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdGuiaTransportistaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDemandaRapida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDemanda.SuspendLayout()
        Me.SuspendLayout()
        '
        'tapViajes
        '
        Me.tapViajes.Controls.Add(Me.griLista)
        Me.tapViajes.Location = New System.Drawing.Point(1, 22)
        Me.tapViajes.Name = "tapViajes"
        Me.tapViajes.Size = New System.Drawing.Size(1052, 445)
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.ogdListaSeguimiento
        UltraGridColumn1.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn1.Header.Fixed = True
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        UltraGridColumn2.CellAppearance = Appearance1
        UltraGridColumn2.Header.Fixed = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Width = 95
        UltraGridColumn3.Header.Fixed = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Viaje"
        UltraGridColumn4.Header.Fixed = True
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Width = 95
        UltraGridColumn5.Header.Fixed = True
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 11
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Width = 113
        UltraGridColumn7.Header.VisiblePosition = 12
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 13
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Width = 109
        UltraGridColumn9.Header.VisiblePosition = 14
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 15
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Width = 124
        UltraGridColumn11.Header.Caption = "Vacio"
        UltraGridColumn11.Header.VisiblePosition = 52
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn11.Width = 32
        UltraGridColumn12.Header.VisiblePosition = 16
        UltraGridColumn12.Hidden = True
        Appearance2.Image = 7
        UltraGridColumn13.CellAppearance = Appearance2
        Appearance3.Image = 3
        UltraGridColumn13.CellButtonAppearance = Appearance3
        UltraGridColumn13.Header.VisiblePosition = 17
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn13.Width = 150
        UltraGridColumn14.Header.VisiblePosition = 18
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 19
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Width = 150
        UltraGridColumn16.Header.VisiblePosition = 23
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 24
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn18.Header.Fixed = True
        UltraGridColumn18.Header.VisiblePosition = 7
        UltraGridColumn18.Hidden = True
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        UltraGridColumn19.CellAppearance = Appearance4
        UltraGridColumn19.Header.Fixed = True
        UltraGridColumn19.Header.VisiblePosition = 8
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Width = 80
        UltraGridColumn20.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn20.Header.Fixed = True
        UltraGridColumn20.Header.VisiblePosition = 9
        UltraGridColumn20.Hidden = True
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        UltraGridColumn21.CellAppearance = Appearance5
        UltraGridColumn21.Header.Fixed = True
        UltraGridColumn21.Header.VisiblePosition = 10
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Width = 71
        UltraGridColumn22.Header.VisiblePosition = 27
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 25
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 26
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Width = 100
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn25.Header.Caption = "FechaAtencion"
        UltraGridColumn25.Header.Fixed = True
        UltraGridColumn25.Header.VisiblePosition = 5
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn25.Width = 100
        UltraGridColumn26.Header.Caption = "UsuarioCrea"
        UltraGridColumn26.Header.VisiblePosition = 44
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.Width = 150
        UltraGridColumn27.Header.VisiblePosition = 28
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn28.Header.Caption = "Valida"
        UltraGridColumn28.Header.Fixed = True
        UltraGridColumn28.Header.VisiblePosition = 3
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn28.Width = 35
        UltraGridColumn29.Header.VisiblePosition = 29
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 51
        UltraGridColumn30.Width = 100
        UltraGridColumn31.Header.VisiblePosition = 30
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 31
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 32
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 22
        UltraGridColumn34.Width = 200
        UltraGridColumn35.Header.VisiblePosition = 33
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 34
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 35
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 45
        UltraGridColumn38.Width = 150
        UltraGridColumn39.Header.Caption = "UsuarioOperacion"
        UltraGridColumn39.Header.VisiblePosition = 46
        UltraGridColumn39.Width = 150
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.Header.VisiblePosition = 36
        UltraGridColumn40.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn40.Width = 100
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn41.Header.VisiblePosition = 37
        UltraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn41.Width = 100
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.Header.VisiblePosition = 38
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn42.Width = 100
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn43.Header.VisiblePosition = 39
        UltraGridColumn43.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn43.Width = 100
        UltraGridColumn44.Header.VisiblePosition = 50
        UltraGridColumn44.Width = 100
        UltraGridColumn45.Header.VisiblePosition = 48
        UltraGridColumn45.Width = 250
        Appearance6.Image = 3
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn46.CellAppearance = Appearance6
        Appearance7.Image = 1
        UltraGridColumn46.CellButtonAppearance = Appearance7
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn46.Header.VisiblePosition = 47
        UltraGridColumn46.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn46.Width = 250
        UltraGridColumn47.Header.VisiblePosition = 53
        UltraGridColumn47.Width = 35
        UltraGridColumn48.Header.Caption = "D/N"
        UltraGridColumn48.Header.VisiblePosition = 54
        UltraGridColumn48.Width = 35
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn49.CellAppearance = Appearance8
        UltraGridColumn49.Header.Caption = "TN"
        UltraGridColumn49.Header.VisiblePosition = 21
        UltraGridColumn49.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn49.Width = 40
        UltraGridColumn50.Header.VisiblePosition = 49
        UltraGridColumn50.Width = 100
        UltraGridColumn51.Header.Caption = "KmTracto O"
        UltraGridColumn51.Header.VisiblePosition = 40
        UltraGridColumn51.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn51.Width = 70
        UltraGridColumn52.Header.Caption = "KmTracto D"
        UltraGridColumn52.Header.VisiblePosition = 41
        UltraGridColumn52.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn52.Width = 70
        UltraGridColumn53.Header.Caption = "KmCarreta O"
        UltraGridColumn53.Header.VisiblePosition = 42
        UltraGridColumn53.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn53.Width = 70
        UltraGridColumn54.Header.Caption = "KmCarreta D"
        UltraGridColumn54.Header.VisiblePosition = 43
        UltraGridColumn54.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn54.Width = 70
        UltraGridColumn55.Header.VisiblePosition = 55
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 20
        UltraGridColumn56.Width = 100
        UltraGridColumn57.Header.VisiblePosition = 56
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 57
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 58
        UltraGridColumn59.Hidden = True
        UltraGridColumn59.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn60.Header.VisiblePosition = 59
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn61.Header.VisiblePosition = 60
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn62.Header.VisiblePosition = 61
        UltraGridColumn62.Hidden = True
        UltraGridColumn62.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn63.Header.VisiblePosition = 62
        UltraGridColumn63.Hidden = True
        UltraGridColumn63.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn64.Header.VisiblePosition = 63
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn65.Header.VisiblePosition = 64
        UltraGridColumn65.Hidden = True
        UltraGridColumn65.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn66.Header.VisiblePosition = 65
        UltraGridColumn66.Hidden = True
        UltraGridColumn66.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn67.Header.VisiblePosition = 66
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 67
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 68
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 70
        UltraGridColumn71.Header.VisiblePosition = 71
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 72
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.Caption = "Retorno"
        UltraGridColumn73.Header.VisiblePosition = 69
        UltraGridColumn73.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn73.Width = 40
        UltraGridColumn74.Header.VisiblePosition = 73
        UltraGridColumn75.Header.VisiblePosition = 74
        UltraGridColumn76.Header.VisiblePosition = 75
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 76
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 77
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 78
        UltraGridColumn79.Hidden = True
        UltraGridColumn241.Header.VisiblePosition = 79
        UltraGridColumn241.Hidden = True
        UltraGridColumn244.Header.VisiblePosition = 80
        UltraGridColumn244.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 81
        UltraGridColumn80.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn241, UltraGridColumn244, UltraGridColumn80})
        UltraGridBand1.GroupHeadersVisible = False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.DisplayLayout.UseFixedHeaders = True
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.ImageList = Me.imagenes
        Me.griLista.Location = New System.Drawing.Point(0, 0)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1052, 445)
        Me.griLista.TabIndex = 0
        Me.griLista.Tag = ""
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Update, Me.EventoViaje, Me.SeguimientoMonitoreo, Me.SeguimientoRapido, Me.itemProgramado})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(187, 114)
        '
        'Update
        '
        Me.Update.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(186, 22)
        Me.Update.Text = "Actualizar"
        Me.Update.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'EventoViaje
        '
        Me.EventoViaje.Image = Global.ISL.Win.My.Resources.Resources.korganizer
        Me.EventoViaje.Name = "EventoViaje"
        Me.EventoViaje.Size = New System.Drawing.Size(186, 22)
        Me.EventoViaje.Text = "Registrar Evento"
        '
        'SeguimientoMonitoreo
        '
        Me.SeguimientoMonitoreo.Image = Global.ISL.Win.My.Resources.Resources.content_tree
        Me.SeguimientoMonitoreo.Name = "SeguimientoMonitoreo"
        Me.SeguimientoMonitoreo.Size = New System.Drawing.Size(186, 22)
        Me.SeguimientoMonitoreo.Text = "Seguimiento Monitoreo"
        '
        'SeguimientoRapido
        '
        Me.SeguimientoRapido.Image = Global.ISL.Win.My.Resources.Resources._Resume
        Me.SeguimientoRapido.Name = "SeguimientoRapido"
        Me.SeguimientoRapido.Size = New System.Drawing.Size(186, 22)
        Me.SeguimientoRapido.Text = "Seguimiento Rapido"
        '
        'itemProgramado
        '
        Me.itemProgramado.Image = Global.ISL.Win.My.Resources.Resources.back
        Me.itemProgramado.Name = "itemProgramado"
        Me.itemProgramado.Size = New System.Drawing.Size(186, 22)
        Me.itemProgramado.Text = "Regresar a Programado"
        '
        'ogdListaSeguimiento
        '
        UltraDataColumn25.DataType = GetType(Date)
        UltraDataColumn40.DataType = GetType(Date)
        UltraDataColumn41.DataType = GetType(Date)
        UltraDataColumn42.DataType = GetType(Date)
        UltraDataColumn43.DataType = GetType(Date)
        Me.ogdListaSeguimiento.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81})
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
        Me.imagenes.Images.SetKeyName(12, "01_messages.ico")
        '
        'tapAlertaViajes
        '
        Me.tapAlertaViajes.Controls.Add(Me.griAlertaViajes)
        Me.tapAlertaViajes.Location = New System.Drawing.Point(-10000, -10000)
        Me.tapAlertaViajes.Name = "tapAlertaViajes"
        Me.tapAlertaViajes.Size = New System.Drawing.Size(1052, 445)
        '
        'griAlertaViajes
        '
        Me.griAlertaViajes.DataSource = Me.ogdListaSeguimiento
        UltraGridColumn81.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn81.Header.Fixed = True
        UltraGridColumn81.Header.VisiblePosition = 0
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn82.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance9.TextHAlignAsString = "Center"
        Appearance9.TextVAlignAsString = "Middle"
        UltraGridColumn82.CellAppearance = Appearance9
        UltraGridColumn82.Header.Fixed = True
        UltraGridColumn82.Header.VisiblePosition = 1
        UltraGridColumn82.Hidden = True
        UltraGridColumn82.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn82.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn82.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn82.Width = 95
        UltraGridColumn83.Header.Fixed = True
        UltraGridColumn83.Header.VisiblePosition = 2
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.Caption = "Viaje"
        UltraGridColumn84.Header.Fixed = True
        UltraGridColumn84.Header.VisiblePosition = 4
        UltraGridColumn84.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn84.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn84.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn84.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn84.Width = 95
        UltraGridColumn85.Header.Fixed = True
        UltraGridColumn85.Header.VisiblePosition = 6
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 11
        UltraGridColumn86.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn86.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn86.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn86.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn86.Width = 113
        UltraGridColumn87.Header.VisiblePosition = 12
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 13
        UltraGridColumn88.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn88.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn88.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn88.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn88.Width = 109
        UltraGridColumn89.Header.VisiblePosition = 14
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 15
        UltraGridColumn90.Hidden = True
        UltraGridColumn90.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn90.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn90.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn90.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn90.Width = 124
        UltraGridColumn91.Header.Caption = "Vacio"
        UltraGridColumn91.Header.VisiblePosition = 52
        UltraGridColumn91.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn91.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn91.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn91.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn91.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn91.Width = 32
        UltraGridColumn92.Header.VisiblePosition = 16
        UltraGridColumn92.Hidden = True
        Appearance10.Image = 7
        UltraGridColumn93.CellAppearance = Appearance10
        Appearance11.Image = 3
        UltraGridColumn93.CellButtonAppearance = Appearance11
        UltraGridColumn93.Header.VisiblePosition = 17
        UltraGridColumn93.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn93.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn93.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn93.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn93.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn93.Width = 150
        UltraGridColumn94.Header.VisiblePosition = 18
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 19
        UltraGridColumn95.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn95.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn95.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn95.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn95.Width = 150
        UltraGridColumn96.Header.VisiblePosition = 23
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 24
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn98.Header.Fixed = True
        UltraGridColumn98.Header.VisiblePosition = 7
        UltraGridColumn98.Hidden = True
        Appearance12.TextHAlignAsString = "Left"
        Appearance12.TextVAlignAsString = "Middle"
        UltraGridColumn99.CellAppearance = Appearance12
        UltraGridColumn99.Header.Fixed = True
        UltraGridColumn99.Header.VisiblePosition = 8
        UltraGridColumn99.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn99.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn99.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn99.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn99.Width = 80
        UltraGridColumn100.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn100.Header.Fixed = True
        UltraGridColumn100.Header.VisiblePosition = 9
        UltraGridColumn100.Hidden = True
        Appearance13.TextHAlignAsString = "Left"
        Appearance13.TextVAlignAsString = "Middle"
        UltraGridColumn101.CellAppearance = Appearance13
        UltraGridColumn101.Header.Fixed = True
        UltraGridColumn101.Header.VisiblePosition = 10
        UltraGridColumn101.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn101.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn101.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn101.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn101.Width = 71
        UltraGridColumn102.Header.VisiblePosition = 27
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 25
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 26
        UltraGridColumn104.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn104.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn104.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn104.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn104.Width = 100
        UltraGridColumn105.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn105.Header.Caption = "FechaAtencion"
        UltraGridColumn105.Header.Fixed = True
        UltraGridColumn105.Header.VisiblePosition = 5
        UltraGridColumn105.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn105.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn105.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn105.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn105.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn105.Width = 100
        UltraGridColumn106.Header.Caption = "UsuarioCrea"
        UltraGridColumn106.Header.VisiblePosition = 44
        UltraGridColumn106.Hidden = True
        UltraGridColumn106.Width = 150
        UltraGridColumn107.Header.VisiblePosition = 28
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn108.Header.Caption = "Valida"
        UltraGridColumn108.Header.Fixed = True
        UltraGridColumn108.Header.VisiblePosition = 3
        UltraGridColumn108.Hidden = True
        UltraGridColumn108.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn108.Width = 35
        UltraGridColumn109.Header.VisiblePosition = 29
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.VisiblePosition = 51
        UltraGridColumn110.Hidden = True
        UltraGridColumn110.Width = 100
        UltraGridColumn111.Header.VisiblePosition = 30
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 31
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 32
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 22
        UltraGridColumn114.Width = 200
        UltraGridColumn115.Header.VisiblePosition = 33
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 34
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 35
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 45
        UltraGridColumn118.Hidden = True
        UltraGridColumn118.Width = 150
        UltraGridColumn119.Header.Caption = "UsuarioOperacion"
        UltraGridColumn119.Header.VisiblePosition = 46
        UltraGridColumn119.Hidden = True
        UltraGridColumn119.Width = 150
        UltraGridColumn120.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn120.Header.VisiblePosition = 36
        UltraGridColumn120.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn120.Width = 100
        UltraGridColumn121.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn121.Header.VisiblePosition = 37
        UltraGridColumn121.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn121.Width = 100
        UltraGridColumn122.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn122.Header.VisiblePosition = 38
        UltraGridColumn122.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn122.Width = 100
        UltraGridColumn123.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn123.Header.VisiblePosition = 39
        UltraGridColumn123.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn123.Width = 100
        UltraGridColumn124.Header.VisiblePosition = 50
        UltraGridColumn124.Width = 100
        UltraGridColumn125.Header.VisiblePosition = 48
        UltraGridColumn125.Hidden = True
        UltraGridColumn125.Width = 250
        Appearance14.Image = 3
        Appearance14.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn126.CellAppearance = Appearance14
        Appearance15.Image = 1
        UltraGridColumn126.CellButtonAppearance = Appearance15
        UltraGridColumn126.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn126.Header.VisiblePosition = 47
        UltraGridColumn126.Hidden = True
        UltraGridColumn126.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn126.Width = 250
        UltraGridColumn127.Header.VisiblePosition = 53
        UltraGridColumn127.Hidden = True
        UltraGridColumn127.Width = 35
        UltraGridColumn128.Header.Caption = "D/N"
        UltraGridColumn128.Header.VisiblePosition = 54
        UltraGridColumn128.Hidden = True
        UltraGridColumn128.Width = 35
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn129.CellAppearance = Appearance16
        UltraGridColumn129.Header.Caption = "TN"
        UltraGridColumn129.Header.VisiblePosition = 21
        UltraGridColumn129.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn129.Width = 40
        UltraGridColumn130.Header.VisiblePosition = 49
        UltraGridColumn130.Width = 100
        UltraGridColumn131.Header.Caption = "KmTracto O"
        UltraGridColumn131.Header.VisiblePosition = 40
        UltraGridColumn131.Hidden = True
        UltraGridColumn131.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn131.Width = 70
        UltraGridColumn132.Header.Caption = "KmTracto D"
        UltraGridColumn132.Header.VisiblePosition = 41
        UltraGridColumn132.Hidden = True
        UltraGridColumn132.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn132.Width = 70
        UltraGridColumn133.Header.Caption = "KmCarreta O"
        UltraGridColumn133.Header.VisiblePosition = 42
        UltraGridColumn133.Hidden = True
        UltraGridColumn133.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn133.Width = 70
        UltraGridColumn134.Header.Caption = "KmCarreta D"
        UltraGridColumn134.Header.VisiblePosition = 43
        UltraGridColumn134.Hidden = True
        UltraGridColumn134.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn134.Width = 70
        UltraGridColumn135.Header.VisiblePosition = 55
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 20
        UltraGridColumn136.Width = 100
        UltraGridColumn137.Header.VisiblePosition = 56
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.Header.VisiblePosition = 57
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.Header.VisiblePosition = 58
        UltraGridColumn139.Hidden = True
        UltraGridColumn139.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn140.Header.VisiblePosition = 59
        UltraGridColumn140.Hidden = True
        UltraGridColumn140.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn141.Header.VisiblePosition = 60
        UltraGridColumn141.Hidden = True
        UltraGridColumn141.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn142.Header.VisiblePosition = 61
        UltraGridColumn142.Hidden = True
        UltraGridColumn142.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn143.Header.VisiblePosition = 62
        UltraGridColumn143.Hidden = True
        UltraGridColumn143.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn144.Header.VisiblePosition = 63
        UltraGridColumn144.Hidden = True
        UltraGridColumn144.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn145.Header.VisiblePosition = 64
        UltraGridColumn145.Hidden = True
        UltraGridColumn145.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn146.Header.VisiblePosition = 65
        UltraGridColumn146.Hidden = True
        UltraGridColumn146.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn147.Header.VisiblePosition = 66
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.VisiblePosition = 67
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.Header.VisiblePosition = 68
        UltraGridColumn149.Hidden = True
        UltraGridColumn150.Header.VisiblePosition = 70
        UltraGridColumn151.Header.VisiblePosition = 71
        UltraGridColumn151.Hidden = True
        UltraGridColumn152.Header.VisiblePosition = 72
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.Caption = "Retorno"
        UltraGridColumn153.Header.VisiblePosition = 69
        UltraGridColumn153.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn153.Width = 40
        UltraGridColumn154.Header.VisiblePosition = 73
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 74
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.Header.VisiblePosition = 75
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.Header.VisiblePosition = 76
        UltraGridColumn157.Hidden = True
        UltraGridColumn158.Header.VisiblePosition = 77
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 78
        UltraGridColumn159.Hidden = True
        UltraGridColumn242.Header.VisiblePosition = 79
        UltraGridColumn245.Header.VisiblePosition = 80
        UltraGridColumn160.Header.VisiblePosition = 81
        UltraGridColumn160.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn242, UltraGridColumn245, UltraGridColumn160})
        UltraGridBand2.GroupHeadersVisible = False
        UltraGridBand2.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAlertaViajes.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griAlertaViajes.DisplayLayout.MaxColScrollRegions = 1
        Me.griAlertaViajes.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griAlertaViajes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlertaViajes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlertaViajes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAlertaViajes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAlertaViajes.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griAlertaViajes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAlertaViajes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griAlertaViajes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAlertaViajes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAlertaViajes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAlertaViajes.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griAlertaViajes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAlertaViajes.DisplayLayout.UseFixedHeaders = True
        Me.griAlertaViajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAlertaViajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlertaViajes.ImageList = Me.imagenes
        Me.griAlertaViajes.Location = New System.Drawing.Point(0, 0)
        Me.griAlertaViajes.Name = "griAlertaViajes"
        Me.griAlertaViajes.Size = New System.Drawing.Size(1052, 445)
        Me.griAlertaViajes.TabIndex = 1
        Me.griAlertaViajes.Tag = ""
        Me.griAlertaViajes.Text = "Viajes con Carga por mas de 24 Horas"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griGuiaRemitente)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(878, 255)
        '
        'griGuiaRemitente
        '
        Me.griGuiaRemitente.ContextMenuStrip = Me.MenuGuiaRemitente
        Me.griGuiaRemitente.DataSource = Me.ogdGuiaRemitente
        Appearance17.BackColor = System.Drawing.Color.White
        Me.griGuiaRemitente.DisplayLayout.Appearance = Appearance17
        UltraGridColumn419.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn419.Header.VisiblePosition = 0
        UltraGridColumn419.Hidden = True
        UltraGridColumn420.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn420.CellAppearance = Appearance18
        UltraGridColumn420.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn420.Header.Appearance = Appearance19
        UltraGridColumn420.Header.VisiblePosition = 1
        UltraGridColumn420.MaskInput = "{LOC}nnnn"
        UltraGridColumn420.Width = 30
        UltraGridColumn421.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn421.CellAppearance = Appearance20
        UltraGridColumn421.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn421.Header.VisiblePosition = 2
        UltraGridColumn421.MaskInput = "{LOC}nnnnnnnnnn"
        UltraGridColumn421.Width = 60
        UltraGridColumn422.Header.VisiblePosition = 3
        UltraGridColumn422.Hidden = True
        UltraGridColumn423.Header.VisiblePosition = 5
        UltraGridColumn423.Width = 90
        UltraGridColumn424.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn424.Header.Caption = "F.Emision"
        UltraGridColumn424.Header.VisiblePosition = 4
        UltraGridColumn424.Width = 70
        UltraGridColumn425.Header.VisiblePosition = 8
        UltraGridColumn425.Hidden = True
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn426.Header.Appearance = Appearance21
        UltraGridColumn426.Header.VisiblePosition = 7
        UltraGridColumn426.Width = 90
        UltraGridColumn427.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn427.Header.VisiblePosition = 6
        UltraGridColumn427.Width = 200
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn419, UltraGridColumn420, UltraGridColumn421, UltraGridColumn422, UltraGridColumn423, UltraGridColumn424, UltraGridColumn425, UltraGridColumn426, UltraGridColumn427})
        Me.griGuiaRemitente.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griGuiaRemitente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGuiaRemitente.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griGuiaRemitente.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griGuiaRemitente.DisplayLayout.GroupByBox.Hidden = True
        Me.griGuiaRemitente.DisplayLayout.MaxColScrollRegions = 1
        Me.griGuiaRemitente.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griGuiaRemitente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griGuiaRemitente.DisplayLayout.Override.CellPadding = 0
        Me.griGuiaRemitente.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griGuiaRemitente.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griGuiaRemitente.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance22.TextHAlignAsString = "Left"
        Me.griGuiaRemitente.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.griGuiaRemitente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griGuiaRemitente.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance23.TextVAlignAsString = "Middle"
        Me.griGuiaRemitente.DisplayLayout.Override.RowAppearance = Appearance23
        Me.griGuiaRemitente.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griGuiaRemitente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGuiaRemitente.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griGuiaRemitente.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griGuiaRemitente.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griGuiaRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griGuiaRemitente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griGuiaRemitente.Location = New System.Drawing.Point(520, 0)
        Me.griGuiaRemitente.Name = "griGuiaRemitente"
        Me.griGuiaRemitente.Size = New System.Drawing.Size(358, 255)
        Me.griGuiaRemitente.TabIndex = 0
        Me.griGuiaRemitente.Tag = ""
        Me.griGuiaRemitente.Text = "GUIAS REMISION REMITENTE"
        '
        'MenuGuiaRemitente
        '
        Me.MenuGuiaRemitente.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuGuiaRemitente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Quitar})
        Me.MenuGuiaRemitente.Name = "mnu_Transferencias"
        Me.MenuGuiaRemitente.Size = New System.Drawing.Size(153, 30)
        '
        'Quitar
        '
        Me.Quitar.Image = CType(resources.GetObject("Quitar.Image"), System.Drawing.Image)
        Me.Quitar.Name = "Quitar"
        Me.Quitar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.Quitar.Size = New System.Drawing.Size(152, 26)
        Me.Quitar.Text = "Quitar"
        '
        'ogdGuiaRemitente
        '
        UltraDataColumn87.DataType = GetType(Date)
        Me.ogdGuiaRemitente.Band.Columns.AddRange(New Object() {UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90})
        '
        'UltraExpandableGroupBox3
        '
        Me.UltraExpandableGroupBox3.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance24.BackColor = System.Drawing.Color.White
        Appearance24.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox3.ContentAreaAppearance = Appearance24
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(520, 255)
        Me.UltraExpandableGroupBox3.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.UltraExpandableGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(520, 255)
        Me.UltraExpandableGroupBox3.TabIndex = 1
        Me.UltraExpandableGroupBox3.Text = "Informacion de Guias"
        Me.UltraExpandableGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griGuiaTransportista)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraExpandableGroupBox5)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(22, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(495, 249)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'griGuiaTransportista
        '
        Me.griGuiaTransportista.ContextMenuStrip = Me.MenuGuiaTransportista
        Me.griGuiaTransportista.DataSource = Me.ogdGuiaTransportista
        Appearance25.BackColor = System.Drawing.Color.White
        Me.griGuiaTransportista.DisplayLayout.Appearance = Appearance25
        UltraGridColumn428.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn428.Header.VisiblePosition = 0
        UltraGridColumn428.Hidden = True
        UltraGridColumn429.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn429.Header.VisiblePosition = 6
        UltraGridColumn429.Hidden = True
        UltraGridColumn429.Width = 210
        UltraGridColumn430.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn430.CellAppearance = Appearance26
        UltraGridColumn430.Header.VisiblePosition = 2
        UltraGridColumn430.MaskInput = ""
        UltraGridColumn430.Width = 30
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn431.CellAppearance = Appearance27
        UltraGridColumn431.Header.VisiblePosition = 3
        UltraGridColumn431.Width = 60
        UltraGridColumn432.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance28.TextHAlignAsString = "Left"
        UltraGridColumn432.CellAppearance = Appearance28
        UltraGridColumn432.Header.Caption = "Remitente"
        UltraGridColumn432.Header.VisiblePosition = 4
        UltraGridColumn432.Width = 125
        UltraGridColumn433.Header.VisiblePosition = 7
        UltraGridColumn433.Hidden = True
        Appearance29.TextHAlignAsString = "Left"
        UltraGridColumn434.CellAppearance = Appearance29
        UltraGridColumn434.Header.Caption = "Destinatario"
        UltraGridColumn434.Header.VisiblePosition = 5
        UltraGridColumn434.MaskInput = ""
        UltraGridColumn434.Width = 125
        UltraGridColumn435.Header.VisiblePosition = 8
        UltraGridColumn435.Hidden = True
        UltraGridColumn436.Header.VisiblePosition = 9
        UltraGridColumn436.Hidden = True
        UltraGridColumn437.Header.VisiblePosition = 10
        UltraGridColumn437.Hidden = True
        UltraGridColumn438.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn438.Header.Appearance = Appearance30
        UltraGridColumn438.Header.Caption = "F.Emision"
        UltraGridColumn438.Header.VisiblePosition = 1
        UltraGridColumn438.Width = 50
        UltraGridColumn439.Header.VisiblePosition = 11
        UltraGridColumn439.Hidden = True
        UltraGridColumn440.Header.VisiblePosition = 12
        UltraGridColumn440.Hidden = True
        Appearance31.TextHAlignAsString = "Center"
        UltraGridColumn441.Header.Appearance = Appearance31
        UltraGridColumn441.Header.VisiblePosition = 15
        UltraGridColumn441.Width = 90
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn442.CellAppearance = Appearance32
        UltraGridColumn442.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn442.Header.Caption = "Peso TN"
        UltraGridColumn442.Header.VisiblePosition = 13
        UltraGridColumn442.MaskInput = "{LOC}nn.nnnn"
        UltraGridColumn442.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn442.Width = 40
        UltraGridColumn443.Header.VisiblePosition = 16
        UltraGridColumn443.Hidden = True
        UltraGridColumn444.Header.VisiblePosition = 17
        UltraGridColumn444.Hidden = True
        UltraGridColumn445.Header.VisiblePosition = 18
        UltraGridColumn445.Hidden = True
        UltraGridColumn446.Header.VisiblePosition = 19
        UltraGridColumn446.Hidden = True
        UltraGridColumn447.Header.VisiblePosition = 20
        UltraGridColumn447.Hidden = True
        UltraGridColumn448.Header.VisiblePosition = 21
        UltraGridColumn448.Hidden = True
        UltraGridColumn449.Header.VisiblePosition = 22
        UltraGridColumn449.Hidden = True
        UltraGridColumn450.Header.VisiblePosition = 23
        UltraGridColumn450.Hidden = True
        UltraGridColumn451.Header.VisiblePosition = 24
        UltraGridColumn451.Hidden = True
        UltraGridColumn452.Header.VisiblePosition = 25
        UltraGridColumn452.Hidden = True
        UltraGridColumn453.Header.VisiblePosition = 26
        UltraGridColumn453.Hidden = True
        UltraGridColumn454.Header.VisiblePosition = 27
        UltraGridColumn454.Hidden = True
        UltraGridColumn455.Header.VisiblePosition = 28
        UltraGridColumn455.Hidden = True
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn456.CellAppearance = Appearance33
        UltraGridColumn456.Header.VisiblePosition = 14
        UltraGridColumn456.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn456.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn456.Width = 40
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn428, UltraGridColumn429, UltraGridColumn430, UltraGridColumn431, UltraGridColumn432, UltraGridColumn433, UltraGridColumn434, UltraGridColumn435, UltraGridColumn436, UltraGridColumn437, UltraGridColumn438, UltraGridColumn439, UltraGridColumn440, UltraGridColumn441, UltraGridColumn442, UltraGridColumn443, UltraGridColumn444, UltraGridColumn445, UltraGridColumn446, UltraGridColumn447, UltraGridColumn448, UltraGridColumn449, UltraGridColumn450, UltraGridColumn451, UltraGridColumn452, UltraGridColumn453, UltraGridColumn454, UltraGridColumn455, UltraGridColumn456})
        Me.griGuiaTransportista.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griGuiaTransportista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGuiaTransportista.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griGuiaTransportista.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griGuiaTransportista.DisplayLayout.GroupByBox.Hidden = True
        Me.griGuiaTransportista.DisplayLayout.MaxColScrollRegions = 1
        Me.griGuiaTransportista.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griGuiaTransportista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance34.TextHAlignAsString = "Left"
        Me.griGuiaTransportista.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.griGuiaTransportista.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance35.TextVAlignAsString = "Middle"
        Me.griGuiaTransportista.DisplayLayout.Override.RowAppearance = Appearance35
        Me.griGuiaTransportista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griGuiaTransportista.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGuiaTransportista.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griGuiaTransportista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griGuiaTransportista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griGuiaTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griGuiaTransportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griGuiaTransportista.Location = New System.Drawing.Point(0, 165)
        Me.griGuiaTransportista.Name = "griGuiaTransportista"
        Me.griGuiaTransportista.Size = New System.Drawing.Size(495, 84)
        Me.griGuiaTransportista.TabIndex = 0
        Me.griGuiaTransportista.Tag = ""
        Me.griGuiaTransportista.Text = "GUIAS REMISION TRANSPORTISTA"
        '
        'MenuGuiaTransportista
        '
        Me.MenuGuiaTransportista.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuGuiaTransportista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Interrumpir, Me.Delete})
        Me.MenuGuiaTransportista.Name = "mnu_Transferencias"
        Me.MenuGuiaTransportista.Size = New System.Drawing.Size(174, 56)
        '
        'Interrumpir
        '
        Me.Interrumpir.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.Interrumpir.Name = "Interrumpir"
        Me.Interrumpir.Size = New System.Drawing.Size(173, 26)
        Me.Interrumpir.Text = "ViajeInterrumpido"
        '
        'Delete
        '
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.Name = "Delete"
        Me.Delete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.Delete.Size = New System.Drawing.Size(173, 26)
        Me.Delete.Text = "Quitar"
        '
        'ogdGuiaTransportista
        '
        UltraDataColumn101.DataType = GetType(Date)
        Me.ogdGuiaTransportista.Band.Columns.AddRange(New Object() {UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119})
        '
        'UltraExpandableGroupBox5
        '
        Me.UltraExpandableGroupBox5.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance36.BackColor = System.Drawing.Color.White
        Appearance36.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox5.ContentAreaAppearance = Appearance36
        Me.UltraExpandableGroupBox5.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.UltraExpandableGroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox5.ExpandedSize = New System.Drawing.Size(495, 165)
        Me.UltraExpandableGroupBox5.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.UltraExpandableGroupBox5.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox5.Name = "UltraExpandableGroupBox5"
        Me.UltraExpandableGroupBox5.Size = New System.Drawing.Size(495, 165)
        Me.UltraExpandableGroupBox5.TabIndex = 5
        Me.UltraExpandableGroupBox5.Text = "Ingreso Datos GRT y GRR"
        Me.UltraExpandableGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtGrtCantidad)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel25)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtGlosa)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtGrtPT)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.fecEmisionGrt)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel13)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.btnAgregar)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.cboPuntoLlegada)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel21)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.cboPuntoPartida)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel19)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel47)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.cboRemitente)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel48)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.cboDestinatario)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.fecEmisionGrr)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel23)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel30)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtGrt)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel27)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel15)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtGrr)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtRangoGrr)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel28)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 22)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(489, 140)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'txtGrtCantidad
        '
        Appearance37.TextHAlignAsString = "Right"
        Me.txtGrtCantidad.Appearance = Appearance37
        Me.txtGrtCantidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGrtCantidad.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtGrtCantidad.InputMask = "{LOC}nnnn.nn"
        Me.txtGrtCantidad.Location = New System.Drawing.Point(409, 119)
        Me.txtGrtCantidad.Name = "txtGrtCantidad"
        Me.txtGrtCantidad.NonAutoSizeHeight = 20
        Me.txtGrtCantidad.NullText = "0.00"
        Me.txtGrtCantidad.Size = New System.Drawing.Size(45, 21)
        Me.txtGrtCantidad.TabIndex = 32
        Me.txtGrtCantidad.Text = "0.00"
        '
        'UltraLabel25
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Appearance38.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance38
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(356, 122)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel25.TabIndex = 31
        Me.UltraLabel25.Text = "Cantidad:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Location = New System.Drawing.Point(410, 4)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(80, 100)
        Me.txtGlosa.TabIndex = 28
        UltraToolTipInfo17.ToolTipText = "Ingrese Glosa de GRR"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtGlosa, UltraToolTipInfo17)
        '
        'txtGrtPT
        '
        Appearance229.TextHAlignAsString = "Right"
        Me.txtGrtPT.Appearance = Appearance229
        Me.txtGrtPT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGrtPT.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtGrtPT.InputMask = "{LOC}nn.nnnn"
        Me.txtGrtPT.Location = New System.Drawing.Point(347, 4)
        Me.txtGrtPT.Name = "txtGrtPT"
        Me.txtGrtPT.NonAutoSizeHeight = 20
        Me.txtGrtPT.NullText = "0.0000"
        Me.txtGrtPT.Size = New System.Drawing.Size(60, 21)
        Me.txtGrtPT.TabIndex = 1
        Me.txtGrtPT.Text = "0.0000"
        '
        'fecEmisionGrt
        '
        Me.fecEmisionGrt.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecEmisionGrt.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecEmisionGrt.Location = New System.Drawing.Point(82, 3)
        Me.fecEmisionGrt.MaskInput = ""
        Me.fecEmisionGrt.Name = "fecEmisionGrt"
        Me.fecEmisionGrt.Size = New System.Drawing.Size(80, 22)
        Me.fecEmisionGrt.TabIndex = 7
        Me.fecEmisionGrt.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel13
        '
        Appearance230.BackColor = System.Drawing.Color.Transparent
        Appearance230.ForeColor = System.Drawing.Color.Navy
        Appearance230.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance230
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(322, 7)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(22, 14)
        Me.UltraLabel13.TabIndex = 0
        Me.UltraLabel13.Text = "TN:"
        '
        'btnAgregar
        '
        Appearance231.Image = "add.ico"
        Me.btnAgregar.Appearance = Appearance231
        Me.btnAgregar.ImageList = Me.imagenes
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(460, 112)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregar.TabIndex = 14
        '
        'cboPuntoLlegada
        '
        Appearance232.ForeColor = System.Drawing.Color.Black
        Me.cboPuntoLlegada.Appearance = Appearance232
        Me.cboPuntoLlegada.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboPuntoLlegada.DisplayMember = "Nombre"
        Me.cboPuntoLlegada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPuntoLlegada.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboPuntoLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPuntoLlegada.ForeColor = System.Drawing.Color.Black
        Me.cboPuntoLlegada.ImageList = Me.imagenes
        Me.cboPuntoLlegada.Location = New System.Drawing.Point(82, 96)
        Me.cboPuntoLlegada.Name = "cboPuntoLlegada"
        Me.cboPuntoLlegada.Size = New System.Drawing.Size(325, 21)
        Me.cboPuntoLlegada.TabIndex = 18
        Me.cboPuntoLlegada.ValueMember = "IdDireccion"
        '
        'UltraLabel21
        '
        Appearance233.BackColor = System.Drawing.Color.Transparent
        Appearance233.ForeColor = System.Drawing.Color.Navy
        Appearance233.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance233
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(20, 31)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel21.TabIndex = 0
        Me.UltraLabel21.Text = "Remitente:"
        '
        'cboPuntoPartida
        '
        Appearance234.ForeColor = System.Drawing.Color.Black
        Me.cboPuntoPartida.Appearance = Appearance234
        Me.cboPuntoPartida.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboPuntoPartida.DisplayMember = "Nombre"
        Me.cboPuntoPartida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPuntoPartida.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboPuntoPartida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPuntoPartida.ForeColor = System.Drawing.Color.Black
        Me.cboPuntoPartida.ImageList = Me.imagenes
        Me.cboPuntoPartida.Location = New System.Drawing.Point(82, 50)
        Me.cboPuntoPartida.Name = "cboPuntoPartida"
        Me.cboPuntoPartida.Size = New System.Drawing.Size(325, 21)
        Me.cboPuntoPartida.TabIndex = 16
        Me.cboPuntoPartida.ValueMember = "IdDireccion"
        '
        'UltraLabel19
        '
        Appearance235.BackColor = System.Drawing.Color.Transparent
        Appearance235.ForeColor = System.Drawing.Color.Navy
        Appearance235.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance235
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(11, 77)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(68, 15)
        Me.UltraLabel19.TabIndex = 2
        Me.UltraLabel19.Text = "Destinatario:"
        '
        'UltraLabel47
        '
        Appearance236.BackColor = System.Drawing.Color.Transparent
        Appearance236.ForeColor = System.Drawing.Color.Navy
        Appearance236.TextVAlignAsString = "Middle"
        Me.UltraLabel47.Appearance = Appearance236
        Me.UltraLabel47.AutoSize = True
        Me.UltraLabel47.Location = New System.Drawing.Point(0, 100)
        Me.UltraLabel47.Name = "UltraLabel47"
        Me.UltraLabel47.Size = New System.Drawing.Size(79, 15)
        Me.UltraLabel47.TabIndex = 17
        Me.UltraLabel47.Text = "Punto Llegada:"
        '
        'cboRemitente
        '
        Appearance237.ForeColor = System.Drawing.Color.Black
        Me.cboRemitente.Appearance = Appearance237
        Me.cboRemitente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboRemitente.DisplayMember = "Nombre"
        Me.cboRemitente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRemitente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRemitente.ForeColor = System.Drawing.Color.Black
        Me.cboRemitente.ImageList = Me.imagenes
        Me.cboRemitente.Location = New System.Drawing.Point(82, 27)
        Me.cboRemitente.Name = "cboRemitente"
        Me.cboRemitente.Size = New System.Drawing.Size(325, 21)
        Me.cboRemitente.TabIndex = 1
        Me.cboRemitente.ValueMember = "Id"
        '
        'UltraLabel48
        '
        Appearance238.BackColor = System.Drawing.Color.Transparent
        Appearance238.ForeColor = System.Drawing.Color.Navy
        Appearance238.TextVAlignAsString = "Middle"
        Me.UltraLabel48.Appearance = Appearance238
        Me.UltraLabel48.AutoSize = True
        Me.UltraLabel48.Location = New System.Drawing.Point(4, 54)
        Me.UltraLabel48.Name = "UltraLabel48"
        Me.UltraLabel48.Size = New System.Drawing.Size(75, 15)
        Me.UltraLabel48.TabIndex = 15
        Me.UltraLabel48.Text = "Punto Partida:"
        '
        'cboDestinatario
        '
        Appearance239.ForeColor = System.Drawing.Color.Black
        Me.cboDestinatario.Appearance = Appearance239
        Me.cboDestinatario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDestinatario.DisplayMember = "Nombre"
        Me.cboDestinatario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestinatario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestinatario.ForeColor = System.Drawing.Color.Black
        Me.cboDestinatario.ImageList = Me.imagenes
        Me.cboDestinatario.Location = New System.Drawing.Point(82, 73)
        Me.cboDestinatario.Name = "cboDestinatario"
        Me.cboDestinatario.Size = New System.Drawing.Size(325, 21)
        Me.cboDestinatario.TabIndex = 3
        Me.cboDestinatario.ValueMember = "Id"
        '
        'fecEmisionGrr
        '
        Me.fecEmisionGrr.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecEmisionGrr.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecEmisionGrr.Location = New System.Drawing.Point(82, 120)
        Me.fecEmisionGrr.MaskInput = ""
        Me.fecEmisionGrr.Name = "fecEmisionGrr"
        Me.fecEmisionGrr.Size = New System.Drawing.Size(80, 22)
        Me.fecEmisionGrr.TabIndex = 9
        Me.fecEmisionGrr.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel23
        '
        Appearance240.BackColor = System.Drawing.Color.Transparent
        Appearance240.ForeColor = System.Drawing.Color.Navy
        Appearance240.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance240
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(167, 7)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel23.TabIndex = 4
        Me.UltraLabel23.Text = "GRT N°:"
        '
        'UltraLabel30
        '
        Appearance241.BackColor = System.Drawing.Color.Transparent
        Appearance241.ForeColor = System.Drawing.Color.Navy
        Appearance241.TextVAlignAsString = "Middle"
        Me.UltraLabel30.Appearance = Appearance241
        Me.UltraLabel30.AutoSize = True
        Me.UltraLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel30.Location = New System.Drawing.Point(20, 124)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel30.TabIndex = 8
        Me.UltraLabel30.Text = "F. E. GRR:"
        '
        'txtGrt
        '
        Appearance242.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance242.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGrt.Appearance = Appearance242
        Me.txtGrt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGrt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrt.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGrt.Location = New System.Drawing.Point(217, 3)
        Me.txtGrt.MaxLength = 15
        Me.txtGrt.Name = "txtGrt"
        Me.txtGrt.Size = New System.Drawing.Size(100, 21)
        Me.txtGrt.TabIndex = 5
        '
        'UltraLabel27
        '
        Appearance243.BackColor = System.Drawing.Color.Transparent
        Appearance243.ForeColor = System.Drawing.Color.Navy
        Appearance243.TextVAlignAsString = "Middle"
        Me.UltraLabel27.Appearance = Appearance243
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel27.Location = New System.Drawing.Point(168, 123)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel27.TabIndex = 10
        Me.UltraLabel27.Text = "GRR N°:"
        '
        'UltraLabel15
        '
        Appearance244.BackColor = System.Drawing.Color.Transparent
        Appearance244.ForeColor = System.Drawing.Color.Navy
        Appearance244.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance244
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(30, 7)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel15.TabIndex = 6
        Me.UltraLabel15.Text = "F. Emis.:"
        '
        'txtGrr
        '
        Appearance245.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance245.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGrr.Appearance = Appearance245
        Me.txtGrr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGrr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrr.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGrr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGrr.Location = New System.Drawing.Point(219, 119)
        Me.txtGrr.MaxLength = 15
        Me.txtGrr.Name = "txtGrr"
        Me.txtGrr.Size = New System.Drawing.Size(100, 21)
        Me.txtGrr.TabIndex = 11
        '
        'txtRangoGrr
        '
        Appearance246.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRangoGrr.Appearance = Appearance246
        Me.txtRangoGrr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRangoGrr.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRangoGrr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRangoGrr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRangoGrr.Location = New System.Drawing.Point(185, 120)
        Me.txtRangoGrr.MaxLength = 15
        Me.txtRangoGrr.Name = "txtRangoGrr"
        Me.txtRangoGrr.Size = New System.Drawing.Size(34, 21)
        Me.txtRangoGrr.TabIndex = 13
        Me.txtRangoGrr.Visible = False
        '
        'UltraLabel28
        '
        Appearance247.BackColor = System.Drawing.Color.Transparent
        Appearance247.ForeColor = System.Drawing.Color.Navy
        Appearance247.TextVAlignAsString = "Middle"
        Me.UltraLabel28.Appearance = Appearance247
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel28.Location = New System.Drawing.Point(165, 123)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel28.TabIndex = 12
        Me.UltraLabel28.Text = "R. Final N°:"
        Me.UltraLabel28.Visible = False
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griViajeInterrumpido)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(878, 255)
        '
        'griViajeInterrumpido
        '
        Me.griViajeInterrumpido.DataSource = Me.ogdGuiaTransportistaInterrumpido
        Appearance73.BackColor = System.Drawing.Color.White
        Me.griViajeInterrumpido.DisplayLayout.Appearance = Appearance73
        UltraGridColumn457.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn457.Header.VisiblePosition = 0
        UltraGridColumn457.Hidden = True
        UltraGridColumn458.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn458.Header.VisiblePosition = 3
        UltraGridColumn458.Hidden = True
        UltraGridColumn458.Width = 210
        UltraGridColumn459.Header.VisiblePosition = 8
        UltraGridColumn459.Hidden = True
        UltraGridColumn460.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance74.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance74.TextHAlignAsString = "Right"
        UltraGridColumn460.CellAppearance = Appearance74
        UltraGridColumn460.Header.VisiblePosition = 1
        UltraGridColumn460.MaskInput = ""
        UltraGridColumn460.Width = 90
        UltraGridColumn461.Header.Caption = "MotivoTrasladoInterrumpido"
        UltraGridColumn461.Header.VisiblePosition = 5
        UltraGridColumn461.Width = 200
        UltraGridColumn462.Header.VisiblePosition = 6
        UltraGridColumn462.Width = 300
        UltraGridColumn463.Header.Caption = "Fecha Partida"
        UltraGridColumn463.Header.VisiblePosition = 4
        UltraGridColumn463.Width = 80
        UltraGridColumn464.Header.VisiblePosition = 7
        UltraGridColumn464.Hidden = True
        UltraGridColumn465.Header.VisiblePosition = 2
        UltraGridColumn465.Width = 110
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn457, UltraGridColumn458, UltraGridColumn459, UltraGridColumn460, UltraGridColumn461, UltraGridColumn462, UltraGridColumn463, UltraGridColumn464, UltraGridColumn465})
        Me.griViajeInterrumpido.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griViajeInterrumpido.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griViajeInterrumpido.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griViajeInterrumpido.DisplayLayout.GroupByBox.Hidden = True
        Me.griViajeInterrumpido.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajeInterrumpido.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViajeInterrumpido.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajeInterrumpido.DisplayLayout.Override.CellPadding = 0
        Me.griViajeInterrumpido.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajeInterrumpido.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajeInterrumpido.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance75.TextHAlignAsString = "Left"
        Me.griViajeInterrumpido.DisplayLayout.Override.HeaderAppearance = Appearance75
        Me.griViajeInterrumpido.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajeInterrumpido.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance76.TextVAlignAsString = "Middle"
        Me.griViajeInterrumpido.DisplayLayout.Override.RowAppearance = Appearance76
        Me.griViajeInterrumpido.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griViajeInterrumpido.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajeInterrumpido.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griViajeInterrumpido.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griViajeInterrumpido.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajeInterrumpido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajeInterrumpido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajeInterrumpido.Location = New System.Drawing.Point(0, 60)
        Me.griViajeInterrumpido.Name = "griViajeInterrumpido"
        Me.griViajeInterrumpido.Size = New System.Drawing.Size(878, 195)
        Me.griViajeInterrumpido.TabIndex = 3
        Me.griViajeInterrumpido.Tag = ""
        '
        'ogdGuiaTransportistaInterrumpido
        '
        UltraDataColumn129.DataType = GetType(Date)
        Me.ogdGuiaTransportistaInterrumpido.Band.Columns.AddRange(New Object() {UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131})
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.fecPartidaViajeInterrumpido)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel44)
        Me.UltraGroupBox4.Controls.Add(Me.txtIdGuiaTransportista)
        Me.UltraGroupBox4.Controls.Add(Me.txtGuiaTransportista)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel43)
        Me.UltraGroupBox4.Controls.Add(Me.cboMotivoTrasladoInterrumpido)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel42)
        Me.UltraGroupBox4.Controls.Add(Me.txtGlosaInterrumpido)
        Me.UltraGroupBox4.Controls.Add(Me.btnAgregarInterrumpido)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(878, 60)
        Me.UltraGroupBox4.TabIndex = 5
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'fecPartidaViajeInterrumpido
        '
        Me.fecPartidaViajeInterrumpido.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecPartidaViajeInterrumpido.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecPartidaViajeInterrumpido.Location = New System.Drawing.Point(463, 9)
        Me.fecPartidaViajeInterrumpido.MaskInput = ""
        Me.fecPartidaViajeInterrumpido.Name = "fecPartidaViajeInterrumpido"
        Me.fecPartidaViajeInterrumpido.Size = New System.Drawing.Size(100, 22)
        Me.fecPartidaViajeInterrumpido.TabIndex = 58
        Me.fecPartidaViajeInterrumpido.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel44
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Appearance77.TextVAlignAsString = "Middle"
        Me.UltraLabel44.Appearance = Appearance77
        Me.UltraLabel44.AutoSize = True
        Me.UltraLabel44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel44.Location = New System.Drawing.Point(382, 13)
        Me.UltraLabel44.Name = "UltraLabel44"
        Me.UltraLabel44.Size = New System.Drawing.Size(78, 14)
        Me.UltraLabel44.TabIndex = 57
        Me.UltraLabel44.Text = "Fecha Partida:"
        '
        'txtIdGuiaTransportista
        '
        Me.txtIdGuiaTransportista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdGuiaTransportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdGuiaTransportista.Location = New System.Drawing.Point(605, 34)
        Me.txtIdGuiaTransportista.Name = "txtIdGuiaTransportista"
        Me.txtIdGuiaTransportista.ReadOnly = True
        Me.txtIdGuiaTransportista.Size = New System.Drawing.Size(100, 21)
        Me.txtIdGuiaTransportista.TabIndex = 35
        Me.txtIdGuiaTransportista.Visible = False
        '
        'txtGuiaTransportista
        '
        Appearance78.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance78.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGuiaTransportista.Appearance = Appearance78
        Me.txtGuiaTransportista.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGuiaTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuiaTransportista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGuiaTransportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuiaTransportista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGuiaTransportista.Location = New System.Drawing.Point(463, 32)
        Me.txtGuiaTransportista.MaxLength = 20
        Me.txtGuiaTransportista.Name = "txtGuiaTransportista"
        Me.txtGuiaTransportista.ReadOnly = True
        Me.txtGuiaTransportista.Size = New System.Drawing.Size(100, 21)
        Me.txtGuiaTransportista.TabIndex = 56
        '
        'UltraLabel43
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Appearance79.TextVAlignAsString = "Middle"
        Me.UltraLabel43.Appearance = Appearance79
        Me.UltraLabel43.AutoSize = True
        Me.UltraLabel43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel43.Location = New System.Drawing.Point(412, 36)
        Me.UltraLabel43.Name = "UltraLabel43"
        Me.UltraLabel43.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel43.TabIndex = 55
        Me.UltraLabel43.Text = "GRT N°:"
        '
        'cboMotivoTrasladoInterrumpido
        '
        Appearance80.ForeColor = System.Drawing.Color.Black
        Me.cboMotivoTrasladoInterrumpido.Appearance = Appearance80
        Me.cboMotivoTrasladoInterrumpido.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMotivoTrasladoInterrumpido.DisplayMember = "Nombre"
        Me.cboMotivoTrasladoInterrumpido.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMotivoTrasladoInterrumpido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMotivoTrasladoInterrumpido.ForeColor = System.Drawing.Color.Black
        Me.cboMotivoTrasladoInterrumpido.ImageList = Me.imagenes
        Me.cboMotivoTrasladoInterrumpido.Location = New System.Drawing.Point(78, 9)
        Me.cboMotivoTrasladoInterrumpido.Name = "cboMotivoTrasladoInterrumpido"
        Me.cboMotivoTrasladoInterrumpido.Size = New System.Drawing.Size(300, 21)
        Me.cboMotivoTrasladoInterrumpido.TabIndex = 54
        Me.cboMotivoTrasladoInterrumpido.ValueMember = "Id"
        '
        'UltraLabel42
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Appearance81.TextHAlignAsString = "Center"
        Appearance81.TextVAlignAsString = "Middle"
        Me.UltraLabel42.Appearance = Appearance81
        Me.UltraLabel42.Location = New System.Drawing.Point(1, 7)
        Me.UltraLabel42.Name = "UltraLabel42"
        Me.UltraLabel42.Size = New System.Drawing.Size(75, 40)
        Me.UltraLabel42.TabIndex = 53
        Me.UltraLabel42.Text = "Motivo del Traslado Interrumpido:"
        '
        'txtGlosaInterrumpido
        '
        Me.txtGlosaInterrumpido.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaInterrumpido.Location = New System.Drawing.Point(78, 32)
        Me.txtGlosaInterrumpido.Multiline = True
        Me.txtGlosaInterrumpido.Name = "txtGlosaInterrumpido"
        Me.txtGlosaInterrumpido.Size = New System.Drawing.Size(300, 21)
        Me.txtGlosaInterrumpido.TabIndex = 52
        Me.txtGlosaInterrumpido.Text = "Glosa:"
        '
        'btnAgregarInterrumpido
        '
        Appearance82.Image = "add.ico"
        Me.btnAgregarInterrumpido.Appearance = Appearance82
        Me.btnAgregarInterrumpido.ImageList = Me.imagenes
        Me.btnAgregarInterrumpido.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarInterrumpido.Location = New System.Drawing.Point(569, 26)
        Me.btnAgregarInterrumpido.Name = "btnAgregarInterrumpido"
        Me.btnAgregarInterrumpido.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarInterrumpido.TabIndex = 21
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griViajeDetalle)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(878, 255)
        '
        'griViajeDetalle
        '
        Me.griViajeDetalle.DataSource = Me.ogdOperacionDetalle
        Appearance83.BackColor = System.Drawing.Color.White
        Me.griViajeDetalle.DisplayLayout.Appearance = Appearance83
        UltraGridColumn466.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn466.Header.VisiblePosition = 1
        UltraGridColumn466.Hidden = True
        UltraGridColumn467.Header.VisiblePosition = 16
        UltraGridColumn467.Hidden = True
        UltraGridColumn467.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn467.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn467.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn467.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn468.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn468.Header.VisiblePosition = 0
        UltraGridColumn468.Hidden = True
        UltraGridColumn469.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn469.Header.VisiblePosition = 2
        UltraGridColumn469.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn469.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn469.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(280, 0)
        UltraGridColumn469.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn469.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn469.Width = 247
        UltraGridColumn470.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn470.Header.VisiblePosition = 3
        UltraGridColumn470.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn470.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn470.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(165, 0)
        UltraGridColumn470.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn470.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn470.Width = 192
        UltraGridColumn471.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance84.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance84.TextHAlignAsString = "Right"
        UltraGridColumn471.CellAppearance = Appearance84
        UltraGridColumn471.Header.VisiblePosition = 4
        UltraGridColumn471.MaskInput = "{double:4.3}"
        UltraGridColumn471.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn471.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn471.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(54, 0)
        UltraGridColumn471.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn471.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn471.Width = 54
        Appearance85.TextHAlignAsString = "Right"
        UltraGridColumn472.CellAppearance = Appearance85
        UltraGridColumn472.Header.VisiblePosition = 5
        UltraGridColumn472.Hidden = True
        UltraGridColumn472.MaskInput = "{LOC}nnn,nnn.nn"
        UltraGridColumn472.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn472.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn472.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        UltraGridColumn472.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn472.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn472.Width = 71
        UltraGridColumn473.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn473.Header.VisiblePosition = 6
        UltraGridColumn473.Hidden = True
        UltraGridColumn473.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn473.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn473.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
        UltraGridColumn473.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn473.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn473.Width = 60
        UltraGridColumn474.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn474.Header.Caption = "ContraEntrega"
        UltraGridColumn474.Header.VisiblePosition = 7
        UltraGridColumn474.Hidden = True
        UltraGridColumn474.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn474.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn474.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn474.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn474.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn474.Width = 83
        UltraGridColumn475.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn475.Header.VisiblePosition = 8
        UltraGridColumn475.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn475.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn475.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(165, 0)
        UltraGridColumn475.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn475.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn475.Width = 182
        UltraGridColumn476.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance86.TextHAlignAsString = "Center"
        UltraGridColumn476.CellAppearance = Appearance86
        UltraGridColumn476.Header.VisiblePosition = 9
        UltraGridColumn476.Hidden = True
        UltraGridColumn476.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn476.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn476.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(41, 0)
        UltraGridColumn476.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn476.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn476.Width = 49
        UltraGridColumn477.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance87.BackColor = System.Drawing.Color.LemonChiffon
        Appearance87.TextHAlignAsString = "Right"
        UltraGridColumn477.CellAppearance = Appearance87
        UltraGridColumn477.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn477.Header.VisiblePosition = 10
        UltraGridColumn477.Hidden = True
        UltraGridColumn477.MaskInput = "{LOC}nnn,nnn,nnn.nn"
        UltraGridColumn477.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn477.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn477.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn477.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn477.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn477.Width = 88
        UltraGridColumn478.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn478.Header.VisiblePosition = 11
        UltraGridColumn478.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn478.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn478.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(280, 0)
        UltraGridColumn478.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn478.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn478.Width = 210
        UltraGridColumn479.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance88.BackColor = System.Drawing.Color.LemonChiffon
        Appearance88.TextHAlignAsString = "Right"
        UltraGridColumn479.CellAppearance = Appearance88
        UltraGridColumn479.Header.VisiblePosition = 12
        UltraGridColumn479.Hidden = True
        UltraGridColumn479.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn479.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn479.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn479.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn479.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn479.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn479.Width = 66
        UltraGridColumn480.Header.VisiblePosition = 13
        UltraGridColumn480.Hidden = True
        UltraGridColumn481.Header.VisiblePosition = 14
        UltraGridColumn481.Hidden = True
        UltraGridColumn482.Header.VisiblePosition = 15
        UltraGridColumn482.Hidden = True
        UltraGridColumn483.Header.VisiblePosition = 17
        UltraGridColumn483.Hidden = True
        UltraGridColumn484.Header.VisiblePosition = 18
        UltraGridColumn484.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn484.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn484.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(144, 0)
        UltraGridColumn484.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn484.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn485.Header.VisiblePosition = 19
        UltraGridColumn485.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn485.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn485.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(144, 0)
        UltraGridColumn485.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn485.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn486.Header.VisiblePosition = 20
        UltraGridColumn486.Hidden = True
        UltraGridColumn486.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn486.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn486.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(48, 0)
        UltraGridColumn486.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn486.RowLayoutColumnInfo.SpanY = 2
        Appearance89.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance89.TextHAlignAsString = "Right"
        UltraGridColumn487.CellAppearance = Appearance89
        UltraGridColumn487.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn487.Header.Caption = "Peso TM"
        UltraGridColumn487.Header.VisiblePosition = 21
        UltraGridColumn487.MaskInput = "{double:2.4}"
        UltraGridColumn487.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn487.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn487.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(54, 0)
        UltraGridColumn487.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn487.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn488.Header.VisiblePosition = 22
        UltraGridColumn488.Hidden = True
        Appearance90.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance90.TextHAlignAsString = "Right"
        UltraGridColumn489.CellAppearance = Appearance90
        UltraGridColumn489.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn489.Header.Caption = "Peso TM Carga"
        UltraGridColumn489.Header.VisiblePosition = 23
        UltraGridColumn489.MaskInput = "{double:4.4}"
        UltraGridColumn489.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn489.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn489.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        UltraGridColumn489.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn489.RowLayoutColumnInfo.SpanY = 2
        Appearance91.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance91.TextHAlignAsString = "Right"
        UltraGridColumn490.CellAppearance = Appearance91
        UltraGridColumn490.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn490.Header.Caption = "P.TM Descarga"
        UltraGridColumn490.Header.VisiblePosition = 24
        UltraGridColumn490.MaskInput = "{double:4.4}"
        UltraGridColumn490.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn490.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn490.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        UltraGridColumn490.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn490.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn491.Header.VisiblePosition = 25
        UltraGridColumn491.Hidden = True
        UltraGridColumn492.Header.VisiblePosition = 26
        UltraGridColumn492.Hidden = True
        UltraGridColumn493.Header.VisiblePosition = 27
        UltraGridColumn493.Hidden = True
        UltraGridColumn494.Header.VisiblePosition = 28
        UltraGridColumn494.Hidden = True
        UltraGridColumn495.Header.VisiblePosition = 29
        UltraGridColumn495.Hidden = True
        UltraGridColumn496.Header.VisiblePosition = 30
        UltraGridColumn496.Hidden = True
        UltraGridColumn497.Header.VisiblePosition = 31
        UltraGridColumn497.Hidden = True
        UltraGridColumn498.Header.VisiblePosition = 32
        UltraGridColumn498.Hidden = True
        UltraGridColumn499.Header.VisiblePosition = 33
        UltraGridColumn499.Hidden = True
        UltraGridColumn500.Header.VisiblePosition = 34
        UltraGridColumn500.Hidden = True
        UltraGridColumn501.Header.VisiblePosition = 35
        UltraGridColumn501.Hidden = True
        UltraGridColumn502.Header.VisiblePosition = 36
        UltraGridColumn502.Hidden = True
        UltraGridColumn503.Header.VisiblePosition = 37
        UltraGridColumn503.Hidden = True
        UltraGridColumn504.Header.VisiblePosition = 38
        UltraGridColumn504.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn466, UltraGridColumn467, UltraGridColumn468, UltraGridColumn469, UltraGridColumn470, UltraGridColumn471, UltraGridColumn472, UltraGridColumn473, UltraGridColumn474, UltraGridColumn475, UltraGridColumn476, UltraGridColumn477, UltraGridColumn478, UltraGridColumn479, UltraGridColumn480, UltraGridColumn481, UltraGridColumn482, UltraGridColumn483, UltraGridColumn484, UltraGridColumn485, UltraGridColumn486, UltraGridColumn487, UltraGridColumn488, UltraGridColumn489, UltraGridColumn490, UltraGridColumn491, UltraGridColumn492, UltraGridColumn493, UltraGridColumn494, UltraGridColumn495, UltraGridColumn496, UltraGridColumn497, UltraGridColumn498, UltraGridColumn499, UltraGridColumn500, UltraGridColumn501, UltraGridColumn502, UltraGridColumn503, UltraGridColumn504})
        UltraGridBand7.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout
        SummarySettings1.DisplayFormat = "Total F = {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance92
        SummarySettings2.DisplayFormat = "Total C = {0}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance93
        UltraGridBand7.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2})
        UltraGridBand7.SummaryFooterCaption = "Totales:"
        Me.griViajeDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griViajeDetalle.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griViajeDetalle.DisplayLayout.GroupByBox.Hidden = True
        Me.griViajeDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajeDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance94.BackColor = System.Drawing.Color.Transparent
        Me.griViajeDetalle.DisplayLayout.Override.CardAreaAppearance = Appearance94
        Me.griViajeDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajeDetalle.DisplayLayout.Override.CellPadding = 2
        Me.griViajeDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance95.TextHAlignAsString = "Left"
        Me.griViajeDetalle.DisplayLayout.Override.HeaderAppearance = Appearance95
        Me.griViajeDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajeDetalle.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance96.TextVAlignAsString = "Middle"
        Me.griViajeDetalle.DisplayLayout.Override.RowAppearance = Appearance96
        Me.griViajeDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griViajeDetalle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajeDetalle.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajeDetalle.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griViajeDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griViajeDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajeDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajeDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajeDetalle.Location = New System.Drawing.Point(0, 0)
        Me.griViajeDetalle.Name = "griViajeDetalle"
        Me.griViajeDetalle.Size = New System.Drawing.Size(878, 255)
        Me.griViajeDetalle.TabIndex = 1
        Me.griViajeDetalle.Tag = ""
        '
        'ogdOperacionDetalle
        '
        UltraDataColumn137.DataType = GetType(Double)
        UltraDataColumn138.DataType = GetType(Double)
        UltraDataColumn139.DataType = GetType(Boolean)
        UltraDataColumn140.DataType = GetType(Boolean)
        UltraDataColumn143.DataType = GetType(Double)
        UltraDataColumn144.DataType = GetType(Object)
        UltraDataColumn145.DataType = GetType(Double)
        UltraDataColumn152.DataType = GetType(Boolean)
        UltraDataColumn153.DataType = GetType(Double)
        Me.ogdOperacionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraExpandableGroupBox6)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1074, 266)
        '
        'UltraExpandableGroupBox6
        '
        Appearance117.BackColor = System.Drawing.Color.White
        Appearance117.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox6.ContentAreaAppearance = Appearance117
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(1074, 76)
        Me.UltraExpandableGroupBox6.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(1074, 76)
        Me.UltraExpandableGroupBox6.TabIndex = 42
        Me.UltraExpandableGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.verClienteConf)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.verPilotoConf)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.verTractoConf)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.verCarretaConf)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel11)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.verCopilotoConf)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtViajeRuta)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.verViajeRetorno)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtViajePiloto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtViajeCarreta)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.verViajeVacio)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtViajeCodigo)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.hViaje)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.fecViaje)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel29)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtCliente)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtViajeTracto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel9)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtViajeEstado)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(1068, 70)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'UltraExpandableGroupBox1
        '
        Appearance118.BackColor = System.Drawing.Color.White
        Appearance118.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance118
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel9)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(250, 70)
        Me.UltraExpandableGroupBox1.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(818, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(250, 70)
        Me.UltraExpandableGroupBox1.TabIndex = 55
        Me.UltraExpandableGroupBox1.Text = "Falla"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel9
        '
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.btnCorreoFalla)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.hFalla)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.fecFalla)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.txtGlosaFalla)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.verIndFallaOP)
        Me.UltraExpandableGroupBoxPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel9.Location = New System.Drawing.Point(22, 3)
        Me.UltraExpandableGroupBoxPanel9.Name = "UltraExpandableGroupBoxPanel9"
        Me.UltraExpandableGroupBoxPanel9.Size = New System.Drawing.Size(225, 64)
        Me.UltraExpandableGroupBoxPanel9.TabIndex = 0
        '
        'btnCorreoFalla
        '
        Appearance119.Image = "01_messages.ico"
        Appearance119.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance119.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnCorreoFalla.Appearance = Appearance119
        Me.btnCorreoFalla.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCorreoFalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCorreoFalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorreoFalla.ForeColor = System.Drawing.Color.Black
        Me.btnCorreoFalla.ImageList = Me.imagenes
        Me.btnCorreoFalla.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCorreoFalla.Location = New System.Drawing.Point(83, 30)
        Me.btnCorreoFalla.Name = "btnCorreoFalla"
        Me.btnCorreoFalla.Size = New System.Drawing.Size(30, 30)
        Me.btnCorreoFalla.TabIndex = 56
        UltraToolTipInfo4.ToolTipText = "Enviar Correo a Supervisores"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.btnCorreoFalla, UltraToolTipInfo4)
        '
        'hFalla
        '
        Me.hFalla.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hFalla.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hFalla.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hFalla.Location = New System.Drawing.Point(57, 6)
        Me.hFalla.MaskInput = "{LOC}hh:mm"
        Me.hFalla.Name = "hFalla"
        Me.hFalla.Nullable = False
        Me.hFalla.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hFalla.Size = New System.Drawing.Size(50, 22)
        Me.hFalla.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hFalla.TabIndex = 54
        Me.hFalla.Tag = ""
        UltraToolTipInfo5.ToolTipText = "Hora de Inicio del Viaje - Salida de Planta"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.hFalla, UltraToolTipInfo5)
        Me.hFalla.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecFalla
        '
        Me.fecFalla.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecFalla.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFalla.Location = New System.Drawing.Point(2, 35)
        Me.fecFalla.MaskInput = ""
        Me.fecFalla.Name = "fecFalla"
        Me.fecFalla.Nullable = False
        Me.fecFalla.Size = New System.Drawing.Size(80, 21)
        Me.fecFalla.TabIndex = 52
        UltraToolTipInfo6.ToolTipText = "Fecha de Inicio del Viaje - Salida de Planta"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.fecFalla, UltraToolTipInfo6)
        Me.fecFalla.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'txtGlosaFalla
        '
        Appearance120.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGlosaFalla.Appearance = Appearance120
        Me.txtGlosaFalla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGlosaFalla.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaFalla.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtGlosaFalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaFalla.Location = New System.Drawing.Point(115, 0)
        Me.txtGlosaFalla.Multiline = True
        Me.txtGlosaFalla.Name = "txtGlosaFalla"
        Me.txtGlosaFalla.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosaFalla.Size = New System.Drawing.Size(110, 64)
        Me.txtGlosaFalla.TabIndex = 55
        UltraToolTipInfo7.ToolTipText = "Ingrese Incidencia / Falla Identificado de OP"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtGlosaFalla, UltraToolTipInfo7)
        '
        'verIndFallaOP
        '
        Appearance121.FontData.BoldAsString = "True"
        Appearance121.ForeColor = System.Drawing.Color.Navy
        Appearance121.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        Appearance121.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.verIndFallaOP.Appearance = Appearance121
        Me.verIndFallaOP.AutoSize = True
        Me.verIndFallaOP.Location = New System.Drawing.Point(2, -1)
        Me.verIndFallaOP.Name = "verIndFallaOP"
        Me.verIndFallaOP.Size = New System.Drawing.Size(50, 36)
        Me.verIndFallaOP.TabIndex = 53
        '
        'verClienteConf
        '
        Appearance122.FontData.BoldAsString = "True"
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Me.verClienteConf.Appearance = Appearance122
        Me.verClienteConf.AutoSize = True
        Me.verClienteConf.Location = New System.Drawing.Point(217, 51)
        Me.verClienteConf.Name = "verClienteConf"
        Me.verClienteConf.Size = New System.Drawing.Size(65, 18)
        Me.verClienteConf.TabIndex = 51
        Me.verClienteConf.Text = "Cliente:"
        '
        'verPilotoConf
        '
        Appearance123.FontData.BoldAsString = "True"
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Me.verPilotoConf.Appearance = Appearance123
        Me.verPilotoConf.AutoSize = True
        Me.verPilotoConf.Location = New System.Drawing.Point(319, 6)
        Me.verPilotoConf.Name = "verPilotoConf"
        Me.verPilotoConf.Size = New System.Drawing.Size(72, 18)
        Me.verPilotoConf.TabIndex = 50
        Me.verPilotoConf.Text = "Piloto    :"
        '
        'verTractoConf
        '
        Appearance124.FontData.BoldAsString = "True"
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Me.verTractoConf.Appearance = Appearance124
        Me.verTractoConf.AutoSize = True
        Me.verTractoConf.Location = New System.Drawing.Point(627, 5)
        Me.verTractoConf.Name = "verTractoConf"
        Me.verTractoConf.Size = New System.Drawing.Size(72, 18)
        Me.verTractoConf.TabIndex = 49
        Me.verTractoConf.Text = "Tracto   :"
        '
        'verCarretaConf
        '
        Appearance125.FontData.BoldAsString = "True"
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Me.verCarretaConf.Appearance = Appearance125
        Me.verCarretaConf.AutoSize = True
        Me.verCarretaConf.Location = New System.Drawing.Point(627, 28)
        Me.verCarretaConf.Name = "verCarretaConf"
        Me.verCarretaConf.Size = New System.Drawing.Size(73, 18)
        Me.verCarretaConf.TabIndex = 48
        Me.verCarretaConf.Text = "Carrreta:"
        '
        'UltraLabel11
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Appearance126.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance126
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(183, 31)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel11.TabIndex = 43
        Me.UltraLabel11.Text = "Hora:"
        '
        'verCopilotoConf
        '
        Appearance127.FontData.BoldAsString = "True"
        Appearance127.ForeColor = System.Drawing.Color.Navy
        Me.verCopilotoConf.Appearance = Appearance127
        Me.verCopilotoConf.AutoSize = True
        Me.verCopilotoConf.Location = New System.Drawing.Point(319, 28)
        Me.verCopilotoConf.Name = "verCopilotoConf"
        Me.verCopilotoConf.Size = New System.Drawing.Size(73, 18)
        Me.verCopilotoConf.TabIndex = 42
        Me.verCopilotoConf.Text = "Copiloto:"
        '
        'txtViajeRuta
        '
        Me.txtViajeRuta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeRuta.Location = New System.Drawing.Point(390, 26)
        Me.txtViajeRuta.Name = "txtViajeRuta"
        Me.txtViajeRuta.ReadOnly = True
        Me.txtViajeRuta.Size = New System.Drawing.Size(225, 19)
        Me.txtViajeRuta.TabIndex = 7
        '
        'verViajeRetorno
        '
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Me.verViajeRetorno.Appearance = Appearance128
        Me.verViajeRetorno.AutoSize = True
        Me.verViajeRetorno.Enabled = False
        Me.verViajeRetorno.Location = New System.Drawing.Point(83, 51)
        Me.verViajeRetorno.Name = "verViajeRetorno"
        Me.verViajeRetorno.Size = New System.Drawing.Size(75, 18)
        Me.verViajeRetorno.TabIndex = 40
        Me.verViajeRetorno.Text = "V. Retorno"
        '
        'txtViajePiloto
        '
        Me.txtViajePiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajePiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajePiloto.Location = New System.Drawing.Point(390, 4)
        Me.txtViajePiloto.Name = "txtViajePiloto"
        Me.txtViajePiloto.ReadOnly = True
        Me.txtViajePiloto.Size = New System.Drawing.Size(225, 19)
        Me.txtViajePiloto.TabIndex = 5
        '
        'txtViajeCarreta
        '
        Me.txtViajeCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeCarreta.Location = New System.Drawing.Point(698, 26)
        Me.txtViajeCarreta.Name = "txtViajeCarreta"
        Me.txtViajeCarreta.ReadOnly = True
        Me.txtViajeCarreta.Size = New System.Drawing.Size(70, 21)
        Me.txtViajeCarreta.TabIndex = 17
        '
        'verViajeVacio
        '
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Me.verViajeVacio.Appearance = Appearance129
        Me.verViajeVacio.AutoSize = True
        Me.verViajeVacio.Enabled = False
        Me.verViajeVacio.Location = New System.Drawing.Point(5, 51)
        Me.verViajeVacio.Name = "verViajeVacio"
        Me.verViajeVacio.Size = New System.Drawing.Size(63, 18)
        Me.verViajeVacio.TabIndex = 8
        Me.verViajeVacio.Text = "V. Vacío"
        '
        'UltraLabel4
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.Navy
        Appearance130.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance130
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(12, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Viaje:"
        '
        'txtViajeCodigo
        '
        Me.txtViajeCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeCodigo.Location = New System.Drawing.Point(46, 4)
        Me.txtViajeCodigo.Name = "txtViajeCodigo"
        Me.txtViajeCodigo.ReadOnly = True
        Me.txtViajeCodigo.Size = New System.Drawing.Size(115, 21)
        Me.txtViajeCodigo.TabIndex = 1
        '
        'hViaje
        '
        Me.hViaje.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hViaje.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hViaje.Location = New System.Drawing.Point(217, 27)
        Me.hViaje.MaskInput = "{LOC}hh:mm"
        Me.hViaje.Name = "hViaje"
        Me.hViaje.Nullable = False
        Me.hViaje.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hViaje.Size = New System.Drawing.Size(50, 22)
        Me.hViaje.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hViaje.TabIndex = 13
        Me.hViaje.Tag = ""
        UltraToolTipInfo8.ToolTipText = "Hora de Inicio del Viaje - Salida de Planta"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.hViaje, UltraToolTipInfo8)
        Me.hViaje.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecViaje
        '
        Me.fecViaje.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecViaje.Enabled = False
        Me.fecViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecViaje.Location = New System.Drawing.Point(217, 4)
        Me.fecViaje.MaskInput = ""
        Me.fecViaje.Name = "fecViaje"
        Me.fecViaje.Nullable = False
        Me.fecViaje.Size = New System.Drawing.Size(90, 21)
        Me.fecViaje.TabIndex = 12
        UltraToolTipInfo9.ToolTipText = "Fecha de Inicio del Viaje - Salida de Planta"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.fecViaje, UltraToolTipInfo9)
        Me.fecViaje.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel29
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Appearance131.TextVAlignAsString = "Middle"
        Me.UltraLabel29.Appearance = Appearance131
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel29.Location = New System.Drawing.Point(2, 31)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel29.TabIndex = 2
        Me.UltraLabel29.Text = "Estado:"
        '
        'txtCliente
        '
        Appearance132.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCliente.Appearance = Appearance132
        Me.txtCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(283, 50)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCliente.Size = New System.Drawing.Size(485, 19)
        Me.txtCliente.TabIndex = 18
        UltraToolTipInfo10.ToolTipText = "Cliente de la Carga Transportada"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtCliente, UltraToolTipInfo10)
        '
        'txtViajeTracto
        '
        Me.txtViajeTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeTracto.Location = New System.Drawing.Point(698, 3)
        Me.txtViajeTracto.Name = "txtViajeTracto"
        Me.txtViajeTracto.ReadOnly = True
        Me.txtViajeTracto.Size = New System.Drawing.Size(70, 21)
        Me.txtViajeTracto.TabIndex = 15
        '
        'UltraLabel9
        '
        Appearance133.BackColor = System.Drawing.Color.Transparent
        Appearance133.ForeColor = System.Drawing.Color.Navy
        Appearance133.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance133
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(167, 8)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel9.TabIndex = 11
        Me.UltraLabel9.Text = "F. Inicio:"
        '
        'txtViajeEstado
        '
        Me.txtViajeEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeEstado.Location = New System.Drawing.Point(46, 27)
        Me.txtViajeEstado.Name = "txtViajeEstado"
        Me.txtViajeEstado.ReadOnly = True
        Me.txtViajeEstado.Size = New System.Drawing.Size(115, 21)
        Me.txtViajeEstado.TabIndex = 3
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rounded
        Appearance134.BackColor = System.Drawing.Color.White
        Appearance134.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance134
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(1074, 190)
        Me.UltraExpandableGroupBox2.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(0, 76)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(1074, 190)
        Me.UltraExpandableGroupBox2.TabIndex = 41
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.grupoEnviarCorreo)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.grupoMarca01)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtIdOperacion)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtViajeId)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtIdTracto)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtSeguimientoId)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtIdCarreta)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.grupoMarca02)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1068, 184)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'grupoEnviarCorreo
        '
        Appearance135.BackColor = System.Drawing.Color.White
        Appearance135.BackColor2 = System.Drawing.Color.White
        Me.grupoEnviarCorreo.ContentAreaAppearance = Appearance135
        Me.grupoEnviarCorreo.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.grupoEnviarCorreo.Dock = System.Windows.Forms.DockStyle.Right
        Me.grupoEnviarCorreo.ExpandedSize = New System.Drawing.Size(250, 184)
        Me.grupoEnviarCorreo.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.grupoEnviarCorreo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.grupoEnviarCorreo.Location = New System.Drawing.Point(818, 0)
        Me.grupoEnviarCorreo.Name = "grupoEnviarCorreo"
        Me.grupoEnviarCorreo.Size = New System.Drawing.Size(250, 184)
        Me.grupoEnviarCorreo.TabIndex = 37
        Me.grupoEnviarCorreo.Text = "Incidencia / Observacion"
        Me.grupoEnviarCorreo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.btnEnviarCorreo)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtObservacion)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.cboLugarTienda)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel18)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtViajeEscala)
        Me.UltraExpandableGroupBoxPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(22, 3)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(225, 178)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        '
        'UltraLabel2
        '
        Appearance136.BackColor = System.Drawing.Color.Transparent
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Appearance136.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance136
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(4, 28)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel2.TabIndex = 40
        Me.UltraLabel2.Text = "Tienda:"
        '
        'btnEnviarCorreo
        '
        Appearance137.Image = CType(resources.GetObject("Appearance137.Image"), Object)
        Appearance137.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance137.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnEnviarCorreo.Appearance = Appearance137
        Me.btnEnviarCorreo.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEnviarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarCorreo.ForeColor = System.Drawing.Color.Black
        Me.btnEnviarCorreo.ImageList = Me.imagenes
        Me.btnEnviarCorreo.ImageSize = New System.Drawing.Size(50, 30)
        Me.btnEnviarCorreo.Location = New System.Drawing.Point(0, 46)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        Me.btnEnviarCorreo.Size = New System.Drawing.Size(45, 30)
        Me.btnEnviarCorreo.TabIndex = 36
        UltraToolTipInfo11.ToolTipText = "Enviar Correo a Supervisores"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.btnEnviarCorreo, UltraToolTipInfo11)
        '
        'txtObservacion
        '
        Appearance138.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtObservacion.Appearance = Appearance138
        Me.txtObservacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(0, 78)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(225, 100)
        Me.txtObservacion.TabIndex = 35
        UltraToolTipInfo12.ToolTipText = "Ingrese Observacion de viaje"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtObservacion, UltraToolTipInfo12)
        '
        'cboLugarTienda
        '
        Appearance139.ForeColor = System.Drawing.Color.Black
        Me.cboLugarTienda.Appearance = Appearance139
        Me.cboLugarTienda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugarTienda.DisplayMember = "Nombre"
        Me.cboLugarTienda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugarTienda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboLugarTienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugarTienda.ForeColor = System.Drawing.Color.Black
        Me.cboLugarTienda.Location = New System.Drawing.Point(47, 24)
        Me.cboLugarTienda.Name = "cboLugarTienda"
        Me.cboLugarTienda.Size = New System.Drawing.Size(175, 21)
        Me.cboLugarTienda.TabIndex = 39
        UltraToolTipInfo13.ToolTipText = "Tienda del Cliente segun Destino de Viaje"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboLugarTienda, UltraToolTipInfo13)
        Me.cboLugarTienda.ValueMember = "Id"
        '
        'UltraLabel18
        '
        Appearance140.BackColor = System.Drawing.Color.Transparent
        Appearance140.ForeColor = System.Drawing.Color.Navy
        Appearance140.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance140
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(4, 6)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel18.TabIndex = 9
        Me.UltraLabel18.Text = "Escala:"
        '
        'txtViajeEscala
        '
        Me.txtViajeEscala.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeEscala.Location = New System.Drawing.Point(47, 3)
        Me.txtViajeEscala.Name = "txtViajeEscala"
        Me.txtViajeEscala.ReadOnly = True
        Me.txtViajeEscala.Size = New System.Drawing.Size(175, 19)
        Me.txtViajeEscala.TabIndex = 10
        '
        'grupoMarca01
        '
        Appearance141.BackColor = System.Drawing.Color.White
        Appearance141.BackColor2 = System.Drawing.Color.White
        Me.grupoMarca01.ContentAreaAppearance = Appearance141
        Me.grupoMarca01.Controls.Add(Me.grupoLlegada)
        Me.grupoMarca01.Controls.Add(Me.exGroupMarca)
        Me.grupoMarca01.Controls.Add(Me.lbOrigen)
        Me.grupoMarca01.Controls.Add(Me.lbDestino)
        Me.grupoMarca01.Controls.Add(Me.verLlegadaOrigen)
        Me.grupoMarca01.Controls.Add(Me.verSalidaOrigen)
        Me.grupoMarca01.Controls.Add(Me.verSalidaDestino)
        Me.grupoMarca01.Controls.Add(Me.hSalidaOrigen)
        Me.grupoMarca01.Controls.Add(Me.hSalidaDestino)
        Me.grupoMarca01.Controls.Add(Me.hLlegadaOrigen)
        Me.grupoMarca01.Controls.Add(Me.btnSalidaOrigen)
        Me.grupoMarca01.Controls.Add(Me.btnSalidaDestino)
        Me.grupoMarca01.Controls.Add(Me.btnLlegadaOrigen)
        Me.grupoMarca01.Controls.Add(Me.fecSalidaDestino)
        Me.grupoMarca01.Controls.Add(Me.lblSalidaDestino)
        Me.grupoMarca01.Controls.Add(Me.fecSalidaOrigen)
        Me.grupoMarca01.Controls.Add(Me.UltraLabel20)
        Me.grupoMarca01.Controls.Add(Me.fecLlegadaOrigen)
        Me.grupoMarca01.Controls.Add(Me.UltraLabel7)
        Me.grupoMarca01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoMarca01.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoMarca01.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.grupoMarca01.Location = New System.Drawing.Point(1, 0)
        Me.grupoMarca01.Name = "grupoMarca01"
        Me.grupoMarca01.Size = New System.Drawing.Size(795, 130)
        Me.grupoMarca01.TabIndex = 21
        Me.grupoMarca01.Text = "Hora de 24 --> 00.00 am - 23:59 pm"
        Me.grupoMarca01.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grupoLlegada
        '
        Appearance142.BackColor = System.Drawing.Color.White
        Appearance142.BackColor2 = System.Drawing.Color.White
        Me.grupoLlegada.ContentAreaAppearance = Appearance142
        Me.grupoLlegada.Controls.Add(Me.btnLlegadaDestino)
        Me.grupoLlegada.Controls.Add(Me.UltraLabel24)
        Me.grupoLlegada.Controls.Add(Me.fecLlegadaDestino)
        Me.grupoLlegada.Controls.Add(Me.hLlegadaDestino)
        Me.grupoLlegada.Controls.Add(Me.verLlegadaDestino)
        Me.grupoLlegada.Location = New System.Drawing.Point(438, 17)
        Me.grupoLlegada.Name = "grupoLlegada"
        Me.grupoLlegada.Size = New System.Drawing.Size(350, 30)
        Me.grupoLlegada.TabIndex = 83
        Me.grupoLlegada.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnLlegadaDestino
        '
        Appearance143.Image = 8
        Appearance143.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnLlegadaDestino.Appearance = Appearance143
        Me.btnLlegadaDestino.ImageList = Me.imagenes
        Me.btnLlegadaDestino.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnLlegadaDestino.Location = New System.Drawing.Point(264, 2)
        Me.btnLlegadaDestino.Name = "btnLlegadaDestino"
        Me.btnLlegadaDestino.Size = New System.Drawing.Size(40, 25)
        Me.btnLlegadaDestino.TabIndex = 23
        '
        'UltraLabel24
        '
        Appearance144.BackColor = System.Drawing.Color.Transparent
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Appearance144.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance144
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(10, 8)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(89, 14)
        Me.UltraLabel24.TabIndex = 8
        Me.UltraLabel24.Text = "Llegada Destino:"
        '
        'fecLlegadaDestino
        '
        Me.fecLlegadaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecLlegadaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecLlegadaDestino.Location = New System.Drawing.Point(102, 4)
        Me.fecLlegadaDestino.MaskInput = ""
        Me.fecLlegadaDestino.Name = "fecLlegadaDestino"
        Me.fecLlegadaDestino.Size = New System.Drawing.Size(90, 21)
        Me.fecLlegadaDestino.TabIndex = 11
        Me.fecLlegadaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'hLlegadaDestino
        '
        Me.hLlegadaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hLlegadaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hLlegadaDestino.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hLlegadaDestino.Location = New System.Drawing.Point(198, 4)
        Me.hLlegadaDestino.MaskInput = "{LOC}hh:mm"
        Me.hLlegadaDestino.Name = "hLlegadaDestino"
        Me.hLlegadaDestino.Nullable = False
        Me.hLlegadaDestino.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hLlegadaDestino.Size = New System.Drawing.Size(55, 21)
        Me.hLlegadaDestino.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hLlegadaDestino.TabIndex = 22
        Me.hLlegadaDestino.Tag = ""
        Me.hLlegadaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'verLlegadaDestino
        '
        Appearance145.ForeColor = System.Drawing.Color.Navy
        Me.verLlegadaDestino.Appearance = Appearance145
        Me.verLlegadaDestino.AutoSize = True
        Me.verLlegadaDestino.Enabled = False
        Me.verLlegadaDestino.Location = New System.Drawing.Point(310, 5)
        Me.verLlegadaDestino.Name = "verLlegadaDestino"
        Me.verLlegadaDestino.Size = New System.Drawing.Size(38, 17)
        Me.verLlegadaDestino.TabIndex = 41
        Me.verLlegadaDestino.Text = "OK"
        '
        'exGroupMarca
        '
        Me.exGroupMarca.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance146.BackColor = System.Drawing.Color.White
        Appearance146.BackColor2 = System.Drawing.Color.White
        Me.exGroupMarca.ContentAreaAppearance = Appearance146
        Me.exGroupMarca.Controls.Add(Me.exGroupMarcaDentro)
        Me.exGroupMarca.ExpandedSize = New System.Drawing.Size(785, 55)
        Me.exGroupMarca.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exGroupMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exGroupMarca.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.exGroupMarca.Location = New System.Drawing.Point(3, 47)
        Me.exGroupMarca.Name = "exGroupMarca"
        Me.exGroupMarca.Size = New System.Drawing.Size(785, 55)
        Me.exGroupMarca.TabIndex = 49
        Me.exGroupMarca.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'exGroupMarcaDentro
        '
        Me.exGroupMarcaDentro.Controls.Add(Me.btnCargaOrigen)
        Me.exGroupMarcaDentro.Controls.Add(Me.fecCargaOrigen)
        Me.exGroupMarcaDentro.Controls.Add(Me.fecDescargaDestino)
        Me.exGroupMarcaDentro.Controls.Add(Me.UltraLabel26)
        Me.exGroupMarcaDentro.Controls.Add(Me.btnDescargaDestino)
        Me.exGroupMarcaDentro.Controls.Add(Me.verTerminoDescargaDestino)
        Me.exGroupMarcaDentro.Controls.Add(Me.hDescargaDestino)
        Me.exGroupMarcaDentro.Controls.Add(Me.hTerminoDescargaDestino)
        Me.exGroupMarcaDentro.Controls.Add(Me.hCargaOrigen)
        Me.exGroupMarcaDentro.Controls.Add(Me.btnTerminoDescargaDestino)
        Me.exGroupMarcaDentro.Controls.Add(Me.verDescargaDestino)
        Me.exGroupMarcaDentro.Controls.Add(Me.fecTerminoDescargaDestino)
        Me.exGroupMarcaDentro.Controls.Add(Me.verCargaOrigen)
        Me.exGroupMarcaDentro.Controls.Add(Me.UltraLabel45)
        Me.exGroupMarcaDentro.Controls.Add(Me.UltraLabel14)
        Me.exGroupMarcaDentro.Controls.Add(Me.lbl)
        Me.exGroupMarcaDentro.Controls.Add(Me.fecTerminoCargaOrigen)
        Me.exGroupMarcaDentro.Controls.Add(Me.verTerminoCargaOrigen)
        Me.exGroupMarcaDentro.Controls.Add(Me.btnTerminoCargaOrigen)
        Me.exGroupMarcaDentro.Controls.Add(Me.hTerminoCargaOrigen)
        Me.exGroupMarcaDentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.exGroupMarcaDentro.Location = New System.Drawing.Point(18, 3)
        Me.exGroupMarcaDentro.Name = "exGroupMarcaDentro"
        Me.exGroupMarcaDentro.Size = New System.Drawing.Size(764, 49)
        Me.exGroupMarcaDentro.TabIndex = 0
        UltraToolTipInfo14.ToolTipText = "Estados"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.exGroupMarcaDentro, UltraToolTipInfo14)
        '
        'btnCargaOrigen
        '
        Appearance147.Image = 8
        Appearance147.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnCargaOrigen.Appearance = Appearance147
        Me.btnCargaOrigen.ImageList = Me.imagenes
        Me.btnCargaOrigen.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnCargaOrigen.Location = New System.Drawing.Point(287, -1)
        Me.btnCargaOrigen.Name = "btnCargaOrigen"
        Me.btnCargaOrigen.Size = New System.Drawing.Size(40, 25)
        Me.btnCargaOrigen.TabIndex = 12
        '
        'fecCargaOrigen
        '
        Me.fecCargaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecCargaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecCargaOrigen.Location = New System.Drawing.Point(125, 1)
        Me.fecCargaOrigen.MaskInput = ""
        Me.fecCargaOrigen.Name = "fecCargaOrigen"
        Me.fecCargaOrigen.Size = New System.Drawing.Size(90, 21)
        Me.fecCargaOrigen.TabIndex = 10
        Me.fecCargaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecDescargaDestino
        '
        Me.fecDescargaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecDescargaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDescargaDestino.Location = New System.Drawing.Point(519, 1)
        Me.fecDescargaDestino.MaskInput = ""
        Me.fecDescargaDestino.Name = "fecDescargaDestino"
        Me.fecDescargaDestino.Size = New System.Drawing.Size(90, 21)
        Me.fecDescargaDestino.TabIndex = 13
        Me.fecDescargaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel26
        '
        Appearance148.BackColor = System.Drawing.Color.Transparent
        Appearance148.ForeColor = System.Drawing.Color.Navy
        Appearance148.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance148
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel26.Location = New System.Drawing.Point(388, 5)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(127, 14)
        Me.UltraLabel26.TabIndex = 12
        Me.UltraLabel26.Text = "Inicio Descarga Destino:"
        '
        'btnDescargaDestino
        '
        Appearance149.Image = 8
        Appearance149.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnDescargaDestino.Appearance = Appearance149
        Me.btnDescargaDestino.ImageList = Me.imagenes
        Me.btnDescargaDestino.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnDescargaDestino.Location = New System.Drawing.Point(681, -1)
        Me.btnDescargaDestino.Name = "btnDescargaDestino"
        Me.btnDescargaDestino.Size = New System.Drawing.Size(40, 25)
        Me.btnDescargaDestino.TabIndex = 27
        '
        'verTerminoDescargaDestino
        '
        Appearance150.ForeColor = System.Drawing.Color.Navy
        Me.verTerminoDescargaDestino.Appearance = Appearance150
        Me.verTerminoDescargaDestino.Enabled = False
        Me.verTerminoDescargaDestino.Location = New System.Drawing.Point(727, 27)
        Me.verTerminoDescargaDestino.Name = "verTerminoDescargaDestino"
        Me.verTerminoDescargaDestino.Size = New System.Drawing.Size(39, 20)
        Me.verTerminoDescargaDestino.TabIndex = 77
        Me.verTerminoDescargaDestino.Text = "OK"
        '
        'hDescargaDestino
        '
        Me.hDescargaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hDescargaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hDescargaDestino.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hDescargaDestino.Location = New System.Drawing.Point(615, 1)
        Me.hDescargaDestino.MaskInput = "{LOC}hh:mm"
        Me.hDescargaDestino.Name = "hDescargaDestino"
        Me.hDescargaDestino.Nullable = False
        Me.hDescargaDestino.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hDescargaDestino.Size = New System.Drawing.Size(55, 21)
        Me.hDescargaDestino.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hDescargaDestino.TabIndex = 26
        Me.hDescargaDestino.Tag = ""
        Me.hDescargaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'hTerminoDescargaDestino
        '
        Me.hTerminoDescargaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hTerminoDescargaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hTerminoDescargaDestino.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hTerminoDescargaDestino.Location = New System.Drawing.Point(615, 26)
        Me.hTerminoDescargaDestino.MaskInput = "{LOC}hh:mm"
        Me.hTerminoDescargaDestino.Name = "hTerminoDescargaDestino"
        Me.hTerminoDescargaDestino.Nullable = False
        Me.hTerminoDescargaDestino.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hTerminoDescargaDestino.Size = New System.Drawing.Size(55, 21)
        Me.hTerminoDescargaDestino.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hTerminoDescargaDestino.TabIndex = 30
        Me.hTerminoDescargaDestino.Tag = ""
        Me.hTerminoDescargaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'hCargaOrigen
        '
        Me.hCargaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hCargaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hCargaOrigen.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hCargaOrigen.Location = New System.Drawing.Point(221, 1)
        Me.hCargaOrigen.MaskInput = "{LOC}hh:mm"
        Me.hCargaOrigen.Name = "hCargaOrigen"
        Me.hCargaOrigen.Nullable = False
        Me.hCargaOrigen.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hCargaOrigen.Size = New System.Drawing.Size(55, 21)
        Me.hCargaOrigen.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hCargaOrigen.TabIndex = 11
        Me.hCargaOrigen.Tag = ""
        Me.hCargaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'btnTerminoDescargaDestino
        '
        Appearance151.Image = 8
        Appearance151.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnTerminoDescargaDestino.Appearance = Appearance151
        Me.btnTerminoDescargaDestino.ImageList = Me.imagenes
        Me.btnTerminoDescargaDestino.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnTerminoDescargaDestino.Location = New System.Drawing.Point(681, 24)
        Me.btnTerminoDescargaDestino.Name = "btnTerminoDescargaDestino"
        Me.btnTerminoDescargaDestino.Size = New System.Drawing.Size(40, 25)
        Me.btnTerminoDescargaDestino.TabIndex = 31
        '
        'verDescargaDestino
        '
        Appearance152.ForeColor = System.Drawing.Color.Navy
        Me.verDescargaDestino.Appearance = Appearance152
        Me.verDescargaDestino.Enabled = False
        Me.verDescargaDestino.Location = New System.Drawing.Point(727, 2)
        Me.verDescargaDestino.Name = "verDescargaDestino"
        Me.verDescargaDestino.Size = New System.Drawing.Size(39, 20)
        Me.verDescargaDestino.TabIndex = 42
        Me.verDescargaDestino.Text = "OK"
        '
        'fecTerminoDescargaDestino
        '
        Me.fecTerminoDescargaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecTerminoDescargaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecTerminoDescargaDestino.Location = New System.Drawing.Point(519, 26)
        Me.fecTerminoDescargaDestino.MaskInput = ""
        Me.fecTerminoDescargaDestino.Name = "fecTerminoDescargaDestino"
        Me.fecTerminoDescargaDestino.Size = New System.Drawing.Size(90, 21)
        Me.fecTerminoDescargaDestino.TabIndex = 15
        Me.fecTerminoDescargaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'verCargaOrigen
        '
        Appearance153.ForeColor = System.Drawing.Color.Navy
        Me.verCargaOrigen.Appearance = Appearance153
        Me.verCargaOrigen.Enabled = False
        Me.verCargaOrigen.Location = New System.Drawing.Point(333, 2)
        Me.verCargaOrigen.Name = "verCargaOrigen"
        Me.verCargaOrigen.Size = New System.Drawing.Size(39, 20)
        Me.verCargaOrigen.TabIndex = 13
        Me.verCargaOrigen.Text = "OK"
        '
        'UltraLabel45
        '
        Appearance154.BackColor = System.Drawing.Color.Transparent
        Appearance154.ForeColor = System.Drawing.Color.Navy
        Appearance154.TextVAlignAsString = "Middle"
        Me.UltraLabel45.Appearance = Appearance154
        Me.UltraLabel45.AutoSize = True
        Me.UltraLabel45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel45.Location = New System.Drawing.Point(375, 30)
        Me.UltraLabel45.Name = "UltraLabel45"
        Me.UltraLabel45.Size = New System.Drawing.Size(142, 14)
        Me.UltraLabel45.TabIndex = 14
        Me.UltraLabel45.Text = "Termino Descarga Destino:"
        '
        'UltraLabel14
        '
        Appearance155.BackColor = System.Drawing.Color.Transparent
        Appearance155.ForeColor = System.Drawing.Color.Navy
        Appearance155.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance155
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(2, 30)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(120, 14)
        Me.UltraLabel14.TabIndex = 14
        Me.UltraLabel14.Text = "Termino Carga Origen:"
        '
        'lbl
        '
        Appearance156.BackColor = System.Drawing.Color.Transparent
        Appearance156.ForeColor = System.Drawing.Color.Navy
        Appearance156.TextVAlignAsString = "Middle"
        Me.lbl.Appearance = Appearance156
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(17, 6)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(105, 14)
        Me.lbl.TabIndex = 9
        Me.lbl.Text = "Inicio Carga Origen:"
        '
        'fecTerminoCargaOrigen
        '
        Me.fecTerminoCargaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecTerminoCargaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecTerminoCargaOrigen.Location = New System.Drawing.Point(125, 26)
        Me.fecTerminoCargaOrigen.MaskInput = ""
        Me.fecTerminoCargaOrigen.Name = "fecTerminoCargaOrigen"
        Me.fecTerminoCargaOrigen.Size = New System.Drawing.Size(90, 21)
        Me.fecTerminoCargaOrigen.TabIndex = 15
        Me.fecTerminoCargaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'verTerminoCargaOrigen
        '
        Appearance157.ForeColor = System.Drawing.Color.Navy
        Me.verTerminoCargaOrigen.Appearance = Appearance157
        Me.verTerminoCargaOrigen.Enabled = False
        Me.verTerminoCargaOrigen.Location = New System.Drawing.Point(333, 27)
        Me.verTerminoCargaOrigen.Name = "verTerminoCargaOrigen"
        Me.verTerminoCargaOrigen.Size = New System.Drawing.Size(39, 20)
        Me.verTerminoCargaOrigen.TabIndex = 18
        Me.verTerminoCargaOrigen.Text = "OK"
        '
        'btnTerminoCargaOrigen
        '
        Appearance158.Image = 8
        Appearance158.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnTerminoCargaOrigen.Appearance = Appearance158
        Me.btnTerminoCargaOrigen.ImageList = Me.imagenes
        Me.btnTerminoCargaOrigen.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnTerminoCargaOrigen.Location = New System.Drawing.Point(287, 24)
        Me.btnTerminoCargaOrigen.Name = "btnTerminoCargaOrigen"
        Me.btnTerminoCargaOrigen.Size = New System.Drawing.Size(40, 25)
        Me.btnTerminoCargaOrigen.TabIndex = 17
        '
        'hTerminoCargaOrigen
        '
        Me.hTerminoCargaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hTerminoCargaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hTerminoCargaOrigen.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hTerminoCargaOrigen.Location = New System.Drawing.Point(221, 26)
        Me.hTerminoCargaOrigen.MaskInput = "{LOC}hh:mm"
        Me.hTerminoCargaOrigen.Name = "hTerminoCargaOrigen"
        Me.hTerminoCargaOrigen.Nullable = False
        Me.hTerminoCargaOrigen.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hTerminoCargaOrigen.Size = New System.Drawing.Size(55, 21)
        Me.hTerminoCargaOrigen.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hTerminoCargaOrigen.TabIndex = 16
        Me.hTerminoCargaOrigen.Tag = ""
        Me.hTerminoCargaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'lbOrigen
        '
        Appearance159.BackColor = System.Drawing.Color.Transparent
        Appearance159.ForeColor = System.Drawing.Color.Black
        Appearance159.TextVAlignAsString = "Middle"
        Me.lbOrigen.Appearance = Appearance159
        Me.lbOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOrigen.Location = New System.Drawing.Point(188, 1)
        Me.lbOrigen.Name = "lbOrigen"
        Me.lbOrigen.Size = New System.Drawing.Size(250, 15)
        Me.lbOrigen.TabIndex = 0
        Me.lbOrigen.Text = "ORIGEN"
        '
        'lbDestino
        '
        Appearance160.BackColor = System.Drawing.Color.Transparent
        Appearance160.ForeColor = System.Drawing.Color.Black
        Appearance160.TextVAlignAsString = "Middle"
        Me.lbDestino.Appearance = Appearance160
        Me.lbDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDestino.Location = New System.Drawing.Point(541, 1)
        Me.lbDestino.Name = "lbDestino"
        Me.lbDestino.Size = New System.Drawing.Size(250, 15)
        Me.lbDestino.TabIndex = 79
        Me.lbDestino.Text = "DESTINO"
        '
        'verLlegadaOrigen
        '
        Appearance161.ForeColor = System.Drawing.Color.Navy
        Me.verLlegadaOrigen.Appearance = Appearance161
        Me.verLlegadaOrigen.Enabled = False
        Me.verLlegadaOrigen.Location = New System.Drawing.Point(354, 21)
        Me.verLlegadaOrigen.Name = "verLlegadaOrigen"
        Me.verLlegadaOrigen.Size = New System.Drawing.Size(39, 20)
        Me.verLlegadaOrigen.TabIndex = 5
        Me.verLlegadaOrigen.Text = "OK"
        '
        'verSalidaOrigen
        '
        Appearance162.ForeColor = System.Drawing.Color.Navy
        Me.verSalidaOrigen.Appearance = Appearance162
        Me.verSalidaOrigen.Enabled = False
        Me.verSalidaOrigen.Location = New System.Drawing.Point(354, 105)
        Me.verSalidaOrigen.Name = "verSalidaOrigen"
        Me.verSalidaOrigen.Size = New System.Drawing.Size(39, 20)
        Me.verSalidaOrigen.TabIndex = 23
        Me.verSalidaOrigen.Text = "OK"
        '
        'verSalidaDestino
        '
        Appearance163.ForeColor = System.Drawing.Color.Navy
        Me.verSalidaDestino.Appearance = Appearance163
        Me.verSalidaDestino.Enabled = False
        Me.verSalidaDestino.Location = New System.Drawing.Point(748, 104)
        Me.verSalidaDestino.Name = "verSalidaDestino"
        Me.verSalidaDestino.Size = New System.Drawing.Size(39, 20)
        Me.verSalidaDestino.TabIndex = 39
        Me.verSalidaDestino.Text = "OK"
        '
        'hSalidaOrigen
        '
        Me.hSalidaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hSalidaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hSalidaOrigen.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hSalidaOrigen.Location = New System.Drawing.Point(242, 104)
        Me.hSalidaOrigen.MaskInput = "{LOC}hh:mm"
        Me.hSalidaOrigen.Name = "hSalidaOrigen"
        Me.hSalidaOrigen.Nullable = False
        Me.hSalidaOrigen.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hSalidaOrigen.Size = New System.Drawing.Size(55, 21)
        Me.hSalidaOrigen.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hSalidaOrigen.TabIndex = 21
        Me.hSalidaOrigen.Tag = ""
        Me.hSalidaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'hSalidaDestino
        '
        Me.hSalidaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hSalidaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hSalidaDestino.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hSalidaDestino.Location = New System.Drawing.Point(636, 104)
        Me.hSalidaDestino.MaskInput = "{LOC}hh:mm"
        Me.hSalidaDestino.Name = "hSalidaDestino"
        Me.hSalidaDestino.Nullable = False
        Me.hSalidaDestino.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hSalidaDestino.Size = New System.Drawing.Size(55, 21)
        Me.hSalidaDestino.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hSalidaDestino.TabIndex = 34
        Me.hSalidaDestino.Tag = ""
        Me.hSalidaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'hLlegadaOrigen
        '
        Me.hLlegadaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hLlegadaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hLlegadaOrigen.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hLlegadaOrigen.Location = New System.Drawing.Point(242, 20)
        Me.hLlegadaOrigen.MaskInput = "{LOC}hh:mm"
        Me.hLlegadaOrigen.Name = "hLlegadaOrigen"
        Me.hLlegadaOrigen.Nullable = False
        Me.hLlegadaOrigen.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hLlegadaOrigen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hLlegadaOrigen.Size = New System.Drawing.Size(55, 21)
        Me.hLlegadaOrigen.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hLlegadaOrigen.TabIndex = 3
        Me.hLlegadaOrigen.Tag = ""
        Me.hLlegadaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'btnSalidaOrigen
        '
        Appearance164.Image = 8
        Appearance164.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnSalidaOrigen.Appearance = Appearance164
        Me.btnSalidaOrigen.ImageList = Me.imagenes
        Me.btnSalidaOrigen.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnSalidaOrigen.Location = New System.Drawing.Point(308, 102)
        Me.btnSalidaOrigen.Name = "btnSalidaOrigen"
        Me.btnSalidaOrigen.Size = New System.Drawing.Size(40, 25)
        Me.btnSalidaOrigen.TabIndex = 22
        '
        'btnSalidaDestino
        '
        Appearance165.Image = 8
        Appearance165.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnSalidaDestino.Appearance = Appearance165
        Me.btnSalidaDestino.ImageList = Me.imagenes
        Me.btnSalidaDestino.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnSalidaDestino.Location = New System.Drawing.Point(702, 102)
        Me.btnSalidaDestino.Name = "btnSalidaDestino"
        Me.btnSalidaDestino.Size = New System.Drawing.Size(40, 25)
        Me.btnSalidaDestino.TabIndex = 35
        '
        'btnLlegadaOrigen
        '
        Appearance166.Image = 8
        Appearance166.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnLlegadaOrigen.Appearance = Appearance166
        Me.btnLlegadaOrigen.ImageList = Me.imagenes
        Me.btnLlegadaOrigen.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnLlegadaOrigen.Location = New System.Drawing.Point(308, 19)
        Me.btnLlegadaOrigen.Name = "btnLlegadaOrigen"
        Me.btnLlegadaOrigen.Size = New System.Drawing.Size(40, 25)
        Me.btnLlegadaOrigen.TabIndex = 4
        '
        'fecSalidaDestino
        '
        Me.fecSalidaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecSalidaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecSalidaDestino.Location = New System.Drawing.Point(540, 104)
        Me.fecSalidaDestino.MaskInput = ""
        Me.fecSalidaDestino.Name = "fecSalidaDestino"
        Me.fecSalidaDestino.Size = New System.Drawing.Size(90, 21)
        Me.fecSalidaDestino.TabIndex = 17
        Me.fecSalidaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'lblSalidaDestino
        '
        Appearance167.BackColor = System.Drawing.Color.Transparent
        Appearance167.ForeColor = System.Drawing.Color.Navy
        Appearance167.TextVAlignAsString = "Middle"
        Me.lblSalidaDestino.Appearance = Appearance167
        Me.lblSalidaDestino.AutoSize = True
        Me.lblSalidaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidaDestino.Location = New System.Drawing.Point(456, 110)
        Me.lblSalidaDestino.Name = "lblSalidaDestino"
        Me.lblSalidaDestino.Size = New System.Drawing.Size(80, 14)
        Me.lblSalidaDestino.TabIndex = 16
        Me.lblSalidaDestino.Text = "Salida Destino:"
        '
        'fecSalidaOrigen
        '
        Me.fecSalidaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecSalidaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecSalidaOrigen.Location = New System.Drawing.Point(146, 104)
        Me.fecSalidaOrigen.MaskInput = ""
        Me.fecSalidaOrigen.Name = "fecSalidaOrigen"
        Me.fecSalidaOrigen.Size = New System.Drawing.Size(90, 21)
        Me.fecSalidaOrigen.TabIndex = 20
        Me.fecSalidaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel20
        '
        Appearance168.BackColor = System.Drawing.Color.Transparent
        Appearance168.ForeColor = System.Drawing.Color.Navy
        Appearance168.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance168
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(67, 110)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel20.TabIndex = 19
        Me.UltraLabel20.Text = "Salida Origen:"
        '
        'fecLlegadaOrigen
        '
        Me.fecLlegadaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecLlegadaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecLlegadaOrigen.Location = New System.Drawing.Point(146, 20)
        Me.fecLlegadaOrigen.MaskInput = ""
        Me.fecLlegadaOrigen.Name = "fecLlegadaOrigen"
        Me.fecLlegadaOrigen.Size = New System.Drawing.Size(90, 21)
        Me.fecLlegadaOrigen.TabIndex = 2
        Me.fecLlegadaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel7
        '
        Appearance169.BackColor = System.Drawing.Color.Transparent
        Appearance169.ForeColor = System.Drawing.Color.Navy
        Appearance169.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance169
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(58, 26)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(85, 14)
        Me.UltraLabel7.TabIndex = 1
        Me.UltraLabel7.Text = "Llegada Origen:"
        '
        'txtIdOperacion
        '
        Me.txtIdOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacion.Location = New System.Drawing.Point(816, 3)
        Me.txtIdOperacion.Name = "txtIdOperacion"
        Me.txtIdOperacion.ReadOnly = True
        Me.txtIdOperacion.Size = New System.Drawing.Size(90, 21)
        Me.txtIdOperacion.TabIndex = 34
        Me.txtIdOperacion.Visible = False
        '
        'txtViajeId
        '
        Me.txtViajeId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeId.Location = New System.Drawing.Point(816, 30)
        Me.txtViajeId.Name = "txtViajeId"
        Me.txtViajeId.ReadOnly = True
        Me.txtViajeId.Size = New System.Drawing.Size(90, 21)
        Me.txtViajeId.TabIndex = 22
        Me.txtViajeId.Visible = False
        '
        'txtIdTracto
        '
        Me.txtIdTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdTracto.Location = New System.Drawing.Point(816, 84)
        Me.txtIdTracto.Name = "txtIdTracto"
        Me.txtIdTracto.ReadOnly = True
        Me.txtIdTracto.Size = New System.Drawing.Size(90, 21)
        Me.txtIdTracto.TabIndex = 38
        Me.txtIdTracto.Visible = False
        '
        'txtSeguimientoId
        '
        Me.txtSeguimientoId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSeguimientoId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeguimientoId.Location = New System.Drawing.Point(816, 57)
        Me.txtSeguimientoId.Name = "txtSeguimientoId"
        Me.txtSeguimientoId.ReadOnly = True
        Me.txtSeguimientoId.Size = New System.Drawing.Size(90, 21)
        Me.txtSeguimientoId.TabIndex = 3
        Me.txtSeguimientoId.Visible = False
        '
        'txtIdCarreta
        '
        Me.txtIdCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCarreta.Location = New System.Drawing.Point(816, 111)
        Me.txtIdCarreta.Name = "txtIdCarreta"
        Me.txtIdCarreta.ReadOnly = True
        Me.txtIdCarreta.Size = New System.Drawing.Size(90, 21)
        Me.txtIdCarreta.TabIndex = 37
        Me.txtIdCarreta.Visible = False
        '
        'grupoMarca02
        '
        Appearance170.BackColor = System.Drawing.Color.White
        Appearance170.BackColor2 = System.Drawing.Color.White
        Me.grupoMarca02.ContentAreaAppearance = Appearance170
        Me.grupoMarca02.Controls.Add(Me.grupoLlegadaE)
        Me.grupoMarca02.Controls.Add(Me.exGroupMarcaE)
        Me.grupoMarca02.Controls.Add(Me.lbOrigenE)
        Me.grupoMarca02.Controls.Add(Me.lbDestinoE)
        Me.grupoMarca02.Controls.Add(Me.verSalidaDestinoE)
        Me.grupoMarca02.Controls.Add(Me.hSalidaDestinoE)
        Me.grupoMarca02.Controls.Add(Me.btnSalidaDestinoE)
        Me.grupoMarca02.Controls.Add(Me.fecSalidaDestinoE)
        Me.grupoMarca02.Controls.Add(Me.lblSalidaDestinoE)
        Me.grupoMarca02.Controls.Add(Me.verLlegadaOrigenE)
        Me.grupoMarca02.Controls.Add(Me.verSalidaOrigenE)
        Me.grupoMarca02.Controls.Add(Me.hSalidaOrigenE)
        Me.grupoMarca02.Controls.Add(Me.hLlegadaOrigenE)
        Me.grupoMarca02.Controls.Add(Me.btnSalidaOrigenE)
        Me.grupoMarca02.Controls.Add(Me.btnLlegadaOrigenE)
        Me.grupoMarca02.Controls.Add(Me.fecSalidaOrigenE)
        Me.grupoMarca02.Controls.Add(Me.UltraLabel16)
        Me.grupoMarca02.Controls.Add(Me.fecLlegadaOrigenE)
        Me.grupoMarca02.Controls.Add(Me.UltraLabel35)
        Me.grupoMarca02.Dock = System.Windows.Forms.DockStyle.Left
        Me.grupoMarca02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoMarca02.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoMarca02.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.grupoMarca02.Location = New System.Drawing.Point(0, 0)
        Me.grupoMarca02.Name = "grupoMarca02"
        Me.grupoMarca02.Size = New System.Drawing.Size(810, 184)
        Me.grupoMarca02.TabIndex = 0
        Me.grupoMarca02.Text = "Hora de 24 --> 00.00 am - 23:59 pm"
        Me.grupoMarca02.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grupoLlegadaE
        '
        Appearance171.BackColor = System.Drawing.Color.White
        Appearance171.BackColor2 = System.Drawing.Color.White
        Me.grupoLlegadaE.ContentAreaAppearance = Appearance171
        Me.grupoLlegadaE.Controls.Add(Me.btnLlegadaAproximadaDestinoE)
        Me.grupoLlegadaE.Controls.Add(Me.UltraLabel41)
        Me.grupoLlegadaE.Controls.Add(Me.fecLlegadaAproximadaDestinoE)
        Me.grupoLlegadaE.Controls.Add(Me.verLlegadaAproximadaDestinoE)
        Me.grupoLlegadaE.Controls.Add(Me.hLlegadaAproximadaDestinoE)
        Me.grupoLlegadaE.Location = New System.Drawing.Point(404, 17)
        Me.grupoLlegadaE.Name = "grupoLlegadaE"
        Me.grupoLlegadaE.Size = New System.Drawing.Size(400, 30)
        Me.grupoLlegadaE.TabIndex = 37
        Me.grupoLlegadaE.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnLlegadaAproximadaDestinoE
        '
        Appearance172.Image = 8
        Appearance172.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnLlegadaAproximadaDestinoE.Appearance = Appearance172
        Me.btnLlegadaAproximadaDestinoE.ImageList = Me.imagenes
        Me.btnLlegadaAproximadaDestinoE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnLlegadaAproximadaDestinoE.Location = New System.Drawing.Point(309, 3)
        Me.btnLlegadaAproximadaDestinoE.Name = "btnLlegadaAproximadaDestinoE"
        Me.btnLlegadaAproximadaDestinoE.Size = New System.Drawing.Size(40, 25)
        Me.btnLlegadaAproximadaDestinoE.TabIndex = 34
        '
        'UltraLabel41
        '
        Appearance173.BackColor = System.Drawing.Color.Transparent
        Appearance173.ForeColor = System.Drawing.Color.Navy
        Appearance173.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance173
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(3, 8)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(141, 14)
        Me.UltraLabel41.TabIndex = 1
        Me.UltraLabel41.Text = "Llegada Aproximada Dest.:"
        '
        'fecLlegadaAproximadaDestinoE
        '
        Me.fecLlegadaAproximadaDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecLlegadaAproximadaDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecLlegadaAproximadaDestinoE.Location = New System.Drawing.Point(147, 4)
        Me.fecLlegadaAproximadaDestinoE.MaskInput = ""
        Me.fecLlegadaAproximadaDestinoE.Name = "fecLlegadaAproximadaDestinoE"
        Me.fecLlegadaAproximadaDestinoE.Size = New System.Drawing.Size(90, 21)
        Me.fecLlegadaAproximadaDestinoE.TabIndex = 32
        Me.fecLlegadaAproximadaDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'verLlegadaAproximadaDestinoE
        '
        Appearance174.ForeColor = System.Drawing.Color.Navy
        Me.verLlegadaAproximadaDestinoE.Appearance = Appearance174
        Me.verLlegadaAproximadaDestinoE.Enabled = False
        Me.verLlegadaAproximadaDestinoE.Location = New System.Drawing.Point(355, 5)
        Me.verLlegadaAproximadaDestinoE.Name = "verLlegadaAproximadaDestinoE"
        Me.verLlegadaAproximadaDestinoE.Size = New System.Drawing.Size(39, 20)
        Me.verLlegadaAproximadaDestinoE.TabIndex = 35
        Me.verLlegadaAproximadaDestinoE.Text = "OK"
        '
        'hLlegadaAproximadaDestinoE
        '
        Me.hLlegadaAproximadaDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hLlegadaAproximadaDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hLlegadaAproximadaDestinoE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hLlegadaAproximadaDestinoE.Location = New System.Drawing.Point(243, 4)
        Me.hLlegadaAproximadaDestinoE.MaskInput = "{LOC}hh:mm"
        Me.hLlegadaAproximadaDestinoE.Name = "hLlegadaAproximadaDestinoE"
        Me.hLlegadaAproximadaDestinoE.Nullable = False
        Me.hLlegadaAproximadaDestinoE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hLlegadaAproximadaDestinoE.Size = New System.Drawing.Size(55, 21)
        Me.hLlegadaAproximadaDestinoE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hLlegadaAproximadaDestinoE.TabIndex = 33
        Me.hLlegadaAproximadaDestinoE.Tag = ""
        Me.hLlegadaAproximadaDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'exGroupMarcaE
        '
        Me.exGroupMarcaE.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance175.BackColor = System.Drawing.Color.White
        Appearance175.BackColor2 = System.Drawing.Color.White
        Me.exGroupMarcaE.ContentAreaAppearance = Appearance175
        Me.exGroupMarcaE.Controls.Add(Me.exGroupMarcaEDentro)
        Me.exGroupMarcaE.ExpandedSize = New System.Drawing.Size(800, 106)
        Me.exGroupMarcaE.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exGroupMarcaE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exGroupMarcaE.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.exGroupMarcaE.Location = New System.Drawing.Point(4, 48)
        Me.exGroupMarcaE.Name = "exGroupMarcaE"
        Me.exGroupMarcaE.Size = New System.Drawing.Size(800, 106)
        Me.exGroupMarcaE.TabIndex = 82
        Me.exGroupMarcaE.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'exGroupMarcaEDentro
        '
        Me.exGroupMarcaEDentro.Controls.Add(Me.verLlegadaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.fecIngresoComplejoOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.hLlegadaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.UltraLabel34)
        Me.exGroupMarcaEDentro.Controls.Add(Me.btnLlegadaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.UltraLabel33)
        Me.exGroupMarcaEDentro.Controls.Add(Me.fecLlegadaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.fecCargaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.UltraLabel40)
        Me.exGroupMarcaEDentro.Controls.Add(Me.verIngresoDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.UltraLabel32)
        Me.exGroupMarcaEDentro.Controls.Add(Me.verTerminoDescargaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.fecTerminoCargaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.verDescargaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.UltraLabel31)
        Me.exGroupMarcaEDentro.Controls.Add(Me.fecImpresionGuiaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.btnIngresoComplejoOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.hIngresoDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.btnImpresionGuiaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.btnTerminoCargaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.hTerminoDescargaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.btnCargaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.hDescargaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.hTerminoCargaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.hImpresionGuiaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.btnIngresoDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.hCargaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.btnDescargaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.hIngresoComplejoOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.btnTerminoDescargaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.verTerminoCargaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.verImpresionGuiaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.verCargaOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.verIngresoComplejoOrigenE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.fecTerminoDescargaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.UltraLabel39)
        Me.exGroupMarcaEDentro.Controls.Add(Me.UltraLabel37)
        Me.exGroupMarcaEDentro.Controls.Add(Me.fecIngresoDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.fecDescargaDestinoE)
        Me.exGroupMarcaEDentro.Controls.Add(Me.UltraLabel38)
        Me.exGroupMarcaEDentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.exGroupMarcaEDentro.Location = New System.Drawing.Point(18, 3)
        Me.exGroupMarcaEDentro.Name = "exGroupMarcaEDentro"
        Me.exGroupMarcaEDentro.Size = New System.Drawing.Size(779, 100)
        Me.exGroupMarcaEDentro.TabIndex = 0
        UltraToolTipInfo15.ToolTipText = "Estados"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.exGroupMarcaEDentro, UltraToolTipInfo15)
        '
        'verLlegadaDestinoE
        '
        Appearance176.ForeColor = System.Drawing.Color.Navy
        Me.verLlegadaDestinoE.Appearance = Appearance176
        Me.verLlegadaDestinoE.Enabled = False
        Me.verLlegadaDestinoE.Location = New System.Drawing.Point(737, 3)
        Me.verLlegadaDestinoE.Name = "verLlegadaDestinoE"
        Me.verLlegadaDestinoE.Size = New System.Drawing.Size(39, 20)
        Me.verLlegadaDestinoE.TabIndex = 40
        Me.verLlegadaDestinoE.Text = "OK"
        '
        'fecIngresoComplejoOrigenE
        '
        Me.fecIngresoComplejoOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecIngresoComplejoOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecIngresoComplejoOrigenE.Location = New System.Drawing.Point(129, 1)
        Me.fecIngresoComplejoOrigenE.MaskInput = ""
        Me.fecIngresoComplejoOrigenE.Name = "fecIngresoComplejoOrigenE"
        Me.fecIngresoComplejoOrigenE.Size = New System.Drawing.Size(90, 21)
        Me.fecIngresoComplejoOrigenE.TabIndex = 6
        Me.fecIngresoComplejoOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'hLlegadaDestinoE
        '
        Me.hLlegadaDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hLlegadaDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hLlegadaDestinoE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hLlegadaDestinoE.Location = New System.Drawing.Point(625, 2)
        Me.hLlegadaDestinoE.MaskInput = "{LOC}hh:mm"
        Me.hLlegadaDestinoE.Name = "hLlegadaDestinoE"
        Me.hLlegadaDestinoE.Nullable = False
        Me.hLlegadaDestinoE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hLlegadaDestinoE.Size = New System.Drawing.Size(55, 21)
        Me.hLlegadaDestinoE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hLlegadaDestinoE.TabIndex = 38
        Me.hLlegadaDestinoE.Tag = ""
        Me.hLlegadaDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel34
        '
        Appearance177.BackColor = System.Drawing.Color.Transparent
        Appearance177.ForeColor = System.Drawing.Color.Navy
        Appearance177.TextVAlignAsString = "Middle"
        Me.UltraLabel34.Appearance = Appearance177
        Me.UltraLabel34.AutoSize = True
        Me.UltraLabel34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel34.Location = New System.Drawing.Point(2, 5)
        Me.UltraLabel34.Name = "UltraLabel34"
        Me.UltraLabel34.Size = New System.Drawing.Size(124, 14)
        Me.UltraLabel34.TabIndex = 2
        Me.UltraLabel34.Text = "Ingreso Complejo Orig.:"
        '
        'btnLlegadaDestinoE
        '
        Appearance178.Image = 8
        Appearance178.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnLlegadaDestinoE.Appearance = Appearance178
        Me.btnLlegadaDestinoE.ImageList = Me.imagenes
        Me.btnLlegadaDestinoE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnLlegadaDestinoE.Location = New System.Drawing.Point(691, 0)
        Me.btnLlegadaDestinoE.Name = "btnLlegadaDestinoE"
        Me.btnLlegadaDestinoE.Size = New System.Drawing.Size(40, 25)
        Me.btnLlegadaDestinoE.TabIndex = 39
        '
        'UltraLabel33
        '
        Appearance179.BackColor = System.Drawing.Color.Transparent
        Appearance179.ForeColor = System.Drawing.Color.Navy
        Appearance179.TextVAlignAsString = "Middle"
        Me.UltraLabel33.Appearance = Appearance179
        Me.UltraLabel33.AutoSize = True
        Me.UltraLabel33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel33.Location = New System.Drawing.Point(21, 30)
        Me.UltraLabel33.Name = "UltraLabel33"
        Me.UltraLabel33.Size = New System.Drawing.Size(105, 14)
        Me.UltraLabel33.TabIndex = 3
        Me.UltraLabel33.Text = "Inicio Carga Origen:"
        '
        'fecLlegadaDestinoE
        '
        Me.fecLlegadaDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecLlegadaDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecLlegadaDestinoE.Location = New System.Drawing.Point(529, 2)
        Me.fecLlegadaDestinoE.MaskInput = ""
        Me.fecLlegadaDestinoE.Name = "fecLlegadaDestinoE"
        Me.fecLlegadaDestinoE.Size = New System.Drawing.Size(90, 21)
        Me.fecLlegadaDestinoE.TabIndex = 37
        Me.fecLlegadaDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecCargaOrigenE
        '
        Me.fecCargaOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecCargaOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecCargaOrigenE.Location = New System.Drawing.Point(129, 26)
        Me.fecCargaOrigenE.MaskInput = ""
        Me.fecCargaOrigenE.Name = "fecCargaOrigenE"
        Me.fecCargaOrigenE.Size = New System.Drawing.Size(90, 21)
        Me.fecCargaOrigenE.TabIndex = 10
        Me.fecCargaOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel40
        '
        Appearance180.BackColor = System.Drawing.Color.Transparent
        Appearance180.ForeColor = System.Drawing.Color.Navy
        Appearance180.TextVAlignAsString = "Middle"
        Me.UltraLabel40.Appearance = Appearance180
        Me.UltraLabel40.AutoSize = True
        Me.UltraLabel40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel40.Location = New System.Drawing.Point(437, 6)
        Me.UltraLabel40.Name = "UltraLabel40"
        Me.UltraLabel40.Size = New System.Drawing.Size(89, 14)
        Me.UltraLabel40.TabIndex = 36
        Me.UltraLabel40.Text = "Llegada Destino:"
        '
        'verIngresoDestinoE
        '
        Appearance181.ForeColor = System.Drawing.Color.Navy
        Me.verIngresoDestinoE.Appearance = Appearance181
        Me.verIngresoDestinoE.Enabled = False
        Me.verIngresoDestinoE.Location = New System.Drawing.Point(737, 28)
        Me.verIngresoDestinoE.Name = "verIngresoDestinoE"
        Me.verIngresoDestinoE.Size = New System.Drawing.Size(39, 20)
        Me.verIngresoDestinoE.TabIndex = 45
        Me.verIngresoDestinoE.Text = "OK"
        '
        'UltraLabel32
        '
        Appearance182.BackColor = System.Drawing.Color.Transparent
        Appearance182.ForeColor = System.Drawing.Color.Navy
        Appearance182.TextVAlignAsString = "Middle"
        Me.UltraLabel32.Appearance = Appearance182
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(6, 55)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(120, 14)
        Me.UltraLabel32.TabIndex = 4
        Me.UltraLabel32.Text = "Termino Carga Origen:"
        '
        'verTerminoDescargaDestinoE
        '
        Appearance183.ForeColor = System.Drawing.Color.Navy
        Me.verTerminoDescargaDestinoE.Appearance = Appearance183
        Me.verTerminoDescargaDestinoE.Enabled = False
        Me.verTerminoDescargaDestinoE.Location = New System.Drawing.Point(737, 78)
        Me.verTerminoDescargaDestinoE.Name = "verTerminoDescargaDestinoE"
        Me.verTerminoDescargaDestinoE.Size = New System.Drawing.Size(39, 20)
        Me.verTerminoDescargaDestinoE.TabIndex = 55
        Me.verTerminoDescargaDestinoE.Text = "OK"
        '
        'fecTerminoCargaOrigenE
        '
        Me.fecTerminoCargaOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecTerminoCargaOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecTerminoCargaOrigenE.Location = New System.Drawing.Point(129, 51)
        Me.fecTerminoCargaOrigenE.MaskInput = ""
        Me.fecTerminoCargaOrigenE.Name = "fecTerminoCargaOrigenE"
        Me.fecTerminoCargaOrigenE.Size = New System.Drawing.Size(90, 21)
        Me.fecTerminoCargaOrigenE.TabIndex = 14
        Me.fecTerminoCargaOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'verDescargaDestinoE
        '
        Appearance184.ForeColor = System.Drawing.Color.Navy
        Me.verDescargaDestinoE.Appearance = Appearance184
        Me.verDescargaDestinoE.Enabled = False
        Me.verDescargaDestinoE.Location = New System.Drawing.Point(737, 53)
        Me.verDescargaDestinoE.Name = "verDescargaDestinoE"
        Me.verDescargaDestinoE.Size = New System.Drawing.Size(39, 20)
        Me.verDescargaDestinoE.TabIndex = 50
        Me.verDescargaDestinoE.Text = "OK"
        '
        'UltraLabel31
        '
        Appearance185.BackColor = System.Drawing.Color.Transparent
        Appearance185.ForeColor = System.Drawing.Color.Navy
        Appearance185.TextVAlignAsString = "Middle"
        Me.UltraLabel31.Appearance = Appearance185
        Me.UltraLabel31.AutoSize = True
        Me.UltraLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel31.Location = New System.Drawing.Point(5, 80)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(121, 14)
        Me.UltraLabel31.TabIndex = 17
        Me.UltraLabel31.Text = "Impresion Guia Origen:"
        '
        'fecImpresionGuiaOrigenE
        '
        Me.fecImpresionGuiaOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecImpresionGuiaOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecImpresionGuiaOrigenE.Location = New System.Drawing.Point(129, 76)
        Me.fecImpresionGuiaOrigenE.MaskInput = ""
        Me.fecImpresionGuiaOrigenE.Name = "fecImpresionGuiaOrigenE"
        Me.fecImpresionGuiaOrigenE.Size = New System.Drawing.Size(90, 21)
        Me.fecImpresionGuiaOrigenE.TabIndex = 18
        Me.fecImpresionGuiaOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'btnIngresoComplejoOrigenE
        '
        Appearance186.Image = 8
        Appearance186.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnIngresoComplejoOrigenE.Appearance = Appearance186
        Me.btnIngresoComplejoOrigenE.ImageList = Me.imagenes
        Me.btnIngresoComplejoOrigenE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnIngresoComplejoOrigenE.Location = New System.Drawing.Point(291, -1)
        Me.btnIngresoComplejoOrigenE.Name = "btnIngresoComplejoOrigenE"
        Me.btnIngresoComplejoOrigenE.Size = New System.Drawing.Size(40, 25)
        Me.btnIngresoComplejoOrigenE.TabIndex = 8
        '
        'hIngresoDestinoE
        '
        Me.hIngresoDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hIngresoDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hIngresoDestinoE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hIngresoDestinoE.Location = New System.Drawing.Point(625, 27)
        Me.hIngresoDestinoE.MaskInput = "{LOC}hh:mm"
        Me.hIngresoDestinoE.Name = "hIngresoDestinoE"
        Me.hIngresoDestinoE.Nullable = False
        Me.hIngresoDestinoE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hIngresoDestinoE.Size = New System.Drawing.Size(55, 21)
        Me.hIngresoDestinoE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hIngresoDestinoE.TabIndex = 43
        Me.hIngresoDestinoE.Tag = ""
        Me.hIngresoDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'btnImpresionGuiaOrigenE
        '
        Appearance187.Image = 8
        Appearance187.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnImpresionGuiaOrigenE.Appearance = Appearance187
        Me.btnImpresionGuiaOrigenE.ImageList = Me.imagenes
        Me.btnImpresionGuiaOrigenE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnImpresionGuiaOrigenE.Location = New System.Drawing.Point(291, 74)
        Me.btnImpresionGuiaOrigenE.Name = "btnImpresionGuiaOrigenE"
        Me.btnImpresionGuiaOrigenE.Size = New System.Drawing.Size(40, 25)
        Me.btnImpresionGuiaOrigenE.TabIndex = 20
        '
        'btnTerminoCargaOrigenE
        '
        Appearance188.Image = 8
        Appearance188.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnTerminoCargaOrigenE.Appearance = Appearance188
        Me.btnTerminoCargaOrigenE.ImageList = Me.imagenes
        Me.btnTerminoCargaOrigenE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnTerminoCargaOrigenE.Location = New System.Drawing.Point(291, 49)
        Me.btnTerminoCargaOrigenE.Name = "btnTerminoCargaOrigenE"
        Me.btnTerminoCargaOrigenE.Size = New System.Drawing.Size(40, 25)
        Me.btnTerminoCargaOrigenE.TabIndex = 16
        '
        'hTerminoDescargaDestinoE
        '
        Me.hTerminoDescargaDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hTerminoDescargaDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hTerminoDescargaDestinoE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hTerminoDescargaDestinoE.Location = New System.Drawing.Point(625, 77)
        Me.hTerminoDescargaDestinoE.MaskInput = "{LOC}hh:mm"
        Me.hTerminoDescargaDestinoE.Name = "hTerminoDescargaDestinoE"
        Me.hTerminoDescargaDestinoE.Nullable = False
        Me.hTerminoDescargaDestinoE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hTerminoDescargaDestinoE.Size = New System.Drawing.Size(55, 21)
        Me.hTerminoDescargaDestinoE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hTerminoDescargaDestinoE.TabIndex = 53
        Me.hTerminoDescargaDestinoE.Tag = ""
        Me.hTerminoDescargaDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'btnCargaOrigenE
        '
        Appearance189.Image = 8
        Appearance189.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnCargaOrigenE.Appearance = Appearance189
        Me.btnCargaOrigenE.ImageList = Me.imagenes
        Me.btnCargaOrigenE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnCargaOrigenE.Location = New System.Drawing.Point(291, 24)
        Me.btnCargaOrigenE.Name = "btnCargaOrigenE"
        Me.btnCargaOrigenE.Size = New System.Drawing.Size(40, 25)
        Me.btnCargaOrigenE.TabIndex = 12
        '
        'hDescargaDestinoE
        '
        Me.hDescargaDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hDescargaDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hDescargaDestinoE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hDescargaDestinoE.Location = New System.Drawing.Point(625, 52)
        Me.hDescargaDestinoE.MaskInput = "{LOC}hh:mm"
        Me.hDescargaDestinoE.Name = "hDescargaDestinoE"
        Me.hDescargaDestinoE.Nullable = False
        Me.hDescargaDestinoE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hDescargaDestinoE.Size = New System.Drawing.Size(55, 21)
        Me.hDescargaDestinoE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hDescargaDestinoE.TabIndex = 48
        Me.hDescargaDestinoE.Tag = ""
        Me.hDescargaDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'hTerminoCargaOrigenE
        '
        Me.hTerminoCargaOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hTerminoCargaOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hTerminoCargaOrigenE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hTerminoCargaOrigenE.Location = New System.Drawing.Point(225, 51)
        Me.hTerminoCargaOrigenE.MaskInput = "{LOC}hh:mm"
        Me.hTerminoCargaOrigenE.Name = "hTerminoCargaOrigenE"
        Me.hTerminoCargaOrigenE.Nullable = False
        Me.hTerminoCargaOrigenE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hTerminoCargaOrigenE.Size = New System.Drawing.Size(55, 21)
        Me.hTerminoCargaOrigenE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hTerminoCargaOrigenE.TabIndex = 15
        Me.hTerminoCargaOrigenE.Tag = ""
        Me.hTerminoCargaOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'hImpresionGuiaOrigenE
        '
        Me.hImpresionGuiaOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hImpresionGuiaOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hImpresionGuiaOrigenE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hImpresionGuiaOrigenE.Location = New System.Drawing.Point(225, 76)
        Me.hImpresionGuiaOrigenE.MaskInput = "{LOC}hh:mm"
        Me.hImpresionGuiaOrigenE.Name = "hImpresionGuiaOrigenE"
        Me.hImpresionGuiaOrigenE.Nullable = False
        Me.hImpresionGuiaOrigenE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hImpresionGuiaOrigenE.Size = New System.Drawing.Size(55, 21)
        Me.hImpresionGuiaOrigenE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hImpresionGuiaOrigenE.TabIndex = 19
        Me.hImpresionGuiaOrigenE.Tag = ""
        Me.hImpresionGuiaOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'btnIngresoDestinoE
        '
        Appearance190.Image = 8
        Appearance190.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnIngresoDestinoE.Appearance = Appearance190
        Me.btnIngresoDestinoE.ImageList = Me.imagenes
        Me.btnIngresoDestinoE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnIngresoDestinoE.Location = New System.Drawing.Point(691, 25)
        Me.btnIngresoDestinoE.Name = "btnIngresoDestinoE"
        Me.btnIngresoDestinoE.Size = New System.Drawing.Size(40, 25)
        Me.btnIngresoDestinoE.TabIndex = 44
        '
        'hCargaOrigenE
        '
        Me.hCargaOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hCargaOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hCargaOrigenE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hCargaOrigenE.Location = New System.Drawing.Point(225, 26)
        Me.hCargaOrigenE.MaskInput = "{LOC}hh:mm"
        Me.hCargaOrigenE.Name = "hCargaOrigenE"
        Me.hCargaOrigenE.Nullable = False
        Me.hCargaOrigenE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hCargaOrigenE.Size = New System.Drawing.Size(55, 21)
        Me.hCargaOrigenE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hCargaOrigenE.TabIndex = 11
        Me.hCargaOrigenE.Tag = ""
        Me.hCargaOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'btnDescargaDestinoE
        '
        Appearance191.Image = 8
        Appearance191.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnDescargaDestinoE.Appearance = Appearance191
        Me.btnDescargaDestinoE.ImageList = Me.imagenes
        Me.btnDescargaDestinoE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnDescargaDestinoE.Location = New System.Drawing.Point(691, 50)
        Me.btnDescargaDestinoE.Name = "btnDescargaDestinoE"
        Me.btnDescargaDestinoE.Size = New System.Drawing.Size(40, 25)
        Me.btnDescargaDestinoE.TabIndex = 49
        '
        'hIngresoComplejoOrigenE
        '
        Me.hIngresoComplejoOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hIngresoComplejoOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hIngresoComplejoOrigenE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hIngresoComplejoOrigenE.Location = New System.Drawing.Point(225, 1)
        Me.hIngresoComplejoOrigenE.MaskInput = "{LOC}hh:mm"
        Me.hIngresoComplejoOrigenE.Name = "hIngresoComplejoOrigenE"
        Me.hIngresoComplejoOrigenE.Nullable = False
        Me.hIngresoComplejoOrigenE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hIngresoComplejoOrigenE.Size = New System.Drawing.Size(55, 21)
        Me.hIngresoComplejoOrigenE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hIngresoComplejoOrigenE.TabIndex = 7
        Me.hIngresoComplejoOrigenE.Tag = ""
        Me.hIngresoComplejoOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'btnTerminoDescargaDestinoE
        '
        Appearance192.Image = 8
        Appearance192.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnTerminoDescargaDestinoE.Appearance = Appearance192
        Me.btnTerminoDescargaDestinoE.ImageList = Me.imagenes
        Me.btnTerminoDescargaDestinoE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnTerminoDescargaDestinoE.Location = New System.Drawing.Point(691, 75)
        Me.btnTerminoDescargaDestinoE.Name = "btnTerminoDescargaDestinoE"
        Me.btnTerminoDescargaDestinoE.Size = New System.Drawing.Size(40, 25)
        Me.btnTerminoDescargaDestinoE.TabIndex = 54
        '
        'verTerminoCargaOrigenE
        '
        Appearance193.ForeColor = System.Drawing.Color.Navy
        Me.verTerminoCargaOrigenE.Appearance = Appearance193
        Me.verTerminoCargaOrigenE.Enabled = False
        Me.verTerminoCargaOrigenE.Location = New System.Drawing.Point(337, 52)
        Me.verTerminoCargaOrigenE.Name = "verTerminoCargaOrigenE"
        Me.verTerminoCargaOrigenE.Size = New System.Drawing.Size(39, 20)
        Me.verTerminoCargaOrigenE.TabIndex = 28
        Me.verTerminoCargaOrigenE.Text = "OK"
        '
        'verImpresionGuiaOrigenE
        '
        Appearance194.ForeColor = System.Drawing.Color.Navy
        Me.verImpresionGuiaOrigenE.Appearance = Appearance194
        Me.verImpresionGuiaOrigenE.Enabled = False
        Me.verImpresionGuiaOrigenE.Location = New System.Drawing.Point(337, 77)
        Me.verImpresionGuiaOrigenE.Name = "verImpresionGuiaOrigenE"
        Me.verImpresionGuiaOrigenE.Size = New System.Drawing.Size(39, 20)
        Me.verImpresionGuiaOrigenE.TabIndex = 29
        Me.verImpresionGuiaOrigenE.Text = "OK"
        '
        'verCargaOrigenE
        '
        Appearance195.ForeColor = System.Drawing.Color.Navy
        Me.verCargaOrigenE.Appearance = Appearance195
        Me.verCargaOrigenE.Enabled = False
        Me.verCargaOrigenE.Location = New System.Drawing.Point(337, 27)
        Me.verCargaOrigenE.Name = "verCargaOrigenE"
        Me.verCargaOrigenE.Size = New System.Drawing.Size(39, 20)
        Me.verCargaOrigenE.TabIndex = 27
        Me.verCargaOrigenE.Text = "OK"
        '
        'verIngresoComplejoOrigenE
        '
        Appearance196.ForeColor = System.Drawing.Color.Navy
        Me.verIngresoComplejoOrigenE.Appearance = Appearance196
        Me.verIngresoComplejoOrigenE.Enabled = False
        Me.verIngresoComplejoOrigenE.Location = New System.Drawing.Point(337, 2)
        Me.verIngresoComplejoOrigenE.Name = "verIngresoComplejoOrigenE"
        Me.verIngresoComplejoOrigenE.Size = New System.Drawing.Size(39, 20)
        Me.verIngresoComplejoOrigenE.TabIndex = 26
        Me.verIngresoComplejoOrigenE.Text = "OK"
        '
        'fecTerminoDescargaDestinoE
        '
        Me.fecTerminoDescargaDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecTerminoDescargaDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecTerminoDescargaDestinoE.Location = New System.Drawing.Point(529, 77)
        Me.fecTerminoDescargaDestinoE.MaskInput = ""
        Me.fecTerminoDescargaDestinoE.Name = "fecTerminoDescargaDestinoE"
        Me.fecTerminoDescargaDestinoE.Size = New System.Drawing.Size(90, 21)
        Me.fecTerminoDescargaDestinoE.TabIndex = 52
        Me.fecTerminoDescargaDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel39
        '
        Appearance197.BackColor = System.Drawing.Color.Transparent
        Appearance197.ForeColor = System.Drawing.Color.Navy
        Appearance197.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance197
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel39.Location = New System.Drawing.Point(439, 31)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(87, 14)
        Me.UltraLabel39.TabIndex = 41
        Me.UltraLabel39.Text = "Ingreso Destino:"
        '
        'UltraLabel37
        '
        Appearance198.BackColor = System.Drawing.Color.Transparent
        Appearance198.ForeColor = System.Drawing.Color.Navy
        Appearance198.TextVAlignAsString = "Middle"
        Me.UltraLabel37.Appearance = Appearance198
        Me.UltraLabel37.AutoSize = True
        Me.UltraLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel37.Location = New System.Drawing.Point(385, 81)
        Me.UltraLabel37.Name = "UltraLabel37"
        Me.UltraLabel37.Size = New System.Drawing.Size(142, 14)
        Me.UltraLabel37.TabIndex = 51
        Me.UltraLabel37.Text = "Termino Descarga Destino:"
        '
        'fecIngresoDestinoE
        '
        Me.fecIngresoDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecIngresoDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecIngresoDestinoE.Location = New System.Drawing.Point(529, 27)
        Me.fecIngresoDestinoE.MaskInput = ""
        Me.fecIngresoDestinoE.Name = "fecIngresoDestinoE"
        Me.fecIngresoDestinoE.Size = New System.Drawing.Size(90, 21)
        Me.fecIngresoDestinoE.TabIndex = 42
        Me.fecIngresoDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecDescargaDestinoE
        '
        Me.fecDescargaDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecDescargaDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDescargaDestinoE.Location = New System.Drawing.Point(529, 52)
        Me.fecDescargaDestinoE.MaskInput = ""
        Me.fecDescargaDestinoE.Name = "fecDescargaDestinoE"
        Me.fecDescargaDestinoE.Size = New System.Drawing.Size(90, 21)
        Me.fecDescargaDestinoE.TabIndex = 47
        Me.fecDescargaDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel38
        '
        Appearance199.BackColor = System.Drawing.Color.Transparent
        Appearance199.ForeColor = System.Drawing.Color.Navy
        Appearance199.TextVAlignAsString = "Middle"
        Me.UltraLabel38.Appearance = Appearance199
        Me.UltraLabel38.AutoSize = True
        Me.UltraLabel38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel38.Location = New System.Drawing.Point(399, 56)
        Me.UltraLabel38.Name = "UltraLabel38"
        Me.UltraLabel38.Size = New System.Drawing.Size(127, 14)
        Me.UltraLabel38.TabIndex = 5
        Me.UltraLabel38.Text = "Inicio Descarga Destino:"
        '
        'lbOrigenE
        '
        Appearance200.BackColor = System.Drawing.Color.Transparent
        Appearance200.ForeColor = System.Drawing.Color.Black
        Appearance200.TextVAlignAsString = "Middle"
        Me.lbOrigenE.Appearance = Appearance200
        Me.lbOrigenE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOrigenE.Location = New System.Drawing.Point(184, 1)
        Me.lbOrigenE.Name = "lbOrigenE"
        Me.lbOrigenE.Size = New System.Drawing.Size(250, 15)
        Me.lbOrigenE.TabIndex = 80
        Me.lbOrigenE.Text = "ORIGEN"
        '
        'lbDestinoE
        '
        Appearance201.BackColor = System.Drawing.Color.Transparent
        Appearance201.ForeColor = System.Drawing.Color.Black
        Appearance201.TextVAlignAsString = "Middle"
        Me.lbDestinoE.Appearance = Appearance201
        Me.lbDestinoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDestinoE.Location = New System.Drawing.Point(551, 1)
        Me.lbDestinoE.Name = "lbDestinoE"
        Me.lbDestinoE.Size = New System.Drawing.Size(250, 15)
        Me.lbDestinoE.TabIndex = 81
        Me.lbDestinoE.Text = "DESTINO"
        '
        'verSalidaDestinoE
        '
        Appearance202.ForeColor = System.Drawing.Color.Navy
        Me.verSalidaDestinoE.Appearance = Appearance202
        Me.verSalidaDestinoE.Enabled = False
        Me.verSalidaDestinoE.Location = New System.Drawing.Point(759, 158)
        Me.verSalidaDestinoE.Name = "verSalidaDestinoE"
        Me.verSalidaDestinoE.Size = New System.Drawing.Size(39, 20)
        Me.verSalidaDestinoE.TabIndex = 0
        Me.verSalidaDestinoE.Text = "OK"
        '
        'hSalidaDestinoE
        '
        Me.hSalidaDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hSalidaDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hSalidaDestinoE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hSalidaDestinoE.Location = New System.Drawing.Point(647, 158)
        Me.hSalidaDestinoE.MaskInput = "{LOC}hh:mm"
        Me.hSalidaDestinoE.Name = "hSalidaDestinoE"
        Me.hSalidaDestinoE.Nullable = False
        Me.hSalidaDestinoE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hSalidaDestinoE.Size = New System.Drawing.Size(55, 21)
        Me.hSalidaDestinoE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hSalidaDestinoE.TabIndex = 58
        Me.hSalidaDestinoE.Tag = ""
        Me.hSalidaDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'btnSalidaDestinoE
        '
        Appearance203.Image = 8
        Appearance203.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnSalidaDestinoE.Appearance = Appearance203
        Me.btnSalidaDestinoE.ImageList = Me.imagenes
        Me.btnSalidaDestinoE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnSalidaDestinoE.Location = New System.Drawing.Point(713, 156)
        Me.btnSalidaDestinoE.Name = "btnSalidaDestinoE"
        Me.btnSalidaDestinoE.Size = New System.Drawing.Size(40, 25)
        Me.btnSalidaDestinoE.TabIndex = 59
        '
        'fecSalidaDestinoE
        '
        Me.fecSalidaDestinoE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecSalidaDestinoE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecSalidaDestinoE.Location = New System.Drawing.Point(551, 158)
        Me.fecSalidaDestinoE.MaskInput = ""
        Me.fecSalidaDestinoE.Name = "fecSalidaDestinoE"
        Me.fecSalidaDestinoE.Size = New System.Drawing.Size(90, 21)
        Me.fecSalidaDestinoE.TabIndex = 57
        Me.fecSalidaDestinoE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'lblSalidaDestinoE
        '
        Appearance204.BackColor = System.Drawing.Color.Transparent
        Appearance204.ForeColor = System.Drawing.Color.Navy
        Appearance204.TextVAlignAsString = "Middle"
        Me.lblSalidaDestinoE.Appearance = Appearance204
        Me.lblSalidaDestinoE.AutoSize = True
        Me.lblSalidaDestinoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidaDestinoE.Location = New System.Drawing.Point(468, 164)
        Me.lblSalidaDestinoE.Name = "lblSalidaDestinoE"
        Me.lblSalidaDestinoE.Size = New System.Drawing.Size(80, 14)
        Me.lblSalidaDestinoE.TabIndex = 56
        Me.lblSalidaDestinoE.Text = "Salida Destino:"
        '
        'verLlegadaOrigenE
        '
        Appearance205.ForeColor = System.Drawing.Color.Navy
        Me.verLlegadaOrigenE.Appearance = Appearance205
        Me.verLlegadaOrigenE.Enabled = False
        Me.verLlegadaOrigenE.Location = New System.Drawing.Point(359, 22)
        Me.verLlegadaOrigenE.Name = "verLlegadaOrigenE"
        Me.verLlegadaOrigenE.Size = New System.Drawing.Size(39, 20)
        Me.verLlegadaOrigenE.TabIndex = 0
        Me.verLlegadaOrigenE.Text = "OK"
        '
        'verSalidaOrigenE
        '
        Appearance206.ForeColor = System.Drawing.Color.Navy
        Me.verSalidaOrigenE.Appearance = Appearance206
        Me.verSalidaOrigenE.Enabled = False
        Me.verSalidaOrigenE.Location = New System.Drawing.Point(359, 157)
        Me.verSalidaOrigenE.Name = "verSalidaOrigenE"
        Me.verSalidaOrigenE.Size = New System.Drawing.Size(39, 20)
        Me.verSalidaOrigenE.TabIndex = 30
        Me.verSalidaOrigenE.Text = "OK"
        '
        'hSalidaOrigenE
        '
        Me.hSalidaOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hSalidaOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hSalidaOrigenE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hSalidaOrigenE.Location = New System.Drawing.Point(247, 157)
        Me.hSalidaOrigenE.MaskInput = "{LOC}hh:mm"
        Me.hSalidaOrigenE.Name = "hSalidaOrigenE"
        Me.hSalidaOrigenE.Nullable = False
        Me.hSalidaOrigenE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hSalidaOrigenE.Size = New System.Drawing.Size(55, 21)
        Me.hSalidaOrigenE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hSalidaOrigenE.TabIndex = 23
        Me.hSalidaOrigenE.Tag = ""
        Me.hSalidaOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'hLlegadaOrigenE
        '
        Me.hLlegadaOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hLlegadaOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hLlegadaOrigenE.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hLlegadaOrigenE.Location = New System.Drawing.Point(247, 21)
        Me.hLlegadaOrigenE.MaskInput = "{LOC}hh:mm"
        Me.hLlegadaOrigenE.Name = "hLlegadaOrigenE"
        Me.hLlegadaOrigenE.Nullable = False
        Me.hLlegadaOrigenE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hLlegadaOrigenE.Size = New System.Drawing.Size(55, 21)
        Me.hLlegadaOrigenE.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hLlegadaOrigenE.TabIndex = 3
        Me.hLlegadaOrigenE.Tag = ""
        Me.hLlegadaOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'btnSalidaOrigenE
        '
        Appearance207.Image = 8
        Appearance207.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnSalidaOrigenE.Appearance = Appearance207
        Me.btnSalidaOrigenE.ImageList = Me.imagenes
        Me.btnSalidaOrigenE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnSalidaOrigenE.Location = New System.Drawing.Point(313, 155)
        Me.btnSalidaOrigenE.Name = "btnSalidaOrigenE"
        Me.btnSalidaOrigenE.Size = New System.Drawing.Size(40, 25)
        Me.btnSalidaOrigenE.TabIndex = 24
        '
        'btnLlegadaOrigenE
        '
        Appearance208.Image = 8
        Appearance208.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnLlegadaOrigenE.Appearance = Appearance208
        Me.btnLlegadaOrigenE.ImageList = Me.imagenes
        Me.btnLlegadaOrigenE.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnLlegadaOrigenE.Location = New System.Drawing.Point(313, 20)
        Me.btnLlegadaOrigenE.Name = "btnLlegadaOrigenE"
        Me.btnLlegadaOrigenE.Size = New System.Drawing.Size(40, 25)
        Me.btnLlegadaOrigenE.TabIndex = 4
        '
        'fecSalidaOrigenE
        '
        Me.fecSalidaOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecSalidaOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecSalidaOrigenE.Location = New System.Drawing.Point(151, 157)
        Me.fecSalidaOrigenE.MaskInput = ""
        Me.fecSalidaOrigenE.Name = "fecSalidaOrigenE"
        Me.fecSalidaOrigenE.Size = New System.Drawing.Size(90, 21)
        Me.fecSalidaOrigenE.TabIndex = 22
        Me.fecSalidaOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel16
        '
        Appearance209.BackColor = System.Drawing.Color.Transparent
        Appearance209.ForeColor = System.Drawing.Color.Navy
        Appearance209.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance209
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(72, 163)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel16.TabIndex = 21
        Me.UltraLabel16.Text = "Salida Origen:"
        '
        'fecLlegadaOrigenE
        '
        Me.fecLlegadaOrigenE.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecLlegadaOrigenE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecLlegadaOrigenE.Location = New System.Drawing.Point(151, 21)
        Me.fecLlegadaOrigenE.MaskInput = ""
        Me.fecLlegadaOrigenE.Name = "fecLlegadaOrigenE"
        Me.fecLlegadaOrigenE.Size = New System.Drawing.Size(90, 21)
        Me.fecLlegadaOrigenE.TabIndex = 2
        Me.fecLlegadaOrigenE.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel35
        '
        Appearance210.BackColor = System.Drawing.Color.Transparent
        Appearance210.ForeColor = System.Drawing.Color.Navy
        Appearance210.TextVAlignAsString = "Middle"
        Me.UltraLabel35.Appearance = Appearance210
        Me.UltraLabel35.AutoSize = True
        Me.UltraLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel35.Location = New System.Drawing.Point(63, 27)
        Me.UltraLabel35.Name = "UltraLabel35"
        Me.UltraLabel35.Size = New System.Drawing.Size(85, 14)
        Me.UltraLabel35.TabIndex = 1
        Me.UltraLabel35.Text = "Llegada Origen:"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griListadoTanqueo)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1074, 266)
        '
        'griListadoTanqueo
        '
        Me.griListadoTanqueo.AllowDrop = True
        Me.griListadoTanqueo.ContextMenuStrip = Me.MenuCombustible
        Me.griListadoTanqueo.DataSource = Me.odRegistroConsCombustible
        UltraGridColumn505.Header.VisiblePosition = 0
        UltraGridColumn505.Hidden = True
        UltraGridColumn506.Header.VisiblePosition = 1
        UltraGridColumn506.Hidden = True
        UltraGridColumn506.Width = 90
        UltraGridColumn507.Header.VisiblePosition = 2
        UltraGridColumn508.Header.VisiblePosition = 3
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn505, UltraGridColumn506, UltraGridColumn507, UltraGridColumn508})
        UltraGridBand8.SummaryFooterCaption = "Totales:"
        UltraGridColumn509.Header.VisiblePosition = 0
        UltraGridColumn510.Header.VisiblePosition = 1
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn509, UltraGridColumn510})
        UltraGridBand9.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand9.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.HeaderIcons
        UltraGridBand9.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        Me.griListadoTanqueo.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griListadoTanqueo.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griListadoTanqueo.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.griListadoTanqueo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListadoTanqueo.DisplayLayout.MaxColScrollRegions = 1
        Me.griListadoTanqueo.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListadoTanqueo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListadoTanqueo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListadoTanqueo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListadoTanqueo.DisplayLayout.Override.CellPadding = 0
        Me.griListadoTanqueo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListadoTanqueo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListadoTanqueo.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griListadoTanqueo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListadoTanqueo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListadoTanqueo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListadoTanqueo.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griListadoTanqueo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListadoTanqueo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListadoTanqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListadoTanqueo.ImageList = Me.imagenes
        Me.griListadoTanqueo.Location = New System.Drawing.Point(0, 0)
        Me.griListadoTanqueo.Name = "griListadoTanqueo"
        Me.griListadoTanqueo.Size = New System.Drawing.Size(1074, 266)
        Me.griListadoTanqueo.TabIndex = 1
        Me.griListadoTanqueo.Tag = ""
        '
        'MenuCombustible
        '
        Me.MenuCombustible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuCombustible.ForeColor = System.Drawing.Color.Black
        Me.MenuCombustible.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.Actualizar, Me.Eliminar})
        Me.MenuCombustible.Name = "MenuContextual1"
        Me.MenuCombustible.Size = New System.Drawing.Size(121, 70)
        '
        'Nuevo
        '
        Me.Nuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(120, 22)
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.ToolTipText = "Insertar"
        '
        'Actualizar
        '
        Me.Actualizar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(120, 22)
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.ToolTipText = "Actualizar o modificar"
        '
        'Eliminar
        '
        Me.Eliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(120, 22)
        Me.Eliminar.Text = "Eliminar"
        '
        'odRegistroConsCombustible
        '
        UltraDataBand1.ChildBands.AddRange(New Object() {UltraDataBand2})
        UltraDataColumn170.DataType = GetType(Date)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn170})
        Me.odRegistroConsCombustible.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        Me.odRegistroConsCombustible.Band.Columns.AddRange(New Object() {UltraDataColumn171, UltraDataColumn172, UltraDataColumn173})
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.ugb_Espera)
        Me.UltraTabPageControl8.Controls.Add(Me.gridImportar)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1080, 467)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(335, 54)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 17
        Me.ugb_Espera.Visible = False
        '
        'gridImportar
        '
        Me.gridImportar.ContextMenuStrip = Me.Menu
        Me.gridImportar.DataSource = Me.ogdListaSeguimiento
        UltraGridColumn161.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn161.Header.Fixed = True
        UltraGridColumn161.Header.VisiblePosition = 0
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn162.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance213.TextHAlignAsString = "Center"
        Appearance213.TextVAlignAsString = "Middle"
        UltraGridColumn162.CellAppearance = Appearance213
        UltraGridColumn162.Header.Fixed = True
        UltraGridColumn162.Header.VisiblePosition = 1
        UltraGridColumn162.Hidden = True
        UltraGridColumn162.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn162.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn162.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn162.Width = 95
        UltraGridColumn163.Header.Fixed = True
        UltraGridColumn163.Header.VisiblePosition = 2
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.Caption = "Viaje"
        UltraGridColumn164.Header.Fixed = True
        UltraGridColumn164.Header.VisiblePosition = 4
        UltraGridColumn164.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn164.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn164.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn164.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn164.Width = 95
        UltraGridColumn165.Header.Fixed = True
        UltraGridColumn165.Header.VisiblePosition = 6
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 11
        UltraGridColumn166.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn166.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn166.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn166.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn166.Width = 113
        UltraGridColumn167.Header.VisiblePosition = 12
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 13
        UltraGridColumn168.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn168.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn168.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn168.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn168.Width = 109
        UltraGridColumn169.Header.VisiblePosition = 14
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 15
        UltraGridColumn170.Hidden = True
        UltraGridColumn170.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn170.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn170.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn170.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn170.Width = 124
        UltraGridColumn171.Header.Caption = "Vacio"
        UltraGridColumn171.Header.VisiblePosition = 52
        UltraGridColumn171.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn171.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn171.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn171.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn171.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn171.Width = 32
        UltraGridColumn172.Header.VisiblePosition = 16
        UltraGridColumn172.Hidden = True
        Appearance214.Image = 7
        UltraGridColumn173.CellAppearance = Appearance214
        Appearance215.Image = 3
        UltraGridColumn173.CellButtonAppearance = Appearance215
        UltraGridColumn173.Header.VisiblePosition = 17
        UltraGridColumn173.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn173.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn173.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn173.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn173.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn173.Width = 150
        UltraGridColumn174.Header.VisiblePosition = 18
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.Header.VisiblePosition = 19
        UltraGridColumn175.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn175.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn175.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn175.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn175.Width = 150
        UltraGridColumn176.Header.VisiblePosition = 23
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 24
        UltraGridColumn177.Hidden = True
        UltraGridColumn178.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn178.Header.Fixed = True
        UltraGridColumn178.Header.VisiblePosition = 7
        UltraGridColumn178.Hidden = True
        Appearance216.TextHAlignAsString = "Left"
        Appearance216.TextVAlignAsString = "Middle"
        UltraGridColumn179.CellAppearance = Appearance216
        UltraGridColumn179.Header.Fixed = True
        UltraGridColumn179.Header.VisiblePosition = 8
        UltraGridColumn179.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn179.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn179.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn179.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn179.Width = 80
        UltraGridColumn180.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn180.Header.Fixed = True
        UltraGridColumn180.Header.VisiblePosition = 9
        UltraGridColumn180.Hidden = True
        Appearance217.TextHAlignAsString = "Left"
        Appearance217.TextVAlignAsString = "Middle"
        UltraGridColumn181.CellAppearance = Appearance217
        UltraGridColumn181.Header.Fixed = True
        UltraGridColumn181.Header.VisiblePosition = 10
        UltraGridColumn181.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn181.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn181.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn181.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn181.Width = 71
        UltraGridColumn182.Header.VisiblePosition = 27
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 25
        UltraGridColumn183.Hidden = True
        UltraGridColumn184.Header.VisiblePosition = 26
        UltraGridColumn184.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn184.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn184.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn184.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn184.Width = 100
        UltraGridColumn185.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn185.Header.Caption = "FechaAtencion"
        UltraGridColumn185.Header.Fixed = True
        UltraGridColumn185.Header.VisiblePosition = 5
        UltraGridColumn185.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn185.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn185.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn185.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn185.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn185.Width = 100
        UltraGridColumn186.Header.Caption = "UsuarioCrea"
        UltraGridColumn186.Header.VisiblePosition = 44
        UltraGridColumn186.Hidden = True
        UltraGridColumn186.Width = 150
        UltraGridColumn187.Header.VisiblePosition = 28
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn188.Header.Caption = "Valida"
        UltraGridColumn188.Header.Fixed = True
        UltraGridColumn188.Header.VisiblePosition = 3
        UltraGridColumn188.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn188.Width = 35
        UltraGridColumn189.Header.VisiblePosition = 29
        UltraGridColumn189.Hidden = True
        UltraGridColumn190.Header.VisiblePosition = 51
        UltraGridColumn190.Width = 100
        UltraGridColumn191.Header.VisiblePosition = 30
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 31
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.VisiblePosition = 32
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 22
        UltraGridColumn194.Width = 200
        UltraGridColumn195.Header.VisiblePosition = 33
        UltraGridColumn195.Hidden = True
        UltraGridColumn196.Header.VisiblePosition = 34
        UltraGridColumn196.Hidden = True
        UltraGridColumn197.Header.VisiblePosition = 35
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.Header.VisiblePosition = 45
        UltraGridColumn198.Width = 150
        UltraGridColumn199.Header.Caption = "UsuarioOperacion"
        UltraGridColumn199.Header.VisiblePosition = 46
        UltraGridColumn199.Width = 150
        UltraGridColumn200.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn200.Header.VisiblePosition = 36
        UltraGridColumn200.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn200.Width = 100
        UltraGridColumn201.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn201.Header.VisiblePosition = 37
        UltraGridColumn201.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn201.Width = 100
        UltraGridColumn202.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn202.Header.VisiblePosition = 38
        UltraGridColumn202.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn202.Width = 100
        UltraGridColumn203.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn203.Header.VisiblePosition = 39
        UltraGridColumn203.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn203.Width = 100
        UltraGridColumn204.Header.VisiblePosition = 50
        UltraGridColumn204.Width = 100
        UltraGridColumn205.Header.VisiblePosition = 48
        UltraGridColumn205.Width = 250
        Appearance218.Image = 3
        Appearance218.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn206.CellAppearance = Appearance218
        Appearance219.Image = 1
        UltraGridColumn206.CellButtonAppearance = Appearance219
        UltraGridColumn206.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn206.Header.VisiblePosition = 47
        UltraGridColumn206.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn206.Width = 250
        UltraGridColumn207.Header.VisiblePosition = 53
        UltraGridColumn207.Width = 35
        UltraGridColumn208.Header.Caption = "D/N"
        UltraGridColumn208.Header.VisiblePosition = 54
        UltraGridColumn208.Width = 35
        Appearance220.TextHAlignAsString = "Right"
        UltraGridColumn209.CellAppearance = Appearance220
        UltraGridColumn209.Header.Caption = "TN"
        UltraGridColumn209.Header.VisiblePosition = 21
        UltraGridColumn209.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn209.Width = 40
        UltraGridColumn210.Header.VisiblePosition = 49
        UltraGridColumn210.Width = 100
        UltraGridColumn211.Header.Caption = "KmTracto O"
        UltraGridColumn211.Header.VisiblePosition = 40
        UltraGridColumn211.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn211.Width = 70
        UltraGridColumn212.Header.Caption = "KmTracto D"
        UltraGridColumn212.Header.VisiblePosition = 41
        UltraGridColumn212.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn212.Width = 70
        UltraGridColumn213.Header.Caption = "KmCarreta O"
        UltraGridColumn213.Header.VisiblePosition = 42
        UltraGridColumn213.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn213.Width = 70
        UltraGridColumn214.Header.Caption = "KmCarreta D"
        UltraGridColumn214.Header.VisiblePosition = 43
        UltraGridColumn214.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn214.Width = 70
        UltraGridColumn215.Header.VisiblePosition = 55
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.VisiblePosition = 20
        UltraGridColumn216.Width = 100
        UltraGridColumn217.Header.VisiblePosition = 56
        UltraGridColumn217.Hidden = True
        UltraGridColumn218.Header.VisiblePosition = 57
        UltraGridColumn218.Hidden = True
        UltraGridColumn219.Header.VisiblePosition = 58
        UltraGridColumn219.Hidden = True
        UltraGridColumn219.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn220.Header.VisiblePosition = 59
        UltraGridColumn220.Hidden = True
        UltraGridColumn220.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn221.Header.VisiblePosition = 60
        UltraGridColumn221.Hidden = True
        UltraGridColumn221.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn222.Header.VisiblePosition = 61
        UltraGridColumn222.Hidden = True
        UltraGridColumn222.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn223.Header.VisiblePosition = 62
        UltraGridColumn223.Hidden = True
        UltraGridColumn223.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn224.Header.VisiblePosition = 63
        UltraGridColumn224.Hidden = True
        UltraGridColumn224.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn225.Header.VisiblePosition = 64
        UltraGridColumn225.Hidden = True
        UltraGridColumn225.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn226.Header.VisiblePosition = 65
        UltraGridColumn226.Hidden = True
        UltraGridColumn226.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn227.Header.VisiblePosition = 66
        UltraGridColumn227.Hidden = True
        UltraGridColumn228.Header.VisiblePosition = 67
        UltraGridColumn228.Hidden = True
        UltraGridColumn229.Header.VisiblePosition = 68
        UltraGridColumn229.Hidden = True
        UltraGridColumn230.Header.VisiblePosition = 70
        UltraGridColumn231.Header.VisiblePosition = 71
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.VisiblePosition = 72
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.Header.Caption = "Retorno"
        UltraGridColumn233.Header.VisiblePosition = 69
        UltraGridColumn233.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn233.Width = 40
        UltraGridColumn234.Header.VisiblePosition = 73
        UltraGridColumn235.Header.VisiblePosition = 74
        UltraGridColumn236.Header.VisiblePosition = 75
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.VisiblePosition = 76
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.Header.VisiblePosition = 77
        UltraGridColumn238.Hidden = True
        UltraGridColumn239.Header.VisiblePosition = 78
        UltraGridColumn239.Hidden = True
        UltraGridColumn243.Header.VisiblePosition = 79
        UltraGridColumn246.Header.VisiblePosition = 80
        UltraGridColumn240.Header.VisiblePosition = 81
        UltraGridColumn240.Hidden = True
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn243, UltraGridColumn246, UltraGridColumn240})
        UltraGridBand11.GroupHeadersVisible = False
        UltraGridBand11.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridImportar.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.gridImportar.DisplayLayout.MaxColScrollRegions = 1
        Me.gridImportar.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridImportar.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridImportar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridImportar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridImportar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridImportar.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridImportar.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridImportar.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.gridImportar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridImportar.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridImportar.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridImportar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridImportar.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridImportar.DisplayLayout.UseFixedHeaders = True
        Me.gridImportar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridImportar.ImageList = Me.imagenes
        Me.gridImportar.Location = New System.Drawing.Point(0, 0)
        Me.gridImportar.Name = "gridImportar"
        Me.gridImportar.Size = New System.Drawing.Size(1080, 467)
        Me.gridImportar.TabIndex = 0
        Me.gridImportar.Tag = ""
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.AutoScroll = True
        Me.UltraTabPageControl7.Controls.Add(Me.tabListado)
        Me.UltraTabPageControl7.Controls.Add(Me.gruopExpanUnidadesSinReportar)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1082, 588)
        '
        'tabListado
        '
        Me.tabListado.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.tabListado.Controls.Add(Me.tapViajes)
        Me.tabListado.Controls.Add(Me.tapAlertaViajes)
        Me.tabListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabListado.Location = New System.Drawing.Point(0, 120)
        Me.tabListado.Name = "tabListado"
        Me.tabListado.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.tabListado.Size = New System.Drawing.Size(1054, 468)
        Me.tabListado.TabIndex = 3
        UltraTab2.TabPage = Me.tapViajes
        UltraTab2.Text = "Viajes"
        UltraTab3.TabPage = Me.tapAlertaViajes
        UltraTab3.Text = "Alerta Viajes"
        Me.tabListado.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab3})
        Me.tabListado.TabStop = False
        Me.tabListado.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1052, 445)
        '
        'gruopExpanUnidadesSinReportar
        '
        Me.gruopExpanUnidadesSinReportar.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.RectangularSolid
        Me.gruopExpanUnidadesSinReportar.Controls.Add(Me.UltraExpandableGroupBoxPanel8)
        Me.gruopExpanUnidadesSinReportar.Dock = System.Windows.Forms.DockStyle.Right
        Me.gruopExpanUnidadesSinReportar.Expanded = False
        Me.gruopExpanUnidadesSinReportar.ExpandedSize = New System.Drawing.Size(250, 468)
        Me.gruopExpanUnidadesSinReportar.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.gruopExpanUnidadesSinReportar.Location = New System.Drawing.Point(1054, 120)
        Me.gruopExpanUnidadesSinReportar.Name = "gruopExpanUnidadesSinReportar"
        Me.gruopExpanUnidadesSinReportar.Size = New System.Drawing.Size(28, 468)
        Me.gruopExpanUnidadesSinReportar.TabIndex = 2
        Me.gruopExpanUnidadesSinReportar.Text = "Unidades Sin Reportar ALERTA"
        Me.gruopExpanUnidadesSinReportar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel8
        '
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.gridUnidadesSinReportar)
        Me.UltraExpandableGroupBoxPanel8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel8.Name = "UltraExpandableGroupBoxPanel8"
        Me.UltraExpandableGroupBoxPanel8.Size = New System.Drawing.Size(224, 464)
        Me.UltraExpandableGroupBoxPanel8.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel8.Visible = False
        '
        'gridUnidadesSinReportar
        '
        Me.gridUnidadesSinReportar.ContextMenuStrip = Me.Menu
        Me.gridUnidadesSinReportar.DataSource = Me.ogdUnidadesSinReportar
        UltraGridColumn416.Header.Caption = "Cant."
        UltraGridColumn416.Header.Fixed = True
        UltraGridColumn416.Header.VisiblePosition = 0
        UltraGridColumn416.Width = 30
        UltraGridColumn417.Header.Caption = "UNIDAD"
        UltraGridColumn417.Header.VisiblePosition = 1
        UltraGridColumn417.Width = 50
        UltraGridColumn418.Header.Caption = "FLOTA"
        UltraGridColumn418.Header.VisiblePosition = 2
        UltraGridColumn418.Width = 90
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn416, UltraGridColumn417, UltraGridColumn418})
        UltraGridBand5.GroupHeadersVisible = False
        UltraGridBand5.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridUnidadesSinReportar.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.gridUnidadesSinReportar.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridUnidadesSinReportar.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridUnidadesSinReportar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridUnidadesSinReportar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridUnidadesSinReportar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridUnidadesSinReportar.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridUnidadesSinReportar.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridUnidadesSinReportar.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.gridUnidadesSinReportar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridUnidadesSinReportar.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridUnidadesSinReportar.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridUnidadesSinReportar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridUnidadesSinReportar.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridUnidadesSinReportar.DisplayLayout.UseFixedHeaders = True
        Me.gridUnidadesSinReportar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridUnidadesSinReportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridUnidadesSinReportar.ImageList = Me.imagenes
        Me.gridUnidadesSinReportar.Location = New System.Drawing.Point(0, 0)
        Me.gridUnidadesSinReportar.Name = "gridUnidadesSinReportar"
        Me.gridUnidadesSinReportar.Size = New System.Drawing.Size(224, 464)
        Me.gridUnidadesSinReportar.TabIndex = 1
        Me.gridUnidadesSinReportar.Tag = ""
        '
        'ogdUnidadesSinReportar
        '
        Me.ogdUnidadesSinReportar.Band.Columns.AddRange(New Object() {UltraDataColumn120, UltraDataColumn121, UltraDataColumn122})
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.UltraExpandableGroupBox7)
        Me.agrBusqueda.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1082, 120)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Busqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBox7
        '
        Appearance39.BackColor = System.Drawing.Color.White
        Appearance39.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox7.ContentAreaAppearance = Appearance39
        Me.UltraExpandableGroupBox7.Controls.Add(Me.UltraExpandableGroupBoxPanel15)
        Me.UltraExpandableGroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox7.ExpandedSize = New System.Drawing.Size(883, 100)
        Me.UltraExpandableGroupBox7.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox7.Location = New System.Drawing.Point(196, 17)
        Me.UltraExpandableGroupBox7.Name = "UltraExpandableGroupBox7"
        Me.UltraExpandableGroupBox7.Size = New System.Drawing.Size(883, 100)
        Me.UltraExpandableGroupBox7.TabIndex = 53
        Me.UltraExpandableGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel15
        '
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.UltraLabel6)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.UltraLabel5)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.numOPSinReportar)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.btnSinReportarUnidades)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.grupoEstado)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.grupoTipoVehiculo)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.colorCambio)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.Etiqueta45)
        Me.UltraExpandableGroupBoxPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel15.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel15.Name = "UltraExpandableGroupBoxPanel15"
        Me.UltraExpandableGroupBoxPanel15.Size = New System.Drawing.Size(862, 94)
        Me.UltraExpandableGroupBoxPanel15.TabIndex = 0
        '
        'UltraLabel6
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Appearance40.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance40
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(661, 33)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(32, 15)
        Me.UltraLabel6.TabIndex = 58
        Me.UltraLabel6.Text = "Oper."
        '
        'UltraLabel5
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Appearance41.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance41
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(577, 34)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel5.TabIndex = 57
        Me.UltraLabel5.Text = "Mayor a:"
        '
        'numOPSinReportar
        '
        Appearance42.TextHAlignAsString = "Right"
        Me.numOPSinReportar.Appearance = Appearance42
        Me.numOPSinReportar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numOPSinReportar.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numOPSinReportar.InputMask = "{LOC}nn"
        Me.numOPSinReportar.Location = New System.Drawing.Point(630, 31)
        Me.numOPSinReportar.Name = "numOPSinReportar"
        Me.numOPSinReportar.NonAutoSizeHeight = 20
        Me.numOPSinReportar.NullText = "0"
        Me.numOPSinReportar.Size = New System.Drawing.Size(30, 21)
        Me.numOPSinReportar.TabIndex = 56
        Me.numOPSinReportar.Text = "2"
        '
        'btnSinReportarUnidades
        '
        Appearance43.Image = 10
        Me.btnSinReportarUnidades.Appearance = Appearance43
        Me.btnSinReportarUnidades.ImageList = Me.imagenes
        Me.btnSinReportarUnidades.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSinReportarUnidades.Location = New System.Drawing.Point(576, 52)
        Me.btnSinReportarUnidades.Name = "btnSinReportarUnidades"
        Me.btnSinReportarUnidades.Size = New System.Drawing.Size(115, 41)
        Me.btnSinReportarUnidades.TabIndex = 55
        Me.btnSinReportarUnidades.Text = "Sin Reportar x Unidad (Alerta)"
        '
        'grupoEstado
        '
        Appearance44.BackColor = System.Drawing.Color.White
        Appearance44.BackColor2 = System.Drawing.Color.White
        Me.grupoEstado.ContentAreaAppearance = Appearance44
        Me.grupoEstado.Controls.Add(Me.ColorFin)
        Me.grupoEstado.Controls.Add(Me.ColorProgramado)
        Me.grupoEstado.Controls.Add(Me.ColorCarga)
        Me.grupoEstado.Controls.Add(Me.Etiqueta6)
        Me.grupoEstado.Controls.Add(Me.Etiqueta5)
        Me.grupoEstado.Controls.Add(Me.ColorTransito)
        Me.grupoEstado.Controls.Add(Me.Etiqueta7)
        Me.grupoEstado.Controls.Add(Me.ColorDescarga)
        Me.grupoEstado.Controls.Add(Me.Etiqueta4)
        Me.grupoEstado.Controls.Add(Me.Etiqueta3)
        Me.grupoEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoEstado.Location = New System.Drawing.Point(0, 69)
        Me.grupoEstado.Name = "grupoEstado"
        Me.grupoEstado.Size = New System.Drawing.Size(570, 25)
        Me.grupoEstado.TabIndex = 30
        UltraToolTipInfo1.ToolTipText = "Estado de un Viaje"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.grupoEstado, UltraToolTipInfo1)
        Me.grupoEstado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorFin
        '
        Me.ColorFin.Color = System.Drawing.Color.Lime
        Me.ColorFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFin.Location = New System.Drawing.Point(515, 3)
        Me.ColorFin.Name = "ColorFin"
        Me.ColorFin.Size = New System.Drawing.Size(43, 19)
        Me.ColorFin.TabIndex = 9
        Me.ColorFin.Text = "Lime"
        '
        'ColorProgramado
        '
        Me.ColorProgramado.Color = System.Drawing.Color.White
        Me.ColorProgramado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorProgramado.Location = New System.Drawing.Point(87, 3)
        Me.ColorProgramado.Name = "ColorProgramado"
        Me.ColorProgramado.Size = New System.Drawing.Size(44, 19)
        Me.ColorProgramado.TabIndex = 1
        Me.ColorProgramado.Text = "White"
        '
        'ColorCarga
        '
        Me.ColorCarga.Color = System.Drawing.Color.Yellow
        Me.ColorCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCarga.Location = New System.Drawing.Point(201, 3)
        Me.ColorCarga.Name = "ColorCarga"
        Me.ColorCarga.Size = New System.Drawing.Size(44, 19)
        Me.ColorCarga.TabIndex = 3
        Me.ColorCarga.Text = "Yellow"
        '
        'Etiqueta6
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance45
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(20, 7)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(68, 14)
        Me.Etiqueta6.TabIndex = 0
        Me.Etiqueta6.Text = "Programado:"
        '
        'Etiqueta5
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance46
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(163, 7)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Carga:"
        '
        'ColorTransito
        '
        Me.ColorTransito.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTransito.Location = New System.Drawing.Point(319, 3)
        Me.ColorTransito.Name = "ColorTransito"
        Me.ColorTransito.Size = New System.Drawing.Size(43, 19)
        Me.ColorTransito.TabIndex = 5
        Me.ColorTransito.Text = "Control"
        '
        'Etiqueta7
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance47
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(491, 7)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(22, 14)
        Me.Etiqueta7.TabIndex = 8
        Me.Etiqueta7.Text = "Fin:"
        '
        'ColorDescarga
        '
        Me.ColorDescarga.Color = System.Drawing.Color.Silver
        Me.ColorDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorDescarga.Location = New System.Drawing.Point(428, 3)
        Me.ColorDescarga.Name = "ColorDescarga"
        Me.ColorDescarga.Size = New System.Drawing.Size(43, 19)
        Me.ColorDescarga.TabIndex = 7
        Me.ColorDescarga.Text = "Silver"
        '
        'Etiqueta4
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance48
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(271, 7)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta4.TabIndex = 4
        Me.Etiqueta4.Text = "Transito:"
        '
        'Etiqueta3
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance49
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(373, 7)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta3.TabIndex = 6
        Me.Etiqueta3.Text = "Descarga:"
        '
        'grupoTipoVehiculo
        '
        Appearance50.BackColor = System.Drawing.Color.White
        Appearance50.BackColor2 = System.Drawing.Color.White
        Me.grupoTipoVehiculo.ContentAreaAppearance = Appearance50
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta47)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorParihuelero)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorPlataforma)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion20M3)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta29)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta28)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorTolvaVolteo)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta27)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta25)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion65M3)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorContenedor)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta222)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorGranelero)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorFurgon)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorFurgonLargo)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta24)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta30)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta21)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamioneta)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorVolquete)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta31)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta32)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta23)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion30M3)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta20)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta26)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCalicera)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion40M3)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta22)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorMediaBaranda)
        Me.grupoTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoTipoVehiculo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoTipoVehiculo.Location = New System.Drawing.Point(0, 0)
        Me.grupoTipoVehiculo.Name = "grupoTipoVehiculo"
        Me.grupoTipoVehiculo.Size = New System.Drawing.Size(570, 70)
        Me.grupoTipoVehiculo.TabIndex = 29
        UltraToolTipInfo2.ToolTipText = "Tipo Vehiculo (Modelo Funcional)"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.grupoTipoVehiculo, UltraToolTipInfo2)
        Me.grupoTipoVehiculo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta47
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta47.Appearance = Appearance51
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta47.Location = New System.Drawing.Point(253, 29)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta47.TabIndex = 72
        Me.Etiqueta47.Text = "Parihuelero:"
        '
        'ColorParihuelero
        '
        Me.ColorParihuelero.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorParihuelero.Location = New System.Drawing.Point(319, 25)
        Me.ColorParihuelero.Name = "ColorParihuelero"
        Me.ColorParihuelero.Size = New System.Drawing.Size(44, 19)
        Me.ColorParihuelero.TabIndex = 73
        Me.ColorParihuelero.Text = "Control"
        '
        'ColorPlataforma
        '
        Me.ColorPlataforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPlataforma.Location = New System.Drawing.Point(88, 6)
        Me.ColorPlataforma.Name = "ColorPlataforma"
        Me.ColorPlataforma.Size = New System.Drawing.Size(44, 19)
        Me.ColorPlataforma.TabIndex = 45
        Me.ColorPlataforma.Text = "Control"
        '
        'ColorCamion20M3
        '
        Me.ColorCamion20M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion20M3.Location = New System.Drawing.Point(515, 6)
        Me.ColorCamion20M3.Name = "ColorCamion20M3"
        Me.ColorCamion20M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion20M3.TabIndex = 61
        Me.ColorCamion20M3.Text = "Control"
        '
        'Etiqueta29
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance52
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta29.Location = New System.Drawing.Point(365, 29)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta29.TabIndex = 58
        Me.Etiqueta29.Text = "Camioneta:"
        '
        'Etiqueta28
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance53
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(156, 9)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta28.TabIndex = 48
        Me.Etiqueta28.Text = "Furgon:"
        '
        'ColorTolvaVolteo
        '
        Me.ColorTolvaVolteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTolvaVolteo.Location = New System.Drawing.Point(319, 44)
        Me.ColorTolvaVolteo.Name = "ColorTolvaVolteo"
        Me.ColorTolvaVolteo.Size = New System.Drawing.Size(44, 19)
        Me.ColorTolvaVolteo.TabIndex = 55
        Me.ColorTolvaVolteo.Text = "Control"
        '
        'Etiqueta27
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance54
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(374, 9)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta27.TabIndex = 46
        Me.Etiqueta27.Text = "Volquete:"
        '
        'Etiqueta25
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance55
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(260, 10)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta25.TabIndex = 52
        Me.Etiqueta25.Text = "Granelero:"
        '
        'ColorCamion65M3
        '
        Me.ColorCamion65M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion65M3.Location = New System.Drawing.Point(427, 44)
        Me.ColorCamion65M3.Name = "ColorCamion65M3"
        Me.ColorCamion65M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion65M3.TabIndex = 67
        Me.ColorCamion65M3.Text = "Control"
        '
        'ColorContenedor
        '
        Me.ColorContenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorContenedor.Location = New System.Drawing.Point(201, 44)
        Me.ColorContenedor.Name = "ColorContenedor"
        Me.ColorContenedor.Size = New System.Drawing.Size(44, 19)
        Me.ColorContenedor.TabIndex = 57
        Me.ColorContenedor.Text = "Control"
        '
        'Etiqueta222
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta222.Appearance = Appearance56
        Me.Etiqueta222.AutoSize = True
        Me.Etiqueta222.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta222.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta222.Location = New System.Drawing.Point(475, 9)
        Me.Etiqueta222.Name = "Etiqueta222"
        Me.Etiqueta222.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta222.TabIndex = 60
        Me.Etiqueta222.Text = "20 M3:"
        '
        'ColorGranelero
        '
        Me.ColorGranelero.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorGranelero.Location = New System.Drawing.Point(319, 6)
        Me.ColorGranelero.Name = "ColorGranelero"
        Me.ColorGranelero.Size = New System.Drawing.Size(44, 19)
        Me.ColorGranelero.TabIndex = 53
        Me.ColorGranelero.Text = "Control"
        '
        'ColorFurgon
        '
        Me.ColorFurgon.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgon.Location = New System.Drawing.Point(201, 6)
        Me.ColorFurgon.Name = "ColorFurgon"
        Me.ColorFurgon.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgon.TabIndex = 49
        Me.ColorFurgon.Text = "Control"
        '
        'ColorFurgonLargo
        '
        Me.ColorFurgonLargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonLargo.Location = New System.Drawing.Point(88, 25)
        Me.ColorFurgonLargo.Name = "ColorFurgonLargo"
        Me.ColorFurgonLargo.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonLargo.TabIndex = 69
        Me.ColorFurgonLargo.Text = "Control"
        '
        'Etiqueta24
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance57
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(26, 9)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta24.TabIndex = 44
        Me.Etiqueta24.Text = "Plataforma:"
        '
        'Etiqueta30
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance58
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta30.Location = New System.Drawing.Point(248, 47)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta30.TabIndex = 54
        Me.Etiqueta30.Text = "Tolva Volteo:"
        '
        'Etiqueta21
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance59
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(367, 48)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta21.TabIndex = 66
        Me.Etiqueta21.Text = "65 / 50 M3:"
        '
        'ColorCamioneta
        '
        Me.ColorCamioneta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamioneta.Location = New System.Drawing.Point(427, 25)
        Me.ColorCamioneta.Name = "ColorCamioneta"
        Me.ColorCamioneta.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamioneta.TabIndex = 59
        Me.ColorCamioneta.Text = "Control"
        '
        'ColorVolquete
        '
        Me.ColorVolquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorVolquete.Location = New System.Drawing.Point(427, 6)
        Me.ColorVolquete.Name = "ColorVolquete"
        Me.ColorVolquete.Size = New System.Drawing.Size(44, 19)
        Me.ColorVolquete.TabIndex = 47
        Me.ColorVolquete.Text = "Control"
        '
        'Etiqueta31
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance60
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Location = New System.Drawing.Point(13, 28)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta31.TabIndex = 56
        Me.Etiqueta31.Text = "Furgon Largo:"
        '
        'Etiqueta32
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance61
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(4, 47)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(84, 14)
        Me.Etiqueta32.TabIndex = 70
        Me.Etiqueta32.Text = "Media Baranda:"
        '
        'Etiqueta23
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance62
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(475, 47)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta23.TabIndex = 64
        Me.Etiqueta23.Text = "40 M3:"
        '
        'ColorCamion30M3
        '
        Me.ColorCamion30M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion30M3.Location = New System.Drawing.Point(515, 25)
        Me.ColorCamion30M3.Name = "ColorCamion30M3"
        Me.ColorCamion30M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion30M3.TabIndex = 63
        Me.ColorCamion30M3.Text = "Control"
        '
        'Etiqueta20
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance63
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(134, 47)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta20.TabIndex = 68
        Me.Etiqueta20.Text = "Contenedor:"
        '
        'Etiqueta26
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance64
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(150, 29)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta26.TabIndex = 50
        Me.Etiqueta26.Text = "Calicera:"
        '
        'ColorCalicera
        '
        Me.ColorCalicera.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCalicera.Location = New System.Drawing.Point(201, 25)
        Me.ColorCalicera.Name = "ColorCalicera"
        Me.ColorCalicera.Size = New System.Drawing.Size(44, 19)
        Me.ColorCalicera.TabIndex = 51
        Me.ColorCalicera.Text = "Control"
        '
        'ColorCamion40M3
        '
        Me.ColorCamion40M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion40M3.Location = New System.Drawing.Point(515, 44)
        Me.ColorCamion40M3.Name = "ColorCamion40M3"
        Me.ColorCamion40M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion40M3.TabIndex = 65
        Me.ColorCamion40M3.Text = "Control"
        '
        'Etiqueta22
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance65
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(475, 29)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta22.TabIndex = 62
        Me.Etiqueta22.Text = "30 M3:"
        '
        'ColorMediaBaranda
        '
        Me.ColorMediaBaranda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorMediaBaranda.Location = New System.Drawing.Point(88, 44)
        Me.ColorMediaBaranda.Name = "ColorMediaBaranda"
        Me.ColorMediaBaranda.Size = New System.Drawing.Size(44, 19)
        Me.ColorMediaBaranda.TabIndex = 71
        Me.ColorMediaBaranda.Text = "Control"
        '
        'colorCambio
        '
        Me.colorCambio.Color = System.Drawing.Color.Cyan
        Me.colorCambio.Location = New System.Drawing.Point(796, 21)
        Me.colorCambio.Name = "colorCambio"
        Me.colorCambio.Size = New System.Drawing.Size(44, 22)
        Me.colorCambio.TabIndex = 28
        Me.colorCambio.Text = "Cyan"
        '
        'Etiqueta45
        '
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(796, 4)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(61, 14)
        Me.Etiqueta45.TabIndex = 27
        Me.Etiqueta45.Text = "Actualizado"
        '
        'UltraExpandableGroupBox4
        '
        Appearance66.BackColor = System.Drawing.Color.White
        Appearance66.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox4.ContentAreaAppearance = Appearance66
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.UltraExpandableGroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(193, 100)
        Me.UltraExpandableGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(3, 17)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(193, 100)
        Me.UltraExpandableGroupBox4.TabIndex = 52
        Me.UltraExpandableGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel12
        '
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboTractoLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboCentro)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.verTracto)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraLabel46)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraGroupBox11)
        Me.UltraExpandableGroupBoxPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel12.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel12.Name = "UltraExpandableGroupBoxPanel12"
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(172, 94)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        '
        'cboTractoLista
        '
        Appearance67.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Appearance = Appearance67
        Me.cboTractoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoLista.DisplayMember = "Nombre"
        Me.cboTractoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoLista.Enabled = False
        Me.cboTractoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoLista.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Location = New System.Drawing.Point(61, 73)
        Me.cboTractoLista.Name = "cboTractoLista"
        Me.cboTractoLista.Size = New System.Drawing.Size(80, 21)
        Me.cboTractoLista.TabIndex = 27
        UltraToolTipInfo3.ToolTipText = "Seleccione Tracto para el Filtro en el Listado de Viajes"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboTractoLista, UltraToolTipInfo3)
        Me.cboTractoLista.ValueMember = "Id"
        '
        'cboCentro
        '
        Appearance68.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance68
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(61, 0)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(100, 21)
        Me.cboCentro.TabIndex = 11
        Me.cboCentro.ValueMember = "Id"
        '
        'verTracto
        '
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.verTracto.Appearance = Appearance69
        Me.verTracto.AutoSize = True
        Me.verTracto.Location = New System.Drawing.Point(3, 74)
        Me.verTracto.Name = "verTracto"
        Me.verTracto.Size = New System.Drawing.Size(57, 18)
        Me.verTracto.TabIndex = 28
        Me.verTracto.Text = "Tracto:"
        '
        'UltraLabel46
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Appearance70.TextVAlignAsString = "Middle"
        Me.UltraLabel46.Appearance = Appearance70
        Me.UltraLabel46.AutoSize = True
        Me.UltraLabel46.Location = New System.Drawing.Point(18, 4)
        Me.UltraLabel46.Name = "UltraLabel46"
        Me.UltraLabel46.Size = New System.Drawing.Size(41, 15)
        Me.UltraLabel46.TabIndex = 12
        Me.UltraLabel46.Text = "Centro:"
        '
        'UltraGroupBox11
        '
        Me.UltraGroupBox11.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox11.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox11.Location = New System.Drawing.Point(10, 22)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(150, 50)
        Me.UltraGroupBox11.TabIndex = 54
        Me.UltraGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecHasta
        '
        Me.fecHasta.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecHasta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecHasta.Location = New System.Drawing.Point(50, 26)
        Me.fecHasta.MaskInput = ""
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(90, 22)
        Me.fecHasta.TabIndex = 50
        Me.fecHasta.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel8
        '
        Appearance71.BackColor = System.Drawing.Color.Transparent
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Appearance71.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance71
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(10, 30)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel8.TabIndex = 49
        Me.UltraLabel8.Text = "Hasta:"
        '
        'fecDesde
        '
        Me.fecDesde.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecDesde.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDesde.Location = New System.Drawing.Point(50, 4)
        Me.fecDesde.MaskInput = ""
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(90, 22)
        Me.fecDesde.TabIndex = 48
        Me.fecDesde.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel10
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Appearance72.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance72
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(7, 8)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel10.TabIndex = 47
        Me.UltraLabel10.Text = "Desde:"
        '
        'utpDetalle
        '
        Me.utpDetalle.AutoScroll = True
        Me.utpDetalle.Controls.Add(Me.tabGuias)
        Me.utpDetalle.Controls.Add(Me.UltraExpandableGroupBox10)
        Me.utpDetalle.Controls.Add(Me.UltraExpandableGroupBox9)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1082, 588)
        '
        'tabGuias
        '
        Me.tabGuias.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.tabGuias.Controls.Add(Me.UltraTabPageControl2)
        Me.tabGuias.Controls.Add(Me.UltraTabPageControl4)
        Me.tabGuias.Controls.Add(Me.UltraTabPageControl5)
        Me.tabGuias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabGuias.Location = New System.Drawing.Point(200, 310)
        Me.tabGuias.Name = "tabGuias"
        Me.tabGuias.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.tabGuias.Size = New System.Drawing.Size(882, 278)
        Me.tabGuias.TabIndex = 0
        UltraTab12.Key = "0"
        Appearance97.Image = Global.ISL.Win.My.Resources.Resources.Actualizar
        UltraTab12.SelectedAppearance = Appearance97
        UltraTab12.TabPage = Me.UltraTabPageControl2
        UltraTab12.Text = "GuiasOperacion"
        UltraTab13.Key = "1"
        Appearance98.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        UltraTab13.SelectedAppearance = Appearance98
        UltraTab13.TabPage = Me.UltraTabPageControl4
        UltraTab13.Text = "ViajeGuiaTransportistaInterrumpido"
        UltraTab14.Key = "2"
        Appearance99.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        UltraTab14.SelectedAppearance = Appearance99
        UltraTab14.TabPage = Me.UltraTabPageControl5
        UltraTab14.Text = "Carga Operacion"
        Me.tabGuias.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab12, UltraTab13, UltraTab14})
        Me.tabGuias.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(878, 255)
        '
        'UltraExpandableGroupBox10
        '
        Appearance100.BackColor = System.Drawing.Color.White
        Appearance100.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox10.ContentAreaAppearance = Appearance100
        Me.UltraExpandableGroupBox10.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.UltraExpandableGroupBox10.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox10.ExpandedSize = New System.Drawing.Size(200, 278)
        Me.UltraExpandableGroupBox10.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.UltraExpandableGroupBox10.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox10.Location = New System.Drawing.Point(0, 310)
        Me.UltraExpandableGroupBox10.Name = "UltraExpandableGroupBox10"
        Me.UltraExpandableGroupBox10.Size = New System.Drawing.Size(200, 278)
        Me.UltraExpandableGroupBox10.TabIndex = 4
        Me.UltraExpandableGroupBox10.Text = "Informacion de Viaje Recorrido de UNIDAD"
        Me.UltraExpandableGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Agrupacion8)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Agrupacion5)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Agrupacion7)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Agrupacion6)
        Me.UltraExpandableGroupBoxPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel7.Location = New System.Drawing.Point(22, 3)
        Me.UltraExpandableGroupBoxPanel7.Name = "UltraExpandableGroupBoxPanel7"
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(175, 272)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        '
        'Agrupacion8
        '
        Me.Agrupacion8.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance101.BackColor = System.Drawing.Color.White
        Appearance101.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion8.ContentAreaAppearance = Appearance101
        Me.Agrupacion8.Controls.Add(Me.txtCantidad)
        Me.Agrupacion8.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion8.Controls.Add(Me.txtPesoToneladas)
        Me.Agrupacion8.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion8.Location = New System.Drawing.Point(1, 196)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(180, 60)
        Me.Agrupacion8.TabIndex = 4
        Me.Agrupacion8.Text = "Otros"
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtCantidad
        '
        Appearance102.TextHAlignAsString = "Right"
        Me.txtCantidad.Appearance = Appearance102
        Me.txtCantidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCantidad.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCantidad.InputMask = "{LOC}nnn.nn"
        Me.txtCantidad.Location = New System.Drawing.Point(91, 34)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NonAutoSizeHeight = 20
        Me.txtCantidad.NullText = "0.00"
        Me.txtCantidad.Size = New System.Drawing.Size(60, 20)
        Me.txtCantidad.TabIndex = 3
        Me.txtCantidad.Text = "0.00"
        '
        'UltraLabel3
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Appearance103.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance103
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(92, 19)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Cantidad:"
        '
        'txtPesoToneladas
        '
        Appearance104.TextHAlignAsString = "Right"
        Me.txtPesoToneladas.Appearance = Appearance104
        Me.txtPesoToneladas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPesoToneladas.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtPesoToneladas.InputMask = "{LOC}nn.nnnn"
        Me.txtPesoToneladas.Location = New System.Drawing.Point(5, 34)
        Me.txtPesoToneladas.Name = "txtPesoToneladas"
        Me.txtPesoToneladas.NonAutoSizeHeight = 20
        Me.txtPesoToneladas.NullText = "0.0000"
        Me.txtPesoToneladas.Size = New System.Drawing.Size(60, 20)
        Me.txtPesoToneladas.TabIndex = 1
        Me.txtPesoToneladas.Text = "0.0000"
        '
        'UltraLabel1
        '
        Appearance105.BackColor = System.Drawing.Color.Transparent
        Appearance105.ForeColor = System.Drawing.Color.Navy
        Appearance105.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance105
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 19)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Peso TM:"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance106.BackColor = System.Drawing.Color.White
        Appearance106.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion5.ContentAreaAppearance = Appearance106
        Me.Agrupacion5.Controls.Add(Me.verKmTractoValida)
        Me.Agrupacion5.Controls.Add(Me.txtKmTractoDestino)
        Me.Agrupacion5.Controls.Add(Me.txtKmTractoOrigen)
        Me.Agrupacion5.Controls.Add(Me.lblKmTractoDestino)
        Me.Agrupacion5.Controls.Add(Me.lblKmTractoOrigen)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(1, 4)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(180, 60)
        Me.Agrupacion5.TabIndex = 0
        Me.Agrupacion5.Text = "KM Tracto"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verKmTractoValida
        '
        Appearance107.ForeColor = System.Drawing.Color.Navy
        Me.verKmTractoValida.Appearance = Appearance107
        Me.verKmTractoValida.AutoSize = True
        Me.verKmTractoValida.Location = New System.Drawing.Point(3, 2)
        Me.verKmTractoValida.Name = "verKmTractoValida"
        Me.verKmTractoValida.Size = New System.Drawing.Size(14, 13)
        Me.verKmTractoValida.TabIndex = 31
        '
        'txtKmTractoDestino
        '
        Me.txtKmTractoDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtKmTractoDestino.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtKmTractoDestino.Enabled = False
        Me.txtKmTractoDestino.InputMask = "{LOC}nnnnnnnn.nnn"
        Me.txtKmTractoDestino.Location = New System.Drawing.Point(92, 34)
        Me.txtKmTractoDestino.Name = "txtKmTractoDestino"
        Me.txtKmTractoDestino.NonAutoSizeHeight = 20
        Me.txtKmTractoDestino.NullText = "0.000"
        Me.txtKmTractoDestino.Size = New System.Drawing.Size(80, 20)
        Me.txtKmTractoDestino.TabIndex = 3
        Me.txtKmTractoDestino.Text = "0.000"
        '
        'txtKmTractoOrigen
        '
        Me.txtKmTractoOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtKmTractoOrigen.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtKmTractoOrigen.Enabled = False
        Me.txtKmTractoOrigen.InputMask = "{LOC}nnnnnnnn.nnn"
        Me.txtKmTractoOrigen.Location = New System.Drawing.Point(5, 34)
        Me.txtKmTractoOrigen.Name = "txtKmTractoOrigen"
        Me.txtKmTractoOrigen.NonAutoSizeHeight = 20
        Me.txtKmTractoOrigen.NullText = "0.000"
        Me.txtKmTractoOrigen.Size = New System.Drawing.Size(80, 20)
        Me.txtKmTractoOrigen.TabIndex = 1
        Me.txtKmTractoOrigen.Text = "0.000"
        '
        'lblKmTractoDestino
        '
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Appearance108.ForeColor = System.Drawing.Color.Navy
        Appearance108.TextVAlignAsString = "Middle"
        Me.lblKmTractoDestino.Appearance = Appearance108
        Me.lblKmTractoDestino.AutoSize = True
        Me.lblKmTractoDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmTractoDestino.Location = New System.Drawing.Point(90, 19)
        Me.lblKmTractoDestino.Name = "lblKmTractoDestino"
        Me.lblKmTractoDestino.Size = New System.Drawing.Size(25, 12)
        Me.lblKmTractoDestino.TabIndex = 2
        Me.lblKmTractoDestino.Text = "Dest:"
        '
        'lblKmTractoOrigen
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Appearance109.TextVAlignAsString = "Middle"
        Me.lblKmTractoOrigen.Appearance = Appearance109
        Me.lblKmTractoOrigen.AutoSize = True
        Me.lblKmTractoOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmTractoOrigen.Location = New System.Drawing.Point(3, 19)
        Me.lblKmTractoOrigen.Name = "lblKmTractoOrigen"
        Me.lblKmTractoOrigen.Size = New System.Drawing.Size(24, 12)
        Me.lblKmTractoOrigen.TabIndex = 0
        Me.lblKmTractoOrigen.Text = "Orig:"
        '
        'Agrupacion7
        '
        Me.Agrupacion7.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance110.BackColor = System.Drawing.Color.White
        Appearance110.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion7.ContentAreaAppearance = Appearance110
        Me.Agrupacion7.Controls.Add(Me.txtHorasTractoDestino)
        Me.Agrupacion7.Controls.Add(Me.txtHorasTractoOrigen)
        Me.Agrupacion7.Controls.Add(Me.lblHrTractoDestino)
        Me.Agrupacion7.Controls.Add(Me.lblHrTractoOrigen)
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion7.Location = New System.Drawing.Point(1, 68)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(180, 60)
        Me.Agrupacion7.TabIndex = 1
        Me.Agrupacion7.Text = "Horas Tracto"
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtHorasTractoDestino
        '
        Me.txtHorasTractoDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtHorasTractoDestino.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtHorasTractoDestino.Enabled = False
        Me.txtHorasTractoDestino.InputMask = "{LOC}nnnnnnnnn.nn"
        Me.txtHorasTractoDestino.Location = New System.Drawing.Point(92, 34)
        Me.txtHorasTractoDestino.Name = "txtHorasTractoDestino"
        Me.txtHorasTractoDestino.NonAutoSizeHeight = 20
        Me.txtHorasTractoDestino.NullText = "0"
        Me.txtHorasTractoDestino.Size = New System.Drawing.Size(80, 20)
        Me.txtHorasTractoDestino.TabIndex = 3
        Me.txtHorasTractoDestino.Text = "0.00"
        '
        'txtHorasTractoOrigen
        '
        Me.txtHorasTractoOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtHorasTractoOrigen.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtHorasTractoOrigen.Enabled = False
        Me.txtHorasTractoOrigen.InputMask = "{LOC}nnnnnnnnn.nn"
        Me.txtHorasTractoOrigen.Location = New System.Drawing.Point(5, 34)
        Me.txtHorasTractoOrigen.Name = "txtHorasTractoOrigen"
        Me.txtHorasTractoOrigen.NonAutoSizeHeight = 20
        Me.txtHorasTractoOrigen.NullText = "0"
        Me.txtHorasTractoOrigen.Size = New System.Drawing.Size(80, 20)
        Me.txtHorasTractoOrigen.TabIndex = 1
        Me.txtHorasTractoOrigen.Text = "0.00"
        '
        'lblHrTractoDestino
        '
        Appearance111.BackColor = System.Drawing.Color.Transparent
        Appearance111.ForeColor = System.Drawing.Color.Navy
        Appearance111.TextVAlignAsString = "Middle"
        Me.lblHrTractoDestino.Appearance = Appearance111
        Me.lblHrTractoDestino.AutoSize = True
        Me.lblHrTractoDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrTractoDestino.Location = New System.Drawing.Point(90, 18)
        Me.lblHrTractoDestino.Name = "lblHrTractoDestino"
        Me.lblHrTractoDestino.Size = New System.Drawing.Size(38, 12)
        Me.lblHrTractoDestino.TabIndex = 2
        Me.lblHrTractoDestino.Text = "Destino:"
        '
        'lblHrTractoOrigen
        '
        Appearance112.BackColor = System.Drawing.Color.Transparent
        Appearance112.ForeColor = System.Drawing.Color.Navy
        Appearance112.TextVAlignAsString = "Middle"
        Me.lblHrTractoOrigen.Appearance = Appearance112
        Me.lblHrTractoOrigen.AutoSize = True
        Me.lblHrTractoOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrTractoOrigen.Location = New System.Drawing.Point(3, 18)
        Me.lblHrTractoOrigen.Name = "lblHrTractoOrigen"
        Me.lblHrTractoOrigen.Size = New System.Drawing.Size(24, 12)
        Me.lblHrTractoOrigen.TabIndex = 0
        Me.lblHrTractoOrigen.Text = "Orig:"
        '
        'Agrupacion6
        '
        Me.Agrupacion6.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance113.BackColor = System.Drawing.Color.White
        Appearance113.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion6.ContentAreaAppearance = Appearance113
        Me.Agrupacion6.Controls.Add(Me.txtKmCarretaDestino)
        Me.Agrupacion6.Controls.Add(Me.txtKmCarretaOrigen)
        Me.Agrupacion6.Controls.Add(Me.lblKmCarretaDestino)
        Me.Agrupacion6.Controls.Add(Me.lblKmCarretaOrigen)
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion6.Location = New System.Drawing.Point(1, 132)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(180, 60)
        Me.Agrupacion6.TabIndex = 2
        Me.Agrupacion6.Text = "KM Carreta"
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtKmCarretaDestino
        '
        Me.txtKmCarretaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtKmCarretaDestino.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtKmCarretaDestino.Enabled = False
        Me.txtKmCarretaDestino.InputMask = "{LOC}nnnnnnnn.nnn"
        Me.txtKmCarretaDestino.Location = New System.Drawing.Point(92, 35)
        Me.txtKmCarretaDestino.Name = "txtKmCarretaDestino"
        Me.txtKmCarretaDestino.NonAutoSizeHeight = 20
        Me.txtKmCarretaDestino.NullText = "0.000"
        Me.txtKmCarretaDestino.ReadOnly = True
        Me.txtKmCarretaDestino.Size = New System.Drawing.Size(80, 20)
        Me.txtKmCarretaDestino.TabIndex = 3
        Me.txtKmCarretaDestino.Text = "0.000"
        '
        'txtKmCarretaOrigen
        '
        Me.txtKmCarretaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtKmCarretaOrigen.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtKmCarretaOrigen.Enabled = False
        Me.txtKmCarretaOrigen.InputMask = "{LOC}nnnnnnnn.nnn"
        Me.txtKmCarretaOrigen.Location = New System.Drawing.Point(5, 34)
        Me.txtKmCarretaOrigen.Name = "txtKmCarretaOrigen"
        Me.txtKmCarretaOrigen.NonAutoSizeHeight = 20
        Me.txtKmCarretaOrigen.NullText = "0.000"
        Me.txtKmCarretaOrigen.Size = New System.Drawing.Size(80, 20)
        Me.txtKmCarretaOrigen.TabIndex = 1
        Me.txtKmCarretaOrigen.Text = "0.000"
        '
        'lblKmCarretaDestino
        '
        Appearance114.BackColor = System.Drawing.Color.Transparent
        Appearance114.ForeColor = System.Drawing.Color.Navy
        Appearance114.TextVAlignAsString = "Middle"
        Me.lblKmCarretaDestino.Appearance = Appearance114
        Me.lblKmCarretaDestino.AutoSize = True
        Me.lblKmCarretaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmCarretaDestino.Location = New System.Drawing.Point(91, 19)
        Me.lblKmCarretaDestino.Name = "lblKmCarretaDestino"
        Me.lblKmCarretaDestino.Size = New System.Drawing.Size(38, 12)
        Me.lblKmCarretaDestino.TabIndex = 2
        Me.lblKmCarretaDestino.Text = "Destino:"
        '
        'lblKmCarretaOrigen
        '
        Appearance115.BackColor = System.Drawing.Color.Transparent
        Appearance115.ForeColor = System.Drawing.Color.Navy
        Appearance115.TextVAlignAsString = "Middle"
        Me.lblKmCarretaOrigen.Appearance = Appearance115
        Me.lblKmCarretaOrigen.AutoSize = True
        Me.lblKmCarretaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmCarretaOrigen.Location = New System.Drawing.Point(3, 18)
        Me.lblKmCarretaOrigen.Name = "lblKmCarretaOrigen"
        Me.lblKmCarretaOrigen.Size = New System.Drawing.Size(24, 12)
        Me.lblKmCarretaOrigen.TabIndex = 0
        Me.lblKmCarretaOrigen.Text = "Orig:"
        '
        'UltraExpandableGroupBox9
        '
        Appearance116.BackColor = System.Drawing.Color.White
        Appearance116.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox9.ContentAreaAppearance = Appearance116
        Me.UltraExpandableGroupBox9.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.UltraExpandableGroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox9.ExpandedSize = New System.Drawing.Size(1082, 310)
        Me.UltraExpandableGroupBox9.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.UltraExpandableGroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox9.Name = "UltraExpandableGroupBox9"
        Me.UltraExpandableGroupBox9.Size = New System.Drawing.Size(1082, 310)
        Me.UltraExpandableGroupBox9.TabIndex = 1
        Me.UltraExpandableGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraTabControl1)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(1076, 287)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.ImageList = Me.imagenes
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl1.Size = New System.Drawing.Size(1076, 287)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.UltraTabControl1.TabIndex = 0
        Appearance211.Image = 10
        UltraTab15.SelectedAppearance = Appearance211
        UltraTab15.TabPage = Me.UltraTabPageControl1
        UltraTab15.Text = "Marcas"
        Appearance212.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        UltraTab16.SelectedAppearance = Appearance212
        UltraTab16.TabPage = Me.UltraTabPageControl3
        UltraTab16.Text = "Informacion Combustible"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab15, UltraTab16})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1074, 266)
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.tabImportar)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1082, 588)
        '
        'tabImportar
        '
        Me.tabImportar.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.tabImportar.Controls.Add(Me.UltraTabPageControl8)
        Me.tabImportar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabImportar.Location = New System.Drawing.Point(0, 98)
        Me.tabImportar.Name = "tabImportar"
        Me.tabImportar.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.tabImportar.Size = New System.Drawing.Size(1082, 490)
        Me.tabImportar.TabIndex = 4
        UltraTab10.TabPage = Me.UltraTabPageControl8
        UltraTab10.Text = "Viajes Sin Marcar"
        Me.tabImportar.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10})
        Me.tabImportar.TabStop = False
        Me.tabImportar.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(1080, 467)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraExpandableGroupBox11)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1082, 98)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Tag = ""
        Me.UltraGroupBox1.Text = "Busqueda"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBox11
        '
        Appearance221.BackColor = System.Drawing.Color.White
        Appearance221.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox11.ContentAreaAppearance = Appearance221
        Me.UltraExpandableGroupBox11.Controls.Add(Me.UltraExpandableGroupBoxPanel11)
        Me.UltraExpandableGroupBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox11.ExpandedSize = New System.Drawing.Size(1076, 78)
        Me.UltraExpandableGroupBox11.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox11.Location = New System.Drawing.Point(3, 17)
        Me.UltraExpandableGroupBox11.Name = "UltraExpandableGroupBox11"
        Me.UltraExpandableGroupBox11.Size = New System.Drawing.Size(1076, 78)
        Me.UltraExpandableGroupBox11.TabIndex = 52
        Me.UltraExpandableGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel11
        '
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.btnGuardar)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.btnBuscarImportar)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.btnImportar)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.UltraLabel12)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.cboTractoImportar)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.cboCentroImportar)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.UltraLabel22)
        Me.UltraExpandableGroupBoxPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel11.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel11.Name = "UltraExpandableGroupBoxPanel11"
        Me.UltraExpandableGroupBoxPanel11.Size = New System.Drawing.Size(1055, 72)
        Me.UltraExpandableGroupBoxPanel11.TabIndex = 0
        '
        'btnGuardar
        '
        Appearance222.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardar.Appearance = Appearance222
        Me.btnGuardar.ImageList = Me.imagenes
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(225, 33)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(95, 27)
        Me.btnGuardar.TabIndex = 58
        Me.btnGuardar.Text = "Guardar"
        '
        'btnBuscarImportar
        '
        Appearance223.Image = Global.ISL.Win.My.Resources.Resources.consult
        Me.btnBuscarImportar.Appearance = Appearance223
        Me.btnBuscarImportar.ImageList = Me.imagenes
        Me.btnBuscarImportar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBuscarImportar.Location = New System.Drawing.Point(23, 33)
        Me.btnBuscarImportar.Name = "btnBuscarImportar"
        Me.btnBuscarImportar.Size = New System.Drawing.Size(95, 27)
        Me.btnBuscarImportar.TabIndex = 56
        Me.btnBuscarImportar.Text = "Buscar"
        '
        'btnImportar
        '
        Appearance224.Image = 10
        Me.btnImportar.Appearance = Appearance224
        Me.btnImportar.ImageList = Me.imagenes
        Me.btnImportar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnImportar.Location = New System.Drawing.Point(124, 33)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(95, 27)
        Me.btnImportar.TabIndex = 57
        Me.btnImportar.Text = "Importar"
        '
        'UltraLabel12
        '
        Appearance225.BackColor = System.Drawing.Color.Transparent
        Appearance225.ForeColor = System.Drawing.Color.Navy
        Appearance225.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance225
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(177, 10)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(40, 15)
        Me.UltraLabel12.TabIndex = 28
        Me.UltraLabel12.Text = "Tracto:"
        '
        'cboTractoImportar
        '
        Appearance226.ForeColor = System.Drawing.Color.Black
        Me.cboTractoImportar.Appearance = Appearance226
        Me.cboTractoImportar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoImportar.DisplayMember = "Nombre"
        Me.cboTractoImportar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoImportar.ForeColor = System.Drawing.Color.Black
        Me.cboTractoImportar.Location = New System.Drawing.Point(220, 6)
        Me.cboTractoImportar.Name = "cboTractoImportar"
        Me.cboTractoImportar.Size = New System.Drawing.Size(100, 21)
        Me.cboTractoImportar.TabIndex = 27
        UltraToolTipInfo16.ToolTipText = "Seleccione Tracto para el Filtro en el Listado de Viajes"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboTractoImportar, UltraToolTipInfo16)
        Me.cboTractoImportar.ValueMember = "Id"
        '
        'cboCentroImportar
        '
        Appearance227.ForeColor = System.Drawing.Color.Black
        Me.cboCentroImportar.Appearance = Appearance227
        Me.cboCentroImportar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCentroImportar.DisplayMember = "Nombre"
        Me.cboCentroImportar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroImportar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroImportar.ForeColor = System.Drawing.Color.Black
        Me.cboCentroImportar.Location = New System.Drawing.Point(61, 6)
        Me.cboCentroImportar.Name = "cboCentroImportar"
        Me.cboCentroImportar.Size = New System.Drawing.Size(100, 21)
        Me.cboCentroImportar.TabIndex = 11
        Me.cboCentroImportar.ValueMember = "Id"
        '
        'UltraLabel22
        '
        Appearance228.BackColor = System.Drawing.Color.Transparent
        Appearance228.ForeColor = System.Drawing.Color.Navy
        Appearance228.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance228
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(18, 10)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(41, 15)
        Me.UltraLabel22.TabIndex = 12
        Me.UltraLabel22.Text = "Centro:"
        '
        'ogdGuiaTransportistaDetalle
        '
        UltraDataColumn179.DataType = GetType(Decimal)
        UltraDataColumn180.DataType = GetType(Decimal)
        Me.ogdGuiaTransportistaDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181})
        '
        'ogdDemandaRapida
        '
        UltraDataColumn182.DataType = GetType(Boolean)
        UltraDataColumn182.DefaultValue = False
        UltraDataColumn185.DataType = GetType(Date)
        UltraDataColumn194.DataType = GetType(Boolean)
        Me.ogdDemandaRapida.Band.Columns.AddRange(New Object() {UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185, UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192, UltraDataColumn193, UltraDataColumn194, UltraDataColumn195, UltraDataColumn196, UltraDataColumn197, UltraDataColumn198})
        '
        'ficDemanda
        '
        Me.ficDemanda.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDemanda.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDemanda.Controls.Add(Me.utpDetalle)
        Me.ficDemanda.Controls.Add(Me.UltraTabPageControl6)
        Me.ficDemanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDemanda.Location = New System.Drawing.Point(0, 0)
        Me.ficDemanda.Name = "ficDemanda"
        Me.ficDemanda.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDemanda.Size = New System.Drawing.Size(1084, 611)
        Me.ficDemanda.TabIndex = 0
        UltraTab17.Key = "Lista"
        UltraTab17.TabPage = Me.UltraTabPageControl7
        UltraTab17.Text = "Lista"
        UltraTab18.Key = "Mantenimiento"
        UltraTab18.TabPage = Me.utpDetalle
        UltraTab18.Text = "Mantenimiento"
        UltraTab1.Key = "Importar"
        UltraTab1.TabPage = Me.UltraTabPageControl6
        UltraTab1.Text = "Importar"
        Me.ficDemanda.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab17, UltraTab18, UltraTab1})
        Me.ficDemanda.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1082, 588)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_Seguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 611)
        Me.ContextMenuStrip = Me.MenuCombustible
        Me.Controls.Add(Me.ficDemanda)
        Me.Name = "frm_Seguimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento Viaje"
        Me.tapViajes.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.ogdListaSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tapAlertaViajes.ResumeLayout(False)
        CType(Me.griAlertaViajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griGuiaRemitente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuGuiaRemitente.ResumeLayout(False)
        CType(Me.ogdGuiaRemitente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griGuiaTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuGuiaTransportista.ResumeLayout(False)
        CType(Me.ogdGuiaTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox5.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecEmisionGrt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPuntoLlegada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPuntoPartida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRemitente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDestinatario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecEmisionGrr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRangoGrr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griViajeInterrumpido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdGuiaTransportistaInterrumpido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.fecPartidaViajeInterrumpido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdGuiaTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGuiaTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMotivoTrasladoInterrumpido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosaInterrumpido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griViajeDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel9.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel9.PerformLayout()
        CType(Me.hFalla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFalla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosaFalla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndFallaOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verClienteConf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verPilotoConf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTractoConf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCarretaConf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCopilotoConf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeRuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verViajeRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajePiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verViajeVacio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.grupoEnviarCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoEnviarCorreo.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.PerformLayout()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLugarTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoMarca01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoMarca01.ResumeLayout(False)
        Me.grupoMarca01.PerformLayout()
        CType(Me.grupoLlegada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoLlegada.ResumeLayout(False)
        Me.grupoLlegada.PerformLayout()
        CType(Me.fecLlegadaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hLlegadaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verLlegadaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exGroupMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exGroupMarca.ResumeLayout(False)
        Me.exGroupMarcaDentro.ResumeLayout(False)
        Me.exGroupMarcaDentro.PerformLayout()
        CType(Me.fecCargaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDescargaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTerminoDescargaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hDescargaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hTerminoDescargaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hCargaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verDescargaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecTerminoDescargaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCargaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecTerminoCargaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTerminoCargaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hTerminoCargaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verLlegadaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verSalidaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verSalidaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hSalidaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hSalidaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hLlegadaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecSalidaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecSalidaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecLlegadaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeguimientoId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoMarca02, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoMarca02.ResumeLayout(False)
        Me.grupoMarca02.PerformLayout()
        CType(Me.grupoLlegadaE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoLlegadaE.ResumeLayout(False)
        Me.grupoLlegadaE.PerformLayout()
        CType(Me.fecLlegadaAproximadaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verLlegadaAproximadaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hLlegadaAproximadaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exGroupMarcaE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exGroupMarcaE.ResumeLayout(False)
        Me.exGroupMarcaEDentro.ResumeLayout(False)
        Me.exGroupMarcaEDentro.PerformLayout()
        CType(Me.verLlegadaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecIngresoComplejoOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hLlegadaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecLlegadaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecCargaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIngresoDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTerminoDescargaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecTerminoCargaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verDescargaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecImpresionGuiaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hIngresoDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hTerminoDescargaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hDescargaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hTerminoCargaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hImpresionGuiaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hCargaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hIngresoComplejoOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTerminoCargaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verImpresionGuiaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCargaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIngresoComplejoOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecTerminoDescargaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecIngresoDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDescargaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verSalidaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hSalidaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecSalidaDestinoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verLlegadaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verSalidaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hSalidaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hLlegadaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecSalidaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecLlegadaOrigenE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griListadoTanqueo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuCombustible.ResumeLayout(False)
        CType(Me.odRegistroConsCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.gridImportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.tabListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabListado.ResumeLayout(False)
        CType(Me.gruopExpanUnidadesSinReportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruopExpanUnidadesSinReportar.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel8.ResumeLayout(False)
        CType(Me.gridUnidadesSinReportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdUnidadesSinReportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox7.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel15.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel15.PerformLayout()
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoEstado.ResumeLayout(False)
        Me.grupoEstado.PerformLayout()
        CType(Me.ColorFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorProgramado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTransito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorDescarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoTipoVehiculo.ResumeLayout(False)
        Me.grupoTipoVehiculo.PerformLayout()
        CType(Me.ColorParihuelero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPlataforma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion20M3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTolvaVolteo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion65M3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGranelero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgonLargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamioneta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVolquete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion30M3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCalicera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion40M3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorMediaBaranda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.PerformLayout()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        Me.UltraGroupBox11.PerformLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.tabGuias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGuias.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox10.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(False)
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        Me.Agrupacion8.PerformLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.verKmTractoValida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.UltraExpandableGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox9.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.tabImportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImportar.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox11.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel11.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel11.PerformLayout()
        CType(Me.cboTractoImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentroImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdGuiaTransportistaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDemandaRapida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDemanda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ogdDemandaRapida As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdGuiaTransportista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents MenuGuiaTransportista As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ficDemanda As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdListaSeguimiento As ISL.Controles.OrigenDatos
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents lblKmTractoDestino As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblKmTractoOrigen As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents lblHrTractoOrigen As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents lblKmCarretaDestino As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblKmCarretaOrigen As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tabGuias As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griGuiaTransportista As ISL.Controles.Grilla
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents ogdGuiaRemitente As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griGuiaRemitente As ISL.Controles.Grilla
    Friend WithEvents lblHrTractoDestino As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txtViajeEscala As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents grupoMarca01 As ISL.Controles.Agrupacion
    Friend WithEvents verLlegadaOrigen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verCargaOrigen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verSalidaOrigen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verDescargaDestino As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verLlegadaDestino As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verSalidaDestino As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents hCargaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hSalidaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hSalidaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hDescargaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hLlegadaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hLlegadaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnSalidaOrigen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLlegadaDestino As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDescargaDestino As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalidaDestino As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCargaOrigen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLlegadaOrigen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents fecSalidaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblSalidaDestino As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDescargaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecLlegadaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecSalidaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecCargaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecLlegadaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSeguimientoId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grupoMarca02 As ISL.Controles.Agrupacion
    Friend WithEvents verLlegadaAproximadaDestinoE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verLlegadaDestinoE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verIngresoDestinoE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verTerminoDescargaDestinoE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verDescargaDestinoE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verSalidaDestinoE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents hLlegadaDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hIngresoDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hSalidaDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hTerminoDescargaDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hDescargaDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hLlegadaAproximadaDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnIngresoDestinoE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDescargaDestinoE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnTerminoDescargaDestinoE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalidaDestinoE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLlegadaDestinoE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLlegadaAproximadaDestinoE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents fecSalidaDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblSalidaDestinoE As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecTerminoDescargaDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDescargaDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel38 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecIngresoDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecLlegadaDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel40 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecLlegadaAproximadaDestinoE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verLlegadaOrigenE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verIngresoComplejoOrigenE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verCargaOrigenE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verImpresionGuiaOrigenE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verTerminoCargaOrigenE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verSalidaOrigenE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents hIngresoComplejoOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hCargaOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hSalidaOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hImpresionGuiaOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hTerminoCargaOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hLlegadaOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnCargaOrigenE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnTerminoCargaOrigenE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnImpresionGuiaOrigenE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalidaOrigenE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnIngresoComplejoOrigenE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLlegadaOrigenE As Infragistics.Win.Misc.UltraButton
    Friend WithEvents fecSalidaOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecImpresionGuiaOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecTerminoCargaOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecCargaOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel33 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecIngresoComplejoOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel34 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecLlegadaOrigenE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel35 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents txtHorasTractoOrigen As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtHorasTractoDestino As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtGrtPT As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents MenuGuiaRemitente As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Quitar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtKmTractoOrigen As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtKmTractoDestino As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtKmCarretaDestino As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtKmCarretaOrigen As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdGuiaTransportistaDetalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdOperacionDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents griViajeDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtIdOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents griViajeInterrumpido As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnAgregarInterrumpido As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtIdGuiaTransportista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtGuiaTransportista As ISL.Controles.Texto
    Friend WithEvents UltraLabel43 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMotivoTrasladoInterrumpido As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel42 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGlosaInterrumpido As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ogdGuiaTransportistaInterrumpido As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Interrumpir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecPartidaViajeInterrumpido As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel44 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verTerminoCargaOrigen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents hTerminoCargaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnTerminoCargaOrigen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents fecTerminoCargaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verTerminoDescargaDestino As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents hTerminoDescargaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnTerminoDescargaDestino As Infragistics.Win.Misc.UltraButton
    Friend WithEvents fecTerminoDescargaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel45 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecEmisionGrr As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecEmisionGrt As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRangoGrr As ISL.Controles.Texto
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGrr As ISL.Controles.Texto
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGrt As ISL.Controles.Texto
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboDestinatario As ISL.Controles.ComboMaestros
    Friend WithEvents cboRemitente As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtObservacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnEnviarCorreo As ISL.Controles.Boton
    Friend WithEvents lbOrigen As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbDestino As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbOrigenE As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbDestinoE As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel46 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents cboPuntoLlegada As ISL.Controles.ComboMaestros
    Friend WithEvents cboPuntoPartida As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel47 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel48 As Infragistics.Win.Misc.UltraLabel
    Shadows WithEvents Menu As ISL.Controles.MenuContextual
    Shadows WithEvents Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odRegistroConsCombustible As ISL.Controles.OrigenDatos
    Friend WithEvents MenuCombustible As ISL.Controles.MenuContextual
    Shadows WithEvents Nuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Actualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents griListadoTanqueo As Infragistics.Win.UltraWinGrid.UltraGrid
    Shadows WithEvents Eliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents verKmTractoValida As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents txtPesoToneladas As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents exGroupMarca As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents exGroupMarcaDentro As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents exGroupMarcaE As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents exGroupMarcaEDentro As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grupoLlegadaE As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents grupoLlegada As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox5 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents verTracto As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboTractoLista As ISL.Controles.Combo
    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox7 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel15 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents colorCambio As ISL.Controles.Colores
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents txtCantidad As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtIdTracto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdCarreta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboLugarTienda As ISL.Controles.ComboMaestros
    Friend WithEvents grupoTipoVehiculo As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents ColorParihuelero As ISL.Controles.Colores
    Friend WithEvents ColorPlataforma As ISL.Controles.Colores
    Friend WithEvents ColorCamion20M3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTolvaVolteo As ISL.Controles.Colores
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion65M3 As ISL.Controles.Colores
    Friend WithEvents ColorContenedor As ISL.Controles.Colores
    Friend WithEvents Etiqueta222 As ISL.Controles.Etiqueta
    Friend WithEvents ColorGranelero As ISL.Controles.Colores
    Friend WithEvents ColorFurgon As ISL.Controles.Colores
    Friend WithEvents ColorFurgonLargo As ISL.Controles.Colores
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamioneta As ISL.Controles.Colores
    Friend WithEvents ColorVolquete As ISL.Controles.Colores
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion30M3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCalicera As ISL.Controles.Colores
    Friend WithEvents ColorCamion40M3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents ColorMediaBaranda As ISL.Controles.Colores
    Friend WithEvents grupoEstado As ISL.Controles.Agrupacion
    Friend WithEvents ColorFin As ISL.Controles.Colores
    Friend WithEvents ColorProgramado As ISL.Controles.Colores
    Friend WithEvents ColorCarga As ISL.Controles.Colores
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTransito As ISL.Controles.Colores
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents ColorDescarga As ISL.Controles.Colores
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents txtGrtCantidad As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grupoEnviarCorreo As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBox10 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel7 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox9 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnSinReportarUnidades As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numOPSinReportar As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents gruopExpanUnidadesSinReportar As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel8 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents gridUnidadesSinReportar As ISL.Controles.Grilla
    Friend WithEvents ogdUnidadesSinReportar As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel9 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents hFalla As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecFalla As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtGlosaFalla As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents verIndFallaOP As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verClienteConf As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verPilotoConf As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verTractoConf As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verCarretaConf As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verCopilotoConf As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtViajeRuta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents verViajeRetorno As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtViajePiloto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeCarreta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents verViajeVacio As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeCodigo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents hViaje As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecViaje As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeTracto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeEstado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnCorreoFalla As ISL.Controles.Boton
    Friend WithEvents tabListado As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tapViajes As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tapAlertaViajes As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griAlertaViajes As ISL.Controles.Grilla
    Friend WithEvents EventoViaje As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguimientoMonitoreo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguimientoRapido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemProgramado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabImportar As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridImportar As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraExpandableGroupBox11 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel11 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnBuscarImportar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnImportar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTractoImportar As ISL.Controles.Combo
    Friend WithEvents cboCentroImportar As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
