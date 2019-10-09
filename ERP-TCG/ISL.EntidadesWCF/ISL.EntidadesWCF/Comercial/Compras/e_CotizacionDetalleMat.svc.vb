


<DataContract()> _
Public Class e_CotizacionDetalleMat
    Implements Ie_CotizacionDetalleMatMat

#Region "Propiedad"

    Private _id As String
    Private _idmaterial As String
    Private _material As String
    Private _codmaterial As String
    Private _idalmacen As String
    Private _almacen As String
    Private _SubAlmacen As String
    Private _glosa As String
    Private _cotizacionproveedor As New e_Cotizacion_Proveedor
    Private _idunidadmedida As String
    Private _unidadmedida As String
    Private _tipoUnidadMedida As String

    Private _cantidad As Double
    Private _precio As Double
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date

    Private _IdRequerimientoMaterial As String
    Private _tipocotizacion As String 'Indica si es una cotizacion por requerimientos(RM) o por materiales(M) 

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    Private _posMat As Integer  'Indica la posicion del material para poder quitarlo del detalle

    Private _Seleccion As Boolean

    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()> _
    Public FechaFinal As Date

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
    Public Property IdSubAlmacen() As String
        Get
            Return _SubAlmacen
        End Get
        Set(ByVal value As String)
            _SubAlmacen = value
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
    Public Property IdCotizacionProveedor() As String
        Get
            Return _cotizacionproveedor.Id
        End Get
        Set(ByVal value As String)
            _cotizacionproveedor.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRequerimientoMaterial() As String
        Get
            Return _IdRequerimientoMaterial
        End Get
        Set(ByVal value As String)
            _IdRequerimientoMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
        End Set
    End Property
    <DataMember()> _
    Public Property Material() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoMaterial() As String
        Get
            Return _codmaterial
        End Get
        Set(ByVal value As String)
            _codmaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAlmacen() As String
        Get
            Return _idalmacen
        End Get
        Set(ByVal value As String)
            _idalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Almacen() As String
        Get
            Return _almacen
        End Get
        Set(ByVal value As String)
            _almacen = value
        End Set
    End Property


    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _idunidadmedida
        End Get
        Set(ByVal value As String)
            _idunidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadMedida() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
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
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCotizacion() As String
        Get
            Return _tipocotizacion
        End Get
        Set(ByVal value As String)
            _tipocotizacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property PosMat() As Integer
        Get
            Return _posMat
        End Get
        Set(ByVal value As Integer)
            _posMat = value
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

#End Region

#Region "Constructor"

    Public Sub New()

        FechaInicio = "01/01/1901"
        FechaFinal = "01/01/1901"
        _activo = True

    End Sub

    Public Sub New( _
           ByVal ls_Id As String _
           , ByVal ld_Seleccion As Boolean _
           , ByVal ls_IdMaterial As String _
           , ByVal ls_CodigoMaterial As String _
           , ByVal ls_Material As String _
           , ByVal ls_IdAlmacen As String _
           , ByVal ls_Almacen As String _
           , ByVal ls_IdUnidadMedida As String _
           , ByVal ls_UnidadMedida As String _
           , ByVal ln_Cantidad As Double _
           , ByVal lb_Activo As Boolean _
           , ByVal ls_UsuarioCreacion As String _
           , ByVal ld_FechaCreacion As Date _
           , ByVal ld_IdTipoUnidadMedida As String _
           , ByVal ld_Precio As String _
           , ByVal ld_IdSubAlmacen As String _
           , ByVal ls_IdCotizacionProveedor As String _
           , ByVal ls_Glosa As String)
        _Seleccion = ld_Seleccion
        _id = ls_Id
        _idmaterial = ls_IdMaterial
        _codmaterial = ls_CodigoMaterial
        _material = ls_Material
        _idalmacen = ls_IdAlmacen
        _almacen = ls_Almacen
        _idunidadmedida = ls_IdUnidadMedida
        _unidadmedida = ls_UnidadMedida
        _cantidad = ln_Cantidad
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _tipoUnidadMedida = ld_IdTipoUnidadMedida
        _precio = ld_Precio
        _SubAlmacen = ld_IdSubAlmacen
        _cotizacionproveedor.Id = ls_IdCotizacionProveedor
        _glosa = ls_Glosa
    End Sub

#End Region

    Public Function Obtener(ByVal cotizacionDetalle As e_CotizacionDetalleMat) As e_CotizacionDetalleMat Implements Ie_CotizacionDetalleMatMat.Obtener
        Return cotizacionDetalle
    End Function

End Class


