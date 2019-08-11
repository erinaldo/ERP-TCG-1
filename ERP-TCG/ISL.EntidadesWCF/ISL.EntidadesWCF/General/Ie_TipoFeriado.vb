Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_TipoFeriado" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_TipoFeriado

    <OperationContract()> _
    Function Obtener(ByVal tipoferiado As e_TipoFeriado) As e_TipoFeriado

End Interface
