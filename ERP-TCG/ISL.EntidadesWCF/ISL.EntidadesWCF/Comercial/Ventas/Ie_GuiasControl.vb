Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GuiasControl", también debe actualizar la referencia a "Ie_GuiasControl" en Web.config.
<ServiceContract()> _
Public Interface Ie_GuiasControl

    <OperationContract()> _
    Function Obtener(ByVal guiasControl As e_GuiasControl) As e_GuiasControl

End Interface
