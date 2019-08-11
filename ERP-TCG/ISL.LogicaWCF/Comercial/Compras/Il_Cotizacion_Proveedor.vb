Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Cotizacion_Proveedor

    <OperationContract()> _
    Function Obtener(ByVal oeCotizacionDetalle As e_Cotizacion_Proveedor) As e_Cotizacion_Proveedor

    <OperationContract()> _
    Function Listar(ByVal oeCotizacionDetalle As e_Cotizacion_Proveedor) As List(Of e_Cotizacion_Proveedor)

    <OperationContract()> _
    Function Validar(ByVal oeCotizacionDetalle As e_Cotizacion_Proveedor) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCotizacionDetalle As e_Cotizacion_Proveedor) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCotizacionDetalle As e_Cotizacion_Proveedor) As Boolean

End Interface
