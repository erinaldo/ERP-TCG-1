Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DocumentoImpuesto", también debe actualizar la referencia a "Il_DocumentoImpuesto" en Web.config.
<ServiceContract()> _
Public Interface Il_DocumentoImpuesto

    <OperationContract()> _
    Function Obtener(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As e_DocumentoImpuesto

    <OperationContract()> _
    Function Listar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As List(Of e_DocumentoImpuesto)

    <OperationContract()> _
    Function Validar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As Boolean

End Interface
