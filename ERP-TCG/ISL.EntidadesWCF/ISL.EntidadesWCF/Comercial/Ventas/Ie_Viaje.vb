Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Viaje", también debe actualizar la referencia a "Ie_Viaje" en Web.config.
<ServiceContract()> _
Public Interface Ie_Viaje

    <OperationContract()> _
    Function Obtener(ByVal viaje As e_Viaje) As e_Viaje
    <OperationContract()> _
    Function CalcularTotalFlete(ByVal FleteUnitario As Double, ByVal Igv As Double) As Double
End Interface
