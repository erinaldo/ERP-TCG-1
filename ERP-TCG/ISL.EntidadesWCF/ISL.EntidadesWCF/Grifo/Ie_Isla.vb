Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Isla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Isla

    <OperationContract()>
    Function Obtener(ByVal isla As e_Isla) As e_Isla

End Interface
