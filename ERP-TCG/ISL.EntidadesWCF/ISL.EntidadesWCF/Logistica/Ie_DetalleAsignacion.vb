Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleAsignacion", también debe actualizar la referencia a "Ie_DetalleAsignacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleAsignacion

    <OperationContract()> _
    Function Obtener(ByVal detalleAsignacion As e_DetalleAsignacion) As e_DetalleAsignacion

End Interface
