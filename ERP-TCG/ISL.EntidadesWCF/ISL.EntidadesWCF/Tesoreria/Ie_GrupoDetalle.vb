Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GrupoDetalle", también debe actualizar la referencia a "Ie_GrupoDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_GrupoDetalle

    <OperationContract()> _
    Function Obtener(ByVal grupoDetalle As e_GrupoDetalle) As e_GrupoDetalle

End Interface
