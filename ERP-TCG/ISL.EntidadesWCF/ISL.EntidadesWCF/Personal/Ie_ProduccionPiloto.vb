Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ProduccionPiloto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ProduccionPiloto

    <OperationContract()>
    Function obtener(ByVal oeProduccionPilito As e_ProduccionPiloto) As e_ProduccionPiloto

End Interface
