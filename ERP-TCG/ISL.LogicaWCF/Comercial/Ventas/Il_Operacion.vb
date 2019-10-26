Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Operacion", también debe actualizar la referencia a "Il_Operacion" en Web.config.
<ServiceContract()> _
Public Interface Il_Operacion

#Region "Métodos asociados a la entidad e_Operacion"

    

    <OperationContract()> _
    Function Obtener(ByVal oeOperacion As e_Operacion) As e_Operacion

    <OperationContract()> _
    Function Listar(ByVal oeOperacion As e_Operacion) As List(Of e_Operacion)

    <OperationContract()> _
    Function Validar(ByVal oeOperacion As e_Operacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOperacion As e_Operacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOperacion As e_Operacion) As Boolean

#End Region

#Region "Métodos asociados a la entidad e_Viaje"

    <OperationContract()> _
    Function ObtenerViaje(ByVal oeViaje As e_Viaje) As e_Viaje

    <OperationContract()> _
    Function ObtenerRango(ByVal oeViaje As e_Viaje) As e_Viaje

    <OperationContract()> _
    Function ListarViaje(ByVal oeViaje As e_Viaje) As List(Of e_Viaje)

    <OperationContract()> _
   Function ListarViajeLurin(ByVal oeViaje As e_Viaje) As DataTable

    <OperationContract()> _
    Function ListarViajeProceso(ByVal oeViaje As e_Viaje) As DataSet

    <OperationContract()> _
   Function ListarViajeDT(ByVal oeViaje As e_Viaje) As DataTable

    <OperationContract()> _
    Function ListarVehiculoEstadoSituacional() As DataTable

    <OperationContract()> _
    Function ListarDocumentosViaje(ByVal oeViaje As e_Viaje) As DataTable

    <OperationContract()> _
    Function ValidarViaje(ByVal oeViaje As e_Viaje) As Boolean

    <OperationContract()> _
    Function GuardarViaje(ByVal oeViaje As e_Viaje) As Boolean

    <OperationContract()> _
    Function EliminarViaje(ByVal oeViaje As e_Viaje) As Boolean

    <OperationContract()> _
    Function ListarFletes(ByVal oeViaje As e_Viaje) As List(Of e_Viaje)

#End Region

#Region "Métodos asociados a la entidad e_OperacionDetalle"

    <OperationContract()> _
    Function ObtenerOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As e_OperacionDetalle

    <OperationContract()> _
    Function ListarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As List(Of e_OperacionDetalle)

    <OperationContract()> _
    Function ValidarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean

    <OperationContract()> _
    Function GuardarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean

    <OperationContract()> _
    Function GuardarOperacionDetalleLista(ByVal oeOperacionDetalle As List(Of e_OperacionDetalle)) As Boolean

    <OperationContract()> _
    Function EliminarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean

    <OperationContract()> _
    Function ObtenerOperacionDetalleViaje(oeOperacionDetalle As e_OperacionDetalle) As e_OperacionDetalle

#End Region

    <OperationContract()> _
    Function ListarDS(ByVal oeDetalleDocOpeDet As e_DetalleDoc_OperacionDet) As List(Of e_DetalleDoc_OperacionDet)

    <OperationContract()> _
    Function RegfacturarOperacionDet(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean

    <OperationContract()> _
    Function ListarDataSet(ByVal oeViaje As e_Viaje) As DataSet

    <OperationContract()> _
    Function ListarDataSetViajesAntiguos(ByVal oeViaje As e_Viaje) As DataSet

    <OperationContract()> _
    Function GuardarODBloque(ByVal ListaPTP As List(Of e_ProcesarTarifasProceso), _
                             ByVal ListaOD As List(Of e_OperacionDetalle)) As Boolean
End Interface
