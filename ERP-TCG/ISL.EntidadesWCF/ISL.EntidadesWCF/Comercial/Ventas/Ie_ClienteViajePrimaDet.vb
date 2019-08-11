Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ClienteViajePrimaDet" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ClienteViajePrimaDet

    <OperationContract()> _
    Function Obtener(ByVal clienteviajeprimadet As e_ClienteViajePrimaDet) As e_ClienteViajePrimaDet

End Interface
