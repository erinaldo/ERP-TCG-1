Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteOTServicio", también debe actualizar la referencia a "Ie_ReporteOTServicio" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteOTServicio

    <OperationContract()> _
    Function Obtener(ByVal reporteotservicio As e_ReporteOTServicio) As e_ReporteOTServicio

End Interface
