Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Material", también debe actualizar la referencia a "Ie_Material" en Web.config.
<ServiceContract()> _
Public Interface Ie_Material

    <OperationContract()> _
    Function Obtener(ByVal material As e_Material) As e_Material

End Interface
