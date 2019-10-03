<DataContract()> _
Public Class e_MantenimientoMaterial
    Implements Ie_MantenimientoMaterial

#Region "Propiedad"
    Private _seleccion As Boolean
    Private _id As String
    Private _mantenimiento As String
    Private _idmaterial As String
    Private _material As String
    Private _codmaterial As String
    Private _codnombre As String
    Private _idalmacen As String
    Private _idfamilia As String
    Private _idSubfamilia As String
    Private _idSubalmacen As String
    Private _preciomat As Double
    Private _stockmat As Double
    Private _cantidad As Double
    Private _idunidadmedida As String
    Private _unidadmedida As String
    Private _idtipounidadmedida As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _precio As Double

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""

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
    Public Property IdMantenimiento() As String
        Get
            Return _mantenimiento
        End Get
        Set(ByVal value As String)
            _mantenimiento = value
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
    Public Property Codigo() As String
        Get
            Return _codmaterial
        End Get
        Set(ByVal value As String)
            _codmaterial = value
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
    Public Property Stock() As Double
        Get
            Return _stockmat
        End Get
        Set(ByVal value As Double)
            _stockmat = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubFamilia() As String
        Get
            Return _idSubfamilia
        End Get
        Set(ByVal value As String)
            _idSubfamilia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdFamilia() As String
        Get
            Return _idfamilia
        End Get
        Set(ByVal value As String)
            _idfamilia = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoNombreMaterial() As String
        Get
            Return _codnombre
        End Get
        Set(ByVal value As String)
            _codnombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoUnidadMedida() As String
        Get
            Return _idtipounidadmedida
        End Get
        Set(ByVal value As String)
            _idtipounidadmedida = value
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
    Public Property IdAlmacen() As String
        Get
            Return _idalmacen
        End Get
        Set(ByVal value As String)
            _idalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacen() As String
        Get
            Return _idSubalmacen
        End Get
        Set(ByVal value As String)
            _idSubalmacen = value
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

#End Region

#Region "Constructor"
    Public Sub New()
    End Sub


    Public Sub New(ByVal lb_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_IdMantenimiento As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Material As String _
              , ByVal ls_IdTipoUnidadMedida As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ls_UnidadMedida As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ls_IdSubAlmacen As String _
              , ByVal ls_IdAlmacen As String _
              , ByVal ld_Precio As Double _
              , ByVal ld_Stock As Double _
              , ByVal ls_IdSubFamilia As String _
              , ByVal ls_IdFamilia As String _
           )
        _id = ls_Id
        _mantenimiento = ls_IdMantenimiento
        _idmaterial = ls_IdMaterial
        _codmaterial = ls_Codigo
        _material = ls_Material
        _idSubfamilia = ls_IdSubFamilia
        _idfamilia = ls_IdFamilia
        _idtipounidadmedida = ls_IdTipoUnidadMedida
        _idunidadmedida = ls_IdUnidadMedida
        _unidadmedida = ls_UnidadMedida
        _cantidad = ln_Cantidad
        _precio = ld_Precio
        _idalmacen = ls_IdAlmacen
        _idSubalmacen = ls_IdSubAlmacen
        _preciomat = ld_Precio
        _stockmat = ld_Stock
        _codnombre = ls_Codigo + " : " + ls_Material
        _seleccion = lb_Seleccion
    End Sub

#End Region

    Public Function Obtener(ByVal mantenimientoMaterial As e_MantenimientoMaterial) As e_MantenimientoMaterial Implements Ie_MantenimientoMaterial.Obtener
        Return mantenimientoMaterial
    End Function

End Class
