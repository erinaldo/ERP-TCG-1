Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ControlActividad", también debe actualizar la referencia a "Ie_ControlActividad" en Web.config.
<ServiceContract()> _
Public Interface Ie_ControlActividad

    <OperationContract()> _
    Function Obtener(ByVal controlActividad As e_ControlActividad) As e_ControlActividad

End Interface
