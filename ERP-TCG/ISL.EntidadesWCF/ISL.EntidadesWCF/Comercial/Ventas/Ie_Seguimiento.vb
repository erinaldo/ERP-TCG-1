Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Seguimiento", también debe actualizar la referencia a "Ie_Seguimiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_Seguimiento

    <OperationContract()> _
    Function Obtener(ByVal seguimiento As e_Seguimiento) As e_Seguimiento

End Interface
