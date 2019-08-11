Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Movimiento_Viaje", también debe actualizar la referencia a "Ie_Movimiento_Viaje" en Web.config.
<ServiceContract()> _
Public Interface Ie_Movimiento_Viaje

    <OperationContract()> _
    Function Obtener(ByVal movimiento_Viaje As e_Movimiento_Viaje) As e_Movimiento_Viaje

End Interface
