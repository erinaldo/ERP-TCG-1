Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoOrden", también debe actualizar la referencia a "Il_TipoOrden" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoOrden

    <OperationContract()> _
    Function Obtener(ByVal oeTipoOrden As e_TipoOrden) As e_TipoOrden

    <OperationContract()> _
    Function Listar(ByVal oeTipoOrden As e_TipoOrden) As List(Of e_TipoOrden)

    <OperationContract()> _
    Function Guardar(ByVal oeTipoOrden As e_TipoOrden) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoOrden As e_TipoOrden) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeTipoOrden As e_TipoOrden) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

End Interface
