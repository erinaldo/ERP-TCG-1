Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenTrabajo_Servicio", también debe actualizar la referencia a "Ie_OrdenTrabajo_Servicio" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenTrabajo_Servicio

    <OperationContract()> _
    Function Obtener(ByVal ordenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As e_OrdenTrabajo_Servicio

End Interface
