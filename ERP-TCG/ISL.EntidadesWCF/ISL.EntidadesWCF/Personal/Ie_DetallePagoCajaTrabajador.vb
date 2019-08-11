Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetallePagoCajaTrabajador" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetallePagoCajaTrabajador

    Function obtener(oeDetallePagoAdicional As e_DetallePagoCajaTrabajador) As e_DetallePagoCajaTrabajador

    <OperationContract()>
    Sub DoWork()

End Interface
