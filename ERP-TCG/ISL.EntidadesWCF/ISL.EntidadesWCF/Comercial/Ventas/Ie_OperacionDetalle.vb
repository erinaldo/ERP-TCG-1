Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OperacionDetalle", también debe actualizar la referencia a "Ie_OperacionDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_OperacionDetalle

    <OperationContract()> _
    Function Obtener(ByVal operacionDetalle As e_OperacionDetalle) As e_OperacionDetalle

End Interface
