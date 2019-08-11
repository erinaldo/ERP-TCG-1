Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovCuentaCte", también debe actualizar la referencia a "Ie_MovCuentaCte" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovCuentaCte

    <OperationContract()> _
 Function Obtener(ByVal movcuentacte As e_MovCuentaCte) As e_MovCuentaCte

End Interface
