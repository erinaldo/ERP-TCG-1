Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GuiasTalonarios", también debe actualizar la referencia a "Ie_GuiasTalonarios" en Web.config.
<ServiceContract()> _
Public Interface Ie_GuiasTalonarios

    <OperationContract()> _
    Function Obtener(ByVal guiasTalonarios As e_GuiasTalonarios) As e_GuiasTalonarios

End Interface
