Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlUsuario", también debe actualizar la referencia a "Il_ControlUsuario" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlUsuario

    <OperationContract()> _
    Function Obtener(ByVal oeControlUsuario As e_ControlUsuario) As e_ControlUsuario

    <OperationContract()> _
    Function Listar(ByVal oeControlUsuario As e_ControlUsuario) As List(Of e_ControlUsuario)

    <OperationContract()> _
    Function Validar(ByVal oeControlUsuario As e_ControlUsuario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeControlUsuario As e_ControlUsuario) As String

    <OperationContract()> _
    Function Eliminar(ByVal oeControlUsuario As e_ControlUsuario) As Boolean

    <OperationContract()> _
    Function RegistrarSalida(ByVal idControlUsuario As String) As Boolean

End Interface
