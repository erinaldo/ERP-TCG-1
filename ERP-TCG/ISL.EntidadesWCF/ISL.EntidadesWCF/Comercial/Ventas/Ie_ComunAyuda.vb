Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "IComunAyuda", también debe actualizar la referencia a "IComunAyuda" en Web.config.
<ServiceContract()> _
Public Interface Ie_ComunAyuda

    <OperationContract()> _
    Function Obtener(ByVal ComunAyuda As e_ComunAyuda) As e_ComunAyuda
    Sub DoWork()

End Interface
