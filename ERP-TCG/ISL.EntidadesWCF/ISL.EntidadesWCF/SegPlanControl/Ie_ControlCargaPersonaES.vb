Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ControlCargaPersonaES", también debe actualizar la referencia a "Ie_ControlCargaPersonaES" en Web.config.
<ServiceContract()> _
Public Interface Ie_ControlCargaPersonaES

    <OperationContract()> _
    Function Obtener(ByVal controlCargaPersonaES As e_ControlCargaPersonaES) As e_ControlCargaPersonaES

End Interface
