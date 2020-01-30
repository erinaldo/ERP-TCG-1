<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_CanjeDocumentos
    Inherits frm_MenuPadre

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_MovimientoDocumento", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("lstDetalleDocumentoCombustible")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnulado")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abrev_Empresa")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnexo")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetalleGlosa")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCanje")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion_Letra")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion_Saldo")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Item")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMotivo")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenCompra")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoSunat")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnticipo")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAfectaAnticipo")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto_Anticipo")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("lstDetalleDocumentoCombustible", 0)
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoReferencia")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegConsumoCombustible")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroLinea")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnit")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDetalleDocumento")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGravado")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioIGV")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVeh")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_DetalleDocumento", -1)
        Dim UltraGridColumn376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn377 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn378 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn379 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn380 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn381 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialServicio")
        Dim UltraGridColumn382 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterialServicio")
        Dim UltraGridColumn383 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn384 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSinImp")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGravado")
        Dim UltraGridColumn388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim UltraGridColumn389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionDetalle")
        Dim UltraGridColumn391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreMaterialServicio")
        Dim UltraGridColumn400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pos")
        Dim UltraGridColumn401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FactorRefUni")
        Dim UltraGridColumn402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContableCompra")
        Dim UltraGridColumn404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConsolidado")
        Dim UltraGridColumn405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaConsolidado")
        Dim UltraGridColumn406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto_Anticipo")
        Dim UltraGridColumn408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Porc_Anticipo")
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
        Dim UltraGridColumn409 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn410 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEmpresa")
        Dim UltraGridColumn411 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEmpresa")
        Dim UltraGridColumn412 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn413 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruc")
        Dim UltraGridColumn414 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn415 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn416 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionTanqueo")
        Dim UltraGridColumn417 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn418 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn419 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgentePercepcion")
        Dim UltraGridColumn420 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgenteRetencion")
        Dim UltraGridColumn421 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBuenContribuyente")
        Dim UltraGridColumn422 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCanjeDocumento")
        Dim UltraGridColumn423 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaLetras")
        Dim UltraGridColumn424 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaCheque")
        Dim UltraGridColumn425 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Morosidad")
        Dim UltraGridColumn426 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim UltraGridColumn427 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNivelComercial")
        Dim UltraGridColumn428 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndClasificacion")
        Dim UltraGridColumn429 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn430 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn431 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoriaEmpresaSGI")
        Dim UltraGridColumn432 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRelacionada")
        Dim UltraGridColumn433 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionFiscal")
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
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_DetalleDocumento", -1)
        Dim UltraGridColumn434 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn435 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn436 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn437 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn438 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn439 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialServicio")
        Dim UltraGridColumn440 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterialServicio")
        Dim UltraGridColumn441 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn442 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn443 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSinImp")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn444 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn445 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGravado")
        Dim UltraGridColumn446 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim UltraGridColumn447 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn448 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionDetalle")
        Dim UltraGridColumn449 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn450 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn451 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn452 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn453 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn454 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn455 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn456 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn457 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreMaterialServicio")
        Dim UltraGridColumn458 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pos")
        Dim UltraGridColumn459 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FactorRefUni")
        Dim UltraGridColumn460 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn461 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContableCompra")
        Dim UltraGridColumn462 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConsolidado")
        Dim UltraGridColumn463 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaConsolidado")
        Dim UltraGridColumn464 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn465 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto_Anticipo")
        Dim UltraGridColumn466 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Porc_Anticipo")
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
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_MovimientoDocumento", -1)
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("lstDetalleDocumentoCombustible")
        Dim UltraGridColumn299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnulado")
        Dim UltraGridColumn300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abrev_Empresa")
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnexo")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetalleGlosa")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCanje")
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion_Letra")
        Dim UltraGridColumn323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion_Saldo")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Item")
        Dim UltraGridColumn326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn340 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn341 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn342 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn343 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn344 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMotivo")
        Dim UltraGridColumn346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenCompra")
        Dim UltraGridColumn347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoSunat")
        Dim UltraGridColumn348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnticipo")
        Dim UltraGridColumn349 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAfectaAnticipo")
        Dim UltraGridColumn350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto_Anticipo")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("lstDetalleDocumentoCombustible", 0)
        Dim UltraGridColumn351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoReferencia")
        Dim UltraGridColumn352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn353 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegConsumoCombustible")
        Dim UltraGridColumn354 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn355 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim UltraGridColumn356 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim UltraGridColumn358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim UltraGridColumn361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroLinea")
        Dim UltraGridColumn362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnit")
        Dim UltraGridColumn364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDetalleDocumento")
        Dim UltraGridColumn365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim UltraGridColumn366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGravado")
        Dim UltraGridColumn369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioIGV")
        Dim UltraGridColumn373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor")
        Dim UltraGridColumn374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim UltraGridColumn375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVeh")
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
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
        Dim UltraGridColumn467 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn468 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEmpresa")
        Dim UltraGridColumn469 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEmpresa")
        Dim UltraGridColumn470 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn471 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruc")
        Dim UltraGridColumn472 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionTanqueo")
        Dim UltraGridColumn475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgentePercepcion")
        Dim UltraGridColumn478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgenteRetencion")
        Dim UltraGridColumn479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBuenContribuyente")
        Dim UltraGridColumn480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCanjeDocumento")
        Dim UltraGridColumn481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaLetras")
        Dim UltraGridColumn482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaCheque")
        Dim UltraGridColumn483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Morosidad")
        Dim UltraGridColumn484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim UltraGridColumn485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNivelComercial")
        Dim UltraGridColumn486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndClasificacion")
        Dim UltraGridColumn487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoriaEmpresaSGI")
        Dim UltraGridColumn490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRelacionada")
        Dim UltraGridColumn491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionFiscal")
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
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Documentos = New ISL.Controles.Grilla(Me.components)
        Me.bso_Documento = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_DetalleProductos = New ISL.Controles.Grilla(Me.components)
        Me.bso_DetalleProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsb_Canjear = New System.Windows.Forms.ToolStripButton()
        Me.tsb_Emitir = New System.Windows.Forms.ToolStripButton()
        Me.tsb_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_Imprimir = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsb_ImprimirA4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmb_ClienteBuscado = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Detalles = New ISL.Controles.Grilla(Me.components)
        Me.bso_Detalle = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_DocumentosSeleccionados = New ISL.Controles.Grilla(Me.components)
        Me.bso_DocumentosSeleccionados = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Numero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Observacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbTipoDocumento = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.txtSerie = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_Cliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTipoPago = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.decTipoCambio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.nud_Total = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.nud_Impuesto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.nud_SubTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbMoneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.fic_Canje = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.udg_Documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bso_Documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.udg_DetalleProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bso_DetalleProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cmb_ClienteBuscado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.udg_Detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bso_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.udg_DocumentosSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bso_DocumentosSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.txt_Numero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Impuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_SubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fic_Canje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fic_Canje.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.ToolStrip1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1356, 676)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox7)
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox8)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 107)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1356, 569)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.udg_Documentos)
        Me.UltraGroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(1350, 413)
        Me.UltraGroupBox7.TabIndex = 11
        Me.UltraGroupBox7.Text = "Documentos"
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Documentos
        '
        Me.udg_Documentos.DataSource = Me.bso_Documento
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Documentos.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 39
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 40
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 37
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 55
        UltraGridColumn5.Header.VisiblePosition = 41
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 42
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 16
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 17
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.Caption = "Nº Documento"
        UltraGridColumn9.Header.VisiblePosition = 4
        UltraGridColumn9.Width = 143
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.Caption = "Producto"
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Width = 150
        UltraGridColumn11.Header.VisiblePosition = 19
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 20
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "Fecha"
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.Width = 77
        UltraGridColumn14.Header.VisiblePosition = 26
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 35
        UltraGridColumn15.Hidden = True
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance2
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Format = "#,###,###,##0.00"
        UltraGridColumn16.Header.Caption = "Imp. Venta"
        UltraGridColumn16.Header.VisiblePosition = 9
        UltraGridColumn16.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn16.Width = 91
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance3
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn17.Format = "#,###,###,##0.00"
        UltraGridColumn17.Header.VisiblePosition = 8
        UltraGridColumn17.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn17.Width = 109
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance4
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn18.Format = "#,###,###,##0.00"
        UltraGridColumn18.Header.VisiblePosition = 10
        UltraGridColumn18.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn18.Width = 104
        UltraGridColumn19.Header.VisiblePosition = 27
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 38
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 48
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn22.Header.Caption = "Sel"
        UltraGridColumn22.Header.VisiblePosition = 0
        UltraGridColumn23.Header.VisiblePosition = 49
        UltraGridColumn23.Hidden = True
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn24.CellAppearance = Appearance5
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn24.Header.Caption = "Tipo Cambio"
        UltraGridColumn24.Header.VisiblePosition = 7
        UltraGridColumn24.Width = 71
        UltraGridColumn25.Header.VisiblePosition = 28
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 43
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 44
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 45
        UltraGridColumn28.Hidden = True
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn29.CellAppearance = Appearance6
        UltraGridColumn29.Format = "#,###,###,##0.00"
        UltraGridColumn29.Header.Caption = "Importe"
        UltraGridColumn29.Header.VisiblePosition = 15
        UltraGridColumn30.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn30.Header.Caption = "Empresa"
        UltraGridColumn30.Header.VisiblePosition = 2
        UltraGridColumn30.Width = 281
        UltraGridColumn31.Header.VisiblePosition = 46
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 21
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 29
        UltraGridColumn33.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn34.CellAppearance = Appearance7
        UltraGridColumn34.Header.VisiblePosition = 22
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.MaskInput = ""
        UltraGridColumn35.Header.VisiblePosition = 30
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 24
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 18
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.Width = 132
        UltraGridColumn38.Header.VisiblePosition = 23
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn39.Header.VisiblePosition = 6
        UltraGridColumn40.Header.VisiblePosition = 36
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 25
        UltraGridColumn41.Hidden = True
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance8
        UltraGridColumn42.Format = "#,###,###,##0.00"
        UltraGridColumn42.Header.Caption = "Precio Unit."
        UltraGridColumn42.Header.VisiblePosition = 14
        UltraGridColumn43.Header.VisiblePosition = 31
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 32
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 34
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn46.Header.Caption = "Estado"
        UltraGridColumn46.Header.VisiblePosition = 5
        UltraGridColumn46.Width = 80
        UltraGridColumn47.Header.VisiblePosition = 33
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn48.Header.Caption = "Tipo Documento"
        UltraGridColumn48.Header.VisiblePosition = 3
        UltraGridColumn48.Width = 167
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn49.CellAppearance = Appearance9
        UltraGridColumn49.Format = "#,###,###,##0.00"
        UltraGridColumn49.Header.Caption = "Cantidad"
        UltraGridColumn49.Header.VisiblePosition = 13
        UltraGridColumn50.Header.VisiblePosition = 47
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 50
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.Caption = "Placa"
        UltraGridColumn52.Header.VisiblePosition = 12
        UltraGridColumn53.Header.VisiblePosition = 51
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 52
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 53
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 54
        UltraGridColumn56.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56})
        UltraGridColumn57.Header.VisiblePosition = 0
        UltraGridColumn58.Header.VisiblePosition = 1
        UltraGridColumn59.Header.VisiblePosition = 2
        UltraGridColumn60.Header.VisiblePosition = 3
        UltraGridColumn61.Header.VisiblePosition = 4
        UltraGridColumn62.Header.VisiblePosition = 5
        UltraGridColumn63.Header.VisiblePosition = 6
        UltraGridColumn64.Header.VisiblePosition = 7
        UltraGridColumn65.Header.VisiblePosition = 8
        UltraGridColumn66.Header.VisiblePosition = 9
        UltraGridColumn67.Header.VisiblePosition = 10
        UltraGridColumn68.Header.VisiblePosition = 11
        UltraGridColumn69.Header.VisiblePosition = 12
        UltraGridColumn70.Header.VisiblePosition = 13
        UltraGridColumn71.Header.VisiblePosition = 14
        UltraGridColumn72.Header.VisiblePosition = 15
        UltraGridColumn73.Header.VisiblePosition = 16
        UltraGridColumn74.Header.VisiblePosition = 17
        UltraGridColumn75.Header.VisiblePosition = 18
        UltraGridColumn76.Header.VisiblePosition = 19
        UltraGridColumn77.Header.VisiblePosition = 20
        UltraGridColumn78.Header.VisiblePosition = 21
        UltraGridColumn79.Header.VisiblePosition = 22
        UltraGridColumn80.Header.VisiblePosition = 23
        UltraGridColumn81.Header.VisiblePosition = 24
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81})
        Me.udg_Documentos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.udg_Documentos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.udg_Documentos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Documentos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Documentos.DisplayLayout.GroupByBox.Appearance = Appearance10
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Documentos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance11
        Me.udg_Documentos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Documentos.DisplayLayout.GroupByBox.Hidden = True
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance12.BackColor2 = System.Drawing.SystemColors.Control
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Documentos.DisplayLayout.GroupByBox.PromptAppearance = Appearance12
        Me.udg_Documentos.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Documentos.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Documentos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Documentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Documentos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Documentos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Documentos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_Documentos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Documentos.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.udg_Documentos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Documentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Me.udg_Documentos.DisplayLayout.Override.RowAppearance = Appearance13
        Me.udg_Documentos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Documentos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Documentos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Documentos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Documentos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.udg_Documentos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Documentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Documentos.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Documentos.Location = New System.Drawing.Point(3, 17)
        Me.udg_Documentos.Name = "udg_Documentos"
        Me.udg_Documentos.Size = New System.Drawing.Size(1344, 393)
        Me.udg_Documentos.TabIndex = 10
        Me.udg_Documentos.Text = "Grilla2"
        '
        'bso_Documento
        '
        Me.bso_Documento.DataSource = GetType(ERP.EntidadesWCF.e_MovimientoDocumento)
        '
        'UltraGroupBox8
        '
        Me.UltraGroupBox8.Controls.Add(Me.udg_DetalleProductos)
        Me.UltraGroupBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraGroupBox8.Location = New System.Drawing.Point(3, 416)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(1350, 150)
        Me.UltraGroupBox8.TabIndex = 12
        Me.UltraGroupBox8.Text = "Detalle de Productos"
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_DetalleProductos
        '
        Me.udg_DetalleProductos.DataSource = Me.bso_DetalleProductos
        UltraGridColumn376.Header.VisiblePosition = 0
        UltraGridColumn376.Hidden = True
        UltraGridColumn377.Header.VisiblePosition = 2
        UltraGridColumn377.Hidden = True
        UltraGridColumn378.Header.VisiblePosition = 3
        UltraGridColumn378.Hidden = True
        UltraGridColumn379.Header.VisiblePosition = 5
        UltraGridColumn379.Hidden = True
        UltraGridColumn380.Header.VisiblePosition = 6
        UltraGridColumn380.Hidden = True
        UltraGridColumn381.Header.VisiblePosition = 4
        UltraGridColumn381.Hidden = True
        UltraGridColumn382.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn382.Header.Caption = "Codigo"
        UltraGridColumn382.Header.VisiblePosition = 7
        UltraGridColumn382.Width = 88
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn383.CellAppearance = Appearance14
        UltraGridColumn383.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn383.Header.Caption = "Cant."
        UltraGridColumn383.Header.VisiblePosition = 9
        UltraGridColumn383.MaskInput = "{LOC}nnnnnnn.nnnn"
        UltraGridColumn383.Width = 82
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn384.CellAppearance = Appearance15
        UltraGridColumn384.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn384.Header.Caption = "PU C/Imp"
        UltraGridColumn384.Header.VisiblePosition = 13
        UltraGridColumn384.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn384.Width = 101
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn385.CellAppearance = Appearance16
        UltraGridColumn385.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn385.Header.Caption = "PU S/Imp"
        UltraGridColumn385.Header.VisiblePosition = 12
        UltraGridColumn385.Hidden = True
        UltraGridColumn385.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn385.Width = 100
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn386.CellAppearance = Appearance17
        UltraGridColumn386.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn386.Format = "#,##0.0000"
        UltraGridColumn386.Header.Caption = "Importe"
        UltraGridColumn386.Header.VisiblePosition = 16
        UltraGridColumn386.MaskInput = "{LOC}nnnnnnn.nnnn"
        UltraGridColumn386.Width = 98
        UltraGridColumn387.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn387.Header.Caption = "Ind. Igv"
        UltraGridColumn387.Header.VisiblePosition = 11
        UltraGridColumn387.Hidden = True
        UltraGridColumn387.Width = 67
        UltraGridColumn388.Header.VisiblePosition = 14
        UltraGridColumn388.Hidden = True
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn389.CellAppearance = Appearance18
        UltraGridColumn389.Header.VisiblePosition = 15
        UltraGridColumn389.Hidden = True
        UltraGridColumn389.MaskInput = "{LOC}nnnnnnn.nnnn"
        UltraGridColumn390.Header.VisiblePosition = 17
        UltraGridColumn390.Hidden = True
        UltraGridColumn391.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn391.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn391.Header.Caption = "Vehiculo"
        UltraGridColumn391.Header.VisiblePosition = 18
        UltraGridColumn391.Width = 113
        UltraGridColumn392.Header.VisiblePosition = 19
        UltraGridColumn392.Hidden = True
        UltraGridColumn393.Header.VisiblePosition = 20
        UltraGridColumn393.Hidden = True
        UltraGridColumn394.Header.VisiblePosition = 21
        UltraGridColumn394.Hidden = True
        UltraGridColumn395.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn395.Header.Caption = "Select"
        UltraGridColumn395.Header.VisiblePosition = 1
        UltraGridColumn395.Hidden = True
        UltraGridColumn395.Width = 62
        UltraGridColumn396.Header.Caption = "Unid. Med."
        UltraGridColumn396.Header.VisiblePosition = 10
        UltraGridColumn396.Hidden = True
        UltraGridColumn397.Header.VisiblePosition = 22
        UltraGridColumn397.Hidden = True
        UltraGridColumn398.Header.VisiblePosition = 24
        UltraGridColumn398.Hidden = True
        UltraGridColumn399.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn399.Header.Caption = "Nombre"
        UltraGridColumn399.Header.VisiblePosition = 8
        UltraGridColumn399.Width = 323
        UltraGridColumn400.Header.VisiblePosition = 23
        UltraGridColumn400.Hidden = True
        UltraGridColumn401.Header.VisiblePosition = 25
        UltraGridColumn401.Hidden = True
        UltraGridColumn402.Header.VisiblePosition = 26
        UltraGridColumn402.Hidden = True
        UltraGridColumn403.Header.VisiblePosition = 27
        UltraGridColumn403.Hidden = True
        UltraGridColumn404.Header.VisiblePosition = 28
        UltraGridColumn404.Hidden = True
        UltraGridColumn405.Header.VisiblePosition = 29
        UltraGridColumn405.Hidden = True
        UltraGridColumn406.Header.VisiblePosition = 30
        UltraGridColumn406.Hidden = True
        UltraGridColumn407.Header.VisiblePosition = 31
        UltraGridColumn407.Hidden = True
        UltraGridColumn408.Header.VisiblePosition = 32
        UltraGridColumn408.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn376, UltraGridColumn377, UltraGridColumn378, UltraGridColumn379, UltraGridColumn380, UltraGridColumn381, UltraGridColumn382, UltraGridColumn383, UltraGridColumn384, UltraGridColumn385, UltraGridColumn386, UltraGridColumn387, UltraGridColumn388, UltraGridColumn389, UltraGridColumn390, UltraGridColumn391, UltraGridColumn392, UltraGridColumn393, UltraGridColumn394, UltraGridColumn395, UltraGridColumn396, UltraGridColumn397, UltraGridColumn398, UltraGridColumn399, UltraGridColumn400, UltraGridColumn401, UltraGridColumn402, UltraGridColumn403, UltraGridColumn404, UltraGridColumn405, UltraGridColumn406, UltraGridColumn407, UltraGridColumn408})
        Me.udg_DetalleProductos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.udg_DetalleProductos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_DetalleProductos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance19.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance19.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_DetalleProductos.DisplayLayout.GroupByBox.Appearance = Appearance19
        Appearance20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_DetalleProductos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance20
        Me.udg_DetalleProductos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_DetalleProductos.DisplayLayout.GroupByBox.Hidden = True
        Appearance21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance21.BackColor2 = System.Drawing.SystemColors.Control
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_DetalleProductos.DisplayLayout.GroupByBox.PromptAppearance = Appearance21
        Me.udg_DetalleProductos.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_DetalleProductos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Appearance22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.udg_DetalleProductos.DisplayLayout.Override.ActiveCellAppearance = Appearance22
        Appearance23.BackColor = System.Drawing.SystemColors.Highlight
        Appearance23.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.udg_DetalleProductos.DisplayLayout.Override.ActiveRowAppearance = Appearance23
        Me.udg_DetalleProductos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_DetalleProductos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_DetalleProductos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_DetalleProductos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance24.BackColor = System.Drawing.SystemColors.Window
        Me.udg_DetalleProductos.DisplayLayout.Override.CardAreaAppearance = Appearance24
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Appearance25.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.udg_DetalleProductos.DisplayLayout.Override.CellAppearance = Appearance25
        Me.udg_DetalleProductos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_DetalleProductos.DisplayLayout.Override.CellPadding = 0
        Me.udg_DetalleProductos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_DetalleProductos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance26.BackColor = System.Drawing.SystemColors.Control
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_DetalleProductos.DisplayLayout.Override.GroupByRowAppearance = Appearance26
        Appearance27.TextHAlignAsString = "Center"
        Me.udg_DetalleProductos.DisplayLayout.Override.HeaderAppearance = Appearance27
        Me.udg_DetalleProductos.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.udg_DetalleProductos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance28.BorderColor = System.Drawing.Color.Silver
        Me.udg_DetalleProductos.DisplayLayout.Override.RowAppearance = Appearance28
        Me.udg_DetalleProductos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_DetalleProductos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_DetalleProductos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_DetalleProductos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.udg_DetalleProductos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance29
        Me.udg_DetalleProductos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_DetalleProductos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_DetalleProductos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_DetalleProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_DetalleProductos.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_DetalleProductos.Location = New System.Drawing.Point(3, 17)
        Me.udg_DetalleProductos.Name = "udg_DetalleProductos"
        Me.udg_DetalleProductos.Size = New System.Drawing.Size(1344, 130)
        Me.udg_DetalleProductos.TabIndex = 1
        Me.udg_DetalleProductos.Text = "Grilla2"
        '
        'bso_DetalleProductos
        '
        Me.bso_DetalleProductos.DataSource = GetType(ERP.EntidadesWCF.e_DetalleDocumento)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_Canjear, Me.tsb_Emitir, Me.tsb_Eliminar, Me.tsb_Imprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 82)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1356, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsb_Canjear
        '
        Me.tsb_Canjear.Image = Global.ISL.Win.My.Resources.Resources.clipboard
        Me.tsb_Canjear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Canjear.Name = "tsb_Canjear"
        Me.tsb_Canjear.Size = New System.Drawing.Size(145, 22)
        Me.tsb_Canjear.Text = "Canjear Seleccionados"
        '
        'tsb_Emitir
        '
        Me.tsb_Emitir.Image = Global.ISL.Win.My.Resources.Resources.if_computer_link_35899
        Me.tsb_Emitir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Emitir.Name = "tsb_Emitir"
        Me.tsb_Emitir.Size = New System.Drawing.Size(58, 22)
        Me.tsb_Emitir.Text = "Emitir"
        '
        'tsb_Eliminar
        '
        Me.tsb_Eliminar.Image = Global.ISL.Win.My.Resources.Resources.back
        Me.tsb_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Eliminar.Name = "tsb_Eliminar"
        Me.tsb_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.tsb_Eliminar.Text = "Eliminar"
        '
        'tsb_Imprimir
        '
        Me.tsb_Imprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_ImprimirA4})
        Me.tsb_Imprimir.Image = Global.ISL.Win.My.Resources.Resources.invoice
        Me.tsb_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Imprimir.Name = "tsb_Imprimir"
        Me.tsb_Imprimir.Size = New System.Drawing.Size(82, 22)
        Me.tsb_Imprimir.Text = "Imprimir"
        '
        'tsb_ImprimirA4
        '
        Me.tsb_ImprimirA4.Name = "tsb_ImprimirA4"
        Me.tsb_ImprimirA4.Size = New System.Drawing.Size(120, 22)
        Me.tsb_ImprimirA4.Text = "Papel A4"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.cmb_ClienteBuscado)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.dtp_FechaHasta)
        Me.UltraGroupBox1.Controls.Add(Me.dtp_FechaDesde)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1356, 82)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Filtros"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmb_ClienteBuscado
        '
        EditorButton1.Key = "Left"
        Me.cmb_ClienteBuscado.ButtonsLeft.Add(EditorButton1)
        EditorButton2.Key = "Right"
        Me.cmb_ClienteBuscado.ButtonsRight.Add(EditorButton2)
        Me.cmb_ClienteBuscado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance30.BackColor = System.Drawing.SystemColors.Window
        Appearance30.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_ClienteBuscado.DisplayLayout.Appearance = Appearance30
        UltraGridColumn409.Header.VisiblePosition = 0
        UltraGridColumn409.Hidden = True
        UltraGridColumn410.Header.VisiblePosition = 5
        UltraGridColumn410.Hidden = True
        UltraGridColumn411.Header.VisiblePosition = 1
        UltraGridColumn412.Header.VisiblePosition = 2
        UltraGridColumn413.Header.VisiblePosition = 3
        UltraGridColumn414.Header.VisiblePosition = 7
        UltraGridColumn414.Width = 300
        UltraGridColumn415.Header.VisiblePosition = 9
        UltraGridColumn415.Hidden = True
        UltraGridColumn416.Header.VisiblePosition = 6
        UltraGridColumn417.Header.VisiblePosition = 24
        UltraGridColumn417.Hidden = True
        UltraGridColumn418.Header.VisiblePosition = 8
        UltraGridColumn419.Header.VisiblePosition = 11
        UltraGridColumn419.Hidden = True
        UltraGridColumn420.Header.VisiblePosition = 13
        UltraGridColumn420.Hidden = True
        UltraGridColumn421.Header.VisiblePosition = 15
        UltraGridColumn421.Hidden = True
        UltraGridColumn422.Header.VisiblePosition = 22
        UltraGridColumn422.Hidden = True
        UltraGridColumn423.Header.VisiblePosition = 19
        UltraGridColumn423.Hidden = True
        UltraGridColumn424.Header.VisiblePosition = 20
        UltraGridColumn424.Hidden = True
        UltraGridColumn425.Header.VisiblePosition = 12
        UltraGridColumn426.Header.VisiblePosition = 14
        UltraGridColumn427.Header.VisiblePosition = 16
        UltraGridColumn428.Header.VisiblePosition = 17
        UltraGridColumn429.Header.VisiblePosition = 4
        UltraGridColumn429.Hidden = True
        UltraGridColumn430.Header.VisiblePosition = 21
        UltraGridColumn431.Header.VisiblePosition = 23
        UltraGridColumn432.Header.VisiblePosition = 18
        UltraGridColumn432.Hidden = True
        UltraGridColumn433.Header.VisiblePosition = 10
        UltraGridColumn433.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn409, UltraGridColumn410, UltraGridColumn411, UltraGridColumn412, UltraGridColumn413, UltraGridColumn414, UltraGridColumn415, UltraGridColumn416, UltraGridColumn417, UltraGridColumn418, UltraGridColumn419, UltraGridColumn420, UltraGridColumn421, UltraGridColumn422, UltraGridColumn423, UltraGridColumn424, UltraGridColumn425, UltraGridColumn426, UltraGridColumn427, UltraGridColumn428, UltraGridColumn429, UltraGridColumn430, UltraGridColumn431, UltraGridColumn432, UltraGridColumn433})
        Me.cmb_ClienteBuscado.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cmb_ClienteBuscado.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmb_ClienteBuscado.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance31.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance31.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb_ClienteBuscado.DisplayLayout.GroupByBox.Appearance = Appearance31
        Appearance32.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb_ClienteBuscado.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance32
        Me.cmb_ClienteBuscado.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance33.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance33.BackColor2 = System.Drawing.SystemColors.Control
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb_ClienteBuscado.DisplayLayout.GroupByBox.PromptAppearance = Appearance33
        Me.cmb_ClienteBuscado.DisplayLayout.MaxColScrollRegions = 1
        Me.cmb_ClienteBuscado.DisplayLayout.MaxRowScrollRegions = 1
        Appearance34.BackColor = System.Drawing.SystemColors.Window
        Appearance34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb_ClienteBuscado.DisplayLayout.Override.ActiveCellAppearance = Appearance34
        Appearance35.BackColor = System.Drawing.SystemColors.Highlight
        Appearance35.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmb_ClienteBuscado.DisplayLayout.Override.ActiveRowAppearance = Appearance35
        Me.cmb_ClienteBuscado.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmb_ClienteBuscado.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_ClienteBuscado.DisplayLayout.Override.CardAreaAppearance = Appearance36
        Appearance37.BorderColor = System.Drawing.Color.Silver
        Appearance37.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cmb_ClienteBuscado.DisplayLayout.Override.CellAppearance = Appearance37
        Me.cmb_ClienteBuscado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cmb_ClienteBuscado.DisplayLayout.Override.CellPadding = 0
        Appearance38.BackColor = System.Drawing.SystemColors.Control
        Appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance38.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance38.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb_ClienteBuscado.DisplayLayout.Override.GroupByRowAppearance = Appearance38
        Appearance39.TextHAlignAsString = "Left"
        Me.cmb_ClienteBuscado.DisplayLayout.Override.HeaderAppearance = Appearance39
        Me.cmb_ClienteBuscado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance40.BackColor = System.Drawing.SystemColors.Window
        Appearance40.BorderColor = System.Drawing.Color.Silver
        Me.cmb_ClienteBuscado.DisplayLayout.Override.RowAppearance = Appearance40
        Me.cmb_ClienteBuscado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance41.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmb_ClienteBuscado.DisplayLayout.Override.TemplateAddRowAppearance = Appearance41
        Me.cmb_ClienteBuscado.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cmb_ClienteBuscado.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cmb_ClienteBuscado.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cmb_ClienteBuscado.DisplayMember = "Nombre"
        Me.cmb_ClienteBuscado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_ClienteBuscado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ClienteBuscado.Location = New System.Drawing.Point(77, 25)
        Me.cmb_ClienteBuscado.Name = "cmb_ClienteBuscado"
        Me.cmb_ClienteBuscado.Size = New System.Drawing.Size(338, 23)
        Me.cmb_ClienteBuscado.TabIndex = 11
        Me.cmb_ClienteBuscado.ValueMember = "Id"
        '
        'UltraLabel10
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Appearance42.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance42
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(29, 30)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel10.TabIndex = 10
        Me.UltraLabel10.Text = "Cliente:"
        '
        'UltraLabel2
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance43
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(196, 54)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "Hasta:"
        '
        'UltraLabel1
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance44
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(32, 54)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Desde:"
        '
        'dtp_FechaHasta
        '
        Me.dtp_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaHasta.Location = New System.Drawing.Point(77, 51)
        Me.dtp_FechaHasta.Name = "dtp_FechaHasta"
        Me.dtp_FechaHasta.Size = New System.Drawing.Size(109, 21)
        Me.dtp_FechaHasta.TabIndex = 1
        '
        'dtp_FechaDesde
        '
        Me.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDesde.Location = New System.Drawing.Point(239, 51)
        Me.dtp_FechaDesde.Name = "dtp_FechaDesde"
        Me.dtp_FechaDesde.Size = New System.Drawing.Size(109, 21)
        Me.dtp_FechaDesde.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox9)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1356, 676)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.udg_Detalles)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 242)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1356, 234)
        Me.UltraGroupBox4.TabIndex = 1
        Me.UltraGroupBox4.Text = "Detalle Documento"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Detalles
        '
        Me.udg_Detalles.DataSource = Me.bso_Detalle
        UltraGridColumn434.Header.VisiblePosition = 0
        UltraGridColumn434.Hidden = True
        UltraGridColumn435.Header.VisiblePosition = 2
        UltraGridColumn435.Hidden = True
        UltraGridColumn436.Header.VisiblePosition = 3
        UltraGridColumn436.Hidden = True
        UltraGridColumn437.Header.VisiblePosition = 5
        UltraGridColumn437.Hidden = True
        UltraGridColumn438.Header.VisiblePosition = 6
        UltraGridColumn438.Hidden = True
        UltraGridColumn439.Header.VisiblePosition = 4
        UltraGridColumn439.Hidden = True
        UltraGridColumn440.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn440.Header.Caption = "Codigo"
        UltraGridColumn440.Header.VisiblePosition = 7
        UltraGridColumn440.Width = 88
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance45.TextHAlignAsString = "Right"
        UltraGridColumn441.CellAppearance = Appearance45
        UltraGridColumn441.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn441.Header.Caption = "Cant."
        UltraGridColumn441.Header.VisiblePosition = 9
        UltraGridColumn441.MaskInput = "{LOC}nnnnnnn.nnnn"
        UltraGridColumn441.Width = 82
        Appearance46.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn442.CellAppearance = Appearance46
        UltraGridColumn442.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn442.Header.Caption = "PU C/Imp"
        UltraGridColumn442.Header.VisiblePosition = 13
        UltraGridColumn442.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn442.Width = 101
        Appearance47.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn443.CellAppearance = Appearance47
        UltraGridColumn443.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn443.Header.Caption = "PU S/Imp"
        UltraGridColumn443.Header.VisiblePosition = 12
        UltraGridColumn443.Hidden = True
        UltraGridColumn443.MaskInput = "{LOC}nnnnnnnn.nnnn"
        UltraGridColumn443.Width = 100
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn444.CellAppearance = Appearance48
        UltraGridColumn444.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn444.Format = "#,##0.0000"
        UltraGridColumn444.Header.Caption = "Importe"
        UltraGridColumn444.Header.VisiblePosition = 16
        UltraGridColumn444.MaskInput = "{LOC}nnnnnnn.nnnn"
        UltraGridColumn444.Width = 98
        UltraGridColumn445.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn445.Header.Caption = "Ind. Igv"
        UltraGridColumn445.Header.VisiblePosition = 11
        UltraGridColumn445.Hidden = True
        UltraGridColumn445.Width = 67
        UltraGridColumn446.Header.VisiblePosition = 14
        UltraGridColumn446.Hidden = True
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn447.CellAppearance = Appearance49
        UltraGridColumn447.Header.VisiblePosition = 15
        UltraGridColumn447.Hidden = True
        UltraGridColumn447.MaskInput = "{LOC}nnnnnnn.nnnn"
        UltraGridColumn448.Header.VisiblePosition = 17
        UltraGridColumn448.Hidden = True
        UltraGridColumn449.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn449.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn449.Header.Caption = "Vehiculo"
        UltraGridColumn449.Header.VisiblePosition = 18
        UltraGridColumn449.Width = 113
        UltraGridColumn450.Header.VisiblePosition = 19
        UltraGridColumn450.Hidden = True
        UltraGridColumn451.Header.VisiblePosition = 20
        UltraGridColumn451.Hidden = True
        UltraGridColumn452.Header.VisiblePosition = 21
        UltraGridColumn452.Hidden = True
        UltraGridColumn453.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn453.Header.Caption = "Select"
        UltraGridColumn453.Header.VisiblePosition = 1
        UltraGridColumn453.Hidden = True
        UltraGridColumn453.Width = 62
        UltraGridColumn454.Header.Caption = "Unid. Med."
        UltraGridColumn454.Header.VisiblePosition = 10
        UltraGridColumn454.Hidden = True
        UltraGridColumn455.Header.VisiblePosition = 22
        UltraGridColumn455.Hidden = True
        UltraGridColumn456.Header.VisiblePosition = 24
        UltraGridColumn456.Hidden = True
        UltraGridColumn457.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn457.Header.Caption = "Nombre"
        UltraGridColumn457.Header.VisiblePosition = 8
        UltraGridColumn457.Width = 323
        UltraGridColumn458.Header.VisiblePosition = 23
        UltraGridColumn458.Hidden = True
        UltraGridColumn459.Header.VisiblePosition = 25
        UltraGridColumn459.Hidden = True
        UltraGridColumn460.Header.VisiblePosition = 26
        UltraGridColumn460.Hidden = True
        UltraGridColumn461.Header.VisiblePosition = 27
        UltraGridColumn461.Hidden = True
        UltraGridColumn462.Header.VisiblePosition = 28
        UltraGridColumn462.Hidden = True
        UltraGridColumn463.Header.VisiblePosition = 29
        UltraGridColumn463.Hidden = True
        UltraGridColumn464.Header.VisiblePosition = 30
        UltraGridColumn464.Hidden = True
        UltraGridColumn465.Header.VisiblePosition = 31
        UltraGridColumn465.Hidden = True
        UltraGridColumn466.Header.VisiblePosition = 32
        UltraGridColumn466.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn434, UltraGridColumn435, UltraGridColumn436, UltraGridColumn437, UltraGridColumn438, UltraGridColumn439, UltraGridColumn440, UltraGridColumn441, UltraGridColumn442, UltraGridColumn443, UltraGridColumn444, UltraGridColumn445, UltraGridColumn446, UltraGridColumn447, UltraGridColumn448, UltraGridColumn449, UltraGridColumn450, UltraGridColumn451, UltraGridColumn452, UltraGridColumn453, UltraGridColumn454, UltraGridColumn455, UltraGridColumn456, UltraGridColumn457, UltraGridColumn458, UltraGridColumn459, UltraGridColumn460, UltraGridColumn461, UltraGridColumn462, UltraGridColumn463, UltraGridColumn464, UltraGridColumn465, UltraGridColumn466})
        Me.udg_Detalles.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.udg_Detalles.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Detalles.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance50.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Detalles.DisplayLayout.GroupByBox.Appearance = Appearance50
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Detalles.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance51
        Me.udg_Detalles.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Detalles.DisplayLayout.GroupByBox.Hidden = True
        Appearance52.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance52.BackColor2 = System.Drawing.SystemColors.Control
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Detalles.DisplayLayout.GroupByBox.PromptAppearance = Appearance52
        Me.udg_Detalles.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Detalles.DisplayLayout.MaxRowScrollRegions = 1
        Appearance53.BackColor = System.Drawing.SystemColors.Window
        Appearance53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.udg_Detalles.DisplayLayout.Override.ActiveCellAppearance = Appearance53
        Appearance54.BackColor = System.Drawing.SystemColors.Highlight
        Appearance54.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.udg_Detalles.DisplayLayout.Override.ActiveRowAppearance = Appearance54
        Me.udg_Detalles.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_Detalles.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Detalles.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Detalles.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Me.udg_Detalles.DisplayLayout.Override.CardAreaAppearance = Appearance55
        Appearance56.BorderColor = System.Drawing.Color.Silver
        Appearance56.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.udg_Detalles.DisplayLayout.Override.CellAppearance = Appearance56
        Me.udg_Detalles.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_Detalles.DisplayLayout.Override.CellPadding = 0
        Me.udg_Detalles.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Detalles.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance57.BackColor = System.Drawing.SystemColors.Control
        Appearance57.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance57.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance57.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Detalles.DisplayLayout.Override.GroupByRowAppearance = Appearance57
        Appearance58.TextHAlignAsString = "Center"
        Me.udg_Detalles.DisplayLayout.Override.HeaderAppearance = Appearance58
        Me.udg_Detalles.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.udg_Detalles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance59.BorderColor = System.Drawing.Color.Silver
        Me.udg_Detalles.DisplayLayout.Override.RowAppearance = Appearance59
        Me.udg_Detalles.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Detalles.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Detalles.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Detalles.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance60.BackColor = System.Drawing.SystemColors.ControlLight
        Me.udg_Detalles.DisplayLayout.Override.TemplateAddRowAppearance = Appearance60
        Me.udg_Detalles.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Detalles.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Detalles.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Detalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Detalles.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Detalles.Location = New System.Drawing.Point(3, 17)
        Me.udg_Detalles.Name = "udg_Detalles"
        Me.udg_Detalles.Size = New System.Drawing.Size(1350, 214)
        Me.udg_Detalles.TabIndex = 0
        Me.udg_Detalles.Text = "Grilla2"
        '
        'bso_Detalle
        '
        Me.bso_Detalle.DataSource = GetType(ERP.EntidadesWCF.e_DetalleDocumento)
        '
        'UltraGroupBox9
        '
        Me.UltraGroupBox9.Controls.Add(Me.udg_DocumentosSeleccionados)
        Me.UltraGroupBox9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraGroupBox9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox9.Location = New System.Drawing.Point(0, 476)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(1356, 200)
        Me.UltraGroupBox9.TabIndex = 12
        Me.UltraGroupBox9.Text = "Documentos Seleccionados"
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_DocumentosSeleccionados
        '
        Me.udg_DocumentosSeleccionados.DataSource = Me.bso_DocumentosSeleccionados
        Appearance61.BackColor = System.Drawing.SystemColors.Window
        Appearance61.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_DocumentosSeleccionados.DisplayLayout.Appearance = Appearance61
        UltraGridColumn295.Header.VisiblePosition = 39
        UltraGridColumn295.Hidden = True
        UltraGridColumn296.Header.VisiblePosition = 40
        UltraGridColumn296.Hidden = True
        UltraGridColumn297.Header.VisiblePosition = 37
        UltraGridColumn297.Hidden = True
        UltraGridColumn298.Header.VisiblePosition = 55
        UltraGridColumn299.Header.VisiblePosition = 41
        UltraGridColumn299.Hidden = True
        UltraGridColumn300.Header.VisiblePosition = 42
        UltraGridColumn300.Hidden = True
        UltraGridColumn301.Header.VisiblePosition = 16
        UltraGridColumn301.Hidden = True
        UltraGridColumn302.Header.VisiblePosition = 17
        UltraGridColumn302.Hidden = True
        UltraGridColumn303.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn303.Header.Caption = "Nº Documento"
        UltraGridColumn303.Header.VisiblePosition = 4
        UltraGridColumn303.Width = 143
        UltraGridColumn304.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn304.Header.Caption = "Producto"
        UltraGridColumn304.Header.VisiblePosition = 11
        UltraGridColumn304.Width = 150
        UltraGridColumn305.Header.VisiblePosition = 19
        UltraGridColumn305.Hidden = True
        UltraGridColumn306.Header.VisiblePosition = 20
        UltraGridColumn306.Hidden = True
        UltraGridColumn307.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn307.Header.Caption = "Fecha"
        UltraGridColumn307.Header.VisiblePosition = 1
        UltraGridColumn307.Width = 77
        UltraGridColumn308.Header.VisiblePosition = 26
        UltraGridColumn308.Hidden = True
        UltraGridColumn309.Header.VisiblePosition = 35
        UltraGridColumn309.Hidden = True
        Appearance62.TextHAlignAsString = "Right"
        UltraGridColumn310.CellAppearance = Appearance62
        UltraGridColumn310.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn310.Format = "#,###,###,##0.00"
        UltraGridColumn310.Header.Caption = "Imp. Venta"
        UltraGridColumn310.Header.VisiblePosition = 9
        UltraGridColumn310.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn310.Width = 91
        Appearance63.TextHAlignAsString = "Right"
        UltraGridColumn311.CellAppearance = Appearance63
        UltraGridColumn311.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn311.Format = "#,###,###,##0.00"
        UltraGridColumn311.Header.VisiblePosition = 8
        UltraGridColumn311.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn311.Width = 109
        Appearance64.TextHAlignAsString = "Right"
        UltraGridColumn312.CellAppearance = Appearance64
        UltraGridColumn312.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn312.Format = "#,###,###,##0.00"
        UltraGridColumn312.Header.VisiblePosition = 10
        UltraGridColumn312.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn312.Width = 104
        UltraGridColumn313.Header.VisiblePosition = 27
        UltraGridColumn313.Hidden = True
        UltraGridColumn314.Header.VisiblePosition = 38
        UltraGridColumn314.Hidden = True
        UltraGridColumn315.Header.VisiblePosition = 48
        UltraGridColumn315.Hidden = True
        UltraGridColumn316.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn316.Header.Caption = "Sel"
        UltraGridColumn316.Header.VisiblePosition = 0
        UltraGridColumn317.Header.VisiblePosition = 49
        UltraGridColumn317.Hidden = True
        Appearance65.TextHAlignAsString = "Right"
        UltraGridColumn318.CellAppearance = Appearance65
        UltraGridColumn318.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn318.Header.Caption = "Tipo Cambio"
        UltraGridColumn318.Header.VisiblePosition = 7
        UltraGridColumn318.Width = 71
        UltraGridColumn319.Header.VisiblePosition = 28
        UltraGridColumn319.Hidden = True
        UltraGridColumn320.Header.VisiblePosition = 43
        UltraGridColumn320.Hidden = True
        UltraGridColumn321.Header.VisiblePosition = 44
        UltraGridColumn321.Hidden = True
        UltraGridColumn322.Header.VisiblePosition = 45
        UltraGridColumn322.Hidden = True
        Appearance66.TextHAlignAsString = "Right"
        UltraGridColumn323.CellAppearance = Appearance66
        UltraGridColumn323.Format = "#,###,###,##0.00"
        UltraGridColumn323.Header.Caption = "Importe"
        UltraGridColumn323.Header.VisiblePosition = 15
        UltraGridColumn324.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn324.Header.Caption = "Empresa"
        UltraGridColumn324.Header.VisiblePosition = 2
        UltraGridColumn324.Width = 281
        UltraGridColumn325.Header.VisiblePosition = 46
        UltraGridColumn325.Hidden = True
        UltraGridColumn326.Header.VisiblePosition = 21
        UltraGridColumn326.Hidden = True
        UltraGridColumn327.Header.VisiblePosition = 29
        UltraGridColumn327.Hidden = True
        Appearance67.TextHAlignAsString = "Right"
        UltraGridColumn328.CellAppearance = Appearance67
        UltraGridColumn328.Header.VisiblePosition = 22
        UltraGridColumn328.Hidden = True
        UltraGridColumn328.MaskInput = ""
        UltraGridColumn329.Header.VisiblePosition = 30
        UltraGridColumn329.Hidden = True
        UltraGridColumn330.Header.VisiblePosition = 24
        UltraGridColumn330.Hidden = True
        UltraGridColumn331.Header.VisiblePosition = 18
        UltraGridColumn331.Hidden = True
        UltraGridColumn331.Width = 132
        UltraGridColumn332.Header.VisiblePosition = 23
        UltraGridColumn332.Hidden = True
        UltraGridColumn333.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn333.Header.VisiblePosition = 6
        UltraGridColumn334.Header.VisiblePosition = 36
        UltraGridColumn334.Hidden = True
        UltraGridColumn335.Header.VisiblePosition = 25
        UltraGridColumn335.Hidden = True
        Appearance68.TextHAlignAsString = "Right"
        UltraGridColumn336.CellAppearance = Appearance68
        UltraGridColumn336.Format = "#,###,###,##0.00"
        UltraGridColumn336.Header.Caption = "Precio Unit."
        UltraGridColumn336.Header.VisiblePosition = 14
        UltraGridColumn337.Header.VisiblePosition = 31
        UltraGridColumn337.Hidden = True
        UltraGridColumn338.Header.VisiblePosition = 32
        UltraGridColumn338.Hidden = True
        UltraGridColumn339.Header.VisiblePosition = 34
        UltraGridColumn339.Hidden = True
        UltraGridColumn340.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn340.Header.Caption = "Estado"
        UltraGridColumn340.Header.VisiblePosition = 5
        UltraGridColumn340.Width = 80
        UltraGridColumn341.Header.VisiblePosition = 33
        UltraGridColumn341.Hidden = True
        UltraGridColumn342.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn342.Header.Caption = "Tipo Documento"
        UltraGridColumn342.Header.VisiblePosition = 3
        UltraGridColumn342.Width = 167
        Appearance69.TextHAlignAsString = "Right"
        UltraGridColumn343.CellAppearance = Appearance69
        UltraGridColumn343.Format = "#,###,###,##0.00"
        UltraGridColumn343.Header.Caption = "Cantidad"
        UltraGridColumn343.Header.VisiblePosition = 13
        UltraGridColumn344.Header.VisiblePosition = 47
        UltraGridColumn344.Hidden = True
        UltraGridColumn345.Header.VisiblePosition = 50
        UltraGridColumn345.Hidden = True
        UltraGridColumn346.Header.Caption = "Placa"
        UltraGridColumn346.Header.VisiblePosition = 12
        UltraGridColumn347.Header.VisiblePosition = 51
        UltraGridColumn347.Hidden = True
        UltraGridColumn348.Header.VisiblePosition = 52
        UltraGridColumn348.Hidden = True
        UltraGridColumn349.Header.VisiblePosition = 53
        UltraGridColumn349.Hidden = True
        UltraGridColumn350.Header.VisiblePosition = 54
        UltraGridColumn350.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn295, UltraGridColumn296, UltraGridColumn297, UltraGridColumn298, UltraGridColumn299, UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn307, UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313, UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn321, UltraGridColumn322, UltraGridColumn323, UltraGridColumn324, UltraGridColumn325, UltraGridColumn326, UltraGridColumn327, UltraGridColumn328, UltraGridColumn329, UltraGridColumn330, UltraGridColumn331, UltraGridColumn332, UltraGridColumn333, UltraGridColumn334, UltraGridColumn335, UltraGridColumn336, UltraGridColumn337, UltraGridColumn338, UltraGridColumn339, UltraGridColumn340, UltraGridColumn341, UltraGridColumn342, UltraGridColumn343, UltraGridColumn344, UltraGridColumn345, UltraGridColumn346, UltraGridColumn347, UltraGridColumn348, UltraGridColumn349, UltraGridColumn350})
        UltraGridColumn351.Header.VisiblePosition = 0
        UltraGridColumn352.Header.VisiblePosition = 1
        UltraGridColumn353.Header.VisiblePosition = 2
        UltraGridColumn354.Header.VisiblePosition = 3
        UltraGridColumn355.Header.VisiblePosition = 4
        UltraGridColumn356.Header.VisiblePosition = 5
        UltraGridColumn357.Header.VisiblePosition = 6
        UltraGridColumn358.Header.VisiblePosition = 7
        UltraGridColumn359.Header.VisiblePosition = 8
        UltraGridColumn360.Header.VisiblePosition = 9
        UltraGridColumn361.Header.VisiblePosition = 10
        UltraGridColumn362.Header.VisiblePosition = 11
        UltraGridColumn363.Header.VisiblePosition = 12
        UltraGridColumn364.Header.VisiblePosition = 13
        UltraGridColumn365.Header.VisiblePosition = 14
        UltraGridColumn366.Header.VisiblePosition = 15
        UltraGridColumn367.Header.VisiblePosition = 16
        UltraGridColumn368.Header.VisiblePosition = 17
        UltraGridColumn369.Header.VisiblePosition = 18
        UltraGridColumn370.Header.VisiblePosition = 19
        UltraGridColumn371.Header.VisiblePosition = 20
        UltraGridColumn372.Header.VisiblePosition = 21
        UltraGridColumn373.Header.VisiblePosition = 22
        UltraGridColumn374.Header.VisiblePosition = 23
        UltraGridColumn375.Header.VisiblePosition = 24
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn351, UltraGridColumn352, UltraGridColumn353, UltraGridColumn354, UltraGridColumn355, UltraGridColumn356, UltraGridColumn357, UltraGridColumn358, UltraGridColumn359, UltraGridColumn360, UltraGridColumn361, UltraGridColumn362, UltraGridColumn363, UltraGridColumn364, UltraGridColumn365, UltraGridColumn366, UltraGridColumn367, UltraGridColumn368, UltraGridColumn369, UltraGridColumn370, UltraGridColumn371, UltraGridColumn372, UltraGridColumn373, UltraGridColumn374, UltraGridColumn375})
        Me.udg_DocumentosSeleccionados.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.udg_DocumentosSeleccionados.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.udg_DocumentosSeleccionados.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_DocumentosSeleccionados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance70.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance70.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance70.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_DocumentosSeleccionados.DisplayLayout.GroupByBox.Appearance = Appearance70
        Appearance71.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_DocumentosSeleccionados.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance71
        Me.udg_DocumentosSeleccionados.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_DocumentosSeleccionados.DisplayLayout.GroupByBox.Hidden = True
        Appearance72.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance72.BackColor2 = System.Drawing.SystemColors.Control
        Appearance72.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance72.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_DocumentosSeleccionados.DisplayLayout.GroupByBox.PromptAppearance = Appearance72
        Me.udg_DocumentosSeleccionados.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_DocumentosSeleccionados.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance73.BorderColor = System.Drawing.Color.Silver
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.RowAppearance = Appearance73
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_DocumentosSeleccionados.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_DocumentosSeleccionados.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_DocumentosSeleccionados.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_DocumentosSeleccionados.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.udg_DocumentosSeleccionados.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_DocumentosSeleccionados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_DocumentosSeleccionados.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_DocumentosSeleccionados.Location = New System.Drawing.Point(3, 17)
        Me.udg_DocumentosSeleccionados.Name = "udg_DocumentosSeleccionados"
        Me.udg_DocumentosSeleccionados.Size = New System.Drawing.Size(1350, 180)
        Me.udg_DocumentosSeleccionados.TabIndex = 10
        Me.udg_DocumentosSeleccionados.Text = "Grilla2"
        '
        'bso_DocumentosSeleccionados
        '
        Me.bso_DocumentosSeleccionados.DataSource = GetType(ERP.EntidadesWCF.e_MovimientoDocumento)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox6)
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox5)
        Me.UltraGroupBox3.Controls.Add(Me.Panel1)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1356, 242)
        Me.UltraGroupBox3.TabIndex = 0
        Me.UltraGroupBox3.Text = "Datos Factura"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel16)
        Me.UltraGroupBox6.Controls.Add(Me.txt_Numero)
        Me.UltraGroupBox6.Controls.Add(Me.txt_Observacion)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel15)
        Me.UltraGroupBox6.Controls.Add(Me.dtp_FechaEmision)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox6.Controls.Add(Me.cmbTipoDocumento)
        Me.UltraGroupBox6.Controls.Add(Me.dtpFechaPago)
        Me.UltraGroupBox6.Controls.Add(Me.txtSerie)
        Me.UltraGroupBox6.Controls.Add(Me.cmb_Cliente)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox6.Controls.Add(Me.cboTipoPago)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox6.Location = New System.Drawing.Point(11, 31)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(467, 200)
        Me.UltraGroupBox6.TabIndex = 1007
        Me.UltraGroupBox6.Text = "Datos del Documento"
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel16
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Appearance74.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance74
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(196, 85)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(8, 15)
        Me.UltraLabel16.TabIndex = 30
        Me.UltraLabel16.Text = "-"
        '
        'txt_Numero
        '
        Me.txt_Numero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Numero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Numero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Numero.Location = New System.Drawing.Point(210, 80)
        Me.txt_Numero.MaxLength = 12
        Me.txt_Numero.Name = "txt_Numero"
        Me.txt_Numero.Size = New System.Drawing.Size(151, 22)
        Me.txt_Numero.TabIndex = 29
        '
        'txt_Observacion
        '
        Me.txt_Observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Observacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Observacion.Location = New System.Drawing.Point(107, 163)
        Me.txt_Observacion.MaxLength = 5000
        Me.txt_Observacion.Name = "txt_Observacion"
        Me.txt_Observacion.Size = New System.Drawing.Size(337, 22)
        Me.txt_Observacion.TabIndex = 15
        '
        'UltraLabel15
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Appearance75.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance75
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(31, 167)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(69, 15)
        Me.UltraLabel15.TabIndex = 14
        Me.UltraLabel15.Text = "Observacion:"
        '
        'dtp_FechaEmision
        '
        Me.dtp_FechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaEmision.Location = New System.Drawing.Point(105, 25)
        Me.dtp_FechaEmision.Name = "dtp_FechaEmision"
        Me.dtp_FechaEmision.Size = New System.Drawing.Size(104, 21)
        Me.dtp_FechaEmision.TabIndex = 1
        '
        'UltraLabel8
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Appearance76.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance76
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(58, 113)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel8.TabIndex = 8
        Me.UltraLabel8.Text = "Cliente:"
        '
        'UltraLabel4
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Appearance77.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance77
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(41, 142)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel4.TabIndex = 10
        Me.UltraLabel4.Text = "TipoCobro:"
        '
        'UltraLabel7
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Appearance78.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance78
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(12, 56)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(87, 15)
        Me.UltraLabel7.TabIndex = 4
        Me.UltraLabel7.Text = "TipoDocumento:"
        '
        'UltraLabel5
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Appearance79.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance79
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(237, 28)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(67, 15)
        Me.UltraLabel5.TabIndex = 12
        Me.UltraLabel5.Text = "FechaCobro:"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(106, 52)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(255, 22)
        Me.cmbTipoDocumento.TabIndex = 5
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Enabled = False
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(311, 24)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(103, 21)
        Me.dtpFechaPago.TabIndex = 13
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Location = New System.Drawing.Point(106, 80)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(84, 22)
        Me.txtSerie.TabIndex = 7
        '
        'cmb_Cliente
        '
        EditorButton3.Key = "Left"
        Me.cmb_Cliente.ButtonsLeft.Add(EditorButton3)
        EditorButton4.Key = "Right"
        Me.cmb_Cliente.ButtonsRight.Add(EditorButton4)
        Me.cmb_Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance80.BackColor = System.Drawing.SystemColors.Window
        Appearance80.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_Cliente.DisplayLayout.Appearance = Appearance80
        UltraGridColumn467.Header.VisiblePosition = 0
        UltraGridColumn467.Hidden = True
        UltraGridColumn468.Header.VisiblePosition = 5
        UltraGridColumn468.Hidden = True
        UltraGridColumn469.Header.VisiblePosition = 1
        UltraGridColumn470.Header.VisiblePosition = 2
        UltraGridColumn471.Header.VisiblePosition = 3
        UltraGridColumn472.Header.VisiblePosition = 7
        UltraGridColumn472.Width = 300
        UltraGridColumn473.Header.VisiblePosition = 9
        UltraGridColumn473.Hidden = True
        UltraGridColumn474.Header.VisiblePosition = 6
        UltraGridColumn475.Header.VisiblePosition = 24
        UltraGridColumn475.Hidden = True
        UltraGridColumn476.Header.VisiblePosition = 8
        UltraGridColumn477.Header.VisiblePosition = 11
        UltraGridColumn477.Hidden = True
        UltraGridColumn478.Header.VisiblePosition = 13
        UltraGridColumn478.Hidden = True
        UltraGridColumn479.Header.VisiblePosition = 15
        UltraGridColumn479.Hidden = True
        UltraGridColumn480.Header.VisiblePosition = 22
        UltraGridColumn480.Hidden = True
        UltraGridColumn481.Header.VisiblePosition = 19
        UltraGridColumn481.Hidden = True
        UltraGridColumn482.Header.VisiblePosition = 20
        UltraGridColumn482.Hidden = True
        UltraGridColumn483.Header.VisiblePosition = 12
        UltraGridColumn484.Header.VisiblePosition = 14
        UltraGridColumn485.Header.VisiblePosition = 16
        UltraGridColumn486.Header.VisiblePosition = 17
        UltraGridColumn487.Header.VisiblePosition = 4
        UltraGridColumn487.Hidden = True
        UltraGridColumn488.Header.VisiblePosition = 21
        UltraGridColumn489.Header.VisiblePosition = 23
        UltraGridColumn490.Header.VisiblePosition = 18
        UltraGridColumn490.Hidden = True
        UltraGridColumn491.Header.VisiblePosition = 10
        UltraGridColumn491.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn467, UltraGridColumn468, UltraGridColumn469, UltraGridColumn470, UltraGridColumn471, UltraGridColumn472, UltraGridColumn473, UltraGridColumn474, UltraGridColumn475, UltraGridColumn476, UltraGridColumn477, UltraGridColumn478, UltraGridColumn479, UltraGridColumn480, UltraGridColumn481, UltraGridColumn482, UltraGridColumn483, UltraGridColumn484, UltraGridColumn485, UltraGridColumn486, UltraGridColumn487, UltraGridColumn488, UltraGridColumn489, UltraGridColumn490, UltraGridColumn491})
        Me.cmb_Cliente.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.cmb_Cliente.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmb_Cliente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance81.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance81.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance81.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb_Cliente.DisplayLayout.GroupByBox.Appearance = Appearance81
        Appearance82.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb_Cliente.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance82
        Me.cmb_Cliente.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance83.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance83.BackColor2 = System.Drawing.SystemColors.Control
        Appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance83.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb_Cliente.DisplayLayout.GroupByBox.PromptAppearance = Appearance83
        Me.cmb_Cliente.DisplayLayout.MaxColScrollRegions = 1
        Me.cmb_Cliente.DisplayLayout.MaxRowScrollRegions = 1
        Appearance84.BackColor = System.Drawing.SystemColors.Window
        Appearance84.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb_Cliente.DisplayLayout.Override.ActiveCellAppearance = Appearance84
        Appearance85.BackColor = System.Drawing.SystemColors.Highlight
        Appearance85.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmb_Cliente.DisplayLayout.Override.ActiveRowAppearance = Appearance85
        Me.cmb_Cliente.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmb_Cliente.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance86.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Cliente.DisplayLayout.Override.CardAreaAppearance = Appearance86
        Appearance87.BorderColor = System.Drawing.Color.Silver
        Appearance87.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cmb_Cliente.DisplayLayout.Override.CellAppearance = Appearance87
        Me.cmb_Cliente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cmb_Cliente.DisplayLayout.Override.CellPadding = 0
        Appearance88.BackColor = System.Drawing.SystemColors.Control
        Appearance88.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance88.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance88.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb_Cliente.DisplayLayout.Override.GroupByRowAppearance = Appearance88
        Appearance89.TextHAlignAsString = "Left"
        Me.cmb_Cliente.DisplayLayout.Override.HeaderAppearance = Appearance89
        Me.cmb_Cliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance90.BackColor = System.Drawing.SystemColors.Window
        Appearance90.BorderColor = System.Drawing.Color.Silver
        Me.cmb_Cliente.DisplayLayout.Override.RowAppearance = Appearance90
        Me.cmb_Cliente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance91.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmb_Cliente.DisplayLayout.Override.TemplateAddRowAppearance = Appearance91
        Me.cmb_Cliente.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cmb_Cliente.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cmb_Cliente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cmb_Cliente.DisplayMember = "Nombre"
        Me.cmb_Cliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_Cliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Cliente.Location = New System.Drawing.Point(106, 108)
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Size = New System.Drawing.Size(338, 23)
        Me.cmb_Cliente.TabIndex = 9
        Me.cmb_Cliente.ValueMember = "Id"
        '
        'UltraLabel6
        '
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Appearance92.ForeColor = System.Drawing.Color.Navy
        Appearance92.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance92
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(34, 85)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(65, 15)
        Me.UltraLabel6.TabIndex = 6
        Me.UltraLabel6.Text = "Documento:"
        '
        'cboTipoPago
        '
        Appearance93.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance93
        Me.cboTipoPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance94.Image = 7
        EditorButton5.Appearance = Appearance94
        Me.cboTipoPago.ButtonsRight.Add(EditorButton5)
        Me.cboTipoPago.DisplayMember = "Nombre"
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Location = New System.Drawing.Point(106, 137)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(338, 22)
        Me.cboTipoPago.TabIndex = 11
        Me.cboTipoPago.ValueMember = "Id"
        '
        'UltraLabel3
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Appearance95.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance95
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(61, 28)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Fecha:"
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.decTipoCambio)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox5.Controls.Add(Me.nud_Total)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox5.Controls.Add(Me.nud_Impuesto)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox5.Controls.Add(Me.nud_SubTotal)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox5.Location = New System.Drawing.Point(484, 31)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(205, 144)
        Me.UltraGroupBox5.TabIndex = 1006
        Me.UltraGroupBox5.Text = "Totales"
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decTipoCambio
        '
        Me.decTipoCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTipoCambio.Location = New System.Drawing.Point(80, 26)
        Me.decTipoCambio.MaskInput = "{double:2.3}"
        Me.decTipoCambio.MaxValue = 5.0R
        Me.decTipoCambio.MinValue = 0R
        Me.decTipoCambio.Name = "decTipoCambio"
        Me.decTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTipoCambio.ReadOnly = True
        Me.decTipoCambio.Size = New System.Drawing.Size(106, 22)
        Me.decTipoCambio.TabIndex = 15
        Me.decTipoCambio.TabStop = False
        '
        'UltraLabel12
        '
        Appearance96.BackColor = System.Drawing.Color.Transparent
        Appearance96.ForeColor = System.Drawing.Color.Navy
        Appearance96.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance96
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(46, 30)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(28, 15)
        Me.UltraLabel12.TabIndex = 14
        Me.UltraLabel12.Text = "T.C.:"
        '
        'nud_Total
        '
        Me.nud_Total.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nud_Total.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Total.Location = New System.Drawing.Point(80, 110)
        Me.nud_Total.MaskInput = "{double:9.2}"
        Me.nud_Total.Name = "nud_Total"
        Me.nud_Total.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nud_Total.ReadOnly = True
        Me.nud_Total.Size = New System.Drawing.Size(106, 22)
        Me.nud_Total.TabIndex = 1003
        '
        'UltraLabel14
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Appearance97.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance97
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(19, 86)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(55, 15)
        Me.UltraLabel14.TabIndex = 1001
        Me.UltraLabel14.Text = "Impuesto:"
        '
        'nud_Impuesto
        '
        Me.nud_Impuesto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nud_Impuesto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Impuesto.Location = New System.Drawing.Point(80, 82)
        Me.nud_Impuesto.MaskInput = "{double:9.2}"
        Me.nud_Impuesto.Name = "nud_Impuesto"
        Me.nud_Impuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nud_Impuesto.ReadOnly = True
        Me.nud_Impuesto.Size = New System.Drawing.Size(106, 22)
        Me.nud_Impuesto.TabIndex = 1004
        '
        'UltraLabel13
        '
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Appearance98.ForeColor = System.Drawing.Color.Navy
        Appearance98.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance98
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(22, 58)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel13.TabIndex = 1000
        Me.UltraLabel13.Text = "SubTotal:"
        '
        'nud_SubTotal
        '
        Me.nud_SubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nud_SubTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_SubTotal.Location = New System.Drawing.Point(80, 54)
        Me.nud_SubTotal.MaskInput = "{double:9.2}"
        Me.nud_SubTotal.Name = "nud_SubTotal"
        Me.nud_SubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nud_SubTotal.ReadOnly = True
        Me.nud_SubTotal.Size = New System.Drawing.Size(106, 22)
        Me.nud_SubTotal.TabIndex = 1005
        '
        'UltraLabel11
        '
        Appearance99.BackColor = System.Drawing.Color.Transparent
        Appearance99.ForeColor = System.Drawing.Color.Navy
        Appearance99.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance99
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(41, 114)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel11.TabIndex = 1002
        Me.UltraLabel11.Text = "Total:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmbMoneda)
        Me.Panel1.Controls.Add(Me.UltraLabel9)
        Me.Panel1.Location = New System.Drawing.Point(1079, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(129, 168)
        Me.Panel1.TabIndex = 16
        Me.Panel1.Visible = False
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbMoneda.Location = New System.Drawing.Point(74, 11)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.ReadOnly = True
        Me.cmbMoneda.Size = New System.Drawing.Size(148, 22)
        Me.cmbMoneda.TabIndex = 3
        Me.cmbMoneda.ValueMember = "Id"
        '
        'UltraLabel9
        '
        Appearance100.BackColor = System.Drawing.Color.Transparent
        Appearance100.ForeColor = System.Drawing.Color.Navy
        Appearance100.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance100
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(20, 15)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel9.TabIndex = 2
        Me.UltraLabel9.Text = "Moneda:"
        '
        'fic_Canje
        '
        Me.fic_Canje.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.fic_Canje.Controls.Add(Me.UltraTabPageControl1)
        Me.fic_Canje.Controls.Add(Me.UltraTabPageControl2)
        Me.fic_Canje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fic_Canje.Location = New System.Drawing.Point(0, 0)
        Me.fic_Canje.Name = "fic_Canje"
        Me.fic_Canje.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.fic_Canje.Size = New System.Drawing.Size(1358, 699)
        Me.fic_Canje.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Lista"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Mantenimiento"
        Me.fic_Canje.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.fic_Canje.TabStop = False
        Me.fic_Canje.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1356, 676)
        '
        'frm_CanjeDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 699)
        Me.Controls.Add(Me.fic_Canje)
        Me.Name = "frm_CanjeDocumentos"
        Me.Text = "Canje de Documentos"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        CType(Me.udg_Documentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bso_Documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        CType(Me.udg_DetalleProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bso_DetalleProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cmb_ClienteBuscado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.udg_Detalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bso_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        CType(Me.udg_DocumentosSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bso_DocumentosSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        Me.UltraGroupBox6.PerformLayout()
        CType(Me.txt_Numero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.UltraGroupBox5.PerformLayout()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Impuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_SubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fic_Canje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fic_Canje.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fic_Canje As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsb_Canjear As ToolStripButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dtp_FechaHasta As DateTimePicker
    Friend WithEvents dtp_FechaDesde As DateTimePicker
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaEmision As DateTimePicker
    Friend WithEvents cboTipoPago As Controles.ComboMaestros
    Friend WithEvents cmb_Cliente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents decTipoCambio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFechaPago As DateTimePicker
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSerie As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udg_Detalles As Controles.Grilla
    Friend WithEvents bso_Detalle As BindingSource
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbTipoDocumento As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbMoneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents bso_Documento As BindingSource
    Friend WithEvents udg_Documentos As Controles.Grilla
    Friend WithEvents cmb_ClienteBuscado As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents nud_Total As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents nud_Impuesto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents nud_SubTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents tsb_Emitir As ToolStripButton
    Friend WithEvents tsb_Eliminar As ToolStripButton
    Friend WithEvents txt_Observacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Numero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tsb_Imprimir As ToolStripDropDownButton
    Friend WithEvents tsb_ImprimirA4 As ToolStripMenuItem
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udg_DetalleProductos As Controles.Grilla
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents bso_DetalleProductos As BindingSource
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udg_DocumentosSeleccionados As Controles.Grilla
    Friend WithEvents bso_DocumentosSeleccionados As BindingSource
End Class
