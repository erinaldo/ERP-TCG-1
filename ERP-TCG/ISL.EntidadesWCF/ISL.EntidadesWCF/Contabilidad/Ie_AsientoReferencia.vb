Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_AsientoReferencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_AsientoReferencia

    <OperationContract()>
    Function Obtener(asientoReferencia As e_AsientoReferencia) As e_AsientoReferencia

End Interface
