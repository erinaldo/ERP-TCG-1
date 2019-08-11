Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetallePlanilla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetallePlanilla

    <OperationContract()>
    Function obtener(ByVal oeDetallePlanilla As e_DetallePlanilla) As e_DetallePlanilla

End Interface
