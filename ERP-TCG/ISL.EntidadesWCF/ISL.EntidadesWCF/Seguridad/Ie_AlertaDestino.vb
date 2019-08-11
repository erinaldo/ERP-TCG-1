Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AlertaDestino", también debe actualizar la referencia a "Ie_AlertaDestino" en Web.config.
<ServiceContract()> _
Public Interface Ie_AlertaDestino

    <OperationContract()> _
    Function Obtener(ByVal alertaDestino As e_AlertaDestino) As e_AlertaDestino

End Interface
