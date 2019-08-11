Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_MotivoCese" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_MotivoCese

    <OperationContract()> _
    Function Obtener(ByVal motivocese As e_MotivoCese) As e_MotivoCese

End Interface
