Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TurnoUsuario", también debe actualizar la referencia a "Il_TurnoUsuario" en Web.config.
<ServiceContract()> _
Public Interface Il_TurnoUsuario

    <OperationContract()> _
    Function Obtener(ByVal oeTurnoUsuario As e_TurnoUsuario) As e_TurnoUsuario

    <OperationContract()> _
    Function Listar(ByVal oeTurnoUsuario As e_TurnoUsuario) As List(Of e_TurnoUsuario)

    <OperationContract()> _
    Function Validar(ByVal oeTurnoUsuario As e_TurnoUsuario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTurnoUsuario As e_TurnoUsuario) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTurnoUsuario As e_TurnoUsuario) As Boolean

End Interface
