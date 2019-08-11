Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetallePagoAdicional" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetallePagoAdicional

    <OperationContract()>
    Function obtener(ByVal oeDetallePagoAdicional As e_DetallePagoAdicional) As e_DetallePagoAdicional

End Interface
