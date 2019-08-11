Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovimientoInventarioAlmacen", también debe actualizar la referencia a "Ie_MovimientoInventarioAlmacen" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovimientoInventarioAlmacen

    <OperationContract()> _
    Function Obtener(ByVal movimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As e_MovimientoInventarioAlmacen

End Interface
