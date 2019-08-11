Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GuiaRemisionRemitente", también debe actualizar la referencia a "Ie_GuiaRemisionRemitente" en Web.config.
<ServiceContract()> _
Public Interface Ie_GuiaRemisionRemitente

    <OperationContract()> _
    Function Obtener(ByVal guiaRemisionRemitente As e_GuiaRemisionRemitente) As e_GuiaRemisionRemitente

End Interface
