Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Icono" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Icono

    <OperationContract()>
    Function Obtener(ByVal icono As e_Icono) As e_Icono

End Interface
