Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Movimiento_Flete", también debe actualizar la referencia a "Il_Movimiento_Flete" en Web.config.
<ServiceContract()> _
Public Interface Il_Movimiento_Flete

    <OperationContract()> _
    Function Obtener(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As e_Movimiento_Flete

    <OperationContract()> _
    Function Listar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As List(Of e_Movimiento_Flete)

    <OperationContract()> _
    Function Validar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As Boolean

End Interface
