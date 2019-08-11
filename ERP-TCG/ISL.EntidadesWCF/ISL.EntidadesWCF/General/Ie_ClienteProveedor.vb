Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ClienteProveedor", también debe actualizar la referencia a "Ie_ClienteProveedor" en Web.config.
<ServiceContract()> _
Public Interface Ie_ClienteProveedor

    <OperationContract()> _
    Function Obtener(ByVal clienteProveedor As e_ClienteProveedor) As e_ClienteProveedor

End Interface
