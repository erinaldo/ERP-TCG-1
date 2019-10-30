Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Distribuidor" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Distribuidor

    <OperationContract()>
    Function Obtener(ByVal distribuidor As e_Distribuidor) As e_Distribuidor

End Interface
