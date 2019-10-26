Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ReporteDocumento", también debe actualizar la referencia a "Il_ReporteDocumento" en Web.config.
<ServiceContract()> _
Public Interface Il_ReporteDocumento

    <OperationContract()> _
    Function Listar(ByVal oeReportDoc As e_ReporteDocumento) As List(Of e_ReporteDocumento)

    <OperationContract()> _
    Function ListarRCM(ByVal oeReportCM As e_ReporteClienteMensual) As List(Of e_ReporteClienteMensual)

End Interface
