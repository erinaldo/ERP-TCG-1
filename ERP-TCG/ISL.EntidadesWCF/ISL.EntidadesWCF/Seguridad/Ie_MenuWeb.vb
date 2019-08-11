Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MenuWeb", también debe actualizar la referencia a "Ie_MenuWeb" en Web.config.
<ServiceContract()> _
Public Interface Ie_MenuWeb

    <OperationContract()> _
    Function Obtener(ByVal menuWeb As e_MenuWeb) As e_MenuWeb

End Interface
