Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DocumentoVentaDetalle", también debe actualizar la referencia a "Il_DocumentoVentaDetalle" en Web.config.
<ServiceContract()> _
Public Interface Il_DocumentoVentaDetalle

    <OperationContract()> _
    Function Obtener(ByVal oeDocumentoVentaDetalle As e_DocumentoVentaDetalle) As e_DocumentoVentaDetalle

    <OperationContract()> _
    Function Listar(ByVal oeDocumentoVentaDetalle As e_DocumentoVentaDetalle) As List(Of e_DocumentoVentaDetalle)

    <OperationContract()> _
    Function Validar(ByVal oeDocumentoVentaDetalle As e_DocumentoVentaDetalle) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDocumentoVentaDetalle As e_DocumentoVentaDetalle) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDocumentoVentaDetalle As e_DocumentoVentaDetalle) As Boolean

End Interface
