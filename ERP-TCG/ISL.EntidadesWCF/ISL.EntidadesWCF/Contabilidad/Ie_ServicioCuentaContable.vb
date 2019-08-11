Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ServicioCuentaContable", también debe actualizar la referencia a "Ie_ServicioCuentaContable" en Web.config.
<ServiceContract()> _
Public Interface Ie_ServicioCuentaContable

    <OperationContract()> _
    Function Obtener(ByVal servicioCuentaContable As e_ServicioCuentaContable) As e_ServicioCuentaContable

End Interface
