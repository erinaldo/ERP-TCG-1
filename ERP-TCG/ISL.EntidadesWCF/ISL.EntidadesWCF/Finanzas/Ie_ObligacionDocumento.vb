Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ObligacionDocumento", también debe actualizar la referencia a "Ie_ObligacionDocumento" en Web.config.
<ServiceContract()> _
Public Interface Ie_ObligacionDocumento

    <OperationContract()> _
    Function Obtener(ByVal obligacionDocumento As e_ObligacionDocumento) As e_ObligacionDocumento

End Interface
