Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlTurnoUsuario", también debe actualizar la referencia a "Il_ControlTurnoUsuario" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlTurnoUsuario

    <OperationContract()> _
    Function Obtener(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As e_ControlTurnoUsuario

    <OperationContract()> _
    Function Listar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As List(Of e_ControlTurnoUsuario)

    <OperationContract()> _
    Function Validar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As Boolean

End Interface
