Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DocumentoVentaDetalle", también debe actualizar la referencia a "Ie_DocumentoVentaDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_DocumentoVentaDetalle

    <OperationContract()> _
    Function Obtener(ByVal documentoVentaDetalle As e_DocumentoVentaDetalle) As e_DocumentoVentaDetalle

End Interface
