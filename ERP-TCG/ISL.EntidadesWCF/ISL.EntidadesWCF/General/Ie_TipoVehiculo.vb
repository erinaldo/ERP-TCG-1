Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoVehiculo", también debe actualizar la referencia a "Ie_TipoVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoVehiculo

    <OperationContract()> _
    Function Obtener(ByVal tipoVehiculo As e_TipoVehiculo) As e_TipoVehiculo

End Interface
