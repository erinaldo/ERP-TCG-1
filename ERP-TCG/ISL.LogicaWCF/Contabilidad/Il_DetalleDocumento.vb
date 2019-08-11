Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleDocumento", también debe actualizar la referencia a "Il_DetalleDocumento" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleDocumento

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleDocumento As e_DetalleDocumento) As e_DetalleDocumento

    <OperationContract()> _
    Function Listar(ByVal oeDetalleDocumento As e_DetalleDocumento) As List(Of e_DetalleDocumento)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleDocumento As e_DetalleDocumento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleDocumento As e_DetalleDocumento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleDocumento As e_DetalleDocumento) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

End Interface
