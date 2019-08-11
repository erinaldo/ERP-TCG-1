Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleDocumento", también debe actualizar la referencia a "Ie_DetalleDocumento" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleDocumento

    <OperationContract()> _
    Function Obtener(ByVal detalleDocumento As e_DetalleDocumento) As e_DetalleDocumento

End Interface
