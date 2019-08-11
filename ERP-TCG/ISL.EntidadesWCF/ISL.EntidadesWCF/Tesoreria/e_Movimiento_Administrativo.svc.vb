


<DataContract()> _
Public Class e_Movimiento_Administrativo
    Implements Ie_Movimiento_Administrativo

#Region "Declaracion de Variables"

    Private _Id As String
    Private _Fecha As Date
    Private _CuentaCorrienteO As String
    Private _codCuentaCorrienteO As String
    Private _idtrabajadorCCO As String
    Private _idCuentaCorrienteD As String
    Private _CuentaCorrienteD As String
    Private _Trabajador As String
    Private _Ingreso As Decimal
    Private _Egreso As Decimal
    Private _Saldo As Decimal
    Private _Glosa As String
    Private _Voucher As String
    Private _FechaCreacion As Date
    Private _UsuarioCreacion As String
    Private _Descuento As String
    Private _TipoMovimiento As String
    Private _IdEstado As String
    Private _Activo As Boolean
    Private _TipoTransa As String
    Private _IngresoTotal As Decimal
    Private _EgresoTotal As Decimal
    Private _SaldoTotal As Decimal
    Private _GastosRendidos As Decimal
    Private _indcerrado As Boolean
    'Private _IndCerrado As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()> _
    Public IdCaja As String = ""

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property GastosRendidos() As Decimal
        Get
            Return _GastosRendidos
        End Get
        Set(ByVal value As Decimal)
            _GastosRendidos = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCerrado() As Boolean
        Get
            Return _indcerrado
        End Get
        Set(ByVal value As Boolean)
            _indcerrado = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoTotal() As Decimal
        Get
            Return _SaldoTotal
        End Get
        Set(ByVal value As Decimal)
            _SaldoTotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property EgresoTotal() As Decimal
        Get
            Return _EgresoTotal
        End Get
        Set(ByVal value As Decimal)
            _EgresoTotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoTotal() As Decimal
        Get
            Return _IngresoTotal
        End Get
        Set(ByVal value As Decimal)
            _IngresoTotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoTransa() As String
        Get
            Return _TipoTransa
        End Get
        Set(ByVal value As String)
            _TipoTransa = value
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
    Public Property IdEstado() As String
        Get
            Return _IdEstado
        End Get
        Set(ByVal value As String)
            _IdEstado = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMovimiento() As String
        Get
            Return _TipoMovimiento
        End Get
        Set(ByVal value As String)
            _TipoMovimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descuento() As String
        Get
            Return _Descuento
        End Get
        Set(ByVal value As String)
            _Descuento = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Voucher() As String
        Get
            Return _Voucher
        End Get
        Set(ByVal value As String)
            _Voucher = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Decimal
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Decimal)
            _Saldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Egreso() As Decimal
        Get
            Return _Egreso
        End Get
        Set(ByVal value As Decimal)
            _Egreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ingreso() As Decimal
        Get
            Return _Ingreso
        End Get
        Set(ByVal value As Decimal)
            _Ingreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaDestino() As String
        Get
            Return _CuentaCorrienteD
        End Get
        Set(ByVal value As String)
            _CuentaCorrienteD = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaCorrienteD() As String
        Get
            Return _idCuentaCorrienteD
        End Get
        Set(ByVal value As String)
            _idCuentaCorrienteD = value
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaOrigen() As String
        Get
            Return _CuentaCorrienteO
        End Get
        Set(ByVal value As String)
            _CuentaCorrienteO = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaCorrienteO() As String
        Get
            Return _CuentaCorrienteO
        End Get
        Set(ByVal value As String)
            _CuentaCorrienteO = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajadorCuentaCorriente() As String
        Get
            Return _idtrabajadorCCO
        End Get
        Set(ByVal value As String)
            _idtrabajadorCCO = value
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
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
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

#End Region

#Region "Contructor"

    Sub New()
        _Activo = 1
    End Sub

    Sub New(ByVal ls_Id As String, _
            ByVal ld_Fecha As Date, _
            ByVal ls_IdCuentaOrigen As String, _
            ByVal ls_CuentaOrigen As String, _
            ByVal ls_IdCuentaDestino As String, _
            ByVal ls_CuentaDestino As String, _
            ByVal ls_IdTrabajador As String, _
            ByVal ls_Trabajador As String, _
            ByVal ld_Ingreso As Decimal, _
            ByVal ld_Egreso As Decimal, _
            ByVal ld_Saldo As Decimal, _
            ByVal ls_Glosa As String, _
            ByVal ls_Voucher As String, _
            ByVal ld_FechaCreacion As Date, _
            ByVal ls_UsuarioCreacion As String, _
            ByVal ls_Descuento As String, _
            ByVal ls_TipoMovimiento As String, _
            ByVal ls_IdEstado As String, _
            ByVal lb_Activo As Boolean, _
            ByVal ls_TipoTransa As String, _
            ByVal ld_IngresoTotal As Decimal, _
            ByVal ld_EgresoTotal As Decimal, _
            ByVal ld_SaldoTotal As Decimal, _
            ByVal ld_GastosRendidos As Decimal, _
            ByVal lb_IndCerrado As Boolean)
        'ByVal li_IndCerrado As Integer)
        _Id = ls_Id
        _Fecha = ld_Fecha
        _CuentaCorrienteO = ls_IdCuentaOrigen
        _codCuentaCorrienteO = ls_CuentaOrigen
        _idtrabajadorCCO = ls_IdTrabajador
        _idCuentaCorrienteD = ls_IdCuentaDestino
        _CuentaCorrienteD = ls_CuentaDestino
        _Trabajador = ls_Trabajador
        _Ingreso = ld_Ingreso
        _Egreso = ld_Egreso
        _Saldo = ld_Saldo
        _Glosa = ls_Glosa
        _Voucher = ls_Voucher
        _FechaCreacion = ld_FechaCreacion
        _UsuarioCreacion = ls_UsuarioCreacion
        _Descuento = ls_Descuento
        _TipoMovimiento = ls_TipoMovimiento
        _IdEstado = ls_IdEstado
        _Activo = lb_Activo
        _TipoTransa = ls_TipoTransa
        _IngresoTotal = ld_IngresoTotal
        _EgresoTotal = ld_EgresoTotal
        _SaldoTotal = ld_SaldoTotal
        _GastosRendidos = ld_GastosRendidos
        _indcerrado = lb_IndCerrado
    End Sub

#End Region

    Public Function Obtener(ByVal movimiento_Administrativo As e_Movimiento_Administrativo) As e_Movimiento_Administrativo Implements Ie_Movimiento_Administrativo.Obtener
        Return movimiento_Administrativo
    End Function

End Class

