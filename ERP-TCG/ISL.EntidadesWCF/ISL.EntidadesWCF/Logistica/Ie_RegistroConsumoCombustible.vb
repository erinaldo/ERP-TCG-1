Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RegistroConsumoCombustible", también debe actualizar la referencia a "Ie_RegistroConsumoCombustible" en Web.config.
<ServiceContract()> _
Public Interface Ie_RegistroConsumoCombustible

    <OperationContract()> _
    Function Obtener(ByVal registroConsumoCombustible As e_RegistroConsumoCombustible) As e_RegistroConsumoCombustible

End Interface
