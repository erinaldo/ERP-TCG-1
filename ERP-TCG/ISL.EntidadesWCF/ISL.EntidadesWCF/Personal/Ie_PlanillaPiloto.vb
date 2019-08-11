Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_PlanillaPiloto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_PlanillaPiloto

    <OperationContract()>
    Function Obtener(ByVal oePlanillaPiloto As e_PlanillaPiloto) As e_PlanillaPiloto

End Interface
