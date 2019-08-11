Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteFlete", también debe actualizar la referencia a "Ie_ReporteFlete" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteFlete

    <OperationContract()> _
    Function Obtener(ByVal reporteFlete As e_ReporteFlete) As e_ReporteFlete

End Interface
