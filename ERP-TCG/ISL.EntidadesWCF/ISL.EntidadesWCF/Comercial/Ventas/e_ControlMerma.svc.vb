<DataContract()> _
Public Class e_ControlMerma
    Implements Ie_ControlMerma

#Region "Propiedad"

    Private _id As String
    Private _idmovimientomermas As String
    Private _indingresosalida As Integer
    Private _clientepersona As String
    Private _idclientepersona As String
    Private _fecha As Date
    Private _idviaje As String
    Private _material As New e_Material
    Private _unidadcantidad As String
    Private _cantidad As Double
    Private _preciounitario As Double
    Private _preciototal As Double
    Private _saldo As Double
    Private _factorconversion As Double
    Private _glosa As String
    Private _estado As New e_Estado
    Private _serie As String
    Private _numero As String
    Private _preciofactura As Double
    Private _indcobro As Integer
    Private _tipopago As Integer
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String

    <DataMember()> _
    Public IdCentro As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String

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
    Public Property IdMovimientoMermas() As String
        Get
            Return _idmovimientomermas
        End Get
        Set(ByVal value As String)
            _idmovimientomermas = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndIngresoSalida() As Integer
        Get
            Return _indingresosalida
        End Get
        Set(ByVal value As Integer)
            _indingresosalida = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdClientePersona() As String
        Get
            Return _idclientepersona
        End Get
        Set(ByVal value As String)
            _idclientepersona = value
        End Set
    End Property

    <DataMember()> _
    Public Property ClientePersona() As String
        Get
            Return _clientepersona
        End Get
        Set(ByVal value As String)
            _clientepersona = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _idviaje
        End Get
        Set(ByVal value As String)
            _idviaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _material.Id
        End Get
        Set(ByVal value As String)
            _material.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _material.Nombre
        End Get
        Set(ByVal value As String)
            _material.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadCantidad() As String
        Get
            Return _unidadcantidad
        End Get
        Set(ByVal value As String)
            _unidadcantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitario() As Double
        Get
            Return _preciounitario
        End Get
        Set(ByVal value As Double)
            _preciounitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioTotal() As Double
        Get
            Return _preciototal
        End Get
        Set(ByVal value As Double)
            _preciototal = value
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
    Public Property FactorConversion() As Double
        Get
            Return _factorconversion
        End Get
        Set(ByVal value As Double)
            _factorconversion = value
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
    Public Property IdEstado() As String
        Get
            Return _estado.Id
        End Get
        Set(ByVal value As String)
            _estado.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado.Nombre
        End Get
        Set(ByVal value As String)
            _estado.Nombre = value
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
    Public Property PrecioFactura() As Double
        Get
            Return _preciofactura
        End Get
        Set(ByVal value As Double)
            _preciofactura = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCobro() As Integer
        Get
            Return _indcobro
        End Get
        Set(ByVal value As Integer)
            _indcobro = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPago() As Integer
        Get
            Return _tipopago
        End Get
        Set(ByVal value As Integer)
            _tipopago = value
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
        Activo = True
        Id = ""
        IdMovimientoMermas = ""
        IdMaterial = ""
        IdClientePersona = ""
        FechaDesde = Date.Parse("01/01/1901")
        FechaHasta = Date.Parse("01/01/1901")
        Fecha = Date.Parse("01/01/1901")
        IdCentro = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdMovimientoMermas As String _
              , ByVal ln_IndIngresoSalida As Integer _
              , ByVal ls_IdClientePersona As String _
              , ByVal ls_ClientePersona As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_IdViaje As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_Material As String _
              , ByVal ls_UnidadCantidad As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_PrecioUnitario As Double _
              , ByVal ln_PrecioTotal As Double _
              , ByVal ln_Saldo As Double _
              , ByVal ln_FactorConversion As Double _
              , ByVal ls_Glosa As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ln_PrecioFactura As Double _
              , ByVal ln_IndCobro As Integer _
              , ByVal ln_TipoPago As Integer _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idmovimientomermas = ls_IdMovimientoMermas
        _indingresosalida = ln_IndIngresoSalida
        _idclientepersona = ls_IdClientePersona
        _clientepersona = ls_ClientePersona
        _fecha = ld_Fecha
        _idviaje = ls_IdViaje
        _material.Id = ls_IdMaterial
        _material.Nombre = ls_Material
        _unidadcantidad = ls_UnidadCantidad
        _cantidad = ln_Cantidad
        _preciounitario = ln_PrecioUnitario
        _preciototal = ln_PrecioTotal
        _saldo = ln_Saldo
        _factorconversion = ln_FactorConversion
        _glosa = ls_Glosa
        _estado.Id = ls_IdEstado
        _estado.Nombre = ls_Estado
        _serie = ls_Serie
        _numero = ls_Numero
        _preciofactura = ln_PrecioFactura
        _indcobro = ln_IndCobro
        _tipopago = ln_TipoPago
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

End Class


