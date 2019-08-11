Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaPorCobrar", también debe actualizar la referencia a "Ie_CuentaPorCobrar" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaPorCobrar

    <OperationContract()> _
    Function Obtener(ByVal cuentaPorCobrar As e_CuentaPorCobrar) As e_CuentaPorCobrar

End Interface
