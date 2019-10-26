Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Banco", también debe actualizar la referencia a "Il_Banco" en Web.config.
<ServiceContract()> _
Public Interface Il_Banco

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeBanco As e_Banco) As e_Banco

    <OperationContract()> _
    Function Listar(ByVal oeBanco As e_Banco) As List(Of e_Banco)

    <OperationContract()> _
    Function Validar(ByVal oeBanco As e_Banco) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeBanco As e_Banco) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeBanco As e_Banco) As Boolean

End Interface
