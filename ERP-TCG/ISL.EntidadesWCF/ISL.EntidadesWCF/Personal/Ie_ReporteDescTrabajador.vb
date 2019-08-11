Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ResporteDescTrabajador", también debe actualizar la referencia a "Ie_ResporteDescTrabajador" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteDescTrabajador

    <OperationContract()> _
    Function Obtener(ByVal reportedectrabajador As e_ReporteDescTrabajador) As e_ReporteDescTrabajador

End Interface
