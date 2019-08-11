Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Cargo", también debe actualizar la referencia a "Ie_Cargo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Cargo

    <OperationContract()> _
    Function Obtener(ByVal cargo As e_Cargo) As e_Cargo

End Interface
