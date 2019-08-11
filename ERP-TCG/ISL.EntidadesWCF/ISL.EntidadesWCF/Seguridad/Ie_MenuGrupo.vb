Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MenuGrupo", también debe actualizar la referencia a "Ie_MenuGrupo" en Web.config.
<ServiceContract()> _
Public Interface Ie_MenuGrupo

    <OperationContract()> _
    Function Obtener(ByVal menuGrupo As e_MenuGrupo) As e_MenuGrupo

End Interface
