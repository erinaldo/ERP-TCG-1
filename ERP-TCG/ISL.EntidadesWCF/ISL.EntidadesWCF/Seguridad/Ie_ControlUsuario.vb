Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ControlUsuario", también debe actualizar la referencia a "Ie_ControlUsuario" en Web.config.
<ServiceContract()> _
Public Interface Ie_ControlUsuario

    <OperationContract()> _
    Function Obtener(ByVal controlUsuario As e_ControlUsuario) As e_ControlUsuario

End Interface
