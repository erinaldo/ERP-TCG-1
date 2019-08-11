Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DocumentoVehicular_Documento", también debe actualizar la referencia a "Ie_DocumentoVehicular_Documento" en Web.config.
<ServiceContract()> _
Public Interface Ie_DocumentoVehicular_Documento

    <OperationContract()> _
    Function Obtener(ByVal DocumentoVehicular_Documento As e_DocumentoVehicular_Documento) As e_DocumentoVehicular_Documento

End Interface
