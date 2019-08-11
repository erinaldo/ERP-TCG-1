Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteRecorrdio", también debe actualizar la referencia a "Ie_ReporteRecorrido" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteRecorrido

    <OperationContract()> _
    Function Obtener(ByVal ReporteRecorrido As e_ReporteRecorrido) As e_ReporteRecorrido

End Interface
