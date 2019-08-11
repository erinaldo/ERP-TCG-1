Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ComprobanteElectronicoBath" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ComprobanteElectronicoBath

    <OperationContract()>
    Function Obtener(ByVal comprobanteelectronicobath As e_ComprobanteElectronicoBath) As e_ComprobanteElectronicoBath

End Interface
