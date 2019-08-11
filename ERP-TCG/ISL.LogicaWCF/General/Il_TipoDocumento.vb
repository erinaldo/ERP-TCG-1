Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoDocumento", también debe actualizar la referencia a "Il_TipoDocumento" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoDocumento

    <OperationContract()> _
    Function Obtener(ByVal oeTipoDocumento As e_TipoDocumento) As e_TipoDocumento

    <OperationContract()> _
    Function Listar(ByVal oeTipoDocumento As e_TipoDocumento) As List(Of e_TipoDocumento)

    <OperationContract()> _
    Function ComboGrilla(ByVal TipoDocumento As List(Of e_TipoDocumento))

    <OperationContract()> _
    Function Validar(ByVal oeTipoDocumento As e_TipoDocumento) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoDocumento As e_TipoDocumento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoDocumento As e_TipoDocumento) As Boolean

End Interface
