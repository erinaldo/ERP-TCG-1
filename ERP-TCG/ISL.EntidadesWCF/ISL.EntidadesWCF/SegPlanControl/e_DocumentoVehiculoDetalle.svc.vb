' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_DocumentoVehiculoDetalle" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_DocumentoVehiculoDetalle.svc o e_DocumentoVehiculoDetalle.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_DocumentoVehiculoDetalle
    Implements Ie_DocumentoVehiculoDetalle

#Region "Propiedad"
    Private _id As String
    Private _codigo As String
    Private _idtipodocumento As String
    Private _tipodocumento As String
    Private _iddocumento As String
    Private _indtodoscliente As Boolean
    Private _indtodosmaterial As Boolean
    Private _idcliente As String
    Private _cliente As String
    Private _idmaterial As String
    Private _material As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    Public TipoOperacion As String
    Public Modificado As Boolean
    Event DatoCambiado()
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodocumento
        End Get
        Set(ByVal value As String)
            _idtipodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocumento() As String
        Get
            Return _tipodocumento
        End Get
        Set(ByVal value As String)
            _tipodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDocumento() As String
        Get
            Return _iddocumento
        End Get
        Set(ByVal value As String)
            _iddocumento = value
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
    Public Property Material() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndTodosCliente() As Boolean
        Get
            Return _indtodoscliente
        End Get
        Set(ByVal value As Boolean)
            _indtodoscliente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndTodosMaterial() As Boolean
        Get
            Return _indtodosmaterial
        End Get
        Set(ByVal value As Boolean)
            _indtodosmaterial = value
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
        TipoOperacion = "I"
        Id = ""
        Codigo = ""
        IdTipoDocumento = ""
        IdDocumento = ""
        IdCliente = ""
        IdMaterial = ""
        IndTodosCliente = False
        IndTodosMaterial = False
        Activo = True
        FechaCreacion = Date.Now
        FechaModifica = Date.Now
        UsuarioModifica = ""
        UsuarioCreacion = ""
        FechaDesde = ""
        FechaHasta = ""
    End Sub
#End Region

    Public Sub DoWork() Implements Ie_DocumentoVehiculoDetalle.DoWork
    End Sub

End Class
