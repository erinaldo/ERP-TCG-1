Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GastoOperacion", también debe actualizar la referencia a "Ie_GastoOperacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_GastoOperacion

    <OperationContract()> _
    Function Obtener(ByVal gastoOperacion As e_GastoOperacion) As e_GastoOperacion

End Interface
