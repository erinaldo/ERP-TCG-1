Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RegistroConformidadOT", también debe actualizar la referencia a "Ie_RegistroConformidadOT" en Web.config.
<ServiceContract()> _
Public Interface Ie_RegistroConformidadOT

    <OperationContract()> _
    Function Obtener(ByVal registroConformidadOT As e_RegistroConformidadOT) As e_RegistroConformidadOT

End Interface
