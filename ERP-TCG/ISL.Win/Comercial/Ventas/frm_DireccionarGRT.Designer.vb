<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DireccionarGRT
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
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
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCarga")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Produccion")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPlanilla")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DireccionarGRT))
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
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.ogdListaGuias = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtDireccionarIdViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTracto = New ISL.Controles.Combo(Me.components)
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumero = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtSerie = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtIdGrt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDireccionarCodigoViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.verFacturado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verDoctsPerdido = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verDocumentos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verConfirmado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.exgruViaje = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViajeOrigen = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajePiloto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeCopiloto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeTracto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigoOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViajeEscala = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeDestino = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCodigoViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtIdSeguimiento = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeCarreta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.fecViaje = New ISL.Controles.Fecha(Me.components)
        Me.txtIdOperacionDetalle = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel36 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_Espera = New ISL.Win.Espere()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdListaGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.txtDireccionarIdViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox3.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdGrt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccionarCodigoViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verFacturado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verDoctsPerdido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verConfirmado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruViaje.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.txtViajeOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajePiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeCopiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'griLista
        '
        Me.griLista.DataSource = Me.ogdListaGuias
        UltraGridColumn1.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn1.Header.VisiblePosition = 8
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        UltraGridColumn2.CellAppearance = Appearance1
        UltraGridColumn2.Header.Caption = "Viaje"
        UltraGridColumn2.Header.Fixed = True
        UltraGridColumn2.Header.VisiblePosition = 3
        UltraGridColumn2.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Width = 95
        UltraGridColumn3.Header.VisiblePosition = 9
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Serie"
        UltraGridColumn4.Header.Fixed = True
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Width = 35
        UltraGridColumn5.Header.Caption = "Punto de Partida"
        UltraGridColumn5.Header.VisiblePosition = 16
        UltraGridColumn5.Width = 200
        UltraGridColumn6.Header.VisiblePosition = 13
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Width = 113
        UltraGridColumn7.Header.Caption = "Punto de Llegada"
        UltraGridColumn7.Header.VisiblePosition = 18
        UltraGridColumn7.Width = 200
        UltraGridColumn8.Header.VisiblePosition = 14
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Width = 109
        UltraGridColumn9.Header.Caption = "Remitente"
        UltraGridColumn9.Header.VisiblePosition = 15
        UltraGridColumn9.Width = 200
        UltraGridColumn10.Header.Caption = "Destinatario"
        UltraGridColumn10.Header.VisiblePosition = 17
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Width = 200
        UltraGridColumn11.Header.Caption = "Fact."
        UltraGridColumn11.Header.Fixed = True
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn11.Width = 35
        UltraGridColumn12.Header.VisiblePosition = 19
        UltraGridColumn12.Hidden = True
        Appearance2.Image = 7
        UltraGridColumn13.CellAppearance = Appearance2
        Appearance3.Image = 3
        UltraGridColumn13.CellButtonAppearance = Appearance3
        UltraGridColumn13.Header.VisiblePosition = 20
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn13.Width = 200
        UltraGridColumn14.Header.VisiblePosition = 21
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 22
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Width = 183
        UltraGridColumn16.Header.VisiblePosition = 23
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 24
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn18.Header.VisiblePosition = 25
        UltraGridColumn18.Hidden = True
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        UltraGridColumn19.CellAppearance = Appearance4
        UltraGridColumn19.Header.Fixed = True
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Width = 80
        UltraGridColumn20.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn20.Header.VisiblePosition = 26
        UltraGridColumn20.Hidden = True
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        UltraGridColumn21.CellAppearance = Appearance5
        UltraGridColumn21.Header.Fixed = True
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Width = 71
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance6
        UltraGridColumn22.Header.VisiblePosition = 30
        UltraGridColumn22.MaskInput = "{LOC}n,nnn,nnn.nn"
        UltraGridColumn23.Header.VisiblePosition = 27
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 28
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Width = 100
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn25.Header.Caption = "F. Viaje"
        UltraGridColumn25.Header.VisiblePosition = 10
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn25.Width = 60
        UltraGridColumn26.Header.Caption = "UsuarioCrea"
        UltraGridColumn26.Header.VisiblePosition = 42
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.Width = 150
        UltraGridColumn27.Header.VisiblePosition = 31
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn28.Header.Caption = "Selec."
        UltraGridColumn28.Header.Fixed = True
        UltraGridColumn28.Header.VisiblePosition = 0
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn28.Width = 35
        UltraGridColumn29.Header.VisiblePosition = 32
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 33
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.Width = 100
        UltraGridColumn31.Header.VisiblePosition = 34
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 35
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 36
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 11
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.Width = 200
        UltraGridColumn35.Header.Caption = "Perdido"
        UltraGridColumn35.Header.VisiblePosition = 56
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn35.Width = 40
        UltraGridColumn36.Header.VisiblePosition = 37
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 38
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.Caption = "UsuarioSeguimiento"
        UltraGridColumn38.Header.VisiblePosition = 43
        UltraGridColumn38.Width = 150
        UltraGridColumn39.Header.Caption = "UsuarioGuias"
        UltraGridColumn39.Header.VisiblePosition = 44
        UltraGridColumn39.Width = 150
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.Header.Caption = "F. GRT"
        UltraGridColumn40.Header.VisiblePosition = 12
        UltraGridColumn40.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn40.Width = 60
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn41.Header.VisiblePosition = 39
        UltraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn41.Width = 100
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.Header.VisiblePosition = 40
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn42.Width = 100
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn43.Header.VisiblePosition = 41
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn43.Width = 100
        UltraGridColumn44.Header.Caption = "Numero"
        UltraGridColumn44.Header.Fixed = True
        UltraGridColumn44.Header.VisiblePosition = 5
        UltraGridColumn44.Width = 70
        UltraGridColumn45.Header.VisiblePosition = 45
        UltraGridColumn45.Width = 250
        Appearance7.Image = 3
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn46.CellAppearance = Appearance7
        Appearance8.Image = 1
        UltraGridColumn46.CellButtonAppearance = Appearance8
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn46.Header.Caption = "IncidenciaGuias"
        UltraGridColumn46.Header.VisiblePosition = 46
        UltraGridColumn46.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn46.Width = 250
        UltraGridColumn47.Header.VisiblePosition = 47
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.Width = 50
        UltraGridColumn48.Header.Caption = "Doct."
        UltraGridColumn48.Header.VisiblePosition = 55
        UltraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn48.Width = 35
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn49.CellAppearance = Appearance9
        UltraGridColumn49.Header.Caption = "TN"
        UltraGridColumn49.Header.VisiblePosition = 29
        UltraGridColumn49.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn49.Width = 40
        UltraGridColumn50.Header.VisiblePosition = 48
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 49
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 50
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 51
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 52
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 53
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 54
        UltraGridColumn57.Header.Caption = "Ok"
        UltraGridColumn57.Header.Fixed = True
        UltraGridColumn57.Header.VisiblePosition = 1
        UltraGridColumn57.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn57.Width = 35
        UltraGridColumn58.Header.VisiblePosition = 57
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 58
        UltraGridColumn59.Hidden = True
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
        UltraGridColumn69.Header.VisiblePosition = 68
        UltraGridColumn69.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69})
        UltraGridBand1.GroupHeadersVisible = False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
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
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.DisplayLayout.UseFixedHeaders = True
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(0, 205)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(884, 357)
        Me.griLista.TabIndex = 2
        Me.griLista.Tag = ""
        '
        'ogdListaGuias
        '
        UltraDataColumn25.DataType = GetType(Date)
        UltraDataColumn40.DataType = GetType(Date)
        UltraDataColumn41.DataType = GetType(Date)
        UltraDataColumn42.DataType = GetType(Date)
        UltraDataColumn43.DataType = GetType(Date)
        Me.ogdListaGuias.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance10
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(884, 110)
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 95)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(884, 110)
        Me.UltraExpandableGroupBox1.TabIndex = 54
        Me.UltraExpandableGroupBox1.Text = "DIRECCIONAR GRT A VIAJE SELECCIONADO"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtDireccionarIdViaje)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtNumero)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtSerie)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel5)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtIdGrt)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtDireccionarCodigoViaje)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.verFacturado)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.verDoctsPerdido)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.verDocumentos)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.verConfirmado)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnCancelar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnAceptar)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(878, 87)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'txtDireccionarIdViaje
        '
        Me.txtDireccionarIdViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDireccionarIdViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionarIdViaje.Location = New System.Drawing.Point(501, 46)
        Me.txtDireccionarIdViaje.Name = "txtDireccionarIdViaje"
        Me.txtDireccionarIdViaje.ReadOnly = True
        Me.txtDireccionarIdViaje.Size = New System.Drawing.Size(21, 21)
        Me.txtDireccionarIdViaje.TabIndex = 66
        Me.txtDireccionarIdViaje.Visible = False
        '
        'UltraExpandableGroupBox3
        '
        Me.UltraExpandableGroupBox3.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox3.ContentAreaAppearance = Appearance11
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(195, 87)
        Me.UltraExpandableGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(195, 87)
        Me.UltraExpandableGroupBox3.TabIndex = 65
        Me.UltraExpandableGroupBox3.Text = "Busca"
        Me.UltraExpandableGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.btnConsultar)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel7)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboTracto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraGroupBox13)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(172, 81)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'btnConsultar
        '
        Appearance12.Image = "266.png"
        Me.btnConsultar.Appearance = Appearance12
        Me.btnConsultar.ImageList = Me.imagenes
        Me.btnConsultar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsultar.Location = New System.Drawing.Point(139, 52)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(30, 30)
        Me.btnConsultar.TabIndex = 66
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
        'UltraLabel7
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance13
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(10, 60)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel7.TabIndex = 66
        Me.UltraLabel7.Text = "Tracto:"
        '
        'cboTracto
        '
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.Appearance = Appearance14
        Me.cboTracto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTracto.DisplayMember = ""
        Me.cboTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTracto.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.Location = New System.Drawing.Point(53, 56)
        Me.cboTracto.Name = "cboTracto"
        Me.cboTracto.Size = New System.Drawing.Size(80, 21)
        Me.cboTracto.TabIndex = 65
        Me.cboTracto.ValueMember = "Id"
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox13.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(2, -1)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(150, 55)
        Me.UltraGroupBox13.TabIndex = 67
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
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
        'UltraLabel8
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance15
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(10, 33)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel8.TabIndex = 49
        Me.UltraLabel8.Text = "Hasta:"
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
        'UltraLabel11
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance16
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(7, 10)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel11.TabIndex = 47
        Me.UltraLabel11.Text = "Desde:"
        '
        'txtNumero
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.txtNumero.Appearance = Appearance17
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[String]
        Me.txtNumero.InputMask = "nnnnnnnnnn"
        Me.txtNumero.Location = New System.Drawing.Point(426, 23)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.NonAutoSizeHeight = 20
        Me.txtNumero.NullText = ""
        Me.txtNumero.Size = New System.Drawing.Size(69, 20)
        Me.txtNumero.TabIndex = 62
        '
        'txtSerie
        '
        Appearance18.TextHAlignAsString = "Right"
        Me.txtSerie.Appearance = Appearance18
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[String]
        Me.txtSerie.InputMask = "nnnn"
        Me.txtSerie.Location = New System.Drawing.Point(385, 23)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.NonAutoSizeHeight = 20
        Me.txtSerie.NullText = ""
        Me.txtSerie.Size = New System.Drawing.Size(35, 20)
        Me.txtSerie.TabIndex = 63
        '
        'UltraLabel5
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance19
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(351, 26)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel5.TabIndex = 60
        Me.UltraLabel5.Text = "GRT:"
        '
        'txtIdGrt
        '
        Me.txtIdGrt.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdGrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdGrt.Location = New System.Drawing.Point(501, 23)
        Me.txtIdGrt.Name = "txtIdGrt"
        Me.txtIdGrt.ReadOnly = True
        Me.txtIdGrt.Size = New System.Drawing.Size(21, 21)
        Me.txtIdGrt.TabIndex = 59
        Me.txtIdGrt.Visible = False
        '
        'UltraLabel2
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance20
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(419, 27)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(8, 14)
        Me.UltraLabel2.TabIndex = 61
        Me.UltraLabel2.Text = "-"
        '
        'UltraLabel1
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Appearance21.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance21
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(349, 49)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel1.TabIndex = 57
        Me.UltraLabel1.Text = "Viaje:"
        '
        'txtDireccionarCodigoViaje
        '
        Me.txtDireccionarCodigoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDireccionarCodigoViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionarCodigoViaje.Location = New System.Drawing.Point(385, 45)
        Me.txtDireccionarCodigoViaje.Name = "txtDireccionarCodigoViaje"
        Me.txtDireccionarCodigoViaje.ReadOnly = True
        Me.txtDireccionarCodigoViaje.Size = New System.Drawing.Size(110, 21)
        Me.txtDireccionarCodigoViaje.TabIndex = 58
        '
        'verFacturado
        '
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.verFacturado.Appearance = Appearance22
        Me.verFacturado.AutoSize = True
        Me.verFacturado.Location = New System.Drawing.Point(229, 3)
        Me.verFacturado.Name = "verFacturado"
        Me.verFacturado.Size = New System.Drawing.Size(92, 17)
        Me.verFacturado.TabIndex = 56
        Me.verFacturado.Text = "FACTURADO"
        '
        'verDoctsPerdido
        '
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.verDoctsPerdido.Appearance = Appearance23
        Me.verDoctsPerdido.AutoSize = True
        Me.verDoctsPerdido.Enabled = False
        Me.verDoctsPerdido.Location = New System.Drawing.Point(229, 68)
        Me.verDoctsPerdido.Name = "verDoctsPerdido"
        Me.verDoctsPerdido.Size = New System.Drawing.Size(119, 17)
        Me.verDoctsPerdido.TabIndex = 55
        Me.verDoctsPerdido.Text = "DOCTS. PERDIDO"
        '
        'verDocumentos
        '
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.verDocumentos.Appearance = Appearance24
        Me.verDocumentos.AutoSize = True
        Me.verDocumentos.Enabled = False
        Me.verDocumentos.Location = New System.Drawing.Point(229, 46)
        Me.verDocumentos.Name = "verDocumentos"
        Me.verDocumentos.Size = New System.Drawing.Size(92, 17)
        Me.verDocumentos.TabIndex = 54
        Me.verDocumentos.Text = "CON DOCTS."
        '
        'verConfirmado
        '
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.verConfirmado.Appearance = Appearance25
        Me.verConfirmado.AutoSize = True
        Me.verConfirmado.Location = New System.Drawing.Point(229, 24)
        Me.verConfirmado.Name = "verConfirmado"
        Me.verConfirmado.Size = New System.Drawing.Size(99, 17)
        Me.verConfirmado.TabIndex = 53
        Me.verConfirmado.Text = "CONFIRMADO"
        '
        'btnCancelar
        '
        Appearance26.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        Me.btnCancelar.Appearance = Appearance26
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCancelar.Location = New System.Drawing.Point(531, 44)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Appearance27.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnAceptar.Appearance = Appearance27
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAceptar.Location = New System.Drawing.Point(531, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "&Aceptar"
        '
        'exgruViaje
        '
        Me.exgruViaje.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance28.BackColor = System.Drawing.Color.White
        Appearance28.BackColor2 = System.Drawing.Color.White
        Me.exgruViaje.ContentAreaAppearance = Appearance28
        Me.exgruViaje.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.exgruViaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruViaje.ExpandedSize = New System.Drawing.Size(884, 95)
        Me.exgruViaje.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.exgruViaje.Location = New System.Drawing.Point(0, 0)
        Me.exgruViaje.Name = "exgruViaje"
        Me.exgruViaje.Size = New System.Drawing.Size(884, 95)
        Me.exgruViaje.TabIndex = 53
        Me.exgruViaje.Text = "VIAJE ACTUAL DE GUIA REMISION TRANSPORTISTA"
        Me.exgruViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel6)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeOrigen)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajePiloto)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeCopiloto)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeTracto)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel17)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtCodigoOperacion)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel20)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel9)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeEscala)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdOperacion)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdViaje)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeDestino)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtCodigoViaje)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel21)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel13)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdSeguimiento)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeCarreta)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.fecViaje)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdOperacionDetalle)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel36)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel10)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(878, 72)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'UltraLabel6
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Appearance29.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance29
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(584, 7)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel6.TabIndex = 46
        Me.UltraLabel6.Text = "Piloto:"
        '
        'txtViajeOrigen
        '
        Me.txtViajeOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeOrigen.Location = New System.Drawing.Point(367, 3)
        Me.txtViajeOrigen.Name = "txtViajeOrigen"
        Me.txtViajeOrigen.ReadOnly = True
        Me.txtViajeOrigen.Size = New System.Drawing.Size(200, 21)
        Me.txtViajeOrigen.TabIndex = 41
        '
        'txtViajePiloto
        '
        Me.txtViajePiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajePiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajePiloto.Location = New System.Drawing.Point(624, 3)
        Me.txtViajePiloto.Name = "txtViajePiloto"
        Me.txtViajePiloto.ReadOnly = True
        Me.txtViajePiloto.Size = New System.Drawing.Size(250, 21)
        Me.txtViajePiloto.TabIndex = 47
        '
        'txtViajeCopiloto
        '
        Me.txtViajeCopiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCopiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeCopiloto.Location = New System.Drawing.Point(624, 26)
        Me.txtViajeCopiloto.Name = "txtViajeCopiloto"
        Me.txtViajeCopiloto.ReadOnly = True
        Me.txtViajeCopiloto.Size = New System.Drawing.Size(250, 21)
        Me.txtViajeCopiloto.TabIndex = 26
        '
        'txtViajeTracto
        '
        Me.txtViajeTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeTracto.Location = New System.Drawing.Point(230, 3)
        Me.txtViajeTracto.Name = "txtViajeTracto"
        Me.txtViajeTracto.ReadOnly = True
        Me.txtViajeTracto.Size = New System.Drawing.Size(70, 21)
        Me.txtViajeTracto.TabIndex = 34
        '
        'UltraLabel17
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Appearance30.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance30
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(571, 30)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel17.TabIndex = 24
        Me.UltraLabel17.Text = "CoPiloto:"
        '
        'UltraLabel4
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Appearance31.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance31
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(308, 7)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel4.TabIndex = 40
        Me.UltraLabel4.Text = "R. Origen:"
        '
        'txtCodigoOperacion
        '
        Me.txtCodigoOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoOperacion.Location = New System.Drawing.Point(68, 3)
        Me.txtCodigoOperacion.Name = "txtCodigoOperacion"
        Me.txtCodigoOperacion.ReadOnly = True
        Me.txtCodigoOperacion.Size = New System.Drawing.Size(110, 21)
        Me.txtCodigoOperacion.TabIndex = 32
        '
        'UltraLabel3
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance32
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(32, 30)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel3.TabIndex = 28
        Me.UltraLabel3.Text = "Viaje:"
        '
        'UltraLabel20
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Appearance33.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance33
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(308, 53)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel20.TabIndex = 44
        Me.UltraLabel20.Text = "R. Escala:"
        '
        'UltraLabel9
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Appearance34.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance34
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(182, 30)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel9.TabIndex = 35
        Me.UltraLabel9.Text = "Carreta:"
        '
        'txtViajeEscala
        '
        Me.txtViajeEscala.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeEscala.Location = New System.Drawing.Point(367, 49)
        Me.txtViajeEscala.Name = "txtViajeEscala"
        Me.txtViajeEscala.ReadOnly = True
        Me.txtViajeEscala.Size = New System.Drawing.Size(200, 21)
        Me.txtViajeEscala.TabIndex = 45
        '
        'txtIdOperacion
        '
        Me.txtIdOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacion.Location = New System.Drawing.Point(230, 49)
        Me.txtIdOperacion.Name = "txtIdOperacion"
        Me.txtIdOperacion.ReadOnly = True
        Me.txtIdOperacion.Size = New System.Drawing.Size(21, 21)
        Me.txtIdOperacion.TabIndex = 37
        '
        'txtIdViaje
        '
        Me.txtIdViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdViaje.Location = New System.Drawing.Point(277, 49)
        Me.txtIdViaje.Name = "txtIdViaje"
        Me.txtIdViaje.ReadOnly = True
        Me.txtIdViaje.Size = New System.Drawing.Size(21, 21)
        Me.txtIdViaje.TabIndex = 27
        '
        'txtViajeDestino
        '
        Me.txtViajeDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeDestino.Location = New System.Drawing.Point(367, 26)
        Me.txtViajeDestino.Name = "txtViajeDestino"
        Me.txtViajeDestino.ReadOnly = True
        Me.txtViajeDestino.Size = New System.Drawing.Size(200, 21)
        Me.txtViajeDestino.TabIndex = 43
        '
        'txtCodigoViaje
        '
        Me.txtCodigoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoViaje.Location = New System.Drawing.Point(68, 26)
        Me.txtCodigoViaje.Name = "txtCodigoViaje"
        Me.txtCodigoViaje.ReadOnly = True
        Me.txtCodigoViaje.Size = New System.Drawing.Size(110, 21)
        Me.txtCodigoViaje.TabIndex = 31
        '
        'UltraLabel21
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance35
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(1, 53)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel21.TabIndex = 29
        Me.UltraLabel21.Text = "F. Atencion:"
        '
        'UltraLabel13
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Appearance36.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance36
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(304, 30)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel13.TabIndex = 42
        Me.UltraLabel13.Text = "R. Destino:"
        '
        'txtIdSeguimiento
        '
        Me.txtIdSeguimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSeguimiento.Location = New System.Drawing.Point(253, 49)
        Me.txtIdSeguimiento.Name = "txtIdSeguimiento"
        Me.txtIdSeguimiento.ReadOnly = True
        Me.txtIdSeguimiento.Size = New System.Drawing.Size(21, 21)
        Me.txtIdSeguimiento.TabIndex = 38
        '
        'txtViajeCarreta
        '
        Me.txtViajeCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeCarreta.Location = New System.Drawing.Point(230, 26)
        Me.txtViajeCarreta.Name = "txtViajeCarreta"
        Me.txtViajeCarreta.ReadOnly = True
        Me.txtViajeCarreta.Size = New System.Drawing.Size(70, 21)
        Me.txtViajeCarreta.TabIndex = 36
        '
        'fecViaje
        '
        Appearance37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecViaje.Appearance = Appearance37
        Me.fecViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecViaje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecViaje.Location = New System.Drawing.Point(68, 49)
        Me.fecViaje.Name = "fecViaje"
        Me.fecViaje.Size = New System.Drawing.Size(80, 21)
        Me.fecViaje.TabIndex = 30
        '
        'txtIdOperacionDetalle
        '
        Me.txtIdOperacionDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacionDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacionDetalle.Location = New System.Drawing.Point(197, 49)
        Me.txtIdOperacionDetalle.Name = "txtIdOperacionDetalle"
        Me.txtIdOperacionDetalle.ReadOnly = True
        Me.txtIdOperacionDetalle.Size = New System.Drawing.Size(30, 21)
        Me.txtIdOperacionDetalle.TabIndex = 39
        '
        'UltraLabel36
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Appearance38.TextVAlignAsString = "Middle"
        Me.UltraLabel36.Appearance = Appearance38
        Me.UltraLabel36.AutoSize = True
        Me.UltraLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel36.Location = New System.Drawing.Point(5, 7)
        Me.UltraLabel36.Name = "UltraLabel36"
        Me.UltraLabel36.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel36.TabIndex = 25
        Me.UltraLabel36.Text = "Operacion:"
        '
        'UltraLabel10
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Appearance39.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance39
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(188, 7)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel10.TabIndex = 33
        Me.UltraLabel10.Text = "Tracto:"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(244, 247)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 55
        Me.ugb_Espera.Visible = False
        '
        'frm_DireccionarGRT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 562)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.griLista)
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Controls.Add(Me.exgruViaje)
        Me.Name = "frm_DireccionarGRT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Direccionar GRT a Otro Viaje"
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdListaGuias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.txtDireccionarIdViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        Me.UltraGroupBox13.PerformLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdGrt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccionarCodigoViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verFacturado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verDoctsPerdido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verConfirmado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruViaje.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.txtViajeOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajePiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeCopiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtViajeTracto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeOrigen As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtIdViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajePiloto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents fecViaje As ISL.Controles.Fecha
    Friend WithEvents txtCodigoOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeEscala As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel36 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtIdOperacionDetalle As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeCarreta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdSeguimiento As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCodigoViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeCopiloto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeDestino As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents exgruViaje As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents verFacturado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verDoctsPerdido As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verDocumentos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verConfirmado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ogdListaGuias As ISL.Controles.OrigenDatos
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDireccionarCodigoViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtSerie As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtIdGrt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTracto As ISL.Controles.Combo
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents btnConsultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents txtDireccionarIdViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
End Class
