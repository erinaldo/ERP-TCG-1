Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_PagoAdicional" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_PagoAdicional

    <OperationContract()>
    Function obtener(ByVal oePagoAdicional As e_PagoAdicional) As e_PagoAdicional

End Interface
