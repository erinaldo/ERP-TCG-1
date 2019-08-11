Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Contratos" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Contratos

    <OperationContract()> _
    Function Obtener(ByVal contratos As e_Contratos) As e_Contratos

End Interface
