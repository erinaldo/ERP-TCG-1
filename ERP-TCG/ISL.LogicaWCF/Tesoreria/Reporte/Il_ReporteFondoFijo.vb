Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ReporteFondoFijo", también debe actualizar la referencia a "Il_ReporteFondoFijo" en Web.config.
<ServiceContract()> _
Public Interface Il_ReporteFondoFijo

    <OperationContract()> _
    Function Obtener(ByVal oeReporteFondoFijo As e_ReporteFondoFijo) As e_ReporteFondoFijo

    <OperationContract()> _
    Function Listar(ByVal oeReporteFondoFijo As e_ReporteFondoFijo) As List(Of e_ReporteFondoFijo)

    <OperationContract()> _
    Function ListarFondo(ByVal oeReporteFondoFijo As e_ReporteFondoFijo) As e_ReporteFondoFijo

End Interface
