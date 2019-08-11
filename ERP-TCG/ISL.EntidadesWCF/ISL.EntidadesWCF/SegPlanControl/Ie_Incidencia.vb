Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Incidencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Incidencia

    <OperationContract()>
    Sub DoWork()

    <OperationContract()> _
    Function Obtener(ByVal incidencia As e_Incidencia) As e_Incidencia
End Interface
