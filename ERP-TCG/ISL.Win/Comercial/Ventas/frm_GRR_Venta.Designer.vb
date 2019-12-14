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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_GuiaRR", -1)
        Dim UltraGridColumn520 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn521 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn522 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn523 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn524 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDoc")
        Dim UltraGridColumn525 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn526 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn527 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn528 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn529 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn530 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn531 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVehiculo")
        Dim UltraGridColumn532 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn533 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdChofer")
        Dim UltraGridColumn534 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chofer")
        Dim UltraGridColumn535 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Propietario")
        Dim UltraGridColumn536 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMotivoTraslado")
        Dim UltraGridColumn537 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Partida")
        Dim UltraGridColumn538 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn539 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn540 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn541 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn542 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn543 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn544 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn545 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn546 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
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
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LstDireccion", -1)
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
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LstTelefono", -1)
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
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LstTipoPago_PerEmp", -1)
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
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LstEmail", -1)
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
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LstPersona", -1)
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
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialServicio")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialServicio")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndImpuesto")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PDscto")
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dscto")
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Costo")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_GRR_Venta))
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
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
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
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
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Orden", -1)
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
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn446 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn448 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Orden", -1)
        Dim UltraGridColumn449 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn450 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn451 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMovimientoInventario")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreReferencia")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim UltraGridColumn504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Costo")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn505 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn506 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn507 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn508 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn509 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn510 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn511 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn512 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMinimo")
        Dim UltraGridColumn513 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockMaximo")
        Dim UltraGridColumn514 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StockActual")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn515 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn516 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn517 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn518 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn519 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadPendiente")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndOperacion")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton6 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton7 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand16 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn547 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn548 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn549 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn550 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn551 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn552 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocumento")
        Dim UltraGridColumn553 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn554 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn555 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn556 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndExterno")
        Dim UltraGridColumn557 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim UltraGridColumn558 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn559 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn560 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn561 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn562 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Conductor")
        Dim UltraGridColumn563 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDoc")
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
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton8 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton9 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim EditorButton10 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton11 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.gbeMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ficServicios = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAlmacenMaterial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox12 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chbBuscarCod = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnBuscarMat = New Infragistics.Win.Misc.UltraButton()
        Me.txtMaterial = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridVentas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtSerieD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNroD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.cboPuntoLlegada = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chkAsociar = New System.Windows.Forms.CheckBox()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNroLicencia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNroMTCC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtLlegada = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtPropietarioCarreta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtPropietarioVehiculo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMTC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboChofer = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbVehiculo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboCarreta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtPartida = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbMotivoTraslado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtProveedor = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNumero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtSerie = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFechaDocumento = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.ficGuiaRR = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
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
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.ficServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficServicios.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griAlmacenMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox12.SuspendLayout()
        CType(Me.chbBuscarCod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.gridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.txtSerieD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPuntoLlegada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.txtNroLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroMTCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLlegada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropietarioCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropietarioVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboChofer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMotivoTraslado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficGuiaRR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficGuiaRR.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(798, 427)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.griDocumento)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 130)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(798, 297)
        Me.UltraGroupBox3.TabIndex = 2
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDocumento
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDocumento.DisplayLayout.Appearance = Appearance1
        UltraGridColumn520.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn520.Header.VisiblePosition = 0
        UltraGridColumn520.Hidden = True
        UltraGridColumn521.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn521.Header.VisiblePosition = 1
        UltraGridColumn521.Hidden = True
        UltraGridColumn522.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn522.Header.VisiblePosition = 2
        UltraGridColumn522.Hidden = True
        UltraGridColumn523.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn523.Header.VisiblePosition = 3
        UltraGridColumn523.Hidden = True
        UltraGridColumn524.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn524.Header.VisiblePosition = 4
        UltraGridColumn524.Hidden = True
        UltraGridColumn525.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn525.Header.VisiblePosition = 5
        UltraGridColumn525.Hidden = True
        UltraGridColumn526.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn526.Header.VisiblePosition = 6
        UltraGridColumn527.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn527.Header.VisiblePosition = 10
        UltraGridColumn527.Hidden = True
        UltraGridColumn527.Width = 40
        UltraGridColumn528.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn528.Header.VisiblePosition = 13
        UltraGridColumn528.Width = 60
        UltraGridColumn529.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn529.Header.VisiblePosition = 14
        UltraGridColumn529.Width = 86
        UltraGridColumn530.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn530.Header.VisiblePosition = 7
        UltraGridColumn530.Hidden = True
        UltraGridColumn531.Header.VisiblePosition = 11
        UltraGridColumn532.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn532.Header.VisiblePosition = 8
        UltraGridColumn532.Hidden = True
        UltraGridColumn533.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn533.Header.VisiblePosition = 9
        UltraGridColumn533.Hidden = True
        UltraGridColumn534.Header.VisiblePosition = 15
        UltraGridColumn535.Header.VisiblePosition = 17
        UltraGridColumn536.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn536.Header.VisiblePosition = 19
        UltraGridColumn536.Hidden = True
        UltraGridColumn536.Width = 49
        UltraGridColumn537.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn537.Header.VisiblePosition = 12
        UltraGridColumn537.Hidden = True
        UltraGridColumn538.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn538.Header.VisiblePosition = 16
        UltraGridColumn538.Hidden = True
        UltraGridColumn539.Header.VisiblePosition = 20
        UltraGridColumn539.Hidden = True
        UltraGridColumn540.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn540.Header.VisiblePosition = 21
        UltraGridColumn540.Width = 108
        UltraGridColumn541.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn541.Header.VisiblePosition = 22
        UltraGridColumn541.Hidden = True
        UltraGridColumn541.Width = 50
        UltraGridColumn542.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn542.Header.VisiblePosition = 23
        UltraGridColumn542.Hidden = True
        UltraGridColumn542.Width = 60
        UltraGridColumn543.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn543.Header.VisiblePosition = 24
        UltraGridColumn543.Hidden = True
        UltraGridColumn543.Width = 52
        UltraGridColumn544.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn544.Header.VisiblePosition = 25
        UltraGridColumn544.Hidden = True
        UltraGridColumn544.Width = 27
        UltraGridColumn545.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn545.Header.Caption = "Cliente"
        UltraGridColumn545.Header.VisiblePosition = 18
        UltraGridColumn545.Width = 328
        UltraGridColumn546.Header.VisiblePosition = 26
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn520, UltraGridColumn521, UltraGridColumn522, UltraGridColumn523, UltraGridColumn524, UltraGridColumn525, UltraGridColumn526, UltraGridColumn527, UltraGridColumn528, UltraGridColumn529, UltraGridColumn530, UltraGridColumn531, UltraGridColumn532, UltraGridColumn533, UltraGridColumn534, UltraGridColumn535, UltraGridColumn536, UltraGridColumn537, UltraGridColumn538, UltraGridColumn539, UltraGridColumn540, UltraGridColumn541, UltraGridColumn542, UltraGridColumn543, UltraGridColumn544, UltraGridColumn545, UltraGridColumn546})
        Me.griDocumento.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDocumento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDocumento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.griDocumento.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDocumento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.griDocumento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDocumento.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDocumento.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
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
        Appearance5.BorderColor = System.Drawing.Color.Silver
        Me.griDocumento.DisplayLayout.Override.RowAppearance = Appearance5
        Me.griDocumento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDocumento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDocumento.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.griDocumento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDocumento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDocumento.Location = New System.Drawing.Point(3, 3)
        Me.griDocumento.Name = "griDocumento"
        Me.griDocumento.Size = New System.Drawing.Size(792, 291)
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
        Me.UltraGroupBox2.Size = New System.Drawing.Size(798, 32)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnAnular
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.btnAnular.Appearance = Appearance6
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
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Appearance = Appearance7
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
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.btnEnviar.Appearance = Appearance8
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
        Me.UltraGroupBox1.Size = New System.Drawing.Size(798, 98)
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
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance9
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
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance10
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
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance11
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
        Me.txtNroDoc.MaxLength = 10
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
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance12
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
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance13
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
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance14
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
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Appearance15.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgProveedor.DisplayLayout.Appearance = Appearance15
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
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246})
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
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271, UltraGridColumn272})
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
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286})
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
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295, UltraGridColumn296, UltraGridColumn297, UltraGridColumn298, UltraGridColumn299})
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
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn317, UltraGridColumn318, UltraGridColumn358, UltraGridColumn359, UltraGridColumn360})
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
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn361, UltraGridColumn362, UltraGridColumn363, UltraGridColumn364, UltraGridColumn365, UltraGridColumn366, UltraGridColumn367, UltraGridColumn368, UltraGridColumn369, UltraGridColumn370, UltraGridColumn371, UltraGridColumn372, UltraGridColumn373, UltraGridColumn374})
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.cbgProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.cbgProveedor.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance16.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgProveedor.DisplayLayout.GroupByBox.Appearance = Appearance16
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgProveedor.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance17
        Me.cbgProveedor.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance18.BackColor2 = System.Drawing.SystemColors.Control
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgProveedor.DisplayLayout.GroupByBox.PromptAppearance = Appearance18
        Me.cbgProveedor.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgProveedor.DisplayLayout.MaxRowScrollRegions = 1
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgProveedor.DisplayLayout.Override.ActiveCellAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.SystemColors.Highlight
        Appearance20.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbgProveedor.DisplayLayout.Override.ActiveRowAppearance = Appearance20
        Me.cbgProveedor.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cbgProveedor.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Me.cbgProveedor.DisplayLayout.Override.CardAreaAppearance = Appearance21
        Appearance22.BorderColor = System.Drawing.Color.Silver
        Appearance22.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbgProveedor.DisplayLayout.Override.CellAppearance = Appearance22
        Me.cbgProveedor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgProveedor.DisplayLayout.Override.CellPadding = 0
        Appearance23.BackColor = System.Drawing.SystemColors.Control
        Appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance23.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance23.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgProveedor.DisplayLayout.Override.GroupByRowAppearance = Appearance23
        Appearance24.TextHAlignAsString = "Left"
        Me.cbgProveedor.DisplayLayout.Override.HeaderAppearance = Appearance24
        Me.cbgProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cbgProveedor.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Me.cbgProveedor.DisplayLayout.Override.RowAppearance = Appearance25
        Me.cbgProveedor.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgProveedor.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
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
        UltraTab2.TabPage = Me.UltraTabPageControl7
        UltraTab2.Text = "Orden Salida"
        Me.ficDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6, UltraTab2})
        Me.ficDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1084, 178)
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
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDetalleDocumento.DisplayLayout.Appearance = Appearance27
        UltraGridColumn225.Header.VisiblePosition = 0
        UltraGridColumn225.Hidden = True
        UltraGridColumn226.Header.VisiblePosition = 3
        UltraGridColumn226.Hidden = True
        UltraGridColumn227.Header.VisiblePosition = 4
        UltraGridColumn227.Hidden = True
        UltraGridColumn228.Header.VisiblePosition = 1
        UltraGridColumn228.Hidden = True
        UltraGridColumn229.Header.VisiblePosition = 2
        UltraGridColumn229.Hidden = True
        UltraGridColumn230.Header.Caption = "IdMaterialServivio"
        UltraGridColumn230.Header.VisiblePosition = 5
        UltraGridColumn230.Hidden = True
        UltraGridColumn231.Header.Caption = "SubAlmacen"
        UltraGridColumn231.Header.VisiblePosition = 12
        UltraGridColumn231.Width = 220
        UltraGridColumn232.Header.Caption = "Almacen"
        UltraGridColumn232.Header.VisiblePosition = 11
        UltraGridColumn232.Hidden = True
        UltraGridColumn232.Width = 220
        UltraGridColumn233.Header.VisiblePosition = 9
        UltraGridColumn233.Hidden = True
        UltraGridColumn234.Header.Caption = "UnidadMedida"
        UltraGridColumn234.Header.VisiblePosition = 8
        UltraGridColumn235.Header.VisiblePosition = 6
        UltraGridColumn236.Header.Caption = "Material"
        UltraGridColumn236.Header.VisiblePosition = 7
        UltraGridColumn236.Width = 373
        Appearance28.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn237.CellAppearance = Appearance28
        UltraGridColumn237.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn237.Header.VisiblePosition = 10
        UltraGridColumn237.MaskInput = "{double:9.4}"
        UltraGridColumn237.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn237.Width = 100
        Appearance29.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn238.CellAppearance = Appearance29
        UltraGridColumn238.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn238.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn238.Header.Caption = "C. Unitario"
        UltraGridColumn238.Header.VisiblePosition = 14
        UltraGridColumn238.Hidden = True
        UltraGridColumn238.MaskInput = "{double:9.4}"
        UltraGridColumn238.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn238.Width = 100
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn239.CellAppearance = Appearance30
        UltraGridColumn239.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn239.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn239.Header.Caption = "P.Unitario"
        UltraGridColumn239.Header.VisiblePosition = 15
        UltraGridColumn239.Hidden = True
        UltraGridColumn239.MaskInput = "{double:9.4}"
        UltraGridColumn239.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn239.Width = 100
        UltraGridColumn240.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn240.CellAppearance = Appearance31
        UltraGridColumn240.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn240.Header.Caption = "P.Total"
        UltraGridColumn240.Header.VisiblePosition = 16
        UltraGridColumn240.Hidden = True
        UltraGridColumn240.MaskInput = "{double:9.4}"
        UltraGridColumn240.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn240.Width = 100
        UltraGridColumn241.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn241.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn241.Header.Caption = "IGV"
        UltraGridColumn241.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn241.Header.VisiblePosition = 13
        UltraGridColumn241.Hidden = True
        UltraGridColumn241.Width = 46
        UltraGridColumn242.Header.VisiblePosition = 17
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.Header.VisiblePosition = 18
        UltraGridColumn243.Hidden = True
        UltraGridColumn307.Header.VisiblePosition = 19
        UltraGridColumn307.Hidden = True
        UltraGridColumn308.Header.VisiblePosition = 20
        UltraGridColumn308.Hidden = True
        UltraGridColumn309.Header.VisiblePosition = 21
        UltraGridColumn309.Hidden = True
        UltraGridColumn310.Header.VisiblePosition = 22
        UltraGridColumn310.Hidden = True
        UltraGridColumn311.Header.VisiblePosition = 23
        UltraGridColumn312.Header.VisiblePosition = 24
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn313.CellAppearance = Appearance32
        UltraGridColumn313.Header.Caption = "Peso (Tn)"
        UltraGridColumn313.Header.VisiblePosition = 25
        UltraGridColumn313.MaskInput = "{double:9.2}"
        UltraGridColumn313.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn307, UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313})
        Me.griDetalleDocumento.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griDetalleDocumento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleDocumento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance33.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetalleDocumento.DisplayLayout.GroupByBox.Appearance = Appearance33
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleDocumento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance34
        Me.griDetalleDocumento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleDocumento.DisplayLayout.GroupByBox.Hidden = True
        Appearance35.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance35.BackColor2 = System.Drawing.SystemColors.Control
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleDocumento.DisplayLayout.GroupByBox.PromptAppearance = Appearance35
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
        Appearance36.BorderColor = System.Drawing.Color.Silver
        Me.griDetalleDocumento.DisplayLayout.Override.RowAppearance = Appearance36
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
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance37
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
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance38
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
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn55.CellAppearance = Appearance39
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
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60})
        Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance40.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance40.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance40
        Appearance41.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance41
        Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.GroupByBox.Hidden = True
        Appearance42.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance42.BackColor2 = System.Drawing.SystemColors.Control
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance42.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance42
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
        Appearance43.BorderColor = System.Drawing.Color.Silver
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance43
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
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.UltraCheckEditor1.Appearance = Appearance44
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
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Appearance45.Image = CType(resources.GetObject("Appearance45.Image"), Object)
        Appearance45.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton1.Appearance = Appearance45
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
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Appearance46.TextVAlignAsString = "Middle"
        Me.UltraLabel30.Appearance = Appearance46
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
        '
        'btnQuitarD
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Appearance47.Image = CType(resources.GetObject("Appearance47.Image"), Object)
        Me.btnQuitarD.Appearance = Appearance47
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
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Appearance48.Image = CType(resources.GetObject("Appearance48.Image"), Object)
        Me.btnAgregarD.Appearance = Appearance48
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
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1350, 345)
        '
        'gbeOrdenes
        '
        Me.gbeOrdenes.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeOrdenes.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.gbeOrdenes.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeOrdenes.Expanded = False
        Me.gbeOrdenes.ExpandedSize = New System.Drawing.Size(740, 315)
        Me.gbeOrdenes.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeOrdenes.Location = New System.Drawing.Point(1328, 30)
        Me.gbeOrdenes.Name = "gbeOrdenes"
        Me.gbeOrdenes.Size = New System.Drawing.Size(22, 315)
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
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Appearance49.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenComercial.DisplayLayout.Appearance = Appearance49
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
        Appearance50.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn15.CellAppearance = Appearance50
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
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn183, UltraGridColumn184})
        Me.griOrdenComercial.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.griOrdenComercial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance51.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance51.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Appearance = Appearance51
        Appearance52.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance52
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Hidden = True
        Appearance53.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance53.BackColor2 = System.Drawing.SystemColors.Control
        Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance53.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.PromptAppearance = Appearance53
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
        Appearance54.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenComercial.DisplayLayout.Override.RowAppearance = Appearance54
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
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Appearance55.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance55
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
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Appearance56.Image = CType(resources.GetObject("Appearance56.Image"), Object)
        Me.UltraButton2.Appearance = Appearance56
        Me.UltraButton2.Location = New System.Drawing.Point(506, 6)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(87, 27)
        Me.UltraButton2.TabIndex = 340
        Me.UltraButton2.Text = "Consultar"
        Me.UltraButton2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel22
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Appearance57.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance57
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
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Appearance58.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance58
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
        Appearance59.BackColor = System.Drawing.SystemColors.Window
        Appearance59.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenDocumento.DisplayLayout.Appearance = Appearance59
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
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn458, UltraGridColumn459, UltraGridColumn460, UltraGridColumn461, UltraGridColumn462, UltraGridColumn463, UltraGridColumn464, UltraGridColumn465, UltraGridColumn466, UltraGridColumn467, UltraGridColumn468, UltraGridColumn469, UltraGridColumn470, UltraGridColumn471, UltraGridColumn472})
        Me.griOrdenDocumento.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.griOrdenDocumento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenDocumento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance60.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance60.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance60.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenDocumento.DisplayLayout.GroupByBox.Appearance = Appearance60
        Appearance61.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenDocumento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance61
        Me.griOrdenDocumento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenDocumento.DisplayLayout.GroupByBox.Hidden = True
        Appearance62.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance62.BackColor2 = System.Drawing.SystemColors.Control
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance62.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenDocumento.DisplayLayout.GroupByBox.PromptAppearance = Appearance62
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
        Appearance63.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenDocumento.DisplayLayout.Override.RowAppearance = Appearance63
        Me.griOrdenDocumento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenDocumento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenDocumento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenDocumento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenDocumento.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenDocumento.Location = New System.Drawing.Point(0, 30)
        Me.griOrdenDocumento.Name = "griOrdenDocumento"
        Me.griOrdenDocumento.Size = New System.Drawing.Size(1350, 315)
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
        Me.UltraGroupBox15.Size = New System.Drawing.Size(1350, 30)
        Me.UltraGroupBox15.TabIndex = 0
        Me.UltraGroupBox15.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'BtnQuitarOv
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Appearance64.Image = CType(resources.GetObject("Appearance64.Image"), Object)
        Me.BtnQuitarOv.Appearance = Appearance64
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
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Appearance65.Image = CType(resources.GetObject("Appearance65.Image"), Object)
        Me.btnAgregarOv.Appearance = Appearance65
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
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1350, 345)
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox2.Expanded = False
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(740, 315)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(1328, 30)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(22, 315)
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
        Appearance66.BackColor = System.Drawing.SystemColors.Window
        Appearance66.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.GriOrdenesSalidas.DisplayLayout.Appearance = Appearance66
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
        Appearance67.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn402.CellAppearance = Appearance67
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
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn385, UltraGridColumn386, UltraGridColumn387, UltraGridColumn388, UltraGridColumn389, UltraGridColumn390, UltraGridColumn391, UltraGridColumn392, UltraGridColumn393, UltraGridColumn394, UltraGridColumn395, UltraGridColumn396, UltraGridColumn397, UltraGridColumn398, UltraGridColumn399, UltraGridColumn400, UltraGridColumn401, UltraGridColumn402, UltraGridColumn403, UltraGridColumn404, UltraGridColumn405, UltraGridColumn406, UltraGridColumn407, UltraGridColumn408, UltraGridColumn446, UltraGridColumn448})
        Me.GriOrdenesSalidas.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.GriOrdenesSalidas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.GriOrdenesSalidas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance68.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance68.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance68.BorderColor = System.Drawing.SystemColors.Window
        Me.GriOrdenesSalidas.DisplayLayout.GroupByBox.Appearance = Appearance68
        Appearance69.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GriOrdenesSalidas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance69
        Me.GriOrdenesSalidas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.GriOrdenesSalidas.DisplayLayout.GroupByBox.Hidden = True
        Appearance70.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance70.BackColor2 = System.Drawing.SystemColors.Control
        Appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance70.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GriOrdenesSalidas.DisplayLayout.GroupByBox.PromptAppearance = Appearance70
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
        Appearance71.BorderColor = System.Drawing.Color.Silver
        Me.GriOrdenesSalidas.DisplayLayout.Override.RowAppearance = Appearance71
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
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Appearance72.Image = CType(resources.GetObject("Appearance72.Image"), Object)
        Me.btmConsultar.Appearance = Appearance72
        Me.btmConsultar.Location = New System.Drawing.Point(315, 6)
        Me.btmConsultar.Name = "btmConsultar"
        Me.btmConsultar.Size = New System.Drawing.Size(87, 27)
        Me.btmConsultar.TabIndex = 340
        Me.btmConsultar.Text = "Consultar"
        Me.btmConsultar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel27
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Appearance73.TextVAlignAsString = "Middle"
        Me.UltraLabel27.Appearance = Appearance73
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
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Appearance74.TextVAlignAsString = "Middle"
        Me.UltraLabel28.Appearance = Appearance74
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
        Appearance75.BackColor = System.Drawing.SystemColors.Window
        Appearance75.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenSalida.DisplayLayout.Appearance = Appearance75
        Appearance76.TextVAlignAsString = "Middle"
        UltraGridColumn449.CellAppearance = Appearance76
        UltraGridColumn449.Header.VisiblePosition = 0
        UltraGridColumn449.Hidden = True
        Appearance77.TextVAlignAsString = "Middle"
        UltraGridColumn450.CellAppearance = Appearance77
        UltraGridColumn450.Header.VisiblePosition = 1
        UltraGridColumn450.Hidden = True
        Appearance78.TextVAlignAsString = "Middle"
        UltraGridColumn451.CellAppearance = Appearance78
        UltraGridColumn451.Header.VisiblePosition = 2
        UltraGridColumn451.Hidden = True
        Appearance79.TextVAlignAsString = "Middle"
        UltraGridColumn473.CellAppearance = Appearance79
        UltraGridColumn473.Header.VisiblePosition = 3
        UltraGridColumn473.Hidden = True
        Appearance80.TextVAlignAsString = "Middle"
        UltraGridColumn474.CellAppearance = Appearance80
        UltraGridColumn474.Header.VisiblePosition = 6
        UltraGridColumn474.Width = 211
        Appearance81.TextHAlignAsString = "Center"
        Appearance81.TextVAlignAsString = "Middle"
        UltraGridColumn475.CellAppearance = Appearance81
        UltraGridColumn475.Header.VisiblePosition = 7
        UltraGridColumn475.Hidden = True
        Appearance82.TextVAlignAsString = "Middle"
        UltraGridColumn476.CellAppearance = Appearance82
        UltraGridColumn476.Header.VisiblePosition = 8
        UltraGridColumn476.Width = 83
        Appearance83.TextVAlignAsString = "Middle"
        UltraGridColumn477.CellAppearance = Appearance83
        UltraGridColumn477.Header.VisiblePosition = 9
        UltraGridColumn477.Hidden = True
        Appearance84.TextVAlignAsString = "Middle"
        UltraGridColumn478.CellAppearance = Appearance84
        UltraGridColumn478.Header.VisiblePosition = 23
        UltraGridColumn478.Width = 108
        Appearance85.TextVAlignAsString = "Middle"
        UltraGridColumn479.CellAppearance = Appearance85
        UltraGridColumn479.Header.VisiblePosition = 11
        UltraGridColumn479.Hidden = True
        Appearance86.TextVAlignAsString = "Middle"
        UltraGridColumn480.CellAppearance = Appearance86
        UltraGridColumn480.Header.VisiblePosition = 13
        UltraGridColumn480.Hidden = True
        Appearance87.TextVAlignAsString = "Middle"
        UltraGridColumn481.CellAppearance = Appearance87
        UltraGridColumn481.Header.VisiblePosition = 5
        UltraGridColumn481.Width = 108
        Appearance88.TextVAlignAsString = "Middle"
        UltraGridColumn482.CellAppearance = Appearance88
        UltraGridColumn482.Header.VisiblePosition = 19
        UltraGridColumn482.Hidden = True
        UltraGridColumn482.Width = 133
        Appearance89.TextVAlignAsString = "Middle"
        UltraGridColumn483.CellAppearance = Appearance89
        UltraGridColumn483.Header.Caption = "TipoReferencia"
        UltraGridColumn483.Header.VisiblePosition = 18
        UltraGridColumn483.Width = 141
        Appearance90.TextVAlignAsString = "Middle"
        UltraGridColumn484.CellAppearance = Appearance90
        UltraGridColumn484.Header.VisiblePosition = 20
        UltraGridColumn484.Hidden = True
        Appearance91.TextVAlignAsString = "Middle"
        UltraGridColumn485.CellAppearance = Appearance91
        UltraGridColumn485.Header.VisiblePosition = 21
        UltraGridColumn485.Width = 115
        Appearance92.TextVAlignAsString = "Middle"
        UltraGridColumn486.CellAppearance = Appearance92
        UltraGridColumn486.Header.VisiblePosition = 16
        UltraGridColumn486.Hidden = True
        Appearance93.TextVAlignAsString = "Middle"
        UltraGridColumn487.CellAppearance = Appearance93
        UltraGridColumn487.Header.VisiblePosition = 22
        UltraGridColumn487.Width = 245
        Appearance94.TextHAlignAsString = "Right"
        Appearance94.TextVAlignAsString = "Middle"
        UltraGridColumn488.CellAppearance = Appearance94
        UltraGridColumn488.Format = "###,##0.00"
        UltraGridColumn488.Header.VisiblePosition = 17
        UltraGridColumn488.MaskInput = "{double:9.2}"
        UltraGridColumn488.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn488.Width = 91
        Appearance95.TextVAlignAsString = "Middle"
        UltraGridColumn489.CellAppearance = Appearance95
        UltraGridColumn489.Header.VisiblePosition = 24
        UltraGridColumn489.Hidden = True
        Appearance96.TextVAlignAsString = "Middle"
        UltraGridColumn490.CellAppearance = Appearance96
        UltraGridColumn490.Header.VisiblePosition = 25
        UltraGridColumn490.Hidden = True
        Appearance97.TextVAlignAsString = "Middle"
        UltraGridColumn491.CellAppearance = Appearance97
        UltraGridColumn491.Header.VisiblePosition = 10
        UltraGridColumn491.Hidden = True
        Appearance98.TextVAlignAsString = "Middle"
        UltraGridColumn492.CellAppearance = Appearance98
        UltraGridColumn492.Header.Caption = "Fecha"
        UltraGridColumn492.Header.VisiblePosition = 4
        UltraGridColumn492.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn492.Width = 133
        Appearance99.TextVAlignAsString = "Middle"
        UltraGridColumn493.CellAppearance = Appearance99
        UltraGridColumn493.Header.VisiblePosition = 12
        UltraGridColumn493.Hidden = True
        Appearance100.TextVAlignAsString = "Middle"
        UltraGridColumn494.CellAppearance = Appearance100
        UltraGridColumn494.Header.VisiblePosition = 14
        UltraGridColumn494.Hidden = True
        Appearance101.TextVAlignAsString = "Middle"
        UltraGridColumn495.CellAppearance = Appearance101
        UltraGridColumn495.Header.VisiblePosition = 15
        UltraGridColumn495.Hidden = True
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn449, UltraGridColumn450, UltraGridColumn451, UltraGridColumn473, UltraGridColumn474, UltraGridColumn475, UltraGridColumn476, UltraGridColumn477, UltraGridColumn478, UltraGridColumn479, UltraGridColumn480, UltraGridColumn481, UltraGridColumn482, UltraGridColumn483, UltraGridColumn484, UltraGridColumn485, UltraGridColumn486, UltraGridColumn487, UltraGridColumn488, UltraGridColumn489, UltraGridColumn490, UltraGridColumn491, UltraGridColumn492, UltraGridColumn493, UltraGridColumn494, UltraGridColumn495})
        Me.griOrdenSalida.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.griOrdenSalida.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenSalida.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance102.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance102.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance102.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenSalida.DisplayLayout.GroupByBox.Appearance = Appearance102
        Appearance103.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenSalida.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance103
        Me.griOrdenSalida.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenSalida.DisplayLayout.GroupByBox.Hidden = True
        Appearance104.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance104.BackColor2 = System.Drawing.SystemColors.Control
        Appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance104.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenSalida.DisplayLayout.GroupByBox.PromptAppearance = Appearance104
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
        Appearance105.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenSalida.DisplayLayout.Override.RowAppearance = Appearance105
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
        Me.griOrdenSalida.Size = New System.Drawing.Size(1350, 315)
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
        Me.UltraGroupBox16.Size = New System.Drawing.Size(1350, 30)
        Me.UltraGroupBox16.TabIndex = 0
        Me.UltraGroupBox16.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnQuitarOs
        '
        Appearance106.BackColor = System.Drawing.Color.Transparent
        Appearance106.ForeColor = System.Drawing.Color.Navy
        Appearance106.Image = CType(resources.GetObject("Appearance106.Image"), Object)
        Me.btnQuitarOs.Appearance = Appearance106
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
        Appearance107.BackColor = System.Drawing.Color.Transparent
        Appearance107.ForeColor = System.Drawing.Color.Navy
        Appearance107.Image = CType(resources.GetObject("Appearance107.Image"), Object)
        Me.btnAgregarOs.Appearance = Appearance107
        Me.btnAgregarOs.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgregarOs.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregarOs.Name = "btnAgregarOs"
        Me.btnAgregarOs.Size = New System.Drawing.Size(87, 24)
        Me.btnAgregarOs.TabIndex = 0
        Me.btnAgregarOs.Text = "Agregar"
        Me.btnAgregarOs.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.gbeMateriales)
        Me.UltraGroupBox4.Controls.Add(Me.cboPuntoLlegada)
        Me.UltraGroupBox4.Controls.Add(Me.chkAsociar)
        Me.UltraGroupBox4.Controls.Add(Me.UltraGroupBox6)
        Me.UltraGroupBox4.Controls.Add(Me.txtPartida)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox4.Controls.Add(Me.cmbMotivoTraslado)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox4.Controls.Add(Me.txtProveedor)
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
        'gbeMateriales
        '
        Me.gbeMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeMateriales.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeMateriales.Expanded = False
        Me.gbeMateriales.ExpandedSize = New System.Drawing.Size(670, 220)
        Me.gbeMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.gbeMateriales.Location = New System.Drawing.Point(1055, 3)
        Me.gbeMateriales.Name = "gbeMateriales"
        Me.gbeMateriales.Size = New System.Drawing.Size(28, 220)
        Me.gbeMateriales.TabIndex = 20
        Me.gbeMateriales.Text = "Materiales"
        Me.gbeMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.gbeMateriales.Visible = False
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ficServicios)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(647, 309)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'ficServicios
        '
        Me.ficServicios.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficServicios.Controls.Add(Me.UltraTabPageControl3)
        Me.ficServicios.Controls.Add(Me.UltraTabPageControl4)
        Me.ficServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficServicios.Location = New System.Drawing.Point(0, 0)
        Me.ficServicios.Name = "ficServicios"
        Me.ficServicios.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficServicios.Size = New System.Drawing.Size(647, 309)
        Me.ficServicios.TabIndex = 1
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Materiales"
        UltraTab3.Visible = False
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Documentos"
        Me.ficServicios.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.ficServicios.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(645, 286)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griAlmacenMaterial)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox12)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(645, 286)
        '
        'griAlmacenMaterial
        '
        Appearance108.BackColor = System.Drawing.SystemColors.Window
        Appearance108.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAlmacenMaterial.DisplayLayout.Appearance = Appearance108
        UltraGridColumn496.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn496.Header.Caption = ""
        UltraGridColumn496.Header.VisiblePosition = 5
        UltraGridColumn496.Width = 29
        UltraGridColumn497.Header.VisiblePosition = 0
        UltraGridColumn497.Hidden = True
        UltraGridColumn498.Header.VisiblePosition = 1
        UltraGridColumn498.Hidden = True
        UltraGridColumn499.Header.VisiblePosition = 2
        UltraGridColumn499.Hidden = True
        UltraGridColumn500.Header.Caption = ""
        UltraGridColumn500.Header.VisiblePosition = 3
        UltraGridColumn500.Hidden = True
        UltraGridColumn501.Header.VisiblePosition = 4
        UltraGridColumn501.Hidden = True
        UltraGridColumn502.Header.VisiblePosition = 6
        UltraGridColumn502.Width = 211
        UltraGridColumn503.Header.VisiblePosition = 7
        UltraGridColumn503.Width = 200
        Appearance109.TextHAlignAsString = "Right"
        UltraGridColumn504.CellAppearance = Appearance109
        UltraGridColumn504.Header.VisiblePosition = 8
        UltraGridColumn504.MaskInput = "{double:9.4}"
        UltraGridColumn504.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn505.Header.VisiblePosition = 9
        UltraGridColumn505.Hidden = True
        UltraGridColumn506.Header.VisiblePosition = 10
        UltraGridColumn506.Hidden = True
        UltraGridColumn507.Header.VisiblePosition = 11
        UltraGridColumn507.Hidden = True
        UltraGridColumn508.Header.VisiblePosition = 12
        UltraGridColumn508.Hidden = True
        UltraGridColumn509.Header.VisiblePosition = 13
        UltraGridColumn509.Hidden = True
        UltraGridColumn510.Header.VisiblePosition = 14
        UltraGridColumn510.Hidden = True
        UltraGridColumn511.Header.VisiblePosition = 15
        UltraGridColumn511.Hidden = True
        UltraGridColumn512.Header.VisiblePosition = 16
        UltraGridColumn512.Hidden = True
        UltraGridColumn513.Header.VisiblePosition = 17
        UltraGridColumn513.Hidden = True
        Appearance110.TextHAlignAsString = "Right"
        UltraGridColumn514.CellAppearance = Appearance110
        UltraGridColumn514.Header.Caption = "Stock"
        UltraGridColumn514.Header.VisiblePosition = 18
        UltraGridColumn514.MaskInput = "{double:9.4}"
        UltraGridColumn514.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn515.Header.VisiblePosition = 19
        UltraGridColumn515.Hidden = True
        UltraGridColumn516.Header.VisiblePosition = 20
        UltraGridColumn516.Hidden = True
        UltraGridColumn517.Header.VisiblePosition = 21
        UltraGridColumn517.Hidden = True
        UltraGridColumn518.Header.VisiblePosition = 22
        UltraGridColumn518.Hidden = True
        UltraGridColumn519.Header.VisiblePosition = 23
        UltraGridColumn519.Hidden = True
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn496, UltraGridColumn497, UltraGridColumn498, UltraGridColumn499, UltraGridColumn500, UltraGridColumn501, UltraGridColumn502, UltraGridColumn503, UltraGridColumn504, UltraGridColumn505, UltraGridColumn506, UltraGridColumn507, UltraGridColumn508, UltraGridColumn509, UltraGridColumn510, UltraGridColumn511, UltraGridColumn512, UltraGridColumn513, UltraGridColumn514, UltraGridColumn515, UltraGridColumn516, UltraGridColumn517, UltraGridColumn518, UltraGridColumn519})
        Me.griAlmacenMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.griAlmacenMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAlmacenMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance111.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance111.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance111.BorderColor = System.Drawing.SystemColors.Window
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.Appearance = Appearance111
        Appearance112.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance112
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance113.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance113.BackColor2 = System.Drawing.SystemColors.Control
        Appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance113.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance113
        Me.griAlmacenMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griAlmacenMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griAlmacenMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAlmacenMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAlmacenMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAlmacenMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAlmacenMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAlmacenMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAlmacenMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance114.BorderColor = System.Drawing.Color.Silver
        Me.griAlmacenMaterial.DisplayLayout.Override.RowAppearance = Appearance114
        Me.griAlmacenMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        Me.griAlmacenMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAlmacenMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAlmacenMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAlmacenMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griAlmacenMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAlmacenMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlmacenMaterial.Location = New System.Drawing.Point(0, 42)
        Me.griAlmacenMaterial.Name = "griAlmacenMaterial"
        Me.griAlmacenMaterial.Size = New System.Drawing.Size(645, 244)
        Me.griAlmacenMaterial.TabIndex = 10
        Me.griAlmacenMaterial.Text = "Grilla2"
        '
        'UltraGroupBox12
        '
        Me.UltraGroupBox12.Controls.Add(Me.chbBuscarCod)
        Me.UltraGroupBox12.Controls.Add(Me.btnBuscarMat)
        Me.UltraGroupBox12.Controls.Add(Me.txtMaterial)
        Me.UltraGroupBox12.Controls.Add(Me.UltraLabel20)
        Me.UltraGroupBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox12.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox12.Name = "UltraGroupBox12"
        Me.UltraGroupBox12.Size = New System.Drawing.Size(645, 42)
        Me.UltraGroupBox12.TabIndex = 9
        Me.UltraGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chbBuscarCod
        '
        Appearance115.ForeColor = System.Drawing.Color.Navy
        Me.chbBuscarCod.Appearance = Appearance115
        Me.chbBuscarCod.BackColor = System.Drawing.Color.Transparent
        Me.chbBuscarCod.BackColorInternal = System.Drawing.Color.Transparent
        Me.chbBuscarCod.Location = New System.Drawing.Point(403, 12)
        Me.chbBuscarCod.Name = "chbBuscarCod"
        Me.chbBuscarCod.Size = New System.Drawing.Size(60, 22)
        Me.chbBuscarCod.TabIndex = 347
        Me.chbBuscarCod.Text = "Codigo"
        '
        'btnBuscarMat
        '
        Appearance116.BackColor = System.Drawing.Color.Transparent
        Appearance116.ForeColor = System.Drawing.Color.Navy
        Appearance116.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnBuscarMat.Appearance = Appearance116
        Me.btnBuscarMat.Location = New System.Drawing.Point(367, 8)
        Me.btnBuscarMat.Name = "btnBuscarMat"
        Me.btnBuscarMat.Size = New System.Drawing.Size(30, 28)
        Me.btnBuscarMat.TabIndex = 347
        '
        'txtMaterial
        '
        Me.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMaterial.Location = New System.Drawing.Point(76, 12)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(288, 22)
        Me.txtMaterial.TabIndex = 346
        '
        'UltraLabel20
        '
        Appearance117.BackColor = System.Drawing.Color.Transparent
        Appearance117.ForeColor = System.Drawing.Color.Navy
        Appearance117.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance117
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(11, 16)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel20.TabIndex = 345
        Me.UltraLabel20.Text = "Materiales:"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.gridVentas)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox7)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(645, 286)
        '
        'gridVentas
        '
        Appearance118.BackColor = System.Drawing.SystemColors.Window
        Appearance118.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridVentas.DisplayLayout.Appearance = Appearance118
        UltraGridColumn79.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn79.Header.VisiblePosition = 1
        UltraGridColumn79.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn79.Width = 33
        UltraGridColumn80.Header.VisiblePosition = 0
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 2
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 3
        UltraGridColumn82.Hidden = True
        UltraGridColumn82.Width = 61
        UltraGridColumn83.Header.VisiblePosition = 6
        UltraGridColumn83.Hidden = True
        UltraGridColumn83.MaskInput = "{LOC}mm/dd/yyyy"
        UltraGridColumn83.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn84.Header.Caption = "Proveedor"
        UltraGridColumn84.Header.VisiblePosition = 4
        UltraGridColumn84.Width = 146
        UltraGridColumn85.Header.VisiblePosition = 8
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 7
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.Caption = "Material"
        UltraGridColumn87.Header.VisiblePosition = 5
        UltraGridColumn87.Width = 143
        UltraGridColumn88.Header.Caption = "UMedida"
        UltraGridColumn88.Header.VisiblePosition = 10
        UltraGridColumn88.Width = 53
        Appearance119.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn89.CellAppearance = Appearance119
        UltraGridColumn89.Header.VisiblePosition = 11
        UltraGridColumn89.Hidden = True
        UltraGridColumn89.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn89.Width = 56
        Appearance120.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn90.CellAppearance = Appearance120
        UltraGridColumn90.Header.VisiblePosition = 12
        UltraGridColumn90.Width = 62
        UltraGridColumn91.Header.VisiblePosition = 9
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.Caption = "Origen"
        UltraGridColumn92.Header.VisiblePosition = 13
        UltraGridColumn92.Width = 140
        UltraGridColumn93.Header.Caption = "Destino"
        UltraGridColumn93.Header.VisiblePosition = 14
        UltraGridColumn93.Width = 131
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93})
        Me.gridVentas.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.gridVentas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridVentas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance121.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance121.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance121.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance121.BorderColor = System.Drawing.SystemColors.Window
        Me.gridVentas.DisplayLayout.GroupByBox.Appearance = Appearance121
        Appearance122.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridVentas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance122
        Me.gridVentas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridVentas.DisplayLayout.GroupByBox.Hidden = True
        Appearance123.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance123.BackColor2 = System.Drawing.SystemColors.Control
        Appearance123.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance123.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridVentas.DisplayLayout.GroupByBox.PromptAppearance = Appearance123
        Me.gridVentas.DisplayLayout.MaxColScrollRegions = 1
        Me.gridVentas.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridVentas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridVentas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridVentas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridVentas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridVentas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridVentas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridVentas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridVentas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridVentas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridVentas.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.gridVentas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridVentas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridVentas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gridVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridVentas.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.gridVentas.Location = New System.Drawing.Point(0, 40)
        Me.gridVentas.Name = "gridVentas"
        Me.gridVentas.Size = New System.Drawing.Size(645, 246)
        Me.gridVentas.TabIndex = 85
        Me.gridVentas.Text = "Grilla2"
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox7.Controls.Add(Me.txtSerieD)
        Me.UltraGroupBox7.Controls.Add(Me.txtNroD)
        Me.UltraGroupBox7.Controls.Add(Me.btnConsultar)
        Me.UltraGroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(645, 40)
        Me.UltraGroupBox7.TabIndex = 1
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel7
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Appearance124.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance124
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(10, 18)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(89, 15)
        Me.UltraLabel7.TabIndex = 343
        Me.UltraLabel7.Text = "Ingrese Numero:"
        '
        'txtSerieD
        '
        Me.txtSerieD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieD.Location = New System.Drawing.Point(105, 11)
        Me.txtSerieD.MaxLength = 4
        Me.txtSerieD.Name = "txtSerieD"
        Me.txtSerieD.Size = New System.Drawing.Size(56, 22)
        Me.txtSerieD.TabIndex = 341
        '
        'txtNroD
        '
        Me.txtNroD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroD.Location = New System.Drawing.Point(167, 11)
        Me.txtNroD.MaxLength = 10
        Me.txtNroD.Name = "txtNroD"
        Me.txtNroD.Size = New System.Drawing.Size(113, 22)
        Me.txtNroD.TabIndex = 342
        '
        'btnConsultar
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Me.btnConsultar.Appearance = Appearance125
        Me.btnConsultar.Location = New System.Drawing.Point(286, 7)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(87, 27)
        Me.btnConsultar.TabIndex = 340
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'cboPuntoLlegada
        '
        Me.cboPuntoLlegada.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        EditorButton1.Key = "Left"
        Me.cboPuntoLlegada.ButtonsLeft.Add(EditorButton1)
        EditorButton2.Key = "Right"
        Me.cboPuntoLlegada.ButtonsRight.Add(EditorButton2)
        Me.cboPuntoLlegada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboPuntoLlegada.Location = New System.Drawing.Point(78, 191)
        Me.cboPuntoLlegada.Name = "cboPuntoLlegada"
        Me.cboPuntoLlegada.Size = New System.Drawing.Size(778, 22)
        Me.cboPuntoLlegada.TabIndex = 13
        '
        'chkAsociar
        '
        Me.chkAsociar.AutoSize = True
        Me.chkAsociar.BackColor = System.Drawing.Color.Transparent
        Me.chkAsociar.ForeColor = System.Drawing.Color.Navy
        Me.chkAsociar.Location = New System.Drawing.Point(862, 193)
        Me.chkAsociar.Name = "chkAsociar"
        Me.chkAsociar.Size = New System.Drawing.Size(118, 17)
        Me.chkAsociar.TabIndex = 14
        Me.chkAsociar.Text = "Asociar Documento"
        Me.chkAsociar.UseVisualStyleBackColor = False
        Me.chkAsociar.Visible = False
        '
        'UltraGroupBox6
        '
        Appearance126.BackColor = System.Drawing.Color.Black
        Me.UltraGroupBox6.Appearance = Appearance126
        Me.UltraGroupBox6.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.RectangularSolid
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox6.Controls.Add(Me.txtNroLicencia)
        Me.UltraGroupBox6.Controls.Add(Me.txtNroMTCC)
        Me.UltraGroupBox6.Controls.Add(Me.txtLlegada)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox6.Controls.Add(Me.txtPropietarioCarreta)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox6.Controls.Add(Me.txtPropietarioVehiculo)
        Me.UltraGroupBox6.Controls.Add(Me.txtMTC)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox6.Controls.Add(Me.cboChofer)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox6.Controls.Add(Me.cmbVehiculo)
        Me.UltraGroupBox6.Controls.Add(Me.cboCarreta)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox6.Location = New System.Drawing.Point(6, 42)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(929, 115)
        Me.UltraGroupBox6.TabIndex = 9
        Me.UltraGroupBox6.Text = "Datos Transporte"
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel17
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.Navy
        Appearance127.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance127
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(470, 87)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(68, 15)
        Me.UltraLabel17.TabIndex = 14
        Me.UltraLabel17.Text = "N°. Licencia:"
        '
        'txtNroLicencia
        '
        EditorButton3.Key = "Right"
        Me.txtNroLicencia.ButtonsRight.Add(EditorButton3)
        Me.txtNroLicencia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroLicencia.Location = New System.Drawing.Point(547, 83)
        Me.txtNroLicencia.MaxLength = 9
        Me.txtNroLicencia.Name = "txtNroLicencia"
        Me.txtNroLicencia.Size = New System.Drawing.Size(182, 22)
        Me.txtNroLicencia.TabIndex = 15
        Me.txtNroLicencia.Tag = "Numero Documento"
        '
        'txtNroMTCC
        '
        EditorButton4.Key = "Right"
        Me.txtNroMTCC.ButtonsRight.Add(EditorButton4)
        Me.txtNroMTCC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroMTCC.Location = New System.Drawing.Point(764, 27)
        Me.txtNroMTCC.MaxLength = 10
        Me.txtNroMTCC.Name = "txtNroMTCC"
        Me.txtNroMTCC.Size = New System.Drawing.Size(147, 22)
        Me.txtNroMTCC.TabIndex = 11
        Me.txtNroMTCC.Tag = "Numero Documento"
        '
        'txtLlegada
        '
        Me.txtLlegada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtLlegada.Location = New System.Drawing.Point(735, 83)
        Me.txtLlegada.Name = "txtLlegada"
        Me.txtLlegada.Size = New System.Drawing.Size(10, 22)
        Me.txtLlegada.TabIndex = 16
        Me.txtLlegada.TabStop = False
        Me.txtLlegada.Visible = False
        '
        'UltraLabel14
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance128
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(710, 33)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel14.TabIndex = 10
        Me.UltraLabel14.Text = "N° MTC:"
        '
        'UltraLabel13
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Appearance129.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance129
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(476, 59)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(62, 15)
        Me.UltraLabel13.TabIndex = 12
        Me.UltraLabel13.Text = "Propietario:"
        '
        'txtPropietarioCarreta
        '
        Me.txtPropietarioCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPropietarioCarreta.Location = New System.Drawing.Point(547, 55)
        Me.txtPropietarioCarreta.MaxLength = 10
        Me.txtPropietarioCarreta.Name = "txtPropietarioCarreta"
        Me.txtPropietarioCarreta.ReadOnly = True
        Me.txtPropietarioCarreta.Size = New System.Drawing.Size(364, 22)
        Me.txtPropietarioCarreta.TabIndex = 13
        Me.txtPropietarioCarreta.Tag = "Numero Documento"
        '
        'UltraLabel12
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.Navy
        Appearance130.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance130
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(3, 62)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(62, 15)
        Me.UltraLabel12.TabIndex = 4
        Me.UltraLabel12.Text = "Propietario:"
        '
        'txtPropietarioVehiculo
        '
        Me.txtPropietarioVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPropietarioVehiculo.Location = New System.Drawing.Point(72, 55)
        Me.txtPropietarioVehiculo.MaxLength = 10
        Me.txtPropietarioVehiculo.Name = "txtPropietarioVehiculo"
        Me.txtPropietarioVehiculo.ReadOnly = True
        Me.txtPropietarioVehiculo.Size = New System.Drawing.Size(384, 22)
        Me.txtPropietarioVehiculo.TabIndex = 5
        Me.txtPropietarioVehiculo.Tag = "Numero Documento"
        '
        'txtMTC
        '
        EditorButton5.Key = "Right"
        Me.txtMTC.ButtonsRight.Add(EditorButton5)
        Me.txtMTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMTC.Location = New System.Drawing.Point(309, 27)
        Me.txtMTC.MaxLength = 10
        Me.txtMTC.Name = "txtMTC"
        Me.txtMTC.Size = New System.Drawing.Size(147, 22)
        Me.txtMTC.TabIndex = 3
        Me.txtMTC.Tag = "Numero Documento"
        '
        'UltraLabel10
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance131
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(254, 34)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel10.TabIndex = 2
        Me.UltraLabel10.Text = "N° MTC:"
        '
        'cboChofer
        '
        Me.cboChofer.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        EditorButton6.Key = "Left"
        Me.cboChofer.ButtonsLeft.Add(EditorButton6)
        EditorButton7.Key = "Right"
        Me.cboChofer.ButtonsRight.Add(EditorButton7)
        Me.cboChofer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance132.BackColor = System.Drawing.SystemColors.Window
        Appearance132.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboChofer.DisplayLayout.Appearance = Appearance132
        UltraGridColumn547.Header.VisiblePosition = 0
        UltraGridColumn547.Hidden = True
        UltraGridColumn548.Header.VisiblePosition = 1
        UltraGridColumn548.Hidden = True
        UltraGridColumn549.Header.VisiblePosition = 2
        UltraGridColumn549.Hidden = True
        UltraGridColumn550.Header.VisiblePosition = 3
        UltraGridColumn551.Header.VisiblePosition = 5
        UltraGridColumn551.Hidden = True
        UltraGridColumn552.Header.VisiblePosition = 16
        UltraGridColumn552.Hidden = True
        UltraGridColumn553.Header.VisiblePosition = 6
        UltraGridColumn553.Hidden = True
        UltraGridColumn554.Header.VisiblePosition = 7
        UltraGridColumn554.Hidden = True
        UltraGridColumn555.Header.VisiblePosition = 8
        UltraGridColumn555.Hidden = True
        UltraGridColumn556.Header.VisiblePosition = 9
        UltraGridColumn556.Hidden = True
        UltraGridColumn557.Header.VisiblePosition = 10
        UltraGridColumn557.Hidden = True
        UltraGridColumn558.Header.VisiblePosition = 13
        UltraGridColumn558.Hidden = True
        UltraGridColumn559.Header.VisiblePosition = 12
        UltraGridColumn559.Hidden = True
        UltraGridColumn560.Header.VisiblePosition = 11
        UltraGridColumn560.Hidden = True
        UltraGridColumn561.Header.VisiblePosition = 4
        UltraGridColumn561.Hidden = True
        UltraGridColumn562.Header.VisiblePosition = 14
        UltraGridColumn563.Header.VisiblePosition = 15
        UltraGridColumn563.Hidden = True
        UltraGridBand16.Columns.AddRange(New Object() {UltraGridColumn547, UltraGridColumn548, UltraGridColumn549, UltraGridColumn550, UltraGridColumn551, UltraGridColumn552, UltraGridColumn553, UltraGridColumn554, UltraGridColumn555, UltraGridColumn556, UltraGridColumn557, UltraGridColumn558, UltraGridColumn559, UltraGridColumn560, UltraGridColumn561, UltraGridColumn562, UltraGridColumn563})
        Me.cboChofer.DisplayLayout.BandsSerializer.Add(UltraGridBand16)
        Me.cboChofer.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboChofer.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance133.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance133.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance133.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance133.BorderColor = System.Drawing.SystemColors.Window
        Me.cboChofer.DisplayLayout.GroupByBox.Appearance = Appearance133
        Appearance134.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboChofer.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance134
        Me.cboChofer.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance135.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance135.BackColor2 = System.Drawing.SystemColors.Control
        Appearance135.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance135.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboChofer.DisplayLayout.GroupByBox.PromptAppearance = Appearance135
        Me.cboChofer.DisplayLayout.MaxColScrollRegions = 1
        Me.cboChofer.DisplayLayout.MaxRowScrollRegions = 1
        Appearance136.BackColor = System.Drawing.SystemColors.Window
        Appearance136.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboChofer.DisplayLayout.Override.ActiveCellAppearance = Appearance136
        Appearance137.BackColor = System.Drawing.SystemColors.Highlight
        Appearance137.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboChofer.DisplayLayout.Override.ActiveRowAppearance = Appearance137
        Me.cboChofer.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboChofer.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance138.BackColor = System.Drawing.SystemColors.Window
        Me.cboChofer.DisplayLayout.Override.CardAreaAppearance = Appearance138
        Appearance139.BorderColor = System.Drawing.Color.Silver
        Appearance139.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboChofer.DisplayLayout.Override.CellAppearance = Appearance139
        Me.cboChofer.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboChofer.DisplayLayout.Override.CellPadding = 0
        Appearance140.BackColor = System.Drawing.SystemColors.Control
        Appearance140.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance140.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance140.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance140.BorderColor = System.Drawing.SystemColors.Window
        Me.cboChofer.DisplayLayout.Override.GroupByRowAppearance = Appearance140
        Appearance141.TextHAlignAsString = "Left"
        Me.cboChofer.DisplayLayout.Override.HeaderAppearance = Appearance141
        Me.cboChofer.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance142.BackColor = System.Drawing.SystemColors.Window
        Appearance142.BorderColor = System.Drawing.Color.Silver
        Me.cboChofer.DisplayLayout.Override.RowAppearance = Appearance142
        Me.cboChofer.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance143.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboChofer.DisplayLayout.Override.TemplateAddRowAppearance = Appearance143
        Me.cboChofer.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboChofer.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboChofer.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboChofer.DisplayMember = "Conductor"
        Me.cboChofer.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboChofer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChofer.Location = New System.Drawing.Point(72, 83)
        Me.cboChofer.Name = "cboChofer"
        Me.cboChofer.Size = New System.Drawing.Size(384, 23)
        Me.cboChofer.TabIndex = 7
        Me.cboChofer.ValueMember = "IdPersona"
        '
        'UltraLabel11
        '
        Appearance144.BackColor = System.Drawing.Color.Transparent
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Appearance144.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance144
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(24, 88)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(41, 15)
        Me.UltraLabel11.TabIndex = 6
        Me.UltraLabel11.Text = "Chofer:"
        '
        'cmbVehiculo
        '
        Me.cmbVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        EditorButton8.Key = "Left"
        Me.cmbVehiculo.ButtonsLeft.Add(EditorButton8)
        EditorButton9.Key = "Right"
        Me.cmbVehiculo.ButtonsRight.Add(EditorButton9)
        Me.cmbVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cmbVehiculo.Location = New System.Drawing.Point(72, 27)
        Me.cmbVehiculo.Name = "cmbVehiculo"
        Me.cmbVehiculo.Size = New System.Drawing.Size(158, 22)
        Me.cmbVehiculo.TabIndex = 1
        '
        'cboCarreta
        '
        Me.cboCarreta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        EditorButton10.Key = "Left"
        Me.cboCarreta.ButtonsLeft.Add(EditorButton10)
        EditorButton11.Key = "Right"
        Me.cboCarreta.ButtonsRight.Add(EditorButton11)
        Me.cboCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCarreta.Location = New System.Drawing.Point(547, 27)
        Me.cboCarreta.Name = "cboCarreta"
        Me.cboCarreta.Size = New System.Drawing.Size(158, 22)
        Me.cboCarreta.TabIndex = 9
        '
        'UltraLabel3
        '
        Appearance145.BackColor = System.Drawing.Color.Transparent
        Appearance145.ForeColor = System.Drawing.Color.Navy
        Appearance145.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance145
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(15, 33)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(50, 15)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Vehiculo:"
        '
        'UltraLabel9
        '
        Appearance146.BackColor = System.Drawing.Color.Transparent
        Appearance146.ForeColor = System.Drawing.Color.Navy
        Appearance146.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance146
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(493, 33)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(45, 15)
        Me.UltraLabel9.TabIndex = 8
        Me.UltraLabel9.Text = "Carreta:"
        '
        'txtPartida
        '
        Me.txtPartida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPartida.Location = New System.Drawing.Point(78, 163)
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.Size = New System.Drawing.Size(778, 22)
        Me.txtPartida.TabIndex = 11
        Me.txtPartida.TabStop = False
        '
        'UltraLabel5
        '
        Appearance147.BackColor = System.Drawing.Color.Transparent
        Appearance147.ForeColor = System.Drawing.Color.Navy
        Appearance147.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance147
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(25, 194)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel5.TabIndex = 12
        Me.UltraLabel5.Text = "Llegada:"
        '
        'UltraLabel4
        '
        Appearance148.BackColor = System.Drawing.Color.Transparent
        Appearance148.ForeColor = System.Drawing.Color.Navy
        Appearance148.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance148
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(29, 167)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 15)
        Me.UltraLabel4.TabIndex = 10
        Me.UltraLabel4.Text = "Partida:"
        '
        'cmbMotivoTraslado
        '
        Me.cmbMotivoTraslado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cmbMotivoTraslado.DropDownListWidth = 350
        Me.cmbMotivoTraslado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbMotivoTraslado.Location = New System.Drawing.Point(823, 14)
        Me.cmbMotivoTraslado.Name = "cmbMotivoTraslado"
        Me.cmbMotivoTraslado.Size = New System.Drawing.Size(112, 22)
        Me.cmbMotivoTraslado.TabIndex = 8
        '
        'UltraLabel1
        '
        Appearance149.BackColor = System.Drawing.Color.Transparent
        Appearance149.ForeColor = System.Drawing.Color.Navy
        Appearance149.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance149
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(744, 18)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(73, 15)
        Me.UltraLabel1.TabIndex = 7
        Me.UltraLabel1.Text = "Mot.Traslado:"
        '
        'txtProveedor
        '
        Me.txtProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtProveedor.Location = New System.Drawing.Point(78, 14)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(304, 22)
        Me.txtProveedor.TabIndex = 1
        Me.txtProveedor.TabStop = False
        '
        'txtNumero
        '
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Location = New System.Drawing.Point(507, 14)
        Me.txtNumero.MaxLength = 10
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
        Appearance150.BackColor = System.Drawing.Color.Transparent
        Appearance150.ForeColor = System.Drawing.Color.Navy
        Appearance150.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance150
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
        Appearance151.BackColor = System.Drawing.Color.Transparent
        Appearance151.ForeColor = System.Drawing.Color.Navy
        Appearance151.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance151
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
        Appearance152.BackColor = System.Drawing.Color.Transparent
        Appearance152.ForeColor = System.Drawing.Color.Navy
        Appearance152.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance152
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
        Me.ficGuiaRR.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab8.TabPage = Me.UltraTabPageControl2
        UltraTab8.Text = "Mantenimiento"
        Me.ficGuiaRR.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab8})
        Me.ficGuiaRR.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1086, 427)
        '
        'frm_GRR_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 450)
        Me.Controls.Add(Me.ficGuiaRR)
        Me.Name = "frm_GRR_Venta"
        Me.Text = "frm_GRR_Venta"
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
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.ficServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficServicios.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griAlmacenMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox12.ResumeLayout(False)
        Me.UltraGroupBox12.PerformLayout()
        CType(Me.chbBuscarCod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.gridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        Me.UltraGroupBox7.PerformLayout()
        CType(Me.txtSerieD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPuntoLlegada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        Me.UltraGroupBox6.PerformLayout()
        CType(Me.txtNroLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroMTCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLlegada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropietarioCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropietarioVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboChofer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMotivoTraslado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficGuiaRR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficGuiaRR.ResumeLayout(False)
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
    Friend WithEvents gbeMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ficServicios As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griAlmacenMaterial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox12 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chbBuscarCod As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnBuscarMat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtMaterial As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridVentas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSerieD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNroD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnConsultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cboPuntoLlegada As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkAsociar As CheckBox
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNroLicencia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNroMTCC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtLlegada As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtPropietarioCarreta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtPropietarioVehiculo As Infragistics.Win.UltraWinEditors.UltraTextEditor
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
    Friend WithEvents txtProveedor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtSerie As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFechaDocumento As DateTimePicker
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
End Class
