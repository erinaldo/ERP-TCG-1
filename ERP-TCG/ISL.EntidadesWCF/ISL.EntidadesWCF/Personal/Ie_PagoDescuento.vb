Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_PagoDescuento", también debe actualizar la referencia a "Ie_PagoDescuento" en Web.config.
<ServiceContract()> _
Public Interface Ie_PagoDescuento

    <OperationContract()> _
    Function Obtener(ByVal pagodescuento As e_PagoDescuento) As e_PagoDescuento

End Interface
