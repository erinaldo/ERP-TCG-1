Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AreaAO", también debe actualizar la referencia a "Ie_AreaAO" en Web.config.
<ServiceContract()> _
Public Interface Ie_AreaAO

    <OperationContract()> _
    Function Obtener(ByVal area As e_AreaAO) As e_AreaAO

End Interface
