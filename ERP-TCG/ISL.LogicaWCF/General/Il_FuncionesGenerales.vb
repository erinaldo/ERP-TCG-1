Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_FuncionesGenerales", también debe actualizar la referencia a "Il_FuncionesGenerales" en Web.config.
<ServiceContract()> _
Public Interface Il_FuncionesGenerales

    <OperationContract()> _
    Function l_GeneraID(ByVal C_Base As e_Base) As String

    <OperationContract()> _
    Function ValidarCampoNoNulo(ByVal campo As String, ByVal mensaje As String) As Boolean

    <OperationContract()> _
    Function ValidarSerieNumCeros(ByVal campo As String, ByVal mensaje As String) As Boolean

    <OperationContract()> _
    Function ValidarNumero(ByVal numero As Integer, ByVal mensaje As String) As Boolean

    <OperationContract()> _
    Function ValidarNumeroDecimal(ByVal numero As Decimal, ByVal mensaje As String) As Boolean

    <OperationContract()> _
    Function ValidarPeriodo(ByVal IdPeriodo As String, ByVal _Modulo As gAreasSGI) As Boolean

    <OperationContract()> _
    Function ValidarPeriodo(ByVal IdPeriodo As String, ByVal Modulo As gAreasSGI, ByVal _Fecha As Date, _
                                   ByVal Codigo As String, Optional ByVal MesPosterior As Integer = 0, _
                                   Optional ByVal OemovDoc As e_MovimientoDocumento = Nothing) As Boolean

    <OperationContract()> _
    Function ValidarDatosDeObligacionExistente(ByVal ListaValida As List(Of e_ObligacionFinanciera), _
                                               Optional ByVal IndValSaldo As Boolean = False) As Boolean

    <OperationContract()> _
    Function ValidarDatosDeDctoExistente(ByVal ListaValida As List(Of e_MovimientoDocumento), _
    Optional ByVal IndValSaldo As Boolean = False) As Boolean

    <OperationContract()> _
    Function ValidarDocumentoDuplicado(ByVal oeMovimientoDocumento As e_MovimientoDocumento, Optional ByVal Venta As Boolean = False) As Boolean

    <OperationContract()> _
    Function CuentasGenerales(ByVal oeTablaCtbleDet As e_TablaContableDet) As List(Of e_TablaContableDet)

    <OperationContract()> _
    Function UltimoDiaMes(ByVal Fecha As Date) As Date

    <OperationContract()> _
    Function UltimaFechaVentas() As Date

    <OperationContract()> _
    Function UltimaFechaCompras() As Date

    <OperationContract()> _
    Function UltimaFechaAdministracion() As Date

    <OperationContract()> _
    Function UltimaFechaContabilidad() As Date

    <OperationContract()> _
    Function UltimaFechaNeu() As Date

    <OperationContract()> _
    Function ValidarFechaCierreOperaciones(Tipo As String, Fecha As Date, FechaServidor As Date) As Boolean

    <OperationContract()> _
    Function ValidarFechaNeu(Tipo As String, Fecha As Date, FechaServidor As Date) As Boolean

    <OperationContract()> _
    Function ValidarFechaPerfil(Tipo As String, Fecha As Date, FechaServidor As Date) As Boolean

    <OperationContract()> _
    Function UltimaFechaPerfil(Perfil As String) As Integer

    <OperationContract()> _
    Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String

    <OperationContract()> _
    Function l_ObtenerFechaServidor() As Date

    <OperationContract()> _
    Function CargaIGV(FechaActual As Date) As Double

    <OperationContract()> _
    Function ObtenerCUOAsiento(NroAsiento As String, IdTipoAsiento As String) As String

End Interface
