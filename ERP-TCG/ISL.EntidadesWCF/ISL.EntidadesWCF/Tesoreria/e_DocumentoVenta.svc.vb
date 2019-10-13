


<DataContract()> _
Public Class e_DocumentoVenta
    Implements Ie_DocumentoVenta

#Region "Propiedad"

    Private _id As String
    Private _idtipodocumento As String
    Private _tipodocumento As String
    Private _idcliente As String
    Private _cliente As String
    Private _concepto As String
    Private _idreferencia As String
    Private _serie As String
    Private _numero As String
    Private _idtipopago As String
    Private _tipopago As String
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _idestado As String
    Private _estado As String
    Private _idmoneda As String
    Private _moneda As String
    Private _totalfacturado As Double
    Private _totalefectivo As Double
    Private _totalcredito As Double
    Private _totaldescuento As Double
    Private _subtotal As Double
    Private _porcentajedescuento As Double
    Private _porcentajedetraccion As Double
    Private _porcentajeigv As Double
    Private _totalmontoneto As Double
    Private _idcuentacorriente As String
    Private _detraccion As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String

    <DataMember()> _
    Public loDocumentoVentaDetalle As New List(Of e_DocumentoVentaDetalle)
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
    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodocumento
        End Get
        Set(ByVal value As String)
            _idtipodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocumento() As String
        Get
            Return _tipodocumento
        End Get
        Set(ByVal value As String)
            _tipodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreCliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
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
    Public Property IdReferencia() As String
        Get
            Return _idreferencia
        End Get
        Set(ByVal value As String)
            _idreferencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
            RaiseEvent DatoCambiado()
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
    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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
    Public Property TotalFacturado() As Double
        Get
            Return _totalfacturado
        End Get
        Set(ByVal value As Double)
            _totalfacturado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TotalEfectivo() As Double
        Get
            Return _totalefectivo
        End Get
        Set(ByVal value As Double)
            _totalefectivo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TotalCredito() As Double
        Get
            Return _totalcredito
        End Get
        Set(ByVal value As Double)
            _totalcredito = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TotalDescuento() As Double
        Get
            Return _totaldescuento
        End Get
        Set(ByVal value As Double)
            _totaldescuento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TotalMontoNeto() As Double
        Get
            Return _totalmontoneto
        End Get
        Set(ByVal value As Double)
            _totalmontoneto = value
            RaiseEvent DatoCambiado()
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
    Public Property TotalDetraccion() As Double
        Get
            Return _detraccion
        End Get
        Set(ByVal value As Double)
            _detraccion = value
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

    <DataMember()> _
    Public Property SubTotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeIgv() As Double
        Get
            Return _porcentajeigv
        End Get
        Set(ByVal value As Double)
            _porcentajeigv = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeDetraccion() As Double
        Get
            Return _porcentajedetraccion
        End Get
        Set(ByVal value As Double)
            _porcentajedetraccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeDescuento() As Double
        Get
            Return _porcentajedescuento
        End Get
        Set(ByVal value As Double)
            _porcentajedescuento = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        IdReferencia = String.Empty
        Activo = True
        FechaVencimiento = Date.Now.Date
        FechaEmision = Date.Now.Date
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_TipoDocumento As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_NombreCliente As String _
              , ByVal ls_Concepto As String _
              , ByVal ls_IdReferencia As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ls_IdTipoPago As String _
              , ByVal ls_TipoPago As String _
              , ByVal ld_FechaEmision As Date _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ln_TotalFacturado As Double _
              , ByVal ln_TotalEfectivo As Double _
              , ByVal ln_TotalCredito As Double _
              , ByVal ln_Descuento As Double _
              , ByVal ln_Saldo As Double _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ln_Detraccion As Double _
              , ByVal ld_FechaCreacion As String _
              , ByVal ln_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ln_PorcentajeDescuento As Decimal _
              , ByVal ln_PorcentajeDetraccion As Decimal _
              , ByVal ln_PorcentajeIgv As Decimal _
              , ByVal ln_SubTotal As Double _
           )
        _id = ls_Id
        _idtipodocumento = ls_IdTipoDocumento
        _tipodocumento = ls_TipoDocumento
        _idcliente = ls_IdCliente
        _cliente = ls_NombreCliente
        _concepto = ls_Concepto
        _idreferencia = ls_IdReferencia
        _serie = ls_Serie
        _numero = ls_Numero
        _idtipopago = ls_IdTipoPago
        _tipopago = ls_TipoPago
        _fechaemision = ld_FechaEmision
        _fechavencimiento = ld_FechaVencimiento
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _idmoneda = ls_IdMoneda
        _moneda = ls_Moneda
        _totalfacturado = ln_TotalFacturado
        _totalefectivo = ln_TotalEfectivo
        _totalcredito = ln_TotalCredito
        _totaldescuento = ln_Descuento
        _totalmontoneto = ln_Saldo
        _idcuentacorriente = ls_IdCuentaCorriente
        _detraccion = ln_Detraccion
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ln_UsuarioCreacion
        _activo = lb_Activo
        _porcentajedescuento = ln_PorcentajeDescuento
        _porcentajedetraccion = ln_PorcentajeDetraccion
        _porcentajeigv = ln_PorcentajeIgv
        _subtotal = ln_SubTotal
    End Sub

#End Region

    Public Function Obtener(ByVal documentoVenta As e_DocumentoVenta) As e_DocumentoVenta Implements Ie_DocumentoVenta.Obtener
        Return documentoVenta
    End Function

End Class

