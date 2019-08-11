Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenCompra", también debe actualizar la referencia a "Ie_OrdenCompra" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenCompra

    <OperationContract()> _
    Function Obtener(ByVal ordenCompra As e_OrdenCompra) As e_OrdenCompra

    <OperationContract()> _
    Function VerificarOrdenCompra(ByVal ordenes As List(Of e_OrdenCompra)) As Integer

End Interface
