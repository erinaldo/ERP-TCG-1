Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ChequesTalonarios", también debe actualizar la referencia a "Ie_ChequesTalonarios" en Web.config.
<ServiceContract()> _
Public Interface Ie_ChequesTalonarios

    <OperationContract()> _
     Function Obtener(ByVal chequesemitidos As e_ChequesTalonarios) As e_ChequesTalonarios

End Interface
