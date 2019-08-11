Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AccidenteMaterial", también debe actualizar la referencia a "Ie_AccidenteMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_AccidenteMaterial

    <OperationContract()> _
    Function Obtener(ByVal accidentematerial As e_AccidenteMaterial) As e_AccidenteMaterial

End Interface
