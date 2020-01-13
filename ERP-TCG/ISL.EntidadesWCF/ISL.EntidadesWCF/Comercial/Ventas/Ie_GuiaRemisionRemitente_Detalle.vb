Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_GuiaRemisionRemitente_Detalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_GuiaRemisionRemitente_Detalle

    <OperationContract()>
    Function Obtener(ByVal guiaRemitente As Ie_GuiaRemisionRemitente_Detalle) As Ie_GuiaRemisionRemitente_Detalle

End Interface
