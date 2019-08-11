Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleDocumentoVehiculo", también debe actualizar la referencia a "Ie_DetalleDocumentoVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleDocumentoVehiculo

    <OperationContract()> _
    Function Obtener(ByVal detalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As e_DetalleDocumentoVehiculo

End Interface
