Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenTrabajo_Material", también debe actualizar la referencia a "Ie_OrdenTrabajo_Material" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenTrabajo_Material

    <OperationContract()> _
    Function Obtener(ByVal ordenTrabajo_Material As e_OrdenTrabajo_Material) As e_OrdenTrabajo_Material

End Interface
