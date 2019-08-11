Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ListaTiposOperacionCabecera", también debe actualizar la referencia a "Ie_ListaTiposOperacionCabecera" en Web.config.
<ServiceContract()> _
Public Interface Ie_ListaTiposOperacionCabecera

    <OperationContract()> _
    Sub Inicializar()

End Interface
