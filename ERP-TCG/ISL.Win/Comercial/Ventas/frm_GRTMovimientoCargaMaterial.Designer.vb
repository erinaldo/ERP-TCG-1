<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GRTMovimientoCargaMaterial
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
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
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCarga")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Produccion")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_GRTMovimientoCargaMaterial))
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSeguimiento")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRemitente")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionLugarPartida")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinatario")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionLugarLlegada")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMotivoDocumentoTraslado")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtConfirmada")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubSerie")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubNumero")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubContrata")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionDetalle")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Incidencia")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumentos")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remitente")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destinatario")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtPerdido")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLocalAlmacen")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLocalAlmacen")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Ingrese Numero de GRT", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Ingrese Serie de GRT", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione Tracto", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Indicador de Viajes de Retorno", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione Centro", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo6 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione Actividad de", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo7 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione Remitente de GRT", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaGrt = New ISL.Controles.Grilla(Me.components)
        Me.ogdListaGuias = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griGrtCargaMaterial = New ISL.Controles.Grilla(Me.components)
        Me.MenuGrt = New ISL.Controles.MenuContextual(Me.components)
        Me.Extorno = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabLista = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorDisponible = New ISL.Controles.Colores(Me.components)
        Me.colorSalida = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorIngreso = New ISL.Controles.Colores(Me.components)
        Me.grupoTipoVehiculo = New ISL.Controles.Agrupacion(Me.components)
        Me.griStockAlmacen = New ISL.Controles.Grilla(Me.components)
        Me.ogdStockAlmacen = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumero = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtSerie = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.verTracto = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboTractoLista = New ISL.Controles.Combo(Me.components)
        Me.verViajeRetorno = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel46 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboActividadNegocio = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboRemitenteBusca = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.ficCtrlMerma = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griListaGrt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdListaGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griGrtCargaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuGrt.SuspendLayout()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.tabLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLista.SuspendLayout()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.colorDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoTipoVehiculo.SuspendLayout()
        CType(Me.griStockAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdStockAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verViajeRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboActividadNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRemitenteBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficCtrlMerma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCtrlMerma.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griListaGrt)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(978, 340)
        '
        'griListaGrt
        '
        Me.griListaGrt.DataSource = Me.ogdListaGuias
        UltraGridColumn1.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn1.Header.VisiblePosition = 8
        UltraGridColumn1.Hidden = True
        UltraGridColumn4.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        UltraGridColumn4.CellAppearance = Appearance1
        UltraGridColumn4.Header.Caption = "Viaje"
        UltraGridColumn4.Header.Fixed = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Width = 95
        UltraGridColumn5.Header.VisiblePosition = 10
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "Serie"
        UltraGridColumn6.Header.Fixed = True
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Width = 35
        UltraGridColumn7.Header.Caption = "Actividad O.P."
        UltraGridColumn7.Header.VisiblePosition = 49
        UltraGridColumn7.Width = 100
        UltraGridColumn8.Header.VisiblePosition = 13
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Width = 113
        UltraGridColumn9.Header.Caption = "Local Almacen"
        UltraGridColumn9.Header.VisiblePosition = 29
        UltraGridColumn9.Width = 100
        UltraGridColumn10.Header.VisiblePosition = 14
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Width = 109
        UltraGridColumn11.Header.Caption = "Remitente"
        UltraGridColumn11.Header.VisiblePosition = 17
        UltraGridColumn11.Width = 200
        UltraGridColumn12.Header.Caption = "Destinatario"
        UltraGridColumn12.Header.VisiblePosition = 18
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Width = 200
        UltraGridColumn13.Header.Caption = "Fact."
        UltraGridColumn13.Header.Fixed = True
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn13.Width = 35
        UltraGridColumn14.Header.VisiblePosition = 19
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn15.Width = 200
        UltraGridColumn16.Header.VisiblePosition = 20
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 21
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Width = 183
        UltraGridColumn18.Header.VisiblePosition = 22
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 23
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn20.Header.VisiblePosition = 24
        UltraGridColumn20.Hidden = True
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        UltraGridColumn21.CellAppearance = Appearance2
        UltraGridColumn21.Header.Fixed = True
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Width = 80
        UltraGridColumn22.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn22.Header.VisiblePosition = 25
        UltraGridColumn22.Hidden = True
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        UltraGridColumn23.CellAppearance = Appearance3
        UltraGridColumn23.Header.Fixed = True
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Width = 71
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn24.CellAppearance = Appearance4
        UltraGridColumn24.Header.VisiblePosition = 35
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.MaskInput = "{LOC}n,nnn,nnn.nn"
        UltraGridColumn25.Header.VisiblePosition = 26
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 27
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Width = 100
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn27.Header.Caption = "F. Viaje"
        UltraGridColumn27.Header.VisiblePosition = 11
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn27.Width = 103
        UltraGridColumn28.Header.Caption = "UsuarioOperaciones"
        UltraGridColumn28.Header.VisiblePosition = 45
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.Width = 150
        UltraGridColumn29.Header.VisiblePosition = 36
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn30.Header.Caption = "Valida"
        UltraGridColumn30.Header.VisiblePosition = 9
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn30.Width = 35
        UltraGridColumn31.Header.VisiblePosition = 37
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Appearance5.TextHAlignAsString = "Center"
        Appearance5.TextVAlignAsString = "Middle"
        UltraGridColumn32.CellAppearance = Appearance5
        UltraGridColumn32.Header.Caption = "Operacion"
        UltraGridColumn32.Header.Fixed = True
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn32.Width = 100
        UltraGridColumn33.Header.VisiblePosition = 38
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 39
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 40
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 16
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.Width = 200
        UltraGridColumn37.Header.Caption = "Perdido"
        UltraGridColumn37.Header.VisiblePosition = 58
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn37.Width = 40
        UltraGridColumn38.Header.VisiblePosition = 41
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 42
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.Caption = "UsuarioSeguimiento"
        UltraGridColumn40.Header.VisiblePosition = 46
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.Width = 150
        UltraGridColumn41.Header.Caption = "UsuarioGuias"
        UltraGridColumn41.Header.VisiblePosition = 47
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.Width = 150
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.Header.Caption = "F. GRT"
        UltraGridColumn42.Header.VisiblePosition = 12
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn42.Width = 60
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn43.Header.Caption = "Fec. I/S"
        UltraGridColumn43.Header.VisiblePosition = 30
        UltraGridColumn43.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn43.Width = 70
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn44.Header.VisiblePosition = 43
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn44.Width = 100
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn45.Header.VisiblePosition = 44
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn45.Width = 100
        UltraGridColumn46.Header.Caption = "Numero"
        UltraGridColumn46.Header.Fixed = True
        UltraGridColumn46.Header.VisiblePosition = 5
        UltraGridColumn46.Width = 70
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance6.Image = 3
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn47.CellAppearance = Appearance6
        Appearance7.Image = 1
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn47.CellButtonAppearance = Appearance7
        UltraGridColumn47.Header.Caption = "Sal."
        UltraGridColumn47.Header.VisiblePosition = 48
        UltraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn47.Width = 35
        Appearance8.Image = 3
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn48.CellAppearance = Appearance8
        Appearance9.Image = 1
        UltraGridColumn48.CellButtonAppearance = Appearance9
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn48.Header.Caption = "IncidenciaGuias"
        UltraGridColumn48.Header.VisiblePosition = 51
        UltraGridColumn48.Hidden = True
        UltraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn48.Width = 250
        UltraGridColumn49.Header.VisiblePosition = 52
        UltraGridColumn49.Hidden = True
        UltraGridColumn49.Width = 50
        UltraGridColumn50.Header.Caption = "Doct."
        UltraGridColumn50.Header.VisiblePosition = 57
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn50.Width = 35
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn51.CellAppearance = Appearance10
        UltraGridColumn51.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn51.Header.Caption = "TN"
        UltraGridColumn51.Header.VisiblePosition = 31
        UltraGridColumn51.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn51.Width = 40
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance11.Image = 3
        Appearance11.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn52.CellAppearance = Appearance11
        Appearance12.Image = 1
        Appearance12.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn52.CellButtonAppearance = Appearance12
        UltraGridColumn52.Header.Caption = "Ing."
        UltraGridColumn52.Header.VisiblePosition = 32
        UltraGridColumn52.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn52.Width = 30
        UltraGridColumn53.Header.VisiblePosition = 53
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 54
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 55
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 56
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn57.Header.Caption = "Glosa de I/S Carga de GRT"
        UltraGridColumn57.Header.VisiblePosition = 50
        UltraGridColumn57.Width = 200
        UltraGridColumn58.Header.VisiblePosition = 28
        UltraGridColumn59.Header.Caption = "Ok"
        UltraGridColumn59.Header.Fixed = True
        UltraGridColumn59.Header.VisiblePosition = 0
        UltraGridColumn59.Hidden = True
        UltraGridColumn59.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn59.Width = 35
        UltraGridColumn60.Header.VisiblePosition = 59
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 60
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 61
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 62
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 63
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 64
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 65
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 66
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 67
        UltraGridColumn68.Hidden = True
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn69.CellAppearance = Appearance13
        UltraGridColumn69.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn69.Header.VisiblePosition = 33
        UltraGridColumn69.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn69.Width = 51
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn70.CellAppearance = Appearance14
        UltraGridColumn70.Header.VisiblePosition = 34
        UltraGridColumn70.Hidden = True
        UltraGridColumn70.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridColumn70.Width = 60
        UltraGridColumn71.Header.VisiblePosition = 68
        UltraGridColumn71.Hidden = True
        UltraGridColumn71.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn71.Width = 40
        UltraGridColumn72.Header.Caption = "Retorno"
        UltraGridColumn72.Header.VisiblePosition = 69
        UltraGridColumn72.Hidden = True
        UltraGridColumn72.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn72.Width = 40
        UltraGridColumn141.Header.VisiblePosition = 70
        UltraGridColumn141.Hidden = True
        UltraGridColumn143.Header.Caption = "Indicador"
        UltraGridColumn143.Header.VisiblePosition = 71
        UltraGridColumn143.Width = 30
        UltraGridColumn144.Header.VisiblePosition = 72
        UltraGridColumn144.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 73
        UltraGridColumn103.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn141, UltraGridColumn143, UltraGridColumn144, UltraGridColumn103})
        UltraGridBand1.GroupHeadersVisible = False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaGrt.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaGrt.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaGrt.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaGrt.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaGrt.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaGrt.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaGrt.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaGrt.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaGrt.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaGrt.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaGrt.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaGrt.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaGrt.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaGrt.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaGrt.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaGrt.DisplayLayout.UseFixedHeaders = True
        Me.griListaGrt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaGrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaGrt.ImageList = Me.imagenes
        Me.griListaGrt.Location = New System.Drawing.Point(0, 0)
        Me.griListaGrt.Name = "griListaGrt"
        Me.griListaGrt.Size = New System.Drawing.Size(978, 340)
        Me.griListaGrt.TabIndex = 1
        Me.griListaGrt.Tag = ""
        '
        'ogdListaGuias
        '
        UltraDataColumn25.DataType = GetType(Date)
        UltraDataColumn40.DataType = GetType(Date)
        UltraDataColumn41.DataType = GetType(Date)
        UltraDataColumn42.DataType = GetType(Date)
        UltraDataColumn43.DataType = GetType(Date)
        Me.ogdListaGuias.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73})
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
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griGrtCargaMaterial)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(978, 340)
        '
        'griGrtCargaMaterial
        '
        Me.griGrtCargaMaterial.ContextMenuStrip = Me.MenuGrt
        Appearance15.BackColor = System.Drawing.Color.White
        Me.griGrtCargaMaterial.DisplayLayout.Appearance = Appearance15
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 7
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 210
        UltraGridColumn73.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn73.CellAppearance = Appearance16
        UltraGridColumn73.Header.VisiblePosition = 3
        UltraGridColumn73.MaskInput = "{LOC}nnnn"
        UltraGridColumn73.Width = 30
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn74.CellAppearance = Appearance17
        UltraGridColumn74.Header.VisiblePosition = 4
        UltraGridColumn74.MaskInput = "{LOC}nnnnnnnnnn"
        UltraGridColumn74.Width = 60
        UltraGridColumn75.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance18.TextHAlignAsString = "Left"
        UltraGridColumn75.CellAppearance = Appearance18
        UltraGridColumn75.Header.Caption = "Cliente"
        UltraGridColumn75.Header.VisiblePosition = 5
        UltraGridColumn75.Width = 200
        UltraGridColumn76.Header.VisiblePosition = 8
        UltraGridColumn76.Hidden = True
        Appearance19.TextHAlignAsString = "Left"
        UltraGridColumn77.CellAppearance = Appearance19
        UltraGridColumn77.Header.Caption = "Material"
        UltraGridColumn77.Header.VisiblePosition = 6
        UltraGridColumn77.MaskInput = ""
        UltraGridColumn77.Width = 100
        UltraGridColumn78.Header.VisiblePosition = 9
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.Caption = "Actividad O.P."
        UltraGridColumn79.Header.VisiblePosition = 10
        UltraGridColumn79.Width = 100
        UltraGridColumn80.Header.VisiblePosition = 27
        UltraGridColumn80.Width = 200
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn81.Header.Appearance = Appearance20
        UltraGridColumn81.Header.Caption = "Fecha I/S"
        UltraGridColumn81.Header.VisiblePosition = 2
        UltraGridColumn81.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn81.Width = 70
        UltraGridColumn82.Header.VisiblePosition = 11
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 12
        UltraGridColumn83.Hidden = True
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn84.Header.Appearance = Appearance21
        UltraGridColumn84.Header.VisiblePosition = 1
        UltraGridColumn84.Hidden = True
        UltraGridColumn84.Width = 90
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn85.CellAppearance = Appearance22
        UltraGridColumn85.Header.Caption = "TN"
        UltraGridColumn85.Header.VisiblePosition = 13
        UltraGridColumn85.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn85.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn85.Width = 40
        UltraGridColumn86.Header.Caption = "Indicador"
        UltraGridColumn86.Header.VisiblePosition = 28
        UltraGridColumn86.Width = 30
        UltraGridColumn87.Header.Caption = "Ok"
        UltraGridColumn87.Header.VisiblePosition = 14
        UltraGridColumn87.Hidden = True
        UltraGridColumn87.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn87.Width = 30
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn88.CellAppearance = Appearance23
        UltraGridColumn88.Header.Caption = "Ingreso"
        UltraGridColumn88.Header.VisiblePosition = 15
        UltraGridColumn88.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn88.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn88.Width = 50
        Appearance24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn89.CellAppearance = Appearance24
        UltraGridColumn89.Header.Caption = "Salida"
        UltraGridColumn89.Header.VisiblePosition = 16
        UltraGridColumn89.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn89.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn89.Width = 50
        UltraGridColumn90.Header.Caption = "Local Almacen"
        UltraGridColumn90.Header.VisiblePosition = 17
        UltraGridColumn90.Width = 100
        UltraGridColumn91.Header.VisiblePosition = 18
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 19
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 20
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.Caption = "Doct."
        UltraGridColumn94.Header.VisiblePosition = 21
        UltraGridColumn94.Hidden = True
        UltraGridColumn94.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn94.Width = 30
        UltraGridColumn95.Header.VisiblePosition = 22
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 23
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 24
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.Caption = "Perdido"
        UltraGridColumn98.Header.VisiblePosition = 25
        UltraGridColumn98.Hidden = True
        UltraGridColumn98.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn98.Width = 30
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn99.CellAppearance = Appearance25
        UltraGridColumn99.Header.VisiblePosition = 26
        UltraGridColumn99.Hidden = True
        UltraGridColumn99.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn99.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn99.Width = 40
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn2, UltraGridColumn3, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99})
        Me.griGrtCargaMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griGrtCargaMaterial.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griGrtCargaMaterial.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griGrtCargaMaterial.DisplayLayout.GroupByBox.Hidden = True
        Me.griGrtCargaMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griGrtCargaMaterial.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griGrtCargaMaterial.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGrtCargaMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGrtCargaMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGrtCargaMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griGrtCargaMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griGrtCargaMaterial.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griGrtCargaMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griGrtCargaMaterial.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griGrtCargaMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griGrtCargaMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griGrtCargaMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griGrtCargaMaterial.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griGrtCargaMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griGrtCargaMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griGrtCargaMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griGrtCargaMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griGrtCargaMaterial.Location = New System.Drawing.Point(0, 0)
        Me.griGrtCargaMaterial.Name = "griGrtCargaMaterial"
        Me.griGrtCargaMaterial.Size = New System.Drawing.Size(978, 340)
        Me.griGrtCargaMaterial.TabIndex = 1
        Me.griGrtCargaMaterial.Tag = ""
        '
        'MenuGrt
        '
        Me.MenuGrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuGrt.ForeColor = System.Drawing.Color.Black
        Me.MenuGrt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Extorno})
        Me.MenuGrt.Name = "MenuContextual1"
        Me.MenuGrt.Size = New System.Drawing.Size(111, 26)
        '
        'Extorno
        '
        Me.Extorno.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.Extorno.Name = "Extorno"
        Me.Extorno.Size = New System.Drawing.Size(110, 22)
        Me.Extorno.Text = "Extorno"
        Me.Extorno.ToolTipText = "Extorno I/S de Material"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.tabLista)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(982, 538)
        '
        'tabLista
        '
        Appearance26.BackColor = System.Drawing.Color.White
        Appearance26.BackColor2 = System.Drawing.Color.White
        Me.tabLista.ClientAreaAppearance = Appearance26
        Me.tabLista.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.tabLista.Controls.Add(Me.UltraTabPageControl3)
        Me.tabLista.Controls.Add(Me.UltraTabPageControl5)
        Me.tabLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabLista.Location = New System.Drawing.Point(0, 175)
        Me.tabLista.Name = "tabLista"
        Me.tabLista.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.tabLista.Size = New System.Drawing.Size(982, 363)
        Me.tabLista.TabIndex = 4
        UltraTab14.TabPage = Me.UltraTabPageControl3
        UltraTab14.Text = "GRT Dar I/S"
        UltraTab16.TabPage = Me.UltraTabPageControl5
        UltraTab16.Text = "Movimiento I/S"
        Me.tabLista.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab14, UltraTab16})
        Me.tabLista.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(978, 340)
        '
        'agrBusqueda
        '
        Appearance27.BackColor = System.Drawing.Color.White
        Appearance27.BackColor2 = System.Drawing.Color.White
        Me.agrBusqueda.ContentAreaAppearance = Appearance27
        Me.agrBusqueda.Controls.Add(Me.Agrupacion1)
        Me.agrBusqueda.Controls.Add(Me.grupoTipoVehiculo)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel2)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel1)
        Me.agrBusqueda.Controls.Add(Me.txtNumero)
        Me.agrBusqueda.Controls.Add(Me.txtSerie)
        Me.agrBusqueda.Controls.Add(Me.verTracto)
        Me.agrBusqueda.Controls.Add(Me.cboTractoLista)
        Me.agrBusqueda.Controls.Add(Me.verViajeRetorno)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel46)
        Me.agrBusqueda.Controls.Add(Me.cboCentro)
        Me.agrBusqueda.Controls.Add(Me.cboActividadNegocio)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel30)
        Me.agrBusqueda.Controls.Add(Me.cboRemitenteBusca)
        Me.agrBusqueda.Controls.Add(Me.UltraGroupBox11)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(982, 175)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion1.Controls.Add(Me.colorDisponible)
        Me.Agrupacion1.Controls.Add(Me.colorSalida)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Controls.Add(Me.colorIngreso)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(3, 139)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(601, 33)
        Me.Agrupacion1.TabIndex = 296
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(120, 13)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta9.TabIndex = 4
        Me.Etiqueta9.Text = "Salida (2):"
        '
        'colorDisponible
        '
        Me.colorDisponible.Color = System.Drawing.Color.White
        Me.colorDisponible.Location = New System.Drawing.Point(302, 9)
        Me.colorDisponible.Name = "colorDisponible"
        Me.colorDisponible.Size = New System.Drawing.Size(44, 21)
        Me.colorDisponible.TabIndex = 11
        Me.colorDisponible.Text = "White"
        '
        'colorSalida
        '
        Me.colorSalida.Color = System.Drawing.Color.LightCoral
        Me.colorSalida.DefaultColor = System.Drawing.Color.Empty
        Me.colorSalida.Location = New System.Drawing.Point(177, 9)
        Me.colorSalida.Name = "colorSalida"
        Me.colorSalida.Size = New System.Drawing.Size(44, 21)
        Me.colorSalida.TabIndex = 5
        Me.colorSalida.Text = "LightCoral"
        '
        'Etiqueta10
        '
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(10, 13)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta10.TabIndex = 0
        Me.Etiqueta10.Text = "Ingreso (1):"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(224, 13)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta5.TabIndex = 10
        Me.Etiqueta5.Text = "Disponible (0):"
        '
        'colorIngreso
        '
        Me.colorIngreso.Color = System.Drawing.Color.Lime
        Me.colorIngreso.Location = New System.Drawing.Point(73, 9)
        Me.colorIngreso.Name = "colorIngreso"
        Me.colorIngreso.Size = New System.Drawing.Size(44, 21)
        Me.colorIngreso.TabIndex = 1
        Me.colorIngreso.Text = "Lime"
        '
        'grupoTipoVehiculo
        '
        Me.grupoTipoVehiculo.Controls.Add(Me.griStockAlmacen)
        Me.grupoTipoVehiculo.Dock = System.Windows.Forms.DockStyle.Right
        Me.grupoTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoTipoVehiculo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoTipoVehiculo.Location = New System.Drawing.Point(604, 16)
        Me.grupoTipoVehiculo.Name = "grupoTipoVehiculo"
        Me.grupoTipoVehiculo.Size = New System.Drawing.Size(375, 156)
        Me.grupoTipoVehiculo.TabIndex = 295
        Me.grupoTipoVehiculo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griStockAlmacen
        '
        Me.griStockAlmacen.DataSource = Me.ogdStockAlmacen
        Appearance28.BackColor = System.Drawing.Color.White
        Me.griStockAlmacen.DisplayLayout.Appearance = Appearance28
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn100.CellAppearance = Appearance29
        UltraGridColumn100.Header.Caption = "STOCK"
        UltraGridColumn100.Header.VisiblePosition = 0
        UltraGridColumn100.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn100.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn100.Width = 50
        UltraGridColumn101.Header.Caption = "MATERIAL"
        UltraGridColumn101.Header.VisiblePosition = 1
        UltraGridColumn101.Width = 150
        UltraGridColumn102.Header.Caption = "LOCAL ALMACEN"
        UltraGridColumn102.Header.VisiblePosition = 2
        UltraGridColumn102.Width = 100
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn100, UltraGridColumn101, UltraGridColumn102})
        Me.griStockAlmacen.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griStockAlmacen.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griStockAlmacen.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griStockAlmacen.DisplayLayout.GroupByBox.Hidden = True
        Me.griStockAlmacen.DisplayLayout.MaxColScrollRegions = 1
        Me.griStockAlmacen.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griStockAlmacen.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griStockAlmacen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griStockAlmacen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griStockAlmacen.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griStockAlmacen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griStockAlmacen.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griStockAlmacen.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griStockAlmacen.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griStockAlmacen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griStockAlmacen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griStockAlmacen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griStockAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griStockAlmacen.Location = New System.Drawing.Point(3, 3)
        Me.griStockAlmacen.Name = "griStockAlmacen"
        Me.griStockAlmacen.Size = New System.Drawing.Size(369, 150)
        Me.griStockAlmacen.TabIndex = 2
        Me.griStockAlmacen.Tag = ""
        '
        'ogdStockAlmacen
        '
        Me.ogdStockAlmacen.Band.Columns.AddRange(New Object() {UltraDataColumn74, UltraDataColumn75, UltraDataColumn76})
        '
        'UltraLabel2
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Appearance30.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance30
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(335, 55)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel2.TabIndex = 292
        Me.UltraLabel2.Text = "Numero:"
        '
        'UltraLabel1
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Appearance31.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance31
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(347, 32)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel1.TabIndex = 291
        Me.UltraLabel1.Text = "Serie:"
        '
        'txtNumero
        '
        Appearance32.TextHAlignAsString = "Right"
        Me.txtNumero.Appearance = Appearance32
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[String]
        Me.txtNumero.InputMask = "nnnnnnnnnn"
        Me.txtNumero.Location = New System.Drawing.Point(385, 52)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.NonAutoSizeHeight = 20
        Me.txtNumero.NullText = ""
        Me.txtNumero.Size = New System.Drawing.Size(70, 20)
        Me.txtNumero.TabIndex = 290
        UltraToolTipInfo1.ToolTipText = "Ingrese Numero de GRT"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtNumero, UltraToolTipInfo1)
        '
        'txtSerie
        '
        Appearance33.TextHAlignAsString = "Right"
        Me.txtSerie.Appearance = Appearance33
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[String]
        Me.txtSerie.InputMask = "nnnn"
        Me.txtSerie.Location = New System.Drawing.Point(385, 29)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.NonAutoSizeHeight = 20
        Me.txtSerie.NullText = ""
        Me.txtSerie.Size = New System.Drawing.Size(35, 20)
        Me.txtSerie.TabIndex = 289
        UltraToolTipInfo2.ToolTipText = "Ingrese Serie de GRT"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtSerie, UltraToolTipInfo2)
        '
        'verTracto
        '
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.verTracto.Appearance = Appearance34
        Me.verTracto.AutoSize = True
        Me.verTracto.Location = New System.Drawing.Point(171, 52)
        Me.verTracto.Name = "verTracto"
        Me.verTracto.Size = New System.Drawing.Size(56, 17)
        Me.verTracto.TabIndex = 288
        Me.verTracto.Text = "Tracto:"
        '
        'cboTractoLista
        '
        Appearance35.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Appearance = Appearance35
        Me.cboTractoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoLista.DisplayMember = "Nombre"
        Me.cboTractoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoLista.Enabled = False
        Me.cboTractoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoLista.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Location = New System.Drawing.Point(231, 51)
        Me.cboTractoLista.Name = "cboTractoLista"
        Me.cboTractoLista.Size = New System.Drawing.Size(100, 21)
        Me.cboTractoLista.TabIndex = 287
        UltraToolTipInfo3.ToolTipText = "Seleccione Tracto"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboTractoLista, UltraToolTipInfo3)
        Me.cboTractoLista.ValueMember = "Id"
        '
        'verViajeRetorno
        '
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.verViajeRetorno.Appearance = Appearance36
        Me.verViajeRetorno.AutoSize = True
        Me.verViajeRetorno.Location = New System.Drawing.Point(6, 103)
        Me.verViajeRetorno.Name = "verViajeRetorno"
        Me.verViajeRetorno.Size = New System.Drawing.Size(75, 17)
        Me.verViajeRetorno.TabIndex = 286
        Me.verViajeRetorno.Text = "V. Retorno"
        UltraToolTipInfo4.ToolTipText = "Indicador de Viajes de Retorno"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.verViajeRetorno, UltraToolTipInfo4)
        '
        'UltraLabel46
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Appearance37.TextVAlignAsString = "Middle"
        Me.UltraLabel46.Appearance = Appearance37
        Me.UltraLabel46.AutoSize = True
        Me.UltraLabel46.Location = New System.Drawing.Point(187, 31)
        Me.UltraLabel46.Name = "UltraLabel46"
        Me.UltraLabel46.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel46.TabIndex = 284
        Me.UltraLabel46.Text = "Centro:"
        '
        'cboCentro
        '
        Appearance38.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance38
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(231, 27)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(100, 21)
        Me.cboCentro.TabIndex = 285
        UltraToolTipInfo5.ToolTipText = "Seleccione Centro"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboCentro, UltraToolTipInfo5)
        Me.cboCentro.ValueMember = "Id"
        '
        'cboActividadNegocio
        '
        Appearance39.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.Appearance = Appearance39
        Me.cboActividadNegocio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance40.Image = 8
        EditorButton1.Appearance = Appearance40
        Me.cboActividadNegocio.ButtonsRight.Add(EditorButton1)
        Me.cboActividadNegocio.DisplayMember = "Nombre"
        Me.cboActividadNegocio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboActividadNegocio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboActividadNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboActividadNegocio.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.ImageList = Me.imagenes
        Me.cboActividadNegocio.Location = New System.Drawing.Point(305, 100)
        Me.cboActividadNegocio.Name = "cboActividadNegocio"
        Me.cboActividadNegocio.Size = New System.Drawing.Size(150, 21)
        Me.cboActividadNegocio.TabIndex = 57
        UltraToolTipInfo6.ToolTipText = "Seleccione Actividad de"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboActividadNegocio, UltraToolTipInfo6)
        Me.cboActividadNegocio.ValueMember = "Id"
        '
        'UltraLabel30
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Appearance41.TextVAlignAsString = "Middle"
        Me.UltraLabel30.Appearance = Appearance41
        Me.UltraLabel30.AutoSize = True
        Me.UltraLabel30.Location = New System.Drawing.Point(204, 104)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(98, 14)
        Me.UltraLabel30.TabIndex = 56
        Me.UltraLabel30.Text = "Actividad Negocio:"
        '
        'cboRemitenteBusca
        '
        Appearance42.ForeColor = System.Drawing.Color.Black
        Me.cboRemitenteBusca.Appearance = Appearance42
        Me.cboRemitenteBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRemitenteBusca.DisplayMember = "Nombre"
        Me.cboRemitenteBusca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRemitenteBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRemitenteBusca.Location = New System.Drawing.Point(5, 76)
        Me.cboRemitenteBusca.Name = "cboRemitenteBusca"
        Me.cboRemitenteBusca.Size = New System.Drawing.Size(450, 22)
        Me.cboRemitenteBusca.TabIndex = 55
        UltraToolTipInfo7.ToolTipText = "Seleccione Remitente de GRT"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboRemitenteBusca, UltraToolTipInfo7)
        Me.cboRemitenteBusca.ValueMember = "Id"
        '
        'UltraGroupBox11
        '
        Me.UltraGroupBox11.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel39)
        Me.UltraGroupBox11.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel41)
        Me.UltraGroupBox11.Location = New System.Drawing.Point(3, 18)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(150, 55)
        Me.UltraGroupBox11.TabIndex = 54
        Me.UltraGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecHasta
        '
        Me.fecHasta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecHasta.Location = New System.Drawing.Point(50, 29)
        Me.fecHasta.MaskInput = ""
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(90, 21)
        Me.fecHasta.TabIndex = 50
        '
        'UltraLabel39
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Appearance43.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance43
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel39.Location = New System.Drawing.Point(10, 33)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel39.TabIndex = 49
        Me.UltraLabel39.Text = "Hasta:"
        '
        'fecDesde
        '
        Me.fecDesde.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDesde.Location = New System.Drawing.Point(50, 6)
        Me.fecDesde.MaskInput = ""
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(90, 21)
        Me.fecDesde.TabIndex = 48
        '
        'UltraLabel41
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Appearance44.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance44
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(7, 10)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel41.TabIndex = 47
        Me.UltraLabel41.Text = "Desde:"
        '
        'ficCtrlMerma
        '
        Me.ficCtrlMerma.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficCtrlMerma.Controls.Add(Me.UltraTabPageControl7)
        Me.ficCtrlMerma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCtrlMerma.Location = New System.Drawing.Point(0, 0)
        Me.ficCtrlMerma.Name = "ficCtrlMerma"
        Me.ficCtrlMerma.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficCtrlMerma.Size = New System.Drawing.Size(984, 561)
        Me.ficCtrlMerma.TabIndex = 2
        UltraTab18.Key = "Lista"
        UltraTab18.TabPage = Me.UltraTabPageControl7
        UltraTab18.Text = "Lista"
        Me.ficCtrlMerma.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab18})
        Me.ficCtrlMerma.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(982, 538)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(282, 226)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 55
        Me.ugb_Espera.Visible = False
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'frm_GRTMovimientoCargaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficCtrlMerma)
        Me.Name = "frm_GRTMovimientoCargaMaterial"
        Me.Text = "frm_GRTMovimientoCargaMaterial"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griListaGrt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdListaGuias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griGrtCargaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuGrt.ResumeLayout(False)
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.tabLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLista.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.colorDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoTipoVehiculo.ResumeLayout(False)
        CType(Me.griStockAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdStockAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verViajeRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboActividadNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRemitenteBusca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        Me.UltraGroupBox11.PerformLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficCtrlMerma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCtrlMerma.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficCtrlMerma As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents tabLista As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdListaGuias As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents griListaGrt As ISL.Controles.Grilla
    Friend WithEvents cboRemitenteBusca As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents cboActividadNegocio As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verViajeRetorno As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel46 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents verTracto As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboTractoLista As ISL.Controles.Combo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtSerie As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents grupoTipoVehiculo As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents colorSalida As ISL.Controles.Colores
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents colorDisponible As ISL.Controles.Colores
    Friend WithEvents colorIngreso As ISL.Controles.Colores
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents griGrtCargaMaterial As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents griStockAlmacen As ISL.Controles.Grilla
    Friend WithEvents ogdStockAlmacen As ISL.Controles.OrigenDatos
    Friend WithEvents MenuGrt As ISL.Controles.MenuContextual
    Friend WithEvents Extorno As System.Windows.Forms.ToolStripMenuItem
End Class
