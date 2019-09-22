

<DataContract()> _
Public Class e_GuiaRRemitenteMaterial
    Implements Ie_GuiaRRemitenteMaterial

#Region "Propiedad"

    Private _id As String
    Private _GRemision As String
    Private _CantidadMaterial As Decimal
    Private _idmaterial As String
    Private _codmaterial As String
    Private _material As String
    Private _idUnidadMedida As String
    Private _UnidadMedida As String
    Private _idtipoUnidadMedida As String
    Private _idalmacen As String
    Private _almacen As String
    Private _idsubalmacen As String
    Private _peso As Double
    Private _glosa As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date = #1/1/1901#
    Private _Seleccion As Boolean
    Private _OrdenTrabajoMaterial As String
    Private _Pos As String = ""

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdGuiaRemision() As String
        Get
            Return _GRemision
        End Get
        Set(ByVal value As String)
            _GRemision = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
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
    Public Property CantidadMaterial() As Decimal
        Get
            Return _CantidadMaterial
        End Get
        Set(ByVal value As Decimal)
            _CantidadMaterial = value
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
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _idUnidadMedida
        End Get
        Set(ByVal value As String)
            _idUnidadMedida = value
            RaiseEvent DatoCambiado()
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
    Public Property CodigoMaterial() As String
        Get
            Return _codmaterial
        End Get
        Set(ByVal value As String)
            _codmaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Peso() As Double
        Get
            Return _peso
        End Get
        Set(ByVal value As Double)
            _peso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
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
    Public Property IdTipoUnidadMedida() As String
        Get
            Return _idtipoUnidadMedida
        End Get
        Set(ByVal value As String)
            _idtipoUnidadMedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property Pos() As String
        Get
            Return _Pos
        End Get
        Set(ByVal value As String)
            _Pos = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
                ByVal ls_Seleccion As String _
              , ByVal ls_Id As String _
              , ByVal ls_IdGuiaRemision As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_CodMaterial As String _
              , ByVal ls_Material As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ls_UnidadMedida As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_Peso As Double _
              , ByVal ls_Glosa As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_idTipoUnidad As String _
              , ByVal ls_idAlmacen As String _
              , ByVal ls_Almacen As String _
              , ByVal ls_idSubAlmacen As String)
        _Seleccion = ls_Seleccion
        _id = ls_Id
        _GRemision = ls_IdGuiaRemision
        _idmaterial = ls_IdMaterial
        _codmaterial = ls_CodMaterial
        _material = ls_Material
        _idUnidadMedida = ls_IdUnidadMedida
        _UnidadMedida = ls_UnidadMedida
        _CantidadMaterial = ln_Cantidad
        _peso = ln_Peso
        _glosa = ls_Glosa
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _idtipoUnidadMedida = ls_idTipoUnidad
        _idsubalmacen = ls_idSubAlmacen
        _idalmacen = ls_idAlmacen
        _almacen = ls_Almacen
    End Sub

#End Region

    Public Function Obtener(ByVal guiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As e_GuiaRRemitenteMaterial Implements Ie_GuiaRRemitenteMaterial.Obtener
        Return guiaRRemitenteMaterial
    End Function

End Class


