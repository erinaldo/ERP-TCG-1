Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Detraccion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Detraccion

    <OperationContract()> _
    Function Obtener(ByVal detraccion As e_Detraccion) As e_Detraccion

End Interface
