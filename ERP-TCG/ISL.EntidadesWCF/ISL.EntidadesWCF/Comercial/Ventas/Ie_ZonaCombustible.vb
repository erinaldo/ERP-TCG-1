Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ZonaCombustible" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ZonaCombustible

    <OperationContract()> _
    Function Obtener(ByVal zonacombustible As e_ZonaCombustible) As e_ZonaCombustible

End Interface
