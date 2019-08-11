Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ResumenAsistencia" en el código y en el archivo de configuración a la vez.

<ServiceContract()>
Public Interface Ie_ResumenAsistencia

    <OperationContract()>
    Function obtener(ByVal oeResumenAsistencia As e_ResumenAsistencia) As e_ResumenAsistencia

End Interface
