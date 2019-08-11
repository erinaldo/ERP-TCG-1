Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MontoFlujoDiario", también debe actualizar la referencia a "Ie_MontoFlujoDiario" en Web.config.
<ServiceContract()> _
Public Interface Ie_MontoFlujoDiario

    <OperationContract()> _
    Function Obtener(ByVal montoFlujoDiario As e_MontoFlujoDiario) As e_MontoFlujoDiario

End Interface
