<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Liquidaciones
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
        Dim UltraGridColumn487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Incidencia")
        Dim UltraGridColumn505 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn506 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn507 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn508 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn509 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroOrigen")
        Dim UltraGridColumn510 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn511 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroDestino")
        Dim UltraGridColumn512 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn513 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn514 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn515 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn516 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn517 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn518 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn519 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn520 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn521 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn522 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn523 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn524 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn525 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn526 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Incidencia")
        Dim UltraGridColumn527 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn528 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", 1)
        Dim UltraGridColumn529 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn530 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn531 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn532 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remitente")
        Dim UltraGridColumn533 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn534 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn535 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destinatario")
        Dim UltraGridColumn536 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PuntoPartida")
        Dim UltraGridColumn537 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PuntoLlegada")
        Dim UltraGridColumn538 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn539 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 3")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 3", 2)
        Dim UltraGridColumn540 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn541 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn542 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn543 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn544 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn545 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataBand2 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataBand3 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 3")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaTransportista")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Remitente")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destinatario")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PuntoPartida")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PuntoLlegada")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroOrigen")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroDestino")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Incidencia")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Incidencia")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn546 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn547 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn548 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn549 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn550 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn551 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn552 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn553 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn554 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn555 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn556 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn557 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn558 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn559 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn560 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn561 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn562 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn563 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Incidencia")
        Dim UltraGridColumn564 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn565 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn566 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn567 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn568 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroOrigen")
        Dim UltraGridColumn569 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn570 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroDestino")
        Dim UltraGridColumn571 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn572 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn573 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn574 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn575 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn576 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn577 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn578 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn579 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn580 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn581 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn582 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn583 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn584 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn585 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Incidencia")
        Dim UltraGridColumn586 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn587 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", 1)
        Dim UltraGridColumn588 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn589 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn590 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn591 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remitente")
        Dim UltraGridColumn592 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn593 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn594 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destinatario")
        Dim UltraGridColumn595 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PuntoPartida")
        Dim UltraGridColumn596 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PuntoLlegada")
        Dim UltraGridColumn597 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn598 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 3")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 3", 2)
        Dim UltraGridColumn599 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn600 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn601 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn602 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn603 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn604 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn605 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn606 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn607 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn608 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn609 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn610 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn611 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn612 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn613 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn614 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFactura")
        Dim UltraGridColumn615 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn616 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn617 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn618 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFormato")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Igv")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFactura")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFormato")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn619 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaSemana")
        Dim UltraGridColumn620 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia")
        Dim UltraGridColumn621 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn622 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Año")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn623 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viajes")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn624 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Camiones")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn625 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Promedio")
        Dim UltraGridColumn626 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn627 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Guardar")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn628 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Prorrateo")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaSemana")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dia")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mes")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Año")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viajes")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Camiones")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Promedio")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Guardar")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Prorrateo")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Liquidaciones))
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn629 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaSemana")
        Dim UltraGridColumn630 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia")
        Dim UltraGridColumn631 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim UltraGridColumn632 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Año")
        Dim UltraGridColumn633 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viajes")
        Dim UltraGridColumn634 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Camiones")
        Dim UltraGridColumn635 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Promedio")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn636 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn637 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Guardar")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn638 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Prorrateo")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn639 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaSemana")
        Dim UltraGridColumn640 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia")
        Dim UltraGridColumn641 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim UltraGridColumn642 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Año")
        Dim UltraGridColumn643 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viajes")
        Dim UltraGridColumn644 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Camiones")
        Dim UltraGridColumn645 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Promedio")
        Dim UltraGridColumn646 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn647 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Guardar")
        Dim UltraGridColumn648 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Prorrateo")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn649 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn650 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn651 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLiquidacion")
        Dim UltraGridColumn652 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn653 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn654 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn655 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn656 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOrigen")
        Dim UltraGridColumn657 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn658 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDestino")
        Dim UltraGridColumn659 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn660 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn661 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn662 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn663 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn664 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn665 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn666 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCarga")
        Dim UltraGridColumn667 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaRemitente")
        Dim UltraGridColumn668 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn669 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn670 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtConfirmada")
        Dim UltraGridColumn671 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumentos")
        Dim UltraGridColumn672 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtPerdido")
        Dim UltraGridColumn673 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn674 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn675 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn676 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn677 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado2")
        Dim UltraGridColumn678 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado3")
        Dim UltraGridColumn679 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn680 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn681 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLlegada")
        Dim UltraGridColumn682 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn683 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado1")
        Dim UltraGridColumn684 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto1")
        Dim UltraGridColumn685 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto2")
        Dim UltraGridColumn686 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto3")
        Dim UltraGridColumn687 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volumen")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLiquidacion")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoOrigen")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoDestino")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCarga")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaRemitente")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaTransportista")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturado")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGrtConfirmada")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDocumentos")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGrtPerdido")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado2")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado3")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaLlegada")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaSalida")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado1")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto1")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto2")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto3")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Volumen")
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn688 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn689 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn690 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLiquidacion")
        Dim UltraGridColumn691 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn692 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn693 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn694 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn695 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOrigen")
        Dim UltraGridColumn696 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn697 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDestino")
        Dim UltraGridColumn698 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn699 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn700 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn701 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn702 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn703 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn704 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn705 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCarga")
        Dim UltraGridColumn706 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaRemitente")
        Dim UltraGridColumn707 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn708 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn709 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtConfirmada")
        Dim UltraGridColumn710 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumentos")
        Dim UltraGridColumn711 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtPerdido")
        Dim UltraGridColumn712 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn713 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn714 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn715 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn716 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado2")
        Dim UltraGridColumn717 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado3")
        Dim UltraGridColumn718 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn719 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn720 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLlegada")
        Dim UltraGridColumn721 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn722 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado1")
        Dim UltraGridColumn723 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto1")
        Dim UltraGridColumn724 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto2")
        Dim UltraGridColumn725 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto3")
        Dim UltraGridColumn726 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volumen")
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn727 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn728 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn729 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLiquidacion")
        Dim UltraGridColumn730 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn731 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn732 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn733 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn734 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOrigen")
        Dim UltraGridColumn735 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn736 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDestino")
        Dim UltraGridColumn737 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn738 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn739 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn740 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn741 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn742 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn743 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn744 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCarga")
        Dim UltraGridColumn745 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaRemitente")
        Dim UltraGridColumn746 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn747 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn748 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtConfirmada")
        Dim UltraGridColumn749 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumentos")
        Dim UltraGridColumn750 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtPerdido")
        Dim UltraGridColumn751 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn752 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn753 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn754 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado2")
        Dim UltraGridColumn755 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado3")
        Dim UltraGridColumn756 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn757 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn758 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn759 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLlegada")
        Dim UltraGridColumn760 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn761 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado1")
        Dim UltraGridColumn762 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto1")
        Dim UltraGridColumn763 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto2")
        Dim UltraGridColumn764 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto3")
        Dim UltraGridColumn765 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volumen")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLiquidacion")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoOrigen")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoDestino")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCarga")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaRemitente")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaTransportista")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturado")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGrtConfirmada")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDocumentos")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGrtPerdido")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado2")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado3")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaLlegada")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaSalida")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado1")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto1")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto2")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto3")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Volumen")
        Dim UltraGridBand16 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn766 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn767 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn768 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLiquidacion")
        Dim UltraGridColumn769 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn770 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn771 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn772 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn773 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOrigen")
        Dim UltraGridColumn774 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn775 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDestino")
        Dim UltraGridColumn776 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn777 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn778 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn779 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn780 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn781 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn782 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn783 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCarga")
        Dim UltraGridColumn784 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaRemitente")
        Dim UltraGridColumn785 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn786 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn787 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtConfirmada")
        Dim UltraGridColumn788 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumentos")
        Dim UltraGridColumn789 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtPerdido")
        Dim UltraGridColumn790 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn791 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn792 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn793 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado2")
        Dim UltraGridColumn794 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado3")
        Dim UltraGridColumn795 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn796 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn797 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn798 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLlegada")
        Dim UltraGridColumn799 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn800 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado1")
        Dim UltraGridColumn801 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto1")
        Dim UltraGridColumn802 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto2")
        Dim UltraGridColumn803 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto3")
        Dim UltraGridColumn804 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volumen")
        Dim UltraGridBand17 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn805 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn806 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn807 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLiquidacion")
        Dim UltraGridColumn808 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn809 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn810 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn811 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn812 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOrigen")
        Dim UltraGridColumn813 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn814 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDestino")
        Dim UltraGridColumn815 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn816 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn817 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn818 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn819 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn820 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn821 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn822 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCarga")
        Dim UltraGridColumn823 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaRemitente")
        Dim UltraGridColumn824 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn825 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn826 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtConfirmada")
        Dim UltraGridColumn827 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumentos")
        Dim UltraGridColumn828 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtPerdido")
        Dim UltraGridColumn829 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn830 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn831 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn832 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn833 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado2")
        Dim UltraGridColumn834 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado3")
        Dim UltraGridColumn835 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn836 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn837 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLlegada")
        Dim UltraGridColumn838 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn839 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado1")
        Dim UltraGridColumn840 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto1")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn841 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto2")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn842 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto3")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn843 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volumen")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLiquidacion")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoOrigen")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoDestino")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCarga")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaRemitente")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaTransportista")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturado")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGrtConfirmada")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDocumentos")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGrtPerdido")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado2")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado3")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaLlegada")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaSalida")
        Dim UltraDataColumn193 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado1")
        Dim UltraDataColumn194 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto1")
        Dim UltraDataColumn195 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto2")
        Dim UltraDataColumn196 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto3")
        Dim UltraDataColumn197 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Volumen")
        Dim UltraGridBand18 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn844 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn845 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn846 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLiquidacion")
        Dim UltraGridColumn847 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn848 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn849 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn850 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn851 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOrigen")
        Dim UltraGridColumn852 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn853 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDestino")
        Dim UltraGridColumn854 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn855 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn856 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn857 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn858 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn859 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn860 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn861 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCarga")
        Dim UltraGridColumn862 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaRemitente")
        Dim UltraGridColumn863 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn864 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn865 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtConfirmada")
        Dim UltraGridColumn866 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumentos")
        Dim UltraGridColumn867 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtPerdido")
        Dim UltraGridColumn868 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn869 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn870 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn871 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn872 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado2")
        Dim UltraGridColumn873 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado3")
        Dim UltraGridColumn874 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn875 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn876 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLlegada")
        Dim UltraGridColumn877 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn878 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado1")
        Dim UltraGridColumn879 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto1")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn880 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto2")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn881 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto3")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn882 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volumen")
        Dim UltraGridBand19 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn883 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn884 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn885 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLiquidacion")
        Dim UltraGridColumn886 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn887 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn888 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn889 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn890 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOrigen")
        Dim UltraGridColumn891 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn892 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDestino")
        Dim UltraGridColumn893 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn894 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn895 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn896 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn897 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn898 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn899 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn900 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCarga")
        Dim UltraGridColumn901 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaRemitente")
        Dim UltraGridColumn902 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn903 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn904 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtConfirmada")
        Dim UltraGridColumn905 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumentos")
        Dim UltraGridColumn906 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtPerdido")
        Dim UltraGridColumn907 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn908 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn909 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn910 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn911 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado2")
        Dim UltraGridColumn912 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado3")
        Dim UltraGridColumn913 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn914 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn915 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLlegada")
        Dim UltraGridColumn916 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn917 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado1")
        Dim UltraGridColumn918 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto1")
        Dim UltraGridColumn919 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto2")
        Dim UltraGridColumn920 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto3")
        Dim UltraGridColumn921 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volumen")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn198 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn199 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn200 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLiquidacion")
        Dim UltraDataColumn201 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn202 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn203 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn204 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn205 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoOrigen")
        Dim UltraDataColumn206 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn207 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoDestino")
        Dim UltraDataColumn208 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn209 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn210 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn211 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn212 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn213 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn214 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn215 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCarga")
        Dim UltraDataColumn216 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaRemitente")
        Dim UltraDataColumn217 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GuiaTransportista")
        Dim UltraDataColumn218 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturado")
        Dim UltraDataColumn219 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGrtConfirmada")
        Dim UltraDataColumn220 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDocumentos")
        Dim UltraDataColumn221 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGrtPerdido")
        Dim UltraDataColumn222 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn223 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn224 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn225 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn226 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado2")
        Dim UltraDataColumn227 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado3")
        Dim UltraDataColumn228 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn229 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn230 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaLlegada")
        Dim UltraDataColumn231 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaSalida")
        Dim UltraDataColumn232 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado1")
        Dim UltraDataColumn233 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto1")
        Dim UltraDataColumn234 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto2")
        Dim UltraDataColumn235 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto3")
        Dim UltraDataColumn236 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Volumen")
        Dim UltraGridBand20 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn922 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn923 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn924 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLiquidacion")
        Dim UltraGridColumn925 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn926 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn927 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn928 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn929 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOrigen")
        Dim UltraGridColumn930 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn931 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDestino")
        Dim UltraGridColumn932 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn933 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn934 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn935 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn936 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn937 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn938 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn939 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCarga")
        Dim UltraGridColumn940 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaRemitente")
        Dim UltraGridColumn941 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuiaTransportista")
        Dim UltraGridColumn942 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn943 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtConfirmada")
        Dim UltraGridColumn944 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumentos")
        Dim UltraGridColumn945 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGrtPerdido")
        Dim UltraGridColumn946 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn947 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn948 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn949 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn950 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado2")
        Dim UltraGridColumn951 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado3")
        Dim UltraGridColumn952 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn953 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn954 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLlegada")
        Dim UltraGridColumn955 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn956 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado1")
        Dim UltraGridColumn957 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto1")
        Dim UltraGridColumn958 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto2")
        Dim UltraGridColumn959 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto3")
        Dim UltraGridColumn960 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volumen")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem21 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem22 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem23 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem24 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccionar Plantillas segun el cambio de cliente", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione Centro", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo6 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Ingrese Observacion de la Liquidacion", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem16 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem17 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem18 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem19 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo7 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione Cliente", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand21 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn961 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoRuta")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn962 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("20M3")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn963 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("30M3")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn964 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("40M3")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn965 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("50M3")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn966 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("65M3")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn237 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoRuta")
        Dim UltraDataColumn238 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("20M3")
        Dim UltraDataColumn239 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("30M3")
        Dim UltraDataColumn240 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("40M3")
        Dim UltraDataColumn241 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("50M3")
        Dim UltraDataColumn242 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("65M3")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand22 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn967 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoRuta")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn968 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("20M3")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn969 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("30M3")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn970 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("40M3")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn971 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("50M3")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn972 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("65M3")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem20 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccionar Plantilla segun el cambio de cliente", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Modificar Fletes Masivamente Segun el filtro actual", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Ingrese Observacion de la Liquidacion", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaViajesAntiguos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdLista = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLiquidacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Enviar = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivideLiquidacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdLiquidacion = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTarifasSPSA = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdViajesSPSA = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.griControlViajesSPSA = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griViajesSPSA = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesSinLiquidar = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuAgregar = New ISL.Controles.MenuContextual(Me.components)
        Me.Agregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdLiquidacionDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesLiquidacionDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuQuitar = New ISL.Controles.MenuContextual(Me.components)
        Me.Quitar = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesSinLiquidarSPSA = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdLiquidacionDetalleSPSA = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesLiquidacionDetalleSPSA = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesSinLiquidarTOTTUS = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdLiquidacionDetalleTOTTUS = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesLiquidacionDetalleTOTTUS = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesSinLiquidarMAESTRO = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdLiquidacionDetalleMAESTRO = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesLiquidacionDetalleMAESTRO = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.opcPlantilla = New ISL.Controles.Opciones(Me.components)
        Me.cboCentro = New ISL.Controles.Combo(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHastaViaje = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesdeViaje = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtOperacionesSinConfirmar = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.opcFormatoLiquidacion = New ISL.Controles.Opciones(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboClienteLiquidacion = New ISL.Controles.ComboMaestros(Me.components)
        Me.btnSeleccionaViajes = New Infragistics.Win.Misc.UltraButton()
        Me.btnViajesSinLiquidar = New Infragistics.Win.Misc.UltraButton()
        Me.grupoTipoVehiculo = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorDoctsPerdido = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorSinConfirmar = New ISL.Controles.Colores(Me.components)
        Me.ColorConDocts = New ISL.Controles.Colores(Me.components)
        Me.ColorSinDocts = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTarifas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdTarifas = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTarifasRetorno = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabListaLiquidaciones = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.btnActualizaDocumentosGuias = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.opcPlantillaLista = New ISL.Controles.Opciones(Me.components)
        Me.Colores2 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFormato7 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFormato6 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFormato5 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFormato3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFormato4 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFormato2 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFormato0 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFormato1 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorCambio = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnEnviarCorreo = New ISL.Controles.Boton(Me.components)
        Me.cboCliente = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnExpandido = New Infragistics.Win.Misc.UltraButton()
        Me.BtnN2 = New Infragistics.Win.Misc.UltraButton()
        Me.btnN1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.opcActualizarGuias = New ISL.Controles.Opciones(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabDetalleLiquidacion = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.tabAdicional = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnActualizarFleteUnitario = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtFleteUnitario = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.fecLiquidacion = New ISL.Controles.Fecha(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.txtIdLiquidacion = New ISL.Controles.Texto(Me.components)
        Me.txtTotal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtObservacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIgv = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtSubTotal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.ficLiquidacion = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griListaViajesAntiguos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.ogdLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl17.SuspendLayout()
        CType(Me.griTarifasSPSA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdViajesSPSA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griControlViajesSPSA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.griViajesSPSA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griViajesSinLiquidar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAgregar.SuspendLayout()
        CType(Me.ogdLiquidacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griViajesLiquidacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuQuitar.SuspendLayout()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.griViajesSinLiquidarSPSA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdLiquidacionDetalleSPSA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.griViajesLiquidacionDetalleSPSA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.griViajesSinLiquidarTOTTUS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdLiquidacionDetalleTOTTUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl13.SuspendLayout()
        CType(Me.griViajesLiquidacionDetalleTOTTUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl14.SuspendLayout()
        CType(Me.griViajesSinLiquidarMAESTRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdLiquidacionDetalleMAESTRO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl15.SuspendLayout()
        CType(Me.griViajesLiquidacionDetalleMAESTRO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.opcPlantilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.fecHastaViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesdeViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperacionesSinConfirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opcFormatoLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoTipoVehiculo.SuspendLayout()
        CType(Me.ColorDoctsPerdido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorSinConfirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorConDocts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorSinDocts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.griTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl16.SuspendLayout()
        CType(Me.griTarifasRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.tabListaLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabListaLiquidaciones.SuspendLayout()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.opcPlantillaLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opcActualizarGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.tabDetalleLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetalleLiquidacion.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.tabAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdicional.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.fecLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficLiquidacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griListaViajesAntiguos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1054, 391)
        '
        'griListaViajesAntiguos
        '
        Me.griListaViajesAntiguos.AllowDrop = True
        Me.griListaViajesAntiguos.DataSource = Me.ogdLista
        UltraGridColumn487.Header.VisiblePosition = 0
        UltraGridColumn487.Hidden = True
        UltraGridColumn488.Header.VisiblePosition = 1
        UltraGridColumn488.Width = 100
        UltraGridColumn489.Header.VisiblePosition = 2
        UltraGridColumn489.Width = 100
        UltraGridColumn490.Header.VisiblePosition = 4
        UltraGridColumn490.Width = 100
        UltraGridColumn491.Header.VisiblePosition = 5
        UltraGridColumn491.Width = 100
        UltraGridColumn492.Header.VisiblePosition = 7
        UltraGridColumn492.Width = 150
        UltraGridColumn493.Header.VisiblePosition = 8
        UltraGridColumn493.Width = 150
        UltraGridColumn494.Header.VisiblePosition = 9
        UltraGridColumn495.Header.VisiblePosition = 10
        UltraGridColumn496.Header.VisiblePosition = 3
        UltraGridColumn496.Width = 100
        UltraGridColumn497.Header.VisiblePosition = 11
        UltraGridColumn497.Width = 200
        UltraGridColumn498.Header.VisiblePosition = 12
        UltraGridColumn498.Width = 150
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn499.CellAppearance = Appearance1
        UltraGridColumn499.Header.Caption = "TN"
        UltraGridColumn499.Header.VisiblePosition = 13
        UltraGridColumn499.MaskInput = "{LOC}nn.nn"
        UltraGridColumn499.Width = 40
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn500.CellAppearance = Appearance2
        UltraGridColumn500.Header.VisiblePosition = 16
        UltraGridColumn500.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn500.Width = 70
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn501.CellAppearance = Appearance3
        UltraGridColumn501.Header.Caption = "Cant."
        UltraGridColumn501.Header.VisiblePosition = 14
        UltraGridColumn501.MaskInput = "{LOC}nn.nn"
        UltraGridColumn501.Width = 40
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn502.CellAppearance = Appearance4
        UltraGridColumn502.Header.VisiblePosition = 15
        UltraGridColumn502.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn502.Width = 50
        UltraGridColumn503.Header.VisiblePosition = 17
        UltraGridColumn503.Width = 200
        UltraGridColumn504.Header.VisiblePosition = 18
        UltraGridColumn505.Header.VisiblePosition = 6
        UltraGridColumn506.Header.VisiblePosition = 19
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn487, UltraGridColumn488, UltraGridColumn489, UltraGridColumn490, UltraGridColumn491, UltraGridColumn492, UltraGridColumn493, UltraGridColumn494, UltraGridColumn495, UltraGridColumn496, UltraGridColumn497, UltraGridColumn498, UltraGridColumn499, UltraGridColumn500, UltraGridColumn501, UltraGridColumn502, UltraGridColumn503, UltraGridColumn504, UltraGridColumn505, UltraGridColumn506})
        UltraGridBand1.SummaryFooterCaption = "Totales:"
        UltraGridColumn507.Header.VisiblePosition = 0
        UltraGridColumn508.Header.VisiblePosition = 1
        UltraGridColumn509.Header.VisiblePosition = 18
        UltraGridColumn510.Header.VisiblePosition = 2
        UltraGridColumn511.Header.VisiblePosition = 19
        UltraGridColumn512.Header.VisiblePosition = 3
        UltraGridColumn513.Header.VisiblePosition = 4
        UltraGridColumn514.Header.VisiblePosition = 5
        UltraGridColumn515.Header.VisiblePosition = 6
        UltraGridColumn516.Header.VisiblePosition = 7
        UltraGridColumn517.Header.VisiblePosition = 8
        UltraGridColumn518.Header.VisiblePosition = 9
        UltraGridColumn519.Header.VisiblePosition = 10
        UltraGridColumn520.Header.VisiblePosition = 12
        UltraGridColumn521.Header.VisiblePosition = 13
        UltraGridColumn522.Header.VisiblePosition = 14
        UltraGridColumn523.Header.VisiblePosition = 15
        UltraGridColumn524.Header.VisiblePosition = 11
        UltraGridColumn525.Header.VisiblePosition = 16
        UltraGridColumn526.Header.VisiblePosition = 17
        UltraGridColumn527.Header.VisiblePosition = 20
        UltraGridColumn528.Header.VisiblePosition = 21
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn507, UltraGridColumn508, UltraGridColumn509, UltraGridColumn510, UltraGridColumn511, UltraGridColumn512, UltraGridColumn513, UltraGridColumn514, UltraGridColumn515, UltraGridColumn516, UltraGridColumn517, UltraGridColumn518, UltraGridColumn519, UltraGridColumn520, UltraGridColumn521, UltraGridColumn522, UltraGridColumn523, UltraGridColumn524, UltraGridColumn525, UltraGridColumn526, UltraGridColumn527, UltraGridColumn528})
        UltraGridBand2.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.HeaderIcons
        UltraGridBand2.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        UltraGridColumn529.Header.VisiblePosition = 0
        UltraGridColumn530.Header.VisiblePosition = 1
        UltraGridColumn531.Header.VisiblePosition = 2
        UltraGridColumn532.Header.VisiblePosition = 3
        UltraGridColumn533.Header.VisiblePosition = 4
        UltraGridColumn534.Header.VisiblePosition = 5
        UltraGridColumn535.Header.VisiblePosition = 6
        UltraGridColumn536.Header.VisiblePosition = 7
        UltraGridColumn537.Header.VisiblePosition = 8
        UltraGridColumn538.Header.VisiblePosition = 9
        UltraGridColumn539.Header.VisiblePosition = 10
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn529, UltraGridColumn530, UltraGridColumn531, UltraGridColumn532, UltraGridColumn533, UltraGridColumn534, UltraGridColumn535, UltraGridColumn536, UltraGridColumn537, UltraGridColumn538, UltraGridColumn539})
        UltraGridColumn540.Header.VisiblePosition = 0
        UltraGridColumn541.Header.VisiblePosition = 1
        UltraGridColumn542.Header.VisiblePosition = 2
        UltraGridColumn543.Header.VisiblePosition = 3
        UltraGridColumn544.Header.VisiblePosition = 4
        UltraGridColumn545.Header.VisiblePosition = 5
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn540, UltraGridColumn541, UltraGridColumn542, UltraGridColumn543, UltraGridColumn544, UltraGridColumn545})
        Me.griListaViajesAntiguos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaViajesAntiguos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaViajesAntiguos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListaViajesAntiguos.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaViajesAntiguos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaViajesAntiguos.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaViajesAntiguos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaViajesAntiguos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaViajesAntiguos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaViajesAntiguos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griListaViajesAntiguos.DisplayLayout.Override.CellPadding = 0
        Me.griListaViajesAntiguos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaViajesAntiguos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaViajesAntiguos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaViajesAntiguos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaViajesAntiguos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griListaViajesAntiguos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaViajesAntiguos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaViajesAntiguos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaViajesAntiguos.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griListaViajesAntiguos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaViajesAntiguos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaViajesAntiguos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaViajesAntiguos.Location = New System.Drawing.Point(0, 0)
        Me.griListaViajesAntiguos.Name = "griListaViajesAntiguos"
        Me.griListaViajesAntiguos.Size = New System.Drawing.Size(1054, 391)
        Me.griListaViajesAntiguos.TabIndex = 2
        Me.griListaViajesAntiguos.Tag = ""
        '
        'ogdLista
        '
        UltraDataBand3.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        UltraDataBand2.ChildBands.AddRange(New Object() {UltraDataBand3})
        UltraDataBand2.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        UltraDataBand1.ChildBands.AddRange(New Object() {UltraDataBand2})
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37})
        Me.ogdLista.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        Me.ogdLista.Band.Columns.AddRange(New Object() {UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griLista)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1054, 391)
        '
        'griLista
        '
        Me.griLista.AllowDrop = True
        Me.griLista.DataSource = Me.ogdLista
        UltraGridColumn546.Header.VisiblePosition = 0
        UltraGridColumn546.Hidden = True
        UltraGridColumn547.Header.VisiblePosition = 1
        UltraGridColumn547.Width = 100
        UltraGridColumn548.Header.VisiblePosition = 2
        UltraGridColumn548.Width = 100
        UltraGridColumn549.Header.VisiblePosition = 4
        UltraGridColumn549.Width = 100
        UltraGridColumn550.Header.VisiblePosition = 5
        UltraGridColumn550.Width = 100
        UltraGridColumn551.Header.VisiblePosition = 6
        UltraGridColumn551.Width = 150
        UltraGridColumn552.Header.VisiblePosition = 7
        UltraGridColumn552.Width = 150
        UltraGridColumn553.Header.VisiblePosition = 8
        UltraGridColumn554.Header.VisiblePosition = 9
        UltraGridColumn555.Header.VisiblePosition = 3
        UltraGridColumn555.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn555.Width = 100
        UltraGridColumn556.Header.VisiblePosition = 10
        UltraGridColumn556.Width = 200
        UltraGridColumn557.Header.VisiblePosition = 11
        UltraGridColumn557.Width = 150
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn558.CellAppearance = Appearance5
        UltraGridColumn558.Header.Caption = "TN"
        UltraGridColumn558.Header.VisiblePosition = 12
        UltraGridColumn558.MaskInput = "{LOC}nn.nn"
        UltraGridColumn558.Width = 40
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn559.CellAppearance = Appearance6
        UltraGridColumn559.Header.VisiblePosition = 15
        UltraGridColumn559.MaskInput = "{LOC}nnnnnnn.nnn"
        UltraGridColumn559.Width = 70
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn560.CellAppearance = Appearance7
        UltraGridColumn560.Header.Caption = "Cant."
        UltraGridColumn560.Header.VisiblePosition = 13
        UltraGridColumn560.MaskInput = "{LOC}nn.nn"
        UltraGridColumn560.Width = 40
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn561.CellAppearance = Appearance8
        UltraGridColumn561.Header.VisiblePosition = 14
        UltraGridColumn561.MaskInput = "{LOC}nnnn.nnn"
        UltraGridColumn561.Width = 50
        UltraGridColumn562.Header.VisiblePosition = 17
        UltraGridColumn562.Width = 200
        UltraGridColumn563.Header.VisiblePosition = 16
        UltraGridColumn563.Width = 150
        UltraGridColumn564.Header.VisiblePosition = 18
        UltraGridColumn565.Header.VisiblePosition = 19
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn546, UltraGridColumn547, UltraGridColumn548, UltraGridColumn549, UltraGridColumn550, UltraGridColumn551, UltraGridColumn552, UltraGridColumn553, UltraGridColumn554, UltraGridColumn555, UltraGridColumn556, UltraGridColumn557, UltraGridColumn558, UltraGridColumn559, UltraGridColumn560, UltraGridColumn561, UltraGridColumn562, UltraGridColumn563, UltraGridColumn564, UltraGridColumn565})
        UltraGridBand5.SummaryFooterCaption = "Totales:"
        UltraGridColumn566.Header.VisiblePosition = 0
        UltraGridColumn567.Header.VisiblePosition = 1
        UltraGridColumn568.Header.VisiblePosition = 2
        UltraGridColumn568.Width = 50
        UltraGridColumn569.Header.VisiblePosition = 3
        UltraGridColumn570.Header.VisiblePosition = 4
        UltraGridColumn570.Width = 50
        UltraGridColumn571.Header.VisiblePosition = 5
        UltraGridColumn572.Header.VisiblePosition = 6
        UltraGridColumn573.Header.VisiblePosition = 7
        UltraGridColumn574.Header.VisiblePosition = 8
        UltraGridColumn575.Header.VisiblePosition = 9
        UltraGridColumn576.Header.VisiblePosition = 10
        UltraGridColumn577.Header.VisiblePosition = 11
        UltraGridColumn578.Header.VisiblePosition = 12
        UltraGridColumn579.Header.VisiblePosition = 13
        UltraGridColumn580.Header.VisiblePosition = 14
        UltraGridColumn581.Header.VisiblePosition = 15
        UltraGridColumn582.Header.VisiblePosition = 16
        UltraGridColumn583.Header.VisiblePosition = 17
        UltraGridColumn584.Header.VisiblePosition = 18
        UltraGridColumn585.Header.VisiblePosition = 19
        UltraGridColumn586.Header.VisiblePosition = 20
        UltraGridColumn587.Header.VisiblePosition = 21
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn566, UltraGridColumn567, UltraGridColumn568, UltraGridColumn569, UltraGridColumn570, UltraGridColumn571, UltraGridColumn572, UltraGridColumn573, UltraGridColumn574, UltraGridColumn575, UltraGridColumn576, UltraGridColumn577, UltraGridColumn578, UltraGridColumn579, UltraGridColumn580, UltraGridColumn581, UltraGridColumn582, UltraGridColumn583, UltraGridColumn584, UltraGridColumn585, UltraGridColumn586, UltraGridColumn587})
        UltraGridBand6.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand6.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.HeaderIcons
        UltraGridBand6.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        UltraGridColumn588.Header.VisiblePosition = 0
        UltraGridColumn589.Header.VisiblePosition = 1
        UltraGridColumn590.Header.VisiblePosition = 2
        UltraGridColumn591.Header.VisiblePosition = 3
        UltraGridColumn592.Header.VisiblePosition = 4
        UltraGridColumn593.Header.VisiblePosition = 5
        UltraGridColumn594.Header.VisiblePosition = 6
        UltraGridColumn595.Header.VisiblePosition = 7
        UltraGridColumn596.Header.VisiblePosition = 8
        UltraGridColumn597.Header.VisiblePosition = 9
        UltraGridColumn598.Header.VisiblePosition = 10
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn588, UltraGridColumn589, UltraGridColumn590, UltraGridColumn591, UltraGridColumn592, UltraGridColumn593, UltraGridColumn594, UltraGridColumn595, UltraGridColumn596, UltraGridColumn597, UltraGridColumn598})
        UltraGridColumn599.Header.VisiblePosition = 0
        UltraGridColumn600.Header.VisiblePosition = 1
        UltraGridColumn601.Header.VisiblePosition = 2
        UltraGridColumn602.Header.VisiblePosition = 3
        UltraGridColumn603.Header.VisiblePosition = 4
        UltraGridColumn604.Header.VisiblePosition = 5
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn599, UltraGridColumn600, UltraGridColumn601, UltraGridColumn602, UltraGridColumn603, UltraGridColumn604})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griLista.DisplayLayout.Override.CellPadding = 0
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(0, 0)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1054, 391)
        Me.griLista.TabIndex = 1
        Me.griLista.Tag = ""
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griLiquidacion)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1054, 391)
        '
        'griLiquidacion
        '
        Me.griLiquidacion.AllowDrop = True
        Me.griLiquidacion.ContextMenuStrip = Me.Menu
        Me.griLiquidacion.DataSource = Me.ogdLiquidacion
        UltraGridColumn605.Header.VisiblePosition = 0
        UltraGridColumn605.Hidden = True
        UltraGridColumn606.Header.VisiblePosition = 1
        UltraGridColumn606.Width = 100
        UltraGridColumn607.Header.Caption = "Cliente"
        UltraGridColumn607.Header.VisiblePosition = 3
        UltraGridColumn607.Width = 200
        UltraGridColumn608.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn608.Header.VisiblePosition = 2
        UltraGridColumn608.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn608.Width = 60
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn609.CellAppearance = Appearance9
        UltraGridColumn609.Format = "#,###,###,##0.00"
        UltraGridColumn609.Header.VisiblePosition = 4
        UltraGridColumn609.MaskInput = "{LOC}nnn,nnn.nn"
        UltraGridColumn609.Width = 80
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn610.CellAppearance = Appearance10
        UltraGridColumn610.Format = "#,###,###,##0.00"
        UltraGridColumn610.Header.VisiblePosition = 5
        UltraGridColumn610.MaskInput = "{LOC}nnn,nnn.nn"
        UltraGridColumn610.Width = 60
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn611.CellAppearance = Appearance11
        UltraGridColumn611.Format = "#,###,###,##0.00"
        UltraGridColumn611.Header.VisiblePosition = 6
        UltraGridColumn611.MaskInput = "{LOC}nnn,nnn.nn"
        UltraGridColumn611.Width = 100
        UltraGridColumn612.Header.VisiblePosition = 7
        UltraGridColumn612.Width = 200
        UltraGridColumn613.Header.Caption = "Estado"
        UltraGridColumn613.Header.VisiblePosition = 8
        UltraGridColumn613.Width = 100
        UltraGridColumn614.Header.Caption = "Factura"
        UltraGridColumn614.Header.VisiblePosition = 12
        UltraGridColumn614.Width = 100
        UltraGridColumn615.Header.VisiblePosition = 9
        UltraGridColumn615.Hidden = True
        UltraGridColumn615.Width = 150
        UltraGridColumn616.Header.VisiblePosition = 10
        UltraGridColumn616.Hidden = True
        UltraGridColumn616.Width = 150
        UltraGridColumn617.Header.VisiblePosition = 11
        UltraGridColumn617.Hidden = True
        UltraGridColumn617.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn617.Width = 40
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn618.CellAppearance = Appearance12
        UltraGridColumn618.Header.Caption = "Formt"
        UltraGridColumn618.Header.VisiblePosition = 13
        UltraGridColumn618.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn618.Width = 35
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn605, UltraGridColumn606, UltraGridColumn607, UltraGridColumn608, UltraGridColumn609, UltraGridColumn610, UltraGridColumn611, UltraGridColumn612, UltraGridColumn613, UltraGridColumn614, UltraGridColumn615, UltraGridColumn616, UltraGridColumn617, UltraGridColumn618})
        UltraGridBand9.SummaryFooterCaption = "Totales:"
        Me.griLiquidacion.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griLiquidacion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLiquidacion.DisplayLayout.MaxColScrollRegions = 1
        Me.griLiquidacion.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLiquidacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLiquidacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLiquidacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLiquidacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLiquidacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLiquidacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLiquidacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLiquidacion.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griLiquidacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLiquidacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLiquidacion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLiquidacion.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griLiquidacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLiquidacion.Location = New System.Drawing.Point(0, 0)
        Me.griLiquidacion.Name = "griLiquidacion"
        Me.griLiquidacion.Size = New System.Drawing.Size(1054, 391)
        Me.griLiquidacion.TabIndex = 4
        Me.griLiquidacion.Tag = ""
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Insert, Me.Update, Me.Delete, Me.VerArchivo, Me.Enviar, Me.DivideLiquidacion})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(251, 158)
        '
        'Insert
        '
        Me.Insert.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(250, 22)
        Me.Insert.Text = "Nuevo"
        Me.Insert.ToolTipText = "Insertar una nueva Pre-Demanda"
        '
        'Update
        '
        Me.Update.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(250, 22)
        Me.Update.Text = "Actualizar"
        Me.Update.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'Delete
        '
        Me.Delete.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(250, 22)
        Me.Delete.Text = "Eliminar"
        Me.Delete.ToolTipText = "Eliminar la Pre-Demanda seleccionada"
        '
        'VerArchivo
        '
        Me.VerArchivo.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.VerArchivo.Name = "VerArchivo"
        Me.VerArchivo.Size = New System.Drawing.Size(250, 22)
        Me.VerArchivo.Text = "VerArchivo"
        Me.VerArchivo.ToolTipText = "Ver Liquidacion archivo generado segun FORMATO"
        '
        'Enviar
        '
        Me.Enviar.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.Enviar.Name = "Enviar"
        Me.Enviar.Size = New System.Drawing.Size(250, 22)
        Me.Enviar.Text = "Enviar (Facturacion)"
        Me.Enviar.ToolTipText = "Liquidacion pasara al area de facturacion"
        '
        'DivideLiquidacion
        '
        Me.DivideLiquidacion.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.DivideLiquidacion.Name = "DivideLiquidacion"
        Me.DivideLiquidacion.Size = New System.Drawing.Size(250, 22)
        Me.DivideLiquidacion.Text = "Falabella/Sodimac/Tottus Divide Liq."
        '
        'ogdLiquidacion
        '
        Me.ogdLiquidacion.Band.Columns.AddRange(New Object() {UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70})
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Controls.Add(Me.griTarifasSPSA)
        Me.UltraTabPageControl17.Controls.Add(Me.griControlViajesSPSA)
        Me.UltraTabPageControl17.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(1054, 391)
        '
        'griTarifasSPSA
        '
        Me.griTarifasSPSA.DataSource = Me.ogdViajesSPSA
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griTarifasSPSA.DisplayLayout.Appearance = Appearance13
        UltraGridBand10.ColHeaderLines = 3
        UltraGridColumn619.Header.VisiblePosition = 0
        UltraGridColumn619.Hidden = True
        UltraGridColumn619.Width = 70
        UltraGridColumn620.Header.VisiblePosition = 1
        UltraGridColumn620.Hidden = True
        UltraGridColumn620.Width = 30
        Appearance14.TextHAlignAsString = "Center"
        Appearance14.TextVAlignAsString = "Middle"
        UltraGridColumn621.CellAppearance = Appearance14
        UltraGridColumn621.Header.Caption = "Tarifa x unidad"
        UltraGridColumn621.Header.VisiblePosition = 3
        UltraGridColumn621.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn621.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn621.Width = 76
        Appearance15.TextHAlignAsString = "Center"
        Appearance15.TextVAlignAsString = "Middle"
        UltraGridColumn622.CellAppearance = Appearance15
        UltraGridColumn622.Header.Caption = "Promedio Inferior de viajes por unidad"
        UltraGridColumn622.Header.VisiblePosition = 4
        UltraGridColumn622.Width = 80
        Appearance16.TextHAlignAsString = "Center"
        UltraGridColumn623.CellAppearance = Appearance16
        UltraGridColumn623.Header.Caption = "asPromedio Superior de viajes por unidad"
        UltraGridColumn623.Header.VisiblePosition = 5
        UltraGridColumn623.Width = 80
        Appearance17.TextHAlignAsString = "Center"
        UltraGridColumn624.CellAppearance = Appearance17
        UltraGridColumn624.Header.Caption = "N° de Vuelta"
        UltraGridColumn624.Header.VisiblePosition = 2
        UltraGridColumn624.Width = 80
        UltraGridColumn625.Header.VisiblePosition = 6
        UltraGridColumn625.Hidden = True
        UltraGridColumn625.Width = 40
        UltraGridColumn626.Header.VisiblePosition = 7
        UltraGridColumn626.Hidden = True
        UltraGridColumn626.Width = 70
        Appearance18.Image = 3
        Appearance18.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn627.CellAppearance = Appearance18
        Appearance19.Image = 1
        Appearance19.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn627.CellButtonAppearance = Appearance19
        UltraGridColumn627.Header.VisiblePosition = 8
        UltraGridColumn627.Hidden = True
        UltraGridColumn627.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn627.Width = 30
        UltraGridColumn628.Header.VisiblePosition = 9
        UltraGridColumn628.Hidden = True
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn619, UltraGridColumn620, UltraGridColumn621, UltraGridColumn622, UltraGridColumn623, UltraGridColumn624, UltraGridColumn625, UltraGridColumn626, UltraGridColumn627, UltraGridColumn628})
        Me.griTarifasSPSA.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.griTarifasSPSA.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifasSPSA.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTarifasSPSA.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.BorderColor = System.Drawing.SystemColors.Window
        Me.griTarifasSPSA.DisplayLayout.GroupByBox.Appearance = Appearance20
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griTarifasSPSA.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance21
        Me.griTarifasSPSA.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifasSPSA.DisplayLayout.GroupByBox.Hidden = True
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance22.BackColor2 = System.Drawing.SystemColors.Control
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griTarifasSPSA.DisplayLayout.GroupByBox.PromptAppearance = Appearance22
        Me.griTarifasSPSA.DisplayLayout.MaxColScrollRegions = 1
        Me.griTarifasSPSA.DisplayLayout.MaxRowScrollRegions = 1
        Me.griTarifasSPSA.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griTarifasSPSA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTarifasSPSA.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance23.TextHAlignAsString = "Center"
        Appearance23.TextVAlignAsString = "Middle"
        Me.griTarifasSPSA.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.griTarifasSPSA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTarifasSPSA.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griTarifasSPSA.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griTarifasSPSA.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTarifasSPSA.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTarifasSPSA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTarifasSPSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTarifasSPSA.ImageList = Me.imagenes
        Me.griTarifasSPSA.Location = New System.Drawing.Point(0, 224)
        Me.griTarifasSPSA.Name = "griTarifasSPSA"
        Me.griTarifasSPSA.Size = New System.Drawing.Size(561, 167)
        Me.griTarifasSPSA.TabIndex = 1
        Me.griTarifasSPSA.Text = "TARIFARIO SPSA"
        '
        'ogdViajesSPSA
        '
        Me.ogdViajesSPSA.Band.Columns.AddRange(New Object() {UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80})
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
        'griControlViajesSPSA
        '
        Me.griControlViajesSPSA.DataSource = Me.ogdViajesSPSA
        Appearance24.BackColor = System.Drawing.SystemColors.Window
        Appearance24.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griControlViajesSPSA.DisplayLayout.Appearance = Appearance24
        UltraGridColumn629.Header.VisiblePosition = 0
        UltraGridColumn629.Width = 70
        UltraGridColumn630.Header.VisiblePosition = 1
        UltraGridColumn630.Width = 30
        UltraGridColumn631.Header.VisiblePosition = 2
        UltraGridColumn631.Width = 30
        UltraGridColumn632.Header.VisiblePosition = 3
        UltraGridColumn632.Width = 35
        UltraGridColumn633.Header.VisiblePosition = 4
        UltraGridColumn633.Width = 40
        UltraGridColumn634.Header.VisiblePosition = 5
        UltraGridColumn634.Width = 40
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn635.CellAppearance = Appearance25
        UltraGridColumn635.Header.VisiblePosition = 6
        UltraGridColumn635.MaskInput = "{LOC}nn.n"
        UltraGridColumn635.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn635.Width = 40
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn636.CellAppearance = Appearance26
        UltraGridColumn636.Header.VisiblePosition = 7
        UltraGridColumn636.MaskInput = "{LOC}nnnnnn.nn"
        UltraGridColumn636.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn636.Width = 70
        Appearance27.Image = 3
        Appearance27.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn637.CellAppearance = Appearance27
        Appearance28.Image = 1
        Appearance28.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn637.CellButtonAppearance = Appearance28
        UltraGridColumn637.Header.VisiblePosition = 8
        UltraGridColumn637.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn637.Width = 30
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn638.CellAppearance = Appearance29
        UltraGridColumn638.Header.VisiblePosition = 9
        UltraGridColumn638.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn638.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn638.Width = 60
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn629, UltraGridColumn630, UltraGridColumn631, UltraGridColumn632, UltraGridColumn633, UltraGridColumn634, UltraGridColumn635, UltraGridColumn636, UltraGridColumn637, UltraGridColumn638})
        Me.griControlViajesSPSA.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.griControlViajesSPSA.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griControlViajesSPSA.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griControlViajesSPSA.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance30.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance30.BorderColor = System.Drawing.SystemColors.Window
        Me.griControlViajesSPSA.DisplayLayout.GroupByBox.Appearance = Appearance30
        Appearance31.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griControlViajesSPSA.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance31
        Me.griControlViajesSPSA.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griControlViajesSPSA.DisplayLayout.GroupByBox.Hidden = True
        Appearance32.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance32.BackColor2 = System.Drawing.SystemColors.Control
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance32.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griControlViajesSPSA.DisplayLayout.GroupByBox.PromptAppearance = Appearance32
        Me.griControlViajesSPSA.DisplayLayout.MaxColScrollRegions = 1
        Me.griControlViajesSPSA.DisplayLayout.MaxRowScrollRegions = 1
        Me.griControlViajesSPSA.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griControlViajesSPSA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griControlViajesSPSA.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griControlViajesSPSA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griControlViajesSPSA.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griControlViajesSPSA.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griControlViajesSPSA.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griControlViajesSPSA.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griControlViajesSPSA.Dock = System.Windows.Forms.DockStyle.Top
        Me.griControlViajesSPSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griControlViajesSPSA.ImageList = Me.imagenes
        Me.griControlViajesSPSA.Location = New System.Drawing.Point(0, 0)
        Me.griControlViajesSPSA.Name = "griControlViajesSPSA"
        Me.griControlViajesSPSA.Size = New System.Drawing.Size(561, 224)
        Me.griControlViajesSPSA.TabIndex = 0
        Me.griControlViajesSPSA.Text = "CONTROL VIAJES SPSA"
        '
        'UltraExpandableGroupBox2
        '
        Appearance33.BackColor = System.Drawing.Color.White
        Appearance33.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance33
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(493, 391)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(561, 0)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(493, 391)
        Me.UltraExpandableGroupBox2.TabIndex = 1
        Me.UltraExpandableGroupBox2.Text = "Tarifas SPSA"
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.griViajesSPSA)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(470, 385)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'griViajesSPSA
        '
        Me.griViajesSPSA.DataSource = Me.ogdViajesSPSA
        Appearance34.BackColor = System.Drawing.SystemColors.Window
        Appearance34.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griViajesSPSA.DisplayLayout.Appearance = Appearance34
        UltraGridColumn639.Header.VisiblePosition = 6
        UltraGridColumn639.Width = 70
        UltraGridColumn640.Header.VisiblePosition = 3
        UltraGridColumn640.Width = 30
        UltraGridColumn641.Header.VisiblePosition = 4
        UltraGridColumn641.Width = 30
        UltraGridColumn642.Header.VisiblePosition = 5
        UltraGridColumn642.Width = 30
        UltraGridColumn643.Header.Caption = "N° Vuelta"
        UltraGridColumn643.Header.VisiblePosition = 2
        UltraGridColumn643.Width = 40
        UltraGridColumn644.Header.Caption = "Viaje"
        UltraGridColumn644.Header.VisiblePosition = 0
        UltraGridColumn644.Width = 110
        UltraGridColumn645.Header.Caption = "CodigoCamion"
        UltraGridColumn645.Header.VisiblePosition = 7
        UltraGridColumn645.Hidden = True
        UltraGridColumn645.Width = 30
        UltraGridColumn646.Header.Caption = "Camion"
        UltraGridColumn646.Header.VisiblePosition = 1
        UltraGridColumn646.Width = 70
        UltraGridColumn647.Header.VisiblePosition = 8
        UltraGridColumn647.Hidden = True
        UltraGridColumn647.Width = 30
        UltraGridColumn648.Header.VisiblePosition = 9
        UltraGridColumn648.Hidden = True
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn639, UltraGridColumn640, UltraGridColumn641, UltraGridColumn642, UltraGridColumn643, UltraGridColumn644, UltraGridColumn645, UltraGridColumn646, UltraGridColumn647, UltraGridColumn648})
        Me.griViajesSPSA.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.griViajesSPSA.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViajesSPSA.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesSPSA.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance35.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.griViajesSPSA.DisplayLayout.GroupByBox.Appearance = Appearance35
        Appearance36.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griViajesSPSA.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance36
        Me.griViajesSPSA.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViajesSPSA.DisplayLayout.GroupByBox.Hidden = True
        Appearance37.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance37.BackColor2 = System.Drawing.SystemColors.Control
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance37.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griViajesSPSA.DisplayLayout.GroupByBox.PromptAppearance = Appearance37
        Me.griViajesSPSA.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesSPSA.DisplayLayout.MaxRowScrollRegions = 1
        Me.griViajesSPSA.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesSPSA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesSPSA.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesSPSA.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesSPSA.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesSPSA.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesSPSA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesSPSA.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesSPSA.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesSPSA.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesSPSA.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griViajesSPSA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesSPSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesSPSA.Location = New System.Drawing.Point(0, 0)
        Me.griViajesSPSA.Name = "griViajesSPSA"
        Me.griViajesSPSA.Size = New System.Drawing.Size(470, 385)
        Me.griViajesSPSA.TabIndex = 1
        Me.griViajesSPSA.Text = "VIAJES DETALLE SPSA"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griViajesSinLiquidar)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1054, 366)
        '
        'griViajesSinLiquidar
        '
        Me.griViajesSinLiquidar.AllowDrop = True
        Me.griViajesSinLiquidar.ContextMenuStrip = Me.MenuAgregar
        Me.griViajesSinLiquidar.DataSource = Me.ogdLiquidacionDetalle
        UltraGridColumn649.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn649.Header.Caption = "Select"
        UltraGridColumn649.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn649.Header.VisiblePosition = 0
        UltraGridColumn649.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn649.Width = 40
        Appearance38.TextHAlignAsString = "Left"
        Appearance38.TextVAlignAsString = "Middle"
        UltraGridColumn650.CellAppearance = Appearance38
        UltraGridColumn650.Header.VisiblePosition = 2
        UltraGridColumn650.Hidden = True
        UltraGridColumn650.Width = 100
        UltraGridColumn651.Header.VisiblePosition = 3
        UltraGridColumn651.Hidden = True
        UltraGridColumn651.Width = 100
        UltraGridColumn652.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance39.TextHAlignAsString = "Left"
        Appearance39.TextVAlignAsString = "Middle"
        UltraGridColumn652.CellAppearance = Appearance39
        UltraGridColumn652.Header.VisiblePosition = 1
        UltraGridColumn652.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn652.Width = 100
        UltraGridColumn653.Header.VisiblePosition = 5
        UltraGridColumn653.Hidden = True
        UltraGridColumn653.Width = 100
        UltraGridColumn654.Header.VisiblePosition = 4
        UltraGridColumn654.Hidden = True
        UltraGridColumn655.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn655.Header.VisiblePosition = 6
        UltraGridColumn655.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn655.Width = 60
        UltraGridColumn656.Header.Caption = "Cent.Orig"
        UltraGridColumn656.Header.VisiblePosition = 7
        UltraGridColumn656.Width = 50
        UltraGridColumn657.Header.VisiblePosition = 8
        UltraGridColumn657.Width = 150
        UltraGridColumn658.Header.Caption = "Cent.Dest"
        UltraGridColumn658.Header.VisiblePosition = 9
        UltraGridColumn658.Width = 50
        UltraGridColumn659.Header.Caption = "Local"
        UltraGridColumn659.Header.VisiblePosition = 10
        UltraGridColumn659.Width = 200
        UltraGridColumn660.Header.VisiblePosition = 11
        UltraGridColumn660.Width = 70
        UltraGridColumn661.Header.VisiblePosition = 12
        UltraGridColumn661.Width = 70
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn662.CellAppearance = Appearance40
        UltraGridColumn662.Header.Caption = "Cap.Carga"
        UltraGridColumn662.Header.VisiblePosition = 13
        UltraGridColumn662.Width = 40
        Appearance41.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance41.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn663.CellAppearance = Appearance41
        UltraGridColumn663.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn663.Header.Caption = "FleteUnit."
        UltraGridColumn663.Header.VisiblePosition = 16
        UltraGridColumn663.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn663.Width = 60
        Appearance42.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance42.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn664.CellAppearance = Appearance42
        UltraGridColumn664.Header.VisiblePosition = 17
        UltraGridColumn664.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn664.Width = 70
        UltraGridColumn665.Header.VisiblePosition = 14
        UltraGridColumn665.Width = 40
        UltraGridColumn666.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn666.Header.VisiblePosition = 18
        UltraGridColumn666.Width = 100
        UltraGridColumn667.Header.VisiblePosition = 19
        UltraGridColumn667.Width = 100
        UltraGridColumn668.Header.VisiblePosition = 20
        UltraGridColumn668.Width = 100
        UltraGridColumn669.Header.VisiblePosition = 21
        UltraGridColumn669.Hidden = True
        UltraGridColumn670.Header.VisiblePosition = 22
        UltraGridColumn670.Hidden = True
        UltraGridColumn671.Header.VisiblePosition = 23
        UltraGridColumn671.Hidden = True
        UltraGridColumn672.Header.VisiblePosition = 24
        UltraGridColumn672.Hidden = True
        UltraGridColumn673.Header.VisiblePosition = 25
        UltraGridColumn673.Width = 100
        UltraGridColumn674.Header.VisiblePosition = 27
        UltraGridColumn674.Hidden = True
        UltraGridColumn675.Header.VisiblePosition = 15
        UltraGridColumn675.Width = 90
        UltraGridColumn676.Header.VisiblePosition = 28
        UltraGridColumn676.Hidden = True
        UltraGridColumn677.Header.VisiblePosition = 29
        UltraGridColumn677.Hidden = True
        UltraGridColumn678.Header.VisiblePosition = 30
        UltraGridColumn678.Hidden = True
        UltraGridColumn679.Header.VisiblePosition = 31
        UltraGridColumn679.Hidden = True
        UltraGridColumn680.Header.VisiblePosition = 32
        UltraGridColumn680.Hidden = True
        UltraGridColumn681.Header.VisiblePosition = 33
        UltraGridColumn681.Hidden = True
        UltraGridColumn682.Header.VisiblePosition = 34
        UltraGridColumn682.Hidden = True
        UltraGridColumn683.Header.VisiblePosition = 35
        UltraGridColumn683.Hidden = True
        UltraGridColumn683.Width = 100
        UltraGridColumn684.Header.VisiblePosition = 36
        UltraGridColumn684.Hidden = True
        UltraGridColumn685.Header.VisiblePosition = 37
        UltraGridColumn685.Hidden = True
        UltraGridColumn686.Header.VisiblePosition = 38
        UltraGridColumn686.Hidden = True
        UltraGridColumn687.Header.VisiblePosition = 26
        UltraGridColumn687.Hidden = True
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn649, UltraGridColumn650, UltraGridColumn651, UltraGridColumn652, UltraGridColumn653, UltraGridColumn654, UltraGridColumn655, UltraGridColumn656, UltraGridColumn657, UltraGridColumn658, UltraGridColumn659, UltraGridColumn660, UltraGridColumn661, UltraGridColumn662, UltraGridColumn663, UltraGridColumn664, UltraGridColumn665, UltraGridColumn666, UltraGridColumn667, UltraGridColumn668, UltraGridColumn669, UltraGridColumn670, UltraGridColumn671, UltraGridColumn672, UltraGridColumn673, UltraGridColumn674, UltraGridColumn675, UltraGridColumn676, UltraGridColumn677, UltraGridColumn678, UltraGridColumn679, UltraGridColumn680, UltraGridColumn681, UltraGridColumn682, UltraGridColumn683, UltraGridColumn684, UltraGridColumn685, UltraGridColumn686, UltraGridColumn687})
        UltraGridBand13.SummaryFooterCaption = "Totales:"
        Me.griViajesSinLiquidar.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.griViajesSinLiquidar.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griViajesSinLiquidar.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesSinLiquidar.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesSinLiquidar.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesSinLiquidar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesSinLiquidar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesSinLiquidar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesSinLiquidar.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesSinLiquidar.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesSinLiquidar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesSinLiquidar.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griViajesSinLiquidar.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesSinLiquidar.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesSinLiquidar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesSinLiquidar.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajesSinLiquidar.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesSinLiquidar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesSinLiquidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesSinLiquidar.Location = New System.Drawing.Point(0, 0)
        Me.griViajesSinLiquidar.Name = "griViajesSinLiquidar"
        Me.griViajesSinLiquidar.Size = New System.Drawing.Size(1054, 366)
        Me.griViajesSinLiquidar.TabIndex = 3
        Me.griViajesSinLiquidar.Tag = ""
        '
        'MenuAgregar
        '
        Me.MenuAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuAgregar.ForeColor = System.Drawing.Color.Black
        Me.MenuAgregar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Agregar})
        Me.MenuAgregar.Name = "MenuContextual1"
        Me.MenuAgregar.Size = New System.Drawing.Size(183, 26)
        '
        'Agregar
        '
        Me.Agregar.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(182, 22)
        Me.Agregar.Text = "Agregar seleccionados"
        Me.Agregar.ToolTipText = "Agregar viajes seleccionados a la liquidacion"
        '
        'ogdLiquidacionDetalle
        '
        UltraDataColumn81.DataType = GetType(Boolean)
        Me.ogdLiquidacionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119})
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griViajesLiquidacionDetalle)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1054, 366)
        '
        'griViajesLiquidacionDetalle
        '
        Me.griViajesLiquidacionDetalle.AllowDrop = True
        Me.griViajesLiquidacionDetalle.ContextMenuStrip = Me.MenuQuitar
        Me.griViajesLiquidacionDetalle.DataSource = Me.ogdLiquidacionDetalle
        UltraGridColumn688.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn688.Header.Caption = "Select"
        UltraGridColumn688.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn688.Header.VisiblePosition = 0
        UltraGridColumn688.Hidden = True
        UltraGridColumn688.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn688.Width = 40
        Appearance43.TextHAlignAsString = "Left"
        Appearance43.TextVAlignAsString = "Middle"
        UltraGridColumn689.CellAppearance = Appearance43
        UltraGridColumn689.Header.VisiblePosition = 2
        UltraGridColumn689.Hidden = True
        UltraGridColumn689.Width = 100
        UltraGridColumn690.Header.VisiblePosition = 3
        UltraGridColumn690.Hidden = True
        UltraGridColumn690.Width = 100
        UltraGridColumn691.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance44.TextHAlignAsString = "Left"
        Appearance44.TextVAlignAsString = "Middle"
        UltraGridColumn691.CellAppearance = Appearance44
        UltraGridColumn691.Header.VisiblePosition = 1
        UltraGridColumn691.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn691.Width = 100
        UltraGridColumn692.Header.VisiblePosition = 5
        UltraGridColumn692.Hidden = True
        UltraGridColumn692.Width = 100
        UltraGridColumn693.Header.VisiblePosition = 4
        UltraGridColumn693.Hidden = True
        UltraGridColumn694.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn694.Header.VisiblePosition = 6
        UltraGridColumn694.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn694.Width = 60
        UltraGridColumn695.Header.Caption = "Cent.Orig"
        UltraGridColumn695.Header.VisiblePosition = 7
        UltraGridColumn695.Width = 50
        UltraGridColumn696.Header.VisiblePosition = 8
        UltraGridColumn696.Width = 150
        UltraGridColumn697.Header.Caption = "Cent.Dest"
        UltraGridColumn697.Header.VisiblePosition = 9
        UltraGridColumn697.Width = 50
        UltraGridColumn698.Header.Caption = "Local"
        UltraGridColumn698.Header.VisiblePosition = 10
        UltraGridColumn698.Width = 200
        UltraGridColumn699.Header.VisiblePosition = 11
        UltraGridColumn699.Width = 70
        UltraGridColumn700.Header.VisiblePosition = 12
        UltraGridColumn700.Width = 70
        Appearance45.TextHAlignAsString = "Right"
        UltraGridColumn701.CellAppearance = Appearance45
        UltraGridColumn701.Header.Caption = "Cap.Carga"
        UltraGridColumn701.Header.VisiblePosition = 13
        UltraGridColumn701.Width = 40
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn702.CellAppearance = Appearance46
        UltraGridColumn702.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn702.Header.Caption = "FleteUnit."
        UltraGridColumn702.Header.VisiblePosition = 16
        UltraGridColumn702.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn702.Width = 60
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn703.CellAppearance = Appearance47
        UltraGridColumn703.Header.VisiblePosition = 17
        UltraGridColumn703.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn703.Width = 70
        UltraGridColumn704.Header.VisiblePosition = 14
        UltraGridColumn704.Width = 40
        UltraGridColumn705.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn705.Header.VisiblePosition = 18
        UltraGridColumn705.Width = 100
        UltraGridColumn706.Header.VisiblePosition = 19
        UltraGridColumn706.Width = 100
        UltraGridColumn707.Header.VisiblePosition = 20
        UltraGridColumn707.Width = 100
        UltraGridColumn708.Header.VisiblePosition = 21
        UltraGridColumn708.Hidden = True
        UltraGridColumn709.Header.VisiblePosition = 22
        UltraGridColumn709.Hidden = True
        UltraGridColumn710.Header.VisiblePosition = 23
        UltraGridColumn710.Hidden = True
        UltraGridColumn711.Header.VisiblePosition = 24
        UltraGridColumn711.Hidden = True
        UltraGridColumn712.Header.VisiblePosition = 26
        UltraGridColumn712.Width = 100
        UltraGridColumn713.Header.VisiblePosition = 27
        UltraGridColumn713.Hidden = True
        UltraGridColumn714.Header.VisiblePosition = 15
        UltraGridColumn714.Width = 90
        UltraGridColumn715.Header.VisiblePosition = 28
        UltraGridColumn715.Hidden = True
        UltraGridColumn716.Header.VisiblePosition = 29
        UltraGridColumn716.Hidden = True
        UltraGridColumn717.Header.VisiblePosition = 30
        UltraGridColumn717.Hidden = True
        UltraGridColumn718.Header.VisiblePosition = 31
        UltraGridColumn718.Hidden = True
        UltraGridColumn719.Header.VisiblePosition = 32
        UltraGridColumn719.Hidden = True
        UltraGridColumn720.Header.VisiblePosition = 25
        UltraGridColumn721.Header.VisiblePosition = 33
        UltraGridColumn721.Hidden = True
        UltraGridColumn722.Header.VisiblePosition = 34
        UltraGridColumn722.Hidden = True
        UltraGridColumn723.Header.VisiblePosition = 35
        UltraGridColumn723.Hidden = True
        UltraGridColumn724.Header.VisiblePosition = 36
        UltraGridColumn724.Hidden = True
        UltraGridColumn725.Header.VisiblePosition = 37
        UltraGridColumn725.Hidden = True
        UltraGridColumn726.Header.VisiblePosition = 38
        UltraGridColumn726.Hidden = True
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn688, UltraGridColumn689, UltraGridColumn690, UltraGridColumn691, UltraGridColumn692, UltraGridColumn693, UltraGridColumn694, UltraGridColumn695, UltraGridColumn696, UltraGridColumn697, UltraGridColumn698, UltraGridColumn699, UltraGridColumn700, UltraGridColumn701, UltraGridColumn702, UltraGridColumn703, UltraGridColumn704, UltraGridColumn705, UltraGridColumn706, UltraGridColumn707, UltraGridColumn708, UltraGridColumn709, UltraGridColumn710, UltraGridColumn711, UltraGridColumn712, UltraGridColumn713, UltraGridColumn714, UltraGridColumn715, UltraGridColumn716, UltraGridColumn717, UltraGridColumn718, UltraGridColumn719, UltraGridColumn720, UltraGridColumn721, UltraGridColumn722, UltraGridColumn723, UltraGridColumn724, UltraGridColumn725, UltraGridColumn726})
        UltraGridBand14.SummaryFooterCaption = "Totales:"
        Me.griViajesLiquidacionDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.griViajesLiquidacionDetalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griViajesLiquidacionDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesLiquidacionDetalle.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajesLiquidacionDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesLiquidacionDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesLiquidacionDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesLiquidacionDetalle.Location = New System.Drawing.Point(0, 0)
        Me.griViajesLiquidacionDetalle.Name = "griViajesLiquidacionDetalle"
        Me.griViajesLiquidacionDetalle.Size = New System.Drawing.Size(1054, 366)
        Me.griViajesLiquidacionDetalle.TabIndex = 4
        Me.griViajesLiquidacionDetalle.Tag = ""
        '
        'MenuQuitar
        '
        Me.MenuQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuQuitar.ForeColor = System.Drawing.Color.Black
        Me.MenuQuitar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Quitar})
        Me.MenuQuitar.Name = "MenuContextual1"
        Me.MenuQuitar.Size = New System.Drawing.Size(129, 26)
        '
        'Quitar
        '
        Me.Quitar.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.Quitar.Name = "Quitar"
        Me.Quitar.Size = New System.Drawing.Size(128, 22)
        Me.Quitar.Text = "Quitar Viaje"
        Me.Quitar.ToolTipText = "Quitar viajes seleccionados a la liquidacion"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.griViajesSinLiquidarSPSA)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1054, 366)
        '
        'griViajesSinLiquidarSPSA
        '
        Me.griViajesSinLiquidarSPSA.AllowDrop = True
        Me.griViajesSinLiquidarSPSA.ContextMenuStrip = Me.MenuAgregar
        Me.griViajesSinLiquidarSPSA.DataSource = Me.ogdLiquidacionDetalleSPSA
        UltraGridColumn727.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn727.Header.Caption = "Select"
        UltraGridColumn727.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn727.Header.VisiblePosition = 0
        UltraGridColumn727.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn727.Width = 40
        Appearance48.TextHAlignAsString = "Left"
        Appearance48.TextVAlignAsString = "Middle"
        UltraGridColumn728.CellAppearance = Appearance48
        UltraGridColumn728.Header.VisiblePosition = 2
        UltraGridColumn728.Hidden = True
        UltraGridColumn728.Width = 100
        UltraGridColumn729.Header.VisiblePosition = 3
        UltraGridColumn729.Hidden = True
        UltraGridColumn729.Width = 100
        UltraGridColumn730.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance49.TextHAlignAsString = "Left"
        Appearance49.TextVAlignAsString = "Middle"
        UltraGridColumn730.CellAppearance = Appearance49
        UltraGridColumn730.Header.VisiblePosition = 1
        UltraGridColumn730.Hidden = True
        UltraGridColumn730.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn730.Width = 100
        UltraGridColumn731.Header.VisiblePosition = 5
        UltraGridColumn731.Width = 100
        UltraGridColumn732.Header.VisiblePosition = 4
        UltraGridColumn732.Hidden = True
        UltraGridColumn733.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn733.Header.VisiblePosition = 6
        UltraGridColumn733.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn733.Width = 60
        UltraGridColumn734.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn734.Header.Caption = "Cent.Orig"
        UltraGridColumn734.Header.VisiblePosition = 7
        UltraGridColumn734.Hidden = True
        UltraGridColumn734.Width = 100
        UltraGridColumn735.Header.VisiblePosition = 10
        UltraGridColumn735.Width = 100
        UltraGridColumn736.Header.Caption = "Cent.Dest"
        UltraGridColumn736.Header.VisiblePosition = 8
        UltraGridColumn736.Hidden = True
        UltraGridColumn736.Width = 50
        UltraGridColumn737.Header.Caption = "Destino Final"
        UltraGridColumn737.Header.VisiblePosition = 11
        UltraGridColumn737.Width = 150
        UltraGridColumn738.Header.VisiblePosition = 15
        UltraGridColumn738.Width = 70
        UltraGridColumn739.Header.VisiblePosition = 16
        UltraGridColumn739.Width = 70
        Appearance50.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance50.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn740.CellAppearance = Appearance50
        UltraGridColumn740.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn740.Header.Caption = "Cap.Carga"
        UltraGridColumn740.Header.VisiblePosition = 14
        UltraGridColumn740.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn740.Width = 50
        Appearance51.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance51.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn741.CellAppearance = Appearance51
        UltraGridColumn741.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn741.Header.Caption = "FleteUnit."
        UltraGridColumn741.Header.VisiblePosition = 18
        UltraGridColumn741.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn741.Width = 60
        Appearance52.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance52.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance52.TextHAlignAsString = "Right"
        UltraGridColumn742.CellAppearance = Appearance52
        UltraGridColumn742.Header.VisiblePosition = 20
        UltraGridColumn742.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn742.Width = 70
        Appearance53.TextHAlignAsString = "Center"
        UltraGridColumn743.CellAppearance = Appearance53
        UltraGridColumn743.Header.Caption = "I y V"
        UltraGridColumn743.Header.VisiblePosition = 17
        UltraGridColumn743.Width = 40
        UltraGridColumn744.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn744.Header.VisiblePosition = 22
        UltraGridColumn744.Width = 200
        UltraGridColumn745.Header.VisiblePosition = 23
        UltraGridColumn745.Width = 200
        UltraGridColumn746.Header.VisiblePosition = 24
        UltraGridColumn746.Width = 200
        UltraGridColumn747.Header.VisiblePosition = 25
        UltraGridColumn747.Hidden = True
        UltraGridColumn748.Header.VisiblePosition = 26
        UltraGridColumn748.Hidden = True
        UltraGridColumn749.Header.VisiblePosition = 27
        UltraGridColumn749.Hidden = True
        UltraGridColumn750.Header.VisiblePosition = 28
        UltraGridColumn750.Hidden = True
        UltraGridColumn751.Header.Caption = "CargaMaterial"
        UltraGridColumn751.Header.VisiblePosition = 30
        UltraGridColumn751.Width = 150
        UltraGridColumn752.Header.VisiblePosition = 29
        UltraGridColumn752.Hidden = True
        UltraGridColumn753.Header.VisiblePosition = 21
        UltraGridColumn753.Width = 100
        UltraGridColumn754.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn754.Header.VisiblePosition = 12
        UltraGridColumn754.Width = 150
        UltraGridColumn755.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn755.Header.VisiblePosition = 13
        UltraGridColumn755.Width = 150
        Appearance54.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance54.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance54.TextHAlignAsString = "Right"
        UltraGridColumn756.CellAppearance = Appearance54
        UltraGridColumn756.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn756.Header.VisiblePosition = 19
        UltraGridColumn756.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn756.Width = 60
        UltraGridColumn757.Header.VisiblePosition = 31
        UltraGridColumn757.Hidden = True
        UltraGridColumn758.Header.VisiblePosition = 32
        UltraGridColumn758.Hidden = True
        UltraGridColumn759.Header.VisiblePosition = 33
        UltraGridColumn759.Hidden = True
        UltraGridColumn760.Header.VisiblePosition = 34
        UltraGridColumn760.Hidden = True
        UltraGridColumn761.Header.VisiblePosition = 35
        UltraGridColumn761.Hidden = True
        UltraGridColumn762.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn762.Header.Caption = "Centro Costo Origen"
        UltraGridColumn762.Header.VisiblePosition = 9
        UltraGridColumn763.Header.VisiblePosition = 36
        UltraGridColumn763.Hidden = True
        UltraGridColumn764.Header.VisiblePosition = 37
        UltraGridColumn764.Hidden = True
        UltraGridColumn765.Header.VisiblePosition = 38
        UltraGridColumn765.Hidden = True
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn727, UltraGridColumn728, UltraGridColumn729, UltraGridColumn730, UltraGridColumn731, UltraGridColumn732, UltraGridColumn733, UltraGridColumn734, UltraGridColumn735, UltraGridColumn736, UltraGridColumn737, UltraGridColumn738, UltraGridColumn739, UltraGridColumn740, UltraGridColumn741, UltraGridColumn742, UltraGridColumn743, UltraGridColumn744, UltraGridColumn745, UltraGridColumn746, UltraGridColumn747, UltraGridColumn748, UltraGridColumn749, UltraGridColumn750, UltraGridColumn751, UltraGridColumn752, UltraGridColumn753, UltraGridColumn754, UltraGridColumn755, UltraGridColumn756, UltraGridColumn757, UltraGridColumn758, UltraGridColumn759, UltraGridColumn760, UltraGridColumn761, UltraGridColumn762, UltraGridColumn763, UltraGridColumn764, UltraGridColumn765})
        UltraGridBand15.SummaryFooterCaption = "Totales:"
        Me.griViajesSinLiquidarSPSA.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.griViajesSinLiquidarSPSA.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griViajesSinLiquidarSPSA.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesSinLiquidarSPSA.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajesSinLiquidarSPSA.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesSinLiquidarSPSA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesSinLiquidarSPSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesSinLiquidarSPSA.Location = New System.Drawing.Point(0, 0)
        Me.griViajesSinLiquidarSPSA.Name = "griViajesSinLiquidarSPSA"
        Me.griViajesSinLiquidarSPSA.Size = New System.Drawing.Size(1054, 366)
        Me.griViajesSinLiquidarSPSA.TabIndex = 4
        Me.griViajesSinLiquidarSPSA.Tag = ""
        '
        'ogdLiquidacionDetalleSPSA
        '
        UltraDataColumn120.DataType = GetType(Boolean)
        Me.ogdLiquidacionDetalleSPSA.Band.Columns.AddRange(New Object() {UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158})
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.griViajesLiquidacionDetalleSPSA)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(1054, 366)
        '
        'griViajesLiquidacionDetalleSPSA
        '
        Me.griViajesLiquidacionDetalleSPSA.AllowDrop = True
        Me.griViajesLiquidacionDetalleSPSA.ContextMenuStrip = Me.MenuQuitar
        Me.griViajesLiquidacionDetalleSPSA.DataSource = Me.ogdLiquidacionDetalleSPSA
        UltraGridColumn766.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn766.Header.Caption = "Select"
        UltraGridColumn766.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn766.Header.VisiblePosition = 0
        UltraGridColumn766.Hidden = True
        UltraGridColumn766.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn766.Width = 40
        Appearance55.TextHAlignAsString = "Left"
        Appearance55.TextVAlignAsString = "Middle"
        UltraGridColumn767.CellAppearance = Appearance55
        UltraGridColumn767.Header.VisiblePosition = 2
        UltraGridColumn767.Hidden = True
        UltraGridColumn767.Width = 100
        UltraGridColumn768.Header.VisiblePosition = 3
        UltraGridColumn768.Hidden = True
        UltraGridColumn768.Width = 100
        UltraGridColumn769.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance56.TextHAlignAsString = "Left"
        Appearance56.TextVAlignAsString = "Middle"
        UltraGridColumn769.CellAppearance = Appearance56
        UltraGridColumn769.Header.VisiblePosition = 1
        UltraGridColumn769.Hidden = True
        UltraGridColumn769.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn769.Width = 100
        UltraGridColumn770.Header.VisiblePosition = 5
        UltraGridColumn770.Width = 100
        UltraGridColumn771.Header.VisiblePosition = 4
        UltraGridColumn771.Hidden = True
        UltraGridColumn772.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn772.Header.VisiblePosition = 6
        UltraGridColumn772.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn772.Width = 60
        UltraGridColumn773.Header.Caption = "Cent.Orig"
        UltraGridColumn773.Header.VisiblePosition = 7
        UltraGridColumn773.Hidden = True
        UltraGridColumn773.Width = 50
        UltraGridColumn774.Header.VisiblePosition = 9
        UltraGridColumn774.Width = 100
        UltraGridColumn775.Header.Caption = "Cent.Dest"
        UltraGridColumn775.Header.VisiblePosition = 10
        UltraGridColumn775.Hidden = True
        UltraGridColumn775.Width = 50
        UltraGridColumn776.Header.Caption = "Destino Final"
        UltraGridColumn776.Header.VisiblePosition = 11
        UltraGridColumn776.Width = 150
        UltraGridColumn777.Header.VisiblePosition = 15
        UltraGridColumn777.Width = 70
        UltraGridColumn778.Header.VisiblePosition = 16
        UltraGridColumn778.Width = 70
        Appearance57.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance57.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance57.TextHAlignAsString = "Right"
        UltraGridColumn779.CellAppearance = Appearance57
        UltraGridColumn779.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn779.Header.Caption = "Cap.Carga"
        UltraGridColumn779.Header.VisiblePosition = 14
        UltraGridColumn779.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn779.Width = 50
        Appearance58.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance58.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance58.TextHAlignAsString = "Right"
        UltraGridColumn780.CellAppearance = Appearance58
        UltraGridColumn780.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn780.Header.Caption = "FleteUnit."
        UltraGridColumn780.Header.VisiblePosition = 18
        UltraGridColumn780.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn780.Width = 60
        Appearance59.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance59.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance59.TextHAlignAsString = "Right"
        UltraGridColumn781.CellAppearance = Appearance59
        UltraGridColumn781.Header.VisiblePosition = 20
        UltraGridColumn781.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn781.Width = 70
        Appearance60.TextHAlignAsString = "Center"
        UltraGridColumn782.CellAppearance = Appearance60
        UltraGridColumn782.Header.Caption = "I y V"
        UltraGridColumn782.Header.VisiblePosition = 17
        UltraGridColumn782.Width = 40
        UltraGridColumn783.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn783.Header.VisiblePosition = 22
        UltraGridColumn783.Width = 200
        UltraGridColumn784.Header.VisiblePosition = 23
        UltraGridColumn784.Width = 200
        UltraGridColumn785.Header.VisiblePosition = 24
        UltraGridColumn785.Width = 200
        UltraGridColumn786.Header.VisiblePosition = 25
        UltraGridColumn786.Hidden = True
        UltraGridColumn787.Header.VisiblePosition = 26
        UltraGridColumn787.Hidden = True
        UltraGridColumn788.Header.VisiblePosition = 27
        UltraGridColumn788.Hidden = True
        UltraGridColumn789.Header.VisiblePosition = 28
        UltraGridColumn789.Hidden = True
        UltraGridColumn790.Header.Caption = "CargaMaterial"
        UltraGridColumn790.Header.VisiblePosition = 29
        UltraGridColumn790.Width = 100
        UltraGridColumn791.Header.VisiblePosition = 30
        UltraGridColumn791.Hidden = True
        UltraGridColumn792.Header.VisiblePosition = 21
        UltraGridColumn792.Width = 90
        UltraGridColumn793.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn793.Header.VisiblePosition = 12
        UltraGridColumn793.NullText = "."
        UltraGridColumn793.Width = 150
        UltraGridColumn794.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn794.Header.VisiblePosition = 13
        UltraGridColumn794.Width = 150
        Appearance61.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance61.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance61.TextHAlignAsString = "Right"
        UltraGridColumn795.CellAppearance = Appearance61
        UltraGridColumn795.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn795.Header.VisiblePosition = 19
        UltraGridColumn795.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn795.Width = 60
        UltraGridColumn796.Header.VisiblePosition = 31
        UltraGridColumn796.Hidden = True
        UltraGridColumn797.Header.VisiblePosition = 32
        UltraGridColumn797.Hidden = True
        UltraGridColumn798.Header.VisiblePosition = 33
        UltraGridColumn798.Hidden = True
        UltraGridColumn799.Header.VisiblePosition = 34
        UltraGridColumn799.Hidden = True
        UltraGridColumn800.Header.VisiblePosition = 35
        UltraGridColumn800.Hidden = True
        UltraGridColumn801.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn801.Header.Caption = "Centro Costo Origen"
        UltraGridColumn801.Header.VisiblePosition = 8
        UltraGridColumn802.Header.VisiblePosition = 36
        UltraGridColumn802.Hidden = True
        UltraGridColumn803.Header.VisiblePosition = 37
        UltraGridColumn803.Hidden = True
        UltraGridColumn804.Header.VisiblePosition = 38
        UltraGridColumn804.Hidden = True
        UltraGridBand16.Columns.AddRange(New Object() {UltraGridColumn766, UltraGridColumn767, UltraGridColumn768, UltraGridColumn769, UltraGridColumn770, UltraGridColumn771, UltraGridColumn772, UltraGridColumn773, UltraGridColumn774, UltraGridColumn775, UltraGridColumn776, UltraGridColumn777, UltraGridColumn778, UltraGridColumn779, UltraGridColumn780, UltraGridColumn781, UltraGridColumn782, UltraGridColumn783, UltraGridColumn784, UltraGridColumn785, UltraGridColumn786, UltraGridColumn787, UltraGridColumn788, UltraGridColumn789, UltraGridColumn790, UltraGridColumn791, UltraGridColumn792, UltraGridColumn793, UltraGridColumn794, UltraGridColumn795, UltraGridColumn796, UltraGridColumn797, UltraGridColumn798, UltraGridColumn799, UltraGridColumn800, UltraGridColumn801, UltraGridColumn802, UltraGridColumn803, UltraGridColumn804})
        UltraGridBand16.SummaryFooterCaption = "Totales:"
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.BandsSerializer.Add(UltraGridBand16)
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajesLiquidacionDetalleSPSA.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesLiquidacionDetalleSPSA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesLiquidacionDetalleSPSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesLiquidacionDetalleSPSA.Location = New System.Drawing.Point(0, 0)
        Me.griViajesLiquidacionDetalleSPSA.Name = "griViajesLiquidacionDetalleSPSA"
        Me.griViajesLiquidacionDetalleSPSA.Size = New System.Drawing.Size(1054, 366)
        Me.griViajesLiquidacionDetalleSPSA.TabIndex = 5
        Me.griViajesLiquidacionDetalleSPSA.Tag = ""
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.griViajesSinLiquidarTOTTUS)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(1054, 366)
        '
        'griViajesSinLiquidarTOTTUS
        '
        Me.griViajesSinLiquidarTOTTUS.AllowDrop = True
        Me.griViajesSinLiquidarTOTTUS.ContextMenuStrip = Me.MenuAgregar
        Me.griViajesSinLiquidarTOTTUS.DataSource = Me.ogdLiquidacionDetalleTOTTUS
        UltraGridColumn805.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn805.Header.Caption = "Select"
        UltraGridColumn805.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn805.Header.VisiblePosition = 0
        UltraGridColumn805.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn805.Width = 40
        Appearance62.TextHAlignAsString = "Left"
        Appearance62.TextVAlignAsString = "Middle"
        UltraGridColumn806.CellAppearance = Appearance62
        UltraGridColumn806.Header.VisiblePosition = 2
        UltraGridColumn806.Hidden = True
        UltraGridColumn806.Width = 100
        UltraGridColumn807.Header.VisiblePosition = 3
        UltraGridColumn807.Hidden = True
        UltraGridColumn807.Width = 100
        UltraGridColumn808.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance63.TextHAlignAsString = "Left"
        Appearance63.TextVAlignAsString = "Middle"
        UltraGridColumn808.CellAppearance = Appearance63
        UltraGridColumn808.Header.VisiblePosition = 1
        UltraGridColumn808.Hidden = True
        UltraGridColumn808.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn808.Width = 100
        UltraGridColumn809.Header.VisiblePosition = 5
        UltraGridColumn809.Width = 100
        UltraGridColumn810.Header.VisiblePosition = 4
        UltraGridColumn810.Hidden = True
        UltraGridColumn811.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn811.Header.Caption = "F. de Salida"
        UltraGridColumn811.Header.VisiblePosition = 15
        UltraGridColumn811.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn811.Width = 70
        UltraGridColumn812.Header.Caption = "Carga Material"
        UltraGridColumn812.Header.VisiblePosition = 29
        UltraGridColumn812.Width = 150
        UltraGridColumn813.Header.VisiblePosition = 18
        UltraGridColumn813.Width = 100
        UltraGridColumn814.Header.Caption = "Cent.Dest"
        UltraGridColumn814.Header.VisiblePosition = 20
        UltraGridColumn814.Hidden = True
        UltraGridColumn814.Width = 50
        UltraGridColumn815.Header.Caption = "Punto de Destino"
        UltraGridColumn815.Header.VisiblePosition = 21
        UltraGridColumn815.Width = 100
        UltraGridColumn816.Header.VisiblePosition = 7
        UltraGridColumn816.Width = 70
        UltraGridColumn817.Header.Caption = "Placa Furgon"
        UltraGridColumn817.Header.VisiblePosition = 8
        UltraGridColumn817.Width = 70
        Appearance64.TextHAlignAsString = "Right"
        UltraGridColumn818.CellAppearance = Appearance64
        UltraGridColumn818.Header.Caption = "Cap.Carga"
        UltraGridColumn818.Header.VisiblePosition = 22
        UltraGridColumn818.Hidden = True
        UltraGridColumn818.Width = 40
        Appearance65.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance65.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance65.TextHAlignAsString = "Right"
        UltraGridColumn819.CellAppearance = Appearance65
        UltraGridColumn819.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn819.Header.Caption = "FleteUnit."
        UltraGridColumn819.Header.VisiblePosition = 24
        UltraGridColumn819.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn819.Width = 60
        Appearance66.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance66.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance66.TextHAlignAsString = "Right"
        UltraGridColumn820.CellAppearance = Appearance66
        UltraGridColumn820.Header.VisiblePosition = 25
        UltraGridColumn820.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn820.Width = 70
        UltraGridColumn821.Header.Caption = "C. de C. / Operacion"
        UltraGridColumn821.Header.VisiblePosition = 9
        UltraGridColumn821.Width = 100
        UltraGridColumn822.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn822.Header.Caption = "N° de Viaje/ N° Folio"
        UltraGridColumn822.Header.VisiblePosition = 6
        UltraGridColumn822.Width = 150
        UltraGridColumn823.Header.VisiblePosition = 27
        UltraGridColumn823.Width = 150
        UltraGridColumn824.Header.Caption = "N° de GRT"
        UltraGridColumn824.Header.VisiblePosition = 23
        UltraGridColumn824.Width = 150
        UltraGridColumn825.Header.VisiblePosition = 30
        UltraGridColumn825.Hidden = True
        UltraGridColumn826.Header.VisiblePosition = 31
        UltraGridColumn826.Hidden = True
        UltraGridColumn827.Header.VisiblePosition = 32
        UltraGridColumn827.Hidden = True
        UltraGridColumn828.Header.VisiblePosition = 33
        UltraGridColumn828.Hidden = True
        UltraGridColumn829.Header.VisiblePosition = 26
        UltraGridColumn829.Width = 100
        UltraGridColumn830.Header.VisiblePosition = 34
        UltraGridColumn830.Hidden = True
        UltraGridColumn831.Header.VisiblePosition = 28
        UltraGridColumn831.Width = 100
        UltraGridColumn832.Header.VisiblePosition = 35
        UltraGridColumn832.Hidden = True
        UltraGridColumn833.Header.Caption = "Clase de Servicio"
        UltraGridColumn833.Header.VisiblePosition = 13
        UltraGridColumn833.Width = 120
        UltraGridColumn834.Header.Caption = "SubClase de Servicio"
        UltraGridColumn834.Header.VisiblePosition = 14
        UltraGridColumn834.Width = 100
        UltraGridColumn835.Header.VisiblePosition = 36
        UltraGridColumn835.Hidden = True
        UltraGridColumn836.Header.VisiblePosition = 37
        UltraGridColumn836.Hidden = True
        UltraGridColumn837.Header.Caption = "F. de Llegada"
        UltraGridColumn837.Header.VisiblePosition = 16
        UltraGridColumn837.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn837.Width = 70
        UltraGridColumn838.Header.Caption = "Hora de Salida"
        UltraGridColumn838.Header.VisiblePosition = 17
        UltraGridColumn838.MaskInput = "{LOC}hh:mm:ss tt"
        UltraGridColumn838.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn838.Width = 70
        UltraGridColumn839.Header.Caption = "Punto de Origen"
        UltraGridColumn839.Header.VisiblePosition = 19
        UltraGridColumn839.Width = 100
        Appearance67.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance67.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance67.TextHAlignAsString = "Right"
        UltraGridColumn840.CellAppearance = Appearance67
        UltraGridColumn840.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn840.Header.Caption = "Cc.1"
        UltraGridColumn840.Header.VisiblePosition = 10
        UltraGridColumn840.Width = 40
        Appearance68.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance68.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance68.TextHAlignAsString = "Right"
        UltraGridColumn841.CellAppearance = Appearance68
        UltraGridColumn841.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn841.Header.Caption = "Cc.2"
        UltraGridColumn841.Header.VisiblePosition = 11
        UltraGridColumn841.Width = 40
        Appearance69.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance69.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance69.TextHAlignAsString = "Right"
        UltraGridColumn842.CellAppearance = Appearance69
        UltraGridColumn842.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn842.Header.Caption = "Cc.3"
        UltraGridColumn842.Header.VisiblePosition = 12
        UltraGridColumn842.Width = 40
        UltraGridColumn843.Header.VisiblePosition = 38
        UltraGridColumn843.Hidden = True
        UltraGridBand17.Columns.AddRange(New Object() {UltraGridColumn805, UltraGridColumn806, UltraGridColumn807, UltraGridColumn808, UltraGridColumn809, UltraGridColumn810, UltraGridColumn811, UltraGridColumn812, UltraGridColumn813, UltraGridColumn814, UltraGridColumn815, UltraGridColumn816, UltraGridColumn817, UltraGridColumn818, UltraGridColumn819, UltraGridColumn820, UltraGridColumn821, UltraGridColumn822, UltraGridColumn823, UltraGridColumn824, UltraGridColumn825, UltraGridColumn826, UltraGridColumn827, UltraGridColumn828, UltraGridColumn829, UltraGridColumn830, UltraGridColumn831, UltraGridColumn832, UltraGridColumn833, UltraGridColumn834, UltraGridColumn835, UltraGridColumn836, UltraGridColumn837, UltraGridColumn838, UltraGridColumn839, UltraGridColumn840, UltraGridColumn841, UltraGridColumn842, UltraGridColumn843})
        UltraGridBand17.SummaryFooterCaption = "Totales:"
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.BandsSerializer.Add(UltraGridBand17)
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajesSinLiquidarTOTTUS.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesSinLiquidarTOTTUS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesSinLiquidarTOTTUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesSinLiquidarTOTTUS.Location = New System.Drawing.Point(0, 0)
        Me.griViajesSinLiquidarTOTTUS.Name = "griViajesSinLiquidarTOTTUS"
        Me.griViajesSinLiquidarTOTTUS.Size = New System.Drawing.Size(1054, 366)
        Me.griViajesSinLiquidarTOTTUS.TabIndex = 4
        Me.griViajesSinLiquidarTOTTUS.Tag = ""
        '
        'ogdLiquidacionDetalleTOTTUS
        '
        UltraDataColumn159.DataType = GetType(Boolean)
        Me.ogdLiquidacionDetalleTOTTUS.Band.Columns.AddRange(New Object() {UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185, UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192, UltraDataColumn193, UltraDataColumn194, UltraDataColumn195, UltraDataColumn196, UltraDataColumn197})
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.griViajesLiquidacionDetalleTOTTUS)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(1054, 366)
        '
        'griViajesLiquidacionDetalleTOTTUS
        '
        Me.griViajesLiquidacionDetalleTOTTUS.AllowDrop = True
        Me.griViajesLiquidacionDetalleTOTTUS.ContextMenuStrip = Me.MenuQuitar
        Me.griViajesLiquidacionDetalleTOTTUS.DataSource = Me.ogdLiquidacionDetalleTOTTUS
        UltraGridColumn844.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn844.Header.Caption = "Select"
        UltraGridColumn844.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn844.Header.VisiblePosition = 0
        UltraGridColumn844.Hidden = True
        UltraGridColumn844.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn844.Width = 40
        Appearance70.TextHAlignAsString = "Left"
        Appearance70.TextVAlignAsString = "Middle"
        UltraGridColumn845.CellAppearance = Appearance70
        UltraGridColumn845.Header.VisiblePosition = 2
        UltraGridColumn845.Hidden = True
        UltraGridColumn845.Width = 100
        UltraGridColumn846.Header.VisiblePosition = 3
        UltraGridColumn846.Hidden = True
        UltraGridColumn846.Width = 100
        UltraGridColumn847.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance71.TextHAlignAsString = "Left"
        Appearance71.TextVAlignAsString = "Middle"
        UltraGridColumn847.CellAppearance = Appearance71
        UltraGridColumn847.Header.VisiblePosition = 1
        UltraGridColumn847.Hidden = True
        UltraGridColumn847.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn847.Width = 100
        UltraGridColumn848.Header.VisiblePosition = 5
        UltraGridColumn848.Width = 100
        UltraGridColumn849.Header.VisiblePosition = 4
        UltraGridColumn849.Hidden = True
        UltraGridColumn850.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn850.Header.Caption = "F. de Salida"
        UltraGridColumn850.Header.VisiblePosition = 15
        UltraGridColumn850.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn850.Width = 70
        UltraGridColumn851.Header.Caption = "Carga Material"
        UltraGridColumn851.Header.VisiblePosition = 29
        UltraGridColumn851.Width = 150
        UltraGridColumn852.Header.VisiblePosition = 18
        UltraGridColumn852.Width = 100
        UltraGridColumn853.Header.Caption = "Cent.Dest"
        UltraGridColumn853.Header.VisiblePosition = 19
        UltraGridColumn853.Hidden = True
        UltraGridColumn853.Width = 50
        UltraGridColumn854.Header.Caption = "Punto de Destino"
        UltraGridColumn854.Header.VisiblePosition = 21
        UltraGridColumn854.Width = 100
        UltraGridColumn855.Header.VisiblePosition = 7
        UltraGridColumn855.Width = 70
        UltraGridColumn856.Header.Caption = "Placa Furgon"
        UltraGridColumn856.Header.VisiblePosition = 8
        UltraGridColumn856.Width = 70
        Appearance72.TextHAlignAsString = "Right"
        UltraGridColumn857.CellAppearance = Appearance72
        UltraGridColumn857.Header.Caption = "Cap.Carga"
        UltraGridColumn857.Header.VisiblePosition = 22
        UltraGridColumn857.Hidden = True
        UltraGridColumn857.Width = 40
        Appearance73.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance73.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance73.TextHAlignAsString = "Right"
        UltraGridColumn858.CellAppearance = Appearance73
        UltraGridColumn858.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn858.Header.Caption = "FleteUnit."
        UltraGridColumn858.Header.VisiblePosition = 24
        UltraGridColumn858.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn858.Width = 60
        Appearance74.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance74.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance74.TextHAlignAsString = "Right"
        UltraGridColumn859.CellAppearance = Appearance74
        UltraGridColumn859.Header.VisiblePosition = 25
        UltraGridColumn859.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn859.Width = 70
        UltraGridColumn860.Header.Caption = "C. de C. / Operacion"
        UltraGridColumn860.Header.VisiblePosition = 9
        UltraGridColumn860.Width = 100
        UltraGridColumn861.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn861.Header.Caption = "N° de Viaje/ N° Folio"
        UltraGridColumn861.Header.VisiblePosition = 6
        UltraGridColumn861.Width = 150
        UltraGridColumn862.Header.VisiblePosition = 27
        UltraGridColumn862.Width = 150
        UltraGridColumn863.Header.Caption = "N° de GRT"
        UltraGridColumn863.Header.VisiblePosition = 23
        UltraGridColumn863.Width = 150
        UltraGridColumn864.Header.VisiblePosition = 30
        UltraGridColumn864.Hidden = True
        UltraGridColumn865.Header.VisiblePosition = 31
        UltraGridColumn865.Hidden = True
        UltraGridColumn866.Header.VisiblePosition = 32
        UltraGridColumn866.Hidden = True
        UltraGridColumn867.Header.VisiblePosition = 33
        UltraGridColumn867.Hidden = True
        UltraGridColumn868.Header.VisiblePosition = 26
        UltraGridColumn868.Width = 100
        UltraGridColumn869.Header.VisiblePosition = 34
        UltraGridColumn869.Hidden = True
        UltraGridColumn870.Header.VisiblePosition = 28
        UltraGridColumn870.Width = 100
        UltraGridColumn871.Header.VisiblePosition = 35
        UltraGridColumn871.Hidden = True
        UltraGridColumn872.Header.Caption = "Clase de Servicio"
        UltraGridColumn872.Header.VisiblePosition = 13
        UltraGridColumn872.Width = 120
        UltraGridColumn873.Header.Caption = "SubClase de Servicio"
        UltraGridColumn873.Header.VisiblePosition = 14
        UltraGridColumn873.Width = 100
        UltraGridColumn874.Header.VisiblePosition = 36
        UltraGridColumn874.Hidden = True
        UltraGridColumn875.Header.VisiblePosition = 37
        UltraGridColumn875.Hidden = True
        UltraGridColumn876.Header.Caption = "F. de Llegada"
        UltraGridColumn876.Header.VisiblePosition = 16
        UltraGridColumn876.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn876.Width = 70
        UltraGridColumn877.Header.Caption = "Hora de Salida"
        UltraGridColumn877.Header.VisiblePosition = 17
        UltraGridColumn877.MaskInput = "{LOC}hh:mm:ss tt"
        UltraGridColumn877.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn877.Width = 70
        UltraGridColumn878.Header.Caption = "Punto de Origen"
        UltraGridColumn878.Header.VisiblePosition = 20
        UltraGridColumn878.Width = 100
        Appearance75.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance75.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance75.TextHAlignAsString = "Right"
        UltraGridColumn879.CellAppearance = Appearance75
        UltraGridColumn879.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn879.Header.Caption = "Cc.1"
        UltraGridColumn879.Header.VisiblePosition = 10
        UltraGridColumn879.Width = 40
        Appearance76.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance76.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance76.TextHAlignAsString = "Right"
        UltraGridColumn880.CellAppearance = Appearance76
        UltraGridColumn880.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn880.Header.Caption = "Cc.2"
        UltraGridColumn880.Header.VisiblePosition = 11
        UltraGridColumn880.Width = 40
        Appearance77.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance77.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance77.TextHAlignAsString = "Right"
        UltraGridColumn881.CellAppearance = Appearance77
        UltraGridColumn881.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn881.Header.Caption = "Cc.3"
        UltraGridColumn881.Header.VisiblePosition = 12
        UltraGridColumn881.Width = 40
        UltraGridColumn882.Header.VisiblePosition = 38
        UltraGridColumn882.Hidden = True
        UltraGridBand18.Columns.AddRange(New Object() {UltraGridColumn844, UltraGridColumn845, UltraGridColumn846, UltraGridColumn847, UltraGridColumn848, UltraGridColumn849, UltraGridColumn850, UltraGridColumn851, UltraGridColumn852, UltraGridColumn853, UltraGridColumn854, UltraGridColumn855, UltraGridColumn856, UltraGridColumn857, UltraGridColumn858, UltraGridColumn859, UltraGridColumn860, UltraGridColumn861, UltraGridColumn862, UltraGridColumn863, UltraGridColumn864, UltraGridColumn865, UltraGridColumn866, UltraGridColumn867, UltraGridColumn868, UltraGridColumn869, UltraGridColumn870, UltraGridColumn871, UltraGridColumn872, UltraGridColumn873, UltraGridColumn874, UltraGridColumn875, UltraGridColumn876, UltraGridColumn877, UltraGridColumn878, UltraGridColumn879, UltraGridColumn880, UltraGridColumn881, UltraGridColumn882})
        UltraGridBand18.SummaryFooterCaption = "Totales:"
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.BandsSerializer.Add(UltraGridBand18)
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajesLiquidacionDetalleTOTTUS.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesLiquidacionDetalleTOTTUS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesLiquidacionDetalleTOTTUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesLiquidacionDetalleTOTTUS.Location = New System.Drawing.Point(0, 0)
        Me.griViajesLiquidacionDetalleTOTTUS.Name = "griViajesLiquidacionDetalleTOTTUS"
        Me.griViajesLiquidacionDetalleTOTTUS.Size = New System.Drawing.Size(1054, 366)
        Me.griViajesLiquidacionDetalleTOTTUS.TabIndex = 5
        Me.griViajesLiquidacionDetalleTOTTUS.Tag = ""
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.griViajesSinLiquidarMAESTRO)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(1054, 366)
        '
        'griViajesSinLiquidarMAESTRO
        '
        Me.griViajesSinLiquidarMAESTRO.AllowDrop = True
        Me.griViajesSinLiquidarMAESTRO.ContextMenuStrip = Me.MenuAgregar
        Me.griViajesSinLiquidarMAESTRO.DataSource = Me.ogdLiquidacionDetalleMAESTRO
        UltraGridColumn883.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn883.Header.Caption = "Select"
        UltraGridColumn883.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn883.Header.VisiblePosition = 0
        UltraGridColumn883.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn883.Width = 40
        Appearance78.TextHAlignAsString = "Left"
        Appearance78.TextVAlignAsString = "Middle"
        UltraGridColumn884.CellAppearance = Appearance78
        UltraGridColumn884.Header.VisiblePosition = 2
        UltraGridColumn884.Hidden = True
        UltraGridColumn884.Width = 100
        UltraGridColumn885.Header.VisiblePosition = 3
        UltraGridColumn885.Hidden = True
        UltraGridColumn885.Width = 100
        UltraGridColumn886.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance79.TextHAlignAsString = "Left"
        Appearance79.TextVAlignAsString = "Middle"
        UltraGridColumn886.CellAppearance = Appearance79
        UltraGridColumn886.Header.VisiblePosition = 1
        UltraGridColumn886.Hidden = True
        UltraGridColumn886.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn886.Width = 100
        UltraGridColumn887.Header.VisiblePosition = 5
        UltraGridColumn887.Width = 100
        UltraGridColumn888.Header.VisiblePosition = 4
        UltraGridColumn888.Hidden = True
        UltraGridColumn889.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn889.Header.VisiblePosition = 6
        UltraGridColumn889.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn889.Width = 60
        UltraGridColumn890.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn890.Header.Caption = "Cent.Orig"
        UltraGridColumn890.Header.VisiblePosition = 10
        UltraGridColumn890.Hidden = True
        UltraGridColumn890.Width = 50
        UltraGridColumn891.Header.VisiblePosition = 12
        UltraGridColumn891.Width = 100
        UltraGridColumn892.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn892.Header.Caption = "Cent.Dest"
        UltraGridColumn892.Header.VisiblePosition = 13
        UltraGridColumn892.Width = 50
        UltraGridColumn893.Header.VisiblePosition = 14
        UltraGridColumn893.Width = 100
        UltraGridColumn894.Header.VisiblePosition = 7
        UltraGridColumn894.Width = 70
        UltraGridColumn895.Header.VisiblePosition = 8
        UltraGridColumn895.Width = 70
        Appearance80.TextHAlignAsString = "Right"
        UltraGridColumn896.CellAppearance = Appearance80
        UltraGridColumn896.Header.Caption = "Cap.Carga"
        UltraGridColumn896.Header.VisiblePosition = 15
        UltraGridColumn896.Hidden = True
        UltraGridColumn896.Width = 40
        Appearance81.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance81.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance81.TextHAlignAsString = "Right"
        UltraGridColumn897.CellAppearance = Appearance81
        UltraGridColumn897.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn897.Header.Caption = "FleteUnit."
        UltraGridColumn897.Header.VisiblePosition = 35
        UltraGridColumn897.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn897.Width = 50
        Appearance82.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance82.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance82.TextHAlignAsString = "Right"
        UltraGridColumn898.CellAppearance = Appearance82
        UltraGridColumn898.Header.VisiblePosition = 36
        UltraGridColumn898.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn898.Width = 60
        UltraGridColumn899.Header.VisiblePosition = 16
        UltraGridColumn899.Hidden = True
        UltraGridColumn899.Width = 40
        UltraGridColumn900.Header.VisiblePosition = 17
        UltraGridColumn900.Hidden = True
        UltraGridColumn900.Width = 100
        UltraGridColumn901.Header.VisiblePosition = 18
        UltraGridColumn901.Width = 100
        UltraGridColumn902.Header.VisiblePosition = 19
        UltraGridColumn902.Width = 100
        UltraGridColumn903.Header.VisiblePosition = 20
        UltraGridColumn903.Hidden = True
        UltraGridColumn904.Header.VisiblePosition = 21
        UltraGridColumn904.Hidden = True
        UltraGridColumn905.Header.VisiblePosition = 22
        UltraGridColumn905.Hidden = True
        UltraGridColumn906.Header.VisiblePosition = 23
        UltraGridColumn906.Hidden = True
        UltraGridColumn907.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn907.Header.VisiblePosition = 37
        UltraGridColumn907.Width = 100
        UltraGridColumn908.Header.VisiblePosition = 24
        UltraGridColumn908.Hidden = True
        UltraGridColumn909.Header.VisiblePosition = 9
        UltraGridColumn910.Header.VisiblePosition = 25
        UltraGridColumn910.Hidden = True
        UltraGridColumn911.Header.VisiblePosition = 26
        UltraGridColumn911.Hidden = True
        UltraGridColumn912.Header.VisiblePosition = 27
        UltraGridColumn912.Hidden = True
        Appearance83.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance83.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance83.TextHAlignAsString = "Right"
        UltraGridColumn913.CellAppearance = Appearance83
        UltraGridColumn913.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn913.Header.Caption = "Peso(KG)"
        UltraGridColumn913.Header.VisiblePosition = 34
        UltraGridColumn913.MaskInput = "{double:5.3}"
        UltraGridColumn913.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn913.Width = 50
        UltraGridColumn914.Header.VisiblePosition = 28
        UltraGridColumn914.Hidden = True
        UltraGridColumn915.Header.VisiblePosition = 29
        UltraGridColumn915.Hidden = True
        UltraGridColumn916.Header.VisiblePosition = 30
        UltraGridColumn916.Hidden = True
        UltraGridColumn917.Header.Caption = "Carga Material"
        UltraGridColumn917.Header.VisiblePosition = 38
        UltraGridColumn918.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn918.Header.Caption = "F. Factura"
        UltraGridColumn918.Header.VisiblePosition = 31
        UltraGridColumn918.Width = 50
        UltraGridColumn919.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn919.Header.Caption = "Factura N°"
        UltraGridColumn919.Header.VisiblePosition = 32
        UltraGridColumn919.Width = 100
        UltraGridColumn920.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn920.Header.Caption = "C. C. Origen"
        UltraGridColumn920.Header.VisiblePosition = 11
        UltraGridColumn920.Width = 50
        Appearance84.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance84.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance84.TextHAlignAsString = "Right"
        UltraGridColumn921.CellAppearance = Appearance84
        UltraGridColumn921.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn921.Header.Caption = "Volm(m3)"
        UltraGridColumn921.Header.VisiblePosition = 33
        UltraGridColumn921.MaskInput = "{double:2.4}"
        UltraGridColumn921.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn921.Width = 50
        UltraGridBand19.Columns.AddRange(New Object() {UltraGridColumn883, UltraGridColumn884, UltraGridColumn885, UltraGridColumn886, UltraGridColumn887, UltraGridColumn888, UltraGridColumn889, UltraGridColumn890, UltraGridColumn891, UltraGridColumn892, UltraGridColumn893, UltraGridColumn894, UltraGridColumn895, UltraGridColumn896, UltraGridColumn897, UltraGridColumn898, UltraGridColumn899, UltraGridColumn900, UltraGridColumn901, UltraGridColumn902, UltraGridColumn903, UltraGridColumn904, UltraGridColumn905, UltraGridColumn906, UltraGridColumn907, UltraGridColumn908, UltraGridColumn909, UltraGridColumn910, UltraGridColumn911, UltraGridColumn912, UltraGridColumn913, UltraGridColumn914, UltraGridColumn915, UltraGridColumn916, UltraGridColumn917, UltraGridColumn918, UltraGridColumn919, UltraGridColumn920, UltraGridColumn921})
        UltraGridBand19.SummaryFooterCaption = "Totales:"
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.BandsSerializer.Add(UltraGridBand19)
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajesSinLiquidarMAESTRO.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesSinLiquidarMAESTRO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesSinLiquidarMAESTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesSinLiquidarMAESTRO.Location = New System.Drawing.Point(0, 0)
        Me.griViajesSinLiquidarMAESTRO.Name = "griViajesSinLiquidarMAESTRO"
        Me.griViajesSinLiquidarMAESTRO.Size = New System.Drawing.Size(1054, 366)
        Me.griViajesSinLiquidarMAESTRO.TabIndex = 4
        Me.griViajesSinLiquidarMAESTRO.Tag = ""
        '
        'ogdLiquidacionDetalleMAESTRO
        '
        UltraDataColumn198.DataType = GetType(Boolean)
        Me.ogdLiquidacionDetalleMAESTRO.Band.Columns.AddRange(New Object() {UltraDataColumn198, UltraDataColumn199, UltraDataColumn200, UltraDataColumn201, UltraDataColumn202, UltraDataColumn203, UltraDataColumn204, UltraDataColumn205, UltraDataColumn206, UltraDataColumn207, UltraDataColumn208, UltraDataColumn209, UltraDataColumn210, UltraDataColumn211, UltraDataColumn212, UltraDataColumn213, UltraDataColumn214, UltraDataColumn215, UltraDataColumn216, UltraDataColumn217, UltraDataColumn218, UltraDataColumn219, UltraDataColumn220, UltraDataColumn221, UltraDataColumn222, UltraDataColumn223, UltraDataColumn224, UltraDataColumn225, UltraDataColumn226, UltraDataColumn227, UltraDataColumn228, UltraDataColumn229, UltraDataColumn230, UltraDataColumn231, UltraDataColumn232, UltraDataColumn233, UltraDataColumn234, UltraDataColumn235, UltraDataColumn236})
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.griViajesLiquidacionDetalleMAESTRO)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(1054, 366)
        '
        'griViajesLiquidacionDetalleMAESTRO
        '
        Me.griViajesLiquidacionDetalleMAESTRO.AllowDrop = True
        Me.griViajesLiquidacionDetalleMAESTRO.ContextMenuStrip = Me.MenuQuitar
        Me.griViajesLiquidacionDetalleMAESTRO.DataSource = Me.ogdLiquidacionDetalleMAESTRO
        UltraGridColumn922.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn922.Header.Caption = "Select"
        UltraGridColumn922.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn922.Header.VisiblePosition = 0
        UltraGridColumn922.Hidden = True
        UltraGridColumn922.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn922.Width = 40
        Appearance85.TextHAlignAsString = "Left"
        Appearance85.TextVAlignAsString = "Middle"
        UltraGridColumn923.CellAppearance = Appearance85
        UltraGridColumn923.Header.VisiblePosition = 2
        UltraGridColumn923.Hidden = True
        UltraGridColumn923.Width = 100
        UltraGridColumn924.Header.VisiblePosition = 3
        UltraGridColumn924.Hidden = True
        UltraGridColumn924.Width = 100
        UltraGridColumn925.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance86.TextHAlignAsString = "Left"
        Appearance86.TextVAlignAsString = "Middle"
        UltraGridColumn925.CellAppearance = Appearance86
        UltraGridColumn925.Header.VisiblePosition = 1
        UltraGridColumn925.Hidden = True
        UltraGridColumn925.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn925.Width = 100
        UltraGridColumn926.Header.VisiblePosition = 5
        UltraGridColumn926.Width = 100
        UltraGridColumn927.Header.VisiblePosition = 4
        UltraGridColumn927.Hidden = True
        UltraGridColumn928.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn928.Header.VisiblePosition = 6
        UltraGridColumn928.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn928.Width = 60
        UltraGridColumn929.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn929.Header.Caption = "Cent.Orig"
        UltraGridColumn929.Header.VisiblePosition = 10
        UltraGridColumn929.Hidden = True
        UltraGridColumn929.Width = 50
        UltraGridColumn930.Header.VisiblePosition = 12
        UltraGridColumn930.Width = 100
        UltraGridColumn931.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn931.Header.Caption = "Cent.Dest"
        UltraGridColumn931.Header.VisiblePosition = 13
        UltraGridColumn931.Width = 50
        UltraGridColumn932.Header.VisiblePosition = 14
        UltraGridColumn932.Width = 100
        UltraGridColumn933.Header.VisiblePosition = 7
        UltraGridColumn933.Width = 70
        UltraGridColumn934.Header.VisiblePosition = 8
        UltraGridColumn934.Width = 70
        Appearance87.TextHAlignAsString = "Right"
        UltraGridColumn935.CellAppearance = Appearance87
        UltraGridColumn935.Header.Caption = "Cap.Carga"
        UltraGridColumn935.Header.VisiblePosition = 15
        UltraGridColumn935.Hidden = True
        UltraGridColumn935.Width = 40
        Appearance88.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance88.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance88.TextHAlignAsString = "Right"
        UltraGridColumn936.CellAppearance = Appearance88
        UltraGridColumn936.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn936.Header.Caption = "FleteUnit."
        UltraGridColumn936.Header.VisiblePosition = 35
        UltraGridColumn936.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn936.Width = 50
        Appearance89.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance89.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance89.TextHAlignAsString = "Right"
        UltraGridColumn937.CellAppearance = Appearance89
        UltraGridColumn937.Header.VisiblePosition = 36
        UltraGridColumn937.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn937.Width = 60
        UltraGridColumn938.Header.VisiblePosition = 16
        UltraGridColumn938.Hidden = True
        UltraGridColumn938.Width = 40
        UltraGridColumn939.Header.VisiblePosition = 17
        UltraGridColumn939.Hidden = True
        UltraGridColumn939.Width = 100
        UltraGridColumn940.Header.VisiblePosition = 18
        UltraGridColumn940.Width = 100
        UltraGridColumn941.Header.VisiblePosition = 19
        UltraGridColumn941.Width = 100
        UltraGridColumn942.Header.VisiblePosition = 20
        UltraGridColumn942.Hidden = True
        UltraGridColumn943.Header.VisiblePosition = 21
        UltraGridColumn943.Hidden = True
        UltraGridColumn944.Header.VisiblePosition = 22
        UltraGridColumn944.Hidden = True
        UltraGridColumn945.Header.VisiblePosition = 23
        UltraGridColumn945.Hidden = True
        UltraGridColumn946.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn946.Header.VisiblePosition = 37
        UltraGridColumn946.Width = 100
        UltraGridColumn947.Header.VisiblePosition = 24
        UltraGridColumn947.Hidden = True
        UltraGridColumn948.Header.VisiblePosition = 9
        UltraGridColumn949.Header.VisiblePosition = 25
        UltraGridColumn949.Hidden = True
        UltraGridColumn950.Header.VisiblePosition = 26
        UltraGridColumn950.Hidden = True
        UltraGridColumn951.Header.VisiblePosition = 27
        UltraGridColumn951.Hidden = True
        Appearance90.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance90.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance90.TextHAlignAsString = "Right"
        UltraGridColumn952.CellAppearance = Appearance90
        UltraGridColumn952.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn952.Header.Caption = "Peso(KG)"
        UltraGridColumn952.Header.VisiblePosition = 34
        UltraGridColumn952.MaskInput = "{double:5.3}"
        UltraGridColumn952.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn952.Width = 50
        UltraGridColumn953.Header.VisiblePosition = 28
        UltraGridColumn953.Hidden = True
        UltraGridColumn954.Header.VisiblePosition = 29
        UltraGridColumn954.Hidden = True
        UltraGridColumn955.Header.VisiblePosition = 30
        UltraGridColumn955.Hidden = True
        UltraGridColumn956.Header.Caption = "Carga Material"
        UltraGridColumn956.Header.VisiblePosition = 38
        UltraGridColumn957.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn957.Header.Caption = "F. Factura"
        UltraGridColumn957.Header.VisiblePosition = 31
        UltraGridColumn957.Width = 50
        UltraGridColumn958.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn958.Header.Caption = "Factura N°"
        UltraGridColumn958.Header.VisiblePosition = 32
        UltraGridColumn958.Width = 100
        UltraGridColumn959.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn959.Header.Caption = "C. C. Origen"
        UltraGridColumn959.Header.VisiblePosition = 11
        UltraGridColumn959.Width = 50
        Appearance91.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance91.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance91.TextHAlignAsString = "Right"
        UltraGridColumn960.CellAppearance = Appearance91
        UltraGridColumn960.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn960.Header.Caption = "Volm(m3)"
        UltraGridColumn960.Header.VisiblePosition = 33
        UltraGridColumn960.MaskInput = "{double:2.4}"
        UltraGridColumn960.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn960.Width = 50
        UltraGridBand20.Columns.AddRange(New Object() {UltraGridColumn922, UltraGridColumn923, UltraGridColumn924, UltraGridColumn925, UltraGridColumn926, UltraGridColumn927, UltraGridColumn928, UltraGridColumn929, UltraGridColumn930, UltraGridColumn931, UltraGridColumn932, UltraGridColumn933, UltraGridColumn934, UltraGridColumn935, UltraGridColumn936, UltraGridColumn937, UltraGridColumn938, UltraGridColumn939, UltraGridColumn940, UltraGridColumn941, UltraGridColumn942, UltraGridColumn943, UltraGridColumn944, UltraGridColumn945, UltraGridColumn946, UltraGridColumn947, UltraGridColumn948, UltraGridColumn949, UltraGridColumn950, UltraGridColumn951, UltraGridColumn952, UltraGridColumn953, UltraGridColumn954, UltraGridColumn955, UltraGridColumn956, UltraGridColumn957, UltraGridColumn958, UltraGridColumn959, UltraGridColumn960})
        UltraGridBand20.SummaryFooterCaption = "Totales:"
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.BandsSerializer.Add(UltraGridBand20)
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajesLiquidacionDetalleMAESTRO.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesLiquidacionDetalleMAESTRO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesLiquidacionDetalleMAESTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesLiquidacionDetalleMAESTRO.Location = New System.Drawing.Point(0, 0)
        Me.griViajesLiquidacionDetalleMAESTRO.Name = "griViajesLiquidacionDetalleMAESTRO"
        Me.griViajesLiquidacionDetalleMAESTRO.Size = New System.Drawing.Size(1054, 366)
        Me.griViajesLiquidacionDetalleMAESTRO.TabIndex = 5
        Me.griViajesLiquidacionDetalleMAESTRO.Tag = ""
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.opcPlantilla)
        Me.UltraTabPageControl8.Controls.Add(Me.cboCentro)
        Me.UltraTabPageControl8.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl8.Controls.Add(Me.txtOperacionesSinConfirmar)
        Me.UltraTabPageControl8.Controls.Add(Me.opcFormatoLiquidacion)
        Me.UltraTabPageControl8.Controls.Add(Me.UltraLabel7)
        Me.UltraTabPageControl8.Controls.Add(Me.cboClienteLiquidacion)
        Me.UltraTabPageControl8.Controls.Add(Me.btnSeleccionaViajes)
        Me.UltraTabPageControl8.Controls.Add(Me.btnViajesSinLiquidar)
        Me.UltraTabPageControl8.Controls.Add(Me.grupoTipoVehiculo)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(621, 121)
        '
        'opcPlantilla
        '
        Appearance92.FontData.BoldAsString = "True"
        Appearance92.ForeColor = System.Drawing.Color.Navy
        Me.opcPlantilla.Appearance = Appearance92
        Me.opcPlantilla.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcPlantilla.CheckedIndex = 0
        Me.opcPlantilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcPlantilla.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem21.DataValue = "Default Item"
        ValueListItem21.DisplayText = "PLANTILLA 1"
        ValueListItem22.DataValue = "ValueListItem1"
        ValueListItem22.DisplayText = "PLANTILLA 2"
        ValueListItem23.DataValue = "ValueListItem2"
        ValueListItem23.DisplayText = "PLANTILLA 3"
        ValueListItem24.DataValue = "ValueListItem3"
        ValueListItem24.DisplayText = "PLANTILLA 4"
        Me.opcPlantilla.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem21, ValueListItem22, ValueListItem23, ValueListItem24})
        Me.opcPlantilla.Location = New System.Drawing.Point(417, 87)
        Me.opcPlantilla.Name = "opcPlantilla"
        Me.opcPlantilla.Size = New System.Drawing.Size(200, 30)
        Me.opcPlantilla.TabIndex = 289
        Me.opcPlantilla.Text = "PLANTILLA 1"
        UltraToolTipInfo4.ToolTipText = "Seleccionar Plantillas segun el cambio de cliente"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.opcPlantilla, UltraToolTipInfo4)
        '
        'cboCentro
        '
        Appearance148.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance148
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(2, 61)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(100, 21)
        Me.cboCentro.TabIndex = 288
        UltraToolTipInfo5.ToolTipText = "Seleccione Centro"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboCentro, UltraToolTipInfo5)
        Me.cboCentro.ValueMember = "Abreviatura"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.fecHastaViaje)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox1.Controls.Add(Me.fecDesdeViaje)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(-1, 3)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(150, 55)
        Me.UltraGroupBox1.TabIndex = 286
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecHastaViaje
        '
        Me.fecHastaViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecHastaViaje.Location = New System.Drawing.Point(50, 29)
        Me.fecHastaViaje.MaskInput = ""
        Me.fecHastaViaje.Name = "fecHastaViaje"
        Me.fecHastaViaje.Size = New System.Drawing.Size(90, 21)
        Me.fecHastaViaje.TabIndex = 50
        '
        'UltraLabel9
        '
        Appearance149.BackColor = System.Drawing.Color.Transparent
        Appearance149.ForeColor = System.Drawing.Color.Navy
        Appearance149.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance149
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(10, 33)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel9.TabIndex = 49
        Me.UltraLabel9.Text = "Hasta:"
        '
        'fecDesdeViaje
        '
        Me.fecDesdeViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDesdeViaje.Location = New System.Drawing.Point(50, 6)
        Me.fecDesdeViaje.MaskInput = ""
        Me.fecDesdeViaje.Name = "fecDesdeViaje"
        Me.fecDesdeViaje.Size = New System.Drawing.Size(90, 21)
        Me.fecDesdeViaje.TabIndex = 48
        '
        'UltraLabel10
        '
        Appearance150.BackColor = System.Drawing.Color.Transparent
        Appearance150.ForeColor = System.Drawing.Color.Navy
        Appearance150.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance150
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(7, 10)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel10.TabIndex = 47
        Me.UltraLabel10.Text = "Desde:"
        '
        'txtOperacionesSinConfirmar
        '
        Me.txtOperacionesSinConfirmar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOperacionesSinConfirmar.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperacionesSinConfirmar.Location = New System.Drawing.Point(86, 86)
        Me.txtOperacionesSinConfirmar.Multiline = True
        Me.txtOperacionesSinConfirmar.Name = "txtOperacionesSinConfirmar"
        Me.txtOperacionesSinConfirmar.Size = New System.Drawing.Size(325, 35)
        Me.txtOperacionesSinConfirmar.TabIndex = 285
        Me.txtOperacionesSinConfirmar.Text = "Operaciones Sin Confirmar: "
        UltraToolTipInfo6.ToolTipText = "Ingrese Observacion de la Liquidacion"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtOperacionesSinConfirmar, UltraToolTipInfo6)
        '
        'opcFormatoLiquidacion
        '
        Appearance151.ForeColor = System.Drawing.Color.Navy
        Me.opcFormatoLiquidacion.Appearance = Appearance151
        Me.opcFormatoLiquidacion.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcFormatoLiquidacion.CheckedIndex = 0
        Me.opcFormatoLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcFormatoLiquidacion.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem12.DataValue = "Default Item"
        ValueListItem12.DisplayText = "SPSA Lurin_Local"
        ValueListItem13.DataValue = "ValueListItem1"
        ValueListItem13.DisplayText = "SPSA Lurin_Prov"
        ValueListItem14.DataValue = "ValueListItem2"
        ValueListItem14.DisplayText = "SPSA Ransa"
        ValueListItem15.DataValue = "ValueListItem3"
        ValueListItem15.DisplayText = "SPSA SF_VES"
        ValueListItem16.DataValue = "ValueListItem4"
        ValueListItem16.DisplayText = "TOTTUS"
        ValueListItem17.DataValue = "ValueListItem5"
        ValueListItem17.DisplayText = "MAESTRO"
        ValueListItem18.DataValue = "ValueListItem6"
        ValueListItem18.DisplayText = "FALABELLA"
        ValueListItem19.DataValue = "ValueListItem7"
        ValueListItem19.DisplayText = "SODIMAC"
        ValueListItem6.DataValue = "ValueListItem8"
        ValueListItem6.DisplayText = "PARIHUELAS"
        Me.opcFormatoLiquidacion.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem12, ValueListItem13, ValueListItem14, ValueListItem15, ValueListItem16, ValueListItem17, ValueListItem18, ValueListItem19, ValueListItem6})
        Me.opcFormatoLiquidacion.Location = New System.Drawing.Point(417, 5)
        Me.opcFormatoLiquidacion.Name = "opcFormatoLiquidacion"
        Me.opcFormatoLiquidacion.Size = New System.Drawing.Size(200, 76)
        Me.opcFormatoLiquidacion.TabIndex = 281
        Me.opcFormatoLiquidacion.Text = "SPSA Lurin_Local"
        '
        'UltraLabel7
        '
        Appearance152.BackColor = System.Drawing.Color.Transparent
        Appearance152.ForeColor = System.Drawing.Color.Navy
        Appearance152.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance152
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(3, 94)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel7.TabIndex = 284
        Me.UltraLabel7.Text = "Select:"
        '
        'cboClienteLiquidacion
        '
        Appearance153.ForeColor = System.Drawing.Color.Black
        Me.cboClienteLiquidacion.Appearance = Appearance153
        Me.cboClienteLiquidacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboClienteLiquidacion.DisplayMember = "Nombre"
        Me.cboClienteLiquidacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClienteLiquidacion.ForeColor = System.Drawing.Color.Black
        Me.cboClienteLiquidacion.Location = New System.Drawing.Point(105, 61)
        Me.cboClienteLiquidacion.Name = "cboClienteLiquidacion"
        Me.cboClienteLiquidacion.Size = New System.Drawing.Size(260, 21)
        Me.cboClienteLiquidacion.TabIndex = 272
        UltraToolTipInfo7.ToolTipText = "Seleccione Cliente"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboClienteLiquidacion, UltraToolTipInfo7)
        Me.cboClienteLiquidacion.ValueMember = "Id"
        '
        'btnSeleccionaViajes
        '
        Appearance154.Image = 8
        Appearance154.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance154.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnSeleccionaViajes.Appearance = Appearance154
        Me.btnSeleccionaViajes.ImageList = Me.imagenes
        Me.btnSeleccionaViajes.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSeleccionaViajes.Location = New System.Drawing.Point(41, 87)
        Me.btnSeleccionaViajes.Name = "btnSeleccionaViajes"
        Me.btnSeleccionaViajes.Size = New System.Drawing.Size(45, 30)
        Me.btnSeleccionaViajes.TabIndex = 283
        '
        'btnViajesSinLiquidar
        '
        Appearance155.Image = "266.png"
        Appearance155.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance155.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnViajesSinLiquidar.Appearance = Appearance155
        Me.btnViajesSinLiquidar.ImageList = Me.imagenes
        Me.btnViajesSinLiquidar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnViajesSinLiquidar.Location = New System.Drawing.Point(367, 56)
        Me.btnViajesSinLiquidar.Name = "btnViajesSinLiquidar"
        Me.btnViajesSinLiquidar.Size = New System.Drawing.Size(45, 30)
        Me.btnViajesSinLiquidar.TabIndex = 282
        '
        'grupoTipoVehiculo
        '
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta9)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorDoctsPerdido)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta3)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta7)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorSinConfirmar)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorConDocts)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorSinDocts)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta8)
        Me.grupoTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoTipoVehiculo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoTipoVehiculo.Location = New System.Drawing.Point(151, 6)
        Me.grupoTipoVehiculo.Name = "grupoTipoVehiculo"
        Me.grupoTipoVehiculo.Size = New System.Drawing.Size(261, 50)
        Me.grupoTipoVehiculo.TabIndex = 274
        Me.grupoTipoVehiculo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(136, 7)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(74, 14)
        Me.Etiqueta9.TabIndex = 4
        Me.Etiqueta9.Text = "Doct. Perdido:"
        '
        'ColorDoctsPerdido
        '
        Me.ColorDoctsPerdido.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorDoctsPerdido.Location = New System.Drawing.Point(211, 3)
        Me.ColorDoctsPerdido.Name = "ColorDoctsPerdido"
        Me.ColorDoctsPerdido.Size = New System.Drawing.Size(44, 21)
        Me.ColorDoctsPerdido.TabIndex = 5
        Me.ColorDoctsPerdido.Text = "255| 192| 192"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(10, 28)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(78, 14)
        Me.Etiqueta3.TabIndex = 8
        Me.Etiqueta3.Text = "Conf. Sin Doct:"
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(158, 29)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta7.TabIndex = 10
        Me.Etiqueta7.Text = "Sin Conf.:"
        '
        'ColorSinConfirmar
        '
        Me.ColorSinConfirmar.Color = System.Drawing.Color.White
        Me.ColorSinConfirmar.Location = New System.Drawing.Point(211, 25)
        Me.ColorSinConfirmar.Name = "ColorSinConfirmar"
        Me.ColorSinConfirmar.Size = New System.Drawing.Size(44, 21)
        Me.ColorSinConfirmar.TabIndex = 11
        Me.ColorSinConfirmar.Text = "White"
        '
        'ColorConDocts
        '
        Me.ColorConDocts.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorConDocts.Location = New System.Drawing.Point(89, 3)
        Me.ColorConDocts.Name = "ColorConDocts"
        Me.ColorConDocts.Size = New System.Drawing.Size(44, 21)
        Me.ColorConDocts.TabIndex = 3
        Me.ColorConDocts.Text = "192| 255| 192"
        '
        'ColorSinDocts
        '
        Me.ColorSinDocts.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorSinDocts.Location = New System.Drawing.Point(89, 25)
        Me.ColorSinDocts.Name = "ColorSinDocts"
        Me.ColorSinDocts.Size = New System.Drawing.Size(44, 21)
        Me.ColorSinDocts.TabIndex = 9
        Me.ColorSinDocts.Text = "255| 255| 192"
        '
        'Etiqueta8
        '
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(6, 6)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(82, 14)
        Me.Etiqueta8.TabIndex = 2
        Me.Etiqueta8.Text = "Conf. Con Doct:"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.griTarifas)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(621, 121)
        '
        'griTarifas
        '
        Me.griTarifas.DataSource = Me.ogdTarifas
        Appearance117.BackColor = System.Drawing.Color.White
        Me.griTarifas.DisplayLayout.Appearance = Appearance117
        Appearance118.TextHAlignAsString = "Center"
        UltraGridColumn961.Header.Appearance = Appearance118
        UltraGridColumn961.Header.VisiblePosition = 0
        Appearance119.TextHAlignAsString = "Right"
        UltraGridColumn962.CellAppearance = Appearance119
        UltraGridColumn962.Header.VisiblePosition = 1
        UltraGridColumn962.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn962.Width = 50
        Appearance120.TextHAlignAsString = "Right"
        UltraGridColumn963.CellAppearance = Appearance120
        UltraGridColumn963.Header.VisiblePosition = 2
        UltraGridColumn963.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn963.Width = 50
        Appearance121.TextHAlignAsString = "Right"
        UltraGridColumn964.CellAppearance = Appearance121
        UltraGridColumn964.Header.VisiblePosition = 3
        UltraGridColumn964.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn964.Width = 50
        Appearance122.TextHAlignAsString = "Right"
        UltraGridColumn965.CellAppearance = Appearance122
        UltraGridColumn965.Header.VisiblePosition = 4
        UltraGridColumn965.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn965.Width = 50
        Appearance123.TextHAlignAsString = "Right"
        UltraGridColumn966.CellAppearance = Appearance123
        UltraGridColumn966.Header.VisiblePosition = 5
        UltraGridColumn966.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn966.Width = 50
        UltraGridBand21.Columns.AddRange(New Object() {UltraGridColumn961, UltraGridColumn962, UltraGridColumn963, UltraGridColumn964, UltraGridColumn965, UltraGridColumn966})
        UltraGridBand21.SummaryFooterCaption = "Totales:"
        Me.griTarifas.DisplayLayout.BandsSerializer.Add(UltraGridBand21)
        Me.griTarifas.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griTarifas.DisplayLayout.GroupByBox.Hidden = True
        Me.griTarifas.DisplayLayout.MaxColScrollRegions = 1
        Me.griTarifas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTarifas.DisplayLayout.Override.CellPadding = 2
        Me.griTarifas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance124.TextHAlignAsString = "Left"
        Me.griTarifas.DisplayLayout.Override.HeaderAppearance = Appearance124
        Me.griTarifas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTarifas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance125.TextVAlignAsString = "Middle"
        Me.griTarifas.DisplayLayout.Override.RowAppearance = Appearance125
        Me.griTarifas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTarifas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTarifas.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griTarifas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTarifas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTarifas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTarifas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTarifas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTarifas.Location = New System.Drawing.Point(0, 0)
        Me.griTarifas.Name = "griTarifas"
        Me.griTarifas.Size = New System.Drawing.Size(621, 121)
        Me.griTarifas.TabIndex = 6
        Me.griTarifas.Tag = ""
        '
        'ogdTarifas
        '
        UltraDataColumn238.DataType = GetType(Double)
        UltraDataColumn239.DataType = GetType(Double)
        UltraDataColumn240.DataType = GetType(Double)
        UltraDataColumn241.DataType = GetType(Double)
        UltraDataColumn242.DataType = GetType(Double)
        Me.ogdTarifas.Band.Columns.AddRange(New Object() {UltraDataColumn237, UltraDataColumn238, UltraDataColumn239, UltraDataColumn240, UltraDataColumn241, UltraDataColumn242})
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.griTarifasRetorno)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(621, 121)
        '
        'griTarifasRetorno
        '
        Me.griTarifasRetorno.DataSource = Me.ogdTarifas
        Appearance126.BackColor = System.Drawing.Color.White
        Me.griTarifasRetorno.DisplayLayout.Appearance = Appearance126
        Appearance127.TextHAlignAsString = "Center"
        UltraGridColumn967.Header.Appearance = Appearance127
        UltraGridColumn967.Header.VisiblePosition = 0
        Appearance128.TextHAlignAsString = "Right"
        UltraGridColumn968.CellAppearance = Appearance128
        UltraGridColumn968.Header.VisiblePosition = 1
        UltraGridColumn968.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn968.Width = 50
        Appearance129.TextHAlignAsString = "Right"
        UltraGridColumn969.CellAppearance = Appearance129
        UltraGridColumn969.Header.VisiblePosition = 2
        UltraGridColumn969.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn969.Width = 50
        Appearance130.TextHAlignAsString = "Right"
        UltraGridColumn970.CellAppearance = Appearance130
        UltraGridColumn970.Header.VisiblePosition = 3
        UltraGridColumn970.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn970.Width = 50
        Appearance131.TextHAlignAsString = "Right"
        UltraGridColumn971.CellAppearance = Appearance131
        UltraGridColumn971.Header.VisiblePosition = 4
        UltraGridColumn971.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn971.Width = 50
        Appearance132.TextHAlignAsString = "Right"
        UltraGridColumn972.CellAppearance = Appearance132
        UltraGridColumn972.Header.VisiblePosition = 5
        UltraGridColumn972.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn972.Width = 50
        UltraGridBand22.Columns.AddRange(New Object() {UltraGridColumn967, UltraGridColumn968, UltraGridColumn969, UltraGridColumn970, UltraGridColumn971, UltraGridColumn972})
        UltraGridBand22.SummaryFooterCaption = "Totales:"
        Me.griTarifasRetorno.DisplayLayout.BandsSerializer.Add(UltraGridBand22)
        Me.griTarifasRetorno.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griTarifasRetorno.DisplayLayout.GroupByBox.Hidden = True
        Me.griTarifasRetorno.DisplayLayout.MaxColScrollRegions = 1
        Me.griTarifasRetorno.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifasRetorno.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTarifasRetorno.DisplayLayout.Override.CellPadding = 2
        Me.griTarifasRetorno.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance133.TextHAlignAsString = "Left"
        Me.griTarifasRetorno.DisplayLayout.Override.HeaderAppearance = Appearance133
        Me.griTarifasRetorno.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTarifasRetorno.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance134.TextVAlignAsString = "Middle"
        Me.griTarifasRetorno.DisplayLayout.Override.RowAppearance = Appearance134
        Me.griTarifasRetorno.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTarifasRetorno.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTarifasRetorno.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griTarifasRetorno.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTarifasRetorno.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTarifasRetorno.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTarifasRetorno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTarifasRetorno.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTarifasRetorno.Location = New System.Drawing.Point(0, 0)
        Me.griTarifasRetorno.Name = "griTarifasRetorno"
        Me.griTarifasRetorno.Size = New System.Drawing.Size(621, 121)
        Me.griTarifasRetorno.TabIndex = 7
        Me.griTarifasRetorno.Tag = ""
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.tabListaLiquidaciones)
        Me.UltraTabPageControl6.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1058, 539)
        '
        'tabListaLiquidaciones
        '
        Me.tabListaLiquidaciones.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabListaLiquidaciones.Controls.Add(Me.UltraTabPageControl1)
        Me.tabListaLiquidaciones.Controls.Add(Me.UltraTabPageControl2)
        Me.tabListaLiquidaciones.Controls.Add(Me.UltraTabPageControl4)
        Me.tabListaLiquidaciones.Controls.Add(Me.UltraTabPageControl17)
        Me.tabListaLiquidaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabListaLiquidaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabListaLiquidaciones.Location = New System.Drawing.Point(0, 125)
        Me.tabListaLiquidaciones.Name = "tabListaLiquidaciones"
        Me.tabListaLiquidaciones.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabListaLiquidaciones.Size = New System.Drawing.Size(1058, 414)
        Me.tabListaLiquidaciones.TabIndex = 1
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Viajes Antiguos"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Viajes Nuevos"
        UltraTab8.TabPage = Me.UltraTabPageControl4
        UltraTab8.Text = "Liquidaciones"
        UltraTab17.TabPage = Me.UltraTabPageControl17
        UltraTab17.Text = "Prorratear SPSA"
        Me.tabListaLiquidaciones.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab8, UltraTab17})
        Me.tabListaLiquidaciones.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1054, 391)
        '
        'agrBusqueda
        '
        Appearance93.ForeColor = System.Drawing.Color.Navy
        Me.agrBusqueda.Appearance = Appearance93
        Me.agrBusqueda.Controls.Add(Me.btnActualizaDocumentosGuias)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel11)
        Me.agrBusqueda.Controls.Add(Me.UltraGroupBox2)
        Me.agrBusqueda.Controls.Add(Me.colorCambio)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta45)
        Me.agrBusqueda.Controls.Add(Me.btnEnviarCorreo)
        Me.agrBusqueda.Controls.Add(Me.cboCliente)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel17)
        Me.agrBusqueda.Controls.Add(Me.btnExpandido)
        Me.agrBusqueda.Controls.Add(Me.BtnN2)
        Me.agrBusqueda.Controls.Add(Me.btnN1)
        Me.agrBusqueda.Controls.Add(Me.UltraGroupBox11)
        Me.agrBusqueda.Controls.Add(Me.opcActualizarGuias)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1058, 125)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Text = "Datos de Búsqueda:"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnActualizaDocumentosGuias
        '
        Appearance94.Image = "266.png"
        Appearance94.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance94.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnActualizaDocumentosGuias.Appearance = Appearance94
        Me.btnActualizaDocumentosGuias.ImageList = Me.imagenes
        Me.btnActualizaDocumentosGuias.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnActualizaDocumentosGuias.Location = New System.Drawing.Point(357, 32)
        Me.btnActualizaDocumentosGuias.Name = "btnActualizaDocumentosGuias"
        Me.btnActualizaDocumentosGuias.Size = New System.Drawing.Size(45, 30)
        Me.btnActualizaDocumentosGuias.TabIndex = 296
        '
        'UltraLabel11
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Appearance95.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance95
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(168, 25)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(80, 40)
        Me.UltraLabel11.TabIndex = 295
        Me.UltraLabel11.Text = "Actualizar Documentos Grt, Grr, Carga"
        '
        'UltraGroupBox2
        '
        Appearance96.BackColor = System.Drawing.Color.White
        Appearance96.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance96
        Me.UltraGroupBox2.Controls.Add(Me.opcPlantillaLista)
        Me.UltraGroupBox2.Controls.Add(Me.Colores2)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta14)
        Me.UltraGroupBox2.Controls.Add(Me.ColorFormato7)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta1)
        Me.UltraGroupBox2.Controls.Add(Me.ColorFormato6)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta5)
        Me.UltraGroupBox2.Controls.Add(Me.ColorFormato5)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta11)
        Me.UltraGroupBox2.Controls.Add(Me.ColorFormato3)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta12)
        Me.UltraGroupBox2.Controls.Add(Me.ColorFormato4)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta13)
        Me.UltraGroupBox2.Controls.Add(Me.ColorFormato2)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta10)
        Me.UltraGroupBox2.Controls.Add(Me.ColorFormato0)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta2)
        Me.UltraGroupBox2.Controls.Add(Me.ColorFormato1)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta4)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraGroupBox2.Location = New System.Drawing.Point(631, 18)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(425, 105)
        Me.UltraGroupBox2.TabIndex = 283
        Me.UltraGroupBox2.Text = "Formato Excel"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'opcPlantillaLista
        '
        Appearance97.FontData.BoldAsString = "True"
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Me.opcPlantillaLista.Appearance = Appearance97
        Me.opcPlantillaLista.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcPlantillaLista.CheckedIndex = 0
        Me.opcPlantillaLista.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.opcPlantillaLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcPlantillaLista.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "PLANTILLA 1    ."
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "PLANTILLA 2    ."
        ValueListItem3.DataValue = "ValueListItem2"
        ValueListItem3.DisplayText = "PLANTILLA 3    ."
        ValueListItem20.DataValue = "ValueListItem3"
        ValueListItem20.DisplayText = "PLANTILLA 4    ."
        Me.opcPlantillaLista.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem20})
        Me.opcPlantillaLista.Location = New System.Drawing.Point(3, 87)
        Me.opcPlantillaLista.Name = "opcPlantillaLista"
        Me.opcPlantillaLista.Size = New System.Drawing.Size(419, 15)
        Me.opcPlantillaLista.TabIndex = 298
        Me.opcPlantillaLista.Text = "PLANTILLA 1    ."
        UltraToolTipInfo1.ToolTipText = "Seleccionar Plantilla segun el cambio de cliente"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.opcPlantillaLista, UltraToolTipInfo1)
        '
        'Colores2
        '
        Me.Colores2.Color = System.Drawing.Color.Yellow
        Me.Colores2.Location = New System.Drawing.Point(377, 60)
        Me.Colores2.Name = "Colores2"
        Me.Colores2.Size = New System.Drawing.Size(43, 21)
        Me.Colores2.TabIndex = 21
        Me.Colores2.Text = "Yellow"
        '
        'Etiqueta14
        '
        Appearance98.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance98
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(285, 64)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(90, 14)
        Me.Etiqueta14.TabIndex = 20
        Me.Etiqueta14.Text = "PARIHUELAS (8)"
        '
        'ColorFormato7
        '
        Me.ColorFormato7.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ColorFormato7.Location = New System.Drawing.Point(377, 39)
        Me.ColorFormato7.Name = "ColorFormato7"
        Me.ColorFormato7.Size = New System.Drawing.Size(43, 21)
        Me.ColorFormato7.TabIndex = 19
        Me.ColorFormato7.Text = "255| 192| 128"
        '
        'Etiqueta1
        '
        Appearance99.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance99
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(302, 43)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(72, 14)
        Me.Etiqueta1.TabIndex = 18
        Me.Etiqueta1.Text = "SODIMAC (7)"
        '
        'ColorFormato6
        '
        Me.ColorFormato6.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ColorFormato6.Location = New System.Drawing.Point(377, 18)
        Me.ColorFormato6.Name = "ColorFormato6"
        Me.ColorFormato6.Size = New System.Drawing.Size(43, 21)
        Me.ColorFormato6.TabIndex = 17
        Me.ColorFormato6.Text = "255| 128| 128"
        '
        'Etiqueta5
        '
        Appearance100.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance100
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(294, 22)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(82, 14)
        Me.Etiqueta5.TabIndex = 16
        Me.Etiqueta5.Text = "FALABELLA (6)"
        '
        'ColorFormato5
        '
        Me.ColorFormato5.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorFormato5.Location = New System.Drawing.Point(241, 60)
        Me.ColorFormato5.Name = "ColorFormato5"
        Me.ColorFormato5.Size = New System.Drawing.Size(43, 21)
        Me.ColorFormato5.TabIndex = 15
        Me.ColorFormato5.Text = "192| 192| 255"
        '
        'Etiqueta11
        '
        Appearance101.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance101
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(165, 64)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta11.TabIndex = 14
        Me.Etiqueta11.Text = "MAESTRO (5)"
        '
        'ColorFormato3
        '
        Me.ColorFormato3.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorFormato3.Location = New System.Drawing.Point(241, 18)
        Me.ColorFormato3.Name = "ColorFormato3"
        Me.ColorFormato3.Size = New System.Drawing.Size(43, 21)
        Me.ColorFormato3.TabIndex = 11
        Me.ColorFormato3.Text = "192| 255| 192"
        '
        'Etiqueta12
        '
        Appearance102.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance102
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(153, 22)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(89, 14)
        Me.Etiqueta12.TabIndex = 10
        Me.Etiqueta12.Text = "SPSA SFVES (3)"
        '
        'ColorFormato4
        '
        Me.ColorFormato4.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorFormato4.Location = New System.Drawing.Point(241, 39)
        Me.ColorFormato4.Name = "ColorFormato4"
        Me.ColorFormato4.Size = New System.Drawing.Size(43, 21)
        Me.ColorFormato4.TabIndex = 13
        Me.ColorFormato4.Text = "192| 255| 255"
        '
        'Etiqueta13
        '
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance103
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(174, 43)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta13.TabIndex = 12
        Me.Etiqueta13.Text = "TOTTUS (4)"
        '
        'ColorFormato2
        '
        Me.ColorFormato2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorFormato2.Location = New System.Drawing.Point(109, 60)
        Me.ColorFormato2.Name = "ColorFormato2"
        Me.ColorFormato2.Size = New System.Drawing.Size(43, 21)
        Me.ColorFormato2.TabIndex = 9
        Me.ColorFormato2.Text = "255| 255| 192"
        '
        'Etiqueta10
        '
        Appearance104.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance104
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(25, 64)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(84, 14)
        Me.Etiqueta10.TabIndex = 8
        Me.Etiqueta10.Text = "SPSA Ransa (2)"
        '
        'ColorFormato0
        '
        Me.ColorFormato0.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorFormato0.Location = New System.Drawing.Point(109, 18)
        Me.ColorFormato0.Name = "ColorFormato0"
        Me.ColorFormato0.Size = New System.Drawing.Size(43, 21)
        Me.ColorFormato0.TabIndex = 5
        Me.ColorFormato0.Text = "255| 192| 192"
        '
        'Etiqueta2
        '
        Appearance105.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance105
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(4, 22)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(103, 14)
        Me.Etiqueta2.TabIndex = 4
        Me.Etiqueta2.Text = "SPSA LurinLocal (0)"
        '
        'ColorFormato1
        '
        Me.ColorFormato1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorFormato1.Location = New System.Drawing.Point(109, 39)
        Me.ColorFormato1.Name = "ColorFormato1"
        Me.ColorFormato1.Size = New System.Drawing.Size(43, 21)
        Me.ColorFormato1.TabIndex = 7
        Me.ColorFormato1.Text = "255| 224| 192"
        '
        'Etiqueta4
        '
        Appearance106.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance106
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(8, 43)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(100, 14)
        Me.Etiqueta4.TabIndex = 6
        Me.Etiqueta4.Text = "SPSA LurinProv (1)"
        '
        'colorCambio
        '
        Me.colorCambio.Color = System.Drawing.Color.Aqua
        Me.colorCambio.Location = New System.Drawing.Point(444, 96)
        Me.colorCambio.Name = "colorCambio"
        Me.colorCambio.Size = New System.Drawing.Size(44, 21)
        Me.colorCambio.TabIndex = 275
        Me.colorCambio.Text = "Aqua"
        '
        'Etiqueta45
        '
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(376, 100)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta45.TabIndex = 274
        Me.Etiqueta45.Text = "Actualizado:"
        '
        'btnEnviarCorreo
        '
        Appearance107.Image = Global.ISL.Win.My.Resources.Resources.accounting_mail
        Appearance107.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance107.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnEnviarCorreo.Appearance = Appearance107
        Me.btnEnviarCorreo.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEnviarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarCorreo.ForeColor = System.Drawing.Color.Black
        Me.btnEnviarCorreo.ImageList = Me.imagenes
        Me.btnEnviarCorreo.ImageSize = New System.Drawing.Size(50, 40)
        Me.btnEnviarCorreo.Location = New System.Drawing.Point(408, 56)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        Me.btnEnviarCorreo.Size = New System.Drawing.Size(80, 40)
        Me.btnEnviarCorreo.TabIndex = 273
        '
        'cboCliente
        '
        Appearance108.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Appearance = Appearance108
        Me.cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Location = New System.Drawing.Point(52, 75)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(350, 21)
        Me.cboCliente.TabIndex = 272
        Me.cboCliente.ValueMember = "Id"
        '
        'UltraLabel17
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Appearance109.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance109
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(6, 79)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel17.TabIndex = 271
        Me.UltraLabel17.Text = "Cliente:"
        '
        'btnExpandido
        '
        Appearance110.TextVAlignAsString = "Top"
        Me.btnExpandido.Appearance = Appearance110
        Me.btnExpandido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandido.Location = New System.Drawing.Point(49, 97)
        Me.btnExpandido.Name = "btnExpandido"
        Me.btnExpandido.Size = New System.Drawing.Size(35, 20)
        Me.btnExpandido.TabIndex = 269
        Me.btnExpandido.Text = "*"
        '
        'BtnN2
        '
        Me.BtnN2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnN2.Location = New System.Drawing.Point(131, 97)
        Me.BtnN2.Name = "BtnN2"
        Me.BtnN2.Size = New System.Drawing.Size(35, 20)
        Me.BtnN2.TabIndex = 268
        Me.BtnN2.Text = "2"
        '
        'btnN1
        '
        Me.btnN1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnN1.Location = New System.Drawing.Point(90, 97)
        Me.btnN1.Name = "btnN1"
        Me.btnN1.Size = New System.Drawing.Size(35, 20)
        Me.btnN1.TabIndex = 267
        Me.btnN1.Text = "1"
        '
        'UltraGroupBox11
        '
        Me.UltraGroupBox11.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel39)
        Me.UltraGroupBox11.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel41)
        Me.UltraGroupBox11.Location = New System.Drawing.Point(2, 18)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(150, 55)
        Me.UltraGroupBox11.TabIndex = 276
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
        Appearance111.BackColor = System.Drawing.Color.Transparent
        Appearance111.ForeColor = System.Drawing.Color.Navy
        Appearance111.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance111
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
        Appearance112.BackColor = System.Drawing.Color.Transparent
        Appearance112.ForeColor = System.Drawing.Color.Navy
        Appearance112.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance112
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(7, 10)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel41.TabIndex = 47
        Me.UltraLabel41.Text = "Desde:"
        '
        'opcActualizarGuias
        '
        Appearance113.ForeColor = System.Drawing.Color.Navy
        Me.opcActualizarGuias.Appearance = Appearance113
        Me.opcActualizarGuias.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcActualizarGuias.CheckedIndex = 0
        Me.opcActualizarGuias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcActualizarGuias.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem7.DataValue = "Default Item"
        ValueListItem7.DisplayText = "GuiaTransportista"
        ValueListItem8.DataValue = "ValueListItem1"
        ValueListItem8.DisplayText = "GuiaRemitente"
        ValueListItem9.DataValue = "ValueListItem2"
        ValueListItem9.DisplayText = "NumeroCarga"
        Me.opcActualizarGuias.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem7, ValueListItem8, ValueListItem9})
        Me.opcActualizarGuias.Location = New System.Drawing.Point(252, 22)
        Me.opcActualizarGuias.Name = "opcActualizarGuias"
        Me.opcActualizarGuias.Size = New System.Drawing.Size(110, 50)
        Me.opcActualizarGuias.TabIndex = 297
        Me.opcActualizarGuias.Text = "GuiaTransportista"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.tabDetalleLiquidacion)
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1058, 539)
        '
        'tabDetalleLiquidacion
        '
        Me.tabDetalleLiquidacion.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tabDetalleLiquidacion.Controls.Add(Me.UltraTabPageControl3)
        Me.tabDetalleLiquidacion.Controls.Add(Me.UltraTabPageControl5)
        Me.tabDetalleLiquidacion.Controls.Add(Me.UltraTabPageControl10)
        Me.tabDetalleLiquidacion.Controls.Add(Me.UltraTabPageControl11)
        Me.tabDetalleLiquidacion.Controls.Add(Me.UltraTabPageControl12)
        Me.tabDetalleLiquidacion.Controls.Add(Me.UltraTabPageControl13)
        Me.tabDetalleLiquidacion.Controls.Add(Me.UltraTabPageControl14)
        Me.tabDetalleLiquidacion.Controls.Add(Me.UltraTabPageControl15)
        Me.tabDetalleLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDetalleLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDetalleLiquidacion.Location = New System.Drawing.Point(0, 150)
        Me.tabDetalleLiquidacion.Name = "tabDetalleLiquidacion"
        Me.tabDetalleLiquidacion.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tabDetalleLiquidacion.Size = New System.Drawing.Size(1058, 389)
        Me.tabDetalleLiquidacion.TabIndex = 3
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "V.S.L - SPSA Local"
        UltraTab1.ToolTipText = "Viajes sin liquidar - SPSA CD_Lurin_Local"
        UltraTab2.TabPage = Me.UltraTabPageControl5
        UltraTab2.Text = "L.D - SPSA Local"
        UltraTab2.ToolTipText = "Liquidacion detalle - SPSA CD_Lurin_Local"
        UltraTab7.TabPage = Me.UltraTabPageControl10
        UltraTab7.Text = "V.S.L - SPSA"
        UltraTab7.ToolTipText = "Viajes sin Liquidar - Lurin_Prov - Ransa - SF_VES"
        UltraTab11.TabPage = Me.UltraTabPageControl11
        UltraTab11.Text = "L.D - SPSA"
        UltraTab11.ToolTipText = "Liquidacion detalle - Lurin_Prov - Ransa - SF_VES"
        UltraTab12.TabPage = Me.UltraTabPageControl12
        UltraTab12.Text = "V.S.L -"
        UltraTab12.ToolTipText = "Viajes sin Liquidar - TOTTUS"
        UltraTab13.TabPage = Me.UltraTabPageControl13
        UltraTab13.Text = "L.D -"
        UltraTab13.ToolTipText = "Liquidacion detalle - TOTTUS"
        UltraTab14.TabPage = Me.UltraTabPageControl14
        UltraTab14.Text = "V.S.L - MAESTRO"
        UltraTab14.ToolTipText = "Viajes sin liquidar - Maestro"
        UltraTab15.TabPage = Me.UltraTabPageControl15
        UltraTab15.Text = "L.D - MAESTRO"
        UltraTab15.ToolTipText = "Liquidacion detalle - Maestro"
        Me.tabDetalleLiquidacion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab7, UltraTab11, UltraTab12, UltraTab13, UltraTab14, UltraTab15})
        Me.tabDetalleLiquidacion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1054, 366)
        '
        'Agrupacion1
        '
        Appearance114.BackColor = System.Drawing.Color.White
        Appearance114.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.Appearance = Appearance114
        Appearance115.BackColor = System.Drawing.Color.White
        Appearance115.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance115
        Me.Agrupacion1.Controls.Add(Me.tabAdicional)
        Me.Agrupacion1.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1058, 150)
        Me.Agrupacion1.TabIndex = 2
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'tabAdicional
        '
        Appearance116.BackColor = System.Drawing.Color.White
        Appearance116.BackColor2 = System.Drawing.Color.White
        Me.tabAdicional.ClientAreaAppearance = Appearance116
        Me.tabAdicional.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.tabAdicional.Controls.Add(Me.UltraTabPageControl8)
        Me.tabAdicional.Controls.Add(Me.UltraTabPageControl9)
        Me.tabAdicional.Controls.Add(Me.UltraTabPageControl16)
        Me.tabAdicional.Dock = System.Windows.Forms.DockStyle.Left
        Me.tabAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdicional.Location = New System.Drawing.Point(3, 3)
        Me.tabAdicional.Name = "tabAdicional"
        Me.tabAdicional.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.tabAdicional.Size = New System.Drawing.Size(625, 144)
        Me.tabAdicional.TabIndex = 284
        UltraTab5.TabPage = Me.UltraTabPageControl8
        UltraTab5.Text = "Filtro de Viajes"
        UltraTab6.TabPage = Me.UltraTabPageControl9
        UltraTab6.Text = "Tarifario de Salida"
        UltraTab16.TabPage = Me.UltraTabPageControl16
        UltraTab16.Text = "Tarifas de Retorno"
        Me.tabAdicional.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6, UltraTab16})
        Me.tabAdicional.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(621, 121)
        '
        'UltraExpandableGroupBox1
        '
        Appearance135.BackColor = System.Drawing.Color.White
        Appearance135.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance135
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(350, 144)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(705, 3)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(350, 144)
        Me.UltraExpandableGroupBox1.TabIndex = 281
        Me.UltraExpandableGroupBox1.Text = "Resumen"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnActualizarFleteUnitario)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel6)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel8)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtFleteUnitario)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.fecLiquidacion)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel5)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtCodigo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtIdLiquidacion)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtTotal)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtObservacion)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtIgv)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtSubTotal)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(327, 138)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'btnActualizarFleteUnitario
        '
        Appearance136.Image = "266.png"
        Appearance136.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance136.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnActualizarFleteUnitario.Appearance = Appearance136
        Me.btnActualizarFleteUnitario.ImageList = Me.imagenes
        Me.btnActualizarFleteUnitario.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnActualizarFleteUnitario.Location = New System.Drawing.Point(276, 107)
        Me.btnActualizarFleteUnitario.Name = "btnActualizarFleteUnitario"
        Me.btnActualizarFleteUnitario.Size = New System.Drawing.Size(45, 30)
        Me.btnActualizarFleteUnitario.TabIndex = 292
        '
        'UltraLabel6
        '
        Appearance137.BackColor = System.Drawing.Color.Transparent
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Appearance137.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance137
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(16, 31)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel6.TabIndex = 290
        Me.UltraLabel6.Text = "Fecha:"
        '
        'UltraLabel8
        '
        Appearance138.BackColor = System.Drawing.Color.Transparent
        Appearance138.ForeColor = System.Drawing.Color.Navy
        Appearance138.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance138
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(198, 79)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(123, 33)
        Me.UltraLabel8.TabIndex = 291
        Me.UltraLabel8.Text = "Cambiar Flete Unitario Segun lo seleccionado:"
        '
        'txtFleteUnitario
        '
        Appearance139.TextHAlignAsString = "Right"
        Me.txtFleteUnitario.Appearance = Appearance139
        Me.txtFleteUnitario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFleteUnitario.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtFleteUnitario.InputMask = "{double:6.4}"
        Me.txtFleteUnitario.Location = New System.Drawing.Point(198, 112)
        Me.txtFleteUnitario.Name = "txtFleteUnitario"
        Me.txtFleteUnitario.NonAutoSizeHeight = 20
        Me.txtFleteUnitario.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFleteUnitario.Size = New System.Drawing.Size(73, 20)
        Me.txtFleteUnitario.TabIndex = 285
        Me.txtFleteUnitario.Text = "0.00"
        UltraToolTipInfo2.ToolTipText = "Modificar Fletes Masivamente Segun el filtro actual"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtFleteUnitario, UltraToolTipInfo2)
        '
        'fecLiquidacion
        '
        Appearance140.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecLiquidacion.Appearance = Appearance140
        Me.fecLiquidacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecLiquidacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecLiquidacion.Location = New System.Drawing.Point(59, 27)
        Me.fecLiquidacion.Name = "fecLiquidacion"
        Me.fecLiquidacion.Size = New System.Drawing.Size(100, 21)
        Me.fecLiquidacion.TabIndex = 289
        '
        'UltraLabel5
        '
        Appearance141.BackColor = System.Drawing.Color.Transparent
        Appearance141.ForeColor = System.Drawing.Color.Navy
        Appearance141.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance141
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(13, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel5.TabIndex = 288
        Me.UltraLabel5.Text = "Codigo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(59, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 287
        '
        'txtIdLiquidacion
        '
        Me.txtIdLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdLiquidacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdLiquidacion.Location = New System.Drawing.Point(171, 27)
        Me.txtIdLiquidacion.Name = "txtIdLiquidacion"
        Me.txtIdLiquidacion.Size = New System.Drawing.Size(26, 21)
        Me.txtIdLiquidacion.TabIndex = 286
        Me.txtIdLiquidacion.Visible = False
        '
        'txtTotal
        '
        Appearance142.TextHAlignAsString = "Right"
        Me.txtTotal.Appearance = Appearance142
        Me.txtTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTotal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtTotal.InputMask = "{double:10.2}"
        Me.txtTotal.Location = New System.Drawing.Point(231, 51)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NonAutoSizeHeight = 20
        Me.txtTotal.NullText = "0.00"
        Me.txtTotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(90, 20)
        Me.txtTotal.TabIndex = 285
        Me.txtTotal.Text = "0.00"
        '
        'txtObservacion
        '
        Me.txtObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacion.Location = New System.Drawing.Point(5, 51)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(185, 50)
        Me.txtObservacion.TabIndex = 282
        UltraToolTipInfo3.ToolTipText = "Ingrese Observacion de la Liquidacion"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtObservacion, UltraToolTipInfo3)
        '
        'txtIgv
        '
        Appearance143.TextHAlignAsString = "Right"
        Me.txtIgv.Appearance = Appearance143
        Me.txtIgv.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIgv.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtIgv.InputMask = "{double:10.2}"
        Me.txtIgv.Location = New System.Drawing.Point(231, 27)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.NonAutoSizeHeight = 20
        Me.txtIgv.NullText = "0.00"
        Me.txtIgv.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtIgv.ReadOnly = True
        Me.txtIgv.Size = New System.Drawing.Size(90, 20)
        Me.txtIgv.TabIndex = 284
        Me.txtIgv.Text = "0.00"
        '
        'txtSubTotal
        '
        Appearance144.TextHAlignAsString = "Right"
        Me.txtSubTotal.Appearance = Appearance144
        Me.txtSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSubTotal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtSubTotal.InputMask = "{double:10.2}"
        Me.txtSubTotal.Location = New System.Drawing.Point(231, 4)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.NonAutoSizeHeight = 20
        Me.txtSubTotal.NullText = "0.00"
        Me.txtSubTotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(90, 20)
        Me.txtSubTotal.TabIndex = 283
        Me.txtSubTotal.Text = "0.00"
        '
        'UltraLabel4
        '
        Appearance145.BackColor = System.Drawing.Color.Transparent
        Appearance145.ForeColor = System.Drawing.Color.Navy
        Appearance145.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance145
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(172, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel4.TabIndex = 280
        Me.UltraLabel4.Text = "SubTotal:"
        '
        'UltraLabel3
        '
        Appearance146.BackColor = System.Drawing.Color.Transparent
        Appearance146.ForeColor = System.Drawing.Color.Navy
        Appearance146.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance146
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(204, 30)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(23, 14)
        Me.UltraLabel3.TabIndex = 279
        Me.UltraLabel3.Text = "Igv:"
        '
        'UltraLabel2
        '
        Appearance147.BackColor = System.Drawing.Color.Transparent
        Appearance147.ForeColor = System.Drawing.Color.Navy
        Appearance147.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance147
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(193, 54)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel2.TabIndex = 278
        Me.UltraLabel2.Text = "Total:"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(333, 249)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 299
        Me.ugb_Espera.Visible = False
        '
        'ficLiquidacion
        '
        Me.ficLiquidacion.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficLiquidacion.Controls.Add(Me.UltraTabPageControl6)
        Me.ficLiquidacion.Controls.Add(Me.UltraTabPageControl7)
        Me.ficLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficLiquidacion.Location = New System.Drawing.Point(0, 0)
        Me.ficLiquidacion.Name = "ficLiquidacion"
        Me.ficLiquidacion.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficLiquidacion.Size = New System.Drawing.Size(1060, 562)
        Me.ficLiquidacion.TabIndex = 3
        UltraTab9.TabPage = Me.UltraTabPageControl6
        UltraTab9.Text = "Viajes Cargas"
        UltraTab10.TabPage = Me.UltraTabPageControl7
        UltraTab10.Text = "Mantenimiento"
        Me.ficLiquidacion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab10})
        Me.ficLiquidacion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1058, 539)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'frm_Liquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 562)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficLiquidacion)
        Me.Name = "frm_Liquidaciones"
        Me.Text = "Liquidaciones"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griListaViajesAntiguos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.ogdLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl17.ResumeLayout(False)
        CType(Me.griTarifasSPSA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdViajesSPSA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griControlViajesSPSA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.griViajesSPSA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griViajesSinLiquidar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAgregar.ResumeLayout(False)
        CType(Me.ogdLiquidacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griViajesLiquidacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuQuitar.ResumeLayout(False)
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.griViajesSinLiquidarSPSA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdLiquidacionDetalleSPSA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.griViajesLiquidacionDetalleSPSA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.griViajesSinLiquidarTOTTUS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdLiquidacionDetalleTOTTUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl13.ResumeLayout(False)
        CType(Me.griViajesLiquidacionDetalleTOTTUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl14.ResumeLayout(False)
        CType(Me.griViajesSinLiquidarMAESTRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdLiquidacionDetalleMAESTRO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl15.ResumeLayout(False)
        CType(Me.griViajesLiquidacionDetalleMAESTRO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        Me.UltraTabPageControl8.PerformLayout()
        CType(Me.opcPlantilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.fecHastaViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesdeViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperacionesSinConfirmar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opcFormatoLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoTipoVehiculo.ResumeLayout(False)
        Me.grupoTipoVehiculo.PerformLayout()
        CType(Me.ColorDoctsPerdido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorSinConfirmar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorConDocts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorSinDocts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.griTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl16.ResumeLayout(False)
        CType(Me.griTarifasRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.tabListaLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabListaLiquidaciones.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.opcPlantillaLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        Me.UltraGroupBox11.PerformLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opcActualizarGuias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.tabDetalleLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetalleLiquidacion.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.tabAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdicional.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.fecLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficLiquidacion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficLiquidacion As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdLista As ISL.Controles.OrigenDatos
    Friend WithEvents griLista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents btnExpandido As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnN2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnN1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tabListaLiquidaciones As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaViajesAntiguos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cboCliente As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnEnviarCorreo As ISL.Controles.Boton
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabDetalleLiquidacion As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents cboClienteLiquidacion As ISL.Controles.ComboMaestros
    Friend WithEvents grupoTipoVehiculo As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents ColorDoctsPerdido As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents ColorSinConfirmar As ISL.Controles.Colores
    Friend WithEvents ColorConDocts As ISL.Controles.Colores
    Friend WithEvents ColorSinDocts As ISL.Controles.Colores
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents opcFormatoLiquidacion As ISL.Controles.Opciones
    Friend WithEvents txtObservacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTotal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtIgv As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtSubTotal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents btnViajesSinLiquidar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griViajesSinLiquidar As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ogdLiquidacionDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents txtIdLiquidacion As ISL.Controles.Texto
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecLiquidacion As ISL.Controles.Fecha
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents btnSeleccionaViajes As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ogdLiquidacion As ISL.Controles.OrigenDatos
    Friend WithEvents griLiquidacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griViajesLiquidacionDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Shadows WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Shadows WithEvents Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Enviar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorCambio As ISL.Controles.Colores
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents tabAdicional As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents griTarifas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ogdTarifas As ISL.Controles.OrigenDatos
    Friend WithEvents MenuAgregar As ISL.Controles.MenuContextual
    Friend WithEvents Agregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuQuitar As ISL.Controles.MenuContextual
    Friend WithEvents Quitar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtOperacionesSinConfirmar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFleteUnitario As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnActualizarFleteUnitario As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHastaViaje As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesdeViaje As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griViajesSinLiquidarSPSA As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griViajesSinLiquidarTOTTUS As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griViajesSinLiquidarMAESTRO As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ColorFormato2 As ISL.Controles.Colores
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFormato0 As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFormato1 As ISL.Controles.Colores
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFormato5 As ISL.Controles.Colores
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFormato3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFormato4 As ISL.Controles.Colores
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents cboCentro As ISL.Controles.Combo
    Friend WithEvents ogdLiquidacionDetalleSPSA As ISL.Controles.OrigenDatos
    Friend WithEvents ogdLiquidacionDetalleTOTTUS As ISL.Controles.OrigenDatos
    Friend WithEvents ogdLiquidacionDetalleMAESTRO As ISL.Controles.OrigenDatos
    Friend WithEvents btnActualizaDocumentosGuias As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents opcActualizarGuias As ISL.Controles.Opciones
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griTarifasRetorno As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griViajesLiquidacionDetalleSPSA As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griViajesLiquidacionDetalleTOTTUS As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griViajesLiquidacionDetalleMAESTRO As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents DivideLiquidacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdViajesSPSA As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griControlViajesSPSA As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griViajesSPSA As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griTarifasSPSA As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents ColorFormato7 As ISL.Controles.Colores
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFormato6 As ISL.Controles.Colores
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents opcPlantilla As ISL.Controles.Opciones
    Friend WithEvents opcPlantillaLista As ISL.Controles.Opciones
    Friend WithEvents Colores2 As ISL.Controles.Colores
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
End Class
