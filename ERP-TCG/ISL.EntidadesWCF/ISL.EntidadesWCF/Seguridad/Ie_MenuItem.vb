Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MenuItem", también debe actualizar la referencia a "Ie_MenuItem" en Web.config.
<ServiceContract()> _
Public Interface Ie_MenuItem

    <OperationContract()> _
    Function Obtener(ByVal menuItem As e_MenuItem) As e_MenuItem

End Interface
