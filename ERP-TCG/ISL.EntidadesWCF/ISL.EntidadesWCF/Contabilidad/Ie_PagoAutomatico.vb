Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_PagoAutomatico", también debe actualizar la referencia a "Ie_PagoAutomatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_PagoAutomatico

    <OperationContract()> _
    Function Obtener(ByVal pagoAutomatico As e_PagoAutomatico) As e_PagoAutomatico

End Interface
