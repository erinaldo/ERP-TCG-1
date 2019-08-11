Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaxCyP", también debe actualizar la referencia a "Ie_CuentaxCyP" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaxCyP

    <OperationContract()> _
    Function Obtener(ByVal cuentaxCyP As e_CuentaxCyP) As e_CuentaxCyP

End Interface
