Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Capacitacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Capacitacion

    <OperationContract()>
    Function Obtener(ByVal capacitacion As e_Capacitacion) As e_Capacitacion

End Interface
