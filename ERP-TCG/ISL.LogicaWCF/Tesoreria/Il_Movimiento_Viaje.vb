Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Movimiento_Viaje", también debe actualizar la referencia a "Il_Movimiento_Viaje" en Web.config.
<ServiceContract()> _
Public Interface Il_Movimiento_Viaje

    <OperationContract()> _
    Function Obtener(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As e_Movimiento_Viaje

    <OperationContract()> _
    Function Listar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As List(Of e_Movimiento_Viaje)

    <OperationContract()> _
    Function Validar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As Boolean

End Interface
