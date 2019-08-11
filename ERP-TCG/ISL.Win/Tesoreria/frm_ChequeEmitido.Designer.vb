<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChequeEmitido
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaBancaria")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCheque")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCobro")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorriente")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Centro")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ChequeEmitido))
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaBancaria")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCheque")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Detalle")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCobro")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConcepto")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorriente")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Centro")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Concepto")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoDocumento")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdChequeEmitido")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdChequeEmitido")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoDocumento")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
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
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCompra")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaChequesPendientes = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odChequesPendientes = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnEliminar = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAnular = New ISL.Controles.Boton(Me.components)
        Me.btnCobrar = New ISL.Controles.Boton(Me.components)
        Me.btnAprobar = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboCentroL = New ISL.Controles.Combo(Me.components)
        Me.etiCentro = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColorAnulado = New ISL.Controles.Colores(Me.components)
        Me.ColorCobrado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresAprobado = New ISL.Controles.Colores(Me.components)
        Me.ColorEmitido = New ISL.Controles.Colores(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.gridDocumentosAsociados = New ISL.Controles.Grilla(Me.components)
        Me.odChequeDocumento = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.expDocumento = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel11 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griListaDocumentoCompra = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboDocumentoAlmacen = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnBuscarDocumento = New ISL.Controles.Boton(Me.components)
        Me.gbNroDoc = New System.Windows.Forms.GroupBox()
        Me.txtSerieDoc = New ISL.Controles.Texto(Me.components)
        Me.txtNumeroDoc = New ISL.Controles.Texto(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaCobro = New System.Windows.Forms.DateTimePicker()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboProveedores = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.rdbCtaAdm = New System.Windows.Forms.RadioButton()
        Me.rbtCtaTrabajador = New System.Windows.Forms.RadioButton()
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajadores = New ISL.Controles.Combo(Me.components)
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiConcepto = New ISL.Controles.Etiqueta(Me.components)
        Me.cboConcepto = New ISL.Controles.Combo(Me.components)
        Me.chkCtaAdm = New System.Windows.Forms.CheckBox()
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnNuevoProveedor = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaBancaria = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.numMonto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtNroCheque = New ISL.Controles.Texto(Me.components)
        Me.odListadoDocumentos = New ISL.Controles.OrigenDatos(Me.components)
        Me.ficChequesPendientes = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.griListaChequesPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odChequesPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboCentroL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.ColorAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCobrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresAprobado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEmitido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.gridDocumentosAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odChequeDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expDocumento.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel11.SuspendLayout()
        CType(Me.griListaDocumentoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.cboDocumentoAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNroDoc.SuspendLayout()
        CType(Me.txtSerieDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.cboProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficChequesPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficChequesPendientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1107, 595)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.griListaChequesPendientes)
        Me.Agrupacion2.Controls.Add(Me.agrMenuLista)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 94)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1107, 501)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaChequesPendientes
        '
        Me.griListaChequesPendientes.ContextMenuStrip = Me.MenuContextual1
        Me.griListaChequesPendientes.DataSource = Me.odChequesPendientes
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn2.Width = 70
        UltraGridColumn3.Header.VisiblePosition = 7
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 11
        UltraGridColumn4.Width = 165
        UltraGridColumn5.Header.VisiblePosition = 10
        UltraGridColumn5.Width = 63
        UltraGridColumn6.Header.VisiblePosition = 8
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Width = 134
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn8.Width = 79
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Width = 308
        UltraGridColumn10.Header.VisiblePosition = 12
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance1
        UltraGridColumn11.Format = "#,###,###,##0.00"
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn11.Header.Appearance = Appearance2
        UltraGridColumn11.Header.VisiblePosition = 5
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.Width = 86
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 14
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 16
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.Caption = "Proveedor/Trabajador"
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn17.Width = 228
        UltraGridColumn18.Header.VisiblePosition = 18
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 19
        UltraGridColumn20.Header.VisiblePosition = 20
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 21
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 22
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 23
        UltraGridColumn24.Header.VisiblePosition = 6
        UltraGridColumn24.Width = 192
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25})
        Me.griListaChequesPendientes.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaChequesPendientes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaChequesPendientes.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaChequesPendientes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.griListaChequesPendientes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaChequesPendientes.DisplayLayout.GroupByBox.Hidden = True
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaChequesPendientes.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.griListaChequesPendientes.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaChequesPendientes.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaChequesPendientes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaChequesPendientes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaChequesPendientes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaChequesPendientes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance6.BorderColor = System.Drawing.Color.Silver
        Me.griListaChequesPendientes.DisplayLayout.Override.CellAppearance = Appearance6
        Me.griListaChequesPendientes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaChequesPendientes.DisplayLayout.Override.CellPadding = 0
        Me.griListaChequesPendientes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaChequesPendientes.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaChequesPendientes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griListaChequesPendientes.DisplayLayout.Override.GroupByRowAppearance = Appearance7
        Appearance8.TextHAlignAsString = "Left"
        Me.griListaChequesPendientes.DisplayLayout.Override.HeaderAppearance = Appearance8
        Me.griListaChequesPendientes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Me.griListaChequesPendientes.DisplayLayout.Override.RowAppearance = Appearance9
        Me.griListaChequesPendientes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaChequesPendientes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaChequesPendientes.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaChequesPendientes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaChequesPendientes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaChequesPendientes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaChequesPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaChequesPendientes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaChequesPendientes.Location = New System.Drawing.Point(3, 33)
        Me.griListaChequesPendientes.Name = "griListaChequesPendientes"
        Me.griListaChequesPendientes.Size = New System.Drawing.Size(1101, 465)
        Me.griListaChequesPendientes.TabIndex = 1
        Me.griListaChequesPendientes.TabStop = False
        Me.griListaChequesPendientes.Text = "Grilla1"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EvaluarToolStripMenuItem, Me.CobrarToolStripMenuItem, Me.AnularToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(112, 136)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EvaluarToolStripMenuItem
        '
        Me.EvaluarToolStripMenuItem.Image = CType(resources.GetObject("EvaluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EvaluarToolStripMenuItem.Name = "EvaluarToolStripMenuItem"
        Me.EvaluarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.EvaluarToolStripMenuItem.Text = "Aprobar"
        '
        'CobrarToolStripMenuItem
        '
        Me.CobrarToolStripMenuItem.Image = CType(resources.GetObject("CobrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CobrarToolStripMenuItem.Name = "CobrarToolStripMenuItem"
        Me.CobrarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.CobrarToolStripMenuItem.Text = "Cobrar"
        '
        'AnularToolStripMenuItem
        '
        Me.AnularToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Me.AnularToolStripMenuItem.Name = "AnularToolStripMenuItem"
        Me.AnularToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AnularToolStripMenuItem.Text = "Anular"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'odChequesPendientes
        '
        UltraDataColumn2.DataType = GetType(Date)
        UltraDataColumn10.DataType = GetType(Date)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn18.DataType = GetType(Boolean)
        Me.odChequesPendientes.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnEliminar)
        Me.agrMenuLista.Controls.Add(Me.btnAnular)
        Me.agrMenuLista.Controls.Add(Me.btnCobrar)
        Me.agrMenuLista.Controls.Add(Me.btnAprobar)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 3)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1101, 30)
        Me.agrMenuLista.TabIndex = 0
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEliminar
        '
        Appearance10.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance10.Image = "16 (Delete).ico"
        Me.btnEliminar.Appearance = Appearance10
        Me.btnEliminar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageList = Me.imagenes
        Me.btnEliminar.Location = New System.Drawing.Point(219, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(72, 24)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "16 (Ok).ico")
        Me.imagenes.Images.SetKeyName(1, "16 (Money bag).ico")
        Me.imagenes.Images.SetKeyName(2, "16 (Minus).ico")
        Me.imagenes.Images.SetKeyName(3, "16 (Delete).ico")
        Me.imagenes.Images.SetKeyName(4, "16 (File new).ico")
        '
        'btnAnular
        '
        Appearance11.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance11.Image = "16 (Minus).ico"
        Me.btnAnular.Appearance = Appearance11
        Me.btnAnular.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnular.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnular.Enabled = False
        Me.btnAnular.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.ForeColor = System.Drawing.Color.Black
        Me.btnAnular.ImageList = Me.imagenes
        Me.btnAnular.Location = New System.Drawing.Point(147, 3)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(72, 24)
        Me.btnAnular.TabIndex = 2
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCobrar
        '
        Appearance12.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance12.Image = "16 (Money bag).ico"
        Me.btnCobrar.Appearance = Appearance12
        Me.btnCobrar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCobrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCobrar.Enabled = False
        Me.btnCobrar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.ForeColor = System.Drawing.Color.Black
        Me.btnCobrar.ImageList = Me.imagenes
        Me.btnCobrar.Location = New System.Drawing.Point(75, 3)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(72, 24)
        Me.btnCobrar.TabIndex = 1
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAprobar
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance13.Image = "16 (Ok).ico"
        Me.btnAprobar.Appearance = Appearance13
        Me.btnAprobar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAprobar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAprobar.Enabled = False
        Me.btnAprobar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.Black
        Me.btnAprobar.ImageList = Me.imagenes
        Me.btnAprobar.Location = New System.Drawing.Point(3, 3)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(72, 24)
        Me.btnAprobar.TabIndex = 0
        Me.btnAprobar.Text = "Aprobar"
        Me.btnAprobar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.cboCentroL)
        Me.Agrupacion1.Controls.Add(Me.etiCentro)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.fecHasta)
        Me.Agrupacion1.Controls.Add(Me.fecDesde)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1107, 94)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Datos:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboCentroL
        '
        Appearance14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroL.Appearance = Appearance14
        Me.cboCentroL.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentroL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroL.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroL.Location = New System.Drawing.Point(206, 32)
        Me.cboCentroL.Name = "cboCentroL"
        Me.cboCentroL.Size = New System.Drawing.Size(144, 21)
        Me.cboCentroL.TabIndex = 5
        Me.cboCentroL.ValueMember = "Id"
        '
        'etiCentro
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.etiCentro.Appearance = Appearance15
        Me.etiCentro.AutoSize = True
        Me.etiCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCentro.ForeColor = System.Drawing.Color.Black
        Me.etiCentro.Location = New System.Drawing.Point(160, 36)
        Me.etiCentro.Name = "etiCentro"
        Me.etiCentro.Size = New System.Drawing.Size(40, 14)
        Me.etiCentro.TabIndex = 4
        Me.etiCentro.Text = "Centro:"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.ColorAnulado)
        Me.Agrupacion5.Controls.Add(Me.ColorCobrado)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion5.Controls.Add(Me.ColoresAprobado)
        Me.Agrupacion5.Controls.Add(Me.ColorEmitido)
        Me.Agrupacion5.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion5.Controls.Add(Me.etiGenerada)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(606, 26)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(308, 62)
        Me.Agrupacion5.TabIndex = 6
        Me.Agrupacion5.Text = "Estados"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorAnulado
        '
        Me.ColorAnulado.Color = System.Drawing.Color.Tomato
        Me.ColorAnulado.Location = New System.Drawing.Point(234, 33)
        Me.ColorAnulado.Name = "ColorAnulado"
        Me.ColorAnulado.Size = New System.Drawing.Size(43, 21)
        Me.ColorAnulado.TabIndex = 7
        Me.ColorAnulado.Text = "Tomato"
        '
        'ColorCobrado
        '
        Me.ColorCobrado.Color = System.Drawing.Color.LightGreen
        Me.ColorCobrado.Location = New System.Drawing.Point(162, 33)
        Me.ColorCobrado.Name = "ColorCobrado"
        Me.ColorCobrado.Size = New System.Drawing.Size(43, 21)
        Me.ColorCobrado.TabIndex = 5
        Me.ColorCobrado.Text = "LightGreen"
        '
        'Etiqueta9
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Appearance = Appearance16
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(235, 18)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta9.TabIndex = 6
        Me.Etiqueta9.Text = "Anulado"
        '
        'Etiqueta4
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Appearance = Appearance17
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(162, 18)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta4.TabIndex = 4
        Me.Etiqueta4.Text = "Cobrado"
        '
        'ColoresAprobado
        '
        Me.ColoresAprobado.Color = System.Drawing.Color.LightSteelBlue
        Me.ColoresAprobado.Location = New System.Drawing.Point(87, 33)
        Me.ColoresAprobado.Name = "ColoresAprobado"
        Me.ColoresAprobado.Size = New System.Drawing.Size(44, 21)
        Me.ColoresAprobado.TabIndex = 3
        Me.ColoresAprobado.Text = "LightSteelBlue"
        '
        'ColorEmitido
        '
        Me.ColorEmitido.Color = System.Drawing.Color.White
        Me.ColorEmitido.Location = New System.Drawing.Point(13, 33)
        Me.ColorEmitido.Name = "ColorEmitido"
        Me.ColorEmitido.Size = New System.Drawing.Size(46, 21)
        Me.ColorEmitido.TabIndex = 1
        Me.ColorEmitido.Text = "White"
        '
        'etiEnProceso
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnProceso.Appearance = Appearance18
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(88, 18)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(51, 15)
        Me.etiEnProceso.TabIndex = 2
        Me.etiEnProceso.Text = "Aprobado"
        '
        'etiGenerada
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance19
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(9, 18)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(40, 15)
        Me.etiGenerada.TabIndex = 0
        Me.etiGenerada.Text = "Emitido"
        '
        'Etiqueta2
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance20
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(12, 60)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Hasta:"
        '
        'Etiqueta1
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance21
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(9, 36)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Desde:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(53, 59)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(100, 20)
        Me.fecHasta.TabIndex = 3
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(53, 33)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(100, 20)
        Me.fecDesde.TabIndex = 1
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1107, 595)
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.Agrupacion7)
        Me.Agrupacion6.Controls.Add(Me.expDocumento)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 321)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(1107, 274)
        Me.Agrupacion6.TabIndex = 2
        Me.Agrupacion6.Text = "Documentos a Pagar"
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.Agrupacion6.Visible = False
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.gridDocumentosAsociados)
        Me.Agrupacion7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion7.Location = New System.Drawing.Point(26, 16)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(1078, 255)
        Me.Agrupacion7.TabIndex = 1
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gridDocumentosAsociados
        '
        Me.gridDocumentosAsociados.DataSource = Me.odChequeDocumento
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Appearance22.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridDocumentosAsociados.DisplayLayout.Appearance = Appearance22
        UltraGridColumn28.Header.VisiblePosition = 0
        UltraGridColumn28.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 1
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 2
        UltraGridColumn34.Hidden = True
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn35.CellAppearance = Appearance23
        UltraGridColumn35.Header.Caption = "Saldo"
        UltraGridColumn35.Header.VisiblePosition = 6
        UltraGridColumn35.MaskInput = "{double:9.2}"
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn35.Width = 86
        UltraGridColumn36.Header.VisiblePosition = 3
        UltraGridColumn36.Width = 285
        Appearance24.TextHAlignAsString = "Center"
        UltraGridColumn37.CellAppearance = Appearance24
        UltraGridColumn37.Header.VisiblePosition = 4
        UltraGridColumn37.Width = 125
        UltraGridColumn59.Header.VisiblePosition = 5
        UltraGridColumn59.Width = 105
        UltraGridColumn26.Header.VisiblePosition = 7
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 8
        UltraGridColumn27.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn28, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn59, UltraGridColumn26, UltraGridColumn27})
        Me.gridDocumentosAsociados.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridDocumentosAsociados.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridDocumentosAsociados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance25.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.gridDocumentosAsociados.DisplayLayout.GroupByBox.Appearance = Appearance25
        Appearance26.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridDocumentosAsociados.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance26
        Me.gridDocumentosAsociados.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridDocumentosAsociados.DisplayLayout.GroupByBox.Hidden = True
        Appearance27.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance27.BackColor2 = System.Drawing.SystemColors.Control
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridDocumentosAsociados.DisplayLayout.GroupByBox.PromptAppearance = Appearance27
        Me.gridDocumentosAsociados.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDocumentosAsociados.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridDocumentosAsociados.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentosAsociados.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDocumentosAsociados.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridDocumentosAsociados.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridDocumentosAsociados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDocumentosAsociados.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDocumentosAsociados.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridDocumentosAsociados.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDocumentosAsociados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance28.BorderColor = System.Drawing.Color.Silver
        Me.gridDocumentosAsociados.DisplayLayout.Override.RowAppearance = Appearance28
        Me.gridDocumentosAsociados.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDocumentosAsociados.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDocumentosAsociados.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridDocumentosAsociados.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridDocumentosAsociados.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridDocumentosAsociados.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gridDocumentosAsociados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDocumentosAsociados.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDocumentosAsociados.Location = New System.Drawing.Point(3, 3)
        Me.gridDocumentosAsociados.Name = "gridDocumentosAsociados"
        Me.gridDocumentosAsociados.Size = New System.Drawing.Size(1072, 249)
        Me.gridDocumentosAsociados.TabIndex = 0
        Me.gridDocumentosAsociados.Text = "Grilla2"
        '
        'odChequeDocumento
        '
        UltraDataColumn29.DataType = GetType(Double)
        Me.odChequeDocumento.Band.Columns.AddRange(New Object() {UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34})
        '
        'expDocumento
        '
        Me.expDocumento.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.expDocumento.Controls.Add(Me.UltraExpandableGroupBoxPanel11)
        Me.expDocumento.Dock = System.Windows.Forms.DockStyle.Left
        Me.expDocumento.Expanded = False
        Me.expDocumento.ExpandedSize = New System.Drawing.Size(704, 255)
        Me.expDocumento.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.expDocumento.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.expDocumento.Location = New System.Drawing.Point(3, 16)
        Me.expDocumento.Name = "expDocumento"
        Me.expDocumento.Size = New System.Drawing.Size(23, 255)
        Me.expDocumento.TabIndex = 0
        Me.expDocumento.TabStop = False
        Me.expDocumento.Text = "Documentos"
        Me.expDocumento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel11
        '
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.griListaDocumentoCompra)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Agrupacion9)
        Me.UltraExpandableGroupBoxPanel11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel11.Name = "UltraExpandableGroupBoxPanel11"
        Me.UltraExpandableGroupBoxPanel11.Size = New System.Drawing.Size(676, 259)
        Me.UltraExpandableGroupBoxPanel11.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel11.Visible = False
        '
        'griListaDocumentoCompra
        '
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaDocumentoCompra.DisplayLayout.Appearance = Appearance29
        UltraGridColumn86.Header.VisiblePosition = 0
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 1
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 2
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 3
        UltraGridColumn89.Hidden = True
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn90.CellAppearance = Appearance30
        UltraGridColumn90.Header.VisiblePosition = 9
        UltraGridColumn90.Hidden = True
        UltraGridColumn90.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn90.Width = 78
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn91.CellAppearance = Appearance31
        UltraGridColumn91.Header.VisiblePosition = 10
        UltraGridColumn91.Hidden = True
        UltraGridColumn91.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn91.Width = 77
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn92.CellAppearance = Appearance32
        UltraGridColumn92.Header.VisiblePosition = 12
        UltraGridColumn92.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn93.Header.VisiblePosition = 8
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 13
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 14
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 15
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 7
        UltraGridColumn97.Width = 83
        UltraGridColumn98.Header.VisiblePosition = 16
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 17
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 18
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 5
        UltraGridColumn101.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn101.Width = 88
        UltraGridColumn102.Header.VisiblePosition = 6
        UltraGridColumn102.Hidden = True
        UltraGridColumn102.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn103.CellAppearance = Appearance33
        UltraGridColumn103.Header.VisiblePosition = 11
        UltraGridColumn103.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn104.Header.VisiblePosition = 19
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 20
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 21
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 22
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 23
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 24
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.VisiblePosition = 25
        UltraGridColumn110.Hidden = True
        UltraGridColumn111.Header.VisiblePosition = 26
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 27
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 28
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.Caption = "Proveedor"
        UltraGridColumn114.Header.VisiblePosition = 4
        UltraGridColumn114.Width = 270
        UltraGridColumn115.Header.VisiblePosition = 29
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 30
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 31
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 32
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.VisiblePosition = 33
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 34
        UltraGridColumn120.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120})
        Me.griListaDocumentoCompra.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListaDocumentoCompra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDocumentoCompra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDocumentoCompra.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griListaDocumentoCompra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDocumentoCompra.DisplayLayout.GroupByBox.Hidden = True
        Me.griListaDocumentoCompra.DisplayLayout.GroupByBox.Prompt = " Drag a column header here to group by that column."
        Me.griListaDocumentoCompra.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDocumentoCompra.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaDocumentoCompra.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDocumentoCompra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDocumentoCompra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDocumentoCompra.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaDocumentoCompra.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None
        Me.griListaDocumentoCompra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaDocumentoCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        Me.griListaDocumentoCompra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDocumentoCompra.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaDocumentoCompra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaDocumentoCompra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaDocumentoCompra.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaDocumentoCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDocumentoCompra.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.griListaDocumentoCompra.Location = New System.Drawing.Point(0, 104)
        Me.griListaDocumentoCompra.Name = "griListaDocumentoCompra"
        Me.griListaDocumentoCompra.Size = New System.Drawing.Size(676, 155)
        Me.griListaDocumentoCompra.TabIndex = 1
        Me.griListaDocumentoCompra.TabStop = False
        Me.griListaDocumentoCompra.Text = "UltraGrid1"
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.cboDocumentoAlmacen)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta46)
        Me.Agrupacion9.Controls.Add(Me.btnBuscarDocumento)
        Me.Agrupacion9.Controls.Add(Me.gbNroDoc)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(676, 104)
        Me.Agrupacion9.TabIndex = 0
        Me.Agrupacion9.Text = "Documento"
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboDocumentoAlmacen
        '
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.cboDocumentoAlmacen.Appearance = Appearance34
        Me.cboDocumentoAlmacen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDocumentoAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDocumentoAlmacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDocumentoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocumentoAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboDocumentoAlmacen.Location = New System.Drawing.Point(13, 53)
        Me.cboDocumentoAlmacen.Name = "cboDocumentoAlmacen"
        Me.cboDocumentoAlmacen.Size = New System.Drawing.Size(261, 21)
        Me.cboDocumentoAlmacen.TabIndex = 1
        Me.cboDocumentoAlmacen.ValueMember = "IdTipoDocumento"
        '
        'Etiqueta46
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta46.Appearance = Appearance35
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta46.Location = New System.Drawing.Point(14, 36)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(88, 14)
        Me.Etiqueta46.TabIndex = 0
        Me.Etiqueta46.Text = "Tipo Documento:"
        '
        'btnBuscarDocumento
        '
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.btnBuscarDocumento.Appearance = Appearance36
        Me.btnBuscarDocumento.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDocumento.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarDocumento.Location = New System.Drawing.Point(467, 50)
        Me.btnBuscarDocumento.Name = "btnBuscarDocumento"
        Me.btnBuscarDocumento.Size = New System.Drawing.Size(83, 25)
        Me.btnBuscarDocumento.TabIndex = 3
        Me.btnBuscarDocumento.Text = "Buscar"
        '
        'gbNroDoc
        '
        Me.gbNroDoc.BackColor = System.Drawing.Color.Transparent
        Me.gbNroDoc.Controls.Add(Me.txtSerieDoc)
        Me.gbNroDoc.Controls.Add(Me.txtNumeroDoc)
        Me.gbNroDoc.ForeColor = System.Drawing.Color.Navy
        Me.gbNroDoc.Location = New System.Drawing.Point(283, 31)
        Me.gbNroDoc.Name = "gbNroDoc"
        Me.gbNroDoc.Size = New System.Drawing.Size(178, 51)
        Me.gbNroDoc.TabIndex = 2
        Me.gbNroDoc.TabStop = False
        Me.gbNroDoc.Text = "N° de Documento:"
        '
        'txtSerieDoc
        '
        Me.txtSerieDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieDoc.Location = New System.Drawing.Point(20, 22)
        Me.txtSerieDoc.MaxLength = 4
        Me.txtSerieDoc.Name = "txtSerieDoc"
        Me.txtSerieDoc.Size = New System.Drawing.Size(42, 21)
        Me.txtSerieDoc.TabIndex = 0
        '
        'txtNumeroDoc
        '
        Me.txtNumeroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDoc.Location = New System.Drawing.Point(68, 22)
        Me.txtNumeroDoc.MaxLength = 10
        Me.txtNumeroDoc.Name = "txtNumeroDoc"
        Me.txtNumeroDoc.Size = New System.Drawing.Size(102, 21)
        Me.txtNumeroDoc.TabIndex = 1
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion4.Controls.Add(Me.fecFechaCobro)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 283)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1107, 38)
        Me.Agrupacion4.TabIndex = 1
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta10
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance37
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(38, 11)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta10.TabIndex = 0
        Me.Etiqueta10.Text = "Fecha Cobro:"
        '
        'fecFechaCobro
        '
        Me.fecFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaCobro.Location = New System.Drawing.Point(114, 10)
        Me.fecFechaCobro.Name = "fecFechaCobro"
        Me.fecFechaCobro.Size = New System.Drawing.Size(101, 20)
        Me.fecFechaCobro.TabIndex = 1
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.cboProveedores)
        Me.Agrupacion3.Controls.Add(Me.rdbCtaAdm)
        Me.Agrupacion3.Controls.Add(Me.rbtCtaTrabajador)
        Me.Agrupacion3.Controls.Add(Me.etiTrabajador)
        Me.Agrupacion3.Controls.Add(Me.cboTrabajadores)
        Me.Agrupacion3.Controls.Add(Me.txtDescripcion)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion3.Controls.Add(Me.etiConcepto)
        Me.Agrupacion3.Controls.Add(Me.cboConcepto)
        Me.Agrupacion3.Controls.Add(Me.chkCtaAdm)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion3.Controls.Add(Me.btnNuevoProveedor)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion3.Controls.Add(Me.fecFechaEmision)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion3.Controls.Add(Me.cboCuentaBancaria)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion3.Controls.Add(Me.numMonto)
        Me.Agrupacion3.Controls.Add(Me.txtNroCheque)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1107, 283)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboProveedores
        '
        Me.cboProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance38.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance38
        Me.cboProveedores.ButtonsRight.Add(EditorButton1)
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
        UltraGridColumn175.Width = 200
        UltraGridColumn176.Header.VisiblePosition = 11
        UltraGridColumn176.Hidden = True
        UltraGridColumn176.Width = 54
        UltraGridColumn177.Header.VisiblePosition = 12
        UltraGridColumn177.Hidden = True
        UltraGridColumn177.Width = 55
        UltraGridColumn178.Header.VisiblePosition = 13
        UltraGridColumn178.Width = 198
        UltraGridColumn179.Header.VisiblePosition = 14
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 15
        UltraGridColumn180.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180})
        Me.cboProveedores.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cboProveedores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedores.DropDownWidth = 400
        Me.cboProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedores.Location = New System.Drawing.Point(113, 9)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(410, 22)
        Me.cboProveedores.TabIndex = 1
        '
        'rdbCtaAdm
        '
        Me.rdbCtaAdm.AutoSize = True
        Me.rdbCtaAdm.BackColor = System.Drawing.Color.Transparent
        Me.rdbCtaAdm.Enabled = False
        Me.rdbCtaAdm.ForeColor = System.Drawing.Color.Navy
        Me.rdbCtaAdm.Location = New System.Drawing.Point(308, 40)
        Me.rdbCtaAdm.Name = "rdbCtaAdm"
        Me.rdbCtaAdm.Size = New System.Drawing.Size(90, 17)
        Me.rdbCtaAdm.TabIndex = 5
        Me.rdbCtaAdm.Text = "Administrativa"
        Me.rdbCtaAdm.UseVisualStyleBackColor = False
        '
        'rbtCtaTrabajador
        '
        Me.rbtCtaTrabajador.AutoSize = True
        Me.rbtCtaTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.rbtCtaTrabajador.Enabled = False
        Me.rbtCtaTrabajador.ForeColor = System.Drawing.Color.Navy
        Me.rbtCtaTrabajador.Location = New System.Drawing.Point(212, 40)
        Me.rbtCtaTrabajador.Name = "rbtCtaTrabajador"
        Me.rbtCtaTrabajador.Size = New System.Drawing.Size(76, 17)
        Me.rbtCtaTrabajador.TabIndex = 4
        Me.rbtCtaTrabajador.Text = "Trabajador"
        Me.rbtCtaTrabajador.UseVisualStyleBackColor = False
        '
        'etiTrabajador
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Me.etiTrabajador.Appearance = Appearance39
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTrabajador.Location = New System.Drawing.Point(48, 68)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(60, 14)
        Me.etiTrabajador.TabIndex = 6
        Me.etiTrabajador.Text = "Trabajador:"
        '
        'cboTrabajadores
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Appearance = Appearance40
        Me.cboTrabajadores.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance41.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton2.Appearance = Appearance41
        Me.cboTrabajadores.ButtonsRight.Add(EditorButton2)
        Me.cboTrabajadores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadores.Enabled = False
        Me.cboTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadores.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Location = New System.Drawing.Point(114, 63)
        Me.cboTrabajadores.Name = "cboTrabajadores"
        Me.cboTrabajadores.Size = New System.Drawing.Size(352, 21)
        Me.cboTrabajadores.TabIndex = 7
        Me.cboTrabajadores.ValueMember = "Id"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(113, 171)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(353, 45)
        Me.txtDescripcion.TabIndex = 15
        '
        'Etiqueta11
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance42
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(67, 174)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta11.TabIndex = 14
        Me.Etiqueta11.Text = "Detalle:"
        '
        'etiConcepto
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.etiConcepto.Appearance = Appearance43
        Me.etiConcepto.AutoSize = True
        Me.etiConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.etiConcepto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiConcepto.Location = New System.Drawing.Point(54, 149)
        Me.etiConcepto.Name = "etiConcepto"
        Me.etiConcepto.Size = New System.Drawing.Size(54, 14)
        Me.etiConcepto.TabIndex = 12
        Me.etiConcepto.Text = "Concepto:"
        '
        'cboConcepto
        '
        Appearance44.ForeColor = System.Drawing.Color.Black
        Me.cboConcepto.Appearance = Appearance44
        Me.cboConcepto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboConcepto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboConcepto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConcepto.ForeColor = System.Drawing.Color.Black
        Me.cboConcepto.Location = New System.Drawing.Point(114, 144)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(352, 21)
        Me.cboConcepto.TabIndex = 13
        Me.cboConcepto.ValueMember = "Id"
        '
        'chkCtaAdm
        '
        Me.chkCtaAdm.AutoSize = True
        Me.chkCtaAdm.BackColor = System.Drawing.Color.Transparent
        Me.chkCtaAdm.ForeColor = System.Drawing.Color.Navy
        Me.chkCtaAdm.Location = New System.Drawing.Point(50, 40)
        Me.chkCtaAdm.Name = "chkCtaAdm"
        Me.chkCtaAdm.Size = New System.Drawing.Size(137, 17)
        Me.chkCtaAdm.TabIndex = 3
        Me.chkCtaAdm.Text = "Asociar a Cta. Corriente"
        Me.chkCtaAdm.UseVisualStyleBackColor = False
        '
        'Etiqueta8
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance45
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(50, 15)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta8.TabIndex = 0
        Me.Etiqueta8.Text = "Proveedor:"
        '
        'btnNuevoProveedor
        '
        Appearance46.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance46.Image = "16 (File new).ico"
        Me.btnNuevoProveedor.Appearance = Appearance46
        Me.btnNuevoProveedor.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnNuevoProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoProveedor.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoProveedor.ImageList = Me.imagenes
        Me.btnNuevoProveedor.Location = New System.Drawing.Point(529, 9)
        Me.btnNuevoProveedor.Name = "btnNuevoProveedor"
        Me.btnNuevoProveedor.Size = New System.Drawing.Size(25, 22)
        Me.btnNuevoProveedor.TabIndex = 2
        Me.btnNuevoProveedor.TabStop = False
        '
        'Etiqueta7
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance47
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(70, 227)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta7.TabIndex = 16
        Me.Etiqueta7.Text = "Monto:"
        '
        'Etiqueta6
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance48
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(70, 251)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta6.TabIndex = 18
        Me.Etiqueta6.Text = "Fecha:"
        '
        'fecFechaEmision
        '
        Me.fecFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaEmision.Location = New System.Drawing.Point(113, 249)
        Me.fecFechaEmision.Name = "fecFechaEmision"
        Me.fecFechaEmision.Size = New System.Drawing.Size(101, 20)
        Me.fecFechaEmision.TabIndex = 19
        '
        'Etiqueta5
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance49
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(42, 122)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(66, 14)
        Me.Etiqueta5.TabIndex = 10
        Me.Etiqueta5.Text = "Nro Cheque:"
        '
        'cboCuentaBancaria
        '
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Appearance = Appearance50
        Me.cboCuentaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaBancaria.DropDownListWidth = 400
        Me.cboCuentaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancaria.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Location = New System.Drawing.Point(114, 90)
        Me.cboCuentaBancaria.Name = "cboCuentaBancaria"
        Me.cboCuentaBancaria.Size = New System.Drawing.Size(352, 21)
        Me.cboCuentaBancaria.TabIndex = 9
        Me.cboCuentaBancaria.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance51
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(37, 95)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta3.TabIndex = 8
        Me.Etiqueta3.Text = "Cta Bancaria:"
        '
        'numMonto
        '
        Appearance52.ForeColor = System.Drawing.Color.Black
        Me.numMonto.Appearance = Appearance52
        Me.numMonto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMonto.ForeColor = System.Drawing.Color.Black
        Me.numMonto.Location = New System.Drawing.Point(114, 222)
        Me.numMonto.Name = "numMonto"
        Me.numMonto.NullText = "0.00"
        Me.numMonto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numMonto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numMonto.Size = New System.Drawing.Size(100, 21)
        Me.numMonto.TabIndex = 17
        '
        'txtNroCheque
        '
        Me.txtNroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroCheque.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroCheque.Location = New System.Drawing.Point(114, 117)
        Me.txtNroCheque.MaxLength = 20
        Me.txtNroCheque.Name = "txtNroCheque"
        Me.txtNroCheque.ReadOnly = True
        Me.txtNroCheque.Size = New System.Drawing.Size(100, 21)
        Me.txtNroCheque.TabIndex = 11
        '
        'odListadoDocumentos
        '
        UltraDataColumn39.DataType = GetType(Double)
        UltraDataColumn40.DataType = GetType(Double)
        UltraDataColumn41.DataType = GetType(Double)
        UltraDataColumn50.DataType = GetType(Date)
        UltraDataColumn52.DataType = GetType(Double)
        Me.odListadoDocumentos.Band.Columns.AddRange(New Object() {UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70})
        '
        'ficChequesPendientes
        '
        Me.ficChequesPendientes.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficChequesPendientes.Controls.Add(Me.UltraTabPageControl1)
        Me.ficChequesPendientes.Controls.Add(Me.UltraTabPageControl2)
        Me.ficChequesPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficChequesPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficChequesPendientes.Location = New System.Drawing.Point(0, 0)
        Me.ficChequesPendientes.Name = "ficChequesPendientes"
        Me.ficChequesPendientes.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficChequesPendientes.Size = New System.Drawing.Size(1109, 618)
        Me.ficChequesPendientes.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Lista"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Mantenimiento"
        Me.ficChequesPendientes.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.ficChequesPendientes.TabStop = False
        Me.ficChequesPendientes.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1107, 595)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(356, 275)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 22
        Me.ugb_Espera.Visible = False
        '
        'frm_ChequeEmitido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 618)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficChequesPendientes)
        Me.Name = "frm_ChequeEmitido"
        Me.Text = "Cheques Emitidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.griListaChequesPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odChequesPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboCentroL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.ColorAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCobrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresAprobado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEmitido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        CType(Me.gridDocumentosAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odChequeDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expDocumento.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel11.ResumeLayout(False)
        CType(Me.griListaDocumentoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        Me.Agrupacion9.PerformLayout()
        CType(Me.cboDocumentoAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNroDoc.ResumeLayout(False)
        Me.gbNroDoc.PerformLayout()
        CType(Me.txtSerieDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.cboProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficChequesPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficChequesPendientes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficChequesPendientes As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents odChequesPendientes As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiConcepto As ISL.Controles.Etiqueta
    Friend WithEvents cboConcepto As ISL.Controles.Combo
    Friend WithEvents chkCtaAdm As System.Windows.Forms.CheckBox
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents btnNuevoProveedor As ISL.Controles.Boton
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaBancaria As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents numMonto As ISL.Controles.NumeroDecimal
    Friend WithEvents txtNroCheque As ISL.Controles.Texto
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents ColorAnulado As ISL.Controles.Colores
    Friend WithEvents ColorCobrado As ISL.Controles.Colores
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresAprobado As ISL.Controles.Colores
    Friend WithEvents ColorEmitido As ISL.Controles.Colores
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents griListaChequesPendientes As ISL.Controles.Grilla
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EvaluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CobrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaCobro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajadores As ISL.Controles.Combo
    Friend WithEvents rdbCtaAdm As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCtaTrabajador As System.Windows.Forms.RadioButton
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboCentroL As ISL.Controles.Combo
    Friend WithEvents etiCentro As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents btnEliminar As ISL.Controles.Boton
    Friend WithEvents btnAnular As ISL.Controles.Boton
    Friend WithEvents btnCobrar As ISL.Controles.Boton
    Friend WithEvents btnAprobar As ISL.Controles.Boton
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Private WithEvents cboProveedores As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents expDocumento As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel11 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griListaDocumentoCompra As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents cboDocumentoAlmacen As ISL.Controles.Combo
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents btnBuscarDocumento As ISL.Controles.Boton
    Friend WithEvents gbNroDoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerieDoc As ISL.Controles.Texto
    Friend WithEvents txtNumeroDoc As ISL.Controles.Texto
    Friend WithEvents gridDocumentosAsociados As ISL.Controles.Grilla
    Friend WithEvents odListadoDocumentos As ISL.Controles.OrigenDatos
    Friend WithEvents odChequeDocumento As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
