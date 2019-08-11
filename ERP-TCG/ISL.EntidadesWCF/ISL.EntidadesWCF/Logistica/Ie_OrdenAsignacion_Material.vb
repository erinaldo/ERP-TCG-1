Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenAsignacion_Material", también debe actualizar la referencia a "Ie_OrdenAsignacion_Material" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenAsignacion_Material

    <OperationContract()> _
    Function Obtener(ByVal ordenAsignacion_Material As e_OrdenAsignacion_Material) As e_OrdenAsignacion_Material

End Interface
