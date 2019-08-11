Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MovimientoInventarioAlmacen", también debe actualizar la referencia a "Il_MovimientoInventarioAlmacen" en Web.config.
<ServiceContract()> _
Public Interface Il_MovimientoInventarioAlmacen

    <OperationContract()> _
    Function Obtener(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As e_MovimientoInventarioAlmacen

    <OperationContract()> _
    Function Listar(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As List(Of e_MovimientoInventarioAlmacen)

    <OperationContract()> _
    Function Guardar(ByVal lista As List(Of e_MovimientoInventarioAlmacen)) As Boolean

    <OperationContract()> _
    Function Guardar1(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As Boolean

End Interface
