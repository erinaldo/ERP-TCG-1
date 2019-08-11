Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovimientoDocumento", también debe actualizar la referencia a "Ie_MovimientoDocumento" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovimientoDocumento

    <OperationContract()> _
    Function Obtener(ByVal movimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

    <OperationContract()> _
    Function CalcularImporte() As Double

    <OperationContract()> _
    Function CalcularTotal() As Double

End Interface
