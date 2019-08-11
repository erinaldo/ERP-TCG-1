Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GuiaTransportista", también debe actualizar la referencia a "Ie_GuiaTransportista" en Web.config.
<ServiceContract()> _
Public Interface Ie_GuiaTransportista

    <OperationContract()> _
    Function Obtener(ByVal guiaTransportista As e_GuiaTransportista) As e_GuiaTransportista

End Interface
