Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleInventario", también debe actualizar la referencia a "Ie_DetalleInventario" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleInventario

    <OperationContract()> _
    Function Obtener(ByVal detalleInventario As e_DetalleInventario) As e_DetalleInventario

End Interface
