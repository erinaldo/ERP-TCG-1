Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenTrabajo_Actividad", también debe actualizar la referencia a "Ie_OrdenTrabajo_Actividad" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenTrabajo_Actividad

    <OperationContract()> _
    Function Obtener(ByVal ordenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As e_OrdenTrabajo_Actividad

End Interface
