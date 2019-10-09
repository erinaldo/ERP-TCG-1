' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Incidencia" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Incidencia.svc o e_Incidencia.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_Incidencia
    Implements Ie_Incidencia

    Public Sub DoWork() Implements Ie_Incidencia.DoWork
    End Sub

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Codigo2 As String _
              , ByVal ls_NroIncidencia As String _
              , ByVal ls_IdTipoIncidencia As String _
              , ByVal ls_IdGradoIncidencia As String _
              , ByVal ls_IdOperacion As String _
              , ByVal ls_IdViaje As String _
              , ByVal ls_IdPiloto As String _
              , ByVal ld_Fecha As Date _
              , ByVal Descripcion As String _
              , ByVal ls_IdUbicacion As String _
              , ByVal ln_IdPrioridad As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_EstadoIncidencia As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _codigo2 = ls_Codigo2
        _nroincidencia = ls_NroIncidencia
        _idtipoincidencia = ls_IdTipoIncidencia
        _idgradoincidencia = ls_IdGradoIncidencia
        _idoperacion = ls_IdOperacion
        _idviaje = ls_IdViaje
        _idpiloto = ls_IdPiloto
        _fecha = ld_Fecha
        _descripcion = Descripcion
        _idubicacion = ls_IdUbicacion
        _idprioridad = ln_IdPrioridad
        _idcliente = ls_IdCliente
        _estadoincidencia = ls_EstadoIncidencia
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
    End Sub

#End Region

#Region "Declaración de variables"
    Private _id As String
    Private _codigo As String
    Private _codigo2 As String
    Private _nroincidencia As String
    Private _idtipoincidencia As String
    Private _idgradoincidencia As String
    Private _idoperacion As String
    Private _idviaje As String
    Private _idpiloto As String
    Private _fecha As Date
    Private _descripcion As String
    Private _idubicacion As String
    Private _idprioridad As String
    Private _idcliente As String
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
    Public Property Codigo2() As String
        Get
            Return _codigo2
        End Get
        Set(ByVal value As String)
            _codigo2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroIncidencia() As String
        Get
            Return _nroincidencia
        End Get
        Set(ByVal value As String)
            _nroincidencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoIncidencia() As String
        Get
            Return _idtipoincidencia
        End Get
        Set(ByVal value As String)
            _idtipoincidencia = value
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
    Public Property IdPiloto() As String
        Get
            Return _idpiloto
        End Get
        Set(ByVal value As String)
            _idpiloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUbicacion() As String
        Get
            Return _idubicacion
        End Get
        Set(ByVal value As String)
            _idubicacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPrioridad() As Integer
        Get
            Return _idprioridad
        End Get
        Set(ByVal value As Integer)
            _idprioridad = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
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

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Incidencia
    ''' </summary>
    ''' <param name="incidencia"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal incidencia As e_Incidencia) As e_Incidencia Implements Ie_Incidencia.Obtener
        Return incidencia
    End Function

#End Region
End Class
