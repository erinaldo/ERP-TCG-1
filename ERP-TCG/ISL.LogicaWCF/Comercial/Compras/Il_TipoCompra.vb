Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoCompra", también debe actualizar la referencia a "Il_TipoCompra" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoCompra

    <OperationContract()> _
    Function Obtener(ByVal oeTipoCompra As e_TipoCompra) As e_TipoCompra

    <OperationContract()> _
    Function Listar(ByVal oeTipoCompra As e_TipoCompra) As List(Of e_TipoCompra)

    <OperationContract()> _
    Function Validar(ByVal oeTipoCompra As e_TipoCompra) As Boolean

    '<OperationContract()> _
    'Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoCompra As e_TipoCompra) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoCompra As e_TipoCompra) As Boolean

End Interface
