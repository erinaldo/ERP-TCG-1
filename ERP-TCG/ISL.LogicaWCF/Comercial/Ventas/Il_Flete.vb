Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Flete", también debe actualizar la referencia a "Il_Flete" en Web.config.
<ServiceContract()> _
Public Interface Il_Flete

    <OperationContract()> _
    Function Obtener(ByVal oeFlete As e_Flete) As e_Flete

    <OperationContract()> _
    Function Listar(ByVal oeFlete As e_Flete) As List(Of e_Flete)

    <OperationContract()> _
    Function ValidarCliente(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarTipoVehiculo(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ListarTarifas(ByVal oeFlete As e_Flete) As DataTable

    <OperationContract()> _
    Function ValidarCarga(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeFlete As e_Flete) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeFlete As e_Flete) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeFlete As e_Flete) As Boolean

End Interface
