Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ProvisionBonificacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ProvisionBonificacion

    <OperationContract()> _
    Function Obtener(ByVal provisionbonificacion As e_ProvisionBonificacion) As e_ProvisionBonificacion

End Interface
