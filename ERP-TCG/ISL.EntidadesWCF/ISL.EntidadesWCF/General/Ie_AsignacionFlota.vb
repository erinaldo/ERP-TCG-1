Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_AsignacionFlota" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_AsignacionFlota

    <OperationContract()>
    Sub DoWork()

    <OperationContract()> _
    Function Obtener(ByVal asignacionflota As e_AsignacionFlota) As e_AsignacionFlota

End Interface
