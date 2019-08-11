Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Marca", también debe actualizar la referencia a "Ie_Marca" en Web.config.
<ServiceContract()> _
Public Interface Ie_Marca

    <OperationContract()> _
    Function Obtener(ByVal marca As e_Marca) As e_Marca

End Interface
