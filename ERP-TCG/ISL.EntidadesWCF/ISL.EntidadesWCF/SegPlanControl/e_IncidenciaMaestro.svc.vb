Public Class e_IncidenciaMaestro
#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _idgradoincidencia As String
    Private _idoperacion As String
    Private _idviaje As String
    Private _idprioridad As String
    Private _idresponsable As String
    Private _fechahora As Date
    Private _asunto As String
    Private _mensaje As String
    Private _clienteexterno As Boolean
    Private _empleadoexterno As String
    Private _estadoincidencia As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fechamodifica As Date
    Private _usuariomodifica As String

    Public TipoOperacion As String
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Event DatoCambiado()

    <DataMember()> _
    Public lstAlarma As New List(Of e_Alarma)

    <DataMember()> _
    Public lstAccidente As New List(Of e_AccidenteIncidencia)

    <DataMember()> _
    Public lstIncidente As New List(Of e_Incidente)

    <DataMember()> _
    Public lstRobo As New List(Of e_Robo)

    '<DataMember()> _
    'Public oeEncargadoSeguimiento As New List(Of e_EncargadoSeguimiento)

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdGradoIncidencia() As String
        Get
            Return _idgradoincidencia
        End Get
        Set(ByVal value As String)
            _idgradoincidencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperacion() As String
        Get
            Return _idoperacion
        End Get
        Set(ByVal value As String)
            _idoperacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _idviaje
        End Get
        Set(ByVal value As String)
            _idviaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPrioridad() As String
        Get
            Return _idprioridad
        End Get
        Set(ByVal value As String)
            _idprioridad = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdResponsable() As String
        Get
            Return _idresponsable
        End Get
        Set(ByVal value As String)
            _idresponsable = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaHora() As Date
        Get
            Return _fechahora
        End Get
        Set(ByVal value As Date)
            _fechahora = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Asunto() As String
        Get
            Return _asunto
        End Get
        Set(ByVal value As String)
            _asunto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Mensaje() As String
        Get
            Return _mensaje
        End Get
        Set(ByVal value As String)
            _mensaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ClienteExterno() As Boolean
        Get
            Return _clienteexterno
        End Get
        Set(ByVal value As Boolean)
            _clienteexterno = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property EmpleadoExterno() As String
        Get
            Return _empleadoexterno
        End Get
        Set(ByVal value As String)
            _empleadoexterno = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoIncidencia() As String
        Get
            Return _estadoincidencia
        End Get
        Set(ByVal value As String)
            _estadoincidencia = value
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
#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdGradoIncidencia As String _
              , ByVal ls_IdOperacion As String _
              , ByVal ls_IdViaje As String _
              , ByVal ls_IdPrioridad As String _
              , ByVal ls_IdResponsable As String _
              , ByVal ld_FechaHora As DateTime _
              , ByVal ls_Asunto As String _
              , ByVal ls_Mensaje As String _
              , ByVal lb_ClienteExterno As Boolean _
              , ByVal ls_EmpleadoExterno As String _
              , ByVal ls_EstadoIncidencia As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _idgradoincidencia = ls_IdGradoIncidencia
        _idoperacion = ls_IdOperacion
        _idviaje = ls_IdViaje
        _idprioridad = ls_IdPrioridad
        _idresponsable = ls_IdResponsable
        _fechahora = ld_FechaHora
        _asunto = ls_Asunto
        _mensaje = ls_Mensaje
        _clienteexterno = lb_ClienteExterno
        _empleadoexterno = ls_EmpleadoExterno
        _estadoincidencia = ls_EstadoIncidencia
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
    End Sub

#End Region

End Class

