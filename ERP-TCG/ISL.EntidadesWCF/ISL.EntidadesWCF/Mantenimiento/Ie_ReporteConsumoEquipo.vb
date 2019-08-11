Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ReporteConsumoEquipo", también debe actualizar la referencia a "Ie_ReporteConsumoEquipo" en Web.config.
<ServiceContract()> _
Public Interface Ie_ReporteConsumoEquipo

    <OperationContract()> _
     Function Obtener(ByVal reporteconsumoequipo As e_ReporteConsumoEquipo) As e_ReporteConsumoEquipo

End Interface
