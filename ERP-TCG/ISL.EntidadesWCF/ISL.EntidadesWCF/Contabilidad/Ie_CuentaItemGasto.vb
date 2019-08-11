Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaItemGasto", también debe actualizar la referencia a "Ie_CuentaItemGasto" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaItemGasto

    <OperationContract()> _
    Function Obtener(ByVal cuentaItemGasto As e_CuentaItemGasto) As e_CuentaItemGasto

End Interface
