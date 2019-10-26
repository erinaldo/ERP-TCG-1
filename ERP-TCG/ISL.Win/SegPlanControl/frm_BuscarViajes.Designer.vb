<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BuscarViajes
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
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoComplejoOrigen")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaOrigen")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoCargaOrigen")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImpresionGuiaOrigen")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaAproximadaDestino")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoDestino")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescargaDestino")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoDescargaDestino")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCarga")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Produccion")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPlanilla")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTercero")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
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
        Dim CalculatorButton1 As Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton = New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15)
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
        Me.ogdListaOperacion = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.UltraExpandableGroupBox7 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel15 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
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
        Me.Colores6 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores7 = New ISL.Controles.Colores(Me.components)
        Me.ColorParihuelero = New ISL.Controles.Colores(Me.components)
        Me.Colores8 = New ISL.Controles.Colores(Me.components)
        Me.ColorPlataforma = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta48 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion20M3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta49 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTolvaVolteo = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta52 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores9 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores10 = New ISL.Controles.Colores(Me.components)
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
        Me.CalculadoraGrilla = New Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown()
        Me.colorCambio = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta44 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorCargaConsolidada = New ISL.Controles.Colores(Me.components)
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.verPilotoLista = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboPilotoLista = New ISL.Controles.ComboMaestros(Me.components)
        Me.verCarretaLista = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboCarretaLista = New ISL.Controles.Combo(Me.components)
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.verTracto = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboTractoLista = New ISL.Controles.Combo(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboUsuario = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel62 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboZona = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        CType(Me.ogdListaOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaRegistro.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Colores6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorParihuelero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPlataforma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion20M3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTolvaVolteo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores10, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.CalculadoraGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCargaConsolidada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox4.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel12.SuspendLayout()
        CType(Me.verPilotoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPilotoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCarretaLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCarretaLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboZona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ogdListaOperacion
        '
        UltraDataColumn11.DataType = GetType(Boolean)
        UltraDataColumn26.DataType = GetType(Date)
        UltraDataColumn41.DataType = GetType(Date)
        UltraDataColumn42.DataType = GetType(Date)
        UltraDataColumn43.DataType = GetType(Date)
        UltraDataColumn44.DataType = GetType(Date)
        UltraDataColumn46.DefaultValue = ""
        UltraDataColumn50.DataType = GetType(Decimal)
        UltraDataColumn52.DataType = GetType(Decimal)
        UltraDataColumn75.DataType = GetType(Date)
        UltraDataColumn76.DataType = GetType(Date)
        Me.ogdListaOperacion.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80})
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(1064, 367)
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(1064, 367)
        Me.UltraExpandableGroupBox1.TabIndex = 4
        Me.UltraExpandableGroupBox1.Text = "Buscar Viaje"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.agrListaRegistro)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraExpandableGroupBox7)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1058, 344)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.ugb_Espera)
        Me.agrListaRegistro.Controls.Add(Me.griLista)
        Me.agrListaRegistro.Location = New System.Drawing.Point(3, 147)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(1058, 189)
        Me.agrListaRegistro.TabIndex = 3
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista Registro"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(347, -12)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 13
        Me.ugb_Espera.Visible = False
        '
        'griLista
        '
        UltraGridColumn216.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn216.Header.Fixed = True
        UltraGridColumn216.Header.VisiblePosition = 0
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn217.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        UltraGridColumn217.CellAppearance = Appearance1
        UltraGridColumn217.Header.Fixed = True
        UltraGridColumn217.Header.VisiblePosition = 1
        UltraGridColumn217.Hidden = True
        UltraGridColumn217.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn217.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn217.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn217.Width = 95
        UltraGridColumn218.Header.Fixed = True
        UltraGridColumn218.Header.VisiblePosition = 2
        UltraGridColumn218.Hidden = True
        UltraGridColumn219.Header.Caption = "Viaje"
        UltraGridColumn219.Header.Fixed = True
        UltraGridColumn219.Header.VisiblePosition = 4
        UltraGridColumn219.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn219.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn219.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn219.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn219.Width = 95
        UltraGridColumn220.Header.Fixed = True
        UltraGridColumn220.Header.VisiblePosition = 6
        UltraGridColumn220.Hidden = True
        UltraGridColumn221.Header.VisiblePosition = 11
        UltraGridColumn221.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn221.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn221.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn221.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn221.Width = 113
        UltraGridColumn222.Header.VisiblePosition = 12
        UltraGridColumn222.Hidden = True
        UltraGridColumn223.Header.VisiblePosition = 13
        UltraGridColumn223.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn223.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn223.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn223.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn223.Width = 109
        UltraGridColumn224.Header.VisiblePosition = 14
        UltraGridColumn224.Hidden = True
        UltraGridColumn225.Header.VisiblePosition = 15
        UltraGridColumn225.Hidden = True
        UltraGridColumn225.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn225.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn225.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn225.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn225.Width = 124
        UltraGridColumn226.Header.Caption = "Vacio"
        UltraGridColumn226.Header.VisiblePosition = 52
        UltraGridColumn226.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn226.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn226.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn226.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn226.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn226.Width = 32
        UltraGridColumn227.Header.VisiblePosition = 16
        UltraGridColumn227.Hidden = True
        Appearance2.Image = 7
        UltraGridColumn228.CellAppearance = Appearance2
        Appearance3.Image = 3
        UltraGridColumn228.CellButtonAppearance = Appearance3
        UltraGridColumn228.Header.VisiblePosition = 17
        UltraGridColumn228.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn228.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn228.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn228.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn228.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn228.Width = 150
        UltraGridColumn229.Header.VisiblePosition = 18
        UltraGridColumn229.Hidden = True
        UltraGridColumn230.Header.VisiblePosition = 19
        UltraGridColumn230.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn230.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn230.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn230.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn230.Width = 150
        UltraGridColumn231.Header.VisiblePosition = 23
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.VisiblePosition = 24
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn233.Header.Fixed = True
        UltraGridColumn233.Header.VisiblePosition = 7
        UltraGridColumn233.Hidden = True
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        UltraGridColumn234.CellAppearance = Appearance4
        UltraGridColumn234.Header.Fixed = True
        UltraGridColumn234.Header.VisiblePosition = 8
        UltraGridColumn234.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn234.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn234.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn234.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn234.Width = 80
        UltraGridColumn235.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn235.Header.Fixed = True
        UltraGridColumn235.Header.VisiblePosition = 9
        UltraGridColumn235.Hidden = True
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        UltraGridColumn236.CellAppearance = Appearance5
        UltraGridColumn236.Header.Fixed = True
        UltraGridColumn236.Header.VisiblePosition = 10
        UltraGridColumn236.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn236.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn236.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn236.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn236.Width = 71
        UltraGridColumn237.Header.VisiblePosition = 27
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.Header.VisiblePosition = 25
        UltraGridColumn238.Hidden = True
        UltraGridColumn239.Header.VisiblePosition = 26
        UltraGridColumn239.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn239.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn239.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn239.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn239.Width = 100
        UltraGridColumn240.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn240.Header.Caption = "FechaAtencion"
        UltraGridColumn240.Header.Fixed = True
        UltraGridColumn240.Header.VisiblePosition = 5
        UltraGridColumn240.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn240.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn240.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn240.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn240.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn240.Width = 100
        UltraGridColumn241.Header.Caption = "UsuarioCrea"
        UltraGridColumn241.Header.VisiblePosition = 44
        UltraGridColumn241.Hidden = True
        UltraGridColumn241.Width = 150
        UltraGridColumn242.Header.VisiblePosition = 28
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn243.Header.Caption = "Valida"
        UltraGridColumn243.Header.Fixed = True
        UltraGridColumn243.Header.VisiblePosition = 3
        UltraGridColumn243.Hidden = True
        UltraGridColumn243.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn243.Width = 35
        UltraGridColumn244.Header.VisiblePosition = 29
        UltraGridColumn244.Hidden = True
        UltraGridColumn245.Header.VisiblePosition = 51
        UltraGridColumn245.Width = 100
        UltraGridColumn246.Header.VisiblePosition = 30
        UltraGridColumn246.Hidden = True
        UltraGridColumn247.Header.VisiblePosition = 31
        UltraGridColumn247.Hidden = True
        UltraGridColumn248.Header.VisiblePosition = 32
        UltraGridColumn248.Hidden = True
        UltraGridColumn249.Header.VisiblePosition = 22
        UltraGridColumn249.Width = 200
        UltraGridColumn250.Header.VisiblePosition = 33
        UltraGridColumn250.Hidden = True
        UltraGridColumn251.Header.VisiblePosition = 34
        UltraGridColumn251.Hidden = True
        UltraGridColumn252.Header.VisiblePosition = 35
        UltraGridColumn252.Hidden = True
        UltraGridColumn253.Header.VisiblePosition = 45
        UltraGridColumn253.Width = 150
        UltraGridColumn254.Header.Caption = "UsuarioOperacion"
        UltraGridColumn254.Header.VisiblePosition = 46
        UltraGridColumn254.Width = 150
        UltraGridColumn255.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn255.Header.VisiblePosition = 36
        UltraGridColumn255.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn255.Width = 100
        UltraGridColumn256.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn256.Header.VisiblePosition = 37
        UltraGridColumn256.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn256.Width = 100
        UltraGridColumn257.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn257.Header.VisiblePosition = 38
        UltraGridColumn257.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn257.Width = 100
        UltraGridColumn258.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn258.Header.VisiblePosition = 39
        UltraGridColumn258.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn258.Width = 100
        UltraGridColumn259.Header.VisiblePosition = 50
        UltraGridColumn259.Width = 100
        UltraGridColumn260.Header.VisiblePosition = 48
        UltraGridColumn260.Width = 250
        Appearance6.Image = 3
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn261.CellAppearance = Appearance6
        Appearance7.Image = 1
        UltraGridColumn261.CellButtonAppearance = Appearance7
        UltraGridColumn261.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn261.Header.VisiblePosition = 47
        UltraGridColumn261.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn261.Width = 250
        UltraGridColumn262.Header.VisiblePosition = 53
        UltraGridColumn262.Width = 35
        UltraGridColumn263.Header.Caption = "D/N"
        UltraGridColumn263.Header.VisiblePosition = 54
        UltraGridColumn263.Width = 35
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn264.CellAppearance = Appearance8
        UltraGridColumn264.Header.Caption = "TN"
        UltraGridColumn264.Header.VisiblePosition = 21
        UltraGridColumn264.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn264.Width = 40
        UltraGridColumn265.Header.VisiblePosition = 49
        UltraGridColumn265.Width = 100
        UltraGridColumn266.Header.Caption = "KmTracto O"
        UltraGridColumn266.Header.VisiblePosition = 40
        UltraGridColumn266.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn266.Width = 70
        UltraGridColumn267.Header.Caption = "KmTracto D"
        UltraGridColumn267.Header.VisiblePosition = 41
        UltraGridColumn267.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn267.Width = 70
        UltraGridColumn268.Header.Caption = "KmCarreta O"
        UltraGridColumn268.Header.VisiblePosition = 42
        UltraGridColumn268.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn268.Width = 70
        UltraGridColumn269.Header.Caption = "KmCarreta D"
        UltraGridColumn269.Header.VisiblePosition = 43
        UltraGridColumn269.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn269.Width = 70
        UltraGridColumn270.Header.VisiblePosition = 55
        UltraGridColumn270.Hidden = True
        UltraGridColumn271.Header.VisiblePosition = 20
        UltraGridColumn271.Width = 100
        UltraGridColumn272.Header.VisiblePosition = 56
        UltraGridColumn272.Hidden = True
        UltraGridColumn273.Header.VisiblePosition = 57
        UltraGridColumn273.Hidden = True
        UltraGridColumn274.Header.VisiblePosition = 58
        UltraGridColumn274.Hidden = True
        UltraGridColumn274.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn275.Header.VisiblePosition = 59
        UltraGridColumn275.Hidden = True
        UltraGridColumn275.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn276.Header.VisiblePosition = 60
        UltraGridColumn276.Hidden = True
        UltraGridColumn276.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn277.Header.VisiblePosition = 61
        UltraGridColumn277.Hidden = True
        UltraGridColumn277.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn278.Header.VisiblePosition = 62
        UltraGridColumn278.Hidden = True
        UltraGridColumn278.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn279.Header.VisiblePosition = 63
        UltraGridColumn279.Hidden = True
        UltraGridColumn279.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn280.Header.VisiblePosition = 64
        UltraGridColumn280.Hidden = True
        UltraGridColumn280.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn281.Header.VisiblePosition = 65
        UltraGridColumn281.Hidden = True
        UltraGridColumn281.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn282.Header.VisiblePosition = 66
        UltraGridColumn282.Hidden = True
        UltraGridColumn283.Header.VisiblePosition = 67
        UltraGridColumn283.Hidden = True
        UltraGridColumn284.Header.VisiblePosition = 68
        UltraGridColumn284.Hidden = True
        UltraGridColumn285.Header.VisiblePosition = 70
        UltraGridColumn286.Header.VisiblePosition = 71
        UltraGridColumn286.Hidden = True
        UltraGridColumn287.Header.VisiblePosition = 72
        UltraGridColumn287.Hidden = True
        UltraGridColumn288.Header.Caption = "Retorno"
        UltraGridColumn288.Header.VisiblePosition = 69
        UltraGridColumn288.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn288.Width = 40
        UltraGridColumn289.Header.VisiblePosition = 73
        UltraGridColumn290.Header.VisiblePosition = 74
        UltraGridColumn291.Header.VisiblePosition = 75
        UltraGridColumn291.Hidden = True
        UltraGridColumn292.Header.VisiblePosition = 76
        UltraGridColumn292.Hidden = True
        UltraGridColumn293.Header.VisiblePosition = 77
        UltraGridColumn293.Hidden = True
        UltraGridColumn294.Header.VisiblePosition = 78
        UltraGridColumn294.Hidden = True
        UltraGridColumn295.Header.VisiblePosition = 79
        UltraGridColumn295.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295})
        UltraGridBand1.GroupHeadersVisible = False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
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
        Me.griLista.Location = New System.Drawing.Point(3, 17)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1052, 169)
        Me.griLista.TabIndex = 13
        Me.griLista.Tag = ""
        '
        'UltraExpandableGroupBox7
        '
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox7.ContentAreaAppearance = Appearance9
        Me.UltraExpandableGroupBox7.Controls.Add(Me.UltraExpandableGroupBoxPanel15)
        Me.UltraExpandableGroupBox7.ExpandedSize = New System.Drawing.Size(711, 147)
        Me.UltraExpandableGroupBox7.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox7.Location = New System.Drawing.Point(350, 0)
        Me.UltraExpandableGroupBox7.Name = "UltraExpandableGroupBox7"
        Me.UltraExpandableGroupBox7.Size = New System.Drawing.Size(711, 147)
        Me.UltraExpandableGroupBox7.TabIndex = 2
        Me.UltraExpandableGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel15
        '
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.grupoEstado)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.grupoTipoVehiculo)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.CalculadoraGrilla)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.colorCambio)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.Etiqueta45)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.Etiqueta44)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.colorCargaConsolidada)
        Me.UltraExpandableGroupBoxPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel15.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel15.Name = "UltraExpandableGroupBoxPanel15"
        Me.UltraExpandableGroupBoxPanel15.Size = New System.Drawing.Size(690, 141)
        Me.UltraExpandableGroupBoxPanel15.TabIndex = 0
        '
        'grupoEstado
        '
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.grupoEstado.ContentAreaAppearance = Appearance10
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
        Me.grupoEstado.Location = New System.Drawing.Point(0, 89)
        Me.grupoEstado.Name = "grupoEstado"
        Me.grupoEstado.Size = New System.Drawing.Size(570, 30)
        Me.grupoEstado.TabIndex = 2
        Me.grupoEstado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorFin
        '
        Me.ColorFin.Color = System.Drawing.Color.LimeGreen
        Me.ColorFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFin.Location = New System.Drawing.Point(515, 5)
        Me.ColorFin.Name = "ColorFin"
        Me.ColorFin.Size = New System.Drawing.Size(43, 19)
        Me.ColorFin.TabIndex = 9
        Me.ColorFin.Text = "LimeGreen"
        '
        'ColorProgramado
        '
        Me.ColorProgramado.Color = System.Drawing.Color.White
        Me.ColorProgramado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorProgramado.Location = New System.Drawing.Point(87, 5)
        Me.ColorProgramado.Name = "ColorProgramado"
        Me.ColorProgramado.Size = New System.Drawing.Size(44, 19)
        Me.ColorProgramado.TabIndex = 1
        Me.ColorProgramado.Text = "White"
        '
        'ColorCarga
        '
        Me.ColorCarga.Color = System.Drawing.Color.Yellow
        Me.ColorCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCarga.Location = New System.Drawing.Point(201, 5)
        Me.ColorCarga.Name = "ColorCarga"
        Me.ColorCarga.Size = New System.Drawing.Size(44, 19)
        Me.ColorCarga.TabIndex = 3
        Me.ColorCarga.Text = "Yellow"
        '
        'Etiqueta6
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance11
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(19, 7)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(68, 14)
        Me.Etiqueta6.TabIndex = 0
        Me.Etiqueta6.Text = "Programado:"
        '
        'Etiqueta5
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance12
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(164, 7)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Carga:"
        '
        'ColorTransito
        '
        Me.ColorTransito.Color = System.Drawing.Color.DarkOrange
        Me.ColorTransito.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTransito.Location = New System.Drawing.Point(319, 5)
        Me.ColorTransito.Name = "ColorTransito"
        Me.ColorTransito.Size = New System.Drawing.Size(43, 19)
        Me.ColorTransito.TabIndex = 5
        Me.ColorTransito.Text = "DarkOrange"
        '
        'Etiqueta7
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance13
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(492, 7)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(22, 14)
        Me.Etiqueta7.TabIndex = 8
        Me.Etiqueta7.Text = "Fin:"
        '
        'ColorDescarga
        '
        Me.ColorDescarga.Color = System.Drawing.Color.Silver
        Me.ColorDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorDescarga.Location = New System.Drawing.Point(428, 5)
        Me.ColorDescarga.Name = "ColorDescarga"
        Me.ColorDescarga.Size = New System.Drawing.Size(43, 19)
        Me.ColorDescarga.TabIndex = 7
        Me.ColorDescarga.Text = "Silver"
        '
        'Etiqueta4
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance14
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
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance15
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
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.BackColor2 = System.Drawing.Color.White
        Me.grupoTipoVehiculo.ContentAreaAppearance = Appearance16
        Me.grupoTipoVehiculo.Controls.Add(Me.Colores6)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta47)
        Me.grupoTipoVehiculo.Controls.Add(Me.Colores7)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorParihuelero)
        Me.grupoTipoVehiculo.Controls.Add(Me.Colores8)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorPlataforma)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta48)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion20M3)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta49)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta29)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta50)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta28)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta51)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorTolvaVolteo)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta52)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta27)
        Me.grupoTipoVehiculo.Controls.Add(Me.Colores9)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta25)
        Me.grupoTipoVehiculo.Controls.Add(Me.Colores10)
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
        Me.grupoTipoVehiculo.Location = New System.Drawing.Point(0, -1)
        Me.grupoTipoVehiculo.Name = "grupoTipoVehiculo"
        Me.grupoTipoVehiculo.Size = New System.Drawing.Size(570, 90)
        Me.grupoTipoVehiculo.TabIndex = 0
        Me.grupoTipoVehiculo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Colores6
        '
        Me.Colores6.Color = System.Drawing.Color.RosyBrown
        Me.Colores6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores6.Location = New System.Drawing.Point(319, 67)
        Me.Colores6.Name = "Colores6"
        Me.Colores6.Size = New System.Drawing.Size(44, 19)
        Me.Colores6.TabIndex = 34
        Me.Colores6.Text = "RosyBrown"
        '
        'Etiqueta47
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta47.Appearance = Appearance17
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta47.Location = New System.Drawing.Point(253, 31)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta47.TabIndex = 14
        Me.Etiqueta47.Text = "Parihuelero:"
        '
        'Colores7
        '
        Me.Colores7.Color = System.Drawing.Color.MediumSpringGreen
        Me.Colores7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores7.Location = New System.Drawing.Point(427, 67)
        Me.Colores7.Name = "Colores7"
        Me.Colores7.Size = New System.Drawing.Size(44, 19)
        Me.Colores7.TabIndex = 36
        Me.Colores7.Text = "MediumSpringGreen"
        '
        'ColorParihuelero
        '
        Me.ColorParihuelero.Color = System.Drawing.Color.PaleGreen
        Me.ColorParihuelero.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorParihuelero.Location = New System.Drawing.Point(319, 27)
        Me.ColorParihuelero.Name = "ColorParihuelero"
        Me.ColorParihuelero.Size = New System.Drawing.Size(44, 19)
        Me.ColorParihuelero.TabIndex = 15
        Me.ColorParihuelero.Text = "PaleGreen"
        '
        'Colores8
        '
        Me.Colores8.Color = System.Drawing.Color.OliveDrab
        Me.Colores8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores8.Location = New System.Drawing.Point(201, 67)
        Me.Colores8.Name = "Colores8"
        Me.Colores8.Size = New System.Drawing.Size(44, 19)
        Me.Colores8.TabIndex = 32
        Me.Colores8.Text = "OliveDrab"
        '
        'ColorPlataforma
        '
        Me.ColorPlataforma.Color = System.Drawing.Color.Coral
        Me.ColorPlataforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPlataforma.Location = New System.Drawing.Point(88, 7)
        Me.ColorPlataforma.Name = "ColorPlataforma"
        Me.ColorPlataforma.Size = New System.Drawing.Size(44, 19)
        Me.ColorPlataforma.TabIndex = 1
        Me.ColorPlataforma.Text = "Coral"
        '
        'Etiqueta48
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta48.Appearance = Appearance18
        Me.Etiqueta48.AutoSize = True
        Me.Etiqueta48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta48.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta48.Location = New System.Drawing.Point(269, 70)
        Me.Etiqueta48.Name = "Etiqueta48"
        Me.Etiqueta48.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta48.TabIndex = 33
        Me.Etiqueta48.Text = "Nuevo 3:"
        '
        'ColorCamion20M3
        '
        Me.ColorCamion20M3.Color = System.Drawing.Color.PaleTurquoise
        Me.ColorCamion20M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion20M3.Location = New System.Drawing.Point(515, 7)
        Me.ColorCamion20M3.Name = "ColorCamion20M3"
        Me.ColorCamion20M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion20M3.TabIndex = 9
        Me.ColorCamion20M3.Text = "PaleTurquoise"
        '
        'Etiqueta49
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta49.Appearance = Appearance19
        Me.Etiqueta49.AutoSize = True
        Me.Etiqueta49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta49.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta49.Location = New System.Drawing.Point(377, 71)
        Me.Etiqueta49.Name = "Etiqueta49"
        Me.Etiqueta49.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta49.TabIndex = 35
        Me.Etiqueta49.Text = "Nuevo 4:"
        '
        'Etiqueta29
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance20
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta29.Location = New System.Drawing.Point(365, 31)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta29.TabIndex = 16
        Me.Etiqueta29.Text = "Camioneta:"
        '
        'Etiqueta50
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta50.Appearance = Appearance21
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta50.Location = New System.Drawing.Point(37, 70)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta50.TabIndex = 29
        Me.Etiqueta50.Text = "Nuevo 1:"
        '
        'Etiqueta28
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance22
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(156, 10)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta28.TabIndex = 2
        Me.Etiqueta28.Text = "Furgon:"
        '
        'Etiqueta51
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta51.Appearance = Appearance23
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(475, 70)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta51.TabIndex = 37
        Me.Etiqueta51.Text = "50 M3:"
        '
        'ColorTolvaVolteo
        '
        Me.ColorTolvaVolteo.Color = System.Drawing.Color.RosyBrown
        Me.ColorTolvaVolteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTolvaVolteo.Location = New System.Drawing.Point(319, 47)
        Me.ColorTolvaVolteo.Name = "ColorTolvaVolteo"
        Me.ColorTolvaVolteo.Size = New System.Drawing.Size(44, 19)
        Me.ColorTolvaVolteo.TabIndex = 24
        Me.ColorTolvaVolteo.Text = "RosyBrown"
        '
        'Etiqueta52
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta52.Appearance = Appearance24
        Me.Etiqueta52.AutoSize = True
        Me.Etiqueta52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta52.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta52.Location = New System.Drawing.Point(150, 70)
        Me.Etiqueta52.Name = "Etiqueta52"
        Me.Etiqueta52.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta52.TabIndex = 31
        Me.Etiqueta52.Text = "Nuevo 2:"
        '
        'Etiqueta27
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance25
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(374, 10)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta27.TabIndex = 6
        Me.Etiqueta27.Text = "Volquete:"
        '
        'Colores9
        '
        Me.Colores9.Color = System.Drawing.Color.Violet
        Me.Colores9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores9.Location = New System.Drawing.Point(515, 67)
        Me.Colores9.Name = "Colores9"
        Me.Colores9.Size = New System.Drawing.Size(44, 19)
        Me.Colores9.TabIndex = 38
        Me.Colores9.Text = "Violet"
        '
        'Etiqueta25
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance26
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(260, 11)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta25.TabIndex = 4
        Me.Etiqueta25.Text = "Granelero:"
        '
        'Colores10
        '
        Me.Colores10.Color = System.Drawing.Color.Orange
        Me.Colores10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores10.Location = New System.Drawing.Point(88, 67)
        Me.Colores10.Name = "Colores10"
        Me.Colores10.Size = New System.Drawing.Size(44, 19)
        Me.Colores10.TabIndex = 30
        Me.Colores10.Text = "Orange"
        '
        'ColorCamion65M3
        '
        Me.ColorCamion65M3.Color = System.Drawing.Color.MediumSpringGreen
        Me.ColorCamion65M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion65M3.Location = New System.Drawing.Point(427, 47)
        Me.ColorCamion65M3.Name = "ColorCamion65M3"
        Me.ColorCamion65M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion65M3.TabIndex = 26
        Me.ColorCamion65M3.Text = "MediumSpringGreen"
        '
        'ColorContenedor
        '
        Me.ColorContenedor.Color = System.Drawing.Color.OliveDrab
        Me.ColorContenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorContenedor.Location = New System.Drawing.Point(201, 47)
        Me.ColorContenedor.Name = "ColorContenedor"
        Me.ColorContenedor.Size = New System.Drawing.Size(44, 19)
        Me.ColorContenedor.TabIndex = 22
        Me.ColorContenedor.Text = "OliveDrab"
        '
        'Etiqueta222
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta222.Appearance = Appearance27
        Me.Etiqueta222.AutoSize = True
        Me.Etiqueta222.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta222.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta222.Location = New System.Drawing.Point(475, 10)
        Me.Etiqueta222.Name = "Etiqueta222"
        Me.Etiqueta222.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta222.TabIndex = 8
        Me.Etiqueta222.Text = "20 M3:"
        '
        'ColorGranelero
        '
        Me.ColorGranelero.Color = System.Drawing.Color.YellowGreen
        Me.ColorGranelero.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorGranelero.Location = New System.Drawing.Point(319, 7)
        Me.ColorGranelero.Name = "ColorGranelero"
        Me.ColorGranelero.Size = New System.Drawing.Size(44, 19)
        Me.ColorGranelero.TabIndex = 5
        Me.ColorGranelero.Text = "YellowGreen"
        '
        'ColorFurgon
        '
        Me.ColorFurgon.Color = System.Drawing.Color.Gold
        Me.ColorFurgon.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgon.Location = New System.Drawing.Point(201, 7)
        Me.ColorFurgon.Name = "ColorFurgon"
        Me.ColorFurgon.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgon.TabIndex = 3
        Me.ColorFurgon.Text = "Gold"
        '
        'ColorFurgonLargo
        '
        Me.ColorFurgonLargo.Color = System.Drawing.Color.PeachPuff
        Me.ColorFurgonLargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonLargo.Location = New System.Drawing.Point(88, 27)
        Me.ColorFurgonLargo.Name = "ColorFurgonLargo"
        Me.ColorFurgonLargo.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonLargo.TabIndex = 11
        Me.ColorFurgonLargo.Text = "PeachPuff"
        '
        'Etiqueta24
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance28
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(26, 10)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta24.TabIndex = 0
        Me.Etiqueta24.Text = "Plataforma:"
        '
        'Etiqueta30
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance29
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta30.Location = New System.Drawing.Point(248, 50)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta30.TabIndex = 23
        Me.Etiqueta30.Text = "Tolva Volteo:"
        '
        'Etiqueta21
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance30
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(388, 51)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta21.TabIndex = 25
        Me.Etiqueta21.Text = "65 M3:"
        '
        'ColorCamioneta
        '
        Me.ColorCamioneta.Color = System.Drawing.Color.LightSeaGreen
        Me.ColorCamioneta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamioneta.Location = New System.Drawing.Point(427, 27)
        Me.ColorCamioneta.Name = "ColorCamioneta"
        Me.ColorCamioneta.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamioneta.TabIndex = 17
        Me.ColorCamioneta.Text = "LightSeaGreen"
        '
        'ColorVolquete
        '
        Me.ColorVolquete.Color = System.Drawing.Color.Peru
        Me.ColorVolquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorVolquete.Location = New System.Drawing.Point(427, 7)
        Me.ColorVolquete.Name = "ColorVolquete"
        Me.ColorVolquete.Size = New System.Drawing.Size(44, 19)
        Me.ColorVolquete.TabIndex = 7
        Me.ColorVolquete.Text = "Peru"
        '
        'Etiqueta31
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance31
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Location = New System.Drawing.Point(13, 30)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta31.TabIndex = 10
        Me.Etiqueta31.Text = "Furgon Largo:"
        '
        'Etiqueta32
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance32
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(4, 50)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(84, 14)
        Me.Etiqueta32.TabIndex = 19
        Me.Etiqueta32.Text = "Media Baranda:"
        '
        'Etiqueta23
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance33
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(475, 50)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta23.TabIndex = 27
        Me.Etiqueta23.Text = "40 M3:"
        '
        'ColorCamion30M3
        '
        Me.ColorCamion30M3.Color = System.Drawing.Color.DeepSkyBlue
        Me.ColorCamion30M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion30M3.Location = New System.Drawing.Point(515, 27)
        Me.ColorCamion30M3.Name = "ColorCamion30M3"
        Me.ColorCamion30M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion30M3.TabIndex = 18
        Me.ColorCamion30M3.Text = "DeepSkyBlue"
        '
        'Etiqueta20
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance34
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(134, 50)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta20.TabIndex = 21
        Me.Etiqueta20.Text = "Contenedor:"
        '
        'Etiqueta26
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance35
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(150, 31)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta26.TabIndex = 12
        Me.Etiqueta26.Text = "Calicera:"
        '
        'ColorCalicera
        '
        Me.ColorCalicera.Color = System.Drawing.Color.DarkKhaki
        Me.ColorCalicera.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCalicera.Location = New System.Drawing.Point(201, 27)
        Me.ColorCalicera.Name = "ColorCalicera"
        Me.ColorCalicera.Size = New System.Drawing.Size(44, 19)
        Me.ColorCalicera.TabIndex = 13
        Me.ColorCalicera.Text = "DarkKhaki"
        '
        'ColorCamion40M3
        '
        Me.ColorCamion40M3.Color = System.Drawing.Color.Violet
        Me.ColorCamion40M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion40M3.Location = New System.Drawing.Point(515, 47)
        Me.ColorCamion40M3.Name = "ColorCamion40M3"
        Me.ColorCamion40M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion40M3.TabIndex = 28
        Me.ColorCamion40M3.Text = "Violet"
        '
        'Etiqueta22
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance36
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(475, 31)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta22.TabIndex = 62
        Me.Etiqueta22.Text = "30 M3:"
        '
        'ColorMediaBaranda
        '
        Me.ColorMediaBaranda.Color = System.Drawing.Color.Orange
        Me.ColorMediaBaranda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorMediaBaranda.Location = New System.Drawing.Point(88, 47)
        Me.ColorMediaBaranda.Name = "ColorMediaBaranda"
        Me.ColorMediaBaranda.Size = New System.Drawing.Size(44, 19)
        Me.ColorMediaBaranda.TabIndex = 20
        Me.ColorMediaBaranda.Text = "Orange"
        '
        'CalculadoraGrilla
        '
        Appearance37.TextHAlignAsString = "Right"
        Me.CalculadoraGrilla.Appearance = Appearance37
        CalculatorButton1.Key = "."
        CalculatorButton1.KeyCodeAlternateValue = 190
        CalculatorButton1.KeyCodeValue = 110
        CalculatorButton1.Text = ","
        Me.CalculadoraGrilla.Buttons.AddRange(New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton() {CalculatorButton1})
        Me.CalculadoraGrilla.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CalculadoraGrilla.Location = New System.Drawing.Point(574, 4)
        Me.CalculadoraGrilla.MaxLength = 15
        Me.CalculadoraGrilla.Name = "CalculadoraGrilla"
        Me.CalculadoraGrilla.NullText = "0.00"
        Me.CalculadoraGrilla.Size = New System.Drawing.Size(100, 22)
        Me.CalculadoraGrilla.TabIndex = 1
        Me.CalculadoraGrilla.Text = "0.00"
        '
        'colorCambio
        '
        Me.colorCambio.Color = System.Drawing.Color.Cyan
        Me.colorCambio.Location = New System.Drawing.Point(582, 88)
        Me.colorCambio.Name = "colorCambio"
        Me.colorCambio.Size = New System.Drawing.Size(44, 22)
        Me.colorCambio.TabIndex = 8
        Me.colorCambio.Text = "Cyan"
        '
        'Etiqueta45
        '
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta45.Appearance = Appearance38
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(582, 73)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta45.TabIndex = 7
        Me.Etiqueta45.Text = "Actualizado:"
        '
        'Etiqueta44
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta44.Appearance = Appearance39
        Me.Etiqueta44.AutoSize = True
        Me.Etiqueta44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta44.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta44.Location = New System.Drawing.Point(577, 30)
        Me.Etiqueta44.Name = "Etiqueta44"
        Me.Etiqueta44.Size = New System.Drawing.Size(105, 14)
        Me.Etiqueta44.TabIndex = 3
        Me.Etiqueta44.Text = "Carga Consolidada"
        '
        'colorCargaConsolidada
        '
        Me.colorCargaConsolidada.Color = System.Drawing.Color.SaddleBrown
        Me.colorCargaConsolidada.Location = New System.Drawing.Point(581, 45)
        Me.colorCargaConsolidada.Name = "colorCargaConsolidada"
        Me.colorCargaConsolidada.Size = New System.Drawing.Size(44, 22)
        Me.colorCargaConsolidada.TabIndex = 4
        Me.colorCargaConsolidada.Text = "SaddleBrown"
        '
        'UltraExpandableGroupBox4
        '
        Appearance40.BackColor = System.Drawing.Color.White
        Appearance40.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox4.ContentAreaAppearance = Appearance40
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(350, 147)
        Me.UltraExpandableGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(350, 147)
        Me.UltraExpandableGroupBox4.TabIndex = 1
        Me.UltraExpandableGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel12
        '
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.btnConsultar)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.verPilotoLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboPilotoLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.verCarretaLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboCarretaLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraGroupBox13)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.verTracto)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboTractoLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboCentro)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraLabel20)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboUsuario)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraLabel62)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboZona)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraLabel16)
        Me.UltraExpandableGroupBoxPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel12.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel12.Name = "UltraExpandableGroupBoxPanel12"
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(329, 141)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        '
        'btnConsultar
        '
        Appearance41.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnConsultar.Appearance = Appearance41
        Me.btnConsultar.Location = New System.Drawing.Point(254, 117)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 12
        Me.btnConsultar.Text = "Consultar"
        '
        'verPilotoLista
        '
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.verPilotoLista.Appearance = Appearance42
        Me.verPilotoLista.AutoSize = True
        Me.verPilotoLista.Location = New System.Drawing.Point(9, 95)
        Me.verPilotoLista.Name = "verPilotoLista"
        Me.verPilotoLista.Size = New System.Drawing.Size(53, 18)
        Me.verPilotoLista.TabIndex = 10
        Me.verPilotoLista.Text = "Piloto:"
        '
        'cboPilotoLista
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.cboPilotoLista.Appearance = Appearance43
        Me.cboPilotoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPilotoLista.DisplayMember = "Nombre"
        Me.cboPilotoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPilotoLista.Enabled = False
        Me.cboPilotoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPilotoLista.ForeColor = System.Drawing.Color.Black
        Me.cboPilotoLista.Location = New System.Drawing.Point(68, 95)
        Me.cboPilotoLista.Name = "cboPilotoLista"
        Me.cboPilotoLista.Size = New System.Drawing.Size(260, 21)
        Me.cboPilotoLista.TabIndex = 11
        Me.cboPilotoLista.ValueMember = "Id"
        '
        'verCarretaLista
        '
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.verCarretaLista.Appearance = Appearance44
        Me.verCarretaLista.AutoSize = True
        Me.verCarretaLista.Location = New System.Drawing.Point(166, 71)
        Me.verCarretaLista.Name = "verCarretaLista"
        Me.verCarretaLista.Size = New System.Drawing.Size(62, 18)
        Me.verCarretaLista.TabIndex = 8
        Me.verCarretaLista.Text = "Carreta:"
        '
        'cboCarretaLista
        '
        Appearance45.ForeColor = System.Drawing.Color.Black
        Me.cboCarretaLista.Appearance = Appearance45
        Me.cboCarretaLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCarretaLista.DisplayMember = ""
        Me.cboCarretaLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCarretaLista.Enabled = False
        Me.cboCarretaLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarretaLista.ForeColor = System.Drawing.Color.Black
        Me.cboCarretaLista.Location = New System.Drawing.Point(228, 72)
        Me.cboCarretaLista.Name = "cboCarretaLista"
        Me.cboCarretaLista.Size = New System.Drawing.Size(100, 21)
        Me.cboCarretaLista.TabIndex = 9
        Me.cboCarretaLista.ValueMember = "Id"
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel39)
        Me.UltraGroupBox13.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel41)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(3, 3)
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
        Me.fecHasta.Size = New System.Drawing.Size(90, 22)
        Me.fecHasta.TabIndex = 3
        Me.fecHasta.Value = New Date(2014, 8, 15, 0, 0, 0, 0)
        '
        'UltraLabel39
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Appearance46.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance46
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
        Me.fecDesde.Size = New System.Drawing.Size(90, 22)
        Me.fecDesde.TabIndex = 1
        Me.fecDesde.Value = New Date(2014, 8, 15, 0, 0, 0, 0)
        '
        'UltraLabel41
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Appearance47.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance47
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(6, 13)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel41.TabIndex = 0
        Me.UltraLabel41.Text = "Desde:"
        '
        'verTracto
        '
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.verTracto.Appearance = Appearance48
        Me.verTracto.AutoSize = True
        Me.verTracto.Location = New System.Drawing.Point(9, 72)
        Me.verTracto.Name = "verTracto"
        Me.verTracto.Size = New System.Drawing.Size(57, 18)
        Me.verTracto.TabIndex = 6
        Me.verTracto.Text = "Tracto:"
        '
        'cboTractoLista
        '
        Appearance49.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Appearance = Appearance49
        Me.cboTractoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoLista.DisplayMember = ""
        Me.cboTractoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoLista.Enabled = False
        Me.cboTractoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoLista.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Location = New System.Drawing.Point(68, 72)
        Me.cboTractoLista.Name = "cboTractoLista"
        Me.cboTractoLista.Size = New System.Drawing.Size(85, 21)
        Me.cboTractoLista.TabIndex = 7
        Me.cboTractoLista.ValueMember = "Id"
        '
        'cboCentro
        '
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance50
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(228, 26)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(100, 21)
        Me.cboCentro.TabIndex = 4
        Me.cboCentro.ValueMember = "Id"
        '
        'UltraLabel20
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Appearance51.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance51
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(182, 30)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel20.TabIndex = 3
        Me.UltraLabel20.Text = "Centro:"
        '
        'cboUsuario
        '
        Appearance52.ForeColor = System.Drawing.Color.Black
        Me.cboUsuario.Appearance = Appearance52
        Me.cboUsuario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboUsuario.DisplayMember = "Login"
        Me.cboUsuario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboUsuario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsuario.ForeColor = System.Drawing.Color.Black
        Me.cboUsuario.Location = New System.Drawing.Point(228, 3)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(100, 21)
        Me.cboUsuario.TabIndex = 2
        Me.cboUsuario.ValueMember = "Id"
        '
        'UltraLabel62
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Appearance53.TextVAlignAsString = "Middle"
        Me.UltraLabel62.Appearance = Appearance53
        Me.UltraLabel62.AutoSize = True
        Me.UltraLabel62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel62.Location = New System.Drawing.Point(177, 7)
        Me.UltraLabel62.Name = "UltraLabel62"
        Me.UltraLabel62.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel62.TabIndex = 1
        Me.UltraLabel62.Text = "Usuario:"
        '
        'cboZona
        '
        Appearance54.ForeColor = System.Drawing.Color.Black
        Me.cboZona.Appearance = Appearance54
        Me.cboZona.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboZona.DisplayMember = "Nombre"
        Me.cboZona.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboZona.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZona.ForeColor = System.Drawing.Color.Black
        Me.cboZona.Location = New System.Drawing.Point(228, 49)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.Size = New System.Drawing.Size(100, 21)
        Me.cboZona.TabIndex = 5
        Me.cboZona.ValueMember = "Id"
        '
        'UltraLabel16
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Appearance55.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance55
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(191, 54)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel16.TabIndex = 5
        Me.UltraLabel16.Text = "Zona:"
        '
        'frm_BuscarViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 367)
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Name = "frm_BuscarViajes"
        Me.Text = "Viajes"
        CType(Me.ogdListaOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaRegistro.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Colores6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorParihuelero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPlataforma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion20M3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTolvaVolteo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores10, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.CalculadoraGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCargaConsolidada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.PerformLayout()
        CType(Me.verPilotoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPilotoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCarretaLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCarretaLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        Me.UltraGroupBox13.PerformLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboZona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents UltraExpandableGroupBox7 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel15 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnConsultar As Infragistics.Win.Misc.UltraButton
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
    Friend WithEvents grupoTipoVehiculo As ISL.Controles.Agrupacion
    Friend WithEvents Colores6 As ISL.Controles.Colores
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents Colores7 As ISL.Controles.Colores
    Friend WithEvents ColorParihuelero As ISL.Controles.Colores
    Friend WithEvents Colores8 As ISL.Controles.Colores
    Friend WithEvents ColorPlataforma As ISL.Controles.Colores
    Friend WithEvents Etiqueta48 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion20M3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta49 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTolvaVolteo As ISL.Controles.Colores
    Friend WithEvents Etiqueta52 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents Colores9 As ISL.Controles.Colores
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents Colores10 As ISL.Controles.Colores
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
    Friend WithEvents CalculadoraGrilla As Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown
    Friend WithEvents colorCambio As ISL.Controles.Colores
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta44 As ISL.Controles.Etiqueta
    Friend WithEvents colorCargaConsolidada As ISL.Controles.Colores
    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents verPilotoLista As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboPilotoLista As ISL.Controles.ComboMaestros
    Friend WithEvents verCarretaLista As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboCarretaLista As ISL.Controles.Combo
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verTracto As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboTractoLista As ISL.Controles.Combo
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboUsuario As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel62 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboZona As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdListaOperacion As ISL.Controles.OrigenDatos
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
End Class
