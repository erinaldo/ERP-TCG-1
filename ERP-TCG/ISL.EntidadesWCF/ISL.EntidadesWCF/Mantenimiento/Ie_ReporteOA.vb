Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteOA", también debe actualizar la referencia a "Ie_ReporteOA" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteOA

    <OperationContract()> _
    Function Obtener(ByVal reporteoa As e_ReporteOA) As e_ReporteOA

End Interface
