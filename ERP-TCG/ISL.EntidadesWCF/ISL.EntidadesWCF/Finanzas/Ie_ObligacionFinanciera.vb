Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ObligacionFinanciera", también debe actualizar la referencia a "Ie_ObligacionFinanciera" en Web.config.
<ServiceContract()> _
Public Interface Ie_ObligacionFinanciera

    <OperationContract()> _
    Function Obtener(ByVal obligacionFinanciera As e_ObligacionFinanciera) As e_ObligacionFinanciera

End Interface
