Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AccidenteCarga", también debe actualizar la referencia a "Ie_AccidenteCarga" en Web.config.
<ServiceContract()> _
Public Interface Ie_AccidenteCarga

    <OperationContract()> _
    Function Obtener(ByVal accidentecarga As e_AccidenteCarga) As e_AccidenteCarga

End Interface
