Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Surtidor" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Surtidor

    <OperationContract()> _
    Function Obtener(ByVal surtidor As e_Surtidor) As e_Surtidor

End Interface
