Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Orden", también debe actualizar la referencia a "Il_Orden" en Web.config.
<ServiceContract()> _
Public Interface Il_Orden

    <OperationContract()> _
    Function Obtener(ByVal oeOrden As e_Orden) As e_Orden

    <OperationContract()>
    Function ObtenerxReferencia(ByVal oeOrden As e_Orden) As e_Orden

    <OperationContract()> _
    Function RectificarOrden(ByVal oeOrden As e_Orden, loDetalleDocumento As List(Of e_DetalleDocumento), IdMoneda As String, TipoCambio As Double) As Boolean

    <OperationContract()> _
    Function Listar(ByVal oeOrden As e_Orden) As List(Of e_Orden)

    <OperationContract()> _
    Sub ValidarProveedor(ByVal oeOrden As e_Orden)

    <OperationContract()> _
    Function Validar(ByVal oeOrden As e_Orden) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrden As e_Orden, lo As List(Of e_RegistroInventario)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrden As e_Orden) As Boolean

    <OperationContract()> _
    Sub GenerarAsientoConsumo(oeOrden As e_Orden)

End Interface
