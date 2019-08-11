Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MenuProceso", también debe actualizar la referencia a "Ie_MenuProceso" en Web.config.
<ServiceContract()> _
Public Interface Ie_MenuProceso

    <OperationContract()> _
    Function Obtener(ByVal menuProceso As e_MenuProceso) As e_MenuProceso

End Interface
