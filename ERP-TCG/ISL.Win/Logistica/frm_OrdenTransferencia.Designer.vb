<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OrdenTransferencia
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
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreSubEstado")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUsuario")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenDocumento")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieNumero")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenOrigen")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenDestino")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioEjecucion")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioEjecucion")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OrdenTransferencia))
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenOrigen")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenDestino")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreSubEstado")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUsuario")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenDocumento")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieNumero")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenOrigen")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenDestino")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioEjecucion")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioEjecucion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMaterial")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMaterial")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidadMedida")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfectoIgv")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBarras")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDivisible")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMaterial")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMaterial")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidadMedida")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serial")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AfectoIgv")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDivisible")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterial")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorVenta")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorIgv")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoMaterial")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimiento")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialAAtender")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoRequerimientoSer")
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenTrabajoMaterial")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
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
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorVenta")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorIgv")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoMaterial")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimiento")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialAAtender")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoRequerimientoSer")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenTrabajoMaterial")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quitar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quitar")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
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
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOrdenesdeTransferencia = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaOrdenTransferencia = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjecutarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odOrden = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnEjecutar = New ISL.Controles.Boton(Me.components)
        Me.agrFiltro = New ISL.Controles.Agrupacion(Me.components)
        Me.gbDatosAdicionales = New ISL.Controles.Agrupacion(Me.components)
        Me.rfOrdenTransferenciaHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfOrdenTransferenciaDesde = New System.Windows.Forms.DateTimePicker()
        Me.cboEstadoOrden = New ISL.Controles.ComboMaestros(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.gbOI = New ISL.Controles.Agrupacion(Me.components)
        Me.txtNIngreso = New ISL.Controles.Texto(Me.components)
        Me.rbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.rbNroOrden = New System.Windows.Forms.RadioButton()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresTerminada = New ISL.Controles.Colores(Me.components)
        Me.etiTerminada = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresRecepcionado = New ISL.Controles.Colores(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabSharedControlsPage1_Fill_Panel = New System.Windows.Forms.Panel()
        Me.UltraToolbarsDockArea11 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea12 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea9 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea10 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDetalle = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.gbeMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griMaterial = New ISL.Controles.Grilla(Me.components)
        Me.odMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.griOrdenMaterial = New ISL.Controles.Grilla(Me.components)
        Me.odOrdenMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraToolbarsDockArea40 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnDetalle = New ISL.Controles.Menu(Me.components)
        Me.UltraToolbarsDockArea41 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea42 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea43 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea37 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea38 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea39 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea33 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea34 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea35 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea36 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea29 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea30 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea31 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea32 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea25 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea26 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea27 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea28 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea4 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea17 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea18 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea19 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea20 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea13 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea14 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea15 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea16 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea5 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea6 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea7 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea8 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea21 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea22 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea23 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea24 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.lbl_etiqueta = New ISL.Controles.Etiqueta(Me.components)
        Me.fecOrden = New System.Windows.Forms.DateTimePicker()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboSubAlmacenDestino = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAlmDestino = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCenDestino = New ISL.Controles.ComboMaestros(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboAlmacenOrigen = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboSubAlmacenOrigen = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCenOrigen = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtProveedor = New ISL.Controles.Texto(Me.components)
        Me.txtMovTransf = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtEstadoOrden = New ISL.Controles.Texto(Me.components)
        Me.etiEstado = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroOrden = New ISL.Controles.Texto(Me.components)
        Me.etiNroOrden = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.mcDetalle = New ISL.Controles.MenuContextual(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ficOrden = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrOrdenesdeTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOrdenesdeTransferencia.SuspendLayout()
        CType(Me.griListaOrdenTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFiltro.SuspendLayout()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.cboEstadoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbOI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOI.SuspendLayout()
        CType(Me.txtNIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.ColoresTerminada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresRecepcionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalle.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griOrdenMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.cboSubAlmacenDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAlmDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCenDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboAlmacenOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSubAlmacenOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCenOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMovTransf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcDetalle.SuspendLayout()
        CType(Me.ficOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOrden.SuspendLayout()
        Me.UltraTabSharedControlsPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrOrdenesdeTransferencia)
        Me.UltraTabPageControl1.Controls.Add(Me.agrFiltro)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTabSharedControlsPage1_Fill_Panel)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea11)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea12)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea9)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraToolbarsDockArea10)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1249, 429)
        '
        'agrOrdenesdeTransferencia
        '
        Me.agrOrdenesdeTransferencia.Controls.Add(Me.griListaOrdenTransferencia)
        Me.agrOrdenesdeTransferencia.Controls.Add(Me.agrMenuLista)
        Me.agrOrdenesdeTransferencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOrdenesdeTransferencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOrdenesdeTransferencia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOrdenesdeTransferencia.Location = New System.Drawing.Point(0, 104)
        Me.agrOrdenesdeTransferencia.Name = "agrOrdenesdeTransferencia"
        Me.agrOrdenesdeTransferencia.Size = New System.Drawing.Size(1249, 325)
        Me.agrOrdenesdeTransferencia.TabIndex = 5
        Me.agrOrdenesdeTransferencia.Text = "Listado de Ordenes de Transferencia"
        Me.agrOrdenesdeTransferencia.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaOrdenTransferencia
        '
        Me.griListaOrdenTransferencia.ContextMenuStrip = Me.MenuContextual1
        Me.griListaOrdenTransferencia.DataSource = Me.odOrden
        UltraGridColumn229.Header.VisiblePosition = 0
        UltraGridColumn229.Hidden = True
        UltraGridColumn230.Header.VisiblePosition = 1
        UltraGridColumn230.Hidden = True
        UltraGridColumn231.Header.Caption = "Nro Orden"
        UltraGridColumn231.Header.VisiblePosition = 2
        UltraGridColumn231.Width = 117
        UltraGridColumn232.Header.VisiblePosition = 5
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.Header.VisiblePosition = 6
        UltraGridColumn233.Hidden = True
        UltraGridColumn234.Header.Caption = "Fecha"
        UltraGridColumn234.Header.VisiblePosition = 3
        UltraGridColumn234.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn234.Width = 146
        UltraGridColumn235.Header.VisiblePosition = 14
        UltraGridColumn235.Hidden = True
        UltraGridColumn236.Header.VisiblePosition = 15
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.VisiblePosition = 16
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.Header.VisiblePosition = 17
        UltraGridColumn238.Hidden = True
        UltraGridColumn239.Header.Caption = "Movimiento Inventario"
        UltraGridColumn239.Header.VisiblePosition = 4
        UltraGridColumn239.Hidden = True
        UltraGridColumn239.Width = 235
        UltraGridColumn240.Header.VisiblePosition = 18
        UltraGridColumn240.Hidden = True
        UltraGridColumn241.Header.Caption = "IdUsuario"
        UltraGridColumn241.Header.VisiblePosition = 19
        UltraGridColumn241.Hidden = True
        UltraGridColumn241.Width = 278
        UltraGridColumn242.Header.VisiblePosition = 20
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.Header.VisiblePosition = 21
        UltraGridColumn243.Hidden = True
        UltraGridColumn244.Header.VisiblePosition = 22
        UltraGridColumn245.Header.Caption = "Tipo Orden"
        UltraGridColumn245.Header.VisiblePosition = 10
        UltraGridColumn245.Hidden = True
        UltraGridColumn245.Width = 231
        UltraGridColumn246.Header.VisiblePosition = 9
        UltraGridColumn246.Hidden = True
        UltraGridColumn246.Width = 77
        UltraGridColumn247.Header.Caption = "Estado"
        UltraGridColumn247.Header.VisiblePosition = 13
        UltraGridColumn247.Width = 125
        UltraGridColumn248.Header.VisiblePosition = 23
        UltraGridColumn248.Hidden = True
        UltraGridColumn249.Header.VisiblePosition = 24
        UltraGridColumn249.Hidden = True
        UltraGridColumn250.Header.VisiblePosition = 25
        UltraGridColumn250.Hidden = True
        UltraGridColumn251.Header.Caption = "Usuario"
        UltraGridColumn251.Header.VisiblePosition = 26
        UltraGridColumn251.Width = 90
        UltraGridColumn252.Header.Caption = "Tipo Referencia"
        UltraGridColumn252.Header.VisiblePosition = 11
        UltraGridColumn252.Hidden = True
        UltraGridColumn252.Width = 166
        UltraGridColumn253.Header.Caption = "Referencia"
        UltraGridColumn253.Header.VisiblePosition = 12
        UltraGridColumn253.Hidden = True
        UltraGridColumn253.Width = 107
        UltraGridColumn254.Header.VisiblePosition = 27
        UltraGridColumn254.Hidden = True
        UltraGridColumn255.Header.VisiblePosition = 28
        UltraGridColumn255.Hidden = True
        UltraGridColumn256.Header.VisiblePosition = 29
        UltraGridColumn256.Hidden = True
        UltraGridColumn257.Header.VisiblePosition = 30
        UltraGridColumn257.Hidden = True
        UltraGridColumn258.Header.Caption = "Almacen Origen"
        UltraGridColumn258.Header.VisiblePosition = 7
        UltraGridColumn258.Width = 306
        UltraGridColumn259.Header.Caption = "Almacen Destino"
        UltraGridColumn259.Header.VisiblePosition = 8
        UltraGridColumn259.Width = 267
        UltraGridColumn260.Header.VisiblePosition = 31
        UltraGridColumn260.Hidden = True
        UltraGridColumn261.Header.VisiblePosition = 32
        UltraGridColumn261.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261})
        Me.griListaOrdenTransferencia.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaOrdenTransferencia.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaOrdenTransferencia.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaOrdenTransferencia.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaOrdenTransferencia.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaOrdenTransferencia.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaOrdenTransferencia.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaOrdenTransferencia.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaOrdenTransferencia.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaOrdenTransferencia.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaOrdenTransferencia.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griListaOrdenTransferencia.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaOrdenTransferencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaOrdenTransferencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaOrdenTransferencia.Location = New System.Drawing.Point(3, 47)
        Me.griListaOrdenTransferencia.Name = "griListaOrdenTransferencia"
        Me.griListaOrdenTransferencia.Size = New System.Drawing.Size(1243, 275)
        Me.griListaOrdenTransferencia.TabIndex = 2
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.EjecutarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(153, 114)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Orden de Ingreso"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar la Orden de Ingreso seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la Orden de Ingreso seleccionada"
        '
        'EjecutarToolStripMenuItem
        '
        Me.EjecutarToolStripMenuItem.Image = CType(resources.GetObject("EjecutarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EjecutarToolStripMenuItem.Name = "EjecutarToolStripMenuItem"
        Me.EjecutarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EjecutarToolStripMenuItem.Text = "Ejecutar"
        '
        'odOrden
        '
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Boolean)
        Me.odOrden.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnEjecutar)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 17)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1243, 30)
        Me.agrMenuLista.TabIndex = 9
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEjecutar
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnEjecutar.Appearance = Appearance1
        Me.btnEjecutar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEjecutar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEjecutar.Enabled = False
        Me.btnEjecutar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.ForeColor = System.Drawing.Color.Black
        Me.btnEjecutar.Location = New System.Drawing.Point(3, 3)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(81, 24)
        Me.btnEjecutar.TabIndex = 3
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'agrFiltro
        '
        Me.agrFiltro.Controls.Add(Me.gbDatosAdicionales)
        Me.agrFiltro.Controls.Add(Me.gbOI)
        Me.agrFiltro.Controls.Add(Me.rbDatosAdicionales)
        Me.agrFiltro.Controls.Add(Me.rbNroOrden)
        Me.agrFiltro.Controls.Add(Me.Agrupacion3)
        Me.agrFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrFiltro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFiltro.ForeColor = System.Drawing.Color.Black
        Me.agrFiltro.Location = New System.Drawing.Point(0, 0)
        Me.agrFiltro.Name = "agrFiltro"
        Me.agrFiltro.Size = New System.Drawing.Size(1249, 104)
        Me.agrFiltro.TabIndex = 0
        Me.agrFiltro.Text = "Filtros:"
        Me.agrFiltro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.Controls.Add(Me.rfOrdenTransferenciaHasta)
        Me.gbDatosAdicionales.Controls.Add(Me.rfOrdenTransferenciaDesde)
        Me.gbDatosAdicionales.Controls.Add(Me.cboEstadoOrden)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta21)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta6)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta2)
        Me.gbDatosAdicionales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosAdicionales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(14, 38)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(368, 60)
        Me.gbDatosAdicionales.TabIndex = 49
        Me.gbDatosAdicionales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rfOrdenTransferenciaHasta
        '
        Me.rfOrdenTransferenciaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfOrdenTransferenciaHasta.Location = New System.Drawing.Point(51, 32)
        Me.rfOrdenTransferenciaHasta.Name = "rfOrdenTransferenciaHasta"
        Me.rfOrdenTransferenciaHasta.Size = New System.Drawing.Size(98, 21)
        Me.rfOrdenTransferenciaHasta.TabIndex = 253
        '
        'rfOrdenTransferenciaDesde
        '
        Me.rfOrdenTransferenciaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfOrdenTransferenciaDesde.Location = New System.Drawing.Point(51, 5)
        Me.rfOrdenTransferenciaDesde.Name = "rfOrdenTransferenciaDesde"
        Me.rfOrdenTransferenciaDesde.Size = New System.Drawing.Size(98, 21)
        Me.rfOrdenTransferenciaDesde.TabIndex = 252
        '
        'cboEstadoOrden
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoOrden.Appearance = Appearance2
        Me.cboEstadoOrden.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoOrden.DisplayMember = "Nombre"
        Me.cboEstadoOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoOrden.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoOrden.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoOrden.ImageList = Me.imagenes
        Me.cboEstadoOrden.Location = New System.Drawing.Point(169, 24)
        Me.cboEstadoOrden.Name = "cboEstadoOrden"
        Me.cboEstadoOrden.Size = New System.Drawing.Size(193, 22)
        Me.cboEstadoOrden.TabIndex = 5
        Me.cboEstadoOrden.ValueMember = "Id"
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
        'Etiqueta21
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance3
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(10, 35)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta21.TabIndex = 251
        Me.Etiqueta21.Text = "Hasta:"
        '
        'Etiqueta6
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance4
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(169, 7)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta6.TabIndex = 12
        Me.Etiqueta6.Text = "Estado:"
        '
        'Etiqueta2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance5
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(7, 8)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta2.TabIndex = 250
        Me.Etiqueta2.Text = "Desde:"
        '
        'gbOI
        '
        Me.gbOI.Controls.Add(Me.txtNIngreso)
        Me.gbOI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOI.ForeColor = System.Drawing.Color.Black
        Me.gbOI.Location = New System.Drawing.Point(388, 39)
        Me.gbOI.Name = "gbOI"
        Me.gbOI.Size = New System.Drawing.Size(148, 34)
        Me.gbOI.TabIndex = 48
        Me.gbOI.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtNIngreso
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNIngreso.Appearance = Appearance6
        Me.txtNIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNIngreso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNIngreso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIngreso.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNIngreso.Location = New System.Drawing.Point(6, 6)
        Me.txtNIngreso.MaxLength = 13
        Me.txtNIngreso.Name = "txtNIngreso"
        Me.txtNIngreso.Size = New System.Drawing.Size(132, 22)
        Me.txtNIngreso.TabIndex = 3
        '
        'rbDatosAdicionales
        '
        Me.rbDatosAdicionales.AutoSize = True
        Me.rbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rbDatosAdicionales.Checked = True
        Me.rbDatosAdicionales.ForeColor = System.Drawing.Color.Navy
        Me.rbDatosAdicionales.Location = New System.Drawing.Point(14, 22)
        Me.rbDatosAdicionales.Name = "rbDatosAdicionales"
        Me.rbDatosAdicionales.Size = New System.Drawing.Size(113, 17)
        Me.rbDatosAdicionales.TabIndex = 0
        Me.rbDatosAdicionales.TabStop = True
        Me.rbDatosAdicionales.Text = "Datos Adicionales:"
        Me.rbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'rbNroOrden
        '
        Me.rbNroOrden.AutoSize = True
        Me.rbNroOrden.BackColor = System.Drawing.Color.Transparent
        Me.rbNroOrden.ForeColor = System.Drawing.Color.Navy
        Me.rbNroOrden.Location = New System.Drawing.Point(388, 22)
        Me.rbNroOrden.Name = "rbNroOrden"
        Me.rbNroOrden.Size = New System.Drawing.Size(77, 17)
        Me.rbNroOrden.TabIndex = 6
        Me.rbNroOrden.Text = "N° Orden :"
        Me.rbNroOrden.UseVisualStyleBackColor = False
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.ColoresTerminada)
        Me.Agrupacion3.Controls.Add(Me.etiTerminada)
        Me.Agrupacion3.Controls.Add(Me.ColoresRecepcionado)
        Me.Agrupacion3.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion3.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion3.Controls.Add(Me.etiGenerada)
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion3.Location = New System.Drawing.Point(542, 21)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(216, 78)
        Me.Agrupacion3.TabIndex = 47
        Me.Agrupacion3.Text = "Estados"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresTerminada
        '
        Me.ColoresTerminada.Location = New System.Drawing.Point(161, 44)
        Me.ColoresTerminada.Name = "ColoresTerminada"
        Me.ColoresTerminada.Size = New System.Drawing.Size(46, 22)
        Me.ColoresTerminada.TabIndex = 6
        Me.ColoresTerminada.Text = "Control"
        '
        'etiTerminada
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.etiTerminada.Appearance = Appearance7
        Me.etiTerminada.AutoSize = True
        Me.etiTerminada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTerminada.ForeColor = System.Drawing.Color.Black
        Me.etiTerminada.Location = New System.Drawing.Point(156, 26)
        Me.etiTerminada.Name = "etiTerminada"
        Me.etiTerminada.Size = New System.Drawing.Size(56, 15)
        Me.etiTerminada.TabIndex = 5
        Me.etiTerminada.Text = "Terminada"
        '
        'ColoresRecepcionado
        '
        Me.ColoresRecepcionado.Location = New System.Drawing.Point(82, 44)
        Me.ColoresRecepcionado.Name = "ColoresRecepcionado"
        Me.ColoresRecepcionado.Size = New System.Drawing.Size(43, 22)
        Me.ColoresRecepcionado.TabIndex = 2
        Me.ColoresRecepcionado.Text = "Control"
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Location = New System.Drawing.Point(5, 44)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 22)
        Me.ColoresGenerado.TabIndex = 1
        Me.ColoresGenerado.Text = "Control"
        '
        'etiEnProceso
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.etiEnProceso.Appearance = Appearance8
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(72, 25)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(71, 15)
        Me.etiEnProceso.TabIndex = 4
        Me.etiEnProceso.Text = "Recepcionada"
        '
        'etiGenerada
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.etiGenerada.Appearance = Appearance9
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(6, 26)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(51, 15)
        Me.etiGenerada.TabIndex = 3
        Me.etiGenerada.Text = "Generada"
        '
        'UltraTabSharedControlsPage1_Fill_Panel
        '
        Me.UltraTabSharedControlsPage1_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.UltraTabSharedControlsPage1_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabSharedControlsPage1_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabSharedControlsPage1_Fill_Panel.Name = "UltraTabSharedControlsPage1_Fill_Panel"
        Me.UltraTabSharedControlsPage1_Fill_Panel.Size = New System.Drawing.Size(1249, 429)
        Me.UltraTabSharedControlsPage1_Fill_Panel.TabIndex = 0
        '
        'UltraToolbarsDockArea11
        '
        Me.UltraToolbarsDockArea11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea11.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea11.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea11.Name = "UltraToolbarsDockArea11"
        Me.UltraToolbarsDockArea11.Size = New System.Drawing.Size(0, 429)
        '
        'UltraToolbarsDockArea12
        '
        Me.UltraToolbarsDockArea12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea12.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea12.Location = New System.Drawing.Point(1249, 0)
        Me.UltraToolbarsDockArea12.Name = "UltraToolbarsDockArea12"
        Me.UltraToolbarsDockArea12.Size = New System.Drawing.Size(0, 429)
        '
        'UltraToolbarsDockArea9
        '
        Me.UltraToolbarsDockArea9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea9.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea9.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea9.Name = "UltraToolbarsDockArea9"
        Me.UltraToolbarsDockArea9.Size = New System.Drawing.Size(1249, 0)
        '
        'UltraToolbarsDockArea10
        '
        Me.UltraToolbarsDockArea10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea10.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea10.Location = New System.Drawing.Point(0, 429)
        Me.UltraToolbarsDockArea10.Name = "UltraToolbarsDockArea10"
        Me.UltraToolbarsDockArea10.Size = New System.Drawing.Size(1249, 0)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea21)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea22)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea23)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea24)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatoGeneral)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1249, 453)
        '
        'agrDetalle
        '
        Me.agrDetalle.Controls.Add(Me.UltraGroupBox1)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea40)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea41)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea42)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea43)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Top)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea37)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea38)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea39)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Left)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Right)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea33)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea34)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea35)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea36)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea29)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea30)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea31)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea32)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea25)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea26)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea27)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea28)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea2)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea3)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea4)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea17)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea18)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea19)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea20)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea13)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea14)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea15)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea16)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea5)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea6)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea7)
        Me.agrDetalle.Controls.Add(Me.UltraToolbarsDockArea8)
        Me.agrDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalle.Location = New System.Drawing.Point(0, 231)
        Me.agrDetalle.Name = "agrDetalle"
        Me.agrDetalle.Size = New System.Drawing.Size(1249, 222)
        Me.agrDetalle.TabIndex = 203
        Me.agrDetalle.Text = "Detalles"
        Me.agrDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.gbeMateriales)
        Me.UltraGroupBox1.Controls.Add(Me.griOrdenMaterial)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(3, 43)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1243, 176)
        Me.UltraGroupBox1.TabIndex = 98
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gbeMateriales
        '
        Me.gbeMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeMateriales.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeMateriales.Expanded = False
        Me.gbeMateriales.ExpandedSize = New System.Drawing.Size(743, 170)
        Me.gbeMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeMateriales.Location = New System.Drawing.Point(1218, 3)
        Me.gbeMateriales.Name = "gbeMateriales"
        Me.gbeMateriales.Size = New System.Drawing.Size(22, 170)
        Me.gbeMateriales.TabIndex = 11
        Me.gbeMateriales.Text = "Materiales"
        Me.gbeMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griMaterial)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(720, 128)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'griMaterial
        '
        Me.griMaterial.DataSource = Me.odMaterial
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griMaterial.DisplayLayout.Appearance = Appearance10
        Appearance11.TextHAlignAsString = "Left"
        UltraGridColumn199.CellAppearance = Appearance11
        UltraGridColumn199.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance12.TextHAlignAsString = "Center"
        UltraGridColumn199.Header.Appearance = Appearance12
        UltraGridColumn199.Header.Caption = "Select"
        UltraGridColumn199.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn199.Header.VisiblePosition = 0
        UltraGridColumn199.Width = 44
        Appearance13.TextHAlignAsString = "Left"
        UltraGridColumn200.CellAppearance = Appearance13
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn200.Header.Appearance = Appearance14
        UltraGridColumn200.Header.VisiblePosition = 1
        UltraGridColumn200.Hidden = True
        Appearance15.TextHAlignAsString = "Left"
        UltraGridColumn201.CellAppearance = Appearance15
        Appearance16.TextHAlignAsString = "Center"
        UltraGridColumn201.Header.Appearance = Appearance16
        UltraGridColumn201.Header.VisiblePosition = 2
        UltraGridColumn201.Hidden = True
        UltraGridColumn201.Width = 81
        Appearance17.TextHAlignAsString = "Left"
        UltraGridColumn202.CellAppearance = Appearance17
        Appearance18.TextHAlignAsString = "Center"
        UltraGridColumn202.Header.Appearance = Appearance18
        UltraGridColumn202.Header.VisiblePosition = 3
        UltraGridColumn202.Hidden = True
        UltraGridColumn202.Width = 289
        Appearance19.TextHAlignAsString = "Left"
        UltraGridColumn203.CellAppearance = Appearance19
        Appearance20.TextHAlignAsString = "Center"
        UltraGridColumn203.Header.Appearance = Appearance20
        UltraGridColumn203.Header.Caption = "Unid. Med."
        UltraGridColumn203.Header.VisiblePosition = 7
        UltraGridColumn203.Width = 81
        Appearance21.TextHAlignAsString = "Left"
        UltraGridColumn204.CellAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Center"
        UltraGridColumn204.Header.Appearance = Appearance22
        UltraGridColumn204.Header.Caption = "Almacen"
        UltraGridColumn204.Header.VisiblePosition = 8
        UltraGridColumn204.Hidden = True
        UltraGridColumn204.Width = 199
        Appearance23.TextHAlignAsString = "Left"
        UltraGridColumn205.CellAppearance = Appearance23
        Appearance24.TextHAlignAsString = "Center"
        UltraGridColumn205.Header.Appearance = Appearance24
        UltraGridColumn205.Header.VisiblePosition = 22
        UltraGridColumn205.Hidden = True
        Appearance25.TextHAlignAsString = "Left"
        UltraGridColumn206.CellAppearance = Appearance25
        Appearance26.TextHAlignAsString = "Center"
        UltraGridColumn206.Header.Appearance = Appearance26
        UltraGridColumn206.Header.VisiblePosition = 9
        UltraGridColumn206.Hidden = True
        Appearance27.TextHAlignAsString = "Left"
        UltraGridColumn207.CellAppearance = Appearance27
        Appearance28.TextHAlignAsString = "Center"
        UltraGridColumn207.Header.Appearance = Appearance28
        UltraGridColumn207.Header.VisiblePosition = 10
        UltraGridColumn207.Hidden = True
        Appearance29.TextHAlignAsString = "Left"
        UltraGridColumn208.CellAppearance = Appearance29
        Appearance30.TextHAlignAsString = "Center"
        UltraGridColumn208.Header.Appearance = Appearance30
        UltraGridColumn208.Header.VisiblePosition = 12
        UltraGridColumn208.Hidden = True
        Appearance31.TextHAlignAsString = "Left"
        UltraGridColumn209.CellAppearance = Appearance31
        Appearance32.TextHAlignAsString = "Center"
        UltraGridColumn209.Header.Appearance = Appearance32
        UltraGridColumn209.Header.VisiblePosition = 13
        UltraGridColumn209.Hidden = True
        Appearance33.TextHAlignAsString = "Left"
        UltraGridColumn210.CellAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Center"
        UltraGridColumn210.Header.Appearance = Appearance34
        UltraGridColumn210.Header.VisiblePosition = 14
        UltraGridColumn210.Hidden = True
        Appearance35.TextHAlignAsString = "Left"
        UltraGridColumn211.CellAppearance = Appearance35
        Appearance36.TextHAlignAsString = "Center"
        UltraGridColumn211.Header.Appearance = Appearance36
        UltraGridColumn211.Header.VisiblePosition = 15
        UltraGridColumn211.Hidden = True
        Appearance37.TextHAlignAsString = "Left"
        UltraGridColumn212.CellAppearance = Appearance37
        Appearance38.TextHAlignAsString = "Center"
        UltraGridColumn212.Header.Appearance = Appearance38
        UltraGridColumn212.Header.VisiblePosition = 20
        UltraGridColumn212.Hidden = True
        Appearance39.TextHAlignAsString = "Left"
        UltraGridColumn213.CellAppearance = Appearance39
        Appearance40.TextHAlignAsString = "Center"
        UltraGridColumn213.Header.Appearance = Appearance40
        UltraGridColumn213.Header.VisiblePosition = 16
        UltraGridColumn213.Hidden = True
        Appearance41.TextHAlignAsString = "Left"
        UltraGridColumn214.CellAppearance = Appearance41
        Appearance42.TextHAlignAsString = "Center"
        UltraGridColumn214.Header.Appearance = Appearance42
        UltraGridColumn214.Header.VisiblePosition = 19
        UltraGridColumn214.Hidden = True
        Appearance43.TextHAlignAsString = "Left"
        UltraGridColumn215.CellAppearance = Appearance43
        Appearance44.TextHAlignAsString = "Center"
        UltraGridColumn215.Header.Appearance = Appearance44
        UltraGridColumn215.Header.VisiblePosition = 18
        UltraGridColumn215.Hidden = True
        Appearance45.TextHAlignAsString = "Left"
        UltraGridColumn216.CellAppearance = Appearance45
        Appearance46.TextHAlignAsString = "Center"
        UltraGridColumn216.Header.Appearance = Appearance46
        UltraGridColumn216.Header.VisiblePosition = 21
        UltraGridColumn216.Hidden = True
        Appearance47.TextHAlignAsString = "Left"
        UltraGridColumn217.CellAppearance = Appearance47
        Appearance48.TextHAlignAsString = "Center"
        UltraGridColumn217.Header.Appearance = Appearance48
        UltraGridColumn217.Header.VisiblePosition = 23
        UltraGridColumn217.Hidden = True
        Appearance49.TextHAlignAsString = "Left"
        UltraGridColumn218.CellAppearance = Appearance49
        Appearance50.TextHAlignAsString = "Center"
        UltraGridColumn218.Header.Appearance = Appearance50
        UltraGridColumn218.Header.VisiblePosition = 11
        UltraGridColumn218.Hidden = True
        Appearance51.TextHAlignAsString = "Left"
        UltraGridColumn219.CellAppearance = Appearance51
        Appearance52.TextHAlignAsString = "Center"
        UltraGridColumn219.Header.Appearance = Appearance52
        UltraGridColumn219.Header.VisiblePosition = 17
        UltraGridColumn219.Hidden = True
        UltraGridColumn220.Header.VisiblePosition = 24
        UltraGridColumn220.Hidden = True
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn221.CellAppearance = Appearance53
        UltraGridColumn221.Header.Caption = "Costo Unit."
        UltraGridColumn221.Header.VisiblePosition = 25
        UltraGridColumn221.Width = 77
        Appearance54.TextHAlignAsString = "Right"
        UltraGridColumn222.CellAppearance = Appearance54
        UltraGridColumn222.Header.VisiblePosition = 5
        UltraGridColumn222.MaskInput = "{double:9.4}"
        UltraGridColumn222.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn222.Width = 106
        UltraGridColumn223.Header.Caption = "Material"
        UltraGridColumn223.Header.VisiblePosition = 4
        UltraGridColumn223.Width = 375
        UltraGridColumn224.Header.VisiblePosition = 26
        UltraGridColumn224.Hidden = True
        UltraGridColumn225.Header.VisiblePosition = 6
        UltraGridColumn225.Hidden = True
        UltraGridColumn226.Header.VisiblePosition = 27
        UltraGridColumn226.Hidden = True
        UltraGridColumn227.Header.VisiblePosition = 28
        UltraGridColumn227.Hidden = True
        UltraGridColumn228.Header.VisiblePosition = 29
        UltraGridColumn228.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228})
        Me.griMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance55.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance55.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance55.BorderColor = System.Drawing.SystemColors.Window
        Me.griMaterial.DisplayLayout.GroupByBox.Appearance = Appearance55
        Appearance56.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance56
        Me.griMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance57.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance57.BackColor2 = System.Drawing.SystemColors.Control
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance57.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance57
        Me.griMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Appearance58.BackColor = System.Drawing.SystemColors.Window
        Appearance58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griMaterial.DisplayLayout.Override.ActiveCellAppearance = Appearance58
        Appearance59.BackColor = System.Drawing.SystemColors.Highlight
        Appearance59.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griMaterial.DisplayLayout.Override.ActiveRowAppearance = Appearance59
        Me.griMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance60.BackColor = System.Drawing.SystemColors.Window
        Me.griMaterial.DisplayLayout.Override.CardAreaAppearance = Appearance60
        Appearance61.BorderColor = System.Drawing.Color.Silver
        Appearance61.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griMaterial.DisplayLayout.Override.CellAppearance = Appearance61
        Me.griMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMaterial.DisplayLayout.Override.CellPadding = 0
        Me.griMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMaterial.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance62.BackColor = System.Drawing.SystemColors.Control
        Appearance62.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance62.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance62.BorderColor = System.Drawing.SystemColors.Window
        Me.griMaterial.DisplayLayout.Override.GroupByRowAppearance = Appearance62
        Appearance63.TextHAlignAsString = "Left"
        Me.griMaterial.DisplayLayout.Override.HeaderAppearance = Appearance63
        Me.griMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance64.BackColor = System.Drawing.SystemColors.Window
        Appearance64.BorderColor = System.Drawing.Color.Silver
        Me.griMaterial.DisplayLayout.Override.RowAppearance = Appearance64
        Me.griMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance65.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griMaterial.DisplayLayout.Override.TemplateAddRowAppearance = Appearance65
        Me.griMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMaterial.Location = New System.Drawing.Point(0, 0)
        Me.griMaterial.Name = "griMaterial"
        Me.griMaterial.Size = New System.Drawing.Size(720, 128)
        Me.griMaterial.TabIndex = 4
        Me.griMaterial.Text = "griMaterial"
        '
        'odMaterial
        '
        UltraDataColumn34.DataType = GetType(Boolean)
        UltraDataColumn52.DefaultValue = "False"
        UltraDataColumn54.DataType = GetType(Boolean)
        Me.odMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63})
        '
        'griOrdenMaterial
        '
        Me.griOrdenMaterial.DataSource = Me.odOrdenMaterial
        Appearance66.BackColor = System.Drawing.SystemColors.Window
        Appearance66.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenMaterial.DisplayLayout.Appearance = Appearance66
        UltraGridColumn262.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance67.TextHAlignAsString = "Center"
        UltraGridColumn262.Header.Appearance = Appearance67
        UltraGridColumn262.Header.Caption = "Select"
        UltraGridColumn262.Header.VisiblePosition = 0
        UltraGridColumn262.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn262.Width = 41
        Appearance68.TextHAlignAsString = "Center"
        UltraGridColumn263.Header.Appearance = Appearance68
        UltraGridColumn263.Header.VisiblePosition = 1
        UltraGridColumn263.Hidden = True
        Appearance69.TextHAlignAsString = "Center"
        UltraGridColumn264.Header.Appearance = Appearance69
        UltraGridColumn264.Header.VisiblePosition = 2
        UltraGridColumn264.Hidden = True
        Appearance70.TextHAlignAsString = "Center"
        UltraGridColumn265.Header.Appearance = Appearance70
        UltraGridColumn265.Header.VisiblePosition = 3
        UltraGridColumn265.Hidden = True
        Appearance71.TextHAlignAsString = "Left"
        UltraGridColumn266.CellAppearance = Appearance71
        Appearance72.TextHAlignAsString = "Center"
        UltraGridColumn266.Header.Appearance = Appearance72
        UltraGridColumn266.Header.Caption = "Codigo"
        UltraGridColumn266.Header.VisiblePosition = 4
        UltraGridColumn266.Width = 76
        Appearance73.TextHAlignAsString = "Left"
        UltraGridColumn267.CellAppearance = Appearance73
        Appearance74.TextHAlignAsString = "Center"
        UltraGridColumn267.Header.Appearance = Appearance74
        UltraGridColumn267.Header.VisiblePosition = 5
        UltraGridColumn267.Width = 315
        Appearance75.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance75.TextHAlignAsString = "Right"
        UltraGridColumn268.CellAppearance = Appearance75
        UltraGridColumn268.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance76.TextHAlignAsString = "Center"
        UltraGridColumn268.Header.Appearance = Appearance76
        UltraGridColumn268.Header.Caption = "Cantidad"
        UltraGridColumn268.Header.VisiblePosition = 8
        UltraGridColumn268.MaskInput = "{double:9.4}"
        Appearance77.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance77.TextHAlignAsString = "Right"
        UltraGridColumn269.CellAppearance = Appearance77
        UltraGridColumn269.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance78.TextHAlignAsString = "Center"
        UltraGridColumn269.Header.Appearance = Appearance78
        UltraGridColumn269.Header.Caption = "Precio Unitario"
        UltraGridColumn269.Header.VisiblePosition = 10
        UltraGridColumn269.MaskInput = "{double:9.4}"
        Appearance79.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance79.TextHAlignAsString = "Right"
        UltraGridColumn270.CellAppearance = Appearance79
        Appearance80.TextHAlignAsString = "Center"
        UltraGridColumn270.Header.Appearance = Appearance80
        UltraGridColumn270.Header.Caption = "Valor Venta"
        UltraGridColumn270.Header.VisiblePosition = 11
        UltraGridColumn270.MaskInput = "{double:9.4}"
        UltraGridColumn270.Width = 89
        Appearance81.TextHAlignAsString = "Center"
        UltraGridColumn271.Header.Appearance = Appearance81
        UltraGridColumn271.Header.Caption = "Almacen"
        UltraGridColumn271.Header.VisiblePosition = 12
        UltraGridColumn271.Hidden = True
        Appearance82.TextHAlignAsString = "Center"
        UltraGridColumn272.Header.Appearance = Appearance82
        UltraGridColumn272.Header.Caption = "NombreAlmacen"
        UltraGridColumn272.Header.VisiblePosition = 13
        UltraGridColumn272.Hidden = True
        Appearance83.TextHAlignAsString = "Center"
        UltraGridColumn273.Header.Appearance = Appearance83
        UltraGridColumn273.Header.VisiblePosition = 14
        UltraGridColumn273.Hidden = True
        Appearance84.TextHAlignAsString = "Center"
        UltraGridColumn274.Header.Appearance = Appearance84
        UltraGridColumn274.Header.VisiblePosition = 15
        UltraGridColumn274.Hidden = True
        Appearance85.TextHAlignAsString = "Center"
        UltraGridColumn275.Header.Appearance = Appearance85
        UltraGridColumn275.Header.VisiblePosition = 16
        UltraGridColumn275.Hidden = True
        Appearance86.TextHAlignAsString = "Center"
        UltraGridColumn276.Header.Appearance = Appearance86
        UltraGridColumn276.Header.VisiblePosition = 17
        UltraGridColumn276.Hidden = True
        Appearance87.TextHAlignAsString = "Center"
        UltraGridColumn277.Header.Appearance = Appearance87
        UltraGridColumn277.Header.VisiblePosition = 18
        UltraGridColumn277.Hidden = True
        Appearance88.TextHAlignAsString = "Center"
        UltraGridColumn278.Header.Appearance = Appearance88
        UltraGridColumn278.Header.Caption = "NombreUnidadMedida"
        UltraGridColumn278.Header.VisiblePosition = 6
        UltraGridColumn278.Hidden = True
        UltraGridColumn278.Width = 103
        Appearance89.TextHAlignAsString = "Center"
        UltraGridColumn279.Header.Appearance = Appearance89
        UltraGridColumn279.Header.VisiblePosition = 19
        UltraGridColumn279.Hidden = True
        Appearance90.TextHAlignAsString = "Center"
        UltraGridColumn280.Header.Appearance = Appearance90
        UltraGridColumn280.Header.Caption = "Unidad Medida"
        UltraGridColumn280.Header.VisiblePosition = 7
        UltraGridColumn280.Width = 101
        Appearance91.TextHAlignAsString = "Center"
        UltraGridColumn281.Header.Appearance = Appearance91
        UltraGridColumn281.Header.VisiblePosition = 20
        UltraGridColumn281.Hidden = True
        Appearance92.TextHAlignAsString = "Center"
        UltraGridColumn282.Header.Appearance = Appearance92
        UltraGridColumn282.Header.VisiblePosition = 21
        UltraGridColumn282.Hidden = True
        Appearance93.TextHAlignAsString = "Center"
        UltraGridColumn283.Header.Appearance = Appearance93
        UltraGridColumn283.Header.VisiblePosition = 22
        UltraGridColumn283.Hidden = True
        Appearance94.TextHAlignAsString = "Center"
        UltraGridColumn284.Header.Appearance = Appearance94
        UltraGridColumn284.Header.VisiblePosition = 23
        UltraGridColumn284.Hidden = True
        Appearance95.TextHAlignAsString = "Center"
        UltraGridColumn285.Header.Appearance = Appearance95
        UltraGridColumn285.Header.VisiblePosition = 24
        UltraGridColumn285.Hidden = True
        Appearance96.TextHAlignAsString = "Center"
        UltraGridColumn286.Header.Appearance = Appearance96
        UltraGridColumn286.Header.VisiblePosition = 25
        UltraGridColumn286.Hidden = True
        Appearance97.TextHAlignAsString = "Center"
        UltraGridColumn287.Header.Appearance = Appearance97
        UltraGridColumn287.Header.VisiblePosition = 26
        UltraGridColumn287.Hidden = True
        Appearance98.TextHAlignAsString = "Center"
        UltraGridColumn288.Header.Appearance = Appearance98
        UltraGridColumn288.Header.VisiblePosition = 27
        UltraGridColumn288.Hidden = True
        UltraGridColumn289.Header.VisiblePosition = 28
        UltraGridColumn289.Hidden = True
        UltraGridColumn290.Header.VisiblePosition = 29
        UltraGridColumn290.Hidden = True
        UltraGridColumn291.Header.VisiblePosition = 30
        UltraGridColumn291.Hidden = True
        UltraGridColumn292.Header.VisiblePosition = 31
        UltraGridColumn292.Hidden = True
        Appearance99.TextHAlignAsString = "Right"
        UltraGridColumn293.CellAppearance = Appearance99
        Appearance100.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn293.Header.Appearance = Appearance100
        UltraGridColumn293.Header.VisiblePosition = 9
        UltraGridColumn293.MaskInput = "{double:9.4}"
        UltraGridColumn293.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn293.Width = 100
        UltraGridColumn294.Header.VisiblePosition = 32
        UltraGridColumn294.Hidden = True
        UltraGridColumn295.Header.VisiblePosition = 33
        UltraGridColumn295.Hidden = True
        UltraGridColumn296.Header.VisiblePosition = 34
        UltraGridColumn296.Hidden = True
        UltraGridColumn297.Header.VisiblePosition = 35
        UltraGridColumn297.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295, UltraGridColumn296, UltraGridColumn297})
        Me.griOrdenMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griOrdenMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance101.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance101.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance101.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenMaterial.DisplayLayout.GroupByBox.Appearance = Appearance101
        Appearance102.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance102
        Me.griOrdenMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance103.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance103.BackColor2 = System.Drawing.SystemColors.Control
        Appearance103.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance103.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance103
        Me.griOrdenMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Appearance104.BackColor = System.Drawing.SystemColors.Window
        Appearance104.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griOrdenMaterial.DisplayLayout.Override.ActiveCellAppearance = Appearance104
        Appearance105.BackColor = System.Drawing.SystemColors.Highlight
        Appearance105.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griOrdenMaterial.DisplayLayout.Override.ActiveRowAppearance = Appearance105
        Me.griOrdenMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance106.BackColor = System.Drawing.SystemColors.Window
        Me.griOrdenMaterial.DisplayLayout.Override.CardAreaAppearance = Appearance106
        Appearance107.BorderColor = System.Drawing.Color.Silver
        Appearance107.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griOrdenMaterial.DisplayLayout.Override.CellAppearance = Appearance107
        Me.griOrdenMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenMaterial.DisplayLayout.Override.CellPadding = 0
        Me.griOrdenMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenMaterial.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griOrdenMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance108.BackColor = System.Drawing.SystemColors.Control
        Appearance108.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance108.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance108.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance108.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenMaterial.DisplayLayout.Override.GroupByRowAppearance = Appearance108
        Appearance109.TextHAlignAsString = "Left"
        Me.griOrdenMaterial.DisplayLayout.Override.HeaderAppearance = Appearance109
        Me.griOrdenMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance110.BackColor = System.Drawing.SystemColors.Window
        Appearance110.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenMaterial.DisplayLayout.Override.RowAppearance = Appearance110
        Me.griOrdenMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance111.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griOrdenMaterial.DisplayLayout.Override.TemplateAddRowAppearance = Appearance111
        Me.griOrdenMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenMaterial.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenMaterial.Name = "griOrdenMaterial"
        Me.griOrdenMaterial.Size = New System.Drawing.Size(1237, 170)
        Me.griOrdenMaterial.TabIndex = 12
        Me.griOrdenMaterial.Text = "Grilla1"
        '
        'odOrdenMaterial
        '
        UltraDataColumn64.DataType = GetType(Boolean)
        UltraDataColumn64.DefaultValue = False
        UltraDataColumn95.DataType = GetType(Double)
        Me.odOrdenMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99})
        '
        'UltraToolbarsDockArea40
        '
        Me.UltraToolbarsDockArea40.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea40.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea40.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea40.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea40.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea40.Name = "UltraToolbarsDockArea40"
        Me.UltraToolbarsDockArea40.Size = New System.Drawing.Size(1243, 26)
        Me.UltraToolbarsDockArea40.ToolbarsManager = Me.mnDetalle
        '
        'mnDetalle
        '
        Appearance112.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mnDetalle.Appearance = Appearance112
        Me.mnDetalle.DesignerFlags = 1
        Me.mnDetalle.DockWithinContainer = Me
        Me.mnDetalle.DockWithinContainerBaseType = GetType(frm_MenuPadre)
        Me.mnDetalle.MdiMergeable = False
        Me.mnDetalle.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool13, ButtonTool14})
        Me.mnDetalle.MiniToolbar.ToolRowCount = 1
        Me.mnDetalle.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(237, 414)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(143, 48)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool17, ButtonTool3})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.mnDetalle.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance113.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance113
        ButtonTool4.SharedPropsInternal.Caption = "Guardar"
        ButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance114.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool5.SharedPropsInternal.AppearancesSmall.Appearance = Appearance114
        ButtonTool5.SharedPropsInternal.Caption = "Editar"
        ButtonTool5.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance115.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance115
        ButtonTool6.SharedPropsInternal.Caption = "Quitar"
        ButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance116.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        ButtonTool10.SharedPropsInternal.AppearancesSmall.Appearance = Appearance116
        ButtonTool10.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance117.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool12.SharedPropsInternal.AppearancesSmall.Appearance = Appearance117
        ButtonTool12.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool12.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool15.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool16.SharedPropsInternal.Caption = "ButtonTool2"
        ButtonTool18.SharedPropsInternal.Caption = "ButtonTool3"
        Appearance118.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance118
        ButtonTool9.SharedPropsInternal.Caption = "Consultar"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance119.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool19.SharedPropsInternal.AppearancesSmall.Appearance = Appearance119
        ButtonTool19.SharedPropsInternal.Caption = "Agregar"
        ButtonTool19.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnDetalle.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool4, ButtonTool5, ButtonTool6, ButtonTool10, ButtonTool12, ButtonTool15, ButtonTool16, ButtonTool18, ButtonTool9, ButtonTool19})
        '
        'UltraToolbarsDockArea41
        '
        Me.UltraToolbarsDockArea41.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea41.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea41.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea41.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea41.Location = New System.Drawing.Point(3, 219)
        Me.UltraToolbarsDockArea41.Name = "UltraToolbarsDockArea41"
        Me.UltraToolbarsDockArea41.Size = New System.Drawing.Size(1243, 0)
        Me.UltraToolbarsDockArea41.ToolbarsManager = Me.mnDetalle
        '
        'UltraToolbarsDockArea42
        '
        Me.UltraToolbarsDockArea42.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea42.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea42.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea42.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea42.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea42.Name = "UltraToolbarsDockArea42"
        Me.UltraToolbarsDockArea42.Size = New System.Drawing.Size(0, 202)
        Me.UltraToolbarsDockArea42.ToolbarsManager = Me.mnDetalle
        '
        'UltraToolbarsDockArea43
        '
        Me.UltraToolbarsDockArea43.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea43.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea43.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea43.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea43.Location = New System.Drawing.Point(1246, 17)
        Me.UltraToolbarsDockArea43.Name = "UltraToolbarsDockArea43"
        Me.UltraToolbarsDockArea43.Size = New System.Drawing.Size(0, 202)
        Me.UltraToolbarsDockArea43.ToolbarsManager = Me.mnDetalle
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Top
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(3, 17)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Top"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea37
        '
        Me.UltraToolbarsDockArea37.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea37.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea37.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea37.Location = New System.Drawing.Point(3, 219)
        Me.UltraToolbarsDockArea37.Name = "UltraToolbarsDockArea37"
        Me.UltraToolbarsDockArea37.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea38
        '
        Me.UltraToolbarsDockArea38.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea38.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea38.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea38.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea38.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea38.Name = "UltraToolbarsDockArea38"
        Me.UltraToolbarsDockArea38.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea39
        '
        Me.UltraToolbarsDockArea39.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea39.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea39.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea39.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea39.Location = New System.Drawing.Point(1246, 17)
        Me.UltraToolbarsDockArea39.Name = "UltraToolbarsDockArea39"
        Me.UltraToolbarsDockArea39.Size = New System.Drawing.Size(0, 202)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Bottom
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(3, 219)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Bottom"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1243, 0)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Left
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(3, 17)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Left"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 202)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Right
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1246, 17)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Right"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea33
        '
        Me.UltraToolbarsDockArea33.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea33.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea33.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea33.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea33.Name = "UltraToolbarsDockArea33"
        Me.UltraToolbarsDockArea33.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea34
        '
        Me.UltraToolbarsDockArea34.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea34.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea34.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea34.Location = New System.Drawing.Point(3, 219)
        Me.UltraToolbarsDockArea34.Name = "UltraToolbarsDockArea34"
        Me.UltraToolbarsDockArea34.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea35
        '
        Me.UltraToolbarsDockArea35.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea35.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea35.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea35.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea35.Name = "UltraToolbarsDockArea35"
        Me.UltraToolbarsDockArea35.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea36
        '
        Me.UltraToolbarsDockArea36.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea36.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea36.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea36.Location = New System.Drawing.Point(1246, 17)
        Me.UltraToolbarsDockArea36.Name = "UltraToolbarsDockArea36"
        Me.UltraToolbarsDockArea36.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea29
        '
        Me.UltraToolbarsDockArea29.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea29.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea29.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea29.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea29.Name = "UltraToolbarsDockArea29"
        Me.UltraToolbarsDockArea29.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea30
        '
        Me.UltraToolbarsDockArea30.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea30.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea30.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea30.Location = New System.Drawing.Point(3, 219)
        Me.UltraToolbarsDockArea30.Name = "UltraToolbarsDockArea30"
        Me.UltraToolbarsDockArea30.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea31
        '
        Me.UltraToolbarsDockArea31.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea31.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea31.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea31.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea31.Name = "UltraToolbarsDockArea31"
        Me.UltraToolbarsDockArea31.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea32
        '
        Me.UltraToolbarsDockArea32.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea32.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea32.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea32.Location = New System.Drawing.Point(1246, 17)
        Me.UltraToolbarsDockArea32.Name = "UltraToolbarsDockArea32"
        Me.UltraToolbarsDockArea32.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea25
        '
        Me.UltraToolbarsDockArea25.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea25.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea25.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea25.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea25.Name = "UltraToolbarsDockArea25"
        Me.UltraToolbarsDockArea25.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea26
        '
        Me.UltraToolbarsDockArea26.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea26.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea26.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea26.Location = New System.Drawing.Point(3, 219)
        Me.UltraToolbarsDockArea26.Name = "UltraToolbarsDockArea26"
        Me.UltraToolbarsDockArea26.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea27
        '
        Me.UltraToolbarsDockArea27.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea27.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea27.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea27.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea27.Name = "UltraToolbarsDockArea27"
        Me.UltraToolbarsDockArea27.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea28
        '
        Me.UltraToolbarsDockArea28.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea28.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea28.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea28.Location = New System.Drawing.Point(1246, 17)
        Me.UltraToolbarsDockArea28.Name = "UltraToolbarsDockArea28"
        Me.UltraToolbarsDockArea28.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea2
        '
        Me.UltraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea2.Location = New System.Drawing.Point(3, 219)
        Me.UltraToolbarsDockArea2.Name = "UltraToolbarsDockArea2"
        Me.UltraToolbarsDockArea2.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea3
        '
        Me.UltraToolbarsDockArea3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea3.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea3.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea3.Name = "UltraToolbarsDockArea3"
        Me.UltraToolbarsDockArea3.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea4
        '
        Me.UltraToolbarsDockArea4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea4.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea4.Location = New System.Drawing.Point(1246, 17)
        Me.UltraToolbarsDockArea4.Name = "UltraToolbarsDockArea4"
        Me.UltraToolbarsDockArea4.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea17
        '
        Me.UltraToolbarsDockArea17.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea17.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea17.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea17.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea17.Name = "UltraToolbarsDockArea17"
        Me.UltraToolbarsDockArea17.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea18
        '
        Me.UltraToolbarsDockArea18.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea18.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea18.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea18.Location = New System.Drawing.Point(3, 219)
        Me.UltraToolbarsDockArea18.Name = "UltraToolbarsDockArea18"
        Me.UltraToolbarsDockArea18.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea19
        '
        Me.UltraToolbarsDockArea19.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea19.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea19.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea19.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea19.Name = "UltraToolbarsDockArea19"
        Me.UltraToolbarsDockArea19.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea20
        '
        Me.UltraToolbarsDockArea20.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea20.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea20.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea20.Location = New System.Drawing.Point(1246, 17)
        Me.UltraToolbarsDockArea20.Name = "UltraToolbarsDockArea20"
        Me.UltraToolbarsDockArea20.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea13
        '
        Me.UltraToolbarsDockArea13.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea13.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea13.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea13.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea13.Name = "UltraToolbarsDockArea13"
        Me.UltraToolbarsDockArea13.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea14
        '
        Me.UltraToolbarsDockArea14.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea14.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea14.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea14.Location = New System.Drawing.Point(3, 219)
        Me.UltraToolbarsDockArea14.Name = "UltraToolbarsDockArea14"
        Me.UltraToolbarsDockArea14.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea15
        '
        Me.UltraToolbarsDockArea15.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea15.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea15.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea15.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea15.Name = "UltraToolbarsDockArea15"
        Me.UltraToolbarsDockArea15.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea16
        '
        Me.UltraToolbarsDockArea16.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea16.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea16.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea16.Location = New System.Drawing.Point(1246, 17)
        Me.UltraToolbarsDockArea16.Name = "UltraToolbarsDockArea16"
        Me.UltraToolbarsDockArea16.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea5
        '
        Me.UltraToolbarsDockArea5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea5.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea5.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea5.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea5.Name = "UltraToolbarsDockArea5"
        Me.UltraToolbarsDockArea5.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea6
        '
        Me.UltraToolbarsDockArea6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea6.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea6.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea6.Location = New System.Drawing.Point(3, 219)
        Me.UltraToolbarsDockArea6.Name = "UltraToolbarsDockArea6"
        Me.UltraToolbarsDockArea6.Size = New System.Drawing.Size(1243, 0)
        '
        'UltraToolbarsDockArea7
        '
        Me.UltraToolbarsDockArea7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea7.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea7.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea7.Location = New System.Drawing.Point(3, 17)
        Me.UltraToolbarsDockArea7.Name = "UltraToolbarsDockArea7"
        Me.UltraToolbarsDockArea7.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea8
        '
        Me.UltraToolbarsDockArea8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea8.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea8.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea8.Location = New System.Drawing.Point(1246, 17)
        Me.UltraToolbarsDockArea8.Name = "UltraToolbarsDockArea8"
        Me.UltraToolbarsDockArea8.Size = New System.Drawing.Size(0, 202)
        '
        'UltraToolbarsDockArea21
        '
        Me.UltraToolbarsDockArea21.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea21.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea21.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea21.Location = New System.Drawing.Point(0, 231)
        Me.UltraToolbarsDockArea21.Name = "UltraToolbarsDockArea21"
        Me.UltraToolbarsDockArea21.Size = New System.Drawing.Size(1249, 0)
        '
        'UltraToolbarsDockArea22
        '
        Me.UltraToolbarsDockArea22.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea22.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea22.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea22.Location = New System.Drawing.Point(0, 453)
        Me.UltraToolbarsDockArea22.Name = "UltraToolbarsDockArea22"
        Me.UltraToolbarsDockArea22.Size = New System.Drawing.Size(1249, 0)
        '
        'UltraToolbarsDockArea23
        '
        Me.UltraToolbarsDockArea23.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea23.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea23.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea23.Location = New System.Drawing.Point(0, 231)
        Me.UltraToolbarsDockArea23.Name = "UltraToolbarsDockArea23"
        Me.UltraToolbarsDockArea23.Size = New System.Drawing.Size(0, 222)
        '
        'UltraToolbarsDockArea24
        '
        Me.UltraToolbarsDockArea24.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea24.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea24.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea24.Location = New System.Drawing.Point(1249, 231)
        Me.UltraToolbarsDockArea24.Name = "UltraToolbarsDockArea24"
        Me.UltraToolbarsDockArea24.Size = New System.Drawing.Size(0, 222)
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.lbl_etiqueta)
        Me.agrDatoGeneral.Controls.Add(Me.fecOrden)
        Me.agrDatoGeneral.Controls.Add(Me.Agrupacion2)
        Me.agrDatoGeneral.Controls.Add(Me.Agrupacion1)
        Me.agrDatoGeneral.Controls.Add(Me.txtProveedor)
        Me.agrDatoGeneral.Controls.Add(Me.txtMovTransf)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta16)
        Me.agrDatoGeneral.Controls.Add(Me.txtEstadoOrden)
        Me.agrDatoGeneral.Controls.Add(Me.etiEstado)
        Me.agrDatoGeneral.Controls.Add(Me.txtNroOrden)
        Me.agrDatoGeneral.Controls.Add(Me.etiNroOrden)
        Me.agrDatoGeneral.Controls.Add(Me.txtGlosa)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta15)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta19)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta20)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(1249, 231)
        Me.agrDatoGeneral.TabIndex = 202
        Me.agrDatoGeneral.Text = "Datos Generales"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Appearance120.ForeColor = System.Drawing.Color.Red
        Me.lbl_etiqueta.Appearance = Appearance120
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_etiqueta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_etiqueta.Location = New System.Drawing.Point(1067, 43)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(175, 18)
        Me.lbl_etiqueta.TabIndex = 310
        Me.lbl_etiqueta.Text = "Ejecutar O. Transferencia"
        Me.lbl_etiqueta.Visible = False
        '
        'fecOrden
        '
        Me.fecOrden.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecOrden.Location = New System.Drawing.Point(512, 25)
        Me.fecOrden.Name = "fecOrden"
        Me.fecOrden.Size = New System.Drawing.Size(98, 20)
        Me.fecOrden.TabIndex = 309
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion2.Controls.Add(Me.cboSubAlmacenDestino)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion2.Controls.Add(Me.cboAlmDestino)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion2.Controls.Add(Me.cboCenDestino)
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(384, 121)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(351, 105)
        Me.Agrupacion2.TabIndex = 308
        Me.Agrupacion2.Text = "Almacén Destino"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta4
        '
        Appearance121.BackColor = System.Drawing.Color.Transparent
        Appearance121.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance121
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(11, 80)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta4.TabIndex = 10
        Me.Etiqueta4.Text = "SubAlmacén:"
        '
        'cboSubAlmacenDestino
        '
        Appearance122.ForeColor = System.Drawing.Color.Black
        Me.cboSubAlmacenDestino.Appearance = Appearance122
        Me.cboSubAlmacenDestino.DisplayMember = "Nombre"
        Me.cboSubAlmacenDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboSubAlmacenDestino.DropDownListWidth = 400
        Me.cboSubAlmacenDestino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboSubAlmacenDestino.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubAlmacenDestino.ForeColor = System.Drawing.Color.Black
        Me.cboSubAlmacenDestino.Location = New System.Drawing.Point(84, 76)
        Me.cboSubAlmacenDestino.Name = "cboSubAlmacenDestino"
        Me.cboSubAlmacenDestino.Size = New System.Drawing.Size(240, 22)
        Me.cboSubAlmacenDestino.TabIndex = 9
        Me.cboSubAlmacenDestino.ValueMember = "Id"
        '
        'Etiqueta11
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance123
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(28, 52)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta11.TabIndex = 8
        Me.Etiqueta11.Text = "Almacén:"
        '
        'cboAlmDestino
        '
        Appearance124.ForeColor = System.Drawing.Color.Black
        Me.cboAlmDestino.Appearance = Appearance124
        Me.cboAlmDestino.DisplayMember = "Nombre"
        Me.cboAlmDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAlmDestino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAlmDestino.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmDestino.ForeColor = System.Drawing.Color.Black
        Me.cboAlmDestino.Location = New System.Drawing.Point(84, 48)
        Me.cboAlmDestino.Name = "cboAlmDestino"
        Me.cboAlmDestino.Size = New System.Drawing.Size(240, 22)
        Me.cboAlmDestino.TabIndex = 7
        Me.cboAlmDestino.ValueMember = "Id"
        '
        'Etiqueta12
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance125
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(38, 24)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta12.TabIndex = 6
        Me.Etiqueta12.Text = "Centro:"
        '
        'cboCenDestino
        '
        Appearance126.ForeColor = System.Drawing.Color.Black
        Me.cboCenDestino.Appearance = Appearance126
        Me.cboCenDestino.DisplayMember = "Nombre"
        Me.cboCenDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCenDestino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCenDestino.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCenDestino.ForeColor = System.Drawing.Color.Black
        Me.cboCenDestino.Location = New System.Drawing.Point(84, 20)
        Me.cboCenDestino.Name = "cboCenDestino"
        Me.cboCenDestino.Size = New System.Drawing.Size(148, 22)
        Me.cboCenDestino.TabIndex = 5
        Me.cboCenDestino.ValueMember = "Id"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.cboAlmacenOrigen)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.cboSubAlmacenOrigen)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion1.Controls.Add(Me.cboCenOrigen)
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(12, 121)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(335, 105)
        Me.Agrupacion1.TabIndex = 307
        Me.Agrupacion1.Text = "Almacén Origen"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboAlmacenOrigen
        '
        Appearance127.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacenOrigen.Appearance = Appearance127
        Me.cboAlmacenOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAlmacenOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAlmacenOrigen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacenOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacenOrigen.Location = New System.Drawing.Point(85, 48)
        Me.cboAlmacenOrigen.Name = "cboAlmacenOrigen"
        Me.cboAlmacenOrigen.Size = New System.Drawing.Size(240, 22)
        Me.cboAlmacenOrigen.TabIndex = 311
        Me.cboAlmacenOrigen.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance128
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(12, 80)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta1.TabIndex = 6
        Me.Etiqueta1.Text = "SubAlmacén:"
        '
        'cboSubAlmacenOrigen
        '
        Appearance129.ForeColor = System.Drawing.Color.Black
        Me.cboSubAlmacenOrigen.Appearance = Appearance129
        Me.cboSubAlmacenOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboSubAlmacenOrigen.DisplayMember = "Nombre"
        Me.cboSubAlmacenOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboSubAlmacenOrigen.DropDownListWidth = 450
        Me.cboSubAlmacenOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboSubAlmacenOrigen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubAlmacenOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboSubAlmacenOrigen.Location = New System.Drawing.Point(85, 76)
        Me.cboSubAlmacenOrigen.Name = "cboSubAlmacenOrigen"
        Me.cboSubAlmacenOrigen.Size = New System.Drawing.Size(240, 22)
        Me.cboSubAlmacenOrigen.TabIndex = 5
        Me.cboSubAlmacenOrigen.ValueMember = "Id"
        '
        'Etiqueta13
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance130
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(30, 52)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta13.TabIndex = 4
        Me.Etiqueta13.Text = "Almacén:"
        '
        'Etiqueta3
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance131
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(39, 24)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Centro:"
        '
        'cboCenOrigen
        '
        Appearance132.ForeColor = System.Drawing.Color.Black
        Me.cboCenOrigen.Appearance = Appearance132
        Me.cboCenOrigen.DisplayMember = "Nombre"
        Me.cboCenOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCenOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCenOrigen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCenOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboCenOrigen.Location = New System.Drawing.Point(85, 20)
        Me.cboCenOrigen.Name = "cboCenOrigen"
        Me.cboCenOrigen.Size = New System.Drawing.Size(148, 22)
        Me.cboCenOrigen.TabIndex = 1
        Me.cboCenOrigen.ValueMember = "Id"
        '
        'txtProveedor
        '
        Appearance133.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtProveedor.Appearance = Appearance133
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtProveedor.Location = New System.Drawing.Point(79, 52)
        Me.txtProveedor.MaxLength = 200
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(351, 22)
        Me.txtProveedor.TabIndex = 306
        Me.txtProveedor.Tag = ""
        '
        'txtMovTransf
        '
        Appearance134.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMovTransf.Appearance = Appearance134
        Me.txtMovTransf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMovTransf.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMovTransf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovTransf.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMovTransf.Location = New System.Drawing.Point(79, 25)
        Me.txtMovTransf.MaxLength = 200
        Me.txtMovTransf.Name = "txtMovTransf"
        Me.txtMovTransf.ReadOnly = True
        Me.txtMovTransf.Size = New System.Drawing.Size(351, 22)
        Me.txtMovTransf.TabIndex = 305
        Me.txtMovTransf.Tag = "1CH000000023"
        Me.txtMovTransf.Text = "ORDEN DE TRANSFERENCIA "
        '
        'Etiqueta16
        '
        Appearance135.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta16.Appearance = Appearance135
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(32, 56)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta16.TabIndex = 304
        Me.Etiqueta16.Text = "Cliente:"
        '
        'txtEstadoOrden
        '
        Appearance136.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEstadoOrden.Appearance = Appearance136
        Me.txtEstadoOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstadoOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstadoOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoOrden.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEstadoOrden.Location = New System.Drawing.Point(512, 79)
        Me.txtEstadoOrden.MaxLength = 200
        Me.txtEstadoOrden.Name = "txtEstadoOrden"
        Me.txtEstadoOrden.ReadOnly = True
        Me.txtEstadoOrden.Size = New System.Drawing.Size(122, 22)
        Me.txtEstadoOrden.TabIndex = 303
        '
        'etiEstado
        '
        Appearance137.BackColor = System.Drawing.Color.Transparent
        Me.etiEstado.Appearance = Appearance137
        Me.etiEstado.AutoSize = True
        Me.etiEstado.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEstado.Location = New System.Drawing.Point(453, 81)
        Me.etiEstado.Name = "etiEstado"
        Me.etiEstado.Size = New System.Drawing.Size(40, 15)
        Me.etiEstado.TabIndex = 302
        Me.etiEstado.Text = "Estado:"
        '
        'txtNroOrden
        '
        Appearance138.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroOrden.Appearance = Appearance138
        Me.txtNroOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrden.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroOrden.Location = New System.Drawing.Point(512, 52)
        Me.txtNroOrden.MaxLength = 200
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.ReadOnly = True
        Me.txtNroOrden.Size = New System.Drawing.Size(122, 22)
        Me.txtNroOrden.TabIndex = 299
        Me.txtNroOrden.Visible = False
        '
        'etiNroOrden
        '
        Appearance139.BackColor = System.Drawing.Color.Transparent
        Me.etiNroOrden.Appearance = Appearance139
        Me.etiNroOrden.AutoSize = True
        Me.etiNroOrden.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNroOrden.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiNroOrden.Location = New System.Drawing.Point(453, 54)
        Me.etiNroOrden.Name = "etiNroOrden"
        Me.etiNroOrden.Size = New System.Drawing.Size(54, 15)
        Me.etiNroOrden.TabIndex = 298
        Me.etiNroOrden.Text = "N° Orden:"
        Me.etiNroOrden.Visible = False
        '
        'txtGlosa
        '
        Appearance140.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance140
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtGlosa.Location = New System.Drawing.Point(79, 79)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(350, 37)
        Me.txtGlosa.TabIndex = 296
        Me.txtGlosa.Tag = "0"
        '
        'Etiqueta15
        '
        Appearance141.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta15.Appearance = Appearance141
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(39, 83)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta15.TabIndex = 297
        Me.Etiqueta15.Text = "Glosa:"
        '
        'Etiqueta19
        '
        Appearance142.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta19.Appearance = Appearance142
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta19.Location = New System.Drawing.Point(453, 27)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta19.TabIndex = 292
        Me.Etiqueta19.Text = "Fecha:"
        '
        'Etiqueta20
        '
        Appearance143.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta20.Appearance = Appearance143
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta20.Location = New System.Drawing.Point(11, 29)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta20.TabIndex = 290
        Me.Etiqueta20.Text = "Tipo Orden:"
        '
        'mcDetalle
        '
        Me.mcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcDetalle.ForeColor = System.Drawing.Color.Black
        Me.mcDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.QuitarToolStripMenuItem})
        Me.mcDetalle.Name = "MenuContextual1"
        Me.mcDetalle.Size = New System.Drawing.Size(112, 48)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        Me.AgregarToolStripMenuItem.ToolTipText = "Insertar un nuevo Detalle"
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        Me.QuitarToolStripMenuItem.ToolTipText = "Quitar detalle seleccionado"
        '
        'ficOrden
        '
        Me.ficOrden.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOrden.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOrden.Controls.Add(Me.UltraTabPageControl2)
        Me.ficOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficOrden.Location = New System.Drawing.Point(0, 24)
        Me.ficOrden.Name = "ficOrden"
        Me.ficOrden.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.UltraTabSharedControlsPage1_Fill_Panel, Me.UltraToolbarsDockArea11, Me.UltraToolbarsDockArea12, Me.UltraToolbarsDockArea9, Me.UltraToolbarsDockArea10})
        Me.ficOrden.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOrden.Size = New System.Drawing.Size(1251, 452)
        Me.ficOrden.TabIndex = 10
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Mantenimiento"
        Me.ficOrden.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab4})
        Me.ficOrden.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraTabSharedControlsPage1_Fill_Panel)
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraToolbarsDockArea11)
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraToolbarsDockArea12)
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraToolbarsDockArea9)
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraToolbarsDockArea10)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1249, 429)
        '
        'frm_OrdenTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1251, 476)
        Me.Controls.Add(Me.ficOrden)
        Me.Name = "frm_OrdenTransferencia"
        Me.Tag = ""
        Me.Text = "Orden de Transferencia"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrOrdenesdeTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOrdenesdeTransferencia.ResumeLayout(False)
        CType(Me.griListaOrdenTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFiltro.ResumeLayout(False)
        Me.agrFiltro.PerformLayout()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.cboEstadoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbOI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOI.ResumeLayout(False)
        Me.gbOI.PerformLayout()
        CType(Me.txtNIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.ColoresTerminada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresRecepcionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalle.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griOrdenMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        Me.agrDatoGeneral.PerformLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.cboSubAlmacenDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAlmDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCenDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboAlmacenOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSubAlmacenOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCenOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMovTransf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcDetalle.ResumeLayout(False)
        CType(Me.ficOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOrden.ResumeLayout(False)
        Me.UltraTabSharedControlsPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents odOrden As ISL.Controles.OrigenDatos
    Friend WithEvents odOrdenMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mcDetalle As ISL.Controles.MenuContextual
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents ficOrden As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabSharedControlsPage1_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents UltraToolbarsDockArea11 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea12 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea9 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea10 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrOrdenesdeTransferencia As ISL.Controles.Agrupacion
    Friend WithEvents griListaOrdenTransferencia As ISL.Controles.Grilla
    Friend WithEvents agrFiltro As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents ColoresTerminada As ISL.Controles.Colores
    Friend WithEvents etiTerminada As ISL.Controles.Etiqueta
    Friend WithEvents ColoresRecepcionado As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents rbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents rbNroOrden As System.Windows.Forms.RadioButton
    Friend WithEvents btnEjecutar As ISL.Controles.Boton
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstadoOrden As ISL.Controles.ComboMaestros
    Friend WithEvents txtNIngreso As ISL.Controles.Texto
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDetalle As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea4 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea17 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea18 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea19 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea20 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea13 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea14 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea15 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea16 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea5 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea6 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea7 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea8 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea21 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea22 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea23 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea24 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents cboAlmDestino As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents cboCenDestino As ISL.Controles.ComboMaestros
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboCenOrigen As ISL.Controles.ComboMaestros
    Friend WithEvents txtProveedor As ISL.Controles.Texto
    Friend WithEvents txtMovTransf As ISL.Controles.Texto
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents txtEstadoOrden As ISL.Controles.Texto
    Friend WithEvents etiEstado As ISL.Controles.Etiqueta
    Friend WithEvents txtNroOrden As ISL.Controles.Texto
    Friend WithEvents etiNroOrden As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents UltraToolbarsDockArea25 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea26 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea27 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea28 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea33 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea34 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea35 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea36 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea29 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea30 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea31 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea32 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea37 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea38 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea39 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea40 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents mnDetalle As ISL.Controles.Menu
    Friend WithEvents UltraToolbarsDockArea41 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea42 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea43 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents griOrdenMaterial As ISL.Controles.Grilla
    Friend WithEvents gbeMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griMaterial As ISL.Controles.Grilla
    Friend WithEvents EjecutarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rfOrdenTransferenciaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfOrdenTransferenciaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents fecOrden As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_etiqueta As ISL.Controles.Etiqueta
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents cboSubAlmacenDestino As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboSubAlmacenOrigen As ISL.Controles.ComboMaestros
    Friend WithEvents cboAlmacenOrigen As ISL.Controles.Combo
    Friend WithEvents gbDatosAdicionales As ISL.Controles.Agrupacion
    Friend WithEvents gbOI As ISL.Controles.Agrupacion
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox

End Class
