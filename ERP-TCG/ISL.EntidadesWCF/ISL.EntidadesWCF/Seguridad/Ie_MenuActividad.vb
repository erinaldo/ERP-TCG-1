Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MenuActividad", también debe actualizar la referencia a "Ie_MenuActividad" en Web.config.
<ServiceContract()> _
Public Interface Ie_MenuActividad

    <OperationContract()> _
    Function Obtener(ByVal menuActividad As e_MenuActividad) As e_MenuActividad

End Interface
