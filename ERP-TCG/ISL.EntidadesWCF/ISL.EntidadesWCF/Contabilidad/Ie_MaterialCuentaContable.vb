Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MaterialCuentaContable", también debe actualizar la referencia a "Ie_MaterialCuentaContable" en Web.config.
<ServiceContract()> _
Public Interface Ie_MaterialCuentaContable

    <OperationContract()> _
    Function Obtener(ByVal materialCuentaContable As e_MaterialCuentaContable) As e_MaterialCuentaContable

End Interface
