Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Botones", también debe actualizar la referencia a "Ie_Botones" en Web.config.
<ServiceContract()> _
Public Interface Ie_Botones

    <OperationContract()> _
    Function Obtener(ByVal botones As e_Botones) As e_Botones

End Interface
