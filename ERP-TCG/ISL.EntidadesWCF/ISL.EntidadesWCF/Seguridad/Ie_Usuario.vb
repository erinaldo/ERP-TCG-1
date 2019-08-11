Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Usuario", también debe actualizar la referencia a "Ie_Usuario" en Web.config.
'<ServiceKnownType("Abrir", GetType(e_Usuario)), ServiceContract()> _

<ServiceKnownType(GetType(e_Persona)), ServiceKnownType(GetType(e_Area)), ServiceKnownType(GetType(e_ControlTurnoUsuario)), _
 ServiceContract()> _
Public Interface Ie_Usuario

    <OperationContract()> _
    Function Obtener(ByVal usuario As e_Usuario) As e_Usuario

    <OperationContract()> _
    Function ObtenerIP() As String

    <OperationContract()> _
    Function ObtenerNombrePC() As String

    <OperationContract()> _
    Function ObtenerLoginWindows() As String

    <OperationContract()> _
    Function Inicializar() As e_Usuario

End Interface
