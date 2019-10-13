

<DataContract()> _
Public Class e_BolsaRuta
    Implements Ie_BolsaRuta

#Region "Declaración de variables"

    Private _Id As String
    Private _IdRuta As String
    Private _IdTipoVehiculo As String
    Private _TipoVehiculo As String
    Private _Ruta As String
    Private _MontoMinimo As Decimal
    Private _MontoNormal As Decimal
    Private _MontoMaximo As Decimal
    Private _Activo As Boolean
    Private _IdUsuario As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Sub New()
        _Id = String.Empty
        _Ruta = String.Empty
        _Activo = True
    End Sub

    Sub New(ByVal Id As String, ByVal IdRuta As String, ByVal IdTipoVehiculo As String, ByVal TipoVehiculo As String, ByVal Ruta As String, ByVal MontoMinimo As Decimal, _
            ByVal MontoNormal As Decimal, ByVal MontoMaximo As Decimal, ByVal Activo As Boolean, ByVal Usuario As String)
        _Id = Id
        _IdRuta = IdRuta
        _IdTipoVehiculo = IdTipoVehiculo
        _TipoVehiculo = TipoVehiculo
        _Ruta = Ruta
        _MontoMinimo = MontoMinimo
        _MontoNormal = MontoNormal
        _MontoMaximo = MontoMaximo
        _Activo = Activo
        _IdUsuario = Usuario
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRuta() As String
        Get
            Return _IdRuta
        End Get
        Set(ByVal value As String)
            _IdRuta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _Ruta
        End Get
        Set(ByVal value As String)
            _Ruta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoVehiculo() As String
        Get
            Return _IdTipoVehiculo
        End Get
        Set(ByVal value As String)
            _IdTipoVehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _TipoVehiculo
        End Get
        Set(ByVal value As String)
            _TipoVehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoMinimo() As Decimal
        Get
            Return _MontoMinimo
        End Get
        Set(ByVal value As Decimal)
            _MontoMinimo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoNormal() As Decimal
        Get
            Return _MontoNormal
        End Get
        Set(ByVal value As Decimal)
            _MontoNormal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoMaximo() As Decimal
        Get
            Return _MontoMaximo
        End Get
        Set(ByVal value As Decimal)
            _MontoMaximo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As String)
            _IdUsuario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal bolsaRuta As e_BolsaRuta) As e_BolsaRuta Implements Ie_BolsaRuta.Obtener
        Return bolsaRuta
    End Function

End Class

