


<DataContract()> _
Public Class e_CajaMonto
    Implements Ie_CajaMonto

#Region "Propiedad"

    Private _id As String
    Private _idcaja As String
    Private _fecha As Date
    Private _monto As Double
    Private _idcuentabancaria As String
    Private _nrocuentabancaria As String
    Private _saldocuentabancaria As String
    Private _idmoneda As String
    Private _moneda As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public Tipooperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False

    Public Event DatoCambiado()

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
    Public Property IdCaja() As String
        Get
            Return _idcaja
        End Get
        Set(ByVal value As String)
            _idcaja = value
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
    Public Property IdCuentaBancaria() As String
        Get
            Return _idcuentabancaria
        End Get
        Set(ByVal value As String)
            _idcuentabancaria = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroCuenta() As String
        Get
            Return _nrocuentabancaria
        End Get
        Set(ByVal value As String)
            _nrocuentabancaria = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoCuentaBancaria() As String
        Get
            Return _saldocuentabancaria
        End Get
        Set(ByVal value As String)
            _saldocuentabancaria = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
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
        _id = String.Empty
        _idcaja = String.Empty
        _fecha = Date.Today
        _monto = Decimal.Zero
        _idcuentabancaria = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCaja As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_Monto As Double _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ls_IdCuentaBancaria As String _
              , ByVal ls_NumeroCuentaBancaria As String _
              , ByVal ls_SaldoCuentaBancaria As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idcaja = ls_IdCaja
        _fecha = ld_Fecha
        _monto = ln_Monto
        _idmoneda = ls_IdMoneda
        _moneda = ls_Moneda
        _idcuentabancaria = ls_IdCuentaBancaria
        _nrocuentabancaria = ls_NumeroCuentaBancaria
        _saldocuentabancaria = ls_SaldoCuentaBancaria
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal cajaMonto As e_CajaMonto) As e_CajaMonto Implements Ie_CajaMonto.Obtener
        Return cajaMonto
    End Function

End Class
