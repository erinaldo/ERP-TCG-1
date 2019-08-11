Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AccidenteVehiculo", también debe actualizar la referencia a "Ie_AccidenteVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Ie_AccidenteVehiculo

    <OperationContract()> _
    Function Obtener(ByVal accidenteVehiculo As e_AccidenteVehiculo) As e_AccidenteVehiculo

End Interface
