Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_PersonaEmpresa_TipoPago", también debe actualizar la referencia a "Ie_PersonaEmpresa_TipoPago" en Web.config.
<ServiceContract()> _
Public Interface Ie_PersonaEmpresa_TipoPago

    <OperationContract()> _
    Function Obtener(ByVal personaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As e_PersonaEmpresa_TipoPago

End Interface
