<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FacturarServicio
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoriaServicio")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CategoriaServicio", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccionar")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
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
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialServicio")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioConImp")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGravado")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionDetalle")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterialServicio", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreMaterialServicio")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pos")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
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
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Listar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Listar")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Ejecutar")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Importar")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool29 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar documento")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FacturarServicio))
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCompra")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenOrigen")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenDestino")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreSubEstado")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUsuario")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenDocumento")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieNumero")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AlmacenOrigen")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AlmacenDestino")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaServicio")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CategoriaServicio")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoDocumento")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterialServicio")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioSinImp")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGravado")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Igv")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacionDetalle")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterialServicio")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreMaterialServicio")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pos")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaServicios = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaDocumentoVenta = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.OrigenDatos1 = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnCargaDocAso = New ISL.Controles.Boton(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumeroDoc = New ISL.Controles.Texto(Me.components)
        Me.txtSerieDoc = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOrdenCompra = New ISL.Controles.Agrupacion(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griListaFacturaCompra = New ISL.Controles.Grilla(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.rbNroDoc = New System.Windows.Forms.RadioButton()
        Me.rbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.gbDatosAdicionales = New System.Windows.Forms.GroupBox()
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboEstadoFactura = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerieD = New ISL.Controles.Texto(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.gbNroDoc = New System.Windows.Forms.GroupBox()
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresEmitido = New ISL.Controles.Colores(Me.components)
        Me.ColoresAnulado = New ISL.Controles.Colores(Me.components)
        Me.etiEmitido = New ISL.Controles.Etiqueta(Me.components)
        Me.etiAnulado = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.griAnticipos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.gbeListadoMatSer = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.utcListadoMatSer = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.griListaDetalleFactura = New ISL.Controles.Grilla(Me.components)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.MenuDetalle = New ISL.Controles.Menu(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea13 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea14 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea17 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea18 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea15 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea16 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea20 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea21 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea9 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea10 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea11 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea12 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.decAnticipo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cbAnticipo = New System.Windows.Forms.CheckBox()
        Me.agrTipoBien = New ISL.Controles.Agrupacion(Me.components)
        Me.cboTipoBien = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtOrdenCompra = New ISL.Controles.Texto(Me.components)
        Me.chkElectronico = New ISL.Controles.Chequear(Me.components)
        Me.agrImpresion = New ISL.Controles.Agrupacion(Me.components)
        Me.verOmiteCta = New System.Windows.Forms.CheckBox()
        Me.verCantidad = New System.Windows.Forms.CheckBox()
        Me.fecPeriodo = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboDireccion = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTipoDocumento = New ISL.Controles.Texto(Me.components)
        Me.etiTipo = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiSubTotal = New Infragistics.Win.Misc.UltraLabel()
        Me.txtIGV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtSubTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.etiIgv = New Infragistics.Win.Misc.UltraLabel()
        Me.agrDetraccion = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.DecDetraer = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.DecMontoDetraccion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNetoPagar = New ISL.Controles.NumeroDecimal(Me.components)
        Me.lbl_etiqueta = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecFechaActual = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.decTc = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboCliente = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboTipoPago = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.decPorcenIGV = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEstadoFacturaM = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtSerieM = New ISL.Controles.Texto(Me.components)
        Me.txtNumeroM = New ISL.Controles.Texto(Me.components)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.ficFacturaCompra = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.odListadoDocumentos = New ISL.Controles.OrigenDatos(Me.components)
        Me.odOrden = New ISL.Controles.OrigenDatos(Me.components)
        Me.odServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.MenuContextual2 = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiActualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAnular = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEmitir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDescargarPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDescargarXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.odDetalleDocumento = New ISL.Controles.OrigenDatos(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griListaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griListaDocumentoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrigenDatos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txtNumeroDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOrdenCompra.SuspendLayout()
        CType(Me.griListaFacturaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.cboEstadoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNroDoc.SuspendLayout()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresEmitido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.griAnticipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeListadoMatSer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeListadoMatSer.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.utcListadoMatSer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcListadoMatSer.SuspendLayout()
        CType(Me.griListaDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.decAnticipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrTipoBien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTipoBien.SuspendLayout()
        CType(Me.cboTipoBien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkElectronico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrImpresion.SuspendLayout()
        CType(Me.fecPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetraccion.SuspendLayout()
        CType(Me.DecDetraer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecMontoDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetoPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decPorcenIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoFacturaM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficFacturaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficFacturaCompra.SuspendLayout()
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual2.SuspendLayout()
        CType(Me.odDetalleDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griListaServicios)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(709, 388)
        '
        'griListaServicios
        '
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 120
        UltraGridColumn3.Header.VisiblePosition = 4
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Categoría"
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.Width = 127
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Width = 226
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Width = 213
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn10.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None
        UltraGridColumn10.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn10.Header.Enabled = False
        UltraGridColumn10.Header.FixOnRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Width = 32
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand1.GroupHeadersVisible = False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaServicios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaServicios.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaServicios.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaServicios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServicios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServicios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaServicios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaServicios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaServicios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaServicios.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaServicios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaServicios.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaServicios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaServicios.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaServicios.Location = New System.Drawing.Point(0, 0)
        Me.griListaServicios.Name = "griListaServicios"
        Me.griListaServicios.Size = New System.Drawing.Size(709, 388)
        Me.griListaServicios.TabIndex = 0
        Me.griListaServicios.Tag = ""
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griListaDocumentoVenta)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(709, 412)
        '
        'griListaDocumentoVenta
        '
        Me.griListaDocumentoVenta.DataSource = Me.OrigenDatos1
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaDocumentoVenta.DisplayLayout.Appearance = Appearance1
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 3
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn18.Header.VisiblePosition = 10
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn19.Header.VisiblePosition = 12
        UltraGridColumn19.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn20.Header.VisiblePosition = 8
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 13
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 14
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 15
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 7
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 16
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 17
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 18
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 5
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn29.Header.VisiblePosition = 6
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn30.Header.VisiblePosition = 11
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn31.Header.VisiblePosition = 19
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 20
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 21
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 22
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 23
        UltraGridColumn35.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 24
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 25
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 26
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 27
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 28
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.Caption = "Cliente"
        UltraGridColumn76.Header.VisiblePosition = 4
        UltraGridColumn76.Width = 270
        UltraGridColumn77.Header.VisiblePosition = 29
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 30
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 31
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 32
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 33
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 34
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 35
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 36
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 37
        UltraGridColumn85.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85})
        Me.griListaDocumentoVenta.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaDocumentoVenta.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDocumentoVenta.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDocumentoVenta.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griListaDocumentoVenta.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDocumentoVenta.DisplayLayout.GroupByBox.Hidden = True
        Me.griListaDocumentoVenta.DisplayLayout.GroupByBox.Prompt = " Drag a column header here to group by that column."
        Me.griListaDocumentoVenta.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDocumentoVenta.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaDocumentoVenta.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaDocumentoVenta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDocumentoVenta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDocumentoVenta.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDocumentoVenta.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaDocumentoVenta.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None
        Me.griListaDocumentoVenta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaDocumentoVenta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaDocumentoVenta.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDocumentoVenta.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDocumentoVenta.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaDocumentoVenta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaDocumentoVenta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaDocumentoVenta.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaDocumentoVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDocumentoVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaDocumentoVenta.Location = New System.Drawing.Point(0, 49)
        Me.griListaDocumentoVenta.Name = "griListaDocumentoVenta"
        Me.griListaDocumentoVenta.Size = New System.Drawing.Size(709, 363)
        Me.griListaDocumentoVenta.TabIndex = 5
        Me.griListaDocumentoVenta.TabStop = False
        Me.griListaDocumentoVenta.Text = "UltraGrid1"
        '
        'OrigenDatos1
        '
        UltraDataColumn38.DataType = GetType(Boolean)
        Me.OrigenDatos1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.btnCargaDocAso)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.txtNumeroDoc)
        Me.UltraGroupBox1.Controls.Add(Me.txtSerieDoc)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(709, 49)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnCargaDocAso
        '
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnCargaDocAso.Appearance = Appearance2
        Me.btnCargaDocAso.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCargaDocAso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCargaDocAso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaDocAso.ForeColor = System.Drawing.Color.Black
        Me.btnCargaDocAso.Location = New System.Drawing.Point(217, 6)
        Me.btnCargaDocAso.Name = "btnCargaDocAso"
        Me.btnCargaDocAso.Size = New System.Drawing.Size(36, 37)
        Me.btnCargaDocAso.TabIndex = 10
        '
        'UltraLabel4
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Appearance3.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance3
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(7, 19)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(65, 15)
        Me.UltraLabel4.TabIndex = 9
        Me.UltraLabel4.Text = "Documento:"
        '
        'txtNumeroDoc
        '
        Me.txtNumeroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDoc.Location = New System.Drawing.Point(132, 15)
        Me.txtNumeroDoc.MaxLength = 10
        Me.txtNumeroDoc.Name = "txtNumeroDoc"
        Me.txtNumeroDoc.Size = New System.Drawing.Size(79, 21)
        Me.txtNumeroDoc.TabIndex = 8
        '
        'txtSerieDoc
        '
        Me.txtSerieDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieDoc.Location = New System.Drawing.Point(78, 15)
        Me.txtSerieDoc.MaxLength = 4
        Me.txtSerieDoc.Name = "txtSerieDoc"
        Me.txtSerieDoc.Size = New System.Drawing.Size(48, 21)
        Me.txtSerieDoc.TabIndex = 6
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrOrdenCompra)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1220, 710)
        '
        'agrOrdenCompra
        '
        Me.agrOrdenCompra.Controls.Add(Me.ugb_Espera)
        Me.agrOrdenCompra.Controls.Add(Me.griListaFacturaCompra)
        Me.agrOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOrdenCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOrdenCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOrdenCompra.Location = New System.Drawing.Point(0, 123)
        Me.agrOrdenCompra.Name = "agrOrdenCompra"
        Me.agrOrdenCompra.Size = New System.Drawing.Size(1220, 587)
        Me.agrOrdenCompra.TabIndex = 1
        Me.agrOrdenCompra.Text = "Listado de Documentos por Servicio"
        Me.agrOrdenCompra.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(413, 119)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 8
        Me.ugb_Espera.Visible = False
        '
        'griListaFacturaCompra
        '
        Appearance4.BackColor = System.Drawing.SystemColors.Window
        Appearance4.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaFacturaCompra.DisplayLayout.Appearance = Appearance4
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 6
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 7
        UltraGridColumn39.Hidden = True
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn40.CellAppearance = Appearance5
        UltraGridColumn40.Header.VisiblePosition = 8
        UltraGridColumn40.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn40.Width = 123
        UltraGridColumn41.Header.Caption = "Imp. Venta"
        UltraGridColumn41.Header.VisiblePosition = 9
        UltraGridColumn41.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance6
        UltraGridColumn42.Header.VisiblePosition = 10
        UltraGridColumn42.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn43.Header.VisiblePosition = 12
        UltraGridColumn44.Header.VisiblePosition = 13
        UltraGridColumn44.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance7
        UltraGridColumn45.Header.VisiblePosition = 14
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.MaskInput = ""
        UltraGridColumn46.Header.VisiblePosition = 15
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 4
        UltraGridColumn48.Header.Caption = "Fecha"
        UltraGridColumn48.Header.VisiblePosition = 5
        UltraGridColumn48.Width = 132
        UltraGridColumn49.Header.VisiblePosition = 16
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 17
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 18
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 19
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 20
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 21
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 22
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 23
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 24
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 25
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 26
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 27
        UltraGridColumn61.Header.VisiblePosition = 28
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 29
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.Caption = "Estado"
        UltraGridColumn63.Header.VisiblePosition = 11
        UltraGridColumn64.Header.Caption = "Empresa"
        UltraGridColumn64.Header.VisiblePosition = 2
        UltraGridColumn64.Width = 304
        UltraGridColumn65.Header.Caption = "Nº Documento"
        UltraGridColumn65.Header.VisiblePosition = 3
        UltraGridColumn65.Width = 143
        UltraGridColumn66.Header.VisiblePosition = 30
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 31
        UltraGridColumn67.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67})
        Me.griListaFacturaCompra.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListaFacturaCompra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaFacturaCompra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance8.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaFacturaCompra.DisplayLayout.GroupByBox.Appearance = Appearance8
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaFacturaCompra.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance9
        Me.griListaFacturaCompra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaFacturaCompra.DisplayLayout.GroupByBox.Hidden = True
        Appearance10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance10.BackColor2 = System.Drawing.SystemColors.Control
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaFacturaCompra.DisplayLayout.GroupByBox.PromptAppearance = Appearance10
        Me.griListaFacturaCompra.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaFacturaCompra.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaFacturaCompra.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaFacturaCompra.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaFacturaCompra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaFacturaCompra.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaFacturaCompra.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaFacturaCompra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaFacturaCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaFacturaCompra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaFacturaCompra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaFacturaCompra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaFacturaCompra.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaFacturaCompra.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaFacturaCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaFacturaCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaFacturaCompra.Location = New System.Drawing.Point(3, 17)
        Me.griListaFacturaCompra.Name = "griListaFacturaCompra"
        Me.griListaFacturaCompra.Size = New System.Drawing.Size(1214, 567)
        Me.griListaFacturaCompra.TabIndex = 0
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.rbNroDoc)
        Me.Agrupacion1.Controls.Add(Me.rbDatosAdicionales)
        Me.Agrupacion1.Controls.Add(Me.gbDatosAdicionales)
        Me.Agrupacion1.Controls.Add(Me.gbNroDoc)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion7)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1220, 123)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Búsqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta2
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance11
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(189, 90)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta2.TabIndex = 5
        Me.Etiqueta2.Text = "Estado:"
        '
        'rbNroDoc
        '
        Me.rbNroDoc.AutoSize = True
        Me.rbNroDoc.BackColor = System.Drawing.Color.Transparent
        Me.rbNroDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNroDoc.Location = New System.Drawing.Point(12, 72)
        Me.rbNroDoc.Name = "rbNroDoc"
        Me.rbNroDoc.Size = New System.Drawing.Size(96, 17)
        Me.rbNroDoc.TabIndex = 3
        Me.rbNroDoc.TabStop = True
        Me.rbNroDoc.Text = "N° de Factura:"
        Me.rbNroDoc.UseVisualStyleBackColor = False
        '
        'rbDatosAdicionales
        '
        Me.rbDatosAdicionales.AutoSize = True
        Me.rbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rbDatosAdicionales.Checked = True
        Me.rbDatosAdicionales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDatosAdicionales.Location = New System.Drawing.Point(11, 19)
        Me.rbDatosAdicionales.Name = "rbDatosAdicionales"
        Me.rbDatosAdicionales.Size = New System.Drawing.Size(113, 17)
        Me.rbDatosAdicionales.TabIndex = 1
        Me.rbDatosAdicionales.TabStop = True
        Me.rbDatosAdicionales.Text = "Datos Adicionales:"
        Me.rbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.gbDatosAdicionales.Controls.Add(Me.fecHasta)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta1)
        Me.gbDatosAdicionales.Controls.Add(Me.fecDesde)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta3)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta7)
        Me.gbDatosAdicionales.Controls.Add(Me.cboEstadoFactura)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta4)
        Me.gbDatosAdicionales.Controls.Add(Me.txtSerieD)
        Me.gbDatosAdicionales.Controls.Add(Me.cboTipoDocumento)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta5)
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(4, 22)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(821, 45)
        Me.gbDatosAdicionales.TabIndex = 0
        Me.gbDatosAdicionales.TabStop = False
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(198, 19)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(89, 20)
        Me.fecHasta.TabIndex = 3
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(156, 22)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta1.TabIndex = 2
        Me.Etiqueta1.Text = "Hasta: "
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(61, 19)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(89, 20)
        Me.fecDesde.TabIndex = 1
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(16, 22)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Desde: "
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(545, 22)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta7.TabIndex = 6
        Me.Etiqueta7.Text = "Estado:"
        '
        'cboEstadoFactura
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoFactura.Appearance = Appearance12
        Me.cboEstadoFactura.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoFactura.DisplayMember = "Nombre"
        Me.cboEstadoFactura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoFactura.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoFactura.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoFactura.Location = New System.Drawing.Point(589, 19)
        Me.cboEstadoFactura.Name = "cboEstadoFactura"
        Me.cboEstadoFactura.Size = New System.Drawing.Size(121, 21)
        Me.cboEstadoFactura.TabIndex = 7
        Me.cboEstadoFactura.ValueMember = "Id"
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(716, 22)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta4.TabIndex = 8
        Me.Etiqueta4.Text = "Serie:"
        '
        'txtSerieD
        '
        Me.txtSerieD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieD.Location = New System.Drawing.Point(755, 19)
        Me.txtSerieD.MaxLength = 4
        Me.txtSerieD.Name = "txtSerieD"
        Me.txtSerieD.Size = New System.Drawing.Size(60, 21)
        Me.txtSerieD.TabIndex = 9
        '
        'cboTipoDocumento
        '
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance13
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.DisplayMember = "Nombre"
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(387, 18)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(152, 21)
        Me.cboTipoDocumento.TabIndex = 5
        Me.cboTipoDocumento.ValueMember = "IdTipoDocumento"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(293, 22)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(90, 15)
        Me.Etiqueta5.TabIndex = 4
        Me.Etiqueta5.Text = "Tipo Documento:"
        '
        'gbNroDoc
        '
        Me.gbNroDoc.BackColor = System.Drawing.Color.Transparent
        Me.gbNroDoc.Controls.Add(Me.txtSerie)
        Me.gbNroDoc.Controls.Add(Me.txtNumero)
        Me.gbNroDoc.Enabled = False
        Me.gbNroDoc.Location = New System.Drawing.Point(2, 70)
        Me.gbNroDoc.Name = "gbNroDoc"
        Me.gbNroDoc.Size = New System.Drawing.Size(164, 51)
        Me.gbNroDoc.TabIndex = 2
        Me.gbNroDoc.TabStop = False
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(6, 22)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(42, 21)
        Me.txtSerie.TabIndex = 0
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(54, 22)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(102, 21)
        Me.txtNumero.TabIndex = 1
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion7.Controls.Add(Me.ColoresEmitido)
        Me.Agrupacion7.Controls.Add(Me.ColoresAnulado)
        Me.Agrupacion7.Controls.Add(Me.etiEmitido)
        Me.Agrupacion7.Controls.Add(Me.etiAnulado)
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion7.Location = New System.Drawing.Point(236, 74)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(323, 39)
        Me.Agrupacion7.TabIndex = 4
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Location = New System.Drawing.Point(68, 12)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresGenerado.TabIndex = 1
        Me.ColoresGenerado.Text = "Control"
        '
        'Etiqueta6
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance14
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(6, 16)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta6.TabIndex = 0
        Me.Etiqueta6.Text = "Generada:"
        '
        'ColoresEmitido
        '
        Me.ColoresEmitido.Color = System.Drawing.Color.Empty
        Me.ColoresEmitido.Location = New System.Drawing.Point(170, 12)
        Me.ColoresEmitido.Name = "ColoresEmitido"
        Me.ColoresEmitido.Size = New System.Drawing.Size(43, 21)
        Me.ColoresEmitido.TabIndex = 3
        '
        'ColoresAnulado
        '
        Me.ColoresAnulado.Color = System.Drawing.Color.Empty
        Me.ColoresAnulado.Location = New System.Drawing.Point(271, 12)
        Me.ColoresAnulado.Name = "ColoresAnulado"
        Me.ColoresAnulado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresAnulado.TabIndex = 5
        '
        'etiEmitido
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.etiEmitido.Appearance = Appearance15
        Me.etiEmitido.AutoSize = True
        Me.etiEmitido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEmitido.ForeColor = System.Drawing.Color.Black
        Me.etiEmitido.Location = New System.Drawing.Point(120, 16)
        Me.etiEmitido.Name = "etiEmitido"
        Me.etiEmitido.Size = New System.Drawing.Size(45, 15)
        Me.etiEmitido.TabIndex = 2
        Me.etiEmitido.Text = "Emitida:"
        '
        'etiAnulado
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.etiAnulado.Appearance = Appearance16
        Me.etiAnulado.AutoSize = True
        Me.etiAnulado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAnulado.ForeColor = System.Drawing.Color.Black
        Me.etiAnulado.Location = New System.Drawing.Point(219, 16)
        Me.etiAnulado.Name = "etiAnulado"
        Me.etiAnulado.Size = New System.Drawing.Size(49, 15)
        Me.etiAnulado.TabIndex = 4
        Me.etiAnulado.Text = "Anulado:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Controls.Add(Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Left)
        Me.UltraTabPageControl2.Controls.Add(Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Right)
        Me.UltraTabPageControl2.Controls.Add(Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Top)
        Me.UltraTabPageControl2.Controls.Add(Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1220, 686)
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.Agrupacion6)
        Me.Agrupacion4.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Top)
        Me.Agrupacion4.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom)
        Me.Agrupacion4.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Left)
        Me.Agrupacion4.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Right)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea13)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea14)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea17)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea18)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea15)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea16)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea20)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea21)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea9)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea10)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea11)
        Me.Agrupacion4.Controls.Add(Me.UltraToolbarsDockArea12)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 217)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1220, 469)
        Me.Agrupacion4.TabIndex = 1
        Me.Agrupacion4.Tag = " "
        Me.Agrupacion4.Text = "Detalle"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.griAnticipos)
        Me.Agrupacion6.Controls.Add(Me.gbeListadoMatSer)
        Me.Agrupacion6.Controls.Add(Me.griListaDetalleFactura)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(3, 43)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(1214, 423)
        Me.Agrupacion6.TabIndex = 0
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griAnticipos
        '
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAnticipos.DisplayLayout.Appearance = Appearance17
        UltraGridColumn68.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn68.Header.CheckBoxAlignment = Infragistics.Win.UltraWinGrid.HeaderCheckBoxAlignment.Center
        UltraGridColumn68.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn68.Header.VisiblePosition = 0
        UltraGridColumn68.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn69.Header.VisiblePosition = 1
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 2
        UltraGridColumn70.Hidden = True
        UltraGridColumn148.Header.VisiblePosition = 3
        UltraGridColumn149.Header.VisiblePosition = 4
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn150.CellAppearance = Appearance18
        UltraGridColumn150.Header.VisiblePosition = 10
        UltraGridColumn150.Hidden = True
        UltraGridColumn150.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn151.CellAppearance = Appearance19
        UltraGridColumn151.Header.VisiblePosition = 11
        UltraGridColumn151.Hidden = True
        UltraGridColumn151.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn152.CellAppearance = Appearance20
        UltraGridColumn152.Header.VisiblePosition = 12
        UltraGridColumn152.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn153.Header.VisiblePosition = 9
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.Header.VisiblePosition = 14
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 15
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.Header.VisiblePosition = 16
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.Header.VisiblePosition = 8
        UltraGridColumn157.Hidden = True
        UltraGridColumn158.Header.VisiblePosition = 17
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 18
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 19
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.Header.VisiblePosition = 6
        UltraGridColumn161.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn162.Header.VisiblePosition = 7
        UltraGridColumn162.Hidden = True
        UltraGridColumn162.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn163.CellAppearance = Appearance21
        UltraGridColumn163.Header.VisiblePosition = 13
        UltraGridColumn163.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn164.CellAppearance = Appearance22
        UltraGridColumn164.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn164.Header.VisiblePosition = 20
        UltraGridColumn164.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn165.Header.VisiblePosition = 21
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 22
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 23
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 24
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 25
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 26
        UltraGridColumn170.Hidden = True
        UltraGridColumn171.Header.VisiblePosition = 27
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 28
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 29
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.Caption = "Cliente"
        UltraGridColumn174.Header.VisiblePosition = 5
        UltraGridColumn174.Width = 270
        UltraGridColumn175.Header.VisiblePosition = 30
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.VisiblePosition = 31
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 32
        UltraGridColumn177.Hidden = True
        UltraGridColumn178.Header.VisiblePosition = 33
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 34
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 35
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 36
        UltraGridColumn181.Hidden = True
        UltraGridColumn182.Header.VisiblePosition = 37
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 38
        UltraGridColumn183.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183})
        Me.griAnticipos.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griAnticipos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAnticipos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAnticipos.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Appearance23.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance23.BorderColor = System.Drawing.SystemColors.Window
        Me.griAnticipos.DisplayLayout.GroupByBox.Appearance = Appearance23
        Appearance24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAnticipos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance24
        Me.griAnticipos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance25.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance25.BackColor2 = System.Drawing.SystemColors.Control
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance25.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAnticipos.DisplayLayout.GroupByBox.PromptAppearance = Appearance25
        Me.griAnticipos.DisplayLayout.MaxColScrollRegions = 1
        Me.griAnticipos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance26.BackColor = System.Drawing.SystemColors.Window
        Appearance26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griAnticipos.DisplayLayout.Override.ActiveCellAppearance = Appearance26
        Appearance27.BackColor = System.Drawing.SystemColors.Highlight
        Appearance27.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griAnticipos.DisplayLayout.Override.ActiveRowAppearance = Appearance27
        Me.griAnticipos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAnticipos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance28.BackColor = System.Drawing.SystemColors.Window
        Me.griAnticipos.DisplayLayout.Override.CardAreaAppearance = Appearance28
        Appearance29.BorderColor = System.Drawing.Color.Silver
        Appearance29.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griAnticipos.DisplayLayout.Override.CellAppearance = Appearance29
        Me.griAnticipos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griAnticipos.DisplayLayout.Override.CellPadding = 0
        Appearance30.BackColor = System.Drawing.SystemColors.Control
        Appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance30.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance30.BorderColor = System.Drawing.SystemColors.Window
        Me.griAnticipos.DisplayLayout.Override.GroupByRowAppearance = Appearance30
        Appearance31.TextHAlignAsString = "Left"
        Me.griAnticipos.DisplayLayout.Override.HeaderAppearance = Appearance31
        Me.griAnticipos.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griAnticipos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAnticipos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance32.BackColor = System.Drawing.SystemColors.Window
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Me.griAnticipos.DisplayLayout.Override.RowAppearance = Appearance32
        Me.griAnticipos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance33.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griAnticipos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance33
        Me.griAnticipos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAnticipos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAnticipos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griAnticipos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.griAnticipos.Location = New System.Drawing.Point(3, 181)
        Me.griAnticipos.Name = "griAnticipos"
        Me.griAnticipos.Size = New System.Drawing.Size(474, 239)
        Me.griAnticipos.TabIndex = 6
        Me.griAnticipos.TabStop = False
        Me.griAnticipos.Text = "Listado de Anticipos"
        '
        'gbeListadoMatSer
        '
        Me.gbeListadoMatSer.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeListadoMatSer.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeListadoMatSer.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeListadoMatSer.ExpandedSize = New System.Drawing.Size(734, 417)
        Me.gbeListadoMatSer.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeListadoMatSer.Location = New System.Drawing.Point(477, 3)
        Me.gbeListadoMatSer.Name = "gbeListadoMatSer"
        Me.gbeListadoMatSer.Size = New System.Drawing.Size(734, 417)
        Me.gbeListadoMatSer.TabIndex = 1
        Me.gbeListadoMatSer.Text = " "
        Me.gbeListadoMatSer.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.utcListadoMatSer)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(711, 411)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'utcListadoMatSer
        '
        Me.utcListadoMatSer.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.utcListadoMatSer.Controls.Add(Me.UltraTabPageControl4)
        Me.utcListadoMatSer.Controls.Add(Me.UltraTabPageControl3)
        Me.utcListadoMatSer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcListadoMatSer.Location = New System.Drawing.Point(0, 0)
        Me.utcListadoMatSer.Name = "utcListadoMatSer"
        Me.utcListadoMatSer.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.utcListadoMatSer.Size = New System.Drawing.Size(711, 411)
        Me.utcListadoMatSer.TabIndex = 0
        UltraTab6.Key = "1"
        UltraTab6.TabPage = Me.UltraTabPageControl4
        UltraTab6.Text = "Servicios"
        UltraTab7.TabPage = Me.UltraTabPageControl3
        UltraTab7.Text = "Documento Venta"
        Me.utcListadoMatSer.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7})
        Me.utcListadoMatSer.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(709, 388)
        '
        'griListaDetalleFactura
        '
        UltraGridColumn86.Header.VisiblePosition = 1
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 3
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 4
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 2
        UltraGridColumn89.Hidden = True
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn90.CellAppearance = Appearance34
        UltraGridColumn90.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn90.Header.VisiblePosition = 7
        UltraGridColumn90.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn90.Width = 73
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn91.CellAppearance = Appearance35
        UltraGridColumn91.Header.Caption = "PU S/Imp"
        UltraGridColumn91.Header.VisiblePosition = 10
        UltraGridColumn91.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn92.CellAppearance = Appearance36
        UltraGridColumn92.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn92.Header.Caption = "PU C/Imp"
        UltraGridColumn92.Header.VisiblePosition = 11
        UltraGridColumn92.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn93.CellAppearance = Appearance37
        UltraGridColumn93.Header.Caption = "Importe"
        UltraGridColumn93.Header.VisiblePosition = 14
        UltraGridColumn93.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn94.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn94.Header.Caption = "Ind. Igv"
        UltraGridColumn94.Header.VisiblePosition = 9
        UltraGridColumn94.Width = 57
        UltraGridColumn95.Header.VisiblePosition = 12
        UltraGridColumn95.Hidden = True
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn96.CellAppearance = Appearance38
        UltraGridColumn96.Header.VisiblePosition = 13
        UltraGridColumn96.Hidden = True
        UltraGridColumn96.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn97.Header.VisiblePosition = 15
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 16
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 17
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 18
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 19
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.Caption = "Codigo"
        UltraGridColumn102.Header.VisiblePosition = 5
        UltraGridColumn102.Width = 74
        UltraGridColumn103.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn103.Header.Caption = "Select"
        UltraGridColumn103.Header.VisiblePosition = 0
        UltraGridColumn103.Width = 53
        UltraGridColumn104.Header.Caption = "Unidad de medida"
        UltraGridColumn104.Header.VisiblePosition = 8
        UltraGridColumn105.Header.VisiblePosition = 20
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.Caption = "Nombre"
        UltraGridColumn106.Header.VisiblePosition = 6
        UltraGridColumn106.Width = 306
        UltraGridColumn107.Header.VisiblePosition = 21
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 22
        UltraGridColumn108.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108})
        Me.griListaDetalleFactura.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griListaDetalleFactura.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleFactura.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance39.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance39.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleFactura.DisplayLayout.GroupByBox.Appearance = Appearance39
        Appearance40.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDetalleFactura.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance40
        Me.griListaDetalleFactura.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleFactura.DisplayLayout.GroupByBox.Hidden = True
        Appearance41.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance41.BackColor2 = System.Drawing.SystemColors.Control
        Appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance41.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDetalleFactura.DisplayLayout.GroupByBox.PromptAppearance = Appearance41
        Me.griListaDetalleFactura.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDetalleFactura.DisplayLayout.MaxRowScrollRegions = 1
        Appearance42.BackColor = System.Drawing.SystemColors.Window
        Appearance42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaDetalleFactura.DisplayLayout.Override.ActiveCellAppearance = Appearance42
        Appearance43.BackColor = System.Drawing.SystemColors.Highlight
        Appearance43.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaDetalleFactura.DisplayLayout.Override.ActiveRowAppearance = Appearance43
        Me.griListaDetalleFactura.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDetalleFactura.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleFactura.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleFactura.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance44.BackColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleFactura.DisplayLayout.Override.CardAreaAppearance = Appearance44
        Appearance45.BorderColor = System.Drawing.Color.Silver
        Appearance45.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaDetalleFactura.DisplayLayout.Override.CellAppearance = Appearance45
        Me.griListaDetalleFactura.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDetalleFactura.DisplayLayout.Override.CellPadding = 0
        Me.griListaDetalleFactura.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDetalleFactura.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance46.BackColor = System.Drawing.SystemColors.Control
        Appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance46.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance46.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleFactura.DisplayLayout.Override.GroupByRowAppearance = Appearance46
        Appearance47.TextHAlignAsString = "Center"
        Me.griListaDetalleFactura.DisplayLayout.Override.HeaderAppearance = Appearance47
        Me.griListaDetalleFactura.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaDetalleFactura.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Appearance48.BorderColor = System.Drawing.Color.Silver
        Me.griListaDetalleFactura.DisplayLayout.Override.RowAppearance = Appearance48
        Me.griListaDetalleFactura.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaDetalleFactura.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDetalleFactura.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleFactura.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance49.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaDetalleFactura.DisplayLayout.Override.TemplateAddRowAppearance = Appearance49
        Me.griListaDetalleFactura.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaDetalleFactura.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaDetalleFactura.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDetalleFactura.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaDetalleFactura.Location = New System.Drawing.Point(3, 3)
        Me.griListaDetalleFactura.Name = "griListaDetalleFactura"
        Me.griListaDetalleFactura.Size = New System.Drawing.Size(1208, 417)
        Me.griListaDetalleFactura.TabIndex = 0
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Top
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(3, 17)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Top"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1214, 26)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ToolbarsManager = Me.MenuDetalle
        '
        'MenuDetalle
        '
        Appearance50.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MenuDetalle.Appearance = Appearance50
        Me.MenuDetalle.DesignerFlags = 1
        Me.MenuDetalle.DockWithinContainer = Me
        Me.MenuDetalle.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.MenuDetalle.ImageListLarge = Me.imagenes
        Me.MenuDetalle.ImageListSmall = Me.imagenes
        Me.MenuDetalle.MdiMergeable = False
        Me.MenuDetalle.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        Me.MenuDetalle.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(414, 398)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(107, 72)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool5, ButtonTool8})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.MenuDetalle.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance51.Image = 7
        ButtonTool11.SharedPropsInternal.AppearancesSmall.Appearance = Appearance51
        ButtonTool11.SharedPropsInternal.Caption = "Importar"
        ButtonTool11.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance52.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool20.SharedPropsInternal.AppearancesSmall.Appearance = Appearance52
        ButtonTool20.SharedPropsInternal.Caption = "Editar"
        ButtonTool20.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance53.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool21.SharedPropsInternal.AppearancesSmall.Appearance = Appearance53
        ButtonTool21.SharedPropsInternal.Caption = "Quitar"
        ButtonTool21.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance54.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        ButtonTool22.SharedPropsInternal.AppearancesSmall.Appearance = Appearance54
        ButtonTool22.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool22.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance55.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool23.SharedPropsInternal.AppearancesSmall.Appearance = Appearance55
        ButtonTool23.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool23.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance56.Image = 6
        ButtonTool24.SharedPropsInternal.AppearancesSmall.Appearance = Appearance56
        ButtonTool24.SharedPropsInternal.Caption = "Listar"
        ButtonTool24.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance57.Image = 2
        ButtonTool25.SharedPropsInternal.AppearancesSmall.Appearance = Appearance57
        ButtonTool25.SharedPropsInternal.Caption = "Generar OI"
        ButtonTool25.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance58.Image = 3
        ButtonTool26.SharedPropsInternal.AppearancesSmall.Appearance = Appearance58
        ButtonTool26.SharedPropsInternal.Caption = "Ejecutar OI"
        ButtonTool26.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance59.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool27.SharedPropsInternal.AppearancesSmall.Appearance = Appearance59
        ButtonTool27.SharedPropsInternal.Caption = "Importar"
        ButtonTool27.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance60.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool28.SharedPropsInternal.AppearancesSmall.Appearance = Appearance60
        ButtonTool28.SharedPropsInternal.Caption = "Agregar"
        ButtonTool28.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance61.Image = 2
        ButtonTool29.SharedPropsInternal.AppearancesSmall.Appearance = Appearance61
        ButtonTool29.SharedPropsInternal.Caption = "Generar documento"
        ButtonTool29.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.MenuDetalle.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool11, ButtonTool20, ButtonTool21, ButtonTool22, ButtonTool23, ButtonTool24, ButtonTool25, ButtonTool26, ButtonTool27, ButtonTool28, ButtonTool29})
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
        '_frm_MenuPadre_Toolbars_Dock_Area_Bottom
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(3, 466)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Bottom"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1214, 0)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.MenuDetalle
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Left
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(3, 17)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Left"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 449)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ToolbarsManager = Me.MenuDetalle
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Right
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1217, 17)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Right"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 449)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea13
        '
        Me.UltraToolbarsDockArea13.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea13.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea13.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea13.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea13.Name = "UltraToolbarsDockArea13"
        Me.UltraToolbarsDockArea13.Size = New System.Drawing.Size(1214, 0)
        '
        'UltraToolbarsDockArea14
        '
        Me.UltraToolbarsDockArea14.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea14.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea14.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea14.Location = New System.Drawing.Point(3, 466)
        Me.UltraToolbarsDockArea14.Name = "UltraToolbarsDockArea14"
        Me.UltraToolbarsDockArea14.Size = New System.Drawing.Size(1214, 0)
        '
        'UltraToolbarsDockArea17
        '
        Me.UltraToolbarsDockArea17.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea17.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea17.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea17.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea17.Name = "UltraToolbarsDockArea17"
        Me.UltraToolbarsDockArea17.Size = New System.Drawing.Size(0, 449)
        '
        'UltraToolbarsDockArea18
        '
        Me.UltraToolbarsDockArea18.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea18.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea18.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea18.Location = New System.Drawing.Point(1217, 17)
        Me.UltraToolbarsDockArea18.Name = "UltraToolbarsDockArea18"
        Me.UltraToolbarsDockArea18.Size = New System.Drawing.Size(0, 449)
        '
        'UltraToolbarsDockArea15
        '
        Me.UltraToolbarsDockArea15.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea15.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea15.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea15.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea15.Name = "UltraToolbarsDockArea15"
        Me.UltraToolbarsDockArea15.Size = New System.Drawing.Size(1214, 0)
        '
        'UltraToolbarsDockArea16
        '
        Me.UltraToolbarsDockArea16.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea16.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea16.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea16.Location = New System.Drawing.Point(3, 466)
        Me.UltraToolbarsDockArea16.Name = "UltraToolbarsDockArea16"
        Me.UltraToolbarsDockArea16.Size = New System.Drawing.Size(1214, 0)
        '
        'UltraToolbarsDockArea20
        '
        Me.UltraToolbarsDockArea20.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea20.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea20.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea20.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea20.Name = "UltraToolbarsDockArea20"
        Me.UltraToolbarsDockArea20.Size = New System.Drawing.Size(0, 449)
        '
        'UltraToolbarsDockArea21
        '
        Me.UltraToolbarsDockArea21.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea21.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea21.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea21.Location = New System.Drawing.Point(1217, 17)
        Me.UltraToolbarsDockArea21.Name = "UltraToolbarsDockArea21"
        Me.UltraToolbarsDockArea21.Size = New System.Drawing.Size(0, 449)
        '
        'UltraToolbarsDockArea9
        '
        Me.UltraToolbarsDockArea9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea9.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea9.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea9.Name = "UltraToolbarsDockArea9"
        Me.UltraToolbarsDockArea9.Size = New System.Drawing.Size(1214, 0)
        '
        'UltraToolbarsDockArea10
        '
        Me.UltraToolbarsDockArea10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea10.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea10.Location = New System.Drawing.Point(3, 466)
        Me.UltraToolbarsDockArea10.Name = "UltraToolbarsDockArea10"
        Me.UltraToolbarsDockArea10.Size = New System.Drawing.Size(1214, 0)
        '
        'UltraToolbarsDockArea11
        '
        Me.UltraToolbarsDockArea11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea11.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea11.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea11.Name = "UltraToolbarsDockArea11"
        Me.UltraToolbarsDockArea11.Size = New System.Drawing.Size(0, 449)
        '
        'UltraToolbarsDockArea12
        '
        Me.UltraToolbarsDockArea12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea12.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea12.Location = New System.Drawing.Point(1217, 17)
        Me.UltraToolbarsDockArea12.Name = "UltraToolbarsDockArea12"
        Me.UltraToolbarsDockArea12.Size = New System.Drawing.Size(0, 449)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.decAnticipo)
        Me.Agrupacion2.Controls.Add(Me.cbAnticipo)
        Me.Agrupacion2.Controls.Add(Me.agrTipoBien)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta32)
        Me.Agrupacion2.Controls.Add(Me.txtOrdenCompra)
        Me.Agrupacion2.Controls.Add(Me.chkElectronico)
        Me.Agrupacion2.Controls.Add(Me.agrImpresion)
        Me.Agrupacion2.Controls.Add(Me.fecPeriodo)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion2.Controls.Add(Me.txtGlosa)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion2.Controls.Add(Me.cboDireccion)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion2.Controls.Add(Me.txtTipoDocumento)
        Me.Agrupacion2.Controls.Add(Me.etiTipo)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion2.Controls.Add(Me.agrDetraccion)
        Me.Agrupacion2.Controls.Add(Me.lbl_etiqueta)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel22)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion2.Controls.Add(Me.fecFechaActual)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel6)
        Me.Agrupacion2.Controls.Add(Me.decTc)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel7)
        Me.Agrupacion2.Controls.Add(Me.cboCliente)
        Me.Agrupacion2.Controls.Add(Me.cboTipoPago)
        Me.Agrupacion2.Controls.Add(Me.cboMoneda)
        Me.Agrupacion2.Controls.Add(Me.decPorcenIGV)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel11)
        Me.Agrupacion2.Controls.Add(Me.cboEstadoFacturaM)
        Me.Agrupacion2.Controls.Add(Me.txtSerieM)
        Me.Agrupacion2.Controls.Add(Me.txtNumeroM)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1220, 217)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos Generales"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decAnticipo
        '
        Appearance62.ForeColor = System.Drawing.Color.Black
        Me.decAnticipo.Appearance = Appearance62
        Me.decAnticipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decAnticipo.ForeColor = System.Drawing.Color.Black
        Me.decAnticipo.FormatString = "##,###,###0.00"
        Me.decAnticipo.Location = New System.Drawing.Point(978, 190)
        Me.decAnticipo.MaskInput = "{double:9.2}"
        Me.decAnticipo.Name = "decAnticipo"
        Me.decAnticipo.Nullable = True
        Me.decAnticipo.NullText = "0.00"
        Me.decAnticipo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decAnticipo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decAnticipo.ReadOnly = True
        Me.decAnticipo.Size = New System.Drawing.Size(93, 21)
        Me.decAnticipo.TabIndex = 49
        Me.decAnticipo.Value = Nothing
        '
        'cbAnticipo
        '
        Me.cbAnticipo.AutoSize = True
        Me.cbAnticipo.BackColor = System.Drawing.Color.Transparent
        Me.cbAnticipo.ForeColor = System.Drawing.Color.Navy
        Me.cbAnticipo.Location = New System.Drawing.Point(844, 194)
        Me.cbAnticipo.Name = "cbAnticipo"
        Me.cbAnticipo.Size = New System.Drawing.Size(128, 17)
        Me.cbAnticipo.TabIndex = 46
        Me.cbAnticipo.Text = "Facturar con Anticipo"
        Me.cbAnticipo.UseVisualStyleBackColor = False
        '
        'agrTipoBien
        '
        Me.agrTipoBien.Controls.Add(Me.cboTipoBien)
        Me.agrTipoBien.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTipoBien.ForeColor = System.Drawing.Color.Black
        Me.agrTipoBien.Location = New System.Drawing.Point(808, 68)
        Me.agrTipoBien.Name = "agrTipoBien"
        Me.agrTipoBien.Size = New System.Drawing.Size(312, 52)
        Me.agrTipoBien.TabIndex = 45
        Me.agrTipoBien.Text = "Tipo Bien:"
        Me.agrTipoBien.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboTipoBien
        '
        Appearance63.ForeColor = System.Drawing.Color.Black
        Me.cboTipoBien.Appearance = Appearance63
        Me.cboTipoBien.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoBien.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoBien.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoBien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoBien.ForeColor = System.Drawing.Color.Black
        Me.cboTipoBien.Location = New System.Drawing.Point(6, 22)
        Me.cboTipoBien.Name = "cboTipoBien"
        Me.cboTipoBien.Size = New System.Drawing.Size(300, 21)
        Me.cboTipoBien.TabIndex = 43
        Me.cboTipoBien.ValueMember = "Abreviatura"
        '
        'Etiqueta32
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance64
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(808, 23)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(122, 14)
        Me.Etiqueta32.TabIndex = 42
        Me.Etiqueta32.Text = "Orden Compra/Servicio:"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdenCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompra.Location = New System.Drawing.Point(808, 41)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(110, 21)
        Me.txtOrdenCompra.TabIndex = 41
        '
        'chkElectronico
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.FontData.BoldAsString = "True"
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Me.chkElectronico.Appearance = Appearance65
        Me.chkElectronico.AutoSize = True
        Me.chkElectronico.BackColor = System.Drawing.Color.Transparent
        Me.chkElectronico.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkElectronico.Checked = True
        Me.chkElectronico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkElectronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkElectronico.ForeColor = System.Drawing.Color.Black
        Me.chkElectronico.Location = New System.Drawing.Point(363, 133)
        Me.chkElectronico.Name = "chkElectronico"
        Me.chkElectronico.Size = New System.Drawing.Size(78, 17)
        Me.chkElectronico.TabIndex = 37
        Me.chkElectronico.Text = "Electronico"
        '
        'agrImpresion
        '
        Me.agrImpresion.Controls.Add(Me.verOmiteCta)
        Me.agrImpresion.Controls.Add(Me.verCantidad)
        Me.agrImpresion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrImpresion.ForeColor = System.Drawing.Color.Black
        Me.agrImpresion.Location = New System.Drawing.Point(646, 128)
        Me.agrImpresion.Name = "agrImpresion"
        Me.agrImpresion.Size = New System.Drawing.Size(179, 83)
        Me.agrImpresion.TabIndex = 1
        Me.agrImpresion.Text = "Preferencia de Impresión"
        Me.agrImpresion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verOmiteCta
        '
        Me.verOmiteCta.AutoSize = True
        Me.verOmiteCta.BackColor = System.Drawing.Color.Transparent
        Me.verOmiteCta.ForeColor = System.Drawing.Color.Navy
        Me.verOmiteCta.Location = New System.Drawing.Point(15, 56)
        Me.verOmiteCta.Name = "verOmiteCta"
        Me.verOmiteCta.Size = New System.Drawing.Size(158, 17)
        Me.verOmiteCta.TabIndex = 28
        Me.verOmiteCta.Text = "Omitir Nombre de la Cuenta"
        Me.verOmiteCta.UseVisualStyleBackColor = False
        '
        'verCantidad
        '
        Me.verCantidad.AutoSize = True
        Me.verCantidad.BackColor = System.Drawing.Color.Transparent
        Me.verCantidad.ForeColor = System.Drawing.Color.Navy
        Me.verCantidad.Location = New System.Drawing.Point(15, 29)
        Me.verCantidad.Name = "verCantidad"
        Me.verCantidad.Size = New System.Drawing.Size(100, 17)
        Me.verCantidad.TabIndex = 27
        Me.verCantidad.Text = "Omitir Cantidad"
        Me.verCantidad.UseVisualStyleBackColor = False
        '
        'fecPeriodo
        '
        Me.fecPeriodo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecPeriodo.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.fecPeriodo.Location = New System.Drawing.Point(508, 21)
        Me.fecPeriodo.MaskInput = "mm/yyyy"
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.Size = New System.Drawing.Size(75, 22)
        Me.fecPeriodo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.fecPeriodo.TabIndex = 19
        '
        'Etiqueta13
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance66
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(458, 23)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta13.TabIndex = 18
        Me.Etiqueta13.Text = "Periodo:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(74, 158)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(367, 53)
        Me.txtGlosa.TabIndex = 17
        '
        'Etiqueta12
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance67
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(32, 160)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta12.TabIndex = 16
        Me.Etiqueta12.Text = "Glosa:"
        '
        'cboDireccion
        '
        Appearance68.ForeColor = System.Drawing.Color.Black
        Me.cboDireccion.Appearance = Appearance68
        Me.cboDireccion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance69.Image = 7
        EditorButton1.Appearance = Appearance69
        Me.cboDireccion.ButtonsRight.Add(EditorButton1)
        Me.cboDireccion.DisplayMember = "Nombre"
        Me.cboDireccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDireccion.ForeColor = System.Drawing.Color.Black
        Me.cboDireccion.Location = New System.Drawing.Point(74, 104)
        Me.cboDireccion.Name = "cboDireccion"
        Me.cboDireccion.Size = New System.Drawing.Size(367, 21)
        Me.cboDireccion.TabIndex = 13
        Me.cboDireccion.ValueMember = "IdDireccion"
        '
        'Etiqueta11
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance70
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(15, 105)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(54, 15)
        Me.Etiqueta11.TabIndex = 12
        Me.Etiqueta11.Text = "Direccion:"
        '
        'Etiqueta10
        '
        Appearance71.BackColor = System.Drawing.Color.Transparent
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance71
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(35, 54)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta10.TabIndex = 4
        Me.Etiqueta10.Text = "Serie:"
        '
        'Etiqueta8
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance72
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(141, 52)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta8.TabIndex = 6
        Me.Etiqueta8.Text = "Numero:"
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDocumento.Location = New System.Drawing.Point(74, 23)
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.ReadOnly = True
        Me.txtTipoDocumento.Size = New System.Drawing.Size(157, 21)
        Me.txtTipoDocumento.TabIndex = 1
        '
        'etiTipo
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Me.etiTipo.Appearance = Appearance73
        Me.etiTipo.AutoSize = True
        Me.etiTipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTipo.ForeColor = System.Drawing.Color.Black
        Me.etiTipo.Location = New System.Drawing.Point(40, 25)
        Me.etiTipo.Name = "etiTipo"
        Me.etiTipo.Size = New System.Drawing.Size(30, 15)
        Me.etiTipo.TabIndex = 0
        Me.etiTipo.Text = "Tipo:"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.txtTotal)
        Me.Agrupacion3.Controls.Add(Me.etiSubTotal)
        Me.Agrupacion3.Controls.Add(Me.txtIGV)
        Me.Agrupacion3.Controls.Add(Me.txtSubTotal)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel15)
        Me.Agrupacion3.Controls.Add(Me.etiIgv)
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(447, 125)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(193, 87)
        Me.Agrupacion3.TabIndex = 26
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtTotal
        '
        Appearance74.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Appearance = Appearance74
        Me.txtTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(61, 59)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NullText = "0.00"
        Me.txtTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(123, 21)
        Me.txtTotal.TabIndex = 5
        '
        'etiSubTotal
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Appearance75.TextVAlignAsString = "Middle"
        Me.etiSubTotal.Appearance = Appearance75
        Me.etiSubTotal.AutoSize = True
        Me.etiSubTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSubTotal.Location = New System.Drawing.Point(6, 9)
        Me.etiSubTotal.Name = "etiSubTotal"
        Me.etiSubTotal.Size = New System.Drawing.Size(49, 15)
        Me.etiSubTotal.TabIndex = 0
        Me.etiSubTotal.Text = "Subtotal:"
        '
        'txtIGV
        '
        Appearance76.ForeColor = System.Drawing.Color.Black
        Me.txtIGV.Appearance = Appearance76
        Me.txtIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.ForeColor = System.Drawing.Color.Black
        Me.txtIGV.Location = New System.Drawing.Point(61, 32)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.NullText = "0.00"
        Me.txtIGV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtIGV.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtIGV.ReadOnly = True
        Me.txtIGV.Size = New System.Drawing.Size(123, 21)
        Me.txtIGV.TabIndex = 3
        '
        'txtSubTotal
        '
        Appearance77.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Appearance = Appearance77
        Me.txtSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Location = New System.Drawing.Point(61, 5)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.NullText = "0.00"
        Me.txtSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtSubTotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(123, 21)
        Me.txtSubTotal.TabIndex = 1
        '
        'UltraLabel15
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Appearance78.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance78
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(22, 64)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel15.TabIndex = 4
        Me.UltraLabel15.Text = "Total:"
        '
        'etiIgv
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Appearance79.TextVAlignAsString = "Middle"
        Me.etiIgv.Appearance = Appearance79
        Me.etiIgv.AutoSize = True
        Me.etiIgv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiIgv.Location = New System.Drawing.Point(28, 37)
        Me.etiIgv.Name = "etiIgv"
        Me.etiIgv.Size = New System.Drawing.Size(27, 15)
        Me.etiIgv.TabIndex = 2
        Me.etiIgv.Text = "IGV:"
        '
        'agrDetraccion
        '
        Me.agrDetraccion.Controls.Add(Me.UltraLabel2)
        Me.agrDetraccion.Controls.Add(Me.UltraLabel5)
        Me.agrDetraccion.Controls.Add(Me.DecDetraer)
        Me.agrDetraccion.Controls.Add(Me.UltraLabel9)
        Me.agrDetraccion.Controls.Add(Me.DecMontoDetraccion)
        Me.agrDetraccion.Controls.Add(Me.UltraLabel8)
        Me.agrDetraccion.Controls.Add(Me.txtNetoPagar)
        Me.agrDetraccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetraccion.ForeColor = System.Drawing.Color.Black
        Me.agrDetraccion.Location = New System.Drawing.Point(603, 20)
        Me.agrDetraccion.Name = "agrDetraccion"
        Me.agrDetraccion.Size = New System.Drawing.Size(190, 105)
        Me.agrDetraccion.TabIndex = 0
        Me.agrDetraccion.Text = "Detracción"
        Me.agrDetraccion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel2
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Appearance80.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance80
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(155, 25)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(15, 15)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "%"
        '
        'UltraLabel5
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Appearance81.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance81
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(18, 25)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel5.TabIndex = 0
        Me.UltraLabel5.Text = "Porcentaje:"
        '
        'DecDetraer
        '
        Me.DecDetraer.Location = New System.Drawing.Point(86, 21)
        Me.DecDetraer.MaskInput = "nnn.nn"
        Me.DecDetraer.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DecDetraer.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DecDetraer.Name = "DecDetraer"
        Me.DecDetraer.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.DecDetraer.Size = New System.Drawing.Size(63, 22)
        Me.DecDetraer.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.DecDetraer.TabIndex = 1
        '
        'UltraLabel9
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Appearance82.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance82
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(41, 52)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel9.TabIndex = 2
        Me.UltraLabel9.Text = "Monto:"
        '
        'DecMontoDetraccion
        '
        Appearance83.ForeColor = System.Drawing.Color.Black
        Me.DecMontoDetraccion.Appearance = Appearance83
        Me.DecMontoDetraccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecMontoDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecMontoDetraccion.ForeColor = System.Drawing.Color.Black
        Me.DecMontoDetraccion.Location = New System.Drawing.Point(86, 48)
        Me.DecMontoDetraccion.MaskInput = "nnnnnnnnn.nn"
        Me.DecMontoDetraccion.Name = "DecMontoDetraccion"
        Me.DecMontoDetraccion.NullText = "0.00"
        Me.DecMontoDetraccion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecMontoDetraccion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecMontoDetraccion.ReadOnly = True
        Me.DecMontoDetraccion.Size = New System.Drawing.Size(95, 21)
        Me.DecMontoDetraccion.TabIndex = 4
        '
        'UltraLabel8
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Appearance84.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance84
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(6, 79)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(73, 15)
        Me.UltraLabel8.TabIndex = 5
        Me.UltraLabel8.Text = "Neto a Pagar:"
        '
        'txtNetoPagar
        '
        Appearance85.ForeColor = System.Drawing.Color.Black
        Me.txtNetoPagar.Appearance = Appearance85
        Me.txtNetoPagar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNetoPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetoPagar.ForeColor = System.Drawing.Color.Black
        Me.txtNetoPagar.Location = New System.Drawing.Point(86, 75)
        Me.txtNetoPagar.MaskInput = "nnnnnnnnn.nn"
        Me.txtNetoPagar.Name = "txtNetoPagar"
        Me.txtNetoPagar.NullText = "0.00"
        Me.txtNetoPagar.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtNetoPagar.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNetoPagar.ReadOnly = True
        Me.txtNetoPagar.Size = New System.Drawing.Size(95, 21)
        Me.txtNetoPagar.TabIndex = 6
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Red
        Me.lbl_etiqueta.Appearance = Appearance86
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_etiqueta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_etiqueta.Location = New System.Drawing.Point(1141, 1)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(57, 16)
        Me.lbl_etiqueta.TabIndex = 2
        Me.lbl_etiqueta.Text = "Etiqueta"
        Me.lbl_etiqueta.Visible = False
        '
        'UltraLabel22
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Appearance87.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance87
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(26, 79)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel22.TabIndex = 10
        Me.UltraLabel22.Text = "Cliente:"
        '
        'UltraLabel1
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Appearance88.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance88
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(301, 50)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel1.TabIndex = 8
        Me.UltraLabel1.Text = "Fecha:"
        '
        'fecFechaActual
        '
        Me.fecFechaActual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaActual.Location = New System.Drawing.Point(341, 48)
        Me.fecFechaActual.MaskInput = ""
        Me.fecFechaActual.Name = "fecFechaActual"
        Me.fecFechaActual.Size = New System.Drawing.Size(100, 22)
        Me.fecFechaActual.TabIndex = 9
        '
        'UltraLabel3
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Appearance89.ForeColor = System.Drawing.Color.Navy
        Appearance89.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance89
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(9, 135)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(58, 15)
        Me.UltraLabel3.TabIndex = 14
        Me.UltraLabel3.Text = "Tipo Pago:"
        '
        'UltraLabel6
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Appearance90.ForeColor = System.Drawing.Color.Navy
        Appearance90.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance90
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(458, 50)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel6.TabIndex = 20
        Me.UltraLabel6.Text = "Moneda:"
        '
        'decTc
        '
        Me.decTc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.decTc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTc.Location = New System.Drawing.Point(508, 101)
        Me.decTc.Name = "decTc"
        Me.decTc.ReadOnly = True
        Me.decTc.Size = New System.Drawing.Size(53, 21)
        Me.decTc.TabIndex = 25
        '
        'UltraLabel7
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Appearance91.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance91
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(480, 99)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(25, 15)
        Me.UltraLabel7.TabIndex = 24
        Me.UltraLabel7.Text = "T.C:"
        '
        'cboCliente
        '
        Appearance92.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Appearance = Appearance92
        Me.cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance93.Image = 7
        EditorButton2.Appearance = Appearance93
        Me.cboCliente.ButtonsRight.Add(EditorButton2)
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Location = New System.Drawing.Point(74, 77)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(367, 21)
        Me.cboCliente.TabIndex = 11
        Me.cboCliente.ValueMember = "Id"
        '
        'cboTipoPago
        '
        Appearance94.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance94
        Me.cboTipoPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoPago.DisplayMember = "Nombre"
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Location = New System.Drawing.Point(74, 131)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(265, 21)
        Me.cboTipoPago.TabIndex = 15
        Me.cboTipoPago.ValueMember = "Id"
        '
        'cboMoneda
        '
        Appearance95.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance95
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(508, 48)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(75, 21)
        Me.cboMoneda.TabIndex = 21
        Me.cboMoneda.ValueMember = "Id"
        '
        'decPorcenIGV
        '
        Me.decPorcenIGV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.decPorcenIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decPorcenIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decPorcenIGV.Location = New System.Drawing.Point(508, 74)
        Me.decPorcenIGV.Name = "decPorcenIGV"
        Me.decPorcenIGV.ReadOnly = True
        Me.decPorcenIGV.Size = New System.Drawing.Size(53, 21)
        Me.decPorcenIGV.TabIndex = 23
        '
        'Etiqueta14
        '
        Appearance96.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta14.Appearance = Appearance96
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(238, 25)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta14.TabIndex = 2
        Me.Etiqueta14.Text = "Estado:"
        '
        'UltraLabel11
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Appearance97.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance97
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(480, 76)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(27, 15)
        Me.UltraLabel11.TabIndex = 22
        Me.UltraLabel11.Text = "IGV:"
        '
        'cboEstadoFacturaM
        '
        Appearance98.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoFacturaM.Appearance = Appearance98
        Me.cboEstadoFacturaM.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoFacturaM.DisplayMember = "Nombre"
        Me.cboEstadoFacturaM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoFacturaM.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoFacturaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoFacturaM.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoFacturaM.Location = New System.Drawing.Point(284, 23)
        Me.cboEstadoFacturaM.Name = "cboEstadoFacturaM"
        Me.cboEstadoFacturaM.ReadOnly = True
        Me.cboEstadoFacturaM.Size = New System.Drawing.Size(157, 21)
        Me.cboEstadoFacturaM.TabIndex = 3
        Me.cboEstadoFacturaM.ValueMember = "Id"
        '
        'txtSerieM
        '
        Me.txtSerieM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieM.Location = New System.Drawing.Point(74, 50)
        Me.txtSerieM.MaxLength = 4
        Me.txtSerieM.Name = "txtSerieM"
        Me.txtSerieM.Size = New System.Drawing.Size(60, 21)
        Me.txtSerieM.TabIndex = 5
        '
        'txtNumeroM
        '
        Me.txtNumeroM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroM.Location = New System.Drawing.Point(192, 50)
        Me.txtNumeroM.MaxLength = 10
        Me.txtNumeroM.Name = "txtNumeroM"
        Me.txtNumeroM.Size = New System.Drawing.Size(102, 21)
        Me.txtNumeroM.TabIndex = 7
        '
        '_UltraTabPageControl2_Toolbars_Dock_Area_1_Left
        '
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Left.ForeColor = System.Drawing.Color.MidnightBlue
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Left.Location = New System.Drawing.Point(0, 0)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Left.Name = "_UltraTabPageControl2_Toolbars_Dock_Area_1_Left"
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Left.Size = New System.Drawing.Size(0, 686)
        '
        '_UltraTabPageControl2_Toolbars_Dock_Area_1_Right
        '
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Right.ForeColor = System.Drawing.Color.MidnightBlue
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Right.Location = New System.Drawing.Point(1220, 0)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Right.Name = "_UltraTabPageControl2_Toolbars_Dock_Area_1_Right"
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Right.Size = New System.Drawing.Size(0, 686)
        '
        '_UltraTabPageControl2_Toolbars_Dock_Area_1_Top
        '
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Top.ForeColor = System.Drawing.Color.MidnightBlue
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Top.Location = New System.Drawing.Point(0, 0)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Top.Name = "_UltraTabPageControl2_Toolbars_Dock_Area_1_Top"
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Top.Size = New System.Drawing.Size(1220, 0)
        '
        '_UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom
        '
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom.ForeColor = System.Drawing.Color.MidnightBlue
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom.Location = New System.Drawing.Point(0, 686)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom.Name = "_UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom"
        Me._UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom.Size = New System.Drawing.Size(1220, 0)
        '
        'ficFacturaCompra
        '
        Me.ficFacturaCompra.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficFacturaCompra.Controls.Add(Me.UltraTabPageControl1)
        Me.ficFacturaCompra.Controls.Add(Me.UltraTabPageControl2)
        Me.ficFacturaCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficFacturaCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficFacturaCompra.Location = New System.Drawing.Point(0, 24)
        Me.ficFacturaCompra.Name = "ficFacturaCompra"
        Me.ficFacturaCompra.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficFacturaCompra.Size = New System.Drawing.Size(1222, 709)
        Me.ficFacturaCompra.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficFacturaCompra.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficFacturaCompra.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1220, 686)
        '
        'odListadoDocumentos
        '
        Me.odListadoDocumentos.Band.Columns.AddRange(New Object() {UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70})
        '
        'odOrden
        '
        UltraDataColumn76.DataType = GetType(Date)
        UltraDataColumn77.DataType = GetType(Double)
        UltraDataColumn83.DataType = GetType(Boolean)
        Me.odOrden.Band.Columns.AddRange(New Object() {UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102})
        '
        'odServicio
        '
        UltraDataColumn111.DataType = GetType(Boolean)
        UltraDataColumn112.DataType = GetType(Boolean)
        UltraDataColumn112.DefaultValue = False
        Me.odServicio.Band.Columns.AddRange(New Object() {UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114})
        '
        'MenuContextual2
        '
        Me.MenuContextual2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual2.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiActualizar, Me.tsmiEliminar, Me.tsmiAnular, Me.tsmiEmitir, Me.tsmiDescargarPDF, Me.tsmiDescargarXML})
        Me.MenuContextual2.Name = "MenuContextual1"
        Me.MenuContextual2.Size = New System.Drawing.Size(181, 180)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(180, 22)
        Me.tsmiNuevo.Text = "Nuevo"
        Me.tsmiNuevo.ToolTipText = "Insertar un nuevo Requerimiento"
        '
        'tsmiActualizar
        '
        Me.tsmiActualizar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiActualizar.Name = "tsmiActualizar"
        Me.tsmiActualizar.Size = New System.Drawing.Size(180, 22)
        Me.tsmiActualizar.Text = "Actualizar"
        Me.tsmiActualizar.ToolTipText = "Actualizar o modificar el Requerimiento seleccionado"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(180, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        Me.tsmiEliminar.ToolTipText = "Eliminar el Requerimiento seleccionado"
        '
        'tsmiAnular
        '
        Me.tsmiAnular.Name = "tsmiAnular"
        Me.tsmiAnular.Size = New System.Drawing.Size(180, 22)
        Me.tsmiAnular.Text = "Anular"
        '
        'tsmiEmitir
        '
        Me.tsmiEmitir.Name = "tsmiEmitir"
        Me.tsmiEmitir.Size = New System.Drawing.Size(180, 22)
        Me.tsmiEmitir.Text = "Emitir"
        '
        'tsmiDescargarPDF
        '
        Me.tsmiDescargarPDF.Image = Global.ISL.Win.My.Resources.Resources.Rename
        Me.tsmiDescargarPDF.Name = "tsmiDescargarPDF"
        Me.tsmiDescargarPDF.Size = New System.Drawing.Size(180, 22)
        Me.tsmiDescargarPDF.Text = "Ver PDF"
        '
        'tsmiDescargarXML
        '
        Me.tsmiDescargarXML.Image = Global.ISL.Win.My.Resources.Resources.Rename
        Me.tsmiDescargarXML.Name = "tsmiDescargarXML"
        Me.tsmiDescargarXML.Size = New System.Drawing.Size(180, 22)
        Me.tsmiDescargarXML.Text = "Descargar XML"
        '
        'odDetalleDocumento
        '
        UltraDataColumn123.DataType = GetType(Boolean)
        UltraDataColumn123.DefaultValue = False
        UltraDataColumn132.DataType = GetType(Boolean)
        UltraDataColumn132.DefaultValue = False
        Me.odDetalleDocumento.Band.Columns.AddRange(New Object() {UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137})
        '
        'frm_FacturarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 733)
        Me.Controls.Add(Me.ficFacturaCompra)
        Me.Name = "frm_FacturarServicio"
        Me.Text = "Facturar Servicio"
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griListaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griListaDocumentoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrigenDatos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txtNumeroDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOrdenCompra.ResumeLayout(False)
        CType(Me.griListaFacturaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.cboEstadoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNroDoc.ResumeLayout(False)
        Me.gbNroDoc.PerformLayout()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresEmitido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        CType(Me.griAnticipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeListadoMatSer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeListadoMatSer.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.utcListadoMatSer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcListadoMatSer.ResumeLayout(False)
        CType(Me.griListaDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.decAnticipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrTipoBien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTipoBien.ResumeLayout(False)
        Me.agrTipoBien.PerformLayout()
        CType(Me.cboTipoBien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkElectronico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrImpresion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrImpresion.ResumeLayout(False)
        Me.agrImpresion.PerformLayout()
        CType(Me.fecPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetraccion.ResumeLayout(False)
        Me.agrDetraccion.PerformLayout()
        CType(Me.DecDetraer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecMontoDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetoPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decPorcenIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoFacturaM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficFacturaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficFacturaCompra.ResumeLayout(False)
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual2.ResumeLayout(False)
        CType(Me.odDetalleDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficFacturaCompra As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrOrdenCompra As ISL.Controles.Agrupacion
    Friend WithEvents griListaFacturaCompra As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents rbNroDoc As System.Windows.Forms.RadioButton
    Friend WithEvents rbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents gbDatosAdicionales As System.Windows.Forms.GroupBox
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstadoFactura As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerieD As ISL.Controles.Texto
    Friend WithEvents cboTipoDocumento As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents gbNroDoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresEmitido As ISL.Controles.Colores
    Friend WithEvents ColoresAnulado As ISL.Controles.Colores
    Friend WithEvents etiEmitido As ISL.Controles.Etiqueta
    Friend WithEvents etiAnulado As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents UltraToolbarsDockArea13 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea14 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea17 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea18 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea15 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea16 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea20 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea21 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea9 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea10 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea11 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea12 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents txtTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents etiSubTotal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtIGV As ISL.Controles.NumeroDecimal
    Friend WithEvents txtSubTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents etiIgv As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents agrDetraccion As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DecDetraer As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DecMontoDetraccion As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNetoPagar As ISL.Controles.NumeroDecimal
    Friend WithEvents lbl_etiqueta As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecFechaActual As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decTc As ISL.Controles.Texto
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCliente As ISL.Controles.ComboMaestros
    Friend WithEvents cboTipoPago As ISL.Controles.ComboMaestros
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents decPorcenIGV As ISL.Controles.Texto
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboEstadoFacturaM As ISL.Controles.ComboMaestros
    Friend WithEvents txtSerieM As ISL.Controles.Texto
    Friend WithEvents txtNumeroM As ISL.Controles.Texto
    Friend WithEvents odListadoDocumentos As ISL.Controles.OrigenDatos
    Friend WithEvents odOrden As ISL.Controles.OrigenDatos
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents odServicio As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents MenuContextual2 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAnular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEmitir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odDetalleDocumento As ISL.Controles.OrigenDatos
    Friend WithEvents _UltraTabPageControl2_Toolbars_Dock_Area_1_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _UltraTabPageControl2_Toolbars_Dock_Area_1_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _UltraTabPageControl2_Toolbars_Dock_Area_1_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _UltraTabPageControl2_Toolbars_Dock_Area_1_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents griListaDetalleFactura As ISL.Controles.Grilla
    Friend WithEvents gbeListadoMatSer As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents utcListadoMatSer As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaServicios As ISL.Controles.Grilla
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents MenuDetalle As ISL.Controles.Menu
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents txtTipoDocumento As ISL.Controles.Texto
    Friend WithEvents etiTipo As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents cboDireccion As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents fecPeriodo As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents agrImpresion As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griListaDocumentoVenta As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumeroDoc As ISL.Controles.Texto
    Friend WithEvents txtSerieDoc As ISL.Controles.Texto
    Friend WithEvents btnCargaDocAso As ISL.Controles.Boton
    Friend WithEvents verOmiteCta As System.Windows.Forms.CheckBox
    Friend WithEvents verCantidad As System.Windows.Forms.CheckBox
    Friend WithEvents OrigenDatos1 As ISL.Controles.OrigenDatos
    Friend WithEvents chkElectronico As ISL.Controles.Chequear
    Friend WithEvents cboTipoBien As ISL.Controles.Combo
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents txtOrdenCompra As ISL.Controles.Texto
    Friend WithEvents agrTipoBien As ISL.Controles.Agrupacion
    Friend WithEvents tsmiDescargarPDF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDescargarXML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cbAnticipo As System.Windows.Forms.CheckBox
    Friend WithEvents griAnticipos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents decAnticipo As ISL.Controles.NumeroDecimal
End Class
