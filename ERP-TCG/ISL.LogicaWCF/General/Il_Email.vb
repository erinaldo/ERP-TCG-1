Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Email", también debe actualizar la referencia a "Il_Email" en Web.config.
<ServiceContract()> _
Public Interface Il_Email

    <OperationContract()> _
    Function Obtener(ByVal oeEmail As e_Email) As e_Email

    <OperationContract()> _
    Function Listar(ByVal oeEmail As e_Email) As List(Of e_Email)

    <OperationContract()> _
    Function ValidarNombre(ByVal Id As String, ByVal Nombre As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeEmail As e_Email) As Boolean

    <OperationContract()> _
    Function ValidarLista(ByVal leEmail As List(Of e_Email)) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeEmail As e_Email) As Boolean

    <OperationContract()> _
    Function GuardarListar(ByVal leEmail As List(Of e_Email)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeEmail As e_Email) As Boolean

End Interface
