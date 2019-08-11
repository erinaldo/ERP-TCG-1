Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaPorCobrarDetalle", también debe actualizar la referencia a "Ie_CuentaPorCobrarDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaPorCobrarDetalle

    <OperationContract()> _
    Function Obtener(ByVal cuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As e_CuentaPorCobrarDetalle

End Interface
