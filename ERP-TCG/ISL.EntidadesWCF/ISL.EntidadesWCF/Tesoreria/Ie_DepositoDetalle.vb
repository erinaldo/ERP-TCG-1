Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DepositoDetalle", también debe actualizar la referencia a "Ie_DepositoDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_DepositoDetalle

    <OperationContract()> _
    Function Obtener(ByVal depositoDetalle As e_DepositoDetalle) As e_DepositoDetalle

End Interface
