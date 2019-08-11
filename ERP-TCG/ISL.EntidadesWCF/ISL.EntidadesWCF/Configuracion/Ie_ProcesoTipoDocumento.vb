Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ProcesoTipoDocumento", también debe actualizar la referencia a "Ie_ProcesoTipoDocumento" en Web.config.
<ServiceContract()> _
Public Interface Ie_ProcesoTipoDocumento

    <OperationContract()> _
    Function Obtener(ByVal procesoTipoDocumento As e_ProcesoTipoDocumento) As e_ProcesoTipoDocumento

End Interface
