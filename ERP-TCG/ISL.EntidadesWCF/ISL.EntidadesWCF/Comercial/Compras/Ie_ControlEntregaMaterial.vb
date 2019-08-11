Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ControlEntregaMaterial", también debe actualizar la referencia a "Ie_ControlEntregaMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_ControlEntregaMaterial

    <OperationContract()> _
    Function Obtener(ByVal controlentregamaterial As e_ControlEntregaMaterial) As e_ControlEntregaMaterial

End Interface
