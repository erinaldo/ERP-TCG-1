

<DataContract()> _
Public Class e_ReporteDocumento
    Implements Ie_ReporteDocumento

#Region "Declaracion de Variables"

    Private _idtipodoc As String
    Private _tipodoc As String
    Private _idmovimientodocumento As String
    Private _serie As String
    Private _numero As String
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _idcliente As String
    Private _cliente As String
    Private _nrodocumento As String
    Private _subtotal As Double
    Private _igv As Double
    Private _total As Double
    Private _saldo As Double
    Private _detraccion As Double
    Private _saldodetraccion As Double
    Private _saldoneto As Double
    Private _idtipomoneda As String
    Private _tipomoneda As String
    Private _tipocambio As Double
    Private _totalsoles As Double
    Private _idestadodocumento As String
    Private _estadodocumento As String
    Private _indicador As String
    Private _glosa As String
    Private _cadenaoperacion As String
    Private _cadenaviaje As String
    Private _IndElectronico As Boolean
    Private _estadodocumentosunat As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public _Fechadesde As Date
    <DataMember()> _
    Public _FechaHasta As Date

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdTipoDoc() As String
        Get
            Return _idtipodoc
        End Get
        Set(ByVal value As String)
            _idtipodoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDoc() As String
        Get
            Return _tipodoc
        End Get
        Set(ByVal value As String)
            _tipodoc = value
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
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
        End Set
    End Property

    <DataMember()> _
   Public Property NroDocumento() As String
        Get
            Return _nrodocumento
        End Get
        Set(ByVal value As String)
            _nrodocumento = value
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
    Public Property IGV() As Double
        Get
            Return _igv
        End Get
        Set(ByVal value As Double)
            _igv = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
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
    Public Property Detraccion()
        Get
            Return _detraccion
        End Get
        Set(ByVal value)
            _detraccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoDetraccion() As Double
        Get
            Return _saldodetraccion
        End Get
        Set(ByVal value As Double)
            _saldodetraccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoNeto() As Double
        Get
            Return _saldoneto
        End Get
        Set(ByVal value As Double)
            _saldoneto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoMoneda() As String
        Get
            Return _idtipomoneda
        End Get
        Set(ByVal value As String)
            _idtipomoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMoneda() As String
        Get
            Return _tipomoneda
        End Get
        Set(ByVal value As String)
            _tipomoneda = value
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
    Public Property TotalSoles() As Double
        Get
            Return _totalsoles
        End Get
        Set(ByVal value As Double)
            _totalsoles = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstadoDocumento() As String
        Get
            Return _idestadodocumento
        End Get
        Set(ByVal value As String)
            _idestadodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoDocumento() As String
        Get
            Return _estadodocumento
        End Get
        Set(ByVal value As String)
            _estadodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Indicador() As String
        Get
            Return _indicador
        End Get
        Set(ByVal value As String)
            _indicador = value
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
    Public Property CadenaOperacion() As String
        Get
            Return _cadenaoperacion
        End Get
        Set(ByVal value As String)
            _cadenaoperacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property CadenaViaje() As String
        Get
            Return _cadenaviaje
        End Get
        Set(ByVal value As String)
            _cadenaviaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndElectronico() As Boolean
        Get
            Return _IndElectronico
        End Get
        Set(ByVal value As Boolean)
            _IndElectronico = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoDocumentoSunat() As String
        Get
            Return _estadodocumentosunat
        End Get
        Set(ByVal value As String)
            _estadodocumentosunat = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _idtipodoc = String.Empty
        _tipodoc = String.Empty
        _idmovimientodocumento = String.Empty
        _serie = String.Empty
        _numero = String.Empty
        _fechaemision = #1/1/1901#
        _fechavencimiento = #1/1/1901#
        _idcliente = String.Empty
        _cliente = String.Empty
        _nrodocumento = String.Empty
        _subtotal = 0
        _igv = 0
        _total = 0
        _saldo = 0
        _detraccion = 0
        _saldodetraccion = 0
        _idtipomoneda = String.Empty
        _tipomoneda = String.Empty
        _tipocambio = 0
        _totalsoles = 0
        _idestadodocumento = String.Empty
        _estadodocumento = String.Empty
        _indicador = String.Empty
        _glosa = String.Empty
        _cadenaoperacion = String.Empty
    End Sub

    Public Sub New(ByVal ls_IdTipoDoc As String, _
                    ByVal ls_TipoDoc As String, _
                    ByVal ls_IdMovimientoDocumento As String, _
                    ByVal ls_Serie As String, _
                    ByVal ls_Numero As String, _
                    ByVal ld_FechaEmision As Date, _
                    ByVal ld_FechaVencimiento As Date, _
                    ByVal ls_IdCliente As String, _
                    ByVal ls_Cliente As String, _
                    ByVal ls_NroDocumento As String, _
                    ByVal ln_SubTotal As Double, _
                    ByVal ln_Igv As Double, _
                    ByVal ln_Total As Double, _
                    ByVal ln_Saldo As Double, _
                    ByVal ln_Detraccion As Double, _
                    ByVal ln_SaldoDetraccion As Double, _
                    ByVal ls_IdTipoMoneda As String, _
                    ByVal ls_TipoMoneda As String, _
                    ByVal ln_TipoCambio As Double, _
                    ByVal ls_IdEstadoDocumento As String, _
                    ByVal ls_EstadoDocumento As String, _
                    ByVal ls_Indicador As String, _
                    ByVal ls_Glosa As String, _
                    ByVal ls_CadenaOperacion As String, _
                    ByVal ls_CadenaViaje As String)

        _idtipodoc = ls_IdTipoDoc
        _tipodoc = ls_TipoDoc
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _serie = ls_Serie
        _numero = ls_Numero
        _fechaemision = ld_FechaEmision
        _fechavencimiento = ld_FechaVencimiento
        _idcliente = ls_IdCliente
        _cliente = ls_Cliente
        _nrodocumento = ls_NroDocumento
        _subtotal = ln_SubTotal
        _igv = ln_Igv
        _total = ln_Total
        _saldo = ln_Saldo
        _detraccion = ln_Detraccion
        _saldodetraccion = ln_SaldoDetraccion
        _saldoneto = ln_Saldo - ln_SaldoDetraccion
        _idtipomoneda = ls_IdTipoMoneda
        _tipomoneda = ls_TipoMoneda
        _tipocambio = IIf(_tipomoneda = "S/", 0, ln_TipoCambio)
        _totalsoles = IIf(_tipocambio = 0, _total, Math.Round(_total * _tipocambio, 2))
        _idestadodocumento = ls_IdEstadoDocumento
        _estadodocumento = ls_EstadoDocumento
        _indicador = ls_Indicador
        _glosa = ls_Glosa
        _cadenaoperacion = ls_CadenaOperacion
        _cadenaviaje = ls_CadenaViaje
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal reportedocumento As e_ReporteDocumento) As e_ReporteDocumento Implements Ie_ReporteDocumento.Obtener
        Return reportedocumento
    End Function

#End Region

End Class


