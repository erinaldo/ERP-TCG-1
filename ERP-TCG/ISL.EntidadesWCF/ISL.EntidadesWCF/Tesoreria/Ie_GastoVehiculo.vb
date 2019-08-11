Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GastoVehiculo", también debe actualizar la referencia a "Ie_GastoVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Ie_GastoVehiculo

    <OperationContract()> _
     Function Obtener(ByVal gastovehiculo As e_GastoVehiculo) As e_GastoVehiculo

End Interface
