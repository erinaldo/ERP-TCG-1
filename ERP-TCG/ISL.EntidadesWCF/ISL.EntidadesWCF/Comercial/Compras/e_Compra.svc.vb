<DataContract()> _
Public Class e_Compra
    Implements Ie_Compra

#Region "Declaración de variables"

    Private _id As String
    Private _anoemisionaduana As Integer
    Private _base1 As Double
    Private _igv1 As Double
    Private _base2 As Double
    Private _igv2 As Double
    Private _base3 As Double
    Private _igv3 As Double
    Private _isc As Double
    Private _otrostributos As Double
    Private _idmovimientodocumento As String
    Private _activo As Boolean
    Private _idtipocompra As String
    Private _tipocompra As String
    Private _nogravadas As Double
    Private _tipopago As String
    Private _percepcion As Double
    Private _detraccion As Double
    Private _retencion As Double
    Private _percepcionporc As Double
    Private _detraccionporc As Double
    Private _retencionporc As Double
    Private _impuestorenta As Double
    Private _glosa As String
    Private _CobraCajaChica As Integer = 0
    Private _IdMotivoDocumento As String
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Private _inddetraccion As Integer = 0
    '----------------------variables de ayuda-----------------
    <DataMember()> _
    Public TipoDoc As e_TipoDocumento
    <DataMember()> _
    Public Moneda As e_Moneda
    <DataMember()> _
    Public TipoCompra As e_TablaContableDet
    <DataMember()> _
    Public Proveedor As e_Proveedor
    <DataMember()>
    Public TotalIGVCompra As Double
    <DataMember()> _
    Public TotalBaseCompra As Double
    '---------------------------------------------------------
    <DataMember()> _
    Public IndTipoOperacion As String
    <DataMember()> _
    Public PagoXCajaTesoreria As Double
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
    Public Property AnoEmisionAduana() As Integer
        Get
            Return _anoemisionaduana
        End Get
        Set(ByVal value As Integer)
            _anoemisionaduana = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Base1() As Double
        Get
            Return _base1
        End Get
        Set(ByVal value As Double)
            _base1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Igv1() As Double
        Get
            Return _igv1
        End Get
        Set(ByVal value As Double)
            _igv1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Base2() As Double
        Get
            Return _base2
        End Get
        Set(ByVal value As Double)
            _base2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Igv2() As Double
        Get
            Return _igv2
        End Get
        Set(ByVal value As Double)
            _igv2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Base3() As Double
        Get
            Return _base3
        End Get
        Set(ByVal value As Double)
            _base3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Igv3() As Double
        Get
            Return _igv3
        End Get
        Set(ByVal value As Double)
            _igv3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Isc() As Double
        Get
            Return _isc
        End Get
        Set(ByVal value As Double)
            _isc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property OtrosTributos() As Double
        Get
            Return _otrostributos
        End Get
        Set(ByVal value As Double)
            _otrostributos = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
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
    Public Property IdTipoCompra() As String
        Get
            Return _idtipocompra
        End Get
        Set(ByVal value As String)
            _idtipocompra = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NoGravadas() As Double
        Get
            Return _nogravadas
        End Get
        Set(ByVal value As Double)
            _nogravadas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoPago() As String
        Get
            Return _tipopago
        End Get
        Set(ByVal value As String)
            _tipopago = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPago() As String
        Get
            Return _tipocompra
        End Get
        Set(ByVal value As String)
            _tipocompra = value
        End Set
    End Property

    <DataMember()> _
    Public Property Percepcion() As Double
        Get
            Return _percepcion
        End Get
        Set(ByVal value As Double)
            _percepcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Detraccion() As Double
        Get
            Return _detraccion
        End Get
        Set(ByVal value As Double)
            _detraccion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion() As Double
        Get
            Return _retencion
        End Get
        Set(ByVal value As Double)
            _retencion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PercepcionPorc() As Double
        Get
            Return _percepcionporc
        End Get
        Set(ByVal value As Double)
            _percepcionporc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DetraccionPorc() As Double
        Get
            Return _detraccionporc
        End Get
        Set(ByVal value As Double)
            _detraccionporc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property RetencionPorc() As Double
        Get
            Return _retencionporc
        End Get
        Set(ByVal value As Double)
            _retencionporc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ImpuestoRenta() As Double
        Get
            Return _impuestorenta
        End Get
        Set(ByVal value As Double)
            _impuestorenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property CobraCajaChica() As Integer
        Get
            Return _CobraCajaChica
        End Get
        Set(ByVal value As Integer)
            _CobraCajaChica = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMotivoDocumento() As String
        Get
            Return _IdMotivoDocumento
        End Get
        Set(ByVal value As String)
            _IdMotivoDocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndDetraccion() As String
        Get
            Return _inddetraccion
        End Get
        Set(ByVal value As String)
            _inddetraccion = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ln_AnoEmisionAduana As Integer _
              , ByVal ln_Base1 As Double _
              , ByVal ln_Igv1 As Double _
              , ByVal ln_Base2 As Double _
              , ByVal ln_Igv2 As Double _
              , ByVal ln_Base3 As Double _
              , ByVal ln_Igv3 As Double _
              , ByVal ln_Isc As Double _
              , ByVal ln_OtrosTributos As Double _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdTipoCompra As String _
              , ByVal ln_NoGravadas As Double _
              , ByVal ln_Percepcion As Double _
          , ByVal ln_Detraccion As Double _
          , ByVal ln_Retencion As Double _
          , ByVal ln_PercepcionPorc As Double _
          , ByVal ln_DetraccionPorc As Double _
          , ByVal ln_RetencionPorc As Double _
          , ByVal lsTipoPago As String _
          , ByVal lsIndTipoOperacion As String _
          , ByVal ln_ImpuestoRenta As Double _
          , ByVal lst_Glosa As String _
          , ByVal lb_CobraCajaChica As Integer _
          , ByVal ls_IdMotivoDocumento As String _
          , ByVal lb_IndDetraccion As Boolean _
          )
        _id = ls_Id
        _anoemisionaduana = ln_AnoEmisionAduana
        _base1 = ln_Base1
        _igv1 = ln_Igv1
        _base2 = ln_Base2
        _igv2 = ln_Igv2
        _base3 = ln_Base3
        _igv3 = ln_Igv3
        _isc = ln_Isc
        _otrostributos = ln_OtrosTributos
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _activo = lb_Activo
        _idtipocompra = ls_IdTipoCompra
        _nogravadas = ln_NoGravadas
        _percepcion = ln_Percepcion
        _detraccion = ln_Detraccion
        _retencion = ln_Retencion
        _percepcionporc = ln_PercepcionPorc
        _detraccionporc = ln_DetraccionPorc
        _retencionporc = ln_RetencionPorc
        _tipopago = lsTipoPago
        IndTipoOperacion = lsIndTipoOperacion
        _impuestorenta = ln_ImpuestoRenta
        _glosa = lst_Glosa
        _CobraCajaChica = lb_CobraCajaChica
        _IdMotivoDocumento = ls_IdMotivoDocumento
        _inddetraccion = lb_IndDetraccion
    End Sub

#End Region

    Public Function Obtener(ByVal compra As e_Compra) As e_Compra Implements Ie_Compra.Obtener
        Return compra
    End Function

End Class
