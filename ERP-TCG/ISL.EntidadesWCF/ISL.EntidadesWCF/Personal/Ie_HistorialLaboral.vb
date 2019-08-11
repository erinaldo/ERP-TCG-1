Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_HistorialLaboral", también debe actualizar la referencia a "Ie_HistorialLaboral" en Web.config.
<ServiceContract()> _
Public Interface Ie_HistorialLaboral

    <OperationContract()> _
    Function Obtener(ByVal historialLaboral As e_HistorialLaboral) As e_HistorialLaboral

End Interface
