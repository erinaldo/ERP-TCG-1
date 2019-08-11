Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_PlanillaVacaciones" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_PlanillaVacaciones

    <OperationContract()>
    Function obtener(ByVal oePlanillaVacaciones As e_PlanillaVacaciones) As e_PlanillaVacaciones

End Interface
