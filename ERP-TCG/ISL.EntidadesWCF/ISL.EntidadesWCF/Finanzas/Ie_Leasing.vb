Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Leasing", también debe actualizar la referencia a "Ie_Leasing" en Web.config.
<ServiceContract()> _
Public Interface Ie_Leasing

    <OperationContract()> _
    Function Obtener(ByVal leasing As e_Leasing) As e_Leasing

End Interface
