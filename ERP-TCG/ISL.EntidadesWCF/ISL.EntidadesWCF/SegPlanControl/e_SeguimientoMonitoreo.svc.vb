' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_SeguimientoMonitoreo" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_SeguimientoMonitoreo.svc o e_SeguimientoMonitoreo.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_SeguimientoMonitoreo
    Implements Ie_SeguimientoMonitoreo

#Region "Propiedad"
    Private _seleccion As Boolean
    Private _id As String
    Private _codigo As String
    Private _idviaje As String
    Private _idoperador As String
    Private _operador As String
    Private _fecha As Date
    Private _fechaaproxllegada As Date
    Private _fechaentrega As Date
    Private _glosa As String
    Private _idubicacion As String
    Private _ubicacion As String
    Private _referencialugar As String
    Private _estado As String
    Private _nombreestado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _oeviaje As e_Viaje

    <DataMember()> _
    Public Identificador As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    '<DataMember()> _
    'Public oeViaje As New e_Viaje
    <DataMember()> _
    Public Property oeViaje() As e_Viaje
        Get
            Return _oeviaje
        End Get
        Set(ByVal value As e_Viaje)
            _oeviaje = value
        End Set
    End Property

    <DataMember()> _
    Public oeSeguimiento As New e_Seguimiento

    Public TipoOperacion As String
    Public Modificado As Boolean

    Event DatoCambiado()

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

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
    Public Property IdOperador() As String
        Get
            Return _idoperador
        End Get
        Set(ByVal value As String)
            _idoperador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Operador() As String
        Get
            Return _operador
        End Get
        Set(ByVal value As String)
            _operador = value
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
    Public Property FechaAproxLlegada() As Date
        Get
            Return _fechaaproxllegada
        End Get
        Set(ByVal value As Date)
            _fechaaproxllegada = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEntrega() As Date
        Get
            Return _fechaentrega
        End Get
        Set(ByVal value As Date)
            _fechaentrega = value
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
    Public Property Ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ReferenciaLugar() As String
        Get
            Return _referencialugar
        End Get
        Set(ByVal value As String)
            _referencialugar = value
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
    Public Property NombreEstado() As String
        Get
            Return _nombreestado
        End Get
        Set(ByVal value As String)
            _nombreestado = value
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
#End Region

    Public Sub DoWork() Implements Ie_SeguimientoMonitoreo.DoWork
    End Sub

End Class
