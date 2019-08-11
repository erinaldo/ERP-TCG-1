Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Utilidad" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Utilidad

    <OperationContract()>
    Function obtener(ByVal oeUtilidad As e_Utilidad) As e_Utilidad

End Interface
