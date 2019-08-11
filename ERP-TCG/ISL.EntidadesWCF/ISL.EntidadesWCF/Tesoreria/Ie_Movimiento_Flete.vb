Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Movimiento_Flete", también debe actualizar la referencia a "Ie_Movimiento_Flete" en Web.config.
<ServiceContract()> _
Public Interface Ie_Movimiento_Flete

    <OperationContract()> _
    Function Obtener(ByVal movimiento_Flete As e_Movimiento_Flete) As e_Movimiento_Flete

End Interface
