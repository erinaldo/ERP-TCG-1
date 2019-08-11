Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Liquidacion", también debe actualizar la referencia a "Il_Liquidacion" en Web.config.
<ServiceContract()> _
Public Interface Il_Liquidacion

    '<OperationContract()> _
    'Sub DoWork()
    <OperationContract()> _
   Function Obtener(ByVal oeLiquidacion As e_Liquidaciones) As e_Liquidaciones

    <OperationContract()> _
   Function Listar(ByVal oeLiquidacion As e_Liquidaciones) As List(Of e_Liquidaciones)

    <OperationContract()> _
   Function Guardar(ByVal oeLiquidacion As e_Liquidaciones) As Boolean

    <OperationContract()> _
   Function Eliminar(ByVal oeLiquidacion As e_Liquidaciones) As Boolean

    <OperationContract()> _
Function ObtenerLiquidacionDetalle(ByVal oeLiquidacionDetalle As e_LiquidacionDetalle) As e_LiquidacionDetalle

    <OperationContract()> _
   Function ListarLiquidacionDetalle(ByVal oeLiquidacionDetalle As e_LiquidacionDetalle) As List(Of e_LiquidacionDetalle)

    <OperationContract()> _
   Function GuardarLiquidacionDetalle(ByVal oeLiquidacionDetalle As e_LiquidacionDetalle) As Boolean

    <OperationContract()> _
   Function EliminarLiquidacionDetalle(ByVal oeLiquidacionDetalle As e_LiquidacionDetalle) As Boolean
End Interface
