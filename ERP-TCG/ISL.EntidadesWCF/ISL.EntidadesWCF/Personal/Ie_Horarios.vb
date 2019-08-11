Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Horarios" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Horarios

    <OperationContract()> _
    Function Obtener(ByVal horarios As e_Horarios) As e_Horarios

End Interface
