Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetalleConfiguracionPlanilla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetalleConfiguracionPlanilla

    <OperationContract()>
    Function obtener(ByVal oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As e_DetalleConfiguracionPlanilla

End Interface
