Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GuiasControl", también debe actualizar la referencia a "Il_GuiasControl" en Web.config.
<ServiceContract()> _
Public Interface Il_GuiasControl

    <OperationContract()> _
    Function Obtener(ByVal oeGuiasControl As e_GuiasControl) As e_GuiasControl

    <OperationContract()> _
    Function Listar(ByVal oeGuiasControl As e_GuiasControl) As List(Of e_GuiasControl)

    <OperationContract()> _
    Function Validar(ByVal oeGuiasControl As e_GuiasControl) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGuiasControl As e_GuiasControl) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGuiasControl As e_GuiasControl) As Boolean

    <OperationContract()> _
    Function ObtenerGuiasTalonarios(ByVal oeGuiasTalonarios As e_GuiasTalonarios) As e_GuiasTalonarios

    <OperationContract()> _
    Function ListarGuiasTalonarios(ByVal oeGuiasTalonarios As e_GuiasTalonarios) As List(Of e_GuiasTalonarios)

    <OperationContract()> _
    Function ValidarGuiasTalonarios(ByVal oeGuiasTalonarios As e_GuiasTalonarios) As Boolean

    <OperationContract()> _
    Function GuardarGuiasTalonarios(ByVal oeGuiasTalonarios As e_GuiasTalonarios) As Boolean

    <OperationContract()> _
    Function EliminarGuiasTalonarios(ByVal oeGuiasTalonarios As e_GuiasTalonarios) As Boolean

End Interface
