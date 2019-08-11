Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenCompraServicio", también debe actualizar la referencia a "Ie_OrdenCompraServicio" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenCompraServicio

    <OperationContract()> _
    Function Obtener(ByVal ordenCompraServicio As e_OrdenCompraServicio) As e_OrdenCompraServicio

End Interface
