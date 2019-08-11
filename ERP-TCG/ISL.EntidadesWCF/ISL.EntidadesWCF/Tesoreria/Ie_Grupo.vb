Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Grupo", también debe actualizar la referencia a "Ie_Grupo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Grupo

    <OperationContract()> _
    Function Obtener(ByVal grupo As e_Grupo) As e_Grupo

End Interface
