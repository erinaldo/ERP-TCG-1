Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GuiaRemitente", también debe actualizar la referencia a "Il_GuiaRemitente" en Web.config.
<ServiceContract()> _
Public Interface Il_GuiaRemitente

    <OperationContract()> _
    Function Obtener(ByVal oeGuiaRemitente As e_GuiaRemitente) As e_GuiaRemitente

    <OperationContract()> _
    Function Listar(ByVal oeGuiaRemitente As e_GuiaRemitente) As List(Of e_GuiaRemitente)

    <OperationContract()> _
    Function ListarDS(ByVal oeGuiaRemitente As e_GuiaRemitente) As List(Of e_GuiaRemitente)

    <OperationContract()> _
    Function Validar(ByVal oeGuiaRemitente As e_GuiaRemitente) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGuiaRemitente As e_GuiaRemitente) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGuiaRemitente As e_GuiaRemitente) As Boolean

End Interface
