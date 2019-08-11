Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TiempoCiclo", también debe actualizar la referencia a "Ie_TiempoCiclo" en Web.config.
<ServiceContract()> _
Public Interface Ie_TiempoCiclo

    <OperationContract()> _
    Function Obtener(ByVal tiempoCiclo As e_TiempoCiclo) As e_TiempoCiclo

End Interface
