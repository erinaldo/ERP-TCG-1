Imports ERP.EntidadesWCF
Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_CotizacionDetalleSer" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CotizacionDetalleSer

    <OperationContract()> _
    Function Obtener(ByVal oeCotizacionDetalle As e_CotizacionDetalleSer) As e_CotizacionDetalleSer

    <OperationContract()> _
    Function Listar(ByVal oeCotizacionDetalle As e_CotizacionDetalleSer) As List(Of e_CotizacionDetalleSer)

    <OperationContract()> _
    Function Validar(ByVal oeCotizacionDetalle As e_CotizacionDetalleSer) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCotizacionDetalle As e_CotizacionDetalleSer) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCotizacionDetalle As e_CotizacionDetalleSer) As Boolean


End Interface
