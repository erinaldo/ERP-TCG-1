Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ComprobanteElectronicoBath_Detalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ComprobanteElectronicoBath_Detalle

    <OperationContract()>
    Function Obtener(ByVal comprobanteelectronicobath_detalle As e_ComprobanteElectronicoBath_Detalle) As e_ComprobanteElectronicoBath_Detalle

End Interface
