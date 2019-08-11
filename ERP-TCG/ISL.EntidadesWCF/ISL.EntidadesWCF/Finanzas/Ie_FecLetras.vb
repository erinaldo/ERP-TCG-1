Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_FecLetras" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_FecLetras

    <OperationContract()>
    Function Obtener(ByVal fecletra As e_FecLetras) As e_FecLetras

End Interface
