Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_GuiaRRVenta_Print" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_GuiaRRVenta_Print

    <OperationContract()>
    Function obtener(ByVal oeDetalleGratificacion As e_GuiaRRVenta_Print) As e_GuiaRRVenta_Print

End Interface
