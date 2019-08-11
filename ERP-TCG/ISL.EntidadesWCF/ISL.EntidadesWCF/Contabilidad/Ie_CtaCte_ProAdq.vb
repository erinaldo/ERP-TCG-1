Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_CtaCte_ProAdq" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_CtaCte_ProAdq

    <OperationContract()> _
    Function Obtener(ByVal ctacte As e_CtaCte_ProAdq) As e_CtaCte_ProAdq

End Interface
