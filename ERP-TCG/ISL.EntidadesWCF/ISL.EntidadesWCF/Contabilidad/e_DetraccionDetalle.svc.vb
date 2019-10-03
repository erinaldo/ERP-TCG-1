' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_DetraccionDetalle" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_DetraccionDetalle.svc o e_DetraccionDetalle.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_DetraccionDetalle
    Implements Ie_DetraccionDetalle

#Region "Declaración de variables"

    Private _Id As String
    Private _IdDetraccion As String
    Private _IdClienteProveedor As String
    Private _ClienteProveedor As String
    Private _RUC As String
    Private _NroProforma As String
    Private _TipoBien As New e_TipoBien
    Private _CtaCte_ProAdq As New e_CtaCte_ProAdq
    Private _TipoOperacion As New e_TipoOpeCon
    Private _Periodo As String
    Private _TipoDocumento As New e_TipoDocumento
    Private _MovimientoDocumento As New e_MovimientoDocumento
    Private _IdTipoGasto As String
    Private _Voucher As String
    Private _FechaPago As Date
    Private _IdMoneda As String
    Private _Importe As Double
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _Activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public CtaContable As String
    <DataMember()>
    Public PrefijoID As String = ""

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdDetraccion = ""
        _IdClienteProveedor = ""
        _NroProforma = "000000000"
        _TipoBien.Id = ""
        _TipoBien.Codigo = ""
        _CtaCte_ProAdq.Id = ""
        _TipoOperacion.Id = ""
        _TipoOperacion.Codigo = ""
        _Periodo = ""
        _IdMoneda = ""
        _IdTipoGasto = ""
        _Voucher = ""
        _FechaPago = #1/1/1901#
        _Importe = 0
        _UsuarioCreacion = ""
        _FechaCreacion = #1/1/1901#
        _Activo = True
        CtaContable = String.Empty
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdDetraccion As String _
              , ByVal ls_IdClienteProveedor As String _
              , ByVal ls_ClienteProveedor As String _
              , ByVal ls_RUC As String _
              , ByVal ls_NroProforma As String _
              , ByVal ls_IdTipoBien As String _
              , ByVal ls_CodigoBien As String _
              , ByVal ls_IdCtaCte_ProAdq As String _
              , ByVal ls_IdTipoOperacion As String _
              , ByVal ls_CodigoOpe As String _
              , ByVal ls_Periodo As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_Importe As Double _
              , ByVal ln_Total As Double _
              , ByVal ld_FechaPago As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_CtaContable As String)
        _Id = ls_Id
        _IdDetraccion = ls_IdDetraccion
        _IdClienteProveedor = ls_IdClienteProveedor
        _ClienteProveedor = ls_ClienteProveedor
        _RUC = ls_RUC
        _NroProforma = ls_NroProforma
        _TipoBien.Id = ls_IdTipoBien
        _TipoBien.Codigo = ls_CodigoBien
        _CtaCte_ProAdq.Id = ls_IdCtaCte_ProAdq
        _TipoOperacion.Id = ls_IdTipoOperacion
        _TipoOperacion.Codigo = ls_CodigoOpe
        _Periodo = ls_Periodo
        _TipoDocumento.Id = ls_IdTipoDocumento
        _MovimientoDocumento.Id = ls_IdMovimientoDocumento
        _MovimientoDocumento.Serie = ls_Serie
        _MovimientoDocumento.Numero = ls_Numero
        _MovimientoDocumento.Total = ln_Total
        _IdMoneda = ls_IdMoneda
        _Importe = ln_Importe
        _FechaPago = ld_FechaPago
        _UsuarioCreacion = ls_UsuarioCreacion
        _FechaCreacion = ld_FechaCreacion
        _Activo = lb_Activo
        CtaContable = ls_CtaContable
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
    Public Property IdDetraccion() As String
        Get
            Return _IdDetraccion
        End Get
        Set(ByVal value As String)
            _IdDetraccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdClienteProveedor() As String
        Get
            Return _IdClienteProveedor
        End Get
        Set(ByVal value As String)
            _IdClienteProveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property ClienteProveedor() As String
        Get
            Return _ClienteProveedor
        End Get
        Set(ByVal value As String)
            _ClienteProveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property RUC() As String
        Get
            Return _RUC
        End Get
        Set(ByVal value As String)
            _RUC = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroProforma() As String
        Get
            Return _NroProforma
        End Get
        Set(ByVal value As String)
            _NroProforma = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoBien() As String
        Get
            Return _TipoBien.Id
        End Get
        Set(ByVal value As String)
            _TipoBien.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoBien() As String
        Get
            Return _TipoBien.Codigo
        End Get
        Set(ByVal value As String)
            _TipoBien.Codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCtaCte_ProAdq() As String
        Get
            Return _CtaCte_ProAdq.Id
        End Get
        Set(ByVal value As String)
            _CtaCte_ProAdq.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoOperacion() As String
        Get
            Return _TipoOperacion.Id
        End Get
        Set(ByVal value As String)
            _TipoOperacion.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoOpe() As String
        Get
            Return _TipoOperacion.Codigo
        End Get
        Set(ByVal value As String)
            _TipoOperacion.Codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Periodo() As String
        Get
            Return _Periodo
        End Get
        Set(ByVal value As String)
            _Periodo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoDocumento() As String
        Get
            Return _TipoDocumento.Id
        End Get
        Set(ByVal value As String)
            _TipoDocumento.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _MovimientoDocumento.Id
        End Get
        Set(ByVal value As String)
            _MovimientoDocumento.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _MovimientoDocumento.Serie
        End Get
        Set(ByVal value As String)
            _MovimientoDocumento.Serie = value
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _MovimientoDocumento.Numero
        End Get
        Set(ByVal value As String)
            _MovimientoDocumento.Numero = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoGasto() As String
        Get
            Return _IdTipoGasto
        End Get
        Set(ByVal value As String)
            _IdTipoGasto = value
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
    Public Property FechaPago() As Date
        Get
            Return _FechaPago
        End Get
        Set(ByVal value As Date)
            _FechaPago = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalDocumento() As String
        Get
            Return _MovimientoDocumento.Total
        End Get
        Set(ByVal value As String)
            _MovimientoDocumento.Total = value
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
    Public Property Importe() As Double
        Get
            Return _Importe
        End Get
        Set(ByVal value As Double)
            _Importe = value
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
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal DetraccionDetalle As e_DetraccionDetalle) As e_DetraccionDetalle Implements Ie_DetraccionDetalle.Obtener
        Return DetraccionDetalle
    End Function

#End Region

End Class
