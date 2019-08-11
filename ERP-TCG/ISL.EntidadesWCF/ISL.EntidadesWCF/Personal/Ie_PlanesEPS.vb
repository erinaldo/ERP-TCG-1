Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_PlanesEPS" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_PlanesEPS

    <OperationContract()>
    Function obtener(ByVal oePlanesEPS As e_PlanesEPS) As e_PlanesEPS

End Interface
