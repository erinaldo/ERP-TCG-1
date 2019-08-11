' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_EncargadoSeguimiento" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_EncargadoSeguimiento.svc o e_EncargadoSeguimiento.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_EncargadoSeguimiento
    Implements Ie_EncargadoSeguimiento

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdIncidencia As String _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_GlosaGeneral As String _
              , ByVal ls_GlosaDescargo As String _
              , ByVal ls_EstadoEncargado As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
           )
        _id = ls_Id
        _idincidencia.Id = ls_IdIncidencia
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _idtrabajador.Id = ls_IdTrabajador
        _glosageneral = ls_GlosaGeneral
        _glosadescargo = ls_GlosaDescargo
        _estadoencargado = ls_EstadoEncargado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
    End Sub

#End Region

#Region "Propiedad"

    Private _id As String
    Private _idincidencia As New e_Incidencia
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _idtrabajador As New e_Trabajador
    Private _glosageneral As String
    Private _glosadescargo As String
    Private _estadoencargado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fechamodifica As Date
    Private _usuariomodifica As String

    Public TipoOperacion As String
    Public Modificado As Boolean

    Event DatoCambiado()

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property IdIncidencia() As String
        Get
            Return _idincidencia.Id
        End Get
        Set(ByVal value As String)
            _idincidencia.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FechaFin() As Date
        Get
            Return _fechafin
        End Get
        Set(ByVal value As Date)
            _fechafin = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador.Id
        End Get
        Set(ByVal value As String)
            _idtrabajador.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property GlosaGeneral() As String
        Get
            Return _glosageneral
        End Get
        Set(ByVal value As String)
            _glosageneral = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property GlosaDescargo() As String
        Get
            Return _glosadescargo
        End Get
        Set(ByVal value As String)
            _glosadescargo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property EstadoEncargado() As String
        Get
            Return _estadoencargado
        End Get
        Set(ByVal value As String)
            _estadoencargado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

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

    Public Sub DoWork() Implements Ie_EncargadoSeguimiento.DoWork
    End Sub

End Class
