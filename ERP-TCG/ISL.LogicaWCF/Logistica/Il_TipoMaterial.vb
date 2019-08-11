Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoMaterial", también debe actualizar la referencia a "Il_TipoMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoMaterial

    <OperationContract()> _
    Function Obtener(ByVal oeTipoMaterial As e_TipoMaterial) As e_TipoMaterial

    <OperationContract()> _
    Function Listar(ByVal oeTipoMaterial As e_TipoMaterial) As List(Of e_TipoMaterial)

    <OperationContract()> _
    Function Guardar(ByVal oeTipoMaterial As e_TipoMaterial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoMaterial As e_TipoMaterial) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeTipoMaterial As e_TipoMaterial) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

End Interface
