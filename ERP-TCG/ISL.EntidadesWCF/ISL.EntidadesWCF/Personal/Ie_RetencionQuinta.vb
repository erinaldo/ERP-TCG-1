Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_RetencionQuinta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_RetencionQuinta

    <OperationContract()>
    Function obtener(ByVal oeRetencionQuinta As e_RetencionQuinta) As e_RetencionQuinta

End Interface
