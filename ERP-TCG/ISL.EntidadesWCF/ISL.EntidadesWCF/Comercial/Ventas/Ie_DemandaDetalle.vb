Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DemandaDetalle", también debe actualizar la referencia a "Ie_DemandaDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_DemandaDetalle

    <OperationContract()> _
    Function Obtener(ByVal demandaDetalle As e_DemandaDetalle) As e_DemandaDetalle

    <OperationContract()> _
    Function CalcularFlete(ByVal DemandaDetalle As e_DemandaDetalle) As Double

End Interface
