Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_TipoBien" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_TipoBien

    <OperationContract()> _
    Function Obtener(ByVal tipobien As e_TipoBien) As e_TipoBien

End Interface
