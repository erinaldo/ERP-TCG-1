<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BoletaCompra
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
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialServicio")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioSinImp")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGravado")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionDetalle")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterialServicio")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreMaterialServicio")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pos")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FactorRefUni")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoDocumento")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterialServicio")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitarioSinImp")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGravado")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Igv")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacionDetalle")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterialServicio")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreMaterialServicio")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pos")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FactorRefUni")
        Dim UltraDataColumn193 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenOrigen")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenDestino")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreSubEstado")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUsuario")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenDocumento")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieNumero")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AlmacenOrigen")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AlmacenDestino")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioEjecucion")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioEjecucion")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenOrigen")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenDestino")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn194 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn195 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn196 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn197 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn198 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn199 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn200 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn201 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenOrigen")
        Dim UltraDataColumn202 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenDestino")
        Dim UltraDataColumn203 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn204 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn205 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn206 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn207 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn208 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn209 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn210 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn211 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn212 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn213 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn214 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn215 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn216 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn217 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreSubEstado")
        Dim UltraDataColumn218 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUsuario")
        Dim UltraDataColumn219 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn220 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenDocumento")
        Dim UltraDataColumn221 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn222 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn223 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieNumero")
        Dim UltraDataColumn224 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AlmacenOrigen")
        Dim UltraDataColumn225 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AlmacenDestino")
        Dim UltraDataColumn226 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioEjecucion")
        Dim UltraDataColumn227 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioEjecucion")
        Dim UltraDataColumn228 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenOrigen")
        Dim UltraDataColumn229 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenOrigen")
        Dim UltraDataColumn230 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenDestino")
        Dim UltraDataColumn231 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenDestino")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenOrigen")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenDestino")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreSubEstado")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUsuario")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenDocumento")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieNumero")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AlmacenOrigen")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AlmacenDestino")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioEjecucion")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioEjecucion")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenOrigen")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenDestino")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn232 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn233 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn234 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn235 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn236 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn237 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn238 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn239 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenOrigen")
        Dim UltraDataColumn240 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenDestino")
        Dim UltraDataColumn241 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn242 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn243 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn244 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn245 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn246 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn247 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn248 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn249 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn250 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn251 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn252 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn253 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn254 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn255 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreSubEstado")
        Dim UltraDataColumn256 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUsuario")
        Dim UltraDataColumn257 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn258 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenDocumento")
        Dim UltraDataColumn259 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn260 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn261 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieNumero")
        Dim UltraDataColumn262 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AlmacenOrigen")
        Dim UltraDataColumn263 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AlmacenDestino")
        Dim UltraDataColumn264 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioEjecucion")
        Dim UltraDataColumn265 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioEjecucion")
        Dim UltraDataColumn266 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenOrigen")
        Dim UltraDataColumn267 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenOrigen")
        Dim UltraDataColumn268 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenDestino")
        Dim UltraDataColumn269 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenDestino")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BoletaCompra))
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn270 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn271 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn272 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn273 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn274 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn275 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn276 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn277 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn278 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn279 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn280 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn281 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn282 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn283 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn284 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn285 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn286 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn287 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn288 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn289 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn290 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn291 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn292 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn293 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn294 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn295 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn296 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn297 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn298 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn299 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn300 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCompra")
        Dim UltraDataColumn301 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn302 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn303 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn304 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn305 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn306 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn307 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Listar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Listar")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Ejecutar")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Importar")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool29 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Generar documento")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn308 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn309 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn310 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn311 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn312 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn313 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn314 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn315 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMaterial")
        Dim UltraDataColumn316 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMaterial")
        Dim UltraDataColumn317 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn318 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraDataColumn319 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn320 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn321 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn322 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidadMedida")
        Dim UltraDataColumn323 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn324 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn325 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn326 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serial")
        Dim UltraDataColumn327 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AfectoIgv")
        Dim UltraDataColumn328 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn329 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn330 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn331 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn332 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn333 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn334 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn335 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn336 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaDetalleBoleta = New ISL.Controles.Grilla(Me.components)
        Me.odDetalleDocumento = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaOrdenIngreso = New ISL.Controles.Grilla(Me.components)
        Me.odOrden = New ISL.Controles.OrigenDatos(Me.components)
        Me.UEGB_Ordenes = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Agrupacion11 = New ISL.Controles.Agrupacion(Me.components)
        Me.griOrdenes = New ISL.Controles.Grilla(Me.components)
        Me.odOrdenesIngreso = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.rFechasHasta = New System.Windows.Forms.DateTimePicker()
        Me.rFechasDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cbTipoOrden = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnBuscarOrdenes = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrBoleta = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaBoletaCompra = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual2 = New ISL.Controles.MenuContextual(Me.components)
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarTesoreriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.odListadoDocumentos = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnAnular = New ISL.Controles.Boton(Me.components)
        Me.cmdEnviaTesoreria = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.gbDatosAdicionales = New ISL.Controles.Agrupacion(Me.components)
        Me.cboProveedor2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.rfFechaDocHasta = New System.Windows.Forms.DateTimePicker()
        Me.cboEstadoBoleta = New ISL.Controles.ComboMaestros(Me.components)
        Me.rfFechaDocDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMaterialServicio = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.gbNroDoc = New ISL.Controles.Agrupacion(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.etiTerminada = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresEmitido = New ISL.Controles.Colores(Me.components)
        Me.etiEnviado = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresAnulado = New ISL.Controles.Colores(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.rbNroDoc = New System.Windows.Forms.RadioButton()
        Me.rbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerieD = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.ficDetalleOCMateriales = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolbarsDockArea13 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.MenuDetalle = New ISL.Controles.Menu(Me.components)
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
        Me.chk_CajaChica = New ISL.Controles.Chequear(Me.components)
        Me.fecFechaActual = New System.Windows.Forms.DateTimePicker()
        Me.chkRuc = New ISL.Controles.Chequear(Me.components)
        Me.cboProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtSubTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtIGV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtEstado = New ISL.Controles.Texto(Me.components)
        Me.lbl_etiqueta = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtEmpresa = New ISL.Controles.Texto(Me.components)
        Me.lbNumeroOrden = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtTc = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTipoPago = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboEstadoBoletaM = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtPorcenIGV = New ISL.Controles.Texto(Me.components)
        Me.txtSerieM = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumeroM = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.agrAsociacion = New ISL.Controles.Agrupacion(Me.components)
        Me.rbAsoDoc = New System.Windows.Forms.RadioButton()
        Me.rbAsoOrd = New System.Windows.Forms.RadioButton()
        Me.odMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.ficBoletaCompra = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.griListaDetalleBoleta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odDetalleDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl13.SuspendLayout()
        CType(Me.griListaOrdenIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UEGB_Ordenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UEGB_Ordenes.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion11.SuspendLayout()
        CType(Me.griOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenesIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.cbTipoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrBoleta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBoleta.SuspendLayout()
        CType(Me.griListaBoletaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual2.SuspendLayout()
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.cboProveedor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoBoleta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaterialServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbNroDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNroDoc.SuspendLayout()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresEmitido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.ficDetalleOCMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalleOCMateriales.SuspendLayout()
        CType(Me.MenuDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.chk_CajaChica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoBoletaM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcenIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrAsociacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrAsociacion.SuspendLayout()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficBoletaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficBoletaCompra.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(1252, 183)
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.griListaDetalleBoleta)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(1252, 183)
        Me.Agrupacion6.TabIndex = 246
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griListaDetalleBoleta
        '
        Me.griListaDetalleBoleta.DataSource = Me.odDetalleDocumento
        UltraGridColumn42.Header.VisiblePosition = 1
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 3
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 4
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 2
        UltraGridColumn45.Hidden = True
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn46.CellAppearance = Appearance1
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn46.Header.VisiblePosition = 7
        UltraGridColumn46.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn46.Width = 96
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn47.CellAppearance = Appearance2
        UltraGridColumn47.Header.Caption = "PU S/Imp"
        UltraGridColumn47.Header.VisiblePosition = 10
        UltraGridColumn47.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn47.Width = 133
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn48.CellAppearance = Appearance3
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn48.Header.Caption = "PU C/Imp"
        UltraGridColumn48.Header.VisiblePosition = 11
        UltraGridColumn48.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn48.Width = 134
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn49.CellAppearance = Appearance4
        UltraGridColumn49.Header.Caption = "Importe"
        UltraGridColumn49.Header.VisiblePosition = 14
        UltraGridColumn49.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn49.Width = 125
        UltraGridColumn50.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn50.Header.Caption = "Ind. Igv"
        UltraGridColumn50.Header.VisiblePosition = 9
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.Width = 75
        UltraGridColumn51.Header.VisiblePosition = 12
        UltraGridColumn51.Hidden = True
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn52.CellAppearance = Appearance5
        UltraGridColumn52.Header.VisiblePosition = 13
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn53.Header.VisiblePosition = 15
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 16
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 17
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 18
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 19
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.Caption = "Codigo"
        UltraGridColumn58.Header.VisiblePosition = 5
        UltraGridColumn58.Width = 116
        UltraGridColumn59.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn59.Header.VisiblePosition = 0
        UltraGridColumn59.Width = 39
        UltraGridColumn60.Header.Caption = "Unid. Med."
        UltraGridColumn60.Header.VisiblePosition = 8
        UltraGridColumn61.Header.VisiblePosition = 20
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.Caption = "Nombre"
        UltraGridColumn62.Header.VisiblePosition = 6
        UltraGridColumn62.Width = 306
        UltraGridColumn63.Header.VisiblePosition = 21
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 22
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 23
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 24
        UltraGridColumn66.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66})
        Me.griListaDetalleBoleta.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaDetalleBoleta.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleBoleta.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleBoleta.DisplayLayout.GroupByBox.Appearance = Appearance6
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDetalleBoleta.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance7
        Me.griListaDetalleBoleta.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDetalleBoleta.DisplayLayout.GroupByBox.Hidden = True
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance8.BackColor2 = System.Drawing.SystemColors.Control
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaDetalleBoleta.DisplayLayout.GroupByBox.PromptAppearance = Appearance8
        Me.griListaDetalleBoleta.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDetalleBoleta.DisplayLayout.MaxRowScrollRegions = 1
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Appearance9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaDetalleBoleta.DisplayLayout.Override.ActiveCellAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.SystemColors.Highlight
        Appearance10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaDetalleBoleta.DisplayLayout.Override.ActiveRowAppearance = Appearance10
        Me.griListaDetalleBoleta.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleBoleta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleBoleta.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaDetalleBoleta.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleBoleta.DisplayLayout.Override.CardAreaAppearance = Appearance11
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Appearance12.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaDetalleBoleta.DisplayLayout.Override.CellAppearance = Appearance12
        Me.griListaDetalleBoleta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDetalleBoleta.DisplayLayout.Override.CellPadding = 0
        Me.griListaDetalleBoleta.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDetalleBoleta.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaDetalleBoleta.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance13.BackColor = System.Drawing.SystemColors.Control
        Appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance13.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance13.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaDetalleBoleta.DisplayLayout.Override.GroupByRowAppearance = Appearance13
        Appearance14.TextHAlignAsString = "Center"
        Me.griListaDetalleBoleta.DisplayLayout.Override.HeaderAppearance = Appearance14
        Me.griListaDetalleBoleta.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaDetalleBoleta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Me.griListaDetalleBoleta.DisplayLayout.Override.RowAppearance = Appearance15
        Me.griListaDetalleBoleta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaDetalleBoleta.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDetalleBoleta.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaDetalleBoleta.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaDetalleBoleta.DisplayLayout.Override.TemplateAddRowAppearance = Appearance16
        Me.griListaDetalleBoleta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaDetalleBoleta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaDetalleBoleta.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaDetalleBoleta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDetalleBoleta.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaDetalleBoleta.Location = New System.Drawing.Point(2, 2)
        Me.griListaDetalleBoleta.Name = "griListaDetalleBoleta"
        Me.griListaDetalleBoleta.Size = New System.Drawing.Size(1248, 179)
        Me.griListaDetalleBoleta.TabIndex = 7
        Me.griListaDetalleBoleta.Text = "Grilla2"
        '
        'odDetalleDocumento
        '
        UltraDataColumn177.DataType = GetType(Boolean)
        UltraDataColumn177.DefaultValue = False
        UltraDataColumn186.DataType = GetType(Boolean)
        UltraDataColumn186.DefaultValue = False
        Me.odDetalleDocumento.Band.Columns.AddRange(New Object() {UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185, UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192, UltraDataColumn193})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.griListaOrdenIngreso)
        Me.UltraTabPageControl13.Controls.Add(Me.UEGB_Ordenes)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(1252, 183)
        '
        'griListaOrdenIngreso
        '
        Me.griListaOrdenIngreso.DataSource = Me.odOrden
        UltraGridColumn67.Header.VisiblePosition = 0
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 1
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.Caption = "N° Orden"
        UltraGridColumn69.Header.VisiblePosition = 17
        UltraGridColumn69.Width = 109
        UltraGridColumn70.Header.VisiblePosition = 2
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 3
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.Caption = "Fecha"
        UltraGridColumn72.Header.VisiblePosition = 22
        UltraGridColumn72.Width = 129
        UltraGridColumn73.Header.VisiblePosition = 4
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 5
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 6
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 7
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 8
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 9
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 10
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 11
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 12
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 13
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 14
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 15
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.Caption = "Tipo Orden"
        UltraGridColumn85.Header.VisiblePosition = 16
        UltraGridColumn85.Width = 135
        UltraGridColumn86.Header.VisiblePosition = 18
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 19
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 20
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.Caption = "Proveedor"
        UltraGridColumn89.Header.VisiblePosition = 21
        UltraGridColumn89.Width = 286
        UltraGridColumn90.Header.VisiblePosition = 23
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 24
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 25
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 26
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 27
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 28
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 29
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 30
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 31
        UltraGridColumn98.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 32
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 33
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 34
        UltraGridColumn170.Hidden = True
        UltraGridColumn171.Header.VisiblePosition = 35
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 36
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 37
        UltraGridColumn173.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173})
        Me.griListaOrdenIngreso.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaOrdenIngreso.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaOrdenIngreso.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaOrdenIngreso.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaOrdenIngreso.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaOrdenIngreso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaOrdenIngreso.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaOrdenIngreso.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaOrdenIngreso.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Me.griListaOrdenIngreso.DisplayLayout.Override.RowAppearance = Appearance17
        Me.griListaOrdenIngreso.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griListaOrdenIngreso.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griListaOrdenIngreso.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaOrdenIngreso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaOrdenIngreso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaOrdenIngreso.Location = New System.Drawing.Point(0, 0)
        Me.griListaOrdenIngreso.Name = "griListaOrdenIngreso"
        Me.griListaOrdenIngreso.Size = New System.Drawing.Size(629, 183)
        Me.griListaOrdenIngreso.TabIndex = 4
        '
        'odOrden
        '
        UltraDataColumn199.DataType = GetType(Date)
        UltraDataColumn200.DataType = GetType(Double)
        UltraDataColumn206.DataType = GetType(Boolean)
        Me.odOrden.Band.Columns.AddRange(New Object() {UltraDataColumn194, UltraDataColumn195, UltraDataColumn196, UltraDataColumn197, UltraDataColumn198, UltraDataColumn199, UltraDataColumn200, UltraDataColumn201, UltraDataColumn202, UltraDataColumn203, UltraDataColumn204, UltraDataColumn205, UltraDataColumn206, UltraDataColumn207, UltraDataColumn208, UltraDataColumn209, UltraDataColumn210, UltraDataColumn211, UltraDataColumn212, UltraDataColumn213, UltraDataColumn214, UltraDataColumn215, UltraDataColumn216, UltraDataColumn217, UltraDataColumn218, UltraDataColumn219, UltraDataColumn220, UltraDataColumn221, UltraDataColumn222, UltraDataColumn223, UltraDataColumn224, UltraDataColumn225, UltraDataColumn226, UltraDataColumn227, UltraDataColumn228, UltraDataColumn229, UltraDataColumn230, UltraDataColumn231})
        '
        'UEGB_Ordenes
        '
        Me.UEGB_Ordenes.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UEGB_Ordenes.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UEGB_Ordenes.Dock = System.Windows.Forms.DockStyle.Right
        Me.UEGB_Ordenes.ExpandedSize = New System.Drawing.Size(623, 183)
        Me.UEGB_Ordenes.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UEGB_Ordenes.Location = New System.Drawing.Point(629, 0)
        Me.UEGB_Ordenes.Name = "UEGB_Ordenes"
        Me.UEGB_Ordenes.Size = New System.Drawing.Size(623, 183)
        Me.UEGB_Ordenes.TabIndex = 247
        Me.UEGB_Ordenes.Text = " Lista Orden's"
        Me.UEGB_Ordenes.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Agrupacion11)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Agrupacion8)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(600, 177)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'Agrupacion11
        '
        Me.Agrupacion11.Controls.Add(Me.griOrdenes)
        Me.Agrupacion11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion11.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion11.Location = New System.Drawing.Point(0, 55)
        Me.Agrupacion11.Name = "Agrupacion11"
        Me.Agrupacion11.Size = New System.Drawing.Size(600, 122)
        Me.Agrupacion11.TabIndex = 1
        Me.Agrupacion11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griOrdenes
        '
        Me.griOrdenes.DataSource = Me.odOrdenesIngreso
        UltraGridColumn99.Header.VisiblePosition = 0
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 1
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.Caption = "N° Orden"
        UltraGridColumn101.Header.VisiblePosition = 17
        UltraGridColumn101.Width = 98
        UltraGridColumn102.Header.VisiblePosition = 2
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 3
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.Caption = "Fecha"
        UltraGridColumn104.Header.VisiblePosition = 22
        UltraGridColumn104.Width = 115
        UltraGridColumn105.Header.VisiblePosition = 4
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 5
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 6
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 7
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 8
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.VisiblePosition = 9
        UltraGridColumn110.Hidden = True
        UltraGridColumn111.Header.VisiblePosition = 10
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 11
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 12
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 13
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 14
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 15
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.Caption = "Tipo Orden"
        UltraGridColumn117.Header.VisiblePosition = 16
        UltraGridColumn117.Width = 116
        UltraGridColumn118.Header.VisiblePosition = 18
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.VisiblePosition = 19
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 20
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.Caption = "Proveedor"
        UltraGridColumn121.Header.VisiblePosition = 21
        UltraGridColumn121.Width = 181
        UltraGridColumn122.Header.VisiblePosition = 23
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.Header.VisiblePosition = 24
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.Header.VisiblePosition = 25
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 26
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 27
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 28
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 29
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 30
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 31
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.Header.VisiblePosition = 32
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.Header.VisiblePosition = 33
        UltraGridColumn132.Hidden = True
        UltraGridColumn174.Header.VisiblePosition = 34
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.Header.VisiblePosition = 35
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.VisiblePosition = 36
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 37
        UltraGridColumn177.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177})
        Me.griOrdenes.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griOrdenes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenes.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griOrdenes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance18.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenes.DisplayLayout.Override.RowAppearance = Appearance18
        Me.griOrdenes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griOrdenes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griOrdenes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenes.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griOrdenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenes.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenes.Location = New System.Drawing.Point(2, 2)
        Me.griOrdenes.Name = "griOrdenes"
        Me.griOrdenes.Size = New System.Drawing.Size(596, 118)
        Me.griOrdenes.TabIndex = 4
        '
        'odOrdenesIngreso
        '
        UltraDataColumn237.DataType = GetType(Date)
        UltraDataColumn238.DataType = GetType(Double)
        UltraDataColumn244.DataType = GetType(Boolean)
        Me.odOrdenesIngreso.Band.Columns.AddRange(New Object() {UltraDataColumn232, UltraDataColumn233, UltraDataColumn234, UltraDataColumn235, UltraDataColumn236, UltraDataColumn237, UltraDataColumn238, UltraDataColumn239, UltraDataColumn240, UltraDataColumn241, UltraDataColumn242, UltraDataColumn243, UltraDataColumn244, UltraDataColumn245, UltraDataColumn246, UltraDataColumn247, UltraDataColumn248, UltraDataColumn249, UltraDataColumn250, UltraDataColumn251, UltraDataColumn252, UltraDataColumn253, UltraDataColumn254, UltraDataColumn255, UltraDataColumn256, UltraDataColumn257, UltraDataColumn258, UltraDataColumn259, UltraDataColumn260, UltraDataColumn261, UltraDataColumn262, UltraDataColumn263, UltraDataColumn264, UltraDataColumn265, UltraDataColumn266, UltraDataColumn267, UltraDataColumn268, UltraDataColumn269})
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.rFechasHasta)
        Me.Agrupacion8.Controls.Add(Me.rFechasDesde)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion8.Controls.Add(Me.cbTipoOrden)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion8.Controls.Add(Me.btnBuscarOrdenes)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion8.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(600, 55)
        Me.Agrupacion8.TabIndex = 0
        Me.Agrupacion8.Text = "Filtros"
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rFechasHasta
        '
        Me.rFechasHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rFechasHasta.Location = New System.Drawing.Point(165, 26)
        Me.rFechasHasta.Name = "rFechasHasta"
        Me.rFechasHasta.Size = New System.Drawing.Size(98, 20)
        Me.rFechasHasta.TabIndex = 342
        '
        'rFechasDesde
        '
        Me.rFechasDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rFechasDesde.Location = New System.Drawing.Point(35, 26)
        Me.rFechasDesde.Name = "rFechasDesde"
        Me.rFechasDesde.Size = New System.Drawing.Size(98, 20)
        Me.rFechasDesde.TabIndex = 341
        '
        'Etiqueta1
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance86
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(140, 27)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(20, 15)
        Me.Etiqueta1.TabIndex = 340
        Me.Etiqueta1.Text = "Al :"
        '
        'Etiqueta2
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance87
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(6, 27)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(28, 15)
        Me.Etiqueta2.TabIndex = 339
        Me.Etiqueta2.Text = "Del :"
        '
        'cbTipoOrden
        '
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.cbTipoOrden.Appearance = Appearance21
        Me.cbTipoOrden.DisplayMember = "Nombre"
        Me.cbTipoOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbTipoOrden.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbTipoOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoOrden.ForeColor = System.Drawing.Color.Black
        Me.cbTipoOrden.Location = New System.Drawing.Point(384, 25)
        Me.cbTipoOrden.Name = "cbTipoOrden"
        Me.cbTipoOrden.Size = New System.Drawing.Size(144, 21)
        Me.cbTipoOrden.TabIndex = 239
        Me.cbTipoOrden.ValueMember = "Id"
        '
        'Etiqueta14
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance88
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(320, 28)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(59, 14)
        Me.Etiqueta14.TabIndex = 238
        Me.Etiqueta14.Text = "Tipo Orden"
        '
        'btnBuscarOrdenes
        '
        Appearance89.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnBuscarOrdenes.Appearance = Appearance89
        Me.btnBuscarOrdenes.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarOrdenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarOrdenes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBuscarOrdenes.ImageList = Me.imagenes
        Me.btnBuscarOrdenes.Location = New System.Drawing.Point(542, 20)
        Me.btnBuscarOrdenes.Name = "btnBuscarOrdenes"
        Me.btnBuscarOrdenes.Size = New System.Drawing.Size(30, 31)
        Me.btnBuscarOrdenes.TabIndex = 235
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
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrBoleta)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1260, 387)
        '
        'agrBoleta
        '
        Me.agrBoleta.Controls.Add(Me.griListaBoletaCompra)
        Me.agrBoleta.Controls.Add(Me.agrMenuLista)
        Me.agrBoleta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrBoleta.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBoleta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrBoleta.Location = New System.Drawing.Point(0, 141)
        Me.agrBoleta.Name = "agrBoleta"
        Me.agrBoleta.Size = New System.Drawing.Size(1260, 246)
        Me.agrBoleta.TabIndex = 2
        Me.agrBoleta.Text = "Listado"
        Me.agrBoleta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaBoletaCompra
        '
        Me.griListaBoletaCompra.ContextMenuStrip = Me.MenuContextual2
        Me.griListaBoletaCompra.DataSource = Me.odListadoDocumentos
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaBoletaCompra.DisplayLayout.Appearance = Appearance23
        UltraGridColumn133.Header.VisiblePosition = 0
        UltraGridColumn133.Hidden = True
        UltraGridColumn134.Header.VisiblePosition = 1
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 7
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 8
        UltraGridColumn136.Hidden = True
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn137.CellAppearance = Appearance24
        UltraGridColumn137.Format = "#,###,###,##0.0000"
        UltraGridColumn137.Header.VisiblePosition = 10
        UltraGridColumn137.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn137.Width = 82
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn138.CellAppearance = Appearance25
        UltraGridColumn138.Format = "#,###,###,##0.0000"
        UltraGridColumn138.Header.Caption = "Imp. Venta"
        UltraGridColumn138.Header.VisiblePosition = 11
        UltraGridColumn138.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn138.Width = 85
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn139.CellAppearance = Appearance26
        UltraGridColumn139.Format = "#,###,###,##0.0000"
        UltraGridColumn139.Header.VisiblePosition = 12
        UltraGridColumn139.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn139.Width = 89
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn140.CellAppearance = Appearance27
        UltraGridColumn140.Header.Caption = "Tipo Cambio"
        UltraGridColumn140.Header.VisiblePosition = 14
        UltraGridColumn140.Width = 86
        UltraGridColumn141.Header.VisiblePosition = 15
        UltraGridColumn141.Hidden = True
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn142.CellAppearance = Appearance28
        UltraGridColumn142.Header.VisiblePosition = 16
        UltraGridColumn142.Hidden = True
        UltraGridColumn142.MaskInput = ""
        UltraGridColumn143.Header.VisiblePosition = 17
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.Header.VisiblePosition = 5
        UltraGridColumn145.Header.VisiblePosition = 6
        UltraGridColumn145.Hidden = True
        UltraGridColumn145.Width = 132
        UltraGridColumn146.Header.VisiblePosition = 18
        UltraGridColumn146.Hidden = True
        UltraGridColumn147.Header.VisiblePosition = 19
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.Caption = "Fecha"
        UltraGridColumn148.Header.VisiblePosition = 2
        UltraGridColumn148.Width = 82
        UltraGridColumn149.Header.VisiblePosition = 20
        UltraGridColumn149.Hidden = True
        UltraGridColumn150.Header.VisiblePosition = 21
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.Header.VisiblePosition = 22
        UltraGridColumn151.Hidden = True
        UltraGridColumn152.Header.VisiblePosition = 23
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.VisiblePosition = 24
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.Header.VisiblePosition = 25
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 26
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.Header.VisiblePosition = 27
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.Header.VisiblePosition = 28
        UltraGridColumn157.Width = 190
        UltraGridColumn158.Header.VisiblePosition = 29
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 30
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.Caption = "Estado"
        UltraGridColumn160.Header.VisiblePosition = 13
        UltraGridColumn161.Header.Caption = "Empresa"
        UltraGridColumn161.Header.VisiblePosition = 3
        UltraGridColumn161.Width = 264
        UltraGridColumn162.Header.Caption = "Nº Documento"
        UltraGridColumn162.Header.VisiblePosition = 4
        UltraGridColumn162.Width = 143
        UltraGridColumn163.Header.VisiblePosition = 31
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.VisiblePosition = 32
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.Header.VisiblePosition = 33
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 9
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 34
        UltraGridColumn167.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 35
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 36
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 37
        UltraGridColumn3.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.griListaBoletaCompra.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaBoletaCompra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaBoletaCompra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance29.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance29.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance29.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaBoletaCompra.DisplayLayout.GroupByBox.Appearance = Appearance29
        Appearance30.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaBoletaCompra.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance30
        Me.griListaBoletaCompra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaBoletaCompra.DisplayLayout.GroupByBox.Hidden = True
        Appearance31.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance31.BackColor2 = System.Drawing.SystemColors.Control
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance31.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaBoletaCompra.DisplayLayout.GroupByBox.PromptAppearance = Appearance31
        Me.griListaBoletaCompra.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaBoletaCompra.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaBoletaCompra.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaBoletaCompra.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaBoletaCompra.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaBoletaCompra.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaBoletaCompra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaBoletaCompra.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaBoletaCompra.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaBoletaCompra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Me.griListaBoletaCompra.DisplayLayout.Override.RowAppearance = Appearance32
        Me.griListaBoletaCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaBoletaCompra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaBoletaCompra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaBoletaCompra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaBoletaCompra.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaBoletaCompra.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaBoletaCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaBoletaCompra.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaBoletaCompra.Location = New System.Drawing.Point(3, 47)
        Me.griListaBoletaCompra.Name = "griListaBoletaCompra"
        Me.griListaBoletaCompra.Size = New System.Drawing.Size(1254, 196)
        Me.griListaBoletaCompra.TabIndex = 8
        Me.griListaBoletaCompra.Text = "Grilla2"
        '
        'MenuContextual2
        '
        Me.MenuContextual2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual2.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.ActualizarToolStripMenuItem2, Me.EliminarToolStripMenuItem3, Me.EnviarTesoreriaToolStripMenuItem, Me.AnularToolStripMenuItem4})
        Me.MenuContextual2.Name = "MenuContextual1"
        Me.MenuContextual2.Size = New System.Drawing.Size(163, 114)
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        Me.NuevoToolStripMenuItem1.ToolTipText = "Insertar un nuevo Requerimiento"
        '
        'ActualizarToolStripMenuItem2
        '
        Me.ActualizarToolStripMenuItem2.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem2.Name = "ActualizarToolStripMenuItem2"
        Me.ActualizarToolStripMenuItem2.Size = New System.Drawing.Size(162, 22)
        Me.ActualizarToolStripMenuItem2.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem2.ToolTipText = "Actualizar o modificar el Requerimiento seleccionado"
        '
        'EliminarToolStripMenuItem3
        '
        Me.EliminarToolStripMenuItem3.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem3.Name = "EliminarToolStripMenuItem3"
        Me.EliminarToolStripMenuItem3.Size = New System.Drawing.Size(162, 22)
        Me.EliminarToolStripMenuItem3.Text = "Eliminar"
        Me.EliminarToolStripMenuItem3.ToolTipText = "Eliminar el Requerimiento seleccionado"
        '
        'EnviarTesoreriaToolStripMenuItem
        '
        Me.EnviarTesoreriaToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.EnviarTesoreriaToolStripMenuItem.Name = "EnviarTesoreriaToolStripMenuItem"
        Me.EnviarTesoreriaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EnviarTesoreriaToolStripMenuItem.Text = "Enviar Documento"
        Me.EnviarTesoreriaToolStripMenuItem.ToolTipText = "Enviar a Tesoreria"
        '
        'AnularToolStripMenuItem4
        '
        Me.AnularToolStripMenuItem4.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.AnularToolStripMenuItem4.Name = "AnularToolStripMenuItem4"
        Me.AnularToolStripMenuItem4.Size = New System.Drawing.Size(162, 22)
        Me.AnularToolStripMenuItem4.Text = "Anular Documento"
        Me.AnularToolStripMenuItem4.Visible = False
        '
        'odListadoDocumentos
        '
        Me.odListadoDocumentos.Band.Columns.AddRange(New Object() {UltraDataColumn270, UltraDataColumn271, UltraDataColumn272, UltraDataColumn273, UltraDataColumn274, UltraDataColumn275, UltraDataColumn276, UltraDataColumn277, UltraDataColumn278, UltraDataColumn279, UltraDataColumn280, UltraDataColumn281, UltraDataColumn282, UltraDataColumn283, UltraDataColumn284, UltraDataColumn285, UltraDataColumn286, UltraDataColumn287, UltraDataColumn288, UltraDataColumn289, UltraDataColumn290, UltraDataColumn291, UltraDataColumn292, UltraDataColumn293, UltraDataColumn294, UltraDataColumn295, UltraDataColumn296, UltraDataColumn297, UltraDataColumn298, UltraDataColumn299, UltraDataColumn300, UltraDataColumn301, UltraDataColumn302, UltraDataColumn303, UltraDataColumn304, UltraDataColumn305, UltraDataColumn306, UltraDataColumn307})
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnAnular)
        Me.agrMenuLista.Controls.Add(Me.cmdEnviaTesoreria)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 17)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1254, 30)
        Me.agrMenuLista.TabIndex = 248
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnAnular
        '
        Appearance33.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance33.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnAnular.Appearance = Appearance33
        Me.btnAnular.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnular.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnular.Enabled = False
        Me.btnAnular.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.ForeColor = System.Drawing.Color.Black
        Me.btnAnular.Location = New System.Drawing.Point(93, 3)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(90, 24)
        Me.btnAnular.TabIndex = 317
        Me.btnAnular.Text = "Anular Doc."
        Me.btnAnular.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.btnAnular.Visible = False
        '
        'cmdEnviaTesoreria
        '
        Appearance90.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance90.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.cmdEnviaTesoreria.Appearance = Appearance90
        Me.cmdEnviaTesoreria.BackColorInternal = System.Drawing.Color.Transparent
        Me.cmdEnviaTesoreria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdEnviaTesoreria.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdEnviaTesoreria.Enabled = False
        Me.cmdEnviaTesoreria.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnviaTesoreria.ForeColor = System.Drawing.Color.Black
        Me.cmdEnviaTesoreria.Location = New System.Drawing.Point(3, 3)
        Me.cmdEnviaTesoreria.Name = "cmdEnviaTesoreria"
        Me.cmdEnviaTesoreria.Size = New System.Drawing.Size(90, 24)
        Me.cmdEnviaTesoreria.TabIndex = 328
        Me.cmdEnviaTesoreria.Text = "Enviar Doc."
        Me.cmdEnviaTesoreria.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.gbDatosAdicionales)
        Me.Agrupacion1.Controls.Add(Me.gbNroDoc)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion1.Controls.Add(Me.rbNroDoc)
        Me.Agrupacion1.Controls.Add(Me.rbDatosAdicionales)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion1.Controls.Add(Me.txtSerieD)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1260, 141)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Búsqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.Controls.Add(Me.cboProveedor2)
        Me.gbDatosAdicionales.Controls.Add(Me.UltraLabel4)
        Me.gbDatosAdicionales.Controls.Add(Me.rfFechaDocHasta)
        Me.gbDatosAdicionales.Controls.Add(Me.cboEstadoBoleta)
        Me.gbDatosAdicionales.Controls.Add(Me.rfFechaDocDesde)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta21)
        Me.gbDatosAdicionales.Controls.Add(Me.cboMaterialServicio)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta3)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta7)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta11)
        Me.gbDatosAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosAdicionales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(6, 38)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(373, 99)
        Me.gbDatosAdicionales.TabIndex = 332
        Me.gbDatosAdicionales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboProveedor2
        '
        Me.cboProveedor2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedor2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedor2.CheckedListSettings.ListSeparator = ","
        Me.cboProveedor2.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboProveedor2.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboProveedor2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedor2.DropDownWidth = 400
        Me.cboProveedor2.Location = New System.Drawing.Point(69, 66)
        Me.cboProveedor2.Name = "cboProveedor2"
        Me.cboProveedor2.Size = New System.Drawing.Size(291, 22)
        Me.cboProveedor2.TabIndex = 357
        '
        'UltraLabel4
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Appearance91.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance91
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 71)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel4.TabIndex = 356
        Me.UltraLabel4.Text = "Proveedor:"
        '
        'rfFechaDocHasta
        '
        Me.rfFechaDocHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rfFechaDocHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaDocHasta.Location = New System.Drawing.Point(244, 15)
        Me.rfFechaDocHasta.Name = "rfFechaDocHasta"
        Me.rfFechaDocHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaDocHasta.TabIndex = 338
        '
        'cboEstadoBoleta
        '
        Appearance37.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoBoleta.Appearance = Appearance37
        Me.cboEstadoBoleta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance38.Image = 7
        EditorButton1.Appearance = Appearance38
        Me.cboEstadoBoleta.ButtonsRight.Add(EditorButton1)
        Me.cboEstadoBoleta.DisplayMember = "Nombre"
        Me.cboEstadoBoleta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoBoleta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoBoleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoBoleta.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoBoleta.Location = New System.Drawing.Point(244, 39)
        Me.cboEstadoBoleta.Name = "cboEstadoBoleta"
        Me.cboEstadoBoleta.Size = New System.Drawing.Size(116, 21)
        Me.cboEstadoBoleta.TabIndex = 305
        Me.cboEstadoBoleta.ValueMember = "Id"
        '
        'rfFechaDocDesde
        '
        Me.rfFechaDocDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rfFechaDocDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaDocDesde.Location = New System.Drawing.Point(71, 13)
        Me.rfFechaDocDesde.Name = "rfFechaDocDesde"
        Me.rfFechaDocDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaDocDesde.TabIndex = 337
        '
        'Etiqueta21
        '
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance92
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(202, 18)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta21.TabIndex = 336
        Me.Etiqueta21.Text = "Hasta :"
        '
        'cboMaterialServicio
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.cboMaterialServicio.Appearance = Appearance40
        Me.cboMaterialServicio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance41.Image = 7
        EditorButton2.Appearance = Appearance41
        Me.cboMaterialServicio.ButtonsRight.Add(EditorButton2)
        Me.cboMaterialServicio.DisplayMember = "Nombre"
        Me.cboMaterialServicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMaterialServicio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMaterialServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterialServicio.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "M"
        ValueListItem1.DisplayText = "MATERIAL"
        ValueListItem2.DataValue = "S"
        ValueListItem2.DisplayText = "SERVICIO"
        Me.cboMaterialServicio.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.cboMaterialServicio.Location = New System.Drawing.Point(71, 39)
        Me.cboMaterialServicio.Name = "cboMaterialServicio"
        Me.cboMaterialServicio.Size = New System.Drawing.Size(123, 21)
        Me.cboMaterialServicio.TabIndex = 311
        Me.cboMaterialServicio.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance93.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance93
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(26, 15)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta3.TabIndex = 335
        Me.Etiqueta3.Text = "Desde :"
        '
        'Etiqueta7
        '
        Appearance94.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance94
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(201, 42)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta7.TabIndex = 302
        Me.Etiqueta7.Text = "Estado:"
        '
        'Etiqueta11
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance95
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(19, 42)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta11.TabIndex = 307
        Me.Etiqueta11.Text = "Mat./Ser:"
        '
        'gbNroDoc
        '
        Me.gbNroDoc.Controls.Add(Me.txtSerie)
        Me.gbNroDoc.Controls.Add(Me.txtNumero)
        Me.gbNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNroDoc.ForeColor = System.Drawing.Color.Black
        Me.gbNroDoc.Location = New System.Drawing.Point(388, 38)
        Me.gbNroDoc.Name = "gbNroDoc"
        Me.gbNroDoc.Size = New System.Drawing.Size(200, 32)
        Me.gbNroDoc.TabIndex = 331
        Me.gbNroDoc.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(25, 5)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(42, 21)
        Me.txtSerie.TabIndex = 12
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(73, 5)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(102, 21)
        Me.txtNumero.TabIndex = 13
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion5.Controls.Add(Me.etiTerminada)
        Me.Agrupacion5.Controls.Add(Me.ColoresEmitido)
        Me.Agrupacion5.Controls.Add(Me.etiEnviado)
        Me.Agrupacion5.Controls.Add(Me.ColoresAnulado)
        Me.Agrupacion5.Controls.Add(Me.etiGenerada)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(386, 75)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(202, 62)
        Me.Agrupacion5.TabIndex = 330
        Me.Agrupacion5.Text = "Estados"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Location = New System.Drawing.Point(22, 36)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresGenerado.TabIndex = 8
        Me.ColoresGenerado.Text = "Control"
        '
        'etiTerminada
        '
        Appearance96.BackColor = System.Drawing.Color.Transparent
        Appearance96.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTerminada.Appearance = Appearance96
        Me.etiTerminada.AutoSize = True
        Me.etiTerminada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTerminada.ForeColor = System.Drawing.Color.Black
        Me.etiTerminada.Location = New System.Drawing.Point(145, 19)
        Me.etiTerminada.Name = "etiTerminada"
        Me.etiTerminada.Size = New System.Drawing.Size(43, 15)
        Me.etiTerminada.TabIndex = 5
        Me.etiTerminada.Text = "Anulado"
        '
        'ColoresEmitido
        '
        Me.ColoresEmitido.Color = System.Drawing.Color.Empty
        Me.ColoresEmitido.Location = New System.Drawing.Point(81, 36)
        Me.ColoresEmitido.Name = "ColoresEmitido"
        Me.ColoresEmitido.Size = New System.Drawing.Size(43, 21)
        Me.ColoresEmitido.TabIndex = 2
        '
        'etiEnviado
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnviado.Appearance = Appearance97
        Me.etiEnviado.AutoSize = True
        Me.etiEnviado.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnviado.ForeColor = System.Drawing.Color.Black
        Me.etiEnviado.Location = New System.Drawing.Point(83, 19)
        Me.etiEnviado.Name = "etiEnviado"
        Me.etiEnviado.Size = New System.Drawing.Size(42, 15)
        Me.etiEnviado.TabIndex = 4
        Me.etiEnviado.Text = "Enviado"
        '
        'ColoresAnulado
        '
        Me.ColoresAnulado.Color = System.Drawing.Color.Empty
        Me.ColoresAnulado.Location = New System.Drawing.Point(141, 36)
        Me.ColoresAnulado.Name = "ColoresAnulado"
        Me.ColoresAnulado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresAnulado.TabIndex = 1
        '
        'etiGenerada
        '
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Appearance98.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance98
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(19, 19)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(51, 15)
        Me.etiGenerada.TabIndex = 3
        Me.etiGenerada.Text = "Generada"
        '
        'rbNroDoc
        '
        Me.rbNroDoc.AutoSize = True
        Me.rbNroDoc.BackColor = System.Drawing.Color.Transparent
        Me.rbNroDoc.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNroDoc.Location = New System.Drawing.Point(388, 21)
        Me.rbNroDoc.Name = "rbNroDoc"
        Me.rbNroDoc.Size = New System.Drawing.Size(89, 17)
        Me.rbNroDoc.TabIndex = 1
        Me.rbNroDoc.TabStop = True
        Me.rbNroDoc.Text = "N° de Boleta:"
        Me.rbNroDoc.UseVisualStyleBackColor = False
        '
        'rbDatosAdicionales
        '
        Me.rbDatosAdicionales.AutoSize = True
        Me.rbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rbDatosAdicionales.Checked = True
        Me.rbDatosAdicionales.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDatosAdicionales.ForeColor = System.Drawing.Color.Navy
        Me.rbDatosAdicionales.Location = New System.Drawing.Point(6, 21)
        Me.rbDatosAdicionales.Name = "rbDatosAdicionales"
        Me.rbDatosAdicionales.Size = New System.Drawing.Size(113, 17)
        Me.rbDatosAdicionales.TabIndex = 0
        Me.rbDatosAdicionales.TabStop = True
        Me.rbDatosAdicionales.Text = "Datos Adicionales:"
        Me.rbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'Etiqueta4
        '
        Appearance99.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance99
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(847, 49)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(32, 15)
        Me.Etiqueta4.TabIndex = 323
        Me.Etiqueta4.Text = "Serie:"
        Me.Etiqueta4.Visible = False
        '
        'txtSerieD
        '
        Me.txtSerieD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieD.Location = New System.Drawing.Point(882, 46)
        Me.txtSerieD.MaxLength = 4
        Me.txtSerieD.Name = "txtSerieD"
        Me.txtSerieD.Size = New System.Drawing.Size(66, 21)
        Me.txtSerieD.TabIndex = 322
        Me.txtSerieD.Visible = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1260, 387)
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.ficDetalleOCMateriales)
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
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 136)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1260, 251)
        Me.Agrupacion4.TabIndex = 247
        Me.Agrupacion4.Tag = " "
        Me.Agrupacion4.Text = "Detalle"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDetalleOCMateriales
        '
        Me.ficDetalleOCMateriales.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.ficDetalleOCMateriales.Controls.Add(Me.UltraTabPageControl12)
        Me.ficDetalleOCMateriales.Controls.Add(Me.UltraTabPageControl13)
        Me.ficDetalleOCMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalleOCMateriales.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetalleOCMateriales.Location = New System.Drawing.Point(3, 42)
        Me.ficDetalleOCMateriales.Name = "ficDetalleOCMateriales"
        Me.ficDetalleOCMateriales.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.ficDetalleOCMateriales.Size = New System.Drawing.Size(1254, 206)
        Me.ficDetalleOCMateriales.TabIndex = 0
        UltraTab12.TabPage = Me.UltraTabPageControl12
        UltraTab12.Text = "Detalle - Boleta"
        UltraTab13.TabPage = Me.UltraTabPageControl13
        UltraTab13.Text = "Detalle Asociación"
        Me.ficDetalleOCMateriales.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab12, UltraTab13})
        Me.ficDetalleOCMateriales.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(1252, 183)
        '
        'UltraToolbarsDockArea13
        '
        Me.UltraToolbarsDockArea13.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea13.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea13.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea13.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea13.Name = "UltraToolbarsDockArea13"
        Me.UltraToolbarsDockArea13.Size = New System.Drawing.Size(1254, 26)
        Me.UltraToolbarsDockArea13.ToolbarsManager = Me.MenuDetalle
        '
        'MenuDetalle
        '
        Appearance113.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MenuDetalle.Appearance = Appearance113
        Me.MenuDetalle.DesignerFlags = 1
        Me.MenuDetalle.DockWithinContainer = Me
        Me.MenuDetalle.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.MenuDetalle.ImageListLarge = Me.imagenes
        Me.MenuDetalle.ImageListSmall = Me.imagenes
        Me.MenuDetalle.MdiMergeable = False
        Me.MenuDetalle.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        Me.MenuDetalle.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 0
        UltraToolbar2.FloatingLocation = New System.Drawing.Point(120, 464)
        UltraToolbar2.FloatingSize = New System.Drawing.Size(227, 48)
        UltraToolbar2.IsMainMenuBar = True
        UltraToolbar2.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool5, ButtonTool8})
        UltraToolbar2.Text = "utMenuDetalle"
        Me.MenuDetalle.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar2})
        Appearance114.Image = 7
        ButtonTool11.SharedPropsInternal.AppearancesSmall.Appearance = Appearance114
        ButtonTool11.SharedPropsInternal.Caption = "Importar"
        ButtonTool11.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance115.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool20.SharedPropsInternal.AppearancesSmall.Appearance = Appearance115
        ButtonTool20.SharedPropsInternal.Caption = "Editar"
        ButtonTool20.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance116.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool21.SharedPropsInternal.AppearancesSmall.Appearance = Appearance116
        ButtonTool21.SharedPropsInternal.Caption = "Quitar"
        ButtonTool21.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance117.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        ButtonTool22.SharedPropsInternal.AppearancesSmall.Appearance = Appearance117
        ButtonTool22.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool22.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance118.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool23.SharedPropsInternal.AppearancesSmall.Appearance = Appearance118
        ButtonTool23.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool23.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance119.Image = 6
        ButtonTool24.SharedPropsInternal.AppearancesSmall.Appearance = Appearance119
        ButtonTool24.SharedPropsInternal.Caption = "Listar"
        ButtonTool24.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance120.Image = 2
        ButtonTool25.SharedPropsInternal.AppearancesSmall.Appearance = Appearance120
        ButtonTool25.SharedPropsInternal.Caption = "Generar OI"
        ButtonTool25.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance121.Image = 3
        ButtonTool26.SharedPropsInternal.AppearancesSmall.Appearance = Appearance121
        ButtonTool26.SharedPropsInternal.Caption = "Ejecutar OI"
        ButtonTool26.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance122.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool27.SharedPropsInternal.AppearancesSmall.Appearance = Appearance122
        ButtonTool27.SharedPropsInternal.Caption = "Importar"
        ButtonTool27.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance123.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool28.SharedPropsInternal.AppearancesSmall.Appearance = Appearance123
        ButtonTool28.SharedPropsInternal.Caption = "Agregar"
        ButtonTool28.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance124.Image = 2
        ButtonTool29.SharedPropsInternal.AppearancesSmall.Appearance = Appearance124
        ButtonTool29.SharedPropsInternal.Caption = "Generar documento"
        ButtonTool29.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.MenuDetalle.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool11, ButtonTool20, ButtonTool21, ButtonTool22, ButtonTool23, ButtonTool24, ButtonTool25, ButtonTool26, ButtonTool27, ButtonTool28, ButtonTool29})
        '
        'UltraToolbarsDockArea14
        '
        Me.UltraToolbarsDockArea14.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea14.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea14.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea14.Location = New System.Drawing.Point(3, 248)
        Me.UltraToolbarsDockArea14.Name = "UltraToolbarsDockArea14"
        Me.UltraToolbarsDockArea14.Size = New System.Drawing.Size(1254, 0)
        Me.UltraToolbarsDockArea14.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea17
        '
        Me.UltraToolbarsDockArea17.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea17.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea17.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea17.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea17.Name = "UltraToolbarsDockArea17"
        Me.UltraToolbarsDockArea17.Size = New System.Drawing.Size(0, 232)
        Me.UltraToolbarsDockArea17.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea18
        '
        Me.UltraToolbarsDockArea18.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea18.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea18.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea18.Location = New System.Drawing.Point(1257, 16)
        Me.UltraToolbarsDockArea18.Name = "UltraToolbarsDockArea18"
        Me.UltraToolbarsDockArea18.Size = New System.Drawing.Size(0, 232)
        Me.UltraToolbarsDockArea18.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea15
        '
        Me.UltraToolbarsDockArea15.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea15.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea15.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea15.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea15.Name = "UltraToolbarsDockArea15"
        Me.UltraToolbarsDockArea15.Size = New System.Drawing.Size(1254, 0)
        '
        'UltraToolbarsDockArea16
        '
        Me.UltraToolbarsDockArea16.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea16.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea16.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea16.Location = New System.Drawing.Point(3, 248)
        Me.UltraToolbarsDockArea16.Name = "UltraToolbarsDockArea16"
        Me.UltraToolbarsDockArea16.Size = New System.Drawing.Size(1254, 0)
        '
        'UltraToolbarsDockArea20
        '
        Me.UltraToolbarsDockArea20.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea20.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea20.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea20.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea20.Name = "UltraToolbarsDockArea20"
        Me.UltraToolbarsDockArea20.Size = New System.Drawing.Size(0, 232)
        '
        'UltraToolbarsDockArea21
        '
        Me.UltraToolbarsDockArea21.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea21.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea21.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea21.Location = New System.Drawing.Point(1257, 16)
        Me.UltraToolbarsDockArea21.Name = "UltraToolbarsDockArea21"
        Me.UltraToolbarsDockArea21.Size = New System.Drawing.Size(0, 232)
        '
        'UltraToolbarsDockArea9
        '
        Me.UltraToolbarsDockArea9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea9.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea9.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea9.Name = "UltraToolbarsDockArea9"
        Me.UltraToolbarsDockArea9.Size = New System.Drawing.Size(1254, 0)
        '
        'UltraToolbarsDockArea10
        '
        Me.UltraToolbarsDockArea10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea10.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea10.Location = New System.Drawing.Point(3, 248)
        Me.UltraToolbarsDockArea10.Name = "UltraToolbarsDockArea10"
        Me.UltraToolbarsDockArea10.Size = New System.Drawing.Size(1254, 0)
        '
        'UltraToolbarsDockArea11
        '
        Me.UltraToolbarsDockArea11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea11.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea11.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea11.Name = "UltraToolbarsDockArea11"
        Me.UltraToolbarsDockArea11.Size = New System.Drawing.Size(0, 232)
        '
        'UltraToolbarsDockArea12
        '
        Me.UltraToolbarsDockArea12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea12.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea12.Location = New System.Drawing.Point(1257, 16)
        Me.UltraToolbarsDockArea12.Name = "UltraToolbarsDockArea12"
        Me.UltraToolbarsDockArea12.Size = New System.Drawing.Size(0, 232)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.chk_CajaChica)
        Me.Agrupacion2.Controls.Add(Me.fecFechaActual)
        Me.Agrupacion2.Controls.Add(Me.chkRuc)
        Me.Agrupacion2.Controls.Add(Me.cboProveedor)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion2.Controls.Add(Me.txtEstado)
        Me.Agrupacion2.Controls.Add(Me.lbl_etiqueta)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel22)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion2.Controls.Add(Me.txtEmpresa)
        Me.Agrupacion2.Controls.Add(Me.lbNumeroOrden)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel6)
        Me.Agrupacion2.Controls.Add(Me.txtTc)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel7)
        Me.Agrupacion2.Controls.Add(Me.cboTipoPago)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion2.Controls.Add(Me.cboMoneda)
        Me.Agrupacion2.Controls.Add(Me.cboEstadoBoletaM)
        Me.Agrupacion2.Controls.Add(Me.txtPorcenIGV)
        Me.Agrupacion2.Controls.Add(Me.txtSerieM)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel11)
        Me.Agrupacion2.Controls.Add(Me.txtNumeroM)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion2.Controls.Add(Me.agrAsociacion)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1260, 136)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos Generales"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chk_CajaChica
        '
        Appearance100.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chk_CajaChica.Appearance = Appearance100
        Me.chk_CajaChica.BackColor = System.Drawing.Color.Transparent
        Me.chk_CajaChica.BackColorInternal = System.Drawing.Color.Transparent
        Me.chk_CajaChica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_CajaChica.ForeColor = System.Drawing.Color.Black
        Me.chk_CajaChica.Location = New System.Drawing.Point(555, 104)
        Me.chk_CajaChica.Name = "chk_CajaChica"
        Me.chk_CajaChica.Size = New System.Drawing.Size(92, 20)
        Me.chk_CajaChica.TabIndex = 358
        Me.chk_CajaChica.Text = "Caja Chica"
        '
        'fecFechaActual
        '
        Me.fecFechaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaActual.Location = New System.Drawing.Point(66, 72)
        Me.fecFechaActual.Name = "fecFechaActual"
        Me.fecFechaActual.Size = New System.Drawing.Size(98, 20)
        Me.fecFechaActual.TabIndex = 357
        '
        'chkRuc
        '
        Appearance101.ForeColor = System.Drawing.Color.Navy
        Me.chkRuc.Appearance = Appearance101
        Me.chkRuc.BackColor = System.Drawing.Color.Transparent
        Me.chkRuc.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRuc.ForeColor = System.Drawing.Color.Black
        Me.chkRuc.Location = New System.Drawing.Point(362, 24)
        Me.chkRuc.Name = "chkRuc"
        Me.chkRuc.Size = New System.Drawing.Size(44, 20)
        Me.chkRuc.TabIndex = 356
        Me.chkRuc.Text = "Ruc"
        '
        'cboProveedor
        '
        Me.cboProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedor.CheckedListSettings.ListSeparator = ","
        Me.cboProveedor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedor.DropDownWidth = 400
        Me.cboProveedor.Location = New System.Drawing.Point(67, 21)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(291, 23)
        Me.cboProveedor.TabIndex = 355
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.txtTotal)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel13)
        Me.Agrupacion3.Controls.Add(Me.txtSubTotal)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel14)
        Me.Agrupacion3.Controls.Add(Me.txtIGV)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel15)
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(5, 96)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(544, 35)
        Me.Agrupacion3.TabIndex = 353
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtTotal
        '
        Appearance49.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Appearance = Appearance49
        Me.txtTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(377, 7)
        Me.txtTotal.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NullText = "0.00"
        Me.txtTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(123, 21)
        Me.txtTotal.TabIndex = 288
        '
        'UltraLabel13
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.ForeColor = System.Drawing.Color.Navy
        Appearance50.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance50
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(6, 12)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(49, 15)
        Me.UltraLabel13.TabIndex = 268
        Me.UltraLabel13.Text = "Subtotal:"
        '
        'txtSubTotal
        '
        Appearance51.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Appearance = Appearance51
        Me.txtSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Location = New System.Drawing.Point(55, 8)
        Me.txtSubTotal.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.NullText = "0.00"
        Me.txtSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(126, 21)
        Me.txtSubTotal.TabIndex = 289
        '
        'UltraLabel14
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Appearance52.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance52
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(189, 11)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(27, 15)
        Me.UltraLabel14.TabIndex = 270
        Me.UltraLabel14.Text = "IGV:"
        '
        'txtIGV
        '
        Appearance53.ForeColor = System.Drawing.Color.Black
        Me.txtIGV.Appearance = Appearance53
        Me.txtIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.ForeColor = System.Drawing.Color.Black
        Me.txtIGV.Location = New System.Drawing.Point(216, 7)
        Me.txtIGV.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.NullText = "0.00"
        Me.txtIGV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtIGV.ReadOnly = True
        Me.txtIGV.Size = New System.Drawing.Size(123, 21)
        Me.txtIGV.TabIndex = 287
        '
        'UltraLabel15
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Appearance54.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance54
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(343, 11)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel15.TabIndex = 272
        Me.UltraLabel15.Text = "Total:"
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(221, 71)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(186, 21)
        Me.txtEstado.TabIndex = 345
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance102.BackColor = System.Drawing.Color.Transparent
        Appearance102.ForeColor = System.Drawing.Color.Red
        Me.lbl_etiqueta.Appearance = Appearance102
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_etiqueta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_etiqueta.Location = New System.Drawing.Point(1148, 27)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(50, 15)
        Me.lbl_etiqueta.TabIndex = 251
        Me.lbl_etiqueta.Text = "Etiqueta"
        Me.lbl_etiqueta.Visible = False
        '
        'UltraLabel22
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Appearance103.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance103
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(6, 26)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel22.TabIndex = 234
        Me.UltraLabel22.Text = "Proveedor:"
        '
        'UltraLabel1
        '
        Appearance104.BackColor = System.Drawing.Color.Transparent
        Appearance104.ForeColor = System.Drawing.Color.Navy
        Appearance104.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance104
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(25, 73)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel1.TabIndex = 237
        Me.UltraLabel1.Text = "Fecha:"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEmpresa.Enabled = False
        Me.txtEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.Location = New System.Drawing.Point(66, 47)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(341, 21)
        Me.txtEmpresa.TabIndex = 243
        '
        'lbNumeroOrden
        '
        Appearance105.BackColor = System.Drawing.Color.Transparent
        Appearance105.ForeColor = System.Drawing.Color.Navy
        Appearance105.TextVAlignAsString = "Middle"
        Me.lbNumeroOrden.Appearance = Appearance105
        Me.lbNumeroOrden.AutoSize = True
        Me.lbNumeroOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumeroOrden.Location = New System.Drawing.Point(14, 48)
        Me.lbNumeroOrden.Name = "lbNumeroOrden"
        Me.lbNumeroOrden.Size = New System.Drawing.Size(51, 15)
        Me.lbNumeroOrden.TabIndex = 244
        Me.lbNumeroOrden.Text = "Empresa:"
        '
        'UltraLabel3
        '
        Appearance106.BackColor = System.Drawing.Color.Transparent
        Appearance106.ForeColor = System.Drawing.Color.Navy
        Appearance106.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance106
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(450, 48)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(58, 15)
        Me.UltraLabel3.TabIndex = 246
        Me.UltraLabel3.Text = "Tipo Pago:"
        '
        'UltraLabel6
        '
        Appearance107.BackColor = System.Drawing.Color.Transparent
        Appearance107.ForeColor = System.Drawing.Color.Navy
        Appearance107.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance107
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(460, 72)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel6.TabIndex = 252
        Me.UltraLabel6.Text = "Moneda:"
        '
        'txtTc
        '
        Me.txtTc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTc.Location = New System.Drawing.Point(685, 71)
        Me.txtTc.Name = "txtTc"
        Me.txtTc.ReadOnly = True
        Me.txtTc.Size = New System.Drawing.Size(53, 21)
        Me.txtTc.TabIndex = 254
        '
        'UltraLabel7
        '
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Appearance108.ForeColor = System.Drawing.Color.Navy
        Appearance108.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance108
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(654, 73)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(25, 15)
        Me.UltraLabel7.TabIndex = 255
        Me.UltraLabel7.Text = "T.C:"
        '
        'cboTipoPago
        '
        Appearance76.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance76
        Me.cboTipoPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance77.Image = 7
        EditorButton3.Appearance = Appearance77
        Me.cboTipoPago.ButtonsRight.Add(EditorButton3)
        Me.cboTipoPago.DisplayMember = "Nombre"
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        ValueListItem5.DataValue = "M"
        ValueListItem5.DisplayText = "Materiales"
        ValueListItem6.DataValue = "S"
        ValueListItem6.DisplayText = "Servicios"
        Me.cboTipoPago.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
        Me.cboTipoPago.Location = New System.Drawing.Point(509, 47)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(229, 21)
        Me.cboTipoPago.TabIndex = 280
        Me.cboTipoPago.ValueMember = "Id"
        '
        'Etiqueta10
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance109
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(175, 74)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta10.TabIndex = 332
        Me.Etiqueta10.Text = "Estado:"
        '
        'cboMoneda
        '
        Appearance79.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance79
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance80.Image = 7
        EditorButton4.Appearance = Appearance80
        Me.cboMoneda.ButtonsRight.Add(EditorButton4)
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(509, 71)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.ReadOnly = True
        Me.cboMoneda.Size = New System.Drawing.Size(138, 21)
        Me.cboMoneda.TabIndex = 281
        Me.cboMoneda.ValueMember = "Id"
        '
        'cboEstadoBoletaM
        '
        Appearance81.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoBoletaM.Appearance = Appearance81
        Me.cboEstadoBoletaM.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance82.Image = 7
        EditorButton5.Appearance = Appearance82
        Me.cboEstadoBoletaM.ButtonsRight.Add(EditorButton5)
        Me.cboEstadoBoletaM.DisplayMember = "Nombre"
        Me.cboEstadoBoletaM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoBoletaM.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoBoletaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoBoletaM.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoBoletaM.Location = New System.Drawing.Point(959, 28)
        Me.cboEstadoBoletaM.Name = "cboEstadoBoletaM"
        Me.cboEstadoBoletaM.Size = New System.Drawing.Size(184, 21)
        Me.cboEstadoBoletaM.TabIndex = 333
        Me.cboEstadoBoletaM.ValueMember = "Id"
        Me.cboEstadoBoletaM.Visible = False
        '
        'txtPorcenIGV
        '
        Me.txtPorcenIGV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcenIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPorcenIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcenIGV.Location = New System.Drawing.Point(685, 24)
        Me.txtPorcenIGV.Name = "txtPorcenIGV"
        Me.txtPorcenIGV.ReadOnly = True
        Me.txtPorcenIGV.Size = New System.Drawing.Size(53, 21)
        Me.txtPorcenIGV.TabIndex = 285
        '
        'txtSerieM
        '
        Me.txtSerieM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieM.Location = New System.Drawing.Point(509, 24)
        Me.txtSerieM.MaxLength = 4
        Me.txtSerieM.Name = "txtSerieM"
        Me.txtSerieM.Size = New System.Drawing.Size(42, 21)
        Me.txtSerieM.TabIndex = 331
        '
        'UltraLabel11
        '
        Appearance110.BackColor = System.Drawing.Color.Transparent
        Appearance110.ForeColor = System.Drawing.Color.Navy
        Appearance110.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance110
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(658, 25)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(27, 15)
        Me.UltraLabel11.TabIndex = 286
        Me.UltraLabel11.Text = "IGV:"
        '
        'txtNumeroM
        '
        Me.txtNumeroM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroM.Location = New System.Drawing.Point(555, 24)
        Me.txtNumeroM.MaxLength = 10
        Me.txtNumeroM.Name = "txtNumeroM"
        Me.txtNumeroM.Size = New System.Drawing.Size(102, 21)
        Me.txtNumeroM.TabIndex = 330
        '
        'UltraLabel2
        '
        Appearance111.BackColor = System.Drawing.Color.Transparent
        Appearance111.ForeColor = System.Drawing.Color.Navy
        Appearance111.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance111
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(482, 25)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(25, 15)
        Me.UltraLabel2.TabIndex = 320
        Me.UltraLabel2.Text = "Nº :"
        '
        'agrAsociacion
        '
        Appearance112.BackColor = System.Drawing.Color.Transparent
        Me.agrAsociacion.Appearance = Appearance112
        Me.agrAsociacion.Controls.Add(Me.rbAsoDoc)
        Me.agrAsociacion.Controls.Add(Me.rbAsoOrd)
        Me.agrAsociacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrAsociacion.ForeColor = System.Drawing.Color.Black
        Me.agrAsociacion.Location = New System.Drawing.Point(744, 89)
        Me.agrAsociacion.Name = "agrAsociacion"
        Me.agrAsociacion.Size = New System.Drawing.Size(184, 41)
        Me.agrAsociacion.TabIndex = 354
        Me.agrAsociacion.Text = "Asociar"
        Me.agrAsociacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        Me.agrAsociacion.Visible = False
        '
        'rbAsoDoc
        '
        Me.rbAsoDoc.AutoSize = True
        Me.rbAsoDoc.Checked = True
        Me.rbAsoDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAsoDoc.ForeColor = System.Drawing.Color.Navy
        Me.rbAsoDoc.Location = New System.Drawing.Point(6, 19)
        Me.rbAsoDoc.Name = "rbAsoDoc"
        Me.rbAsoDoc.Size = New System.Drawing.Size(79, 17)
        Me.rbAsoDoc.TabIndex = 0
        Me.rbAsoDoc.TabStop = True
        Me.rbAsoDoc.Text = "Documento"
        Me.rbAsoDoc.UseVisualStyleBackColor = True
        '
        'rbAsoOrd
        '
        Me.rbAsoOrd.AutoSize = True
        Me.rbAsoOrd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAsoOrd.ForeColor = System.Drawing.Color.Navy
        Me.rbAsoOrd.Location = New System.Drawing.Point(101, 19)
        Me.rbAsoOrd.Name = "rbAsoOrd"
        Me.rbAsoOrd.Size = New System.Drawing.Size(55, 17)
        Me.rbAsoOrd.TabIndex = 1
        Me.rbAsoOrd.TabStop = True
        Me.rbAsoOrd.Text = "Orden"
        Me.rbAsoOrd.UseVisualStyleBackColor = True
        '
        'odMaterial
        '
        UltraDataColumn308.DataType = GetType(Boolean)
        UltraDataColumn327.DefaultValue = "False"
        UltraDataColumn329.DataType = GetType(Boolean)
        Me.odMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn308, UltraDataColumn309, UltraDataColumn310, UltraDataColumn311, UltraDataColumn312, UltraDataColumn313, UltraDataColumn314, UltraDataColumn315, UltraDataColumn316, UltraDataColumn317, UltraDataColumn318, UltraDataColumn319, UltraDataColumn320, UltraDataColumn321, UltraDataColumn322, UltraDataColumn323, UltraDataColumn324, UltraDataColumn325, UltraDataColumn326, UltraDataColumn327, UltraDataColumn328, UltraDataColumn329, UltraDataColumn330, UltraDataColumn331, UltraDataColumn332, UltraDataColumn333, UltraDataColumn334, UltraDataColumn335, UltraDataColumn336})
        '
        'ficBoletaCompra
        '
        Me.ficBoletaCompra.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficBoletaCompra.Controls.Add(Me.UltraTabPageControl1)
        Me.ficBoletaCompra.Controls.Add(Me.UltraTabPageControl2)
        Me.ficBoletaCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficBoletaCompra.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficBoletaCompra.Location = New System.Drawing.Point(0, 0)
        Me.ficBoletaCompra.Name = "ficBoletaCompra"
        Me.ficBoletaCompra.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficBoletaCompra.Size = New System.Drawing.Size(1262, 410)
        Me.ficBoletaCompra.TabIndex = 4
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficBoletaCompra.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficBoletaCompra.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1260, 387)
        '
        'frm_BoletaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1262, 410)
        Me.Controls.Add(Me.ficBoletaCompra)
        Me.Name = "frm_BoletaCompra"
        Me.Text = "Boleta Compra"
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        CType(Me.griListaDetalleBoleta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odDetalleDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl13.ResumeLayout(False)
        CType(Me.griListaOrdenIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UEGB_Ordenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UEGB_Ordenes.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion11.ResumeLayout(False)
        CType(Me.griOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenesIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        Me.Agrupacion8.PerformLayout()
        CType(Me.cbTipoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrBoleta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBoleta.ResumeLayout(False)
        CType(Me.griListaBoletaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual2.ResumeLayout(False)
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.cboProveedor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoBoleta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaterialServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbNroDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNroDoc.ResumeLayout(False)
        Me.gbNroDoc.PerformLayout()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresEmitido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.ficDetalleOCMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalleOCMateriales.ResumeLayout(False)
        CType(Me.MenuDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.chk_CajaChica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoBoletaM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcenIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrAsociacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrAsociacion.ResumeLayout(False)
        Me.agrAsociacion.PerformLayout()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficBoletaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficBoletaCompra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficBoletaCompra As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBoleta As ISL.Controles.Agrupacion
    Friend WithEvents griListaBoletaCompra As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents rbNroDoc As System.Windows.Forms.RadioButton
    Friend WithEvents rbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstadoBoleta As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerieD As ISL.Controles.Texto
    Friend WithEvents cboMaterialServicio As ISL.Controles.ComboMaestros
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents btnAnular As ISL.Controles.Boton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents ficDetalleOCMateriales As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents griListaDetalleBoleta As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraToolbarsDockArea15 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea16 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea20 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea21 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea9 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea10 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea11 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea12 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents MenuContextual2 As ISL.Controles.MenuContextual
    Friend WithEvents NuevoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents odOrden As ISL.Controles.OrigenDatos
    Friend WithEvents griListaOrdenIngreso As ISL.Controles.Grilla
    Friend WithEvents UltraToolbarsDockArea13 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents MenuDetalle As ISL.Controles.Menu
    Friend WithEvents UltraToolbarsDockArea14 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea17 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea18 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UEGB_Ordenes As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Agrupacion11 As ISL.Controles.Agrupacion
    Friend WithEvents griOrdenes As ISL.Controles.Grilla
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents btnBuscarOrdenes As ISL.Controles.Boton
    Friend WithEvents odOrdenesIngreso As ISL.Controles.OrigenDatos
    Friend WithEvents cbTipoOrden As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents cmdEnviaTesoreria As ISL.Controles.Boton
    Friend WithEvents EnviarTesoreriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents txtEstado As ISL.Controles.Texto
    Friend WithEvents lbl_etiqueta As ISL.Controles.Etiqueta
    Friend WithEvents rbAsoOrd As System.Windows.Forms.RadioButton
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents rbAsoDoc As System.Windows.Forms.RadioButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtEmpresa As ISL.Controles.Texto
    Friend WithEvents lbNumeroOrden As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTc As ISL.Controles.Texto
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents txtSubTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTipoPago As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents cboEstadoBoletaM As ISL.Controles.ComboMaestros
    Friend WithEvents txtPorcenIGV As ISL.Controles.Texto
    Friend WithEvents txtSerieM As ISL.Controles.Texto
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumeroM As ISL.Controles.Texto
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odDetalleDocumento As ISL.Controles.OrigenDatos
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents agrAsociacion As ISL.Controles.Agrupacion
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents ColoresEmitido As ISL.Controles.Colores
    Friend WithEvents ColoresAnulado As ISL.Controles.Colores
    Friend WithEvents rfFechaDocHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfFechaDocDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents chkRuc As ISL.Controles.Chequear
    Private WithEvents cboProveedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents odListadoDocumentos As ISL.Controles.OrigenDatos
    Friend WithEvents rFechasHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rFechasDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents etiTerminada As ISL.Controles.Etiqueta
    Friend WithEvents etiEnviado As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents fecFechaActual As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_CajaChica As ISL.Controles.Chequear
    Friend WithEvents gbDatosAdicionales As ISL.Controles.Agrupacion
    Friend WithEvents gbNroDoc As ISL.Controles.Agrupacion
    Private WithEvents cboProveedor2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtIGV As ISL.Controles.NumeroDecimal

End Class
