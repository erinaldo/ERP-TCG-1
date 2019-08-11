Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Demanda", también debe actualizar la referencia a "Il_Demanda" en Web.config.
<ServiceContract()> _
Public Interface Il_Demanda

    <OperationContract()> _
    Function Obtener(ByVal oeDemanda As e_Demanda) As e_Demanda

    <OperationContract()> _
    Function Listar(ByVal oeDemanda As e_Demanda) As List(Of e_Demanda)

    <OperationContract()> _
    Function ValidarRuta(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarTipoVehiculo(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeDemanda As e_Demanda) As Boolean

    <OperationContract()> _
    Function ListarDataSet(ByVal oeDemanda As e_Demanda) As DataSet

    <OperationContract()> _
    Function Guardar(ByVal oeDemanda As e_Demanda) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDemanda As e_Demanda) As Boolean

    <OperationContract()> _
    Function Cancelar(ByVal oeDemanda As e_Demanda) As Boolean

    <OperationContract()> _
    Function ObtenerDetalle(ByVal oeDemandaDetalle As e_DemandaDetalle) As e_DemandaDetalle

    <OperationContract()> _
    Function ListarDetalle(ByVal oeDemandaDetalle As e_DemandaDetalle) As List(Of e_DemandaDetalle)

    <OperationContract()> _
    Function ValidarCliente(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarCarga(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarMaterial(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarComisionista(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarDetalle(ByVal oeDemandaDetalle As e_DemandaDetalle) As Boolean

    <OperationContract()> _
    Function ValidarDemandaCodigo(ByVal Codigo As String) As Boolean

    


End Interface
