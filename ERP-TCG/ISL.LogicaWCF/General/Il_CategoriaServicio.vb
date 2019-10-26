Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CategoriaServicio", también debe actualizar la referencia a "Il_CategoriaServicio" en Web.config.
<ServiceContract()> _
Public Interface Il_CategoriaServicio

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ID As String, ByVal NOMBRE As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeCategoriaServicio As e_CategoriaServicio) As e_CategoriaServicio

    <OperationContract()> _
    Function Listar(ByVal oeCategoriaServicio As e_CategoriaServicio) As List(Of e_CategoriaServicio)

    <OperationContract()> _
    Function Validar(ByVal oeCategoriaServicio As e_CategoriaServicio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCategoriaServicio As e_CategoriaServicio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCategoriaServicio As e_CategoriaServicio) As Boolean

End Interface
