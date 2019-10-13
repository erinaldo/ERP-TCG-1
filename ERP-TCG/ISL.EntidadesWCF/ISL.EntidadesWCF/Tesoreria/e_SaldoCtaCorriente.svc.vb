<DataContract()> _
Public Class e_SaldoCtaCorriente
    Implements Ie_SaldoCtaCorriente

#Region "Declaracion de Variables"

    Private _id As String
    Private _idcuentacorriente As String
    Private _tipocuenta As Integer
    Private _dni As String
    Private _trabajador As String
    Private _monto As Double
    Private _saldo As Double
    Private _cargo As Double
    Private _abono As Double
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _usuarioliquida As String
    Private _fechaliquida As Date
    Private _liquidado As Integer
    Private _movimiento As Integer
    Private _IdReferencia As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leMovCtaCte As List(Of e_MovCuentaCte)
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Event DatoCambiado()

#End Region

#Region "Propiedad"

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
    Public Property IdCuentaCorriente() As String
        Get
            Return _idcuentacorriente
        End Get
        Set(ByVal value As String)
            _idcuentacorriente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCuenta() As Integer
        Get
            Return _tipocuenta
        End Get
        Set(ByVal value As Integer)
            _tipocuenta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
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
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
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
    Public Property UsuarioLiquida() As String
        Get
            Return _usuarioliquida
        End Get
        Set(ByVal value As String)
            _usuarioliquida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaLiquida() As Date
        Get
            Return _fechaliquida
        End Get
        Set(ByVal value As Date)
            _fechaliquida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Liquidado() As Integer
        Get
            Return _liquidado
        End Get
        Set(ByVal value As Integer)
            _liquidado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cargo() As Double
        Get
            Return _cargo
        End Get
        Set(ByVal value As Double)
            _cargo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Abono() As Double
        Get
            Return _abono
        End Get
        Set(ByVal value As Double)
            _abono = value
        End Set
    End Property

    <DataMember()> _
    Public Property Movimiento() As Integer
        Get
            Return _movimiento
        End Get
        Set(ByVal value As Integer)
            _movimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdReferencia() As String
        Get
            Return _IdReferencia
        End Get
        Set(ByVal value As String)
            _IdReferencia = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _id = String.Empty
        _idcuentacorriente = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _tipocuenta = -1
        _monto = 0
        _saldo = 0
        _activo = 1
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuarioliquida = String.Empty
        _fechaliquida = #1/1/1901#
        _liquidado = -1
        _cargo = 0
        _abono = 0
        _movimiento = 0
        _IdReferencia = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ln_TipoCuenta As Integer _
              , ByVal ls_Dni As String _
              , ByVal ls_Trabajador As String _
              , ByVal ln_Monto As Double _
              , ByVal ln_Saldo As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioLiquida As String _
              , ByVal ld_FechaLiquida As Date _
              , ByVal lb_Liquidado As Boolean _
              , ByVal ln_Cargo As Double _
              , ByVal ln_Abono As Double _
              , ByVal li_Movimiento As Integer _
              , ByVal ls_IdReferencia As String)
        _id = ls_Id
        _idcuentacorriente = ls_IdCuentaCorriente
        _tipocuenta = ln_TipoCuenta
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _monto = ln_Monto
        _saldo = ln_Saldo
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _usuarioliquida = ls_UsuarioLiquida
        _fechaliquida = ld_FechaLiquida
        _liquidado = IIf(lb_Liquidado, 1, 0)
        _cargo = ln_Cargo
        _abono = ln_Abono
        _movimiento = li_Movimiento
        _IdReferencia = ls_IdReferencia
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal saldoctacorriente As e_SaldoCtaCorriente) As e_SaldoCtaCorriente Implements Ie_SaldoCtaCorriente.Obtener
        Return saldoctacorriente
    End Function

#End Region

End Class

