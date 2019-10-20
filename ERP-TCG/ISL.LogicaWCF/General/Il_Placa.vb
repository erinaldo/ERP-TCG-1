Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Placa", también debe actualizar la referencia a "Il_Placa" en Web.config.
<ServiceContract()> _
Public Interface Il_Placa

    <OperationContract()> _
    Function ValidarDuplicado(ByVal Id As String, ByVal Nombre As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oePlaca As e_Placa) As e_Placa

    <OperationContract()> _
    Function Listar(ByVal oePlaca As e_Placa) As List(Of e_Placa)

    <OperationContract()> _
    Function Validar(ByVal oePlaca As e_Placa) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePlaca As e_Placa) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePlaca As e_Placa) As Boolean

End Interface
