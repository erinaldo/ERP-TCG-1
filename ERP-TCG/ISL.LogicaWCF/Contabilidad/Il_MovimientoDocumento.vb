Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MovimientoDocumento", también debe actualizar la referencia a "Il_MovimientoDocumento" en Web.config.
<ServiceContract()> _
Public Interface Il_MovimientoDocumento

    Function ValidarNC_ND(oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()>
    Function obtener(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

    <OperationContract()>
    Function dt_DocumentoCtble_Impresion(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As DataTable

    <OperationContract()> _
    Function Obtener2(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

    <OperationContract()> _
    Function ListarDetallesPorDocumentos(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As List(Of e_Material)

    <OperationContract()> _
    Function ObtenerDocumentosPorCompras(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

    <OperationContract()> _
    Function ObtenerCantDoc(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

    <OperationContract()> _
    Function Listar(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As List(Of e_MovimientoDocumento)

    <OperationContract()> _
    Function ListarDocumentosPorCompras(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As List(Of e_MovimientoDocumento)

    <OperationContract()> _
    Function Validar(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function GuardarMasivo(ByVal oeMovimientoDoc As e_MovimientoDocumento) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeMovimientoDocumento As e_MovimientoDocumento, Optional oeAnticipo As e_MovimientoDocumento = Nothing) As e_MovimientoDocumento

    <OperationContract()>
    Function GuardarCanje(oeMovimientoDocumento As e_MovimientoDocumento, oeNotaDespacho As e_MovimientoDocumento) As e_MovimientoDocumento

    <OperationContract()>
    Function GuardarCanjeDocumentos(DocumentoGenerado As e_MovimientoDocumento, ListaDocumentos As List(Of e_MovimientoDocumento)) As e_MovimientoDocumento

    <OperationContract()>
    Function VerificarDocumento(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function CambiarPeriodo(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function ValidarTipoCambio(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function AjusteTipoCambio(ByVal TipoOperacion As String, ByVal oePeriodo As e_Periodo, ByVal leMovimientoDocumento As List(Of e_MovimientoDocumento)) As Boolean

    <OperationContract()> _
    Function AjusteTipoCambioObligacion(ByVal TipoOperacion As String, ByVal oePeriodo As e_Periodo, _
    ByVal leMovimientoObligacion As List(Of e_ObligacionFinanciera), ByVal IdUsuariocrea As String) As Boolean

    <OperationContract()> _
    Sub CtaGananciaPerdida(ByRef lsCta As String, ByVal G_P As Boolean, ByVal Ejercicio As Integer)

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

    <OperationContract()> _
    Function ObtenerNumDoc(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

    <OperationContract()> _
    Function Emitir(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function Anular(ByVal oeMovimientoDocumento As e_MovimientoDocumento, IdUsuario As String) As Boolean

    <OperationContract()> _
    Function ListarVerificacionAsiento(ByVal oeMovDoc As e_MovimientoDocumento) As DataTable

    <OperationContract()> _
    Function ListarAjusteTipoCambio(ByVal TipoOperacion As String, ByVal IdMovimientoDocumento As String, ByVal IdPeriodo As String, ByVal Ejercicio As Integer) As DataTable

    <OperationContract()> _
    Function ListarFlujoCajaIsl(ByVal FechaInic As Date, ByVal FechaFin As Date) As DataTable

    <OperationContract()> _
    Function ActualizarSaldoDoc(ByVal leMovDoc As List(Of e_MovimientoDocumento)) As Boolean

    <OperationContract()> _
    Function ActualizarEstadopago(ByVal oeMovDoc As e_MovimientoDocumento) As Boolean


#Region "Anticipo"

    <OperationContract()> _
    Function ValidarAnticipo(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function GuardarAnticipo(ByVal oeMovimientoDocumento As e_MovimientoDocumento, ByVal oeMovCajaBanco As e_MovimientoCajaBanco, ByVal TipoAnticipo As String) As Boolean

    '<OperationContract()> _
    'Function AnticipoCliente(ByRef obj As Object) As Boolean

    '<OperationContract()> _
    'Function AnticipoProveedor(ByRef obj As Object, ByVal leCuotaMovimiento As List(Of e_CuotaDocVeh_Movimiento)) As Boolean

    <OperationContract()> _
    Function EliminarAnticipo(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

#End Region

#Region "Cancelacion de Documentos"

    <OperationContract()> _
    Function ValidarCancelacionDocumentos(ByVal leDocumentosAgregados As List(Of e_MovimientoDocumento), ByVal fecha As Date) As Boolean

    <OperationContract()> _
    Function GuardarCancelacion(ByVal leDocumentosAgregados As List(Of e_MovimientoDocumento), ByVal Obj As Object()) As Boolean

    <OperationContract()> _
    Function GuardarCancelacionMovimientoAnalisis(ByVal leMovimientosAgregados As List(Of e_MovimientoAnalisis), ByVal Obj As Object()) As Boolean

    <OperationContract()> _
    Function GuardarAnalisisYDocumento(ByVal leMovimientosAgregados As  _
    System.Collections.Generic.List(Of e_MovimientoAnalisis), ByVal leDocumentosAgregados As  _
    System.Collections.Generic.List(Of e_MovimientoDocumento), ByVal Obj() As Object) As Boolean

#End Region

#Region "Venta"

    <OperationContract()> _
    Function ObtenerVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

    <OperationContract()> _
    Function ValidarVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    '<OperationContract()> _
    'Function GuardarVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento, Optional ByVal leDocumentos As List(Of e_MovimientoDocumento) = Nothing) As Boolean

    '<OperationContract()> _
    'Function Linea12(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento, _
    'ByVal leCuentaGeneral As List(Of e_TablaContableDet)) As e_AsientoMovimiento

    '<OperationContract()> _
    'Function LineaImpuestosVentas(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento, _
    'ByVal leCuentaGeneral As List(Of e_TablaContableDet)) As List(Of e_AsientoMovimiento)

    '<OperationContract()> _
    'Function Linea70(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento) As e_AsientoMovimiento

    <OperationContract()> _
    Function GuardarVentaAsiento(ByVal oeMovDocumento As e_MovimientoDocumento, _
                           ByVal oeAsientoModel As e_AsientoModelo, _
                           ByVal oeServCtaCtble As e_ServicioCuentaContable, _
                           ByVal IndOtros As Boolean, _
                           ByVal IdCtaCtble16321 As String, Optional b_anticipo As Boolean = False) As Boolean

    <OperationContract()>
    Function GuardarVenta2(ByVal oeMovDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

#End Region

#Region "Compra"

    <OperationContract()> _
    Function ValidarCompraVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento, _
    Optional ByVal indCompra As Boolean = False, Optional ByVal Modulo As gAreasSGI = gAreasSGI.Contabilidad) As Boolean

    <OperationContract()> _
    Function ObtenerCompra(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

    <OperationContract()> _
    Function GuardarCompraMaterial(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function GuardarCompraServicio(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function GuardarCompra(ByVal oeMovimientoDocumento As e_MovimientoDocumento, _
     ByVal leMovimientoDocumento As List(Of e_MovimientoDocumento), _
    Optional ByVal IndComprobanteCompra As Boolean = False, Optional ByVal oeObligacion As e_ObligacionFin = Nothing) As Boolean

    <OperationContract()> _
    Function Linea42(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento, _
    ByVal leCuentasGenerales As List(Of e_TablaContableDet)) As e_AsientoMovimiento

    <OperationContract()> _
    Function LineaImpuestosCompras(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento, _
    ByVal leCuentasGenerales As List(Of e_TablaContableDet)) As List(Of e_AsientoMovimiento)

    <OperationContract()> _
    Function Linea60(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento, _
                     Optional ByVal Masivo As Boolean = True, Optional ByVal oeObligacion As e_ObligacionFin = Nothing) As List(Of e_AsientoMovimiento)

    <OperationContract()> _
    Function LineasDestinoCompras(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento) As List(Of e_AsientoMovimiento)

    <OperationContract()> _
    Function ExisteCta(ByVal Lista As List(Of e_AsientoMovimiento), ByVal IdCta As String) As e_AsientoMovimiento

#End Region

#Region "Interfaz Ventas de Viajes y Servicios"

    '<OperationContract()> _
    'Function InterfazVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean 'sirve para compra de materiales y combustibles

#End Region

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function EliminarComprobante(ByVal oeMovimientoDocumento As e_MovimientoDocumento, _
                                        Optional ByVal OeAsiento As e_Asiento = Nothing) As Boolean
    <OperationContract()> _
    Function EliminarDocumentoVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function ExtornarDocEmitidoEnviado(ByVal oeMovimientoDocumento As e_MovimientoDocumento, ByVal IdUsuario As String) As Boolean

    <OperationContract()> _
    Function CambiarGlosa(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function ValidarMonto(ByVal movimientosDocumento As List(Of e_MovimientoDocumento), ByVal tipoMovimiento As String) As Boolean

    <OperationContract()> _
    Function ListarCtasXCobrar(ByVal IdClienteProveedor As String, ByVal FechaHasta As Date) As DataTable

    <OperationContract()> _
    Function EstadoCuenta(ByVal IdClienteProveedor As String, ByVal Cliente As Integer) As DataTable

    <OperationContract()> _
    Function RegistroVentas(ByVal IdPeriodo As String) As DataTable

    <OperationContract()> _
    Function RegistroCompras(ByVal IdPeriodo As String) As DataTable

    <OperationContract()> _
    Function ListarCtasXPagar(ByVal IdClienteProveedor As String, ByVal IndBancos As Boolean, IdEstado As String, IndDeuda As Boolean, IdMoneda As String) As DataTable

    <OperationContract()> _
    Function CuentasxPagarxPeriodo(ByVal Ejercicio As Integer, ByVal Mes As Integer, _
    ByVal IndRegCompras As String, ByVal Idmoneda As String) As DataTable

    <OperationContract()> _
    Function CuentasxCobrarxPeriodo(ByVal Ejercicio As Integer, ByVal Mes As Integer, _
    ByVal IndRegVentas As String, ByVal Idmoneda As String) As DataTable

    <OperationContract()>
    Function AsientoAperturaDocumentos(ByVal oeMovimientoDocumento() As Object, ByVal lsTipo As String,
    ByVal lsMoneda As String, ByVal Ejercicio As Integer, ByVal lnTipoCambio As Double, ByVal IdUsuarioCreacion As String,
                                       ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function AperturaDetalle(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As DataTable

#Region "Interfaz Compras de Almacen y Servicios"

    '<OperationContract()> _
    'Function InterfazCompra(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean 'sirve para compra de materiales y combustibles

    <OperationContract()> _
    Function EnviarCompra(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean

#End Region

    <OperationContract()> _
    Function Listar_Anticipos(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As DataTable

End Interface
