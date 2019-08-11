Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_TipoPago

    <OperationContract()> _
    Function Obtener(ByVal oeTipoPago As e_TipoPago) As e_TipoPago

    <OperationContract()> _
    Function Listar(ByVal oeTipoPago As e_TipoPago) As List(Of e_TipoPago)

    <OperationContract()> _
    Function Validar(ByVal oeTipoPago As e_TipoPago) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoPago As e_TipoPago) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoPago As e_TipoPago) As Boolean

End Interface
