Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoDocumento", también debe actualizar la referencia a "Ie_TipoDocumento" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoDocumento

    <OperationContract()> _
    Function Obtener(ByVal tipoDocumento As e_TipoDocumento) As e_TipoDocumento

End Interface
