Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleDocumentoVehiculo", también debe actualizar la referencia a "Ie_DetalleDocumentoVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuotaDocumentoVehiculo

    <OperationContract()> _
    Function Obtener(ByVal cuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As e_CuotaDocumentoVehiculo

End Interface
