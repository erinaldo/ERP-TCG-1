Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ObligacionPago", también debe actualizar la referencia a "Ie_ObligacionPago" en Web.config.
<ServiceContract()> _
Public Interface Ie_ObligacionPago

    <OperationContract()> _
    Function Obtener(ByVal obligacionPago As e_ObligacionPago) As e_ObligacionPago

End Interface
