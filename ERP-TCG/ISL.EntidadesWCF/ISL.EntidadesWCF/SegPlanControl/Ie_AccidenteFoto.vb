Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AccidenteFoto", también debe actualizar la referencia a "Ie_AccidenteFoto" en Web.config.
<ServiceContract()> _
Public Interface Ie_AccidenteFoto

    <OperationContract()> _
    Function Obtener(ByVal accidenteFoto As e_AccidenteFoto) As e_AccidenteFoto

End Interface
