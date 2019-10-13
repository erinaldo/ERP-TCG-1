' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_MontoRuta" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_MontoRuta.svc o e_MontoRuta.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_MontoRuta
    Implements Ie_MontoRuta
    Implements IEquatable(Of e_MontoRuta)

#Region "Propiedad"

    Private _id As String
    Private _ruta As New e_Ruta
    Private _tipovehiculo As New e_TipoVehiculo
    Private _cuenta As Integer
    Private _indcargado As Boolean
    Private _montosolo As Double
    Private _montoacompañado As Double
    Private _porcentajecopiloto As Double
    Private _porcentajeayudante As Double
    Private _kilometraje As Double
    Private _vigencia As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _bonosolo As Double
    Private _bonocruceropiloto As Double
    Private _bonocrucerocopiloto As Double
    Private _indnacional As Boolean
    Private _indcategoria As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public FechaDesde As Date
    <DataMember()> _
    Public FechaHasta As Date
    <DataMember()> _
    Public Tipo As Integer
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
    Public Property IdRuta() As String
        Get
            Return _ruta.Id
        End Get
        Set(ByVal value As String)
            _ruta.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Origen() As String
        Get
            Return _ruta.Origen
        End Get
        Set(ByVal value As String)
            _ruta.Origen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Destino() As String
        Get
            Return _ruta.Destino
        End Get
        Set(ByVal value As String)
            _ruta.Destino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCategoria() As Boolean
        Get
            Return _indcategoria
        End Get
        Set(ByVal value As Boolean)
            _indcategoria = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _tipovehiculo.Nombre
        End Get
        Set(ByVal value As String)
            _tipovehiculo.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndNacional() As Boolean
        Get
            Return _indnacional
        End Get
        Set(ByVal value As Boolean)
            _indnacional = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cuenta() As Integer
        Get
            Return _cuenta
        End Get
        Set(ByVal value As Integer)
            _cuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoVehiculo() As String
        Get
            Return _tipovehiculo.Id
        End Get
        Set(ByVal value As String)
            _tipovehiculo.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndCargado() As Boolean
        Get
            Return _indcargado
        End Get
        Set(ByVal value As Boolean)
            _indcargado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoSolo() As Double
        Get
            Return _montosolo
        End Get
        Set(ByVal value As Double)
            _montosolo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoAcompañado() As Double
        Get
            Return _montoacompañado
        End Get
        Set(ByVal value As Double)
            _montoacompañado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeCopiloto() As Double
        Get
            Return _porcentajecopiloto
        End Get
        Set(ByVal value As Double)
            _porcentajecopiloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeAyudante() As Double
        Get
            Return _porcentajeayudante
        End Get
        Set(ByVal value As Double)
            _porcentajeayudante = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property BonoCruceroCopiloto() As Double
        Get
            Return _bonocrucerocopiloto
        End Get
        Set(ByVal value As Double)
            _bonocrucerocopiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoCruceroPiloto() As Double
        Get
            Return _bonocruceropiloto
        End Get
        Set(ByVal value As Double)
            _bonocruceropiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoSolo() As Double
        Get
            Return _bonosolo
        End Get
        Set(ByVal value As Double)
            _bonosolo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Kilometraje() As Double
        Get
            Return _kilometraje
        End Get
        Set(ByVal value As Double)
            _kilometraje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Vigencia() As Boolean
        Get
            Return _vigencia
        End Get
        Set(ByVal value As Boolean)
            _vigencia = value
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
        TipoOperacion = String.Empty
        Activo = True
        IndCargado = True
        Vigencia = True
        FechaCreacion = Date.Parse("01/01/1901")
        MontoAcompañado = 0
        MontoSolo = 0
        PorcentajeAyudante = 0
        PorcentajeCopiloto = 0
        Kilometraje = 0
        FechaDesde = Date.Parse("01/01/1901")
        FechaHasta = Date.Parse("01/01/1901")
        Cuenta = 0
        IndNacional = True
        IndCategoria = True
        IdRuta = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdRuta As String _
              , ByVal ls_IdTipoVehiculo As String _
              , ByVal li_Cuenta As String _
              , ByVal lb_IndCargado As Boolean _
              , ByVal lb_IndNacional As Boolean _
              , ByVal lb_IndCategoria As Boolean _
              , ByVal ln_MontoSolo As Double _
              , ByVal ln_MontoAcompañado As Double _
              , ByVal ln_PorcentajeCopiloto As Double _
              , ByVal ln_PorcentajeAyudante As Double _
              , ByVal ld_BonoSolo As Double _
              , ByVal ld_BonoCruceroPiloto As Double _
              , ByVal ld_BonoCruceroCopiloto As Double _
              , ByVal ln_Kilometraje As Double _
              , ByVal lb_Vigencia As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_TipoVehiculo As String _
              , ByVal ls_Origen As String _
              , ByVal ls_Destino As String)
        _id = ls_Id
        _ruta.Id = ls_IdRuta
        _tipovehiculo.Id = ls_IdTipoVehiculo
        _indcargado = lb_IndCargado
        _indnacional = lb_IndNacional
        _indcategoria = lb_IndCategoria
        _cuenta = li_Cuenta
        _montosolo = ln_MontoSolo
        _montoacompañado = ln_MontoAcompañado
        _porcentajecopiloto = ln_PorcentajeCopiloto
        _porcentajeayudante = ln_PorcentajeAyudante
        _bonosolo = ld_BonoSolo
        _bonocruceropiloto = ld_BonoCruceroPiloto
        _bonocrucerocopiloto = ld_BonoCruceroCopiloto
        _kilometraje = ln_Kilometraje
        _vigencia = lb_Vigencia
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _tipovehiculo.Nombre = ls_TipoVehiculo
        _ruta.Origen = ls_Origen
        _ruta.Destino = ls_Destino
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal montoruta As e_MontoRuta) As e_MontoRuta Implements Ie_MontoRuta.Obtener
        Return montoruta
    End Function

    Public Overloads Function Equals(ByVal MontoRuta As e_MontoRuta) As Boolean Implements IEquatable(Of e_MontoRuta).Equals
        If Me.IdRuta = MontoRuta.IdRuta And Me.IndCargado = MontoRuta.IndCargado And Me.IdTipoVehiculo = MontoRuta.IdTipoVehiculo Then Return True
        Return False
    End Function

#End Region

End Class
