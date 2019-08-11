Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenMaterial", también debe actualizar la referencia a "Ie_OrdenMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenMaterial

    <OperationContract()> _
    Function Obtener(ByVal ordenMaterial As e_OrdenMaterial) As e_OrdenMaterial

End Interface
