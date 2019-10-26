Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GrupoDetalle", también debe actualizar la referencia a "Il_GrupoDetalle" en Web.config.
<ServiceContract()> _
Public Interface Il_GrupoDetalle

    <OperationContract()> _
    Function Obtener(ByVal oeGrupoDetalle As e_GrupoDetalle) As e_GrupoDetalle

    <OperationContract()> _
    Function Listar(ByVal oeGrupoDetalle As e_GrupoDetalle) As List(Of e_GrupoDetalle)

    <OperationContract()> _
    Function ListarDesc(ByVal oeGrupoDetalle As e_GrupoDetalle) As List(Of e_GrupoDetalle)

    <OperationContract()> _
    Function ListarFlete(ByVal oeGrupoDetalle As e_GrupoDetalle) As List(Of e_GrupoDetalle)

    <OperationContract()> _
    Function ListarLiq(ByVal oeGrupoDetalle As e_GrupoDetalle) As List(Of e_GrupoDetalle)

    <OperationContract()> _
    Function Validar(ByVal oeGrupoDetalle As e_GrupoDetalle) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGrupoDetalle As e_GrupoDetalle) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGrupoDetalle As e_GrupoDetalle) As Boolean

End Interface
