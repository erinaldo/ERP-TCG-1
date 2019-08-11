<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PagoRetencion
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoDoc")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEnviado")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnulado")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Regimen")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tasa")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comentario")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMonedaRetencion")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambioRetencion")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteRetencion")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMonedaPagado")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImportePagado")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDocElectronico")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoElectronico")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEmail")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndExterno")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Voucher")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreTipoDoc")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndElectronico")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEnviado")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnulado")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Regimen")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tasa")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comentario")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMonedaRetencion")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambioRetencion")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImporteRetencion")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMonedaPagado")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImportePagado")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroDocElectronico")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoElectronico")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEmail")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndExterno")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoCajaBanco")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnexo")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMotivo")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenCompra")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoCajaBanco")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndElectronico")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnexo")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoBien")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMotivo")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OrdenCompra")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoCajaBanco")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnexo")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMotivo")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenCompra")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoCajaBanco")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndElectronico")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnexo")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoBien")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMotivo")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OrdenCompra")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersonaEmpresa")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oePersona")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oeEmpresa")
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grilla1 = New ISL.Controles.Grilla(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActualizarStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.FiltroGeneral = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAnulados = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridTicket = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gridPagoAgregado = New ISL.Controles.Grilla(Me.components)
        Me.MenuAgregados = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.gridPago = New ISL.Controles.Grilla(Me.components)
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.chkProveedor = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecRetencion = New System.Windows.Forms.DateTimePicker()
        Me.UltraPanel3 = New Infragistics.Win.Misc.UltraPanel()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiImporteSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiImporteDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficRetencion = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.colorGenerado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorRechazado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorProceso = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorAceptado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.btnConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.btnAnular = New Infragistics.Win.Misc.UltraButton()
        Me.btnXml = New Infragistics.Win.Misc.UltraButton()
        Me.fecFin = New System.Windows.Forms.DateTimePicker()
        Me.fecInicio = New System.Windows.Forms.DateTimePicker()
        Me.btnEnviarSunat = New Infragistics.Win.Misc.UltraButton()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.FecEmisAgregar = New ISL.Controles.Fecha(Me.components)
        Me.btanCancelar = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerieAgregar = New ISL.Controles.Texto(Me.components)
        Me.btnAgregar = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtVoucherAgregar = New ISL.Controles.Texto(Me.components)
        Me.txtNroAgregar = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.tcCobranza = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.Grilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griAnulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.gridTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridPagoAgregado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAgregados.SuspendLayout()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.chkProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel3.ClientArea.SuspendLayout()
        Me.UltraPanel3.SuspendLayout()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ficRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficRetencion.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.colorGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorRechazado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAceptado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.FecEmisAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcCobranza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcCobranza.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Grilla1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1201, 371)
        '
        'Grilla1
        '
        Me.Grilla1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Grilla1.DataSource = Me.UltraDataSource3
        UltraGridColumn85.Header.VisiblePosition = 0
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.Caption = "TipoDoc"
        UltraGridColumn86.Header.VisiblePosition = 1
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.Width = 140
        UltraGridColumn87.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn87.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn87.Header.VisiblePosition = 3
        UltraGridColumn87.Width = 76
        UltraGridColumn88.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn88.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn88.Header.VisiblePosition = 4
        UltraGridColumn88.Width = 102
        UltraGridColumn89.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn89.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn89.Header.Caption = "Fec Emi."
        UltraGridColumn89.Header.VisiblePosition = 5
        UltraGridColumn89.Width = 119
        UltraGridColumn90.Header.VisiblePosition = 8
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 7
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 6
        UltraGridColumn93.Header.Caption = "Tipo Doc"
        UltraGridColumn93.Header.VisiblePosition = 2
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 9
        UltraGridColumn95.Header.Caption = "Electronico"
        UltraGridColumn95.Header.VisiblePosition = 14
        UltraGridColumn95.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn96.Header.Caption = "Enviado"
        UltraGridColumn96.Header.VisiblePosition = 15
        UltraGridColumn97.Header.Caption = "Anulado"
        UltraGridColumn97.Header.VisiblePosition = 16
        UltraGridColumn98.Header.VisiblePosition = 10
        UltraGridColumn98.Width = 57
        UltraGridColumn99.Header.VisiblePosition = 11
        UltraGridColumn99.Width = 48
        UltraGridColumn100.Header.VisiblePosition = 17
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 18
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 19
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 20
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 21
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 22
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 12
        UltraGridColumn107.Header.VisiblePosition = 13
        UltraGridColumn108.Header.Caption = "Email"
        UltraGridColumn108.Header.VisiblePosition = 23
        UltraGridColumn109.Header.Caption = "Externo"
        UltraGridColumn109.Header.VisiblePosition = 24
        UltraGridColumn110.Header.VisiblePosition = 25
        UltraGridColumn110.Hidden = True
        UltraGridColumn111.Header.VisiblePosition = 26
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 27
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 28
        UltraGridColumn113.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113})
        Me.Grilla1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grilla1.DisplayLayout.MaxColScrollRegions = 1
        Me.Grilla1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.Grilla1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grilla1.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grilla1.DisplayLayout.Override.FilterUIProvider = Me.FiltroGeneral
        Me.Grilla1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grilla1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grilla1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grilla1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.Grilla1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla1.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.Grilla1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla1.Location = New System.Drawing.Point(0, 0)
        Me.Grilla1.Name = "Grilla1"
        Me.Grilla1.Size = New System.Drawing.Size(1201, 371)
        Me.Grilla1.TabIndex = 7
        Me.Grilla1.Text = "Retencion"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarStripMenuItem1, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "mnu_Transferencias"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(131, 56)
        '
        'ActualizarStripMenuItem1
        '
        Me.ActualizarStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.ActualizarStripMenuItem1.Name = "ActualizarStripMenuItem1"
        Me.ActualizarStripMenuItem1.Size = New System.Drawing.Size(130, 26)
        Me.ActualizarStripMenuItem1.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'UltraDataSource3
        '
        UltraDataColumn11.DataType = GetType(Short)
        UltraDataColumn12.DataType = GetType(Boolean)
        UltraDataColumn13.DataType = GetType(Boolean)
        UltraDataColumn15.DataType = GetType(Double)
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Double)
        UltraDataColumn24.DataType = GetType(Boolean)
        UltraDataColumn25.DataType = GetType(Boolean)
        UltraDataColumn27.DataType = GetType(Date)
        UltraDataColumn29.DataType = GetType(Date)
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29})
        Me.UltraDataSource3.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object(-1) {})})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griAnulados)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1201, 371)
        '
        'griAnulados
        '
        Me.griAnulados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAnulados.Location = New System.Drawing.Point(0, 0)
        Me.griAnulados.Name = "griAnulados"
        Me.griAnulados.Size = New System.Drawing.Size(1201, 371)
        Me.griAnulados.TabIndex = 0
        Me.griAnulados.Text = "UltraGrid1"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.gridTicket)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1201, 371)
        '
        'gridTicket
        '
        Me.gridTicket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridTicket.Location = New System.Drawing.Point(0, 0)
        Me.gridTicket.Name = "gridTicket"
        Me.gridTicket.Size = New System.Drawing.Size(1201, 371)
        Me.gridTicket.TabIndex = 19
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.SplitContainer1)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1203, 476)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 75)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridPagoAgregado)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridPago)
        Me.SplitContainer1.Size = New System.Drawing.Size(1203, 401)
        Me.SplitContainer1.SplitterDistance = 175
        Me.SplitContainer1.TabIndex = 8
        '
        'gridPagoAgregado
        '
        Me.gridPagoAgregado.ContextMenuStrip = Me.MenuAgregados
        Me.gridPagoAgregado.DataSource = Me.UltraDataSource2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.Caption = "TipoDoc"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 72
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Width = 61
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 95
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance1
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.Caption = "Fec Emision"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 86
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance2
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.Caption = "Fec Venc."
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Width = 80
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance3
        UltraGridColumn8.Header.VisiblePosition = 12
        UltraGridColumn8.Hidden = True
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance4
        UltraGridColumn9.Header.VisiblePosition = 13
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance5
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Format = "#,##0.00"
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance6
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Format = "#,##0.00"
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.Width = 97
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.Caption = "Proveedor"
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn12.Width = 300
        UltraGridColumn13.Header.VisiblePosition = 14
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 16
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Header.Caption = "Mon."
        UltraGridColumn16.Header.VisiblePosition = 8
        UltraGridColumn16.Width = 38
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance7
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn17.Format = "#,##0.0000"
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn17.Width = 84
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.Caption = "Detraccion"
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn23.Hidden = True
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn24.CellAppearance = Appearance8
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn24.Format = "#,##0.0000"
        UltraGridColumn24.Header.Caption = "Monto a Pagar"
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.MaskInput = "{double:9.4}"
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn24.Width = 96
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 30
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 31
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 32
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 33
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 34
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 35
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 36
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 37
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 38
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 39
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 40
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 41
        UltraGridColumn42.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42})
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPagoAgregado.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridPagoAgregado.DisplayLayout.MaxColScrollRegions = 1
        Me.gridPagoAgregado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPagoAgregado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridPagoAgregado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridPagoAgregado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridPagoAgregado.DisplayLayout.Override.FilterUIProvider = Me.FiltroGeneral
        Me.gridPagoAgregado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridPagoAgregado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridPagoAgregado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridPagoAgregado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridPagoAgregado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPagoAgregado.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridPagoAgregado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPagoAgregado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPagoAgregado.Location = New System.Drawing.Point(0, 0)
        Me.gridPagoAgregado.Name = "gridPagoAgregado"
        Me.gridPagoAgregado.Size = New System.Drawing.Size(1203, 175)
        Me.gridPagoAgregado.TabIndex = 7
        Me.gridPagoAgregado.Text = "Aplicacion de Pago"
        '
        'MenuAgregados
        '
        Me.MenuAgregados.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuAgregados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarDocumento})
        Me.MenuAgregados.Name = "mnu_Transferencias"
        Me.MenuAgregados.Size = New System.Drawing.Size(112, 30)
        '
        'QuitarDocumento
        '
        Me.QuitarDocumento.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.QuitarDocumento.Name = "QuitarDocumento"
        Me.QuitarDocumento.Size = New System.Drawing.Size(111, 26)
        Me.QuitarDocumento.Text = "Quitar"
        '
        'UltraDataSource2
        '
        UltraDataColumn40.DataType = GetType(Double)
        UltraDataColumn40.DefaultValue = 0.0R
        UltraDataColumn66.DataType = GetType(Boolean)
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71})
        Me.UltraDataSource2.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'gridPago
        '
        Me.gridPago.DataSource = Me.UltraDataSource1
        UltraGridColumn43.Header.VisiblePosition = 0
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.Caption = "Periodo"
        UltraGridColumn44.Header.VisiblePosition = 1
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.Width = 61
        UltraGridColumn45.Header.Caption = "TipoDoc"
        UltraGridColumn45.Header.VisiblePosition = 3
        UltraGridColumn45.Width = 70
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn46.Header.VisiblePosition = 4
        UltraGridColumn46.Width = 62
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn47.Header.VisiblePosition = 5
        UltraGridColumn47.Width = 93
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn48.CellAppearance = Appearance9
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn48.Header.Caption = "Fec Emi."
        UltraGridColumn48.Header.VisiblePosition = 8
        UltraGridColumn48.Width = 86
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn49.CellAppearance = Appearance10
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn49.Header.Caption = "Fec Venc."
        UltraGridColumn49.Header.VisiblePosition = 9
        UltraGridColumn49.Width = 80
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn50.CellAppearance = Appearance11
        UltraGridColumn50.Header.VisiblePosition = 6
        UltraGridColumn50.Hidden = True
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn51.CellAppearance = Appearance12
        UltraGridColumn51.Header.VisiblePosition = 7
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn52.CellAppearance = Appearance13
        UltraGridColumn52.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn52.Format = "#,##0.00"
        UltraGridColumn52.Header.Caption = "Neto Pagado"
        UltraGridColumn52.Header.VisiblePosition = 12
        UltraGridColumn52.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn53.CellAppearance = Appearance14
        UltraGridColumn53.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn53.Format = "#,##0.00"
        UltraGridColumn53.Header.Caption = "Retencion"
        UltraGridColumn53.Header.VisiblePosition = 13
        UltraGridColumn53.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn54.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn54.Header.Caption = "Proveedor"
        UltraGridColumn54.Header.VisiblePosition = 2
        UltraGridColumn54.Width = 300
        UltraGridColumn55.Header.VisiblePosition = 16
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 17
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 18
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn58.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn58.Header.Caption = "Mon."
        UltraGridColumn58.Header.VisiblePosition = 10
        UltraGridColumn58.Width = 41
        UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn59.CellAppearance = Appearance15
        UltraGridColumn59.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn59.Format = "#,##0.0000"
        UltraGridColumn59.Header.VisiblePosition = 11
        UltraGridColumn59.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn59.Width = 76
        UltraGridColumn60.Header.VisiblePosition = 19
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 14
        UltraGridColumn61.Hidden = True
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn62.CellAppearance = Appearance16
        UltraGridColumn62.Header.VisiblePosition = 15
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 20
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 21
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 22
        UltraGridColumn65.Hidden = True
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn66.CellAppearance = Appearance17
        UltraGridColumn66.Header.VisiblePosition = 23
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 24
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 25
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 26
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 27
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 28
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 29
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 30
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 31
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 32
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 33
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 34
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 35
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 36
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 37
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 38
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 39
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 40
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 41
        UltraGridColumn84.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84})
        Me.gridPago.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.gridPago.DisplayLayout.MaxColScrollRegions = 1
        Me.gridPago.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPago.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridPago.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridPago.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridPago.DisplayLayout.Override.FilterUIProvider = Me.FiltroGeneral
        Me.gridPago.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridPago.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridPago.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridPago.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridPago.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPago.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPago.Location = New System.Drawing.Point(0, 0)
        Me.gridPago.Name = "gridPago"
        Me.gridPago.Size = New System.Drawing.Size(1203, 222)
        Me.gridPago.TabIndex = 6
        Me.gridPago.Text = "Compras"
        '
        'UltraDataSource1
        '
        UltraDataColumn108.DataType = GetType(Boolean)
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113})
        Me.UltraDataSource1.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.chkProveedor)
        Me.Agrupacion1.Controls.Add(Me.cboProveedor)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion1.Controls.Add(Me.fecRetencion)
        Me.Agrupacion1.Controls.Add(Me.UltraPanel3)
        Me.Agrupacion1.Controls.Add(Me.txtNumero)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Controls.Add(Me.txtSerie)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.cboMoneda)
        Me.Agrupacion1.Controls.Add(Me.DecTC)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1203, 75)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Datos de Retencion"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkProveedor
        '
        Me.chkProveedor.AutoSize = True
        Me.chkProveedor.BackColor = System.Drawing.Color.Transparent
        Me.chkProveedor.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkProveedor.Location = New System.Drawing.Point(769, 43)
        Me.chkProveedor.Name = "chkProveedor"
        Me.chkProveedor.Size = New System.Drawing.Size(73, 18)
        Me.chkProveedor.TabIndex = 6
        Me.chkProveedor.Text = "Ver Todos"
        '
        'cboProveedor
        '
        Me.cboProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedor.CheckedListSettings.ListSeparator = ","
        Me.cboProveedor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn165.Header.VisiblePosition = 0
        UltraGridColumn165.Hidden = True
        UltraGridColumn165.Width = 19
        UltraGridColumn166.Header.VisiblePosition = 1
        UltraGridColumn166.Hidden = True
        UltraGridColumn166.Width = 18
        UltraGridColumn167.Header.VisiblePosition = 2
        UltraGridColumn167.Hidden = True
        UltraGridColumn167.Width = 31
        UltraGridColumn168.Header.VisiblePosition = 3
        UltraGridColumn168.Hidden = True
        UltraGridColumn168.Width = 28
        UltraGridColumn169.Header.VisiblePosition = 4
        UltraGridColumn169.Hidden = True
        UltraGridColumn169.Width = 25
        UltraGridColumn170.Header.VisiblePosition = 5
        UltraGridColumn170.Hidden = True
        UltraGridColumn170.Width = 17
        UltraGridColumn171.Header.VisiblePosition = 6
        UltraGridColumn171.Hidden = True
        UltraGridColumn171.Width = 25
        UltraGridColumn172.Header.VisiblePosition = 7
        UltraGridColumn172.Hidden = True
        UltraGridColumn172.Width = 25
        UltraGridColumn173.Header.VisiblePosition = 8
        UltraGridColumn173.Hidden = True
        UltraGridColumn173.Width = 25
        UltraGridColumn174.Header.VisiblePosition = 9
        UltraGridColumn174.Hidden = True
        UltraGridColumn174.Width = 54
        UltraGridColumn175.Header.VisiblePosition = 10
        UltraGridColumn175.Width = 251
        UltraGridColumn176.Header.VisiblePosition = 11
        UltraGridColumn176.Hidden = True
        UltraGridColumn176.Width = 54
        UltraGridColumn177.Header.VisiblePosition = 12
        UltraGridColumn177.Hidden = True
        UltraGridColumn177.Width = 55
        UltraGridColumn178.Header.VisiblePosition = 13
        UltraGridColumn178.Width = 247
        UltraGridColumn179.Header.VisiblePosition = 14
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 15
        UltraGridColumn180.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180})
        Me.cboProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cboProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedor.DropDownWidth = 500
        Me.cboProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.Location = New System.Drawing.Point(453, 41)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(310, 23)
        Me.cboProveedor.TabIndex = 5
        '
        'Etiqueta13
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance18
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(453, 20)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta13.TabIndex = 280
        Me.Etiqueta13.Text = "Proveedor"
        '
        'fecRetencion
        '
        Me.fecRetencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecRetencion.Location = New System.Drawing.Point(6, 41)
        Me.fecRetencion.Name = "fecRetencion"
        Me.fecRetencion.Size = New System.Drawing.Size(99, 20)
        Me.fecRetencion.TabIndex = 0
        '
        'UltraPanel3
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.UltraPanel3.Appearance = Appearance19
        Me.UltraPanel3.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4
        '
        'UltraPanel3.ClientArea
        '
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta3)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.EtiImporteSoles)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta9)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.EtiImporteDolares)
        Me.UltraPanel3.Location = New System.Drawing.Point(854, 38)
        Me.UltraPanel3.Name = "UltraPanel3"
        Me.UltraPanel3.Size = New System.Drawing.Size(292, 30)
        Me.UltraPanel3.TabIndex = 278
        '
        'Etiqueta3
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance20
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(10, 7)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta3.TabIndex = 20
        Me.Etiqueta3.Text = "Importe S/.:"
        '
        'EtiImporteSoles
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.EtiImporteSoles.Appearance = Appearance21
        Me.EtiImporteSoles.AutoSize = True
        Me.EtiImporteSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteSoles.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteSoles.Location = New System.Drawing.Point(82, 7)
        Me.EtiImporteSoles.Name = "EtiImporteSoles"
        Me.EtiImporteSoles.Size = New System.Drawing.Size(11, 15)
        Me.EtiImporteSoles.TabIndex = 35
        Me.EtiImporteSoles.Text = "0"
        '
        'Etiqueta9
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance22
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(145, 7)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta9.TabIndex = 36
        Me.Etiqueta9.Text = "Importe $.:"
        '
        'EtiImporteDolares
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.EtiImporteDolares.Appearance = Appearance23
        Me.EtiImporteDolares.AutoSize = True
        Me.EtiImporteDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteDolares.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteDolares.Location = New System.Drawing.Point(212, 7)
        Me.EtiImporteDolares.Name = "EtiImporteDolares"
        Me.EtiImporteDolares.Size = New System.Drawing.Size(11, 15)
        Me.EtiImporteDolares.TabIndex = 37
        Me.EtiImporteDolares.Text = "0"
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(169, 41)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(72, 22)
        Me.txtNumero.TabIndex = 2
        '
        'Etiqueta5
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance24
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(169, 20)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta5.TabIndex = 42
        Me.Etiqueta5.Text = "Numero"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(111, 41)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(52, 22)
        Me.txtSerie.TabIndex = 1
        '
        'Etiqueta2
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance25
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(111, 20)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(29, 15)
        Me.Etiqueta2.TabIndex = 40
        Me.Etiqueta2.Text = "Serie"
        '
        'Etiqueta1
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance26
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(247, 20)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta1.TabIndex = 39
        Me.Etiqueta1.Text = "Moneda"
        '
        'cboMoneda
        '
        Appearance27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance27
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(247, 41)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(100, 22)
        Me.cboMoneda.TabIndex = 3
        Me.cboMoneda.ValueMember = "Id"
        '
        'DecTC
        '
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance28
        Appearance29.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance29
        Me.DecTC.ButtonsRight.Add(EditorButton1)
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(352, 41)
        Me.DecTC.MaskInput = "{double:6.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.ReadOnly = True
        Me.DecTC.Size = New System.Drawing.Size(95, 22)
        Me.DecTC.TabIndex = 4
        '
        'Etiqueta4
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance30
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(353, 20)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta4.TabIndex = 29
        Me.Etiqueta4.Text = "Tipo Cambio"
        '
        'Etiqueta18
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance31
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(7, 20)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta18.TabIndex = 11
        Me.Etiqueta18.Text = "Fecha"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ficRetencion)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1203, 476)
        '
        'ficRetencion
        '
        Me.ficRetencion.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficRetencion.Controls.Add(Me.UltraTabPageControl3)
        Me.ficRetencion.Controls.Add(Me.UltraTabPageControl4)
        Me.ficRetencion.Controls.Add(Me.UltraTabPageControl5)
        Me.ficRetencion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficRetencion.Location = New System.Drawing.Point(0, 82)
        Me.ficRetencion.Name = "ficRetencion"
        Me.ficRetencion.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficRetencion.Size = New System.Drawing.Size(1203, 394)
        Me.ficRetencion.TabIndex = 9
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Emitidas"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Anuladas"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Ticket"
        Me.ficRetencion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab5})
        Me.ficRetencion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1201, 371)
        '
        'Agrupacion2
        '
        Appearance32.BackColor = System.Drawing.Color.White
        Appearance32.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion2.ContentAreaAppearance = Appearance32
        Me.Agrupacion2.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel4)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion2.Controls.Add(Me.colorGenerado)
        Me.Agrupacion2.Controls.Add(Me.colorRechazado)
        Me.Agrupacion2.Controls.Add(Me.colorProceso)
        Me.Agrupacion2.Controls.Add(Me.colorAceptado)
        Me.Agrupacion2.Controls.Add(Me.btnConsultar)
        Me.Agrupacion2.Controls.Add(Me.btnAnular)
        Me.Agrupacion2.Controls.Add(Me.btnXml)
        Me.Agrupacion2.Controls.Add(Me.fecFin)
        Me.Agrupacion2.Controls.Add(Me.fecInicio)
        Me.Agrupacion2.Controls.Add(Me.btnEnviarSunat)
        Me.Agrupacion2.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1203, 82)
        Me.Agrupacion2.TabIndex = 8
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel3
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance33
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(271, 55)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(53, 15)
        Me.UltraLabel3.TabIndex = 411
        Me.UltraLabel3.Text = "Por Enviar"
        '
        'UltraLabel4
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance34
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(385, 55)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(57, 15)
        Me.UltraLabel4.TabIndex = 412
        Me.UltraLabel4.Text = "En Proceso"
        '
        'UltraLabel1
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance35
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(507, 55)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(49, 15)
        Me.UltraLabel1.TabIndex = 413
        Me.UltraLabel1.Text = "Aceptado"
        '
        'UltraLabel2
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance36
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(618, 55)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(56, 15)
        Me.UltraLabel2.TabIndex = 414
        Me.UltraLabel2.Text = "Rechazado"
        '
        'colorGenerado
        '
        Me.colorGenerado.Color = System.Drawing.Color.White
        Me.colorGenerado.Location = New System.Drawing.Point(331, 51)
        Me.colorGenerado.Name = "colorGenerado"
        Me.colorGenerado.ReadOnly = True
        Me.colorGenerado.Size = New System.Drawing.Size(44, 22)
        Me.colorGenerado.TabIndex = 408
        Me.colorGenerado.Text = "White"
        '
        'colorRechazado
        '
        Me.colorRechazado.Color = System.Drawing.Color.LightCoral
        Me.colorRechazado.Location = New System.Drawing.Point(684, 51)
        Me.colorRechazado.Name = "colorRechazado"
        Me.colorRechazado.ReadOnly = True
        Me.colorRechazado.Size = New System.Drawing.Size(46, 22)
        Me.colorRechazado.TabIndex = 407
        Me.colorRechazado.Text = "LightCoral"
        '
        'colorProceso
        '
        Me.colorProceso.Color = System.Drawing.Color.LightSteelBlue
        Me.colorProceso.Location = New System.Drawing.Point(452, 51)
        Me.colorProceso.Name = "colorProceso"
        Me.colorProceso.ReadOnly = True
        Me.colorProceso.Size = New System.Drawing.Size(44, 22)
        Me.colorProceso.TabIndex = 409
        Me.colorProceso.Text = "LightSteelBlue"
        '
        'colorAceptado
        '
        Me.colorAceptado.Color = System.Drawing.Color.LightGreen
        Me.colorAceptado.Location = New System.Drawing.Point(563, 51)
        Me.colorAceptado.Name = "colorAceptado"
        Me.colorAceptado.ReadOnly = True
        Me.colorAceptado.Size = New System.Drawing.Size(44, 22)
        Me.colorAceptado.TabIndex = 410
        Me.colorAceptado.Text = "LightGreen"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(635, 10)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(96, 25)
        Me.btnConsultar.TabIndex = 58
        Me.btnConsultar.Text = "::: Consultar :::"
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(551, 10)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(78, 25)
        Me.btnAnular.TabIndex = 58
        Me.btnAnular.Text = "::: Anular :::"
        '
        'btnXml
        '
        Me.btnXml.Location = New System.Drawing.Point(424, 10)
        Me.btnXml.Name = "btnXml"
        Me.btnXml.Size = New System.Drawing.Size(121, 25)
        Me.btnXml.TabIndex = 57
        Me.btnXml.Text = "::: Descargar XML :::"
        '
        'fecFin
        '
        Me.fecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFin.Location = New System.Drawing.Point(242, 13)
        Me.fecFin.Name = "fecFin"
        Me.fecFin.Size = New System.Drawing.Size(91, 20)
        Me.fecFin.TabIndex = 56
        '
        'fecInicio
        '
        Me.fecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicio.Location = New System.Drawing.Point(83, 13)
        Me.fecInicio.Name = "fecInicio"
        Me.fecInicio.Size = New System.Drawing.Size(91, 20)
        Me.fecInicio.TabIndex = 55
        '
        'btnEnviarSunat
        '
        Me.btnEnviarSunat.Location = New System.Drawing.Point(339, 10)
        Me.btnEnviarSunat.Name = "btnEnviarSunat"
        Me.btnEnviarSunat.Size = New System.Drawing.Size(79, 25)
        Me.btnEnviarSunat.TabIndex = 54
        Me.btnEnviarSunat.Text = "::: Enviar :::"
        '
        'UltraExpandableGroupBox1
        '
        Appearance37.BackColor = System.Drawing.Color.White
        Appearance37.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance37
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(466, 76)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(734, 3)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(466, 76)
        Me.UltraExpandableGroupBox1.TabIndex = 53
        Me.UltraExpandableGroupBox1.Text = "AGREGAR RETENCIÓN ANULADA"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.FecEmisAgregar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btanCancelar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta8)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtSerieAgregar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnAgregar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta7)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtVoucherAgregar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtNroAgregar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta10)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Etiqueta6)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 17)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(460, 56)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'FecEmisAgregar
        '
        Appearance38.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecEmisAgregar.Appearance = Appearance38
        Me.FecEmisAgregar.DateTime = New Date(2017, 1, 2, 0, 0, 0, 0)
        Me.FecEmisAgregar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecEmisAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecEmisAgregar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecEmisAgregar.Location = New System.Drawing.Point(58, 3)
        Me.FecEmisAgregar.Name = "FecEmisAgregar"
        Me.FecEmisAgregar.Size = New System.Drawing.Size(90, 21)
        Me.FecEmisAgregar.TabIndex = 43
        Me.FecEmisAgregar.Value = New Date(2017, 1, 2, 0, 0, 0, 0)
        '
        'btanCancelar
        '
        Appearance39.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        Me.btanCancelar.Appearance = Appearance39
        Me.btanCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btanCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btanCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btanCancelar.ForeColor = System.Drawing.Color.Black
        Me.btanCancelar.Location = New System.Drawing.Point(365, 28)
        Me.btanCancelar.Name = "btanCancelar"
        Me.btanCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btanCancelar.TabIndex = 52
        Me.btanCancelar.Text = "Cancelar"
        '
        'Etiqueta8
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance40
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(16, 7)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta8.TabIndex = 44
        Me.Etiqueta8.Text = "Fecha:"
        '
        'txtSerieAgregar
        '
        Me.txtSerieAgregar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieAgregar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieAgregar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieAgregar.Location = New System.Drawing.Point(58, 30)
        Me.txtSerieAgregar.MaxLength = 4
        Me.txtSerieAgregar.Name = "txtSerieAgregar"
        Me.txtSerieAgregar.Size = New System.Drawing.Size(90, 22)
        Me.txtSerieAgregar.TabIndex = 45
        '
        'btnAgregar
        '
        Appearance41.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.btnAgregar.Appearance = Appearance41
        Me.btnAgregar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(365, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(90, 25)
        Me.btnAgregar.TabIndex = 51
        Me.btnAgregar.Text = "Agregar"
        '
        'Etiqueta7
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance42
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(21, 34)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta7.TabIndex = 47
        Me.Etiqueta7.Text = "Serie:"
        '
        'txtVoucherAgregar
        '
        Me.txtVoucherAgregar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVoucherAgregar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVoucherAgregar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherAgregar.Location = New System.Drawing.Point(244, 3)
        Me.txtVoucherAgregar.MaxLength = 10
        Me.txtVoucherAgregar.Name = "txtVoucherAgregar"
        Me.txtVoucherAgregar.Size = New System.Drawing.Size(98, 22)
        Me.txtVoucherAgregar.TabIndex = 49
        '
        'txtNroAgregar
        '
        Me.txtNroAgregar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroAgregar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroAgregar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroAgregar.Location = New System.Drawing.Point(244, 30)
        Me.txtNroAgregar.MaxLength = 10
        Me.txtNroAgregar.Name = "txtNroAgregar"
        Me.txtNroAgregar.Size = New System.Drawing.Size(98, 22)
        Me.txtNroAgregar.TabIndex = 46
        '
        'Etiqueta10
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance43
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(188, 7)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta10.TabIndex = 50
        Me.Etiqueta10.Text = "Voucher:"
        '
        'Etiqueta6
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance44
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(188, 34)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta6.TabIndex = 48
        Me.Etiqueta6.Text = "Numero:"
        '
        'Etiqueta12
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance45
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(180, 15)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta12.TabIndex = 47
        Me.Etiqueta12.Text = "Fecha Fin:"
        '
        'Etiqueta11
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance46
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(9, 15)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(68, 15)
        Me.Etiqueta11.TabIndex = 45
        Me.Etiqueta11.Text = "Fecha Inicio:"
        '
        'tcCobranza
        '
        Me.tcCobranza.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcCobranza.Controls.Add(Me.UltraTabPageControl2)
        Me.tcCobranza.Controls.Add(Me.UltraTabPageControl1)
        Me.tcCobranza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcCobranza.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcCobranza.Location = New System.Drawing.Point(0, 0)
        Me.tcCobranza.Name = "tcCobranza"
        Me.tcCobranza.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcCobranza.Size = New System.Drawing.Size(1205, 499)
        Me.tcCobranza.TabIndex = 0
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Pagos de Retenciones"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Retenciones"
        Me.tcCobranza.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab1})
        Me.tcCobranza.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1203, 476)
        '
        'frm_PagoRetencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1205, 499)
        Me.Controls.Add(Me.tcCobranza)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_PagoRetencion"
        Me.Text = "Pago de Retencion"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.Grilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griAnulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.gridTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridPagoAgregado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAgregados.ResumeLayout(False)
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.chkProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel3.ClientArea.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.PerformLayout()
        Me.UltraPanel3.ResumeLayout(False)
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ficRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficRetencion.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.colorGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorRechazado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAceptado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.FecEmisAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcCobranza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcCobranza.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuAgregados As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents tcCobranza As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gridPagoAgregado As ISL.Controles.Grilla
    Friend WithEvents gridPago As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents EtiImporteDolares As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents EtiImporteSoles As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grilla1 As ISL.Controles.Grilla
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ActualizarStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents txtNroAgregar As ISL.Controles.Texto
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerieAgregar As ISL.Controles.Texto
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents FecEmisAgregar As ISL.Controles.Fecha
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents btanCancelar As ISL.Controles.Boton
    Friend WithEvents btnAgregar As ISL.Controles.Boton
    Friend WithEvents txtVoucherAgregar As ISL.Controles.Texto
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents FiltroGeneral As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel3 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents fecRetencion As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnEnviarSunat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents fecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnXml As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ficRetencion As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griAnulados As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnAnular As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Private WithEvents cboProveedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkProveedor As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnConsultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents colorGenerado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorRechazado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorProceso As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorAceptado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents gridTicket As ISL.Controles.Grilla
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider

End Class
