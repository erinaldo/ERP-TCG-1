' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_UsuarioSucursal" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_UsuarioSucursal.svc o e_UsuarioSucursal.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()>
Public Class e_UsuarioSucursal
    Implements Ie_UsuarioSucursal
    Implements IEquatable(Of e_UsuarioSucursal)

#Region "Declaracion de Variables"

    Private _id As String
    Private _descripcion As String
    Private _principal As Integer
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String


    <DataMember()>
    Public oeUsuario As New e_Usuario
    <DataMember()>
    Public oeCentro As New e_Centro

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Propiedad"

    <DataMember()>
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()>
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()>
    Public Property Principal() As Integer
        Get
            Return _principal
        End Get
        Set(ByVal value As Integer)
            _principal = value
        End Set
    End Property

    <DataMember()>
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()>
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()>
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        oeUsuario.Id = ""
        _descripcion = ""
        _activo = True
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _principal = -1
        oeCentro.Id = ""
        TipoOperacion = ""
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_IdUsuario As String _
              , ByVal ls_IdCentro As String _
              , ByVal centro As String _
              , ByVal ls_Descripcion As String _
              , ByVal Principal As Boolean _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String
           )
        _id = ls_Id
        oeUsuario.Id = ls_IdUsuario
        oeCentro.Id = ls_IdCentro
        oeCentro.Nombre = centro
        _descripcion = ls_Descripcion
        _principal = IIf(Principal, 1, 0)
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        TipoOperacion = ""
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As Boolean Implements System.IEquatable(Of e_UsuarioSucursal).Equals
        If Me.oeCentro.Id = oeUsuarioSucursal.oeCentro.Id Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function Obtener(ByVal usuarioSucursal As e_UsuarioSucursal) As e_UsuarioSucursal Implements Ie_UsuarioSucursal.Obtener
        Return usuarioSucursal
    End Function

#End Region

End Class
