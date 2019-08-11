Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Formula" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Formula

    <OperationContract()> _
    Function Obtener(ByVal formula As e_Formula) As e_Formula

End Interface
