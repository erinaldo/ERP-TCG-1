Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ChequeDocumento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ChequeDocumento

    <OperationContract()> _
    Function Obtener(ByVal chequedocumento As e_ChequeDocumento) As e_ChequeDocumento

End Interface
