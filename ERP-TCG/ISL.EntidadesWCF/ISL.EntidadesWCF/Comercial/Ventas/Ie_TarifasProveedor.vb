Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_TarifasProveedor" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_TarifasProveedor

    <OperationContract()> _
    Function Obtener(ByVal TarifasProveedor As e_TarifasProveedor) As e_TarifasProveedor

End Interface
