Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetalleProduccionPiloto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetalleProduccionPiloto

    <OperationContract()>
    Function obtener(ByVal oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As e_DetalleProduccionPiloto

End Interface
