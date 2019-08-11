Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ControlPersonaVehiculoES", también debe actualizar la referencia a "Ie_ControlPersonaVehiculoES" en Web.config.
<ServiceContract()> _
Public Interface Ie_ControlPersonaVehiculoES

    <OperationContract()> _
    Function Obtener(ByVal controlPersonaVehiculoES As e_ControlPersonaVehiculoES) As e_ControlPersonaVehiculoES

End Interface
