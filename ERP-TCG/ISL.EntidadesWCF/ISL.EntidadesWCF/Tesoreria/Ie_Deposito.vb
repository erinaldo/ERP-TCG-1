Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Deposito", también debe actualizar la referencia a "Ie_Deposito" en Web.config.
<ServiceContract()> _
Public Interface Ie_Deposito

    <OperationContract()> _
    Function Obtener(ByVal deposito As e_Deposito) As e_Deposito

End Interface
