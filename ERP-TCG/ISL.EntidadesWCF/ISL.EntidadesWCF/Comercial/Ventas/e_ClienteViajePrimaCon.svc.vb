' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ClienteViajePrimaCon" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ClienteViajePrimaCon.svc o e_ClienteViajePrimaCon.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ClienteViajePrimaCon
    Implements Ie_ClienteViajePrimaCon

#Region "Propiedad"

    Private _id As String
    Private _idclienteviajeprima As String
    Private _idcliente As String
    Private _cliente As String
    Private _cuentaviaje As Integer
    Private _importeseguro As Double
    Private _factor1 As Double
    Private _primareal As Double
    Private _primaminima As Double
    Private _factor As Double
    Private _primatotal As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
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
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaViaje() As Integer
        Get
            Return _cuentaviaje
        End Get
        Set(ByVal value As Integer)
            _cuentaviaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ImporteSeguro() As Double
        Get
            Return _importeseguro
        End Get
        Set(ByVal value As Double)
            _importeseguro = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Factor1() As Double
        Get
            Return _factor1
        End Get
        Set(ByVal value As Double)
            _factor1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PrimaReal() As Double
        Get
            Return _primareal
        End Get
        Set(ByVal value As Double)
            _primareal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PrimaMinima() As Double
        Get
            Return _primaminima
        End Get
        Set(ByVal value As Double)
            _primaminima = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Factor() As Double
        Get
            Return _factor
        End Get
        Set(ByVal value As Double)
            _factor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PrimaTotal() As Double
        Get
            _primatotal = PrimaReal + PrimaMinima + Factor
            Return _primatotal
        End Get
        Set(ByVal value As Double)
            _primatotal = value
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
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdClienteViajePrima As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_Cliente As String _
              , ByVal ln_CuentaViaje As Integer _
              , ByVal ln_ImporteSeguro As Double _
              , ByVal ln_Factor1 As Double _
              , ByVal ln_PrimaReal As Double _
              , ByVal ln_PrimaMinima As Double _
              , ByVal ln_Factor As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idclienteviajeprima = ls_IdClienteViajePrima
        _idcliente = ls_IdCliente
        _cliente = ls_Cliente
        _cuentaviaje = ln_CuentaViaje
        _importeseguro = ln_ImporteSeguro
        _factor1 = ln_Factor1
        _primareal = ln_PrimaReal
        _primaminima = ln_PrimaMinima
        _factor = ln_Factor
        '_primatotal = Math.Round(ln_PrimaMinima * 1.2154 * ln_CuentaViaje, 4)
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal clienteviajeprimacon As e_ClienteViajePrimaCon) As e_ClienteViajePrimaCon Implements Ie_ClienteViajePrimaCon.Obtener
        Return clienteviajeprimacon
    End Function

#End Region

End Class
