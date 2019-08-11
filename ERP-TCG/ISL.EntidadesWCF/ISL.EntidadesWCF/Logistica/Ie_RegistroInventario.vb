Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RegistroInventario", también debe actualizar la referencia a "Ie_RegistroInventario" en Web.config.
<ServiceContract()> _
Public Interface Ie_RegistroInventario

    <OperationContract()> _
    Function Obtener(ByVal registroInventario As e_RegistroInventario) As e_RegistroInventario

End Interface
