Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MontoFlujoDiario_Det", también debe actualizar la referencia a "Ie_MontoFlujoDiario_Det" en Web.config.
<ServiceContract()> _
Public Interface Ie_MontoFlujoDiario_Det

    <OperationContract()> _
    Function Obtener(ByVal montoFlujoDiario_Det As e_MontoFlujoDiario_Det) As e_MontoFlujoDiario_Det

End Interface
