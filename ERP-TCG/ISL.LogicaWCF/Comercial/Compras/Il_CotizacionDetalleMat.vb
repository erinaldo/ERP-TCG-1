Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_CotizacionDetalleMat

    <OperationContract()> _
    Function Obtener(ByVal oeCotizacionDetalle As e_CotizacionDetalleMat) As e_CotizacionDetalleMat

    <OperationContract()> _
    Function Listar(ByVal oeCotizacionDetalle As e_CotizacionDetalleMat) As List(Of e_CotizacionDetalleMat)

    <OperationContract()> _
    Function Validar(ByVal oeCotizacionDetalle As e_CotizacionDetalleMat) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCotizacionDetalle As e_CotizacionDetalleMat) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCotizacionDetalle As e_CotizacionDetalleMat) As Boolean

    <OperationContract()> _
    Sub ValidarProveedor(ByVal oeCotizacionDetalle As e_CotizacionDetalleMat)

End Interface
