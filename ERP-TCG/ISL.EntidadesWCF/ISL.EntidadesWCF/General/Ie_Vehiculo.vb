Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Vehiculo", también debe actualizar la referencia a "Ie_Vehiculo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Vehiculo

    <OperationContract()> _
    Function Obtener(ByVal vehiculo As e_Vehiculo) As e_Vehiculo
    <OperationContract()> _
    Function CapacidadUtil(ByVal TaraTracto As Double, ByVal TaraCarreta As Double, ByVal Bonificacion As Double) As Double
End Interface
