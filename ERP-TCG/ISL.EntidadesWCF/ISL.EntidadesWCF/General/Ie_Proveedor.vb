Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Proveedor", también debe actualizar la referencia a "Ie_Proveedor" en Web.config.
<ServiceContract()> _
Public Interface Ie_Proveedor

    <OperationContract()> _
    Function Obtener(ByVal proveedor As e_Proveedor) As e_Proveedor

End Interface
