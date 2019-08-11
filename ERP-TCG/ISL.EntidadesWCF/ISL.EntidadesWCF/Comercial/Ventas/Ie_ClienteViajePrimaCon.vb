Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ClienteViajePrimaCon" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ClienteViajePrimaCon

    <OperationContract()> _
    Function Obtener(ByVal clienteviajeprimacon As e_ClienteViajePrimaCon) As e_ClienteViajePrimaCon

End Interface
