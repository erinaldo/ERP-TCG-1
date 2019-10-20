Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_OrdenCompra

    <OperationContract()> _
    Function Obtener(ByVal oeOrden As e_OrdenCompra) As e_OrdenCompra

    <OperationContract()> _
    Function Listar(ByVal oeOrden As e_OrdenCompra, ByVal oeFecha As e_Fechas) As List(Of e_OrdenCompra)

    <OperationContract()> _
    Function Guardar(ByVal oeOrden As e_OrdenCompra) As Boolean

    <OperationContract()> _
    Function ModificarPrecios(ByVal oeOrden As e_OrdenCompra) As Boolean

    <OperationContract()> _
    Function Guardar1(ByVal oeOrden As e_OrdenCompra) As Boolean

    <OperationContract()> _
    Sub GuardarLista(ByVal llOrden As List(Of e_OrdenCompra), ByVal tipoOperacion As String, ByVal IdTrabajador As String, ByVal IdUsuario As String)

    <OperationContract()> _
    Function Eliminar(ByVal oeOrden As e_OrdenCompra) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeOrden As e_OrdenCompra) As Boolean

    <OperationContract()> _
    Sub ValidarProveedor(ByVal oeOrden As e_OrdenCompra)

    <OperationContract()> _
    Sub ValidarDuplicado(ByVal oeOrden As e_OrdenCompra)

End Interface
