Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ReporteFlete", también debe actualizar la referencia a "Il_ReporteFlete" en Web.config.
<ServiceContract()> _
Public Interface Il_ReporteFlete

    <OperationContract()> _
    Function Obtener(ByVal oeReporteFlete As e_ReporteFlete) As e_ReporteFlete

    <OperationContract()> _
    Function Listar(ByVal oeReporteFlete As e_ReporteFlete) As List(Of e_ReporteFlete)

End Interface
