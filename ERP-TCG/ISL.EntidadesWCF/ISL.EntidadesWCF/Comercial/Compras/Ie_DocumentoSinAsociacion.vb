Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DocumentoSinAsociacion", también debe actualizar la referencia a "Ie_DocumentoSinAsociacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_DocumentoSinAsociacion

    <OperationContract()> _
    Function Obtener(ByVal documentoSinAsociacion As e_DocumentoSinAsociacion) As e_DocumentoSinAsociacion

End Interface
