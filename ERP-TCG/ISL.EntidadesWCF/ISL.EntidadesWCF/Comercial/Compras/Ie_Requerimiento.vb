Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Requerimiento", también debe actualizar la referencia a "Ie_Requerimiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_Requerimiento

    <OperationContract()> _
    Function Obtener(ByVal requerimiento As e_Requerimiento) As e_Requerimiento

End Interface
