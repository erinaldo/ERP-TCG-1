Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_PlanillaViaje" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_PlanillaViaje

    <OperationContract()>
    Function Obtener(ByVal oePlanillaViaje As e_PlanillaViaje) As e_PlanillaViaje

End Interface
