Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_LiquidacionPersonal" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_LiquidacionTrabajador

    <OperationContract()> _
    Function Obtener(ByVal liquidaciontrabajador As e_LiquidacionTrabajador) As e_LiquidacionTrabajador

End Interface
