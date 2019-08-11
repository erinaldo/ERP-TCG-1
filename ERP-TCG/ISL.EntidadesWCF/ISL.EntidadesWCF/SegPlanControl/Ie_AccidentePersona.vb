Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AccidentePersona", también debe actualizar la referencia a "Ie_AccidentePersona" en Web.config.
<ServiceContract()> _
Public Interface Ie_AccidentePersona

    <OperationContract()> _
    Function Obtener(ByVal accidentePersona As e_AccidentePersona) As e_AccidentePersona

End Interface
