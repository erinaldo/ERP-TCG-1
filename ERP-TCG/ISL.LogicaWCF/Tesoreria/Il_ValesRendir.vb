Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Il_ValesRendir", también debe actualizar la referencia a "Il_ValesRendir" en Web.config.
<ServiceContract()> _
Public Interface Il_ValesRendir

    <OperationContract()> _
    Sub DoWork()

End Interface
