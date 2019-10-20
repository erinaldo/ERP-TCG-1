Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Cargo", también debe actualizar la referencia a "Il_Cargo" en Web.config.
<ServiceContract()> _
Public Interface Il_Cargo

    <OperationContract()> _
    Function Obtener(ByVal oeCargo As e_Cargo) As e_Cargo

    <OperationContract()> _
    Function Listar(ByVal oeCargo As e_Cargo) As List(Of e_Cargo)

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeCargo As e_Cargo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCargo As e_Cargo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCargo As e_Cargo) As Boolean

End Interface
