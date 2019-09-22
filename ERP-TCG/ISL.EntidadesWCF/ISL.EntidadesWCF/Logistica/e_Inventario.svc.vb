<DataContract()> _
Public Class e_Inventario
    Implements Ie_Inventario

#Region "Propiedad"

    Private _id As String
    <DataMember()> _
    Public Activo As Boolean
    Private _cantidadinicial As Double
    Private _cantidadingreso As Double
    Private _cantidadsalida As Double
    Private _cantidadfinal As Double
    Private _valorunitario As Double
    Private _valortotal As Double
    Private _preciounitario As Double
    Private _preciototal As Double
    Private _fechacreacion As Date
    Private _ubicacion As String
    Private _stockmayor As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public IndDevolucion As Boolean = False
    <DataMember()> _
    Public IndValidar As Boolean = False
    <DataMember()> _
    Public IdRegistroInventario As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Usuario As String
    <DataMember()> _
    Public IdOrden As String = ""
    <DataMember()>
    Public oeRegistroInventario As e_RegistroInventario
    <DataMember()>
    Public PrefijoID As String = ""

    Public Property IdEmpresaSis() As String
    Public Property IdSucursal() As String

    Private _idmataterial As String
    Private _codmaterial As String
    Private _material As String
    Private _serial As String
    Private _idsubalmacen As String
    Private _idunidadmedida As String
    Private _unidadmedida As String
    Private _stockmax As String
    Private _stockmin As String
    Private _subfamilia As String
    Private _familia As String
    Private _cuenta As String

    Public Event DatoCambiado()

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
            Return _idmataterial
        End Get
        Set(ByVal value As String)
            _idmataterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Serial() As String
        Get
            Return _serial
        End Get
        Set(ByVal value As String)
            _serial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codmaterial
        End Get
        Set(ByVal value As String)
            _codmaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SubFamilia() As String
        Get
            Return _subfamilia
        End Get
        Set(ByVal value As String)
            _subfamilia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Familia() As String
        Get
            Return _familia
        End Get
        Set(ByVal value As String)
            _familia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _idunidadmedida
        End Get
        Set(ByVal value As String)
            _idunidadmedida = value
            RaiseEvent DatoCambiado()
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
    Public Property UnidadMedida() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacen() As String
        Get
            Return _idsubalmacen
        End Get
        Set(ByVal value As String)
            _idsubalmacen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadInicial() As Double
        Get
            Return _cantidadinicial
        End Get
        Set(ByVal value As Double)
            _cantidadinicial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadIngreso() As Double
        Get
            Return _cantidadingreso
        End Get
        Set(ByVal value As Double)
            _cantidadingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadSalida() As Double
        Get
            Return _cantidadsalida
        End Get
        Set(ByVal value As Double)
            _cantidadsalida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadFinal() As Double
        Get
            Return _cantidadfinal
        End Get
        Set(ByVal value As Double)
            _cantidadfinal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ValorUnitario() As Double
        Get
            Return _valorunitario
        End Get
        Set(ByVal value As Double)
            _valorunitario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ValorTotal() As Double
        Get
            Return _valortotal
        End Get
        Set(ByVal value As Double)
            _valortotal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitario() As Double
        Get
            Return _preciounitario
        End Get
        Set(ByVal value As Double)
            _preciounitario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioTotal() As Double
        Get
            Return _preciototal
        End Get
        Set(ByVal value As Double)
            _preciototal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property StockMayor() As Boolean
        Get
            Return _stockmayor
        End Get
        Set(ByVal value As Boolean)
            _stockmayor = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property StockMax() As Double
        Get
            Return _stockmax
        End Get
        Set(ByVal value As Double)
            _stockmax = value
        End Set
    End Property

    <DataMember()> _
    Public Property StockMin() As Double
        Get
            Return _stockmin
        End Get
        Set(ByVal value As Double)
            _stockmin = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _id = Cuenta
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _cantidadsalida = 0
        _cantidadinicial = 0
        _cantidadfinal = 0
        _cantidadingreso = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Material As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ls_UnidadMedida As String _
              , ByVal ls_IdSubAlmacen As String _
              , ByVal ln_CantidadInicial As Double _
              , ByVal ln_CantidadIngreso As Double _
              , ByVal ln_CantidadSalida As Double _
              , ByVal ln_CantidadFinal As Double _
              , ByVal ln_CostoUnitario As Double _
              , ByVal ln_CostoTotal As Double _
              , ByVal ln_PrecioUnitario As Double _
              , ByVal ln_PrecioTotal As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ln_StockMax As Double _
              , ByVal ln_StockMin As Double _
              , ByVal ls_Cuenta As String _
              , ByVal ls_Serial As String _
              , ByVal ls_Ubicacion As String _
              , ByVal ls_SubFamilia As String _
              , ByVal ls_Familia As String)
        _id = ls_Id
        _idmataterial = ls_IdMaterial
        _codmaterial = ls_Codigo
        _material = ls_Material
        _serial = ls_Serial
        _idsubalmacen = ls_IdSubAlmacen
        _idunidadmedida = ls_IdUnidadMedida
        _unidadmedida = ls_UnidadMedida
        _stockmax = ln_StockMax
        _stockmin = ln_StockMin
        _cantidadinicial = ln_CantidadInicial
        _cantidadingreso = ln_CantidadIngreso
        _cantidadsalida = ln_CantidadSalida
        _cantidadfinal = ln_CantidadFinal
        _valorunitario = ln_CostoUnitario
        _valortotal = ln_CostoTotal
        _preciounitario = ln_PrecioUnitario
        _preciototal = ln_PrecioTotal
        _fechacreacion = ld_FechaCreacion
        _cuenta = ls_Cuenta
        _ubicacion = ls_Ubicacion
        _subfamilia = ls_SubFamilia
        _familia = ls_Familia
    End Sub

    Public Sub New( _
             ByVal ls_Id As String _
             , ByVal ls_IdMaterial As String _
             , ByVal ls_IdSubAlmacen As String _
             , ByVal ln_CantidadFinal As Double _
             , ByVal ln_ValorUnitario As Double)
        _id = ls_Id
        _idmataterial = ls_IdMaterial
        _idsubalmacen = ls_IdSubAlmacen
        _valorunitario = ln_ValorUnitario
        _cantidadfinal = ln_CantidadFinal
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal inventario As e_Inventario) As e_Inventario Implements Ie_Inventario.Obtener
        Return inventario
    End Function

#End Region

End Class
