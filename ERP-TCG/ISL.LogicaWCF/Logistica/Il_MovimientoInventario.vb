Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MovimientoInventario", también debe actualizar la referencia a "Il_MovimientoInventario" en Web.config.
<ServiceContract()> _
Public Interface Il_MovimientoInventario

    <OperationContract()> _
    Function Obtener(ByVal oeMovimientoInventario As e_MovimientoInventario) As e_MovimientoInventario

    <OperationContract()> _
    Function Listar(ByVal oeMovimientoInventario As e_MovimientoInventario) As List(Of e_MovimientoInventario)

    <OperationContract()> _
    Function Guardar(ByVal oeMovimientoInventario As e_MovimientoInventario) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimientoInventario As e_MovimientoInventario) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeMovimientoInventario As e_MovimientoInventario) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo _
                                      As String) As Boolean

End Interface
