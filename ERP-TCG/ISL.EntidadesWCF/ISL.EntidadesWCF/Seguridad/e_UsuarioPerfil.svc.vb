
<DataContract()> _
Public Class e_UsuarioPerfil
    Implements Ie_UsuarioPerfil
    Implements IEquatable(Of e_UsuarioPerfil)

#Region "Declaracion de Variables"

    Private _id As String
    Private _descripcion As String
    Private _principal As Integer
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String


    <DataMember()> _
    Public oeUsuario As New e_Usuario
    <DataMember()> _
    Public oePerfil As New e_Perfil

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Principal() As Integer
        Get
            Return _principal
        End Get
        Set(ByVal value As Integer)
            _principal = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
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
        oePerfil.Id = ""
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdUsuario As String _
              , ByVal ls_IdPerfil As String _
              , ByVal Perfil As String _
              , ByVal ls_Descripcion As String _
              , ByVal Principal As Boolean _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        oeUsuario.Id = ls_IdUsuario
        oePerfil.Id = ls_IdPerfil
        oePerfil.Nombre = Perfil
        _descripcion = ls_Descripcion
        _principal = IIf(Principal, 1, 0)
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        TipoOperacion = ""
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As Boolean Implements System.IEquatable(Of e_UsuarioPerfil).Equals
        If Me.oePerfil.Id = oeUsuarioPerfil.oePerfil.Id Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Obtener una entidad de tipo e_UsuarioPerfil
    ''' </summary>
    ''' <param name="usuarioPerfil"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal usuarioPerfil As e_UsuarioPerfil) As e_UsuarioPerfil Implements Ie_UsuarioPerfil.Obtener
        Return usuarioPerfil
    End Function

#End Region

End Class

