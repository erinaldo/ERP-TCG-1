Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GrupoAprobacionDet", también debe actualizar la referencia a "Il_GrupoAprobacionDet" en Web.config.
<ServiceContract()> _
Public Interface Il_GrupoAprobacionDet

    <OperationContract()> _
   Function Obtener(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As e_GrupoAprobacionDet

    <OperationContract()> _
    Function Listar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As List(Of e_GrupoAprobacionDet)

    <OperationContract()> _
    Function Validar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As Boolean

End Interface
