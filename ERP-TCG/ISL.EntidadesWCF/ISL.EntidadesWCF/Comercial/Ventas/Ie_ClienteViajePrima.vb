Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ClienteViajePrima" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ClienteViajePrima

    <OperationContract()> _
    Function Obtener(ByVal clienteviajeprima As e_ClienteViajePrima) As e_ClienteViajePrima

End Interface
