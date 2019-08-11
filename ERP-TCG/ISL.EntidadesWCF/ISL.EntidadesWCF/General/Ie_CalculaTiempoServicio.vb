Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_TiempoServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_CalculaTiempoServicio

    <OperationContract()> _
    Function Obtener(ByVal calculatiemposervicio As e_CalculaTiempoServicio) As e_CalculaTiempoServicio

End Interface
