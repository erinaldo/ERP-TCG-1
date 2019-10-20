Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DocumentoSinAsociacion", también debe actualizar la referencia a "Il_DocumentoSinAsociacion" en Web.config.
<ServiceContract()> _
Public Interface Il_DocumentoSinAsociacion

    <OperationContract()> _
    Function Obtener(ByVal oeDocumentoSinAsociacion As e_DocumentoSinAsociacion) As e_DocumentoSinAsociacion

    <OperationContract()> _
    Function Listar(ByVal oeDocumentoSinAsociacion As e_DocumentoSinAsociacion) As List(Of e_DocumentoSinAsociacion)

    <OperationContract()> _
    Function Validar(ByVal oeDocumentoSinAsociacion As e_DocumentoSinAsociacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDocumentoSinAsociacion As e_DocumentoSinAsociacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDocumentoSinAsociacion As e_DocumentoSinAsociacion) As Boolean

End Interface
