Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ReqOAMSancion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ReqOAMSancion

    <OperationContract()> _
    Function Obtener(ByVal reqoamsan As e_ReqOAMSancion) As e_ReqOAMSancion

End Interface
