Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ChequeEmitido", también debe actualizar la referencia a "Ie_ChequeEmitido" en Web.config.
<ServiceContract()> _
Public Interface Ie_ChequeEmitido

    <OperationContract()> _
    Function Obtener(ByVal chequeemitido As e_ChequeEmitido) As e_ChequeEmitido

End Interface
