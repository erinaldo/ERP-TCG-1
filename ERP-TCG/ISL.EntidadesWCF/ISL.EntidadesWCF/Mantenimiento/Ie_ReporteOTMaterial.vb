Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteOTMaterial", también debe actualizar la referencia a "Ie_ReporteOTMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteOTMaterial

    <OperationContract()> _
     Function Obtener(ByVal reporteotmaterial As e_ReporteOTMaterial) As e_ReporteOTMaterial

End Interface
