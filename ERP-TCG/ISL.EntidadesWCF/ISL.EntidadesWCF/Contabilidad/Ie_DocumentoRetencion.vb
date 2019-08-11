Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DocumentoRetencion", también debe actualizar la referencia a "Ie_DocumentoRetencion" en Web.config.
<ServiceContract()> _
Public Interface Ie_DocumentoRetencion

    <OperationContract()> _
    Function Obtener(ByVal documentoRetencion As e_DocumentoRetencion) As e_DocumentoRetencion

End Interface
