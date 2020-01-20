<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GRR_Venta
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_GuiaRemisionRemitente_Detalle", -1)
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGRR_Venta")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Costo")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMinimo")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMaximo")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockActual")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_GRR_Venta))
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn458 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn459 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn460 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn461 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden")
        Dim UltraGridColumn462 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn463 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn464 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn465 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn466 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn467 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn468 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn469 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn470 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn471 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipo")
        Dim UltraGridColumn472 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Orden", -1)
        Dim UltraGridColumn385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMovimientoInventario")
        Dim UltraGridColumn389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim UltraGridColumn390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden")
        Dim UltraGridColumn397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreReferencia")
        Dim UltraGridColumn399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim UltraGridColumn400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn446 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn448 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Orden", -1)
        Dim UltraGridColumn449 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn450 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn451 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMovimientoInventario")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreReferencia")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_GRR_Venta", -1)
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTransportista")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Transportista")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTraslado")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdChofer")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chofer")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Brevete")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMotivoTraslado")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoTraslado")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPartida")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Partida")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
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
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEmpresa")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDoc")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDoc")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionFiscal")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCliente")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndProveedor")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndComisionista")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgentePercepcion")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgenteRetencion")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBuenContribuyente")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaLetras")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaCheque")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCanjeDocumento")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LstDireccion")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LstTelefono")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LstTipoPago_PerEmp")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LstEmail")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LstPersona")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LstDireccion", -1)
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbigeo")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroPoblado")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVia")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoZona")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Via")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroInterior")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Manzana")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lote")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kilometro")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Block")
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Etapa")
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LstTelefono", -1)
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoLargaDistancia")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPrincipal")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LstTipoPago_PerEmp", -1)
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndClienteProveedor")
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LstEmail", -1)
        Dim UltraGridColumn300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPrincipal")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LstPersona", -1)
        Dim UltraGridColumn361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ApellidoPaterno")
        Dim UltraGridColumn365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ApellidoMaterno")
        Dim UltraGridColumn366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sexo")
        Dim UltraGridColumn368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaNacimiento")
        Dim UltraGridColumn369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Combo", -1)
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Extras")
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Extras", 0)
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacity")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Count")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsFixedSize")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsReadOnly")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsSynchronized")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SyncRoot")
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
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox14 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griDetalleDocumento = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraCheckEditor1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox10 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnQuitarD = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregarD = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gbeOrdenes = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrdenComercial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmbMatSerOC = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFinOC = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicioOC = New System.Windows.Forms.DateTimePicker()
        Me.griOrdenDocumento = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox15 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.BtnQuitarOv = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregarOv = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox17 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.GriOrdenesSalidas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox18 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btmConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.griOrdenSalida = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox16 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnQuitarOs = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregarOs = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griDocumento = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnAnular = New Infragistics.Win.Misc.UltraButton()
        Me.btnEliminar = New Infragistics.Win.Misc.UltraButton()
        Me.btnEnviar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ColorAtendido = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.colorAnulado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.colorGenerado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.grbNroOrden = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtSerieDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNroDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.rdbNroDocumento = New System.Windows.Forms.RadioButton()
        Me.rdbDatosBasicos = New System.Windows.Forms.RadioButton()
        Me.grbDatosBasicos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.cbgProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmb_Cliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.dtp_FechaTraslado = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboPuntoPartida = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Destino = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboPuntoLlegada = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chkAsociar = New System.Windows.Forms.CheckBox()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_DocAsoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTransportista = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNroLicencia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNroMTCC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtLlegada = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtMTC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbMotivoTraslado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboChofer = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbVehiculo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboCarreta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtPartida = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtSerie = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFechaDocumento = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.ficGuiaRR = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.EGRRVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EGuiaRRemitenteMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EComboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtMarcaVehiculo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox14.SuspendLayout()
        CType(Me.griDetalleDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox10.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.gbeOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeOrdenes.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.cmbMatSerOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griOrdenDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox15.SuspendLayout()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.UltraGroupBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox17.SuspendLayout()
        CType(Me.GriOrdenesSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox18.SuspendLayout()
        CType(Me.griOrdenSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox16.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.griDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.ColorAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbNroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNroOrden.SuspendLayout()
        CType(Me.txtSerieDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosBasicos.SuspendLayout()
        CType(Me.cbgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalle.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.cmb_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPuntoPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Destino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPuntoLlegada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.txt_DocAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroMTCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLlegada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMotivoTraslado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboChofer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficGuiaRR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficGuiaRR.SuspendLayout()
        CType(Me.EGRRVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGuiaRRemitenteMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EComboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarcaVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox14)
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox10)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1084, 178)
        '
        'UltraGroupBox14
        '
        Me.UltraGroupBox14.Controls.Add(Me.griDetalleDocumento)
        Me.UltraGroupBox14.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraGroupBox14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox14.Location = New System.Drawing.Point(0, 30)
        Me.UltraGroupBox14.Name = "UltraGroupBox14"
        Me.UltraGroupBox14.Size = New System.Drawing.Size(1084, 148)
        Me.UltraGroupBox14.TabIndex = 1
        Me.UltraGroupBox14.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetalleDocumento
        '
        Me.griDetalleDocumento.DataSource = Me.EGuiaRRemitenteMaterialBindingSource
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDetalleDocumento.DisplayLayout.Appearance = Appearance1
        UltraGridColumn78.Header.VisiblePosition = 0
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 1
        UltraGridColumn80.Header.VisiblePosition = 2
        UltraGridColumn81.Header.VisiblePosition = 4
        UltraGridColumn82.Header.Caption = "UnidadMedida"
        UltraGridColumn82.Header.VisiblePosition = 8
        UltraGridColumn83.Header.VisiblePosition = 3
        UltraGridColumn84.Header.VisiblePosition = 9
        UltraGridColumn85.Header.VisiblePosition = 6
        UltraGridColumn86.Header.VisiblePosition = 5
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn87.CellAppearance = Appearance2
        UltraGridColumn87.Header.Caption = "Peso (Tn)"
        UltraGridColumn87.Header.VisiblePosition = 10
        UltraGridColumn87.MaskInput = "{double:9.2}"
        UltraGridColumn87.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn88.Header.VisiblePosition = 7
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88})
        Me.griDetalleDocumento.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDetalleDocumento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleDocumento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetalleDocumento.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleDocumento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.griDetalleDocumento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleDocumento.DisplayLayout.GroupByBox.Hidden = True
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleDocumento.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.griDetalleDocumento.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleDocumento.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDetalleDocumento.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleDocumento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleDocumento.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetalleDocumento.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetalleDocumento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalleDocumento.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleDocumento.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleDocumento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BorderColor = System.Drawing.Color.Silver
        Me.griDetalleDocumento.DisplayLayout.Override.RowAppearance = Appearance6
        Me.griDetalleDocumento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleDocumento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleDocumento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalleDocumento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleDocumento.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griDetalleDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleDocumento.Location = New System.Drawing.Point(3, 3)
        Me.griDetalleDocumento.Name = "griDetalleDocumento"
        Me.griDetalleDocumento.Size = New System.Drawing.Size(1050, 142)
        Me.griDetalleDocumento.TabIndex = 0
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox1.Expanded = False
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(663, 142)
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(1053, 3)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(28, 142)
        Me.UltraExpandableGroupBox1.TabIndex = 13
        Me.UltraExpandableGroupBox1.Text = "Materiales"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.UltraExpandableGroupBox1.Visible = False
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraGroupBox13)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraGroupBox5)
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(640, 285)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel2.Visible = False
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.UltraGrid1)
        Me.UltraGroupBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox13.Location = New System.Drawing.Point(0, 39)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(640, 246)
        Me.UltraGroupBox13.TabIndex = 3
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGrid1
        '
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Appearance7.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance7
        UltraGridColumn37.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn37.Header.Caption = ""
        UltraGridColumn37.Header.VisiblePosition = 5
        UltraGridColumn37.Width = 29
        UltraGridColumn38.Header.VisiblePosition = 0
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 1
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 2
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.Caption = ""
        UltraGridColumn41.Header.VisiblePosition = 3
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 4
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 6
        UltraGridColumn43.Width = 233
        UltraGridColumn44.Header.VisiblePosition = 7
        UltraGridColumn44.Width = 213
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance8
        UltraGridColumn45.Header.VisiblePosition = 9
        UltraGridColumn45.MaskInput = "{double:9.4}"
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn46.Header.VisiblePosition = 10
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 11
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 12
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 13
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 14
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 15
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 16
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 17
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 18
        UltraGridColumn54.Hidden = True
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn55.CellAppearance = Appearance9
        UltraGridColumn55.Header.Caption = "Stock"
        UltraGridColumn55.Header.VisiblePosition = 8
        UltraGridColumn55.MaskInput = "{double:9.4}"
        UltraGridColumn55.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn56.Header.VisiblePosition = 19
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 20
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 21
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 22
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 23
        UltraGridColumn60.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60})
        Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance10
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance11
        Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.GroupByBox.Hidden = True
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance12.BackColor2 = System.Drawing.SystemColors.Control
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance12
        Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
        Me.UltraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.UltraGrid1.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.UltraGrid1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance13
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGrid1.Location = New System.Drawing.Point(3, 3)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(634, 240)
        Me.UltraGrid1.TabIndex = 6
        Me.UltraGrid1.Text = "Grilla2"
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.UltraCheckEditor1)
        Me.UltraGroupBox5.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox5.Controls.Add(Me.UltraTextEditor1)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel30)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(640, 39)
        Me.UltraGroupBox5.TabIndex = 2
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraCheckEditor1
        '
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraCheckEditor1.Appearance = Appearance14
        Me.UltraCheckEditor1.BackColor = System.Drawing.Color.Transparent
        Me.UltraCheckEditor1.BackColorInternal = System.Drawing.Color.Transparent
        Me.UltraCheckEditor1.Location = New System.Drawing.Point(403, 12)
        Me.UltraCheckEditor1.Name = "UltraCheckEditor1"
        Me.UltraCheckEditor1.Size = New System.Drawing.Size(60, 22)
        Me.UltraCheckEditor1.TabIndex = 347
        Me.UltraCheckEditor1.Text = "Codigo"
        '
        'UltraButton1
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Appearance15.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton1.Appearance = Appearance15
        Me.UltraButton1.Location = New System.Drawing.Point(367, 8)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(30, 28)
        Me.UltraButton1.TabIndex = 347
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UltraTextEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraTextEditor1.Location = New System.Drawing.Point(76, 12)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(288, 22)
        Me.UltraTextEditor1.TabIndex = 346
        '
        'UltraLabel30
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextVAlignAsString = "Middle"
        Me.UltraLabel30.Appearance = Appearance16
        Me.UltraLabel30.AutoSize = True
        Me.UltraLabel30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel30.Location = New System.Drawing.Point(11, 16)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel30.TabIndex = 345
        Me.UltraLabel30.Text = "Materiales:"
        '
        'UltraGroupBox10
        '
        Me.UltraGroupBox10.Controls.Add(Me.btnQuitarD)
        Me.UltraGroupBox10.Controls.Add(Me.btnAgregarD)
        Me.UltraGroupBox10.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox10.Name = "UltraGroupBox10"
        Me.UltraGroupBox10.Size = New System.Drawing.Size(1084, 30)
        Me.UltraGroupBox10.TabIndex = 0
        Me.UltraGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.UltraGroupBox10.Visible = False
        '
        'btnQuitarD
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Appearance17.Image = CType(resources.GetObject("Appearance17.Image"), Object)
        Me.btnQuitarD.Appearance = Appearance17
        Me.btnQuitarD.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnQuitarD.Location = New System.Drawing.Point(90, 3)
        Me.btnQuitarD.Name = "btnQuitarD"
        Me.btnQuitarD.Size = New System.Drawing.Size(87, 24)
        Me.btnQuitarD.TabIndex = 1
        Me.btnQuitarD.Text = "Quitar"
        Me.btnQuitarD.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAgregarD
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.Image = CType(resources.GetObject("Appearance18.Image"), Object)
        Me.btnAgregarD.Appearance = Appearance18
        Me.btnAgregarD.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgregarD.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregarD.Name = "btnAgregarD"
        Me.btnAgregarD.Size = New System.Drawing.Size(87, 24)
        Me.btnAgregarD.TabIndex = 0
        Me.btnAgregarD.Text = "Agregar"
        Me.btnAgregarD.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.gbeOrdenes)
        Me.UltraTabPageControl6.Controls.Add(Me.griOrdenDocumento)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGroupBox15)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1084, 178)
        '
        'gbeOrdenes
        '
        Me.gbeOrdenes.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeOrdenes.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.gbeOrdenes.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeOrdenes.Expanded = False
        Me.gbeOrdenes.ExpandedSize = New System.Drawing.Size(740, 148)
        Me.gbeOrdenes.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeOrdenes.Location = New System.Drawing.Point(1062, 30)
        Me.gbeOrdenes.Name = "gbeOrdenes"
        Me.gbeOrdenes.Size = New System.Drawing.Size(22, 148)
        Me.gbeOrdenes.TabIndex = 11
        Me.gbeOrdenes.Text = "Orden Venta / Salida"
        Me.gbeOrdenes.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.gbeOrdenes.Visible = False
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraGroupBox8)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraGroupBox9)
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(717, 291)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel3.Visible = False
        '
        'UltraGroupBox8
        '
        Me.UltraGroupBox8.Controls.Add(Me.griOrdenComercial)
        Me.UltraGroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox8.Location = New System.Drawing.Point(0, 40)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(717, 251)
        Me.UltraGroupBox8.TabIndex = 1
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrdenComercial
        '
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenComercial.DisplayLayout.Appearance = Appearance19
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 24
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 25
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 274
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 109
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 87
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn13.Width = 74
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Width = 115
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn15.CellAppearance = Appearance20
        UltraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn15.Header.VisiblePosition = 12
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Width = 269
        UltraGridColumn16.Header.VisiblePosition = 13
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 26
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 27
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 14
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 16
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 18
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 20
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 15
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 17
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 19
        UltraGridColumn26.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 21
        UltraGridColumn183.Hidden = True
        UltraGridColumn184.Header.VisiblePosition = 23
        UltraGridColumn184.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn183, UltraGridColumn184})
        Me.griOrdenComercial.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griOrdenComercial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance21.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Appearance = Appearance21
        Appearance22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance22
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Hidden = True
        Appearance23.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance23.BackColor2 = System.Drawing.SystemColors.Control
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance23.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.PromptAppearance = Appearance23
        Me.griOrdenComercial.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenComercial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenComercial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenComercial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenComercial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance24.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenComercial.DisplayLayout.Override.RowAppearance = Appearance24
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenComercial.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.griOrdenComercial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenComercial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenComercial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenComercial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenComercial.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenComercial.Name = "griOrdenComercial"
        Me.griOrdenComercial.Size = New System.Drawing.Size(711, 245)
        Me.griOrdenComercial.TabIndex = 6
        Me.griOrdenComercial.Text = "Grilla2"
        '
        'UltraGroupBox9
        '
        Me.UltraGroupBox9.Controls.Add(Me.cmbMatSerOC)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel23)
        Me.UltraGroupBox9.Controls.Add(Me.UltraButton2)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel22)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel24)
        Me.UltraGroupBox9.Controls.Add(Me.dtpFinOC)
        Me.UltraGroupBox9.Controls.Add(Me.dtpInicioOC)
        Me.UltraGroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(717, 40)
        Me.UltraGroupBox9.TabIndex = 0
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmbMatSerOC
        '
        Me.cmbMatSerOC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMatSerOC.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem3.DataValue = "1"
        ValueListItem3.DisplayText = "MATERIAL"
        ValueListItem4.DataValue = "2"
        ValueListItem4.DisplayText = "SERVICIO"
        Me.cmbMatSerOC.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.cmbMatSerOC.Location = New System.Drawing.Point(348, 8)
        Me.cmbMatSerOC.Name = "cmbMatSerOC"
        Me.cmbMatSerOC.Size = New System.Drawing.Size(152, 22)
        Me.cmbMatSerOC.TabIndex = 343
        '
        'UltraLabel23
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance25
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(304, 12)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(43, 15)
        Me.UltraLabel23.TabIndex = 342
        Me.UltraLabel23.Text = "Mat/Ser"
        '
        'UltraButton2
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Appearance26.Image = CType(resources.GetObject("Appearance26.Image"), Object)
        Me.UltraButton2.Appearance = Appearance26
        Me.UltraButton2.Location = New System.Drawing.Point(506, 6)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(87, 27)
        Me.UltraButton2.TabIndex = 340
        Me.UltraButton2.Text = "Consultar"
        Me.UltraButton2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel22
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Appearance27.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance27
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(162, 12)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel22.TabIndex = 339
        Me.UltraLabel22.Text = "Hasta:"
        '
        'UltraLabel24
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Appearance28.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance28
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(16, 12)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel24.TabIndex = 338
        Me.UltraLabel24.Text = "Desde:"
        '
        'dtpFinOC
        '
        Me.dtpFinOC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinOC.Location = New System.Drawing.Point(205, 9)
        Me.dtpFinOC.Name = "dtpFinOC"
        Me.dtpFinOC.Size = New System.Drawing.Size(95, 21)
        Me.dtpFinOC.TabIndex = 4
        '
        'dtpInicioOC
        '
        Me.dtpInicioOC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicioOC.Location = New System.Drawing.Point(61, 9)
        Me.dtpInicioOC.Name = "dtpInicioOC"
        Me.dtpInicioOC.Size = New System.Drawing.Size(95, 21)
        Me.dtpInicioOC.TabIndex = 3
        '
        'griOrdenDocumento
        '
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenDocumento.DisplayLayout.Appearance = Appearance29
        UltraGridColumn458.Header.VisiblePosition = 0
        UltraGridColumn458.Hidden = True
        UltraGridColumn459.Header.VisiblePosition = 3
        UltraGridColumn459.Width = 311
        UltraGridColumn460.Header.VisiblePosition = 4
        UltraGridColumn460.Width = 89
        UltraGridColumn461.Header.VisiblePosition = 1
        UltraGridColumn461.Width = 124
        UltraGridColumn462.Header.VisiblePosition = 5
        UltraGridColumn462.Hidden = True
        UltraGridColumn463.Header.VisiblePosition = 6
        UltraGridColumn463.Hidden = True
        UltraGridColumn464.Header.VisiblePosition = 7
        UltraGridColumn464.Hidden = True
        UltraGridColumn465.Header.VisiblePosition = 8
        UltraGridColumn465.Hidden = True
        UltraGridColumn466.Header.VisiblePosition = 9
        UltraGridColumn466.Hidden = True
        UltraGridColumn467.Header.VisiblePosition = 10
        UltraGridColumn467.Hidden = True
        UltraGridColumn468.Header.VisiblePosition = 11
        UltraGridColumn468.Hidden = True
        UltraGridColumn469.Header.VisiblePosition = 14
        UltraGridColumn469.Hidden = True
        UltraGridColumn470.Header.VisiblePosition = 12
        UltraGridColumn470.Hidden = True
        UltraGridColumn471.Header.Caption = "Tipo"
        UltraGridColumn471.Header.VisiblePosition = 2
        UltraGridColumn471.Width = 141
        UltraGridColumn472.Header.VisiblePosition = 13
        UltraGridColumn472.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn458, UltraGridColumn459, UltraGridColumn460, UltraGridColumn461, UltraGridColumn462, UltraGridColumn463, UltraGridColumn464, UltraGridColumn465, UltraGridColumn466, UltraGridColumn467, UltraGridColumn468, UltraGridColumn469, UltraGridColumn470, UltraGridColumn471, UltraGridColumn472})
        Me.griOrdenDocumento.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griOrdenDocumento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenDocumento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance30.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance30.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenDocumento.DisplayLayout.GroupByBox.Appearance = Appearance30
        Appearance31.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenDocumento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance31
        Me.griOrdenDocumento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenDocumento.DisplayLayout.GroupByBox.Hidden = True
        Appearance32.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance32.BackColor2 = System.Drawing.SystemColors.Control
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance32.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenDocumento.DisplayLayout.GroupByBox.PromptAppearance = Appearance32
        Me.griOrdenDocumento.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenDocumento.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenDocumento.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenDocumento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenDocumento.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenDocumento.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenDocumento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenDocumento.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenDocumento.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenDocumento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance33.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenDocumento.DisplayLayout.Override.RowAppearance = Appearance33
        Me.griOrdenDocumento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenDocumento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenDocumento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenDocumento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenDocumento.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenDocumento.Location = New System.Drawing.Point(0, 30)
        Me.griOrdenDocumento.Name = "griOrdenDocumento"
        Me.griOrdenDocumento.Size = New System.Drawing.Size(1084, 148)
        Me.griOrdenDocumento.TabIndex = 1
        Me.griOrdenDocumento.Text = "Grilla2"
        '
        'UltraGroupBox15
        '
        Me.UltraGroupBox15.Controls.Add(Me.BtnQuitarOv)
        Me.UltraGroupBox15.Controls.Add(Me.btnAgregarOv)
        Me.UltraGroupBox15.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox15.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox15.Name = "UltraGroupBox15"
        Me.UltraGroupBox15.Size = New System.Drawing.Size(1084, 30)
        Me.UltraGroupBox15.TabIndex = 0
        Me.UltraGroupBox15.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'BtnQuitarOv
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Appearance34.Image = CType(resources.GetObject("Appearance34.Image"), Object)
        Me.BtnQuitarOv.Appearance = Appearance34
        Me.BtnQuitarOv.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnQuitarOv.Location = New System.Drawing.Point(90, 3)
        Me.BtnQuitarOv.Name = "BtnQuitarOv"
        Me.BtnQuitarOv.Size = New System.Drawing.Size(87, 24)
        Me.BtnQuitarOv.TabIndex = 1
        Me.BtnQuitarOv.Text = "Quitar"
        Me.BtnQuitarOv.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAgregarOv
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.Image = CType(resources.GetObject("Appearance35.Image"), Object)
        Me.btnAgregarOv.Appearance = Appearance35
        Me.btnAgregarOv.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgregarOv.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregarOv.Name = "btnAgregarOv"
        Me.btnAgregarOv.Size = New System.Drawing.Size(87, 24)
        Me.btnAgregarOv.TabIndex = 0
        Me.btnAgregarOv.Text = "Agregar"
        Me.btnAgregarOv.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraTabPageControl7.Controls.Add(Me.griOrdenSalida)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGroupBox16)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1084, 178)
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox2.Expanded = False
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(740, 148)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(1062, 30)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(22, 148)
        Me.UltraExpandableGroupBox2.TabIndex = 12
        Me.UltraExpandableGroupBox2.Text = "Orden Venta / Salida"
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.UltraExpandableGroupBox2.Visible = False
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraGroupBox17)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraGroupBox18)
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(717, 291)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel4.Visible = False
        '
        'UltraGroupBox17
        '
        Me.UltraGroupBox17.Controls.Add(Me.GriOrdenesSalidas)
        Me.UltraGroupBox17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox17.Location = New System.Drawing.Point(0, 40)
        Me.UltraGroupBox17.Name = "UltraGroupBox17"
        Me.UltraGroupBox17.Size = New System.Drawing.Size(717, 251)
        Me.UltraGroupBox17.TabIndex = 1
        Me.UltraGroupBox17.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'GriOrdenesSalidas
        '
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Appearance36.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.GriOrdenesSalidas.DisplayLayout.Appearance = Appearance36
        UltraGridColumn385.Header.VisiblePosition = 0
        UltraGridColumn385.Hidden = True
        UltraGridColumn386.Header.VisiblePosition = 23
        UltraGridColumn386.Hidden = True
        UltraGridColumn387.Header.VisiblePosition = 24
        UltraGridColumn387.Hidden = True
        UltraGridColumn388.Header.VisiblePosition = 2
        UltraGridColumn388.Hidden = True
        UltraGridColumn389.Header.VisiblePosition = 3
        UltraGridColumn389.Hidden = True
        UltraGridColumn390.Header.VisiblePosition = 8
        UltraGridColumn390.Hidden = True
        UltraGridColumn391.Header.VisiblePosition = 9
        UltraGridColumn391.Hidden = True
        UltraGridColumn391.Width = 87
        UltraGridColumn392.Header.VisiblePosition = 6
        UltraGridColumn392.Hidden = True
        UltraGridColumn393.Header.VisiblePosition = 7
        UltraGridColumn393.Width = 109
        UltraGridColumn394.Header.VisiblePosition = 1
        UltraGridColumn394.Hidden = True
        UltraGridColumn395.Header.VisiblePosition = 4
        UltraGridColumn395.Width = 274
        UltraGridColumn396.Header.VisiblePosition = 10
        UltraGridColumn397.Header.VisiblePosition = 11
        UltraGridColumn397.Hidden = True
        UltraGridColumn398.Header.VisiblePosition = 12
        UltraGridColumn398.Hidden = True
        UltraGridColumn399.Header.VisiblePosition = 13
        UltraGridColumn399.Hidden = True
        UltraGridColumn400.Header.VisiblePosition = 14
        UltraGridColumn400.Hidden = True
        UltraGridColumn401.Header.VisiblePosition = 25
        UltraGridColumn401.Hidden = True
        Appearance37.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn402.CellAppearance = Appearance37
        UltraGridColumn402.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn402.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn402.Header.VisiblePosition = 5
        UltraGridColumn402.Width = 269
        UltraGridColumn403.Header.VisiblePosition = 21
        UltraGridColumn403.Hidden = True
        UltraGridColumn404.Header.VisiblePosition = 17
        UltraGridColumn404.Hidden = True
        UltraGridColumn405.Header.VisiblePosition = 19
        UltraGridColumn405.Hidden = True
        UltraGridColumn406.Header.VisiblePosition = 15
        UltraGridColumn406.Hidden = True
        UltraGridColumn407.Header.VisiblePosition = 16
        UltraGridColumn407.Hidden = True
        UltraGridColumn408.Header.VisiblePosition = 18
        UltraGridColumn408.Hidden = True
        UltraGridColumn446.Header.VisiblePosition = 20
        UltraGridColumn446.Hidden = True
        UltraGridColumn448.Header.VisiblePosition = 22
        UltraGridColumn448.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn385, UltraGridColumn386, UltraGridColumn387, UltraGridColumn388, UltraGridColumn389, UltraGridColumn390, UltraGridColumn391, UltraGridColumn392, UltraGridColumn393, UltraGridColumn394, UltraGridColumn395, UltraGridColumn396, UltraGridColumn397, UltraGridColumn398, UltraGridColumn399, UltraGridColumn400, UltraGridColumn401, UltraGridColumn402, UltraGridColumn403, UltraGridColumn404, UltraGridColumn405, UltraGridColumn406, UltraGridColumn407, UltraGridColumn408, UltraGridColumn446, UltraGridColumn448})
        Me.GriOrdenesSalidas.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.GriOrdenesSalidas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.GriOrdenesSalidas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance38.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance38.BorderColor = System.Drawing.SystemColors.Window
        Me.GriOrdenesSalidas.DisplayLayout.GroupByBox.Appearance = Appearance38
        Appearance39.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GriOrdenesSalidas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance39
        Me.GriOrdenesSalidas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.GriOrdenesSalidas.DisplayLayout.GroupByBox.Hidden = True
        Appearance40.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance40.BackColor2 = System.Drawing.SystemColors.Control
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance40.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GriOrdenesSalidas.DisplayLayout.GroupByBox.PromptAppearance = Appearance40
        Me.GriOrdenesSalidas.DisplayLayout.MaxColScrollRegions = 1
        Me.GriOrdenesSalidas.DisplayLayout.MaxRowScrollRegions = 1
        Me.GriOrdenesSalidas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GriOrdenesSalidas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GriOrdenesSalidas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.GriOrdenesSalidas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.GriOrdenesSalidas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GriOrdenesSalidas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GriOrdenesSalidas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GriOrdenesSalidas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance41.BorderColor = System.Drawing.Color.Silver
        Me.GriOrdenesSalidas.DisplayLayout.Override.RowAppearance = Appearance41
        Me.GriOrdenesSalidas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GriOrdenesSalidas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GriOrdenesSalidas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.GriOrdenesSalidas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.GriOrdenesSalidas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.GriOrdenesSalidas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.GriOrdenesSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GriOrdenesSalidas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GriOrdenesSalidas.Location = New System.Drawing.Point(3, 3)
        Me.GriOrdenesSalidas.Name = "GriOrdenesSalidas"
        Me.GriOrdenesSalidas.Size = New System.Drawing.Size(711, 245)
        Me.GriOrdenesSalidas.TabIndex = 6
        Me.GriOrdenesSalidas.Text = "Grilla2"
        '
        'UltraGroupBox18
        '
        Me.UltraGroupBox18.Controls.Add(Me.btmConsultar)
        Me.UltraGroupBox18.Controls.Add(Me.UltraLabel27)
        Me.UltraGroupBox18.Controls.Add(Me.UltraLabel28)
        Me.UltraGroupBox18.Controls.Add(Me.DateTimePicker1)
        Me.UltraGroupBox18.Controls.Add(Me.DateTimePicker2)
        Me.UltraGroupBox18.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox18.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox18.Name = "UltraGroupBox18"
        Me.UltraGroupBox18.Size = New System.Drawing.Size(717, 40)
        Me.UltraGroupBox18.TabIndex = 0
        Me.UltraGroupBox18.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btmConsultar
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Appearance42.Image = CType(resources.GetObject("Appearance42.Image"), Object)
        Me.btmConsultar.Appearance = Appearance42
        Me.btmConsultar.Location = New System.Drawing.Point(315, 6)
        Me.btmConsultar.Name = "btmConsultar"
        Me.btmConsultar.Size = New System.Drawing.Size(87, 27)
        Me.btmConsultar.TabIndex = 340
        Me.btmConsultar.Text = "Consultar"
        Me.btmConsultar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel27
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Appearance43.TextVAlignAsString = "Middle"
        Me.UltraLabel27.Appearance = Appearance43
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel27.Location = New System.Drawing.Point(162, 12)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel27.TabIndex = 339
        Me.UltraLabel27.Text = "Hasta:"
        '
        'UltraLabel28
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Appearance44.TextVAlignAsString = "Middle"
        Me.UltraLabel28.Appearance = Appearance44
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel28.Location = New System.Drawing.Point(16, 12)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel28.TabIndex = 338
        Me.UltraLabel28.Text = "Desde:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(205, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 21)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(61, 9)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(95, 21)
        Me.DateTimePicker2.TabIndex = 3
        '
        'griOrdenSalida
        '
        Appearance45.BackColor = System.Drawing.SystemColors.Window
        Appearance45.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenSalida.DisplayLayout.Appearance = Appearance45
        Appearance46.TextVAlignAsString = "Middle"
        UltraGridColumn449.CellAppearance = Appearance46
        UltraGridColumn449.Header.VisiblePosition = 0
        UltraGridColumn449.Hidden = True
        Appearance47.TextVAlignAsString = "Middle"
        UltraGridColumn450.CellAppearance = Appearance47
        UltraGridColumn450.Header.VisiblePosition = 1
        UltraGridColumn450.Hidden = True
        Appearance48.TextVAlignAsString = "Middle"
        UltraGridColumn451.CellAppearance = Appearance48
        UltraGridColumn451.Header.VisiblePosition = 2
        UltraGridColumn451.Hidden = True
        Appearance49.TextVAlignAsString = "Middle"
        UltraGridColumn473.CellAppearance = Appearance49
        UltraGridColumn473.Header.VisiblePosition = 3
        UltraGridColumn473.Hidden = True
        Appearance50.TextVAlignAsString = "Middle"
        UltraGridColumn474.CellAppearance = Appearance50
        UltraGridColumn474.Header.VisiblePosition = 6
        UltraGridColumn474.Width = 211
        Appearance51.TextHAlignAsString = "Center"
        Appearance51.TextVAlignAsString = "Middle"
        UltraGridColumn475.CellAppearance = Appearance51
        UltraGridColumn475.Header.VisiblePosition = 7
        UltraGridColumn475.Hidden = True
        Appearance52.TextVAlignAsString = "Middle"
        UltraGridColumn476.CellAppearance = Appearance52
        UltraGridColumn476.Header.VisiblePosition = 8
        UltraGridColumn476.Width = 83
        Appearance53.TextVAlignAsString = "Middle"
        UltraGridColumn477.CellAppearance = Appearance53
        UltraGridColumn477.Header.VisiblePosition = 9
        UltraGridColumn477.Hidden = True
        Appearance54.TextVAlignAsString = "Middle"
        UltraGridColumn478.CellAppearance = Appearance54
        UltraGridColumn478.Header.VisiblePosition = 23
        UltraGridColumn478.Width = 108
        Appearance55.TextVAlignAsString = "Middle"
        UltraGridColumn479.CellAppearance = Appearance55
        UltraGridColumn479.Header.VisiblePosition = 11
        UltraGridColumn479.Hidden = True
        Appearance56.TextVAlignAsString = "Middle"
        UltraGridColumn480.CellAppearance = Appearance56
        UltraGridColumn480.Header.VisiblePosition = 13
        UltraGridColumn480.Hidden = True
        Appearance57.TextVAlignAsString = "Middle"
        UltraGridColumn481.CellAppearance = Appearance57
        UltraGridColumn481.Header.VisiblePosition = 5
        UltraGridColumn481.Width = 108
        Appearance58.TextVAlignAsString = "Middle"
        UltraGridColumn482.CellAppearance = Appearance58
        UltraGridColumn482.Header.VisiblePosition = 19
        UltraGridColumn482.Hidden = True
        UltraGridColumn482.Width = 133
        Appearance59.TextVAlignAsString = "Middle"
        UltraGridColumn483.CellAppearance = Appearance59
        UltraGridColumn483.Header.Caption = "TipoReferencia"
        UltraGridColumn483.Header.VisiblePosition = 18
        UltraGridColumn483.Width = 141
        Appearance60.TextVAlignAsString = "Middle"
        UltraGridColumn484.CellAppearance = Appearance60
        UltraGridColumn484.Header.VisiblePosition = 20
        UltraGridColumn484.Hidden = True
        Appearance61.TextVAlignAsString = "Middle"
        UltraGridColumn485.CellAppearance = Appearance61
        UltraGridColumn485.Header.VisiblePosition = 21
        UltraGridColumn485.Width = 115
        Appearance62.TextVAlignAsString = "Middle"
        UltraGridColumn486.CellAppearance = Appearance62
        UltraGridColumn486.Header.VisiblePosition = 16
        UltraGridColumn486.Hidden = True
        Appearance63.TextVAlignAsString = "Middle"
        UltraGridColumn487.CellAppearance = Appearance63
        UltraGridColumn487.Header.VisiblePosition = 22
        UltraGridColumn487.Width = 245
        Appearance64.TextHAlignAsString = "Right"
        Appearance64.TextVAlignAsString = "Middle"
        UltraGridColumn488.CellAppearance = Appearance64
        UltraGridColumn488.Format = "###,##0.00"
        UltraGridColumn488.Header.VisiblePosition = 17
        UltraGridColumn488.MaskInput = "{double:9.2}"
        UltraGridColumn488.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn488.Width = 91
        Appearance65.TextVAlignAsString = "Middle"
        UltraGridColumn489.CellAppearance = Appearance65
        UltraGridColumn489.Header.VisiblePosition = 24
        UltraGridColumn489.Hidden = True
        Appearance66.TextVAlignAsString = "Middle"
        UltraGridColumn490.CellAppearance = Appearance66
        UltraGridColumn490.Header.VisiblePosition = 25
        UltraGridColumn490.Hidden = True
        Appearance67.TextVAlignAsString = "Middle"
        UltraGridColumn491.CellAppearance = Appearance67
        UltraGridColumn491.Header.VisiblePosition = 10
        UltraGridColumn491.Hidden = True
        Appearance68.TextVAlignAsString = "Middle"
        UltraGridColumn492.CellAppearance = Appearance68
        UltraGridColumn492.Header.Caption = "Fecha"
        UltraGridColumn492.Header.VisiblePosition = 4
        UltraGridColumn492.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn492.Width = 133
        Appearance69.TextVAlignAsString = "Middle"
        UltraGridColumn493.CellAppearance = Appearance69
        UltraGridColumn493.Header.VisiblePosition = 12
        UltraGridColumn493.Hidden = True
        Appearance70.TextVAlignAsString = "Middle"
        UltraGridColumn494.CellAppearance = Appearance70
        UltraGridColumn494.Header.VisiblePosition = 14
        UltraGridColumn494.Hidden = True
        Appearance71.TextVAlignAsString = "Middle"
        UltraGridColumn495.CellAppearance = Appearance71
        UltraGridColumn495.Header.VisiblePosition = 15
        UltraGridColumn495.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn449, UltraGridColumn450, UltraGridColumn451, UltraGridColumn473, UltraGridColumn474, UltraGridColumn475, UltraGridColumn476, UltraGridColumn477, UltraGridColumn478, UltraGridColumn479, UltraGridColumn480, UltraGridColumn481, UltraGridColumn482, UltraGridColumn483, UltraGridColumn484, UltraGridColumn485, UltraGridColumn486, UltraGridColumn487, UltraGridColumn488, UltraGridColumn489, UltraGridColumn490, UltraGridColumn491, UltraGridColumn492, UltraGridColumn493, UltraGridColumn494, UltraGridColumn495})
        Me.griOrdenSalida.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griOrdenSalida.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenSalida.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance72.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance72.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance72.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance72.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenSalida.DisplayLayout.GroupByBox.Appearance = Appearance72
        Appearance73.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenSalida.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance73
        Me.griOrdenSalida.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenSalida.DisplayLayout.GroupByBox.Hidden = True
        Appearance74.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance74.BackColor2 = System.Drawing.SystemColors.Control
        Appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance74.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenSalida.DisplayLayout.GroupByBox.PromptAppearance = Appearance74
        Me.griOrdenSalida.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenSalida.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenSalida.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenSalida.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenSalida.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenSalida.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenSalida.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenSalida.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenSalida.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenSalida.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance75.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenSalida.DisplayLayout.Override.RowAppearance = Appearance75
        Me.griOrdenSalida.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenSalida.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenSalida.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.griOrdenSalida.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenSalida.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenSalida.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenSalida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenSalida.Location = New System.Drawing.Point(0, 30)
        Me.griOrdenSalida.Name = "griOrdenSalida"
        Me.griOrdenSalida.Size = New System.Drawing.Size(1084, 148)
        Me.griOrdenSalida.TabIndex = 1
        Me.griOrdenSalida.Text = "Grilla2"
        '
        'UltraGroupBox16
        '
        Me.UltraGroupBox16.Controls.Add(Me.btnQuitarOs)
        Me.UltraGroupBox16.Controls.Add(Me.btnAgregarOs)
        Me.UltraGroupBox16.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox16.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox16.Name = "UltraGroupBox16"
        Me.UltraGroupBox16.Size = New System.Drawing.Size(1084, 30)
        Me.UltraGroupBox16.TabIndex = 0
        Me.UltraGroupBox16.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnQuitarOs
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Appearance76.Image = CType(resources.GetObject("Appearance76.Image"), Object)
        Me.btnQuitarOs.Appearance = Appearance76
        Me.btnQuitarOs.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnQuitarOs.Location = New System.Drawing.Point(90, 3)
        Me.btnQuitarOs.Name = "btnQuitarOs"
        Me.btnQuitarOs.Size = New System.Drawing.Size(87, 24)
        Me.btnQuitarOs.TabIndex = 1
        Me.btnQuitarOs.Text = "Quitar"
        Me.btnQuitarOs.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAgregarOs
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Appearance77.Image = CType(resources.GetObject("Appearance77.Image"), Object)
        Me.btnAgregarOs.Appearance = Appearance77
        Me.btnAgregarOs.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgregarOs.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregarOs.Name = "btnAgregarOs"
        Me.btnAgregarOs.Size = New System.Drawing.Size(87, 24)
        Me.btnAgregarOs.TabIndex = 0
        Me.btnAgregarOs.Text = "Agregar"
        Me.btnAgregarOs.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1086, 427)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.griDocumento)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 130)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1086, 297)
        Me.UltraGroupBox3.TabIndex = 2
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDocumento
        '
        Me.griDocumento.DataSource = Me.EGRRVentaBindingSource
        Appearance78.BackColor = System.Drawing.SystemColors.Window
        Appearance78.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDocumento.DisplayLayout.Appearance = Appearance78
        UltraGridColumn89.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn89.Header.VisiblePosition = 0
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn90.Header.VisiblePosition = 1
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn91.Header.VisiblePosition = 2
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 3
        UltraGridColumn93.Header.VisiblePosition = 4
        UltraGridColumn94.Header.VisiblePosition = 5
        UltraGridColumn95.Header.VisiblePosition = 6
        UltraGridColumn96.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn96.Header.VisiblePosition = 7
        UltraGridColumn97.Header.VisiblePosition = 9
        UltraGridColumn98.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn98.Header.VisiblePosition = 14
        UltraGridColumn98.Width = 60
        UltraGridColumn99.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn99.Header.VisiblePosition = 15
        UltraGridColumn99.Width = 86
        UltraGridColumn100.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn100.Header.VisiblePosition = 8
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 12
        UltraGridColumn102.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn102.Header.VisiblePosition = 10
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 16
        UltraGridColumn104.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn104.Header.VisiblePosition = 11
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 17
        UltraGridColumn106.Header.VisiblePosition = 19
        UltraGridColumn107.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn107.Header.VisiblePosition = 20
        UltraGridColumn107.Hidden = True
        UltraGridColumn107.Width = 49
        UltraGridColumn108.Header.VisiblePosition = 21
        UltraGridColumn109.Header.VisiblePosition = 22
        UltraGridColumn110.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn110.Header.VisiblePosition = 13
        UltraGridColumn110.Hidden = True
        UltraGridColumn111.Header.VisiblePosition = 24
        UltraGridColumn112.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn112.Header.VisiblePosition = 18
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn113.Header.VisiblePosition = 23
        UltraGridColumn113.Width = 108
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113})
        Me.griDocumento.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griDocumento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDocumento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance79.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance79.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance79.BorderColor = System.Drawing.SystemColors.Window
        Me.griDocumento.DisplayLayout.GroupByBox.Appearance = Appearance79
        Appearance80.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDocumento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance80
        Me.griDocumento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDocumento.DisplayLayout.GroupByBox.Hidden = True
        Appearance81.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance81.BackColor2 = System.Drawing.SystemColors.Control
        Appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance81.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDocumento.DisplayLayout.GroupByBox.PromptAppearance = Appearance81
        Me.griDocumento.DisplayLayout.MaxColScrollRegions = 1
        Me.griDocumento.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDocumento.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDocumento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDocumento.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDocumento.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDocumento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDocumento.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDocumento.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDocumento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance82.BorderColor = System.Drawing.Color.Silver
        Me.griDocumento.DisplayLayout.Override.RowAppearance = Appearance82
        Me.griDocumento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDocumento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDocumento.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.griDocumento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDocumento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDocumento.Location = New System.Drawing.Point(3, 3)
        Me.griDocumento.Name = "griDocumento"
        Me.griDocumento.Size = New System.Drawing.Size(1080, 291)
        Me.griDocumento.TabIndex = 0
        Me.griDocumento.Text = "Grilla2"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.btnAnular)
        Me.UltraGroupBox2.Controls.Add(Me.btnEliminar)
        Me.UltraGroupBox2.Controls.Add(Me.btnEnviar)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 98)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1086, 32)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnAnular
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Appearance83.ForeColor = System.Drawing.Color.Navy
        Me.btnAnular.Appearance = Appearance83
        Me.btnAnular.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnular.Location = New System.Drawing.Point(177, 3)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(87, 26)
        Me.btnAnular.TabIndex = 2
        Me.btnAnular.Text = "&Anular"
        Me.btnAnular.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnEliminar
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Appearance = Appearance84
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(90, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 26)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnEnviar
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Me.btnEnviar.Appearance = Appearance85
        Me.btnEnviar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Location = New System.Drawing.Point(3, 3)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(87, 26)
        Me.btnEnviar.TabIndex = 0
        Me.btnEnviar.Text = "&Enviar"
        Me.btnEnviar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox11)
        Me.UltraGroupBox1.Controls.Add(Me.grbNroOrden)
        Me.UltraGroupBox1.Controls.Add(Me.rdbNroDocumento)
        Me.UltraGroupBox1.Controls.Add(Me.rdbDatosBasicos)
        Me.UltraGroupBox1.Controls.Add(Me.grbDatosBasicos)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1086, 98)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Buscar"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox11
        '
        Me.UltraGroupBox11.Controls.Add(Me.ColorAtendido)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel19)
        Me.UltraGroupBox11.Controls.Add(Me.colorAnulado)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox11.Controls.Add(Me.colorGenerado)
        Me.UltraGroupBox11.Location = New System.Drawing.Point(581, 35)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(366, 39)
        Me.UltraGroupBox11.TabIndex = 4
        Me.UltraGroupBox11.Text = "Estados"
        Me.UltraGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorAtendido
        '
        Me.ColorAtendido.Color = System.Drawing.Color.LightGreen
        Me.ColorAtendido.Location = New System.Drawing.Point(287, 12)
        Me.ColorAtendido.Name = "ColorAtendido"
        Me.ColorAtendido.Size = New System.Drawing.Size(46, 22)
        Me.ColorAtendido.TabIndex = 5
        Me.ColorAtendido.Text = "LightGreen"
        '
        'UltraLabel19
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Appearance86.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance86
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(231, 16)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel19.TabIndex = 4
        Me.UltraLabel19.Text = "Atendido:"
        '
        'colorAnulado
        '
        Me.colorAnulado.Color = System.Drawing.Color.PaleVioletRed
        Me.colorAnulado.Location = New System.Drawing.Point(171, 12)
        Me.colorAnulado.Name = "colorAnulado"
        Me.colorAnulado.Size = New System.Drawing.Size(46, 22)
        Me.colorAnulado.TabIndex = 3
        Me.colorAnulado.Text = "PaleVioletRed"
        '
        'UltraLabel26
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Appearance87.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance87
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel26.Location = New System.Drawing.Point(120, 16)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(49, 15)
        Me.UltraLabel26.TabIndex = 2
        Me.UltraLabel26.Text = "Anulado:"
        '
        'UltraLabel21
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Appearance88.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance88
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(6, 16)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(56, 15)
        Me.UltraLabel21.TabIndex = 0
        Me.UltraLabel21.Text = "Generado:"
        '
        'colorGenerado
        '
        Me.colorGenerado.Color = System.Drawing.Color.White
        Me.colorGenerado.Location = New System.Drawing.Point(68, 12)
        Me.colorGenerado.Name = "colorGenerado"
        Me.colorGenerado.Size = New System.Drawing.Size(46, 22)
        Me.colorGenerado.TabIndex = 1
        Me.colorGenerado.Text = "White"
        '
        'grbNroOrden
        '
        Me.grbNroOrden.Controls.Add(Me.txtSerieDoc)
        Me.grbNroOrden.Controls.Add(Me.txtNroDoc)
        Me.grbNroOrden.Location = New System.Drawing.Point(382, 35)
        Me.grbNroOrden.Name = "grbNroOrden"
        Me.grbNroOrden.Size = New System.Drawing.Size(193, 39)
        Me.grbNroOrden.TabIndex = 3
        Me.grbNroOrden.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtSerieDoc
        '
        Me.txtSerieDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieDoc.Location = New System.Drawing.Point(6, 9)
        Me.txtSerieDoc.MaxLength = 4
        Me.txtSerieDoc.Name = "txtSerieDoc"
        Me.txtSerieDoc.Size = New System.Drawing.Size(56, 22)
        Me.txtSerieDoc.TabIndex = 0
        '
        'txtNroDoc
        '
        Me.txtNroDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroDoc.Location = New System.Drawing.Point(68, 9)
        Me.txtNroDoc.MaxLength = 8
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(113, 22)
        Me.txtNroDoc.TabIndex = 1
        '
        'rdbNroDocumento
        '
        Me.rdbNroDocumento.AutoSize = True
        Me.rdbNroDocumento.BackColor = System.Drawing.Color.Transparent
        Me.rdbNroDocumento.ForeColor = System.Drawing.Color.Navy
        Me.rdbNroDocumento.Location = New System.Drawing.Point(382, 18)
        Me.rdbNroDocumento.Name = "rdbNroDocumento"
        Me.rdbNroDocumento.Size = New System.Drawing.Size(99, 17)
        Me.rdbNroDocumento.TabIndex = 2
        Me.rdbNroDocumento.Text = "Nro Documento"
        Me.rdbNroDocumento.UseVisualStyleBackColor = False
        '
        'rdbDatosBasicos
        '
        Me.rdbDatosBasicos.AutoSize = True
        Me.rdbDatosBasicos.BackColor = System.Drawing.Color.Transparent
        Me.rdbDatosBasicos.Checked = True
        Me.rdbDatosBasicos.ForeColor = System.Drawing.Color.Navy
        Me.rdbDatosBasicos.Location = New System.Drawing.Point(11, 18)
        Me.rdbDatosBasicos.Name = "rdbDatosBasicos"
        Me.rdbDatosBasicos.Size = New System.Drawing.Size(91, 17)
        Me.rdbDatosBasicos.TabIndex = 0
        Me.rdbDatosBasicos.TabStop = True
        Me.rdbDatosBasicos.Text = "Datos Basicos"
        Me.rdbDatosBasicos.UseVisualStyleBackColor = False
        '
        'grbDatosBasicos
        '
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel15)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel18)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel16)
        Me.grbDatosBasicos.Controls.Add(Me.dtpFechaInicio)
        Me.grbDatosBasicos.Controls.Add(Me.dtpFechaFin)
        Me.grbDatosBasicos.Controls.Add(Me.cbgProveedor)
        Me.grbDatosBasicos.Location = New System.Drawing.Point(11, 35)
        Me.grbDatosBasicos.Name = "grbDatosBasicos"
        Me.grbDatosBasicos.Size = New System.Drawing.Size(352, 58)
        Me.grbDatosBasicos.TabIndex = 1
        Me.grbDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel15
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Appearance89.ForeColor = System.Drawing.Color.Navy
        Appearance89.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance89
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(6, 9)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel15.TabIndex = 3
        Me.UltraLabel15.Text = "Desde:"
        '
        'UltraLabel18
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Appearance90.ForeColor = System.Drawing.Color.Navy
        Appearance90.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance90
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(6, 35)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel18.TabIndex = 4
        Me.UltraLabel18.Text = "Cliente:"
        '
        'UltraLabel16
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Appearance91.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance91
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(177, 9)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel16.TabIndex = 1
        Me.UltraLabel16.Text = "Hasta:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(52, 5)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(114, 21)
        Me.dtpFechaInicio.TabIndex = 0
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(220, 5)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(110, 21)
        Me.dtpFechaFin.TabIndex = 2
        '
        'cbgProveedor
        '
        Appearance92.BackColor = System.Drawing.SystemColors.Window
        Appearance92.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgProveedor.DisplayLayout.Appearance = Appearance92
        UltraGridColumn186.Header.VisiblePosition = 0
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.VisiblePosition = 1
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.Header.VisiblePosition = 2
        UltraGridColumn188.Hidden = True
        UltraGridColumn189.Header.VisiblePosition = 3
        UltraGridColumn189.Hidden = True
        UltraGridColumn190.Header.VisiblePosition = 4
        UltraGridColumn190.Hidden = True
        UltraGridColumn191.Header.VisiblePosition = 5
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 6
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.Caption = "RUC"
        UltraGridColumn193.Header.VisiblePosition = 7
        UltraGridColumn193.Width = 100
        UltraGridColumn194.Header.VisiblePosition = 8
        UltraGridColumn194.Width = 250
        UltraGridColumn195.Header.VisiblePosition = 9
        UltraGridColumn195.Hidden = True
        UltraGridColumn196.Header.VisiblePosition = 10
        UltraGridColumn196.Hidden = True
        UltraGridColumn197.Header.VisiblePosition = 11
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.Header.VisiblePosition = 12
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.VisiblePosition = 13
        UltraGridColumn199.Hidden = True
        UltraGridColumn200.Header.VisiblePosition = 14
        UltraGridColumn200.Hidden = True
        UltraGridColumn201.Header.VisiblePosition = 15
        UltraGridColumn201.Hidden = True
        UltraGridColumn202.Header.VisiblePosition = 16
        UltraGridColumn202.Hidden = True
        UltraGridColumn203.Header.VisiblePosition = 17
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 18
        UltraGridColumn204.Hidden = True
        UltraGridColumn205.Header.VisiblePosition = 19
        UltraGridColumn205.Hidden = True
        UltraGridColumn206.Header.VisiblePosition = 20
        UltraGridColumn206.Hidden = True
        UltraGridColumn207.Header.VisiblePosition = 26
        UltraGridColumn208.Header.VisiblePosition = 27
        UltraGridColumn209.Header.VisiblePosition = 28
        UltraGridColumn210.Header.VisiblePosition = 29
        UltraGridColumn211.Header.VisiblePosition = 30
        UltraGridColumn212.Header.VisiblePosition = 21
        UltraGridColumn212.Hidden = True
        UltraGridColumn213.Header.VisiblePosition = 22
        UltraGridColumn213.Hidden = True
        UltraGridColumn244.Header.VisiblePosition = 23
        UltraGridColumn244.Hidden = True
        UltraGridColumn245.Header.VisiblePosition = 24
        UltraGridColumn245.Hidden = True
        UltraGridColumn246.Header.VisiblePosition = 25
        UltraGridColumn246.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246})
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
        UltraGridColumn272.Header.VisiblePosition = 25
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271, UltraGridColumn272})
        UltraGridColumn273.Header.VisiblePosition = 0
        UltraGridColumn274.Header.VisiblePosition = 1
        UltraGridColumn275.Header.VisiblePosition = 2
        UltraGridColumn276.Header.VisiblePosition = 3
        UltraGridColumn277.Header.VisiblePosition = 4
        UltraGridColumn278.Header.VisiblePosition = 5
        UltraGridColumn279.Header.VisiblePosition = 6
        UltraGridColumn280.Header.VisiblePosition = 7
        UltraGridColumn281.Header.VisiblePosition = 8
        UltraGridColumn282.Header.VisiblePosition = 9
        UltraGridColumn283.Header.VisiblePosition = 10
        UltraGridColumn284.Header.VisiblePosition = 11
        UltraGridColumn285.Header.VisiblePosition = 12
        UltraGridColumn286.Header.VisiblePosition = 13
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286})
        UltraGridColumn287.Header.VisiblePosition = 0
        UltraGridColumn288.Header.VisiblePosition = 1
        UltraGridColumn289.Header.VisiblePosition = 2
        UltraGridColumn290.Header.VisiblePosition = 3
        UltraGridColumn291.Header.VisiblePosition = 4
        UltraGridColumn292.Header.VisiblePosition = 5
        UltraGridColumn293.Header.VisiblePosition = 6
        UltraGridColumn294.Header.VisiblePosition = 7
        UltraGridColumn295.Header.VisiblePosition = 8
        UltraGridColumn296.Header.VisiblePosition = 9
        UltraGridColumn297.Header.VisiblePosition = 10
        UltraGridColumn298.Header.VisiblePosition = 11
        UltraGridColumn299.Header.VisiblePosition = 12
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295, UltraGridColumn296, UltraGridColumn297, UltraGridColumn298, UltraGridColumn299})
        UltraGridColumn300.Header.VisiblePosition = 0
        UltraGridColumn301.Header.VisiblePosition = 1
        UltraGridColumn302.Header.VisiblePosition = 2
        UltraGridColumn303.Header.VisiblePosition = 3
        UltraGridColumn304.Header.VisiblePosition = 4
        UltraGridColumn305.Header.VisiblePosition = 5
        UltraGridColumn306.Header.VisiblePosition = 6
        UltraGridColumn317.Header.VisiblePosition = 7
        UltraGridColumn318.Header.VisiblePosition = 8
        UltraGridColumn358.Header.VisiblePosition = 9
        UltraGridColumn359.Header.VisiblePosition = 10
        UltraGridColumn360.Header.VisiblePosition = 11
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn317, UltraGridColumn318, UltraGridColumn358, UltraGridColumn359, UltraGridColumn360})
        UltraGridColumn361.Header.VisiblePosition = 0
        UltraGridColumn362.Header.VisiblePosition = 1
        UltraGridColumn363.Header.VisiblePosition = 2
        UltraGridColumn364.Header.VisiblePosition = 3
        UltraGridColumn365.Header.VisiblePosition = 4
        UltraGridColumn366.Header.VisiblePosition = 5
        UltraGridColumn367.Header.VisiblePosition = 6
        UltraGridColumn368.Header.VisiblePosition = 7
        UltraGridColumn369.Header.VisiblePosition = 8
        UltraGridColumn370.Header.VisiblePosition = 9
        UltraGridColumn371.Header.VisiblePosition = 10
        UltraGridColumn372.Header.VisiblePosition = 11
        UltraGridColumn373.Header.VisiblePosition = 12
        UltraGridColumn374.Header.VisiblePosition = 13
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn361, UltraGridColumn362, UltraGridColumn363, UltraGridColumn364, UltraGridColumn365, UltraGridColumn366, UltraGridColumn367, UltraGridColumn368, UltraGridColumn369, UltraGridColumn370, UltraGridColumn371, UltraGridColumn372, UltraGridColumn373, UltraGridColumn374})
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.cbgProveedor.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance93.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance93.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance93.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgProveedor.DisplayLayout.GroupByBox.Appearance = Appearance93
        Appearance94.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgProveedor.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance94
        Me.cbgProveedor.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance95.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance95.BackColor2 = System.Drawing.SystemColors.Control
        Appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance95.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgProveedor.DisplayLayout.GroupByBox.PromptAppearance = Appearance95
        Me.cbgProveedor.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgProveedor.DisplayLayout.MaxRowScrollRegions = 1
        Appearance96.BackColor = System.Drawing.SystemColors.Window
        Appearance96.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgProveedor.DisplayLayout.Override.ActiveCellAppearance = Appearance96
        Appearance97.BackColor = System.Drawing.SystemColors.Highlight
        Appearance97.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbgProveedor.DisplayLayout.Override.ActiveRowAppearance = Appearance97
        Me.cbgProveedor.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cbgProveedor.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance98.BackColor = System.Drawing.SystemColors.Window
        Me.cbgProveedor.DisplayLayout.Override.CardAreaAppearance = Appearance98
        Appearance99.BorderColor = System.Drawing.Color.Silver
        Appearance99.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbgProveedor.DisplayLayout.Override.CellAppearance = Appearance99
        Me.cbgProveedor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgProveedor.DisplayLayout.Override.CellPadding = 0
        Appearance100.BackColor = System.Drawing.SystemColors.Control
        Appearance100.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance100.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance100.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgProveedor.DisplayLayout.Override.GroupByRowAppearance = Appearance100
        Appearance101.TextHAlignAsString = "Left"
        Me.cbgProveedor.DisplayLayout.Override.HeaderAppearance = Appearance101
        Me.cbgProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cbgProveedor.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance102.BackColor = System.Drawing.SystemColors.Window
        Appearance102.BorderColor = System.Drawing.Color.Silver
        Me.cbgProveedor.DisplayLayout.Override.RowAppearance = Appearance102
        Me.cbgProveedor.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance103.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgProveedor.DisplayLayout.Override.TemplateAddRowAppearance = Appearance103
        Me.cbgProveedor.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbgProveedor.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgProveedor.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbgProveedor.DisplayMember = "Nombre"
        Me.cbgProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbgProveedor.Location = New System.Drawing.Point(52, 27)
        Me.cbgProveedor.Name = "cbgProveedor"
        Me.cbgProveedor.Size = New System.Drawing.Size(278, 23)
        Me.cbgProveedor.TabIndex = 5
        Me.cbgProveedor.ValueMember = "Id"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ficDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1086, 427)
        '
        'ficDetalle
        '
        Me.ficDetalle.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl5)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl6)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalle.Location = New System.Drawing.Point(0, 226)
        Me.ficDetalle.Name = "ficDetalle"
        Me.ficDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficDetalle.Size = New System.Drawing.Size(1086, 201)
        Me.ficDetalle.TabIndex = 1
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Detalle"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Orden Venta"
        UltraTab6.Visible = False
        UltraTab2.TabPage = Me.UltraTabPageControl7
        UltraTab2.Text = "Orden Salida"
        UltraTab2.Visible = False
        Me.ficDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6, UltraTab2})
        Me.ficDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1084, 178)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.cmb_Cliente)
        Me.UltraGroupBox4.Controls.Add(Me.dtp_FechaTraslado)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox4.Controls.Add(Me.cboPuntoPartida)
        Me.UltraGroupBox4.Controls.Add(Me.txt_Destino)
        Me.UltraGroupBox4.Controls.Add(Me.cboPuntoLlegada)
        Me.UltraGroupBox4.Controls.Add(Me.txtNroMTCC)
        Me.UltraGroupBox4.Controls.Add(Me.chkAsociar)
        Me.UltraGroupBox4.Controls.Add(Me.UltraGroupBox6)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox4.Controls.Add(Me.txtPartida)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox4.Controls.Add(Me.txtNumero)
        Me.UltraGroupBox4.Controls.Add(Me.txtSerie)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox4.Controls.Add(Me.dtpFechaDocumento)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1086, 226)
        Me.UltraGroupBox4.TabIndex = 0
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmb_Cliente.CheckedListSettings.ListSeparator = ","
        Me.cmb_Cliente.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cmb_Cliente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cmb_Cliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_Cliente.DropDownWidth = 400
        Me.cmb_Cliente.Location = New System.Drawing.Point(78, 12)
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Size = New System.Drawing.Size(304, 23)
        Me.cmb_Cliente.TabIndex = 1
        '
        'dtp_FechaTraslado
        '
        Me.dtp_FechaTraslado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaTraslado.Location = New System.Drawing.Point(851, 15)
        Me.dtp_FechaTraslado.Name = "dtp_FechaTraslado"
        Me.dtp_FechaTraslado.Size = New System.Drawing.Size(100, 21)
        Me.dtp_FechaTraslado.TabIndex = 8
        '
        'UltraLabel12
        '
        Appearance104.BackColor = System.Drawing.Color.Transparent
        Appearance104.ForeColor = System.Drawing.Color.Navy
        Appearance104.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance104
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(760, 18)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(84, 15)
        Me.UltraLabel12.TabIndex = 7
        Me.UltraLabel12.Text = "Fecha Traslado:"
        '
        'cboPuntoPartida
        '
        Me.cboPuntoPartida.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPuntoPartida.DisplayMember = "Nombre"
        Me.cboPuntoPartida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboPuntoPartida.Location = New System.Drawing.Point(97, 166)
        Me.cboPuntoPartida.Name = "cboPuntoPartida"
        Me.cboPuntoPartida.Size = New System.Drawing.Size(206, 22)
        Me.cboPuntoPartida.TabIndex = 11
        Me.cboPuntoPartida.ValueMember = "Id"
        '
        'txt_Destino
        '
        Me.txt_Destino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Destino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Destino.Location = New System.Drawing.Point(309, 194)
        Me.txt_Destino.Name = "txt_Destino"
        Me.txt_Destino.Size = New System.Drawing.Size(627, 22)
        Me.txt_Destino.TabIndex = 15
        Me.txt_Destino.TabStop = False
        '
        'cboPuntoLlegada
        '
        Me.cboPuntoLlegada.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPuntoLlegada.DisplayMember = "Nombre"
        Me.cboPuntoLlegada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboPuntoLlegada.Location = New System.Drawing.Point(97, 194)
        Me.cboPuntoLlegada.Name = "cboPuntoLlegada"
        Me.cboPuntoLlegada.Size = New System.Drawing.Size(206, 22)
        Me.cboPuntoLlegada.TabIndex = 14
        Me.cboPuntoLlegada.ValueMember = "Id"
        '
        'chkAsociar
        '
        Me.chkAsociar.AutoSize = True
        Me.chkAsociar.BackColor = System.Drawing.Color.Transparent
        Me.chkAsociar.ForeColor = System.Drawing.Color.Navy
        Me.chkAsociar.Location = New System.Drawing.Point(957, 104)
        Me.chkAsociar.Name = "chkAsociar"
        Me.chkAsociar.Size = New System.Drawing.Size(118, 17)
        Me.chkAsociar.TabIndex = 14
        Me.chkAsociar.Text = "Asociar Documento"
        Me.chkAsociar.UseVisualStyleBackColor = False
        Me.chkAsociar.Visible = False
        '
        'UltraGroupBox6
        '
        Appearance105.BackColor = System.Drawing.Color.Black
        Me.UltraGroupBox6.Appearance = Appearance105
        Me.UltraGroupBox6.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.RectangularSolid
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox6.Controls.Add(Me.txtMarcaVehiculo)
        Me.UltraGroupBox6.Controls.Add(Me.txt_DocAsoc)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox6.Controls.Add(Me.cboTransportista)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel25)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox6.Controls.Add(Me.txtNroLicencia)
        Me.UltraGroupBox6.Controls.Add(Me.txtLlegada)
        Me.UltraGroupBox6.Controls.Add(Me.txtMTC)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox6.Controls.Add(Me.cmbMotivoTraslado)
        Me.UltraGroupBox6.Controls.Add(Me.cboChofer)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox6.Controls.Add(Me.cmbVehiculo)
        Me.UltraGroupBox6.Controls.Add(Me.cboCarreta)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox6.Location = New System.Drawing.Point(6, 42)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(945, 118)
        Me.UltraGroupBox6.TabIndex = 9
        Me.UltraGroupBox6.Text = "Datos Transporte"
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txt_DocAsoc
        '
        Me.txt_DocAsoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_DocAsoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_DocAsoc.Location = New System.Drawing.Point(783, 29)
        Me.txt_DocAsoc.Name = "txt_DocAsoc"
        Me.txt_DocAsoc.Size = New System.Drawing.Size(147, 22)
        Me.txt_DocAsoc.TabIndex = 5
        '
        'UltraLabel13
        '
        Appearance107.BackColor = System.Drawing.Color.Transparent
        Appearance107.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance107
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(727, 33)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(49, 15)
        Me.UltraLabel13.TabIndex = 4
        Me.UltraLabel13.Text = "Nro Doc:"
        '
        'cboTransportista
        '
        Me.cboTransportista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTransportista.CheckedListSettings.ListSeparator = ","
        Me.cboTransportista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboTransportista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboTransportista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTransportista.DropDownWidth = 400
        Me.cboTransportista.Location = New System.Drawing.Point(91, 28)
        Me.cboTransportista.Name = "cboTransportista"
        Me.cboTransportista.Size = New System.Drawing.Size(384, 23)
        Me.cboTransportista.TabIndex = 1
        '
        'UltraLabel25
        '
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Appearance108.ForeColor = System.Drawing.Color.Navy
        Appearance108.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance108
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(11, 33)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(74, 15)
        Me.UltraLabel25.TabIndex = 0
        Me.UltraLabel25.Text = "Transportista:"
        '
        'UltraLabel17
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Appearance109.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance109
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(492, 89)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(68, 15)
        Me.UltraLabel17.TabIndex = 16
        Me.UltraLabel17.Text = "N°. Licencia:"
        '
        'txtNroLicencia
        '
        EditorButton2.Key = "Right"
        Me.txtNroLicencia.ButtonsRight.Add(EditorButton2)
        Me.txtNroLicencia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroLicencia.Location = New System.Drawing.Point(566, 86)
        Me.txtNroLicencia.MaxLength = 9
        Me.txtNroLicencia.Name = "txtNroLicencia"
        Me.txtNroLicencia.Size = New System.Drawing.Size(182, 22)
        Me.txtNroLicencia.TabIndex = 17
        Me.txtNroLicencia.Tag = "Numero Documento"
        '
        'txtNroMTCC
        '
        EditorButton1.Key = "Right"
        Me.txtNroMTCC.ButtonsRight.Add(EditorButton1)
        Me.txtNroMTCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroMTCC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroMTCC.Location = New System.Drawing.Point(1051, 40)
        Me.txtNroMTCC.MaxLength = 10
        Me.txtNroMTCC.Name = "txtNroMTCC"
        Me.txtNroMTCC.Size = New System.Drawing.Size(147, 22)
        Me.txtNroMTCC.TabIndex = 13
        Me.txtNroMTCC.TabStop = False
        Me.txtNroMTCC.Tag = "Numero Documento"
        Me.txtNroMTCC.Visible = False
        '
        'txtLlegada
        '
        Me.txtLlegada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtLlegada.Location = New System.Drawing.Point(754, 86)
        Me.txtLlegada.Name = "txtLlegada"
        Me.txtLlegada.Size = New System.Drawing.Size(10, 22)
        Me.txtLlegada.TabIndex = 18
        Me.txtLlegada.TabStop = False
        Me.txtLlegada.Visible = False
        '
        'UltraLabel14
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance127
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(997, 46)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel14.TabIndex = 12
        Me.UltraLabel14.Text = "N° MTC:"
        Me.UltraLabel14.Visible = False
        '
        'txtMTC
        '
        EditorButton3.Key = "Right"
        Me.txtMTC.ButtonsRight.Add(EditorButton3)
        Me.txtMTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMTC.Location = New System.Drawing.Point(308, 57)
        Me.txtMTC.MaxLength = 10
        Me.txtMTC.Name = "txtMTC"
        Me.txtMTC.Size = New System.Drawing.Size(167, 22)
        Me.txtMTC.TabIndex = 9
        Me.txtMTC.Tag = "Numero Documento"
        '
        'UltraLabel10
        '
        Appearance110.BackColor = System.Drawing.Color.Transparent
        Appearance110.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance110
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(255, 61)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel10.TabIndex = 8
        Me.UltraLabel10.Text = "N° MTC:"
        '
        'cmbMotivoTraslado
        '
        Me.cmbMotivoTraslado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cmbMotivoTraslado.DropDownListWidth = 350
        Me.cmbMotivoTraslado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbMotivoTraslado.Location = New System.Drawing.Point(566, 29)
        Me.cmbMotivoTraslado.Name = "cmbMotivoTraslado"
        Me.cmbMotivoTraslado.Size = New System.Drawing.Size(158, 22)
        Me.cmbMotivoTraslado.TabIndex = 3
        '
        'cboChofer
        '
        Me.cboChofer.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        EditorButton4.Key = "Left"
        Me.cboChofer.ButtonsLeft.Add(EditorButton4)
        EditorButton5.Key = "Right"
        Me.cboChofer.ButtonsRight.Add(EditorButton5)
        Me.cboChofer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboChofer.DataSource = Me.EComboBindingSource
        Appearance111.BackColor = System.Drawing.SystemColors.Window
        Appearance111.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboChofer.DisplayLayout.Appearance = Appearance111
        UltraGridColumn114.Header.VisiblePosition = 0
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 1
        UltraGridColumn116.Header.VisiblePosition = 2
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 3
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117})
        UltraGridColumn118.Header.VisiblePosition = 0
        UltraGridColumn119.Header.VisiblePosition = 1
        UltraGridColumn120.Header.VisiblePosition = 2
        UltraGridColumn121.Header.VisiblePosition = 3
        UltraGridColumn122.Header.VisiblePosition = 4
        UltraGridColumn123.Header.VisiblePosition = 5
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123})
        Me.cboChofer.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.cboChofer.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.cboChofer.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboChofer.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance112.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance112.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance112.BorderColor = System.Drawing.SystemColors.Window
        Me.cboChofer.DisplayLayout.GroupByBox.Appearance = Appearance112
        Appearance113.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboChofer.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance113
        Me.cboChofer.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance114.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance114.BackColor2 = System.Drawing.SystemColors.Control
        Appearance114.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance114.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboChofer.DisplayLayout.GroupByBox.PromptAppearance = Appearance114
        Me.cboChofer.DisplayLayout.MaxColScrollRegions = 1
        Me.cboChofer.DisplayLayout.MaxRowScrollRegions = 1
        Appearance115.BackColor = System.Drawing.SystemColors.Window
        Appearance115.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboChofer.DisplayLayout.Override.ActiveCellAppearance = Appearance115
        Appearance116.BackColor = System.Drawing.SystemColors.Highlight
        Appearance116.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboChofer.DisplayLayout.Override.ActiveRowAppearance = Appearance116
        Me.cboChofer.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboChofer.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance117.BackColor = System.Drawing.SystemColors.Window
        Me.cboChofer.DisplayLayout.Override.CardAreaAppearance = Appearance117
        Appearance118.BorderColor = System.Drawing.Color.Silver
        Appearance118.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboChofer.DisplayLayout.Override.CellAppearance = Appearance118
        Me.cboChofer.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboChofer.DisplayLayout.Override.CellPadding = 0
        Appearance119.BackColor = System.Drawing.SystemColors.Control
        Appearance119.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance119.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance119.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance119.BorderColor = System.Drawing.SystemColors.Window
        Me.cboChofer.DisplayLayout.Override.GroupByRowAppearance = Appearance119
        Appearance120.TextHAlignAsString = "Left"
        Me.cboChofer.DisplayLayout.Override.HeaderAppearance = Appearance120
        Me.cboChofer.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance121.BackColor = System.Drawing.SystemColors.Window
        Appearance121.BorderColor = System.Drawing.Color.Silver
        Me.cboChofer.DisplayLayout.Override.RowAppearance = Appearance121
        Me.cboChofer.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance122.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboChofer.DisplayLayout.Override.TemplateAddRowAppearance = Appearance122
        Me.cboChofer.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboChofer.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboChofer.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboChofer.DisplayMember = "Nombre"
        Me.cboChofer.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboChofer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChofer.Location = New System.Drawing.Point(91, 85)
        Me.cboChofer.Name = "cboChofer"
        Me.cboChofer.Size = New System.Drawing.Size(384, 23)
        Me.cboChofer.TabIndex = 15
        Me.cboChofer.ValueMember = "Id"
        '
        'UltraLabel1
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Appearance123.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance123
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(487, 33)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(73, 15)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Mot.Traslado:"
        '
        'UltraLabel11
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Appearance124.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance124
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(26, 90)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel11.TabIndex = 14
        Me.UltraLabel11.Text = "Conductor:"
        '
        'cmbVehiculo
        '
        Me.cmbVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmbVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cmbVehiculo.Location = New System.Drawing.Point(91, 57)
        Me.cmbVehiculo.MaxLength = 10
        Me.cmbVehiculo.Name = "cmbVehiculo"
        Me.cmbVehiculo.Size = New System.Drawing.Size(158, 22)
        Me.cmbVehiculo.TabIndex = 7
        '
        'cboCarreta
        '
        Me.cboCarreta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCarreta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCarreta.Location = New System.Drawing.Point(783, 57)
        Me.cboCarreta.MaxLength = 10
        Me.cboCarreta.Name = "cboCarreta"
        Me.cboCarreta.Size = New System.Drawing.Size(147, 22)
        Me.cboCarreta.TabIndex = 13
        '
        'UltraLabel3
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Appearance125.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance125
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(35, 63)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(50, 15)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "Vehiculo:"
        '
        'UltraLabel9
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Appearance126.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance126
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(732, 63)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(45, 15)
        Me.UltraLabel9.TabIndex = 12
        Me.UltraLabel9.Text = "Carreta:"
        '
        'txtPartida
        '
        Me.txtPartida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPartida.Location = New System.Drawing.Point(309, 166)
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.Size = New System.Drawing.Size(627, 22)
        Me.txtPartida.TabIndex = 12
        Me.txtPartida.TabStop = False
        '
        'UltraLabel5
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Appearance128.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance128
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(44, 198)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "Llegada:"
        '
        'UltraLabel4
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Appearance129.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance129
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(48, 170)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 15)
        Me.UltraLabel4.TabIndex = 10
        Me.UltraLabel4.Text = "Partida:"
        '
        'txtNumero
        '
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Location = New System.Drawing.Point(507, 14)
        Me.txtNumero.MaxLength = 8
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(81, 22)
        Me.txtNumero.TabIndex = 4
        '
        'txtSerie
        '
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Location = New System.Drawing.Point(459, 14)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(42, 22)
        Me.txtSerie.TabIndex = 3
        '
        'UltraLabel6
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.Navy
        Appearance130.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance130
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(388, 18)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(65, 15)
        Me.UltraLabel6.TabIndex = 2
        Me.UltraLabel6.Text = "Documento:"
        '
        'UltraLabel2
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Appearance131.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance131
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(594, 18)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Fecha:"
        '
        'dtpFechaDocumento
        '
        Me.dtpFechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDocumento.Location = New System.Drawing.Point(638, 14)
        Me.dtpFechaDocumento.Name = "dtpFechaDocumento"
        Me.dtpFechaDocumento.Size = New System.Drawing.Size(100, 21)
        Me.dtpFechaDocumento.TabIndex = 6
        '
        'UltraLabel8
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Appearance132.ForeColor = System.Drawing.Color.Navy
        Appearance132.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance132
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(30, 18)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel8.TabIndex = 0
        Me.UltraLabel8.Text = "Cliente:"
        '
        'ficGuiaRR
        '
        Me.ficGuiaRR.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficGuiaRR.Controls.Add(Me.UltraTabPageControl1)
        Me.ficGuiaRR.Controls.Add(Me.UltraTabPageControl2)
        Me.ficGuiaRR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficGuiaRR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficGuiaRR.Location = New System.Drawing.Point(0, 0)
        Me.ficGuiaRR.Name = "ficGuiaRR"
        Me.ficGuiaRR.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficGuiaRR.Size = New System.Drawing.Size(1088, 450)
        Me.ficGuiaRR.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab8.TabPage = Me.UltraTabPageControl2
        UltraTab8.Text = "Mantenimiento"
        Me.ficGuiaRR.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab8})
        Me.ficGuiaRR.TabStop = False
        Me.ficGuiaRR.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1086, 427)
        '
        'EGRRVentaBindingSource
        '
        Me.EGRRVentaBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_GRR_Venta)
        '
        'EGuiaRRemitenteMaterialBindingSource
        '
        Me.EGuiaRRemitenteMaterialBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_GuiaRemisionRemitente_Detalle)
        '
        'EComboBindingSource
        '
        Me.EComboBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_Combo)
        '
        'txtMarcaVehiculo
        '
        Me.txtMarcaVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMarcaVehiculo.Location = New System.Drawing.Point(566, 57)
        Me.txtMarcaVehiculo.Name = "txtMarcaVehiculo"
        Me.txtMarcaVehiculo.Size = New System.Drawing.Size(158, 22)
        Me.txtMarcaVehiculo.TabIndex = 11
        '
        'UltraLabel7
        '
        Appearance106.BackColor = System.Drawing.Color.Transparent
        Appearance106.ForeColor = System.Drawing.Color.Navy
        Appearance106.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance106
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(522, 61)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel7.TabIndex = 10
        Me.UltraLabel7.Text = "Marca:"
        '
        'frm_GRR_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 450)
        Me.Controls.Add(Me.ficGuiaRR)
        Me.Name = "frm_GRR_Venta"
        Me.Text = "GRR Venta"
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox14.ResumeLayout(False)
        CType(Me.griDetalleDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.UltraGroupBox5.PerformLayout()
        CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox10.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.gbeOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeOrdenes.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        Me.UltraGroupBox9.PerformLayout()
        CType(Me.cmbMatSerOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griOrdenDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox15.ResumeLayout(False)
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        CType(Me.UltraGroupBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox17.ResumeLayout(False)
        CType(Me.GriOrdenesSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox18.ResumeLayout(False)
        Me.UltraGroupBox18.PerformLayout()
        CType(Me.griOrdenSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox16.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.griDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        Me.UltraGroupBox11.PerformLayout()
        CType(Me.ColorAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbNroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNroOrden.ResumeLayout(False)
        Me.grbNroOrden.PerformLayout()
        CType(Me.txtSerieDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosBasicos.ResumeLayout(False)
        Me.grbDatosBasicos.PerformLayout()
        CType(Me.cbgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalle.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.cmb_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPuntoPartida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Destino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPuntoLlegada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        Me.UltraGroupBox6.PerformLayout()
        CType(Me.txt_DocAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroMTCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLlegada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMotivoTraslado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboChofer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficGuiaRR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficGuiaRR.ResumeLayout(False)
        CType(Me.EGRRVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGuiaRRemitenteMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EComboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarcaVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ficGuiaRR As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griDocumento As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnAnular As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEliminar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEnviar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ColorAtendido As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents colorAnulado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents colorGenerado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents grbNroOrden As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtSerieDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNroDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents rdbNroDocumento As RadioButton
    Friend WithEvents rdbDatosBasicos As RadioButton
    Friend WithEvents grbDatosBasicos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents cbgProveedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ficDetalle As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox14 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griDetalleDocumento As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraCheckEditor1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox10 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnQuitarD As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregarD As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gbeOrdenes As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griOrdenComercial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cmbMatSerOC As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFinOC As DateTimePicker
    Friend WithEvents dtpInicioOC As DateTimePicker
    Friend WithEvents griOrdenDocumento As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox15 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents BtnQuitarOv As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregarOv As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox17 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents GriOrdenesSalidas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox18 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btmConsultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents griOrdenSalida As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox16 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnQuitarOs As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregarOs As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboPuntoLlegada As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkAsociar As CheckBox
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNroLicencia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNroMTCC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtLlegada As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtMTC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboChofer As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbVehiculo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboCarreta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtPartida As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbMotivoTraslado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtSerie As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFechaDocumento As DateTimePicker
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboPuntoPartida As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Destino As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Private WithEvents cboTransportista As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dtp_FechaTraslado As DateTimePicker
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_DocAsoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Private WithEvents cmb_Cliente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents EGRRVentaBindingSource As BindingSource
    Friend WithEvents EGuiaRRemitenteMaterialBindingSource As BindingSource
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents EComboBindingSource As BindingSource
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtMarcaVehiculo As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
