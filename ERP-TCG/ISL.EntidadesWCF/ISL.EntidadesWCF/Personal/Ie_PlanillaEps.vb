Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_PlanillaEps" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_PlanillaEps

    <OperationContract()>
    Function obtener(ByVal oePlanillaEps As e_PlanillaEps) As e_PlanillaEps

End Interface
