Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenTrabajo", también debe actualizar la referencia a "Ie_OrdenTrabajo" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenTrabajo

    <OperationContract()> _
    Function Obtener(ByVal ordenTrabajo As e_OrdenTrabajo) As e_OrdenTrabajo

End Interface
