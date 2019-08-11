Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteConfiguracion", también debe actualizar la referencia a "Ie_ReporteConfiguracion" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteConfiguracion

    <OperationContract()> _
    Function Obtener(ByVal reporteConfiguracion As e_ReporteConfiguracion) As e_ReporteConfiguracion

End Interface
