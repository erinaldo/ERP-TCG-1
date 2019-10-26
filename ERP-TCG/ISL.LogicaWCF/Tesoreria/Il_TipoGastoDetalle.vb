Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoGastoDetalle", también debe actualizar la referencia a "Il_TipoGastoDetalle" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoGastoDetalle

    <OperationContract()> _
    Function Obtener(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As e_TipoGastoDetalle

    <OperationContract()> _
    Function Listar(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As List(Of e_TipoGastoDetalle)

    <OperationContract()> _
    Function Validar(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As Boolean

End Interface
