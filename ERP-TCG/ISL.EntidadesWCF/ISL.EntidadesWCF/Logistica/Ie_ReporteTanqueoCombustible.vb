Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RegistroConsumoCombustible", también debe actualizar la referencia a "Ie_RegistroConsumoCombustible" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteTanqueoCombustible

    <OperationContract()> _
    Function Obtener(ByVal ReporteTanqueoCombustible As e_ReporteTanqueoCombustible) As e_ReporteTanqueoCombustible

End Interface
