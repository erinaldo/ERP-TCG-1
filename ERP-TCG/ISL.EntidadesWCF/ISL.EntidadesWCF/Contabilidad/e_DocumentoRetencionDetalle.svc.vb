<DataContract()> _
Public Class e_DocumentoRetencionDetalle
    Implements Ie_DocumentoRetencionDetalle

#Region "Declaracion de Variables"

    Private _id As String
    Private _iddocumentoretencion As String
    Private _fechapago As Date
    Private _nrovoucher As String
    Private _numeropago As Integer
    Private _idmovimientodocumento As String
    Private _idproveedor As String
    Private _tipocambio As Double
    Private _montopagoorigen As Double
    Private _montopagosoles As Double
    Private _retencionorigen As Double
    Private _retencionsoles As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

#End Region

#Region "Propiedades"

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
    Public Property IdDocumentoRetencion() As String
        Get
            Return _iddocumentoretencion
        End Get
        Set(ByVal value As String)
            _iddocumentoretencion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaPago() As Date
        Get
            Return _fechapago
        End Get
        Set(ByVal value As Date)
            _fechapago = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroVoucher() As String
        Get
            Return _nrovoucher
        End Get
        Set(ByVal value As String)
            _nrovoucher = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroPago() As Integer
        Get
            Return _numeropago
        End Get
        Set(ByVal value As Integer)
            _numeropago = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdProveedor() As String
        Get
            Return _idproveedor
        End Get
        Set(ByVal value As String)
            _idproveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoPagoOrigen() As Double
        Get
            Return _montopagoorigen
        End Get
        Set(ByVal value As Double)
            _montopagoorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoPagoSoles() As Double
        Get
            Return _montopagosoles
        End Get
        Set(ByVal value As Double)
            _montopagosoles = value
        End Set
    End Property

    <DataMember()> _
    Public Property RetencionOrigen() As Double
        Get
            Return _retencionorigen
        End Get
        Set(ByVal value As Double)
            _retencionorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property RetencionSoles() As Double
        Get
            Return _retencionsoles
        End Get
        Set(ByVal value As Double)
            _retencionsoles = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _iddocumentoretencion = ""
        _fechapago = #1/1/1901#
        _nrovoucher = ""
        _numeropago = 0
        _idmovimientodocumento = ""
        _idproveedor = ""
        _tipocambio = 0
        _montopagoorigen = 0
        _montopagosoles = 0
        _retencionorigen = 0
        _retencionsoles = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _fechamodifica = #1/1/1901#
        _usuariomodifica = ""
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdDocumentoRetencion As String _
              , ByVal ld_FechaPago As Date _
              , ByVal ls_NroVoucher As String _
              , ByVal ln_NumeroPago As Integer _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ls_IdProveedor As String _
              , ByVal ln_TipoCambio As Double _
              , ByVal ln_MontoPagoOrigen As Double _
              , ByVal ln_MontoPagoSoles As Double _
              , ByVal ln_RetencionOrigen As Double _
              , ByVal ln_RetencionSoles As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _iddocumentoretencion = ls_IdDocumentoRetencion
        _fechapago = ld_FechaPago
        _nrovoucher = ls_NroVoucher
        _numeropago = ln_NumeroPago
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _idproveedor = ls_IdProveedor
        _tipocambio = ln_TipoCambio
        _montopagoorigen = ln_MontoPagoOrigen
        _montopagosoles = ln_MontoPagoSoles
        _retencionorigen = ln_RetencionOrigen
        _retencionsoles = ln_RetencionSoles
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(documentoretenciondetalle As e_DocumentoRetencionDetalle) As e_DocumentoRetencionDetalle Implements Ie_DocumentoRetencionDetalle.Obtener
        Return documentoretenciondetalle
    End Function

#End Region

End Class
