Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DocumentoVehicular", también debe actualizar la referencia a "Ie_DocumentoVehicular" en Web.config.
<ServiceContract()> _
Public Interface Ie_DocumentoVehicular

    <OperationContract()> _
    Function Obtener(ByVal documentoVehicular As e_DocumentoVehicular) As e_DocumentoVehicular

End Interface
