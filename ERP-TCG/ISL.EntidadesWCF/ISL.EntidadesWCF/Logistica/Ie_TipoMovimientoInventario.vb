Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoMovimientoInventario", también debe actualizar la referencia a "Ie_TipoMovimientoInventario" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoMovimientoInventario

    <OperationContract()> _
    Function Obtener(ByVal tipoMovimientoInventario As e_TipoMovimientoInventario) As e_TipoMovimientoInventario

End Interface
