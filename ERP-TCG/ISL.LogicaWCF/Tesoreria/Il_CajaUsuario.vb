Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CajaUsuario", también debe actualizar la referencia a "Il_CajaUsuario" en Web.config.
<ServiceContract()> _
Public Interface Il_CajaUsuario

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ID As String, ByVal CAJA As String, ByVal USUARIO As String, ByVal ACTIVO As Boolean) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeCajaUsuario As e_CajaUsuario) As e_CajaUsuario

    <OperationContract()> _
    Function Listar(ByVal oeCajaUsuario As e_CajaUsuario) As List(Of e_CajaUsuario)

    <OperationContract()> _
    Function Validar(ByVal oeCajaUsuario As e_CajaUsuario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCajaUsuario As e_CajaUsuario) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCajaUsuario As e_CajaUsuario) As Boolean

End Interface
