Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DocumentoVenta", también debe actualizar la referencia a "Ie_DocumentoVenta" en Web.config.
<ServiceContract()> _
Public Interface Ie_DocumentoVenta

    <OperationContract()> _
    Function Obtener(ByVal documentoVenta As e_DocumentoVenta) As e_DocumentoVenta

End Interface
