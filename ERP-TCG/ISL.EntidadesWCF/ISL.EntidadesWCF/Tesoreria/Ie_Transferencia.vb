Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Transferencia", también debe actualizar la referencia a "Ie_Transferencia" en Web.config.
<ServiceContract()> _
Public Interface Ie_Transferencia

    <OperationContract()> _
    Function Obtener(ByVal transferencia As e_Transferencia) As e_Transferencia

End Interface
