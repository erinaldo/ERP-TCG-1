<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GastosCaja
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorriente")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAutoriza")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAutoriza")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAlmacen")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FlujoCaja")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDoc")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrupo")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroGrupo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGasto")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorriente")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajadorAutoriza")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TrabajadorAutoriza")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAlmacen")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMovimiento")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlujoCaja")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FlujoCaja")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieDoc")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroDoc")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrupo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroGrupo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vehiculo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGasto")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorriente")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAutoriza")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAutoriza")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAlmacen")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FlujoCaja")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDoc")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrupo")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroGrupo")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGasto")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl18 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaDocumentoCompra = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl19 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Etiqueta65 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosaOC = New ISL.Controles.Texto(Me.components)
        Me.txt_NroOrden = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta59 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griGastosLista = New ISL.Controles.Grilla(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.udsGastoOperacion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.filtro = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.dtp_FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.cboCaja = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griGastoOperacion = New ISL.Controles.Grilla(Me.components)
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.expDocumento = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel11 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Ficha1 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage8 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtNumeroDoc = New ISL.Controles.Texto(Me.components)
        Me.txtSerieDoc = New ISL.Controles.Texto(Me.components)
        Me.cboDocumentoAlmacen = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnBuscarDocumento = New ISL.Controles.Boton(Me.components)
        Me.ExpRegistroConsumoCombustible = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel8 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta38 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboLugar = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta39 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboDireccion = New ISL.Controles.ComboMaestros(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecCantidadGalones = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboMaterial = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.numTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.numPercepcion = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.numGravada = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.numIGV = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.numSubTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.btnLimpiar = New ISL.Controles.Boton(Me.components)
        Me.btnCancelarDetalle = New ISL.Controles.Boton(Me.components)
        Me.btnAceptarDetalle = New ISL.Controles.Boton(Me.components)
        Me.cboAutoriza = New ISL.Controles.Combo(Me.components)
        Me.etiAutoriza = New ISL.Controles.Etiqueta(Me.components)
        Me.ChkVehiculoProper = New System.Windows.Forms.CheckBox()
        Me.etiCentroCosto = New ISL.Controles.Etiqueta(Me.components)
        Me.cboGastoFuncion = New ISL.Controles.Combo(Me.components)
        Me.cboCentroCosto = New ISL.Controles.Combo(Me.components)
        Me.cboArea = New ISL.Controles.Combo(Me.components)
        Me.etiPlaca = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGastoFuncion = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProveedores = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.dtpFecVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.btnNuevoProveedor = New ISL.Controles.Boton(Me.components)
        Me.cboPlaca = New ISL.Controles.Combo(Me.components)
        Me.etiTipoGasto = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRuc = New ISL.Controles.Etiqueta(Me.components)
        Me.cboGrupo = New ISL.Controles.Combo(Me.components)
        Me.etiPeriodo = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.etiFechavencimiento = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNroGrupo = New ISL.Controles.Etiqueta(Me.components)
        Me.fecPeriodo = New ISL.Controles.Fecha(Me.components)
        Me.txtRUC = New ISL.Controles.Texto(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.etiProveedor = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFlujoCaja = New ISL.Controles.Combo(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.etiGlosa = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.etiNumero = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.etiSerie = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFechaDoc = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTipoDocumento = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoGasto = New ISL.Controles.Combo(Me.components)
        Me.etiFlujoCaja = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta54 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.Importe = New ISL.Controles.Etiqueta(Me.components)
        Me.etiIGV = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficGastosCaja = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl18.SuspendLayout()
        CType(Me.griListaDocumentoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl19.SuspendLayout()
        CType(Me.txtGlosaOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.griGastosLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.udsGastoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cboCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griGastoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.expDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expDocumento.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel11.SuspendLayout()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha1.SuspendLayout()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.txtNumeroDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDocumentoAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpRegistroConsumoCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpRegistroConsumoCombustible.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel8.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.DecCantidadGalones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPercepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGravada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAutoriza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGastoFuncion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRUC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficGastosCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficGastosCaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl18
        '
        Me.UltraTabPageControl18.Controls.Add(Me.griListaDocumentoCompra)
        Me.UltraTabPageControl18.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl18.Name = "UltraTabPageControl18"
        Me.UltraTabPageControl18.Size = New System.Drawing.Size(663, 110)
        '
        'griListaDocumentoCompra
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaDocumentoCompra.DisplayLayout.Appearance = Appearance1
        UltraGridColumn191.Header.VisiblePosition = 0
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 1
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.VisiblePosition = 2
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 3
        UltraGridColumn194.Hidden = True
        UltraGridColumn195.Header.VisiblePosition = 9
        UltraGridColumn195.Hidden = True
        UltraGridColumn195.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn196.Header.VisiblePosition = 10
        UltraGridColumn196.Hidden = True
        UltraGridColumn196.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn197.CellAppearance = Appearance2
        UltraGridColumn197.Header.VisiblePosition = 12
        UltraGridColumn197.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn198.Header.VisiblePosition = 8
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.VisiblePosition = 13
        UltraGridColumn199.Hidden = True
        UltraGridColumn200.Header.VisiblePosition = 14
        UltraGridColumn200.Hidden = True
        UltraGridColumn201.Header.VisiblePosition = 15
        UltraGridColumn201.Hidden = True
        UltraGridColumn202.Header.VisiblePosition = 7
        UltraGridColumn203.Header.VisiblePosition = 16
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 17
        UltraGridColumn204.Hidden = True
        UltraGridColumn205.Header.VisiblePosition = 18
        UltraGridColumn205.Hidden = True
        UltraGridColumn206.Header.VisiblePosition = 5
        UltraGridColumn206.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn207.Header.VisiblePosition = 6
        UltraGridColumn207.Hidden = True
        UltraGridColumn207.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn208.CellAppearance = Appearance3
        UltraGridColumn208.Header.VisiblePosition = 11
        UltraGridColumn208.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn209.Header.VisiblePosition = 19
        UltraGridColumn209.Hidden = True
        UltraGridColumn210.Header.VisiblePosition = 20
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.VisiblePosition = 21
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.VisiblePosition = 22
        UltraGridColumn212.Hidden = True
        UltraGridColumn213.Header.VisiblePosition = 23
        UltraGridColumn213.Hidden = True
        UltraGridColumn214.Header.VisiblePosition = 24
        UltraGridColumn214.Hidden = True
        UltraGridColumn215.Header.VisiblePosition = 25
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.VisiblePosition = 26
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.Header.VisiblePosition = 27
        UltraGridColumn217.Hidden = True
        UltraGridColumn218.Header.VisiblePosition = 28
        UltraGridColumn218.Hidden = True
        UltraGridColumn219.Header.VisiblePosition = 4
        UltraGridColumn219.Width = 270
        UltraGridColumn220.Header.VisiblePosition = 29
        UltraGridColumn220.Hidden = True
        UltraGridColumn221.Header.VisiblePosition = 30
        UltraGridColumn221.Hidden = True
        UltraGridColumn222.Header.VisiblePosition = 31
        UltraGridColumn222.Hidden = True
        UltraGridColumn223.Header.VisiblePosition = 32
        UltraGridColumn223.Hidden = True
        UltraGridColumn224.Header.VisiblePosition = 33
        UltraGridColumn224.Hidden = True
        UltraGridColumn225.Header.VisiblePosition = 34
        UltraGridColumn225.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225})
        Me.griListaDocumentoCompra.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaDocumentoCompra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDocumentoCompra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDocumentoCompra.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griListaDocumentoCompra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDocumentoCompra.DisplayLayout.GroupByBox.Hidden = True
        Me.griListaDocumentoCompra.DisplayLayout.GroupByBox.Prompt = " Drag a column header here to group by that column."
        Me.griListaDocumentoCompra.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDocumentoCompra.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaDocumentoCompra.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaDocumentoCompra.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDocumentoCompra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDocumentoCompra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDocumentoCompra.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaDocumentoCompra.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None
        Me.griListaDocumentoCompra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaDocumentoCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaDocumentoCompra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDocumentoCompra.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaDocumentoCompra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaDocumentoCompra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaDocumentoCompra.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaDocumentoCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDocumentoCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaDocumentoCompra.Location = New System.Drawing.Point(0, 0)
        Me.griListaDocumentoCompra.Name = "griListaDocumentoCompra"
        Me.griListaDocumentoCompra.Size = New System.Drawing.Size(663, 110)
        Me.griListaDocumentoCompra.TabIndex = 0
        Me.griListaDocumentoCompra.TabStop = False
        Me.griListaDocumentoCompra.Text = "UltraGrid1"
        '
        'UltraTabPageControl19
        '
        Me.UltraTabPageControl19.Controls.Add(Me.Etiqueta65)
        Me.UltraTabPageControl19.Controls.Add(Me.txtGlosaOC)
        Me.UltraTabPageControl19.Controls.Add(Me.txt_NroOrden)
        Me.UltraTabPageControl19.Controls.Add(Me.Etiqueta59)
        Me.UltraTabPageControl19.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl19.Name = "UltraTabPageControl19"
        Me.UltraTabPageControl19.Size = New System.Drawing.Size(663, 110)
        '
        'Etiqueta65
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta65.Appearance = Appearance4
        Me.Etiqueta65.AutoSize = True
        Me.Etiqueta65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta65.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta65.Location = New System.Drawing.Point(21, 44)
        Me.Etiqueta65.Name = "Etiqueta65"
        Me.Etiqueta65.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta65.TabIndex = 2
        Me.Etiqueta65.Text = "Glosa: "
        '
        'txtGlosaOC
        '
        Me.txtGlosaOC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaOC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaOC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaOC.Location = New System.Drawing.Point(65, 44)
        Me.txtGlosaOC.Multiline = True
        Me.txtGlosaOC.Name = "txtGlosaOC"
        Me.txtGlosaOC.ReadOnly = True
        Me.txtGlosaOC.Size = New System.Drawing.Size(307, 43)
        Me.txtGlosaOC.TabIndex = 3
        '
        'txt_NroOrden
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.txt_NroOrden.Appearance = Appearance5
        Me.txt_NroOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_NroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_NroOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroOrden.Location = New System.Drawing.Point(65, 10)
        Me.txt_NroOrden.Name = "txt_NroOrden"
        Me.txt_NroOrden.ReadOnly = True
        Me.txt_NroOrden.Size = New System.Drawing.Size(121, 22)
        Me.txt_NroOrden.TabIndex = 1
        Me.txt_NroOrden.TabStop = False
        '
        'Etiqueta59
        '
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta59.Appearance = Appearance6
        Me.Etiqueta59.AutoSize = True
        Me.Etiqueta59.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta59.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta59.Location = New System.Drawing.Point(5, 14)
        Me.Etiqueta59.Name = "Etiqueta59"
        Me.Etiqueta59.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta59.TabIndex = 0
        Me.Etiqueta59.Text = "NroOrden: "
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1089, 429)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.griGastosLista)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 34)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1089, 395)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griGastosLista
        '
        Me.griGastosLista.ContextMenuStrip = Me.ContextMenuStrip1
        Me.griGastosLista.DataSource = Me.udsGastoOperacion
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn10.Width = 187
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.Caption = "Serie"
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Width = 40
        UltraGridColumn15.Header.Caption = "Nro"
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.Width = 88
        UltraGridColumn16.Header.VisiblePosition = 16
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 13
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.Width = 241
        UltraGridColumn21.Header.VisiblePosition = 29
        UltraGridColumn21.Width = 241
        UltraGridColumn22.Header.VisiblePosition = 20
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 21
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 22
        UltraGridColumn24.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance7
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn25.Header.Appearance = Appearance8
        UltraGridColumn25.Header.VisiblePosition = 23
        UltraGridColumn25.MaskInput = "{double:5.2}"
        UltraGridColumn25.Width = 68
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn26.CellAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn26.Header.Appearance = Appearance10
        UltraGridColumn26.Header.VisiblePosition = 24
        UltraGridColumn26.MaskInput = "{double:5.2}"
        UltraGridColumn26.Width = 61
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn27.CellAppearance = Appearance11
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn27.Header.Appearance = Appearance12
        UltraGridColumn27.Header.VisiblePosition = 25
        UltraGridColumn27.MaskInput = "{double:5.2}"
        UltraGridColumn27.Width = 59
        UltraGridColumn28.Header.VisiblePosition = 26
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 27
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 28
        UltraGridColumn30.Width = 121
        UltraGridColumn31.Header.VisiblePosition = 30
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 31
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 32
        UltraGridColumn33.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 9
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
        UltraGridColumn86.Header.VisiblePosition = 38
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 39
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 40
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 41
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 42
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 43
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 44
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 45
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 46
        UltraGridColumn94.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn65, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94})
        Me.griGastosLista.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griGastosLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance13.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.BorderColor = System.Drawing.SystemColors.Window
        Me.griGastosLista.DisplayLayout.GroupByBox.Appearance = Appearance13
        Appearance14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griGastosLista.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance14
        Me.griGastosLista.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griGastosLista.DisplayLayout.GroupByBox.Hidden = True
        Appearance15.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance15.BackColor2 = System.Drawing.SystemColors.Control
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griGastosLista.DisplayLayout.GroupByBox.PromptAppearance = Appearance15
        Me.griGastosLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griGastosLista.DisplayLayout.MaxRowScrollRegions = 1
        Me.griGastosLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGastosLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griGastosLista.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griGastosLista.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance16.BorderColor = System.Drawing.Color.Silver
        Me.griGastosLista.DisplayLayout.Override.CellAppearance = Appearance16
        Me.griGastosLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griGastosLista.DisplayLayout.Override.CellPadding = 0
        Me.griGastosLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griGastosLista.DisplayLayout.Override.FilterUIProvider = Me.filtro
        Me.griGastosLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griGastosLista.DisplayLayout.Override.GroupByRowAppearance = Appearance17
        Appearance18.TextHAlignAsString = "Left"
        Me.griGastosLista.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.griGastosLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance19.BorderColor = System.Drawing.Color.Silver
        Me.griGastosLista.DisplayLayout.Override.RowAppearance = Appearance19
        Me.griGastosLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griGastosLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griGastosLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griGastosLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griGastosLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griGastosLista.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griGastosLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griGastosLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griGastosLista.Location = New System.Drawing.Point(3, 3)
        Me.griGastosLista.Name = "griGastosLista"
        Me.griGastosLista.Size = New System.Drawing.Size(1083, 389)
        Me.griGastosLista.TabIndex = 0
        Me.griGastosLista.TabStop = False
        Me.griGastosLista.Text = "Grilla1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.ToolStripMenuItem1.Text = "Nuevo"
        '
        'udsGastoOperacion
        '
        UltraDataColumn6.DataType = GetType(Boolean)
        UltraDataColumn21.DataType = GetType(Double)
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Double)
        UltraDataColumn26.DataType = GetType(Double)
        UltraDataColumn30.DataType = GetType(Date)
        UltraDataColumn32.DataType = GetType(Boolean)
        UltraDataColumn33.DataType = GetType(Date)
        UltraDataColumn34.DataType = GetType(Date)
        UltraDataColumn47.DataType = GetType(Short)
        Me.udsGastoOperacion.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta2)
        Me.UltraGroupBox1.Controls.Add(Me.dtp_FechaHasta)
        Me.UltraGroupBox1.Controls.Add(Me.dtp_FechaDesde)
        Me.UltraGroupBox1.Controls.Add(Me.cboCaja)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta1)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1089, 34)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta2
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance20
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(233, 10)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta2.TabIndex = 4
        Me.Etiqueta2.Text = "Fechas:"
        '
        'dtp_FechaHasta
        '
        Me.dtp_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaHasta.Location = New System.Drawing.Point(381, 6)
        Me.dtp_FechaHasta.Name = "dtp_FechaHasta"
        Me.dtp_FechaHasta.Size = New System.Drawing.Size(93, 21)
        Me.dtp_FechaHasta.TabIndex = 3
        '
        'dtp_FechaDesde
        '
        Me.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDesde.Location = New System.Drawing.Point(282, 6)
        Me.dtp_FechaDesde.Name = "dtp_FechaDesde"
        Me.dtp_FechaDesde.Size = New System.Drawing.Size(93, 21)
        Me.dtp_FechaDesde.TabIndex = 2
        '
        'cboCaja
        '
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.cboCaja.Appearance = Appearance21
        Me.cboCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCaja.Enabled = False
        Me.cboCaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCaja.ForeColor = System.Drawing.Color.Black
        Me.cboCaja.Location = New System.Drawing.Point(47, 6)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(180, 22)
        Me.cboCaja.TabIndex = 1
        Me.cboCaja.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance22
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(11, 10)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(30, 15)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Caja:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griGastoOperacion)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1089, 429)
        '
        'griGastoOperacion
        '
        Me.griGastoOperacion.DataSource = Me.udsGastoOperacion
        UltraGridColumn142.Header.VisiblePosition = 0
        UltraGridColumn142.Hidden = True
        UltraGridColumn143.Header.VisiblePosition = 1
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.Header.VisiblePosition = 2
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.Header.VisiblePosition = 3
        UltraGridColumn145.Hidden = True
        UltraGridColumn146.Header.VisiblePosition = 4
        UltraGridColumn146.Hidden = True
        UltraGridColumn147.Header.VisiblePosition = 5
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.VisiblePosition = 6
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn149.Header.Caption = "FlujoCaja"
        UltraGridColumn149.Header.VisiblePosition = 7
        UltraGridColumn149.Width = 180
        UltraGridColumn150.Header.VisiblePosition = 8
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.Header.VisiblePosition = 10
        UltraGridColumn151.Hidden = True
        UltraGridColumn152.Header.VisiblePosition = 11
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.VisiblePosition = 12
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn154.Header.Caption = "Serie"
        UltraGridColumn154.Header.VisiblePosition = 14
        UltraGridColumn154.Width = 49
        UltraGridColumn155.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn155.Header.Caption = "Nro"
        UltraGridColumn155.Header.VisiblePosition = 15
        UltraGridColumn155.Width = 91
        UltraGridColumn156.Header.VisiblePosition = 16
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn157.Header.VisiblePosition = 13
        UltraGridColumn157.Width = 135
        UltraGridColumn158.Header.VisiblePosition = 17
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 18
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn160.Header.VisiblePosition = 19
        UltraGridColumn160.Width = 210
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn161.CellAppearance = Appearance23
        UltraGridColumn161.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn161.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn161.Header.VisiblePosition = 28
        UltraGridColumn161.Width = 187
        UltraGridColumn162.Header.VisiblePosition = 20
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.Header.VisiblePosition = 21
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.VisiblePosition = 22
        UltraGridColumn164.Hidden = True
        UltraGridColumn181.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance24.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn181.CellAppearance = Appearance24
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn181.Header.Appearance = Appearance25
        UltraGridColumn181.Header.VisiblePosition = 23
        UltraGridColumn181.MaskInput = "{double:5.2}"
        UltraGridColumn182.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn182.CellAppearance = Appearance26
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn182.Header.Appearance = Appearance27
        UltraGridColumn182.Header.VisiblePosition = 24
        UltraGridColumn182.MaskInput = "{double:5.2}"
        UltraGridColumn183.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn183.CellAppearance = Appearance28
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn183.Header.Appearance = Appearance29
        UltraGridColumn183.Header.VisiblePosition = 25
        UltraGridColumn183.MaskInput = "{double:5.2}"
        UltraGridColumn184.Header.VisiblePosition = 26
        UltraGridColumn184.Hidden = True
        UltraGridColumn185.Header.VisiblePosition = 27
        UltraGridColumn185.Hidden = True
        UltraGridColumn186.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn186.Header.VisiblePosition = 29
        UltraGridColumn186.Hidden = True
        UltraGridColumn186.Width = 107
        UltraGridColumn187.Header.VisiblePosition = 30
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.Header.VisiblePosition = 31
        UltraGridColumn188.Hidden = True
        UltraGridColumn189.Header.VisiblePosition = 32
        UltraGridColumn189.Hidden = True
        UltraGridColumn190.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn190.Header.VisiblePosition = 9
        UltraGridColumn190.Width = 79
        UltraGridColumn226.Header.VisiblePosition = 33
        UltraGridColumn226.Hidden = True
        UltraGridColumn227.Header.VisiblePosition = 34
        UltraGridColumn227.Hidden = True
        UltraGridColumn228.Header.VisiblePosition = 35
        UltraGridColumn228.Hidden = True
        UltraGridColumn229.Header.VisiblePosition = 36
        UltraGridColumn229.Hidden = True
        UltraGridColumn230.Header.VisiblePosition = 37
        UltraGridColumn230.Hidden = True
        UltraGridColumn231.Header.VisiblePosition = 38
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.VisiblePosition = 39
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.Header.VisiblePosition = 40
        UltraGridColumn233.Hidden = True
        UltraGridColumn234.Header.VisiblePosition = 41
        UltraGridColumn234.Hidden = True
        UltraGridColumn235.Header.VisiblePosition = 42
        UltraGridColumn235.Hidden = True
        UltraGridColumn236.Header.VisiblePosition = 43
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.VisiblePosition = 44
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.Header.VisiblePosition = 45
        UltraGridColumn238.Hidden = True
        UltraGridColumn239.Header.VisiblePosition = 46
        UltraGridColumn239.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239})
        Me.griGastoOperacion.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griGastoOperacion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance30.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance30.BorderColor = System.Drawing.SystemColors.Window
        Me.griGastoOperacion.DisplayLayout.GroupByBox.Appearance = Appearance30
        Appearance31.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griGastoOperacion.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance31
        Me.griGastoOperacion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griGastoOperacion.DisplayLayout.GroupByBox.Hidden = True
        Appearance32.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance32.BackColor2 = System.Drawing.SystemColors.Control
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance32.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griGastoOperacion.DisplayLayout.GroupByBox.PromptAppearance = Appearance32
        Me.griGastoOperacion.DisplayLayout.MaxColScrollRegions = 1
        Me.griGastoOperacion.DisplayLayout.MaxRowScrollRegions = 1
        Me.griGastoOperacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGastoOperacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGastoOperacion.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griGastoOperacion.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance33.BorderColor = System.Drawing.Color.Silver
        Me.griGastoOperacion.DisplayLayout.Override.CellAppearance = Appearance33
        Me.griGastoOperacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griGastoOperacion.DisplayLayout.Override.CellPadding = 0
        Me.griGastoOperacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griGastoOperacion.DisplayLayout.Override.FilterUIProvider = Me.filtro
        Me.griGastoOperacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griGastoOperacion.DisplayLayout.Override.GroupByRowAppearance = Appearance34
        Appearance35.TextHAlignAsString = "Left"
        Me.griGastoOperacion.DisplayLayout.Override.HeaderAppearance = Appearance35
        Me.griGastoOperacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance36.BorderColor = System.Drawing.Color.Silver
        Me.griGastoOperacion.DisplayLayout.Override.RowAppearance = Appearance36
        Me.griGastoOperacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griGastoOperacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griGastoOperacion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griGastoOperacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griGastoOperacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griGastoOperacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griGastoOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griGastoOperacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griGastoOperacion.Location = New System.Drawing.Point(0, 234)
        Me.griGastoOperacion.Name = "griGastoOperacion"
        Me.griGastoOperacion.Size = New System.Drawing.Size(1089, 195)
        Me.griGastoOperacion.TabIndex = 1
        Me.griGastoOperacion.TabStop = False
        Me.griGastoOperacion.Text = "Grilla1"
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.expDocumento)
        Me.UltraGroupBox3.Controls.Add(Me.ExpRegistroConsumoCombustible)
        Me.UltraGroupBox3.Controls.Add(Me.ugb_Espera)
        Me.UltraGroupBox3.Controls.Add(Me.numTotal)
        Me.UltraGroupBox3.Controls.Add(Me.numPercepcion)
        Me.UltraGroupBox3.Controls.Add(Me.numGravada)
        Me.UltraGroupBox3.Controls.Add(Me.numIGV)
        Me.UltraGroupBox3.Controls.Add(Me.numSubTotal)
        Me.UltraGroupBox3.Controls.Add(Me.btnLimpiar)
        Me.UltraGroupBox3.Controls.Add(Me.btnCancelarDetalle)
        Me.UltraGroupBox3.Controls.Add(Me.btnAceptarDetalle)
        Me.UltraGroupBox3.Controls.Add(Me.cboAutoriza)
        Me.UltraGroupBox3.Controls.Add(Me.etiAutoriza)
        Me.UltraGroupBox3.Controls.Add(Me.ChkVehiculoProper)
        Me.UltraGroupBox3.Controls.Add(Me.etiCentroCosto)
        Me.UltraGroupBox3.Controls.Add(Me.cboGastoFuncion)
        Me.UltraGroupBox3.Controls.Add(Me.cboCentroCosto)
        Me.UltraGroupBox3.Controls.Add(Me.cboArea)
        Me.UltraGroupBox3.Controls.Add(Me.etiPlaca)
        Me.UltraGroupBox3.Controls.Add(Me.etiGastoFuncion)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta33)
        Me.UltraGroupBox3.Controls.Add(Me.cboProveedores)
        Me.UltraGroupBox3.Controls.Add(Me.dtpFecVencimiento)
        Me.UltraGroupBox3.Controls.Add(Me.etiTrabajador)
        Me.UltraGroupBox3.Controls.Add(Me.dtpFechaEmision)
        Me.UltraGroupBox3.Controls.Add(Me.btnNuevoProveedor)
        Me.UltraGroupBox3.Controls.Add(Me.cboPlaca)
        Me.UltraGroupBox3.Controls.Add(Me.etiTipoGasto)
        Me.UltraGroupBox3.Controls.Add(Me.etiRuc)
        Me.UltraGroupBox3.Controls.Add(Me.cboGrupo)
        Me.UltraGroupBox3.Controls.Add(Me.etiPeriodo)
        Me.UltraGroupBox3.Controls.Add(Me.cboTrabajador)
        Me.UltraGroupBox3.Controls.Add(Me.etiFechavencimiento)
        Me.UltraGroupBox3.Controls.Add(Me.etiNroGrupo)
        Me.UltraGroupBox3.Controls.Add(Me.fecPeriodo)
        Me.UltraGroupBox3.Controls.Add(Me.txtRUC)
        Me.UltraGroupBox3.Controls.Add(Me.cboTipoDocumento)
        Me.UltraGroupBox3.Controls.Add(Me.etiProveedor)
        Me.UltraGroupBox3.Controls.Add(Me.cboFlujoCaja)
        Me.UltraGroupBox3.Controls.Add(Me.txtNumero)
        Me.UltraGroupBox3.Controls.Add(Me.etiGlosa)
        Me.UltraGroupBox3.Controls.Add(Me.txtSerie)
        Me.UltraGroupBox3.Controls.Add(Me.etiNumero)
        Me.UltraGroupBox3.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox3.Controls.Add(Me.etiSerie)
        Me.UltraGroupBox3.Controls.Add(Me.etiFechaDoc)
        Me.UltraGroupBox3.Controls.Add(Me.etiTipoDocumento)
        Me.UltraGroupBox3.Controls.Add(Me.cboTipoGasto)
        Me.UltraGroupBox3.Controls.Add(Me.etiFlujoCaja)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta54)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta47)
        Me.UltraGroupBox3.Controls.Add(Me.Importe)
        Me.UltraGroupBox3.Controls.Add(Me.etiIGV)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta36)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1089, 234)
        Me.UltraGroupBox3.TabIndex = 0
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'expDocumento
        '
        Me.expDocumento.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.expDocumento.Controls.Add(Me.UltraExpandableGroupBoxPanel11)
        Me.expDocumento.Dock = System.Windows.Forms.DockStyle.Left
        Me.expDocumento.Expanded = False
        Me.expDocumento.ExpandedSize = New System.Drawing.Size(739, 228)
        Me.expDocumento.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.expDocumento.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.expDocumento.Location = New System.Drawing.Point(3, 3)
        Me.expDocumento.Name = "expDocumento"
        Me.expDocumento.Size = New System.Drawing.Size(23, 228)
        Me.expDocumento.TabIndex = 52
        Me.expDocumento.TabStop = False
        Me.expDocumento.Text = "Compras para Almacen"
        Me.expDocumento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel11
        '
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Ficha1)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Agrupacion9)
        Me.UltraExpandableGroupBoxPanel11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel11.Name = "UltraExpandableGroupBoxPanel11"
        Me.UltraExpandableGroupBoxPanel11.Size = New System.Drawing.Size(665, 222)
        Me.UltraExpandableGroupBoxPanel11.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel11.Visible = False
        '
        'Ficha1
        '
        Me.Ficha1.Controls.Add(Me.UltraTabSharedControlsPage8)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl18)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl19)
        Me.Ficha1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ficha1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha1.Location = New System.Drawing.Point(0, 89)
        Me.Ficha1.Name = "Ficha1"
        Me.Ficha1.SharedControlsPage = Me.UltraTabSharedControlsPage8
        Me.Ficha1.Size = New System.Drawing.Size(665, 133)
        Me.Ficha1.TabIndex = 1
        UltraTab4.TabPage = Me.UltraTabPageControl18
        UltraTab4.Text = "Documento"
        UltraTab8.TabPage = Me.UltraTabPageControl19
        UltraTab8.Text = "OrdenAsociada"
        Me.Ficha1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab8})
        Me.Ficha1.TabStop = False
        Me.Ficha1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage8
        '
        Me.UltraTabSharedControlsPage8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage8.Name = "UltraTabSharedControlsPage8"
        Me.UltraTabSharedControlsPage8.Size = New System.Drawing.Size(663, 110)
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.UltraGroupBox4)
        Me.Agrupacion9.Controls.Add(Me.cboDocumentoAlmacen)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta46)
        Me.Agrupacion9.Controls.Add(Me.btnBuscarDocumento)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(665, 89)
        Me.Agrupacion9.TabIndex = 0
        Me.Agrupacion9.Text = "Documento"
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.txtNumeroDoc)
        Me.UltraGroupBox4.Controls.Add(Me.txtSerieDoc)
        Me.UltraGroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox4.Location = New System.Drawing.Point(282, 30)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(165, 51)
        Me.UltraGroupBox4.TabIndex = 2
        Me.UltraGroupBox4.Text = "Documento"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtNumeroDoc
        '
        Me.txtNumeroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDoc.Location = New System.Drawing.Point(54, 23)
        Me.txtNumeroDoc.MaxLength = 10
        Me.txtNumeroDoc.Name = "txtNumeroDoc"
        Me.txtNumeroDoc.Size = New System.Drawing.Size(102, 22)
        Me.txtNumeroDoc.TabIndex = 1
        '
        'txtSerieDoc
        '
        Me.txtSerieDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieDoc.Location = New System.Drawing.Point(6, 23)
        Me.txtSerieDoc.MaxLength = 4
        Me.txtSerieDoc.Name = "txtSerieDoc"
        Me.txtSerieDoc.Size = New System.Drawing.Size(42, 22)
        Me.txtSerieDoc.TabIndex = 0
        '
        'cboDocumentoAlmacen
        '
        Appearance37.ForeColor = System.Drawing.Color.Black
        Me.cboDocumentoAlmacen.Appearance = Appearance37
        Me.cboDocumentoAlmacen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDocumentoAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDocumentoAlmacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDocumentoAlmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocumentoAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboDocumentoAlmacen.Location = New System.Drawing.Point(13, 53)
        Me.cboDocumentoAlmacen.Name = "cboDocumentoAlmacen"
        Me.cboDocumentoAlmacen.Size = New System.Drawing.Size(261, 22)
        Me.cboDocumentoAlmacen.TabIndex = 1
        Me.cboDocumentoAlmacen.ValueMember = "IdTipoDocumento"
        '
        'Etiqueta46
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta46.Appearance = Appearance38
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta46.Location = New System.Drawing.Point(14, 36)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(90, 15)
        Me.Etiqueta46.TabIndex = 0
        Me.Etiqueta46.Text = "Tipo Documento:"
        '
        'btnBuscarDocumento
        '
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Me.btnBuscarDocumento.Appearance = Appearance39
        Me.btnBuscarDocumento.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDocumento.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarDocumento.Location = New System.Drawing.Point(453, 49)
        Me.btnBuscarDocumento.Name = "btnBuscarDocumento"
        Me.btnBuscarDocumento.Size = New System.Drawing.Size(83, 25)
        Me.btnBuscarDocumento.TabIndex = 3
        Me.btnBuscarDocumento.Text = "Buscar"
        '
        'ExpRegistroConsumoCombustible
        '
        Me.ExpRegistroConsumoCombustible.Controls.Add(Me.UltraExpandableGroupBoxPanel8)
        Me.ExpRegistroConsumoCombustible.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpRegistroConsumoCombustible.Expanded = False
        Me.ExpRegistroConsumoCombustible.ExpandedSize = New System.Drawing.Size(294, 228)
        Me.ExpRegistroConsumoCombustible.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightOutsideBorder
        Me.ExpRegistroConsumoCombustible.Location = New System.Drawing.Point(1063, 3)
        Me.ExpRegistroConsumoCombustible.Name = "ExpRegistroConsumoCombustible"
        Me.ExpRegistroConsumoCombustible.Size = New System.Drawing.Size(23, 228)
        Me.ExpRegistroConsumoCombustible.TabIndex = 51
        Me.ExpRegistroConsumoCombustible.TabStop = False
        Me.ExpRegistroConsumoCombustible.Text = "Registro Consumo de Combustible"
        Me.ExpRegistroConsumoCombustible.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.ExpRegistroConsumoCombustible.Visible = False
        '
        'UltraExpandableGroupBoxPanel8
        '
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Agrupacion4)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Agrupacion2)
        Me.UltraExpandableGroupBoxPanel8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel8.Name = "UltraExpandableGroupBoxPanel8"
        Me.UltraExpandableGroupBoxPanel8.Size = New System.Drawing.Size(266, 222)
        Me.UltraExpandableGroupBoxPanel8.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel8.Visible = False
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.Etiqueta38)
        Me.Agrupacion4.Controls.Add(Me.cboLugar)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta39)
        Me.Agrupacion4.Controls.Add(Me.cboDireccion)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 75)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(266, 147)
        Me.Agrupacion4.TabIndex = 1
        Me.Agrupacion4.Text = "Datos Grifo"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta38
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta38.Appearance = Appearance40
        Me.Etiqueta38.AutoSize = True
        Me.Etiqueta38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta38.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta38.Location = New System.Drawing.Point(18, 26)
        Me.Etiqueta38.Name = "Etiqueta38"
        Me.Etiqueta38.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta38.TabIndex = 0
        Me.Etiqueta38.Text = "Lugar:"
        '
        'cboLugar
        '
        Appearance41.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Appearance = Appearance41
        Me.cboLugar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugar.DisplayMember = "Nombre"
        Me.cboLugar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboLugar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugar.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Location = New System.Drawing.Point(59, 21)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(201, 22)
        Me.cboLugar.TabIndex = 1
        Me.cboLugar.ValueMember = "Id"
        '
        'Etiqueta39
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta39.Appearance = Appearance42
        Me.Etiqueta39.AutoSize = True
        Me.Etiqueta39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta39.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta39.Location = New System.Drawing.Point(6, 48)
        Me.Etiqueta39.Name = "Etiqueta39"
        Me.Etiqueta39.Size = New System.Drawing.Size(54, 15)
        Me.Etiqueta39.TabIndex = 2
        Me.Etiqueta39.Text = "Direccion:"
        '
        'cboDireccion
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.cboDireccion.Appearance = Appearance43
        Me.cboDireccion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDireccion.DisplayMember = "Nombre"
        Me.cboDireccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDireccion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDireccion.ForeColor = System.Drawing.Color.Black
        Me.cboDireccion.Location = New System.Drawing.Point(6, 68)
        Me.cboDireccion.Name = "cboDireccion"
        Me.cboDireccion.Size = New System.Drawing.Size(257, 22)
        Me.cboDireccion.TabIndex = 3
        Me.cboDireccion.ValueMember = "Id"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion2.Controls.Add(Me.DecCantidadGalones)
        Me.Agrupacion2.Controls.Add(Me.cboMaterial)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta27)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(266, 75)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos a Ingresar"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta22
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance44
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(5, 23)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta22.TabIndex = 0
        Me.Etiqueta22.Text = "Galones:"
        '
        'DecCantidadGalones
        '
        Appearance45.ForeColor = System.Drawing.Color.Black
        Me.DecCantidadGalones.Appearance = Appearance45
        Me.DecCantidadGalones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecCantidadGalones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecCantidadGalones.ForeColor = System.Drawing.Color.Black
        Me.DecCantidadGalones.Location = New System.Drawing.Point(59, 19)
        Me.DecCantidadGalones.MaskInput = "{double:4.3}"
        Me.DecCantidadGalones.MaxValue = 1000.0R
        Me.DecCantidadGalones.MinValue = 0R
        Me.DecCantidadGalones.Name = "DecCantidadGalones"
        Me.DecCantidadGalones.NullText = "0.00"
        Me.DecCantidadGalones.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecCantidadGalones.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecCantidadGalones.Size = New System.Drawing.Size(54, 22)
        Me.DecCantidadGalones.TabIndex = 1
        '
        'cboMaterial
        '
        Appearance46.ForeColor = System.Drawing.Color.Black
        Me.cboMaterial.Appearance = Appearance46
        Me.cboMaterial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMaterial.DisplayMember = "Nombre"
        Me.cboMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMaterial.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterial.ForeColor = System.Drawing.Color.Black
        Me.cboMaterial.Location = New System.Drawing.Point(59, 46)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(201, 22)
        Me.cboMaterial.TabIndex = 3
        Me.cboMaterial.ValueMember = "Id"
        '
        'Etiqueta27
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance47
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(7, 50)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta27.TabIndex = 2
        Me.Etiqueta27.Text = "Material:"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(375, 105)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(394, 68)
        Me.ugb_Espera.TabIndex = 5
        Me.ugb_Espera.Visible = False
        '
        'numTotal
        '
        Me.numTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTotal.Location = New System.Drawing.Point(686, 96)
        Me.numTotal.MaskInput = "{double:9.2}"
        Me.numTotal.Name = "numTotal"
        Me.numTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTotal.Size = New System.Drawing.Size(93, 22)
        Me.numTotal.TabIndex = 32
        '
        'numPercepcion
        '
        Me.numPercepcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numPercepcion.Location = New System.Drawing.Point(549, 97)
        Me.numPercepcion.MaskInput = "{double:9.2}"
        Me.numPercepcion.Name = "numPercepcion"
        Me.numPercepcion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numPercepcion.ReadOnly = True
        Me.numPercepcion.Size = New System.Drawing.Size(93, 22)
        Me.numPercepcion.TabIndex = 30
        Me.numPercepcion.TabStop = False
        '
        'numGravada
        '
        Me.numGravada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numGravada.Location = New System.Drawing.Point(382, 97)
        Me.numGravada.MaskInput = "{double:9.2}"
        Me.numGravada.Name = "numGravada"
        Me.numGravada.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numGravada.Size = New System.Drawing.Size(93, 22)
        Me.numGravada.TabIndex = 28
        Me.numGravada.TabStop = False
        '
        'numIGV
        '
        Me.numIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numIGV.Location = New System.Drawing.Point(229, 96)
        Me.numIGV.MaskInput = "{double:5.2}"
        Me.numIGV.Name = "numIGV"
        Me.numIGV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numIGV.Size = New System.Drawing.Size(75, 22)
        Me.numIGV.TabIndex = 26
        '
        'numSubTotal
        '
        Me.numSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numSubTotal.Location = New System.Drawing.Point(98, 96)
        Me.numSubTotal.MaskInput = "{double:9.2}"
        Me.numSubTotal.Name = "numSubTotal"
        Me.numSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numSubTotal.Size = New System.Drawing.Size(93, 22)
        Me.numSubTotal.TabIndex = 24
        '
        'btnLimpiar
        '
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Appearance48.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Appearance48.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance48.TextHAlignAsString = "Right"
        Me.btnLimpiar.Appearance = Appearance48
        Me.btnLimpiar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(580, 200)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(78, 27)
        Me.btnLimpiar.TabIndex = 49
        Me.btnLimpiar.TabStop = False
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnCancelarDetalle
        '
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Appearance49.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Appearance49.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance49.TextHAlignAsString = "Right"
        Me.btnCancelarDetalle.Appearance = Appearance49
        Me.btnCancelarDetalle.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarDetalle.ForeColor = System.Drawing.Color.Black
        Me.btnCancelarDetalle.Location = New System.Drawing.Point(664, 200)
        Me.btnCancelarDetalle.Name = "btnCancelarDetalle"
        Me.btnCancelarDetalle.Size = New System.Drawing.Size(78, 27)
        Me.btnCancelarDetalle.TabIndex = 50
        Me.btnCancelarDetalle.TabStop = False
        Me.btnCancelarDetalle.Text = "Quitar"
        '
        'btnAceptarDetalle
        '
        Appearance50.ForeColor = System.Drawing.Color.Navy
        Appearance50.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Appearance50.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance50.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance50.TextHAlignAsString = "Right"
        Me.btnAceptarDetalle.Appearance = Appearance50
        Me.btnAceptarDetalle.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptarDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarDetalle.ForeColor = System.Drawing.Color.Black
        Me.btnAceptarDetalle.Location = New System.Drawing.Point(496, 199)
        Me.btnAceptarDetalle.Name = "btnAceptarDetalle"
        Me.btnAceptarDetalle.Size = New System.Drawing.Size(78, 29)
        Me.btnAceptarDetalle.TabIndex = 48
        Me.btnAceptarDetalle.Text = "Aceptar"
        '
        'cboAutoriza
        '
        Appearance51.ForeColor = System.Drawing.Color.Black
        Me.cboAutoriza.Appearance = Appearance51
        Me.cboAutoriza.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboAutoriza.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAutoriza.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAutoriza.ForeColor = System.Drawing.Color.Black
        Me.cboAutoriza.Location = New System.Drawing.Point(98, 202)
        Me.cboAutoriza.Name = "cboAutoriza"
        Me.cboAutoriza.Size = New System.Drawing.Size(356, 22)
        Me.cboAutoriza.TabIndex = 47
        Me.cboAutoriza.ValueMember = "Id"
        '
        'etiAutoriza
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.etiAutoriza.Appearance = Appearance52
        Me.etiAutoriza.AutoSize = True
        Me.etiAutoriza.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAutoriza.ForeColor = System.Drawing.Color.Black
        Me.etiAutoriza.Location = New System.Drawing.Point(45, 206)
        Me.etiAutoriza.Name = "etiAutoriza"
        Me.etiAutoriza.Size = New System.Drawing.Size(49, 15)
        Me.etiAutoriza.TabIndex = 46
        Me.etiAutoriza.Text = "Autoriza:"
        '
        'ChkVehiculoProper
        '
        Me.ChkVehiculoProper.AutoSize = True
        Me.ChkVehiculoProper.BackColor = System.Drawing.Color.Transparent
        Me.ChkVehiculoProper.Enabled = False
        Me.ChkVehiculoProper.ForeColor = System.Drawing.Color.Navy
        Me.ChkVehiculoProper.Location = New System.Drawing.Point(990, 176)
        Me.ChkVehiculoProper.Name = "ChkVehiculoProper"
        Me.ChkVehiculoProper.Size = New System.Drawing.Size(55, 17)
        Me.ChkVehiculoProper.TabIndex = 45
        Me.ChkVehiculoProper.TabStop = False
        Me.ChkVehiculoProper.Text = "Varios"
        Me.ChkVehiculoProper.UseVisualStyleBackColor = False
        '
        'etiCentroCosto
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Me.etiCentroCosto.Appearance = Appearance53
        Me.etiCentroCosto.AutoSize = True
        Me.etiCentroCosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCentroCosto.ForeColor = System.Drawing.Color.Black
        Me.etiCentroCosto.Location = New System.Drawing.Point(735, 152)
        Me.etiCentroCosto.Name = "etiCentroCosto"
        Me.etiCentroCosto.Size = New System.Drawing.Size(73, 15)
        Me.etiCentroCosto.TabIndex = 37
        Me.etiCentroCosto.Text = "Centro Costo:"
        '
        'cboGastoFuncion
        '
        Appearance54.ForeColor = System.Drawing.Color.Black
        Me.cboGastoFuncion.Appearance = Appearance54
        Me.cboGastoFuncion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboGastoFuncion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGastoFuncion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGastoFuncion.ForeColor = System.Drawing.Color.Black
        Me.cboGastoFuncion.Location = New System.Drawing.Point(813, 121)
        Me.cboGastoFuncion.Name = "cboGastoFuncion"
        Me.cboGastoFuncion.Size = New System.Drawing.Size(232, 22)
        Me.cboGastoFuncion.TabIndex = 36
        Me.cboGastoFuncion.ValueMember = "Id"
        '
        'cboCentroCosto
        '
        Appearance55.ForeColor = System.Drawing.Color.Black
        Me.cboCentroCosto.Appearance = Appearance55
        Me.cboCentroCosto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCentroCosto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroCosto.Enabled = False
        Me.cboCentroCosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroCosto.ForeColor = System.Drawing.Color.Black
        Me.cboCentroCosto.Location = New System.Drawing.Point(813, 148)
        Me.cboCentroCosto.Name = "cboCentroCosto"
        Me.cboCentroCosto.Size = New System.Drawing.Size(232, 22)
        Me.cboCentroCosto.TabIndex = 38
        Me.cboCentroCosto.ValueMember = "Id"
        '
        'cboArea
        '
        Appearance56.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Appearance = Appearance56
        Me.cboArea.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Location = New System.Drawing.Point(496, 175)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(270, 22)
        Me.cboArea.TabIndex = 42
        Me.cboArea.ValueMember = "Id"
        '
        'etiPlaca
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.etiPlaca.Appearance = Appearance57
        Me.etiPlaca.AutoSize = True
        Me.etiPlaca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPlaca.ForeColor = System.Drawing.Color.Black
        Me.etiPlaca.Location = New System.Drawing.Point(772, 179)
        Me.etiPlaca.Name = "etiPlaca"
        Me.etiPlaca.Size = New System.Drawing.Size(34, 15)
        Me.etiPlaca.TabIndex = 43
        Me.etiPlaca.Text = "Placa:"
        '
        'etiGastoFuncion
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.etiGastoFuncion.Appearance = Appearance58
        Me.etiGastoFuncion.AutoSize = True
        Me.etiGastoFuncion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGastoFuncion.ForeColor = System.Drawing.Color.Black
        Me.etiGastoFuncion.Location = New System.Drawing.Point(771, 125)
        Me.etiGastoFuncion.Name = "etiGastoFuncion"
        Me.etiGastoFuncion.Size = New System.Drawing.Size(37, 15)
        Me.etiGastoFuncion.TabIndex = 35
        Me.etiGastoFuncion.Text = "Gasto:"
        '
        'Etiqueta33
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta33.Appearance = Appearance59
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta33.Location = New System.Drawing.Point(460, 179)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta33.TabIndex = 41
        Me.Etiqueta33.Text = "Area:"
        '
        'cboProveedores
        '
        Me.cboProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance60.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance60
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
        Me.cboProveedores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedores.Location = New System.Drawing.Point(261, 69)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(473, 23)
        Me.cboProveedores.TabIndex = 21
        '
        'dtpFecVencimiento
        '
        Me.dtpFecVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecVencimiento.Location = New System.Drawing.Point(966, 43)
        Me.dtpFecVencimiento.Name = "dtpFecVencimiento"
        Me.dtpFecVencimiento.Size = New System.Drawing.Size(78, 21)
        Me.dtpFecVencimiento.TabIndex = 17
        '
        'etiTrabajador
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.etiTrabajador.Appearance = Appearance61
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.Black
        Me.etiTrabajador.Location = New System.Drawing.Point(32, 179)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(63, 15)
        Me.etiTrabajador.TabIndex = 39
        Me.etiTrabajador.Text = "Trabajador:"
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(839, 43)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(79, 21)
        Me.dtpFechaEmision.TabIndex = 15
        '
        'btnNuevoProveedor
        '
        Appearance62.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Appearance62.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance62.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnNuevoProveedor.Appearance = Appearance62
        Me.btnNuevoProveedor.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnNuevoProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoProveedor.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoProveedor.Location = New System.Drawing.Point(740, 68)
        Me.btnNuevoProveedor.Name = "btnNuevoProveedor"
        Me.btnNuevoProveedor.Size = New System.Drawing.Size(25, 25)
        Me.btnNuevoProveedor.TabIndex = 22
        Me.btnNuevoProveedor.TabStop = False
        '
        'cboPlaca
        '
        Appearance63.ForeColor = System.Drawing.Color.Black
        Me.cboPlaca.Appearance = Appearance63
        Me.cboPlaca.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPlaca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPlaca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlaca.ForeColor = System.Drawing.Color.Black
        Me.cboPlaca.Location = New System.Drawing.Point(813, 175)
        Me.cboPlaca.Name = "cboPlaca"
        Me.cboPlaca.Size = New System.Drawing.Size(171, 22)
        Me.cboPlaca.TabIndex = 44
        Me.cboPlaca.ValueMember = "Id"
        '
        'etiTipoGasto
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Me.etiTipoGasto.Appearance = Appearance64
        Me.etiTipoGasto.AutoSize = True
        Me.etiTipoGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTipoGasto.ForeColor = System.Drawing.Color.Black
        Me.etiTipoGasto.Location = New System.Drawing.Point(375, 19)
        Me.etiTipoGasto.Name = "etiTipoGasto"
        Me.etiTipoGasto.Size = New System.Drawing.Size(62, 15)
        Me.etiTipoGasto.TabIndex = 4
        Me.etiTipoGasto.Text = "Tipo Gasto:"
        '
        'etiRuc
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Me.etiRuc.Appearance = Appearance65
        Me.etiRuc.AutoSize = True
        Me.etiRuc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRuc.ForeColor = System.Drawing.Color.Black
        Me.etiRuc.Location = New System.Drawing.Point(61, 73)
        Me.etiRuc.Name = "etiRuc"
        Me.etiRuc.Size = New System.Drawing.Size(29, 15)
        Me.etiRuc.TabIndex = 18
        Me.etiRuc.Text = "RUC:"
        '
        'cboGrupo
        '
        Appearance66.ForeColor = System.Drawing.Color.Black
        Me.cboGrupo.Appearance = Appearance66
        Me.cboGrupo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboGrupo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGrupo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboGrupo.Enabled = False
        Me.cboGrupo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.ForeColor = System.Drawing.Color.Black
        Me.cboGrupo.Location = New System.Drawing.Point(249, 15)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(120, 22)
        Me.cboGrupo.TabIndex = 3
        Me.cboGrupo.ValueMember = "Id"
        '
        'etiPeriodo
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Me.etiPeriodo.Appearance = Appearance67
        Me.etiPeriodo.AutoSize = True
        Me.etiPeriodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPeriodo.ForeColor = System.Drawing.Color.Black
        Me.etiPeriodo.Location = New System.Drawing.Point(47, 19)
        Me.etiPeriodo.Name = "etiPeriodo"
        Me.etiPeriodo.Size = New System.Drawing.Size(46, 15)
        Me.etiPeriodo.TabIndex = 0
        Me.etiPeriodo.Text = "Periodo:"
        '
        'cboTrabajador
        '
        Appearance68.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance68
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(98, 175)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(356, 22)
        Me.cboTrabajador.TabIndex = 40
        Me.cboTrabajador.ValueMember = "Id"
        '
        'etiFechavencimiento
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.etiFechavencimiento.Appearance = Appearance69
        Me.etiFechavencimiento.AutoSize = True
        Me.etiFechavencimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechavencimiento.ForeColor = System.Drawing.Color.Black
        Me.etiFechavencimiento.Location = New System.Drawing.Point(924, 46)
        Me.etiFechavencimiento.Name = "etiFechavencimiento"
        Me.etiFechavencimiento.Size = New System.Drawing.Size(36, 15)
        Me.etiFechavencimiento.TabIndex = 16
        Me.etiFechavencimiento.Text = "Venc.:"
        '
        'etiNroGrupo
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Me.etiNroGrupo.Appearance = Appearance70
        Me.etiNroGrupo.AutoSize = True
        Me.etiNroGrupo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNroGrupo.ForeColor = System.Drawing.Color.Black
        Me.etiNroGrupo.Location = New System.Drawing.Point(183, 19)
        Me.etiNroGrupo.Name = "etiNroGrupo"
        Me.etiNroGrupo.Size = New System.Drawing.Size(60, 15)
        Me.etiNroGrupo.TabIndex = 2
        Me.etiNroGrupo.Text = "Nro Grupo:"
        '
        'fecPeriodo
        '
        Appearance71.ForeColor = System.Drawing.Color.Black
        Me.fecPeriodo.Appearance = Appearance71
        Me.fecPeriodo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecPeriodo.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.fecPeriodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecPeriodo.ForeColor = System.Drawing.Color.Black
        Me.fecPeriodo.Location = New System.Drawing.Point(98, 15)
        Me.fecPeriodo.MaskInput = "mm/yyyy"
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.Size = New System.Drawing.Size(79, 22)
        Me.fecPeriodo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.fecPeriodo.TabIndex = 1
        Me.fecPeriodo.TabStop = False
        '
        'txtRUC
        '
        Me.txtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRUC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.Location = New System.Drawing.Point(98, 69)
        Me.txtRUC.MaxLength = 11
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(93, 22)
        Me.txtRUC.TabIndex = 19
        '
        'cboTipoDocumento
        '
        Appearance72.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance72
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownListWidth = 600
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(98, 42)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(299, 22)
        Me.cboTipoDocumento.TabIndex = 9
        Me.cboTipoDocumento.ValueMember = "IdTipoDocumento"
        '
        'etiProveedor
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Me.etiProveedor.Appearance = Appearance73
        Me.etiProveedor.AutoSize = True
        Me.etiProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiProveedor.ForeColor = System.Drawing.Color.Black
        Me.etiProveedor.Location = New System.Drawing.Point(197, 73)
        Me.etiProveedor.Name = "etiProveedor"
        Me.etiProveedor.Size = New System.Drawing.Size(59, 15)
        Me.etiProveedor.TabIndex = 20
        Me.etiProveedor.Text = "Proveedor:"
        '
        'cboFlujoCaja
        '
        Appearance74.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoCaja.Appearance = Appearance74
        Me.cboFlujoCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance75.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton2.Appearance = Appearance75
        Me.cboFlujoCaja.ButtonsRight.Add(EditorButton2)
        Me.cboFlujoCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlujoCaja.DropDownListWidth = 350
        Me.cboFlujoCaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoCaja.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoCaja.Location = New System.Drawing.Point(780, 15)
        Me.cboFlujoCaja.Name = "cboFlujoCaja"
        Me.cboFlujoCaja.Size = New System.Drawing.Size(265, 22)
        Me.cboFlujoCaja.TabIndex = 7
        Me.cboFlujoCaja.ValueMember = "Id"
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(630, 42)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(136, 22)
        Me.txtNumero.TabIndex = 13
        '
        'etiGlosa
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Me.etiGlosa.Appearance = Appearance76
        Me.etiGlosa.AutoSize = True
        Me.etiGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGlosa.ForeColor = System.Drawing.Color.Black
        Me.etiGlosa.Location = New System.Drawing.Point(56, 125)
        Me.etiGlosa.Name = "etiGlosa"
        Me.etiGlosa.Size = New System.Drawing.Size(35, 15)
        Me.etiGlosa.TabIndex = 33
        Me.etiGlosa.Text = "Glosa:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(442, 42)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(132, 22)
        Me.txtSerie.TabIndex = 11
        '
        'etiNumero
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Me.etiNumero.Appearance = Appearance77
        Me.etiNumero.AutoSize = True
        Me.etiNumero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNumero.ForeColor = System.Drawing.Color.Black
        Me.etiNumero.Location = New System.Drawing.Point(580, 46)
        Me.etiNumero.Name = "etiNumero"
        Me.etiNumero.Size = New System.Drawing.Size(48, 15)
        Me.etiNumero.TabIndex = 12
        Me.etiNumero.Text = "Numero:"
        '
        'txtGlosa
        '
        Me.txtGlosa.AccessibleDescription = ""
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(98, 123)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txtGlosa.Size = New System.Drawing.Size(631, 46)
        Me.txtGlosa.TabIndex = 34
        '
        'etiSerie
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.etiSerie.Appearance = Appearance78
        Me.etiSerie.AutoSize = True
        Me.etiSerie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSerie.ForeColor = System.Drawing.Color.Black
        Me.etiSerie.Location = New System.Drawing.Point(403, 46)
        Me.etiSerie.Name = "etiSerie"
        Me.etiSerie.Size = New System.Drawing.Size(33, 15)
        Me.etiSerie.TabIndex = 10
        Me.etiSerie.Text = "Serie:"
        '
        'etiFechaDoc
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Me.etiFechaDoc.Appearance = Appearance79
        Me.etiFechaDoc.AutoSize = True
        Me.etiFechaDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaDoc.ForeColor = System.Drawing.Color.Black
        Me.etiFechaDoc.Location = New System.Drawing.Point(769, 46)
        Me.etiFechaDoc.Name = "etiFechaDoc"
        Me.etiFechaDoc.Size = New System.Drawing.Size(64, 15)
        Me.etiFechaDoc.TabIndex = 14
        Me.etiFechaDoc.Text = "FecEmision:"
        '
        'etiTipoDocumento
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Me.etiTipoDocumento.Appearance = Appearance80
        Me.etiTipoDocumento.AutoSize = True
        Me.etiTipoDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.etiTipoDocumento.Location = New System.Drawing.Point(50, 46)
        Me.etiTipoDocumento.Name = "etiTipoDocumento"
        Me.etiTipoDocumento.Size = New System.Drawing.Size(44, 15)
        Me.etiTipoDocumento.TabIndex = 8
        Me.etiTipoDocumento.Text = "T. Doc.:"
        '
        'cboTipoGasto
        '
        Appearance81.ForeColor = System.Drawing.Color.Black
        Me.cboTipoGasto.Appearance = Appearance81
        Me.cboTipoGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance82.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton3.Appearance = Appearance82
        Me.cboTipoGasto.ButtonsRight.Add(EditorButton3)
        Me.cboTipoGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoGasto.DropDownListWidth = 350
        Me.cboTipoGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoGasto.ForeColor = System.Drawing.Color.Black
        Me.cboTipoGasto.Location = New System.Drawing.Point(442, 15)
        Me.cboTipoGasto.Name = "cboTipoGasto"
        Me.cboTipoGasto.Size = New System.Drawing.Size(254, 22)
        Me.cboTipoGasto.TabIndex = 5
        Me.cboTipoGasto.ValueMember = "Id"
        '
        'etiFlujoCaja
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Appearance83.ForeColor = System.Drawing.Color.Navy
        Me.etiFlujoCaja.Appearance = Appearance83
        Me.etiFlujoCaja.AutoSize = True
        Me.etiFlujoCaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFlujoCaja.ForeColor = System.Drawing.Color.Black
        Me.etiFlujoCaja.Location = New System.Drawing.Point(702, 19)
        Me.etiFlujoCaja.Name = "etiFlujoCaja"
        Me.etiFlujoCaja.Size = New System.Drawing.Size(74, 15)
        Me.etiFlujoCaja.TabIndex = 6
        Me.etiFlujoCaja.Text = "Flujo de Caja:"
        '
        'Etiqueta54
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta54.Appearance = Appearance84
        Me.Etiqueta54.AutoSize = True
        Me.Etiqueta54.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta54.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta54.Location = New System.Drawing.Point(481, 101)
        Me.Etiqueta54.Name = "Etiqueta54"
        Me.Etiqueta54.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta54.TabIndex = 29
        Me.Etiqueta54.Text = "Percepcion:"
        '
        'Etiqueta47
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta47.Appearance = Appearance85
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta47.Location = New System.Drawing.Point(310, 101)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta47.TabIndex = 27
        Me.Etiqueta47.Text = "No Gravada:"
        '
        'Importe
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Me.Importe.Appearance = Appearance86
        Me.Importe.AutoSize = True
        Me.Importe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Importe.ForeColor = System.Drawing.Color.Black
        Me.Importe.Location = New System.Drawing.Point(41, 101)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(52, 15)
        Me.Importe.TabIndex = 23
        Me.Importe.Text = "SubTotal:"
        '
        'etiIGV
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Me.etiIGV.Appearance = Appearance87
        Me.etiIGV.AutoSize = True
        Me.etiIGV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiIGV.ForeColor = System.Drawing.Color.Black
        Me.etiIGV.Location = New System.Drawing.Point(197, 101)
        Me.etiIGV.Name = "etiIGV"
        Me.etiIGV.Size = New System.Drawing.Size(27, 15)
        Me.etiIGV.TabIndex = 25
        Me.etiIGV.Text = "IGV:"
        '
        'Etiqueta36
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta36.Appearance = Appearance88
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta36.Location = New System.Drawing.Point(648, 101)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta36.TabIndex = 31
        Me.Etiqueta36.Text = "Total:"
        '
        'ficGastosCaja
        '
        Me.ficGastosCaja.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficGastosCaja.Controls.Add(Me.UltraTabPageControl1)
        Me.ficGastosCaja.Controls.Add(Me.UltraTabPageControl2)
        Me.ficGastosCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficGastosCaja.Location = New System.Drawing.Point(0, 0)
        Me.ficGastosCaja.Name = "ficGastosCaja"
        Me.ficGastosCaja.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficGastosCaja.Size = New System.Drawing.Size(1091, 452)
        Me.ficGastosCaja.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficGastosCaja.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficGastosCaja.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficGastosCaja.TabStop = False
        Me.ficGastosCaja.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1089, 429)
        '
        'frm_GastosCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 452)
        Me.Controls.Add(Me.ficGastosCaja)
        Me.Name = "frm_GastosCaja"
        Me.Text = "Gastos Caja"
        Me.UltraTabPageControl18.ResumeLayout(False)
        CType(Me.griListaDocumentoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl19.ResumeLayout(False)
        Me.UltraTabPageControl19.PerformLayout()
        CType(Me.txtGlosaOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.griGastosLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.udsGastoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cboCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griGastoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.expDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expDocumento.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel11.ResumeLayout(False)
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha1.ResumeLayout(False)
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        Me.Agrupacion9.PerformLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.txtNumeroDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDocumentoAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpRegistroConsumoCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpRegistroConsumoCombustible.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel8.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.DecCantidadGalones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPercepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGravada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAutoriza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGastoFuncion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRUC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficGastosCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficGastosCaja.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficGastosCaja As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udsGastoOperacion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griGastoOperacion As ISL.Controles.Grilla
    Friend WithEvents filtro As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Private WithEvents cboProveedores As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dtpFecVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNuevoProveedor As ISL.Controles.Boton
    Friend WithEvents etiTipoGasto As ISL.Controles.Etiqueta
    Friend WithEvents etiRuc As ISL.Controles.Etiqueta
    Friend WithEvents cboGrupo As ISL.Controles.Combo
    Friend WithEvents etiPeriodo As ISL.Controles.Etiqueta
    Friend WithEvents etiFechavencimiento As ISL.Controles.Etiqueta
    Friend WithEvents etiNroGrupo As ISL.Controles.Etiqueta
    Friend WithEvents fecPeriodo As ISL.Controles.Fecha
    Friend WithEvents txtRUC As ISL.Controles.Texto
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents etiProveedor As ISL.Controles.Etiqueta
    Friend WithEvents cboFlujoCaja As ISL.Controles.Combo
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents etiGlosa As ISL.Controles.Etiqueta
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents etiNumero As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents etiSerie As ISL.Controles.Etiqueta
    Friend WithEvents etiFechaDoc As ISL.Controles.Etiqueta
    Friend WithEvents etiTipoDocumento As ISL.Controles.Etiqueta
    Friend WithEvents cboArea As ISL.Controles.Combo
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents ChkVehiculoProper As System.Windows.Forms.CheckBox
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents cboAutoriza As ISL.Controles.Combo
    Friend WithEvents etiPlaca As ISL.Controles.Etiqueta
    Friend WithEvents cboGastoFuncion As ISL.Controles.Combo
    Friend WithEvents etiCentroCosto As ISL.Controles.Etiqueta
    Friend WithEvents cboCentroCosto As ISL.Controles.Combo
    Friend WithEvents etiGastoFuncion As ISL.Controles.Etiqueta
    Friend WithEvents etiAutoriza As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents cboPlaca As ISL.Controles.Combo
    Friend WithEvents cboTipoGasto As ISL.Controles.Combo
    Friend WithEvents etiFlujoCaja As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta54 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents Importe As ISL.Controles.Etiqueta
    Friend WithEvents etiIGV As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents btnLimpiar As ISL.Controles.Boton
    Friend WithEvents btnCancelarDetalle As ISL.Controles.Boton
    Friend WithEvents btnAceptarDetalle As ISL.Controles.Boton
    Friend WithEvents griGastosLista As ISL.Controles.Grilla
    Friend WithEvents expDocumento As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel11 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Ficha1 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage8 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl18 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaDocumentoCompra As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl19 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Etiqueta65 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosaOC As ISL.Controles.Texto
    Friend WithEvents txt_NroOrden As ISL.Controles.Texto
    Friend WithEvents Etiqueta59 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents cboDocumentoAlmacen As ISL.Controles.Combo
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents btnBuscarDocumento As ISL.Controles.Boton
    Friend WithEvents txtSerieDoc As ISL.Controles.Texto
    Friend WithEvents txtNumeroDoc As ISL.Controles.Texto
    Friend WithEvents numTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents numPercepcion As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents numGravada As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents numIGV As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents numSubTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ExpRegistroConsumoCombustible As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel8 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta38 As ISL.Controles.Etiqueta
    Friend WithEvents cboLugar As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta39 As ISL.Controles.Etiqueta
    Friend WithEvents cboDireccion As ISL.Controles.ComboMaestros
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents DecCantidadGalones As ISL.Controles.NumeroDecimal
    Friend WithEvents cboMaterial As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents cboCaja As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents Etiqueta2 As Controles.Etiqueta
    Friend WithEvents dtp_FechaHasta As DateTimePicker
    Friend WithEvents dtp_FechaDesde As DateTimePicker
End Class
