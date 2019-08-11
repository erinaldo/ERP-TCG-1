Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_TipoOrdenCompra

    <OperationContract()> _
    Function Obtener(ByVal oeTipoOrdenCompra As e_TipoOrdenCompra) As e_TipoOrdenCompra

    <OperationContract()> _
    Function Listar(ByVal oeTipoOrdenCompra As e_TipoOrdenCompra) As List(Of e_TipoOrdenCompra)

    <OperationContract()> _
    Function Validar(ByVal oeTipoOrdenCompra As e_TipoOrdenCompra) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoOrdenCompra As e_TipoOrdenCompra) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoOrdenCompra As e_TipoOrdenCompra) As Boolean

End Interface
