' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_OrdenVenta" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_OrdenVenta.svc o e_OrdenVenta.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_OrdenVenta
    Implements Ie_OrdenVenta

#Region "Declaracion Variables"

    Private _id As String
    Private _empresasis As String
    Private _sucursal As String
    Private _empresa As New e_Empresa
    Private _tipopago As New e_TipoPago
    Private _estado As New e_Estado
    Private _idmoneda As String
    Private _moneda As String
    Private _nombretipocompra As String
    Private _trabajadoraprobacion As String
    Private _idtrabajadoraprobacion As String
    Private _fecha As Date
    Private _ordencomercial As String
    Private _glosa As String
    Private _tipo As Integer
    Private _tipoexistencia As Integer
    Private _tipocompra As Integer
    Private _tipocambio As Double
    Private _subtotal As Double
    Private _impuesto As Double
    Private _total As Double
    Private _usuariocrea As String
    Private _fechacrea As Date
    Private _indfactser As Boolean
    Private _indfacturado As Boolean
    Private _indcantidadvariable As Boolean
    Private _IdOrdenReferencia As String
    Private _IndFacturadoProducto As Boolean
    Private _IdVendedorTrabajador As String
    Private _DocAsoc As String

    ' Added by Cess
    Private _IdTurno As String
    Private _IdCanalVenta As String
    Private _IdTipoVenta As String

    Public TipoOperacion As String
    Public lstOrdenComercialMaterial As New List(Of e_OrdenVentaMaterial)
    'Public lstOrdenComercialServicio As New List(Of e_OrdenComercialServicio)

    <DataMember()>
    Public oeOrdenIngreso, oeOrdenSalida As New e_Orden
    <DataMember()>
    Public oeDocumento As New e_MovimientoDocumento
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    <DataMember()>
    Public Property IdEmpresaAlterna As String = ""

#End Region

#Region "Propiedad"

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property IdEmpresaSis() As String
        Get
            Return _empresasis
        End Get
        Set(ByVal value As String)
            _empresasis = value
        End Set
    End Property

    Public Property IdSucursal() As String
        Get
            Return _sucursal
        End Get
        Set(ByVal value As String)
            _sucursal = value
        End Set
    End Property

    Public Property IdEmpresa() As String
        Get
            Return _empresa.Id
        End Get
        Set(ByVal value As String)
            _empresa.Id = value
        End Set
    End Property

    Public Property Empresa() As String
        Get
            Return _empresa.Nombre
        End Get
        Set(ByVal value As String)
            _empresa.Nombre = value
        End Set
    End Property

    Public Property IdTipoPago() As String
        Get
            Return _tipopago.Id
        End Get
        Set(ByVal value As String)
            _tipopago.Id = value
        End Set
    End Property

    Public Property IdEstado() As String
        Get
            Return _estado.Id
        End Get
        Set(ByVal value As String)
            _estado.Id = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return _estado.Nombre
        End Get
        Set(ByVal value As String)
            _estado.Nombre = value
        End Set
    End Property

    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
        End Set
    End Property

    Public Property IdTrabajadorAprobacion() As String
        Get
            Return _idtrabajadoraprobacion
        End Get
        Set(ByVal value As String)
            _idtrabajadoraprobacion = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Public Property OrdenComercial() As String
        Get
            Return _ordencomercial
        End Get
        Set(ByVal value As String)
            _ordencomercial = value
        End Set
    End Property

    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
        End Set
    End Property

    Public Property TipoExistencia() As Integer
        Get
            Return _tipoexistencia
        End Get
        Set(ByVal value As Integer)
            _tipoexistencia = value
        End Set
    End Property

    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
        End Set
    End Property

    Public Property TipoCompra() As Integer
        Get
            Return _tipocompra
        End Get
        Set(ByVal value As Integer)
            _tipocompra = value
        End Set
    End Property

    Public Property TrabajadorAprobacion() As String
        Get
            Return _trabajadoraprobacion
        End Get
        Set(ByVal value As String)
            _trabajadoraprobacion = value
        End Set
    End Property

    Public Property NombreTipoCompra() As String
        Get
            Return _nombretipocompra
        End Get
        Set(ByVal value As String)
            _nombretipocompra = value
        End Set
    End Property

    Public Property Moneda() As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
        End Set
    End Property

    Public Property SubTotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
        End Set
    End Property

    Public Property Impuesto() As Double
        Get
            Return _impuesto
        End Get
        Set(ByVal value As Double)
            _impuesto = value
        End Set
    End Property

    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

    Public Property UsuarioCrea() As String
        Get
            Return _usuariocrea
        End Get
        Set(ByVal value As String)
            _usuariocrea = value
        End Set
    End Property

    Public Property FechaCrea() As Date
        Get
            Return _fechacrea
        End Get
        Set(ByVal value As Date)
            _fechacrea = value
        End Set
    End Property

    Public Property IndFactSer() As Boolean
        Get
            Return _indfactser
        End Get
        Set(ByVal value As Boolean)
            _indfactser = value
        End Set
    End Property

    Public Property IndFacturado() As Boolean
        Get
            Return _indfacturado
        End Get
        Set(ByVal value As Boolean)
            _indfacturado = value
        End Set
    End Property

    Public Property IndCantidadVariable() As Boolean
        Get
            Return _indcantidadvariable
        End Get
        Set(ByVal value As Boolean)
            _indcantidadvariable = value
        End Set
    End Property

    Public Property IdOrdenReferencia() As String
        Get
            Return _IdOrdenReferencia
        End Get
        Set(value As String)
            _IdOrdenReferencia = value
        End Set
    End Property

    Public Property IndFacturadoProducto() As Boolean
        Get
            Return _IndFacturadoProducto
        End Get
        Set(value As Boolean)
            _IndFacturadoProducto = value
        End Set
    End Property

    Public Property DocAsoc() As String
        Get
            Return _DocAsoc
        End Get
        Set(value As String)
            _DocAsoc = value
        End Set
    End Property

    Public Property IdVendedorTrabajador() As String
        Get
            Return _IdVendedorTrabajador
        End Get
        Set(value As String)
            _IdVendedorTrabajador = value
        End Set
    End Property

    Public Property IdTurno() As String
        Get
            Return _IdTurno
        End Get
        Set(ByVal value As String)
            _IdTurno = value
        End Set
    End Property
    Public Property IdCanalVenta() As String
        Get
            Return _IdCanalVenta
        End Get
        Set(ByVal value As String)
            _IdCanalVenta = value
        End Set
    End Property
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
        TipoOperacion = ""
        _id = ""
        _tipo = 0
        _tipoexistencia = 0
        _fecha = Date.Parse("01/01/1901")
        _fechacrea = Date.Parse("01/01/1901")
        _indfactser = False
        _indfacturado = False
        _indcantidadvariable = False
        _IndFacturadoProducto = False
        _IdVendedorTrabajador = String.Empty
        _DocAsoc = String.Empty
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_IdEmpresaSis As String _
              , ByVal ls_IdSucursal As String _
              , ByVal ls_IdEmpresa As String _
              , ByVal ls_Empresa As String _
              , ByVal ls_IdEmpresaAlterna As String _
              , ByVal ls_IdTipoPago As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ls_IdTrabajadorAprobacion As String _
              , ByVal ls_TrabajadorAprobacion As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_OrdenComercial As String _
              , ByVal ls_Glosa As String _
              , ByVal ln_TipoExistencia As Integer _
              , ByVal ln_TipoCompra As Integer _
              , ByVal ls_TipoCompra As String _
              , ByVal ln_TipoCambio As Double _
              , ByVal ln_SubTotal As Double _
              , ByVal ln_Impuesto As Double _
              , ByVal ln_Total As Double _
              , ByVal ls_UsuarioCrea As String _
              , ByVal lb_IndFactSer As Boolean _
              , ByVal lb_IndFacturado As Boolean _
              , ByVal lb_IndCantidadVariable As Boolean _
              , ByVal ls_IdOrdenReferencia As String _
              , ByVal lb_IndFacturadoProducto As Boolean _
              , ByVal ls_IdVendedorTrabajador As String _
              , ByVal ls_DocAsoc As String _
              , ByVal ls_IdTurno As String _
              , ByVal ls_IdCanalVenta As String _
              , ByVal ls_IdTipoVenta As String)
        _id = ls_Id
        '_empresasis.Id = ls_IdEmpresaSis
        '_sucursal.Id = ls_IdSucursal
        _empresa.Id = ls_IdEmpresa
        _empresa.Nombre = ls_Empresa
        IdEmpresaAlterna = ls_IdEmpresaAlterna
        _tipopago.Id = ls_IdTipoPago
        _estado.Id = ls_IdEstado
        _estado.Nombre = ls_Estado
        _idmoneda = ls_IdMoneda
        _moneda = ls_Moneda
        _idtrabajadoraprobacion = ls_IdTrabajadorAprobacion
        _trabajadoraprobacion = ls_TrabajadorAprobacion
        _fecha = ld_Fecha
        _ordencomercial = ls_OrdenComercial
        _glosa = ls_Glosa
        _tipoexistencia = ln_TipoExistencia
        _tipocompra = ln_TipoCompra
        _nombretipocompra = ls_TipoCompra
        _tipocambio = ln_TipoCambio
        _subtotal = ln_SubTotal
        _impuesto = ln_Impuesto
        _total = ln_Total
        _usuariocrea = ls_UsuarioCrea
        _indfactser = lb_IndFactSer
        _indfacturado = lb_IndFacturado
        _indcantidadvariable = lb_IndCantidadVariable
        _IdOrdenReferencia = ls_IdOrdenReferencia
        _IndFacturadoProducto = lb_IndFacturadoProducto
        _IdVendedorTrabajador = ls_IdVendedorTrabajador
        _DocAsoc = ls_DocAsoc
        _IdTurno = ls_IdTurno
        _IdCanalVenta = ls_IdCanalVenta
        _IdTipoVenta = ls_IdTipoVenta
    End Sub


    Public Function Obtener(ByVal operacion As e_OrdenVenta) As e_OrdenVenta Implements Ie_OrdenVenta.Obtener
        Return operacion
    End Function

#End Region


End Class
