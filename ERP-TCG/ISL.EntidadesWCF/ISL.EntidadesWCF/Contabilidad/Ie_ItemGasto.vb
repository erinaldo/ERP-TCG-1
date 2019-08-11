Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ItemGasto", también debe actualizar la referencia a "Ie_ItemGasto" en Web.config.
<ServiceContract()> _
Public Interface Ie_ItemGasto

    <OperationContract()> _
    Function Obtener(ByVal itemGasto As e_ItemGasto) As e_ItemGasto

End Interface
