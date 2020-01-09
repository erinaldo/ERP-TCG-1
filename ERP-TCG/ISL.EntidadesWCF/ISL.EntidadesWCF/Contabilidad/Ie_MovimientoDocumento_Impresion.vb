Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_MovimientoDocumento_Impresion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_MovimientoDocumento_Impresion

    <OperationContract()>
    Sub DoWork()

End Interface
