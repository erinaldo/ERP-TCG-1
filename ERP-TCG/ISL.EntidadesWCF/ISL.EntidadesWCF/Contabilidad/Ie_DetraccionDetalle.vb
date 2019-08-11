Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetraccionDetalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetraccionDetalle

    <OperationContract()> _
    Function Obtener(ByVal detracciondetalle As e_DetraccionDetalle) As e_DetraccionDetalle

End Interface
