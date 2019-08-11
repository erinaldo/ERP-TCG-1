Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleEntornoTrabajo", también debe actualizar la referencia a "Ie_DetalleEntornoTrabajo" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleEntornoTrabajo

    <OperationContract()> _
    Function Obtener(ByVal detalleEntornoTrabajo As e_DetalleEntornoTrabajo) As e_DetalleEntornoTrabajo

End Interface
