<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BuscarDocumento
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
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim RowLayout1 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("fila")
        Dim RowLayoutColumnInfo1 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Id", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo2 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTipoDocumento", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo3 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Serie", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo4 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Numero", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo5 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SubTotal", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo6 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IGV", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo7 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Total", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo8 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoCambio", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo9 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdClienteProveedor", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo10 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndCompraVenta", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo11 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdMoneda", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo12 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Moneda", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo13 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaCreacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo14 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdUsuarioCrea", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo15 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo16 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaEmision", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo17 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaVencimiento", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo18 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Saldo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo19 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "MontoOperar", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo20 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdAsientoMovimiento", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo21 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdPeriodo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo22 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SaldoDetraccion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo23 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Neto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo24 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCuentaContable", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo25 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoPago", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo26 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTipoPago", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo27 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEstadoDocumento", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo28 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "EstadoDocumento", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo29 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "NombreProveedor", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo30 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "NombreDocumento", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo31 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCompra", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo32 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Seleccion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo33 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Percepcion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo34 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DiasVen", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo35 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "AbreviaturaMoneda", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo36 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Glosa", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo37 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndServicioMaterial", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo38 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndDetraccion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCompra")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim RowLayout2 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("fila")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOT")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOT")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOT")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaProgramacionIni")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaProgramacionFin")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngresoTaller")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioTrabajo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinTrabajo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTentativaSalida")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Calibracion")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdJefeTaller")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSupervisorMant")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaExterna")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorTipo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Auxilio")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Siniestro")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMantenimiento")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOT")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOT")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOT")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaProgramacionIni")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaProgramacionFin")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIngresoTaller")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicioTrabajo")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFinTrabajo")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaTentativaSalida")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Calibracion")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdJefeTaller")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSupervisorMant")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaExterna")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorTipo")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Auxilio")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Siniestro")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMantenimiento")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BuscarDocumento))
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridDocumentos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odListadoDocumentos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griObligaciones = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdListaObligaciones = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griOrdenTrabajo = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udsOrdenTrabajo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabLista = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion11 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.agrBusquedaDoc = New ISL.Controles.Agrupacion(Me.components)
        Me.rbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.rbNroDoc = New System.Windows.Forms.RadioButton()
        Me.gbNroDoc = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.gbDatosAdicionales = New ISL.Controles.Agrupacion(Me.components)
        Me.cmbEmpresa = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.rfFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbTipoDoc = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnBuscarDoc = New ISL.Controles.Boton(Me.components)
        Me.ficDocAosciados = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.gridDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griObligaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdListaObligaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griOrdenTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsOrdenTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.tabLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLista.SuspendLayout()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion11.SuspendLayout()
        CType(Me.agrBusquedaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusquedaDoc.SuspendLayout()
        CType(Me.gbNroDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNroDoc.SuspendLayout()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.cmbEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDocAosciados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDocAosciados.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.gridDocumentos)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(952, 271)
        '
        'gridDocumentos
        '
        Me.gridDocumentos.DataSource = Me.odListadoDocumentos
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 2
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn39.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn39.Header.VisiblePosition = 4
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Width = 52
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn40.Header.VisiblePosition = 5
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Width = 75
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance1
        UltraGridColumn41.Format = "#,##0.00"
        UltraGridColumn41.Header.VisiblePosition = 9
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(84, 0)
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance2
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn42.Format = "#,##0.00"
        UltraGridColumn42.Header.VisiblePosition = 10
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(75, 0)
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Width = 92
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn43.CellAppearance = Appearance3
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn43.Format = "#,##0.00"
        UltraGridColumn43.Header.VisiblePosition = 11
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(85, 0)
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn44.CellAppearance = Appearance4
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn44.Format = "#,##0.000"
        UltraGridColumn44.Header.Caption = "T.C."
        UltraGridColumn44.Header.VisiblePosition = 8
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(84, 0)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Width = 59
        UltraGridColumn45.Header.VisiblePosition = 12
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.Header.VisiblePosition = 13
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 14
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn48.Header.VisiblePosition = 7
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.Width = 77
        UltraGridColumn49.Header.VisiblePosition = 15
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 16
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 17
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn52.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn52.Header.Caption = "Fec. Emision"
        UltraGridColumn52.Header.VisiblePosition = 3
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn52.Width = 76
        UltraGridColumn53.Header.VisiblePosition = 18
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 19
        UltraGridColumn54.Hidden = True
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.Width = 84
        UltraGridColumn55.Header.VisiblePosition = 20
        UltraGridColumn55.Hidden = True
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.Header.VisiblePosition = 21
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 22
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 23
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 24
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 1
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.Header.VisiblePosition = 25
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 26
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 27
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn64.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn64.Header.Caption = "Estado"
        UltraGridColumn64.Header.VisiblePosition = 28
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn65.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn65.Header.Caption = "Empresa"
        UltraGridColumn65.Header.VisiblePosition = 6
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(282, 0)
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.Width = 212
        UltraGridColumn66.Header.VisiblePosition = 29
        UltraGridColumn66.Hidden = True
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn67.Header.VisiblePosition = 30
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 31
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 32
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 33
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 34
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 35
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 36
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 37
        UltraGridColumn74.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74})
        UltraGridBand1.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        RowLayoutColumnInfo3.OriginX = 2
        RowLayoutColumnInfo3.OriginY = 0
        RowLayoutColumnInfo3.PreferredCellSize = New System.Drawing.Size(68, 0)
        RowLayoutColumnInfo3.SpanX = 2
        RowLayoutColumnInfo3.SpanY = 2
        RowLayoutColumnInfo4.OriginX = 4
        RowLayoutColumnInfo4.OriginY = 0
        RowLayoutColumnInfo4.PreferredCellSize = New System.Drawing.Size(81, 0)
        RowLayoutColumnInfo4.SpanX = 2
        RowLayoutColumnInfo4.SpanY = 2
        RowLayoutColumnInfo5.OriginX = 10
        RowLayoutColumnInfo5.OriginY = 0
        RowLayoutColumnInfo5.PreferredCellSize = New System.Drawing.Size(84, 0)
        RowLayoutColumnInfo5.SpanX = 2
        RowLayoutColumnInfo5.SpanY = 2
        RowLayoutColumnInfo6.OriginX = 12
        RowLayoutColumnInfo6.OriginY = 0
        RowLayoutColumnInfo6.PreferredCellSize = New System.Drawing.Size(75, 0)
        RowLayoutColumnInfo6.SpanX = 2
        RowLayoutColumnInfo6.SpanY = 2
        RowLayoutColumnInfo7.OriginX = 14
        RowLayoutColumnInfo7.OriginY = 0
        RowLayoutColumnInfo7.PreferredCellSize = New System.Drawing.Size(85, 0)
        RowLayoutColumnInfo7.SpanX = 2
        RowLayoutColumnInfo7.SpanY = 2
        RowLayoutColumnInfo8.OriginX = 16
        RowLayoutColumnInfo8.OriginY = 0
        RowLayoutColumnInfo8.PreferredCellSize = New System.Drawing.Size(84, 0)
        RowLayoutColumnInfo8.SpanX = 2
        RowLayoutColumnInfo8.SpanY = 2
        RowLayoutColumnInfo9.OriginX = 20
        RowLayoutColumnInfo9.OriginY = 0
        RowLayoutColumnInfo9.SpanX = 2
        RowLayoutColumnInfo9.SpanY = 2
        RowLayoutColumnInfo12.OriginX = 8
        RowLayoutColumnInfo12.OriginY = 0
        RowLayoutColumnInfo12.PreferredCellSize = New System.Drawing.Size(69, 0)
        RowLayoutColumnInfo12.SpanX = 2
        RowLayoutColumnInfo12.SpanY = 2
        RowLayoutColumnInfo16.OriginX = 18
        RowLayoutColumnInfo16.OriginY = 0
        RowLayoutColumnInfo16.SpanX = 2
        RowLayoutColumnInfo16.SpanY = 2
        RowLayoutColumnInfo18.OriginX = 20
        RowLayoutColumnInfo18.OriginY = 0
        RowLayoutColumnInfo18.SpanX = 2
        RowLayoutColumnInfo18.SpanY = 2
        RowLayoutColumnInfo19.OriginX = 30
        RowLayoutColumnInfo19.OriginY = 0
        RowLayoutColumnInfo19.SpanX = 2
        RowLayoutColumnInfo19.SpanY = 2
        RowLayoutColumnInfo24.OriginX = 0
        RowLayoutColumnInfo24.OriginY = 0
        RowLayoutColumnInfo24.ParentGroupIndex = 4
        RowLayoutColumnInfo24.ParentGroupKey = "NewGroup4"
        RowLayoutColumnInfo24.SpanX = 2
        RowLayoutColumnInfo24.SpanY = 2
        RowLayoutColumnInfo28.OriginX = 22
        RowLayoutColumnInfo28.OriginY = 0
        RowLayoutColumnInfo28.SpanX = 2
        RowLayoutColumnInfo28.SpanY = 2
        RowLayoutColumnInfo29.OriginX = 6
        RowLayoutColumnInfo29.OriginY = 0
        RowLayoutColumnInfo29.PreferredCellSize = New System.Drawing.Size(282, 0)
        RowLayoutColumnInfo29.SpanX = 2
        RowLayoutColumnInfo29.SpanY = 2
        RowLayoutColumnInfo30.OriginX = 0
        RowLayoutColumnInfo30.OriginY = 0
        RowLayoutColumnInfo30.SpanX = 2
        RowLayoutColumnInfo30.SpanY = 2
        RowLayout1.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo1, RowLayoutColumnInfo2, RowLayoutColumnInfo3, RowLayoutColumnInfo4, RowLayoutColumnInfo5, RowLayoutColumnInfo6, RowLayoutColumnInfo7, RowLayoutColumnInfo8, RowLayoutColumnInfo9, RowLayoutColumnInfo10, RowLayoutColumnInfo11, RowLayoutColumnInfo12, RowLayoutColumnInfo13, RowLayoutColumnInfo14, RowLayoutColumnInfo15, RowLayoutColumnInfo16, RowLayoutColumnInfo17, RowLayoutColumnInfo18, RowLayoutColumnInfo19, RowLayoutColumnInfo20, RowLayoutColumnInfo21, RowLayoutColumnInfo22, RowLayoutColumnInfo23, RowLayoutColumnInfo24, RowLayoutColumnInfo25, RowLayoutColumnInfo26, RowLayoutColumnInfo27, RowLayoutColumnInfo28, RowLayoutColumnInfo29, RowLayoutColumnInfo30, RowLayoutColumnInfo31, RowLayoutColumnInfo32, RowLayoutColumnInfo33, RowLayoutColumnInfo34, RowLayoutColumnInfo35, RowLayoutColumnInfo36, RowLayoutColumnInfo37, RowLayoutColumnInfo38})
        RowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout
        UltraGridBand1.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.gridDocumentos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridDocumentos.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDocumentos.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridDocumentos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDocumentos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gridDocumentos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDocumentos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridDocumentos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDocumentos.DisplayLayout.Override.FormulaRowIndexSource = Infragistics.Win.UltraWinGrid.FormulaRowIndexSource.ListIndex
        Me.gridDocumentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridDocumentos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.ListIndex
        Me.gridDocumentos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridDocumentos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridDocumentos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDocumentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDocumentos.Location = New System.Drawing.Point(0, 0)
        Me.gridDocumentos.Name = "gridDocumentos"
        Me.gridDocumentos.Size = New System.Drawing.Size(952, 271)
        Me.gridDocumentos.TabIndex = 6
        '
        'odListadoDocumentos
        '
        UltraDataColumn38.DataType = GetType(Boolean)
        Me.odListadoDocumentos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griObligaciones)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(952, 271)
        '
        'griObligaciones
        '
        Me.griObligaciones.DataSource = Me.ogdListaObligaciones
        UltraGridBand2.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        RowLayout2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout
        UltraGridBand2.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout2})
        UltraGridBand2.SummaryFooterCaption = ""
        Me.griObligaciones.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griObligaciones.DisplayLayout.MaxColScrollRegions = 1
        Me.griObligaciones.DisplayLayout.MaxRowScrollRegions = 1
        Me.griObligaciones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griObligaciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griObligaciones.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griObligaciones.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griObligaciones.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griObligaciones.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griObligaciones.DisplayLayout.Override.FormulaRowIndexSource = Infragistics.Win.UltraWinGrid.FormulaRowIndexSource.ListIndex
        Me.griObligaciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griObligaciones.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.ListIndex
        Me.griObligaciones.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griObligaciones.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griObligaciones.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griObligaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griObligaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griObligaciones.Location = New System.Drawing.Point(0, 0)
        Me.griObligaciones.Name = "griObligaciones"
        Me.griObligaciones.Size = New System.Drawing.Size(952, 271)
        Me.griObligaciones.TabIndex = 7
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griOrdenTrabajo)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(952, 271)
        '
        'griOrdenTrabajo
        '
        Me.griOrdenTrabajo.DataSource = Me.udsOrdenTrabajo
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenTrabajo.DisplayLayout.Appearance = Appearance5
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 130
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 120
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 111
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Width = 347
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
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
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25})
        Me.griOrdenTrabajo.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griOrdenTrabajo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenTrabajo.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenTrabajo.DisplayLayout.GroupByBox.Appearance = Appearance6
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenTrabajo.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance7
        Me.griOrdenTrabajo.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenTrabajo.DisplayLayout.GroupByBox.Hidden = True
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance8.BackColor2 = System.Drawing.SystemColors.Control
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenTrabajo.DisplayLayout.GroupByBox.PromptAppearance = Appearance8
        Me.griOrdenTrabajo.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenTrabajo.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenTrabajo.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griOrdenTrabajo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenTrabajo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenTrabajo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenTrabajo.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griOrdenTrabajo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenTrabajo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griOrdenTrabajo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenTrabajo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenTrabajo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griOrdenTrabajo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenTrabajo.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.griOrdenTrabajo.Name = "griOrdenTrabajo"
        Me.griOrdenTrabajo.Size = New System.Drawing.Size(952, 271)
        Me.griOrdenTrabajo.TabIndex = 315
        '
        'udsOrdenTrabajo
        '
        UltraDataColumn43.DataType = GetType(Date)
        UltraDataColumn44.DataType = GetType(Date)
        UltraDataColumn45.DataType = GetType(Date)
        UltraDataColumn46.DataType = GetType(Date)
        UltraDataColumn47.DataType = GetType(Date)
        UltraDataColumn48.DataType = GetType(Date)
        UltraDataColumn49.DataType = GetType(Boolean)
        UltraDataColumn55.DataType = GetType(Boolean)
        UltraDataColumn56.DataType = GetType(Boolean)
        UltraDataColumn57.DataType = GetType(Boolean)
        UltraDataColumn59.DataType = GetType(Date)
        Me.udsOrdenTrabajo.Band.Columns.AddRange(New Object() {UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.tabLista)
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion11)
        Me.UltraTabPageControl4.Controls.Add(Me.agrBusquedaDoc)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(954, 451)
        '
        'tabLista
        '
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.White
        Me.tabLista.ClientAreaAppearance = Appearance9
        Me.tabLista.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.tabLista.Controls.Add(Me.UltraTabPageControl3)
        Me.tabLista.Controls.Add(Me.UltraTabPageControl5)
        Me.tabLista.Controls.Add(Me.UltraTabPageControl1)
        Me.tabLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabLista.Location = New System.Drawing.Point(0, 119)
        Me.tabLista.Name = "tabLista"
        Me.tabLista.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.tabLista.Size = New System.Drawing.Size(954, 294)
        Me.tabLista.TabIndex = 28
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Documentos"
        UltraTab2.TabPage = Me.UltraTabPageControl5
        UltraTab2.Text = "Obligaciones"
        UltraTab4.TabPage = Me.UltraTabPageControl1
        UltraTab4.Text = "OrdenTrabajo"
        Me.tabLista.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab4})
        Me.tabLista.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(952, 271)
        '
        'Agrupacion11
        '
        Me.Agrupacion11.Controls.Add(Me.btnCancelar)
        Me.Agrupacion11.Controls.Add(Me.btnAceptar)
        Me.Agrupacion11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Agrupacion11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion11.Location = New System.Drawing.Point(0, 413)
        Me.Agrupacion11.Name = "Agrupacion11"
        Me.Agrupacion11.Size = New System.Drawing.Size(954, 38)
        Me.Agrupacion11.TabIndex = 27
        Me.Agrupacion11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnCancelar
        '
        Appearance10.Image = 2
        Me.btnCancelar.Appearance = Appearance10
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.ImageList = Me.imagenes
        Me.btnCancelar.Location = New System.Drawing.Point(853, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.btnCancelar.TabIndex = 342
        Me.btnCancelar.Text = "&Cancelar"
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
        'btnAceptar
        '
        Appearance11.Image = 8
        Me.btnAceptar.Appearance = Appearance11
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.ImageList = Me.imagenes
        Me.btnAceptar.Location = New System.Drawing.Point(757, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 30)
        Me.btnAceptar.TabIndex = 341
        Me.btnAceptar.Text = "&Aceptar"
        '
        'agrBusquedaDoc
        '
        Me.agrBusquedaDoc.Controls.Add(Me.rbDatosAdicionales)
        Me.agrBusquedaDoc.Controls.Add(Me.rbNroDoc)
        Me.agrBusquedaDoc.Controls.Add(Me.gbNroDoc)
        Me.agrBusquedaDoc.Controls.Add(Me.gbDatosAdicionales)
        Me.agrBusquedaDoc.Controls.Add(Me.btnBuscarDoc)
        Me.agrBusquedaDoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusquedaDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusquedaDoc.ForeColor = System.Drawing.Color.Black
        Me.agrBusquedaDoc.Location = New System.Drawing.Point(0, 0)
        Me.agrBusquedaDoc.Name = "agrBusquedaDoc"
        Me.agrBusquedaDoc.Size = New System.Drawing.Size(954, 119)
        Me.agrBusquedaDoc.TabIndex = 0
        Me.agrBusquedaDoc.Text = "Filtros de Búsqueda"
        Me.agrBusquedaDoc.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rbDatosAdicionales
        '
        Me.rbDatosAdicionales.AutoSize = True
        Me.rbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rbDatosAdicionales.Checked = True
        Me.rbDatosAdicionales.Location = New System.Drawing.Point(17, 17)
        Me.rbDatosAdicionales.Name = "rbDatosAdicionales"
        Me.rbDatosAdicionales.Size = New System.Drawing.Size(108, 17)
        Me.rbDatosAdicionales.TabIndex = 0
        Me.rbDatosAdicionales.TabStop = True
        Me.rbDatosAdicionales.Text = "Datos Generales:"
        Me.rbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'rbNroDoc
        '
        Me.rbNroDoc.AutoSize = True
        Me.rbNroDoc.BackColor = System.Drawing.Color.Transparent
        Me.rbNroDoc.Location = New System.Drawing.Point(402, 17)
        Me.rbNroDoc.Name = "rbNroDoc"
        Me.rbNroDoc.Size = New System.Drawing.Size(98, 17)
        Me.rbNroDoc.TabIndex = 1
        Me.rbNroDoc.TabStop = True
        Me.rbNroDoc.Text = "N° Documento:"
        Me.rbNroDoc.UseVisualStyleBackColor = False
        '
        'gbNroDoc
        '
        Me.gbNroDoc.Controls.Add(Me.Etiqueta1)
        Me.gbNroDoc.Controls.Add(Me.txtSerie)
        Me.gbNroDoc.Controls.Add(Me.txtNumero)
        Me.gbNroDoc.Enabled = False
        Me.gbNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNroDoc.ForeColor = System.Drawing.Color.Black
        Me.gbNroDoc.Location = New System.Drawing.Point(394, 27)
        Me.gbNroDoc.Name = "gbNroDoc"
        Me.gbNroDoc.Size = New System.Drawing.Size(210, 56)
        Me.gbNroDoc.TabIndex = 2
        Me.gbNroDoc.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta1
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance12
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(73, 21)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(8, 15)
        Me.Etiqueta1.TabIndex = 356
        Me.Etiqueta1.Text = "-"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(27, 17)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(42, 21)
        Me.txtSerie.TabIndex = 0
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(83, 17)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 21)
        Me.txtNumero.TabIndex = 1
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.Controls.Add(Me.cmbEmpresa)
        Me.gbDatosAdicionales.Controls.Add(Me.UltraLabel12)
        Me.gbDatosAdicionales.Controls.Add(Me.rfFechaHasta)
        Me.gbDatosAdicionales.Controls.Add(Me.rfFechaDesde)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta21)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta3)
        Me.gbDatosAdicionales.Controls.Add(Me.cmbTipoDoc)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta7)
        Me.gbDatosAdicionales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosAdicionales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(9, 27)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(375, 87)
        Me.gbDatosAdicionales.TabIndex = 2
        Me.gbDatosAdicionales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbEmpresa.CheckedListSettings.ListSeparator = ","
        Me.cmbEmpresa.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cmbEmpresa.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cmbEmpresa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbEmpresa.DropDownWidth = 400
        Me.cmbEmpresa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpresa.Location = New System.Drawing.Point(72, 60)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(297, 23)
        Me.cmbEmpresa.TabIndex = 3
        '
        'UltraLabel12
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance13
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(7, 63)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(51, 15)
        Me.UltraLabel12.TabIndex = 354
        Me.UltraLabel12.Text = "Empresa:"
        '
        'rfFechaHasta
        '
        Me.rfFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rfFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaHasta.Location = New System.Drawing.Point(225, 13)
        Me.rfFechaHasta.Name = "rfFechaHasta"
        Me.rfFechaHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaHasta.TabIndex = 1
        '
        'rfFechaDesde
        '
        Me.rfFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rfFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaDesde.Location = New System.Drawing.Point(71, 13)
        Me.rfFechaDesde.Name = "rfFechaDesde"
        Me.rfFechaDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaDesde.TabIndex = 0
        '
        'Etiqueta21
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance14
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(183, 15)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta21.TabIndex = 332
        Me.Etiqueta21.Text = "Hasta :"
        '
        'Etiqueta3
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance15
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(7, 16)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta3.TabIndex = 331
        Me.Etiqueta3.Text = "Desde :"
        '
        'cmbTipoDoc
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.cmbTipoDoc.Appearance = Appearance16
        Me.cmbTipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmbTipoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipoDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDoc.ForeColor = System.Drawing.Color.Black
        Me.cmbTipoDoc.Location = New System.Drawing.Point(71, 36)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(297, 22)
        Me.cmbTipoDoc.TabIndex = 2
        Me.cmbTipoDoc.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance17
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(7, 40)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta7.TabIndex = 302
        Me.Etiqueta7.Text = "Tipo Doc:"
        '
        'btnBuscarDoc
        '
        Appearance18.Image = 7
        Me.btnBuscarDoc.Appearance = Appearance18
        Me.btnBuscarDoc.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDoc.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarDoc.ImageList = Me.imagenes
        Me.btnBuscarDoc.Location = New System.Drawing.Point(514, 85)
        Me.btnBuscarDoc.Name = "btnBuscarDoc"
        Me.btnBuscarDoc.Size = New System.Drawing.Size(90, 30)
        Me.btnBuscarDoc.TabIndex = 3
        Me.btnBuscarDoc.Text = "&Buscar"
        '
        'ficDocAosciados
        '
        Me.ficDocAosciados.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDocAosciados.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDocAosciados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDocAosciados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDocAosciados.Location = New System.Drawing.Point(0, 0)
        Me.ficDocAosciados.Name = "ficDocAosciados"
        Me.ficDocAosciados.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDocAosciados.Size = New System.Drawing.Size(956, 474)
        Me.ficDocAosciados.TabIndex = 3
        UltraTab3.TabPage = Me.UltraTabPageControl4
        UltraTab3.Text = "&Documentos y &Obligaciones"
        Me.ficDocAosciados.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3})
        Me.ficDocAosciados.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(954, 451)
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
        Me.ugb_Espera.Location = New System.Drawing.Point(280, 203)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 4
        Me.ugb_Espera.Visible = False
        '
        'frm_BuscarDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 474)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficDocAosciados)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_BuscarDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Documentos"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.gridDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griObligaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdListaObligaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griOrdenTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsOrdenTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.tabLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLista.ResumeLayout(False)
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion11.ResumeLayout(False)
        CType(Me.agrBusquedaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusquedaDoc.ResumeLayout(False)
        Me.agrBusquedaDoc.PerformLayout()
        CType(Me.gbNroDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNroDoc.ResumeLayout(False)
        Me.gbNroDoc.PerformLayout()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.cmbEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDocAosciados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDocAosciados.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ficDocAosciados As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBusquedaDoc As ISL.Controles.Agrupacion
    Friend WithEvents btnBuscarDoc As ISL.Controles.Boton
    Friend WithEvents cmbTipoDoc As ISL.Controles.Combo
    Friend WithEvents odListadoDocumentos As ISL.Controles.OrigenDatos
    Friend WithEvents gridDocumentos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gbDatosAdicionales As ISL.Controles.Agrupacion
    Private WithEvents cmbEmpresa As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents rfFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents rbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents rbNroDoc As System.Windows.Forms.RadioButton
    Friend WithEvents gbNroDoc As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents Agrupacion11 As ISL.Controles.Agrupacion
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents tabLista As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griObligaciones As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents ogdListaObligaciones As ISL.Controles.OrigenDatos
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griOrdenTrabajo As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udsOrdenTrabajo As Infragistics.Win.UltraWinDataSource.UltraDataSource
End Class
