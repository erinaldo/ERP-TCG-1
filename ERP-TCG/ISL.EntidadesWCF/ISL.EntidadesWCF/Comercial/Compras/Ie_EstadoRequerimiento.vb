Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_EstadoRequerimiento", también debe actualizar la referencia a "Ie_EstadoRequerimiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_EstadoRequerimiento

    <OperationContract()> _
    Function Obtener(ByVal estadoRequerimiento As e_EstadoRequerimiento) As e_EstadoRequerimiento

End Interface
