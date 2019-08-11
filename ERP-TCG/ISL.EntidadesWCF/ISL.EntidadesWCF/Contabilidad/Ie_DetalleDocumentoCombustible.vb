Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleDocumentoCombustible", también debe actualizar la referencia a "Ie_DetalleDocumentoCombustible" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleDocumentoCombustible

    <OperationContract()> _
    Function Obtener(ByVal detalleDocumentoCombustible As e_DetalleDocumentoCombustible) As e_DetalleDocumentoCombustible

End Interface
