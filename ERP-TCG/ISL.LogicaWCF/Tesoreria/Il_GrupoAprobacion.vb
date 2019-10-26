Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GrupoAprobacion", también debe actualizar la referencia a "Il_GrupoAprobacion" en Web.config.
<ServiceContract()> _
Public Interface Il_GrupoAprobacion

    <OperationContract()> _
   Function Obtener(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As e_GrupoAprobacion

    <OperationContract()> _
    Function Listar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As System.Data.DataSet

    <OperationContract()> _
    Function ListarDetalle(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As List(Of e_GrupoAprobacion)

    <OperationContract()> _
    Function Validar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As Boolean


End Interface
