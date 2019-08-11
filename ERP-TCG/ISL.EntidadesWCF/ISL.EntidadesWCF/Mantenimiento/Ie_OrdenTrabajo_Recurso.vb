Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenTrabajo_Recurso", también debe actualizar la referencia a "Ie_OrdenTrabajo_Recurso" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenTrabajo_Recurso

    <OperationContract()> _
    Function Obtener(ByVal ordenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As e_OrdenTrabajo_Recurso

End Interface
