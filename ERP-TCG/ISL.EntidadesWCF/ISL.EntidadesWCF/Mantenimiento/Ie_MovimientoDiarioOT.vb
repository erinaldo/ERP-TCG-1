Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovimientoDiarioOT", también debe actualizar la referencia a "Ie_MovimientoDiarioOT" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovimientoDiarioOT

    <OperationContract()> _
        Function Obtener(ByVal movimientoot As e_MovimientoDiarioOT) As e_MovimientoDiarioOT

End Interface
