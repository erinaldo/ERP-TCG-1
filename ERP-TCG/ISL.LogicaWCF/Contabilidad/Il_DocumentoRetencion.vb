Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DocumentoRetencion", también debe actualizar la referencia a "Il_DocumentoRetencion" en Web.config.
<ServiceContract()> _
Public Interface Il_DocumentoRetencion

    <OperationContract()> _
    Function Obtener(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As e_DocumentoRetencion

    <OperationContract()> _
    Function Listar(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As List(Of e_DocumentoRetencion)

    <OperationContract()> _
    Function Validar(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As Boolean

    <OperationContract()> _
    Function UltimoNroRetencion(ByVal Serie As String) As String

    <OperationContract()> _
    Function ImprimirDocumentoRetencion(ByVal IdRetencion As String) As System.Data.DataTable

    <OperationContract()> _
    Function EnviarSunat(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As Boolean

    <OperationContract()> _
    Function ComunicaBajaSunat(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As String

    <OperationContract()> _
    Function ImpresionElectronico(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As System.Data.DataSet

    <OperationContract()> _
    Function ConsultarDocumento(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As Boolean

End Interface
