Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Base", también debe actualizar la referencia a "Ie_Base" en Web.config.
<ServiceContract()> _
Public Interface Ie_Base

    <OperationContract()> _
    Function Obtener(ByVal base As e_Base) As e_Base

End Interface
