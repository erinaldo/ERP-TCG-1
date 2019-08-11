<DataContract()> _
Public Class e_PerfilActividadNegocio
    Implements Ie_PerfilActividadNegocio
    Implements IEquatable(Of e_PerfilActividadNegocio)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idperfil As String
    Private _Perfil As String ' New e_Perfil
    Private _idprocesonegocio As String
    Private _procesonegocio
    Private _idactividadnegocio As String 'New e_ActividadNegocio
    Private _ActividadNegocio As String
    Private _descripcion As String
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String

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
    Public Property IdPerfil() As String
        Get
            Return _idperfil
        End Get
        Set(ByVal value As String)
            _idperfil = value
        End Set
    End Property

    <DataMember()> _
    Public Property Perfil() As String
        Get
            Return _Perfil
        End Get
        Set(ByVal value As String)
            _Perfil = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdProcesoNegocio() As String
        Get
            Return _idprocesonegocio
        End Get
        Set(ByVal value As String)
            _idprocesonegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property ProcesoNegocio() As String
        Get
            Return _procesonegocio
        End Get
        Set(ByVal value As String)
            _procesonegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdActividadNegocio() As String
        Get
            Return _idactividadnegocio
        End Get
        Set(ByVal value As String)
            _idactividadnegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property ActividadNegocio() As String
        Get
            Return _ActividadNegocio
        End Get
        Set(ByVal value As String)
            _ActividadNegocio = value
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

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _activo = True
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _descripcion = String.Empty
        _idperfil = String.Empty
        _Perfil = String.Empty
        _idprocesonegocio = String.Empty
        _procesonegocio = String.Empty
        _idactividadnegocio = String.Empty
        _ActividadNegocio = String.Empty
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPerfil As String _
              , ByVal ls_Perfil As String _
              , ByVal ls_IdProcesoNegocio As String _
              , ByVal ls_ProcesoNegocio As String _
              , ByVal ls_IdActividadNegocio As String _
              , ByVal ls_ActividadNegocio As String _
              , ByVal ls_Descripcion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idperfil = ls_IdPerfil
        _Perfil = ls_Perfil
        _idprocesonegocio = ls_IdProcesoNegocio
        _procesonegocio = ls_ProcesoNegocio
        _idactividadnegocio = ls_IdActividadNegocio
        _ActividadNegocio = ls_ActividadNegocio
        _descripcion = ls_Descripcion
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        TipoOperacion = ""
    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_PerfilActividadNegocio
    ''' </summary>
    ''' <param name="perfilActividadNegocio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal perfilActividadNegocio As e_PerfilActividadNegocio) As e_PerfilActividadNegocio Implements Ie_PerfilActividadNegocio.Obtener
        Return perfilActividadNegocio
    End Function

    Public Overloads Function Equals(ByVal oe As e_PerfilActividadNegocio) _
   As Boolean Implements System.IEquatable(Of e_PerfilActividadNegocio).Equals
        If Me.IdActividadNegocio = oe.IdActividadNegocio Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class
