Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaContable", también debe actualizar la referencia a "Ie_CuentaContable" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaContable

    <OperationContract()> _
    Function Obtener(ByVal cuentaContable As e_CuentaContable) As e_CuentaContable

End Interface
