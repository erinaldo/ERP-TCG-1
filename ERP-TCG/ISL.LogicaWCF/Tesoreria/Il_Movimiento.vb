Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Movimiento", también debe actualizar la referencia a "Il_Movimiento" en Web.config.
<ServiceContract()> _
Public Interface Il_Movimiento

    <OperationContract()> _
    Function Obtener(ByVal oeMovimiento As e_Movimiento) As e_Movimiento

    <OperationContract()> _
    Function ObtenerMovimiento(ByVal oeMovimiento As e_Movimiento) As e_Movimiento

    <OperationContract()> _
    Function Listar(ByVal oeMovimiento As e_Movimiento) As List(Of e_Movimiento)

    <OperationContract()> _
    Function ListarDscto(ByVal oeMovimiento As e_Movimiento) As List(Of e_Movimiento)

    <OperationContract()> _
    Function GuardarSimple(ByVal oeMovimiento As e_Movimiento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMovimiento As e_Movimiento, ByVal oeMov As e_Movimiento) As Boolean

    <OperationContract()> _
    Function LiquidarHabilitar(ByVal loMovimiento As List(Of e_Movimiento)) As Boolean

    <OperationContract()> _
    Function GuardarDobleMovimiento(ByVal loMovimiento As List(Of e_Movimiento), ByVal oeMov As e_Movimiento) As Boolean

    <OperationContract()> _
    Function GuardarDsctoExtorno(ByVal oeMovimiento As e_Movimiento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimiento As e_Movimiento) As Boolean

End Interface
