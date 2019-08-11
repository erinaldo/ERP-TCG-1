Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Orden", también debe actualizar la referencia a "Ie_Orden" en Web.config.
<ServiceContract()> _
Public Interface Ie_Orden

    <OperationContract()> _
    Function Obtener(ByVal orden As e_Orden) As e_Orden

End Interface
