Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_ObligacionPago

    <OperationContract()> _
    Function Obtener(ByVal oeObligacionPago As e_ObligacionPago) As e_ObligacionPago

    <OperationContract()> _
    Function Listar(ByVal oeObligacionPago As e_ObligacionPago) As List(Of e_ObligacionPago)

    <OperationContract()> _
    Function Validar(ByVal oeObligacionPago As e_ObligacionPago) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeObligacionPago As e_ObligacionPago) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeObligacionPago As e_ObligacionPago) As Boolean

End Interface
