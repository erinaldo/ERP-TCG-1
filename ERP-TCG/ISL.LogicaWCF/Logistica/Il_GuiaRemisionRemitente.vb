Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GuiaRemisionRemitente", también debe actualizar la referencia a "Il_GuiaRemisionRemitente" en Web.config.
<ServiceContract()> _
Public Interface Il_GuiaRemisionRemitente

    <OperationContract()> _
    Function Obtener(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As e_GuiaRemisionRemitente

    <OperationContract()> _
    Function ObtenerDetallesGr(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As List(Of e_Material)

    <OperationContract()> _
    Function Listar(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As List(Of e_GuiaRemisionRemitente)

    <OperationContract()> _
    Sub ValidarProveedor(ByVal oeGRRemitente As e_GuiaRemisionRemitente)

    <OperationContract()> _
    Sub ValidarGuiaRemisionRemitente(ByVal oeGRRemitente As e_GuiaRemisionRemitente)

    <OperationContract()> _
    Function Validar(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As Boolean

End Interface
