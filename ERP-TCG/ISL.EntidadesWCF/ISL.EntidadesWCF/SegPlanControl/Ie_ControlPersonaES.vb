Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ControlPersonaES", también debe actualizar la referencia a "Ie_ControlPersonaES" en Web.config.
<ServiceContract()> _
Public Interface Ie_ControlPersonaES

    <OperationContract()> _
    Function Obtener(ByVal controlPersonaES As e_ControlPersonaES) As e_ControlPersonaES

End Interface
