Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetallePlanillaVacaciones" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetallePlanillaVacaciones

    <OperationContract()>
    Function obtener(ByVal oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As e_DetallePlanillaVacaciones

End Interface
