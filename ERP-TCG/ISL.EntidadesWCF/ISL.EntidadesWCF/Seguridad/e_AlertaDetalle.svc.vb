
<DataContract()> _
Public Class e_AlertaDetalle
    Implements Ie_AlertaDetalle

#Region "Declaracion de Variables"

    Private _id As String
    Private _idalerta As String
    Private _estado As String
    Private _glosa As String
    Private _email As Boolean
    Private _visual As Boolean
    Private _sonora As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _nombrecompleto As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

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
    Public Property IdAlerta() As String
        Get
            Return _idalerta
        End Get
        Set(ByVal value As String)
            _idalerta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Email() As Boolean
        Get
            Return _email
        End Get
        Set(ByVal value As Boolean)
            _email = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Visual() As Boolean
        Get
            Return _visual
        End Get
        Set(ByVal value As Boolean)
            _visual = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Sonora() As Boolean
        Get
            Return _sonora
        End Get
        Set(ByVal value As Boolean)
            _sonora = value
            RaiseEvent DatoCambiado()
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
    Public Property NombreCompleto() As String
        Get
            Return _nombrecompleto
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _idalerta = ""
        _estado = ""
        _glosa = ""
        _email = False
        _visual = False
        _sonora = False
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        TipoOperacion = ""
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAlerta As String _
              , ByVal ls_Estado As String _
              , ByVal ls_Glosa As String _
              , ByVal lb_Email As Boolean _
              , ByVal lb_Visual As Boolean _
              , ByVal lb_Sonora As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_NombreCompleto As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idalerta = ls_IdAlerta
        _estado = ls_Estado
        _glosa = ls_Glosa
        _email = lb_Email
        _visual = lb_Visual
        _sonora = lb_Sonora
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _nombrecompleto = ls_NombreCompleto
        _activo = lb_Activo

    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_AlertaDetalle
    ''' </summary>
    ''' <param name="alertaDetalle"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal alertaDetalle As e_AlertaDetalle) As e_AlertaDetalle Implements Ie_AlertaDetalle.Obtener
        Return alertaDetalle
    End Function

#End Region

End Class
