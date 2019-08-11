Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ControlVehiculoES", también debe actualizar la referencia a "Ie_ControlVehiculoES" en Web.config.
<ServiceContract()> _
Public Interface Ie_ControlVehiculoES

    <OperationContract()> _
    Function Obtener(ByVal controlVehiculoES As e_ControlVehiculoES) As e_ControlVehiculoES

End Interface
