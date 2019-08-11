Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AlertaDetalle", también debe actualizar la referencia a "Ie_AlertaDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_AlertaDetalle

    <OperationContract()> _
    Function Obtener(ByVal alertaDetalle As e_AlertaDetalle) As e_AlertaDetalle

End Interface
