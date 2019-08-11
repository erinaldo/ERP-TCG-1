Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DepositoDetalle", también debe actualizar la referencia a "Il_DepositoDetalle" en Web.config.
<ServiceContract()> _
Public Interface Il_DepositoDetalle

    <OperationContract()> _
    Function Obtener(ByVal oeDepositoDetalle As e_DepositoDetalle) As e_DepositoDetalle

    <OperationContract()> _
    Function Listar(ByVal oeDepositoDetalle As e_DepositoDetalle) As List(Of e_DepositoDetalle)

    <OperationContract()> _
    Function Validar(ByVal oeDepositoDetalle As e_DepositoDetalle) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDepositoDetalle As e_DepositoDetalle) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDepositoDetalle As e_DepositoDetalle) As Boolean

End Interface
