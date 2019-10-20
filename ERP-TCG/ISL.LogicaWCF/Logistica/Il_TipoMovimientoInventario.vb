Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoMovimientoInventario", también debe actualizar la referencia a "Il_TipoMovimientoInventario" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoMovimientoInventario

    <OperationContract()> _
    Function Obtener(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As e_TipoMovimientoInventario

    <OperationContract()> _
    Function Listar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As List(Of e_TipoMovimientoInventario)

    <OperationContract()> _
    Function Guardar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

End Interface
