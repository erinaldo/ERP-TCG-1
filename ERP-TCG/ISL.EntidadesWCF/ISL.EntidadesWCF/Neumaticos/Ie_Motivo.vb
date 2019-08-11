Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Motivo", también debe actualizar la referencia a "Ie_Motivo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Motivo

    <OperationContract()> _
    Function Obtener(ByVal motivo As e_Motivo) As e_Motivo

End Interface
