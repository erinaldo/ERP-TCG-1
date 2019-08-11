Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_KmMack" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_KmMack

    <OperationContract()> _
    Function Obtener(ByVal kmmack As e_KmMack) As e_KmMack

End Interface
