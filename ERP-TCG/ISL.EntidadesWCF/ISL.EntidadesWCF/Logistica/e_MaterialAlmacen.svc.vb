<DataContract()> _
Public Class e_MaterialAlmacen
    Implements Ie_MaterialAlmacen

#Region "Declaración de variables"

    Private _seleccion As Boolean

    Private _id As String

    Private _idmaterial As String
    Private _material As String
    Private _codmaterial As String
    Private _unidadmedida As String
    Private _idzona As String
    Private _zona As String
    Private _idalmacen As String
    Private _almacen As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _activo As Boolean
    Private _stockActual As Double
    Private _costounitario As Double
    Private _stockMaximo As Double
    Private _stockMinimo As Double

    Public Tipo As Integer

    <DataMember()> _
    Public TipoReferencia As String
    <DataMember()> _
    Public IdUnidad As String
    <DataMember()> _
    Public IdCentro As String

    <DataMember()> _
    Public IdsAlmacenes As String
    <DataMember()> _
    Public IdsMateriales As String
    <DataMember()> _
    Public IdSubAlmacen As String
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean = False


    Public Property IdEmpresaSis() As String
    Public Property IdSucursal() As String

#End Region

#Region "Constructor"

    Public Sub New()
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_IdAlmacen As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idmaterial = ls_IdMaterial
        _idalmacen = ls_IdAlmacen
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
    End Sub

    Public Sub New(ByVal id As String _
              , ByVal idalmacen As String _
              , ByVal almacen As String _
              , ByVal idmaterial As String _
              , ByVal activo As Boolean)
        _id = id
        _idalmacen = idalmacen
        _almacen = almacen
        _idmaterial = idmaterial
        _activo = activo
    End Sub

    Public Sub New(ByVal Seleccion As Boolean, _
                    ByVal Id As String, _
                    ByVal IdMaterial As String, _
                    ByVal CodigoMaterial As String, _
                    ByVal Material As String, _
                    ByVal NombreUnidadMedida As String, _
                    ByVal IdZona As String, _
                    ByVal Zona As String, _
                    ByVal StockActual As Double, _
                    ByVal CostoUnitario As Double, _
                    ByVal StockMinimo As Double, _
                    ByVal StockMaximo As Double, _
                    ByVal IdAlmacen As String, _
                    ByVal Almacen As String, _
                    ByVal Activo As Boolean)
        _seleccion = Seleccion
        _id = Id
        _idmaterial = IdMaterial
        _codmaterial = CodigoMaterial
        _material = Material
        _unidadmedida = NombreUnidadMedida
        _idzona = IdZona
        _zona = Zona
        _stockActual = StockActual
        _costounitario = CostoUnitario
        _stockMinimo = StockMinimo
        _stockMaximo = StockMaximo
        _idalmacen = IdAlmacen
        _almacen = Almacen
        _activo = Activo
    End Sub

#End Region

#Region "Propiedad"

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
    Public Property StockActual() As Double
        Get
            Return _stockActual
        End Get
        Set(ByVal value As Double)
            _stockActual = value
        End Set
    End Property

    <DataMember()> _
    Public Property StockMaximo() As Double
        Get
            Return _stockMaximo
        End Get
        Set(ByVal value As Double)
            _stockMaximo = value
        End Set
    End Property

    <DataMember()> _
    Public Property StockMinimo() As Double
        Get
            Return _stockMinimo
        End Get
        Set(ByVal value As Double)
            _stockMinimo = value
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
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
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
    Public Property Material() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
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
    Public Property IdZona() As String
        Get
            Return _idzona
        End Get
        Set(ByVal value As String)
            _idzona = value
        End Set
    End Property

    <DataMember()> _
    Public Property Zona() As String
        Get
            Return _zona
        End Get
        Set(ByVal value As String)
            _zona = value
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
    Public Property CostoUnitario() As Double
        Get
            Return _costounitario
        End Get
        Set(ByVal value As Double)
            _costounitario = value
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

    Public Function Obtener(ByVal materialAlmacen As e_MaterialAlmacen) As e_MaterialAlmacen Implements Ie_MaterialAlmacen.Obtener
        Return materialAlmacen
    End Function

End Class
