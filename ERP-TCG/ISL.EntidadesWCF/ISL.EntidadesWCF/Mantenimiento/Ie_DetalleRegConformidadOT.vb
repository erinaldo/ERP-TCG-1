Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleRegConformidadOT", también debe actualizar la referencia a "Ie_DetalleRegConformidadOT" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleRegConformidadOT

    <OperationContract()> _
    Function Obtener(ByVal detalleRegConformidadOT As e_DetalleRegConformidadOT) As e_DetalleRegConformidadOT

End Interface
