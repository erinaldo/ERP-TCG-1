Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleDoc_GuiaTrans", también debe actualizar la referencia a "Il_DetalleDoc_GuiaTrans" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleDoc_GuiaTrans

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As e_DetalleDoc_GuiaTrans

    <OperationContract()> _
    Function Listar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As List(Of e_DetalleDoc_GuiaTrans)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

End Interface
