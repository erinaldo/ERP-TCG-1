Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DemandaRapida", también debe actualizar la referencia a "Ie_DemandaRapida" en Web.config.
<ServiceContract()> _
Public Interface Ie_DemandaRapida

    <OperationContract()> _
    Function Obtener(ByVal demandaRapida As e_DemandaRapida) As e_DemandaRapida

End Interface
