Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteClienteMensual", también debe actualizar la referencia a "Ie_ReporteClienteMensual" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteClienteMensual

    <OperationContract()> _
    Function Obtener(ByVal reporteclientemensual As e_ReporteClienteMensual) As e_ReporteClienteMensual

End Interface
