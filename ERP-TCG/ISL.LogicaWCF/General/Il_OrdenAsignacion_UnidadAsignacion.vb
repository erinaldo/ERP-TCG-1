Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenAsignacion_UnidadAsignacion", también debe actualizar la referencia a "Il_OrdenAsignacion_UnidadAsignacion" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenAsignacion_UnidadAsignacion

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As e_OrdenAsignacion_UnidadAsignacion

    <OperationContract()> _
    Function Listar(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As List(Of e_OrdenAsignacion_UnidadAsignacion)

    <OperationContract()> _
    Function ListarTodo(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As List(Of e_OrdenAsignacion_UnidadAsignacion)

    <OperationContract()> _
    Function Validar(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As Boolean

End Interface
