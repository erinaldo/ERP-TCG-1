Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_AsientoModelo" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_AsientoModelo

    <OperationContract()>
    Function Obtener(ByVal asientomodelo As e_AsientoModelo) As e_AsientoModelo

End Interface
