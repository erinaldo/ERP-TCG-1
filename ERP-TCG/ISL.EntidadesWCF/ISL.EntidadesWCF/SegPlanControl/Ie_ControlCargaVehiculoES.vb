Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ControlCargaVehiculoES", también debe actualizar la referencia a "Ie_ControlCargaVehiculoES" en Web.config.
<ServiceContract()> _
Public Interface Ie_ControlCargaVehiculoES

    <OperationContract()> _
    Function Obtener(ByVal controlCargaVehiculoES As e_ControlCargaVehiculoES) As e_ControlCargaVehiculoES

End Interface
