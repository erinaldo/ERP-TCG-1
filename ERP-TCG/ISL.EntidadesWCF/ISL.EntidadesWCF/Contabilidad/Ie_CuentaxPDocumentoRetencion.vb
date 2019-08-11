Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaxPDocumentoRetencion", también debe actualizar la referencia a "Ie_CuentaxPDocumentoRetencion" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaxPDocumentoRetencion

    <OperationContract()> _
    Function Obtener(ByVal cuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As e_CuentaxPDocumentoRetencion

End Interface
