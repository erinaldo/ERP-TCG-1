Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ClienteRutaCarga" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ClienteRutaCarga

    <OperationContract()> _
    Function Obtener(ByVal ClienteRutaCarga As e_ClienteRutaCarga) As e_ClienteRutaCarga

End Interface
