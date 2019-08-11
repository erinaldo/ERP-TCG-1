Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Cliente", también debe actualizar la referencia a "Ie_Cliente" en Web.config.
<ServiceContract()> _
Public Interface Ie_Cliente

    <OperationContract()> _
    Function Obtener(ByVal cliente As e_Cliente) As e_Cliente

End Interface
