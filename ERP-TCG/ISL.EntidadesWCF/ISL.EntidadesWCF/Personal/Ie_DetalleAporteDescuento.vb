Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetalleAporteDescuento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetalleAporteDescuento

    <OperationContract()>
    Function obtener(ByVal oeDetalleAporteDescuento As e_DetalleAporteDescuento) As e_DetalleAporteDescuento

End Interface
