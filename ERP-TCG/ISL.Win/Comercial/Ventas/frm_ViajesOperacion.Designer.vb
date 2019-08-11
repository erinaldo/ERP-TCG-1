<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ViajesOperacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ViajesOperacion))
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
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
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
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
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
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTercero")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim RowLayout1 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("Operacion")
        Dim RowLayoutColumnInfo1 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOperacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo2 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Operacion", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo3 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Id", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo4 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Codigo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo5 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOrigen", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo6 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Origen", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo7 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdDestino", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo8 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Destino", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo9 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEscala", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo10 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Escala", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo11 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeVacio", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo12 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdPiloto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo13 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Piloto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo14 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCopiloto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo15 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Copiloto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo16 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdAyudante", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo17 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Ayudante", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo18 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTracto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo19 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tracto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo20 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCarreta", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo21 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carreta", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo22 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TotalFlete", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo23 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEstado", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo24 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Estado", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo25 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Fecha", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo26 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioCreacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo27 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo28 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Seleccion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo29 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo30 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo31 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleP", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo32 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleC", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo33 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleA", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo34 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cliente", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo35 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo36 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "GlosaEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo37 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaMaterial", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo38 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioModifica", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo39 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo40 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo41 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo42 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo43 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo44 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Flota", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo45 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaOperaciones", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo46 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo47 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Turno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo48 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DiaNoche", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo49 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PesoToneladas", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo50 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Zona", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo51 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tesoreria", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo52 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo53 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndFecha", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo54 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PorcentajeFlete", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo55 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo56 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo57 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo58 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo59 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoComplejoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo60 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo61 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoCargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo62 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ImpresionGuiaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo63 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaAproximadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo64 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo65 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo66 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoDescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo67 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cantidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo68 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FleteUnitario", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo69 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncluyeIgv", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo70 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Capacidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo71 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndCarga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo72 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Produccion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo73 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeRetorno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo74 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaCreacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo75 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaModifica", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo76 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndPlanilla", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo77 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCentro", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo78 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Subtotal", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo79 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Consolidado", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo80 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTercero", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.ogdListaOperacion = New ISL.Controles.OrigenDatos(Me.components)
        Me.btnCerrar = New ISL.Controles.Boton(Me.components)
        Me.btnEliminar = New ISL.Controles.Boton(Me.components)
        Me.griViajesElimina = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        CType(Me.ogdListaOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griViajesElimina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
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
        'ogdListaOperacion
        '
        UltraDataColumn11.DataType = GetType(Boolean)
        UltraDataColumn25.DataType = GetType(Date)
        UltraDataColumn40.DataType = GetType(Date)
        UltraDataColumn41.DataType = GetType(Date)
        UltraDataColumn42.DataType = GetType(Date)
        UltraDataColumn43.DataType = GetType(Date)
        UltraDataColumn45.DefaultValue = ""
        UltraDataColumn49.DataType = GetType(Decimal)
        UltraDataColumn51.DataType = GetType(Decimal)
        Me.ogdListaOperacion.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80})
        '
        'btnCerrar
        '
        Appearance1.Image = 2
        Me.btnCerrar.Appearance = Appearance1
        Me.btnCerrar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.ImageList = Me.imagenes
        Me.btnCerrar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCerrar.Location = New System.Drawing.Point(278, 117)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(100, 40)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "&Cerrar"
        '
        'btnEliminar
        '
        Appearance2.Image = 5
        Me.btnEliminar.Appearance = Appearance2
        Me.btnEliminar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageList = Me.imagenes
        Me.btnEliminar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEliminar.Location = New System.Drawing.Point(172, 117)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 40)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "&Eliminar"
        '
        'griViajesElimina
        '
        Me.griViajesElimina.DataSource = Me.ogdListaOperacion
        UltraGridColumn1.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn1.Header.VisiblePosition = 16
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance3.TextHAlignAsString = "Center"
        Appearance3.TextVAlignAsString = "Middle"
        UltraGridColumn2.CellAppearance = Appearance3
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn2.Header.Appearance = Appearance4
        UltraGridColumn2.Header.Caption = "OPERACION"
        UltraGridColumn2.Header.Fixed = True
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn2.Width = 100
        UltraGridColumn3.Header.VisiblePosition = 17
        UltraGridColumn3.Hidden = True
        Appearance5.TextVAlignAsString = "Middle"
        UltraGridColumn4.CellAppearance = Appearance5
        UltraGridColumn4.Header.Caption = "VIAJE"
        UltraGridColumn4.Header.Fixed = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn4.Width = 100
        UltraGridColumn5.Header.VisiblePosition = 18
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Fixed = True
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Width = 100
        UltraGridColumn7.Header.VisiblePosition = 19
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.Fixed = True
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Width = 100
        UltraGridColumn9.Header.VisiblePosition = 20
        UltraGridColumn9.Hidden = True
        Appearance6.TextVAlignAsString = "Middle"
        UltraGridColumn10.CellAppearance = Appearance6
        UltraGridColumn10.Header.VisiblePosition = 21
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn10.Width = 124
        Appearance7.TextVAlignAsString = "Middle"
        UltraGridColumn11.CellAppearance = Appearance7
        UltraGridColumn11.Header.Caption = "Vacio"
        UltraGridColumn11.Header.VisiblePosition = 34
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn11.Width = 40
        UltraGridColumn12.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn12.Header.VisiblePosition = 22
        UltraGridColumn12.Hidden = True
        Appearance8.Image = 7
        UltraGridColumn13.CellAppearance = Appearance8
        Appearance9.Image = 3
        UltraGridColumn13.CellButtonAppearance = Appearance9
        UltraGridColumn13.Header.VisiblePosition = 7
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn13.Width = 150
        UltraGridColumn14.Header.VisiblePosition = 23
        UltraGridColumn14.Hidden = True
        Appearance10.Image = 7
        UltraGridColumn15.CellButtonAppearance = Appearance10
        UltraGridColumn15.Header.VisiblePosition = 8
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Width = 150
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 14
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn18.Header.VisiblePosition = 13
        UltraGridColumn18.Hidden = True
        Appearance11.TextHAlignAsString = "Left"
        Appearance11.TextVAlignAsString = "Middle"
        UltraGridColumn19.CellAppearance = Appearance11
        UltraGridColumn19.Header.Fixed = True
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Width = 80
        UltraGridColumn20.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn20.Header.VisiblePosition = 12
        UltraGridColumn20.Hidden = True
        Appearance12.TextHAlignAsString = "Left"
        Appearance12.TextVAlignAsString = "Middle"
        UltraGridColumn21.CellAppearance = Appearance12
        UltraGridColumn21.Header.Fixed = True
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn21.Hidden = True
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.VertScrollBar = True
        UltraGridColumn21.Width = 80
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance13
        UltraGridColumn22.Format = "#,###,###,##0.00"
        UltraGridColumn22.Header.VisiblePosition = 28
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.MaskInput = "{LOC}n,nnn,nnn.nn"
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn22.Width = 100
        UltraGridColumn23.Header.VisiblePosition = 25
        UltraGridColumn23.Hidden = True
        Appearance14.TextVAlignAsString = "Middle"
        UltraGridColumn24.CellAppearance = Appearance14
        UltraGridColumn24.Header.Caption = "ESTADO"
        UltraGridColumn24.Header.VisiblePosition = 35
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn24.Width = 100
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn25.Header.Caption = "FECHA"
        UltraGridColumn25.Header.Fixed = True
        UltraGridColumn25.Header.VisiblePosition = 2
        UltraGridColumn25.MaskInput = "{date} {time}"
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn25.Width = 100
        UltraGridColumn26.Header.Caption = "UsuarioCrea"
        UltraGridColumn26.Header.VisiblePosition = 52
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.Width = 150
        UltraGridColumn27.Header.VisiblePosition = 29
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 24
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 30
        UltraGridColumn29.Hidden = True
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn30.CellAppearance = Appearance15
        UltraGridColumn30.Header.VisiblePosition = 49
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Width = 100
        UltraGridColumn31.Header.VisiblePosition = 36
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 37
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 38
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 9
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.Width = 150
        UltraGridColumn35.Header.VisiblePosition = 39
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 40
        UltraGridColumn36.Hidden = True
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn37.CellAppearance = Appearance16
        UltraGridColumn37.Header.VisiblePosition = 10
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.Width = 100
        UltraGridColumn38.Header.VisiblePosition = 53
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.Width = 150
        UltraGridColumn39.Header.VisiblePosition = 54
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.Width = 150
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.Header.VisiblePosition = 41
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn40.Width = 100
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn41.Header.VisiblePosition = 42
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn41.Width = 100
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.Header.VisiblePosition = 43
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn42.Width = 100
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn43.Header.VisiblePosition = 44
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn43.Width = 100
        UltraGridColumn44.Header.VisiblePosition = 50
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.Width = 100
        Appearance17.Image = 3
        Appearance17.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn45.CellAppearance = Appearance17
        Appearance18.Image = 1
        UltraGridColumn45.CellButtonAppearance = Appearance18
        UltraGridColumn45.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn45.Header.VisiblePosition = 55
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn45.Width = 250
        UltraGridColumn46.Header.VisiblePosition = 56
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.Width = 250
        UltraGridColumn47.Header.Caption = "Bloque"
        UltraGridColumn47.Header.VisiblePosition = 57
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.Width = 40
        UltraGridColumn48.Header.Caption = "D/N"
        UltraGridColumn48.Header.VisiblePosition = 58
        UltraGridColumn48.Hidden = True
        UltraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn48.Width = 40
        UltraGridColumn49.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance19.TextHAlignAsString = "Right"
        Appearance19.TextVAlignAsString = "Middle"
        UltraGridColumn49.CellAppearance = Appearance19
        UltraGridColumn49.Format = "#,###,###,##0.00"
        UltraGridColumn49.Header.Caption = "TN"
        UltraGridColumn49.Header.VisiblePosition = 11
        UltraGridColumn49.Hidden = True
        UltraGridColumn49.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn49.Width = 40
        UltraGridColumn50.Header.VisiblePosition = 51
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.Width = 100
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn51.CellAppearance = Appearance20
        UltraGridColumn51.Format = "#,###,###,##0.00"
        UltraGridColumn51.Header.VisiblePosition = 33
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.MaskInput = "{currency:9.2}"
        UltraGridColumn51.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn51.Width = 100
        UltraGridColumn52.Header.VisiblePosition = 59
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.Width = 40
        UltraGridColumn53.Header.Caption = "Ind"
        UltraGridColumn53.Header.VisiblePosition = 60
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn53.Width = 40
        UltraGridColumn54.Header.Caption = "%FLETE"
        UltraGridColumn54.Header.VisiblePosition = 31
        UltraGridColumn54.Width = 30
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn55.CellAppearance = Appearance21
        UltraGridColumn55.Header.Caption = "KmTracto O"
        UltraGridColumn55.Header.VisiblePosition = 45
        UltraGridColumn55.Hidden = True
        UltraGridColumn55.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn55.Width = 70
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn56.CellAppearance = Appearance22
        UltraGridColumn56.Header.Caption = "KmTracto D"
        UltraGridColumn56.Header.VisiblePosition = 46
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn56.Width = 70
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn57.CellAppearance = Appearance23
        UltraGridColumn57.Header.Caption = "KmCarreta O"
        UltraGridColumn57.Header.VisiblePosition = 47
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn57.Width = 70
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn58.CellAppearance = Appearance24
        UltraGridColumn58.Header.Caption = "KmCarreta D"
        UltraGridColumn58.Header.VisiblePosition = 48
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn58.Width = 70
        UltraGridColumn59.Header.VisiblePosition = 61
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 62
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 63
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 64
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 66
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 65
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 67
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 68
        UltraGridColumn66.Hidden = True
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn67.CellAppearance = Appearance25
        UltraGridColumn67.Format = "#,###,###,##0.00"
        UltraGridColumn67.Header.Caption = "Cant."
        UltraGridColumn67.Header.VisiblePosition = 26
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn67.Width = 40
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn68.CellAppearance = Appearance26
        UltraGridColumn68.Format = "#,###,###,##0.00"
        UltraGridColumn68.Header.VisiblePosition = 27
        UltraGridColumn68.Hidden = True
        UltraGridColumn68.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridColumn68.Width = 60
        UltraGridColumn69.Header.VisiblePosition = 69
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn69.Width = 40
        UltraGridColumn70.Header.VisiblePosition = 70
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 71
        UltraGridColumn71.Hidden = True
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn72.CellAppearance = Appearance27
        UltraGridColumn72.Format = "#,###,###,##0.00"
        UltraGridColumn72.Header.VisiblePosition = 32
        UltraGridColumn72.Hidden = True
        UltraGridColumn72.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn72.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn72.Width = 100
        UltraGridColumn73.Header.Caption = "Retorno"
        UltraGridColumn73.Header.VisiblePosition = 72
        UltraGridColumn73.Hidden = True
        UltraGridColumn73.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn73.Width = 40
        UltraGridColumn74.Header.Caption = "F.CREACION"
        UltraGridColumn74.Header.VisiblePosition = 73
        UltraGridColumn74.Width = 90
        UltraGridColumn75.Header.VisiblePosition = 74
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 75
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 76
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 77
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 78
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 79
        UltraGridColumn80.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80})
        UltraGridBand1.GroupHeadersVisible = False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        RowLayoutColumnInfo2.OriginX = 0
        RowLayoutColumnInfo2.OriginY = 0
        RowLayoutColumnInfo2.SpanX = 2
        RowLayoutColumnInfo2.SpanY = 4
        RowLayoutColumnInfo4.OriginX = 2
        RowLayoutColumnInfo4.OriginY = 0
        RowLayoutColumnInfo4.SpanX = 2
        RowLayoutColumnInfo4.SpanY = 4
        RowLayoutColumnInfo6.OriginX = 6
        RowLayoutColumnInfo6.OriginY = 0
        RowLayoutColumnInfo6.SpanX = 2
        RowLayoutColumnInfo6.SpanY = 2
        RowLayoutColumnInfo8.OriginX = 6
        RowLayoutColumnInfo8.OriginY = 2
        RowLayoutColumnInfo8.SpanX = 2
        RowLayoutColumnInfo8.SpanY = 2
        RowLayoutColumnInfo10.OriginX = 8
        RowLayoutColumnInfo10.OriginY = 0
        RowLayoutColumnInfo10.SpanX = 2
        RowLayoutColumnInfo10.SpanY = 4
        RowLayoutColumnInfo11.OriginX = 16
        RowLayoutColumnInfo11.OriginY = 0
        RowLayoutColumnInfo11.PreferredCellSize = New System.Drawing.Size(61, 0)
        RowLayoutColumnInfo11.SpanX = 2
        RowLayoutColumnInfo11.SpanY = 2
        RowLayoutColumnInfo13.OriginX = 10
        RowLayoutColumnInfo13.OriginY = 0
        RowLayoutColumnInfo13.PreferredCellSize = New System.Drawing.Size(254, 0)
        RowLayoutColumnInfo13.SpanX = 2
        RowLayoutColumnInfo13.SpanY = 2
        RowLayoutColumnInfo15.OriginX = 10
        RowLayoutColumnInfo15.OriginY = 2
        RowLayoutColumnInfo15.PreferredCellSize = New System.Drawing.Size(254, 0)
        RowLayoutColumnInfo15.SpanX = 2
        RowLayoutColumnInfo15.SpanY = 2
        RowLayoutColumnInfo19.OriginX = 12
        RowLayoutColumnInfo19.OriginY = 0
        RowLayoutColumnInfo19.SpanX = 2
        RowLayoutColumnInfo19.SpanY = 2
        RowLayoutColumnInfo21.OriginX = 12
        RowLayoutColumnInfo21.OriginY = 2
        RowLayoutColumnInfo21.SpanX = 2
        RowLayoutColumnInfo21.SpanY = 2
        RowLayoutColumnInfo22.OriginX = 16
        RowLayoutColumnInfo22.OriginY = 2
        RowLayoutColumnInfo22.SpanX = 2
        RowLayoutColumnInfo22.SpanY = 2
        RowLayoutColumnInfo24.OriginX = 14
        RowLayoutColumnInfo24.OriginY = 0
        RowLayoutColumnInfo24.SpanX = 2
        RowLayoutColumnInfo24.SpanY = 4
        RowLayoutColumnInfo25.OriginX = 4
        RowLayoutColumnInfo25.OriginY = 0
        RowLayoutColumnInfo25.SpanX = 2
        RowLayoutColumnInfo25.SpanY = 2
        RowLayoutColumnInfo30.OriginX = 4
        RowLayoutColumnInfo30.OriginY = 2
        RowLayoutColumnInfo30.SpanX = 2
        RowLayoutColumnInfo30.SpanY = 2
        RowLayout1.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo1, RowLayoutColumnInfo2, RowLayoutColumnInfo3, RowLayoutColumnInfo4, RowLayoutColumnInfo5, RowLayoutColumnInfo6, RowLayoutColumnInfo7, RowLayoutColumnInfo8, RowLayoutColumnInfo9, RowLayoutColumnInfo10, RowLayoutColumnInfo11, RowLayoutColumnInfo12, RowLayoutColumnInfo13, RowLayoutColumnInfo14, RowLayoutColumnInfo15, RowLayoutColumnInfo16, RowLayoutColumnInfo17, RowLayoutColumnInfo18, RowLayoutColumnInfo19, RowLayoutColumnInfo20, RowLayoutColumnInfo21, RowLayoutColumnInfo22, RowLayoutColumnInfo23, RowLayoutColumnInfo24, RowLayoutColumnInfo25, RowLayoutColumnInfo26, RowLayoutColumnInfo27, RowLayoutColumnInfo28, RowLayoutColumnInfo29, RowLayoutColumnInfo30, RowLayoutColumnInfo31, RowLayoutColumnInfo32, RowLayoutColumnInfo33, RowLayoutColumnInfo34, RowLayoutColumnInfo35, RowLayoutColumnInfo36, RowLayoutColumnInfo37, RowLayoutColumnInfo38, RowLayoutColumnInfo39, RowLayoutColumnInfo40, RowLayoutColumnInfo41, RowLayoutColumnInfo42, RowLayoutColumnInfo43, RowLayoutColumnInfo44, RowLayoutColumnInfo45, RowLayoutColumnInfo46, RowLayoutColumnInfo47, RowLayoutColumnInfo48, RowLayoutColumnInfo49, RowLayoutColumnInfo50, RowLayoutColumnInfo51, RowLayoutColumnInfo52, RowLayoutColumnInfo53, RowLayoutColumnInfo54, RowLayoutColumnInfo55, RowLayoutColumnInfo56, RowLayoutColumnInfo57, RowLayoutColumnInfo58, RowLayoutColumnInfo59, RowLayoutColumnInfo60, RowLayoutColumnInfo61, RowLayoutColumnInfo62, RowLayoutColumnInfo63, RowLayoutColumnInfo64, RowLayoutColumnInfo65, RowLayoutColumnInfo66, RowLayoutColumnInfo67, RowLayoutColumnInfo68, RowLayoutColumnInfo69, RowLayoutColumnInfo70, RowLayoutColumnInfo71, RowLayoutColumnInfo72, RowLayoutColumnInfo73, RowLayoutColumnInfo74, RowLayoutColumnInfo75, RowLayoutColumnInfo76, RowLayoutColumnInfo77, RowLayoutColumnInfo78, RowLayoutColumnInfo79, RowLayoutColumnInfo80})
        RowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        UltraGridBand1.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout1})
        UltraGridBand1.SummaryFooterCaption = "Totales:"
        Me.griViajesElimina.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griViajesElimina.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesElimina.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesElimina.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance28.FontData.BoldAsString = "True"
        Me.griViajesElimina.DisplayLayout.Override.HeaderAppearance = Appearance28
        Me.griViajesElimina.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesElimina.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesElimina.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesElimina.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesElimina.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesElimina.Dock = System.Windows.Forms.DockStyle.Top
        Me.griViajesElimina.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesElimina.ImageList = Me.imagenes
        Me.griViajesElimina.Location = New System.Drawing.Point(3, 16)
        Me.griViajesElimina.Name = "griViajesElimina"
        Me.griViajesElimina.Size = New System.Drawing.Size(578, 100)
        Me.griViajesElimina.TabIndex = 5
        Me.griViajesElimina.Tag = ""
        '
        'Agrupacion6
        '
        Appearance29.BackColor = System.Drawing.Color.White
        Appearance29.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion6.ContentAreaAppearance = Appearance29
        Me.Agrupacion6.Controls.Add(Me.griViajesElimina)
        Me.Agrupacion6.Controls.Add(Me.btnCerrar)
        Me.Agrupacion6.Controls.Add(Me.btnEliminar)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(584, 161)
        Me.Agrupacion6.TabIndex = 11
        Me.Agrupacion6.Text = "VIAJES EN UNA OPERACION"
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(70, 48)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 12
        Me.ugb_Espera.Visible = False
        '
        'frm_ViajesOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 161)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.Agrupacion6)
        Me.Name = "frm_ViajesOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViajesOperacion"
        CType(Me.ogdListaOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griViajesElimina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents ogdListaOperacion As ISL.Controles.OrigenDatos
    Friend WithEvents btnCerrar As ISL.Controles.Boton
    Friend WithEvents btnEliminar As ISL.Controles.Boton
    Friend WithEvents griViajesElimina As ISL.Controles.Grilla
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
