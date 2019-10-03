' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_EquivalenciaRuta" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_EquivalenciaRuta.svc o e_EquivalenciaRuta.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_EquivalenciaRuta
    Implements Ie_EquivalenciaRuta

#Region "Propiedad"

    Private _id As String
    Private _ruta As New e_Ruta
    Private _cuenta As Integer
    Private _monto As Double
    Private _equivalencia As Double
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrigen() As String
        Get
            Return _ruta.IdOrigen
        End Get
        Set(ByVal value As String)
            _ruta.IdOrigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Destino() As String
        Get
            Return _ruta.Destino
        End Get
        Set(ByVal value As String)
            _ruta.Destino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDestino() As String
        Get
            Return _ruta.IdDestino
        End Get
        Set(ByVal value As String)
            _ruta.IdDestino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cuenta() As Integer
        Get
            Return _cuenta
        End Get
        Set(ByVal value As Integer)
            _cuenta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Equivalencia() As Double
        Get
            Return _equivalencia
        End Get
        Set(ByVal value As Double)
            _equivalencia = value
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
        Activo = True
        TipoOperacion = ""
        Cuenta = 0
        FechaCreacion = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdRuta As String _
              , ByVal ls_IdOrigen As String _
              , ByVal ls_Origen As String _
              , ByVal ls_IdDestino As String _
              , ByVal ls_Destino As String _
              , ByVal ln_Cuenta As Integer _
              , ByVal ln_Monto As Double _
              , ByVal ln_Equivalencia As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _ruta.Id = ls_IdRuta
        _ruta.IdOrigen = ls_IdOrigen
        _ruta.Origen = ls_Origen
        _ruta.IdDestino = ls_IdDestino
        _ruta.Destino = ls_Destino
        _cuenta = ln_Cuenta
        _monto = ln_Monto
        _equivalencia = ln_Equivalencia
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal equivalenciaruta As e_EquivalenciaRuta) As e_EquivalenciaRuta Implements Ie_EquivalenciaRuta.Obtener
        Return equivalenciaruta
    End Function


End Class
