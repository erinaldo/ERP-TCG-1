Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "IIl_ComunAyuda", también debe actualizar la referencia a "IIl_ComunAyuda" en Web.config.
<ServiceContract()> _
Public Interface Il_ComunAyuda

    <OperationContract()> _
    Sub DoWork()

End Interface
