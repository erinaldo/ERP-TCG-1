Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DocumentoAsociado", también debe actualizar la referencia a "Il_DocumentoAsociado" en Web.config.
<ServiceContract()> _
Public Interface Il_DocumentoAsociado

    <OperationContract()> _
    Function Obtener(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As e_DocumentoAsociado

    <OperationContract()> _
    Function Listar(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As List(Of e_DocumentoAsociado)

    <OperationContract()> _
    Function ListarDocAsoc(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As List(Of e_MovimientoDocumento)

    <OperationContract()> _
    Function Validar(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As Boolean

End Interface
