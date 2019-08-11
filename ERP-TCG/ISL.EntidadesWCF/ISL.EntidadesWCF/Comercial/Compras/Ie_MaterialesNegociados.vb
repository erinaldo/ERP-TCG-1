Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MaterialesNegociados", también debe actualizar la referencia a "Ie_MaterialesNegociados" en Web.config.
<ServiceContract()> _
Public Interface Ie_MaterialesNegociados

    <OperationContract()> _
    Function Obtener(ByVal materialesNegociados As e_MaterialesNegociados) As e_MaterialesNegociados

End Interface
