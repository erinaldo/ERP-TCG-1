Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleInventario", también debe actualizar la referencia a "Ie_DetalleInventario" en Web.config.
<ServiceContract()> _
Public Interface Ie_CodigoBarraMaterial

    <OperationContract()> _
    Function Obtener(ByVal codigobarramaterial As e_CodigoBarraMaterial) As e_CodigoBarraMaterial

End Interface
