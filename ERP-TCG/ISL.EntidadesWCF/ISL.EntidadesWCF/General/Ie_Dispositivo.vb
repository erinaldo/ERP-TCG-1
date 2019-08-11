Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Dispositivo", también debe actualizar la referencia a "Ie_Dispositivo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Dispositivo

    <OperationContract()> _
    Function Obtener(ByVal dispositivo As e_Dispositivo) As e_Dispositivo

End Interface
