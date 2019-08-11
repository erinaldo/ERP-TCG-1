Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DocVehDocPago

    <OperationContract()> _
    Function Obtener(ByVal docvehdocpago As e_DocVehDocPago) As e_DocVehDocPago

End Interface
