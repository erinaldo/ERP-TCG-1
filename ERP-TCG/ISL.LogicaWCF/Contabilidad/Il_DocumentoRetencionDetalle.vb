Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DocumentoRetencionDetalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DocumentoRetencionDetalle

    <OperationContract()> _
    Function Obtener(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As e_DocumentoRetencionDetalle

    <OperationContract()> _
    Function Listar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As List(Of e_DocumentoRetencionDetalle)

    <OperationContract()> _
    Function Validar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As Boolean

    <OperationContract()> _
    Function ListarDoc(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As List(Of e_MovimientoDocumento)

End Interface
