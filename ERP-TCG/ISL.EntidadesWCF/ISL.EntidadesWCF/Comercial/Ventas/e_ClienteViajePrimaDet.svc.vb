' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ClienteViajePrimaDet" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ClienteViajePrimaDet.svc o e_ClienteViajePrimaDet.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ClienteViajePrimaDet
    Implements Ie_ClienteViajePrimaDet

#Region "Propiedad"

    Private _id As String
    Private _idclienteviajeprima As String
    Private _viaje As New e_Viaje
    Private _idoperaciondetalle As String
    Private _idcliente As String
    Private _cliente As String
    Private _idorigen As String
    Private _origen As String
    Private _iddestino As String
    Private _destino As String
    Private _idmaterial As String
    Private _material As String
    Private _indasegurado As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdClienteViajePrima() As String
        Get
            Return _idclienteviajeprima
        End Get
        Set(ByVal value As String)
            _idclienteviajeprima = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _viaje.Id
        End Get
        Set(ByVal value As String)
            _viaje.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Viaje() As String
        Get
            Return _viaje.Codigo
        End Get
        Set(ByVal value As String)
            _viaje.Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaViaje() As String
        Get
            Return _viaje.Fecha
        End Get
        Set(ByVal value As String)
            _viaje.Fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tracto() As String
        Get
            Return _viaje.Tracto
        End Get
        Set(ByVal value As String)
            _viaje.Tracto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperacionDetalle() As String
        Get
            Return _idoperaciondetalle
        End Get
        Set(ByVal value As String)
            _idoperaciondetalle = value
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
    Public Property Cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrigen() As String
        Get
            Return _idorigen
        End Get
        Set(ByVal value As String)
            _idorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDestino() As String
        Get
            Return _iddestino
        End Get
        Set(ByVal value As String)
            _iddestino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Destino() As String
        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Property CargaMaterial() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndAsegurado() As Integer
        Get
            Return _indasegurado
        End Get
        Set(ByVal value As Integer)
            _indasegurado = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdClienteViajePrima As String _
              , ByVal ls_IdViaje As String _
              , ByVal ls_Viaje As String _
              , ByVal ld_FechaViaje As Date _
              , ByVal ls_Tracto As String _
              , ByVal ls_IdOperacionDetalle As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_Cliente As String _
              , ByVal ls_IdOrigen As String _
              , ByVal ls_Origen As String _
              , ByVal ls_IdDestino As String _
              , ByVal ls_Destino As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_Material As String _
              , ByVal ln_IndAsegurado As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idclienteviajeprima = ls_IdClienteViajePrima
        _viaje.Id = ls_IdViaje
        _viaje.Codigo = ls_Viaje
        _viaje.Fecha = ld_FechaViaje
        _viaje.Tracto = ls_Tracto
        _idoperaciondetalle = ls_IdOperacionDetalle
        _idcliente = ls_IdCliente
        _cliente = ls_Cliente
        _idorigen = ls_IdOrigen
        _origen = ls_Origen
        _iddestino = ls_IdDestino
        _destino = ls_Destino
        _idmaterial = ls_IdMaterial
        _material = ls_Material
        _indasegurado = ln_IndAsegurado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal clienteviajeprimadet As e_ClienteViajePrimaDet) As e_ClienteViajePrimaDet Implements Ie_ClienteViajePrimaDet.Obtener
        Return clienteviajeprimadet
    End Function

#End Region

End Class
