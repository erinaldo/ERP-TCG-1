Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_RetencionImpresa" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_RetencionImpresa

    <OperationContract()> _
    Function Obtener(ByVal periodo As e_RetencionImpresa) As e_RetencionImpresa

End Interface
