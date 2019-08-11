Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteFondoFijo", también debe actualizar la referencia a "Ie_ReporteFondoFijo" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteFondoFijo

    <OperationContract()> _
    Function Obtener(ByVal reporteFondoFijo As e_ReporteFondoFijo) As e_ReporteFondoFijo

End Interface
