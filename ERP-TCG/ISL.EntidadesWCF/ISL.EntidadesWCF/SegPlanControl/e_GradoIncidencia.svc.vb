' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_GradoIncidencia" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_GradoIncidencia.svc o e_GradoIncidencia.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_GradoIncidencia
    Implements Ie_GradoIncidencia

    Public Sub DoWork() Implements Ie_GradoIncidencia.DoWork
    End Sub

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_Nombre As String _
          , ByVal lb_Activo As Boolean _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
       )
        _id = ls_Id
        _nombre = ls_Nombre
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
    End Sub
#End Region

#Region "Propiedad"

    Private _id As String
    Private _nombre As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _fechamodifica As Date
    Private _usuariomodifica As String

    Public TipoOperacion As String
    Public Modificado As Boolean

    Event DatoCambiado()

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
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
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

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region
End Class
