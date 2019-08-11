<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Pagos
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
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoCajaBanco")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mes")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndElectronico")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnexo")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoBien")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMotivo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OrdenCompra")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoCajaBanco")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mes")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndElectronico")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnexo")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoBien")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMotivo")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OrdenCompra")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoCajaBanco")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnexo")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMotivo")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenCompra")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoCajaBanco")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnexo")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMotivo")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenCompra")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Pagos))
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.MenuAgregados = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro = New ISL.Controles.Filtro(Me.components)
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.gridPago = New ISL.Controles.Grilla(Me.components)
        Me.gridPagoAgregado = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.decPagoNeto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decRetencion = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.chkRetencion = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtRuc = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProveedores = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.EtiImporteDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiImporteSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraPanel3 = New Infragistics.Win.Misc.UltraPanel()
        Me.OptPago = New System.Windows.Forms.RadioButton()
        Me.OptGanancia = New System.Windows.Forms.RadioButton()
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.chkCalculadora = New ISL.Controles.Chequear(Me.components)
        Me.UltraCalculatorDropDown1 = New Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown()
        Me.cboTipoGasto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaContable = New ISL.Controles.Combo(Me.components)
        Me.cboMedio = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha = New ISL.Controles.Fecha(Me.components)
        Me.txtVoucher = New ISL.Controles.Texto(Me.components)
        Me.cboCuentaBancaria = New ISL.Controles.Combo(Me.components)
        Me.cboFlujoGasto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.MenuAgregados.SuspendLayout()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.gridPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPagoAgregado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.decPagoNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        Me.UltraPanel3.ClientArea.SuspendLayout()
        Me.UltraPanel3.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.chkCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCalculatorDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlujoGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn11.DefaultValue = 0.0R
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn38.DataType = GetType(Boolean)
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43})
        Me.UltraDataSource2.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'Filtro
        '
        Me.Filtro.MenuSettings.RightAlignedMenus = True
        Me.Filtro.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2007
        '
        'UltraDataSource1
        '
        UltraDataColumn81.DataType = GetType(Boolean)
        UltraDataColumn82.DataType = GetType(Short)
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86})
        Me.UltraDataSource1.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.gridPago)
        Me.UltraGroupBox1.Controls.Add(Me.gridPagoAgregado)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 115)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1134, 513)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gridPago
        '
        Me.gridPago.DataSource = Me.UltraDataSource1
        Me.gridPago.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Periodo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 61
        UltraGridColumn3.Header.Caption = "TipoDoc"
        UltraGridColumn3.Header.VisiblePosition = 4
        UltraGridColumn3.Width = 74
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.Width = 37
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.Width = 101
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.Caption = "Fec Emi."
        UltraGridColumn6.Header.VisiblePosition = 9
        UltraGridColumn6.Width = 95
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.Caption = "Fec Venc."
        UltraGridColumn7.Header.VisiblePosition = 10
        UltraGridColumn7.Width = 96
        UltraGridColumn8.Format = "#,##0.00"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.MaskInput = "{double:9.4}"
        UltraGridColumn9.Format = "#,##0.00"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.MaskInput = "{double:9.4}"
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance1
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Format = "#,##0.00"
        UltraGridColumn10.Header.VisiblePosition = 13
        UltraGridColumn10.MaskInput = "{double:9.4}"
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.Width = 120
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance2
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Format = "#,##0.00"
        UltraGridColumn11.Header.VisiblePosition = 14
        UltraGridColumn11.MaskInput = "{double:9.4}"
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.Width = 114
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.Caption = "Proveedor"
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Width = 287
        UltraGridColumn13.Header.VisiblePosition = 17
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 18
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 19
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn16.Header.Caption = "Mon."
        UltraGridColumn16.Header.VisiblePosition = 11
        UltraGridColumn16.Width = 41
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance3
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn17.Format = "#,##0.0000"
        UltraGridColumn17.Header.VisiblePosition = 12
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn17.Width = 87
        UltraGridColumn18.Header.VisiblePosition = 20
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 15
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 16
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 21
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 22
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 23
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 24
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 25
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 26
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 27
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 28
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 29
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 30
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 31
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 32
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 33
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 34
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 2
        UltraGridColumn35.Width = 36
        UltraGridColumn36.Header.VisiblePosition = 35
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 36
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 37
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 38
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.Width = 66
        UltraGridColumn40.Header.VisiblePosition = 39
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.Width = 75
        UltraGridColumn41.Header.VisiblePosition = 40
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.Width = 86
        UltraGridColumn42.Header.VisiblePosition = 41
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.Width = 103
        UltraGridColumn43.Header.VisiblePosition = 42
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Width = 122
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43})
        Me.gridPago.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridPago.DisplayLayout.MaxColScrollRegions = 1
        Me.gridPago.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPago.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridPago.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridPago.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridPago.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.gridPago.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridPago.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridPago.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridPago.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridPago.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPago.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPago.Location = New System.Drawing.Point(3, 264)
        Me.gridPago.Name = "gridPago"
        Me.gridPago.Size = New System.Drawing.Size(1128, 246)
        Me.gridPago.TabIndex = 0
        Me.gridPago.Text = "Compras"
        '
        'gridPagoAgregado
        '
        Me.gridPagoAgregado.ContextMenuStrip = Me.MenuAgregados
        Me.gridPagoAgregado.DataSource = Me.UltraDataSource2
        Me.gridPagoAgregado.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn44.Header.VisiblePosition = 0
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 1
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.Caption = "TipoDoc"
        UltraGridColumn46.Header.VisiblePosition = 4
        UltraGridColumn46.Width = 71
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn47.Header.VisiblePosition = 5
        UltraGridColumn47.Width = 36
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn48.Header.VisiblePosition = 6
        UltraGridColumn48.Width = 87
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn49.Header.Caption = "Fec Emision"
        UltraGridColumn49.Header.VisiblePosition = 7
        UltraGridColumn49.Width = 86
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn50.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn50.Header.Caption = "Fec Venc."
        UltraGridColumn50.Header.VisiblePosition = 8
        UltraGridColumn50.Width = 85
        UltraGridColumn51.Format = "#,##0.00"
        UltraGridColumn51.Header.VisiblePosition = 13
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.MaskInput = "{double:9.4}"
        UltraGridColumn52.Format = "#,##0.00"
        UltraGridColumn52.Header.VisiblePosition = 14
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.MaskInput = "{double:9.4}"
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn53.CellAppearance = Appearance4
        UltraGridColumn53.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn53.Format = "#,##0.00"
        UltraGridColumn53.Header.VisiblePosition = 11
        UltraGridColumn53.MaskInput = "{double:9.4}"
        UltraGridColumn53.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn53.Width = 111
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn54.CellAppearance = Appearance5
        UltraGridColumn54.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn54.Format = "#,##0.00"
        UltraGridColumn54.Header.VisiblePosition = 12
        UltraGridColumn54.MaskInput = "{double:9.4}"
        UltraGridColumn54.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn54.Width = 87
        UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn55.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn55.Header.Caption = "Proveedor"
        UltraGridColumn55.Header.VisiblePosition = 3
        UltraGridColumn55.Width = 266
        UltraGridColumn56.Header.VisiblePosition = 15
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 16
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 17
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn59.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn59.Header.Caption = "Mon."
        UltraGridColumn59.Header.VisiblePosition = 9
        UltraGridColumn59.Width = 40
        UltraGridColumn60.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn60.CellAppearance = Appearance6
        UltraGridColumn60.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn60.Format = "#,##0.0000"
        UltraGridColumn60.Header.VisiblePosition = 10
        UltraGridColumn60.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn60.Width = 85
        UltraGridColumn61.Header.VisiblePosition = 18
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.Caption = "Detraccion"
        UltraGridColumn62.Header.VisiblePosition = 19
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 20
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 21
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 22
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 23
        UltraGridColumn66.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn67.CellAppearance = Appearance7
        UltraGridColumn67.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn67.Format = "#,##0.00"
        UltraGridColumn67.Header.Caption = "Monto a Pagar"
        UltraGridColumn67.Header.VisiblePosition = 24
        UltraGridColumn67.MaskInput = "{double:9.2}"
        UltraGridColumn67.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn67.Width = 97
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
        UltraGridColumn78.Header.VisiblePosition = 2
        UltraGridColumn78.Width = 37
        UltraGridColumn79.Header.VisiblePosition = 35
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 36
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 37
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 38
        UltraGridColumn82.Hidden = True
        UltraGridColumn82.Width = 92
        UltraGridColumn83.Header.VisiblePosition = 39
        UltraGridColumn83.Hidden = True
        UltraGridColumn83.Width = 91
        UltraGridColumn84.Header.VisiblePosition = 40
        UltraGridColumn84.Hidden = True
        UltraGridColumn84.Width = 91
        UltraGridColumn85.Header.VisiblePosition = 41
        UltraGridColumn85.Hidden = True
        UltraGridColumn85.Width = 91
        UltraGridColumn86.Header.VisiblePosition = 42
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.Width = 91
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86})
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPagoAgregado.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridPagoAgregado.DisplayLayout.MaxColScrollRegions = 1
        Me.gridPagoAgregado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPagoAgregado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridPagoAgregado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridPagoAgregado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridPagoAgregado.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.gridPagoAgregado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridPagoAgregado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridPagoAgregado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridPagoAgregado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridPagoAgregado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPagoAgregado.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridPagoAgregado.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridPagoAgregado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPagoAgregado.Location = New System.Drawing.Point(3, 3)
        Me.gridPagoAgregado.Name = "gridPagoAgregado"
        Me.gridPagoAgregado.Size = New System.Drawing.Size(1128, 261)
        Me.gridPagoAgregado.TabIndex = 0
        Me.gridPagoAgregado.Text = "Aplicacion de Pago"
        '
        'Agrupacion1
        '
        Appearance8.BackColor = System.Drawing.Color.White
        Appearance8.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance8
        Me.Agrupacion1.Controls.Add(Me.decPagoNeto)
        Me.Agrupacion1.Controls.Add(Me.decRetencion)
        Me.Agrupacion1.Controls.Add(Me.chkRetencion)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Controls.Add(Me.txtRuc)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta31)
        Me.Agrupacion1.Controls.Add(Me.cboProveedores)
        Me.Agrupacion1.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.Agrupacion1.Controls.Add(Me.cboTipoGasto)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.cboCuentaContable)
        Me.Agrupacion1.Controls.Add(Me.cboMedio)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.DecTC)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion1.Controls.Add(Me.Fecha)
        Me.Agrupacion1.Controls.Add(Me.txtVoucher)
        Me.Agrupacion1.Controls.Add(Me.cboCuentaBancaria)
        Me.Agrupacion1.Controls.Add(Me.cboFlujoGasto)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1134, 115)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Generar"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decPagoNeto
        '
        Appearance9.BackColor = System.Drawing.Color.LightCyan
        Me.decPagoNeto.Appearance = Appearance9
        Me.decPagoNeto.BackColor = System.Drawing.Color.LightCyan
        Me.decPagoNeto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decPagoNeto.Location = New System.Drawing.Point(755, 71)
        Me.decPagoNeto.MaskInput = "{double:9.4}"
        Me.decPagoNeto.Name = "decPagoNeto"
        Me.decPagoNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decPagoNeto.ReadOnly = True
        Me.decPagoNeto.Size = New System.Drawing.Size(100, 22)
        Me.decPagoNeto.TabIndex = 23
        '
        'decRetencion
        '
        Me.decRetencion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decRetencion.Location = New System.Drawing.Point(755, 43)
        Me.decRetencion.MaskInput = "{double:9.4}"
        Me.decRetencion.Name = "decRetencion"
        Me.decRetencion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decRetencion.ReadOnly = True
        Me.decRetencion.Size = New System.Drawing.Size(100, 22)
        Me.decRetencion.TabIndex = 22
        '
        'chkRetencion
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkRetencion.Appearance = Appearance10
        Me.chkRetencion.AutoSize = True
        Me.chkRetencion.BackColor = System.Drawing.Color.Transparent
        Me.chkRetencion.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkRetencion.Location = New System.Drawing.Point(755, 23)
        Me.chkRetencion.Name = "chkRetencion"
        Me.chkRetencion.Size = New System.Drawing.Size(75, 18)
        Me.chkRetencion.TabIndex = 21
        Me.chkRetencion.Text = "Retención:"
        '
        'Etiqueta5
        '
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance11
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(355, 71)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta5.TabIndex = 14
        Me.Etiqueta5.Text = "Cliente R.S.:"
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(424, 90)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(100, 22)
        Me.txtRuc.TabIndex = 17
        Me.txtRuc.TabStop = False
        '
        'Etiqueta31
        '
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance12
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(353, 94)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta31.TabIndex = 16
        Me.Etiqueta31.Text = "RUC Cliente:"
        '
        'cboProveedores
        '
        Me.cboProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedores.CheckedListSettings.ListSeparator = ","
        Me.cboProveedores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
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
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180})
        Me.cboProveedores.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cboProveedores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedores.DropDownWidth = 500
        Me.cboProveedores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedores.Location = New System.Drawing.Point(424, 66)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(325, 23)
        Me.cboProveedores.TabIndex = 15
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance13
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(250, 95)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(881, 17)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(250, 95)
        Me.UltraExpandableGroupBox2.TabIndex = 20
        Me.UltraExpandableGroupBox2.Text = "Verificacion de Totales"
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.EtiImporteDolares)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.EtiImporteSoles)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta3)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraPanel3)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta9)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraPanel1)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.chkCalculadora)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraCalculatorDropDown1)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(30, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(217, 89)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'EtiImporteDolares
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.EtiImporteDolares.Appearance = Appearance14
        Me.EtiImporteDolares.AutoSize = True
        Me.EtiImporteDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteDolares.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteDolares.Location = New System.Drawing.Point(74, 23)
        Me.EtiImporteDolares.Name = "EtiImporteDolares"
        Me.EtiImporteDolares.Size = New System.Drawing.Size(10, 15)
        Me.EtiImporteDolares.TabIndex = 3
        Me.EtiImporteDolares.Text = "0"
        '
        'EtiImporteSoles
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.EtiImporteSoles.Appearance = Appearance15
        Me.EtiImporteSoles.AutoSize = True
        Me.EtiImporteSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteSoles.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteSoles.Location = New System.Drawing.Point(74, 4)
        Me.EtiImporteSoles.Name = "EtiImporteSoles"
        Me.EtiImporteSoles.Size = New System.Drawing.Size(10, 15)
        Me.EtiImporteSoles.TabIndex = 1
        Me.EtiImporteSoles.Text = "0"
        '
        'Etiqueta3
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance16
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(2, 3)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Importe S/.:"
        '
        'UltraPanel3
        '
        Appearance17.BackColor = System.Drawing.Color.AliceBlue
        Me.UltraPanel3.Appearance = Appearance17
        Me.UltraPanel3.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4
        '
        'UltraPanel3.ClientArea
        '
        Me.UltraPanel3.ClientArea.Controls.Add(Me.OptPago)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.OptGanancia)
        Me.UltraPanel3.Location = New System.Drawing.Point(2, 44)
        Me.UltraPanel3.Name = "UltraPanel3"
        Me.UltraPanel3.Size = New System.Drawing.Size(125, 45)
        Me.UltraPanel3.TabIndex = 4
        '
        'OptPago
        '
        Me.OptPago.AutoSize = True
        Me.OptPago.Checked = True
        Me.OptPago.Location = New System.Drawing.Point(2, 2)
        Me.OptPago.Name = "OptPago"
        Me.OptPago.Size = New System.Drawing.Size(85, 17)
        Me.OptPago.TabIndex = 0
        Me.OptPago.TabStop = True
        Me.OptPago.Text = "Pago Normal"
        Me.OptPago.UseVisualStyleBackColor = True
        '
        'OptGanancia
        '
        Me.OptGanancia.AutoSize = True
        Me.OptGanancia.Location = New System.Drawing.Point(2, 22)
        Me.OptGanancia.Name = "OptGanancia"
        Me.OptGanancia.Size = New System.Drawing.Size(105, 17)
        Me.OptGanancia.TabIndex = 1
        Me.OptGanancia.Text = "Todo a Ganancia"
        Me.OptGanancia.UseVisualStyleBackColor = True
        '
        'Etiqueta9
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance18
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(3, 23)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta9.TabIndex = 2
        Me.Etiqueta9.Text = "Importe $.:"
        '
        'UltraPanel1
        '
        Appearance19.ImageBackground = CType(resources.GetObject("Appearance19.ImageBackground"), System.Drawing.Image)
        Me.UltraPanel1.Appearance = Appearance19
        Me.UltraPanel1.Location = New System.Drawing.Point(168, 33)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(50, 57)
        Me.UltraPanel1.TabIndex = 6
        '
        'chkCalculadora
        '
        Me.chkCalculadora.AutoSize = True
        Me.chkCalculadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCalculadora.ForeColor = System.Drawing.Color.Black
        Me.chkCalculadora.Location = New System.Drawing.Point(155, 12)
        Me.chkCalculadora.Name = "chkCalculadora"
        Me.chkCalculadora.Size = New System.Drawing.Size(62, 17)
        Me.chkCalculadora.TabIndex = 5
        Me.chkCalculadora.Text = "Habilitar"
        '
        'UltraCalculatorDropDown1
        '
        Me.UltraCalculatorDropDown1.Location = New System.Drawing.Point(133, 67)
        Me.UltraCalculatorDropDown1.Name = "UltraCalculatorDropDown1"
        Me.UltraCalculatorDropDown1.Size = New System.Drawing.Size(62, 22)
        Me.UltraCalculatorDropDown1.TabIndex = 7
        Me.UltraCalculatorDropDown1.Text = "UltraCalculatorDropDown1"
        Me.UltraCalculatorDropDown1.Visible = False
        '
        'cboTipoGasto
        '
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.cboTipoGasto.Appearance = Appearance20
        Me.cboTipoGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoGasto.DropDownListWidth = 350
        Me.cboTipoGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoGasto.ForeColor = System.Drawing.Color.Black
        Me.cboTipoGasto.Location = New System.Drawing.Point(424, 43)
        Me.cboTipoGasto.Name = "cboTipoGasto"
        Me.cboTipoGasto.Size = New System.Drawing.Size(325, 22)
        Me.cboTipoGasto.TabIndex = 13
        Me.cboTipoGasto.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance21
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(359, 47)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta2.TabIndex = 12
        Me.Etiqueta2.Text = "Tipo Gasto:"
        '
        'cboCuentaContable
        '
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Appearance = Appearance22
        Me.cboCuentaContable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaContable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaContable.DropDownListWidth = 400
        Me.cboCuentaContable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaContable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaContable.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Location = New System.Drawing.Point(94, 66)
        Me.cboCuentaContable.Name = "cboCuentaContable"
        Me.cboCuentaContable.Size = New System.Drawing.Size(250, 22)
        Me.cboCuentaContable.TabIndex = 7
        Me.cboCuentaContable.ValueMember = "Id"
        '
        'cboMedio
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.cboMedio.Appearance = Appearance23
        Me.cboMedio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMedio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMedio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedio.ForeColor = System.Drawing.Color.Black
        Me.cboMedio.Location = New System.Drawing.Point(94, 43)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(250, 22)
        Me.cboMedio.TabIndex = 5
        Me.cboMedio.ValueMember = "Id"
        '
        'Etiqueta8
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance24
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(6, 70)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(82, 15)
        Me.Etiqueta8.TabIndex = 6
        Me.Etiqueta8.Text = "Cta Ctble Pago:"
        '
        'Etiqueta1
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance25
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(22, 47)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta1.TabIndex = 4
        Me.Etiqueta1.Text = "Medio Pago:"
        '
        'DecTC
        '
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance26
        Appearance27.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance27
        Me.DecTC.ButtonsRight.Add(EditorButton1)
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(254, 19)
        Me.DecTC.MaskInput = "{double:5.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.ReadOnly = True
        Me.DecTC.Size = New System.Drawing.Size(90, 22)
        Me.DecTC.TabIndex = 3
        '
        'Etiqueta4
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance28
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(218, 23)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta4.TabIndex = 2
        Me.Etiqueta4.Text = "T.C. :"
        '
        'Fecha
        '
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Fecha.Appearance = Appearance29
        Me.Fecha.DateTime = New Date(2017, 1, 3, 0, 0, 0, 0)
        Me.Fecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Fecha.Location = New System.Drawing.Point(94, 19)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(96, 21)
        Me.Fecha.TabIndex = 1
        Me.Fecha.Value = New Date(2017, 1, 3, 0, 0, 0, 0)
        '
        'txtVoucher
        '
        Me.txtVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVoucher.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVoucher.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucher.Location = New System.Drawing.Point(649, 90)
        Me.txtVoucher.MaxLength = 20
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(100, 22)
        Me.txtVoucher.TabIndex = 19
        '
        'cboCuentaBancaria
        '
        Appearance30.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Appearance = Appearance30
        Me.cboCuentaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaBancaria.DropDownListWidth = 600
        Me.cboCuentaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancaria.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancaria.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Location = New System.Drawing.Point(94, 89)
        Me.cboCuentaBancaria.Name = "cboCuentaBancaria"
        Me.cboCuentaBancaria.Size = New System.Drawing.Size(250, 22)
        Me.cboCuentaBancaria.TabIndex = 9
        Me.cboCuentaBancaria.ValueMember = "Id"
        '
        'cboFlujoGasto
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoGasto.Appearance = Appearance31
        Me.cboFlujoGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboFlujoGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlujoGasto.DropDownListWidth = 400
        Me.cboFlujoGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlujoGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoGasto.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoGasto.Location = New System.Drawing.Point(424, 20)
        Me.cboFlujoGasto.Name = "cboFlujoGasto"
        Me.cboFlujoGasto.Size = New System.Drawing.Size(325, 22)
        Me.cboFlujoGasto.TabIndex = 11
        Me.cboFlujoGasto.ValueMember = "Id"
        '
        'Etiqueta18
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance32
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(50, 23)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta18.TabIndex = 0
        Me.Etiqueta18.Text = "Fecha:"
        '
        'Etiqueta17
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance33
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(597, 94)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta17.TabIndex = 18
        Me.Etiqueta17.Text = "Voucher:"
        '
        'Etiqueta11
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance34
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(17, 93)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(71, 15)
        Me.Etiqueta11.TabIndex = 8
        Me.Etiqueta11.Text = "Cta Bancaria:"
        '
        'Etiqueta6
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance35
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(348, 24)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(74, 15)
        Me.Etiqueta6.TabIndex = 10
        Me.Etiqueta6.Text = "Flujo de Caja:"
        '
        'frm_Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 628)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_Pagos"
        Me.Text = "Pagos"
        Me.MenuAgregados.ResumeLayout(False)
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.gridPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPagoAgregado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.decPagoNeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        Me.UltraPanel3.ClientArea.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.PerformLayout()
        Me.UltraPanel3.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.chkCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCalculatorDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlujoGasto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents gridPagoAgregado As ISL.Controles.Grilla
    Friend WithEvents gridPago As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents EtiImporteDolares As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents EtiImporteSoles As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Fecha As ISL.Controles.Fecha
    Friend WithEvents txtVoucher As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaBancaria As ISL.Controles.Combo
    Friend WithEvents cboFlujoGasto As ISL.Controles.Combo
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents cboCuentaContable As ISL.Controles.Combo
    Friend WithEvents cboMedio As ISL.Controles.Combo
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents MenuAgregados As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraCalculatorDropDown1 As Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown
    Friend WithEvents chkCalculadora As ISL.Controles.Chequear
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoGasto As ISL.Controles.Combo
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanel3 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents OptPago As System.Windows.Forms.RadioButton
    Friend WithEvents OptGanancia As System.Windows.Forms.RadioButton
    Private WithEvents cboProveedores As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtRuc As ISL.Controles.Texto
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro As ISL.Controles.Filtro
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents decRetencion As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents chkRetencion As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents decPagoNeto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
End Class
