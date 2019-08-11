Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Orden_Documento

    <OperationContract()> _
    Function ObtenerDocumento(ByVal oeOrden_Documento As e_Orden_Documento) As e_MovimientoDocumento

    <OperationContract()> _
    Function Obtener(ByVal oeOrden_Documento As e_Orden_Documento) As e_Orden_Documento

    <OperationContract()> _
    Function Listar(ByVal oeOrden_Documento As e_Orden_Documento) As List(Of e_Orden_Documento)

    <OperationContract()> _
    Function Guardar(ByVal oeOrden_Documento As e_Orden_Documento) As Boolean

    <OperationContract()> _
    Function ObtenerDocumentoGuiaRemision(ByVal oeOrden_Documento As e_Orden_Documento) As e_GuiaRemisionRemitente

    <OperationContract()> _
    Function ValidaOIEjecutada(ByVal oeOrden_Documento As e_Orden_Documento) As Boolean

End Interface
