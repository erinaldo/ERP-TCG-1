Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GrupoSancion", también debe actualizar la referencia a "Il_GrupoSancion" en Web.config.
<ServiceContract()> _
Public Interface Il_GrupoSancion

    <OperationContract()> _
     Function Obtener(ByVal oeGrupoSancion As e_GrupoSancion) As e_GrupoSancion

    <OperationContract()> _
    Function ObtenerGrupoGenerado(ByVal oeGrupoSancion As e_GrupoSancion) As e_GrupoSancion
 
    <OperationContract()> _
    Function Listar(ByVal oeGrupoSancion As e_GrupoSancion) As List(Of e_GrupoSancion)

    <OperationContract()> _
    Function ListarDS(ByVal oeGrupoSancion As e_GrupoSancion) As Data.DataSet
 
    <OperationContract()> _
    Function Validar(ByVal oeGrupoSancion As e_GrupoSancion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGrupoSancion As e_GrupoSancion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGrupoSancion As e_GrupoSancion) As Boolean


End Interface
