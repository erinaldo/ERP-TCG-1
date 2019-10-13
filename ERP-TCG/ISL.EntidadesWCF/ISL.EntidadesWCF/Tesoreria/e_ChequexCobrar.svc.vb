


<DataContract()> _
Public Class e_ChequexCobrar
    Implements Ie_ChequexCobrar

#Region "Declaracion de Variables"

    Private _id As String
    Private _idbanco As String
    Private _banco As String
    Private _nrocheque As String
    Private _fecha As Date
    Private _idmoneda As String
    Private _moneda As String
    Private _monto As Double
    Private _saldo As Double
    Private _cobrado As Boolean
    Private _fechacobro As Date
    Private _idtrabajadorcobro As String
    Private _trabajadorcobro As String
    Private _cuentacorriente As String
    Private _cuentabancaria As String
    Private _Trabajador As String
    Private _Asociado As Integer
    Private _TipoTransa As Integer
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
    Public Event DatoCambiado()

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
    Public Property IdCuentaBancaria() As String
        Get
            Return _cuentabancaria
        End Get
        Set(ByVal value As String)
            _cuentabancaria = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdBanco() As String
        Get
            Return _idbanco
        End Get
        Set(ByVal value As String)
            _idbanco = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Banco() As String
        Get
            Return _banco
        End Get
        Set(ByVal value As String)
            _banco = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroCheque() As String
        Get
            Return _nrocheque
        End Get
        Set(ByVal value As String)
            _nrocheque = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property Cobrado() As Boolean
        Get
            Return _cobrado
        End Get
        Set(ByVal value As Boolean)
            _cobrado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCobro() As Date
        Get
            Return _fechacobro
        End Get
        Set(ByVal value As Date)
            _fechacobro = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajadorCobro() As String
        Get
            Return _idtrabajadorcobro
        End Get
        Set(ByVal value As String)
            _idtrabajadorcobro = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TrabajadorCobro() As String
        Get
            Return _trabajadorcobro
        End Get
        Set(ByVal value As String)
            _trabajadorcobro = value
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

    <DataMember()> _
    Public Property IdCuentaCorriente() As String
        Get
            Return _cuentacorriente
        End Get
        Set(ByVal value As String)
            _cuentacorriente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _Trabajador
        End Get
        Set(ByVal value As String)
            _Trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Asociado() As Integer
        Get
            Return _Asociado
        End Get
        Set(ByVal value As Integer)
            _Asociado = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoTransa() As Integer
        Get
            Return _TipoTransa
        End Get
        Set(ByVal value As Integer)
            _TipoTransa = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _nrocheque = ""
        _fecha = #1/1/1901#
        _monto = 0
        _saldo = 0
        _cobrado = False
        _fechacobro = #1/1/1901#
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _cuentacorriente = ""
        _Trabajador = ""
        Activo = True
        Asociado = 0
        TipoTransa = 0
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdBanco As String _
              , ByVal ls_Banco As String _
              , ByVal ls_NroCheque As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ln_Monto As Double _
              , ByVal ln_saldo As Double _
              , ByVal lb_Cobrado As Boolean _
              , ByVal ld_FechaCobro As Date _
              , ByVal ls_IdTrabajadorCobro As String _
              , ByVal ls_TrabajadorCobro As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ls_Trabajador As String _
              , ByVal lb_Asociado As Integer _
              , ByVal ld_TipoTransa As Integer _
           )
        _id = ls_Id
        _idbanco = ls_IdBanco
        _banco = ls_Banco
        _nrocheque = ls_NroCheque
        _fecha = ld_Fecha
        _idmoneda = ls_IdMoneda
        _moneda = ls_Moneda
        _monto = ln_Monto
        _saldo = ln_saldo
        _cobrado = lb_Cobrado
        _fechacobro = ld_FechaCobro
        _idtrabajadorcobro = ls_IdTrabajadorCobro
        _trabajadorcobro = ls_TrabajadorCobro
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _cuentacorriente = ls_IdCuentaCorriente
        _Trabajador = ls_Trabajador
        _Asociado = lb_Asociado
        _TipoTransa = ld_TipoTransa

    End Sub

#End Region

    Public Function Obtener(ByVal chequexCobrar As e_ChequexCobrar) As e_ChequexCobrar Implements Ie_ChequexCobrar.Obtener
        Return chequexCobrar
    End Function

End Class

