Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Detraccion_Det", también debe actualizar la referencia a "Ie_Detraccion_Det" en Web.config.
<ServiceContract()> _
Public Interface Ie_Detraccion_Det

    <OperationContract()> _
    Function Obtener(ByVal detraccion_Det As e_Detraccion_Det) As e_Detraccion_Det

End Interface
