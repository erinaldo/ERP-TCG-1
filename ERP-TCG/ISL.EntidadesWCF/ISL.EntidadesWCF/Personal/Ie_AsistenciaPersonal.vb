Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_AsistenciaPersonal" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_AsistenciaPersonal

    <OperationContract()> _
    Function Obtener(ByVal asistencia As e_AsistenciaPersonal) As e_AsistenciaPersonal

End Interface
