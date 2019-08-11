Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovimientoCajaBanco", también debe actualizar la referencia a "Ie_MovimientoCajaBanco" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovimientoCajaBanco

    <OperationContract()> _
    Function Obtener(ByVal movimientoCajaBanco As e_MovimientoCajaBanco) As e_MovimientoCajaBanco

End Interface
