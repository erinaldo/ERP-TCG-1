Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaFlujoCaja", también debe actualizar la referencia a "Ie_CuentaFlujoCaja" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaFlujoCaja

    <OperationContract()> _
    Function Obtener(ByVal cuentaFlujoCaja As e_CuentaFlujoCaja) As e_CuentaFlujoCaja

End Interface
