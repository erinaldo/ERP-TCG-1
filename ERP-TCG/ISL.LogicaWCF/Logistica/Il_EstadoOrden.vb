Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_EstadoOrden", también debe actualizar la referencia a "Il_EstadoOrden" en Web.config.
<ServiceContract()> _
Public Interface Il_EstadoOrden

    <OperationContract()> _
    Function Obtener(ByVal oeEstadoOrden As e_EstadoOrden) As e_EstadoOrden

    <OperationContract()> _
    Function Listar(ByVal oeEstadoOrden As e_EstadoOrden) As List(Of e_EstadoOrden)

    <OperationContract()> _
    Function Guardar(ByVal oeEstadoOrden As e_EstadoOrden) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeEstadoOrden As e_EstadoOrden) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeEstadoOrden As e_EstadoOrden) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

End Interface
