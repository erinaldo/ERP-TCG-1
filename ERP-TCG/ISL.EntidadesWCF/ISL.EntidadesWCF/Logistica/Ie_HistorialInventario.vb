Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_HistorialInventario", también debe actualizar la referencia a "Ie_HistorialInventario" en Web.config.
<ServiceContract()> _
Public Interface Ie_HistorialInventario

    <OperationContract()> _
    Function Obtener(ByVal historialInventario As e_HistorialInventario) As e_HistorialInventario

End Interface
