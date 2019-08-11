Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ListaTiposOperacionDetalle", también debe actualizar la referencia a "Ie_ListaTiposOperacionDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_ListaTiposOperacionDetalle

    <OperationContract()> _
    Sub Inicializar()

End Interface
