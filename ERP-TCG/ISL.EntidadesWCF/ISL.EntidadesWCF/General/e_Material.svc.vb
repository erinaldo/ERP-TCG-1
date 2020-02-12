''' <summary>
''' Clase para definir la entidad: Material
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Material
    Implements Ie_Material
    Implements IPropiedadesBasicas
    Implements IEquatable(Of e_Material)

#Region "Declaración de variables"

    Private _Seleccion As Boolean
    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _codigonombre As String
    Private _idtipomaterial As String
    Private _tipomaterial As String
    Private _idsubfamilia As String
    Private _subfamilia As String
    Private _idfamilia As String
    Private _familia As String
    Private _idunidadmedida As String
    Private _unidadmedida As String
    Private _idtipounidadmedida As String
    Private _tipounidadmedida As String
    Private _medida As String
    Private _peso As Double
    Private _serial As String
    Private _afectoigv As Boolean
    Private _glosa As String
    Private _activo As Boolean
    Private _precio As Double
    Private _stock As Double
    Private _ubicacion As String
    Private _idsubalmacen As String
    Private _subalmacen As String
    Private _idalmacen As String
    Private _almacen As String
    Private _descripcion As String
    Private _inddivisible As Boolean
    Private _indActivoFjo As Integer
    <DataMember()> _
    Public IdItemGasto As String
    <DataMember()> _
    Public IdCentro As String

    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()> _
    Public ListaMaterialCuentaContable As New List(Of e_MaterialCuentaContable)

    '<DataMember()>
    'Public Property PrecioMaterial() As Double

    <DataMember()> _
    Public ListaCodigoBarras As New List(Of e_CodigoBarraMaterial)

    <DataMember()> _
    Public ListaCaracteristicaMaterial As New List(Of e_CaracteristicaMaterial)

    <DataMember()> _
    Public ListaAlmacenesAsignados As New List(Of e_MaterialAlmacen)

    <DataMember()> _
    Public IndAsignar As Boolean = 0

    <DataMember()> _
    Public oeMaterial_DisenoNeu As New e_Material_DisenoNeu
    <DataMember()> _
    Public Tipo As Integer = 0

#End Region

#Region "Constructor"

    Sub New()
        Activo = True
        Tipo = 0
        IdCentro = ""
        _indActivoFjo = 0
    End Sub

    Sub New(ByVal lb_seleccion As Boolean, _
        ByVal ls_IdMaterial As String, _
        ByVal ls_Codigo As String, _
        ByVal ls_Material As String, _
        ByVal ls_IdUnidadMedida As String, _
        ByVal ls_UnidadMedida As String, _
        ByVal ls_IdSubAlmacen As String, _
        ByVal ls_SubAlmacen As String, _
        ByVal ls_IdAlmacen As String, _
        ByVal ls_Almacen As String, _
        ByVal ln_Precio As Double, _
        ByVal ln_Stock As Double, _
        ByVal ls_IdTipoUnidadMedida As String, _
        ByVal ls_TipoUnidadMedida As String)
        _Seleccion = lb_seleccion
        _id = ls_IdMaterial
        _codigo = ls_Codigo
        _nombre = ls_Material
        _idunidadmedida = ls_IdUnidadMedida
        _unidadmedida = ls_UnidadMedida
        _idsubalmacen = ls_IdSubAlmacen
        _descripcion = ls_SubAlmacen
        _idalmacen = ls_IdAlmacen
        _almacen = ls_Almacen
        _precio = ln_Precio
        _stock = ln_Stock
        _idtipounidadmedida = ls_IdTipoUnidadMedida
        _tipounidadmedida = ls_TipoUnidadMedida
        _codigonombre = ls_Material & " - " & " [ " & Trim(ls_Codigo) & " ]"
    End Sub

    Public Sub New(ByVal ls_seleccion As Boolean,
                  ByVal ls_id As String,
                  ByVal ls_codigo As String,
                  ByVal ls_nombre As String,
                 ByVal ls_idunidadmedida As String,
                  ByVal ls_unidadMedida As String,
                  ByVal ls_nombresubfamilia As String,
                   ByVal ln_Precio As Double,
                   ByVal ln_Peso As Double,
                   ByVal ln_Stock As Double,
                  ByVal ls_activo As String)

        _Seleccion = ls_seleccion
        _id = ls_id
        _codigo = ls_codigo
        _nombre = ls_nombre
        _idunidadmedida = ls_idunidadmedida
        _unidadmedida = ls_unidadMedida
        _subfamilia = ls_nombresubfamilia
        _peso = ln_Peso
        _stock = ln_Stock
        _activo = ls_activo
        _precio = ln_Precio
    End Sub

    Sub New(ByVal Seleccion As Boolean, _
            ByVal Id As String, _
            ByVal Codigo As String, _
            ByVal Nombre As String, _
            ByVal IdTipoMaterial As String, _
            ByVal TipoMaterial As String, _
            ByVal IdFamilia As String, _
            ByVal Familia As String, _
            ByVal IdSubFamilia As String, _
            ByVal SubFamilia As String, _
            ByVal IdTipoUnidadMedida As String, _
            ByVal TipoUnidadMedida As String, _
            ByVal IdUnidadMedida As String, _
            ByVal UnidadMedida As String, _
            ByVal Medida As String, _
            ByVal Peso As Decimal, _
            ByVal Serial As String, _
            ByVal AfectoIgv As Boolean, _
            ByVal Glosa As String, _
            ByVal IdAlmacen As String, _
            ByVal Almacen As String, _
            ByVal Activo As Boolean, _
            ByVal ln_Precio As Double, _
            ByVal ln_Stock As Double, _
            ByVal ls_IdItemGasto As String, _
            ByVal ls_IdSubAlmacen As String, _
            ByVal ls_SubAlmacen As String, _
            ByVal ls_Ubicacion As String, _
            ByVal lb_IndDivisible As Boolean, _
            ByVal li_IndActivoFijo As Integer)

        _Seleccion = Seleccion
        _id = Id
        _codigo = Codigo
        _nombre = Nombre
        _idtipomaterial = IdTipoMaterial
        _tipomaterial = TipoMaterial
        _idfamilia = IdFamilia
        _familia = Familia
        _idsubfamilia = IdSubFamilia
        _subfamilia = SubFamilia
        _idtipounidadmedida = IdTipoUnidadMedida
        _tipounidadmedida = TipoUnidadMedida
        _idunidadmedida = IdUnidadMedida
        _unidadmedida = UnidadMedida
        _medida = Medida
        _peso = Peso
        _serial = Serial
        _afectoigv = AfectoIgv
        _glosa = Glosa
        _idalmacen = IdAlmacen
        _almacen = Almacen
        _activo = Activo
        _codigonombre = Nombre & " - " & " [ " & Trim(Codigo) & " ]"  'Codigo & " : " & Nombre
        _precio = ln_Precio
        _stock = ln_Stock
        IdItemGasto = ls_IdItemGasto
        _idsubalmacen = ls_IdSubAlmacen
        _descripcion = ls_SubAlmacen
        _ubicacion = ls_Ubicacion
        _inddivisible = lb_IndDivisible
        _indActivoFjo = li_IndActivoFijo
    End Sub

    Sub New(ByVal Seleccion As Boolean, _
            ByVal Id As String, _
            ByVal Codigo As String, _
            ByVal Nombre As String, _
            ByVal IdTipoUnidadMedida As String, _
            ByVal TipoUnidadMedida As String, _
            ByVal IdUnidadMedida As String, _
            ByVal UnidadMedida As String, _
            ByVal Medida As String, _
            ByVal Peso As Decimal, _
            ByVal Serial As String, _
            ByVal AfectoIgv As Boolean, _
            ByVal Glosa As String, _
            ByVal IdAlmacen As String, _
            ByVal Almacen As String, _
            ByVal IdSubAlmacen As String, _
            ByVal Activo As Boolean, _
            ByVal ln_Precio As Double, _
            ByVal ln_Stock As Double)

        _Seleccion = Seleccion
        _id = Id
        _codigo = Codigo
        _nombre = Nombre
        _idtipounidadmedida = IdTipoUnidadMedida
        _tipounidadmedida = TipoUnidadMedida
        _idunidadmedida = IdUnidadMedida
        _unidadmedida = UnidadMedida
        _medida = Medida
        _peso = Peso
        _serial = Serial
        _afectoigv = AfectoIgv
        _glosa = Glosa
        _idalmacen = IdAlmacen
        _almacen = Almacen
        _idsubalmacen = IdSubAlmacen
        _activo = Activo
        _codigonombre = Nombre & " - " & " [ " & Trim(Codigo) & " ]" 'Codigo & " : " & Nombre
        _precio = ln_Precio
        _stock = ln_Stock

    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndDivisible() As Boolean
        Get
            Return _inddivisible
        End Get
        Set(ByVal value As Boolean)
            _inddivisible = value
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
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoNombre() As String
        Get
            Return _codigonombre
        End Get
        Set(ByVal value As String)
            _codigonombre = value
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
    Public Property IdTipoMaterial() As String
        Get
            Return _idtipomaterial
        End Get
        Set(ByVal value As String)
            _idtipomaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMaterial() As String
        Get
            Return _tipomaterial
        End Get
        Set(ByVal value As String)
            _tipomaterial = value
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
    Public Property Familia() As String
        Get
            Return _familia
        End Get
        Set(ByVal value As String)
            _familia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubFamilia() As String
        Get
            Return _idsubfamilia
        End Get
        Set(ByVal value As String)
            _idsubfamilia = value
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
    Public Property IdTipoUnidadMedida() As String
        Get
            Return _idtipounidadmedida
        End Get
        Set(ByVal value As String)
            _idtipounidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoUnidadMedida() As String
        Get
            Return _tipounidadmedida
        End Get
        Set(ByVal value As String)
            _tipounidadmedida = value
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
    Public Property Medida() As String
        Get
            Return _medida
        End Get
        Set(ByVal value As String)
            _medida = value
        End Set
    End Property

    <DataMember()>
    Public Property Peso() As Double
        Get
            Return _peso
        End Get
        Set(ByVal value As Double)
            _peso = value
        End Set
    End Property

    <DataMember()> _
    Public Property Serial() As String
        Get
            Return _serial
        End Get
        Set(ByVal value As String)
            _serial = value
        End Set
    End Property

    <DataMember()> _
    Public Property AfectoIgv() As Boolean
        Get
            Return _afectoigv
        End Get
        Set(ByVal value As Boolean)
            _afectoigv = value
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
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacen() As String
        Get
            Return _idsubalmacen
        End Get
        Set(ByVal value As String)
            _idsubalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubAlmacen() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
    Public Property IdAlmacen() As String
        Get
            Return _idalmacen
        End Get
        Set(ByVal value As String)
            _idalmacen = value
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
    Public Property Stock() As Double
        Get
            Return _stock
        End Get
        Set(ByVal value As Double)
            _stock = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndActivoFijo() As Integer
        Get
            Return _indActivoFjo
        End Get
        Set(ByVal value As Integer)
            _indActivoFjo = value
        End Set
    End Property
#End Region

#Region "Métodos"

    Public Function Obtener(ByVal material As e_Material) As e_Material Implements Ie_Material.Obtener
        Return material
    End Function

    Public Overloads Function Equals(ByVal oeMat As e_Material) As Boolean Implements System.IEquatable(Of e_Material).Equals
        If Me.Id = oeMat.Id Then Return True
        Return False
    End Function

#End Region

End Class


