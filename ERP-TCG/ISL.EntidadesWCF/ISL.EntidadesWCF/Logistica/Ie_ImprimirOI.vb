Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ImprimirOI", también debe actualizar la referencia a "Ie_ImprimirOI" en Web.config.
<ServiceContract()> _
Public Interface Ie_ImprimirOI

    <OperationContract()> _
    Sub DoWork()

End Interface
