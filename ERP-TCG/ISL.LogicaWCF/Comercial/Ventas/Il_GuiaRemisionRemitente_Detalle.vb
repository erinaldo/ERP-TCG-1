Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_GuiaRemisionRemitente_Detalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_GuiaRemisionRemitente_Detalle

    <OperationContract()>
    Function Eliminar(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As Boolean

    <OperationContract()>
    Function Listar(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As System.Collections.Generic.List(Of e_GuiaRemisionRemitente_Detalle)

    <OperationContract()>
    Function Obtener(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As e_GuiaRemisionRemitente_Detalle

    <OperationContract()>
    Function ListarDT(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As DataTable

End Interface
