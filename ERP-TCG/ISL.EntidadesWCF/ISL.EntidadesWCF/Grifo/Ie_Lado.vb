Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Lado" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Lado

    <OperationContract()>
    Function Obtener(ByVal lado As e_Lado) As e_Lado

End Interface
