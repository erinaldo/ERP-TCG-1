Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Email", también debe actualizar la referencia a "Ie_Email" en Web.config.
<ServiceContract()> _
Public Interface Ie_Email

    <OperationContract()> _
    Function Obtener(ByVal email As e_Email) As e_Email

End Interface
