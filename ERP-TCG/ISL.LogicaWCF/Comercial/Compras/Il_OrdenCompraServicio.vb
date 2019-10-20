Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_OrdenCompraServicio

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenServicio As e_OrdenCompraServicio) As e_OrdenCompraServicio

    <OperationContract()> _
    Function Listar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As List(Of e_OrdenCompraServicio)

    <OperationContract()> _
    Function Validar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As Boolean

    <OperationContract()> _
    Sub GuardarLista(ByVal llOrden As List(Of e_OrdenCompraServicio))

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As Boolean

End Interface
