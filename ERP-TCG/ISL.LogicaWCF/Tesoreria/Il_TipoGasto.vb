Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoGasto", también debe actualizar la referencia a "Il_TipoGasto" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoGasto

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ID As String, ByVal NOMBRE As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeTipoGasto As e_TipoGasto) As e_TipoGasto

    <OperationContract()> _
    Function Listar(ByVal oeTipoGasto As e_TipoGasto) As DataSet

    <OperationContract()> _
    Function Listar2(ByVal oeTipoGasto As e_TipoGasto) As List(Of e_TipoGasto)

    <OperationContract()> _
    Function ListarDetalle(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As List(Of e_TipoGastoDetalle)

    <OperationContract()> _
    Function Validar(ByVal oeTipoGasto As e_TipoGasto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoGasto As e_TipoGasto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoGasto As e_TipoGasto) As Boolean

End Interface
