Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_EstacionServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_EstacionServicio

    <OperationContract()>
    Function Obtener(ByVal estacionservicio As e_EstacionServicio) As e_EstacionServicio

End Interface
