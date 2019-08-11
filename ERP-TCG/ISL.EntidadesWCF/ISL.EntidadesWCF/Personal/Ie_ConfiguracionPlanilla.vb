Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ConfiguracionPlanilla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ConfiguracionPlanilla

    <OperationContract()>
    Function obtener(ByVal oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As e_ConfiguracionPlanilla

End Interface
