Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OcupacionTrabajador", también debe actualizar la referencia a "Ie_OcupacionTrabajador" en Web.config.
<ServiceContract()> _
Public Interface Ie_OcupacionTrabajador

    <OperationContract()> _
    Function Obtener(ByVal ocupacionTrabajador As e_OcupacionTrabajador) As e_OcupacionTrabajador

End Interface
