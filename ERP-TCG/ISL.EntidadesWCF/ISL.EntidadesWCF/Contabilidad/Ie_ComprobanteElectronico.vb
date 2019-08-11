Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ComprobanteElectronico" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ComprobanteElectronico

    <OperationContract()>
    Function Obtener(ByVal comprobanteelectronico As e_ComprobanteElectronico) As e_ComprobanteElectronico

End Interface
