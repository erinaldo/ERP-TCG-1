Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "IClienteLugar", también debe actualizar la referencia a "IClienteLugar" en Web.config.
<ServiceContract()> _
Public Interface IClienteLugar

    <OperationContract()> _
    Sub DoWork()

End Interface
