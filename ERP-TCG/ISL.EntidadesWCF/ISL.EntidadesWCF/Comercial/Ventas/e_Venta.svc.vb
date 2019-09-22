

<DataContract()> _
Public Class e_Venta
    Implements Ie_Venta

#Region "Declaración de variables"

    Private _id As String
    Private _exportacion As Double
    Private _grabado As Double
    Private _exonerado As Double
    Private _inafecto As Double
    Private _isc As Double
    Private _igv As Double
    Private _otrostributos As Double
    Private _descuentos As Double
    Private _detraccion As Double
    Private _saldodetraccion As Double
    Private _idmovimientodocumento As String
    Private _activo As Boolean
    Private _IdTipoVenta As String
    Private _idDireccion As String
    Private _idTipoPago As String
    Private _glosa As String
    Private _factorrefuni As Double
    Private _porcendetra As Double
    Private _IndCliente As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    '----------------------variables de ayuda-----------------
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public TipoDoc As e_TipoDocumento
    <DataMember()> _
    Public Cliente As e_Cliente
    <DataMember()> _
    Public Moneda As e_Moneda
    <DataMember()> _
    Public TipoVenta As e_TablaContableDet
    ''' <summary>
    ''' SubtTotal de venta(Sin Impuestos!) y cuando es en dolares NO esta por tipo de cambio
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public TotalVenta As Double
    '-----------------------------------------------------
    Public Property IdEmpresaSis() As String
    Public Property IdSucursal() As String

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
    Public Property Exportacion() As Double
        Get
            Return _exportacion
        End Get
        Set(ByVal value As Double)
            _exportacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Gravado() As Double
        Get
            Return _grabado
        End Get
        Set(ByVal value As Double)
            _grabado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Exonerado() As Double
        Get
            Return _exonerado
        End Get
        Set(ByVal value As Double)
            _exonerado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Inafecto() As Double
        Get
            Return _inafecto
        End Get
        Set(ByVal value As Double)
            _inafecto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ISC() As Double
        Get
            Return _isc
        End Get
        Set(ByVal value As Double)
            _isc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IGV() As Double
        Get
            Return _igv
        End Get
        Set(ByVal value As Double)
            _igv = value
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
    Public Property Descuentos() As Double
        Get
            Return _descuentos
        End Get
        Set(ByVal value As Double)
            _descuentos = value
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
    Public Property SaldoDetraccion() As Double
        Get
            Return _saldodetraccion
        End Get
        Set(ByVal value As Double)
            _saldodetraccion = value
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
    Public Property IdDireccion() As String
        Get
            Return _idDireccion
        End Get
        Set(ByVal value As String)
            _idDireccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoPago() As String
        Get
            Return _idTipoPago
        End Get
        Set(ByVal value As String)
            _idTipoPago = value
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
    Public Property FactorRefUni() As Double
        Get
            Return _factorrefuni
        End Get
        Set(ByVal value As Double)
            _factorrefuni = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcenDetra() As Double
        Get
            Return _porcendetra
        End Get
        Set(ByVal value As Double)
            _porcendetra = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCliente() As Integer
        Get
            Return _IndCliente
        End Get
        Set(ByVal value As Integer)
            _IndCliente = value
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
    Public Property IdTipoVenta() As String
        Get
            Return _IdTipoVenta
        End Get
        Set(ByVal value As String)
            _IdTipoVenta = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ln_Exportacion As Double _
              , ByVal ln_Grabado As Double _
              , ByVal ln_Exonerado As Double _
              , ByVal ln_Inafecto As Double _
              , ByVal ln_ISC As Double _
              , ByVal ln_IGV As Double _
              , ByVal ln_OtrosTributos As Double _
              , ByVal ln_Descuentos As Double _
              , ByVal ln_Detraccion As Double _
              , ByVal ln_SaldoDetraccion As Double _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal _IdTipoV As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdDireccion As String _
              , ByVal ls_IdTipoPago As String _
              , ByVal ls_Glosa As String _
              , ByVal ln_FactorRefUni As Double _
              , ByVal ln_PorcenDetra As Double _
              , ByVal ln_IndCliente As Integer _
           )
        _id = ls_Id
        _exportacion = ln_Exportacion
        _grabado = ln_Grabado
        _exonerado = ln_Exonerado
        _inafecto = ln_Inafecto
        _isc = ln_ISC
        _igv = ln_IGV
        _otrostributos = ln_OtrosTributos
        _descuentos = ln_Descuentos
        _detraccion = ln_Detraccion
        _saldodetraccion = ln_SaldoDetraccion
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _activo = lb_Activo
        _IdTipoVenta = _IdTipoV
        _idDireccion = ls_IdDireccion
        _idTipoPago = ls_IdTipoPago
        _glosa = ls_Glosa
        _factorrefuni = ln_FactorRefUni
        _porcendetra = ln_PorcenDetra
        _IndCliente = ln_IndCliente
    End Sub

#End Region

    Public Function Obtener(ByVal venta As e_Venta) As e_Venta Implements Ie_Venta.Obtener
        Return venta
    End Function

End Class


