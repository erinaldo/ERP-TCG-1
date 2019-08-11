Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Alerta", también debe actualizar la referencia a "Ie_Alerta" en Web.config.
<ServiceContract()> _
Public Interface Ie_Alerta

    <OperationContract()> _
    Function Obtener(ByVal alerta As e_Alerta) As e_Alerta

End Interface
