Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ProvisionPoliza" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ProvisionPoliza

    Function Obtener(ProvisionPoliza As e_ProvisionPoliza) As e_ProvisionPoliza



    <OperationContract()>
    Sub DoWork()

End Interface
