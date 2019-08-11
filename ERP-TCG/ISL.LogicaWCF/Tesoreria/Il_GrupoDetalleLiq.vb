Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GrupoDetalleLiq", también debe actualizar la referencia a "Il_GrupoDetalleLiq" en Web.config.
<ServiceContract()> _
Public Interface Il_GrupoDetalleLiq

    <OperationContract()> _
    Function Obtener(ByVal oeGrupoDetalleLiq As e_GrupoDetalleLiq) As e_GrupoDetalleLiq

    <OperationContract()> _
    Function Listar(ByVal oeGrupoDetalleLiq As e_GrupoDetalleLiq) As List(Of e_GrupoDetalleLiq)

    <OperationContract()> _
    Function Validar(ByVal oeGrupoDetalleLiq As e_GrupoDetalleLiq) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGrupoDetalleLiq As e_GrupoDetalleLiq) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGrupoDetalleLiq As e_GrupoDetalleLiq) As Boolean

End Interface
