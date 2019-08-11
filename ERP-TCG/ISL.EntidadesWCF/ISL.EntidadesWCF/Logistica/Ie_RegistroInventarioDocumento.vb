Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RegistroInventarioDocumento", también debe actualizar la referencia a "Ie_RegistroInventarioDocumento" en Web.config.
<ServiceContract()> _
Public Interface Ie_RegistroInventarioDocumento

    <OperationContract()> _
    Function Obtener(ByVal registroInventarioDocumento As e_RegistroInventarioDocumento) As e_RegistroInventarioDocumento

End Interface
