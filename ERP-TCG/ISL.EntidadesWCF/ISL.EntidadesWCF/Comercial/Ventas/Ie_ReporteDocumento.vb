Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteDocumento", también debe actualizar la referencia a "Ie_ReporteDocumento" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteDocumento

    <OperationContract()> _
    Function Obtener(ByVal reportedocumento As e_ReporteDocumento) As e_ReporteDocumento

End Interface
