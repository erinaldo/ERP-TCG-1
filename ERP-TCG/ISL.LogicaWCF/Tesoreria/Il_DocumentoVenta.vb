Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DocumentoVenta", también debe actualizar la referencia a "Il_DocumentoVenta" en Web.config.
<ServiceContract()> _
Public Interface Il_DocumentoVenta

    <OperationContract()> _
    Function Obtener(ByVal oeDocumentoVenta As e_DocumentoVenta) As e_DocumentoVenta

    <OperationContract()> _
    Function Listar(ByVal oeDocumentoVenta As e_DocumentoVenta) As List(Of e_DocumentoVenta)

    <OperationContract()> _
    Function Validar(ByVal oeDocumentoVenta As e_DocumentoVenta) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDocumentoVenta As e_DocumentoVenta) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDocumentoVenta As e_DocumentoVenta) As Boolean

End Interface
