Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_AporteDescuento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_AporteDescuento

    <OperationContract()>
    Function obtener(ByVal oeAporteDescuento As e_AporteDescuento) As e_AporteDescuento

End Interface
