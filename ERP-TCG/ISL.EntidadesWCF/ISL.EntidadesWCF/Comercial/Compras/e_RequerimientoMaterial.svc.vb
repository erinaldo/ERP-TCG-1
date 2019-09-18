

<DataContract()> _
Public Class e_RequerimientoMaterial
    Implements Ie_RequerimientoMaterial

#Region "Propiedad"

    Private _id As String
    Private _seleccion As Boolean

    Private _codigorequerimiento As String
    Private _codigomaterial As String
    Private _idmaterial As String
    Private _material As String
    Private _idunidadmedida As String
    Private _unidadmedida As String
    Private _tipounidadmedida As String
    Private _centrocosto As String
    Private _idcentrocosto As String
    Private _idrequerimiento As String
    Private _trabajador As String
    Private _cantidad As Double 'Cantidad requerida
    Private _precio As Double ' No manejarlo por el momento
    Private _glosa As String
    Private _idalmacen As String
    Private _almacen As String 'Al generar los requerimientos se asigna y despues al momento de atender los requerimientos se reemplaza por el idAlmacen del producto qe atendi ya que el material puede cambiar de almacen.
    Private _idSubAlmacen As String
    Private _cantidadporatender As Decimal  'Cantidad que falto atender. Solicito 5 y solo atendi 2 entonces CantporAtender es 5-2 =3
    Private _cantidadaAtender As Double
    Private _mantenimiento As String
    Private _idmantenimiento As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _idarea As String
    Private _area As String 'id de otra tabla
    Private _stockActual As Double
    Private _ubicacion As String
    Private _indicadorAprobacion As Boolean = False
    Private _idestadorequerimientomaterial As String
    Private _estadorequerimientomaterial As String
    Private _indregularizado As Boolean
    Private _cantidadporregularizar As Double
    Private _cantidadaregularizar As Double
    Private _fechaatencion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()> _
    Public FechaFinal As Date
    <DataMember()> _
    Public Tipooperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public IdMantenimientoEquipo As String
    <DataMember()> _
    Public oeSancion As New e_Sancion
    <DataMember()> _
    Public IdOrdenAsignacionMaterial As String = ""
    <DataMember()> _
    Public lstDetalleMaterialAsignacion As New List(Of e_DetalleMaterialAsignacion)
    <DataMember()> _
    Public loControlEntregaMaterial As New List(Of e_ControlEntregaMaterial)

    <DataMember()> _
    Public Property StockActual() As Double
        Get
            Return _stockActual
        End Get
        Set(ByVal value As Double)
            _stockActual = value
        End Set
    End Property

    '<DataMember()> _
    'Public Property IdTrabajadorRecepciona() As String
    '    Get
    '        Return _idtrabajadorrecepciona
    '    End Get
    '    Set(ByVal value As String)
    '        _idtrabajadorrecepciona = value
    '    End Set
    'End Property

    <DataMember()> _
    Public Property Mantenimiento() As String
        Get
            Return _mantenimiento
        End Get
        Set(ByVal value As String)
            _mantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMantenimiento() As String
        Get
            Return _idmantenimiento
        End Get
        Set(ByVal value As String)
            _idmantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacen() As String
        Get
            Return _idSubAlmacen
        End Get
        Set(ByVal value As String)
            _idSubAlmacen = value
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
    Public Property CantidadARegularizar() As Double
        Get
            Return _cantidadaregularizar
        End Get
        Set(ByVal value As Double)
            _cantidadaregularizar = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaAtencion() As String
        Get
            Return _fechaatencion
        End Get
        Set(ByVal value As String)
            _fechaatencion = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadPorRegularizar() As Double
        Get
            Return _cantidadporregularizar
        End Get
        Set(ByVal value As Double)
            _cantidadporregularizar = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndRegularizado() As Boolean
        Get
            Return _indregularizado
        End Get
        Set(ByVal value As Boolean)
            _indregularizado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstadoRequerimientoMaterial() As String
        Get
            Return _idestadorequerimientomaterial
        End Get
        Set(ByVal value As String)
            _idestadorequerimientomaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoRequerimientoMaterial() As String
        Get
            Return _estadorequerimientomaterial
        End Get
        Set(ByVal value As String)
            _estadorequerimientomaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentroCosto() As String
        Get
            Return _idcentrocosto
        End Get
        Set(ByVal value As String)
            _idcentrocosto = value
        End Set
    End Property
    <DataMember()> _
    Public Property CentroCosto() As String
        Get
            Return _centrocosto
        End Get
        Set(ByVal value As String)
            _centrocosto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

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
    Public Property UnidadMedida() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
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
    Public Property IdTipoUnidadMedida() As String
        Get
            Return _tipounidadmedida
        End Get
        Set(ByVal value As String)
            _tipounidadmedida = value
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
    Public Property IdRequerimiento() As String
        Get
            Return _idrequerimiento
        End Get
        Set(ByVal value As String)
            _idrequerimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
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
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
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
    Public Property CantidadPorAtender() As Decimal
        Get
            Return _cantidadporatender
        End Get
        Set(ByVal value As Decimal)
            _cantidadporatender = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadAAtender() As Double
        Get
            Return _cantidadaAtender
        End Get
        Set(ByVal value As Double)
            _cantidadaAtender = value
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
    Public Property CodigoRequerimiento() As String
        Get
            Return _codigorequerimiento
        End Get
        Set(ByVal value As String)
            _codigorequerimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoMaterial() As String
        Get
            Return _codigomaterial
        End Get
        Set(ByVal value As String)
            _codigomaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            _idarea = value
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndicadorAprobacion() As Boolean
        Get
            Return _indicadorAprobacion
        End Get
        Set(ByVal value As Boolean)
            _indicadorAprobacion = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        FechaAtencion = Date.Parse("01/01/1901")
    End Sub

    Public Sub New( _
              ByVal ls_Seleccion As String _
              , ByVal ls_Id As String _
              , ByVal ls_IdRequerimiento As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_Precio As Double _
              , ByVal ls_Glosa As String _
              , ByVal ls_IdAlmacen As String _
              , ByVal ln_CantidadPorAtender As Decimal _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_Material As String _
              , ByVal ls_Almacen As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ls_UnidadMedida As String _
              , ByVal ls_IdTipoUnidadMedida As String _
              , ByVal ls_IdCentroCosto As String _
              , ByVal ls_codigorequerimiento As String _
              , ByVal ls_codigomaterial As String _
              , ByVal ls_CentroCosto As String _
              , ByVal ls_IdArea As String _
              , ByVal ls_Area As String _
              , ByVal ls_IdEstadoRequerimientoMaterial As String _
              , ByVal ls_EstadoRequerimientoMaterial As String _
              , ByVal ls_StockActual As String _
             , ByVal ls_Trabajador As String _
              , ByVal ld_IdSubAlmacen As String _
              , ByVal ls_IdMantenimiento As String _
              , ByVal ls_Mantenimiento As String _
              , ByVal ls_IdMantenimientoEquipo As String _
              , ByVal lb_IndRegularizado As String _
              , ByVal ld_CantidadPorRegularizar As Double _
              , ByVal ls_Ubicacion As String)
        _seleccion = ls_Seleccion
        _id = ls_Id
        _idmaterial = ls_IdMaterial
        _idrequerimiento = ls_IdRequerimiento
        _cantidad = ln_Cantidad
        _precio = ln_Precio
        _glosa = ls_Glosa
        _idalmacen = ls_IdAlmacen
        _cantidadporatender = ln_CantidadPorAtender
        '_cantidadAAtender = ln_CantidadPorAtender
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _almacen = ls_Almacen
        _material = ls_Material
        _idunidadmedida = ls_IdUnidadMedida
        _unidadmedida = ls_UnidadMedida
        _tipounidadmedida = ls_IdTipoUnidadMedida
        _idcentrocosto = ls_IdCentroCosto
        _codigorequerimiento = ls_codigorequerimiento
        _codigomaterial = ls_codigomaterial
        _centrocosto = ls_CentroCosto
        _idarea = ls_IdArea
        _area = ls_Area
        _indicadorAprobacion = 1
        _estadorequerimientomaterial = ls_EstadoRequerimientoMaterial
        _idestadorequerimientomaterial = ls_IdEstadoRequerimientoMaterial
        _stockActual = ls_StockActual
        _trabajador = ls_Trabajador
        _idSubAlmacen = ld_IdSubAlmacen
        _idmantenimiento = ls_IdMantenimiento
        _mantenimiento = ls_Mantenimiento
        IdMantenimientoEquipo = ls_IdMantenimientoEquipo
        _cantidadporregularizar = ld_CantidadPorRegularizar
        _indregularizado = lb_IndRegularizado
        _ubicacion = ls_Ubicacion
        'CantEntOTM = ln_CantidadEntregadaOTM
    End Sub

#End Region

    Public Function Obtener(ByVal requerimientoMaterial As e_RequerimientoMaterial) As e_RequerimientoMaterial Implements Ie_RequerimientoMaterial.Obtener
        Return requerimientoMaterial
    End Function

End Class


