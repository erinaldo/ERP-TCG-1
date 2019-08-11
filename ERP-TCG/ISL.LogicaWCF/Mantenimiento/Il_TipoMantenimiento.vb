Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoMantenimiento", también debe actualizar la referencia a "Il_TipoMantenimiento" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoMantenimiento

    <OperationContract()> _
    Function Obtener(ByVal oeTipoMantenimiento As e_TipoMantenimiento) As e_TipoMantenimiento

    <OperationContract()> _
    Function Listar(ByVal oeTipoMantenimiento As e_TipoMantenimiento) As List(Of e_TipoMantenimiento)

    <OperationContract()> _
    Function Validar(ByVal oeTipoMantenimiento As e_TipoMantenimiento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoMantenimiento As e_TipoMantenimiento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoMantenimiento As e_TipoMantenimiento) As Boolean

End Interface
