Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovimientoInventario", también debe actualizar la referencia a "Ie_MovimientoInventario" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovimientoInventario

    <OperationContract()> _
    Function Obtener(ByVal movimientoInventario As e_MovimientoInventario) As e_MovimientoInventario

End Interface
