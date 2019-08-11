Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DocumentoRetencionDetalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DocumentoRetencionDetalle

    <OperationContract()>
    Function Obtener(ByVal documentoretenciondetalle As e_DocumentoRetencionDetalle) As e_DocumentoRetencionDetalle

End Interface
