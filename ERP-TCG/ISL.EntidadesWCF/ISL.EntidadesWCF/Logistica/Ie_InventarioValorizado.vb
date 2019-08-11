Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_InventarioValorizado", también debe actualizar la referencia a "Ie_InventarioValorizado" en Web.config.
<ServiceContract()> _
Public Interface Ie_InventarioValorizado

    <OperationContract()> _
    Function Obtener(ByVal inventarioValorizado As e_InventarioValorizado) As e_InventarioValorizado

End Interface
