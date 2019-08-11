Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ControlPermisos", también debe actualizar la referencia a "Ie_ControlPermisos" en Web.config.
<ServiceContract()> _
Public Interface Ie_ControlPermisos

    <OperationContract()> _
     Function Obtener(ByVal controlpermisos As e_ControlPermisos) As e_ControlPermisos

End Interface
