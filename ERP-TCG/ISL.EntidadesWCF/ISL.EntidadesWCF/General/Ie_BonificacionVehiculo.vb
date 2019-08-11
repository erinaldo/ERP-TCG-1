Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DocumentoVehicular", también debe actualizar la referencia a "Ie_DocumentoVehicular" en Web.config.
<ServiceContract()> _
Public Interface Ie_BonificacionVehiculo

    <OperationContract()> _
    Function Obtener(ByVal BonificacionVehiculo As e_BonificacionVehiculo) As e_BonificacionVehiculo

End Interface
