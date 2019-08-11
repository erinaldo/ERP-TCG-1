Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenAsignacion", también debe actualizar la referencia a "Ie_OrdenAsignacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenAsignacion

    <OperationContract()> _
    Function Obtener(ByVal ordenAsignacion As e_OrdenAsignacion) As e_OrdenAsignacion

End Interface
