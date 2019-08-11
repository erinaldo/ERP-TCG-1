Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DocumentoAsociado", también debe actualizar la referencia a "Ie_DocumentoAsociado" en Web.config.
<ServiceContract()> _
Public Interface Ie_DocumentoAsociado

    <OperationContract()> _
    Function Obtener(ByVal documentoAsociado As e_DocumentoAsociado) As e_DocumentoAsociado

End Interface
