' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ClientePrima" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ClientePrima.svc o e_ClientePrima.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ClientePrima
    Implements Ie_ClientePrima
    Implements IEquatable(Of e_ClientePrima)

#Region "Propiedad"

    Private _id As String
    Private _cliente As New e_Cliente
    Private _moneda As New e_Moneda
    Private _montoasegurado As Double
    Private _observacion As String
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _vigente As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As String
    Private _activo As Boolean

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
    Public Property IdCliente() As String
        Get
            Return _cliente.Id
        End Get
        Set(ByVal value As String)
            _cliente.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _cliente.Nombre
        End Get
        Set(ByVal value As String)
            _cliente.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _moneda.Id
        End Get
        Set(ByVal value As String)
            _moneda.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _moneda.Nombre
        End Get
        Set(ByVal value As String)
            _moneda.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoAsegurado() As Double
        Get
            Return _montoasegurado
        End Get
        Set(ByVal value As Double)
            _montoasegurado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _fechafin
        End Get
        Set(ByVal value As Date)
            _fechafin = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Vigente() As Boolean
        Get
            Return _vigente
        End Get
        Set(ByVal value As Boolean)
            _vigente = value
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
    Public Property FechaCreacion() As String
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As String)
            _fechacreacion = value
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
              , ByVal ls_IdCliente As String _
              , ByVal ls_Cliente As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ln_MontoAsegurado As Double _
              , ByVal ls_Observacion As String _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal lb_Vigente As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_FechaCreacion As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _cliente.Id = ls_IdCliente
        _cliente.Nombre = ls_Cliente
        _moneda.Id = ls_IdMoneda
        _moneda.Nombre = ls_Moneda
        _montoasegurado = ln_MontoAsegurado
        _observacion = ls_Observacion
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _vigente = lb_Vigente
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ls_FechaCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal clienteprima As e_ClientePrima) As e_ClientePrima Implements Ie_ClientePrima.Obtener
        Return clienteprima
    End Function

    Public Function Equals1(other As e_ClientePrima) As Boolean Implements IEquatable(Of e_ClientePrima).Equals
        If Me.IdCliente.Trim = other.IdCliente.Trim Then Return True
        Return False
    End Function

End Class
