Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_PagoAdicional" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_MovimientoPeaje

    <OperationContract()>
    Function obtener(ByVal oePagoAdicional As e_MovimientoPeaje) As e_MovimientoPeaje

End Interface
