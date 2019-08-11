Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteCajaDiario", también debe actualizar la referencia a "Ie_ReporteCajaDiario" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteCajaDiario

    <OperationContract()> _
    Function Obtener(ByVal reporteCajaDiario As e_ReporteCajaDiario) As e_ReporteCajaDiario

End Interface
