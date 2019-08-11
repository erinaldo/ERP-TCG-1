Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Saldo", también debe actualizar la referencia a "Ie_Saldo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Saldo

    <OperationContract()> _
    Function Obtener(ByVal saldo As e_Saldo) As e_Saldo

End Interface
