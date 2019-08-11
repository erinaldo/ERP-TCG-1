Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Cotizacion

    <OperationContract()> _
    Function Obtener(ByVal oeCotizacion As e_Cotizacion) As e_Cotizacion

    <OperationContract()> _
    Function Listar(ByVal oeCotizacion As e_Cotizacion) As List(Of e_Cotizacion)

    <OperationContract()> _
    Function ListarDataSet(ByVal desde As Date, ByVal hasta As Date, ByVal estado As Boolean) As DataSet

    <OperationContract()> _
    Function Validar(ByVal oeCotizacion As e_Cotizacion) As Boolean

    <OperationContract()> _
    Function ValidarL(ByVal oeCotizacion As e_Cotizacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCotizacion As e_Cotizacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCotizacion As e_Cotizacion) As Boolean

End Interface
