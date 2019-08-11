Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RegistroInventarioOrden", también debe actualizar la referencia a "Ie_RegistroInventarioOrden" en Web.config.
<ServiceContract()> _
Public Interface Ie_RegistroInventarioOrden

    <OperationContract()> _
    Function Obtener(ByVal registroInventarioOrden As e_RegistroInventarioOrden) As e_RegistroInventarioOrden

End Interface
