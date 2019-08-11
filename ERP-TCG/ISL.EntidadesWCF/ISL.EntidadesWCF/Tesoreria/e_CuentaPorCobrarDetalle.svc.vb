


<DataContract()> _
Public Class e_CuentaPorCobrarDetalle
    Implements Ie_CuentaPorCobrarDetalle

#Region "Propiedades"

    Private _id As String
    Private _idcuentaporcobrar As String
    Private _concepto As String
    Private _monto As Double
    Private _saldo As Double
    Private _fecha As Date
    Private _idtipopago As String
    Private _tipopago As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property IdCuentaPorCobrar() As String
        Get
            Return _idcuentaporcobrar
        End Get
        Set(ByVal value As String)
            _idcuentaporcobrar = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Concepto() As String
        Get
            Return _concepto
        End Get
        Set(ByVal value As String)
            _concepto = value
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
    Public Property IdTipoPago() As String
        Get
            Return _idtipopago
        End Get
        Set(ByVal value As String)
            _idtipopago = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPago() As String
        Get
            Return _tipopago
        End Get
        Set(ByVal value As String)
            _tipopago = value
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

#Region "Constructores"

    Public Sub New()
        Activo = True
        Fecha = Date.Now.Date
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCuentaPorCobrar As String _
              , ByVal ls_Concepto As String _
              , ByVal ln_Monto As Double _
              , ByVal ln_Saldo As Double _
              , ByVal ln_Fecha As Date _
              , ByVal ls_IdTipoPago As String _
              , ByVal ls_TipoPago As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idcuentaporcobrar = ls_IdCuentaPorCobrar
        _concepto = ls_Concepto
        _monto = ln_Monto
        _saldo = ln_Saldo
        _fecha = ln_Fecha
        _idtipopago = ls_IdTipoPago
        _tipopago = ls_TipoPago
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal cuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As e_CuentaPorCobrarDetalle Implements Ie_CuentaPorCobrarDetalle.Obtener
        Return cuentaPorCobrarDetalle
    End Function

End Class
