Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenAsignacion_UnidadAsignacion", también debe actualizar la referencia a "Ie_OrdenAsignacion_UnidadAsignacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenAsignacion_UnidadAsignacion

    <OperationContract()> _
    Function Obtener(ByVal ordenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As e_OrdenAsignacion_UnidadAsignacion

End Interface
