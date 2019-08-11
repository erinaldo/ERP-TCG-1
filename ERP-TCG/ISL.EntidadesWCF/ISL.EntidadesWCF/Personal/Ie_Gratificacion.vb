Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Gratificacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Gratificacion

    <OperationContract()>
    Function obtener(ByVal oeGratificacion As e_Gratificacion) As e_Gratificacion

End Interface
