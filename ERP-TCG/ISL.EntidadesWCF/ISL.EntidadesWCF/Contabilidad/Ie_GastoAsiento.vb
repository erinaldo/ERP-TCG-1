Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GastoAsiento", también debe actualizar la referencia a "Ie_GastoAsiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_GastoAsiento

    <OperationContract()> _
    Function Obtener(ByVal gastoAsiento As e_GastoAsiento) As e_GastoAsiento

End Interface
