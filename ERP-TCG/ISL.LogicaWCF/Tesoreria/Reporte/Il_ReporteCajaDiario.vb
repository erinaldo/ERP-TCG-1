Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ReporteCajaDiario", también debe actualizar la referencia a "Il_ReporteCajaDiario" en Web.config.
<ServiceContract()> _
Public Interface Il_ReporteCajaDiario

    <OperationContract()> _
    Function Listar(ByVal oeReporteCajaDiario As e_ReporteCajaDiario) As List(Of e_ReporteCajaDiario)

End Interface
