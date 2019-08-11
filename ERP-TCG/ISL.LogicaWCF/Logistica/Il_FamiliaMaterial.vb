Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_FamiliaMaterial", también debe actualizar la referencia a "Il_FamiliaMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_FamiliaMaterial

    <OperationContract()> _
    Function Obtener(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As e_FamiliaMaterial

    <OperationContract()> _
    Function Listar(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As List(Of e_FamiliaMaterial)

    <OperationContract()> _
    Function Guardar(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

End Interface
