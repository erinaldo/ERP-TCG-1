Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Il_HistorialRechazoOC", también debe actualizar la referencia a "Il_HistorialRechazoOC" en Web.config.
<ServiceContract()> _
Public Interface Il_HistorialRechazoOC

    <OperationContract()> _
    Sub DoWork()

End Interface
