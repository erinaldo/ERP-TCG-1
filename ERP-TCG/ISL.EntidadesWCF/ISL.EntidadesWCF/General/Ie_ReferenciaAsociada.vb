Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ReferenciaAsociada" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ReferenciaAsociada

    <OperationContract()>
    Function Obtener(ByVal referencia As e_ReferenciaAsociada) As e_ReferenciaAsociada

End Interface
