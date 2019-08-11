Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_EstadoOT", también debe actualizar la referencia a "Ie_EstadoOT" en Web.config.
<ServiceContract()> _
Public Interface Ie_EstadoOT

    <OperationContract()> _
    Function Obtener(ByVal estadoOT As e_EstadoOT) As e_EstadoOT

End Interface
