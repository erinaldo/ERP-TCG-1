<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CompensacionSaldo
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
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdItemGasto")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis1")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis2")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vehiculo")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAsiento")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoFuncion")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigenProrrateo")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdItemGasto")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis1")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis2")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vehiculo")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAsiento")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoFuncion")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigenProrrateo")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdItemGasto")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis1")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis2")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAsiento")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoFuncion")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProrrateo")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdItemGasto")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis1")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis2")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAsiento")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoFuncion")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProrrateo")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.MenuAgregados = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.MenuAgregado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarAnalisis = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraDataSource4 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.filtro = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GridPersonalAgregado = New ISL.Controles.Grilla(Me.components)
        Me.gridCobranzaAgregado = New ISL.Controles.Grilla(Me.components)
        Me.gridDetallePersonal = New ISL.Controles.Grilla(Me.components)
        Me.gridCobranza = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.chkPersonal = New ISL.Controles.Chequear(Me.components)
        Me.chkPersonalCtas = New ISL.Controles.Chequear(Me.components)
        Me.cboClienteProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.chkEmpresas = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraPanel3 = New Infragistics.Win.Misc.UltraPanel()
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiImporteSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiImporteDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecFecha = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.OptProveedores = New System.Windows.Forms.RadioButton()
        Me.OptClientes = New System.Windows.Forms.RadioButton()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.MenuAgregados.SuspendLayout()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAgregado.SuspendLayout()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridPersonalAgregado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCobranzaAgregado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDetallePersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCobranza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        CType(Me.chkPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPersonalCtas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel3.ClientArea.SuspendLayout()
        Me.UltraPanel3.SuspendLayout()
        CType(Me.FecFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35})
        Me.UltraDataSource2.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarDocumento})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(121, 30)
        '
        'AgregarDocumento
        '
        Me.AgregarDocumento.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarDocumento.Name = "AgregarDocumento"
        Me.AgregarDocumento.Size = New System.Drawing.Size(120, 26)
        Me.AgregarDocumento.Text = "Agregar"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70})
        Me.UltraDataSource1.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'MenuAgregado
        '
        Me.MenuAgregado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuAgregado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarAnalisis})
        Me.MenuAgregado.Name = "mnu_Transferencias"
        Me.MenuAgregado.Size = New System.Drawing.Size(122, 30)
        '
        'EliminarAnalisis
        '
        Me.EliminarAnalisis.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarAnalisis.Name = "EliminarAnalisis"
        Me.EliminarAnalisis.Size = New System.Drawing.Size(121, 26)
        Me.EliminarAnalisis.Text = "Eliminar"
        '
        'UltraDataSource3
        '
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98})
        '
        'UltraDataSource4
        '
        Me.UltraDataSource4.Band.Columns.AddRange(New Object() {UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126})
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 109)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridPersonalAgregado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridCobranzaAgregado)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridDetallePersonal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridCobranza)
        Me.SplitContainer1.Size = New System.Drawing.Size(875, 367)
        Me.SplitContainer1.SplitterDistance = 164
        Me.SplitContainer1.TabIndex = 9
        Me.SplitContainer1.TabStop = False
        '
        'GridPersonalAgregado
        '
        Me.GridPersonalAgregado.ContextMenuStrip = Me.MenuAgregado
        Me.GridPersonalAgregado.DataSource = Me.UltraDataSource3
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "IdCuenta"
        UltraGridColumn4.Header.VisiblePosition = 7
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 91
        UltraGridColumn121.Header.VisiblePosition = 8
        UltraGridColumn121.Hidden = True
        UltraGridColumn121.Width = 147
        UltraGridColumn122.Header.VisiblePosition = 9
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.Header.VisiblePosition = 11
        UltraGridColumn123.Hidden = True
        UltraGridColumn123.Width = 245
        UltraGridColumn124.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn124.Header.VisiblePosition = 12
        UltraGridColumn124.Hidden = True
        UltraGridColumn124.Width = 118
        UltraGridColumn125.Header.VisiblePosition = 14
        UltraGridColumn125.Hidden = True
        UltraGridColumn125.Width = 164
        UltraGridColumn126.Header.VisiblePosition = 15
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 16
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 17
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 18
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 19
        UltraGridColumn130.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn131.CellAppearance = Appearance1
        UltraGridColumn131.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn131.Format = "#,##0.00"
        UltraGridColumn131.Header.VisiblePosition = 22
        UltraGridColumn132.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn132.CellAppearance = Appearance2
        UltraGridColumn132.Format = "#,##0.00"
        UltraGridColumn132.Header.VisiblePosition = 21
        UltraGridColumn132.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn132.Width = 95
        UltraGridColumn133.Header.Caption = "Moneda"
        UltraGridColumn133.Header.VisiblePosition = 20
        UltraGridColumn133.Width = 51
        UltraGridColumn134.Header.Caption = "Periodo"
        UltraGridColumn134.Header.VisiblePosition = 1
        UltraGridColumn134.Width = 67
        UltraGridColumn135.Header.VisiblePosition = 25
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn136.Header.VisiblePosition = 4
        UltraGridColumn136.Width = 57
        UltraGridColumn137.Header.VisiblePosition = 24
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.Header.VisiblePosition = 13
        UltraGridColumn138.Hidden = True
        UltraGridColumn138.Width = 244
        UltraGridColumn139.Header.VisiblePosition = 10
        UltraGridColumn139.Hidden = True
        UltraGridColumn139.Width = 205
        UltraGridColumn140.Header.VisiblePosition = 23
        UltraGridColumn140.Width = 77
        UltraGridColumn141.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn141.Header.VisiblePosition = 2
        UltraGridColumn141.Width = 57
        UltraGridColumn142.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn142.Header.VisiblePosition = 3
        UltraGridColumn142.Width = 74
        UltraGridColumn143.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn143.Header.VisiblePosition = 5
        UltraGridColumn143.Width = 293
        UltraGridColumn144.Header.VisiblePosition = 26
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn145.Header.VisiblePosition = 6
        UltraGridColumn146.Header.VisiblePosition = 27
        UltraGridColumn146.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146})
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridBand1.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridPersonalAgregado.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.GridPersonalAgregado.DisplayLayout.MaxColScrollRegions = 1
        Me.GridPersonalAgregado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridPersonalAgregado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GridPersonalAgregado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GridPersonalAgregado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridPersonalAgregado.DisplayLayout.Override.FilterUIProvider = Me.filtro
        Me.GridPersonalAgregado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridPersonalAgregado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GridPersonalAgregado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GridPersonalAgregado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPersonalAgregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPersonalAgregado.Location = New System.Drawing.Point(1160, 0)
        Me.GridPersonalAgregado.Name = "GridPersonalAgregado"
        Me.GridPersonalAgregado.Size = New System.Drawing.Size(0, 164)
        Me.GridPersonalAgregado.TabIndex = 1
        Me.GridPersonalAgregado.TabStop = False
        Me.GridPersonalAgregado.Text = "Aplicación"
        '
        'gridCobranzaAgregado
        '
        Me.gridCobranzaAgregado.ContextMenuStrip = Me.MenuAgregados
        Me.gridCobranzaAgregado.DataSource = Me.UltraDataSource2
        UltraGridColumn147.Header.VisiblePosition = 0
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.Caption = "Periodo"
        UltraGridColumn148.Header.VisiblePosition = 1
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn149.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn149.Header.Caption = "TipoDoc"
        UltraGridColumn149.Header.VisiblePosition = 4
        UltraGridColumn149.Width = 70
        UltraGridColumn150.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn150.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn150.Header.VisiblePosition = 5
        UltraGridColumn150.Width = 73
        UltraGridColumn151.Header.VisiblePosition = 6
        UltraGridColumn151.Width = 97
        UltraGridColumn152.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn152.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn152.Header.VisiblePosition = 7
        UltraGridColumn152.Width = 99
        UltraGridColumn153.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn153.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn153.Header.VisiblePosition = 8
        UltraGridColumn154.Header.VisiblePosition = 9
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 19
        UltraGridColumn155.Hidden = True
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn156.CellAppearance = Appearance3
        UltraGridColumn156.Format = "#,##0.00"
        UltraGridColumn156.Header.VisiblePosition = 12
        UltraGridColumn156.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn156.Width = 96
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn157.CellAppearance = Appearance4
        UltraGridColumn157.Format = "#,##0.00"
        UltraGridColumn157.Header.VisiblePosition = 14
        UltraGridColumn157.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn157.Width = 92
        UltraGridColumn158.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn158.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn158.Header.Caption = "Cliente/Proveedor"
        UltraGridColumn158.Header.VisiblePosition = 3
        UltraGridColumn158.Width = 253
        UltraGridColumn159.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn159.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn159.Header.VisiblePosition = 15
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 16
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn161.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn161.Header.Caption = "Tipo"
        UltraGridColumn161.Header.VisiblePosition = 2
        UltraGridColumn161.Width = 62
        UltraGridColumn162.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn162.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn162.Header.Caption = "Mon."
        UltraGridColumn162.Header.VisiblePosition = 10
        UltraGridColumn162.Width = 44
        UltraGridColumn163.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn163.CellAppearance = Appearance5
        UltraGridColumn163.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn163.Format = "#,##0.0000"
        UltraGridColumn163.Header.Caption = "T.C."
        UltraGridColumn163.Header.VisiblePosition = 11
        UltraGridColumn163.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn163.Width = 52
        UltraGridColumn164.Header.VisiblePosition = 17
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.Header.VisiblePosition = 18
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 20
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 26
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn168.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn168.Header.VisiblePosition = 21
        UltraGridColumn168.Hidden = True
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn169.CellAppearance = Appearance6
        UltraGridColumn169.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn169.Format = "#,##0.00"
        UltraGridColumn169.Header.Caption = "Monto Aplicar"
        UltraGridColumn169.Header.VisiblePosition = 22
        UltraGridColumn169.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn169.Width = 97
        UltraGridColumn170.Header.VisiblePosition = 23
        UltraGridColumn170.Hidden = True
        UltraGridColumn171.Header.VisiblePosition = 24
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 25
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 27
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.VisiblePosition = 28
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.Header.VisiblePosition = 29
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.VisiblePosition = 30
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 31
        UltraGridColumn177.Hidden = True
        UltraGridColumn178.Header.VisiblePosition = 32
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 33
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 34
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 13
        UltraGridColumn181.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181})
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCobranzaAgregado.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridCobranzaAgregado.DisplayLayout.MaxColScrollRegions = 1
        Me.gridCobranzaAgregado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCobranzaAgregado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridCobranzaAgregado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridCobranzaAgregado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridCobranzaAgregado.DisplayLayout.Override.FilterUIProvider = Me.filtro
        Me.gridCobranzaAgregado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridCobranzaAgregado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridCobranzaAgregado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridCobranzaAgregado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridCobranzaAgregado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCobranzaAgregado.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridCobranzaAgregado.Dock = System.Windows.Forms.DockStyle.Left
        Me.gridCobranzaAgregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridCobranzaAgregado.Location = New System.Drawing.Point(0, 0)
        Me.gridCobranzaAgregado.Name = "gridCobranzaAgregado"
        Me.gridCobranzaAgregado.Size = New System.Drawing.Size(1160, 164)
        Me.gridCobranzaAgregado.TabIndex = 0
        Me.gridCobranzaAgregado.TabStop = False
        Me.gridCobranzaAgregado.Text = "Aplicación"
        '
        'gridDetallePersonal
        '
        Me.gridDetallePersonal.ContextMenuStrip = Me.MenuDetalle
        Me.gridDetallePersonal.DataSource = Me.UltraDataSource4
        UltraGridColumn182.Header.VisiblePosition = 0
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.Caption = "IdCuenta"
        UltraGridColumn183.Header.VisiblePosition = 7
        UltraGridColumn183.Hidden = True
        UltraGridColumn183.Width = 93
        UltraGridColumn184.Header.VisiblePosition = 8
        UltraGridColumn184.Hidden = True
        UltraGridColumn184.Width = 146
        UltraGridColumn185.Header.VisiblePosition = 9
        UltraGridColumn185.Hidden = True
        UltraGridColumn186.Header.VisiblePosition = 11
        UltraGridColumn186.Hidden = True
        UltraGridColumn186.Width = 243
        UltraGridColumn187.Header.VisiblePosition = 12
        UltraGridColumn187.Hidden = True
        UltraGridColumn187.Width = 122
        UltraGridColumn188.Header.VisiblePosition = 14
        UltraGridColumn188.Hidden = True
        UltraGridColumn188.Width = 163
        UltraGridColumn189.Header.VisiblePosition = 15
        UltraGridColumn189.Hidden = True
        UltraGridColumn190.Header.VisiblePosition = 16
        UltraGridColumn190.Hidden = True
        UltraGridColumn191.Header.VisiblePosition = 17
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 18
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.VisiblePosition = 19
        UltraGridColumn193.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn194.CellAppearance = Appearance7
        UltraGridColumn194.Format = "#,##0.00"
        UltraGridColumn194.Header.VisiblePosition = 21
        UltraGridColumn194.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn194.Width = 74
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn195.CellAppearance = Appearance8
        UltraGridColumn195.Format = "#,##0.00"
        UltraGridColumn195.Header.VisiblePosition = 22
        UltraGridColumn195.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn195.Width = 88
        UltraGridColumn196.Header.Caption = "Moneda"
        UltraGridColumn196.Header.VisiblePosition = 20
        UltraGridColumn196.Width = 35
        UltraGridColumn197.Header.Caption = "Periodo"
        UltraGridColumn197.Header.VisiblePosition = 1
        UltraGridColumn197.Width = 60
        UltraGridColumn198.Header.VisiblePosition = 25
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.VisiblePosition = 10
        UltraGridColumn199.Hidden = True
        UltraGridColumn199.Width = 204
        UltraGridColumn200.Header.VisiblePosition = 23
        UltraGridColumn200.Width = 84
        UltraGridColumn201.Header.VisiblePosition = 13
        UltraGridColumn201.Hidden = True
        UltraGridColumn201.Width = 237
        UltraGridColumn202.Header.VisiblePosition = 4
        UltraGridColumn202.Width = 61
        UltraGridColumn203.Header.VisiblePosition = 24
        UltraGridColumn204.Header.VisiblePosition = 2
        UltraGridColumn204.Width = 42
        UltraGridColumn205.Header.VisiblePosition = 3
        UltraGridColumn205.Width = 79
        UltraGridColumn206.Header.VisiblePosition = 5
        UltraGridColumn206.Width = 283
        UltraGridColumn207.Header.Caption = "GastoFuncion"
        UltraGridColumn207.Header.VisiblePosition = 26
        UltraGridColumn207.Hidden = True
        UltraGridColumn208.Header.VisiblePosition = 6
        UltraGridColumn209.Header.VisiblePosition = 27
        UltraGridColumn209.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209})
        UltraGridBand3.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDetallePersonal.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.gridDetallePersonal.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDetallePersonal.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDetallePersonal.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDetallePersonal.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDetallePersonal.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDetallePersonal.DisplayLayout.Override.FilterUIProvider = Me.filtro
        Me.gridDetallePersonal.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDetallePersonal.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridDetallePersonal.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDetallePersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDetallePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDetallePersonal.Location = New System.Drawing.Point(1137, 0)
        Me.gridDetallePersonal.Name = "gridDetallePersonal"
        Me.gridDetallePersonal.Size = New System.Drawing.Size(0, 199)
        Me.gridDetallePersonal.TabIndex = 1
        Me.gridDetallePersonal.TabStop = False
        Me.gridDetallePersonal.Text = "Documentos por rendir"
        '
        'gridCobranza
        '
        Me.gridCobranza.ContextMenuStrip = Me.MenuDetalle
        Me.gridCobranza.DataSource = Me.UltraDataSource1
        UltraGridColumn210.Header.VisiblePosition = 0
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.Caption = "Periodo"
        UltraGridColumn211.Header.VisiblePosition = 1
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.Caption = "TipoDoc"
        UltraGridColumn212.Header.VisiblePosition = 4
        UltraGridColumn212.Width = 72
        UltraGridColumn213.Header.VisiblePosition = 5
        UltraGridColumn213.Width = 71
        UltraGridColumn214.Header.VisiblePosition = 6
        UltraGridColumn214.Width = 98
        UltraGridColumn215.Header.VisiblePosition = 7
        UltraGridColumn215.Width = 101
        UltraGridColumn216.Header.VisiblePosition = 8
        UltraGridColumn217.Header.VisiblePosition = 9
        UltraGridColumn217.Hidden = True
        UltraGridColumn218.Header.VisiblePosition = 10
        UltraGridColumn218.Hidden = True
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn219.CellAppearance = Appearance9
        UltraGridColumn219.Format = "#,##0.00"
        UltraGridColumn219.Header.VisiblePosition = 13
        UltraGridColumn219.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn219.Width = 103
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn220.CellAppearance = Appearance10
        UltraGridColumn220.Format = "#,##0.00"
        UltraGridColumn220.Header.VisiblePosition = 14
        UltraGridColumn220.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn220.Width = 103
        UltraGridColumn221.Header.Caption = "Cliente/Proveedor"
        UltraGridColumn221.Header.VisiblePosition = 3
        UltraGridColumn221.Width = 253
        UltraGridColumn222.Header.VisiblePosition = 15
        UltraGridColumn222.Hidden = True
        UltraGridColumn223.Header.VisiblePosition = 16
        UltraGridColumn223.Hidden = True
        UltraGridColumn224.Header.Caption = "Tipo"
        UltraGridColumn224.Header.VisiblePosition = 2
        UltraGridColumn224.Width = 72
        UltraGridColumn225.Header.Caption = "Mon."
        UltraGridColumn225.Header.VisiblePosition = 11
        UltraGridColumn225.Width = 40
        UltraGridColumn226.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn226.CellAppearance = Appearance11
        UltraGridColumn226.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn226.Format = "#,##0.0000"
        UltraGridColumn226.Header.Caption = "T.C."
        UltraGridColumn226.Header.VisiblePosition = 12
        UltraGridColumn226.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn226.Width = 56
        UltraGridColumn227.Header.VisiblePosition = 17
        UltraGridColumn227.Hidden = True
        UltraGridColumn228.Header.VisiblePosition = 18
        UltraGridColumn228.Hidden = True
        UltraGridColumn229.Header.VisiblePosition = 19
        UltraGridColumn229.Hidden = True
        UltraGridColumn230.Header.VisiblePosition = 21
        UltraGridColumn230.Hidden = True
        UltraGridColumn231.Header.VisiblePosition = 22
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.VisiblePosition = 20
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.Header.VisiblePosition = 23
        UltraGridColumn233.Hidden = True
        UltraGridColumn234.Header.VisiblePosition = 24
        UltraGridColumn234.Hidden = True
        UltraGridColumn235.Header.VisiblePosition = 25
        UltraGridColumn235.Hidden = True
        UltraGridColumn236.Header.VisiblePosition = 26
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.VisiblePosition = 27
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.Header.VisiblePosition = 28
        UltraGridColumn238.Hidden = True
        UltraGridColumn239.Header.VisiblePosition = 29
        UltraGridColumn239.Hidden = True
        UltraGridColumn240.Header.VisiblePosition = 30
        UltraGridColumn240.Hidden = True
        UltraGridColumn249.Header.VisiblePosition = 31
        UltraGridColumn249.Hidden = True
        UltraGridColumn250.Header.VisiblePosition = 32
        UltraGridColumn250.Hidden = True
        UltraGridColumn251.Header.VisiblePosition = 33
        UltraGridColumn251.Hidden = True
        UltraGridColumn252.Header.VisiblePosition = 34
        UltraGridColumn252.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252})
        Me.gridCobranza.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.gridCobranza.DisplayLayout.MaxColScrollRegions = 1
        Me.gridCobranza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCobranza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridCobranza.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridCobranza.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridCobranza.DisplayLayout.Override.FilterUIProvider = Me.filtro
        Me.gridCobranza.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridCobranza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridCobranza.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridCobranza.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridCobranza.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCobranza.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridCobranza.Dock = System.Windows.Forms.DockStyle.Left
        Me.gridCobranza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridCobranza.Location = New System.Drawing.Point(0, 0)
        Me.gridCobranza.Name = "gridCobranza"
        Me.gridCobranza.Size = New System.Drawing.Size(1137, 199)
        Me.gridCobranza.TabIndex = 0
        Me.gridCobranza.TabStop = False
        Me.gridCobranza.Text = "Documentos"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.OptProveedores)
        Me.Agrupacion2.Controls.Add(Me.OptClientes)
        Me.Agrupacion2.Controls.Add(Me.chkEmpresas)
        Me.Agrupacion2.Controls.Add(Me.UltraPanel2)
        Me.Agrupacion2.Controls.Add(Me.chkPersonalCtas)
        Me.Agrupacion2.Controls.Add(Me.cboClienteProveedor)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion2.Controls.Add(Me.UltraPanel3)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta29)
        Me.Agrupacion2.Controls.Add(Me.FecFecha)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion2.Controls.Add(Me.decTC)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion2.Controls.Add(Me.cboMoneda)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta31)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(875, 109)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Parametros para Cancelación:"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraPanel2
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.UltraPanel2.Appearance = Appearance14
        Me.UltraPanel2.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.chkPersonal)
        Me.UltraPanel2.Location = New System.Drawing.Point(470, 50)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(122, 25)
        Me.UltraPanel2.TabIndex = 14
        '
        'chkPersonal
        '
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.chkPersonal.Appearance = Appearance15
        Me.chkPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPersonal.ForeColor = System.Drawing.Color.Black
        Me.chkPersonal.Location = New System.Drawing.Point(25, 1)
        Me.chkPersonal.Name = "chkPersonal"
        Me.chkPersonal.Size = New System.Drawing.Size(71, 20)
        Me.chkPersonal.TabIndex = 0
        Me.chkPersonal.Text = "Personal"
        '
        'chkPersonalCtas
        '
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.chkPersonalCtas.Appearance = Appearance16
        Me.chkPersonalCtas.BackColor = System.Drawing.Color.Transparent
        Me.chkPersonalCtas.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkPersonalCtas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPersonalCtas.ForeColor = System.Drawing.Color.Black
        Me.chkPersonalCtas.Location = New System.Drawing.Point(598, 52)
        Me.chkPersonalCtas.Name = "chkPersonalCtas"
        Me.chkPersonalCtas.Size = New System.Drawing.Size(99, 20)
        Me.chkPersonalCtas.TabIndex = 15
        Me.chkPersonalCtas.Text = "PersonalCtas"
        Me.chkPersonalCtas.Visible = False
        '
        'cboClienteProveedor
        '
        Me.cboClienteProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteProveedor.DisplayMember = "Nombre"
        Me.cboClienteProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClienteProveedor.Location = New System.Drawing.Point(60, 50)
        Me.cboClienteProveedor.Name = "cboClienteProveedor"
        Me.cboClienteProveedor.Size = New System.Drawing.Size(357, 22)
        Me.cboClienteProveedor.TabIndex = 5
        Me.cboClienteProveedor.ValueMember = "Id"
        '
        'chkEmpresas
        '
        Appearance13.BorderColor = System.Drawing.Color.CadetBlue
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.chkEmpresas.Appearance = Appearance13
        Me.chkEmpresas.BackColor = System.Drawing.Color.Transparent
        Me.chkEmpresas.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkEmpresas.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dashed
        Me.chkEmpresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmpresas.ForeColor = System.Drawing.Color.Black
        Me.chkEmpresas.Location = New System.Drawing.Point(219, 26)
        Me.chkEmpresas.Name = "chkEmpresas"
        Me.chkEmpresas.Size = New System.Drawing.Size(133, 20)
        Me.chkEmpresas.TabIndex = 3
        Me.chkEmpresas.Text = "Diferentes Empresas"
        '
        'Etiqueta1
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance17
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(421, 28)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta1.TabIndex = 12
        Me.Etiqueta1.Text = "Montos:"
        '
        'UltraPanel3
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Me.UltraPanel3.Appearance = Appearance18
        Me.UltraPanel3.BorderStyle = Infragistics.Win.UIElementBorderStyle.Etched
        '
        'UltraPanel3.ClientArea
        '
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta15)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta14)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.EtiImporteSoles)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.EtiImporteDolares)
        Me.UltraPanel3.Location = New System.Drawing.Point(470, 22)
        Me.UltraPanel3.Name = "UltraPanel3"
        Me.UltraPanel3.Size = New System.Drawing.Size(341, 24)
        Me.UltraPanel3.TabIndex = 13
        '
        'Etiqueta15
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta15.Appearance = Appearance19
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(6, 2)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta15.TabIndex = 0
        Me.Etiqueta15.Text = "Importe S/.:"
        '
        'Etiqueta14
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta14.Appearance = Appearance20
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(192, 3)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta14.TabIndex = 2
        Me.Etiqueta14.Text = "Importe $.:"
        '
        'EtiImporteSoles
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.EtiImporteSoles.Appearance = Appearance21
        Me.EtiImporteSoles.AutoSize = True
        Me.EtiImporteSoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteSoles.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteSoles.Location = New System.Drawing.Point(79, 2)
        Me.EtiImporteSoles.Name = "EtiImporteSoles"
        Me.EtiImporteSoles.Size = New System.Drawing.Size(11, 14)
        Me.EtiImporteSoles.TabIndex = 1
        Me.EtiImporteSoles.Text = "0"
        '
        'EtiImporteDolares
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.EtiImporteDolares.Appearance = Appearance22
        Me.EtiImporteDolares.AutoSize = True
        Me.EtiImporteDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteDolares.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteDolares.Location = New System.Drawing.Point(254, 3)
        Me.EtiImporteDolares.Name = "EtiImporteDolares"
        Me.EtiImporteDolares.Size = New System.Drawing.Size(11, 14)
        Me.EtiImporteDolares.TabIndex = 3
        Me.EtiImporteDolares.Text = "0"
        '
        'Etiqueta29
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta29.Appearance = Appearance23
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta29.Location = New System.Drawing.Point(16, 78)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta29.TabIndex = 6
        Me.Etiqueta29.Text = "Fecha:"
        '
        'FecFecha
        '
        Appearance24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecFecha.Appearance = Appearance24
        Me.FecFecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecFecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecFecha.Location = New System.Drawing.Point(60, 78)
        Me.FecFecha.Name = "FecFecha"
        Me.FecFecha.Size = New System.Drawing.Size(95, 21)
        Me.FecFecha.TabIndex = 7
        '
        'Etiqueta4
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance25
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(161, 78)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(22, 14)
        Me.Etiqueta4.TabIndex = 8
        Me.Etiqueta4.Text = "TC:"
        '
        'decTC
        '
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.decTC.Appearance = Appearance26
        Me.decTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTC.ForeColor = System.Drawing.Color.Black
        Me.decTC.FormatString = ""
        Me.decTC.Location = New System.Drawing.Point(189, 78)
        Me.decTC.MaskInput = "{double:2.4}"
        Me.decTC.Name = "decTC"
        Me.decTC.NullText = "0.00"
        Me.decTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTC.Size = New System.Drawing.Size(68, 21)
        Me.decTC.TabIndex = 9
        '
        'Etiqueta3
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance27
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(263, 82)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta3.TabIndex = 10
        Me.Etiqueta3.Text = "Moneda:"
        '
        'cboMoneda
        '
        Appearance28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance28
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(316, 78)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(101, 21)
        Me.cboMoneda.TabIndex = 11
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta31
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta31.Appearance = Appearance29
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(13, 52)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta31.TabIndex = 4
        Me.Etiqueta31.Text = "Cta Cte:"
        '
        'OptProveedores
        '
        Me.OptProveedores.AutoSize = True
        Me.OptProveedores.BackColor = System.Drawing.Color.Transparent
        Me.OptProveedores.ForeColor = System.Drawing.Color.Navy
        Me.OptProveedores.Location = New System.Drawing.Point(128, 26)
        Me.OptProveedores.Name = "OptProveedores"
        Me.OptProveedores.Size = New System.Drawing.Size(85, 17)
        Me.OptProveedores.TabIndex = 2
        Me.OptProveedores.Text = "Proveedores"
        Me.OptProveedores.UseVisualStyleBackColor = False
        '
        'OptClientes
        '
        Me.OptClientes.AutoSize = True
        Me.OptClientes.BackColor = System.Drawing.Color.Transparent
        Me.OptClientes.Checked = True
        Me.OptClientes.ForeColor = System.Drawing.Color.Navy
        Me.OptClientes.Location = New System.Drawing.Point(60, 26)
        Me.OptClientes.Name = "OptClientes"
        Me.OptClientes.Size = New System.Drawing.Size(62, 17)
        Me.OptClientes.TabIndex = 1
        Me.OptClientes.TabStop = True
        Me.OptClientes.Text = "Clientes"
        Me.OptClientes.UseVisualStyleBackColor = False
        '
        'Etiqueta2
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance12
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(25, 28)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(29, 14)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "Tipo:"
        '
        'frm_CompensacionSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(875, 476)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Agrupacion2)
        Me.Name = "frm_CompensacionSaldo"
        Me.Text = "Cancelacion de saldos"
        Me.MenuAgregados.ResumeLayout(False)
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAgregado.ResumeLayout(False)
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridPersonalAgregado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCobranzaAgregado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDetallePersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCobranza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ResumeLayout(False)
        CType(Me.chkPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPersonalCtas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel3.ClientArea.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.PerformLayout()
        Me.UltraPanel3.ResumeLayout(False)
        CType(Me.FecFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents decTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents FecFecha As ISL.Controles.Fecha
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents EtiImporteDolares As ISL.Controles.Etiqueta
    Friend WithEvents EtiImporteSoles As ISL.Controles.Etiqueta
    Friend WithEvents gridCobranza As ISL.Controles.Grilla
    Friend WithEvents gridCobranzaAgregado As ISL.Controles.Grilla
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAgregados As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource4 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents GridPersonalAgregado As ISL.Controles.Grilla
    Friend WithEvents gridDetallePersonal As ISL.Controles.Grilla
    Friend WithEvents MenuAgregado As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarAnalisis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkPersonalCtas As ISL.Controles.Chequear
    Friend WithEvents chkPersonal As ISL.Controles.Chequear
    Friend WithEvents chkEmpresas As ISL.Controles.Chequear
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents UltraPanel3 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents cboClienteProveedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents filtro As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents OptProveedores As System.Windows.Forms.RadioButton
    Friend WithEvents OptClientes As System.Windows.Forms.RadioButton

End Class
