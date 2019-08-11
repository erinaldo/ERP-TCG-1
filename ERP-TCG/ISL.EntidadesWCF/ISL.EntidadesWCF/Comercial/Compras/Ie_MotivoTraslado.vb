Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MotivoTraslado", también debe actualizar la referencia a "Ie_MotivoTraslado" en Web.config.
<ServiceContract()> _
Public Interface Ie_MotivoTraslado

    <OperationContract()> _
    Function Obtener(ByVal motivoTraslado As e_MotivoTraslado) As e_MotivoTraslado

End Interface
