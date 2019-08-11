Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GrupoDetalleLiq", también debe actualizar la referencia a "Ie_GrupoDetalleLiq" en Web.config.
<ServiceContract()> _
Public Interface Ie_GrupoDetalleLiq

    <OperationContract()> _
    Function Obtener(ByVal grupoDetalleLiq As e_GrupoDetalleLiq) As e_GrupoDetalleLiq

End Interface
