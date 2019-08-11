Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Historial", también debe actualizar la referencia a "Ie_Historial" en Web.config.
<ServiceContract()> _
Public Interface Ie_Historial

    <OperationContract()> _
    Function Obtener(ByVal historial As e_Historial) As e_Historial

End Interface
