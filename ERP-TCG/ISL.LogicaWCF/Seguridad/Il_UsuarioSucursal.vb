Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_UsuarioSucursal", también debe actualizar la referencia a "Il_UsuarioSucursal" en Web.config.
<ServiceContract()>
Public Interface Il_UsuarioSucursal

    <OperationContract()>
    Function Obtener(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As e_UsuarioSucursal

    <OperationContract()>
    Function Listar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As List(Of e_UsuarioSucursal)

    <OperationContract()>
    Function ListarTodos(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As List(Of e_UsuarioSucursal)

    <OperationContract()>
    Function Validar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As Boolean

End Interface