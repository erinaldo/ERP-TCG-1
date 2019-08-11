Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MotivoDocumento", también debe actualizar la referencia a "Ie_MotivoDocumento" en Web.config.
<ServiceContract()> _
Public Interface Ie_MotivoDocumento

    <OperationContract()> _
    Function Obtener(ByVal motivoDocumento As e_MotivoDocumento) As e_MotivoDocumento

End Interface
