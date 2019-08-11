Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaAsociada", también debe actualizar la referencia a "Ie_CuentaAsociada" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaAsociada

    <OperationContract()> _
    Function Obtener(ByVal cuentaAsociada As e_CuentaAsociada) As e_CuentaAsociada

End Interface
