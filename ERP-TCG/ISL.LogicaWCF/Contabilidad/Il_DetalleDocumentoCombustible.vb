Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleDocumentoCombustible", también debe actualizar la referencia a "Il_DetalleDocumentoCombustible" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleDocumentoCombustible

    '<OperationContract()> _
    'Function Obtener(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As e_DetalleDocumentoCombustible

    '<OperationContract()> _
    'Function Listar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As List(Of e_DetalleDocumentoCombustible)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As Boolean

End Interface
