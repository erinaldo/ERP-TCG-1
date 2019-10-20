Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TiempoCiclo", también debe actualizar la referencia a "Il_TiempoCiclo" en Web.config.
<ServiceContract()> _
Public Interface Il_TiempoCiclo

    <OperationContract()> _
    Function Obtener(ByVal oeTiempoCiclo As e_TiempoCiclo) As e_TiempoCiclo

    <OperationContract()> _
    Function Listar(ByVal oeTiempoCiclo As e_TiempoCiclo) As List(Of e_TiempoCiclo)

    <OperationContract()> _
    Function ValidarCliente(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarTipoVehiculo(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeTiempoCiclo As e_TiempoCiclo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTiempoCiclo As e_TiempoCiclo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTiempoCiclo As e_TiempoCiclo) As Boolean

End Interface
