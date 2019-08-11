Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleMaterialAsignacion", también debe actualizar la referencia a "Ie_DetalleMaterialAsignacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleMaterialAsignacion

    <OperationContract()> _
    Function Obtener(ByVal detalleMaterialAsignacion As e_DetalleMaterialAsignacion) As e_DetalleMaterialAsignacion

End Interface
