<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DocumentoVenta
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumentoVenta")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumentoVenta")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdReferencia")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPreDemanda")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAtendida")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalComision")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoPreDemanda")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPreDemanda")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAtendida")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalComision")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoPreDemanda")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumentoVenta")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumentoVenta")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Concepto")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdReferencia")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFacturado")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalEfectivo")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalCredito")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalDescuento")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorriente")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Detraccion")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCliente")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeDescuento")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeDetraccion")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeIgv")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteCalcular")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.griDocumentoVentaDetalle = New ISL.Controles.Grilla(Me.components)
        Me.ogdDocumentoVentaDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.griDemanda = New ISL.Controles.Grilla(Me.components)
        Me.ogdDemanda = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.spcDocumentoVenta = New System.Windows.Forms.SplitContainer
        Me.agrListaDocumentoVenta = New ISL.Controles.Agrupacion(Me.components)
        Me.griDocumentoVenta = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.agrFechaListaDocumento = New ISL.Controles.Agrupacion(Me.components)
        Me.btnMostrarDetalle = New ISL.Controles.Boton(Me.components)
        Me.rgFecha = New ISL.Controles.RangoFechas2
        Me.object_d690ce1c_52a5_4c5e_b603_e9d168e11f95 = New ISL.Controles.Etiqueta(Me.components)
        Me.object_6e204a67_2146_4672_8ec0_5044b4c17289 = New ISL.Controles.Etiqueta(Me.components)
        Me.FechaHasta = New ISL.Controles.Fecha(Me.components)
        Me.FechaDesde = New ISL.Controles.Fecha(Me.components)
        Me.object_65ab087e_4fbb_431a_a85f_0f1f92b7b088 = New ISL.Controles.Etiqueta(Me.components)
        Me.object_85877b47_31a5_4c83_9f99_d9de9c861541 = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha1 = New ISL.Controles.Fecha(Me.components)
        Me.Fecha2 = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha3 = New ISL.Controles.Fecha(Me.components)
        Me.Fecha4 = New ISL.Controles.Fecha(Me.components)
        Me.object_5ddaa1bb_9920_4049_b390_616c2bb28fed = New ISL.Controles.Etiqueta(Me.components)
        Me.object_04356b12_703c_4eeb_93d6_ef3ca567a82d = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha5 = New ISL.Controles.Fecha(Me.components)
        Me.Fecha6 = New ISL.Controles.Fecha(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrDetalleVenta = New ISL.Controles.Agrupacion(Me.components)
        Me.Ficha1 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.agrVenta = New ISL.Controles.Agrupacion(Me.components)
        Me.agrTotalTexto = New ISL.Controles.Agrupacion(Me.components)
        Me.etiTotal = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoPago = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCliente = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtConcepto = New ISL.Controles.Texto(Me.components)
        Me.nupPorcentajeDescuento = New System.Windows.Forms.NumericUpDown
        Me.agrTotales = New ISL.Controles.Agrupacion(Me.components)
        Me.decValorIgv = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSubTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaVencimiento = New ISL.Controles.Fecha(Me.components)
        Me.decSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaEmision = New ISL.Controles.Fecha(Me.components)
        Me.etiFechaVencimiento = New ISL.Controles.Etiqueta(Me.components)
        Me.decTotalEfectivo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decTotalFacturado = New ISL.Controles.NumeroDecimal(Me.components)
        Me.verIgv = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.decDetraccion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTotalDetraccion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.nupPorcentajeDetraccion = New System.Windows.Forms.NumericUpDown
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.agrTrabajadorAsignado = New ISL.Controles.Agrupacion(Me.components)
        Me.etiSaldoCuentaTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNumeroCuenta = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.etiDni = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaCorrienteTrabajador = New ISL.Controles.Combo(Me.components)
        Me.picRecibidor = New System.Windows.Forms.PictureBox
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.verTrabajadorAsignado = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTotalDescuento = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.ogdDocumentoVenta = New ISL.Controles.OrigenDatos(Me.components)
        Me.ogdDemandaDetalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.FicDocumentoVenta = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griDocumentoVentaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDocumentoVentaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        Me.spcDocumentoVenta.Panel1.SuspendLayout()
        Me.spcDocumentoVenta.Panel2.SuspendLayout()
        Me.spcDocumentoVenta.SuspendLayout()
        CType(Me.agrListaDocumentoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaDocumentoVenta.SuspendLayout()
        CType(Me.griDocumentoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griListaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrFechaListaDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFechaListaDocumento.SuspendLayout()
        Me.rgFecha.SuspendLayout()
        CType(Me.FechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalleVenta.SuspendLayout()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha1.SuspendLayout()
        CType(Me.agrVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrVenta.SuspendLayout()
        CType(Me.agrTotalTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalTexto.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupPorcentajeDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotales.SuspendLayout()
        CType(Me.decValorIgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalFacturado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.decDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupPorcentajeDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrTrabajadorAsignado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTrabajadorAsignado.SuspendLayout()
        CType(Me.cboCuentaCorrienteTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRecibidor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verTrabajadorAsignado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDocumentoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDemandaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FicDocumentoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FicDocumentoVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griDocumentoVentaDetalle)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1208, 209)
        '
        'griDocumentoVentaDetalle
        '
        Me.griDocumentoVentaDetalle.DataSource = Me.ogdDocumentoVentaDetalle
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 350
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 66
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.griDocumentoVentaDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDocumentoVentaDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griDocumentoVentaDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDocumentoVentaDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDocumentoVentaDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDocumentoVentaDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDocumentoVentaDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDocumentoVentaDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDocumentoVentaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDocumentoVentaDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDocumentoVentaDetalle.Location = New System.Drawing.Point(0, 0)
        Me.griDocumentoVentaDetalle.Name = "griDocumentoVentaDetalle"
        Me.griDocumentoVentaDetalle.Size = New System.Drawing.Size(1208, 209)
        Me.griDocumentoVentaDetalle.TabIndex = 0
        Me.griDocumentoVentaDetalle.Text = "Detalle Documento Venta"
        '
        'ogdDocumentoVentaDetalle
        '
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        Me.ogdDocumentoVentaDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1208, 209)
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griDemanda)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1214, 492)
        '
        'griDemanda
        '
        Me.griDemanda.DataSource = Me.ogdDemanda
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn10.Header.Caption = "Select"
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Width = 43
        UltraGridColumn11.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 85
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn12.Width = 104
        UltraGridColumn13.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn14.Header.VisiblePosition = 5
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 6
        UltraGridColumn15.Width = 146
        UltraGridColumn16.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn16.Header.VisiblePosition = 9
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 11
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 122
        UltraGridColumn18.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn18.Header.VisiblePosition = 16
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 14
        UltraGridColumn19.Width = 91
        UltraGridColumn20.Header.VisiblePosition = 15
        UltraGridColumn20.Hidden = True
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance16
        UltraGridColumn21.Header.VisiblePosition = 8
        UltraGridColumn21.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn21.Width = 74
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance33
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 18
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 17
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 19
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 20
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 7
        UltraGridColumn27.Width = 187
        UltraGridColumn28.Header.VisiblePosition = 10
        UltraGridColumn28.Width = 182
        UltraGridColumn29.Header.VisiblePosition = 21
        UltraGridColumn30.Header.VisiblePosition = 12
        UltraGridColumn31.Header.VisiblePosition = 13
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31})
        Me.griDemanda.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griDemanda.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griDemanda.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griDemanda.DisplayLayout.MaxColScrollRegions = 1
        Me.griDemanda.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDemanda.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDemanda.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDemanda.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDemanda.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.Button
        Me.griDemanda.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDemanda.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDemanda.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.None
        Me.griDemanda.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griDemanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDemanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDemanda.Location = New System.Drawing.Point(0, 0)
        Me.griDemanda.Name = "griDemanda"
        Me.griDemanda.Size = New System.Drawing.Size(1214, 492)
        Me.griDemanda.TabIndex = 1
        Me.griDemanda.Tag = ""
        '
        'ogdDemanda
        '
        UltraDataColumn10.DataType = GetType(Boolean)
        UltraDataColumn10.DefaultValue = False
        UltraDataColumn21.DataType = GetType(Double)
        UltraDataColumn22.DataType = GetType(Double)
        Me.ogdDemanda.Band.Columns.AddRange(New Object() {UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31})
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.spcDocumentoVenta)
        Me.UltraTabPageControl7.Controls.Add(Me.agrFechaListaDocumento)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1214, 492)
        '
        'spcDocumentoVenta
        '
        Me.spcDocumentoVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcDocumentoVenta.Location = New System.Drawing.Point(0, 73)
        Me.spcDocumentoVenta.Name = "spcDocumentoVenta"
        Me.spcDocumentoVenta.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcDocumentoVenta.Panel1
        '
        Me.spcDocumentoVenta.Panel1.Controls.Add(Me.agrListaDocumentoVenta)
        '
        'spcDocumentoVenta.Panel2
        '
        Me.spcDocumentoVenta.Panel2.Controls.Add(Me.Agrupacion1)
        Me.spcDocumentoVenta.Size = New System.Drawing.Size(1214, 419)
        Me.spcDocumentoVenta.SplitterDistance = 209
        Me.spcDocumentoVenta.TabIndex = 8
        '
        'agrListaDocumentoVenta
        '
        Me.agrListaDocumentoVenta.Controls.Add(Me.griDocumentoVenta)
        Me.agrListaDocumentoVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaDocumentoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrListaDocumentoVenta.ForeColor = System.Drawing.Color.Black
        Me.agrListaDocumentoVenta.Location = New System.Drawing.Point(0, 0)
        Me.agrListaDocumentoVenta.Name = "agrListaDocumentoVenta"
        Me.agrListaDocumentoVenta.Size = New System.Drawing.Size(1214, 209)
        Me.agrListaDocumentoVenta.TabIndex = 6
        Me.agrListaDocumentoVenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griDocumentoVenta
        '
        Me.griDocumentoVenta.DataSource = Me.ogdDocumentoVentaDetalle
        UltraGridColumn32.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn32.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn32.Header.VisiblePosition = 6
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn34.Header.VisiblePosition = 1
        UltraGridColumn35.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn35.Header.VisiblePosition = 7
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 2
        UltraGridColumn37.Header.VisiblePosition = 3
        UltraGridColumn38.Header.VisiblePosition = 4
        UltraGridColumn39.Header.VisiblePosition = 5
        UltraGridColumn40.Header.VisiblePosition = 8
        UltraGridColumn40.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40})
        UltraGridBand3.SummaryFooterCaption = "Totales:"
        Me.griDocumentoVenta.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griDocumentoVenta.DisplayLayout.MaxColScrollRegions = 1
        Me.griDocumentoVenta.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDocumentoVenta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDocumentoVenta.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDocumentoVenta.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDocumentoVenta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDocumentoVenta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDocumentoVenta.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDocumentoVenta.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griDocumentoVenta.DisplayLayout.UseFixedHeaders = True
        Me.griDocumentoVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDocumentoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDocumentoVenta.Location = New System.Drawing.Point(2, 0)
        Me.griDocumentoVenta.Name = "griDocumentoVenta"
        Me.griDocumentoVenta.Size = New System.Drawing.Size(1210, 207)
        Me.griDocumentoVenta.TabIndex = 1
        Me.griDocumentoVenta.Text = "Documento Venta"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.griListaDetalle)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1214, 206)
        Me.Agrupacion1.TabIndex = 7
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griListaDetalle
        '
        Me.griListaDetalle.DataSource = Me.ogdDocumentoVentaDetalle
        UltraGridColumn41.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn41.Header.VisiblePosition = 0
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn42.Header.VisiblePosition = 1
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 2
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn44.Header.VisiblePosition = 3
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 8
        UltraGridColumn46.Header.VisiblePosition = 4
        UltraGridColumn46.Width = 139
        UltraGridColumn47.Header.VisiblePosition = 5
        UltraGridColumn47.Width = 66
        UltraGridColumn48.Header.VisiblePosition = 6
        UltraGridColumn49.Header.VisiblePosition = 7
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49})
        UltraGridBand4.SummaryFooterCaption = "Totales"
        Me.griListaDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDetalle.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griListaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaDetalle.Location = New System.Drawing.Point(2, 0)
        Me.griListaDetalle.Name = "griListaDetalle"
        Me.griListaDetalle.Size = New System.Drawing.Size(1210, 204)
        Me.griListaDetalle.TabIndex = 6
        Me.griListaDetalle.Text = "Detalle Documento Venta"
        '
        'agrFechaListaDocumento
        '
        Me.agrFechaListaDocumento.Controls.Add(Me.btnMostrarDetalle)
        Me.agrFechaListaDocumento.Controls.Add(Me.rgFecha)
        Me.agrFechaListaDocumento.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrFechaListaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFechaListaDocumento.ForeColor = System.Drawing.Color.Black
        Me.agrFechaListaDocumento.Location = New System.Drawing.Point(0, 0)
        Me.agrFechaListaDocumento.Name = "agrFechaListaDocumento"
        Me.agrFechaListaDocumento.Size = New System.Drawing.Size(1214, 73)
        Me.agrFechaListaDocumento.TabIndex = 5
        Me.agrFechaListaDocumento.Text = "Documentos Venta"
        Me.agrFechaListaDocumento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnMostrarDetalle
        '
        Me.btnMostrarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMostrarDetalle.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnMostrarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrarDetalle.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton
        Me.btnMostrarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarDetalle.ForeColor = System.Drawing.Color.Black
        Me.btnMostrarDetalle.Location = New System.Drawing.Point(1119, 35)
        Me.btnMostrarDetalle.Name = "btnMostrarDetalle"
        Me.btnMostrarDetalle.Size = New System.Drawing.Size(90, 25)
        Me.btnMostrarDetalle.TabIndex = 47
        Me.btnMostrarDetalle.Text = "Mostrar Detalle"
        '
        'rgFecha
        '
        Me.rgFecha.BackColor = System.Drawing.Color.White
        Me.rgFecha.Controls.Add(Me.object_d690ce1c_52a5_4c5e_b603_e9d168e11f95)
        Me.rgFecha.Controls.Add(Me.object_6e204a67_2146_4672_8ec0_5044b4c17289)
        Me.rgFecha.Controls.Add(Me.FechaHasta)
        Me.rgFecha.Controls.Add(Me.FechaDesde)
        Me.rgFecha.Controls.Add(Me.object_65ab087e_4fbb_431a_a85f_0f1f92b7b088)
        Me.rgFecha.Controls.Add(Me.object_85877b47_31a5_4c83_9f99_d9de9c861541)
        Me.rgFecha.Controls.Add(Me.Fecha1)
        Me.rgFecha.Controls.Add(Me.Fecha2)
        Me.rgFecha.Controls.Add(Me.Etiqueta3)
        Me.rgFecha.Controls.Add(Me.Etiqueta4)
        Me.rgFecha.Controls.Add(Me.Fecha3)
        Me.rgFecha.Controls.Add(Me.Fecha4)
        Me.rgFecha.Controls.Add(Me.object_5ddaa1bb_9920_4049_b390_616c2bb28fed)
        Me.rgFecha.Controls.Add(Me.object_04356b12_703c_4eeb_93d6_ef3ca567a82d)
        Me.rgFecha.Controls.Add(Me.Fecha5)
        Me.rgFecha.Controls.Add(Me.Fecha6)
        Me.rgFecha.Desde = New Date(2011, 12, 5, 0, 0, 0, 0)
        Me.rgFecha.Dock = System.Windows.Forms.DockStyle.Left
        Me.rgFecha.Hasta = New Date(2011, 12, 5, 0, 0, 0, 0)
        Me.rgFecha.Location = New System.Drawing.Point(2, 18)
        Me.rgFecha.Name = "rgFecha"
        Me.rgFecha.Size = New System.Drawing.Size(141, 53)
        Me.rgFecha.TabIndex = 46
        '
        'object_d690ce1c_52a5_4c5e_b603_e9d168e11f95
        '
        Me.object_d690ce1c_52a5_4c5e_b603_e9d168e11f95.AutoSize = True
        Me.object_d690ce1c_52a5_4c5e_b603_e9d168e11f95.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_d690ce1c_52a5_4c5e_b603_e9d168e11f95.ForeColor = System.Drawing.Color.Navy
        Me.object_d690ce1c_52a5_4c5e_b603_e9d168e11f95.Location = New System.Drawing.Point(8, 32)
        Me.object_d690ce1c_52a5_4c5e_b603_e9d168e11f95.Name = "object_d690ce1c_52a5_4c5e_b603_e9d168e11f95"
        Me.object_d690ce1c_52a5_4c5e_b603_e9d168e11f95.Size = New System.Drawing.Size(33, 14)
        Me.object_d690ce1c_52a5_4c5e_b603_e9d168e11f95.TabIndex = 3
        Me.object_d690ce1c_52a5_4c5e_b603_e9d168e11f95.Text = "Hasta"
        '
        'object_6e204a67_2146_4672_8ec0_5044b4c17289
        '
        Me.object_6e204a67_2146_4672_8ec0_5044b4c17289.AutoSize = True
        Me.object_6e204a67_2146_4672_8ec0_5044b4c17289.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_6e204a67_2146_4672_8ec0_5044b4c17289.ForeColor = System.Drawing.Color.Navy
        Me.object_6e204a67_2146_4672_8ec0_5044b4c17289.Location = New System.Drawing.Point(5, 6)
        Me.object_6e204a67_2146_4672_8ec0_5044b4c17289.Name = "object_6e204a67_2146_4672_8ec0_5044b4c17289"
        Me.object_6e204a67_2146_4672_8ec0_5044b4c17289.Size = New System.Drawing.Size(36, 14)
        Me.object_6e204a67_2146_4672_8ec0_5044b4c17289.TabIndex = 2
        Me.object_6e204a67_2146_4672_8ec0_5044b4c17289.Text = "Desde"
        '
        'FechaHasta
        '
        Appearance32.ForeColor = System.Drawing.Color.SteelBlue
        Me.FechaHasta.Appearance = Appearance32
        Me.FechaHasta.DateTime = New Date(2011, 12, 5, 0, 0, 0, 0)
        Me.FechaHasta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaHasta.ForeColor = System.Drawing.Color.SteelBlue
        Me.FechaHasta.Location = New System.Drawing.Point(51, 27)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(88, 23)
        Me.FechaHasta.TabIndex = 1
        Me.FechaHasta.Value = New Date(2011, 12, 5, 0, 0, 0, 0)
        '
        'FechaDesde
        '
        Appearance31.ForeColor = System.Drawing.Color.SteelBlue
        Me.FechaDesde.Appearance = Appearance31
        Me.FechaDesde.DateTime = New Date(2011, 12, 5, 0, 0, 0, 0)
        Me.FechaDesde.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDesde.ForeColor = System.Drawing.Color.SteelBlue
        Me.FechaDesde.Location = New System.Drawing.Point(51, 0)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(88, 23)
        Me.FechaDesde.TabIndex = 0
        Me.FechaDesde.Value = New Date(2011, 12, 5, 0, 0, 0, 0)
        '
        'object_65ab087e_4fbb_431a_a85f_0f1f92b7b088
        '
        Me.object_65ab087e_4fbb_431a_a85f_0f1f92b7b088.AutoSize = True
        Me.object_65ab087e_4fbb_431a_a85f_0f1f92b7b088.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_65ab087e_4fbb_431a_a85f_0f1f92b7b088.ForeColor = System.Drawing.Color.Navy
        Me.object_65ab087e_4fbb_431a_a85f_0f1f92b7b088.Location = New System.Drawing.Point(8, 32)
        Me.object_65ab087e_4fbb_431a_a85f_0f1f92b7b088.Name = "object_65ab087e_4fbb_431a_a85f_0f1f92b7b088"
        Me.object_65ab087e_4fbb_431a_a85f_0f1f92b7b088.Size = New System.Drawing.Size(33, 14)
        Me.object_65ab087e_4fbb_431a_a85f_0f1f92b7b088.TabIndex = 3
        Me.object_65ab087e_4fbb_431a_a85f_0f1f92b7b088.Text = "Hasta"
        '
        'object_85877b47_31a5_4c83_9f99_d9de9c861541
        '
        Me.object_85877b47_31a5_4c83_9f99_d9de9c861541.AutoSize = True
        Me.object_85877b47_31a5_4c83_9f99_d9de9c861541.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_85877b47_31a5_4c83_9f99_d9de9c861541.ForeColor = System.Drawing.Color.Navy
        Me.object_85877b47_31a5_4c83_9f99_d9de9c861541.Location = New System.Drawing.Point(5, 6)
        Me.object_85877b47_31a5_4c83_9f99_d9de9c861541.Name = "object_85877b47_31a5_4c83_9f99_d9de9c861541"
        Me.object_85877b47_31a5_4c83_9f99_d9de9c861541.Size = New System.Drawing.Size(36, 14)
        Me.object_85877b47_31a5_4c83_9f99_d9de9c861541.TabIndex = 2
        Me.object_85877b47_31a5_4c83_9f99_d9de9c861541.Text = "Desde"
        '
        'Fecha1
        '
        Appearance43.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha1.Appearance = Appearance43
        Me.Fecha1.DateTime = New Date(2011, 12, 5, 0, 0, 0, 0)
        Me.Fecha1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha1.Location = New System.Drawing.Point(51, 27)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(88, 23)
        Me.Fecha1.TabIndex = 1
        Me.Fecha1.Value = New Date(2011, 12, 5, 0, 0, 0, 0)
        '
        'Fecha2
        '
        Appearance2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha2.Appearance = Appearance2
        Me.Fecha2.DateTime = New Date(2011, 12, 5, 0, 0, 0, 0)
        Me.Fecha2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha2.Location = New System.Drawing.Point(51, 0)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(88, 23)
        Me.Fecha2.TabIndex = 0
        Me.Fecha2.Value = New Date(2011, 12, 5, 0, 0, 0, 0)
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Location = New System.Drawing.Point(8, 32)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta3.TabIndex = 3
        Me.Etiqueta3.Text = "Hasta"
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Location = New System.Drawing.Point(5, 6)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta4.TabIndex = 2
        Me.Etiqueta4.Text = "Desde"
        '
        'Fecha3
        '
        Appearance122.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha3.Appearance = Appearance122
        Me.Fecha3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha3.Location = New System.Drawing.Point(51, 27)
        Me.Fecha3.Name = "Fecha3"
        Me.Fecha3.Size = New System.Drawing.Size(88, 23)
        Me.Fecha3.TabIndex = 1
        '
        'Fecha4
        '
        Appearance121.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha4.Appearance = Appearance121
        Me.Fecha4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha4.Location = New System.Drawing.Point(51, 0)
        Me.Fecha4.Name = "Fecha4"
        Me.Fecha4.Size = New System.Drawing.Size(88, 23)
        Me.Fecha4.TabIndex = 0
        '
        'object_5ddaa1bb_9920_4049_b390_616c2bb28fed
        '
        Me.object_5ddaa1bb_9920_4049_b390_616c2bb28fed.AutoSize = True
        Me.object_5ddaa1bb_9920_4049_b390_616c2bb28fed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_5ddaa1bb_9920_4049_b390_616c2bb28fed.ForeColor = System.Drawing.Color.Navy
        Me.object_5ddaa1bb_9920_4049_b390_616c2bb28fed.Location = New System.Drawing.Point(8, 32)
        Me.object_5ddaa1bb_9920_4049_b390_616c2bb28fed.Name = "object_5ddaa1bb_9920_4049_b390_616c2bb28fed"
        Me.object_5ddaa1bb_9920_4049_b390_616c2bb28fed.Size = New System.Drawing.Size(33, 14)
        Me.object_5ddaa1bb_9920_4049_b390_616c2bb28fed.TabIndex = 3
        Me.object_5ddaa1bb_9920_4049_b390_616c2bb28fed.Text = "Hasta"
        '
        'object_04356b12_703c_4eeb_93d6_ef3ca567a82d
        '
        Me.object_04356b12_703c_4eeb_93d6_ef3ca567a82d.AutoSize = True
        Me.object_04356b12_703c_4eeb_93d6_ef3ca567a82d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_04356b12_703c_4eeb_93d6_ef3ca567a82d.ForeColor = System.Drawing.Color.Navy
        Me.object_04356b12_703c_4eeb_93d6_ef3ca567a82d.Location = New System.Drawing.Point(5, 6)
        Me.object_04356b12_703c_4eeb_93d6_ef3ca567a82d.Name = "object_04356b12_703c_4eeb_93d6_ef3ca567a82d"
        Me.object_04356b12_703c_4eeb_93d6_ef3ca567a82d.Size = New System.Drawing.Size(36, 14)
        Me.object_04356b12_703c_4eeb_93d6_ef3ca567a82d.TabIndex = 2
        Me.object_04356b12_703c_4eeb_93d6_ef3ca567a82d.Text = "Desde"
        '
        'Fecha5
        '
        Appearance20.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha5.Appearance = Appearance20
        Me.Fecha5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha5.Location = New System.Drawing.Point(51, 27)
        Me.Fecha5.Name = "Fecha5"
        Me.Fecha5.Size = New System.Drawing.Size(88, 23)
        Me.Fecha5.TabIndex = 1
        '
        'Fecha6
        '
        Appearance22.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha6.Appearance = Appearance22
        Me.Fecha6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Fecha6.Location = New System.Drawing.Point(51, 0)
        Me.Fecha6.Name = "Fecha6"
        Me.Fecha6.Size = New System.Drawing.Size(88, 23)
        Me.Fecha6.TabIndex = 0
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrDetalleVenta)
        Me.UltraTabPageControl1.Controls.Add(Me.agrVenta)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1214, 492)
        '
        'agrDetalleVenta
        '
        Me.agrDetalleVenta.Controls.Add(Me.Ficha1)
        Me.agrDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalleVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetalleVenta.ForeColor = System.Drawing.Color.Black
        Me.agrDetalleVenta.Location = New System.Drawing.Point(0, 240)
        Me.agrDetalleVenta.Name = "agrDetalleVenta"
        Me.agrDetalleVenta.Size = New System.Drawing.Size(1214, 252)
        Me.agrDetalleVenta.TabIndex = 1
        Me.agrDetalleVenta.Text = "Detalle Venta"
        Me.agrDetalleVenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Ficha1
        '
        Me.Ficha1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl2)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl3)
        Me.Ficha1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ficha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha1.Location = New System.Drawing.Point(2, 18)
        Me.Ficha1.Name = "Ficha1"
        Me.Ficha1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.Ficha1.Size = New System.Drawing.Size(1210, 232)
        Me.Ficha1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl2
        UltraTab1.Text = "Detalle"
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "Documentos Venta Referenciados"
        Me.Ficha1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.Ficha1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1208, 209)
        '
        'agrVenta
        '
        Me.agrVenta.Controls.Add(Me.agrTotalTexto)
        Me.agrVenta.Controls.Add(Me.Agrupacion3)
        Me.agrVenta.Controls.Add(Me.nupPorcentajeDescuento)
        Me.agrVenta.Controls.Add(Me.agrTotales)
        Me.agrVenta.Controls.Add(Me.Agrupacion2)
        Me.agrVenta.Controls.Add(Me.agrTrabajadorAsignado)
        Me.agrVenta.Controls.Add(Me.Etiqueta24)
        Me.agrVenta.Controls.Add(Me.verTrabajadorAsignado)
        Me.agrVenta.Controls.Add(Me.Etiqueta14)
        Me.agrVenta.Controls.Add(Me.decTotalDescuento)
        Me.agrVenta.Controls.Add(Me.Etiqueta18)
        Me.agrVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrVenta.ForeColor = System.Drawing.Color.Black
        Me.agrVenta.Location = New System.Drawing.Point(0, 0)
        Me.agrVenta.Name = "agrVenta"
        Me.agrVenta.Size = New System.Drawing.Size(1214, 240)
        Me.agrVenta.TabIndex = 0
        Me.agrVenta.Text = "Datos Generales"
        Me.agrVenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'agrTotalTexto
        '
        Me.agrTotalTexto.Controls.Add(Me.etiTotal)
        Me.agrTotalTexto.Controls.Add(Me.Etiqueta26)
        Me.agrTotalTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalTexto.ForeColor = System.Drawing.Color.Black
        Me.agrTotalTexto.Location = New System.Drawing.Point(2, 212)
        Me.agrTotalTexto.Name = "agrTotalTexto"
        Me.agrTotalTexto.Size = New System.Drawing.Size(1028, 28)
        Me.agrTotalTexto.TabIndex = 55
        Me.agrTotalTexto.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'etiTotal
        '
        Me.etiTotal.AutoSize = True
        Me.etiTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotal.ForeColor = System.Drawing.Color.Black
        Me.etiTotal.Location = New System.Drawing.Point(39, 8)
        Me.etiTotal.Name = "etiTotal"
        Me.etiTotal.Size = New System.Drawing.Size(0, 0)
        Me.etiTotal.TabIndex = 4
        '
        'Etiqueta26
        '
        Appearance9.BackColor = System.Drawing.Color.White
        Me.Etiqueta26.Appearance = Appearance9
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(5, 8)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(27, 14)
        Me.Etiqueta26.TabIndex = 3
        Me.Etiqueta26.Text = "Son:"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion3.Controls.Add(Me.cboTipoDocumento)
        Me.Agrupacion3.Controls.Add(Me.cboMoneda)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion3.Controls.Add(Me.cboTipoPago)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion3.Controls.Add(Me.cboCliente)
        Me.Agrupacion3.Controls.Add(Me.txtNumero)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion3.Controls.Add(Me.txtSerie)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion3.Controls.Add(Me.txtConcepto)
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(2, 19)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(365, 163)
        Me.Agrupacion3.TabIndex = 54
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Etiqueta8
        '
        Appearance8.BackColor = System.Drawing.Color.White
        Me.Etiqueta8.Appearance = Appearance8
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(4, 4)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(78, 14)
        Me.Etiqueta8.TabIndex = 4
        Me.Etiqueta8.Text = "Serie - Numero"
        '
        'Etiqueta5
        '
        Appearance46.BackColor = System.Drawing.Color.White
        Me.Etiqueta5.Appearance = Appearance46
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(4, 24)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(85, 14)
        Me.Etiqueta5.TabIndex = 0
        Me.Etiqueta5.Text = "Tipo Documento"
        '
        'cboTipoDocumento
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance4
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.DisplayMember = "Nombre"
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(95, 26)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.ReadOnly = True
        Me.cboTipoDocumento.Size = New System.Drawing.Size(264, 21)
        Me.cboTipoDocumento.TabIndex = 2
        Me.cboTipoDocumento.ValueMember = "Id"
        '
        'cboMoneda
        '
        Appearance38.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance38
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(95, 70)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(264, 21)
        Me.cboMoneda.TabIndex = 4
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Appearance15.BackColor = System.Drawing.Color.White
        Me.Etiqueta7.Appearance = Appearance15
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(4, 46)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta7.TabIndex = 0
        Me.Etiqueta7.Text = "Tipo Pago"
        '
        'cboTipoPago
        '
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance14
        Me.cboTipoPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoPago.DisplayMember = "Nombre"
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Location = New System.Drawing.Point(95, 48)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(264, 21)
        Me.cboTipoPago.TabIndex = 3
        Me.cboTipoPago.ValueMember = "Id"
        '
        'Etiqueta11
        '
        Appearance29.BackColor = System.Drawing.Color.White
        Me.Etiqueta11.Appearance = Appearance29
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(4, 68)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(68, 14)
        Me.Etiqueta11.TabIndex = 0
        Me.Etiqueta11.Text = "Tipo Moneda"
        '
        'Etiqueta17
        '
        Appearance45.BackColor = System.Drawing.Color.White
        Me.Etiqueta17.Appearance = Appearance45
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(4, 90)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta17.TabIndex = 0
        Me.Etiqueta17.Text = "Cliente"
        '
        'cboCliente
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Appearance = Appearance3
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Location = New System.Drawing.Point(95, 92)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(264, 21)
        Me.cboCliente.TabIndex = 5
        Me.cboCliente.ValueMember = "Id"
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(138, 4)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(74, 21)
        Me.txtNumero.TabIndex = 1
        '
        'Etiqueta6
        '
        Appearance54.BackColor = System.Drawing.Color.White
        Me.Etiqueta6.Appearance = Appearance54
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(4, 113)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta6.TabIndex = 2
        Me.Etiqueta6.Text = "Glosa"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(95, 4)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(35, 21)
        Me.txtSerie.TabIndex = 0
        '
        'Etiqueta9
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Me.Etiqueta9.Appearance = Appearance5
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(130, 5)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta9.TabIndex = 2
        Me.Etiqueta9.Text = "-"
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Location = New System.Drawing.Point(95, 114)
        Me.txtConcepto.MaxLength = 400
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConcepto.Size = New System.Drawing.Size(264, 39)
        Me.txtConcepto.TabIndex = 6
        '
        'nupPorcentajeDescuento
        '
        Me.nupPorcentajeDescuento.DecimalPlaces = 2
        Me.nupPorcentajeDescuento.Location = New System.Drawing.Point(1136, 121)
        Me.nupPorcentajeDescuento.Name = "nupPorcentajeDescuento"
        Me.nupPorcentajeDescuento.Size = New System.Drawing.Size(56, 20)
        Me.nupPorcentajeDescuento.TabIndex = 1
        Me.nupPorcentajeDescuento.Visible = False
        '
        'agrTotales
        '
        Me.agrTotales.Controls.Add(Me.decValorIgv)
        Me.agrTotales.Controls.Add(Me.Etiqueta20)
        Me.agrTotales.Controls.Add(Me.Etiqueta12)
        Me.agrTotales.Controls.Add(Me.decSubTotal)
        Me.agrTotales.Controls.Add(Me.Etiqueta13)
        Me.agrTotales.Controls.Add(Me.fecFechaVencimiento)
        Me.agrTotales.Controls.Add(Me.decSaldo)
        Me.agrTotales.Controls.Add(Me.Etiqueta15)
        Me.agrTotales.Controls.Add(Me.fecFechaEmision)
        Me.agrTotales.Controls.Add(Me.etiFechaVencimiento)
        Me.agrTotales.Controls.Add(Me.decTotalEfectivo)
        Me.agrTotales.Controls.Add(Me.decTotalFacturado)
        Me.agrTotales.Controls.Add(Me.verIgv)
        Me.agrTotales.Controls.Add(Me.Etiqueta10)
        Me.agrTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotales.ForeColor = System.Drawing.Color.Black
        Me.agrTotales.Location = New System.Drawing.Point(368, 21)
        Me.agrTotales.Name = "agrTotales"
        Me.agrTotales.Size = New System.Drawing.Size(222, 161)
        Me.agrTotales.TabIndex = 53
        Me.agrTotales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'decValorIgv
        '
        Appearance41.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance41.ForeColor = System.Drawing.Color.Black
        Me.decValorIgv.Appearance = Appearance41
        Me.decValorIgv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decValorIgv.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decValorIgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValorIgv.ForeColor = System.Drawing.Color.Black
        Me.decValorIgv.Location = New System.Drawing.Point(104, 70)
        Me.decValorIgv.Name = "decValorIgv"
        Me.decValorIgv.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValorIgv.ReadOnly = True
        Me.decValorIgv.Size = New System.Drawing.Size(115, 21)
        Me.decValorIgv.TabIndex = 4
        '
        'Etiqueta20
        '
        Appearance21.BackColor = System.Drawing.Color.White
        Me.Etiqueta20.Appearance = Appearance21
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(6, 53)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(61, 14)
        Me.Etiqueta20.TabIndex = 48
        Me.Etiqueta20.Text = "Valor Venta"
        '
        'Etiqueta12
        '
        Appearance49.BackColor = System.Drawing.Color.White
        Me.Etiqueta12.Appearance = Appearance49
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(4, 96)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta12.TabIndex = 5
        Me.Etiqueta12.Text = "Total Facturado"
        '
        'decSubTotal
        '
        Appearance50.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal.Appearance = Appearance50
        Me.decSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSubTotal.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal.Location = New System.Drawing.Point(104, 48)
        Me.decSubTotal.Name = "decSubTotal"
        Me.decSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotal.ReadOnly = True
        Me.decSubTotal.Size = New System.Drawing.Size(115, 21)
        Me.decSubTotal.TabIndex = 2
        '
        'Etiqueta13
        '
        Appearance24.BackColor = System.Drawing.Color.White
        Me.Etiqueta13.Appearance = Appearance24
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(4, 118)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta13.TabIndex = 6
        Me.Etiqueta13.Text = "Total Efectivo"
        '
        'fecFechaVencimiento
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.fecFechaVencimiento.Appearance = Appearance10
        Me.fecFechaVencimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaVencimiento.ForeColor = System.Drawing.Color.Black
        Me.fecFechaVencimiento.Location = New System.Drawing.Point(104, 26)
        Me.fecFechaVencimiento.Name = "fecFechaVencimiento"
        Me.fecFechaVencimiento.Size = New System.Drawing.Size(115, 21)
        Me.fecFechaVencimiento.TabIndex = 1
        '
        'decSaldo
        '
        Appearance39.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance39.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Appearance = Appearance39
        Me.decSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldo.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Location = New System.Drawing.Point(104, 136)
        Me.decSaldo.Name = "decSaldo"
        Me.decSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldo.ReadOnly = True
        Me.decSaldo.Size = New System.Drawing.Size(115, 21)
        Me.decSaldo.TabIndex = 8
        '
        'Etiqueta15
        '
        Appearance40.BackColor = System.Drawing.Color.White
        Me.Etiqueta15.Appearance = Appearance40
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(4, 140)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta15.TabIndex = 6
        Me.Etiqueta15.Text = "Total Credito"
        '
        'fecFechaEmision
        '
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.fecFechaEmision.Appearance = Appearance13
        Me.fecFechaEmision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaEmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaEmision.ForeColor = System.Drawing.Color.Black
        Me.fecFechaEmision.Location = New System.Drawing.Point(104, 5)
        Me.fecFechaEmision.Name = "fecFechaEmision"
        Me.fecFechaEmision.Size = New System.Drawing.Size(115, 21)
        Me.fecFechaEmision.TabIndex = 0
        '
        'etiFechaVencimiento
        '
        Appearance17.BackColor = System.Drawing.Color.White
        Me.etiFechaVencimiento.Appearance = Appearance17
        Me.etiFechaVencimiento.AutoSize = True
        Me.etiFechaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaVencimiento.ForeColor = System.Drawing.Color.Black
        Me.etiFechaVencimiento.Location = New System.Drawing.Point(6, 28)
        Me.etiFechaVencimiento.Name = "etiFechaVencimiento"
        Me.etiFechaVencimiento.Size = New System.Drawing.Size(66, 14)
        Me.etiFechaVencimiento.TabIndex = 6
        Me.etiFechaVencimiento.Text = "Fecha Venc."
        '
        'decTotalEfectivo
        '
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance25.ForeColor = System.Drawing.Color.Black
        Me.decTotalEfectivo.Appearance = Appearance25
        Me.decTotalEfectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decTotalEfectivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalEfectivo.ForeColor = System.Drawing.Color.Black
        Me.decTotalEfectivo.Location = New System.Drawing.Point(104, 114)
        Me.decTotalEfectivo.Name = "decTotalEfectivo"
        Me.decTotalEfectivo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalEfectivo.Size = New System.Drawing.Size(115, 21)
        Me.decTotalEfectivo.TabIndex = 7
        '
        'decTotalFacturado
        '
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.decTotalFacturado.Appearance = Appearance23
        Me.decTotalFacturado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decTotalFacturado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalFacturado.ForeColor = System.Drawing.Color.Black
        Me.decTotalFacturado.Location = New System.Drawing.Point(104, 92)
        Me.decTotalFacturado.Name = "decTotalFacturado"
        Me.decTotalFacturado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalFacturado.ReadOnly = True
        Me.decTotalFacturado.Size = New System.Drawing.Size(115, 21)
        Me.decTotalFacturado.TabIndex = 6
        '
        'verIgv
        '
        Me.verIgv.BackColor = System.Drawing.Color.White
        Me.verIgv.BackColorInternal = System.Drawing.Color.White
        Me.verIgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIgv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verIgv.Location = New System.Drawing.Point(6, 69)
        Me.verIgv.Name = "verIgv"
        Me.verIgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verIgv.Size = New System.Drawing.Size(56, 20)
        Me.verIgv.TabIndex = 3
        Me.verIgv.Tag = "0"
        Me.verIgv.Text = "Inc. Igv"
        '
        'Etiqueta10
        '
        Appearance12.BackColor = System.Drawing.Color.White
        Me.Etiqueta10.Appearance = Appearance12
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(6, 5)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(77, 14)
        Me.Etiqueta10.TabIndex = 6
        Me.Etiqueta10.Text = "Fecha Emision"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.decDetraccion)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta25)
        Me.Agrupacion2.Controls.Add(Me.decTotalDetraccion)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion2.Controls.Add(Me.nupPorcentajeDetraccion)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(2, 182)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(588, 30)
        Me.Agrupacion2.TabIndex = 52
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'decDetraccion
        '
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.decDetraccion.Appearance = Appearance26
        Me.decDetraccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decDetraccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decDetraccion.ForeColor = System.Drawing.Color.Black
        Me.decDetraccion.Location = New System.Drawing.Point(470, 4)
        Me.decDetraccion.Name = "decDetraccion"
        Me.decDetraccion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decDetraccion.ReadOnly = True
        Me.decDetraccion.Size = New System.Drawing.Size(115, 21)
        Me.decDetraccion.TabIndex = 2
        '
        'Etiqueta25
        '
        Appearance27.BackColor = System.Drawing.Color.White
        Me.Etiqueta25.Appearance = Appearance27
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(182, 8)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta25.TabIndex = 8
        Me.Etiqueta25.Text = "Detracción"
        '
        'decTotalDetraccion
        '
        Appearance52.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance52.ForeColor = System.Drawing.Color.Black
        Me.decTotalDetraccion.Appearance = Appearance52
        Me.decTotalDetraccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decTotalDetraccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalDetraccion.ForeColor = System.Drawing.Color.Black
        Me.decTotalDetraccion.Location = New System.Drawing.Point(244, 4)
        Me.decTotalDetraccion.Name = "decTotalDetraccion"
        Me.decTotalDetraccion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalDetraccion.ReadOnly = True
        Me.decTotalDetraccion.Size = New System.Drawing.Size(115, 21)
        Me.decTotalDetraccion.TabIndex = 1
        '
        'Etiqueta21
        '
        Appearance35.BackColor = System.Drawing.Color.White
        Me.Etiqueta21.Appearance = Appearance35
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(5, 6)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta21.TabIndex = 6
        Me.Etiqueta21.Text = "Detracción"
        '
        'nupPorcentajeDetraccion
        '
        Me.nupPorcentajeDetraccion.DecimalPlaces = 2
        Me.nupPorcentajeDetraccion.Location = New System.Drawing.Point(95, 5)
        Me.nupPorcentajeDetraccion.Name = "nupPorcentajeDetraccion"
        Me.nupPorcentajeDetraccion.Size = New System.Drawing.Size(56, 20)
        Me.nupPorcentajeDetraccion.TabIndex = 0
        '
        'Etiqueta23
        '
        Appearance53.BackColor = System.Drawing.Color.White
        Me.Etiqueta23.Appearance = Appearance53
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(371, 9)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta23.TabIndex = 6
        Me.Etiqueta23.Text = "Neto a Pagar"
        '
        'Etiqueta22
        '
        Appearance19.BackColor = System.Drawing.Color.White
        Me.Etiqueta22.Appearance = Appearance19
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(68, 8)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta22.TabIndex = 1
        Me.Etiqueta22.Text = "%"
        '
        'agrTrabajadorAsignado
        '
        Me.agrTrabajadorAsignado.Controls.Add(Me.etiSaldoCuentaTrabajador)
        Me.agrTrabajadorAsignado.Controls.Add(Me.etiNumeroCuenta)
        Me.agrTrabajadorAsignado.Controls.Add(Me.etiNombre)
        Me.agrTrabajadorAsignado.Controls.Add(Me.etiDni)
        Me.agrTrabajadorAsignado.Controls.Add(Me.cboCuentaCorrienteTrabajador)
        Me.agrTrabajadorAsignado.Controls.Add(Me.picRecibidor)
        Me.agrTrabajadorAsignado.Controls.Add(Me.Etiqueta16)
        Me.agrTrabajadorAsignado.Controls.Add(Me.Etiqueta2)
        Me.agrTrabajadorAsignado.Controls.Add(Me.Etiqueta1)
        Me.agrTrabajadorAsignado.Controls.Add(Me.Etiqueta19)
        Me.agrTrabajadorAsignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTrabajadorAsignado.ForeColor = System.Drawing.Color.Black
        Me.agrTrabajadorAsignado.Location = New System.Drawing.Point(593, 35)
        Me.agrTrabajadorAsignado.Name = "agrTrabajadorAsignado"
        Me.agrTrabajadorAsignado.Size = New System.Drawing.Size(437, 147)
        Me.agrTrabajadorAsignado.TabIndex = 1
        Me.agrTrabajadorAsignado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        Me.agrTrabajadorAsignado.Visible = False
        '
        'etiSaldoCuentaTrabajador
        '
        Appearance37.BackColor = System.Drawing.Color.White
        Me.etiSaldoCuentaTrabajador.Appearance = Appearance37
        Me.etiSaldoCuentaTrabajador.AutoSize = True
        Me.etiSaldoCuentaTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSaldoCuentaTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiSaldoCuentaTrabajador.Location = New System.Drawing.Point(221, 109)
        Me.etiSaldoCuentaTrabajador.Name = "etiSaldoCuentaTrabajador"
        Me.etiSaldoCuentaTrabajador.Size = New System.Drawing.Size(0, 0)
        Me.etiSaldoCuentaTrabajador.TabIndex = 45
        '
        'etiNumeroCuenta
        '
        Appearance7.BackColor = System.Drawing.Color.White
        Me.etiNumeroCuenta.Appearance = Appearance7
        Me.etiNumeroCuenta.AutoSize = True
        Me.etiNumeroCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNumeroCuenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNumeroCuenta.Location = New System.Drawing.Point(221, 85)
        Me.etiNumeroCuenta.Name = "etiNumeroCuenta"
        Me.etiNumeroCuenta.Size = New System.Drawing.Size(0, 0)
        Me.etiNumeroCuenta.TabIndex = 45
        '
        'etiNombre
        '
        Appearance28.BackColor = System.Drawing.Color.White
        Me.etiNombre.Appearance = Appearance28
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNombre.Location = New System.Drawing.Point(221, 63)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(0, 0)
        Me.etiNombre.TabIndex = 45
        '
        'etiDni
        '
        Appearance11.BackColor = System.Drawing.Color.White
        Me.etiDni.Appearance = Appearance11
        Me.etiDni.AutoSize = True
        Me.etiDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiDni.Location = New System.Drawing.Point(221, 39)
        Me.etiDni.Name = "etiDni"
        Me.etiDni.Size = New System.Drawing.Size(0, 0)
        Me.etiDni.TabIndex = 44
        '
        'cboCuentaCorrienteTrabajador
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaCorrienteTrabajador.Appearance = Appearance1
        Me.cboCuentaCorrienteTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCuentaCorrienteTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaCorrienteTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaCorrienteTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaCorrienteTrabajador.Location = New System.Drawing.Point(126, 4)
        Me.cboCuentaCorrienteTrabajador.Name = "cboCuentaCorrienteTrabajador"
        Me.cboCuentaCorrienteTrabajador.Size = New System.Drawing.Size(307, 21)
        Me.cboCuentaCorrienteTrabajador.TabIndex = 0
        Me.cboCuentaCorrienteTrabajador.ValueMember = "Id"
        '
        'picRecibidor
        '
        Me.picRecibidor.Location = New System.Drawing.Point(3, 4)
        Me.picRecibidor.Name = "picRecibidor"
        Me.picRecibidor.Size = New System.Drawing.Size(121, 140)
        Me.picRecibidor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRecibidor.TabIndex = 43
        Me.picRecibidor.TabStop = False
        '
        'Etiqueta16
        '
        Appearance18.BackColor = System.Drawing.Color.White
        Me.Etiqueta16.Appearance = Appearance18
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(126, 39)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(21, 14)
        Me.Etiqueta16.TabIndex = 41
        Me.Etiqueta16.Text = "Dni"
        '
        'Etiqueta2
        '
        Appearance44.BackColor = System.Drawing.Color.White
        Me.Etiqueta2.Appearance = Appearance44
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(126, 109)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta2.TabIndex = 42
        Me.Etiqueta2.Text = "Saldo"
        '
        'Etiqueta1
        '
        Appearance34.BackColor = System.Drawing.Color.White
        Me.Etiqueta1.Appearance = Appearance34
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(126, 85)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta1.TabIndex = 42
        Me.Etiqueta1.Text = "Numero Cuenta "
        '
        'Etiqueta19
        '
        Appearance30.BackColor = System.Drawing.Color.White
        Me.Etiqueta19.Appearance = Appearance30
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta19.Location = New System.Drawing.Point(126, 63)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta19.TabIndex = 42
        Me.Etiqueta19.Text = "Nombre"
        '
        'Etiqueta24
        '
        Appearance48.BackColor = System.Drawing.Color.White
        Me.Etiqueta24.Appearance = Appearance48
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(1036, 144)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta24.TabIndex = 6
        Me.Etiqueta24.Text = "TotalDescuento"
        Me.Etiqueta24.Visible = False
        '
        'verTrabajadorAsignado
        '
        Appearance36.BackColor = System.Drawing.Color.White
        Me.verTrabajadorAsignado.Appearance = Appearance36
        Me.verTrabajadorAsignado.BackColor = System.Drawing.Color.White
        Me.verTrabajadorAsignado.BackColorInternal = System.Drawing.Color.White
        Me.verTrabajadorAsignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verTrabajadorAsignado.ForeColor = System.Drawing.Color.Black
        Me.verTrabajadorAsignado.Location = New System.Drawing.Point(593, 18)
        Me.verTrabajadorAsignado.Name = "verTrabajadorAsignado"
        Me.verTrabajadorAsignado.Size = New System.Drawing.Size(129, 20)
        Me.verTrabajadorAsignado.TabIndex = 0
        Me.verTrabajadorAsignado.Text = "Trabajador Asignado"
        '
        'Etiqueta14
        '
        Appearance6.BackColor = System.Drawing.Color.White
        Me.Etiqueta14.Appearance = Appearance6
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(1036, 121)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta14.TabIndex = 6
        Me.Etiqueta14.Text = "Descuento"
        Me.Etiqueta14.Visible = False
        '
        'decTotalDescuento
        '
        Appearance47.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance47.ForeColor = System.Drawing.Color.Black
        Me.decTotalDescuento.Appearance = Appearance47
        Me.decTotalDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decTotalDescuento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalDescuento.ForeColor = System.Drawing.Color.Black
        Me.decTotalDescuento.Location = New System.Drawing.Point(1136, 143)
        Me.decTotalDescuento.Name = "decTotalDescuento"
        Me.decTotalDescuento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalDescuento.ReadOnly = True
        Me.decTotalDescuento.Size = New System.Drawing.Size(115, 21)
        Me.decTotalDescuento.TabIndex = 3
        Me.decTotalDescuento.Visible = False
        '
        'Etiqueta18
        '
        Appearance42.BackColor = System.Drawing.Color.White
        Me.Etiqueta18.Appearance = Appearance42
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(1099, 120)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta18.TabIndex = 2
        Me.Etiqueta18.Text = "%"
        Me.Etiqueta18.Visible = False
        '
        'ogdDocumentoVenta
        '
        UltraDataColumn52.DataType = GetType(Double)
        UltraDataColumn52.DefaultValue = 0
        UltraDataColumn57.DataType = GetType(Boolean)
        UltraDataColumn59.DataType = GetType(Double)
        UltraDataColumn59.DefaultValue = 0
        UltraDataColumn60.DataType = GetType(Double)
        UltraDataColumn60.DefaultValue = 0
        UltraDataColumn61.DataType = GetType(Double)
        UltraDataColumn61.DefaultValue = 0
        Me.ogdDocumentoVenta.Band.Columns.AddRange(New Object() {UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61})
        '
        'ogdDemandaDetalle
        '
        UltraDataColumn66.DataType = GetType(Double)
        UltraDataColumn66.DefaultValue = 0
        UltraDataColumn67.DataType = GetType(Double)
        UltraDataColumn67.DefaultValue = 0
        UltraDataColumn68.DataType = GetType(Boolean)
        UltraDataColumn69.DataType = GetType(Boolean)
        UltraDataColumn72.DataType = GetType(Double)
        UltraDataColumn72.DefaultValue = 0
        UltraDataColumn73.DataType = GetType(Object)
        UltraDataColumn74.DataType = GetType(Double)
        Me.ogdDemandaDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78})
        '
        'FicDocumentoVenta
        '
        Me.FicDocumentoVenta.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.FicDocumentoVenta.Controls.Add(Me.UltraTabPageControl6)
        Me.FicDocumentoVenta.Controls.Add(Me.UltraTabPageControl7)
        Me.FicDocumentoVenta.Controls.Add(Me.UltraTabPageControl1)
        Me.FicDocumentoVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FicDocumentoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FicDocumentoVenta.Location = New System.Drawing.Point(0, 0)
        Me.FicDocumentoVenta.Name = "FicDocumentoVenta"
        Me.FicDocumentoVenta.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.FicDocumentoVenta.Size = New System.Drawing.Size(1216, 515)
        Me.FicDocumentoVenta.TabIndex = 5
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Operaciones"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Listado"
        UltraTab8.TabPage = Me.UltraTabPageControl1
        UltraTab8.Text = "Generar Documento"
        Me.FicDocumentoVenta.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7, UltraTab8})
        Me.FicDocumentoVenta.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1214, 492)
        '
        'frm_DocumentoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 515)
        Me.Controls.Add(Me.FicDocumentoVenta)
        Me.Name = "frm_DocumentoVenta"
        Me.Text = "Documento de Venta"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griDocumentoVentaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDocumentoVentaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        Me.spcDocumentoVenta.Panel1.ResumeLayout(False)
        Me.spcDocumentoVenta.Panel2.ResumeLayout(False)
        Me.spcDocumentoVenta.ResumeLayout(False)
        CType(Me.agrListaDocumentoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaDocumentoVenta.ResumeLayout(False)
        CType(Me.griDocumentoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griListaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrFechaListaDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFechaListaDocumento.ResumeLayout(False)
        Me.rgFecha.ResumeLayout(False)
        Me.rgFecha.PerformLayout()
        CType(Me.FechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalleVenta.ResumeLayout(False)
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha1.ResumeLayout(False)
        CType(Me.agrVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrVenta.ResumeLayout(False)
        Me.agrVenta.PerformLayout()
        CType(Me.agrTotalTexto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalTexto.ResumeLayout(False)
        Me.agrTotalTexto.PerformLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupPorcentajeDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrTotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotales.ResumeLayout(False)
        Me.agrTotales.PerformLayout()
        CType(Me.decValorIgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaEmision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalFacturado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.decDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupPorcentajeDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrTrabajadorAsignado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTrabajadorAsignado.ResumeLayout(False)
        Me.agrTrabajadorAsignado.PerformLayout()
        CType(Me.cboCuentaCorrienteTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRecibidor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verTrabajadorAsignado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDocumentoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDemandaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FicDocumentoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FicDocumentoVenta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ogdDocumentoVenta As ISL.Controles.OrigenDatos
    Friend WithEvents agrVenta As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoDocumento As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents txtConcepto As ISL.Controles.Texto
    Friend WithEvents cboTipoPago As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaVencimiento As ISL.Controles.Fecha
    Friend WithEvents fecFechaEmision As ISL.Controles.Fecha
    Friend WithEvents etiFechaVencimiento As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents decTotalFacturado As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents decTotalEfectivo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents decSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents agrDetalleVenta As ISL.Controles.Agrupacion
    Friend WithEvents cboCliente As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents FicDocumentoVenta As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdDemandaDetalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents cboCuentaCorrienteTrabajador As ISL.Controles.Combo
    Friend WithEvents verTrabajadorAsignado As ISL.Controles.Chequear
    Friend WithEvents picRecibidor As System.Windows.Forms.PictureBox
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents etiDni As ISL.Controles.Etiqueta
    Friend WithEvents agrTrabajadorAsignado As ISL.Controles.Agrupacion
    Friend WithEvents etiNumeroCuenta As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents etiSaldoCuentaTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents griDemanda As ISL.Controles.Grilla
    Friend WithEvents ogdDemanda As ISL.Controles.OrigenDatos
    Friend WithEvents griDocumentoVentaDetalle As ISL.Controles.Grilla
    Friend WithEvents ogdDocumentoVentaDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents agrFechaListaDocumento As ISL.Controles.Agrupacion
    Friend WithEvents rgFecha As ISL.Controles.RangoFechas2
    Friend WithEvents object_d690ce1c_52a5_4c5e_b603_e9d168e11f95 As ISL.Controles.Etiqueta
    Friend WithEvents object_6e204a67_2146_4672_8ec0_5044b4c17289 As ISL.Controles.Etiqueta
    Friend WithEvents FechaHasta As ISL.Controles.Fecha
    Friend WithEvents FechaDesde As ISL.Controles.Fecha
    Friend WithEvents object_65ab087e_4fbb_431a_a85f_0f1f92b7b088 As ISL.Controles.Etiqueta
    Friend WithEvents object_85877b47_31a5_4c83_9f99_d9de9c861541 As ISL.Controles.Etiqueta
    Friend WithEvents Fecha1 As ISL.Controles.Fecha
    Friend WithEvents Fecha2 As ISL.Controles.Fecha
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Fecha3 As ISL.Controles.Fecha
    Friend WithEvents Fecha4 As ISL.Controles.Fecha
    Friend WithEvents object_5ddaa1bb_9920_4049_b390_616c2bb28fed As ISL.Controles.Etiqueta
    Friend WithEvents object_04356b12_703c_4eeb_93d6_ef3ca567a82d As ISL.Controles.Etiqueta
    Friend WithEvents Fecha5 As ISL.Controles.Fecha
    Friend WithEvents Fecha6 As ISL.Controles.Fecha
    Friend WithEvents agrListaDocumentoVenta As ISL.Controles.Agrupacion
    Friend WithEvents griDocumentoVenta As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents griListaDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents spcDocumentoVenta As System.Windows.Forms.SplitContainer
    Friend WithEvents btnMostrarDetalle As ISL.Controles.Boton
    Friend WithEvents verIgv As ISL.Controles.Chequear
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents decSubTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents decTotalDetraccion As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents nupPorcentajeDescuento As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupPorcentajeDetraccion As System.Windows.Forms.NumericUpDown
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents decTotalDescuento As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents agrTotales As ISL.Controles.Agrupacion
    Friend WithEvents decDetraccion As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents Ficha1 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents agrTotalTexto As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents etiTotal As ISL.Controles.Etiqueta
    Friend WithEvents decValorIgv As ISL.Controles.NumeroDecimal
End Class
