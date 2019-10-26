Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_UsuarioPerfil", también debe actualizar la referencia a "Il_UsuarioPerfil" en Web.config.
<ServiceContract()> _
Public Interface Il_UsuarioPerfil

    <OperationContract()> _
    Function Obtener(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As e_UsuarioPerfil

    <OperationContract()> _
    Function Listar(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As List(Of e_UsuarioPerfil)

    <OperationContract()> _
    Function ListarTodos(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As List(Of e_UsuarioPerfil)

    <OperationContract()> _
    Function Validar(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As Boolean

End Interface
