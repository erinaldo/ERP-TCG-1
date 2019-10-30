Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_TurnoCierre" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_TurnoCierre

    <OperationContract()>
    Function Obtener(ByVal turnocierre As e_TurnoCierre) As e_TurnoCierre

End Interface
