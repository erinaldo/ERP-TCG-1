Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleDoc_GuiaTrans", también debe actualizar la referencia a "Ie_DetalleDoc_GuiaTrans" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleDoc_GuiaTrans

    <OperationContract()> _
    Function Obtener(ByVal detalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As e_DetalleDoc_GuiaTrans

End Interface
