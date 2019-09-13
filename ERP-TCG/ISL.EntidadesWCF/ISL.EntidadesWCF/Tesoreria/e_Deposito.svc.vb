


<DataContract()> _
Public Class e_Deposito
    Implements Ie_Deposito

#Region "Propiedad"

    Private _id As String
    Private _numero As String
    Private _fecha As Date
    Private _glosa As String
    Private _idcuentabancaria As String
    Private _cuentabancaria As String
    Private _idmoneda As String
    Private _moneda As String
    Private _idBanco As String
    Private _Banco As String
    Private _total As Double
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _viaje As String

    <DataMember()> _
    Public loDepositoDetalle As New List(Of e_DepositoDetalle)

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()>
    Public FechaHasta As String
    <DataMember()>
    Public PrefijoID As String = ""

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
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Viaje() As String
        Get
            Return _viaje
        End Get
        Set(ByVal value As String)
            _viaje = value
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
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
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
            Return _cuentabancaria
        End Get
        Set(ByVal value As String)
            _cuentabancaria = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
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
    Public Property Moneda() As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property Banco() As String
        Get
            Return _Banco
        End Get
        Set(ByVal value As String)
            _Banco = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdBanco() As String
        Get
            Return _idBanco
        End Get
        Set(ByVal value As String)
            _idBanco = value
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

#End Region

#Region "Constructor"
    Public Sub New()
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Numero As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Glosa As String _
              , ByVal ls_IdBanco As String _
              , ByVal ls_Banco As String _
              , ByVal ls_IdCuentaBancaria As String _
              , ByVal ls_NumeroCuentaBancaria As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ln_Total As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_Viaje As String)

        _id = ls_Id
        _numero = ls_Numero
        _fecha = ld_Fecha
        _glosa = ls_Glosa
        _idBanco = ls_IdBanco
        _Banco = ls_Banco
        _idcuentabancaria = ls_IdCuentaBancaria
        _cuentabancaria = ls_NumeroCuentaBancaria
        _idmoneda = ls_IdBanco
        _moneda = ls_Moneda
        _total = ln_Total
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _viaje = ls_Viaje
    End Sub

#End Region

    Public Function Obtener(ByVal deposito As e_Deposito) As e_Deposito Implements Ie_Deposito.Obtener
        Return deposito
    End Function

End Class

