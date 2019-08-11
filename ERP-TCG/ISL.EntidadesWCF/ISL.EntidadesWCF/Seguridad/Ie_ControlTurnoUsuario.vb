Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ControlTurnoUsuario", también debe actualizar la referencia a "Ie_ControlTurnoUsuario" en Web.config.
<ServiceContract()> _
Public Interface Ie_ControlTurnoUsuario

    <OperationContract()> _
    Function Obtener(ByVal controlTurnoUsuario As e_ControlTurnoUsuario) As e_ControlTurnoUsuario

End Interface
