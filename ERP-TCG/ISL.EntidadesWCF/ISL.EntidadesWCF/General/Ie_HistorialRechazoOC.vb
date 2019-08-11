Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_HistorialRechazoOC", también debe actualizar la referencia a "Ie_HistorialRechazoOC" en Web.config.
<ServiceContract()> _
Public Interface Ie_HistorialRechazoOC

    <OperationContract()> _
    Function Obtener(ByVal historialrechazooc As e_HistorialRechazoOC) As e_HistorialRechazoOC

End Interface
