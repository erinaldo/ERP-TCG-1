<DataContract()> _
Public Class e_OrdenMaterial
    Implements Ie_OrdenMaterial

#Region "Declaración de variables"

    Private _Id As String
    Private _idOrden As String
    Private _Orden As String
    Private _fecorden As Date
    Private _estadoorden As Date
    Private _CantidadMaterial As Double
    Private _PrecioUnitario As Double
    Private _ValorVenta As Double  'Es el subtotal sin incluir IGV, este se guardará en la BD para cuando es una orden de compra
    Private _Importe As Double 'Es el subtotal con IGV, solo servirá para que el usuario lo visualize.
    Private _SubAlmacen As String
    Private _idAlmacen As String
    Private _Almacen As String
    Private _Activo As Boolean
    Private _IndicadorIgv As Boolean
    Private _Seleccion As Boolean
    Private _idMaterial As String
    Private _Material As String
    Private _codMaterial As String
    Private _idArea As String
    Private _Area As String
    Private _Glosa As String
    Private _idCentroCosto As String
    Private _CentroCosto As String
    Private _idUnidadMedida As String
    Private _UnidadMedida As String
    Private _tipoUnidadMedida As String
    Private _usuariocreacion As String
    Private _stock As Double
    Private _ubicacion As String

    '---Campos utilizados para listar ordenes de salida para generar ordenes de compra-
    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()> _
    Public FechaFin As Date
    <DataMember()> _
    Public IdTipoOrden As String
    <DataMember()> _
    Public IdEstadoOrden As String
    <DataMember()> _
    Public IdRequerimientoMaterial As String
    <DataMember()> _
    Public oeControlEntregaMat As New e_ControlEntregaMaterial
    <DataMember()> _
    Public loControlEntregaMaterial As New List(Of e_ControlEntregaMaterial)
    <DataMember()> _
    Public IndPropio As Boolean = False
    '-------------------------------------------------------------------------
    <DataMember()> _
    Public IdReferencia As String = ""
    <DataMember()> _
    Public TipoReferencia As String = ""
    '----------------------------
    <DataMember()> _
    Public TipoOperacion As String
    '---------------------------
    <DataMember()> _
    Public IdSubFamiliaMaterial As String = ""

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Stock() As Double
        Get
            Return _stock
        End Get
        Set(ByVal value As Double)
            _stock = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As String
        Get
            Return _Importe
        End Get
        Set(ByVal value As String)
            _Importe = value
        End Set
    End Property

    <DataMember()> _
    Public Property CentroCosto() As String
        Get
            Return _CentroCosto
        End Get
        Set(ByVal value As String)
            _CentroCosto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentroCosto() As String
        Get
            Return _idCentroCosto
        End Get
        Set(ByVal value As String)
            _idCentroCosto = value
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
    Public Property Area() As String
        Get
            Return _Area
        End Get
        Set(ByVal value As String)
            _Area = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idArea
        End Get
        Set(ByVal value As String)
            _idArea = value
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
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

    <DataMember()> _
    Public Property IdOrden() As String
        Get
            Return _idOrden
        End Get
        Set(ByVal value As String)
            _idOrden = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroOrden() As String
        Get
            Return _Orden
        End Get
        Set(ByVal value As String)
            _Orden = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaOrden() As Date
        Get
            Return _fecorden
        End Get
        Set(ByVal value As Date)
            _fecorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoOrden() As String
        Get
            Return _estadoorden
        End Get
        Set(ByVal value As String)
            _estadoorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idMaterial
        End Get
        Set(ByVal value As String)
            _idMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _Material
        End Get
        Set(ByVal value As String)
            _Material = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoMaterial() As String
        Get
            Return _codMaterial
        End Get
        Set(ByVal value As String)
            _codMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMaterial() As Double
        Get
            Return _CantidadMaterial
        End Get
        Set(ByVal value As Double)
            _CantidadMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitario() As Double
        Get
            Return _PrecioUnitario
        End Get
        Set(ByVal value As Double)
            _PrecioUnitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property ValorVenta() As Double
        Get
            Return _ValorVenta
        End Get
        Set(ByVal value As Double)
            _ValorVenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacen() As String
        Get
            Return _SubAlmacen
        End Get
        Set(ByVal value As String)
            _SubAlmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAlmacen() As String
        Get
            Return _idAlmacen
        End Get
        Set(ByVal value As String)
            _idAlmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Almacen() As String
        Get
            Return _Almacen
        End Get
        Set(ByVal value As String)
            _Almacen = value
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
    Public Property IdUnidadMedida() As String
        Get
            Return _idUnidadMedida
        End Get
        Set(ByVal value As String)
            _idUnidadMedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadMedida() As String
        Get
            Return _UnidadMedida
        End Get
        Set(ByVal value As String)
            _UnidadMedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndicadorIgv() As Boolean
        Get
            Return _IndicadorIgv
        End Get
        Set(ByVal value As Boolean)
            _IndicadorIgv = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoUnidadMedida() As String
        Get
            Return _tipoUnidadMedida
        End Get
        Set(ByVal value As String)
            _tipoUnidadMedida = value
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

#End Region

#Region "Constructores"

    Sub New()
        Activo = True
        TipoOperacion = String.Empty
    End Sub

    Sub New(ByVal Seleccion As Boolean, _
            ByVal Id As String, _
            ByVal IdOrden As String, _
            ByVal NroOrden As String, _
            ByVal IdMaterial As String, _
            ByVal Material As String, _
            ByVal CantidadMaterial As Double, _
            ByVal PrecioUnitario As Double, _
            ByVal ValorVenta As Double, _
            ByVal IdSubAlmacen As String, _
            ByVal IdAlmacen As String, _
            ByVal Almacen As String, _
            ByVal IndicadorIgv As Boolean, _
            ByVal Activo As Boolean, _
            ByVal IdUnidadMedida As String, _
            ByVal UnidadMedida As String, _
            ByVal IdTipoUnidadMedida As String, _
            ByVal CodigoMaterial As String, _
            ByVal ls_Ubicacion As String)
        _Seleccion = Seleccion
        _Id = Id
        _idOrden = IdOrden
        _Orden = NroOrden
        _idMaterial = IdMaterial
        _Material = Material
        _CantidadMaterial = CantidadMaterial
        _PrecioUnitario = PrecioUnitario
        _ValorVenta = ValorVenta 'Es el subtotal sin incluir IGV
        _SubAlmacen = IdSubAlmacen
        _idAlmacen = IdAlmacen
        _Almacen = Almacen
        _IndicadorIgv = IndicadorIgv
        _Activo = Activo
        _idUnidadMedida = IdUnidadMedida
        _UnidadMedida = UnidadMedida
        _tipoUnidadMedida = IdTipoUnidadMedida
        _codMaterial = CodigoMaterial
        _ubicacion = ls_Ubicacion
    End Sub

    Sub New(ByVal ls_IdOrden As String, _
            ByVal ls_NroOrden As String, _
            ByVal ld_Fecha As Date, _
            ByVal ls_Estado As String, _
            ByVal ls_IdMaterial As String, _
            ByVal ls_Material As String, _
            ByVal ln_Cantidad As Double, _
            ByVal ls_IdUnidadMedida As String, _
            ByVal ls_UnidadMedida As String, _
            ByVal ln_PrecioUnit As Double)
        _idOrden = ls_IdOrden
        _Orden = ls_NroOrden
        _fecorden = ld_Fecha
        _estadoorden = ls_Estado
        _idMaterial = ls_IdMaterial
        _Material = ls_Material
        _CantidadMaterial = ln_Cantidad
        _PrecioUnitario = ln_PrecioUnit
        _idUnidadMedida = ls_IdUnidadMedida
        _UnidadMedida = ls_UnidadMedida
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal ordenMaterial As e_OrdenMaterial) As e_OrdenMaterial Implements Ie_OrdenMaterial.Obtener
        Return ordenMaterial
    End Function

#End Region

End Class
