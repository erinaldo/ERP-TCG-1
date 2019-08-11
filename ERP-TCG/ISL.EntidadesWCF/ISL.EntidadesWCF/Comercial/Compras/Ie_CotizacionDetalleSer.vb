Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_CotizacionDetalleMatSer" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_CotizacionDetalleSer

    <OperationContract()> _
    Function Obtener(ByVal cotizacionDetalleSer As e_CotizacionDetalleSer) As e_CotizacionDetalleSer

End Interface
