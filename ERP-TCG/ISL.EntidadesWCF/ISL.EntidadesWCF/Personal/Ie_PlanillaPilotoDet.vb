Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_PlanillaPilotoDet" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_PlanillaPilotoDet

    <OperationContract()>
    Function Obtener(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As e_PlanillaPilotoDet

End Interface
