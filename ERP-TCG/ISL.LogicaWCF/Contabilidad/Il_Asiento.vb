Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Asiento", también debe actualizar la referencia a "Il_Asiento" en Web.config.
<ServiceContract()> _
Public Interface Il_Asiento

#Region "Cobranza"
    <OperationContract()> _
    Function ListarEstadoGanaciasPerdidas(ls_IdPeriodo As String, ls_Rpt As String) As DataSet

    <OperationContract()> _
   Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function GuardarCobranza(ByVal leMovDocAgregado As List(Of e_MovimientoDocumento), _
                                   ByVal oeMovCajaBanco As e_MovimientoCajaBanco, ByVal oeMedioCobro As e_MedioPago, _
                                   ByVal idUsuario As String, ByVal MacLocal As String, ByVal oeCtaCble As e_CuentaContable, _
                                   ByVal Opcion As String) As Boolean

    <OperationContract()> _
    Function ValidarCobranzaPago(ByVal leDocumentosAgregados As List(Of e_MovimientoDocumento), ByVal fecha As Date)

    <OperationContract()> _
    Function ValidarCobranza(ByVal cadena As String, ByVal leDocumentosAgregados As List(Of e_MovimientoDocumento), ByVal fecha As Date, _
                             ByVal opcion As String)
    <OperationContract()> _
    Function ValidarPago(ByVal cadena As String, ByVal leDocumentosAgregados As List(Of e_MovimientoDocumento), ByVal fecha As Date, _
                             ByVal opcion As String)

    <OperationContract()> _
    Function EliminarCobroPago(ByVal oeAsiento As e_Asiento) As Boolean

    <OperationContract()> _
    Function EliminarCobroPago2(ByVal oeAsiento As e_Asiento) As Boolean

#End Region

#Region "Pagos"

    <OperationContract()> _
    Function GuardarPago(ByVal leMovDocAgregado As List(Of e_MovimientoDocumento), _
                               ByRef oeMovCajaBanco As e_MovimientoCajaBanco, ByVal oeMedioPago As e_MedioPago, _
                               ByVal idUsuario As String, ByVal MacLocal As String, ByVal oeCtaCble As e_CuentaContable, _
                               ByVal lsOpcion As String) As Boolean

    <OperationContract()> _
    Function GuardarPagoRetencion(ByVal leMovDocAgregado As List(Of e_MovimientoDocumento), _
                                     ByRef oeDocumentoRetencion As e_DocumentoRetencion, _
                                     ByVal ls_Actualizar As String)

    <OperationContract()> _
    Function PagoBono(ByVal leMovDoc As List(Of e_MovimientoDocumento), ByVal oeAsiMod As e_AsientoModelo, ByVal oeSaldoCta As e_SaldoCtaCorriente) As Boolean

#End Region

#Region "Asientos"

    <OperationContract()> _
    Function InventariosYBalances(ByVal Mes As String, ByVal TipoConsulta As String) As DataTable

    <OperationContract()> _
    Function Obtener(ByVal oeAsiento As e_Asiento) As e_Asiento

    <OperationContract()> _
    Function Listar(ByVal oeAsiento As e_Asiento) As List(Of e_Asiento)

    <OperationContract()> _
    Function Validar(ByVal oeAsiento As e_Asiento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAsiento As e_Asiento, Optional idAsientoEx As String = Nothing) As Boolean

    <OperationContract()> _
    Function GuardarDocumentoxRendir(ByVal leMovAnalisisAgrega As List(Of e_MovimientoAnalisis), _
    ByVal oeAsiento As e_Asiento, ByVal oeDocumento As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function GuardarProrrateoVenta(ByVal leLista1 As List(Of e_Vehiculo), ByVal leLista2 As List(Of e_Vehiculo), _
    ByVal oeAsiento As e_Asiento) As Boolean

    <OperationContract()> _
    Function GuardarProrrateoCompra(ByVal leLista1 As List(Of e_Vehiculo), ByVal leLista2 As List(Of e_Vehiculo), _
    ByVal oeAsiento As e_Asiento) As Boolean

    <OperationContract()> _
    Function DuplicaAsiento(ByVal oeAsiento As e_Asiento) As Boolean

    <OperationContract()> _
    Function ExtornarAsiento(ByVal oeAsiento As e_Asiento) As Boolean

    <OperationContract()> _
    Function CorrelativoAsiento(ByVal IdPeriodo As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAsiento As e_Asiento) As Boolean

    <OperationContract()> _
    Function Obtener2(ByVal oeAsiento As e_Asiento) As e_Asiento

#End Region

#Region "Estados Financieros"

    <OperationContract()> _
    Function ListarEEFF(ByVal Ejercicio As Integer, ByVal Mes As Integer, Optional Operacion As String = "") As DataTable

    <OperationContract()> _
    Function ListarBalanceGeneral(ByVal Ejercicio As Integer, ByVal Mes As Integer) As DataTable

    <OperationContract()> _
    Function ListarBalanceComprobacion(ByVal oeAsiento As e_Asiento) As DataTable

    <OperationContract()> _
    Function ListarBalanceComprobacionDestino(ByVal oeAsiento As e_Asiento) As DataTable

    <OperationContract()> _
    Function ListarAsientosDescuadrados(ByVal oeAsiento As e_Asiento) As DataTable

    <OperationContract()> _
    Function ListarUtilidadBrutaVehicular(ByVal Ejercicio As Integer, ByVal Mes As Integer, _
                                          ByVal Acumulado As Integer) As DataSet

    <OperationContract()> _
    Function Suma1Nivel(ByVal Filas As DataTable) As DataTable

    <OperationContract()> _
    Function Suma2Nivel(ByVal Filas As DataTable) As DataTable

    <OperationContract()> _
    Function ListarDetalles(ByVal TipoOperacion As String, ByVal IdPeriodo As String, _
    ByVal IdCuentaContable As String, ByVal IdGastoFuncion As String) As DataTable
#End Region

#Region "Impresiones"

    <OperationContract()> _
    Function ImprimeTranferencia(ByVal IdMovCajaBanco As String) As DataTable

    <OperationContract()> _
    Function ImprimeCobroPagoAnticipoObligacion(ByVal IdMovCajaBanco As String, ByVal lsTipoOperacion As String) As DataTable

#End Region

#Region "Consumos"

    <OperationContract()> _
    Function ListarConsumoMaterial(ByVal oePeriodo As e_Periodo, ByVal lsIdSubAlmacen As String) As DataTable

    <OperationContract()> _
    Function Evalua_Monto(ByVal monto As Double, ByVal cta As String, ByVal ds_Monto As DataTable, ByVal ds_Div As DataTable) As Double

    <OperationContract()> _
    Function Captura_Valor(ByVal cta As String, ByVal dsobj As DataTable) As Single

    <OperationContract()>
    Function GenerarAsientoConsumo(ByVal DtConsumo As DataTable, ByVal ls_IdSubAlmacen As String,
    ByVal TipoCambio As Double, ByVal IdPeriodo As String, ByVal FecUltimoDia As Date,
    ByVal IdUsuarioCrea As String, ByVal PrefijoId As String) As Boolean

#End Region

    <OperationContract()> _
    Function ListarDevengadoSeguros(ByVal FechaVencimiento As Date, ByVal lsTipoOper As String, ByVal lsIddoc As String) As DataTable

    <OperationContract()>
    Function GuardarSegurosDevengados(ByVal DtSeguros As DataTable, ByVal oePeriodo As e_Periodo,
    ByVal IdUsuarioCreacion As String, ByVal lsIdMoneda As e_Moneda, ByVal lnTipoCambio As Double,
    ByVal lsTipo As String, ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function ObtenerOrigenContable(ByVal Tipo As String, ByVal IdMovDoc As String) As Integer

#Region "Descuentos a Personal"

    <OperationContract()> _
    Function GuardarAsientoDscto(ByVal oeAsiento As e_Asiento, Optional oeAsientoAnticipo As e_Asiento = Nothing) As Boolean

    <OperationContract()> _
    Function GuardarLista(loAsiento As List(Of e_Asiento)) As Boolean

    <OperationContract()>
    Function GuardarListaMasiva(loAsiento As List(Of e_Asiento), ByVal PrefijoID As String) As Boolean

    <OperationContract()>
    Function GuardarListaMasiva2(loAsiento As List(Of e_Asiento), ByVal PrefijoID As String) As Boolean

    <OperationContract()>
    Function GuardarListaMasiva3(loAsiento As List(Of e_Asiento), ByVal PrefijoID As String) As Boolean

    <OperationContract()>
    Function GuardarListaMasiva4(loAsiento As List(Of e_Asiento), ByVal PrefijoID As String) As Boolean

#End Region

#Region "Ajuste Tipo Cambio y Aperturas"

    <OperationContract()> _
    Function ListarAjusteTC(ByVal oeAjusteTC As e_AjusteTC) As List(Of e_AjusteTC)

    <OperationContract()> _
    Function GuardarAjusteTC(ByVal leAsientoModelo As List(Of e_AsientoModelo), ByVal leAjusteTC As List(Of e_AjusteTC)) As Boolean

    <OperationContract()> _
    Function GuardarAjusteTC(ByVal leAsientoModelo As List(Of e_AsientoModelo), ByVal oeAjusteTC As e_AjusteTC) As Boolean

    <OperationContract()>
    Function GuardarApertura(ByVal leAsientoModel As List(Of e_AsientoModelo), ByVal leApertura As List(Of e_AjusteTC), ByVal lb_Obligacion As Boolean, ByVal PrefijoID As String) As Boolean

#End Region

End Interface
