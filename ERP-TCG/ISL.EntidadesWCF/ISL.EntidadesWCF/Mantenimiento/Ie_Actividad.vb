Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Actividad", también debe actualizar la referencia a "Ie_Actividad" en Web.config.
<ServiceContract()> _
Public Interface Ie_Actividad

    <OperationContract()> _
    Function Obtener(ByVal actividad As e_Actividad) As e_Actividad

End Interface
