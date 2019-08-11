Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GuiaRRemitenteMaterial", también debe actualizar la referencia a "Ie_GuiaRRemitenteMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_GuiaRRemitenteMaterial

    <OperationContract()> _
    Function Obtener(ByVal guiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As e_GuiaRRemitenteMaterial

End Interface
