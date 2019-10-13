''' <summary>
''' Clase para definir la entidad: Servicio
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Servicio
    Implements Ie_Servicio
    Implements IPropiedadesBasicas

#Region "Propiedades"

    Private _seleccion As Boolean
    Private _id As String
    Private _idcategoriaservicio As String
    Private _categoriaservicio As String
    <DataMember()> _
    Public IdItemGasto As String
    Private _codigo As String = ""
    Private _nombre As String
    Private _precio As Double
    Private _descripcion As String
    Private _activo As Boolean
    Private _usuariocreacion As String

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

    <DataMember()>
    Public ListaServicioCuentaContable As New List(Of e_ServicioCuentaContable)
    '-------------------------------------------
    Private _idunidadmedida As String
    Private _unidadmedida As String

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
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCategoriaServicio() As String
        Get
            Return _idcategoriaservicio
        End Get
        Set(ByVal value As String)
            _idcategoriaservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property CategoriaServicio() As String
        Get
            Return _categoriaservicio
        End Get
        Set(ByVal value As String)
            _categoriaservicio = value
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
    Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_IdCategoriaServicio As String _
              , ByVal ls_CategoriaServicio As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ln_Precio As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdTipoUnidadMedida As String _
              , ByVal ls_TipoUnidadMedida As String _
              , ByVal ls_Descripcion As String _
              , ByVal ls_ItemGasto As String _
                   )
        _seleccion = lb_Seleccion
        _id = ls_Id
        _idcategoriaservicio = ls_IdCategoriaServicio
        _categoriaservicio = ls_CategoriaServicio
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _precio = ln_Precio
        _activo = lb_Activo
        _idunidadmedida = ls_IdTipoUnidadMedida
        _unidadmedida = ls_TipoUnidadMedida
        _descripcion = ls_Descripcion
        IdItemGasto = ls_ItemGasto
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal servicio As e_Servicio) As e_Servicio Implements Ie_Servicio.Obtener
        Return servicio
    End Function

#End Region

End Class


