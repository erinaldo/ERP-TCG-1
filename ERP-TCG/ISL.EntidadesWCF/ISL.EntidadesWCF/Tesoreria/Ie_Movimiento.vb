Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Movimiento", también debe actualizar la referencia a "Ie_Movimiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_Movimiento

    <OperationContract()> _
    Function Obtener(ByVal movimiento As e_Movimiento) As e_Movimiento

End Interface
