<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EstadoSituacionalVehiculo
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1597 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1598 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1599 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn1600 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1601 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn1602 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1603 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1604 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1605 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn1606 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1607 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1608 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1609 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1610 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1611 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1612 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn1613 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn1614 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn1615 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn1616 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn1617 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn1618 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn1619 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn1620 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn1621 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1622 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1623 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1624 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1625 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1626 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1627 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1628 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn1629 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn1630 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn1631 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn1632 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn1633 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn1634 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1635 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn1636 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2413 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2414 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2415 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2416 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2417 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2418 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDespacho")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaN")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MaterialCarga")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tonelada")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MNTO")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClienteGlosa")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Hora")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoGlosa")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Disponible")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ocurrencia")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCelular")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarcaVehiculo")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculoCarreta")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroMTC")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Brevete")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndMantenimiento")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroMTCCarreta")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoViajeProg")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTractoProg")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarretaProg")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPilotoProg")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopilotoProg")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigenProg")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestinoProg")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClienteProg")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFleteProg")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1637 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1638 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1639 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn1640 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1641 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn1642 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1643 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1644 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1645 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn1646 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1647 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1648 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1649 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1650 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1651 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1652 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn1653 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn1654 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn1655 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn1656 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn1657 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn1658 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn1659 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn1660 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn1661 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1662 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1663 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1664 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1665 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1666 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1667 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1668 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn1669 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn1670 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn1671 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn1672 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn1673 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn1674 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1675 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn1676 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2419 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2420 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2421 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2422 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2423 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2424 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1677 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1678 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1679 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn1680 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1681 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn1682 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1683 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1684 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1685 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn1686 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1687 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1688 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1689 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1690 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1691 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1692 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn1693 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn1694 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn1695 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn1696 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn1697 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn1698 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn1699 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn1700 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn1701 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1702 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1703 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1704 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1705 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1706 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1707 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1708 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn1709 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn1710 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn1711 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn1712 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn1713 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn1714 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1715 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn1716 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2425 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2426 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2427 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2428 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2429 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2430 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1717 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1718 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1719 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn1720 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1721 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn1722 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1723 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1724 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1725 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn1726 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1727 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1728 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1729 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1730 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1731 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1732 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn1733 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn1734 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn1735 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn1736 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn1737 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn1738 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn1739 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn1740 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn1741 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1742 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1743 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1744 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1745 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1746 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1747 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1748 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn1749 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn1750 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn1751 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn1752 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn1753 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn1754 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1755 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn1756 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2431 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2432 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2433 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2434 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2435 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2436 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1757 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1758 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1759 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn1760 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1761 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn1762 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1763 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1764 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1765 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn1766 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1767 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1768 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1769 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1770 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1771 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1772 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn1773 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn1774 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn1775 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn1776 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn1777 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn1778 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn1779 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn1780 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn1781 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1782 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1783 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1784 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1785 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1786 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1787 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1788 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn1789 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn1790 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn1791 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn1792 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn1793 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn1794 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1795 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn1796 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2437 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2438 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2439 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2440 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2441 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2442 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1797 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1798 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1799 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn1800 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1801 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn1802 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1803 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1804 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1805 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn1806 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1807 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1808 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1809 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1810 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1811 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1812 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn1813 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn1814 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn1815 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn1816 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn1817 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn1818 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn1819 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn1820 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn1821 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1822 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1823 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1824 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1825 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1826 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1827 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1828 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn1829 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn1830 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn1831 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn1832 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn1833 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn1834 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1835 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn1836 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2443 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2444 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2445 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2446 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2447 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2448 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1837 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1838 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1839 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn1840 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1841 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn1842 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1843 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1844 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1845 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn1846 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1847 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1848 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1849 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1850 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1851 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1852 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn1853 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn1854 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn1855 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn1856 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn1857 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn1858 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn1859 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn1860 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn1861 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1862 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1863 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1864 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1865 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1866 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1867 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1868 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn1869 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn1870 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn1871 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn1872 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn1873 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn1874 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1875 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn1876 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2449 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2450 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2451 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2452 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2453 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2454 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1877 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1878 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1879 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn1880 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1881 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn1882 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1883 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1884 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1885 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn1886 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1887 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1888 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1889 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1890 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1891 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1892 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn1893 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn1894 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn1895 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn1896 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn1897 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn1898 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn1899 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn1900 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn1901 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1902 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1903 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1904 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1905 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1906 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1907 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1908 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn1909 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn1910 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn1911 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn1912 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn1913 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn1914 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1915 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn1916 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2455 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2456 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2457 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2458 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2459 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2460 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1917 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1918 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1919 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn1920 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1921 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn1922 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1923 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1924 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1925 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn1926 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1927 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1928 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1929 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1930 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1931 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1932 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn1933 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn1934 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn1935 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn1936 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn1937 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn1938 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn1939 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn1940 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn1941 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1942 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1943 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1944 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1945 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1946 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1947 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1948 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn1949 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn1950 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn1951 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn1952 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn1953 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn1954 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1955 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn1956 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2461 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2462 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2463 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2464 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2465 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2466 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1957 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1958 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1959 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn1960 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1961 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn1962 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1963 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1964 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1965 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn1966 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1967 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1968 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1969 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1970 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1971 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1972 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn1973 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn1974 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn1975 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn1976 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn1977 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn1978 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn1979 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn1980 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn1981 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1982 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1983 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1984 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1985 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1986 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1987 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1988 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn1989 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn1990 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn1991 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn1992 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn1993 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn1994 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1995 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn1996 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2467 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2468 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2469 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2470 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2471 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2472 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1997 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1998 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1999 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn2000 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn2001 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn2002 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn2003 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn2004 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn2005 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn2006 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn2007 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn2008 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn2009 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn2010 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn2011 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn2012 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn2013 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn2014 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn2015 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn2016 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn2017 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn2018 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn2019 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn2020 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn2021 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn2022 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn2023 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn2024 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn2025 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn2026 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn2027 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn2028 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn2029 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn2030 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn2031 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn2032 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn2033 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn2034 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn2035 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn2036 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2037 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2038 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2039 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn2040 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn2041 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn2042 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn2043 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn2044 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn2045 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn2046 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn2047 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn2048 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn2049 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn2050 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn2051 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn2052 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn2053 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn2054 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn2055 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn2056 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn2057 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn2058 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn2059 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn2060 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn2061 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn2062 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn2063 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn2064 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn2065 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn2066 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn2067 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn2068 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn2069 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn2070 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn2071 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn2072 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn2073 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn2074 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn2075 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn2076 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2077 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2078 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2079 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn2080 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn2081 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn2082 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn2083 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn2084 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn2085 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn2086 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn2087 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn2088 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn2089 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn2090 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn2091 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn2092 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn2093 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn2094 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn2095 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn2096 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn2097 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn2098 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn2099 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn2100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn2101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn2102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn2103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn2104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn2105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn2106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn2107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn2108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn2109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn2110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn2111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn2112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn2113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn2114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn2115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn2116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn2120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn2121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn2122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn2123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn2124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn2125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn2126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn2127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn2128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn2129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn2130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn2131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn2132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn2133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn2134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn2135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn2136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn2137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn2138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn2139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn2140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn2141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn2142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn2143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn2144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn2145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn2146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn2147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn2148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn2149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn2150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn2151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn2152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn2153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn2154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn2155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn2156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn2160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn2161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn2162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn2163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn2164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn2165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn2166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn2167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn2168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn2169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn2170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn2171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn2172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn2173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn2174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn2175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn2176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn2177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn2178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn2179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn2180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn2181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn2182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn2183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn2184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn2185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn2186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn2187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn2188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn2189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn2190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn2191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn2192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn2193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn2194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn2195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn2196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraToolTipInfo12 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Producción a la que se quiere llegar", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo13 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Producción Programada hasta el momento", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand19 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn2200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn2201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn2202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn2203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn2204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn2205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn2206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn2207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn2208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn2209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn2210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn2211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn2212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn2213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim UltraGridColumn2214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn2215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn2216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn2217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn2218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn2219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn2220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn2221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn2222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn2223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn2224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn2225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn2226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn2227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn2228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn2229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn2230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn2231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn2232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn2233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn2234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn2235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn2236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2505 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2506 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2507 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2508 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand18 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDespacho")
        Dim UltraGridColumn2240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn2241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn2242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn2243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn2244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn2245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaN")
        Dim UltraGridColumn2246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn2247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn2248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn2249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn2250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn2251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn2252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialCarga")
        Dim UltraGridColumn2253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tonelada")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MNTO")
        Dim UltraGridColumn2255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteGlosa")
        Dim UltraGridColumn2257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn2258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoGlosa")
        Dim UltraGridColumn2259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Disponible")
        Dim UltraGridColumn2260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocurrencia")
        Dim UltraGridColumn2261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn2262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn2263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn2264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn2265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn2266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn2267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn2268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCelular")
        Dim UltraGridColumn2269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarcaVehiculo")
        Dim UltraGridColumn2270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculoCarreta")
        Dim UltraGridColumn2271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn2272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn2273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMantenimiento")
        Dim UltraGridColumn2274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn2275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTCCarreta")
        Dim UltraGridColumn2276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViajeProg")
        Dim UltraGridColumn2509 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTractoProg")
        Dim UltraGridColumn2510 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarretaProg")
        Dim UltraGridColumn2511 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPilotoProg")
        Dim UltraGridColumn2512 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopilotoProg")
        Dim UltraGridColumn2513 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProg")
        Dim UltraGridColumn2514 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestinoProg")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProg")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFleteProg")
        Dim UltraGridColumn2277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoAceptar", 0)
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand16 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn2319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn2320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn2322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn2323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn2324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn2325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn2326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn2327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn2328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn2329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn2330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn2332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn2333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn2334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn2335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn2336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn2338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn2339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn2340 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn2341 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn2342 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn2343 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn2344 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn2345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn2347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn2348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn2349 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn2350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn2351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn2352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn2353 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2354 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn2355 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn2356 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn2357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn2358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn2359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn2360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn2361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn2362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn2363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn2365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn2366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn2367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn2368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn2369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn2370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn2371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn2372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn2373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn2375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn2376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn2377 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn2378 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn2379 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn2380 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn2381 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn2382 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn2383 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn2384 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn2385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn2386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn2387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn2388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn2389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim UltraGridColumn2390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn2391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn2392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn2393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn2394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn2395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn2396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn2397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EstadoSituacionalVehiculo))
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoComplejoOrigen")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaOrigen")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoCargaOrigen")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImpresionGuiaOrigen")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaAproximadaDestino")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoDestino")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescargaDestino")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoDescargaDestino")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCarga")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Produccion")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPlanilla")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTercero")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione el lugar de origen de la demanda", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Estados Viaje", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Estados", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo9 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Trabajador / Vehiculos No Disponible", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo8 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("No Disponibles", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo6 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo7 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el copiloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand17 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Selec")
        Dim UltraGridColumn2399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD_VEHICULO")
        Dim UltraGridColumn2400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLACA_VEH")
        Dim UltraGridColumn2401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IND_MOTRIZ")
        Dim UltraGridColumn2402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TIPO_VEH")
        Dim UltraGridColumn2403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MARCA_VEH")
        Dim UltraGridColumn2404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ULT_FEC_OPER")
        Dim UltraGridColumn2405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ULT_DESTINO")
        Dim UltraGridColumn2406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOperacion")
        Dim UltraGridColumn2407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoMantenimiento")
        Dim UltraGridColumn2408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("REFERENCIA")
        Dim UltraGridColumn2409 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FECH_REF")
        Dim UltraGridColumn2410 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CAN_HOROMETRO")
        Dim UltraGridColumn2411 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn2412 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloFuncional")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Selec")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("COD_VEHICULO")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PLACA_VEH")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IND_MOTRIZ")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TIPO_VEH")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MARCA_VEH")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ULT_FEC_OPER")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ULT_DESTINO")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOperacion")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoMantenimiento")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("REFERENCIA")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FECH_REF")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CAN_HOROMETRO")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ModeloFuncional")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo11 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Estados Viaje", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo10 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Estados", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab37 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDespacho")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroMovil")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidad")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaN")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MaterialCarga")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tonelada")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MNTO")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClienteGlosa")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Hora")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoGlosa")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Disponible")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ocurrencia")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculoCarreta")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndMantenimiento")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoViajeProg")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTractoProg")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarretaProg")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPilotoProg")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopilotoProg")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn193 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn194 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn195 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn196 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn197 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn198 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn199 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn200 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn201 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn202 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn203 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn204 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn205 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn206 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn207 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn208 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn209 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn210 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn211 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn212 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn213 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn214 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn215 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn216 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn217 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn218 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn219 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn220 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn221 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn222 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn223 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn224 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn225 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn226 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn227 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn228 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn229 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn230 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn231 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn232 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn233 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn234 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn235 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn236 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn237 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn238 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn239 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn240 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn241 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn242 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn243 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn244 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoComplejoOrigen")
        Dim UltraDataColumn245 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaOrigen")
        Dim UltraDataColumn246 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoCargaOrigen")
        Dim UltraDataColumn247 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImpresionGuiaOrigen")
        Dim UltraDataColumn248 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaAproximadaDestino")
        Dim UltraDataColumn249 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoDestino")
        Dim UltraDataColumn250 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescargaDestino")
        Dim UltraDataColumn251 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoDescargaDestino")
        Dim UltraDataColumn252 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn253 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn254 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn255 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn256 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCarga")
        Dim UltraDataColumn257 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Produccion")
        Dim UltraDataColumn258 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn259 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn260 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn261 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPlanilla")
        Dim UltraDataColumn262 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn263 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn264 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn265 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn266 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn267 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProdReal")
        Dim UltraDataColumn268 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProdProgramado")
        Dim UltraDataColumn269 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProdTotal")
        Dim UltraDataColumn270 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn271 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn272 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn273 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn274 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn275 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn276 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn277 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraTab38 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab39 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab40 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.tap01 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab01 = New ISL.Controles.Grilla(Me.components)
        Me.udsDespachoOperaciones = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.tap02 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab02 = New ISL.Controles.Grilla(Me.components)
        Me.tap03 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab03 = New ISL.Controles.Grilla(Me.components)
        Me.tap04 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab04 = New ISL.Controles.Grilla(Me.components)
        Me.tap05 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab05 = New ISL.Controles.Grilla(Me.components)
        Me.tap06 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab06 = New ISL.Controles.Grilla(Me.components)
        Me.tap07 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab07 = New ISL.Controles.Grilla(Me.components)
        Me.tap08 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab08 = New ISL.Controles.Grilla(Me.components)
        Me.tap09 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab09 = New ISL.Controles.Grilla(Me.components)
        Me.tap10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab10 = New ISL.Controles.Grilla(Me.components)
        Me.tap11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab11 = New ISL.Controles.Grilla(Me.components)
        Me.tap12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab12 = New ISL.Controles.Grilla(Me.components)
        Me.tap13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab13 = New ISL.Controles.Grilla(Me.components)
        Me.tap14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab14 = New ISL.Controles.Grilla(Me.components)
        Me.tap15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTab15 = New ISL.Controles.Grilla(Me.components)
        Me.tapListadoDespacho = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.utcDespachosDinamicos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugbTotalesLista = New Infragistics.Win.Misc.UltraGroupBox()
        Me.unePorcentajeMeta = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.uneTotalViajes = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.uneTotalSinCopiloto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneProdUnidadFiltro = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.uneTotalSinPiloto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.uneProdTotalFiltro = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.uneProdRealFiltro = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboZonaListado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboEstadoFiltro = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCentroFiltro = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.dtpHastaFiltro = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDesdeFiltro = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.griFormatoClientes = New ISL.Controles.Grilla(Me.components)
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ColorParihuelero = New ISL.Controles.Colores(Me.components)
        Me.ColorPlataforma = New ISL.Controles.Colores(Me.components)
        Me.ColorBaranda = New ISL.Controles.Colores(Me.components)
        Me.ColorTolvaVolteo = New ISL.Controles.Colores(Me.components)
        Me.ColorGranelero = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgon = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgonLargo = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgonAmericano = New ISL.Controles.Colores(Me.components)
        Me.ColorCisterna = New ISL.Controles.Colores(Me.components)
        Me.ColorBomboma = New ISL.Controles.Colores(Me.components)
        Me.ColorCalicera = New ISL.Controles.Colores(Me.components)
        Me.ColorMediaBaranda = New ISL.Controles.Colores(Me.components)
        Me.Color30M3 = New System.Windows.Forms.Label()
        Me.Color20M3 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tapMantenimientoDespacho = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griDetalles = New ISL.Controles.Grilla(Me.components)
        Me.tspDespacho = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarDespacho = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarDespacho = New System.Windows.Forms.ToolStripButton()
        Me.ugbTotalesMantenimiento = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uneProdProg = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.uneProdReal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneProdTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ugbDespacho = New Infragistics.Win.Misc.UltraGroupBox()
        Me.colorColumnaEstado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorMantUrgente = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorCeldaResaltada = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorMant = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorCamposNoEncontrados = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtZonaEditar = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodigo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.expGenerarDesde = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.rbtNinguno = New System.Windows.Forms.RadioButton()
        Me.btnGenerarDesde = New Infragistics.Win.Misc.UltraButton()
        Me.rbtImportarExcel = New System.Windows.Forms.RadioButton()
        Me.rbtUltimoDespacho = New System.Windows.Forms.RadioButton()
        Me.rbtUltimosViajes = New System.Windows.Forms.RadioButton()
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.PlataformaM = New ISL.Controles.Colores(Me.components)
        Me.BarandaM = New ISL.Controles.Colores(Me.components)
        Me.TolvaVolteoM = New ISL.Controles.Colores(Me.components)
        Me.CisternaM = New ISL.Controles.Colores(Me.components)
        Me.BombomaM = New ISL.Controles.Colores(Me.components)
        Me.MediaBarandaM = New ISL.Controles.Colores(Me.components)
        Me.ParihueleroM = New ISL.Controles.Colores(Me.components)
        Me.GraneleroM = New ISL.Controles.Colores(Me.components)
        Me.FurgonLargoM = New ISL.Controles.Colores(Me.components)
        Me.FurgonAmericanoM = New ISL.Controles.Colores(Me.components)
        Me.CaliceraM = New ISL.Controles.Colores(Me.components)
        Me.FurgonM = New ISL.Controles.Colores(Me.components)
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.griDisponibleVehiculo = New ISL.Controles.Grilla(Me.components)
        Me.MenuOperacion = New ISL.Controles.MenuContextual(Me.components)
        Me.Programar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdDisponibleVehiculos = New ISL.Controles.OrigenDatos(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel8 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.lblListoRegistro = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboRutaOrigen = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraExpandableGroupBox5 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorParihueleroD = New ISL.Controles.Colores(Me.components)
        Me.ColorPlataformaD = New ISL.Controles.Colores(Me.components)
        Me.ColorCamion20M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTolvaVolteoD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion65M3D = New ISL.Controles.Colores(Me.components)
        Me.ColorContenedorD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta222 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorGraneleroD = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgonD = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgonLargoD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamionetaD = New ISL.Controles.Colores(Me.components)
        Me.ColorVolqueteD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion30M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCaliceraD = New ISL.Controles.Colores(Me.components)
        Me.ColorCamion40M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorMediaBarandaD = New ISL.Controles.Colores(Me.components)
        Me.exgruDisponibleNo = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ColorAdvertencia = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorPiloto = New ISL.Controles.Colores(Me.components)
        Me.ColorAyudante = New ISL.Controles.Colores(Me.components)
        Me.ColorCarreta = New ISL.Controles.Colores(Me.components)
        Me.ColorTracto = New ISL.Controles.Colores(Me.components)
        Me.ColorCopiloto = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboZonaDisponibles = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel59 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnConsultarDisponibles = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion12 = New ISL.Controles.Agrupacion(Me.components)
        Me.griVehiculoEstadoSituacional = New ISL.Controles.Grilla(Me.components)
        Me.ogdVehiculoEstadoSituacional = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel10 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ColorRuta = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorDisponible = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorMantenimiento = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboZonaVehiculo = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel61 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnConsultarVehiculo = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.utcDespacho = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ogdDespachoOperaciones = New ISL.Controles.OrigenDatos(Me.components)
        Me.ogdListaOperacion = New ISL.Controles.OrigenDatos(Me.components)
        Me.ogdDespacho = New ISL.Controles.OrigenDatos(Me.components)
        Me.cmsMenuListado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itemNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemEditarViaje = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemEjecutar = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemGenerarProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemFormatoClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemResumenDiario = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemIniciarDespacho = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemDesenlazarViaje = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.cmsMenuMantenimiento = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itemMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemMantUrgente = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemResaltarCeldas = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemResaltarEstado = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabDisponibilidad = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.tap01.SuspendLayout()
        CType(Me.griTab01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsDespachoOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap02.SuspendLayout()
        CType(Me.griTab02, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap03.SuspendLayout()
        CType(Me.griTab03, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap04.SuspendLayout()
        CType(Me.griTab04, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap05.SuspendLayout()
        CType(Me.griTab05, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap06.SuspendLayout()
        CType(Me.griTab06, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap07.SuspendLayout()
        CType(Me.griTab07, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap08.SuspendLayout()
        CType(Me.griTab08, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap09.SuspendLayout()
        CType(Me.griTab09, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap10.SuspendLayout()
        CType(Me.griTab10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap11.SuspendLayout()
        CType(Me.griTab11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap12.SuspendLayout()
        CType(Me.griTab12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap13.SuspendLayout()
        CType(Me.griTab13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap14.SuspendLayout()
        CType(Me.griTab14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tap15.SuspendLayout()
        CType(Me.griTab15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tapListadoDespacho.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.utcDespachosDinamicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcDespachosDinamicos.SuspendLayout()
        CType(Me.ugbTotalesLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbTotalesLista.SuspendLayout()
        CType(Me.unePorcentajeMeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneTotalViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneTotalSinCopiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneProdUnidadFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneTotalSinPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneProdTotalFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneProdRealFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.cboZonaListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentroFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griFormatoClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox3.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.ColorParihuelero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPlataforma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBaranda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTolvaVolteo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGranelero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgonLargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgonAmericano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCisterna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBomboma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCalicera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorMediaBaranda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tapMantenimientoDespacho.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.griDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspDespacho.SuspendLayout()
        CType(Me.ugbTotalesMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbTotalesMantenimiento.SuspendLayout()
        CType(Me.uneProdProg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneProdReal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneProdTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugbDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbDespacho.SuspendLayout()
        CType(Me.colorColumnaEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorMantUrgente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCeldaResaltada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorMant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCamposNoEncontrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZonaEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expGenerarDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expGenerarDesde.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox6.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout()
        CType(Me.PlataformaM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarandaM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TolvaVolteoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CisternaM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombomaM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaBarandaM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParihueleroM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraneleroM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FurgonLargoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FurgonAmericanoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaliceraM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FurgonM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.griDisponibleVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuOperacion.SuspendLayout()
        CType(Me.ogdDisponibleVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel8.SuspendLayout()
        CType(Me.cboRutaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox5.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.ColorParihueleroD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPlataformaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion20M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTolvaVolteoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion65M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorContenedorD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGraneleroD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgonD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgonLargoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamionetaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVolqueteD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion30M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCaliceraD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion40M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorMediaBarandaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruDisponibleNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruDisponibleNo.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.ColorAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAyudante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCopiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboZonaDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion12.SuspendLayout()
        CType(Me.griVehiculoEstadoSituacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdVehiculoEstadoSituacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox4.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel10.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.ColorRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboZonaVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.utcDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcDespacho.SuspendLayout()
        CType(Me.ogdDespachoOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdListaOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuListado.SuspendLayout()
        Me.cmsMenuMantenimiento.SuspendLayout()
        CType(Me.TabDisponibilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDisponibilidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'tap01
        '
        Me.tap01.Controls.Add(Me.griTab01)
        Me.tap01.Location = New System.Drawing.Point(1, 1)
        Me.tap01.Name = "tap01"
        Me.tap01.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab01
        '
        Me.griTab01.DataSource = Me.udsDespachoOperaciones
        Appearance1.BackColor = System.Drawing.Color.White
        Me.griTab01.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1597.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn1597.Header.VisiblePosition = 0
        UltraGridColumn1597.Hidden = True
        UltraGridColumn1598.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1598.Header.VisiblePosition = 1
        UltraGridColumn1598.Hidden = True
        UltraGridColumn1599.Header.VisiblePosition = 2
        UltraGridColumn1599.Hidden = True
        UltraGridColumn1600.Header.VisiblePosition = 3
        UltraGridColumn1601.Header.VisiblePosition = 4
        UltraGridColumn1601.Width = 228
        UltraGridColumn1602.Header.VisiblePosition = 5
        UltraGridColumn1602.Width = 220
        UltraGridColumn1603.Header.VisiblePosition = 8
        UltraGridColumn1604.Header.VisiblePosition = 9
        UltraGridColumn1604.Hidden = True
        UltraGridColumn1605.Header.VisiblePosition = 10
        UltraGridColumn1606.Header.VisiblePosition = 11
        UltraGridColumn1607.Header.VisiblePosition = 12
        UltraGridColumn1608.Header.VisiblePosition = 14
        UltraGridColumn1608.Width = 157
        UltraGridColumn1609.Header.VisiblePosition = 15
        UltraGridColumn1609.Width = 157
        UltraGridColumn1610.Header.VisiblePosition = 16
        UltraGridColumn1610.Width = 116
        UltraGridColumn1611.Header.VisiblePosition = 18
        UltraGridColumn1611.Width = 284
        UltraGridColumn1612.Header.VisiblePosition = 19
        UltraGridColumn1613.Header.VisiblePosition = 20
        UltraGridColumn1614.Header.VisiblePosition = 21
        UltraGridColumn1614.Width = 73
        UltraGridColumn1615.Header.VisiblePosition = 22
        UltraGridColumn1615.Width = 55
        UltraGridColumn1616.Header.VisiblePosition = 23
        UltraGridColumn1616.Width = 218
        UltraGridColumn1617.Header.VisiblePosition = 24
        UltraGridColumn1617.Width = 54
        UltraGridColumn1618.Header.VisiblePosition = 25
        UltraGridColumn1618.Width = 161
        UltraGridColumn1619.Header.VisiblePosition = 26
        UltraGridColumn1619.Width = 166
        UltraGridColumn1620.Header.VisiblePosition = 27
        UltraGridColumn1620.Hidden = True
        UltraGridColumn1621.Header.VisiblePosition = 28
        UltraGridColumn1621.Hidden = True
        UltraGridColumn1622.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1622.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1622.Header.VisiblePosition = 17
        UltraGridColumn1622.Width = 315
        UltraGridColumn1623.Header.VisiblePosition = 29
        UltraGridColumn1623.Hidden = True
        UltraGridColumn1624.Header.VisiblePosition = 30
        UltraGridColumn1624.Hidden = True
        UltraGridColumn1625.Header.VisiblePosition = 31
        UltraGridColumn1625.Hidden = True
        UltraGridColumn1626.Header.VisiblePosition = 32
        UltraGridColumn1626.Hidden = True
        UltraGridColumn1627.Header.VisiblePosition = 13
        UltraGridColumn1627.Hidden = True
        UltraGridColumn1628.Header.VisiblePosition = 6
        UltraGridColumn1628.Width = 88
        UltraGridColumn1629.Header.VisiblePosition = 7
        UltraGridColumn1629.Width = 106
        UltraGridColumn1630.Header.VisiblePosition = 33
        UltraGridColumn1631.Header.VisiblePosition = 34
        UltraGridColumn1632.Header.VisiblePosition = 35
        UltraGridColumn1633.Header.VisiblePosition = 36
        UltraGridColumn1634.Header.VisiblePosition = 37
        UltraGridColumn1635.Header.VisiblePosition = 38
        UltraGridColumn1636.Header.VisiblePosition = 39
        UltraGridColumn2413.Header.VisiblePosition = 40
        UltraGridColumn2414.Header.VisiblePosition = 41
        UltraGridColumn2415.Header.VisiblePosition = 42
        UltraGridColumn2416.Header.VisiblePosition = 43
        UltraGridColumn2417.Header.VisiblePosition = 44
        UltraGridColumn2418.Header.VisiblePosition = 45
        UltraGridColumn1.Header.VisiblePosition = 46
        UltraGridColumn19.Header.VisiblePosition = 47
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1597, UltraGridColumn1598, UltraGridColumn1599, UltraGridColumn1600, UltraGridColumn1601, UltraGridColumn1602, UltraGridColumn1603, UltraGridColumn1604, UltraGridColumn1605, UltraGridColumn1606, UltraGridColumn1607, UltraGridColumn1608, UltraGridColumn1609, UltraGridColumn1610, UltraGridColumn1611, UltraGridColumn1612, UltraGridColumn1613, UltraGridColumn1614, UltraGridColumn1615, UltraGridColumn1616, UltraGridColumn1617, UltraGridColumn1618, UltraGridColumn1619, UltraGridColumn1620, UltraGridColumn1621, UltraGridColumn1622, UltraGridColumn1623, UltraGridColumn1624, UltraGridColumn1625, UltraGridColumn1626, UltraGridColumn1627, UltraGridColumn1628, UltraGridColumn1629, UltraGridColumn1630, UltraGridColumn1631, UltraGridColumn1632, UltraGridColumn1633, UltraGridColumn1634, UltraGridColumn1635, UltraGridColumn1636, UltraGridColumn2413, UltraGridColumn2414, UltraGridColumn2415, UltraGridColumn2416, UltraGridColumn2417, UltraGridColumn2418, UltraGridColumn1, UltraGridColumn19})
        Me.griTab01.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griTab01.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab01.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab01.DisplayLayout.MaxRowScrollRegions = 1
        Me.griTab01.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab01.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab01.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab01.DisplayLayout.Override.CellPadding = 0
        Me.griTab01.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab01.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab01.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab01.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance2.TextHAlignAsString = "Left"
        Me.griTab01.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.griTab01.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab01.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance3.TextVAlignAsString = "Middle"
        Me.griTab01.DisplayLayout.Override.RowAppearance = Appearance3
        Me.griTab01.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab01.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab01.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab01.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab01.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab01.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab01.Location = New System.Drawing.Point(0, 0)
        Me.griTab01.Name = "griTab01"
        Me.griTab01.Size = New System.Drawing.Size(1072, 327)
        Me.griTab01.TabIndex = 7
        Me.griTab01.Tag = ""
        '
        'udsDespachoOperaciones
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn17.DataType = GetType(Double)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Date)
        UltraDataColumn28.DataType = GetType(Date)
        UltraDataColumn30.DataType = GetType(Date)
        UltraDataColumn31.DataType = GetType(Boolean)
        UltraDataColumn37.DataType = GetType(Boolean)
        UltraDataColumn48.DataType = GetType(Double)
        Me.udsDespachoOperaciones.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'tap02
        '
        Me.tap02.Controls.Add(Me.griTab02)
        Me.tap02.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap02.Name = "tap02"
        Me.tap02.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab02
        '
        Me.griTab02.DataSource = Me.udsDespachoOperaciones
        Appearance4.BackColor = System.Drawing.Color.White
        Me.griTab02.DisplayLayout.Appearance = Appearance4
        UltraGridColumn1637.Header.VisiblePosition = 0
        UltraGridColumn1637.Hidden = True
        UltraGridColumn1638.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1638.Header.VisiblePosition = 1
        UltraGridColumn1638.Hidden = True
        UltraGridColumn1639.Header.VisiblePosition = 2
        UltraGridColumn1639.Hidden = True
        UltraGridColumn1640.Header.VisiblePosition = 3
        UltraGridColumn1641.Header.VisiblePosition = 4
        UltraGridColumn1641.Width = 228
        UltraGridColumn1642.Header.VisiblePosition = 5
        UltraGridColumn1642.Width = 220
        UltraGridColumn1643.Header.VisiblePosition = 6
        UltraGridColumn1644.Header.VisiblePosition = 7
        UltraGridColumn1644.Hidden = True
        UltraGridColumn1645.Header.VisiblePosition = 8
        UltraGridColumn1646.Header.VisiblePosition = 9
        UltraGridColumn1647.Header.VisiblePosition = 10
        UltraGridColumn1648.Header.VisiblePosition = 12
        UltraGridColumn1648.Width = 157
        UltraGridColumn1649.Header.VisiblePosition = 13
        UltraGridColumn1649.Width = 157
        UltraGridColumn1650.Header.VisiblePosition = 14
        UltraGridColumn1650.Width = 116
        UltraGridColumn1651.Header.VisiblePosition = 16
        UltraGridColumn1651.Width = 284
        UltraGridColumn1652.Header.VisiblePosition = 17
        UltraGridColumn1653.Header.VisiblePosition = 18
        UltraGridColumn1654.Header.VisiblePosition = 19
        UltraGridColumn1655.Header.VisiblePosition = 20
        UltraGridColumn1656.Header.VisiblePosition = 21
        UltraGridColumn1656.Width = 218
        UltraGridColumn1657.Header.VisiblePosition = 22
        UltraGridColumn1657.Width = 80
        UltraGridColumn1658.Header.VisiblePosition = 23
        UltraGridColumn1658.Width = 161
        UltraGridColumn1659.Header.VisiblePosition = 24
        UltraGridColumn1659.Width = 166
        UltraGridColumn1660.Header.VisiblePosition = 25
        UltraGridColumn1660.Hidden = True
        UltraGridColumn1661.Header.VisiblePosition = 26
        UltraGridColumn1661.Hidden = True
        UltraGridColumn1662.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1662.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1662.Header.VisiblePosition = 15
        UltraGridColumn1662.Width = 315
        UltraGridColumn1663.Header.VisiblePosition = 27
        UltraGridColumn1663.Hidden = True
        UltraGridColumn1664.Header.VisiblePosition = 28
        UltraGridColumn1664.Hidden = True
        UltraGridColumn1665.Header.VisiblePosition = 29
        UltraGridColumn1665.Hidden = True
        UltraGridColumn1666.Header.VisiblePosition = 30
        UltraGridColumn1666.Hidden = True
        UltraGridColumn1667.Header.VisiblePosition = 11
        UltraGridColumn1667.Hidden = True
        UltraGridColumn1668.Header.VisiblePosition = 31
        UltraGridColumn1669.Header.VisiblePosition = 32
        UltraGridColumn1670.Header.VisiblePosition = 33
        UltraGridColumn1671.Header.VisiblePosition = 34
        UltraGridColumn1672.Header.VisiblePosition = 35
        UltraGridColumn1673.Header.VisiblePosition = 36
        UltraGridColumn1674.Header.VisiblePosition = 37
        UltraGridColumn1675.Header.VisiblePosition = 38
        UltraGridColumn1676.Header.VisiblePosition = 39
        UltraGridColumn2419.Header.VisiblePosition = 40
        UltraGridColumn2420.Header.VisiblePosition = 41
        UltraGridColumn2421.Header.VisiblePosition = 42
        UltraGridColumn2422.Header.VisiblePosition = 43
        UltraGridColumn2423.Header.VisiblePosition = 44
        UltraGridColumn2424.Header.VisiblePosition = 45
        UltraGridColumn2.Header.VisiblePosition = 46
        UltraGridColumn20.Header.VisiblePosition = 47
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn1637, UltraGridColumn1638, UltraGridColumn1639, UltraGridColumn1640, UltraGridColumn1641, UltraGridColumn1642, UltraGridColumn1643, UltraGridColumn1644, UltraGridColumn1645, UltraGridColumn1646, UltraGridColumn1647, UltraGridColumn1648, UltraGridColumn1649, UltraGridColumn1650, UltraGridColumn1651, UltraGridColumn1652, UltraGridColumn1653, UltraGridColumn1654, UltraGridColumn1655, UltraGridColumn1656, UltraGridColumn1657, UltraGridColumn1658, UltraGridColumn1659, UltraGridColumn1660, UltraGridColumn1661, UltraGridColumn1662, UltraGridColumn1663, UltraGridColumn1664, UltraGridColumn1665, UltraGridColumn1666, UltraGridColumn1667, UltraGridColumn1668, UltraGridColumn1669, UltraGridColumn1670, UltraGridColumn1671, UltraGridColumn1672, UltraGridColumn1673, UltraGridColumn1674, UltraGridColumn1675, UltraGridColumn1676, UltraGridColumn2419, UltraGridColumn2420, UltraGridColumn2421, UltraGridColumn2422, UltraGridColumn2423, UltraGridColumn2424, UltraGridColumn2, UltraGridColumn20})
        Me.griTab02.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griTab02.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab02.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab02.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab02.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab02.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab02.DisplayLayout.Override.CellPadding = 0
        Me.griTab02.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab02.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab02.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab02.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance5.TextHAlignAsString = "Left"
        Me.griTab02.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.griTab02.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab02.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance6.TextVAlignAsString = "Middle"
        Me.griTab02.DisplayLayout.Override.RowAppearance = Appearance6
        Me.griTab02.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab02.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab02.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab02.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab02.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab02.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab02.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab02.Location = New System.Drawing.Point(0, 0)
        Me.griTab02.Name = "griTab02"
        Me.griTab02.Size = New System.Drawing.Size(1072, 327)
        Me.griTab02.TabIndex = 8
        Me.griTab02.Tag = ""
        '
        'tap03
        '
        Me.tap03.Controls.Add(Me.griTab03)
        Me.tap03.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap03.Name = "tap03"
        Me.tap03.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab03
        '
        Me.griTab03.DataSource = Me.udsDespachoOperaciones
        Appearance7.BackColor = System.Drawing.Color.White
        Me.griTab03.DisplayLayout.Appearance = Appearance7
        UltraGridColumn1677.Header.VisiblePosition = 0
        UltraGridColumn1677.Hidden = True
        UltraGridColumn1678.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1678.Header.VisiblePosition = 1
        UltraGridColumn1678.Hidden = True
        UltraGridColumn1679.Header.VisiblePosition = 2
        UltraGridColumn1679.Hidden = True
        UltraGridColumn1680.Header.VisiblePosition = 3
        UltraGridColumn1681.Header.VisiblePosition = 4
        UltraGridColumn1681.Width = 228
        UltraGridColumn1682.Header.VisiblePosition = 5
        UltraGridColumn1682.Width = 220
        UltraGridColumn1683.Header.VisiblePosition = 6
        UltraGridColumn1684.Header.VisiblePosition = 7
        UltraGridColumn1684.Hidden = True
        UltraGridColumn1685.Header.VisiblePosition = 8
        UltraGridColumn1686.Header.VisiblePosition = 9
        UltraGridColumn1687.Header.VisiblePosition = 10
        UltraGridColumn1688.Header.VisiblePosition = 12
        UltraGridColumn1688.Width = 157
        UltraGridColumn1689.Header.VisiblePosition = 13
        UltraGridColumn1689.Width = 157
        UltraGridColumn1690.Header.VisiblePosition = 14
        UltraGridColumn1690.Width = 116
        UltraGridColumn1691.Header.VisiblePosition = 16
        UltraGridColumn1691.Width = 284
        UltraGridColumn1692.Header.VisiblePosition = 17
        UltraGridColumn1693.Header.VisiblePosition = 18
        UltraGridColumn1694.Header.VisiblePosition = 19
        UltraGridColumn1695.Header.VisiblePosition = 20
        UltraGridColumn1696.Header.VisiblePosition = 21
        UltraGridColumn1696.Width = 218
        UltraGridColumn1697.Header.VisiblePosition = 22
        UltraGridColumn1697.Width = 80
        UltraGridColumn1698.Header.VisiblePosition = 23
        UltraGridColumn1698.Width = 161
        UltraGridColumn1699.Header.VisiblePosition = 24
        UltraGridColumn1699.Width = 166
        UltraGridColumn1700.Header.VisiblePosition = 25
        UltraGridColumn1700.Hidden = True
        UltraGridColumn1701.Header.VisiblePosition = 26
        UltraGridColumn1701.Hidden = True
        UltraGridColumn1702.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1702.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1702.Header.VisiblePosition = 15
        UltraGridColumn1702.Width = 315
        UltraGridColumn1703.Header.VisiblePosition = 27
        UltraGridColumn1703.Hidden = True
        UltraGridColumn1704.Header.VisiblePosition = 28
        UltraGridColumn1704.Hidden = True
        UltraGridColumn1705.Header.VisiblePosition = 29
        UltraGridColumn1705.Hidden = True
        UltraGridColumn1706.Header.VisiblePosition = 30
        UltraGridColumn1706.Hidden = True
        UltraGridColumn1707.Header.VisiblePosition = 11
        UltraGridColumn1707.Hidden = True
        UltraGridColumn1708.Header.VisiblePosition = 31
        UltraGridColumn1709.Header.VisiblePosition = 32
        UltraGridColumn1710.Header.VisiblePosition = 33
        UltraGridColumn1711.Header.VisiblePosition = 34
        UltraGridColumn1712.Header.VisiblePosition = 35
        UltraGridColumn1713.Header.VisiblePosition = 36
        UltraGridColumn1714.Header.VisiblePosition = 37
        UltraGridColumn1715.Header.VisiblePosition = 38
        UltraGridColumn1716.Header.VisiblePosition = 39
        UltraGridColumn2425.Header.VisiblePosition = 40
        UltraGridColumn2426.Header.VisiblePosition = 41
        UltraGridColumn2427.Header.VisiblePosition = 42
        UltraGridColumn2428.Header.VisiblePosition = 43
        UltraGridColumn2429.Header.VisiblePosition = 44
        UltraGridColumn2430.Header.VisiblePosition = 45
        UltraGridColumn3.Header.VisiblePosition = 46
        UltraGridColumn21.Header.VisiblePosition = 47
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn1677, UltraGridColumn1678, UltraGridColumn1679, UltraGridColumn1680, UltraGridColumn1681, UltraGridColumn1682, UltraGridColumn1683, UltraGridColumn1684, UltraGridColumn1685, UltraGridColumn1686, UltraGridColumn1687, UltraGridColumn1688, UltraGridColumn1689, UltraGridColumn1690, UltraGridColumn1691, UltraGridColumn1692, UltraGridColumn1693, UltraGridColumn1694, UltraGridColumn1695, UltraGridColumn1696, UltraGridColumn1697, UltraGridColumn1698, UltraGridColumn1699, UltraGridColumn1700, UltraGridColumn1701, UltraGridColumn1702, UltraGridColumn1703, UltraGridColumn1704, UltraGridColumn1705, UltraGridColumn1706, UltraGridColumn1707, UltraGridColumn1708, UltraGridColumn1709, UltraGridColumn1710, UltraGridColumn1711, UltraGridColumn1712, UltraGridColumn1713, UltraGridColumn1714, UltraGridColumn1715, UltraGridColumn1716, UltraGridColumn2425, UltraGridColumn2426, UltraGridColumn2427, UltraGridColumn2428, UltraGridColumn2429, UltraGridColumn2430, UltraGridColumn3, UltraGridColumn21})
        Me.griTab03.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griTab03.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab03.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab03.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab03.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab03.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab03.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab03.DisplayLayout.Override.CellPadding = 0
        Me.griTab03.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab03.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab03.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab03.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance8.TextHAlignAsString = "Left"
        Me.griTab03.DisplayLayout.Override.HeaderAppearance = Appearance8
        Me.griTab03.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab03.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance9.TextVAlignAsString = "Middle"
        Me.griTab03.DisplayLayout.Override.RowAppearance = Appearance9
        Me.griTab03.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab03.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab03.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab03.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab03.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab03.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab03.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab03.Location = New System.Drawing.Point(0, 0)
        Me.griTab03.Name = "griTab03"
        Me.griTab03.Size = New System.Drawing.Size(1072, 327)
        Me.griTab03.TabIndex = 8
        Me.griTab03.Tag = ""
        '
        'tap04
        '
        Me.tap04.Controls.Add(Me.griTab04)
        Me.tap04.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap04.Name = "tap04"
        Me.tap04.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab04
        '
        Me.griTab04.DataSource = Me.udsDespachoOperaciones
        Appearance10.BackColor = System.Drawing.Color.White
        Me.griTab04.DisplayLayout.Appearance = Appearance10
        UltraGridColumn1717.Header.VisiblePosition = 0
        UltraGridColumn1717.Hidden = True
        UltraGridColumn1718.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1718.Header.VisiblePosition = 1
        UltraGridColumn1718.Hidden = True
        UltraGridColumn1719.Header.VisiblePosition = 2
        UltraGridColumn1719.Hidden = True
        UltraGridColumn1720.Header.VisiblePosition = 3
        UltraGridColumn1721.Header.VisiblePosition = 4
        UltraGridColumn1721.Width = 228
        UltraGridColumn1722.Header.VisiblePosition = 5
        UltraGridColumn1722.Width = 220
        UltraGridColumn1723.Header.VisiblePosition = 6
        UltraGridColumn1724.Header.VisiblePosition = 7
        UltraGridColumn1724.Hidden = True
        UltraGridColumn1725.Header.VisiblePosition = 8
        UltraGridColumn1726.Header.VisiblePosition = 9
        UltraGridColumn1727.Header.VisiblePosition = 10
        UltraGridColumn1728.Header.VisiblePosition = 12
        UltraGridColumn1728.Width = 157
        UltraGridColumn1729.Header.VisiblePosition = 13
        UltraGridColumn1729.Width = 157
        UltraGridColumn1730.Header.VisiblePosition = 14
        UltraGridColumn1730.Width = 116
        UltraGridColumn1731.Header.VisiblePosition = 16
        UltraGridColumn1731.Width = 284
        UltraGridColumn1732.Header.VisiblePosition = 17
        UltraGridColumn1733.Header.VisiblePosition = 18
        UltraGridColumn1734.Header.VisiblePosition = 19
        UltraGridColumn1735.Header.VisiblePosition = 20
        UltraGridColumn1736.Header.VisiblePosition = 21
        UltraGridColumn1736.Width = 218
        UltraGridColumn1737.Header.VisiblePosition = 22
        UltraGridColumn1737.Width = 80
        UltraGridColumn1738.Header.VisiblePosition = 23
        UltraGridColumn1738.Width = 161
        UltraGridColumn1739.Header.VisiblePosition = 24
        UltraGridColumn1739.Width = 166
        UltraGridColumn1740.Header.VisiblePosition = 25
        UltraGridColumn1740.Hidden = True
        UltraGridColumn1741.Header.VisiblePosition = 26
        UltraGridColumn1741.Hidden = True
        UltraGridColumn1742.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1742.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1742.Header.VisiblePosition = 15
        UltraGridColumn1742.Width = 315
        UltraGridColumn1743.Header.VisiblePosition = 27
        UltraGridColumn1743.Hidden = True
        UltraGridColumn1744.Header.VisiblePosition = 28
        UltraGridColumn1744.Hidden = True
        UltraGridColumn1745.Header.VisiblePosition = 29
        UltraGridColumn1745.Hidden = True
        UltraGridColumn1746.Header.VisiblePosition = 30
        UltraGridColumn1746.Hidden = True
        UltraGridColumn1747.Header.VisiblePosition = 11
        UltraGridColumn1747.Hidden = True
        UltraGridColumn1748.Header.VisiblePosition = 31
        UltraGridColumn1749.Header.VisiblePosition = 32
        UltraGridColumn1750.Header.VisiblePosition = 33
        UltraGridColumn1751.Header.VisiblePosition = 34
        UltraGridColumn1752.Header.VisiblePosition = 35
        UltraGridColumn1753.Header.VisiblePosition = 36
        UltraGridColumn1754.Header.VisiblePosition = 37
        UltraGridColumn1755.Header.VisiblePosition = 38
        UltraGridColumn1756.Header.VisiblePosition = 39
        UltraGridColumn2431.Header.VisiblePosition = 40
        UltraGridColumn2432.Header.VisiblePosition = 41
        UltraGridColumn2433.Header.VisiblePosition = 42
        UltraGridColumn2434.Header.VisiblePosition = 43
        UltraGridColumn2435.Header.VisiblePosition = 44
        UltraGridColumn2436.Header.VisiblePosition = 45
        UltraGridColumn4.Header.VisiblePosition = 46
        UltraGridColumn22.Header.VisiblePosition = 47
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn1717, UltraGridColumn1718, UltraGridColumn1719, UltraGridColumn1720, UltraGridColumn1721, UltraGridColumn1722, UltraGridColumn1723, UltraGridColumn1724, UltraGridColumn1725, UltraGridColumn1726, UltraGridColumn1727, UltraGridColumn1728, UltraGridColumn1729, UltraGridColumn1730, UltraGridColumn1731, UltraGridColumn1732, UltraGridColumn1733, UltraGridColumn1734, UltraGridColumn1735, UltraGridColumn1736, UltraGridColumn1737, UltraGridColumn1738, UltraGridColumn1739, UltraGridColumn1740, UltraGridColumn1741, UltraGridColumn1742, UltraGridColumn1743, UltraGridColumn1744, UltraGridColumn1745, UltraGridColumn1746, UltraGridColumn1747, UltraGridColumn1748, UltraGridColumn1749, UltraGridColumn1750, UltraGridColumn1751, UltraGridColumn1752, UltraGridColumn1753, UltraGridColumn1754, UltraGridColumn1755, UltraGridColumn1756, UltraGridColumn2431, UltraGridColumn2432, UltraGridColumn2433, UltraGridColumn2434, UltraGridColumn2435, UltraGridColumn2436, UltraGridColumn4, UltraGridColumn22})
        Me.griTab04.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griTab04.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab04.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab04.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab04.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab04.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab04.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab04.DisplayLayout.Override.CellPadding = 0
        Me.griTab04.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab04.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab04.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab04.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance11.TextHAlignAsString = "Left"
        Me.griTab04.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.griTab04.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab04.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance12.TextVAlignAsString = "Middle"
        Me.griTab04.DisplayLayout.Override.RowAppearance = Appearance12
        Me.griTab04.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab04.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab04.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab04.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab04.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab04.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab04.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab04.Location = New System.Drawing.Point(0, 0)
        Me.griTab04.Name = "griTab04"
        Me.griTab04.Size = New System.Drawing.Size(1072, 327)
        Me.griTab04.TabIndex = 8
        Me.griTab04.Tag = ""
        '
        'tap05
        '
        Me.tap05.Controls.Add(Me.griTab05)
        Me.tap05.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap05.Name = "tap05"
        Me.tap05.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab05
        '
        Me.griTab05.DataSource = Me.udsDespachoOperaciones
        Appearance13.BackColor = System.Drawing.Color.White
        Me.griTab05.DisplayLayout.Appearance = Appearance13
        UltraGridColumn1757.Header.VisiblePosition = 0
        UltraGridColumn1757.Hidden = True
        UltraGridColumn1758.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1758.Header.VisiblePosition = 1
        UltraGridColumn1758.Hidden = True
        UltraGridColumn1759.Header.VisiblePosition = 2
        UltraGridColumn1759.Hidden = True
        UltraGridColumn1760.Header.VisiblePosition = 3
        UltraGridColumn1761.Header.VisiblePosition = 4
        UltraGridColumn1761.Width = 228
        UltraGridColumn1762.Header.VisiblePosition = 5
        UltraGridColumn1762.Width = 220
        UltraGridColumn1763.Header.VisiblePosition = 6
        UltraGridColumn1764.Header.VisiblePosition = 7
        UltraGridColumn1764.Hidden = True
        UltraGridColumn1765.Header.VisiblePosition = 8
        UltraGridColumn1766.Header.VisiblePosition = 9
        UltraGridColumn1767.Header.VisiblePosition = 10
        UltraGridColumn1768.Header.VisiblePosition = 12
        UltraGridColumn1768.Width = 157
        UltraGridColumn1769.Header.VisiblePosition = 13
        UltraGridColumn1769.Width = 157
        UltraGridColumn1770.Header.VisiblePosition = 14
        UltraGridColumn1770.Width = 116
        UltraGridColumn1771.Header.VisiblePosition = 16
        UltraGridColumn1771.Width = 284
        UltraGridColumn1772.Header.VisiblePosition = 17
        UltraGridColumn1773.Header.VisiblePosition = 18
        UltraGridColumn1774.Header.VisiblePosition = 19
        UltraGridColumn1775.Header.VisiblePosition = 20
        UltraGridColumn1776.Header.VisiblePosition = 21
        UltraGridColumn1776.Width = 218
        UltraGridColumn1777.Header.VisiblePosition = 22
        UltraGridColumn1777.Width = 80
        UltraGridColumn1778.Header.VisiblePosition = 23
        UltraGridColumn1778.Width = 161
        UltraGridColumn1779.Header.VisiblePosition = 24
        UltraGridColumn1779.Width = 166
        UltraGridColumn1780.Header.VisiblePosition = 25
        UltraGridColumn1780.Hidden = True
        UltraGridColumn1781.Header.VisiblePosition = 26
        UltraGridColumn1781.Hidden = True
        UltraGridColumn1782.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1782.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1782.Header.VisiblePosition = 15
        UltraGridColumn1782.Width = 315
        UltraGridColumn1783.Header.VisiblePosition = 27
        UltraGridColumn1783.Hidden = True
        UltraGridColumn1784.Header.VisiblePosition = 28
        UltraGridColumn1784.Hidden = True
        UltraGridColumn1785.Header.VisiblePosition = 29
        UltraGridColumn1785.Hidden = True
        UltraGridColumn1786.Header.VisiblePosition = 30
        UltraGridColumn1786.Hidden = True
        UltraGridColumn1787.Header.VisiblePosition = 11
        UltraGridColumn1787.Hidden = True
        UltraGridColumn1788.Header.VisiblePosition = 31
        UltraGridColumn1789.Header.VisiblePosition = 32
        UltraGridColumn1790.Header.VisiblePosition = 33
        UltraGridColumn1791.Header.VisiblePosition = 34
        UltraGridColumn1792.Header.VisiblePosition = 35
        UltraGridColumn1793.Header.VisiblePosition = 36
        UltraGridColumn1794.Header.VisiblePosition = 37
        UltraGridColumn1795.Header.VisiblePosition = 38
        UltraGridColumn1796.Header.VisiblePosition = 39
        UltraGridColumn2437.Header.VisiblePosition = 40
        UltraGridColumn2438.Header.VisiblePosition = 41
        UltraGridColumn2439.Header.VisiblePosition = 42
        UltraGridColumn2440.Header.VisiblePosition = 43
        UltraGridColumn2441.Header.VisiblePosition = 44
        UltraGridColumn2442.Header.VisiblePosition = 45
        UltraGridColumn5.Header.VisiblePosition = 46
        UltraGridColumn23.Header.VisiblePosition = 47
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn1757, UltraGridColumn1758, UltraGridColumn1759, UltraGridColumn1760, UltraGridColumn1761, UltraGridColumn1762, UltraGridColumn1763, UltraGridColumn1764, UltraGridColumn1765, UltraGridColumn1766, UltraGridColumn1767, UltraGridColumn1768, UltraGridColumn1769, UltraGridColumn1770, UltraGridColumn1771, UltraGridColumn1772, UltraGridColumn1773, UltraGridColumn1774, UltraGridColumn1775, UltraGridColumn1776, UltraGridColumn1777, UltraGridColumn1778, UltraGridColumn1779, UltraGridColumn1780, UltraGridColumn1781, UltraGridColumn1782, UltraGridColumn1783, UltraGridColumn1784, UltraGridColumn1785, UltraGridColumn1786, UltraGridColumn1787, UltraGridColumn1788, UltraGridColumn1789, UltraGridColumn1790, UltraGridColumn1791, UltraGridColumn1792, UltraGridColumn1793, UltraGridColumn1794, UltraGridColumn1795, UltraGridColumn1796, UltraGridColumn2437, UltraGridColumn2438, UltraGridColumn2439, UltraGridColumn2440, UltraGridColumn2441, UltraGridColumn2442, UltraGridColumn5, UltraGridColumn23})
        Me.griTab05.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griTab05.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab05.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab05.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab05.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab05.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab05.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab05.DisplayLayout.Override.CellPadding = 0
        Me.griTab05.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab05.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab05.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab05.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance14.TextHAlignAsString = "Left"
        Me.griTab05.DisplayLayout.Override.HeaderAppearance = Appearance14
        Me.griTab05.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab05.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance15.TextVAlignAsString = "Middle"
        Me.griTab05.DisplayLayout.Override.RowAppearance = Appearance15
        Me.griTab05.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab05.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab05.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab05.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab05.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab05.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab05.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab05.Location = New System.Drawing.Point(0, 0)
        Me.griTab05.Name = "griTab05"
        Me.griTab05.Size = New System.Drawing.Size(1072, 327)
        Me.griTab05.TabIndex = 8
        Me.griTab05.Tag = ""
        '
        'tap06
        '
        Me.tap06.Controls.Add(Me.griTab06)
        Me.tap06.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap06.Name = "tap06"
        Me.tap06.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab06
        '
        Me.griTab06.DataSource = Me.udsDespachoOperaciones
        Appearance16.BackColor = System.Drawing.Color.White
        Me.griTab06.DisplayLayout.Appearance = Appearance16
        UltraGridColumn1797.Header.VisiblePosition = 0
        UltraGridColumn1797.Hidden = True
        UltraGridColumn1798.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1798.Header.VisiblePosition = 1
        UltraGridColumn1798.Hidden = True
        UltraGridColumn1799.Header.VisiblePosition = 2
        UltraGridColumn1799.Hidden = True
        UltraGridColumn1800.Header.VisiblePosition = 3
        UltraGridColumn1801.Header.VisiblePosition = 4
        UltraGridColumn1801.Width = 228
        UltraGridColumn1802.Header.VisiblePosition = 5
        UltraGridColumn1802.Width = 220
        UltraGridColumn1803.Header.VisiblePosition = 6
        UltraGridColumn1804.Header.VisiblePosition = 7
        UltraGridColumn1804.Hidden = True
        UltraGridColumn1805.Header.VisiblePosition = 8
        UltraGridColumn1806.Header.VisiblePosition = 9
        UltraGridColumn1807.Header.VisiblePosition = 10
        UltraGridColumn1808.Header.VisiblePosition = 12
        UltraGridColumn1808.Width = 157
        UltraGridColumn1809.Header.VisiblePosition = 13
        UltraGridColumn1809.Width = 157
        UltraGridColumn1810.Header.VisiblePosition = 14
        UltraGridColumn1810.Width = 116
        UltraGridColumn1811.Header.VisiblePosition = 16
        UltraGridColumn1811.Width = 284
        UltraGridColumn1812.Header.VisiblePosition = 17
        UltraGridColumn1813.Header.VisiblePosition = 18
        UltraGridColumn1814.Header.VisiblePosition = 19
        UltraGridColumn1815.Header.VisiblePosition = 20
        UltraGridColumn1816.Header.VisiblePosition = 21
        UltraGridColumn1816.Width = 218
        UltraGridColumn1817.Header.VisiblePosition = 22
        UltraGridColumn1817.Width = 80
        UltraGridColumn1818.Header.VisiblePosition = 23
        UltraGridColumn1818.Width = 161
        UltraGridColumn1819.Header.VisiblePosition = 24
        UltraGridColumn1819.Width = 166
        UltraGridColumn1820.Header.VisiblePosition = 25
        UltraGridColumn1820.Hidden = True
        UltraGridColumn1821.Header.VisiblePosition = 26
        UltraGridColumn1821.Hidden = True
        UltraGridColumn1822.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1822.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1822.Header.VisiblePosition = 15
        UltraGridColumn1822.Width = 315
        UltraGridColumn1823.Header.VisiblePosition = 27
        UltraGridColumn1823.Hidden = True
        UltraGridColumn1824.Header.VisiblePosition = 28
        UltraGridColumn1824.Hidden = True
        UltraGridColumn1825.Header.VisiblePosition = 29
        UltraGridColumn1825.Hidden = True
        UltraGridColumn1826.Header.VisiblePosition = 30
        UltraGridColumn1826.Hidden = True
        UltraGridColumn1827.Header.VisiblePosition = 11
        UltraGridColumn1827.Hidden = True
        UltraGridColumn1828.Header.VisiblePosition = 31
        UltraGridColumn1829.Header.VisiblePosition = 32
        UltraGridColumn1830.Header.VisiblePosition = 33
        UltraGridColumn1831.Header.VisiblePosition = 34
        UltraGridColumn1832.Header.VisiblePosition = 35
        UltraGridColumn1833.Header.VisiblePosition = 36
        UltraGridColumn1834.Header.VisiblePosition = 37
        UltraGridColumn1835.Header.VisiblePosition = 38
        UltraGridColumn1836.Header.VisiblePosition = 39
        UltraGridColumn2443.Header.VisiblePosition = 40
        UltraGridColumn2444.Header.VisiblePosition = 41
        UltraGridColumn2445.Header.VisiblePosition = 42
        UltraGridColumn2446.Header.VisiblePosition = 43
        UltraGridColumn2447.Header.VisiblePosition = 44
        UltraGridColumn2448.Header.VisiblePosition = 45
        UltraGridColumn6.Header.VisiblePosition = 46
        UltraGridColumn24.Header.VisiblePosition = 47
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn1797, UltraGridColumn1798, UltraGridColumn1799, UltraGridColumn1800, UltraGridColumn1801, UltraGridColumn1802, UltraGridColumn1803, UltraGridColumn1804, UltraGridColumn1805, UltraGridColumn1806, UltraGridColumn1807, UltraGridColumn1808, UltraGridColumn1809, UltraGridColumn1810, UltraGridColumn1811, UltraGridColumn1812, UltraGridColumn1813, UltraGridColumn1814, UltraGridColumn1815, UltraGridColumn1816, UltraGridColumn1817, UltraGridColumn1818, UltraGridColumn1819, UltraGridColumn1820, UltraGridColumn1821, UltraGridColumn1822, UltraGridColumn1823, UltraGridColumn1824, UltraGridColumn1825, UltraGridColumn1826, UltraGridColumn1827, UltraGridColumn1828, UltraGridColumn1829, UltraGridColumn1830, UltraGridColumn1831, UltraGridColumn1832, UltraGridColumn1833, UltraGridColumn1834, UltraGridColumn1835, UltraGridColumn1836, UltraGridColumn2443, UltraGridColumn2444, UltraGridColumn2445, UltraGridColumn2446, UltraGridColumn2447, UltraGridColumn2448, UltraGridColumn6, UltraGridColumn24})
        Me.griTab06.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griTab06.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab06.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab06.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab06.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab06.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab06.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab06.DisplayLayout.Override.CellPadding = 0
        Me.griTab06.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab06.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab06.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab06.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance17.TextHAlignAsString = "Left"
        Me.griTab06.DisplayLayout.Override.HeaderAppearance = Appearance17
        Me.griTab06.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab06.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance18.TextVAlignAsString = "Middle"
        Me.griTab06.DisplayLayout.Override.RowAppearance = Appearance18
        Me.griTab06.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab06.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab06.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab06.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab06.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab06.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab06.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab06.Location = New System.Drawing.Point(0, 0)
        Me.griTab06.Name = "griTab06"
        Me.griTab06.Size = New System.Drawing.Size(1072, 327)
        Me.griTab06.TabIndex = 8
        Me.griTab06.Tag = ""
        '
        'tap07
        '
        Me.tap07.Controls.Add(Me.griTab07)
        Me.tap07.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap07.Name = "tap07"
        Me.tap07.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab07
        '
        Me.griTab07.DataSource = Me.udsDespachoOperaciones
        Appearance19.BackColor = System.Drawing.Color.White
        Me.griTab07.DisplayLayout.Appearance = Appearance19
        UltraGridColumn1837.Header.VisiblePosition = 0
        UltraGridColumn1837.Hidden = True
        UltraGridColumn1838.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1838.Header.VisiblePosition = 1
        UltraGridColumn1838.Hidden = True
        UltraGridColumn1839.Header.VisiblePosition = 2
        UltraGridColumn1839.Hidden = True
        UltraGridColumn1840.Header.VisiblePosition = 3
        UltraGridColumn1841.Header.VisiblePosition = 4
        UltraGridColumn1841.Width = 228
        UltraGridColumn1842.Header.VisiblePosition = 5
        UltraGridColumn1842.Width = 220
        UltraGridColumn1843.Header.VisiblePosition = 6
        UltraGridColumn1844.Header.VisiblePosition = 7
        UltraGridColumn1844.Hidden = True
        UltraGridColumn1845.Header.VisiblePosition = 8
        UltraGridColumn1846.Header.VisiblePosition = 9
        UltraGridColumn1847.Header.VisiblePosition = 10
        UltraGridColumn1848.Header.VisiblePosition = 12
        UltraGridColumn1848.Width = 157
        UltraGridColumn1849.Header.VisiblePosition = 13
        UltraGridColumn1849.Width = 157
        UltraGridColumn1850.Header.VisiblePosition = 14
        UltraGridColumn1850.Width = 116
        UltraGridColumn1851.Header.VisiblePosition = 16
        UltraGridColumn1851.Width = 284
        UltraGridColumn1852.Header.VisiblePosition = 17
        UltraGridColumn1853.Header.VisiblePosition = 18
        UltraGridColumn1854.Header.VisiblePosition = 19
        UltraGridColumn1855.Header.VisiblePosition = 20
        UltraGridColumn1856.Header.VisiblePosition = 21
        UltraGridColumn1856.Width = 218
        UltraGridColumn1857.Header.VisiblePosition = 22
        UltraGridColumn1857.Width = 80
        UltraGridColumn1858.Header.VisiblePosition = 23
        UltraGridColumn1858.Width = 161
        UltraGridColumn1859.Header.VisiblePosition = 24
        UltraGridColumn1859.Width = 166
        UltraGridColumn1860.Header.VisiblePosition = 25
        UltraGridColumn1860.Hidden = True
        UltraGridColumn1861.Header.VisiblePosition = 26
        UltraGridColumn1861.Hidden = True
        UltraGridColumn1862.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1862.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1862.Header.VisiblePosition = 15
        UltraGridColumn1862.Width = 315
        UltraGridColumn1863.Header.VisiblePosition = 27
        UltraGridColumn1863.Hidden = True
        UltraGridColumn1864.Header.VisiblePosition = 28
        UltraGridColumn1864.Hidden = True
        UltraGridColumn1865.Header.VisiblePosition = 29
        UltraGridColumn1865.Hidden = True
        UltraGridColumn1866.Header.VisiblePosition = 30
        UltraGridColumn1866.Hidden = True
        UltraGridColumn1867.Header.VisiblePosition = 11
        UltraGridColumn1867.Hidden = True
        UltraGridColumn1868.Header.VisiblePosition = 31
        UltraGridColumn1869.Header.VisiblePosition = 32
        UltraGridColumn1870.Header.VisiblePosition = 33
        UltraGridColumn1871.Header.VisiblePosition = 34
        UltraGridColumn1872.Header.VisiblePosition = 35
        UltraGridColumn1873.Header.VisiblePosition = 36
        UltraGridColumn1874.Header.VisiblePosition = 37
        UltraGridColumn1875.Header.VisiblePosition = 38
        UltraGridColumn1876.Header.VisiblePosition = 39
        UltraGridColumn2449.Header.VisiblePosition = 40
        UltraGridColumn2450.Header.VisiblePosition = 41
        UltraGridColumn2451.Header.VisiblePosition = 42
        UltraGridColumn2452.Header.VisiblePosition = 43
        UltraGridColumn2453.Header.VisiblePosition = 44
        UltraGridColumn2454.Header.VisiblePosition = 45
        UltraGridColumn7.Header.VisiblePosition = 46
        UltraGridColumn25.Header.VisiblePosition = 47
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn1837, UltraGridColumn1838, UltraGridColumn1839, UltraGridColumn1840, UltraGridColumn1841, UltraGridColumn1842, UltraGridColumn1843, UltraGridColumn1844, UltraGridColumn1845, UltraGridColumn1846, UltraGridColumn1847, UltraGridColumn1848, UltraGridColumn1849, UltraGridColumn1850, UltraGridColumn1851, UltraGridColumn1852, UltraGridColumn1853, UltraGridColumn1854, UltraGridColumn1855, UltraGridColumn1856, UltraGridColumn1857, UltraGridColumn1858, UltraGridColumn1859, UltraGridColumn1860, UltraGridColumn1861, UltraGridColumn1862, UltraGridColumn1863, UltraGridColumn1864, UltraGridColumn1865, UltraGridColumn1866, UltraGridColumn1867, UltraGridColumn1868, UltraGridColumn1869, UltraGridColumn1870, UltraGridColumn1871, UltraGridColumn1872, UltraGridColumn1873, UltraGridColumn1874, UltraGridColumn1875, UltraGridColumn1876, UltraGridColumn2449, UltraGridColumn2450, UltraGridColumn2451, UltraGridColumn2452, UltraGridColumn2453, UltraGridColumn2454, UltraGridColumn7, UltraGridColumn25})
        Me.griTab07.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griTab07.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab07.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab07.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab07.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab07.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab07.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab07.DisplayLayout.Override.CellPadding = 0
        Me.griTab07.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab07.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab07.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab07.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance20.TextHAlignAsString = "Left"
        Me.griTab07.DisplayLayout.Override.HeaderAppearance = Appearance20
        Me.griTab07.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab07.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance21.TextVAlignAsString = "Middle"
        Me.griTab07.DisplayLayout.Override.RowAppearance = Appearance21
        Me.griTab07.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab07.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab07.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab07.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab07.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab07.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab07.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab07.Location = New System.Drawing.Point(0, 0)
        Me.griTab07.Name = "griTab07"
        Me.griTab07.Size = New System.Drawing.Size(1072, 327)
        Me.griTab07.TabIndex = 8
        Me.griTab07.Tag = ""
        '
        'tap08
        '
        Me.tap08.Controls.Add(Me.griTab08)
        Me.tap08.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap08.Name = "tap08"
        Me.tap08.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab08
        '
        Me.griTab08.DataSource = Me.udsDespachoOperaciones
        Appearance22.BackColor = System.Drawing.Color.White
        Me.griTab08.DisplayLayout.Appearance = Appearance22
        UltraGridColumn1877.Header.VisiblePosition = 0
        UltraGridColumn1877.Hidden = True
        UltraGridColumn1878.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1878.Header.VisiblePosition = 1
        UltraGridColumn1878.Hidden = True
        UltraGridColumn1879.Header.VisiblePosition = 2
        UltraGridColumn1879.Hidden = True
        UltraGridColumn1880.Header.VisiblePosition = 3
        UltraGridColumn1881.Header.VisiblePosition = 4
        UltraGridColumn1881.Width = 228
        UltraGridColumn1882.Header.VisiblePosition = 5
        UltraGridColumn1882.Width = 220
        UltraGridColumn1883.Header.VisiblePosition = 6
        UltraGridColumn1884.Header.VisiblePosition = 7
        UltraGridColumn1884.Hidden = True
        UltraGridColumn1885.Header.VisiblePosition = 8
        UltraGridColumn1886.Header.VisiblePosition = 9
        UltraGridColumn1887.Header.VisiblePosition = 10
        UltraGridColumn1888.Header.VisiblePosition = 12
        UltraGridColumn1888.Width = 157
        UltraGridColumn1889.Header.VisiblePosition = 13
        UltraGridColumn1889.Width = 157
        UltraGridColumn1890.Header.VisiblePosition = 14
        UltraGridColumn1890.Width = 116
        UltraGridColumn1891.Header.VisiblePosition = 16
        UltraGridColumn1891.Width = 284
        UltraGridColumn1892.Header.VisiblePosition = 17
        UltraGridColumn1893.Header.VisiblePosition = 18
        UltraGridColumn1894.Header.VisiblePosition = 19
        UltraGridColumn1895.Header.VisiblePosition = 20
        UltraGridColumn1896.Header.VisiblePosition = 21
        UltraGridColumn1896.Width = 218
        UltraGridColumn1897.Header.VisiblePosition = 22
        UltraGridColumn1897.Width = 80
        UltraGridColumn1898.Header.VisiblePosition = 23
        UltraGridColumn1898.Width = 161
        UltraGridColumn1899.Header.VisiblePosition = 24
        UltraGridColumn1899.Width = 166
        UltraGridColumn1900.Header.VisiblePosition = 25
        UltraGridColumn1900.Hidden = True
        UltraGridColumn1901.Header.VisiblePosition = 26
        UltraGridColumn1901.Hidden = True
        UltraGridColumn1902.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1902.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1902.Header.VisiblePosition = 15
        UltraGridColumn1902.Width = 315
        UltraGridColumn1903.Header.VisiblePosition = 27
        UltraGridColumn1903.Hidden = True
        UltraGridColumn1904.Header.VisiblePosition = 28
        UltraGridColumn1904.Hidden = True
        UltraGridColumn1905.Header.VisiblePosition = 29
        UltraGridColumn1905.Hidden = True
        UltraGridColumn1906.Header.VisiblePosition = 30
        UltraGridColumn1906.Hidden = True
        UltraGridColumn1907.Header.VisiblePosition = 11
        UltraGridColumn1907.Hidden = True
        UltraGridColumn1908.Header.VisiblePosition = 31
        UltraGridColumn1909.Header.VisiblePosition = 32
        UltraGridColumn1910.Header.VisiblePosition = 33
        UltraGridColumn1911.Header.VisiblePosition = 34
        UltraGridColumn1912.Header.VisiblePosition = 35
        UltraGridColumn1913.Header.VisiblePosition = 36
        UltraGridColumn1914.Header.VisiblePosition = 37
        UltraGridColumn1915.Header.VisiblePosition = 38
        UltraGridColumn1916.Header.VisiblePosition = 39
        UltraGridColumn2455.Header.VisiblePosition = 40
        UltraGridColumn2456.Header.VisiblePosition = 41
        UltraGridColumn2457.Header.VisiblePosition = 42
        UltraGridColumn2458.Header.VisiblePosition = 43
        UltraGridColumn2459.Header.VisiblePosition = 44
        UltraGridColumn2460.Header.VisiblePosition = 45
        UltraGridColumn8.Header.VisiblePosition = 46
        UltraGridColumn26.Header.VisiblePosition = 47
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn1877, UltraGridColumn1878, UltraGridColumn1879, UltraGridColumn1880, UltraGridColumn1881, UltraGridColumn1882, UltraGridColumn1883, UltraGridColumn1884, UltraGridColumn1885, UltraGridColumn1886, UltraGridColumn1887, UltraGridColumn1888, UltraGridColumn1889, UltraGridColumn1890, UltraGridColumn1891, UltraGridColumn1892, UltraGridColumn1893, UltraGridColumn1894, UltraGridColumn1895, UltraGridColumn1896, UltraGridColumn1897, UltraGridColumn1898, UltraGridColumn1899, UltraGridColumn1900, UltraGridColumn1901, UltraGridColumn1902, UltraGridColumn1903, UltraGridColumn1904, UltraGridColumn1905, UltraGridColumn1906, UltraGridColumn1907, UltraGridColumn1908, UltraGridColumn1909, UltraGridColumn1910, UltraGridColumn1911, UltraGridColumn1912, UltraGridColumn1913, UltraGridColumn1914, UltraGridColumn1915, UltraGridColumn1916, UltraGridColumn2455, UltraGridColumn2456, UltraGridColumn2457, UltraGridColumn2458, UltraGridColumn2459, UltraGridColumn2460, UltraGridColumn8, UltraGridColumn26})
        Me.griTab08.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griTab08.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab08.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab08.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab08.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab08.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab08.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab08.DisplayLayout.Override.CellPadding = 0
        Me.griTab08.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab08.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab08.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab08.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance23.TextHAlignAsString = "Left"
        Me.griTab08.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.griTab08.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab08.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance24.TextVAlignAsString = "Middle"
        Me.griTab08.DisplayLayout.Override.RowAppearance = Appearance24
        Me.griTab08.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab08.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab08.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab08.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab08.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab08.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab08.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab08.Location = New System.Drawing.Point(0, 0)
        Me.griTab08.Name = "griTab08"
        Me.griTab08.Size = New System.Drawing.Size(1072, 327)
        Me.griTab08.TabIndex = 8
        Me.griTab08.Tag = ""
        '
        'tap09
        '
        Me.tap09.Controls.Add(Me.griTab09)
        Me.tap09.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap09.Name = "tap09"
        Me.tap09.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab09
        '
        Me.griTab09.DataSource = Me.udsDespachoOperaciones
        Appearance25.BackColor = System.Drawing.Color.White
        Me.griTab09.DisplayLayout.Appearance = Appearance25
        UltraGridColumn1917.Header.VisiblePosition = 0
        UltraGridColumn1917.Hidden = True
        UltraGridColumn1918.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1918.Header.VisiblePosition = 1
        UltraGridColumn1918.Hidden = True
        UltraGridColumn1919.Header.VisiblePosition = 2
        UltraGridColumn1919.Hidden = True
        UltraGridColumn1920.Header.VisiblePosition = 3
        UltraGridColumn1921.Header.VisiblePosition = 4
        UltraGridColumn1921.Width = 228
        UltraGridColumn1922.Header.VisiblePosition = 5
        UltraGridColumn1922.Width = 220
        UltraGridColumn1923.Header.VisiblePosition = 6
        UltraGridColumn1924.Header.VisiblePosition = 7
        UltraGridColumn1924.Hidden = True
        UltraGridColumn1925.Header.VisiblePosition = 8
        UltraGridColumn1926.Header.VisiblePosition = 9
        UltraGridColumn1927.Header.VisiblePosition = 10
        UltraGridColumn1928.Header.VisiblePosition = 12
        UltraGridColumn1928.Width = 157
        UltraGridColumn1929.Header.VisiblePosition = 13
        UltraGridColumn1929.Width = 157
        UltraGridColumn1930.Header.VisiblePosition = 14
        UltraGridColumn1930.Width = 116
        UltraGridColumn1931.Header.VisiblePosition = 16
        UltraGridColumn1931.Width = 284
        UltraGridColumn1932.Header.VisiblePosition = 17
        UltraGridColumn1933.Header.VisiblePosition = 18
        UltraGridColumn1934.Header.VisiblePosition = 19
        UltraGridColumn1935.Header.VisiblePosition = 20
        UltraGridColumn1936.Header.VisiblePosition = 21
        UltraGridColumn1936.Width = 218
        UltraGridColumn1937.Header.VisiblePosition = 22
        UltraGridColumn1937.Width = 80
        UltraGridColumn1938.Header.VisiblePosition = 23
        UltraGridColumn1938.Width = 161
        UltraGridColumn1939.Header.VisiblePosition = 24
        UltraGridColumn1939.Width = 166
        UltraGridColumn1940.Header.VisiblePosition = 25
        UltraGridColumn1940.Hidden = True
        UltraGridColumn1941.Header.VisiblePosition = 26
        UltraGridColumn1941.Hidden = True
        UltraGridColumn1942.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1942.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1942.Header.VisiblePosition = 15
        UltraGridColumn1942.Width = 315
        UltraGridColumn1943.Header.VisiblePosition = 27
        UltraGridColumn1943.Hidden = True
        UltraGridColumn1944.Header.VisiblePosition = 28
        UltraGridColumn1944.Hidden = True
        UltraGridColumn1945.Header.VisiblePosition = 29
        UltraGridColumn1945.Hidden = True
        UltraGridColumn1946.Header.VisiblePosition = 30
        UltraGridColumn1946.Hidden = True
        UltraGridColumn1947.Header.VisiblePosition = 11
        UltraGridColumn1947.Hidden = True
        UltraGridColumn1948.Header.VisiblePosition = 31
        UltraGridColumn1949.Header.VisiblePosition = 32
        UltraGridColumn1950.Header.VisiblePosition = 33
        UltraGridColumn1951.Header.VisiblePosition = 34
        UltraGridColumn1952.Header.VisiblePosition = 35
        UltraGridColumn1953.Header.VisiblePosition = 36
        UltraGridColumn1954.Header.VisiblePosition = 37
        UltraGridColumn1955.Header.VisiblePosition = 38
        UltraGridColumn1956.Header.VisiblePosition = 39
        UltraGridColumn2461.Header.VisiblePosition = 40
        UltraGridColumn2462.Header.VisiblePosition = 41
        UltraGridColumn2463.Header.VisiblePosition = 42
        UltraGridColumn2464.Header.VisiblePosition = 43
        UltraGridColumn2465.Header.VisiblePosition = 44
        UltraGridColumn2466.Header.VisiblePosition = 45
        UltraGridColumn9.Header.VisiblePosition = 46
        UltraGridColumn27.Header.VisiblePosition = 47
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn1917, UltraGridColumn1918, UltraGridColumn1919, UltraGridColumn1920, UltraGridColumn1921, UltraGridColumn1922, UltraGridColumn1923, UltraGridColumn1924, UltraGridColumn1925, UltraGridColumn1926, UltraGridColumn1927, UltraGridColumn1928, UltraGridColumn1929, UltraGridColumn1930, UltraGridColumn1931, UltraGridColumn1932, UltraGridColumn1933, UltraGridColumn1934, UltraGridColumn1935, UltraGridColumn1936, UltraGridColumn1937, UltraGridColumn1938, UltraGridColumn1939, UltraGridColumn1940, UltraGridColumn1941, UltraGridColumn1942, UltraGridColumn1943, UltraGridColumn1944, UltraGridColumn1945, UltraGridColumn1946, UltraGridColumn1947, UltraGridColumn1948, UltraGridColumn1949, UltraGridColumn1950, UltraGridColumn1951, UltraGridColumn1952, UltraGridColumn1953, UltraGridColumn1954, UltraGridColumn1955, UltraGridColumn1956, UltraGridColumn2461, UltraGridColumn2462, UltraGridColumn2463, UltraGridColumn2464, UltraGridColumn2465, UltraGridColumn2466, UltraGridColumn9, UltraGridColumn27})
        Me.griTab09.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griTab09.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab09.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab09.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab09.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab09.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab09.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab09.DisplayLayout.Override.CellPadding = 0
        Me.griTab09.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab09.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab09.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab09.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance26.TextHAlignAsString = "Left"
        Me.griTab09.DisplayLayout.Override.HeaderAppearance = Appearance26
        Me.griTab09.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab09.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance27.TextVAlignAsString = "Middle"
        Me.griTab09.DisplayLayout.Override.RowAppearance = Appearance27
        Me.griTab09.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab09.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab09.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab09.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab09.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab09.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab09.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab09.Location = New System.Drawing.Point(0, 0)
        Me.griTab09.Name = "griTab09"
        Me.griTab09.Size = New System.Drawing.Size(1072, 327)
        Me.griTab09.TabIndex = 8
        Me.griTab09.Tag = ""
        '
        'tap10
        '
        Me.tap10.Controls.Add(Me.griTab10)
        Me.tap10.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap10.Name = "tap10"
        Me.tap10.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab10
        '
        Me.griTab10.DataSource = Me.udsDespachoOperaciones
        Appearance28.BackColor = System.Drawing.Color.White
        Me.griTab10.DisplayLayout.Appearance = Appearance28
        UltraGridColumn1957.Header.VisiblePosition = 0
        UltraGridColumn1957.Hidden = True
        UltraGridColumn1958.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1958.Header.VisiblePosition = 1
        UltraGridColumn1958.Hidden = True
        UltraGridColumn1959.Header.VisiblePosition = 2
        UltraGridColumn1959.Hidden = True
        UltraGridColumn1960.Header.VisiblePosition = 3
        UltraGridColumn1961.Header.VisiblePosition = 4
        UltraGridColumn1961.Width = 228
        UltraGridColumn1962.Header.VisiblePosition = 5
        UltraGridColumn1962.Width = 220
        UltraGridColumn1963.Header.VisiblePosition = 6
        UltraGridColumn1964.Header.VisiblePosition = 7
        UltraGridColumn1964.Hidden = True
        UltraGridColumn1965.Header.VisiblePosition = 8
        UltraGridColumn1966.Header.VisiblePosition = 9
        UltraGridColumn1967.Header.VisiblePosition = 10
        UltraGridColumn1968.Header.VisiblePosition = 12
        UltraGridColumn1968.Width = 157
        UltraGridColumn1969.Header.VisiblePosition = 13
        UltraGridColumn1969.Width = 157
        UltraGridColumn1970.Header.VisiblePosition = 14
        UltraGridColumn1970.Width = 116
        UltraGridColumn1971.Header.VisiblePosition = 16
        UltraGridColumn1971.Width = 284
        UltraGridColumn1972.Header.VisiblePosition = 17
        UltraGridColumn1973.Header.VisiblePosition = 18
        UltraGridColumn1974.Header.VisiblePosition = 19
        UltraGridColumn1975.Header.VisiblePosition = 20
        UltraGridColumn1976.Header.VisiblePosition = 21
        UltraGridColumn1976.Width = 218
        UltraGridColumn1977.Header.VisiblePosition = 22
        UltraGridColumn1977.Width = 80
        UltraGridColumn1978.Header.VisiblePosition = 23
        UltraGridColumn1978.Width = 161
        UltraGridColumn1979.Header.VisiblePosition = 24
        UltraGridColumn1979.Width = 166
        UltraGridColumn1980.Header.VisiblePosition = 25
        UltraGridColumn1980.Hidden = True
        UltraGridColumn1981.Header.VisiblePosition = 26
        UltraGridColumn1981.Hidden = True
        UltraGridColumn1982.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1982.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1982.Header.VisiblePosition = 15
        UltraGridColumn1982.Width = 315
        UltraGridColumn1983.Header.VisiblePosition = 27
        UltraGridColumn1983.Hidden = True
        UltraGridColumn1984.Header.VisiblePosition = 28
        UltraGridColumn1984.Hidden = True
        UltraGridColumn1985.Header.VisiblePosition = 29
        UltraGridColumn1985.Hidden = True
        UltraGridColumn1986.Header.VisiblePosition = 30
        UltraGridColumn1986.Hidden = True
        UltraGridColumn1987.Header.VisiblePosition = 11
        UltraGridColumn1987.Hidden = True
        UltraGridColumn1988.Header.VisiblePosition = 31
        UltraGridColumn1989.Header.VisiblePosition = 32
        UltraGridColumn1990.Header.VisiblePosition = 33
        UltraGridColumn1991.Header.VisiblePosition = 34
        UltraGridColumn1992.Header.VisiblePosition = 35
        UltraGridColumn1993.Header.VisiblePosition = 36
        UltraGridColumn1994.Header.VisiblePosition = 37
        UltraGridColumn1995.Header.VisiblePosition = 38
        UltraGridColumn1996.Header.VisiblePosition = 39
        UltraGridColumn2467.Header.VisiblePosition = 40
        UltraGridColumn2468.Header.VisiblePosition = 41
        UltraGridColumn2469.Header.VisiblePosition = 42
        UltraGridColumn2470.Header.VisiblePosition = 43
        UltraGridColumn2471.Header.VisiblePosition = 44
        UltraGridColumn2472.Header.VisiblePosition = 45
        UltraGridColumn10.Header.VisiblePosition = 46
        UltraGridColumn28.Header.VisiblePosition = 47
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn1957, UltraGridColumn1958, UltraGridColumn1959, UltraGridColumn1960, UltraGridColumn1961, UltraGridColumn1962, UltraGridColumn1963, UltraGridColumn1964, UltraGridColumn1965, UltraGridColumn1966, UltraGridColumn1967, UltraGridColumn1968, UltraGridColumn1969, UltraGridColumn1970, UltraGridColumn1971, UltraGridColumn1972, UltraGridColumn1973, UltraGridColumn1974, UltraGridColumn1975, UltraGridColumn1976, UltraGridColumn1977, UltraGridColumn1978, UltraGridColumn1979, UltraGridColumn1980, UltraGridColumn1981, UltraGridColumn1982, UltraGridColumn1983, UltraGridColumn1984, UltraGridColumn1985, UltraGridColumn1986, UltraGridColumn1987, UltraGridColumn1988, UltraGridColumn1989, UltraGridColumn1990, UltraGridColumn1991, UltraGridColumn1992, UltraGridColumn1993, UltraGridColumn1994, UltraGridColumn1995, UltraGridColumn1996, UltraGridColumn2467, UltraGridColumn2468, UltraGridColumn2469, UltraGridColumn2470, UltraGridColumn2471, UltraGridColumn2472, UltraGridColumn10, UltraGridColumn28})
        Me.griTab10.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.griTab10.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab10.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab10.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab10.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab10.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab10.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab10.DisplayLayout.Override.CellPadding = 0
        Me.griTab10.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab10.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab10.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab10.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance29.TextHAlignAsString = "Left"
        Me.griTab10.DisplayLayout.Override.HeaderAppearance = Appearance29
        Me.griTab10.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab10.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance30.TextVAlignAsString = "Middle"
        Me.griTab10.DisplayLayout.Override.RowAppearance = Appearance30
        Me.griTab10.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab10.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab10.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab10.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab10.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab10.Location = New System.Drawing.Point(0, 0)
        Me.griTab10.Name = "griTab10"
        Me.griTab10.Size = New System.Drawing.Size(1072, 327)
        Me.griTab10.TabIndex = 8
        Me.griTab10.Tag = ""
        '
        'tap11
        '
        Me.tap11.Controls.Add(Me.griTab11)
        Me.tap11.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap11.Name = "tap11"
        Me.tap11.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab11
        '
        Me.griTab11.DataSource = Me.udsDespachoOperaciones
        Appearance31.BackColor = System.Drawing.Color.White
        Me.griTab11.DisplayLayout.Appearance = Appearance31
        UltraGridColumn1997.Header.VisiblePosition = 0
        UltraGridColumn1997.Hidden = True
        UltraGridColumn1998.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1998.Header.VisiblePosition = 1
        UltraGridColumn1998.Hidden = True
        UltraGridColumn1999.Header.VisiblePosition = 2
        UltraGridColumn1999.Hidden = True
        UltraGridColumn2000.Header.VisiblePosition = 3
        UltraGridColumn2001.Header.VisiblePosition = 4
        UltraGridColumn2001.Width = 228
        UltraGridColumn2002.Header.VisiblePosition = 5
        UltraGridColumn2002.Width = 220
        UltraGridColumn2003.Header.VisiblePosition = 6
        UltraGridColumn2004.Header.VisiblePosition = 7
        UltraGridColumn2004.Hidden = True
        UltraGridColumn2005.Header.VisiblePosition = 8
        UltraGridColumn2006.Header.VisiblePosition = 9
        UltraGridColumn2007.Header.VisiblePosition = 10
        UltraGridColumn2008.Header.VisiblePosition = 12
        UltraGridColumn2008.Width = 157
        UltraGridColumn2009.Header.VisiblePosition = 13
        UltraGridColumn2009.Width = 157
        UltraGridColumn2010.Header.VisiblePosition = 14
        UltraGridColumn2010.Width = 116
        UltraGridColumn2011.Header.VisiblePosition = 16
        UltraGridColumn2011.Width = 284
        UltraGridColumn2012.Header.VisiblePosition = 17
        UltraGridColumn2013.Header.VisiblePosition = 18
        UltraGridColumn2014.Header.VisiblePosition = 19
        UltraGridColumn2015.Header.VisiblePosition = 20
        UltraGridColumn2016.Header.VisiblePosition = 21
        UltraGridColumn2016.Width = 218
        UltraGridColumn2017.Header.VisiblePosition = 22
        UltraGridColumn2017.Width = 80
        UltraGridColumn2018.Header.VisiblePosition = 23
        UltraGridColumn2018.Width = 161
        UltraGridColumn2019.Header.VisiblePosition = 24
        UltraGridColumn2019.Width = 166
        UltraGridColumn2020.Header.VisiblePosition = 25
        UltraGridColumn2020.Hidden = True
        UltraGridColumn2021.Header.VisiblePosition = 26
        UltraGridColumn2021.Hidden = True
        UltraGridColumn2022.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2022.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2022.Header.VisiblePosition = 15
        UltraGridColumn2022.Width = 315
        UltraGridColumn2023.Header.VisiblePosition = 27
        UltraGridColumn2023.Hidden = True
        UltraGridColumn2024.Header.VisiblePosition = 28
        UltraGridColumn2024.Hidden = True
        UltraGridColumn2025.Header.VisiblePosition = 29
        UltraGridColumn2025.Hidden = True
        UltraGridColumn2026.Header.VisiblePosition = 30
        UltraGridColumn2026.Hidden = True
        UltraGridColumn2027.Header.VisiblePosition = 11
        UltraGridColumn2027.Hidden = True
        UltraGridColumn2028.Header.VisiblePosition = 31
        UltraGridColumn2029.Header.VisiblePosition = 32
        UltraGridColumn2030.Header.VisiblePosition = 33
        UltraGridColumn2031.Header.VisiblePosition = 34
        UltraGridColumn2032.Header.VisiblePosition = 35
        UltraGridColumn2033.Header.VisiblePosition = 36
        UltraGridColumn2034.Header.VisiblePosition = 37
        UltraGridColumn2035.Header.VisiblePosition = 38
        UltraGridColumn2036.Header.VisiblePosition = 39
        UltraGridColumn2473.Header.VisiblePosition = 40
        UltraGridColumn2474.Header.VisiblePosition = 41
        UltraGridColumn2475.Header.VisiblePosition = 42
        UltraGridColumn2476.Header.VisiblePosition = 43
        UltraGridColumn2477.Header.VisiblePosition = 44
        UltraGridColumn2478.Header.VisiblePosition = 45
        UltraGridColumn11.Header.VisiblePosition = 46
        UltraGridColumn29.Header.VisiblePosition = 47
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn1997, UltraGridColumn1998, UltraGridColumn1999, UltraGridColumn2000, UltraGridColumn2001, UltraGridColumn2002, UltraGridColumn2003, UltraGridColumn2004, UltraGridColumn2005, UltraGridColumn2006, UltraGridColumn2007, UltraGridColumn2008, UltraGridColumn2009, UltraGridColumn2010, UltraGridColumn2011, UltraGridColumn2012, UltraGridColumn2013, UltraGridColumn2014, UltraGridColumn2015, UltraGridColumn2016, UltraGridColumn2017, UltraGridColumn2018, UltraGridColumn2019, UltraGridColumn2020, UltraGridColumn2021, UltraGridColumn2022, UltraGridColumn2023, UltraGridColumn2024, UltraGridColumn2025, UltraGridColumn2026, UltraGridColumn2027, UltraGridColumn2028, UltraGridColumn2029, UltraGridColumn2030, UltraGridColumn2031, UltraGridColumn2032, UltraGridColumn2033, UltraGridColumn2034, UltraGridColumn2035, UltraGridColumn2036, UltraGridColumn2473, UltraGridColumn2474, UltraGridColumn2475, UltraGridColumn2476, UltraGridColumn2477, UltraGridColumn2478, UltraGridColumn11, UltraGridColumn29})
        Me.griTab11.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.griTab11.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab11.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab11.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab11.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab11.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab11.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab11.DisplayLayout.Override.CellPadding = 0
        Me.griTab11.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab11.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab11.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab11.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance32.TextHAlignAsString = "Left"
        Me.griTab11.DisplayLayout.Override.HeaderAppearance = Appearance32
        Me.griTab11.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab11.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance33.TextVAlignAsString = "Middle"
        Me.griTab11.DisplayLayout.Override.RowAppearance = Appearance33
        Me.griTab11.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab11.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab11.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab11.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab11.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab11.Location = New System.Drawing.Point(0, 0)
        Me.griTab11.Name = "griTab11"
        Me.griTab11.Size = New System.Drawing.Size(1072, 327)
        Me.griTab11.TabIndex = 8
        Me.griTab11.Tag = ""
        '
        'tap12
        '
        Me.tap12.Controls.Add(Me.griTab12)
        Me.tap12.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap12.Name = "tap12"
        Me.tap12.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab12
        '
        Me.griTab12.DataSource = Me.udsDespachoOperaciones
        Appearance34.BackColor = System.Drawing.Color.White
        Me.griTab12.DisplayLayout.Appearance = Appearance34
        UltraGridColumn2037.Header.VisiblePosition = 0
        UltraGridColumn2037.Hidden = True
        UltraGridColumn2038.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2038.Header.VisiblePosition = 1
        UltraGridColumn2038.Hidden = True
        UltraGridColumn2039.Header.VisiblePosition = 2
        UltraGridColumn2039.Hidden = True
        UltraGridColumn2040.Header.VisiblePosition = 3
        UltraGridColumn2041.Header.VisiblePosition = 4
        UltraGridColumn2041.Width = 228
        UltraGridColumn2042.Header.VisiblePosition = 5
        UltraGridColumn2042.Width = 220
        UltraGridColumn2043.Header.VisiblePosition = 6
        UltraGridColumn2044.Header.VisiblePosition = 7
        UltraGridColumn2044.Hidden = True
        UltraGridColumn2045.Header.VisiblePosition = 8
        UltraGridColumn2046.Header.VisiblePosition = 9
        UltraGridColumn2047.Header.VisiblePosition = 10
        UltraGridColumn2048.Header.VisiblePosition = 12
        UltraGridColumn2048.Width = 157
        UltraGridColumn2049.Header.VisiblePosition = 13
        UltraGridColumn2049.Width = 157
        UltraGridColumn2050.Header.VisiblePosition = 14
        UltraGridColumn2050.Width = 116
        UltraGridColumn2051.Header.VisiblePosition = 16
        UltraGridColumn2051.Width = 284
        UltraGridColumn2052.Header.VisiblePosition = 17
        UltraGridColumn2053.Header.VisiblePosition = 18
        UltraGridColumn2054.Header.VisiblePosition = 19
        UltraGridColumn2055.Header.VisiblePosition = 20
        UltraGridColumn2056.Header.VisiblePosition = 21
        UltraGridColumn2056.Width = 218
        UltraGridColumn2057.Header.VisiblePosition = 22
        UltraGridColumn2057.Width = 80
        UltraGridColumn2058.Header.VisiblePosition = 23
        UltraGridColumn2058.Width = 161
        UltraGridColumn2059.Header.VisiblePosition = 24
        UltraGridColumn2059.Width = 166
        UltraGridColumn2060.Header.VisiblePosition = 25
        UltraGridColumn2060.Hidden = True
        UltraGridColumn2061.Header.VisiblePosition = 26
        UltraGridColumn2061.Hidden = True
        UltraGridColumn2062.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2062.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2062.Header.VisiblePosition = 15
        UltraGridColumn2062.Width = 315
        UltraGridColumn2063.Header.VisiblePosition = 27
        UltraGridColumn2063.Hidden = True
        UltraGridColumn2064.Header.VisiblePosition = 28
        UltraGridColumn2064.Hidden = True
        UltraGridColumn2065.Header.VisiblePosition = 29
        UltraGridColumn2065.Hidden = True
        UltraGridColumn2066.Header.VisiblePosition = 30
        UltraGridColumn2066.Hidden = True
        UltraGridColumn2067.Header.VisiblePosition = 11
        UltraGridColumn2067.Hidden = True
        UltraGridColumn2068.Header.VisiblePosition = 31
        UltraGridColumn2069.Header.VisiblePosition = 32
        UltraGridColumn2070.Header.VisiblePosition = 33
        UltraGridColumn2071.Header.VisiblePosition = 34
        UltraGridColumn2072.Header.VisiblePosition = 35
        UltraGridColumn2073.Header.VisiblePosition = 36
        UltraGridColumn2074.Header.VisiblePosition = 37
        UltraGridColumn2075.Header.VisiblePosition = 38
        UltraGridColumn2076.Header.VisiblePosition = 39
        UltraGridColumn2479.Header.VisiblePosition = 40
        UltraGridColumn2480.Header.VisiblePosition = 41
        UltraGridColumn2481.Header.VisiblePosition = 42
        UltraGridColumn2482.Header.VisiblePosition = 43
        UltraGridColumn2483.Header.VisiblePosition = 44
        UltraGridColumn2484.Header.VisiblePosition = 45
        UltraGridColumn12.Header.VisiblePosition = 46
        UltraGridColumn30.Header.VisiblePosition = 47
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn2037, UltraGridColumn2038, UltraGridColumn2039, UltraGridColumn2040, UltraGridColumn2041, UltraGridColumn2042, UltraGridColumn2043, UltraGridColumn2044, UltraGridColumn2045, UltraGridColumn2046, UltraGridColumn2047, UltraGridColumn2048, UltraGridColumn2049, UltraGridColumn2050, UltraGridColumn2051, UltraGridColumn2052, UltraGridColumn2053, UltraGridColumn2054, UltraGridColumn2055, UltraGridColumn2056, UltraGridColumn2057, UltraGridColumn2058, UltraGridColumn2059, UltraGridColumn2060, UltraGridColumn2061, UltraGridColumn2062, UltraGridColumn2063, UltraGridColumn2064, UltraGridColumn2065, UltraGridColumn2066, UltraGridColumn2067, UltraGridColumn2068, UltraGridColumn2069, UltraGridColumn2070, UltraGridColumn2071, UltraGridColumn2072, UltraGridColumn2073, UltraGridColumn2074, UltraGridColumn2075, UltraGridColumn2076, UltraGridColumn2479, UltraGridColumn2480, UltraGridColumn2481, UltraGridColumn2482, UltraGridColumn2483, UltraGridColumn2484, UltraGridColumn12, UltraGridColumn30})
        Me.griTab12.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.griTab12.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab12.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab12.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab12.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab12.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab12.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab12.DisplayLayout.Override.CellPadding = 0
        Me.griTab12.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab12.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab12.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab12.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance35.TextHAlignAsString = "Left"
        Me.griTab12.DisplayLayout.Override.HeaderAppearance = Appearance35
        Me.griTab12.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab12.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance36.TextVAlignAsString = "Middle"
        Me.griTab12.DisplayLayout.Override.RowAppearance = Appearance36
        Me.griTab12.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab12.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab12.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab12.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab12.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab12.Location = New System.Drawing.Point(0, 0)
        Me.griTab12.Name = "griTab12"
        Me.griTab12.Size = New System.Drawing.Size(1072, 327)
        Me.griTab12.TabIndex = 8
        Me.griTab12.Tag = ""
        '
        'tap13
        '
        Me.tap13.Controls.Add(Me.griTab13)
        Me.tap13.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap13.Name = "tap13"
        Me.tap13.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab13
        '
        Me.griTab13.DataSource = Me.udsDespachoOperaciones
        Appearance37.BackColor = System.Drawing.Color.White
        Me.griTab13.DisplayLayout.Appearance = Appearance37
        UltraGridColumn2077.Header.VisiblePosition = 0
        UltraGridColumn2077.Hidden = True
        UltraGridColumn2078.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2078.Header.VisiblePosition = 1
        UltraGridColumn2078.Hidden = True
        UltraGridColumn2079.Header.VisiblePosition = 2
        UltraGridColumn2079.Hidden = True
        UltraGridColumn2080.Header.VisiblePosition = 3
        UltraGridColumn2081.Header.VisiblePosition = 4
        UltraGridColumn2081.Width = 228
        UltraGridColumn2082.Header.VisiblePosition = 5
        UltraGridColumn2082.Width = 220
        UltraGridColumn2083.Header.VisiblePosition = 6
        UltraGridColumn2084.Header.VisiblePosition = 7
        UltraGridColumn2084.Hidden = True
        UltraGridColumn2085.Header.VisiblePosition = 8
        UltraGridColumn2086.Header.VisiblePosition = 9
        UltraGridColumn2087.Header.VisiblePosition = 10
        UltraGridColumn2088.Header.VisiblePosition = 12
        UltraGridColumn2088.Width = 157
        UltraGridColumn2089.Header.VisiblePosition = 13
        UltraGridColumn2089.Width = 157
        UltraGridColumn2090.Header.VisiblePosition = 14
        UltraGridColumn2090.Width = 116
        UltraGridColumn2091.Header.VisiblePosition = 16
        UltraGridColumn2091.Width = 284
        UltraGridColumn2092.Header.VisiblePosition = 17
        UltraGridColumn2093.Header.VisiblePosition = 18
        UltraGridColumn2094.Header.VisiblePosition = 19
        UltraGridColumn2095.Header.VisiblePosition = 20
        UltraGridColumn2096.Header.VisiblePosition = 21
        UltraGridColumn2096.Width = 218
        UltraGridColumn2097.Header.VisiblePosition = 22
        UltraGridColumn2097.Width = 80
        UltraGridColumn2098.Header.VisiblePosition = 23
        UltraGridColumn2098.Width = 161
        UltraGridColumn2099.Header.VisiblePosition = 24
        UltraGridColumn2099.Width = 166
        UltraGridColumn2100.Header.VisiblePosition = 25
        UltraGridColumn2100.Hidden = True
        UltraGridColumn2101.Header.VisiblePosition = 26
        UltraGridColumn2101.Hidden = True
        UltraGridColumn2102.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2102.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2102.Header.VisiblePosition = 15
        UltraGridColumn2102.Width = 315
        UltraGridColumn2103.Header.VisiblePosition = 27
        UltraGridColumn2103.Hidden = True
        UltraGridColumn2104.Header.VisiblePosition = 28
        UltraGridColumn2104.Hidden = True
        UltraGridColumn2105.Header.VisiblePosition = 29
        UltraGridColumn2105.Hidden = True
        UltraGridColumn2106.Header.VisiblePosition = 30
        UltraGridColumn2106.Hidden = True
        UltraGridColumn2107.Header.VisiblePosition = 11
        UltraGridColumn2107.Hidden = True
        UltraGridColumn2108.Header.VisiblePosition = 31
        UltraGridColumn2109.Header.VisiblePosition = 32
        UltraGridColumn2110.Header.VisiblePosition = 33
        UltraGridColumn2111.Header.VisiblePosition = 34
        UltraGridColumn2112.Header.VisiblePosition = 35
        UltraGridColumn2113.Header.VisiblePosition = 36
        UltraGridColumn2114.Header.VisiblePosition = 37
        UltraGridColumn2115.Header.VisiblePosition = 38
        UltraGridColumn2116.Header.VisiblePosition = 39
        UltraGridColumn2485.Header.VisiblePosition = 40
        UltraGridColumn2486.Header.VisiblePosition = 41
        UltraGridColumn2487.Header.VisiblePosition = 42
        UltraGridColumn2488.Header.VisiblePosition = 43
        UltraGridColumn2489.Header.VisiblePosition = 44
        UltraGridColumn2490.Header.VisiblePosition = 45
        UltraGridColumn13.Header.VisiblePosition = 46
        UltraGridColumn31.Header.VisiblePosition = 47
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn2077, UltraGridColumn2078, UltraGridColumn2079, UltraGridColumn2080, UltraGridColumn2081, UltraGridColumn2082, UltraGridColumn2083, UltraGridColumn2084, UltraGridColumn2085, UltraGridColumn2086, UltraGridColumn2087, UltraGridColumn2088, UltraGridColumn2089, UltraGridColumn2090, UltraGridColumn2091, UltraGridColumn2092, UltraGridColumn2093, UltraGridColumn2094, UltraGridColumn2095, UltraGridColumn2096, UltraGridColumn2097, UltraGridColumn2098, UltraGridColumn2099, UltraGridColumn2100, UltraGridColumn2101, UltraGridColumn2102, UltraGridColumn2103, UltraGridColumn2104, UltraGridColumn2105, UltraGridColumn2106, UltraGridColumn2107, UltraGridColumn2108, UltraGridColumn2109, UltraGridColumn2110, UltraGridColumn2111, UltraGridColumn2112, UltraGridColumn2113, UltraGridColumn2114, UltraGridColumn2115, UltraGridColumn2116, UltraGridColumn2485, UltraGridColumn2486, UltraGridColumn2487, UltraGridColumn2488, UltraGridColumn2489, UltraGridColumn2490, UltraGridColumn13, UltraGridColumn31})
        Me.griTab13.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.griTab13.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab13.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab13.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab13.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab13.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab13.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab13.DisplayLayout.Override.CellPadding = 0
        Me.griTab13.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab13.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab13.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab13.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance38.TextHAlignAsString = "Left"
        Me.griTab13.DisplayLayout.Override.HeaderAppearance = Appearance38
        Me.griTab13.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab13.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance39.TextVAlignAsString = "Middle"
        Me.griTab13.DisplayLayout.Override.RowAppearance = Appearance39
        Me.griTab13.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab13.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab13.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab13.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab13.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab13.Location = New System.Drawing.Point(0, 0)
        Me.griTab13.Name = "griTab13"
        Me.griTab13.Size = New System.Drawing.Size(1072, 327)
        Me.griTab13.TabIndex = 8
        Me.griTab13.Tag = ""
        '
        'tap14
        '
        Me.tap14.Controls.Add(Me.griTab14)
        Me.tap14.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap14.Name = "tap14"
        Me.tap14.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab14
        '
        Me.griTab14.DataSource = Me.udsDespachoOperaciones
        Appearance40.BackColor = System.Drawing.Color.White
        Me.griTab14.DisplayLayout.Appearance = Appearance40
        UltraGridColumn2117.Header.VisiblePosition = 0
        UltraGridColumn2117.Hidden = True
        UltraGridColumn2118.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2118.Header.VisiblePosition = 1
        UltraGridColumn2118.Hidden = True
        UltraGridColumn2119.Header.VisiblePosition = 2
        UltraGridColumn2119.Hidden = True
        UltraGridColumn2120.Header.VisiblePosition = 3
        UltraGridColumn2121.Header.VisiblePosition = 4
        UltraGridColumn2121.Width = 228
        UltraGridColumn2122.Header.VisiblePosition = 5
        UltraGridColumn2122.Width = 220
        UltraGridColumn2123.Header.VisiblePosition = 6
        UltraGridColumn2124.Header.VisiblePosition = 7
        UltraGridColumn2124.Hidden = True
        UltraGridColumn2125.Header.VisiblePosition = 8
        UltraGridColumn2126.Header.VisiblePosition = 9
        UltraGridColumn2127.Header.VisiblePosition = 10
        UltraGridColumn2128.Header.VisiblePosition = 12
        UltraGridColumn2128.Width = 157
        UltraGridColumn2129.Header.VisiblePosition = 13
        UltraGridColumn2129.Width = 157
        UltraGridColumn2130.Header.VisiblePosition = 14
        UltraGridColumn2130.Width = 116
        UltraGridColumn2131.Header.VisiblePosition = 16
        UltraGridColumn2131.Width = 284
        UltraGridColumn2132.Header.VisiblePosition = 17
        UltraGridColumn2133.Header.VisiblePosition = 18
        UltraGridColumn2134.Header.VisiblePosition = 19
        UltraGridColumn2135.Header.VisiblePosition = 20
        UltraGridColumn2136.Header.VisiblePosition = 21
        UltraGridColumn2136.Width = 218
        UltraGridColumn2137.Header.VisiblePosition = 22
        UltraGridColumn2137.Width = 80
        UltraGridColumn2138.Header.VisiblePosition = 23
        UltraGridColumn2138.Width = 161
        UltraGridColumn2139.Header.VisiblePosition = 24
        UltraGridColumn2139.Width = 166
        UltraGridColumn2140.Header.VisiblePosition = 25
        UltraGridColumn2140.Hidden = True
        UltraGridColumn2141.Header.VisiblePosition = 26
        UltraGridColumn2141.Hidden = True
        UltraGridColumn2142.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2142.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2142.Header.VisiblePosition = 15
        UltraGridColumn2142.Width = 315
        UltraGridColumn2143.Header.VisiblePosition = 27
        UltraGridColumn2143.Hidden = True
        UltraGridColumn2144.Header.VisiblePosition = 28
        UltraGridColumn2144.Hidden = True
        UltraGridColumn2145.Header.VisiblePosition = 29
        UltraGridColumn2145.Hidden = True
        UltraGridColumn2146.Header.VisiblePosition = 30
        UltraGridColumn2146.Hidden = True
        UltraGridColumn2147.Header.VisiblePosition = 11
        UltraGridColumn2147.Hidden = True
        UltraGridColumn2148.Header.VisiblePosition = 31
        UltraGridColumn2149.Header.VisiblePosition = 32
        UltraGridColumn2150.Header.VisiblePosition = 33
        UltraGridColumn2151.Header.VisiblePosition = 34
        UltraGridColumn2152.Header.VisiblePosition = 35
        UltraGridColumn2153.Header.VisiblePosition = 36
        UltraGridColumn2154.Header.VisiblePosition = 37
        UltraGridColumn2155.Header.VisiblePosition = 38
        UltraGridColumn2156.Header.VisiblePosition = 39
        UltraGridColumn2491.Header.VisiblePosition = 40
        UltraGridColumn2492.Header.VisiblePosition = 41
        UltraGridColumn2493.Header.VisiblePosition = 42
        UltraGridColumn2494.Header.VisiblePosition = 43
        UltraGridColumn2495.Header.VisiblePosition = 44
        UltraGridColumn2496.Header.VisiblePosition = 45
        UltraGridColumn14.Header.VisiblePosition = 46
        UltraGridColumn32.Header.VisiblePosition = 47
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn2117, UltraGridColumn2118, UltraGridColumn2119, UltraGridColumn2120, UltraGridColumn2121, UltraGridColumn2122, UltraGridColumn2123, UltraGridColumn2124, UltraGridColumn2125, UltraGridColumn2126, UltraGridColumn2127, UltraGridColumn2128, UltraGridColumn2129, UltraGridColumn2130, UltraGridColumn2131, UltraGridColumn2132, UltraGridColumn2133, UltraGridColumn2134, UltraGridColumn2135, UltraGridColumn2136, UltraGridColumn2137, UltraGridColumn2138, UltraGridColumn2139, UltraGridColumn2140, UltraGridColumn2141, UltraGridColumn2142, UltraGridColumn2143, UltraGridColumn2144, UltraGridColumn2145, UltraGridColumn2146, UltraGridColumn2147, UltraGridColumn2148, UltraGridColumn2149, UltraGridColumn2150, UltraGridColumn2151, UltraGridColumn2152, UltraGridColumn2153, UltraGridColumn2154, UltraGridColumn2155, UltraGridColumn2156, UltraGridColumn2491, UltraGridColumn2492, UltraGridColumn2493, UltraGridColumn2494, UltraGridColumn2495, UltraGridColumn2496, UltraGridColumn14, UltraGridColumn32})
        Me.griTab14.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.griTab14.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab14.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab14.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab14.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab14.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab14.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab14.DisplayLayout.Override.CellPadding = 0
        Me.griTab14.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab14.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab14.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab14.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance41.TextHAlignAsString = "Left"
        Me.griTab14.DisplayLayout.Override.HeaderAppearance = Appearance41
        Me.griTab14.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab14.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance42.TextVAlignAsString = "Middle"
        Me.griTab14.DisplayLayout.Override.RowAppearance = Appearance42
        Me.griTab14.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab14.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab14.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab14.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab14.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab14.Location = New System.Drawing.Point(0, 0)
        Me.griTab14.Name = "griTab14"
        Me.griTab14.Size = New System.Drawing.Size(1072, 327)
        Me.griTab14.TabIndex = 8
        Me.griTab14.Tag = ""
        '
        'tap15
        '
        Me.tap15.Controls.Add(Me.griTab15)
        Me.tap15.Location = New System.Drawing.Point(-10000, -10000)
        Me.tap15.Name = "tap15"
        Me.tap15.Size = New System.Drawing.Size(1072, 327)
        '
        'griTab15
        '
        Me.griTab15.DataSource = Me.udsDespachoOperaciones
        Appearance43.BackColor = System.Drawing.Color.White
        Me.griTab15.DisplayLayout.Appearance = Appearance43
        UltraGridColumn2157.Header.VisiblePosition = 0
        UltraGridColumn2157.Hidden = True
        UltraGridColumn2158.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2158.Header.VisiblePosition = 1
        UltraGridColumn2158.Hidden = True
        UltraGridColumn2159.Header.VisiblePosition = 2
        UltraGridColumn2159.Hidden = True
        UltraGridColumn2160.Header.VisiblePosition = 3
        UltraGridColumn2161.Header.VisiblePosition = 4
        UltraGridColumn2161.Width = 228
        UltraGridColumn2162.Header.VisiblePosition = 5
        UltraGridColumn2162.Width = 220
        UltraGridColumn2163.Header.VisiblePosition = 6
        UltraGridColumn2164.Header.VisiblePosition = 7
        UltraGridColumn2164.Hidden = True
        UltraGridColumn2165.Header.VisiblePosition = 8
        UltraGridColumn2166.Header.VisiblePosition = 9
        UltraGridColumn2167.Header.VisiblePosition = 10
        UltraGridColumn2168.Header.VisiblePosition = 12
        UltraGridColumn2168.Width = 157
        UltraGridColumn2169.Header.VisiblePosition = 13
        UltraGridColumn2169.Width = 157
        UltraGridColumn2170.Header.VisiblePosition = 14
        UltraGridColumn2170.Width = 116
        UltraGridColumn2171.Header.VisiblePosition = 16
        UltraGridColumn2171.Width = 284
        UltraGridColumn2172.Header.VisiblePosition = 17
        UltraGridColumn2173.Header.VisiblePosition = 18
        UltraGridColumn2174.Header.VisiblePosition = 19
        UltraGridColumn2175.Header.VisiblePosition = 20
        UltraGridColumn2176.Header.VisiblePosition = 21
        UltraGridColumn2176.Width = 218
        UltraGridColumn2177.Header.VisiblePosition = 22
        UltraGridColumn2177.Width = 80
        UltraGridColumn2178.Header.VisiblePosition = 23
        UltraGridColumn2178.Width = 161
        UltraGridColumn2179.Header.VisiblePosition = 24
        UltraGridColumn2179.Width = 166
        UltraGridColumn2180.Header.VisiblePosition = 25
        UltraGridColumn2180.Hidden = True
        UltraGridColumn2181.Header.VisiblePosition = 26
        UltraGridColumn2181.Hidden = True
        UltraGridColumn2182.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2182.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2182.Header.VisiblePosition = 15
        UltraGridColumn2182.Width = 315
        UltraGridColumn2183.Header.VisiblePosition = 27
        UltraGridColumn2183.Hidden = True
        UltraGridColumn2184.Header.VisiblePosition = 28
        UltraGridColumn2184.Hidden = True
        UltraGridColumn2185.Header.VisiblePosition = 29
        UltraGridColumn2185.Hidden = True
        UltraGridColumn2186.Header.VisiblePosition = 30
        UltraGridColumn2186.Hidden = True
        UltraGridColumn2187.Header.VisiblePosition = 11
        UltraGridColumn2187.Hidden = True
        UltraGridColumn2188.Header.VisiblePosition = 31
        UltraGridColumn2189.Header.VisiblePosition = 32
        UltraGridColumn2190.Header.VisiblePosition = 33
        UltraGridColumn2191.Header.VisiblePosition = 34
        UltraGridColumn2192.Header.VisiblePosition = 35
        UltraGridColumn2193.Header.VisiblePosition = 36
        UltraGridColumn2194.Header.VisiblePosition = 37
        UltraGridColumn2195.Header.VisiblePosition = 38
        UltraGridColumn2196.Header.VisiblePosition = 39
        UltraGridColumn2497.Header.VisiblePosition = 40
        UltraGridColumn2498.Header.VisiblePosition = 41
        UltraGridColumn2499.Header.VisiblePosition = 42
        UltraGridColumn2500.Header.VisiblePosition = 43
        UltraGridColumn2501.Header.VisiblePosition = 44
        UltraGridColumn2502.Header.VisiblePosition = 45
        UltraGridColumn15.Header.VisiblePosition = 46
        UltraGridColumn33.Header.VisiblePosition = 47
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn2157, UltraGridColumn2158, UltraGridColumn2159, UltraGridColumn2160, UltraGridColumn2161, UltraGridColumn2162, UltraGridColumn2163, UltraGridColumn2164, UltraGridColumn2165, UltraGridColumn2166, UltraGridColumn2167, UltraGridColumn2168, UltraGridColumn2169, UltraGridColumn2170, UltraGridColumn2171, UltraGridColumn2172, UltraGridColumn2173, UltraGridColumn2174, UltraGridColumn2175, UltraGridColumn2176, UltraGridColumn2177, UltraGridColumn2178, UltraGridColumn2179, UltraGridColumn2180, UltraGridColumn2181, UltraGridColumn2182, UltraGridColumn2183, UltraGridColumn2184, UltraGridColumn2185, UltraGridColumn2186, UltraGridColumn2187, UltraGridColumn2188, UltraGridColumn2189, UltraGridColumn2190, UltraGridColumn2191, UltraGridColumn2192, UltraGridColumn2193, UltraGridColumn2194, UltraGridColumn2195, UltraGridColumn2196, UltraGridColumn2497, UltraGridColumn2498, UltraGridColumn2499, UltraGridColumn2500, UltraGridColumn2501, UltraGridColumn2502, UltraGridColumn15, UltraGridColumn33})
        Me.griTab15.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.griTab15.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab15.DisplayLayout.GroupByBox.Hidden = True
        Me.griTab15.DisplayLayout.MaxColScrollRegions = 1
        Me.griTab15.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTab15.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTab15.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTab15.DisplayLayout.Override.CellPadding = 0
        Me.griTab15.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTab15.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTab15.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTab15.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance44.TextHAlignAsString = "Left"
        Me.griTab15.DisplayLayout.Override.HeaderAppearance = Appearance44
        Me.griTab15.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTab15.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance45.TextVAlignAsString = "Middle"
        Me.griTab15.DisplayLayout.Override.RowAppearance = Appearance45
        Me.griTab15.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTab15.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTab15.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTab15.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTab15.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTab15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTab15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTab15.Location = New System.Drawing.Point(0, 0)
        Me.griTab15.Name = "griTab15"
        Me.griTab15.Size = New System.Drawing.Size(1072, 327)
        Me.griTab15.TabIndex = 8
        Me.griTab15.Tag = ""
        '
        'tapListadoDespacho
        '
        Me.tapListadoDespacho.Controls.Add(Me.UltraGroupBox1)
        Me.tapListadoDespacho.Location = New System.Drawing.Point(1, 22)
        Me.tapListadoDespacho.Name = "tapListadoDespacho"
        Me.tapListadoDespacho.Size = New System.Drawing.Size(1080, 515)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.utcDespachosDinamicos)
        Me.UltraGroupBox1.Controls.Add(Me.ugbTotalesLista)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1080, 515)
        Me.UltraGroupBox1.TabIndex = 18
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'utcDespachosDinamicos
        '
        Me.utcDespachosDinamicos.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap01)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap02)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap03)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap04)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap05)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap06)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap07)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap08)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap09)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap10)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap11)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap12)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap13)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap14)
        Me.utcDespachosDinamicos.Controls.Add(Me.tap15)
        Me.utcDespachosDinamicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcDespachosDinamicos.Location = New System.Drawing.Point(3, 162)
        Me.utcDespachosDinamicos.Name = "utcDespachosDinamicos"
        Me.utcDespachosDinamicos.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.utcDespachosDinamicos.Size = New System.Drawing.Size(1074, 350)
        Me.utcDespachosDinamicos.TabIndex = 55
        Me.utcDespachosDinamicos.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.BottomLeft
        UltraTab1.TabPage = Me.tap01
        UltraTab1.Text = "Fechas"
        UltraTab2.TabPage = Me.tap02
        UltraTab2.Text = "tab2"
        UltraTab3.TabPage = Me.tap03
        UltraTab3.Text = "tab3"
        UltraTab4.TabPage = Me.tap04
        UltraTab4.Text = "tab4"
        UltraTab5.TabPage = Me.tap05
        UltraTab5.Text = "tab5"
        UltraTab6.TabPage = Me.tap06
        UltraTab6.Text = "tab6"
        UltraTab7.TabPage = Me.tap07
        UltraTab7.Text = "tab7"
        UltraTab8.TabPage = Me.tap08
        UltraTab8.Text = "tab8"
        UltraTab12.TabPage = Me.tap09
        UltraTab12.Text = "tab9"
        UltraTab13.TabPage = Me.tap10
        UltraTab13.Text = "tab10"
        UltraTab14.TabPage = Me.tap11
        UltraTab14.Text = "tab11"
        UltraTab15.TabPage = Me.tap12
        UltraTab15.Text = "tab12"
        UltraTab16.TabPage = Me.tap13
        UltraTab16.Text = "tab13"
        UltraTab17.TabPage = Me.tap14
        UltraTab17.Text = "tab14"
        UltraTab18.TabPage = Me.tap15
        UltraTab18.Text = "tab15"
        Me.utcDespachosDinamicos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7, UltraTab8, UltraTab12, UltraTab13, UltraTab14, UltraTab15, UltraTab16, UltraTab17, UltraTab18})
        Me.utcDespachosDinamicos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1072, 327)
        '
        'ugbTotalesLista
        '
        Me.ugbTotalesLista.Controls.Add(Me.unePorcentajeMeta)
        Me.ugbTotalesLista.Controls.Add(Me.Label45)
        Me.ugbTotalesLista.Controls.Add(Me.uneTotalViajes)
        Me.ugbTotalesLista.Controls.Add(Me.Label44)
        Me.ugbTotalesLista.Controls.Add(Me.uneTotalSinCopiloto)
        Me.ugbTotalesLista.Controls.Add(Me.uneProdUnidadFiltro)
        Me.ugbTotalesLista.Controls.Add(Me.Label43)
        Me.ugbTotalesLista.Controls.Add(Me.uneTotalSinPiloto)
        Me.ugbTotalesLista.Controls.Add(Me.Label7)
        Me.ugbTotalesLista.Controls.Add(Me.Label42)
        Me.ugbTotalesLista.Controls.Add(Me.uneProdTotalFiltro)
        Me.ugbTotalesLista.Controls.Add(Me.Label6)
        Me.ugbTotalesLista.Controls.Add(Me.uneProdRealFiltro)
        Me.ugbTotalesLista.Controls.Add(Me.Label5)
        Me.ugbTotalesLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.ugbTotalesLista.Location = New System.Drawing.Point(3, 115)
        Me.ugbTotalesLista.Name = "ugbTotalesLista"
        Me.ugbTotalesLista.Size = New System.Drawing.Size(1074, 47)
        Me.ugbTotalesLista.TabIndex = 54
        Me.ugbTotalesLista.Text = "Totales"
        Me.ugbTotalesLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'unePorcentajeMeta
        '
        Me.unePorcentajeMeta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.unePorcentajeMeta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unePorcentajeMeta.FormatString = "#,##0.00"
        Me.unePorcentajeMeta.Location = New System.Drawing.Point(717, 19)
        Me.unePorcentajeMeta.MaskInput = "{double:4.2}"
        Me.unePorcentajeMeta.Name = "unePorcentajeMeta"
        Me.unePorcentajeMeta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.unePorcentajeMeta.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.unePorcentajeMeta.ReadOnly = True
        Me.unePorcentajeMeta.Size = New System.Drawing.Size(34, 22)
        Me.unePorcentajeMeta.TabIndex = 4
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Location = New System.Drawing.Point(636, 23)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(83, 13)
        Me.Label45.TabIndex = 92
        Me.Label45.Text = "% Programado:"
        '
        'uneTotalViajes
        '
        Me.uneTotalViajes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uneTotalViajes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneTotalViajes.FormatString = "#,##0"
        Me.uneTotalViajes.Location = New System.Drawing.Point(28, 19)
        Me.uneTotalViajes.MaskInput = "{double:3.0}"
        Me.uneTotalViajes.Name = "uneTotalViajes"
        Me.uneTotalViajes.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneTotalViajes.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneTotalViajes.ReadOnly = True
        Me.uneTotalViajes.Size = New System.Drawing.Size(34, 22)
        Me.uneTotalViajes.TabIndex = 0
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Location = New System.Drawing.Point(6, 23)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(23, 13)
        Me.Label44.TabIndex = 90
        Me.Label44.Text = "N°:"
        '
        'uneTotalSinCopiloto
        '
        Me.uneTotalSinCopiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uneTotalSinCopiloto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneTotalSinCopiloto.FormatString = "#,##0"
        Me.uneTotalSinCopiloto.Location = New System.Drawing.Point(1002, 19)
        Me.uneTotalSinCopiloto.MaskInput = "{double:3.0}"
        Me.uneTotalSinCopiloto.Name = "uneTotalSinCopiloto"
        Me.uneTotalSinCopiloto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneTotalSinCopiloto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneTotalSinCopiloto.ReadOnly = True
        Me.uneTotalSinCopiloto.Size = New System.Drawing.Size(59, 22)
        Me.uneTotalSinCopiloto.TabIndex = 6
        '
        'uneProdUnidadFiltro
        '
        Me.uneProdUnidadFiltro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uneProdUnidadFiltro.FormatString = "###,###,##0.00"
        Me.uneProdUnidadFiltro.Location = New System.Drawing.Point(163, 19)
        Me.uneProdUnidadFiltro.MaskInput = "{double:4.2}"
        Me.uneProdUnidadFiltro.Name = "uneProdUnidadFiltro"
        Me.uneProdUnidadFiltro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneProdUnidadFiltro.ReadOnly = True
        Me.uneProdUnidadFiltro.Size = New System.Drawing.Size(68, 22)
        Me.uneProdUnidadFiltro.TabIndex = 1
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(904, 23)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(98, 13)
        Me.Label43.TabIndex = 89
        Me.Label43.Text = "Viajes Sin Copiloto:"
        '
        'uneTotalSinPiloto
        '
        Me.uneTotalSinPiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uneTotalSinPiloto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneTotalSinPiloto.FormatString = "#,##0"
        Me.uneTotalSinPiloto.Location = New System.Drawing.Point(841, 19)
        Me.uneTotalSinPiloto.MaskInput = "{double:3.0}"
        Me.uneTotalSinPiloto.Name = "uneTotalSinPiloto"
        Me.uneTotalSinPiloto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneTotalSinPiloto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneTotalSinPiloto.ReadOnly = True
        Me.uneTotalSinPiloto.Size = New System.Drawing.Size(57, 22)
        Me.uneTotalSinPiloto.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(66, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Producción Unidad:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(754, 23)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(85, 13)
        Me.Label42.TabIndex = 88
        Me.Label42.Text = "Viajes Sin Piloto:"
        '
        'uneProdTotalFiltro
        '
        Me.uneProdTotalFiltro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uneProdTotalFiltro.FormatString = "###,###,##0.00"
        Me.uneProdTotalFiltro.Location = New System.Drawing.Point(321, 19)
        Me.uneProdTotalFiltro.MaskInput = "{double:9.2}"
        Me.uneProdTotalFiltro.Name = "uneProdTotalFiltro"
        Me.uneProdTotalFiltro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneProdTotalFiltro.ReadOnly = True
        Me.uneProdTotalFiltro.Size = New System.Drawing.Size(110, 22)
        Me.uneProdTotalFiltro.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(233, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Producción Total:"
        UltraToolTipInfo12.ToolTipText = "Producción a la que se quiere llegar"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.Label6, UltraToolTipInfo12)
        '
        'uneProdRealFiltro
        '
        Me.uneProdRealFiltro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uneProdRealFiltro.FormatString = "###,###,##0.00"
        Me.uneProdRealFiltro.Location = New System.Drawing.Point(521, 19)
        Me.uneProdRealFiltro.MaskInput = "{double:9.2}"
        Me.uneProdRealFiltro.Name = "uneProdRealFiltro"
        Me.uneProdRealFiltro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneProdRealFiltro.ReadOnly = True
        Me.uneProdRealFiltro.Size = New System.Drawing.Size(110, 22)
        Me.uneProdRealFiltro.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(434, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Producción Real:"
        UltraToolTipInfo13.ToolTipText = "Producción Programada hasta el momento"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.Label5, UltraToolTipInfo13)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.cboZonaListado)
        Me.UltraGroupBox3.Controls.Add(Me.Label26)
        Me.UltraGroupBox3.Controls.Add(Me.Button1)
        Me.UltraGroupBox3.Controls.Add(Me.cboEstadoFiltro)
        Me.UltraGroupBox3.Controls.Add(Me.Label15)
        Me.UltraGroupBox3.Controls.Add(Me.Label3)
        Me.UltraGroupBox3.Controls.Add(Me.cboCentroFiltro)
        Me.UltraGroupBox3.Controls.Add(Me.dtpHastaFiltro)
        Me.UltraGroupBox3.Controls.Add(Me.Label2)
        Me.UltraGroupBox3.Controls.Add(Me.dtpDesdeFiltro)
        Me.UltraGroupBox3.Controls.Add(Me.Label1)
        Me.UltraGroupBox3.Controls.Add(Me.griFormatoClientes)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox3.Location = New System.Drawing.Point(3, 72)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1074, 43)
        Me.UltraGroupBox3.TabIndex = 18
        Me.UltraGroupBox3.Text = "Filtros"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboZonaListado
        '
        Me.cboZonaListado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboZonaListado.DisplayMember = "Nombre"
        Me.cboZonaListado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboZonaListado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboZonaListado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZonaListado.Location = New System.Drawing.Point(688, 11)
        Me.cboZonaListado.Name = "cboZonaListado"
        Me.cboZonaListado.Size = New System.Drawing.Size(141, 22)
        Me.cboZonaListado.TabIndex = 4
        Me.cboZonaListado.ValueMember = "Id"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(604, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 13)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "Zona a Editar:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Image = Global.ISL.Win.My.Resources.Resources.content_tree
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(935, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 37)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Ultima Ubicación Unidades"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cboEstadoFiltro
        '
        Me.cboEstadoFiltro.DisplayMember = "Nombre"
        Me.cboEstadoFiltro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoFiltro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoFiltro.Location = New System.Drawing.Point(478, 12)
        Me.cboEstadoFiltro.Name = "cboEstadoFiltro"
        Me.cboEstadoFiltro.Size = New System.Drawing.Size(120, 22)
        Me.cboEstadoFiltro.TabIndex = 3
        Me.cboEstadoFiltro.ValueMember = "Id"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(433, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(254, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Centro:"
        '
        'cboCentroFiltro
        '
        Me.cboCentroFiltro.DisplayMember = "Nombre"
        Me.cboCentroFiltro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroFiltro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroFiltro.Location = New System.Drawing.Point(298, 12)
        Me.cboCentroFiltro.Name = "cboCentroFiltro"
        Me.cboCentroFiltro.Size = New System.Drawing.Size(120, 22)
        Me.cboCentroFiltro.TabIndex = 2
        Me.cboCentroFiltro.ValueMember = "Descripcion"
        '
        'dtpHastaFiltro
        '
        Me.dtpHastaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHastaFiltro.Location = New System.Drawing.Point(170, 13)
        Me.dtpHastaFiltro.Name = "dtpHastaFiltro"
        Me.dtpHastaFiltro.Size = New System.Drawing.Size(80, 21)
        Me.dtpHastaFiltro.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(132, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Hasta:"
        '
        'dtpDesdeFiltro
        '
        Me.dtpDesdeFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesdeFiltro.Location = New System.Drawing.Point(48, 13)
        Me.dtpDesdeFiltro.Name = "dtpDesdeFiltro"
        Me.dtpDesdeFiltro.Size = New System.Drawing.Size(80, 21)
        Me.dtpDesdeFiltro.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Desde:"
        '
        'griFormatoClientes
        '
        Me.griFormatoClientes.DataSource = Me.udsDespachoOperaciones
        Appearance100.BackColor = System.Drawing.Color.White
        Me.griFormatoClientes.DisplayLayout.Appearance = Appearance100
        UltraGridColumn2197.Header.VisiblePosition = 0
        UltraGridColumn2197.Hidden = True
        UltraGridColumn2198.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2198.Header.VisiblePosition = 1
        UltraGridColumn2198.Hidden = True
        UltraGridColumn2199.Header.VisiblePosition = 2
        UltraGridColumn2199.Hidden = True
        UltraGridColumn2200.Header.VisiblePosition = 3
        UltraGridColumn2201.Header.VisiblePosition = 4
        UltraGridColumn2201.Width = 228
        UltraGridColumn2202.Header.VisiblePosition = 5
        UltraGridColumn2202.Width = 220
        UltraGridColumn2203.Header.VisiblePosition = 8
        UltraGridColumn2204.Header.VisiblePosition = 9
        UltraGridColumn2204.Hidden = True
        UltraGridColumn2205.Header.VisiblePosition = 10
        UltraGridColumn2206.Header.VisiblePosition = 11
        UltraGridColumn2207.Header.VisiblePosition = 12
        UltraGridColumn2208.Header.VisiblePosition = 14
        UltraGridColumn2208.Width = 157
        UltraGridColumn2209.Header.VisiblePosition = 15
        UltraGridColumn2209.Width = 157
        UltraGridColumn2210.Header.VisiblePosition = 16
        UltraGridColumn2210.Width = 116
        UltraGridColumn2211.Header.VisiblePosition = 18
        UltraGridColumn2211.Width = 284
        UltraGridColumn2212.Header.VisiblePosition = 19
        UltraGridColumn2213.Header.VisiblePosition = 20
        UltraGridColumn2214.Header.VisiblePosition = 21
        UltraGridColumn2215.Header.VisiblePosition = 22
        UltraGridColumn2215.Width = 55
        UltraGridColumn2216.Header.VisiblePosition = 23
        UltraGridColumn2216.Width = 218
        UltraGridColumn2217.Header.VisiblePosition = 24
        UltraGridColumn2217.Width = 54
        UltraGridColumn2218.Header.VisiblePosition = 25
        UltraGridColumn2218.Width = 161
        UltraGridColumn2219.Header.VisiblePosition = 26
        UltraGridColumn2219.Width = 166
        UltraGridColumn2220.Header.VisiblePosition = 27
        UltraGridColumn2220.Hidden = True
        UltraGridColumn2221.Header.VisiblePosition = 28
        UltraGridColumn2221.Hidden = True
        UltraGridColumn2222.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2222.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2222.Header.VisiblePosition = 17
        UltraGridColumn2222.Width = 315
        UltraGridColumn2223.Header.VisiblePosition = 29
        UltraGridColumn2223.Hidden = True
        UltraGridColumn2224.Header.VisiblePosition = 30
        UltraGridColumn2224.Hidden = True
        UltraGridColumn2225.Header.VisiblePosition = 31
        UltraGridColumn2225.Hidden = True
        UltraGridColumn2226.Header.VisiblePosition = 32
        UltraGridColumn2226.Hidden = True
        UltraGridColumn2227.Header.VisiblePosition = 13
        UltraGridColumn2227.Hidden = True
        UltraGridColumn2228.Header.VisiblePosition = 6
        UltraGridColumn2228.Width = 88
        UltraGridColumn2229.Header.VisiblePosition = 7
        UltraGridColumn2229.Width = 106
        UltraGridColumn2230.Header.VisiblePosition = 33
        UltraGridColumn2231.Header.VisiblePosition = 34
        UltraGridColumn2232.Header.VisiblePosition = 35
        UltraGridColumn2233.Header.VisiblePosition = 36
        UltraGridColumn2234.Header.VisiblePosition = 37
        UltraGridColumn2235.Header.VisiblePosition = 38
        UltraGridColumn2236.Header.VisiblePosition = 39
        UltraGridColumn2503.Header.VisiblePosition = 40
        UltraGridColumn2504.Header.VisiblePosition = 41
        UltraGridColumn2505.Header.VisiblePosition = 42
        UltraGridColumn2506.Header.VisiblePosition = 43
        UltraGridColumn2507.Header.VisiblePosition = 44
        UltraGridColumn2508.Header.VisiblePosition = 45
        UltraGridColumn16.Header.VisiblePosition = 46
        UltraGridColumn34.Header.VisiblePosition = 47
        UltraGridBand19.Columns.AddRange(New Object() {UltraGridColumn2197, UltraGridColumn2198, UltraGridColumn2199, UltraGridColumn2200, UltraGridColumn2201, UltraGridColumn2202, UltraGridColumn2203, UltraGridColumn2204, UltraGridColumn2205, UltraGridColumn2206, UltraGridColumn2207, UltraGridColumn2208, UltraGridColumn2209, UltraGridColumn2210, UltraGridColumn2211, UltraGridColumn2212, UltraGridColumn2213, UltraGridColumn2214, UltraGridColumn2215, UltraGridColumn2216, UltraGridColumn2217, UltraGridColumn2218, UltraGridColumn2219, UltraGridColumn2220, UltraGridColumn2221, UltraGridColumn2222, UltraGridColumn2223, UltraGridColumn2224, UltraGridColumn2225, UltraGridColumn2226, UltraGridColumn2227, UltraGridColumn2228, UltraGridColumn2229, UltraGridColumn2230, UltraGridColumn2231, UltraGridColumn2232, UltraGridColumn2233, UltraGridColumn2234, UltraGridColumn2235, UltraGridColumn2236, UltraGridColumn2503, UltraGridColumn2504, UltraGridColumn2505, UltraGridColumn2506, UltraGridColumn2507, UltraGridColumn2508, UltraGridColumn16, UltraGridColumn34})
        Me.griFormatoClientes.DisplayLayout.BandsSerializer.Add(UltraGridBand19)
        Me.griFormatoClientes.DisplayLayout.GroupByBox.Hidden = True
        Me.griFormatoClientes.DisplayLayout.MaxColScrollRegions = 1
        Me.griFormatoClientes.DisplayLayout.MaxRowScrollRegions = 1
        Me.griFormatoClientes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griFormatoClientes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griFormatoClientes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griFormatoClientes.DisplayLayout.Override.CellPadding = 0
        Me.griFormatoClientes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griFormatoClientes.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griFormatoClientes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griFormatoClientes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance101.TextHAlignAsString = "Left"
        Me.griFormatoClientes.DisplayLayout.Override.HeaderAppearance = Appearance101
        Me.griFormatoClientes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griFormatoClientes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance102.TextVAlignAsString = "Middle"
        Me.griFormatoClientes.DisplayLayout.Override.RowAppearance = Appearance102
        Me.griFormatoClientes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griFormatoClientes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griFormatoClientes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griFormatoClientes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griFormatoClientes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griFormatoClientes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griFormatoClientes.Location = New System.Drawing.Point(909, 8)
        Me.griFormatoClientes.Name = "griFormatoClientes"
        Me.griFormatoClientes.Size = New System.Drawing.Size(22, 29)
        Me.griFormatoClientes.TabIndex = 8
        Me.griFormatoClientes.Tag = ""
        Me.griFormatoClientes.Visible = False
        '
        'UltraExpandableGroupBox3
        '
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(1074, 69)
        Me.UltraExpandableGroupBox3.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(1074, 69)
        Me.UltraExpandableGroupBox3.TabIndex = 55
        Me.UltraExpandableGroupBox3.Text = "Colores Modelo Funcional Carreta"
        Me.UltraExpandableGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorParihuelero)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorPlataforma)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorBaranda)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorTolvaVolteo)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorGranelero)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorFurgon)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorFurgonLargo)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorFurgonAmericano)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorCisterna)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorBomboma)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorCalicera)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorMediaBaranda)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Color30M3)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Color20M3)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label25)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label24)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label23)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label22)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label21)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label19)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label18)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label17)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label16)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label4)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1068, 46)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'ColorParihuelero
        '
        Me.ColorParihuelero.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorParihuelero.Location = New System.Drawing.Point(297, 26)
        Me.ColorParihuelero.Name = "ColorParihuelero"
        Me.ColorParihuelero.Size = New System.Drawing.Size(44, 19)
        Me.ColorParihuelero.TabIndex = 73
        Me.ColorParihuelero.Text = "Control"
        '
        'ColorPlataforma
        '
        Me.ColorPlataforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPlataforma.Location = New System.Drawing.Point(402, 26)
        Me.ColorPlataforma.Name = "ColorPlataforma"
        Me.ColorPlataforma.Size = New System.Drawing.Size(44, 19)
        Me.ColorPlataforma.TabIndex = 45
        Me.ColorPlataforma.Text = "Control"
        '
        'ColorBaranda
        '
        Me.ColorBaranda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorBaranda.Location = New System.Drawing.Point(500, 3)
        Me.ColorBaranda.Name = "ColorBaranda"
        Me.ColorBaranda.Size = New System.Drawing.Size(44, 19)
        Me.ColorBaranda.TabIndex = 61
        Me.ColorBaranda.Text = "Control"
        '
        'ColorTolvaVolteo
        '
        Me.ColorTolvaVolteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTolvaVolteo.Location = New System.Drawing.Point(627, 26)
        Me.ColorTolvaVolteo.Name = "ColorTolvaVolteo"
        Me.ColorTolvaVolteo.Size = New System.Drawing.Size(44, 19)
        Me.ColorTolvaVolteo.TabIndex = 55
        Me.ColorTolvaVolteo.Text = "Control"
        '
        'ColorGranelero
        '
        Me.ColorGranelero.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorGranelero.Location = New System.Drawing.Point(297, 3)
        Me.ColorGranelero.Name = "ColorGranelero"
        Me.ColorGranelero.Size = New System.Drawing.Size(44, 19)
        Me.ColorGranelero.TabIndex = 53
        Me.ColorGranelero.Text = "Control"
        '
        'ColorFurgon
        '
        Me.ColorFurgon.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgon.Location = New System.Drawing.Point(189, 3)
        Me.ColorFurgon.Name = "ColorFurgon"
        Me.ColorFurgon.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgon.TabIndex = 49
        Me.ColorFurgon.Text = "Control"
        '
        'ColorFurgonLargo
        '
        Me.ColorFurgonLargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonLargo.Location = New System.Drawing.Point(98, 26)
        Me.ColorFurgonLargo.Name = "ColorFurgonLargo"
        Me.ColorFurgonLargo.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonLargo.TabIndex = 69
        Me.ColorFurgonLargo.Text = "Control"
        '
        'ColorFurgonAmericano
        '
        Me.ColorFurgonAmericano.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonAmericano.Location = New System.Drawing.Point(97, 3)
        Me.ColorFurgonAmericano.Name = "ColorFurgonAmericano"
        Me.ColorFurgonAmericano.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonAmericano.TabIndex = 59
        Me.ColorFurgonAmericano.Text = "Control"
        '
        'ColorCisterna
        '
        Me.ColorCisterna.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCisterna.Location = New System.Drawing.Point(402, 3)
        Me.ColorCisterna.Name = "ColorCisterna"
        Me.ColorCisterna.Size = New System.Drawing.Size(44, 19)
        Me.ColorCisterna.TabIndex = 47
        Me.ColorCisterna.Text = "Control"
        '
        'ColorBomboma
        '
        Me.ColorBomboma.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorBomboma.Location = New System.Drawing.Point(500, 26)
        Me.ColorBomboma.Name = "ColorBomboma"
        Me.ColorBomboma.Size = New System.Drawing.Size(44, 19)
        Me.ColorBomboma.TabIndex = 63
        Me.ColorBomboma.Text = "Control"
        '
        'ColorCalicera
        '
        Me.ColorCalicera.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCalicera.Location = New System.Drawing.Point(189, 26)
        Me.ColorCalicera.Name = "ColorCalicera"
        Me.ColorCalicera.Size = New System.Drawing.Size(44, 19)
        Me.ColorCalicera.TabIndex = 51
        Me.ColorCalicera.Text = "Control"
        '
        'ColorMediaBaranda
        '
        Me.ColorMediaBaranda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorMediaBaranda.Location = New System.Drawing.Point(627, 3)
        Me.ColorMediaBaranda.Name = "ColorMediaBaranda"
        Me.ColorMediaBaranda.Size = New System.Drawing.Size(44, 19)
        Me.ColorMediaBaranda.TabIndex = 71
        Me.ColorMediaBaranda.Text = "Control"
        '
        'Color30M3
        '
        Me.Color30M3.AutoSize = True
        Me.Color30M3.BackColor = System.Drawing.Color.Transparent
        Me.Color30M3.Location = New System.Drawing.Point(447, 28)
        Me.Color30M3.Name = "Color30M3"
        Me.Color30M3.Size = New System.Drawing.Size(57, 13)
        Me.Color30M3.TabIndex = 87
        Me.Color30M3.Text = "Bomboma:"
        '
        'Color20M3
        '
        Me.Color20M3.AutoSize = True
        Me.Color20M3.BackColor = System.Drawing.Color.Transparent
        Me.Color20M3.Location = New System.Drawing.Point(453, 5)
        Me.Color20M3.Name = "Color20M3"
        Me.Color20M3.Size = New System.Drawing.Size(51, 13)
        Me.Color20M3.TabIndex = 86
        Me.Color20M3.Text = "Baranda:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(1, 5)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 13)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "Furgon Americano:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(355, 5)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 13)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "Cisterna:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(546, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 13)
        Me.Label23.TabIndex = 82
        Me.Label23.Text = "Tolva de Volteo:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(236, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 13)
        Me.Label22.TabIndex = 81
        Me.Label22.Text = "Parihuelero:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(243, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 13)
        Me.Label21.TabIndex = 80
        Me.Label21.Text = "Granelero:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(144, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Calicera:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(148, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Furgon:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(549, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 13)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "Media Baranda:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(25, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = "Furgon Largo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(343, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Plataforma:"
        '
        'tapMantenimientoDespacho
        '
        Me.tapMantenimientoDespacho.Controls.Add(Me.UltraGroupBox2)
        Me.tapMantenimientoDespacho.Location = New System.Drawing.Point(-10000, -10000)
        Me.tapMantenimientoDespacho.Name = "tapMantenimientoDespacho"
        Me.tapMantenimientoDespacho.Size = New System.Drawing.Size(1080, 515)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.griDetalles)
        Me.UltraGroupBox2.Controls.Add(Me.tspDespacho)
        Me.UltraGroupBox2.Controls.Add(Me.ugbTotalesMantenimiento)
        Me.UltraGroupBox2.Controls.Add(Me.ugbDespacho)
        Me.UltraGroupBox2.Controls.Add(Me.expGenerarDesde)
        Me.UltraGroupBox2.Controls.Add(Me.UltraExpandableGroupBox6)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1080, 515)
        Me.UltraGroupBox2.TabIndex = 19
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetalles
        '
        Me.griDetalles.DataSource = Me.udsDespachoOperaciones
        Appearance92.BackColor = System.Drawing.Color.White
        Me.griDetalles.DisplayLayout.Appearance = Appearance92
        UltraGridColumn2237.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn2237.Header.Caption = ""
        UltraGridColumn2237.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn2237.Header.VisiblePosition = 0
        UltraGridColumn2237.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2237.Width = 30
        UltraGridColumn2238.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2238.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2238.Header.VisiblePosition = 1
        UltraGridColumn2238.Hidden = True
        UltraGridColumn2239.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2239.Header.VisiblePosition = 2
        UltraGridColumn2239.Hidden = True
        UltraGridColumn2240.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2240.Header.VisiblePosition = 3
        UltraGridColumn2241.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2241.Header.VisiblePosition = 4
        UltraGridColumn2241.Width = 213
        UltraGridColumn2242.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2242.Header.VisiblePosition = 5
        UltraGridColumn2242.Width = 180
        UltraGridColumn2243.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2243.Header.VisiblePosition = 8
        UltraGridColumn2243.Width = 72
        UltraGridColumn2244.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2244.Header.VisiblePosition = 9
        UltraGridColumn2244.Hidden = True
        UltraGridColumn2245.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2245.Header.VisiblePosition = 10
        UltraGridColumn2246.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2246.Header.VisiblePosition = 11
        UltraGridColumn2246.Width = 69
        UltraGridColumn2247.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2247.Header.VisiblePosition = 12
        UltraGridColumn2247.Width = 83
        UltraGridColumn2248.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2248.Header.VisiblePosition = 14
        UltraGridColumn2248.Width = 157
        UltraGridColumn2249.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2249.Header.VisiblePosition = 15
        UltraGridColumn2249.Width = 157
        UltraGridColumn2250.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2250.Header.VisiblePosition = 16
        UltraGridColumn2250.Width = 98
        UltraGridColumn2251.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2251.Header.VisiblePosition = 18
        UltraGridColumn2251.Width = 266
        UltraGridColumn2252.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2252.Header.VisiblePosition = 19
        Appearance93.TextHAlignAsString = "Right"
        UltraGridColumn2253.CellAppearance = Appearance93
        UltraGridColumn2253.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2253.Format = "###,###0.00"
        UltraGridColumn2253.Header.VisiblePosition = 20
        UltraGridColumn2253.MaskInput = "{double:12.2}"
        UltraGridColumn2254.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2254.Header.VisiblePosition = 21
        UltraGridColumn2254.Width = 85
        UltraGridColumn2255.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance94.TextHAlignAsString = "Right"
        UltraGridColumn2255.CellAppearance = Appearance94
        UltraGridColumn2255.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2255.Format = "###,##0.00"
        UltraGridColumn2255.Header.VisiblePosition = 22
        UltraGridColumn2255.MaskInput = "{double:12.2}"
        UltraGridColumn2255.Width = 62
        UltraGridColumn2256.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2256.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn2256.Header.VisiblePosition = 23
        UltraGridColumn2256.Width = 218
        UltraGridColumn2257.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn2257.Format = "HH:mm"
        UltraGridColumn2257.Header.VisiblePosition = 24
        UltraGridColumn2257.MaskInput = "{LOC}hh:mm"
        UltraGridColumn2257.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn2257.Width = 46
        UltraGridColumn2258.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2258.Header.VisiblePosition = 25
        UltraGridColumn2258.Width = 161
        UltraGridColumn2259.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2259.Header.VisiblePosition = 26
        UltraGridColumn2259.Width = 166
        UltraGridColumn2260.Header.VisiblePosition = 27
        UltraGridColumn2260.Hidden = True
        UltraGridColumn2261.Header.VisiblePosition = 28
        UltraGridColumn2261.Hidden = True
        UltraGridColumn2262.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2262.Header.VisiblePosition = 17
        UltraGridColumn2262.Width = 237
        UltraGridColumn2263.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2263.Header.VisiblePosition = 29
        UltraGridColumn2263.Hidden = True
        UltraGridColumn2264.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2264.Header.VisiblePosition = 30
        UltraGridColumn2264.Hidden = True
        UltraGridColumn2265.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2265.Header.VisiblePosition = 31
        UltraGridColumn2265.Hidden = True
        UltraGridColumn2266.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2266.Header.VisiblePosition = 32
        UltraGridColumn2266.Hidden = True
        UltraGridColumn2267.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2267.Header.VisiblePosition = 13
        UltraGridColumn2267.Hidden = True
        UltraGridColumn2268.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2268.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn2268.Header.VisiblePosition = 6
        UltraGridColumn2269.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2269.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn2269.Header.VisiblePosition = 7
        UltraGridColumn2269.Width = 110
        UltraGridColumn2270.Header.VisiblePosition = 33
        UltraGridColumn2271.Header.VisiblePosition = 34
        UltraGridColumn2272.Header.VisiblePosition = 35
        UltraGridColumn2273.Header.VisiblePosition = 36
        UltraGridColumn2274.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2274.Header.VisiblePosition = 37
        UltraGridColumn2275.Header.VisiblePosition = 38
        UltraGridColumn2276.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2276.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2276.Header.VisiblePosition = 39
        UltraGridColumn2509.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2509.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2509.Header.VisiblePosition = 40
        UltraGridColumn2510.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2510.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2510.Header.VisiblePosition = 42
        UltraGridColumn2511.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2511.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2511.Header.VisiblePosition = 43
        UltraGridColumn2512.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2512.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2512.Header.VisiblePosition = 44
        UltraGridColumn2513.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2513.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2513.Header.VisiblePosition = 45
        UltraGridColumn2514.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2514.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2514.Header.VisiblePosition = 46
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn17.Header.VisiblePosition = 47
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn35.Header.VisiblePosition = 48
        UltraGridColumn2277.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        Appearance95.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        UltraGridColumn2277.CellButtonAppearance = Appearance95
        UltraGridColumn2277.Header.VisiblePosition = 41
        UltraGridColumn2277.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridBand18.Columns.AddRange(New Object() {UltraGridColumn2237, UltraGridColumn2238, UltraGridColumn2239, UltraGridColumn2240, UltraGridColumn2241, UltraGridColumn2242, UltraGridColumn2243, UltraGridColumn2244, UltraGridColumn2245, UltraGridColumn2246, UltraGridColumn2247, UltraGridColumn2248, UltraGridColumn2249, UltraGridColumn2250, UltraGridColumn2251, UltraGridColumn2252, UltraGridColumn2253, UltraGridColumn2254, UltraGridColumn2255, UltraGridColumn2256, UltraGridColumn2257, UltraGridColumn2258, UltraGridColumn2259, UltraGridColumn2260, UltraGridColumn2261, UltraGridColumn2262, UltraGridColumn2263, UltraGridColumn2264, UltraGridColumn2265, UltraGridColumn2266, UltraGridColumn2267, UltraGridColumn2268, UltraGridColumn2269, UltraGridColumn2270, UltraGridColumn2271, UltraGridColumn2272, UltraGridColumn2273, UltraGridColumn2274, UltraGridColumn2275, UltraGridColumn2276, UltraGridColumn2509, UltraGridColumn2510, UltraGridColumn2511, UltraGridColumn2512, UltraGridColumn2513, UltraGridColumn2514, UltraGridColumn17, UltraGridColumn35, UltraGridColumn2277})
        Me.griDetalles.DisplayLayout.BandsSerializer.Add(UltraGridBand18)
        Me.griDetalles.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalles.DisplayLayout.GroupByBox.Hidden = True
        Me.griDetalles.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalles.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDetalles.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalles.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalles.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalles.DisplayLayout.Override.CellPadding = 0
        Me.griDetalles.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalles.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalles.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalles.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance96.TextHAlignAsString = "Left"
        Me.griDetalles.DisplayLayout.Override.HeaderAppearance = Appearance96
        Me.griDetalles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalles.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance97.TextVAlignAsString = "Middle"
        Me.griDetalles.DisplayLayout.Override.RowAppearance = Appearance97
        Me.griDetalles.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalles.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griDetalles.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griDetalles.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalles.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalles.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalles.Location = New System.Drawing.Point(3, 289)
        Me.griDetalles.Name = "griDetalles"
        Me.griDetalles.Size = New System.Drawing.Size(1074, 223)
        Me.griDetalles.TabIndex = 4
        Me.griDetalles.Tag = ""
        '
        'tspDespacho
        '
        Me.tspDespacho.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspDespacho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarDespacho, Me.tsbQuitarDespacho})
        Me.tspDespacho.Location = New System.Drawing.Point(3, 264)
        Me.tspDespacho.Name = "tspDespacho"
        Me.tspDespacho.Size = New System.Drawing.Size(1074, 25)
        Me.tspDespacho.TabIndex = 3
        '
        'tsbAgregarDespacho
        '
        Me.tsbAgregarDespacho.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregarDespacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarDespacho.Name = "tsbAgregarDespacho"
        Me.tsbAgregarDespacho.Size = New System.Drawing.Size(69, 22)
        Me.tsbAgregarDespacho.Text = "Agregar"
        '
        'tsbQuitarDespacho
        '
        Me.tsbQuitarDespacho.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsbQuitarDespacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarDespacho.Name = "tsbQuitarDespacho"
        Me.tsbQuitarDespacho.Size = New System.Drawing.Size(60, 22)
        Me.tsbQuitarDespacho.Text = "Quitar"
        '
        'ugbTotalesMantenimiento
        '
        Me.ugbTotalesMantenimiento.Controls.Add(Me.uneProdProg)
        Me.ugbTotalesMantenimiento.Controls.Add(Me.Label12)
        Me.ugbTotalesMantenimiento.Controls.Add(Me.Label10)
        Me.ugbTotalesMantenimiento.Controls.Add(Me.uneProdReal)
        Me.ugbTotalesMantenimiento.Controls.Add(Me.uneProdTotal)
        Me.ugbTotalesMantenimiento.Controls.Add(Me.Label11)
        Me.ugbTotalesMantenimiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.ugbTotalesMantenimiento.Location = New System.Drawing.Point(3, 214)
        Me.ugbTotalesMantenimiento.Name = "ugbTotalesMantenimiento"
        Me.ugbTotalesMantenimiento.Size = New System.Drawing.Size(1074, 50)
        Me.ugbTotalesMantenimiento.TabIndex = 2
        Me.ugbTotalesMantenimiento.Text = "Totales"
        Me.ugbTotalesMantenimiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'uneProdProg
        '
        Me.uneProdProg.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uneProdProg.FormatString = "###,###,##0.00"
        Me.uneProdProg.Location = New System.Drawing.Point(131, 19)
        Me.uneProdProg.MaskInput = "{double:10.2}"
        Me.uneProdProg.Name = "uneProdProg"
        Me.uneProdProg.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneProdProg.ReadOnly = True
        Me.uneProdProg.Size = New System.Drawing.Size(112, 22)
        Me.uneProdProg.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(263, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Producción Real:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(9, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Producción Programada:"
        '
        'uneProdReal
        '
        Me.uneProdReal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uneProdReal.FormatString = "###,###,##0.00"
        Me.uneProdReal.Location = New System.Drawing.Point(350, 19)
        Me.uneProdReal.MaskInput = "{double:10.2}"
        Me.uneProdReal.Name = "uneProdReal"
        Me.uneProdReal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneProdReal.ReadOnly = True
        Me.uneProdReal.Size = New System.Drawing.Size(112, 22)
        Me.uneProdReal.TabIndex = 1
        '
        'uneProdTotal
        '
        Me.uneProdTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uneProdTotal.FormatString = "###,###,##0.00"
        Me.uneProdTotal.Location = New System.Drawing.Point(565, 19)
        Me.uneProdTotal.MaskInput = "{double:10.2}"
        Me.uneProdTotal.Name = "uneProdTotal"
        Me.uneProdTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneProdTotal.ReadOnly = True
        Me.uneProdTotal.Size = New System.Drawing.Size(112, 22)
        Me.uneProdTotal.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(477, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Producción Total:"
        '
        'ugbDespacho
        '
        Me.ugbDespacho.Controls.Add(Me.colorColumnaEstado)
        Me.ugbDespacho.Controls.Add(Me.colorMantUrgente)
        Me.ugbDespacho.Controls.Add(Me.colorCeldaResaltada)
        Me.ugbDespacho.Controls.Add(Me.colorMant)
        Me.ugbDespacho.Controls.Add(Me.colorCamposNoEncontrados)
        Me.ugbDespacho.Controls.Add(Me.Label20)
        Me.ugbDespacho.Controls.Add(Me.Label47)
        Me.ugbDespacho.Controls.Add(Me.txtZonaEditar)
        Me.ugbDespacho.Controls.Add(Me.Label46)
        Me.ugbDespacho.Controls.Add(Me.Label27)
        Me.ugbDespacho.Controls.Add(Me.txtGlosa)
        Me.ugbDespacho.Controls.Add(Me.Label14)
        Me.ugbDespacho.Controls.Add(Me.cboEstado)
        Me.ugbDespacho.Controls.Add(Me.Label13)
        Me.ugbDespacho.Controls.Add(Me.txtCodigo)
        Me.ugbDespacho.Controls.Add(Me.Label9)
        Me.ugbDespacho.Controls.Add(Me.dtpFecha)
        Me.ugbDespacho.Controls.Add(Me.Label8)
        Me.ugbDespacho.Controls.Add(Me.Label40)
        Me.ugbDespacho.Controls.Add(Me.Label41)
        Me.ugbDespacho.Dock = System.Windows.Forms.DockStyle.Top
        Me.ugbDespacho.Location = New System.Drawing.Point(3, 128)
        Me.ugbDespacho.Name = "ugbDespacho"
        Me.ugbDespacho.Size = New System.Drawing.Size(1074, 86)
        Me.ugbDespacho.TabIndex = 1
        Me.ugbDespacho.Text = "Datos Despacho"
        Me.ugbDespacho.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorColumnaEstado
        '
        Me.colorColumnaEstado.Color = System.Drawing.Color.PaleGreen
        Me.colorColumnaEstado.Location = New System.Drawing.Point(979, 24)
        Me.colorColumnaEstado.Name = "colorColumnaEstado"
        Me.colorColumnaEstado.Size = New System.Drawing.Size(46, 22)
        Me.colorColumnaEstado.TabIndex = 91
        Me.colorColumnaEstado.Text = "PaleGreen"
        '
        'colorMantUrgente
        '
        Me.colorMantUrgente.Color = System.Drawing.Color.OrangeRed
        Me.colorMantUrgente.Location = New System.Drawing.Point(862, 48)
        Me.colorMantUrgente.Name = "colorMantUrgente"
        Me.colorMantUrgente.Size = New System.Drawing.Size(46, 22)
        Me.colorMantUrgente.TabIndex = 33
        Me.colorMantUrgente.Text = "OrangeRed"
        '
        'colorCeldaResaltada
        '
        Me.colorCeldaResaltada.Color = System.Drawing.Color.DarkKhaki
        Me.colorCeldaResaltada.Location = New System.Drawing.Point(862, 23)
        Me.colorCeldaResaltada.Name = "colorCeldaResaltada"
        Me.colorCeldaResaltada.Size = New System.Drawing.Size(46, 22)
        Me.colorCeldaResaltada.TabIndex = 89
        Me.colorCeldaResaltada.Text = "DarkKhaki"
        '
        'colorMant
        '
        Me.colorMant.Color = System.Drawing.Color.MediumAquamarine
        Me.colorMant.Location = New System.Drawing.Point(736, 48)
        Me.colorMant.Name = "colorMant"
        Me.colorMant.Size = New System.Drawing.Size(46, 22)
        Me.colorMant.TabIndex = 31
        Me.colorMant.Text = "MediumAquamarine"
        '
        'colorCamposNoEncontrados
        '
        Me.colorCamposNoEncontrados.Color = System.Drawing.Color.LightBlue
        Me.colorCamposNoEncontrados.Location = New System.Drawing.Point(736, 25)
        Me.colorCamposNoEncontrados.Name = "colorCamposNoEncontrados"
        Me.colorCamposNoEncontrados.Size = New System.Drawing.Size(46, 22)
        Me.colorCamposNoEncontrados.TabIndex = 29
        Me.colorCamposNoEncontrados.Text = "LightBlue"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(612, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Campos No Encontrados:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(911, 28)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(72, 13)
        Me.Label47.TabIndex = 90
        Me.Label47.Text = "Color Estado:"
        '
        'txtZonaEditar
        '
        Me.txtZonaEditar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtZonaEditar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtZonaEditar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZonaEditar.Location = New System.Drawing.Point(445, 21)
        Me.txtZonaEditar.Name = "txtZonaEditar"
        Me.txtZonaEditar.ReadOnly = True
        Me.txtZonaEditar.Size = New System.Drawing.Size(133, 23)
        Me.txtZonaEditar.TabIndex = 2
        Me.txtZonaEditar.TabStop = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(783, 28)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(83, 13)
        Me.Label46.TabIndex = 88
        Me.Label46.Text = "Origen/Destino:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(353, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(92, 14)
        Me.Label27.TabIndex = 36
        Me.Label27.Text = "Zona a Editar:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Location = New System.Drawing.Point(220, 55)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(358, 22)
        Me.txtGlosa.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(182, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Glosa:"
        '
        'cboEstado
        '
        Me.cboEstado.DisplayMember = "Nombre"
        Me.cboEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstado.Location = New System.Drawing.Point(220, 23)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.ReadOnly = True
        Me.cboEstado.Size = New System.Drawing.Size(120, 22)
        Me.cboEstado.TabIndex = 1
        Me.cboEstado.ValueMember = "Id"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(175, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Estado:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Location = New System.Drawing.Point(47, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(117, 22)
        Me.txtCodigo.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(3, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Código:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(47, 56)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(117, 21)
        Me.dtpFecha.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(7, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Fecha:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(659, 53)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(81, 13)
        Me.Label40.TabIndex = 30
        Me.Label40.Text = "Mantenimiento:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(785, 53)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(81, 13)
        Me.Label41.TabIndex = 32
        Me.Label41.Text = "Mant. Urgente:"
        '
        'expGenerarDesde
        '
        Me.expGenerarDesde.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.expGenerarDesde.Dock = System.Windows.Forms.DockStyle.Top
        Me.expGenerarDesde.ExpandedSize = New System.Drawing.Size(1074, 50)
        Me.expGenerarDesde.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.expGenerarDesde.Location = New System.Drawing.Point(3, 78)
        Me.expGenerarDesde.Name = "expGenerarDesde"
        Me.expGenerarDesde.Size = New System.Drawing.Size(1074, 50)
        Me.expGenerarDesde.TabIndex = 0
        Me.expGenerarDesde.Text = "Generar Desde..."
        Me.expGenerarDesde.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.rbtNinguno)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.btnGenerarDesde)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.rbtImportarExcel)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.rbtUltimoDespacho)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.rbtUltimosViajes)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(1068, 27)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'rbtNinguno
        '
        Me.rbtNinguno.AutoSize = True
        Me.rbtNinguno.BackColor = System.Drawing.Color.Transparent
        Me.rbtNinguno.Checked = True
        Me.rbtNinguno.ForeColor = System.Drawing.Color.Navy
        Me.rbtNinguno.Location = New System.Drawing.Point(6, 4)
        Me.rbtNinguno.Name = "rbtNinguno"
        Me.rbtNinguno.Size = New System.Drawing.Size(64, 17)
        Me.rbtNinguno.TabIndex = 0
        Me.rbtNinguno.TabStop = True
        Me.rbtNinguno.Text = "Ninguno"
        Me.rbtNinguno.UseVisualStyleBackColor = False
        '
        'btnGenerarDesde
        '
        Me.btnGenerarDesde.AutoSize = True
        Me.btnGenerarDesde.Location = New System.Drawing.Point(393, 0)
        Me.btnGenerarDesde.Name = "btnGenerarDesde"
        Me.btnGenerarDesde.Size = New System.Drawing.Size(52, 25)
        Me.btnGenerarDesde.TabIndex = 4
        Me.btnGenerarDesde.Text = "Aceptar"
        '
        'rbtImportarExcel
        '
        Me.rbtImportarExcel.AutoSize = True
        Me.rbtImportarExcel.BackColor = System.Drawing.Color.Transparent
        Me.rbtImportarExcel.ForeColor = System.Drawing.Color.Navy
        Me.rbtImportarExcel.Location = New System.Drawing.Point(293, 3)
        Me.rbtImportarExcel.Name = "rbtImportarExcel"
        Me.rbtImportarExcel.Size = New System.Drawing.Size(95, 17)
        Me.rbtImportarExcel.TabIndex = 3
        Me.rbtImportarExcel.Text = "Importar Excel"
        Me.rbtImportarExcel.UseVisualStyleBackColor = False
        '
        'rbtUltimoDespacho
        '
        Me.rbtUltimoDespacho.AutoSize = True
        Me.rbtUltimoDespacho.BackColor = System.Drawing.Color.Transparent
        Me.rbtUltimoDespacho.ForeColor = System.Drawing.Color.Navy
        Me.rbtUltimoDespacho.Location = New System.Drawing.Point(184, 3)
        Me.rbtUltimoDespacho.Name = "rbtUltimoDespacho"
        Me.rbtUltimoDespacho.Size = New System.Drawing.Size(104, 17)
        Me.rbtUltimoDespacho.TabIndex = 2
        Me.rbtUltimoDespacho.Text = "Último Despacho"
        Me.rbtUltimoDespacho.UseVisualStyleBackColor = False
        '
        'rbtUltimosViajes
        '
        Me.rbtUltimosViajes.AutoSize = True
        Me.rbtUltimosViajes.BackColor = System.Drawing.Color.Transparent
        Me.rbtUltimosViajes.ForeColor = System.Drawing.Color.Navy
        Me.rbtUltimosViajes.Location = New System.Drawing.Point(72, 4)
        Me.rbtUltimosViajes.Name = "rbtUltimosViajes"
        Me.rbtUltimosViajes.Size = New System.Drawing.Size(110, 17)
        Me.rbtUltimosViajes.TabIndex = 1
        Me.rbtUltimosViajes.Text = "Últimos Viajes SGI"
        Me.rbtUltimosViajes.UseVisualStyleBackColor = False
        '
        'UltraExpandableGroupBox6
        '
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(1074, 75)
        Me.UltraExpandableGroupBox6.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(1074, 75)
        Me.UltraExpandableGroupBox6.TabIndex = 56
        Me.UltraExpandableGroupBox6.Text = "Colores Modelo Funcional Carreta"
        Me.UltraExpandableGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.PlataformaM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.BarandaM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.TolvaVolteoM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.CisternaM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.BombomaM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.MediaBarandaM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.ParihueleroM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.GraneleroM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.FurgonLargoM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.FurgonAmericanoM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.CaliceraM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.FurgonM)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label28)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label29)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label30)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label31)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label32)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label33)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label34)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label35)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label37)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label38)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label39)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Label36)
        Me.UltraExpandableGroupBoxPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(1068, 52)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        '
        'PlataformaM
        '
        Me.PlataformaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlataformaM.Location = New System.Drawing.Point(408, 28)
        Me.PlataformaM.Name = "PlataformaM"
        Me.PlataformaM.Size = New System.Drawing.Size(44, 19)
        Me.PlataformaM.TabIndex = 45
        Me.PlataformaM.Text = "Control"
        '
        'BarandaM
        '
        Me.BarandaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarandaM.Location = New System.Drawing.Point(509, 5)
        Me.BarandaM.Name = "BarandaM"
        Me.BarandaM.Size = New System.Drawing.Size(44, 19)
        Me.BarandaM.TabIndex = 61
        Me.BarandaM.Text = "Control"
        '
        'TolvaVolteoM
        '
        Me.TolvaVolteoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TolvaVolteoM.Location = New System.Drawing.Point(637, 28)
        Me.TolvaVolteoM.Name = "TolvaVolteoM"
        Me.TolvaVolteoM.Size = New System.Drawing.Size(44, 19)
        Me.TolvaVolteoM.TabIndex = 55
        Me.TolvaVolteoM.Text = "Control"
        '
        'CisternaM
        '
        Me.CisternaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CisternaM.Location = New System.Drawing.Point(408, 5)
        Me.CisternaM.Name = "CisternaM"
        Me.CisternaM.Size = New System.Drawing.Size(44, 19)
        Me.CisternaM.TabIndex = 47
        Me.CisternaM.Text = "Control"
        '
        'BombomaM
        '
        Me.BombomaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BombomaM.Location = New System.Drawing.Point(509, 28)
        Me.BombomaM.Name = "BombomaM"
        Me.BombomaM.Size = New System.Drawing.Size(44, 19)
        Me.BombomaM.TabIndex = 63
        Me.BombomaM.Text = "Control"
        '
        'MediaBarandaM
        '
        Me.MediaBarandaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MediaBarandaM.Location = New System.Drawing.Point(637, 5)
        Me.MediaBarandaM.Name = "MediaBarandaM"
        Me.MediaBarandaM.Size = New System.Drawing.Size(44, 19)
        Me.MediaBarandaM.TabIndex = 71
        Me.MediaBarandaM.Text = "Control"
        '
        'ParihueleroM
        '
        Me.ParihueleroM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParihueleroM.Location = New System.Drawing.Point(301, 28)
        Me.ParihueleroM.Name = "ParihueleroM"
        Me.ParihueleroM.Size = New System.Drawing.Size(44, 19)
        Me.ParihueleroM.TabIndex = 73
        Me.ParihueleroM.Text = "Control"
        '
        'GraneleroM
        '
        Me.GraneleroM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraneleroM.Location = New System.Drawing.Point(301, 5)
        Me.GraneleroM.Name = "GraneleroM"
        Me.GraneleroM.Size = New System.Drawing.Size(44, 19)
        Me.GraneleroM.TabIndex = 53
        Me.GraneleroM.Text = "Control"
        '
        'FurgonLargoM
        '
        Me.FurgonLargoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FurgonLargoM.Location = New System.Drawing.Point(99, 28)
        Me.FurgonLargoM.Name = "FurgonLargoM"
        Me.FurgonLargoM.Size = New System.Drawing.Size(44, 19)
        Me.FurgonLargoM.TabIndex = 69
        Me.FurgonLargoM.Text = "Control"
        '
        'FurgonAmericanoM
        '
        Me.FurgonAmericanoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FurgonAmericanoM.Location = New System.Drawing.Point(99, 5)
        Me.FurgonAmericanoM.Name = "FurgonAmericanoM"
        Me.FurgonAmericanoM.Size = New System.Drawing.Size(44, 19)
        Me.FurgonAmericanoM.TabIndex = 59
        Me.FurgonAmericanoM.Text = "Control"
        '
        'CaliceraM
        '
        Me.CaliceraM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaliceraM.Location = New System.Drawing.Point(193, 28)
        Me.CaliceraM.Name = "CaliceraM"
        Me.CaliceraM.Size = New System.Drawing.Size(44, 19)
        Me.CaliceraM.TabIndex = 51
        Me.CaliceraM.Text = "Control"
        '
        'FurgonM
        '
        Me.FurgonM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FurgonM.Location = New System.Drawing.Point(193, 5)
        Me.FurgonM.Name = "FurgonM"
        Me.FurgonM.Size = New System.Drawing.Size(44, 19)
        Me.FurgonM.TabIndex = 49
        Me.FurgonM.Text = "Control"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(455, 30)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 13)
        Me.Label28.TabIndex = 87
        Me.Label28.Text = "Bomboma:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(461, 7)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(51, 13)
        Me.Label29.TabIndex = 86
        Me.Label29.Text = "Baranda:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(3, 7)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(98, 13)
        Me.Label30.TabIndex = 84
        Me.Label30.Text = "Furgon Americano:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(360, 7)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 13)
        Me.Label31.TabIndex = 83
        Me.Label31.Text = "Cisterna:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(555, 30)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(85, 13)
        Me.Label32.TabIndex = 82
        Me.Label32.Text = "Tolva de Volteo:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(240, 30)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 13)
        Me.Label33.TabIndex = 81
        Me.Label33.Text = "Parihuelero:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(247, 7)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(58, 13)
        Me.Label34.TabIndex = 80
        Me.Label34.Text = "Granelero:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(148, 30)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(49, 13)
        Me.Label35.TabIndex = 78
        Me.Label35.Text = "Calicera:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.ForeColor = System.Drawing.Color.Navy
        Me.Label37.Location = New System.Drawing.Point(558, 7)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(82, 13)
        Me.Label37.TabIndex = 76
        Me.Label37.Text = "Media Baranda:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(27, 30)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(75, 13)
        Me.Label38.TabIndex = 75
        Me.Label38.Text = "Furgon Largo:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(348, 30)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(63, 13)
        Me.Label39.TabIndex = 74
        Me.Label39.Text = "Plataforma:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.ForeColor = System.Drawing.Color.Navy
        Me.Label36.Location = New System.Drawing.Point(152, 7)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(45, 13)
        Me.Label36.TabIndex = 77
        Me.Label36.Text = "Furgon:"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion9)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1082, 538)
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.griDisponibleVehiculo)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 102)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(1082, 436)
        Me.Agrupacion9.TabIndex = 4
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griDisponibleVehiculo
        '
        Me.griDisponibleVehiculo.ContextMenuStrip = Me.MenuOperacion
        Me.griDisponibleVehiculo.DataSource = Me.ogdDisponibleVehiculos
        UltraGridColumn2318.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn2318.GroupByMode = Infragistics.Win.UltraWinGrid.GroupByMode.Value
        UltraGridColumn2318.Header.VisiblePosition = 0
        UltraGridColumn2318.Hidden = True
        UltraGridColumn2319.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn2319.GroupByMode = Infragistics.Win.UltraWinGrid.GroupByMode.Value
        UltraGridColumn2319.Header.VisiblePosition = 2
        UltraGridColumn2319.Hidden = True
        UltraGridColumn2319.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2319.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2319.Width = 109
        UltraGridColumn2320.Header.VisiblePosition = 3
        UltraGridColumn2320.Hidden = True
        UltraGridColumn2321.Header.Caption = "Viaje"
        UltraGridColumn2321.Header.VisiblePosition = 4
        UltraGridColumn2321.Hidden = True
        UltraGridColumn2321.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn2321.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2321.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2321.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2321.Width = 87
        UltraGridColumn2322.Header.VisiblePosition = 5
        UltraGridColumn2322.Hidden = True
        UltraGridColumn2323.Header.VisiblePosition = 12
        UltraGridColumn2323.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn2323.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2323.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2323.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2323.Width = 100
        UltraGridColumn2324.Header.VisiblePosition = 14
        UltraGridColumn2324.Hidden = True
        UltraGridColumn2325.Header.Caption = "Disponible En"
        UltraGridColumn2325.Header.VisiblePosition = 13
        UltraGridColumn2325.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn2325.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2325.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2325.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2325.Width = 100
        UltraGridColumn2326.Header.VisiblePosition = 15
        UltraGridColumn2326.Hidden = True
        UltraGridColumn2327.Header.VisiblePosition = 16
        UltraGridColumn2327.Hidden = True
        UltraGridColumn2327.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn2327.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2327.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2327.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2327.Width = 124
        UltraGridColumn2328.Header.VisiblePosition = 31
        UltraGridColumn2328.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn2328.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2328.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2328.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2328.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2328.Width = 50
        UltraGridColumn2329.Header.VisiblePosition = 17
        UltraGridColumn2329.Hidden = True
        Appearance46.Image = 7
        UltraGridColumn2330.CellAppearance = Appearance46
        Appearance47.Image = 3
        UltraGridColumn2330.CellButtonAppearance = Appearance47
        UltraGridColumn2330.Header.VisiblePosition = 8
        UltraGridColumn2330.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn2330.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2330.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2330.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2330.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn2330.Width = 200
        UltraGridColumn2331.Header.VisiblePosition = 26
        UltraGridColumn2331.Hidden = True
        UltraGridColumn2332.Header.VisiblePosition = 9
        UltraGridColumn2332.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn2332.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2332.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2332.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2332.Width = 212
        UltraGridColumn2333.Header.VisiblePosition = 27
        UltraGridColumn2333.Hidden = True
        UltraGridColumn2334.Header.VisiblePosition = 36
        UltraGridColumn2334.Hidden = True
        UltraGridColumn2334.Width = 223
        UltraGridColumn2335.Header.VisiblePosition = 28
        UltraGridColumn2335.Hidden = True
        Appearance48.Image = 7
        UltraGridColumn2336.CellAppearance = Appearance48
        Appearance49.Image = 3
        UltraGridColumn2336.CellButtonAppearance = Appearance49
        UltraGridColumn2336.Header.VisiblePosition = 10
        UltraGridColumn2336.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn2336.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2336.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2336.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2336.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn2336.Width = 70
        UltraGridColumn2337.Header.VisiblePosition = 29
        UltraGridColumn2337.Hidden = True
        UltraGridColumn2338.Header.VisiblePosition = 11
        UltraGridColumn2338.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn2338.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2338.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2338.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2338.Width = 60
        UltraGridColumn2339.Header.VisiblePosition = 32
        UltraGridColumn2339.Hidden = True
        UltraGridColumn2340.Header.VisiblePosition = 30
        UltraGridColumn2340.Hidden = True
        UltraGridColumn2341.Header.VisiblePosition = 18
        UltraGridColumn2341.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn2341.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2341.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2341.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2341.Width = 80
        UltraGridColumn2342.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2342.Format = "dd/MM/yyyy hh:mm tt"
        UltraGridColumn2342.Header.VisiblePosition = 6
        UltraGridColumn2342.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn2342.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2342.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2342.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2342.Width = 120
        UltraGridColumn2343.Header.VisiblePosition = 33
        UltraGridColumn2343.Hidden = True
        UltraGridColumn2344.Header.VisiblePosition = 34
        UltraGridColumn2344.Hidden = True
        UltraGridColumn2345.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn2345.Header.Caption = "Select"
        UltraGridColumn2345.Header.VisiblePosition = 1
        UltraGridColumn2345.Hidden = True
        UltraGridColumn2345.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2345.Width = 35
        UltraGridColumn2346.Header.VisiblePosition = 35
        UltraGridColumn2346.Hidden = True
        UltraGridColumn2347.Header.VisiblePosition = 23
        UltraGridColumn2347.Width = 100
        UltraGridColumn2348.Header.VisiblePosition = 37
        UltraGridColumn2348.Hidden = True
        UltraGridColumn2349.Header.VisiblePosition = 38
        UltraGridColumn2349.Hidden = True
        UltraGridColumn2350.Header.VisiblePosition = 39
        UltraGridColumn2350.Hidden = True
        UltraGridColumn2351.Header.VisiblePosition = 40
        UltraGridColumn2351.Hidden = True
        UltraGridColumn2352.Header.VisiblePosition = 19
        UltraGridColumn2352.Width = 200
        Appearance50.Image = 3
        Appearance50.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn2353.CellAppearance = Appearance50
        Appearance51.Image = 1
        UltraGridColumn2353.CellButtonAppearance = Appearance51
        UltraGridColumn2353.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn2353.Header.Caption = "Comentario - Observacion"
        UltraGridColumn2353.Header.VisiblePosition = 22
        UltraGridColumn2353.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn2353.Width = 300
        UltraGridColumn2354.Header.VisiblePosition = 41
        UltraGridColumn2354.Hidden = True
        UltraGridColumn2355.Header.VisiblePosition = 42
        UltraGridColumn2355.Hidden = True
        UltraGridColumn2356.Header.VisiblePosition = 43
        UltraGridColumn2356.Hidden = True
        UltraGridColumn2357.Header.VisiblePosition = 44
        UltraGridColumn2357.Hidden = True
        UltraGridColumn2357.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn2357.Width = 100
        UltraGridColumn2358.Header.VisiblePosition = 45
        UltraGridColumn2358.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn2358.Width = 100
        UltraGridColumn2359.Header.VisiblePosition = 46
        UltraGridColumn2359.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn2359.Width = 100
        UltraGridColumn2360.Header.VisiblePosition = 47
        UltraGridColumn2360.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn2360.Width = 100
        UltraGridColumn2361.Header.VisiblePosition = 25
        UltraGridColumn2361.Width = 100
        UltraGridColumn2362.Header.Caption = "Bloque"
        UltraGridColumn2362.Header.VisiblePosition = 24
        UltraGridColumn2362.Hidden = True
        UltraGridColumn2362.Width = 35
        UltraGridColumn2363.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance52.TextHAlignAsString = "Right"
        UltraGridColumn2363.CellAppearance = Appearance52
        UltraGridColumn2363.Format = "###,###,##0.00"
        UltraGridColumn2363.Header.Caption = "TN"
        UltraGridColumn2363.Header.VisiblePosition = 21
        UltraGridColumn2363.Width = 50
        UltraGridColumn2364.Header.VisiblePosition = 7
        UltraGridColumn2364.Width = 80
        UltraGridColumn2365.Header.VisiblePosition = 20
        UltraGridColumn2366.Header.VisiblePosition = 48
        UltraGridColumn2366.Hidden = True
        UltraGridColumn2366.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2366.Width = 50
        UltraGridColumn2367.Header.VisiblePosition = 49
        UltraGridColumn2367.Hidden = True
        UltraGridColumn2368.Header.VisiblePosition = 50
        UltraGridColumn2368.Hidden = True
        UltraGridColumn2369.Header.VisiblePosition = 51
        UltraGridColumn2369.Hidden = True
        UltraGridColumn2370.Header.VisiblePosition = 52
        UltraGridColumn2370.Hidden = True
        UltraGridColumn2371.Header.VisiblePosition = 53
        UltraGridColumn2371.Hidden = True
        UltraGridColumn2372.Header.VisiblePosition = 54
        UltraGridColumn2372.Hidden = True
        UltraGridColumn2373.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn2373.CellAppearance = Appearance53
        UltraGridColumn2373.Format = "###,###,##0.00"
        UltraGridColumn2373.Header.Caption = "Capacidad"
        UltraGridColumn2373.Header.VisiblePosition = 55
        UltraGridColumn2373.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn2373.Width = 50
        UltraGridColumn2374.Header.VisiblePosition = 56
        UltraGridColumn2374.Hidden = True
        UltraGridColumn2375.Header.VisiblePosition = 57
        UltraGridColumn2375.Hidden = True
        UltraGridColumn2376.Header.VisiblePosition = 58
        UltraGridColumn2376.Hidden = True
        UltraGridColumn2377.Header.VisiblePosition = 59
        UltraGridColumn2377.Hidden = True
        UltraGridColumn2378.Header.VisiblePosition = 60
        UltraGridColumn2378.Hidden = True
        UltraGridColumn2379.Header.VisiblePosition = 61
        UltraGridColumn2379.Hidden = True
        UltraGridColumn2380.Header.VisiblePosition = 62
        UltraGridColumn2380.Hidden = True
        UltraGridColumn2381.Header.VisiblePosition = 63
        UltraGridColumn2381.Hidden = True
        UltraGridColumn2382.Header.VisiblePosition = 64
        UltraGridColumn2382.Hidden = True
        UltraGridColumn2383.Header.VisiblePosition = 65
        UltraGridColumn2383.Hidden = True
        UltraGridColumn2384.Header.VisiblePosition = 66
        UltraGridColumn2384.Hidden = True
        UltraGridColumn2385.Header.VisiblePosition = 67
        UltraGridColumn2385.Hidden = True
        UltraGridColumn2386.Header.VisiblePosition = 68
        UltraGridColumn2386.Hidden = True
        UltraGridColumn2387.Header.VisiblePosition = 69
        UltraGridColumn2387.Hidden = True
        UltraGridColumn2388.Header.VisiblePosition = 70
        UltraGridColumn2388.Hidden = True
        UltraGridColumn2389.Header.VisiblePosition = 71
        UltraGridColumn2389.Hidden = True
        UltraGridColumn2390.Header.VisiblePosition = 72
        UltraGridColumn2390.Hidden = True
        UltraGridColumn2391.Header.VisiblePosition = 73
        UltraGridColumn2391.Hidden = True
        UltraGridColumn2392.Header.VisiblePosition = 74
        UltraGridColumn2392.Hidden = True
        UltraGridColumn2393.Header.VisiblePosition = 75
        UltraGridColumn2393.Hidden = True
        UltraGridColumn2394.Header.VisiblePosition = 76
        UltraGridColumn2394.Hidden = True
        UltraGridColumn2395.Header.VisiblePosition = 77
        UltraGridColumn2395.Hidden = True
        UltraGridColumn2396.Header.VisiblePosition = 78
        UltraGridColumn2396.Hidden = True
        UltraGridColumn2397.Header.VisiblePosition = 79
        UltraGridColumn2397.Hidden = True
        UltraGridBand16.Columns.AddRange(New Object() {UltraGridColumn2318, UltraGridColumn2319, UltraGridColumn2320, UltraGridColumn2321, UltraGridColumn2322, UltraGridColumn2323, UltraGridColumn2324, UltraGridColumn2325, UltraGridColumn2326, UltraGridColumn2327, UltraGridColumn2328, UltraGridColumn2329, UltraGridColumn2330, UltraGridColumn2331, UltraGridColumn2332, UltraGridColumn2333, UltraGridColumn2334, UltraGridColumn2335, UltraGridColumn2336, UltraGridColumn2337, UltraGridColumn2338, UltraGridColumn2339, UltraGridColumn2340, UltraGridColumn2341, UltraGridColumn2342, UltraGridColumn2343, UltraGridColumn2344, UltraGridColumn2345, UltraGridColumn2346, UltraGridColumn2347, UltraGridColumn2348, UltraGridColumn2349, UltraGridColumn2350, UltraGridColumn2351, UltraGridColumn2352, UltraGridColumn2353, UltraGridColumn2354, UltraGridColumn2355, UltraGridColumn2356, UltraGridColumn2357, UltraGridColumn2358, UltraGridColumn2359, UltraGridColumn2360, UltraGridColumn2361, UltraGridColumn2362, UltraGridColumn2363, UltraGridColumn2364, UltraGridColumn2365, UltraGridColumn2366, UltraGridColumn2367, UltraGridColumn2368, UltraGridColumn2369, UltraGridColumn2370, UltraGridColumn2371, UltraGridColumn2372, UltraGridColumn2373, UltraGridColumn2374, UltraGridColumn2375, UltraGridColumn2376, UltraGridColumn2377, UltraGridColumn2378, UltraGridColumn2379, UltraGridColumn2380, UltraGridColumn2381, UltraGridColumn2382, UltraGridColumn2383, UltraGridColumn2384, UltraGridColumn2385, UltraGridColumn2386, UltraGridColumn2387, UltraGridColumn2388, UltraGridColumn2389, UltraGridColumn2390, UltraGridColumn2391, UltraGridColumn2392, UltraGridColumn2393, UltraGridColumn2394, UltraGridColumn2395, UltraGridColumn2396, UltraGridColumn2397})
        UltraGridBand16.GroupHeadersVisible = False
        UltraGridBand16.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDisponibleVehiculo.DisplayLayout.BandsSerializer.Add(UltraGridBand16)
        Me.griDisponibleVehiculo.DisplayLayout.MaxColScrollRegions = 1
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDisponibleVehiculo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griDisponibleVehiculo.DisplayLayout.Override.CellPadding = 1
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDisponibleVehiculo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDisponibleVehiculo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDisponibleVehiculo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDisponibleVehiculo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDisponibleVehiculo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDisponibleVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDisponibleVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDisponibleVehiculo.ImageList = Me.imagenes
        Me.griDisponibleVehiculo.Location = New System.Drawing.Point(2, 2)
        Me.griDisponibleVehiculo.Name = "griDisponibleVehiculo"
        Me.griDisponibleVehiculo.Size = New System.Drawing.Size(1078, 432)
        Me.griDisponibleVehiculo.TabIndex = 1
        Me.griDisponibleVehiculo.Tag = ""
        '
        'MenuOperacion
        '
        Me.MenuOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuOperacion.ForeColor = System.Drawing.Color.Black
        Me.MenuOperacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Programar})
        Me.MenuOperacion.Name = "MenuContextual1"
        Me.MenuOperacion.Size = New System.Drawing.Size(149, 26)
        '
        'Programar
        '
        Me.Programar.Image = CType(resources.GetObject("Programar.Image"), System.Drawing.Image)
        Me.Programar.Name = "Programar"
        Me.Programar.Size = New System.Drawing.Size(148, 22)
        Me.Programar.Text = "Programar Viaje"
        Me.Programar.ToolTipText = "Programar Viaje de la Demanda seleccionada"
        '
        'ogdDisponibleVehiculos
        '
        UltraDataColumn73.DataType = GetType(Date)
        UltraDataColumn94.DataType = GetType(Double)
        UltraDataColumn104.DataType = GetType(Double)
        UltraDataColumn122.DataType = GetType(Date)
        UltraDataColumn126.DataType = GetType(Double)
        Me.ogdDisponibleVehiculos.Band.Columns.AddRange(New Object() {UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128})
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
        'UltraExpandableGroupBox2
        '
        Appearance54.BackColor = System.Drawing.Color.White
        Appearance54.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance54
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel8)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(1082, 102)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(1082, 102)
        Me.UltraExpandableGroupBox2.TabIndex = 3
        Me.UltraExpandableGroupBox2.Text = "Filtros"
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel8
        '
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.lblListoRegistro)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.UltraLabel11)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboRutaOrigen)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.UltraExpandableGroupBox5)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.exgruDisponibleNo)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboZonaDisponibles)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.UltraLabel59)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.btnConsultarDisponibles)
        Me.UltraExpandableGroupBoxPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel8.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel8.Name = "UltraExpandableGroupBoxPanel8"
        Me.UltraExpandableGroupBoxPanel8.Size = New System.Drawing.Size(1076, 79)
        Me.UltraExpandableGroupBoxPanel8.TabIndex = 0
        '
        'lblListoRegistro
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Appearance55.TextVAlignAsString = "Middle"
        Me.lblListoRegistro.Appearance = Appearance55
        Me.lblListoRegistro.AutoSize = True
        Me.lblListoRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListoRegistro.Location = New System.Drawing.Point(5, 64)
        Me.lblListoRegistro.Name = "lblListoRegistro"
        Me.lblListoRegistro.Size = New System.Drawing.Size(80, 14)
        Me.lblListoRegistro.TabIndex = 54
        Me.lblListoRegistro.Text = "Lista Registro:"
        '
        'UltraLabel11
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Appearance56.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance56
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(3, 3)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(77, 14)
        Me.UltraLabel11.TabIndex = 52
        Me.UltraLabel11.Text = "Disponible En:"
        '
        'cboRutaOrigen
        '
        Appearance57.ForeColor = System.Drawing.Color.Black
        Me.cboRutaOrigen.Appearance = Appearance57
        Me.cboRutaOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboRutaOrigen.DisplayMember = "Nombre"
        Me.cboRutaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRutaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRutaOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboRutaOrigen.ImageList = Me.imagenes
        Me.cboRutaOrigen.Location = New System.Drawing.Point(3, 17)
        Me.cboRutaOrigen.Name = "cboRutaOrigen"
        Me.cboRutaOrigen.Size = New System.Drawing.Size(200, 21)
        Me.cboRutaOrigen.TabIndex = 53
        UltraToolTipInfo1.ToolTipText = "Seleccione el lugar de origen de la demanda"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboRutaOrigen, UltraToolTipInfo1)
        Me.cboRutaOrigen.ValueMember = "Id"
        '
        'UltraExpandableGroupBox5
        '
        Me.UltraExpandableGroupBox5.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance58.BackColor = System.Drawing.Color.White
        Appearance58.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox5.ContentAreaAppearance = Appearance58
        Me.UltraExpandableGroupBox5.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.UltraExpandableGroupBox5.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox5.ExpandedSize = New System.Drawing.Size(585, 79)
        Me.UltraExpandableGroupBox5.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox5.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox5.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox5.Location = New System.Drawing.Point(251, 0)
        Me.UltraExpandableGroupBox5.Name = "UltraExpandableGroupBox5"
        Me.UltraExpandableGroupBox5.Size = New System.Drawing.Size(585, 79)
        Me.UltraExpandableGroupBox5.TabIndex = 51
        Me.UltraExpandableGroupBox5.Text = "T.V"
        UltraToolTipInfo3.ToolTipText = "Estados Viaje"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBox5, UltraToolTipInfo3)
        Me.UltraExpandableGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta47)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorParihueleroD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorPlataformaD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCamion20M3D)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta29)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta28)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorTolvaVolteoD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta27)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta25)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCamion65M3D)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorContenedorD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta222)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorGraneleroD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorFurgonD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorFurgonLargoD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta24)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta30)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta21)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCamionetaD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorVolqueteD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta31)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta32)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta23)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCamion30M3D)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta20)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta26)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCaliceraD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCamion40M3D)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta22)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorMediaBarandaD)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(562, 73)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        UltraToolTipInfo2.ToolTipText = "Estados"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBoxPanel4, UltraToolTipInfo2)
        '
        'Etiqueta47
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta47.Appearance = Appearance59
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta47.Location = New System.Drawing.Point(252, 23)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta47.TabIndex = 72
        Me.Etiqueta47.Text = "Parihuelero:"
        '
        'ColorParihueleroD
        '
        Me.ColorParihueleroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorParihueleroD.Location = New System.Drawing.Point(318, 19)
        Me.ColorParihueleroD.Name = "ColorParihueleroD"
        Me.ColorParihueleroD.Size = New System.Drawing.Size(44, 19)
        Me.ColorParihueleroD.TabIndex = 73
        Me.ColorParihueleroD.Text = "Control"
        '
        'ColorPlataformaD
        '
        Me.ColorPlataformaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPlataformaD.Location = New System.Drawing.Point(87, 0)
        Me.ColorPlataformaD.Name = "ColorPlataformaD"
        Me.ColorPlataformaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorPlataformaD.TabIndex = 45
        Me.ColorPlataformaD.Text = "Control"
        '
        'ColorCamion20M3D
        '
        Me.ColorCamion20M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion20M3D.Location = New System.Drawing.Point(514, 0)
        Me.ColorCamion20M3D.Name = "ColorCamion20M3D"
        Me.ColorCamion20M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion20M3D.TabIndex = 61
        Me.ColorCamion20M3D.Text = "Control"
        '
        'Etiqueta29
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance60
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta29.Location = New System.Drawing.Point(364, 23)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta29.TabIndex = 58
        Me.Etiqueta29.Text = "Camioneta:"
        '
        'Etiqueta28
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance61
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(155, 3)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta28.TabIndex = 48
        Me.Etiqueta28.Text = "Furgon:"
        '
        'ColorTolvaVolteoD
        '
        Me.ColorTolvaVolteoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTolvaVolteoD.Location = New System.Drawing.Point(318, 38)
        Me.ColorTolvaVolteoD.Name = "ColorTolvaVolteoD"
        Me.ColorTolvaVolteoD.Size = New System.Drawing.Size(44, 19)
        Me.ColorTolvaVolteoD.TabIndex = 55
        Me.ColorTolvaVolteoD.Text = "Control"
        '
        'Etiqueta27
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance62
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(373, 3)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta27.TabIndex = 46
        Me.Etiqueta27.Text = "Volquete:"
        '
        'Etiqueta25
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance63
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(259, 4)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta25.TabIndex = 52
        Me.Etiqueta25.Text = "Granelero:"
        '
        'ColorCamion65M3D
        '
        Me.ColorCamion65M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion65M3D.Location = New System.Drawing.Point(426, 38)
        Me.ColorCamion65M3D.Name = "ColorCamion65M3D"
        Me.ColorCamion65M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion65M3D.TabIndex = 67
        Me.ColorCamion65M3D.Text = "Control"
        '
        'ColorContenedorD
        '
        Me.ColorContenedorD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorContenedorD.Location = New System.Drawing.Point(200, 38)
        Me.ColorContenedorD.Name = "ColorContenedorD"
        Me.ColorContenedorD.Size = New System.Drawing.Size(44, 19)
        Me.ColorContenedorD.TabIndex = 57
        Me.ColorContenedorD.Text = "Control"
        '
        'Etiqueta222
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta222.Appearance = Appearance64
        Me.Etiqueta222.AutoSize = True
        Me.Etiqueta222.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta222.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta222.Location = New System.Drawing.Point(474, 3)
        Me.Etiqueta222.Name = "Etiqueta222"
        Me.Etiqueta222.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta222.TabIndex = 60
        Me.Etiqueta222.Text = "20 M3:"
        '
        'ColorGraneleroD
        '
        Me.ColorGraneleroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorGraneleroD.Location = New System.Drawing.Point(318, 0)
        Me.ColorGraneleroD.Name = "ColorGraneleroD"
        Me.ColorGraneleroD.Size = New System.Drawing.Size(44, 19)
        Me.ColorGraneleroD.TabIndex = 53
        Me.ColorGraneleroD.Text = "Control"
        '
        'ColorFurgonD
        '
        Me.ColorFurgonD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonD.Location = New System.Drawing.Point(200, 0)
        Me.ColorFurgonD.Name = "ColorFurgonD"
        Me.ColorFurgonD.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonD.TabIndex = 49
        Me.ColorFurgonD.Text = "Control"
        '
        'ColorFurgonLargoD
        '
        Me.ColorFurgonLargoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonLargoD.Location = New System.Drawing.Point(87, 19)
        Me.ColorFurgonLargoD.Name = "ColorFurgonLargoD"
        Me.ColorFurgonLargoD.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonLargoD.TabIndex = 69
        Me.ColorFurgonLargoD.Text = "Control"
        '
        'Etiqueta24
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance65
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(25, 3)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta24.TabIndex = 44
        Me.Etiqueta24.Text = "Plataforma:"
        '
        'Etiqueta30
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance66
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta30.Location = New System.Drawing.Point(247, 41)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta30.TabIndex = 54
        Me.Etiqueta30.Text = "Tolva Volteo:"
        '
        'Etiqueta21
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance67
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(366, 42)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta21.TabIndex = 66
        Me.Etiqueta21.Text = "65 / 50 M3:"
        '
        'ColorCamionetaD
        '
        Me.ColorCamionetaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamionetaD.Location = New System.Drawing.Point(426, 19)
        Me.ColorCamionetaD.Name = "ColorCamionetaD"
        Me.ColorCamionetaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamionetaD.TabIndex = 59
        Me.ColorCamionetaD.Text = "Control"
        '
        'ColorVolqueteD
        '
        Me.ColorVolqueteD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorVolqueteD.Location = New System.Drawing.Point(426, 0)
        Me.ColorVolqueteD.Name = "ColorVolqueteD"
        Me.ColorVolqueteD.Size = New System.Drawing.Size(44, 19)
        Me.ColorVolqueteD.TabIndex = 47
        Me.ColorVolqueteD.Text = "Control"
        '
        'Etiqueta31
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance68
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Location = New System.Drawing.Point(12, 22)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta31.TabIndex = 56
        Me.Etiqueta31.Text = "Furgon Largo:"
        '
        'Etiqueta32
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance69
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(3, 41)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(84, 14)
        Me.Etiqueta32.TabIndex = 70
        Me.Etiqueta32.Text = "Media Baranda:"
        '
        'Etiqueta23
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance70
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(474, 41)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta23.TabIndex = 64
        Me.Etiqueta23.Text = "40 M3:"
        '
        'ColorCamion30M3D
        '
        Me.ColorCamion30M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion30M3D.Location = New System.Drawing.Point(514, 19)
        Me.ColorCamion30M3D.Name = "ColorCamion30M3D"
        Me.ColorCamion30M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion30M3D.TabIndex = 63
        Me.ColorCamion30M3D.Text = "Control"
        '
        'Etiqueta20
        '
        Appearance71.BackColor = System.Drawing.Color.Transparent
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance71
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(133, 41)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta20.TabIndex = 68
        Me.Etiqueta20.Text = "Contenedor:"
        '
        'Etiqueta26
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance72
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(149, 23)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta26.TabIndex = 50
        Me.Etiqueta26.Text = "Calicera:"
        '
        'ColorCaliceraD
        '
        Me.ColorCaliceraD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCaliceraD.Location = New System.Drawing.Point(200, 19)
        Me.ColorCaliceraD.Name = "ColorCaliceraD"
        Me.ColorCaliceraD.Size = New System.Drawing.Size(44, 19)
        Me.ColorCaliceraD.TabIndex = 51
        Me.ColorCaliceraD.Text = "Control"
        '
        'ColorCamion40M3D
        '
        Me.ColorCamion40M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion40M3D.Location = New System.Drawing.Point(514, 38)
        Me.ColorCamion40M3D.Name = "ColorCamion40M3D"
        Me.ColorCamion40M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion40M3D.TabIndex = 65
        Me.ColorCamion40M3D.Text = "Control"
        '
        'Etiqueta22
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance73
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(474, 23)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta22.TabIndex = 62
        Me.Etiqueta22.Text = "30 M3:"
        '
        'ColorMediaBarandaD
        '
        Me.ColorMediaBarandaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorMediaBarandaD.Location = New System.Drawing.Point(87, 38)
        Me.ColorMediaBarandaD.Name = "ColorMediaBarandaD"
        Me.ColorMediaBarandaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorMediaBarandaD.TabIndex = 71
        Me.ColorMediaBarandaD.Text = "Control"
        '
        'exgruDisponibleNo
        '
        Me.exgruDisponibleNo.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance74.BackColor = System.Drawing.Color.White
        Appearance74.BackColor2 = System.Drawing.Color.White
        Me.exgruDisponibleNo.ContentAreaAppearance = Appearance74
        Me.exgruDisponibleNo.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.exgruDisponibleNo.Dock = System.Windows.Forms.DockStyle.Right
        Me.exgruDisponibleNo.ExpandedSize = New System.Drawing.Size(240, 79)
        Me.exgruDisponibleNo.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruDisponibleNo.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exgruDisponibleNo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.exgruDisponibleNo.Location = New System.Drawing.Point(836, 0)
        Me.exgruDisponibleNo.Name = "exgruDisponibleNo"
        Me.exgruDisponibleNo.Size = New System.Drawing.Size(240, 79)
        Me.exgruDisponibleNo.TabIndex = 50
        Me.exgruDisponibleNo.Text = "No"
        UltraToolTipInfo9.ToolTipText = "Trabajador / Vehiculos No Disponible"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.exgruDisponibleNo, UltraToolTipInfo9)
        Me.exgruDisponibleNo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorAdvertencia)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta19)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta15)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorPiloto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorAyudante)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorCarreta)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorTracto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorCopiloto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta14)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta18)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta17)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta16)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(217, 73)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        UltraToolTipInfo8.ToolTipText = "No Disponibles"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBoxPanel3, UltraToolTipInfo8)
        '
        'ColorAdvertencia
        '
        Me.ColorAdvertencia.Color = System.Drawing.Color.Red
        Me.ColorAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAdvertencia.Location = New System.Drawing.Point(69, 1)
        Me.ColorAdvertencia.Name = "ColorAdvertencia"
        Me.ColorAdvertencia.Size = New System.Drawing.Size(44, 19)
        Me.ColorAdvertencia.TabIndex = 24
        Me.ColorAdvertencia.Text = "Red"
        '
        'Etiqueta19
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance75
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(29, 22)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta19.TabIndex = 31
        Me.Etiqueta19.Text = "Tracto:"
        '
        'Etiqueta15
        '
        Appearance76.BackColor = System.Drawing.Color.White
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance76
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(2, 3)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta15.TabIndex = 23
        Me.Etiqueta15.Text = "Advertencia:"
        '
        'ColorPiloto
        '
        Me.ColorPiloto.Color = System.Drawing.Color.Lime
        Me.ColorPiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPiloto.Location = New System.Drawing.Point(170, 1)
        Me.ColorPiloto.Name = "ColorPiloto"
        Me.ColorPiloto.Size = New System.Drawing.Size(44, 19)
        Me.ColorPiloto.TabIndex = 30
        Me.ColorPiloto.Text = "Lime"
        UltraToolTipInfo4.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo4.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorPiloto, UltraToolTipInfo4)
        '
        'ColorAyudante
        '
        Me.ColorAyudante.Color = System.Drawing.Color.Blue
        Me.ColorAyudante.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAyudante.Location = New System.Drawing.Point(170, 39)
        Me.ColorAyudante.Name = "ColorAyudante"
        Me.ColorAyudante.Size = New System.Drawing.Size(44, 19)
        Me.ColorAyudante.TabIndex = 27
        Me.ColorAyudante.Text = "Blue"
        UltraToolTipInfo5.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo5.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorAyudante, UltraToolTipInfo5)
        '
        'ColorCarreta
        '
        Me.ColorCarreta.Color = System.Drawing.Color.Yellow
        Me.ColorCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCarreta.Location = New System.Drawing.Point(69, 39)
        Me.ColorCarreta.Name = "ColorCarreta"
        Me.ColorCarreta.Size = New System.Drawing.Size(44, 19)
        Me.ColorCarreta.TabIndex = 34
        Me.ColorCarreta.Text = "Yellow"
        '
        'ColorTracto
        '
        Me.ColorTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTracto.Location = New System.Drawing.Point(69, 20)
        Me.ColorTracto.Name = "ColorTracto"
        Me.ColorTracto.Size = New System.Drawing.Size(44, 19)
        Me.ColorTracto.TabIndex = 28
        Me.ColorTracto.Text = "Control"
        UltraToolTipInfo6.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo6.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorTracto, UltraToolTipInfo6)
        '
        'ColorCopiloto
        '
        Me.ColorCopiloto.Color = System.Drawing.Color.Aqua
        Me.ColorCopiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCopiloto.Location = New System.Drawing.Point(170, 20)
        Me.ColorCopiloto.Name = "ColorCopiloto"
        Me.ColorCopiloto.Size = New System.Drawing.Size(44, 19)
        Me.ColorCopiloto.TabIndex = 26
        Me.ColorCopiloto.Text = "Aqua"
        UltraToolTipInfo7.ToolTipText = "Color que especifica si el copiloto no se encuentra disponible para el viaje"
        UltraToolTipInfo7.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorCopiloto, UltraToolTipInfo7)
        '
        'Etiqueta14
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance77
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(134, 3)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta14.TabIndex = 29
        Me.Etiqueta14.Text = "Piloto:"
        '
        'Etiqueta18
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance78
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(115, 41)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta18.TabIndex = 32
        Me.Etiqueta18.Text = "Ayudante:"
        '
        'Etiqueta17
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance79
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(121, 23)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta17.TabIndex = 25
        Me.Etiqueta17.Text = "Copiloto:"
        '
        'Etiqueta16
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance80
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(24, 41)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta16.TabIndex = 33
        Me.Etiqueta16.Text = "Carreta:"
        '
        'cboZonaDisponibles
        '
        Appearance81.ForeColor = System.Drawing.Color.Black
        Me.cboZonaDisponibles.Appearance = Appearance81
        Me.cboZonaDisponibles.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboZonaDisponibles.DisplayMember = "Nombre"
        Me.cboZonaDisponibles.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboZonaDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZonaDisponibles.ForeColor = System.Drawing.Color.Black
        Me.cboZonaDisponibles.Location = New System.Drawing.Point(38, 40)
        Me.cboZonaDisponibles.Name = "cboZonaDisponibles"
        Me.cboZonaDisponibles.Size = New System.Drawing.Size(114, 21)
        Me.cboZonaDisponibles.TabIndex = 26
        Me.cboZonaDisponibles.ValueMember = "Id"
        '
        'UltraLabel59
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Appearance82.TextVAlignAsString = "Middle"
        Me.UltraLabel59.Appearance = Appearance82
        Me.UltraLabel59.AutoSize = True
        Me.UltraLabel59.Location = New System.Drawing.Point(3, 44)
        Me.UltraLabel59.Name = "UltraLabel59"
        Me.UltraLabel59.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel59.TabIndex = 25
        Me.UltraLabel59.Text = "Zona:"
        '
        'btnConsultarDisponibles
        '
        Appearance83.Image = "266.png"
        Appearance83.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance83.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnConsultarDisponibles.Appearance = Appearance83
        Me.btnConsultarDisponibles.ImageList = Me.imagenes
        Me.btnConsultarDisponibles.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnConsultarDisponibles.Location = New System.Drawing.Point(170, 39)
        Me.btnConsultarDisponibles.Name = "btnConsultarDisponibles"
        Me.btnConsultarDisponibles.Size = New System.Drawing.Size(33, 33)
        Me.btnConsultarDisponibles.TabIndex = 24
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.Agrupacion12)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1082, 538)
        '
        'Agrupacion12
        '
        Me.Agrupacion12.Controls.Add(Me.griVehiculoEstadoSituacional)
        Me.Agrupacion12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion12.Location = New System.Drawing.Point(0, 80)
        Me.Agrupacion12.Name = "Agrupacion12"
        Me.Agrupacion12.Size = New System.Drawing.Size(1082, 458)
        Me.Agrupacion12.TabIndex = 8
        Me.Agrupacion12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griVehiculoEstadoSituacional
        '
        Me.griVehiculoEstadoSituacional.DataSource = Me.ogdVehiculoEstadoSituacional
        UltraGridColumn2398.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn2398.Header.VisiblePosition = 1
        UltraGridColumn2398.Hidden = True
        UltraGridColumn2398.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2398.Width = 30
        UltraGridColumn2399.Header.VisiblePosition = 0
        UltraGridColumn2399.Hidden = True
        UltraGridColumn2400.Header.Caption = "Placa"
        UltraGridColumn2400.Header.VisiblePosition = 4
        UltraGridColumn2400.Width = 100
        UltraGridColumn2401.Header.Caption = "Motriz"
        UltraGridColumn2401.Header.VisiblePosition = 9
        UltraGridColumn2401.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2401.Width = 40
        UltraGridColumn2402.Header.Caption = "Tipo Vehiculo"
        UltraGridColumn2402.Header.VisiblePosition = 11
        UltraGridColumn2402.Width = 100
        UltraGridColumn2403.Header.Caption = "Marca"
        UltraGridColumn2403.Header.VisiblePosition = 10
        UltraGridColumn2403.Width = 113
        UltraGridColumn2404.Header.Caption = "Ultima F. O."
        UltraGridColumn2404.Header.VisiblePosition = 6
        UltraGridColumn2404.Width = 100
        UltraGridColumn2405.Header.Caption = "Ultimo Destino"
        UltraGridColumn2405.Header.VisiblePosition = 5
        UltraGridColumn2405.Width = 100
        UltraGridColumn2406.Header.Caption = "E.Operaciones"
        UltraGridColumn2406.Header.VisiblePosition = 7
        UltraGridColumn2406.Width = 70
        UltraGridColumn2407.Header.Caption = "E.Mantenimiento"
        UltraGridColumn2407.Header.VisiblePosition = 8
        UltraGridColumn2407.Width = 110
        UltraGridColumn2408.Header.VisiblePosition = 12
        UltraGridColumn2408.Hidden = True
        UltraGridColumn2409.Header.VisiblePosition = 13
        UltraGridColumn2409.Hidden = True
        UltraGridColumn2410.Header.VisiblePosition = 14
        UltraGridColumn2410.Hidden = True
        UltraGridColumn2411.Header.VisiblePosition = 2
        UltraGridColumn2411.Width = 100
        UltraGridColumn2412.Header.VisiblePosition = 3
        UltraGridBand17.Columns.AddRange(New Object() {UltraGridColumn2398, UltraGridColumn2399, UltraGridColumn2400, UltraGridColumn2401, UltraGridColumn2402, UltraGridColumn2403, UltraGridColumn2404, UltraGridColumn2405, UltraGridColumn2406, UltraGridColumn2407, UltraGridColumn2408, UltraGridColumn2409, UltraGridColumn2410, UltraGridColumn2411, UltraGridColumn2412})
        UltraGridBand17.GroupHeadersVisible = False
        UltraGridBand17.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griVehiculoEstadoSituacional.DisplayLayout.BandsSerializer.Add(UltraGridBand17)
        Me.griVehiculoEstadoSituacional.DisplayLayout.MaxColScrollRegions = 1
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.CellPadding = 1
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griVehiculoEstadoSituacional.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griVehiculoEstadoSituacional.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griVehiculoEstadoSituacional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griVehiculoEstadoSituacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griVehiculoEstadoSituacional.Location = New System.Drawing.Point(2, 2)
        Me.griVehiculoEstadoSituacional.Name = "griVehiculoEstadoSituacional"
        Me.griVehiculoEstadoSituacional.Size = New System.Drawing.Size(1078, 454)
        Me.griVehiculoEstadoSituacional.TabIndex = 2
        Me.griVehiculoEstadoSituacional.Tag = ""
        '
        'ogdVehiculoEstadoSituacional
        '
        Me.ogdVehiculoEstadoSituacional.Band.Columns.AddRange(New Object() {UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143})
        '
        'UltraExpandableGroupBox4
        '
        Appearance84.BackColor = System.Drawing.Color.White
        Appearance84.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox4.ContentAreaAppearance = Appearance84
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel10)
        Me.UltraExpandableGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(1082, 80)
        Me.UltraExpandableGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(1082, 80)
        Me.UltraExpandableGroupBox4.TabIndex = 7
        Me.UltraExpandableGroupBox4.Text = "Filtros"
        Me.UltraExpandableGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel10
        '
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.cboZonaVehiculo)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.UltraLabel61)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.btnConsultarVehiculo)
        Me.UltraExpandableGroupBoxPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel10.Location = New System.Drawing.Point(3, 25)
        Me.UltraExpandableGroupBoxPanel10.Name = "UltraExpandableGroupBoxPanel10"
        Me.UltraExpandableGroupBoxPanel10.Size = New System.Drawing.Size(1076, 52)
        Me.UltraExpandableGroupBoxPanel10.TabIndex = 0
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance85.BackColor = System.Drawing.Color.White
        Appearance85.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance85
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(296, 52)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(780, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(296, 52)
        Me.UltraExpandableGroupBox1.TabIndex = 51
        Me.UltraExpandableGroupBox1.Text = "Est"
        UltraToolTipInfo11.ToolTipText = "Estados Viaje"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBox1, UltraToolTipInfo11)
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ColorRuta)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ColorDisponible)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta3)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ColorMantenimiento)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta4)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(25, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(268, 46)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        UltraToolTipInfo10.ToolTipText = "Estados"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBoxPanel1, UltraToolTipInfo10)
        '
        'ColorRuta
        '
        Me.ColorRuta.Color = System.Drawing.Color.White
        Me.ColorRuta.Location = New System.Drawing.Point(68, 24)
        Me.ColorRuta.Name = "ColorRuta"
        Me.ColorRuta.Size = New System.Drawing.Size(44, 19)
        Me.ColorRuta.TabIndex = 11
        Me.ColorRuta.Text = "White"
        '
        'Etiqueta2
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance86
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(18, 26)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta2.TabIndex = 10
        Me.Etiqueta2.Text = "En Ruta:"
        '
        'ColorDisponible
        '
        Me.ColorDisponible.Color = System.Drawing.Color.Lime
        Me.ColorDisponible.Location = New System.Drawing.Point(68, 3)
        Me.ColorDisponible.Name = "ColorDisponible"
        Me.ColorDisponible.Size = New System.Drawing.Size(44, 19)
        Me.ColorDisponible.TabIndex = 7
        Me.ColorDisponible.Text = "Lime"
        '
        'Etiqueta3
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance87
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(5, 5)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(59, 14)
        Me.Etiqueta3.TabIndex = 6
        Me.Etiqueta3.Text = "Disponible:"
        '
        'ColorMantenimiento
        '
        Me.ColorMantenimiento.Location = New System.Drawing.Point(218, 3)
        Me.ColorMantenimiento.Name = "ColorMantenimiento"
        Me.ColorMantenimiento.Size = New System.Drawing.Size(43, 19)
        Me.ColorMantenimiento.TabIndex = 9
        Me.ColorMantenimiento.Text = "Control"
        '
        'Etiqueta4
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance88
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(118, 5)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(96, 14)
        Me.Etiqueta4.TabIndex = 8
        Me.Etiqueta4.Text = "En Mantenimiento:"
        '
        'cboZonaVehiculo
        '
        Appearance89.ForeColor = System.Drawing.Color.Black
        Me.cboZonaVehiculo.Appearance = Appearance89
        Me.cboZonaVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboZonaVehiculo.DisplayMember = "Nombre"
        Me.cboZonaVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboZonaVehiculo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboZonaVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZonaVehiculo.ForeColor = System.Drawing.Color.Black
        Me.cboZonaVehiculo.Location = New System.Drawing.Point(53, 24)
        Me.cboZonaVehiculo.Name = "cboZonaVehiculo"
        Me.cboZonaVehiculo.Size = New System.Drawing.Size(150, 21)
        Me.cboZonaVehiculo.TabIndex = 26
        Me.cboZonaVehiculo.ValueMember = "Id"
        Me.cboZonaVehiculo.Visible = False
        '
        'UltraLabel61
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Appearance90.ForeColor = System.Drawing.Color.Navy
        Appearance90.TextVAlignAsString = "Middle"
        Me.UltraLabel61.Appearance = Appearance90
        Me.UltraLabel61.AutoSize = True
        Me.UltraLabel61.Location = New System.Drawing.Point(53, 6)
        Me.UltraLabel61.Name = "UltraLabel61"
        Me.UltraLabel61.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel61.TabIndex = 25
        Me.UltraLabel61.Text = "Zona:"
        Me.UltraLabel61.Visible = False
        '
        'btnConsultarVehiculo
        '
        Appearance91.Image = "266.png"
        Appearance91.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance91.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnConsultarVehiculo.Appearance = Appearance91
        Me.btnConsultarVehiculo.ImageList = Me.imagenes
        Me.btnConsultarVehiculo.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnConsultarVehiculo.Location = New System.Drawing.Point(4, 15)
        Me.btnConsultarVehiculo.Name = "btnConsultarVehiculo"
        Me.btnConsultarVehiculo.Size = New System.Drawing.Size(40, 30)
        Me.btnConsultarVehiculo.TabIndex = 24
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.utcDespacho)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1082, 538)
        '
        'utcDespacho
        '
        Me.utcDespacho.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utcDespacho.Controls.Add(Me.tapListadoDespacho)
        Me.utcDespacho.Controls.Add(Me.tapMantenimientoDespacho)
        Me.utcDespacho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcDespacho.Location = New System.Drawing.Point(0, 0)
        Me.utcDespacho.Name = "utcDespacho"
        Me.utcDespacho.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utcDespacho.Size = New System.Drawing.Size(1082, 538)
        Me.utcDespacho.TabIndex = 17
        UltraTab19.TabPage = Me.tapListadoDespacho
        UltraTab19.Text = "Lista"
        UltraTab37.TabPage = Me.tapMantenimientoDespacho
        UltraTab37.Text = "Mantenimiento"
        Me.utcDespacho.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab19, UltraTab37})
        Me.utcDespacho.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1080, 515)
        '
        'ogdDespachoOperaciones
        '
        Me.ogdDespachoOperaciones.Band.Columns.AddRange(New Object() {UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185})
        '
        'ogdListaOperacion
        '
        UltraDataColumn196.DataType = GetType(Boolean)
        UltraDataColumn210.DataType = GetType(Date)
        UltraDataColumn225.DataType = GetType(Date)
        UltraDataColumn226.DataType = GetType(Date)
        UltraDataColumn227.DataType = GetType(Date)
        UltraDataColumn228.DataType = GetType(Date)
        UltraDataColumn230.DefaultValue = ""
        UltraDataColumn234.DataType = GetType(Decimal)
        UltraDataColumn236.DataType = GetType(Decimal)
        UltraDataColumn259.DataType = GetType(Date)
        UltraDataColumn260.DataType = GetType(Date)
        Me.ogdListaOperacion.Band.Columns.AddRange(New Object() {UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192, UltraDataColumn193, UltraDataColumn194, UltraDataColumn195, UltraDataColumn196, UltraDataColumn197, UltraDataColumn198, UltraDataColumn199, UltraDataColumn200, UltraDataColumn201, UltraDataColumn202, UltraDataColumn203, UltraDataColumn204, UltraDataColumn205, UltraDataColumn206, UltraDataColumn207, UltraDataColumn208, UltraDataColumn209, UltraDataColumn210, UltraDataColumn211, UltraDataColumn212, UltraDataColumn213, UltraDataColumn214, UltraDataColumn215, UltraDataColumn216, UltraDataColumn217, UltraDataColumn218, UltraDataColumn219, UltraDataColumn220, UltraDataColumn221, UltraDataColumn222, UltraDataColumn223, UltraDataColumn224, UltraDataColumn225, UltraDataColumn226, UltraDataColumn227, UltraDataColumn228, UltraDataColumn229, UltraDataColumn230, UltraDataColumn231, UltraDataColumn232, UltraDataColumn233, UltraDataColumn234, UltraDataColumn235, UltraDataColumn236, UltraDataColumn237, UltraDataColumn238, UltraDataColumn239, UltraDataColumn240, UltraDataColumn241, UltraDataColumn242, UltraDataColumn243, UltraDataColumn244, UltraDataColumn245, UltraDataColumn246, UltraDataColumn247, UltraDataColumn248, UltraDataColumn249, UltraDataColumn250, UltraDataColumn251, UltraDataColumn252, UltraDataColumn253, UltraDataColumn254, UltraDataColumn255, UltraDataColumn256, UltraDataColumn257, UltraDataColumn258, UltraDataColumn259, UltraDataColumn260, UltraDataColumn261, UltraDataColumn262})
        '
        'ogdDespacho
        '
        Me.ogdDespacho.Band.Columns.AddRange(New Object() {UltraDataColumn263, UltraDataColumn264, UltraDataColumn265, UltraDataColumn266, UltraDataColumn267, UltraDataColumn268, UltraDataColumn269, UltraDataColumn270, UltraDataColumn271, UltraDataColumn272, UltraDataColumn273, UltraDataColumn274, UltraDataColumn275, UltraDataColumn276, UltraDataColumn277})
        '
        'cmsMenuListado
        '
        Me.cmsMenuListado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemNuevo, Me.itemEditar, Me.itemEditarViaje, Me.itemEliminar, Me.itemEjecutar, Me.itemGenerarProg, Me.itemFormatoClientes, Me.itemResumenDiario, Me.itemIniciarDespacho, Me.itemDesenlazarViaje})
        Me.cmsMenuListado.Name = "cmsMenuListado"
        Me.cmsMenuListado.Size = New System.Drawing.Size(194, 224)
        '
        'itemNuevo
        '
        Me.itemNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.itemNuevo.Name = "itemNuevo"
        Me.itemNuevo.Size = New System.Drawing.Size(193, 22)
        Me.itemNuevo.Text = "Nuevo"
        '
        'itemEditar
        '
        Me.itemEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.itemEditar.Name = "itemEditar"
        Me.itemEditar.Size = New System.Drawing.Size(193, 22)
        Me.itemEditar.Text = "Editar"
        '
        'itemEditarViaje
        '
        Me.itemEditarViaje.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.itemEditarViaje.Name = "itemEditarViaje"
        Me.itemEditarViaje.Size = New System.Drawing.Size(193, 22)
        Me.itemEditarViaje.Text = "Editar Viaje"
        '
        'itemEliminar
        '
        Me.itemEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.itemEliminar.Name = "itemEliminar"
        Me.itemEliminar.Size = New System.Drawing.Size(193, 22)
        Me.itemEliminar.Text = "Eliminar"
        '
        'itemEjecutar
        '
        Me.itemEjecutar.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.itemEjecutar.Name = "itemEjecutar"
        Me.itemEjecutar.Size = New System.Drawing.Size(193, 22)
        Me.itemEjecutar.Text = "Ejecutar"
        '
        'itemGenerarProg
        '
        Me.itemGenerarProg.Image = Global.ISL.Win.My.Resources.Resources.Rename
        Me.itemGenerarProg.Name = "itemGenerarProg"
        Me.itemGenerarProg.Size = New System.Drawing.Size(193, 22)
        Me.itemGenerarProg.Text = "Generar Programación"
        '
        'itemFormatoClientes
        '
        Me.itemFormatoClientes.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.itemFormatoClientes.Name = "itemFormatoClientes"
        Me.itemFormatoClientes.Size = New System.Drawing.Size(193, 22)
        Me.itemFormatoClientes.Text = "Formato Clientes"
        '
        'itemResumenDiario
        '
        Me.itemResumenDiario.Image = Global.ISL.Win.My.Resources.Resources.kchart
        Me.itemResumenDiario.Name = "itemResumenDiario"
        Me.itemResumenDiario.Size = New System.Drawing.Size(193, 22)
        Me.itemResumenDiario.Text = "Resumen Diario"
        '
        'itemIniciarDespacho
        '
        Me.itemIniciarDespacho.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.itemIniciarDespacho.Name = "itemIniciarDespacho"
        Me.itemIniciarDespacho.Size = New System.Drawing.Size(193, 22)
        Me.itemIniciarDespacho.Text = "Iniciar Despacho"
        '
        'itemDesenlazarViaje
        '
        Me.itemDesenlazarViaje.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.itemDesenlazarViaje.Name = "itemDesenlazarViaje"
        Me.itemDesenlazarViaje.Size = New System.Drawing.Size(193, 22)
        Me.itemDesenlazarViaje.Text = "Desenlazar Viaje"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UltraGridExcelExporter1
        '
        Me.UltraGridExcelExporter1.ExportValueLists = False
        '
        'cmsMenuMantenimiento
        '
        Me.cmsMenuMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemMantenimiento, Me.itemMantUrgente, Me.itemResaltarCeldas, Me.itemResaltarEstado})
        Me.cmsMenuMantenimiento.Name = "cmsMenuMantenimiento"
        Me.cmsMenuMantenimiento.Size = New System.Drawing.Size(200, 92)
        '
        'itemMantenimiento
        '
        Me.itemMantenimiento.Image = Global.ISL.Win.My.Resources.Resources.Neumatico
        Me.itemMantenimiento.Name = "itemMantenimiento"
        Me.itemMantenimiento.Size = New System.Drawing.Size(199, 22)
        Me.itemMantenimiento.Text = "Mantenimiento"
        '
        'itemMantUrgente
        '
        Me.itemMantUrgente.Image = Global.ISL.Win.My.Resources.Resources.status_mail
        Me.itemMantUrgente.Name = "itemMantUrgente"
        Me.itemMantUrgente.Size = New System.Drawing.Size(199, 22)
        Me.itemMantUrgente.Text = "Mant. Urgente"
        '
        'itemResaltarCeldas
        '
        Me.itemResaltarCeldas.Image = Global.ISL.Win.My.Resources.Resources.hire_me
        Me.itemResaltarCeldas.Name = "itemResaltarCeldas"
        Me.itemResaltarCeldas.Size = New System.Drawing.Size(199, 22)
        Me.itemResaltarCeldas.Text = "Resaltar Origen/Destino"
        '
        'itemResaltarEstado
        '
        Me.itemResaltarEstado.Image = Global.ISL.Win.My.Resources.Resources.content_reorder
        Me.itemResaltarEstado.Name = "itemResaltarEstado"
        Me.itemResaltarEstado.Size = New System.Drawing.Size(199, 22)
        Me.itemResaltarEstado.Text = "Resaltar Estado"
        '
        'TabDisponibilidad
        '
        Me.TabDisponibilidad.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.TabDisponibilidad.Controls.Add(Me.UltraTabPageControl3)
        Me.TabDisponibilidad.Controls.Add(Me.UltraTabPageControl6)
        Me.TabDisponibilidad.Controls.Add(Me.UltraTabPageControl1)
        Me.TabDisponibilidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDisponibilidad.Location = New System.Drawing.Point(0, 0)
        Me.TabDisponibilidad.Name = "TabDisponibilidad"
        Me.TabDisponibilidad.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.TabDisponibilidad.Size = New System.Drawing.Size(1084, 561)
        Me.TabDisponibilidad.TabIndex = 1
        Appearance98.Image = Global.ISL.Win.My.Resources.Resources.EsperaVerde
        UltraTab38.SelectedAppearance = Appearance98
        UltraTab38.TabPage = Me.UltraTabPageControl3
        UltraTab38.Text = "Disponibles Trabajador / Vehiculos"
        Appearance99.Image = Global.ISL.Win.My.Resources.Resources.EsperaVerde
        UltraTab39.SelectedAppearance = Appearance99
        UltraTab39.TabPage = Me.UltraTabPageControl6
        UltraTab39.Text = "Vehiculo Estado Situacional"
        UltraTab40.TabPage = Me.UltraTabPageControl1
        UltraTab40.Text = "Despacho Transporte"
        Me.TabDisponibilidad.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab38, UltraTab39, UltraTab40})
        Me.TabDisponibilidad.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1082, 538)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(319, 296)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 7
        Me.ugb_Espera.Visible = False
        '
        'frm_EstadoSituacionalVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.TabDisponibilidad)
        Me.Controls.Add(Me.ugb_Espera)
        Me.KeyPreview = True
        Me.Name = "frm_EstadoSituacionalVehiculo"
        Me.Text = "Disponibilidad Vehiculo"
        Me.tap01.ResumeLayout(False)
        CType(Me.griTab01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsDespachoOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap02.ResumeLayout(False)
        CType(Me.griTab02, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap03.ResumeLayout(False)
        CType(Me.griTab03, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap04.ResumeLayout(False)
        CType(Me.griTab04, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap05.ResumeLayout(False)
        CType(Me.griTab05, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap06.ResumeLayout(False)
        CType(Me.griTab06, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap07.ResumeLayout(False)
        CType(Me.griTab07, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap08.ResumeLayout(False)
        CType(Me.griTab08, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap09.ResumeLayout(False)
        CType(Me.griTab09, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap10.ResumeLayout(False)
        CType(Me.griTab10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap11.ResumeLayout(False)
        CType(Me.griTab11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap12.ResumeLayout(False)
        CType(Me.griTab12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap13.ResumeLayout(False)
        CType(Me.griTab13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap14.ResumeLayout(False)
        CType(Me.griTab14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tap15.ResumeLayout(False)
        CType(Me.griTab15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tapListadoDespacho.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.utcDespachosDinamicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcDespachosDinamicos.ResumeLayout(False)
        CType(Me.ugbTotalesLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbTotalesLista.ResumeLayout(False)
        Me.ugbTotalesLista.PerformLayout()
        CType(Me.unePorcentajeMeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneTotalViajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneTotalSinCopiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneProdUnidadFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneTotalSinPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneProdTotalFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneProdRealFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.cboZonaListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentroFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griFormatoClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.ColorParihuelero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPlataforma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBaranda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTolvaVolteo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGranelero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgonLargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgonAmericano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCisterna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBomboma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCalicera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorMediaBaranda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tapMantenimientoDespacho.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.griDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspDespacho.ResumeLayout(False)
        Me.tspDespacho.PerformLayout()
        CType(Me.ugbTotalesMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbTotalesMantenimiento.ResumeLayout(False)
        Me.ugbTotalesMantenimiento.PerformLayout()
        CType(Me.uneProdProg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneProdReal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneProdTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugbDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbDespacho.ResumeLayout(False)
        Me.ugbDespacho.PerformLayout()
        CType(Me.colorColumnaEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorMantUrgente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCeldaResaltada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorMant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCamposNoEncontrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZonaEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expGenerarDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expGenerarDesde.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.PerformLayout()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.PerformLayout()
        CType(Me.PlataformaM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarandaM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TolvaVolteoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CisternaM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombomaM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaBarandaM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParihueleroM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraneleroM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FurgonLargoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FurgonAmericanoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaliceraM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FurgonM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        CType(Me.griDisponibleVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuOperacion.ResumeLayout(False)
        CType(Me.ogdDisponibleVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel8.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel8.PerformLayout()
        CType(Me.cboRutaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox5.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.ColorParihueleroD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPlataformaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion20M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTolvaVolteoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion65M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorContenedorD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGraneleroD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgonD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgonLargoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamionetaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVolqueteD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion30M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCaliceraD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion40M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorMediaBarandaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruDisponibleNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruDisponibleNo.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        CType(Me.ColorAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAyudante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCopiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboZonaDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion12.ResumeLayout(False)
        CType(Me.griVehiculoEstadoSituacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdVehiculoEstadoSituacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel10.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel10.PerformLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.ColorRuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboZonaVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.utcDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcDespacho.ResumeLayout(False)
        CType(Me.ogdDespachoOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdListaOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuListado.ResumeLayout(False)
        Me.cmsMenuMantenimiento.ResumeLayout(False)
        CType(Me.TabDisponibilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDisponibilidad.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents TabDisponibilidad As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel8 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion12 As ISL.Controles.Agrupacion
    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel10 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents ogdVehiculoEstadoSituacional As ISL.Controles.OrigenDatos
    Friend WithEvents ogdDisponibleVehiculos As ISL.Controles.OrigenDatos
    Friend WithEvents cboZonaDisponibles As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel59 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnConsultarDisponibles As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cboZonaVehiculo As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel61 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnConsultarVehiculo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griDisponibleVehiculo As ISL.Controles.Grilla
    Friend WithEvents griVehiculoEstadoSituacional As ISL.Controles.Grilla
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ColorRuta As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents ColorDisponible As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ColorMantenimiento As ISL.Controles.Colores
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents MenuOperacion As ISL.Controles.MenuContextual
    Friend WithEvents Programar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraExpandableGroupBox5 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents exgruDisponibleNo As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboRutaOrigen As ISL.Controles.ComboMaestros
    Friend WithEvents lblListoRegistro As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents ColorParihueleroD As ISL.Controles.Colores
    Friend WithEvents ColorPlataformaD As ISL.Controles.Colores
    Friend WithEvents ColorCamion20M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTolvaVolteoD As ISL.Controles.Colores
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion65M3D As ISL.Controles.Colores
    Friend WithEvents ColorContenedorD As ISL.Controles.Colores
    Friend WithEvents Etiqueta222 As ISL.Controles.Etiqueta
    Friend WithEvents ColorGraneleroD As ISL.Controles.Colores
    Friend WithEvents ColorFurgonD As ISL.Controles.Colores
    Friend WithEvents ColorFurgonLargoD As ISL.Controles.Colores
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamionetaD As ISL.Controles.Colores
    Friend WithEvents ColorVolqueteD As ISL.Controles.Colores
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion30M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCaliceraD As ISL.Controles.Colores
    Friend WithEvents ColorCamion40M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents ColorMediaBarandaD As ISL.Controles.Colores
    Friend WithEvents ColorAdvertencia As ISL.Controles.Colores
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents ColorPiloto As ISL.Controles.Colores
    Friend WithEvents ColorAyudante As ISL.Controles.Colores
    Friend WithEvents ColorCarreta As ISL.Controles.Colores
    Friend WithEvents ColorTracto As ISL.Controles.Colores
    Friend WithEvents ColorCopiloto As ISL.Controles.Colores
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdListaOperacion As ISL.Controles.OrigenDatos
    Friend WithEvents ogdDespachoOperaciones As ISL.Controles.OrigenDatos
    Friend WithEvents ogdDespacho As ISL.Controles.OrigenDatos
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents utcDespacho As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tapListadoDespacho As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents utcDespachosDinamicos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents ugbTotalesLista As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uneProdUnidadFiltro As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents uneProdTotalFiltro As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents uneProdRealFiltro As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCentroFiltro As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents dtpHastaFiltro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDesdeFiltro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tapMantenimientoDespacho As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents tap01 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap02 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap03 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap04 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap05 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap06 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap07 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap08 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap09 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tap15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griTab01 As ISL.Controles.Grilla
    Friend WithEvents udsDespachoOperaciones As ISL.Controles.OrigenDatos
    Friend WithEvents griTab02 As ISL.Controles.Grilla
    Friend WithEvents griTab03 As ISL.Controles.Grilla
    Friend WithEvents griTab04 As ISL.Controles.Grilla
    Friend WithEvents griTab05 As ISL.Controles.Grilla
    Friend WithEvents griTab06 As ISL.Controles.Grilla
    Friend WithEvents griTab07 As ISL.Controles.Grilla
    Friend WithEvents griTab08 As ISL.Controles.Grilla
    Friend WithEvents griTab09 As ISL.Controles.Grilla
    Friend WithEvents griTab10 As ISL.Controles.Grilla
    Friend WithEvents griTab11 As ISL.Controles.Grilla
    Friend WithEvents griTab12 As ISL.Controles.Grilla
    Friend WithEvents griTab13 As ISL.Controles.Grilla
    Friend WithEvents griTab14 As ISL.Controles.Grilla
    Friend WithEvents griTab15 As ISL.Controles.Grilla
    Friend WithEvents cboEstadoFiltro As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents griDetalles As ISL.Controles.Grilla
    Friend WithEvents tspDespacho As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarDespacho As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitarDespacho As System.Windows.Forms.ToolStripButton
    Friend WithEvents ugbTotalesMantenimiento As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uneProdProg As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents uneProdReal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneProdTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ugbDespacho As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents expGenerarDesde As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents rbtNinguno As System.Windows.Forms.RadioButton
    Friend WithEvents btnGenerarDesde As Infragistics.Win.Misc.UltraButton
    Friend WithEvents rbtImportarExcel As System.Windows.Forms.RadioButton
    Friend WithEvents rbtUltimoDespacho As System.Windows.Forms.RadioButton
    Friend WithEvents rbtUltimosViajes As System.Windows.Forms.RadioButton
    Friend WithEvents cmsMenuListado As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itemEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemEjecutar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents itemFormatoClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents itemGenerarProg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Color30M3 As System.Windows.Forms.Label
    Friend WithEvents Color20M3 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColorParihuelero As ISL.Controles.Colores
    Friend WithEvents ColorPlataforma As ISL.Controles.Colores
    Friend WithEvents ColorBaranda As ISL.Controles.Colores
    Friend WithEvents ColorTolvaVolteo As ISL.Controles.Colores
    Friend WithEvents ColorGranelero As ISL.Controles.Colores
    Friend WithEvents ColorFurgon As ISL.Controles.Colores
    Friend WithEvents ColorFurgonLargo As ISL.Controles.Colores
    Friend WithEvents ColorFurgonAmericano As ISL.Controles.Colores
    Friend WithEvents ColorCisterna As ISL.Controles.Colores
    Friend WithEvents ColorBomboma As ISL.Controles.Colores
    Friend WithEvents ColorCalicera As ISL.Controles.Colores
    Friend WithEvents ColorMediaBaranda As ISL.Controles.Colores
    Friend WithEvents griFormatoClientes As ISL.Controles.Grilla
    Friend WithEvents itemResumenDiario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmsMenuMantenimiento As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itemMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorCamposNoEncontrados As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents itemIniciarDespacho As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboZonaListado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtZonaEditar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents ParihueleroM As ISL.Controles.Colores
    Friend WithEvents PlataformaM As ISL.Controles.Colores
    Friend WithEvents BarandaM As ISL.Controles.Colores
    Friend WithEvents TolvaVolteoM As ISL.Controles.Colores
    Friend WithEvents GraneleroM As ISL.Controles.Colores
    Friend WithEvents FurgonM As ISL.Controles.Colores
    Friend WithEvents FurgonLargoM As ISL.Controles.Colores
    Friend WithEvents FurgonAmericanoM As ISL.Controles.Colores
    Friend WithEvents CisternaM As ISL.Controles.Colores
    Friend WithEvents BombomaM As ISL.Controles.Colores
    Friend WithEvents CaliceraM As ISL.Controles.Colores
    Friend WithEvents MediaBarandaM As ISL.Controles.Colores
    Friend WithEvents itemEditarViaje As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemMantUrgente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorMantUrgente As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents colorMant As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents uneTotalSinCopiloto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneTotalSinPiloto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents uneTotalViajes As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents unePorcentajeMeta As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents itemResaltarCeldas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorCeldaResaltada As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents itemDesenlazarViaje As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemResaltarEstado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorColumnaEstado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents Label47 As System.Windows.Forms.Label
End Class
