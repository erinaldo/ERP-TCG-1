Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_EstadoOrden", también debe actualizar la referencia a "Ie_EstadoOrden" en Web.config.
<ServiceContract()> _
Public Interface Ie_EstadoOrden

    <OperationContract()> _
    Function Obtener(ByVal estadoOrden As e_EstadoOrden) As e_EstadoOrden

End Interface
