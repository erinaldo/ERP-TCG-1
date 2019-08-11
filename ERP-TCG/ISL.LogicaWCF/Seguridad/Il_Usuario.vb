Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Usuario", también debe actualizar la referencia a "Il_Usuario" en Web.config.
<ServiceContract()> _
Public Interface Il_Usuario

    <OperationContract()> _
    Function Autenticar(usuario As String, clave As String) As e_Usuario

    <OperationContract()> _
    Function ValidarNombre(ByVal Nombre As String) As Boolean

    <OperationContract()> _
    Function ValidarClave(ByVal Clave As String) As Boolean

    <OperationContract()> _
    Overloads Function Validar(ByVal oeUsuario As e_Usuario) As Boolean

    <OperationContract()> _
    Function IniciarSesion(ByVal oeUsuario As e_Usuario) As e_Usuario

    <OperationContract()> _
    Function ActualizaFechaUltimoIngreso(ByVal oeUsuario As e_Usuario) As Boolean

    <OperationContract()> _
    Overloads Function Obtener(ByVal oeUsuario As e_Usuario) As e_Usuario

    <OperationContract()> _
    Function Obtener2(ByVal oeUsuario As e_Usuario) As e_Usuario

    <OperationContract()> _
    Function ObtenerUsuarioInicial(ByVal oeUsuario As e_Usuario) As e_Usuario

    <OperationContract()> _
    Function ObtenerAutorizado(ByVal oeUsuario As e_Usuario) As e_Usuario

    <OperationContract()> _
    Overloads Function Listar(ByVal oeUsuario As e_Usuario) As List(Of e_Usuario)

    <OperationContract()> _
    Overloads Function ListarIngreso(ByVal oeUsuario As e_Usuario) As List(Of e_Usuario)

    <OperationContract()> _
    Overloads Function ListarConectados() As List(Of e_UsuarioConectado)

    <OperationContract()> _
    Overloads Function ListarDesconectados() As List(Of e_UsuarioDesconectado)

    <OperationContract()> _
    Overloads Function ListarSinAccesoUnaSemana() As List(Of e_UsuarioSinAcceso)

    <OperationContract()> _
    Overloads Function ListarSinAccesoMasDeUnaSemana() As List(Of e_UsuarioSinAcceso)

    <OperationContract()> _
    Overloads Function Guardar(ByVal oeUsuario As e_Usuario) As Boolean

    <OperationContract()> _
    Overloads Function Eliminar(ByVal oeUsuario As e_Usuario) As Boolean

    <OperationContract()> _
    Function CambiarClave(ByVal oeUsuario As e_Usuario) As Boolean

    <OperationContract()> _
    Function Area(ByVal oeUsuario As e_Usuario) As e_Area

    <OperationContract()> _
    Function ValidaTurno(ByVal oeUsuario As e_Usuario) As Boolean

    <OperationContract()> _
    Function ValidaSalida(ByVal oeUsuario As e_Usuario) As DataSet

    <OperationContract()> _
    Function ObtieneFechaServidor(ByVal oeUsuario As e_Usuario) As e_Usuario

    <OperationContract()> _
    Function RecuperarClave(usuario As String) As String

    '<OperationContract()> _
    'Function Inicializar() As e_Usuario

End Interface
