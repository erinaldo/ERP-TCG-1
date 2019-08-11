Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_PagoCajaTrabajador" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_PagoCajaTrabajador

    Function obtener(oePagoAdicional As e_PagoCajaTrabajador) As e_PagoCajaTrabajador

    <OperationContract()>
    Sub DoWork()

End Interface
