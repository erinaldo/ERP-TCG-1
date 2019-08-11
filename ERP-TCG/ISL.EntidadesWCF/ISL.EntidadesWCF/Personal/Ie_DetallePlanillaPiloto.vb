Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetallePlanillaPiloto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetallePlanillaPiloto

    <OperationContract()>
    Function obtener(ByVal oeDetallePlanilla As e_DetallePlanillaPiloto) As e_DetallePlanillaPiloto

End Interface
