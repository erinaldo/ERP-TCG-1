Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Auditoria", también debe actualizar la referencia a "Ie_Auditoria" en Web.config.
<ServiceContract()> _
Public Interface Ie_Auditoria

    <OperationContract()> _
    Function Obtener(ByVal auditoria As e_Auditoria) As e_Auditoria

End Interface
