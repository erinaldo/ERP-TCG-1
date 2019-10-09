


<DataContract()> _
Public Class e_CuentaBancaria
    Implements Ie_CuentaBancaria
    Implements IEquatable(Of e_CuentaBancaria)

#Region "Declaracion de Variables"
    Private _Seleccion As Boolean
    Private _Id As String
    Private _IdBanco As String
    Private _NombreBanco As String
    Private _NumeroCuenta As String
    Private _NombreMoneda As String
    Private _IdMoneda As String
    Private _IdCuentaContable As String
    Private _SaldoInicial As Decimal
    Private _Contacto As String
    Private _ContactoTelefono As String
    Private _TasaActiva As Decimal
    Private _TasaPasiva As Decimal
    Private _LineaCredito As Decimal
    Private _NumeroCorrelativo As Integer
    Private _bancocuenta As String
    Private _Activo As Boolean
    Private _Modificado As Boolean = False
    Private _Usuario As String

    <DataMember()> _
    Public TipoOperacion As String = ""
    <DataMember()> _
    Public Ejercicio As Integer
    <DataMember()> _
    Public TipoBusca As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

#End Region

#Region "Constructor"

    Sub New()
        _Id = String.Empty
        _IdBanco = String.Empty
        _NumeroCuenta = String.Empty
        _Activo = True
        TipoOperacion = ""
    End Sub

    Sub New(ByVal lb_Seleccion As Boolean, ByVal Id As String, ByVal IdBanco As String, ByVal NombreBanco As String, _
    ByVal NumeroCuenta As String, ByVal NombreMoneda As String, ByVal IdMoneda As String, ByVal IdCuentaContable As String, _
            ByVal SaldoInicial As Decimal, ByVal Contacto As String, ByVal ContactoTelefono As String, _
            ByVal TasaActiva As Decimal, ByVal TasaPasiva As Decimal, ByVal LineaCredito As Decimal, _
            ByVal NumeroCorrelativo As Integer, ByVal Activo As Boolean)

        _Id = Id
        _IdBanco = IdBanco
        _NombreBanco = NombreBanco
        _NumeroCuenta = NumeroCuenta
        _IdMoneda = IdMoneda
        _NombreMoneda = NombreMoneda
        _IdCuentaContable = IdCuentaContable
        _SaldoInicial = SaldoInicial
        _Contacto = Contacto
        _ContactoTelefono = ContactoTelefono
        _TasaActiva = TasaActiva
        _TasaPasiva = TasaPasiva
        _LineaCredito = LineaCredito
        _NumeroCorrelativo = NumeroCorrelativo
        _bancocuenta = NombreBanco & "  /  " & NumeroCuenta & " / " & NombreMoneda
        _Activo = Activo
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

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
    Public Property IdBanco() As String
        Get
            Return _IdBanco
        End Get
        Set(ByVal value As String)
            _IdBanco = value
        End Set
    End Property
    <DataMember()> _
    Public Property NumeroCuenta() As String
        Get
            Return _NumeroCuenta
        End Get
        Set(ByVal value As String)
            _NumeroCuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _IdMoneda
        End Get
        Set(ByVal value As String)
            _IdMoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable() As String
        Get
            Return _IdCuentaContable
        End Get
        Set(ByVal value As String)
            _IdCuentaContable = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoInicial() As String
        Get
            Return _SaldoInicial
        End Get
        Set(ByVal value As String)
            _SaldoInicial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Contacto() As String
        Get
            Return _Contacto
        End Get
        Set(ByVal value As String)
            _Contacto = value
        End Set
    End Property

    <DataMember()> _
    Public Property ContactoTelefono() As String
        Get
            Return _ContactoTelefono
        End Get
        Set(ByVal value As String)
            _ContactoTelefono = value
        End Set
    End Property

    <DataMember()> _
    Public Property TasaActiva() As Decimal
        Get
            Return _TasaActiva
        End Get
        Set(ByVal value As Decimal)
            _TasaActiva = value
        End Set
    End Property

    <DataMember()> _
    Public Property TasaPasiva() As Decimal
        Get
            Return _TasaPasiva
        End Get
        Set(ByVal value As Decimal)
            _TasaPasiva = value
        End Set
    End Property

    <DataMember()> _
    Public Property LineaCredito() As Decimal
        Get
            Return _LineaCredito
        End Get
        Set(ByVal value As Decimal)
            _LineaCredito = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroCorrelativo() As Integer
        Get
            Return _NumeroCorrelativo
        End Get
        Set(ByVal value As Integer)
            _NumeroCorrelativo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreBanco() As String
        Get
            Return _NombreBanco
        End Get
        Set(ByVal value As String)
            _NombreBanco = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreMoneda() As String
        Get
            Return _NombreMoneda
        End Get
        Set(ByVal value As String)
            _NombreMoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property BancoCuenta() As String
        Get
            Return _bancocuenta
        End Get
        Set(ByVal value As String)
            _bancocuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Modificado() As Boolean
        Get
            Return _Modificado
        End Get
        Set(ByVal value As Boolean)
            _Modificado = value
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal cuentaBancaria As e_CuentaBancaria) As e_CuentaBancaria Implements Ie_CuentaBancaria.Obtener
        Return cuentaBancaria
    End Function

    Public Function Equals1(other As e_CuentaBancaria) As Boolean Implements IEquatable(Of e_CuentaBancaria).Equals
        Select Case other.TipoBusca
            Case 1 : If Me.Id = other.Id Then Return True
        End Select
        Return False
    End Function
End Class
