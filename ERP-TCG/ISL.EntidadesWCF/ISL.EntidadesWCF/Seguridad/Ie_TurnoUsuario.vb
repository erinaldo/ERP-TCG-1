Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TurnoUsuario", también debe actualizar la referencia a "Ie_TurnoUsuario" en Web.config.
<ServiceContract()> _
Public Interface Ie_TurnoUsuario

    <OperationContract()> _
    Function Obtener(ByVal turnoUsuario As e_TurnoUsuario) As e_TurnoUsuario

End Interface
