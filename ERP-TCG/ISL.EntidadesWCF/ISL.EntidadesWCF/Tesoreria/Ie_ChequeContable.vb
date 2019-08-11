Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ChequeContable", también debe actualizar la referencia a "Ie_ChequeContable" en Web.config.
<ServiceContract()> _
Public Interface Ie_ChequeContable

    <OperationContract()> _
    Function Obtener(ByVal chequeContable As e_ChequeContable) As e_ChequeContable

End Interface
