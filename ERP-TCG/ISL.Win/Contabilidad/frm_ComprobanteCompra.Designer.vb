<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ComprobanteCompra
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_MovimientoDocumento", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("lstDetalleDocumentoCombustible")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnexo")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetalleGlosa")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCanje")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion_Letra")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion_Saldo")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMotivo")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenCompra")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoSunat")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("lstDetalleDocumentoCombustible", 0)
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoReferencia")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegConsumoCombustible")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroLinea")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnit")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDetalleDocumento")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGravado")
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioIGV")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVeh")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool31 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool32 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool33 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool34 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim ButtonTool35 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool36 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool37 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool38 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool39 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool40 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool41 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool42 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool43 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool44 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exportar")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool45 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Modificar")
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ComprobanteCompra))
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
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersonaEmpresa")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oePersona")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oeEmpresa")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdItemGasto")
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis1")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis2")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaContable")
        Dim UltraGridColumn329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoFuncion")
        Dim UltraGridColumn332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAsiento")
        Dim UltraGridColumn333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProrrateo")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "Monto", 12, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Monto", 12, True)
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdItemGasto")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis1")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis2")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vehiculo")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaContable")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoFuncion")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAsiento")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigenProrrateo")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn340 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn341 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn342 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn343 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn344 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim UltraGridColumn348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn349 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemandaDetalle")
        Dim UltraGridColumn352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn353 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn354 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn355 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn356 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasCarga")
        Dim UltraGridColumn358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasDescarga")
        Dim UltraGridColumn359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargar")
        Dim UltraGridColumn361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descarga")
        Dim UltraGridColumn362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPesoTnDescarga")
        Dim UltraGridColumn363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteFinal")
        Dim UltraGridColumn369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstiba")
        Dim UltraGridColumn370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstibaDescarga")
        Dim UltraGridColumn371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete")
        Dim UltraGridColumn372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgvConsolidado")
        Dim UltraGridColumn373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoEfectivoDeposito")
        Dim UltraGridColumn374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FalsoFlete")
        Dim UltraGridColumn375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoConsolidado")
        Dim UltraGridColumn376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemandaDetalle")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasCarga")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasDescarga")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cargar")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descarga")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPesoTnDescarga")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClienteFinal")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoEstiba")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoEstibaDescarga")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AdelantoFlete")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgvConsolidado")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoEfectivoDeposito")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FalsoFlete")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MotivoConsolidado")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GriComprobanteAsociado = New ISL.Controles.Grilla(Me.components)
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.GriSeleccionaComprobante = New ISL.Controles.Grilla(Me.components)
        Me.EMovimientoDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Agrupacion10 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraToolbarsDockArea5 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnuDetalleAsiento = New ISL.Controles.Menu(Me.components)
        Me.UltraToolbarsDockArea6 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea7 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea8 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea4 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrObligación = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta52 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTotalLeasing = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.decInteres = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTotalLeasing = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta43 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCuota = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta44 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta42 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda2 = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta41 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta40 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.fecVenc = New ISL.Controles.Fecha(Me.components)
        Me.txtCuenta = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta39 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta38 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCodigoLeasing = New ISL.Controles.Combo(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.PanelCupon = New Infragistics.Win.Misc.UltraPanel()
        Me.CboMonedaCupon = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta49 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.nd_SaldoCupon = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.CboFilPoliza = New ISL.Controles.ComboMaestros(Me.components)
        Me.LblNumeroPoliza = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtNumeroPoliza = New ISL.Controles.Texto(Me.components)
        Me.nd_MontoOperaCupon = New ISL.Controles.NumeroDecimal(Me.components)
        Me.LblMontoOperaCupon = New Infragistics.Win.Misc.UltraLabel()
        Me.ndMontoCupon = New ISL.Controles.NumeroDecimal(Me.components)
        Me.dtpFechaCupon = New ISL.Controles.Fecha(Me.components)
        Me.LblMontoCupon = New Infragistics.Win.Misc.UltraLabel()
        Me.LblVencimientoCupon = New Infragistics.Win.Misc.UltraLabel()
        Me.BtnConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.CmbMes = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridComprobanteCompra = New ISL.Controles.Grilla(Me.components)
        Me.MenuCabecera = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarCabecera = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarCabecera = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminaCabecera = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.dtpFechaEjercicio = New System.Windows.Forms.DateTimePicker()
        Me.etiProveedor = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProveedores = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Etiqueta48 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorBloque = New ISL.Controles.Colores(Me.components)
        Me.btn_Extornar = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tcComprobanteDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.grupoDetalleCuentas = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.gridDetalleAsientoAnalisis = New ISL.Controles.Grilla(Me.components)
        Me.MenuAnalisis = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarAnalisis = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource4 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.grupoMontaCarga = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdOperacionDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.opcTerceros = New ISL.Controles.Opciones(Me.components)
        Me.grupoDetalle = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.ChkVehiculoProper = New System.Windows.Forms.CheckBox()
        Me.DecMontoAn = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbAgregar = New ISL.Controles.Boton(Me.components)
        Me.cboCuenta = New ISL.Controles.Combo(Me.components)
        Me.cboGastonFuncion = New ISL.Controles.Combo(Me.components)
        Me.cboItemGasto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCentroCosto = New ISL.Controles.Combo(Me.components)
        Me.cboBanco = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.cboRuta = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboVehiculo = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoCompra = New ISL.Controles.Combo(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grupoVerificacion = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grupoDoctRendir = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.cboAnalisis2 = New ISL.Controles.Combo(Me.components)
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.grupoVerificar = New ISL.Controles.Agrupacion(Me.components)
        Me.cboAnalisis1 = New ISL.Controles.Combo(Me.components)
        Me.BtnVerificar = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.Lblsuario = New Infragistics.Win.Misc.UltraLabel()
        Me.LblFeccha = New Infragistics.Win.Misc.UltraLabel()
        Me.grupoObligaciones = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.TabFinanciero = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.ChkCupon = New ISL.Controles.Chequear(Me.components)
        Me.chkLeasing = New ISL.Controles.Chequear(Me.components)
        Me.grupoCabeceraAsiento = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.cbeCtaCte = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cbCaja = New System.Windows.Forms.CheckBox()
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.FecVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiPeriodo = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecEmision = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTotalDoc = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecTotalImponible = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecTotalIgv = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecNoGravadas = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecBi1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecBi2 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecISC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecBi3 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecOtrosTributos = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecIgv2 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecIgv3 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecIgv1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroDocumento = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta37 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtRuc = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroSerie = New ISL.Controles.Texto(Me.components)
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tcComprobanteCompra = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53 = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero3 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero4 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero5 = New ISL.Controles.NumeroEntero(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.GriComprobanteAsociado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.GriSeleccionaComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMovimientoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion10.SuspendLayout()
        CType(Me.mnuDetalleAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.agrObligación, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrObligación.SuspendLayout()
        CType(Me.decInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalLeasing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecVenc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCodigoLeasing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.PanelCupon.ClientArea.SuspendLayout()
        Me.PanelCupon.SuspendLayout()
        CType(Me.CboMonedaCupon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_SaldoCupon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboFilPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumeroPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_MontoOperaCupon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndMontoCupon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaCupon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.gridComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuCabecera.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.tcComprobanteDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcComprobanteDetalle.SuspendLayout()
        CType(Me.grupoDetalleCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDetalleCuentas.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout()
        CType(Me.gridDetalleAsientoAnalisis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAnalisis.SuspendLayout()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoMontaCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoMontaCarga.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opcTerceros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDetalle.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.DecMontoAn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGastonFuncion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.grupoVerificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoVerificacion.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.grupoDoctRendir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDoctRendir.SuspendLayout()
        CType(Me.cboAnalisis2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoVerificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoVerificar.SuspendLayout()
        CType(Me.cboAnalisis1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoObligaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoObligaciones.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.TabFinanciero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFinanciero.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.ChkCupon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLeasing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoCabeceraAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoCabeceraAsiento.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.cbeCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.DecTotalDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTotalImponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTotalIgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecNoGravadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecBi1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecBi2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecISC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecBi3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecOtrosTributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecIgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecIgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecIgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcComprobanteCompra.SuspendLayout()
        CType(Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_dad2a13d_427e_4777_870d_044a3363ce53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.GriComprobanteAsociado)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1237, 247)
        '
        'GriComprobanteAsociado
        '
        Me.GriComprobanteAsociado.ContextMenuStrip = Me.MenuDetalle
        Me.GriComprobanteAsociado.DataSource = Me.UltraDataSource2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Periodo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 61
        UltraGridColumn3.Header.Caption = "Tipo Doc"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 97
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Width = 47
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 82
        UltraGridColumn6.Header.Caption = "Fec Emision"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 86
        UltraGridColumn7.Header.Caption = "Fec Venc."
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Width = 80
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance1
        UltraGridColumn8.Format = "#,##0.00"
        UltraGridColumn8.Header.VisiblePosition = 10
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.Width = 69
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance2
        UltraGridColumn9.Format = "#,##0.00"
        UltraGridColumn9.Header.VisiblePosition = 11
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Width = 95
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance3
        UltraGridColumn10.Format = "#,##0.00"
        UltraGridColumn10.Header.VisiblePosition = 12
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance4
        UltraGridColumn11.Format = "#,##0.00"
        UltraGridColumn11.Header.VisiblePosition = 13
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.Header.Caption = "Proveedor"
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn12.Width = 309
        UltraGridColumn13.Header.VisiblePosition = 15
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 16
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.Caption = "Moneda"
        UltraGridColumn16.Header.VisiblePosition = 8
        UltraGridColumn16.Width = 58
        UltraGridColumn17.Header.Caption = "T.C"
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.Width = 55
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
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
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.Hidden = True
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
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        Me.GriComprobanteAsociado.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.GriComprobanteAsociado.DisplayLayout.MaxColScrollRegions = 1
        Me.GriComprobanteAsociado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GriComprobanteAsociado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GriComprobanteAsociado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GriComprobanteAsociado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GriComprobanteAsociado.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.GriComprobanteAsociado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GriComprobanteAsociado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GriComprobanteAsociado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GriComprobanteAsociado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GriComprobanteAsociado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.GriComprobanteAsociado.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GriComprobanteAsociado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GriComprobanteAsociado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GriComprobanteAsociado.Location = New System.Drawing.Point(0, 0)
        Me.GriComprobanteAsociado.Name = "GriComprobanteAsociado"
        Me.GriComprobanteAsociado.Size = New System.Drawing.Size(1237, 247)
        Me.GriComprobanteAsociado.TabIndex = 35
        Me.GriComprobanteAsociado.Text = "Documentos Asociados"
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarDetalle, Me.EliminarDetalle})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(122, 56)
        '
        'AgregarDetalle
        '
        Me.AgregarDetalle.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarDetalle.Name = "AgregarDetalle"
        Me.AgregarDetalle.Size = New System.Drawing.Size(121, 26)
        Me.AgregarDetalle.Text = "Agregar"
        '
        'EliminarDetalle
        '
        Me.EliminarDetalle.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarDetalle.Name = "EliminarDetalle"
        Me.EliminarDetalle.Size = New System.Drawing.Size(121, 26)
        Me.EliminarDetalle.Text = "Eliminar"
        '
        'UltraDataSource2
        '
        UltraDataColumn35.DataType = GetType(Boolean)
        UltraDataColumn36.DataType = GetType(Date)
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion8)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1237, 247)
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.Agrupacion9)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion8.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(1237, 247)
        Me.Agrupacion8.TabIndex = 46
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.GriSeleccionaComprobante)
        Me.Agrupacion9.Controls.Add(Me.Agrupacion10)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion9.Location = New System.Drawing.Point(2, 2)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(1233, 243)
        Me.Agrupacion9.TabIndex = 48
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GriSeleccionaComprobante
        '
        Me.GriSeleccionaComprobante.DataSource = Me.EMovimientoDocumentoBindingSource
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn38.Header.VisiblePosition = 47
        UltraGridColumn39.Header.VisiblePosition = 1
        UltraGridColumn40.Header.VisiblePosition = 2
        UltraGridColumn41.Header.VisiblePosition = 3
        UltraGridColumn42.Header.VisiblePosition = 4
        UltraGridColumn43.Header.VisiblePosition = 5
        UltraGridColumn44.Header.VisiblePosition = 6
        UltraGridColumn45.Header.VisiblePosition = 7
        UltraGridColumn46.Header.VisiblePosition = 8
        UltraGridColumn47.Header.VisiblePosition = 9
        UltraGridColumn48.Header.VisiblePosition = 10
        UltraGridColumn49.Header.VisiblePosition = 11
        UltraGridColumn50.Header.VisiblePosition = 12
        UltraGridColumn51.Header.VisiblePosition = 13
        UltraGridColumn52.Header.VisiblePosition = 14
        UltraGridColumn53.Header.VisiblePosition = 15
        UltraGridColumn54.Header.VisiblePosition = 16
        UltraGridColumn55.Header.VisiblePosition = 17
        UltraGridColumn56.Header.VisiblePosition = 18
        UltraGridColumn57.Header.VisiblePosition = 19
        UltraGridColumn58.Header.VisiblePosition = 21
        UltraGridColumn59.Header.VisiblePosition = 23
        UltraGridColumn60.Header.VisiblePosition = 25
        UltraGridColumn61.Header.VisiblePosition = 27
        UltraGridColumn62.Header.VisiblePosition = 20
        UltraGridColumn63.Header.VisiblePosition = 22
        UltraGridColumn64.Header.VisiblePosition = 24
        UltraGridColumn65.Header.VisiblePosition = 26
        UltraGridColumn66.Header.VisiblePosition = 28
        UltraGridColumn67.Header.VisiblePosition = 29
        UltraGridColumn68.Header.VisiblePosition = 30
        UltraGridColumn69.Header.VisiblePosition = 31
        UltraGridColumn70.Header.VisiblePosition = 32
        UltraGridColumn71.Header.VisiblePosition = 33
        UltraGridColumn72.Header.VisiblePosition = 34
        UltraGridColumn73.Header.VisiblePosition = 35
        UltraGridColumn236.Header.VisiblePosition = 36
        UltraGridColumn237.Header.VisiblePosition = 37
        UltraGridColumn238.Header.VisiblePosition = 38
        UltraGridColumn239.Header.VisiblePosition = 39
        UltraGridColumn240.Header.VisiblePosition = 40
        UltraGridColumn241.Header.VisiblePosition = 41
        UltraGridColumn242.Header.VisiblePosition = 42
        UltraGridColumn243.Header.VisiblePosition = 43
        UltraGridColumn244.Header.VisiblePosition = 44
        UltraGridColumn245.Header.VisiblePosition = 45
        UltraGridColumn246.Header.VisiblePosition = 46
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246})
        UltraGridColumn247.Header.VisiblePosition = 0
        UltraGridColumn248.Header.VisiblePosition = 1
        UltraGridColumn249.Header.VisiblePosition = 2
        UltraGridColumn250.Header.VisiblePosition = 3
        UltraGridColumn251.Header.VisiblePosition = 4
        UltraGridColumn252.Header.VisiblePosition = 5
        UltraGridColumn253.Header.VisiblePosition = 6
        UltraGridColumn254.Header.VisiblePosition = 7
        UltraGridColumn255.Header.VisiblePosition = 8
        UltraGridColumn256.Header.VisiblePosition = 9
        UltraGridColumn257.Header.VisiblePosition = 10
        UltraGridColumn258.Header.VisiblePosition = 11
        UltraGridColumn259.Header.VisiblePosition = 12
        UltraGridColumn260.Header.VisiblePosition = 13
        UltraGridColumn261.Header.VisiblePosition = 14
        UltraGridColumn262.Header.VisiblePosition = 15
        UltraGridColumn263.Header.VisiblePosition = 16
        UltraGridColumn264.Header.VisiblePosition = 17
        UltraGridColumn265.Header.VisiblePosition = 18
        UltraGridColumn266.Header.VisiblePosition = 19
        UltraGridColumn267.Header.VisiblePosition = 20
        UltraGridColumn268.Header.VisiblePosition = 21
        UltraGridColumn269.Header.VisiblePosition = 22
        UltraGridColumn270.Header.VisiblePosition = 23
        UltraGridColumn271.Header.VisiblePosition = 24
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271})
        Me.GriSeleccionaComprobante.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.GriSeleccionaComprobante.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.GriSeleccionaComprobante.DisplayLayout.MaxColScrollRegions = 1
        Me.GriSeleccionaComprobante.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GriSeleccionaComprobante.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GriSeleccionaComprobante.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GriSeleccionaComprobante.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GriSeleccionaComprobante.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.GriSeleccionaComprobante.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GriSeleccionaComprobante.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GriSeleccionaComprobante.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GriSeleccionaComprobante.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GriSeleccionaComprobante.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GriSeleccionaComprobante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GriSeleccionaComprobante.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GriSeleccionaComprobante.Location = New System.Drawing.Point(2, 27)
        Me.GriSeleccionaComprobante.Name = "GriSeleccionaComprobante"
        Me.GriSeleccionaComprobante.Size = New System.Drawing.Size(1229, 214)
        Me.GriSeleccionaComprobante.TabIndex = 49
        '
        'EMovimientoDocumentoBindingSource
        '
        Me.EMovimientoDocumentoBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_MovimientoDocumento)
        '
        'Agrupacion10
        '
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea5)
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea6)
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea7)
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea8)
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea2)
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea3)
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea4)
        Me.Agrupacion10.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Top)
        Me.Agrupacion10.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom)
        Me.Agrupacion10.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Left)
        Me.Agrupacion10.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Right)
        Me.Agrupacion10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion10.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion10.Location = New System.Drawing.Point(2, 2)
        Me.Agrupacion10.Name = "Agrupacion10"
        Me.Agrupacion10.Size = New System.Drawing.Size(1229, 25)
        Me.Agrupacion10.TabIndex = 245
        Me.Agrupacion10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraToolbarsDockArea5
        '
        Me.UltraToolbarsDockArea5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea5.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea5.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea5.Location = New System.Drawing.Point(3, 3)
        Me.UltraToolbarsDockArea5.Name = "UltraToolbarsDockArea5"
        Me.UltraToolbarsDockArea5.Size = New System.Drawing.Size(1223, 26)
        Me.UltraToolbarsDockArea5.ToolbarsManager = Me.mnuDetalleAsiento
        '
        'mnuDetalleAsiento
        '
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mnuDetalleAsiento.Appearance = Appearance5
        Me.mnuDetalleAsiento.DesignerFlags = 1
        Me.mnuDetalleAsiento.DockWithinContainer = Me
        Me.mnuDetalleAsiento.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.mnuDetalleAsiento.MdiMergeable = False
        Me.mnuDetalleAsiento.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool31, ButtonTool32})
        Me.mnuDetalleAsiento.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(252, 298)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(447, 48)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool33, ButtonTool34})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.mnuDetalleAsiento.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance135.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool35.SharedPropsInternal.AppearancesSmall.Appearance = Appearance135
        ButtonTool35.SharedPropsInternal.Caption = "Agregar"
        ButtonTool35.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance136.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool36.SharedPropsInternal.AppearancesSmall.Appearance = Appearance136
        ButtonTool36.SharedPropsInternal.Caption = "Editar"
        ButtonTool36.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance137.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool37.SharedPropsInternal.AppearancesSmall.Appearance = Appearance137
        ButtonTool37.SharedPropsInternal.Caption = "Eliminar"
        ButtonTool37.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance138.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        ButtonTool38.SharedPropsInternal.AppearancesSmall.Appearance = Appearance138
        ButtonTool38.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool38.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance139.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool39.SharedPropsInternal.AppearancesSmall.Appearance = Appearance139
        ButtonTool39.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool39.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool40.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool41.SharedPropsInternal.Caption = "ButtonTool2"
        ButtonTool42.SharedPropsInternal.Caption = "ButtonTool3"
        Appearance140.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool43.SharedPropsInternal.AppearancesSmall.Appearance = Appearance140
        ButtonTool43.SharedPropsInternal.Caption = "Consultar"
        ButtonTool43.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance141.Image = CType(resources.GetObject("Appearance141.Image"), Object)
        ButtonTool44.SharedPropsInternal.AppearancesSmall.Appearance = Appearance141
        ButtonTool44.SharedPropsInternal.Caption = "Exportar"
        ButtonTool44.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance142.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool45.SharedPropsInternal.AppearancesSmall.Appearance = Appearance142
        ButtonTool45.SharedPropsInternal.Caption = "Modificar"
        ButtonTool45.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnuDetalleAsiento.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool35, ButtonTool36, ButtonTool37, ButtonTool38, ButtonTool39, ButtonTool40, ButtonTool41, ButtonTool42, ButtonTool43, ButtonTool44, ButtonTool45})
        '
        'UltraToolbarsDockArea6
        '
        Me.UltraToolbarsDockArea6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea6.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea6.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea6.Location = New System.Drawing.Point(3, 22)
        Me.UltraToolbarsDockArea6.Name = "UltraToolbarsDockArea6"
        Me.UltraToolbarsDockArea6.Size = New System.Drawing.Size(1223, 0)
        Me.UltraToolbarsDockArea6.ToolbarsManager = Me.mnuDetalleAsiento
        '
        'UltraToolbarsDockArea7
        '
        Me.UltraToolbarsDockArea7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea7.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea7.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea7.Location = New System.Drawing.Point(3, 3)
        Me.UltraToolbarsDockArea7.Name = "UltraToolbarsDockArea7"
        Me.UltraToolbarsDockArea7.Size = New System.Drawing.Size(0, 19)
        Me.UltraToolbarsDockArea7.ToolbarsManager = Me.mnuDetalleAsiento
        '
        'UltraToolbarsDockArea8
        '
        Me.UltraToolbarsDockArea8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea8.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea8.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea8.Location = New System.Drawing.Point(1226, 3)
        Me.UltraToolbarsDockArea8.Name = "UltraToolbarsDockArea8"
        Me.UltraToolbarsDockArea8.Size = New System.Drawing.Size(0, 19)
        Me.UltraToolbarsDockArea8.ToolbarsManager = Me.mnuDetalleAsiento
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(3, 3)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1223, 0)
        '
        'UltraToolbarsDockArea2
        '
        Me.UltraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea2.Location = New System.Drawing.Point(3, 22)
        Me.UltraToolbarsDockArea2.Name = "UltraToolbarsDockArea2"
        Me.UltraToolbarsDockArea2.Size = New System.Drawing.Size(1223, 0)
        '
        'UltraToolbarsDockArea3
        '
        Me.UltraToolbarsDockArea3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea3.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea3.Location = New System.Drawing.Point(3, 3)
        Me.UltraToolbarsDockArea3.Name = "UltraToolbarsDockArea3"
        Me.UltraToolbarsDockArea3.Size = New System.Drawing.Size(0, 19)
        '
        'UltraToolbarsDockArea4
        '
        Me.UltraToolbarsDockArea4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea4.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea4.Location = New System.Drawing.Point(1226, 3)
        Me.UltraToolbarsDockArea4.Name = "UltraToolbarsDockArea4"
        Me.UltraToolbarsDockArea4.Size = New System.Drawing.Size(0, 19)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Top
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(3, 3)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Top"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1223, 0)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Bottom
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(3, 22)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Bottom"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1223, 0)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Left
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(3, 3)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Left"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 19)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Right
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1226, 3)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Right"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 19)
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.agrObligación)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(319, 120)
        '
        'agrObligación
        '
        Appearance74.BackColor = System.Drawing.Color.Azure
        Me.agrObligación.Appearance = Appearance74
        Appearance75.BackColor = System.Drawing.Color.Azure
        Me.agrObligación.ContentAreaAppearance = Appearance75
        Me.agrObligación.Controls.Add(Me.Etiqueta52)
        Me.agrObligación.Controls.Add(Me.etiTotalLeasing)
        Me.agrObligación.Controls.Add(Me.Etiqueta46)
        Me.agrObligación.Controls.Add(Me.decInteres)
        Me.agrObligación.Controls.Add(Me.Etiqueta45)
        Me.agrObligación.Controls.Add(Me.decTotalLeasing)
        Me.agrObligación.Controls.Add(Me.txtGlosa)
        Me.agrObligación.Controls.Add(Me.Etiqueta43)
        Me.agrObligación.Controls.Add(Me.txtCuota)
        Me.agrObligación.Controls.Add(Me.Etiqueta44)
        Me.agrObligación.Controls.Add(Me.Etiqueta42)
        Me.agrObligación.Controls.Add(Me.cboMoneda2)
        Me.agrObligación.Controls.Add(Me.Etiqueta41)
        Me.agrObligación.Controls.Add(Me.Etiqueta40)
        Me.agrObligación.Controls.Add(Me.decSaldo)
        Me.agrObligación.Controls.Add(Me.fecVenc)
        Me.agrObligación.Controls.Add(Me.txtCuenta)
        Me.agrObligación.Controls.Add(Me.Etiqueta39)
        Me.agrObligación.Controls.Add(Me.Etiqueta38)
        Me.agrObligación.Controls.Add(Me.cboCodigoLeasing)
        Me.agrObligación.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrObligación.Enabled = False
        Me.agrObligación.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrObligación.ForeColor = System.Drawing.Color.Black
        Me.agrObligación.Location = New System.Drawing.Point(0, 0)
        Me.agrObligación.Name = "agrObligación"
        Me.agrObligación.Size = New System.Drawing.Size(319, 120)
        Me.agrObligación.TabIndex = 0
        Me.agrObligación.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta52
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta52.Appearance = Appearance76
        Me.Etiqueta52.AutoSize = True
        Me.Etiqueta52.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta52.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta52.Location = New System.Drawing.Point(180, 76)
        Me.Etiqueta52.Name = "Etiqueta52"
        Me.Etiqueta52.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta52.TabIndex = 16
        Me.Etiqueta52.Text = "Total:"
        '
        'etiTotalLeasing
        '
        Me.etiTotalLeasing.AutoSize = True
        Me.etiTotalLeasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotalLeasing.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTotalLeasing.Location = New System.Drawing.Point(227, 77)
        Me.etiTotalLeasing.Name = "etiTotalLeasing"
        Me.etiTotalLeasing.Size = New System.Drawing.Size(10, 14)
        Me.etiTotalLeasing.TabIndex = 17
        Me.etiTotalLeasing.Text = "0"
        '
        'Etiqueta46
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta46.Appearance = Appearance77
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta46.Location = New System.Drawing.Point(166, 54)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta46.TabIndex = 14
        Me.Etiqueta46.Text = "Interes:"
        '
        'decInteres
        '
        Appearance78.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decInteres.Appearance = Appearance78
        Me.decInteres.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decInteres.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decInteres.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decInteres.Location = New System.Drawing.Point(214, 50)
        Me.decInteres.Name = "decInteres"
        Me.decInteres.NullText = "0.00"
        Me.decInteres.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decInteres.Size = New System.Drawing.Size(99, 22)
        Me.decInteres.TabIndex = 15
        '
        'Etiqueta45
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta45.Appearance = Appearance79
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(13, 53)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta45.TabIndex = 4
        Me.Etiqueta45.Text = "Monto:"
        '
        'decTotalLeasing
        '
        Appearance80.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTotalLeasing.Appearance = Appearance80
        Me.decTotalLeasing.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalLeasing.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalLeasing.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decTotalLeasing.Location = New System.Drawing.Point(59, 50)
        Me.decTotalLeasing.Name = "decTotalLeasing"
        Me.decTotalLeasing.NullText = "0.00"
        Me.decTotalLeasing.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalLeasing.Size = New System.Drawing.Size(98, 22)
        Me.decTotalLeasing.TabIndex = 5
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(180, 92)
        Me.txtGlosa.MaxLength = 200
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(133, 22)
        Me.txtGlosa.TabIndex = 19
        '
        'Etiqueta43
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta43.Appearance = Appearance81
        Me.Etiqueta43.AutoSize = True
        Me.Etiqueta43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta43.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta43.Location = New System.Drawing.Point(143, 97)
        Me.Etiqueta43.Name = "Etiqueta43"
        Me.Etiqueta43.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta43.TabIndex = 18
        Me.Etiqueta43.Text = "Glosa"
        '
        'txtCuota
        '
        Me.txtCuota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuota.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuota.Location = New System.Drawing.Point(59, 96)
        Me.txtCuota.MaxLength = 11
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(59, 22)
        Me.txtCuota.TabIndex = 9
        '
        'Etiqueta44
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta44.Appearance = Appearance82
        Me.Etiqueta44.AutoSize = True
        Me.Etiqueta44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta44.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta44.Location = New System.Drawing.Point(3, 97)
        Me.Etiqueta44.Name = "Etiqueta44"
        Me.Etiqueta44.Size = New System.Drawing.Size(54, 15)
        Me.Etiqueta44.TabIndex = 8
        Me.Etiqueta44.Text = "N° Cuota:"
        '
        'Etiqueta42
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Appearance83.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta42.Appearance = Appearance83
        Me.Etiqueta42.AutoSize = True
        Me.Etiqueta42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta42.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta42.Location = New System.Drawing.Point(179, 31)
        Me.Etiqueta42.Name = "Etiqueta42"
        Me.Etiqueta42.Size = New System.Drawing.Size(29, 15)
        Me.Etiqueta42.TabIndex = 12
        Me.Etiqueta42.Text = "Mon:"
        '
        'cboMoneda2
        '
        Appearance84.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda2.Appearance = Appearance84
        Me.cboMoneda2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda2.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda2.Enabled = False
        Me.cboMoneda2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda2.Location = New System.Drawing.Point(214, 27)
        Me.cboMoneda2.Name = "cboMoneda2"
        Me.cboMoneda2.Size = New System.Drawing.Size(99, 21)
        Me.cboMoneda2.TabIndex = 13
        Me.cboMoneda2.ValueMember = "Id"
        '
        'Etiqueta41
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta41.Appearance = Appearance85
        Me.Etiqueta41.AutoSize = True
        Me.Etiqueta41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta41.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta41.Location = New System.Drawing.Point(17, 76)
        Me.Etiqueta41.Name = "Etiqueta41"
        Me.Etiqueta41.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta41.TabIndex = 6
        Me.Etiqueta41.Text = "Saldo:"
        Me.Etiqueta41.Visible = False
        '
        'Etiqueta40
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta40.Appearance = Appearance86
        Me.Etiqueta40.AutoSize = True
        Me.Etiqueta40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta40.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta40.Location = New System.Drawing.Point(12, 31)
        Me.Etiqueta40.Name = "Etiqueta40"
        Me.Etiqueta40.Size = New System.Drawing.Size(45, 15)
        Me.Etiqueta40.TabIndex = 2
        Me.Etiqueta40.Text = "F. Venc."
        '
        'decSaldo
        '
        Appearance87.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decSaldo.Appearance = Appearance87
        Me.decSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decSaldo.Location = New System.Drawing.Point(59, 73)
        Me.decSaldo.Name = "decSaldo"
        Me.decSaldo.NullText = "0.00"
        Me.decSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldo.Size = New System.Drawing.Size(99, 22)
        Me.decSaldo.TabIndex = 7
        Me.decSaldo.Visible = False
        '
        'fecVenc
        '
        Appearance88.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecVenc.Appearance = Appearance88
        Me.fecVenc.DateTime = New Date(2011, 11, 29, 0, 0, 0, 0)
        Me.fecVenc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecVenc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecVenc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecVenc.Location = New System.Drawing.Point(59, 28)
        Me.fecVenc.Name = "fecVenc"
        Me.fecVenc.ReadOnly = True
        Me.fecVenc.Size = New System.Drawing.Size(98, 21)
        Me.fecVenc.TabIndex = 3
        Me.fecVenc.Value = New Date(2011, 11, 29, 0, 0, 0, 0)
        '
        'txtCuenta
        '
        Appearance89.TextHAlignAsString = "Right"
        Me.txtCuenta.Appearance = Appearance89
        Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(214, 4)
        Me.txtCuenta.MaxLength = 11
        Me.txtCuenta.Name = "txtCuenta"
        Appearance90.TextHAlignAsString = "Right"
        Me.txtCuenta.NullTextAppearance = Appearance90
        Me.txtCuenta.Size = New System.Drawing.Size(99, 21)
        Me.txtCuenta.TabIndex = 11
        '
        'Etiqueta39
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta39.Appearance = Appearance91
        Me.Etiqueta39.AutoSize = True
        Me.Etiqueta39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta39.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta39.Location = New System.Drawing.Point(180, 8)
        Me.Etiqueta39.Name = "Etiqueta39"
        Me.Etiqueta39.Size = New System.Drawing.Size(25, 15)
        Me.Etiqueta39.TabIndex = 10
        Me.Etiqueta39.Text = "Cta:"
        '
        'Etiqueta38
        '
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Appearance92.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta38.Appearance = Appearance92
        Me.Etiqueta38.AutoSize = True
        Me.Etiqueta38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta38.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta38.Location = New System.Drawing.Point(9, 9)
        Me.Etiqueta38.Name = "Etiqueta38"
        Me.Etiqueta38.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta38.TabIndex = 0
        Me.Etiqueta38.Text = "Codigo:"
        '
        'cboCodigoLeasing
        '
        Appearance93.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCodigoLeasing.Appearance = Appearance93
        Me.cboCodigoLeasing.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCodigoLeasing.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCodigoLeasing.DropDownListWidth = 200
        Me.cboCodigoLeasing.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCodigoLeasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodigoLeasing.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCodigoLeasing.ImageList = Me.imagenes
        Me.cboCodigoLeasing.Location = New System.Drawing.Point(59, 5)
        Me.cboCodigoLeasing.Name = "cboCodigoLeasing"
        Me.cboCodigoLeasing.Size = New System.Drawing.Size(98, 21)
        Me.cboCodigoLeasing.TabIndex = 1
        Me.cboCodigoLeasing.ValueMember = "Id"
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
        Me.UltraTabPageControl5.Controls.Add(Me.PanelCupon)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(319, 120)
        '
        'PanelCupon
        '
        Appearance64.BackColor = System.Drawing.Color.Azure
        Me.PanelCupon.Appearance = Appearance64
        Me.PanelCupon.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        '
        'PanelCupon.ClientArea
        '
        Me.PanelCupon.ClientArea.Controls.Add(Me.CboMonedaCupon)
        Me.PanelCupon.ClientArea.Controls.Add(Me.Etiqueta49)
        Me.PanelCupon.ClientArea.Controls.Add(Me.UltraLabel1)
        Me.PanelCupon.ClientArea.Controls.Add(Me.nd_SaldoCupon)
        Me.PanelCupon.ClientArea.Controls.Add(Me.Etiqueta50)
        Me.PanelCupon.ClientArea.Controls.Add(Me.CboFilPoliza)
        Me.PanelCupon.ClientArea.Controls.Add(Me.LblNumeroPoliza)
        Me.PanelCupon.ClientArea.Controls.Add(Me.TxtNumeroPoliza)
        Me.PanelCupon.ClientArea.Controls.Add(Me.nd_MontoOperaCupon)
        Me.PanelCupon.ClientArea.Controls.Add(Me.LblMontoOperaCupon)
        Me.PanelCupon.ClientArea.Controls.Add(Me.ndMontoCupon)
        Me.PanelCupon.ClientArea.Controls.Add(Me.dtpFechaCupon)
        Me.PanelCupon.ClientArea.Controls.Add(Me.LblMontoCupon)
        Me.PanelCupon.ClientArea.Controls.Add(Me.LblVencimientoCupon)
        Me.PanelCupon.ClientArea.Controls.Add(Me.BtnConsultar)
        Me.PanelCupon.ClientArea.Controls.Add(Me.CmbMes)
        Me.PanelCupon.ClientArea.Controls.Add(Me.Etiqueta51)
        Me.PanelCupon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCupon.Enabled = False
        Me.PanelCupon.Location = New System.Drawing.Point(0, 0)
        Me.PanelCupon.Name = "PanelCupon"
        Me.PanelCupon.Size = New System.Drawing.Size(319, 120)
        Me.PanelCupon.TabIndex = 0
        '
        'CboMonedaCupon
        '
        Appearance65.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CboMonedaCupon.Appearance = Appearance65
        Me.CboMonedaCupon.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.CboMonedaCupon.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboMonedaCupon.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboMonedaCupon.Enabled = False
        Me.CboMonedaCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMonedaCupon.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CboMonedaCupon.Location = New System.Drawing.Point(196, 49)
        Me.CboMonedaCupon.Name = "CboMonedaCupon"
        Me.CboMonedaCupon.Size = New System.Drawing.Size(91, 21)
        Me.CboMonedaCupon.TabIndex = 391
        Me.CboMonedaCupon.ValueMember = "Id"
        '
        'Etiqueta49
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta49.Appearance = Appearance66
        Me.Etiqueta49.AutoSize = True
        Me.Etiqueta49.Enabled = False
        Me.Etiqueta49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Etiqueta49.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta49.Location = New System.Drawing.Point(145, 53)
        Me.Etiqueta49.Name = "Etiqueta49"
        Me.Etiqueta49.Size = New System.Drawing.Size(48, 14)
        Me.Etiqueta49.TabIndex = 390
        Me.Etiqueta49.Text = "Moneda:"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Enabled = False
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 97)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel1.TabIndex = 389
        Me.UltraLabel1.Text = "Saldo:"
        '
        'nd_SaldoCupon
        '
        Appearance67.ForeColor = System.Drawing.Color.Black
        Me.nd_SaldoCupon.Appearance = Appearance67
        Me.nd_SaldoCupon.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_SaldoCupon.Enabled = False
        Me.nd_SaldoCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_SaldoCupon.ForeColor = System.Drawing.Color.Black
        Me.nd_SaldoCupon.Location = New System.Drawing.Point(47, 93)
        Me.nd_SaldoCupon.MaskInput = "{LOC}nnnnnnn.nnn"
        Me.nd_SaldoCupon.Name = "nd_SaldoCupon"
        Me.nd_SaldoCupon.NullText = "0.00"
        Me.nd_SaldoCupon.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_SaldoCupon.Size = New System.Drawing.Size(79, 21)
        Me.nd_SaldoCupon.TabIndex = 388
        '
        'Etiqueta50
        '
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta50.Location = New System.Drawing.Point(18, 31)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(26, 14)
        Me.Etiqueta50.TabIndex = 387
        Me.Etiqueta50.Text = "Sel.:"
        '
        'CboFilPoliza
        '
        Appearance68.ForeColor = System.Drawing.Color.Black
        Me.CboFilPoliza.Appearance = Appearance68
        Me.CboFilPoliza.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CboFilPoliza.DisplayMember = "Placa"
        Me.CboFilPoliza.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboFilPoliza.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboFilPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFilPoliza.ForeColor = System.Drawing.Color.Black
        Me.CboFilPoliza.Location = New System.Drawing.Point(47, 27)
        Me.CboFilPoliza.Name = "CboFilPoliza"
        Me.CboFilPoliza.Size = New System.Drawing.Size(239, 21)
        Me.CboFilPoliza.TabIndex = 386
        Me.CboFilPoliza.ValueMember = "Id"
        '
        'LblNumeroPoliza
        '
        Me.LblNumeroPoliza.AutoSize = True
        Me.LblNumeroPoliza.Enabled = False
        Me.LblNumeroPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumeroPoliza.Location = New System.Drawing.Point(6, 53)
        Me.LblNumeroPoliza.Name = "LblNumeroPoliza"
        Me.LblNumeroPoliza.Size = New System.Drawing.Size(38, 14)
        Me.LblNumeroPoliza.TabIndex = 385
        Me.LblNumeroPoliza.Text = "Poliza:"
        '
        'TxtNumeroPoliza
        '
        Me.TxtNumeroPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumeroPoliza.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtNumeroPoliza.Enabled = False
        Me.TxtNumeroPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroPoliza.Location = New System.Drawing.Point(47, 49)
        Me.TxtNumeroPoliza.MaxLength = 20
        Me.TxtNumeroPoliza.Name = "TxtNumeroPoliza"
        Me.TxtNumeroPoliza.Size = New System.Drawing.Size(79, 21)
        Me.TxtNumeroPoliza.TabIndex = 384
        '
        'nd_MontoOperaCupon
        '
        Appearance69.ForeColor = System.Drawing.Color.Black
        Me.nd_MontoOperaCupon.Appearance = Appearance69
        Me.nd_MontoOperaCupon.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_MontoOperaCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_MontoOperaCupon.ForeColor = System.Drawing.Color.Black
        Me.nd_MontoOperaCupon.Location = New System.Drawing.Point(196, 93)
        Me.nd_MontoOperaCupon.MaskInput = "{LOC}nnnnnnn.nnn"
        Me.nd_MontoOperaCupon.Name = "nd_MontoOperaCupon"
        Me.nd_MontoOperaCupon.NullText = "0.00"
        Me.nd_MontoOperaCupon.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_MontoOperaCupon.Size = New System.Drawing.Size(91, 21)
        Me.nd_MontoOperaCupon.TabIndex = 383
        '
        'LblMontoOperaCupon
        '
        Me.LblMontoOperaCupon.AutoSize = True
        Me.LblMontoOperaCupon.Enabled = False
        Me.LblMontoOperaCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoOperaCupon.Location = New System.Drawing.Point(151, 97)
        Me.LblMontoOperaCupon.Name = "LblMontoOperaCupon"
        Me.LblMontoOperaCupon.Size = New System.Drawing.Size(42, 14)
        Me.LblMontoOperaCupon.TabIndex = 382
        Me.LblMontoOperaCupon.Text = "Aplicar:"
        '
        'ndMontoCupon
        '
        Appearance70.ForeColor = System.Drawing.Color.Black
        Me.ndMontoCupon.Appearance = Appearance70
        Me.ndMontoCupon.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndMontoCupon.Enabled = False
        Me.ndMontoCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndMontoCupon.ForeColor = System.Drawing.Color.Black
        Me.ndMontoCupon.Location = New System.Drawing.Point(47, 71)
        Me.ndMontoCupon.MaskInput = "{LOC}nnnnnnn.nnn"
        Me.ndMontoCupon.Name = "ndMontoCupon"
        Me.ndMontoCupon.NullText = "0.00"
        Me.ndMontoCupon.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndMontoCupon.Size = New System.Drawing.Size(79, 21)
        Me.ndMontoCupon.TabIndex = 381
        '
        'dtpFechaCupon
        '
        Appearance71.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dtpFechaCupon.Appearance = Appearance71
        Me.dtpFechaCupon.DateTime = New Date(2015, 7, 22, 0, 0, 0, 0)
        Me.dtpFechaCupon.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.dtpFechaCupon.Enabled = False
        Me.dtpFechaCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCupon.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dtpFechaCupon.Location = New System.Drawing.Point(196, 71)
        Me.dtpFechaCupon.Name = "dtpFechaCupon"
        Me.dtpFechaCupon.Size = New System.Drawing.Size(91, 21)
        Me.dtpFechaCupon.TabIndex = 380
        Me.dtpFechaCupon.Value = New Date(2015, 7, 22, 0, 0, 0, 0)
        '
        'LblMontoCupon
        '
        Me.LblMontoCupon.AutoSize = True
        Me.LblMontoCupon.Enabled = False
        Me.LblMontoCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoCupon.Location = New System.Drawing.Point(5, 75)
        Me.LblMontoCupon.Name = "LblMontoCupon"
        Me.LblMontoCupon.Size = New System.Drawing.Size(39, 14)
        Me.LblMontoCupon.TabIndex = 379
        Me.LblMontoCupon.Text = "Monto:"
        '
        'LblVencimientoCupon
        '
        Me.LblVencimientoCupon.AutoSize = True
        Me.LblVencimientoCupon.Enabled = False
        Me.LblVencimientoCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimientoCupon.Location = New System.Drawing.Point(147, 75)
        Me.LblVencimientoCupon.Name = "LblVencimientoCupon"
        Me.LblVencimientoCupon.Size = New System.Drawing.Size(46, 14)
        Me.LblVencimientoCupon.TabIndex = 378
        Me.LblVencimientoCupon.Text = "F. Venc:"
        '
        'BtnConsultar
        '
        Appearance72.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.BtnConsultar.Appearance = Appearance72
        Me.BtnConsultar.Location = New System.Drawing.Point(259, 3)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(28, 22)
        Me.BtnConsultar.TabIndex = 377
        '
        'CmbMes
        '
        Appearance73.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CmbMes.Appearance = Appearance73
        Me.CmbMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.CmbMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CmbMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CmbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMes.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem4.DataValue = "1"
        ValueListItem4.DisplayText = "Enero"
        ValueListItem5.DataValue = "2"
        ValueListItem5.DisplayText = "Febrero"
        ValueListItem6.DataValue = "3"
        ValueListItem6.DisplayText = "Marzo"
        ValueListItem7.DataValue = "4"
        ValueListItem7.DisplayText = "Abril"
        ValueListItem8.DataValue = "5"
        ValueListItem8.DisplayText = "Marzo"
        ValueListItem9.DataValue = "6"
        ValueListItem9.DisplayText = "Junio"
        ValueListItem10.DataValue = "7"
        ValueListItem10.DisplayText = "Julio"
        ValueListItem11.DataValue = "8"
        ValueListItem11.DisplayText = "Agosto"
        ValueListItem12.DataValue = "9"
        ValueListItem12.DisplayText = "Setiembre"
        ValueListItem13.DataValue = "10"
        ValueListItem13.DisplayText = "Octubre"
        ValueListItem14.DataValue = "11"
        ValueListItem14.DisplayText = "Noviembre"
        ValueListItem15.DataValue = "12"
        ValueListItem15.DisplayText = "Diciembre"
        Me.CmbMes.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem4, ValueListItem5, ValueListItem6, ValueListItem7, ValueListItem8, ValueListItem9, ValueListItem10, ValueListItem11, ValueListItem12, ValueListItem13, ValueListItem14, ValueListItem15})
        Me.CmbMes.Location = New System.Drawing.Point(124, 4)
        Me.CmbMes.Name = "CmbMes"
        Me.CmbMes.Size = New System.Drawing.Size(130, 21)
        Me.CmbMes.TabIndex = 376
        Me.CmbMes.ValueMember = "Id"
        '
        'Etiqueta51
        '
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(18, 8)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(27, 14)
        Me.Etiqueta51.TabIndex = 374
        Me.Etiqueta51.Text = "Año:"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.gridComprobanteCompra)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1239, 710)
        '
        'gridComprobanteCompra
        '
        Me.gridComprobanteCompra.ContextMenuStrip = Me.MenuCabecera
        Me.gridComprobanteCompra.DataSource = Me.UltraDataSource1
        UltraGridColumn272.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn272.Header.VisiblePosition = 0
        UltraGridColumn272.Hidden = True
        UltraGridColumn273.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn273.Header.Caption = "TipoDocumento"
        UltraGridColumn273.Header.VisiblePosition = 2
        UltraGridColumn273.Width = 150
        UltraGridColumn274.Header.VisiblePosition = 3
        UltraGridColumn274.Hidden = True
        UltraGridColumn274.Width = 200
        UltraGridColumn275.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn275.Header.VisiblePosition = 4
        UltraGridColumn275.Width = 50
        UltraGridColumn276.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn276.Header.VisiblePosition = 5
        UltraGridColumn276.Width = 100
        UltraGridColumn277.Header.Caption = "F.Emision"
        UltraGridColumn277.Header.VisiblePosition = 7
        UltraGridColumn277.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn277.Width = 70
        UltraGridColumn278.Header.Caption = "F.Vencto"
        UltraGridColumn278.Header.VisiblePosition = 8
        UltraGridColumn278.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn278.Width = 70
        UltraGridColumn279.Header.VisiblePosition = 9
        UltraGridColumn279.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn280.CellAppearance = Appearance7
        UltraGridColumn280.Header.VisiblePosition = 15
        UltraGridColumn280.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn280.Width = 50
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn281.CellAppearance = Appearance8
        UltraGridColumn281.Header.VisiblePosition = 14
        UltraGridColumn281.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn281.Width = 60
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn282.CellAppearance = Appearance9
        UltraGridColumn282.Header.VisiblePosition = 16
        UltraGridColumn282.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn282.Width = 70
        UltraGridColumn283.Header.VisiblePosition = 17
        UltraGridColumn283.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn284.CellAppearance = Appearance10
        UltraGridColumn284.Header.Caption = "T.Cambio"
        UltraGridColumn284.Header.VisiblePosition = 11
        UltraGridColumn284.MaskInput = "{LOC}n.nnnn"
        UltraGridColumn284.Width = 50
        UltraGridColumn285.Header.VisiblePosition = 18
        UltraGridColumn285.Hidden = True
        UltraGridColumn286.Header.VisiblePosition = 19
        UltraGridColumn286.Hidden = True
        UltraGridColumn287.Header.Caption = "Proveedor"
        UltraGridColumn287.Header.VisiblePosition = 6
        UltraGridColumn287.Width = 250
        UltraGridColumn288.Header.VisiblePosition = 20
        UltraGridColumn288.Hidden = True
        UltraGridColumn289.Header.VisiblePosition = 21
        UltraGridColumn289.Hidden = True
        UltraGridColumn290.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn290.Header.Caption = "Periodo"
        UltraGridColumn290.Header.VisiblePosition = 1
        UltraGridColumn290.Width = 50
        UltraGridColumn291.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn291.Header.Caption = "Usuario Crea"
        UltraGridColumn291.Header.VisiblePosition = 23
        UltraGridColumn291.Width = 190
        UltraGridColumn292.Header.VisiblePosition = 24
        UltraGridColumn292.Hidden = True
        UltraGridColumn293.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn293.Header.Caption = "Moneda"
        UltraGridColumn293.Header.VisiblePosition = 13
        UltraGridColumn293.Width = 35
        UltraGridColumn294.Header.VisiblePosition = 12
        UltraGridColumn294.Hidden = True
        UltraGridColumn294.MaskInput = ""
        UltraGridColumn294.Width = 30
        UltraGridColumn295.Header.VisiblePosition = 25
        UltraGridColumn295.Hidden = True
        UltraGridColumn296.Header.VisiblePosition = 26
        UltraGridColumn296.Hidden = True
        UltraGridColumn297.Header.VisiblePosition = 27
        UltraGridColumn297.Hidden = True
        UltraGridColumn298.Header.VisiblePosition = 28
        UltraGridColumn298.Hidden = True
        UltraGridColumn299.Header.VisiblePosition = 29
        UltraGridColumn299.Hidden = True
        UltraGridColumn300.Header.VisiblePosition = 30
        UltraGridColumn300.Hidden = True
        UltraGridColumn301.Header.VisiblePosition = 31
        UltraGridColumn301.Hidden = True
        UltraGridColumn302.Header.VisiblePosition = 32
        UltraGridColumn302.Hidden = True
        Appearance11.Image = 3
        Appearance11.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn303.CellAppearance = Appearance11
        Appearance12.Image = 1
        Appearance12.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn303.CellButtonAppearance = Appearance12
        UltraGridColumn303.Header.Caption = "Guardar"
        UltraGridColumn303.Header.VisiblePosition = 10
        UltraGridColumn303.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn303.Width = 30
        UltraGridColumn304.Header.VisiblePosition = 33
        UltraGridColumn304.Hidden = True
        Appearance13.TextHAlignAsString = "Center"
        Appearance13.TextVAlignAsString = "Middle"
        UltraGridColumn305.CellAppearance = Appearance13
        UltraGridColumn305.Header.Caption = "Verificado"
        UltraGridColumn305.Header.VisiblePosition = 34
        UltraGridColumn305.Width = 63
        UltraGridColumn306.Header.VisiblePosition = 35
        UltraGridColumn306.Hidden = True
        UltraGridColumn307.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn307.Header.Caption = "Detraccion"
        UltraGridColumn307.Header.VisiblePosition = 22
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295, UltraGridColumn296, UltraGridColumn297, UltraGridColumn298, UltraGridColumn299, UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn307})
        UltraGridBand4.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridComprobanteCompra.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.gridComprobanteCompra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridComprobanteCompra.DisplayLayout.MaxColScrollRegions = 1
        Me.gridComprobanteCompra.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridComprobanteCompra.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridComprobanteCompra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridComprobanteCompra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridComprobanteCompra.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridComprobanteCompra.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridComprobanteCompra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridComprobanteCompra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridComprobanteCompra.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridComprobanteCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridComprobanteCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridComprobanteCompra.ImageList = Me.imagenes
        Me.gridComprobanteCompra.Location = New System.Drawing.Point(0, 57)
        Me.gridComprobanteCompra.Name = "gridComprobanteCompra"
        Me.gridComprobanteCompra.Size = New System.Drawing.Size(1239, 653)
        Me.gridComprobanteCompra.TabIndex = 1
        Me.gridComprobanteCompra.Text = "Comprobante Compra"
        '
        'MenuCabecera
        '
        Me.MenuCabecera.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarCabecera, Me.EditarCabecera, Me.EliminaCabecera, Me.CambiarPeriodoToolStripMenuItem})
        Me.MenuCabecera.Name = "mnu_Transferencias"
        Me.MenuCabecera.Size = New System.Drawing.Size(168, 108)
        '
        'AgregarCabecera
        '
        Me.AgregarCabecera.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarCabecera.Name = "AgregarCabecera"
        Me.AgregarCabecera.Size = New System.Drawing.Size(167, 26)
        Me.AgregarCabecera.Text = "Agregar"
        '
        'EditarCabecera
        '
        Me.EditarCabecera.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarCabecera.Name = "EditarCabecera"
        Me.EditarCabecera.Size = New System.Drawing.Size(167, 26)
        Me.EditarCabecera.Text = "Editar"
        '
        'EliminaCabecera
        '
        Me.EliminaCabecera.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminaCabecera.Name = "EliminaCabecera"
        Me.EliminaCabecera.Size = New System.Drawing.Size(167, 26)
        Me.EliminaCabecera.Text = "Eliminar"
        '
        'CambiarPeriodoToolStripMenuItem
        '
        Me.CambiarPeriodoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.CambiarPeriodoToolStripMenuItem.Name = "CambiarPeriodoToolStripMenuItem"
        Me.CambiarPeriodoToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.CambiarPeriodoToolStripMenuItem.Text = "Cambiar Periodo"
        '
        'UltraDataSource1
        '
        UltraDataColumn72.DataType = GetType(Boolean)
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.dtpFechaEjercicio)
        Me.Agrupacion1.Controls.Add(Me.etiProveedor)
        Me.Agrupacion1.Controls.Add(Me.cboProveedores)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta48)
        Me.Agrupacion1.Controls.Add(Me.ColorBloque)
        Me.Agrupacion1.Controls.Add(Me.btn_Extornar)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion1.Controls.Add(Me.cboMes)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1239, 57)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Busca"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'dtpFechaEjercicio
        '
        Me.dtpFechaEjercicio.CustomFormat = "yyyy"
        Me.dtpFechaEjercicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaEjercicio.Location = New System.Drawing.Point(69, 26)
        Me.dtpFechaEjercicio.Name = "dtpFechaEjercicio"
        Me.dtpFechaEjercicio.ShowUpDown = True
        Me.dtpFechaEjercicio.Size = New System.Drawing.Size(52, 21)
        Me.dtpFechaEjercicio.TabIndex = 8
        '
        'etiProveedor
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.etiProveedor.Appearance = Appearance14
        Me.etiProveedor.AutoSize = True
        Me.etiProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiProveedor.ForeColor = System.Drawing.Color.Black
        Me.etiProveedor.Location = New System.Drawing.Point(433, 30)
        Me.etiProveedor.Name = "etiProveedor"
        Me.etiProveedor.Size = New System.Drawing.Size(59, 15)
        Me.etiProveedor.TabIndex = 5
        Me.etiProveedor.Text = "Proveedor:"
        '
        'cboProveedores
        '
        Me.cboProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance15.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance15
        Me.cboProveedores.ButtonsRight.Add(EditorButton1)
        Me.cboProveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedores.CheckedListSettings.ListSeparator = ","
        Me.cboProveedores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn99.Header.VisiblePosition = 0
        UltraGridColumn99.Hidden = True
        UltraGridColumn99.Width = 19
        UltraGridColumn100.Header.VisiblePosition = 1
        UltraGridColumn100.Hidden = True
        UltraGridColumn100.Width = 18
        UltraGridColumn101.Header.VisiblePosition = 2
        UltraGridColumn101.Hidden = True
        UltraGridColumn101.Width = 31
        UltraGridColumn102.Header.VisiblePosition = 3
        UltraGridColumn102.Hidden = True
        UltraGridColumn102.Width = 28
        UltraGridColumn103.Header.VisiblePosition = 4
        UltraGridColumn103.Hidden = True
        UltraGridColumn103.Width = 25
        UltraGridColumn104.Header.VisiblePosition = 5
        UltraGridColumn104.Hidden = True
        UltraGridColumn104.Width = 17
        UltraGridColumn105.Header.VisiblePosition = 6
        UltraGridColumn105.Hidden = True
        UltraGridColumn105.Width = 25
        UltraGridColumn106.Header.VisiblePosition = 7
        UltraGridColumn106.Hidden = True
        UltraGridColumn106.Width = 25
        UltraGridColumn107.Header.VisiblePosition = 8
        UltraGridColumn107.Hidden = True
        UltraGridColumn107.Width = 25
        UltraGridColumn108.Header.VisiblePosition = 9
        UltraGridColumn108.Hidden = True
        UltraGridColumn108.Width = 54
        UltraGridColumn109.Header.VisiblePosition = 10
        UltraGridColumn109.Width = 200
        UltraGridColumn110.Header.VisiblePosition = 11
        UltraGridColumn110.Hidden = True
        UltraGridColumn110.Width = 54
        UltraGridColumn111.Header.VisiblePosition = 12
        UltraGridColumn111.Hidden = True
        UltraGridColumn111.Width = 55
        UltraGridColumn112.Header.VisiblePosition = 13
        UltraGridColumn112.Width = 198
        UltraGridColumn113.Header.VisiblePosition = 14
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 15
        UltraGridColumn114.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114})
        Me.cboProveedores.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.cboProveedores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedores.DropDownWidth = 400
        Me.cboProveedores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedores.Location = New System.Drawing.Point(497, 25)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(410, 23)
        Me.cboProveedores.TabIndex = 6
        '
        'Etiqueta48
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta48.Appearance = Appearance16
        Me.Etiqueta48.AutoSize = True
        Me.Etiqueta48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta48.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta48.Location = New System.Drawing.Point(300, 30)
        Me.Etiqueta48.Name = "Etiqueta48"
        Me.Etiqueta48.Size = New System.Drawing.Size(65, 15)
        Me.Etiqueta48.TabIndex = 3
        Me.Etiqueta48.Text = "Actualizado:"
        '
        'ColorBloque
        '
        Me.ColorBloque.Color = System.Drawing.Color.Aqua
        Me.ColorBloque.Location = New System.Drawing.Point(371, 26)
        Me.ColorBloque.Name = "ColorBloque"
        Me.ColorBloque.Size = New System.Drawing.Size(44, 22)
        Me.ColorBloque.TabIndex = 4
        Me.ColorBloque.TabStop = False
        Me.ColorBloque.Text = "Aqua"
        '
        'btn_Extornar
        '
        Appearance17.Image = 5
        Me.btn_Extornar.Appearance = Appearance17
        Me.btn_Extornar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btn_Extornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Extornar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Extornar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Extornar.ForeColor = System.Drawing.Color.Black
        Me.btn_Extornar.ImageList = Me.imagenes
        Me.btn_Extornar.Location = New System.Drawing.Point(1121, 17)
        Me.btn_Extornar.Name = "btn_Extornar"
        Me.btn_Extornar.Size = New System.Drawing.Size(115, 37)
        Me.btn_Extornar.TabIndex = 7
        Me.btn_Extornar.Text = "Extornar Envio"
        '
        'Etiqueta7
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance18
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(129, 30)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta7.TabIndex = 1
        Me.Etiqueta7.Text = "Mes:"
        '
        'cboMes
        '
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance19
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(166, 26)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(128, 22)
        Me.cboMes.TabIndex = 2
        Me.cboMes.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance20
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(6, 30)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "Ejercicio:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.tcComprobanteDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.grupoDetalleCuentas)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1239, 710)
        '
        'tcComprobanteDetalle
        '
        Me.tcComprobanteDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tcComprobanteDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.tcComprobanteDetalle.Controls.Add(Me.UltraTabPageControl4)
        Me.tcComprobanteDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcComprobanteDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcComprobanteDetalle.Location = New System.Drawing.Point(0, 440)
        Me.tcComprobanteDetalle.Name = "tcComprobanteDetalle"
        Me.tcComprobanteDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tcComprobanteDetalle.Size = New System.Drawing.Size(1239, 270)
        Me.tcComprobanteDetalle.TabIndex = 2
        UltraTab5.Key = "Tab1"
        UltraTab5.TabPage = Me.UltraTabPageControl3
        UltraTab5.Text = "Lista"
        UltraTab6.Key = "Tab2"
        UltraTab6.TabPage = Me.UltraTabPageControl4
        UltraTab6.Text = "Matenimiento"
        Me.tcComprobanteDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        Me.tcComprobanteDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1237, 247)
        '
        'grupoDetalleCuentas
        '
        Appearance21.BackColor = System.Drawing.Color.White
        Appearance21.BackColor2 = System.Drawing.Color.White
        Me.grupoDetalleCuentas.ContentAreaAppearance = Appearance21
        Me.grupoDetalleCuentas.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.grupoDetalleCuentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupoDetalleCuentas.ExpandedSize = New System.Drawing.Size(1239, 250)
        Me.grupoDetalleCuentas.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.grupoDetalleCuentas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoDetalleCuentas.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.grupoDetalleCuentas.Location = New System.Drawing.Point(0, 190)
        Me.grupoDetalleCuentas.Name = "grupoDetalleCuentas"
        Me.grupoDetalleCuentas.Size = New System.Drawing.Size(1239, 250)
        Me.grupoDetalleCuentas.TabIndex = 1
        Me.grupoDetalleCuentas.Text = "Detalles de Cuentas"
        Me.grupoDetalleCuentas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.gridDetalleAsientoAnalisis)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.grupoMontaCarga)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.grupoDetalle)
        Me.UltraExpandableGroupBoxPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(1233, 227)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        '
        'gridDetalleAsientoAnalisis
        '
        Me.gridDetalleAsientoAnalisis.ContextMenuStrip = Me.MenuAnalisis
        Me.gridDetalleAsientoAnalisis.DataSource = Me.UltraDataSource4
        UltraGridColumn308.Header.VisiblePosition = 0
        UltraGridColumn308.Hidden = True
        UltraGridColumn309.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn309.Header.Caption = "Cuenta"
        UltraGridColumn309.Header.VisiblePosition = 1
        UltraGridColumn310.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn310.Header.Caption = "ItemGasto"
        UltraGridColumn310.Header.VisiblePosition = 3
        UltraGridColumn311.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn311.Header.Caption = "CentroCosto"
        UltraGridColumn311.Header.VisiblePosition = 4
        UltraGridColumn312.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn312.Header.Caption = "Trabajador"
        UltraGridColumn312.Header.VisiblePosition = 5
        UltraGridColumn313.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn313.Header.Caption = "Vehiculo"
        UltraGridColumn313.Header.VisiblePosition = 6
        UltraGridColumn314.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn314.Header.Caption = "Ruta"
        UltraGridColumn314.Header.VisiblePosition = 7
        UltraGridColumn315.Header.Caption = "Banco"
        UltraGridColumn315.Header.VisiblePosition = 8
        UltraGridColumn315.Hidden = True
        UltraGridColumn316.Header.Caption = "Analisis1"
        UltraGridColumn316.Header.VisiblePosition = 9
        UltraGridColumn316.Hidden = True
        UltraGridColumn317.Header.Caption = "Analisis2"
        UltraGridColumn317.Header.VisiblePosition = 10
        UltraGridColumn317.Hidden = True
        UltraGridColumn318.Header.VisiblePosition = 11
        UltraGridColumn318.Hidden = True
        UltraGridColumn319.Header.VisiblePosition = 12
        UltraGridColumn319.Hidden = True
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn320.CellAppearance = Appearance22
        UltraGridColumn320.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn320.Format = "#,##0.00"
        UltraGridColumn320.Header.VisiblePosition = 13
        UltraGridColumn320.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn321.Header.VisiblePosition = 14
        UltraGridColumn321.Hidden = True
        UltraGridColumn322.Header.VisiblePosition = 15
        UltraGridColumn322.Hidden = True
        UltraGridColumn323.Header.VisiblePosition = 16
        UltraGridColumn323.Hidden = True
        UltraGridColumn324.Header.VisiblePosition = 17
        UltraGridColumn324.Hidden = True
        UltraGridColumn325.Header.VisiblePosition = 18
        UltraGridColumn325.Hidden = True
        UltraGridColumn326.Header.VisiblePosition = 19
        UltraGridColumn326.Hidden = True
        UltraGridColumn327.Header.VisiblePosition = 20
        UltraGridColumn327.Hidden = True
        UltraGridColumn328.Header.VisiblePosition = 21
        UltraGridColumn328.Hidden = True
        UltraGridColumn329.Header.VisiblePosition = 22
        UltraGridColumn329.Hidden = True
        UltraGridColumn330.Header.VisiblePosition = 23
        UltraGridColumn330.Hidden = True
        UltraGridColumn331.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn331.Header.Caption = "Gasto Funcion"
        UltraGridColumn331.Header.VisiblePosition = 2
        UltraGridColumn332.Header.VisiblePosition = 24
        UltraGridColumn332.Hidden = True
        UltraGridColumn333.Header.VisiblePosition = 25
        UltraGridColumn333.Hidden = True
        UltraGridColumn334.Header.VisiblePosition = 26
        UltraGridColumn334.Hidden = True
        UltraGridColumn335.Header.VisiblePosition = 27
        UltraGridColumn335.Hidden = True
        UltraGridColumn336.Header.VisiblePosition = 28
        UltraGridColumn336.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313, UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn321, UltraGridColumn322, UltraGridColumn323, UltraGridColumn324, UltraGridColumn325, UltraGridColumn326, UltraGridColumn327, UltraGridColumn328, UltraGridColumn329, UltraGridColumn330, UltraGridColumn331, UltraGridColumn332, UltraGridColumn333, UltraGridColumn334, UltraGridColumn335, UltraGridColumn336})
        UltraGridBand6.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        SummarySettings1.DisplayFormat = "{0:#,##0.00}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance23
        UltraGridBand6.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand6.SummaryFooterCaption = "Total"
        Me.gridDetalleAsientoAnalisis.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.gridDetalleAsientoAnalisis.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDetalleAsientoAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDetalleAsientoAnalisis.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDetalleAsientoAnalisis.Location = New System.Drawing.Point(701, 0)
        Me.gridDetalleAsientoAnalisis.Name = "gridDetalleAsientoAnalisis"
        Me.gridDetalleAsientoAnalisis.Size = New System.Drawing.Size(532, 227)
        Me.gridDetalleAsientoAnalisis.TabIndex = 2
        '
        'MenuAnalisis
        '
        Me.MenuAnalisis.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuAnalisis.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarAnalisis})
        Me.MenuAnalisis.Name = "mnu_Transferencias"
        Me.MenuAnalisis.Size = New System.Drawing.Size(118, 26)
        '
        'EliminarAnalisis
        '
        Me.EliminarAnalisis.Name = "EliminarAnalisis"
        Me.EliminarAnalisis.Size = New System.Drawing.Size(117, 22)
        Me.EliminarAnalisis.Text = "Eliminar"
        '
        'UltraDataSource4
        '
        Me.UltraDataSource4.Band.Columns.AddRange(New Object() {UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101})
        '
        'grupoMontaCarga
        '
        Appearance24.BackColor = System.Drawing.Color.White
        Appearance24.BackColor2 = System.Drawing.Color.White
        Me.grupoMontaCarga.ContentAreaAppearance = Appearance24
        Me.grupoMontaCarga.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.grupoMontaCarga.Dock = System.Windows.Forms.DockStyle.Left
        Me.grupoMontaCarga.ExpandedSize = New System.Drawing.Size(381, 227)
        Me.grupoMontaCarga.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.grupoMontaCarga.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.grupoMontaCarga.Location = New System.Drawing.Point(320, 0)
        Me.grupoMontaCarga.Name = "grupoMontaCarga"
        Me.grupoMontaCarga.Size = New System.Drawing.Size(381, 227)
        Me.grupoMontaCarga.TabIndex = 1
        Me.grupoMontaCarga.Text = "Servivios Logisticos Terceros"
        Me.grupoMontaCarga.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.griLista)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.opcTerceros)
        Me.UltraExpandableGroupBoxPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel7.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel7.Name = "UltraExpandableGroupBoxPanel7"
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(358, 221)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        '
        'griLista
        '
        Me.griLista.DataSource = Me.ogdOperacionDetalle
        UltraGridColumn337.Header.VisiblePosition = 1
        UltraGridColumn337.Hidden = True
        UltraGridColumn338.Header.Caption = "Carreta"
        UltraGridColumn338.Header.VisiblePosition = 6
        UltraGridColumn338.Hidden = True
        UltraGridColumn338.Width = 60
        UltraGridColumn339.Header.VisiblePosition = 8
        UltraGridColumn339.Hidden = True
        UltraGridColumn339.Width = 150
        UltraGridColumn340.Header.Caption = "EstadoCarga"
        UltraGridColumn340.Header.VisiblePosition = 21
        UltraGridColumn340.Hidden = True
        UltraGridColumn340.Width = 75
        UltraGridColumn341.Header.VisiblePosition = 13
        UltraGridColumn341.Hidden = True
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn342.CellAppearance = Appearance25
        UltraGridColumn342.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn342.Header.Caption = "SubTotal"
        UltraGridColumn342.Header.VisiblePosition = 14
        UltraGridColumn342.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn342.Width = 60
        UltraGridColumn343.Header.VisiblePosition = 15
        UltraGridColumn343.Hidden = True
        UltraGridColumn343.Width = 100
        UltraGridColumn344.Header.VisiblePosition = 16
        UltraGridColumn344.Hidden = True
        Appearance26.TextVAlignAsString = "Middle"
        UltraGridColumn345.CellAppearance = Appearance26
        UltraGridColumn345.Header.Caption = "Operacion"
        UltraGridColumn345.Header.VisiblePosition = 2
        UltraGridColumn345.Hidden = True
        UltraGridColumn345.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn345.Width = 90
        UltraGridColumn346.Header.Caption = "Ruta"
        UltraGridColumn346.Header.VisiblePosition = 7
        UltraGridColumn346.Hidden = True
        UltraGridColumn346.Width = 150
        UltraGridColumn347.Header.VisiblePosition = 17
        UltraGridColumn347.Hidden = True
        UltraGridColumn348.Header.Caption = "Proveedor"
        UltraGridColumn348.Header.VisiblePosition = 12
        UltraGridColumn348.Hidden = True
        UltraGridColumn348.Width = 150
        UltraGridColumn349.Header.VisiblePosition = 18
        UltraGridColumn349.Hidden = True
        UltraGridColumn350.Header.VisiblePosition = 19
        UltraGridColumn350.Hidden = True
        UltraGridColumn351.Header.Caption = "Viaje"
        UltraGridColumn351.Header.VisiblePosition = 3
        UltraGridColumn351.Hidden = True
        UltraGridColumn351.Width = 90
        UltraGridColumn352.Header.Caption = "Orden Trabajo"
        UltraGridColumn352.Header.VisiblePosition = 10
        UltraGridColumn352.Hidden = True
        UltraGridColumn352.Width = 90
        UltraGridColumn353.Header.Caption = "Factura Prove."
        UltraGridColumn353.Header.VisiblePosition = 20
        UltraGridColumn353.Width = 125
        UltraGridColumn354.Header.VisiblePosition = 22
        UltraGridColumn354.Hidden = True
        UltraGridColumn355.Header.VisiblePosition = 23
        UltraGridColumn355.Hidden = True
        UltraGridColumn356.Header.Caption = "Flujo Caja"
        UltraGridColumn356.Header.VisiblePosition = 9
        UltraGridColumn356.Hidden = True
        UltraGridColumn356.Width = 150
        UltraGridColumn357.Header.VisiblePosition = 24
        UltraGridColumn357.Hidden = True
        UltraGridColumn358.Header.VisiblePosition = 25
        UltraGridColumn358.Hidden = True
        UltraGridColumn359.Header.Caption = "Tracto"
        UltraGridColumn359.Header.VisiblePosition = 5
        UltraGridColumn359.Width = 60
        UltraGridColumn360.Header.VisiblePosition = 26
        UltraGridColumn360.Hidden = True
        UltraGridColumn361.Header.VisiblePosition = 27
        UltraGridColumn361.Hidden = True
        UltraGridColumn362.Header.VisiblePosition = 28
        UltraGridColumn362.Hidden = True
        UltraGridColumn363.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn363.Header.Caption = "Sel"
        UltraGridColumn363.Header.VisiblePosition = 0
        UltraGridColumn363.Hidden = True
        UltraGridColumn363.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn363.Width = 30
        UltraGridColumn364.Header.VisiblePosition = 29
        UltraGridColumn364.Hidden = True
        UltraGridColumn365.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn365.Header.Caption = "F.Viaje"
        UltraGridColumn365.Header.VisiblePosition = 4
        UltraGridColumn365.Hidden = True
        UltraGridColumn365.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn365.Width = 60
        UltraGridColumn366.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn366.Header.Caption = "F.Orden T."
        UltraGridColumn366.Header.VisiblePosition = 11
        UltraGridColumn366.Hidden = True
        UltraGridColumn366.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn366.Width = 60
        UltraGridColumn367.Header.VisiblePosition = 30
        UltraGridColumn367.Hidden = True
        UltraGridColumn368.Header.VisiblePosition = 31
        UltraGridColumn368.Hidden = True
        UltraGridColumn369.Header.VisiblePosition = 32
        UltraGridColumn369.Hidden = True
        UltraGridColumn370.Header.VisiblePosition = 33
        UltraGridColumn370.Hidden = True
        UltraGridColumn371.Header.VisiblePosition = 34
        UltraGridColumn371.Hidden = True
        UltraGridColumn372.Header.VisiblePosition = 35
        UltraGridColumn372.Hidden = True
        UltraGridColumn373.Header.VisiblePosition = 36
        UltraGridColumn373.Hidden = True
        UltraGridColumn374.Header.VisiblePosition = 37
        UltraGridColumn374.Hidden = True
        UltraGridColumn375.Header.VisiblePosition = 38
        UltraGridColumn375.Hidden = True
        UltraGridColumn376.Header.VisiblePosition = 39
        UltraGridColumn376.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn337, UltraGridColumn338, UltraGridColumn339, UltraGridColumn340, UltraGridColumn341, UltraGridColumn342, UltraGridColumn343, UltraGridColumn344, UltraGridColumn345, UltraGridColumn346, UltraGridColumn347, UltraGridColumn348, UltraGridColumn349, UltraGridColumn350, UltraGridColumn351, UltraGridColumn352, UltraGridColumn353, UltraGridColumn354, UltraGridColumn355, UltraGridColumn356, UltraGridColumn357, UltraGridColumn358, UltraGridColumn359, UltraGridColumn360, UltraGridColumn361, UltraGridColumn362, UltraGridColumn363, UltraGridColumn364, UltraGridColumn365, UltraGridColumn366, UltraGridColumn367, UltraGridColumn368, UltraGridColumn369, UltraGridColumn370, UltraGridColumn371, UltraGridColumn372, UltraGridColumn373, UltraGridColumn374, UltraGridColumn375, UltraGridColumn376})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Appearance27.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.griLista.DisplayLayout.GroupByBox.Appearance = Appearance27
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance28
        Me.griLista.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance29.BackColor2 = System.Drawing.SystemColors.Control
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.PromptAppearance = Appearance29
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.MaxRowScrollRegions = 1
        Me.griLista.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.ImageList = Me.imagenes
        Me.griLista.Location = New System.Drawing.Point(0, 45)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(358, 176)
        Me.griLista.TabIndex = 1
        '
        'ogdOperacionDetalle
        '
        UltraDataColumn106.DataType = GetType(Double)
        UltraDataColumn107.DataType = GetType(Double)
        UltraDataColumn108.DataType = GetType(Boolean)
        UltraDataColumn109.DataType = GetType(Boolean)
        UltraDataColumn112.DataType = GetType(Double)
        UltraDataColumn113.DataType = GetType(Object)
        UltraDataColumn114.DataType = GetType(Double)
        UltraDataColumn119.DataType = GetType(Boolean)
        UltraDataColumn128.DataType = GetType(Boolean)
        Me.ogdOperacionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140})
        '
        'opcTerceros
        '
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.opcTerceros.Appearance = Appearance30
        Me.opcTerceros.BackColor = System.Drawing.Color.Transparent
        Me.opcTerceros.BackColorInternal = System.Drawing.Color.Transparent
        Me.opcTerceros.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcTerceros.CheckedIndex = 2
        Me.opcTerceros.Dock = System.Windows.Forms.DockStyle.Top
        Me.opcTerceros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcTerceros.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "SERVICIO DE ESTIBA Y DESESTIBA DE TERCEROS"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "SERVICIO TRANSPORTE DE CARGA CONTRATO DE TERCEROS"
        ValueListItem3.DataValue = "ValueListItem2"
        ValueListItem3.DisplayText = "NINGUNO SERVICIO"
        Me.opcTerceros.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.opcTerceros.Location = New System.Drawing.Point(0, 0)
        Me.opcTerceros.Name = "opcTerceros"
        Me.opcTerceros.Size = New System.Drawing.Size(358, 45)
        Me.opcTerceros.TabIndex = 0
        Me.opcTerceros.Text = "NINGUNO SERVICIO"
        '
        'grupoDetalle
        '
        Appearance31.BackColor = System.Drawing.Color.White
        Appearance31.BackColor2 = System.Drawing.Color.White
        Me.grupoDetalle.ContentAreaAppearance = Appearance31
        Me.grupoDetalle.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.grupoDetalle.Dock = System.Windows.Forms.DockStyle.Left
        Me.grupoDetalle.ExpandedSize = New System.Drawing.Size(320, 227)
        Me.grupoDetalle.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.grupoDetalle.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.grupoDetalle.Location = New System.Drawing.Point(0, 0)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Size = New System.Drawing.Size(320, 227)
        Me.grupoDetalle.TabIndex = 0
        Me.grupoDetalle.Text = "Detalle"
        Me.grupoDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta33)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.ChkVehiculoProper)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.DecMontoAn)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta34)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cmbAgregar)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboCuenta)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboGastonFuncion)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboItemGasto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta19)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta32)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta21)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboCentroCosto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboBanco)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta20)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta22)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboTrabajador)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboRuta)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta18)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboVehiculo)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta1)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta23)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboTipoCompra)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(297, 221)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'Etiqueta33
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta33.Appearance = Appearance32
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta33.Location = New System.Drawing.Point(69, 197)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta33.TabIndex = 17
        Me.Etiqueta33.Text = "Monto:"
        '
        'ChkVehiculoProper
        '
        Me.ChkVehiculoProper.AutoSize = True
        Me.ChkVehiculoProper.Location = New System.Drawing.Point(280, 133)
        Me.ChkVehiculoProper.Name = "ChkVehiculoProper"
        Me.ChkVehiculoProper.Size = New System.Drawing.Size(15, 14)
        Me.ChkVehiculoProper.TabIndex = 12
        Me.ChkVehiculoProper.UseVisualStyleBackColor = True
        '
        'DecMontoAn
        '
        Appearance33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecMontoAn.Appearance = Appearance33
        Me.DecMontoAn.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecMontoAn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecMontoAn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecMontoAn.Location = New System.Drawing.Point(109, 193)
        Me.DecMontoAn.MaskInput = "{double:8.4}"
        Me.DecMontoAn.Name = "DecMontoAn"
        Me.DecMontoAn.NullText = "0.00"
        Me.DecMontoAn.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecMontoAn.Size = New System.Drawing.Size(77, 22)
        Me.DecMontoAn.TabIndex = 17
        '
        'Etiqueta34
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta34.Appearance = Appearance34
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta34.Location = New System.Drawing.Point(2, 48)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta34.TabIndex = 2
        Me.Etiqueta34.Text = "Distribucion:"
        '
        'cmbAgregar
        '
        Appearance35.Image = "add.ico"
        Appearance35.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance35.TextHAlignAsString = "Left"
        Me.cmbAgregar.Appearance = Appearance35
        Me.cmbAgregar.BackColorInternal = System.Drawing.Color.Transparent
        Me.cmbAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmbAgregar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgregar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbAgregar.ImageList = Me.imagenes
        Me.cmbAgregar.Location = New System.Drawing.Point(216, 191)
        Me.cmbAgregar.Name = "cmbAgregar"
        Me.cmbAgregar.Size = New System.Drawing.Size(80, 30)
        Me.cmbAgregar.TabIndex = 22
        Me.cmbAgregar.Text = "Agregar"
        '
        'cboCuenta
        '
        Appearance36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuenta.Appearance = Appearance36
        Me.cboCuenta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuenta.DropDownListWidth = 400
        Me.cboCuenta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuenta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuenta.ImageList = Me.imagenes
        Me.cboCuenta.Location = New System.Drawing.Point(71, 26)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(225, 19)
        Me.cboCuenta.TabIndex = 1
        Me.cboCuenta.ValueMember = "Id"
        '
        'cboGastonFuncion
        '
        Appearance37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboGastonFuncion.Appearance = Appearance37
        Me.cboGastonFuncion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboGastonFuncion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGastonFuncion.DropDownListWidth = 400
        Me.cboGastonFuncion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboGastonFuncion.Enabled = False
        Me.cboGastonFuncion.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGastonFuncion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboGastonFuncion.ImageList = Me.imagenes
        Me.cboGastonFuncion.Location = New System.Drawing.Point(71, 46)
        Me.cboGastonFuncion.Name = "cboGastonFuncion"
        Me.cboGastonFuncion.Size = New System.Drawing.Size(225, 19)
        Me.cboGastonFuncion.TabIndex = 3
        Me.cboGastonFuncion.ValueMember = "Id"
        '
        'cboItemGasto
        '
        Appearance38.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.Appearance = Appearance38
        Me.cboItemGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboItemGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboItemGasto.DropDownListWidth = 400
        Me.cboItemGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboItemGasto.Enabled = False
        Me.cboItemGasto.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemGasto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.ImageList = Me.imagenes
        Me.cboItemGasto.Location = New System.Drawing.Point(71, 67)
        Me.cboItemGasto.Name = "cboItemGasto"
        Me.cboItemGasto.Size = New System.Drawing.Size(225, 19)
        Me.cboItemGasto.TabIndex = 5
        Me.cboItemGasto.ValueMember = "Id"
        '
        'Etiqueta19
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta19.Appearance = Appearance39
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta19.Location = New System.Drawing.Point(7, 69)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(64, 15)
        Me.Etiqueta19.TabIndex = 4
        Me.Etiqueta19.Text = "Item Gasto:"
        '
        'Etiqueta32
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta32.Appearance = Appearance40
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta32.Location = New System.Drawing.Point(26, 28)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta32.TabIndex = 0
        Me.Etiqueta32.Text = "Cuenta:"
        '
        'Etiqueta21
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance41
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(68, 175)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta21.TabIndex = 15
        Me.Etiqueta21.Text = "Banco:"
        '
        'cboCentroCosto
        '
        Appearance42.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroCosto.Appearance = Appearance42
        Me.cboCentroCosto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentroCosto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroCosto.DropDownListWidth = 400
        Me.cboCentroCosto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroCosto.Enabled = False
        Me.cboCentroCosto.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroCosto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroCosto.ImageList = Me.imagenes
        Me.cboCentroCosto.Location = New System.Drawing.Point(93, 88)
        Me.cboCentroCosto.Name = "cboCentroCosto"
        Me.cboCentroCosto.Size = New System.Drawing.Size(203, 19)
        Me.cboCentroCosto.TabIndex = 7
        Me.cboCentroCosto.ValueMember = "Id"
        '
        'cboBanco
        '
        Appearance43.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBanco.Appearance = Appearance43
        Me.cboBanco.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboBanco.DropDownListWidth = 400
        Me.cboBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboBanco.Enabled = False
        Me.cboBanco.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBanco.ImageList = Me.imagenes
        Me.cboBanco.Location = New System.Drawing.Point(109, 172)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(186, 19)
        Me.cboBanco.TabIndex = 16
        Me.cboBanco.ValueMember = "Id"
        '
        'Etiqueta20
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta20.Appearance = Appearance44
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta20.Location = New System.Drawing.Point(28, 91)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(63, 15)
        Me.Etiqueta20.TabIndex = 6
        Me.Etiqueta20.Text = "Cent. Cost.:"
        '
        'Etiqueta22
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta22.Appearance = Appearance45
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta22.Location = New System.Drawing.Point(76, 154)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta22.TabIndex = 13
        Me.Etiqueta22.Text = "Ruta:"
        '
        'cboTrabajador
        '
        Appearance46.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Appearance = Appearance46
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.DropDownListWidth = 400
        Me.cboTrabajador.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTrabajador.Enabled = False
        Me.cboTrabajador.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.ImageList = Me.imagenes
        Me.cboTrabajador.Location = New System.Drawing.Point(93, 109)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(203, 19)
        Me.cboTrabajador.TabIndex = 9
        Me.cboTrabajador.ValueMember = "Id"
        '
        'cboRuta
        '
        Appearance47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboRuta.Appearance = Appearance47
        Me.cboRuta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboRuta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRuta.DropDownListWidth = 400
        Me.cboRuta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboRuta.Enabled = False
        Me.cboRuta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRuta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboRuta.ImageList = Me.imagenes
        Me.cboRuta.Location = New System.Drawing.Point(109, 151)
        Me.cboRuta.Name = "cboRuta"
        Me.cboRuta.Size = New System.Drawing.Size(186, 19)
        Me.cboRuta.TabIndex = 14
        Me.cboRuta.ValueMember = "Id"
        '
        'Etiqueta18
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta18.Appearance = Appearance48
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta18.Location = New System.Drawing.Point(29, 111)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(63, 15)
        Me.Etiqueta18.TabIndex = 8
        Me.Etiqueta18.Text = "Trabajador:"
        '
        'cboVehiculo
        '
        Appearance49.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboVehiculo.Appearance = Appearance49
        Me.cboVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVehiculo.DropDownListWidth = 400
        Me.cboVehiculo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboVehiculo.Enabled = False
        Me.cboVehiculo.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboVehiculo.ImageList = Me.imagenes
        Me.cboVehiculo.Location = New System.Drawing.Point(93, 130)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(182, 19)
        Me.cboVehiculo.TabIndex = 11
        Me.cboVehiculo.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance50
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(9, 5)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta1.TabIndex = 19
        Me.Etiqueta1.Text = "T. Compra:"
        '
        'Etiqueta23
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta23.Appearance = Appearance51
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta23.Location = New System.Drawing.Point(40, 132)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta23.TabIndex = 10
        Me.Etiqueta23.Text = "Vehiculo:"
        '
        'cboTipoCompra
        '
        Appearance52.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoCompra.Appearance = Appearance52
        Me.cboTipoCompra.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoCompra.DropDownListWidth = 400
        Me.cboTipoCompra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoCompra.ImageList = Me.imagenes
        Me.cboTipoCompra.Location = New System.Drawing.Point(71, 2)
        Me.cboTipoCompra.Name = "cboTipoCompra"
        Me.cboTipoCompra.Size = New System.Drawing.Size(213, 22)
        Me.cboTipoCompra.TabIndex = 20
        Me.cboTipoCompra.ValueMember = "Id"
        '
        'UltraExpandableGroupBox1
        '
        Appearance53.BackColor = System.Drawing.Color.White
        Appearance53.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance53
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(1239, 190)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(1239, 190)
        Me.UltraExpandableGroupBox1.TabIndex = 0
        Me.UltraExpandableGroupBox1.Text = "Datos Generales"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.grupoVerificacion)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.grupoObligaciones)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.grupoCabeceraAsiento)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1233, 167)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'grupoVerificacion
        '
        Appearance54.BackColor = System.Drawing.Color.White
        Appearance54.BackColor2 = System.Drawing.Color.White
        Me.grupoVerificacion.ContentAreaAppearance = Appearance54
        Me.grupoVerificacion.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.grupoVerificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupoVerificacion.ExpandedSize = New System.Drawing.Size(240, 167)
        Me.grupoVerificacion.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.grupoVerificacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoVerificacion.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.grupoVerificacion.Location = New System.Drawing.Point(993, 0)
        Me.grupoVerificacion.Name = "grupoVerificacion"
        Me.grupoVerificacion.Size = New System.Drawing.Size(240, 167)
        Me.grupoVerificacion.TabIndex = 2
        Me.grupoVerificacion.Text = "Verificacion Documentos"
        Me.grupoVerificacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.grupoDoctRendir)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.grupoVerificar)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(217, 161)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'grupoDoctRendir
        '
        Appearance55.BackColor = System.Drawing.Color.White
        Appearance55.BackColor2 = System.Drawing.Color.White
        Me.grupoDoctRendir.ContentAreaAppearance = Appearance55
        Me.grupoDoctRendir.Controls.Add(Me.Etiqueta24)
        Me.grupoDoctRendir.Controls.Add(Me.btnAceptar)
        Me.grupoDoctRendir.Controls.Add(Me.cboAnalisis2)
        Me.grupoDoctRendir.Controls.Add(Me.btnCancelar)
        Me.grupoDoctRendir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupoDoctRendir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoDoctRendir.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoDoctRendir.Location = New System.Drawing.Point(0, 92)
        Me.grupoDoctRendir.Name = "grupoDoctRendir"
        Me.grupoDoctRendir.Size = New System.Drawing.Size(217, 69)
        Me.grupoDoctRendir.TabIndex = 1
        Me.grupoDoctRendir.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta24
        '
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta24.Location = New System.Drawing.Point(93, 21)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta24.TabIndex = 20
        Me.Etiqueta24.Text = "Analisis2:"
        Me.Etiqueta24.Visible = False
        '
        'btnAceptar
        '
        Appearance56.Image = 8
        Appearance56.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance56.TextHAlignAsString = "Left"
        Me.btnAceptar.Appearance = Appearance56
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.ImageList = Me.imagenes
        Me.btnAceptar.Location = New System.Drawing.Point(7, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 30)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        '
        'cboAnalisis2
        '
        Appearance57.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAnalisis2.Appearance = Appearance57
        Me.cboAnalisis2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAnalisis2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAnalisis2.DropDownListWidth = 400
        Me.cboAnalisis2.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAnalisis2.Enabled = False
        Me.cboAnalisis2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnalisis2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAnalisis2.ImageList = Me.imagenes
        Me.cboAnalisis2.Location = New System.Drawing.Point(148, 18)
        Me.cboAnalisis2.Name = "cboAnalisis2"
        Me.cboAnalisis2.Size = New System.Drawing.Size(103, 19)
        Me.cboAnalisis2.TabIndex = 21
        Me.cboAnalisis2.ValueMember = "Id"
        Me.cboAnalisis2.Visible = False
        '
        'btnCancelar
        '
        Appearance6.Image = 5
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance6.TextHAlignAsString = "Left"
        Me.btnCancelar.Appearance = Appearance6
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.ImageList = Me.imagenes
        Me.btnCancelar.Location = New System.Drawing.Point(7, 36)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 30)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        '
        'grupoVerificar
        '
        Appearance58.BackColor = System.Drawing.Color.White
        Appearance58.BackColor2 = System.Drawing.Color.White
        Me.grupoVerificar.ContentAreaAppearance = Appearance58
        Me.grupoVerificar.Controls.Add(Me.cboAnalisis1)
        Me.grupoVerificar.Controls.Add(Me.BtnVerificar)
        Me.grupoVerificar.Controls.Add(Me.Etiqueta25)
        Me.grupoVerificar.Controls.Add(Me.Lblsuario)
        Me.grupoVerificar.Controls.Add(Me.LblFeccha)
        Me.grupoVerificar.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupoVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoVerificar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoVerificar.Location = New System.Drawing.Point(0, 0)
        Me.grupoVerificar.Name = "grupoVerificar"
        Me.grupoVerificar.Size = New System.Drawing.Size(217, 92)
        Me.grupoVerificar.TabIndex = 0
        Me.grupoVerificar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboAnalisis1
        '
        Appearance59.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAnalisis1.Appearance = Appearance59
        Me.cboAnalisis1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAnalisis1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAnalisis1.DropDownListWidth = 400
        Me.cboAnalisis1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAnalisis1.Enabled = False
        Me.cboAnalisis1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnalisis1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAnalisis1.ImageList = Me.imagenes
        Me.cboAnalisis1.Location = New System.Drawing.Point(126, 27)
        Me.cboAnalisis1.Name = "cboAnalisis1"
        Me.cboAnalisis1.Size = New System.Drawing.Size(103, 19)
        Me.cboAnalisis1.TabIndex = 19
        Me.cboAnalisis1.ValueMember = "Id"
        Me.cboAnalisis1.Visible = False
        '
        'BtnVerificar
        '
        Appearance60.Image = 10
        Appearance60.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance60.TextHAlignAsString = "Left"
        Me.BtnVerificar.Appearance = Appearance60
        Me.BtnVerificar.Enabled = False
        Me.BtnVerificar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificar.ImageList = Me.imagenes
        Me.BtnVerificar.Location = New System.Drawing.Point(7, 6)
        Me.BtnVerificar.Name = "BtnVerificar"
        Me.BtnVerificar.Size = New System.Drawing.Size(80, 30)
        Me.BtnVerificar.TabIndex = 0
        Me.BtnVerificar.Text = "Verificar"
        '
        'Etiqueta25
        '
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta25.Location = New System.Drawing.Point(126, 11)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta25.TabIndex = 18
        Me.Etiqueta25.Text = "Analisis1:"
        Me.Etiqueta25.Visible = False
        '
        'Lblsuario
        '
        Appearance61.TextHAlignAsString = "Center"
        Appearance61.TextVAlignAsString = "Middle"
        Me.Lblsuario.Appearance = Appearance61
        Me.Lblsuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsuario.Location = New System.Drawing.Point(6, 40)
        Me.Lblsuario.Name = "Lblsuario"
        Me.Lblsuario.Size = New System.Drawing.Size(119, 21)
        Me.Lblsuario.TabIndex = 1
        Me.Lblsuario.Text = "-------"
        '
        'LblFeccha
        '
        Appearance62.TextHAlignAsString = "Center"
        Appearance62.TextVAlignAsString = "Middle"
        Me.LblFeccha.Appearance = Appearance62
        Me.LblFeccha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFeccha.Location = New System.Drawing.Point(6, 61)
        Me.LblFeccha.Name = "LblFeccha"
        Me.LblFeccha.Size = New System.Drawing.Size(119, 21)
        Me.LblFeccha.TabIndex = 2
        Me.LblFeccha.Text = "--/--/--"
        '
        'grupoObligaciones
        '
        Appearance63.BackColor = System.Drawing.Color.White
        Appearance63.BackColor2 = System.Drawing.Color.White
        Me.grupoObligaciones.ContentAreaAppearance = Appearance63
        Me.grupoObligaciones.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.grupoObligaciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.grupoObligaciones.ExpandedSize = New System.Drawing.Size(344, 167)
        Me.grupoObligaciones.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.grupoObligaciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoObligaciones.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.grupoObligaciones.Location = New System.Drawing.Point(649, 0)
        Me.grupoObligaciones.Name = "grupoObligaciones"
        Me.grupoObligaciones.Size = New System.Drawing.Size(344, 167)
        Me.grupoObligaciones.TabIndex = 1
        Me.grupoObligaciones.Text = "Obligaciones Finacieras"
        Me.grupoObligaciones.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.TabFinanciero)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Agrupacion3)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(321, 161)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'TabFinanciero
        '
        Me.TabFinanciero.CloseButtonLocation = Infragistics.Win.UltraWinTabs.TabCloseButtonLocation.None
        Me.TabFinanciero.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.TabFinanciero.Controls.Add(Me.UltraTabPageControl5)
        Me.TabFinanciero.Controls.Add(Me.UltraTabPageControl6)
        Me.TabFinanciero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFinanciero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabFinanciero.Location = New System.Drawing.Point(0, 20)
        Me.TabFinanciero.Name = "TabFinanciero"
        Me.TabFinanciero.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.TabFinanciero.Size = New System.Drawing.Size(321, 141)
        Me.TabFinanciero.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio2005
        Me.TabFinanciero.TabIndex = 1
        UltraTab9.TabPage = Me.UltraTabPageControl6
        UltraTab9.Text = "Leasing"
        UltraTab10.TabPage = Me.UltraTabPageControl5
        UltraTab10.Text = "Cupón Poliza"
        Me.TabFinanciero.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab10})
        Me.TabFinanciero.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(319, 120)
        '
        'Agrupacion3
        '
        Appearance94.BackColor = System.Drawing.Color.White
        Appearance94.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion3.ContentAreaAppearance = Appearance94
        Me.Agrupacion3.Controls.Add(Me.ChkCupon)
        Me.Agrupacion3.Controls.Add(Me.chkLeasing)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(321, 20)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ChkCupon
        '
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Me.ChkCupon.Appearance = Appearance95
        Me.ChkCupon.BackColor = System.Drawing.Color.Transparent
        Me.ChkCupon.BackColorInternal = System.Drawing.Color.Transparent
        Me.ChkCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCupon.ForeColor = System.Drawing.Color.Black
        Me.ChkCupon.Location = New System.Drawing.Point(93, 3)
        Me.ChkCupon.Name = "ChkCupon"
        Me.ChkCupon.Size = New System.Drawing.Size(123, 15)
        Me.ChkCupon.TabIndex = 1
        Me.ChkCupon.Text = "Cupon de Poliza"
        '
        'chkLeasing
        '
        Appearance96.ForeColor = System.Drawing.Color.Navy
        Me.chkLeasing.Appearance = Appearance96
        Me.chkLeasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLeasing.ForeColor = System.Drawing.Color.Black
        Me.chkLeasing.Location = New System.Drawing.Point(6, 3)
        Me.chkLeasing.Name = "chkLeasing"
        Me.chkLeasing.Size = New System.Drawing.Size(80, 14)
        Me.chkLeasing.TabIndex = 0
        Me.chkLeasing.Text = "Leasing"
        '
        'grupoCabeceraAsiento
        '
        Appearance97.BackColor = System.Drawing.Color.White
        Appearance97.BackColor2 = System.Drawing.Color.White
        Me.grupoCabeceraAsiento.ContentAreaAppearance = Appearance97
        Me.grupoCabeceraAsiento.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.grupoCabeceraAsiento.Dock = System.Windows.Forms.DockStyle.Left
        Me.grupoCabeceraAsiento.ExpandedSize = New System.Drawing.Size(649, 167)
        Me.grupoCabeceraAsiento.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.grupoCabeceraAsiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoCabeceraAsiento.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.grupoCabeceraAsiento.Location = New System.Drawing.Point(0, 0)
        Me.grupoCabeceraAsiento.Name = "grupoCabeceraAsiento"
        Me.grupoCabeceraAsiento.Size = New System.Drawing.Size(649, 167)
        Me.grupoCabeceraAsiento.TabIndex = 0
        Me.grupoCabeceraAsiento.Text = "Cabecera Asiento"
        Me.grupoCabeceraAsiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cbeCtaCte)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cbCaja)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cboTipoDocumento)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.FecVencimiento)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta28)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.EtiPeriodo)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta4)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.FecEmision)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta29)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Agrupacion2)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtNroDocumento)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta37)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta26)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.decTC)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtRuc)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta30)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta27)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cboMoneda)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta31)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta3)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtNroSerie)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(626, 161)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'cbeCtaCte
        '
        Me.cbeCtaCte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbeCtaCte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbeCtaCte.CheckedListSettings.ListSeparator = ","
        Me.cbeCtaCte.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cbeCtaCte.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cbeCtaCte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbeCtaCte.DropDownWidth = 400
        Me.cbeCtaCte.Location = New System.Drawing.Point(3, 115)
        Me.cbeCtaCte.Name = "cbeCtaCte"
        Me.cbeCtaCte.Size = New System.Drawing.Size(274, 23)
        Me.cbeCtaCte.TabIndex = 14
        '
        'cbCaja
        '
        Me.cbCaja.AutoSize = True
        Me.cbCaja.BackColor = System.Drawing.Color.Transparent
        Me.cbCaja.ForeColor = System.Drawing.Color.Navy
        Me.cbCaja.Location = New System.Drawing.Point(189, 95)
        Me.cbCaja.Name = "cbCaja"
        Me.cbCaja.Size = New System.Drawing.Size(72, 17)
        Me.cbCaja.TabIndex = 13
        Me.cbCaja.Text = "PagoCaja"
        Me.cbCaja.UseVisualStyleBackColor = False
        '
        'cboTipoDocumento
        '
        Appearance98.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDocumento.Appearance = Appearance98
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownListWidth = 400
        Me.cboTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDocumento.ImageList = Me.imagenes
        Me.cboTipoDocumento.Location = New System.Drawing.Point(64, 1)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(213, 22)
        Me.cboTipoDocumento.TabIndex = 1
        Me.cboTipoDocumento.ValueMember = "Id"
        '
        'FecVencimiento
        '
        Me.FecVencimiento.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecVencimiento.Location = New System.Drawing.Point(186, 70)
        Me.FecVencimiento.Name = "FecVencimiento"
        Me.FecVencimiento.Size = New System.Drawing.Size(91, 20)
        Me.FecVencimiento.TabIndex = 9
        '
        'Etiqueta28
        '
        Appearance99.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta28.Appearance = Appearance99
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta28.Location = New System.Drawing.Point(10, 51)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta28.TabIndex = 4
        Me.Etiqueta28.Text = "Numero:"
        '
        'EtiPeriodo
        '
        Appearance100.BackColor = System.Drawing.Color.Transparent
        Me.EtiPeriodo.Appearance = Appearance100
        Me.EtiPeriodo.AutoSize = True
        Me.EtiPeriodo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiPeriodo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.EtiPeriodo.Location = New System.Drawing.Point(284, 6)
        Me.EtiPeriodo.Name = "EtiPeriodo"
        Me.EtiPeriodo.Size = New System.Drawing.Size(91, 22)
        Me.EtiPeriodo.TabIndex = 21
        Me.EtiPeriodo.Text = "PERIODO:"
        '
        'Etiqueta4
        '
        Appearance101.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance101
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(145, 142)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(59, 15)
        Me.Etiqueta4.TabIndex = 17
        Me.Etiqueta4.Text = "T. Cambio:"
        '
        'FecEmision
        '
        Me.FecEmision.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecEmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecEmision.Location = New System.Drawing.Point(64, 70)
        Me.FecEmision.Name = "FecEmision"
        Me.FecEmision.Size = New System.Drawing.Size(79, 20)
        Me.FecEmision.TabIndex = 7
        '
        'Etiqueta29
        '
        Appearance102.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta29.Appearance = Appearance102
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta29.Location = New System.Drawing.Point(15, 73)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta29.TabIndex = 6
        Me.Etiqueta29.Text = "Emision:"
        '
        'Agrupacion2
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Me.Agrupacion2.Appearance = Appearance103
        Appearance104.BackColor = System.Drawing.Color.White
        Appearance104.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion2.ContentAreaAppearance = Appearance104
        Me.Agrupacion2.Controls.Add(Me.Etiqueta36)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta35)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion2.Controls.Add(Me.DecTotalDoc)
        Me.Agrupacion2.Controls.Add(Me.DecTotalImponible)
        Me.Agrupacion2.Controls.Add(Me.DecTotalIgv)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion2.Controls.Add(Me.DecNoGravadas)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion2.Controls.Add(Me.DecBi1)
        Me.Agrupacion2.Controls.Add(Me.DecBi2)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion2.Controls.Add(Me.DecISC)
        Me.Agrupacion2.Controls.Add(Me.DecBi3)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion2.Controls.Add(Me.DecOtrosTributos)
        Me.Agrupacion2.Controls.Add(Me.DecIgv2)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion2.Controls.Add(Me.DecIgv3)
        Me.Agrupacion2.Controls.Add(Me.DecIgv1)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(280, 33)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(342, 128)
        Me.Agrupacion2.TabIndex = 22
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta36
        '
        Appearance105.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta36.Appearance = Appearance105
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta36.Location = New System.Drawing.Point(107, 100)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(15, 15)
        Me.Etiqueta36.TabIndex = 16
        Me.Etiqueta36.Text = "T:"
        '
        'Etiqueta35
        '
        Appearance106.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta35.Appearance = Appearance106
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta35.Location = New System.Drawing.Point(11, 100)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(15, 15)
        Me.Etiqueta35.TabIndex = 7
        Me.Etiqueta35.Text = "T:"
        '
        'Etiqueta17
        '
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta17.Location = New System.Drawing.Point(202, 99)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta17.TabIndex = 24
        Me.Etiqueta17.Text = "Total Doc:"
        '
        'DecTotalDoc
        '
        Appearance107.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalDoc.Appearance = Appearance107
        Me.DecTotalDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalDoc.Location = New System.Drawing.Point(262, 96)
        Me.DecTotalDoc.MaskInput = "{double:7.3}"
        Me.DecTotalDoc.Name = "DecTotalDoc"
        Me.DecTotalDoc.NullText = "0.00"
        Me.DecTotalDoc.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalDoc.ReadOnly = True
        Me.DecTotalDoc.Size = New System.Drawing.Size(69, 22)
        Me.DecTotalDoc.TabIndex = 25
        '
        'DecTotalImponible
        '
        Appearance108.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalImponible.Appearance = Appearance108
        Me.DecTotalImponible.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalImponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalImponible.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalImponible.Location = New System.Drawing.Point(31, 95)
        Me.DecTotalImponible.MaskInput = "{double:7.3}"
        Me.DecTotalImponible.Name = "DecTotalImponible"
        Me.DecTotalImponible.NullText = "0.00"
        Me.DecTotalImponible.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalImponible.ReadOnly = True
        Me.DecTotalImponible.Size = New System.Drawing.Size(70, 21)
        Me.DecTotalImponible.TabIndex = 8
        '
        'DecTotalIgv
        '
        Appearance109.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalIgv.Appearance = Appearance109
        Me.DecTotalIgv.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalIgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalIgv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalIgv.Location = New System.Drawing.Point(126, 96)
        Me.DecTotalIgv.MaskInput = "{double:5.3}"
        Me.DecTotalIgv.Name = "DecTotalIgv"
        Me.DecTotalIgv.NullText = "0.00"
        Me.DecTotalIgv.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalIgv.ReadOnly = True
        Me.DecTotalIgv.Size = New System.Drawing.Size(65, 21)
        Me.DecTotalIgv.TabIndex = 17
        '
        'Etiqueta16
        '
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(205, 76)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta16.TabIndex = 22
        Me.Etiqueta16.Text = "No Grav.:"
        '
        'DecNoGravadas
        '
        Appearance110.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecNoGravadas.Appearance = Appearance110
        Me.DecNoGravadas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecNoGravadas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecNoGravadas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecNoGravadas.Location = New System.Drawing.Point(262, 72)
        Me.DecNoGravadas.MaskInput = "{double:7.3}"
        Me.DecNoGravadas.Name = "DecNoGravadas"
        Me.DecNoGravadas.NullText = "0.00"
        Me.DecNoGravadas.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecNoGravadas.Size = New System.Drawing.Size(69, 22)
        Me.DecNoGravadas.TabIndex = 23
        '
        'Etiqueta11
        '
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(126, 8)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(23, 15)
        Me.Etiqueta11.TabIndex = 9
        Me.Etiqueta11.Text = "IGV"
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(21, 8)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(81, 15)
        Me.Etiqueta6.TabIndex = 0
        Me.Etiqueta6.Text = "Base Imponible"
        '
        'DecBi1
        '
        Appearance111.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecBi1.Appearance = Appearance111
        Me.DecBi1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecBi1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecBi1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecBi1.Location = New System.Drawing.Point(31, 26)
        Me.DecBi1.MaskInput = "{double:7.3}"
        Me.DecBi1.Name = "DecBi1"
        Me.DecBi1.NullText = "0.00"
        Me.DecBi1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecBi1.Size = New System.Drawing.Size(70, 21)
        Me.DecBi1.TabIndex = 2
        '
        'DecBi2
        '
        Appearance112.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecBi2.Appearance = Appearance112
        Me.DecBi2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecBi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecBi2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecBi2.Location = New System.Drawing.Point(31, 49)
        Me.DecBi2.MaskInput = "{double:7.3}"
        Me.DecBi2.Name = "DecBi2"
        Me.DecBi2.NullText = "0.00"
        Me.DecBi2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecBi2.Size = New System.Drawing.Size(70, 21)
        Me.DecBi2.TabIndex = 4
        '
        'Etiqueta13
        '
        Appearance113.BackColor = System.Drawing.Color.Transparent
        Appearance113.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance113
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(12, 30)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(14, 15)
        Me.Etiqueta13.TabIndex = 1
        Me.Etiqueta13.Text = "1:"
        '
        'Etiqueta14
        '
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(197, 54)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta14.TabIndex = 20
        Me.Etiqueta14.Text = "Otros Trib.:"
        '
        'Etiqueta12
        '
        Appearance114.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance114
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(12, 54)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(14, 15)
        Me.Etiqueta12.TabIndex = 3
        Me.Etiqueta12.Text = "2:"
        '
        'DecISC
        '
        Appearance115.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecISC.Appearance = Appearance115
        Me.DecISC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecISC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecISC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecISC.Location = New System.Drawing.Point(262, 26)
        Me.DecISC.MaskInput = "{double:7.3}"
        Me.DecISC.Name = "DecISC"
        Me.DecISC.NullText = "0.00"
        Me.DecISC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecISC.Size = New System.Drawing.Size(69, 22)
        Me.DecISC.TabIndex = 19
        '
        'DecBi3
        '
        Appearance116.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecBi3.Appearance = Appearance116
        Me.DecBi3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecBi3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecBi3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecBi3.Location = New System.Drawing.Point(31, 72)
        Me.DecBi3.MaskInput = "{double:7.3}"
        Me.DecBi3.Name = "DecBi3"
        Me.DecBi3.NullText = "0.00"
        Me.DecBi3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecBi3.Size = New System.Drawing.Size(70, 21)
        Me.DecBi3.TabIndex = 6
        '
        'Etiqueta15
        '
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(231, 30)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(26, 15)
        Me.Etiqueta15.TabIndex = 18
        Me.Etiqueta15.Text = "ISC:"
        '
        'Etiqueta5
        '
        Appearance117.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance117
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(12, 77)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(14, 15)
        Me.Etiqueta5.TabIndex = 5
        Me.Etiqueta5.Text = "3:"
        '
        'DecOtrosTributos
        '
        Appearance118.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecOtrosTributos.Appearance = Appearance118
        Me.DecOtrosTributos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecOtrosTributos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecOtrosTributos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecOtrosTributos.Location = New System.Drawing.Point(262, 49)
        Me.DecOtrosTributos.MaskInput = "{double:7.3}"
        Me.DecOtrosTributos.Name = "DecOtrosTributos"
        Me.DecOtrosTributos.NullText = "0.00"
        Me.DecOtrosTributos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecOtrosTributos.Size = New System.Drawing.Size(69, 22)
        Me.DecOtrosTributos.TabIndex = 21
        '
        'DecIgv2
        '
        Appearance119.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIgv2.Appearance = Appearance119
        Me.DecIgv2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecIgv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecIgv2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIgv2.Location = New System.Drawing.Point(126, 49)
        Me.DecIgv2.MaskInput = "{double:5.3}"
        Me.DecIgv2.Name = "DecIgv2"
        Me.DecIgv2.NullText = "0.00"
        Me.DecIgv2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecIgv2.Size = New System.Drawing.Size(65, 21)
        Me.DecIgv2.TabIndex = 13
        '
        'Etiqueta8
        '
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance120
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(107, 77)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(14, 15)
        Me.Etiqueta8.TabIndex = 14
        Me.Etiqueta8.Text = "3:"
        '
        'Etiqueta10
        '
        Appearance121.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance121
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(107, 30)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(14, 15)
        Me.Etiqueta10.TabIndex = 10
        Me.Etiqueta10.Text = "1:"
        '
        'DecIgv3
        '
        Appearance122.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIgv3.Appearance = Appearance122
        Me.DecIgv3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecIgv3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecIgv3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIgv3.Location = New System.Drawing.Point(126, 72)
        Me.DecIgv3.MaskInput = "{double:5.3}"
        Me.DecIgv3.Name = "DecIgv3"
        Me.DecIgv3.NullText = "0.00"
        Me.DecIgv3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecIgv3.Size = New System.Drawing.Size(65, 21)
        Me.DecIgv3.TabIndex = 15
        '
        'DecIgv1
        '
        Appearance123.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIgv1.Appearance = Appearance123
        Me.DecIgv1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecIgv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecIgv1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIgv1.Location = New System.Drawing.Point(126, 26)
        Me.DecIgv1.MaskInput = "{double:5.3}"
        Me.DecIgv1.Name = "DecIgv1"
        Me.DecIgv1.NullText = "0.00"
        Me.DecIgv1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecIgv1.Size = New System.Drawing.Size(65, 21)
        Me.DecIgv1.TabIndex = 11
        '
        'Etiqueta9
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance124
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(107, 54)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(14, 15)
        Me.Etiqueta9.TabIndex = 12
        Me.Etiqueta9.Text = "2:"
        '
        'txtNroDocumento
        '
        Appearance125.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroDocumento.Appearance = Appearance125
        Me.txtNroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroDocumento.Location = New System.Drawing.Point(64, 47)
        Me.txtNroDocumento.MaxLength = 20
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(213, 22)
        Me.txtNroDocumento.TabIndex = 5
        '
        'Etiqueta37
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta37.Appearance = Appearance126
        Me.Etiqueta37.AutoSize = True
        Me.Etiqueta37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta37.Location = New System.Drawing.Point(147, 97)
        Me.Etiqueta37.Name = "Etiqueta37"
        Me.Etiqueta37.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta37.TabIndex = 12
        Me.Etiqueta37.Text = "<<Ruc"
        '
        'Etiqueta26
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta26.Appearance = Appearance127
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta26.Location = New System.Drawing.Point(10, 5)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta26.TabIndex = 0
        Me.Etiqueta26.Text = "Tipo Doc:"
        '
        'decTC
        '
        Appearance128.ForeColor = System.Drawing.Color.Black
        Me.decTC.Appearance = Appearance128
        Me.decTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTC.ForeColor = System.Drawing.Color.Black
        Me.decTC.FormatString = ""
        Me.decTC.Location = New System.Drawing.Point(206, 139)
        Me.decTC.MaskInput = "{double:6.4}"
        Me.decTC.Name = "decTC"
        Me.decTC.NullText = "0.00"
        Me.decTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTC.Size = New System.Drawing.Size(71, 22)
        Me.decTC.TabIndex = 18
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(64, 92)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(79, 22)
        Me.txtRuc.TabIndex = 11
        '
        'Etiqueta30
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta30.Appearance = Appearance129
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta30.Location = New System.Drawing.Point(148, 73)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta30.TabIndex = 8
        Me.Etiqueta30.Text = "Venc.:"
        '
        'Etiqueta27
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta27.Appearance = Appearance130
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta27.Location = New System.Drawing.Point(28, 28)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta27.TabIndex = 2
        Me.Etiqueta27.Text = "Serie:"
        '
        'cboMoneda
        '
        Appearance131.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance131
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(64, 139)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(75, 22)
        Me.cboMoneda.TabIndex = 16
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta31
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta31.Appearance = Appearance132
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(17, 96)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(45, 15)
        Me.Etiqueta31.TabIndex = 10
        Me.Etiqueta31.Text = "Cta Cte:"
        '
        'Etiqueta3
        '
        Appearance133.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance133
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(14, 142)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta3.TabIndex = 15
        Me.Etiqueta3.Text = "Moneda:"
        '
        'txtNroSerie
        '
        Appearance134.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroSerie.Appearance = Appearance134
        Me.txtNroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroSerie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroSerie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroSerie.Location = New System.Drawing.Point(64, 24)
        Me.txtNroSerie.MaxLength = 20
        Me.txtNroSerie.Name = "txtNroSerie"
        Me.txtNroSerie.Size = New System.Drawing.Size(213, 22)
        Me.txtNroSerie.TabIndex = 3
        '
        'UltraDataSource3
        '
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172})
        '
        'tcComprobanteCompra
        '
        Me.tcComprobanteCompra.Controls.Add(Me.UltraTabPageControl1)
        Me.tcComprobanteCompra.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcComprobanteCompra.Controls.Add(Me.UltraTabPageControl2)
        Me.tcComprobanteCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcComprobanteCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcComprobanteCompra.Location = New System.Drawing.Point(0, 0)
        Me.tcComprobanteCompra.Name = "tcComprobanteCompra"
        Me.tcComprobanteCompra.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcComprobanteCompra.Size = New System.Drawing.Size(1241, 733)
        Me.tcComprobanteCompra.TabIndex = 0
        UltraTab11.Key = "Lista"
        UltraTab11.TabPage = Me.UltraTabPageControl1
        UltraTab11.Text = "Lista"
        UltraTab12.Key = "Mantenimiento"
        UltraTab12.TabPage = Me.UltraTabPageControl2
        UltraTab12.Text = "Mantenimiento"
        Me.tcComprobanteCompra.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab11, UltraTab12})
        Me.tcComprobanteCompra.TabStop = False
        Me.tcComprobanteCompra.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1239, 710)
        '
        'object_855f81c2_3cbe_4b7a_881f_c489a882030f
        '
        Appearance143.ForeColor = System.Drawing.Color.Black
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Appearance = Appearance143
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.ForeColor = System.Drawing.Color.Black
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.FormatString = ""
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Location = New System.Drawing.Point(1, 0)
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Margin = New System.Windows.Forms.Padding(142, 43, 142, 43)
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.MaskInput = "nnnn"
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.MaxValue = 2020
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.MinValue = 2000
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Name = "object_855f81c2_3cbe_4b7a_881f_c489a882030f"
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.NullText = "0"
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Size = New System.Drawing.Size(2714, 21)
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.TabIndex = 0
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Value = 2013
        '
        'object_dad2a13d_427e_4777_870d_044a3363ce53
        '
        Appearance144.ForeColor = System.Drawing.Color.Black
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Appearance = Appearance144
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.ForeColor = System.Drawing.Color.Black
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.FormatString = ""
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Location = New System.Drawing.Point(1, 0)
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Margin = New System.Windows.Forms.Padding(191, 54, 191, 54)
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.MaskInput = "nnnn"
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.MaxValue = 2020
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.MinValue = 2000
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Name = "object_dad2a13d_427e_4777_870d_044a3363ce53"
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.NullText = "0"
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Size = New System.Drawing.Size(3620, 21)
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.TabIndex = 0
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Value = 2013
        '
        'object_b0dda586_e2d5_4d7e_8bc1_45e71784c992
        '
        Appearance145.ForeColor = System.Drawing.Color.Black
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Appearance = Appearance145
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.ForeColor = System.Drawing.Color.Black
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.FormatString = ""
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Location = New System.Drawing.Point(1, 0)
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Margin = New System.Windows.Forms.Padding(2567, 350, 2567, 350)
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.MaskInput = "nnnn"
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.MaxValue = 2020
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.MinValue = 2000
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Name = "object_b0dda586_e2d5_4d7e_8bc1_45e71784c992"
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.NullText = "0"
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Size = New System.Drawing.Size(48202, 21)
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.TabIndex = 0
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Value = 2013
        '
        'NumeroEntero3
        '
        Appearance146.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.Appearance = Appearance146
        Me.NumeroEntero3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero3.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.FormatString = ""
        Me.NumeroEntero3.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero3.Margin = New System.Windows.Forms.Padding(2567, 350, 2567, 350)
        Me.NumeroEntero3.MaskInput = "nnnn"
        Me.NumeroEntero3.MaxValue = 2020
        Me.NumeroEntero3.MinValue = 2000
        Me.NumeroEntero3.Name = "NumeroEntero3"
        Me.NumeroEntero3.NullText = "0"
        Me.NumeroEntero3.Size = New System.Drawing.Size(48202, 21)
        Me.NumeroEntero3.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero3.TabIndex = 0
        Me.NumeroEntero3.Value = 2013
        '
        'NumeroEntero4
        '
        Appearance147.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.Appearance = Appearance147
        Me.NumeroEntero4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero4.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.FormatString = ""
        Me.NumeroEntero4.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero4.Margin = New System.Windows.Forms.Padding(2567, 350, 2567, 350)
        Me.NumeroEntero4.MaskInput = "nnnn"
        Me.NumeroEntero4.MaxValue = 2020
        Me.NumeroEntero4.MinValue = 2000
        Me.NumeroEntero4.Name = "NumeroEntero4"
        Me.NumeroEntero4.NullText = "0"
        Me.NumeroEntero4.Size = New System.Drawing.Size(48202, 21)
        Me.NumeroEntero4.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero4.TabIndex = 0
        Me.NumeroEntero4.Value = 2011
        '
        'NumeroEntero5
        '
        Appearance148.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.Appearance = Appearance148
        Me.NumeroEntero5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero5.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.FormatString = ""
        Me.NumeroEntero5.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero5.Margin = New System.Windows.Forms.Padding(2567, 350, 2567, 350)
        Me.NumeroEntero5.MaskInput = "nnnn"
        Me.NumeroEntero5.MaxValue = 2020
        Me.NumeroEntero5.MinValue = 2000
        Me.NumeroEntero5.Name = "NumeroEntero5"
        Me.NumeroEntero5.NullText = "0"
        Me.NumeroEntero5.Size = New System.Drawing.Size(48202, 21)
        Me.NumeroEntero5.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero5.TabIndex = 0
        Me.NumeroEntero5.Value = 2011
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(422, 332)
        Me.ugb_Espera.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 3
        Me.ugb_Espera.Visible = False
        '
        'frm_ComprobanteCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(1241, 733)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.tcComprobanteCompra)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ComprobanteCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.GriComprobanteAsociado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        CType(Me.GriSeleccionaComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMovimientoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion10.ResumeLayout(False)
        CType(Me.mnuDetalleAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.agrObligación, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrObligación.ResumeLayout(False)
        Me.agrObligación.PerformLayout()
        CType(Me.decInteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalLeasing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecVenc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCodigoLeasing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.PanelCupon.ClientArea.ResumeLayout(False)
        Me.PanelCupon.ClientArea.PerformLayout()
        Me.PanelCupon.ResumeLayout(False)
        CType(Me.CboMonedaCupon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_SaldoCupon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboFilPoliza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumeroPoliza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_MontoOperaCupon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndMontoCupon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaCupon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.gridComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuCabecera.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.tcComprobanteDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcComprobanteDetalle.ResumeLayout(False)
        CType(Me.grupoDetalleCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDetalleCuentas.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        CType(Me.gridDetalleAsientoAnalisis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAnalisis.ResumeLayout(False)
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoMontaCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoMontaCarga.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opcTerceros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDetalle.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.PerformLayout()
        CType(Me.DecMontoAn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGastonFuncion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.grupoVerificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoVerificacion.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        CType(Me.grupoDoctRendir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDoctRendir.ResumeLayout(False)
        Me.grupoDoctRendir.PerformLayout()
        CType(Me.cboAnalisis2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoVerificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoVerificar.ResumeLayout(False)
        Me.grupoVerificar.PerformLayout()
        CType(Me.cboAnalisis1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoObligaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoObligaciones.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.TabFinanciero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFinanciero.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.ChkCupon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLeasing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoCabeceraAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoCabeceraAsiento.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.cbeCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.DecTotalDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTotalImponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTotalIgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecNoGravadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecBi1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecBi2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecISC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecBi3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecOtrosTributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecIgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecIgv3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecIgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcComprobanteCompra.ResumeLayout(False)
        CType(Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_dad2a13d_427e_4777_870d_044a3363ce53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcComprobanteCompra As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridComprobanteCompra As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tcComprobanteDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GriComprobanteAsociado As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents GriSeleccionaComprobante As ISL.Controles.Grilla
    Friend WithEvents Agrupacion10 As ISL.Controles.Agrupacion
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea4 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents DecBi1 As ISL.Controles.NumeroDecimal
    Friend WithEvents DecBi2 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents DecISC As ISL.Controles.NumeroDecimal
    Friend WithEvents DecBi3 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents DecOtrosTributos As ISL.Controles.NumeroDecimal
    Friend WithEvents DecIgv2 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents DecIgv3 As ISL.Controles.NumeroDecimal
    Friend WithEvents DecIgv1 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoCompra As ISL.Controles.Combo
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroDocumento As ISL.Controles.Texto
    Friend WithEvents decTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroSerie As ISL.Controles.Texto
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents MenuCabecera As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarCabecera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarCabecera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminaCabecera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents UltraToolbarsDockArea5 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents mnuDetalleAsiento As ISL.Controles.Menu
    Friend WithEvents UltraToolbarsDockArea6 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea7 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea8 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents DecTotalDoc As ISL.Controles.NumeroDecimal
    Friend WithEvents DecTotalImponible As ISL.Controles.NumeroDecimal
    Friend WithEvents DecTotalIgv As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents DecNoGravadas As ISL.Controles.NumeroDecimal
    Friend WithEvents gridDetalleAsientoAnalisis As ISL.Controles.Grilla
    Friend WithEvents UltraDataSource4 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents cboItemGasto As ISL.Controles.Combo
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents cboCentroCosto As ISL.Controles.Combo
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents cboBanco As ISL.Controles.Combo
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents cboRuta As ISL.Controles.Combo
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents cboVehiculo As ISL.Controles.Combo
    Friend WithEvents cmbAgregar As ISL.Controles.Boton
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents cboAnalisis2 As ISL.Controles.Combo
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents cboAnalisis1 As ISL.Controles.Combo
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuenta As ISL.Controles.Combo
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents DecMontoAn As ISL.Controles.NumeroDecimal
    Friend WithEvents MenuAnalisis As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarAnalisis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EtiPeriodo As ISL.Controles.Etiqueta
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ChkVehiculoProper As System.Windows.Forms.CheckBox
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents cboGastonFuncion As ISL.Controles.Combo
    Friend WithEvents btn_Extornar As ISL.Controles.Boton
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents txtRuc As ISL.Controles.Texto
    Friend WithEvents Etiqueta37 As ISL.Controles.Etiqueta
    Friend WithEvents agrObligación As ISL.Controles.Agrupacion
    Friend WithEvents chkLeasing As ISL.Controles.Chequear
    Friend WithEvents fecVenc As ISL.Controles.Fecha
    Friend WithEvents txtCuenta As ISL.Controles.Texto
    Friend WithEvents Etiqueta39 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta38 As ISL.Controles.Etiqueta
    Friend WithEvents cboCodigoLeasing As ISL.Controles.Combo
    Friend WithEvents Etiqueta41 As ISL.Controles.Etiqueta
    Friend WithEvents decSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta42 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda2 As ISL.Controles.Combo
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta43 As ISL.Controles.Etiqueta
    Friend WithEvents txtCuota As ISL.Controles.Texto
    Friend WithEvents Etiqueta44 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents decInteres As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents decTotalLeasing As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents etiTotalLeasing As ISL.Controles.Etiqueta
    Friend WithEvents FecEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents FecVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Etiqueta48 As ISL.Controles.Etiqueta
    Friend WithEvents ColorBloque As ISL.Controles.Colores
    Friend WithEvents CambiarPeriodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblFeccha As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Lblsuario As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BtnVerificar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents TabFinanciero As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Etiqueta40 As ISL.Controles.Etiqueta
    Friend WithEvents PanelCupon As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents CboMonedaCupon As ISL.Controles.Combo
    Friend WithEvents Etiqueta49 As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents nd_SaldoCupon As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents CboFilPoliza As ISL.Controles.ComboMaestros
    Friend WithEvents LblNumeroPoliza As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents TxtNumeroPoliza As ISL.Controles.Texto
    Friend WithEvents nd_MontoOperaCupon As ISL.Controles.NumeroDecimal
    Friend WithEvents LblMontoOperaCupon As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndMontoCupon As ISL.Controles.NumeroDecimal
    Friend WithEvents dtpFechaCupon As ISL.Controles.Fecha
    Friend WithEvents LblMontoCupon As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents LblVencimientoCupon As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BtnConsultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CmbMes As ISL.Controles.Combo
    Friend WithEvents Año As ISL.Win.Año
    Friend WithEvents object_855f81c2_3cbe_4b7a_881f_c489a882030f As ISL.Controles.NumeroEntero
    Friend WithEvents object_dad2a13d_427e_4777_870d_044a3363ce53 As ISL.Controles.NumeroEntero
    Friend WithEvents object_b0dda586_e2d5_4d7e_8bc1_45e71784c992 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero3 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero4 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero5 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents ChkCupon As ISL.Controles.Chequear
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grupoVerificacion As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grupoObligaciones As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grupoCabeceraAsiento As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents grupoDetalleCuentas As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grupoMontaCarga As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel7 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grupoDetalle As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grupoVerificar As ISL.Controles.Agrupacion
    Friend WithEvents grupoDoctRendir As ISL.Controles.Agrupacion
    Friend WithEvents ogdOperacionDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents griLista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Etiqueta52 As ISL.Controles.Etiqueta
    Private WithEvents cboProveedores As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents etiProveedor As ISL.Controles.Etiqueta
    Friend WithEvents opcTerceros As ISL.Controles.Opciones
    Friend WithEvents cbCaja As System.Windows.Forms.CheckBox
    Private WithEvents cbeCtaCte As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents EMovimientoDocumentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtpFechaEjercicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ugb_Espera As ISL.Win.Espere

End Class
