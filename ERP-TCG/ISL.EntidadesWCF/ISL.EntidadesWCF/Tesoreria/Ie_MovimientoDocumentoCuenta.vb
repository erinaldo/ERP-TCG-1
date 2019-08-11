Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovimientoDocumentoCuenta", también debe actualizar la referencia a "Ie_MovimientoDocumentoCuenta" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovimientoDocumentoCuenta

    <OperationContract()> _
    Function Obtener(ByVal movimientoDocumentoCuenta As e_MovimientoDocumentoCuenta) As e_MovimientoDocumentoCuenta

End Interface
