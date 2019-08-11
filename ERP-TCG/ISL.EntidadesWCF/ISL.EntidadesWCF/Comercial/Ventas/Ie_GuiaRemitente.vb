Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GuiaRemitente", también debe actualizar la referencia a "Ie_GuiaRemitente" en Web.config.
<ServiceContract()> _
Public Interface Ie_GuiaRemitente

    <OperationContract()> _
    Function Obtener(ByVal guiaRemitente As e_GuiaRemitente) As e_GuiaRemitente

End Interface
