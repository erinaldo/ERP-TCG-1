Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ClientePrima" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ClientePrima

    <OperationContract()> _
    Function Obtener(ByVal clienteprima As e_ClientePrima) As e_ClientePrima

End Interface
