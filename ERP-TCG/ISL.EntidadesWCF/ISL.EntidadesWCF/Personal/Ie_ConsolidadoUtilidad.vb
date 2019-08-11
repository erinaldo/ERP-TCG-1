Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetalleUtilidad" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ConsolidadoUtilidad

    <OperationContract()>
    Function obtener(ByVal oeDetalleUtilidad As e_ConsolidadoUtilidad) As e_ConsolidadoUtilidad

End Interface
