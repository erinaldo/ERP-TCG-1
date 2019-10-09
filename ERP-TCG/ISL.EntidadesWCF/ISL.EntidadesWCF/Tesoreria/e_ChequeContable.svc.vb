


<DataContract()> _
Public Class e_ChequeContable
    Implements Ie_ChequeContable

#Region "Declaracion de Variables"

    Private _Id As String
    Private _IdCuentaBancaria As String
    Private _IdBanco As String
    Private _NombreBanco As String
    Private _NumeroCuenta As String
    Private _NumeroChequera As String
    Private _Fecha As Date
    Private _NumeroInicial As Decimal
    Private _NumeroFinal As Decimal
    Private _NumeroEmitir As Decimal
    Private _Activo As Boolean
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal Id As String, ByVal IdCuentaBancaria As String, ByVal IdBanco As String, ByVal NombreBanco As String, _
            ByVal NumeroCuenta As String, ByVal NumeroChequera As String, ByVal Fecha As Date, _
            ByVal NumeroInicial As Decimal, ByVal NumeroFinal As Decimal, ByVal NumeroEmitir As Decimal, _
            ByVal Activo As Boolean)

        _Id = Id
        _IdCuentaBancaria = IdCuentaBancaria
        _IdBanco = IdBanco
        _NombreBanco = NombreBanco
        _NumeroCuenta = NumeroCuenta
        _NumeroChequera = NumeroChequera
        _Fecha = Fecha
        _NumeroInicial = NumeroInicial
        _NumeroFinal = NumeroFinal
        _NumeroEmitir = NumeroEmitir
        _Activo = Activo

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
    Public Property IdCuentaBancaria() As String
        Get
            Return _IdCuentaBancaria
        End Get
        Set(ByVal value As String)
            _IdCuentaBancaria = value
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
    Public Property NombreBanco() As String
        Get
            Return _NombreBanco
        End Get
        Set(ByVal value As String)
            _NombreBanco = value
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
    Public Property NumeroChequera() As String
        Get
            Return _NumeroChequera
        End Get
        Set(ByVal value As String)
            _NumeroChequera = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroEmitir() As Decimal
        Get
            Return _NumeroEmitir
        End Get
        Set(ByVal value As Decimal)
            _NumeroEmitir = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroFinal() As Decimal
        Get
            Return _NumeroFinal
        End Get
        Set(ByVal value As Decimal)
            _NumeroFinal = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroInicial() As Decimal
        Get
            Return _NumeroInicial
        End Get
        Set(ByVal value As Decimal)
            _NumeroInicial = value
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

#End Region

    Public Function Obtener(ByVal chequeContable As e_ChequeContable) As e_ChequeContable Implements Ie_ChequeContable.Obtener
        Return chequeContable
    End Function

End Class
