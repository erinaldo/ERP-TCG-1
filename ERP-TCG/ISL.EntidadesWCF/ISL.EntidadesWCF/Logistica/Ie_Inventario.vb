Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Inventario", también debe actualizar la referencia a "Ie_Inventario" en Web.config.
<ServiceContract()> _
Public Interface Ie_Inventario

    <OperationContract()> _
    Function Obtener(ByVal inventario As e_Inventario) As e_Inventario

End Interface
