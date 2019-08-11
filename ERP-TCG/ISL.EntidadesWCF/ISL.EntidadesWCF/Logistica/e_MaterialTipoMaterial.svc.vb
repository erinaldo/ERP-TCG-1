<DataContract()> _
Public Class e_MaterialTipoMaterial
    Implements Ie_MaterialTipoMaterial

#Region "Declaración de variables"

    Private _Id As String
    Private _idMaterial As String
    Private _Material As String
    Private _TipoMaterial As String
    Private _idTipoMaterial As String
    Private _Activo As Boolean
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal Id As String, ByVal Nombre As String)
        'MovimientoInventario.Id = Id
        'MovimientoInventario.Nombre = Nombre
    End Sub

    Sub New(ByVal Id As String, ByVal IdTipoMaterial As String, ByVal TipoMaterial As String, _
            ByVal IdMaterial As String, ByVal Material As String, ByVal Activo As Boolean)
        _Id = Id
        _idTipoMaterial = IdTipoMaterial
        _TipoMaterial = TipoMaterial
        _idMaterial = IdMaterial
        _Material = Material
        _Activo = Activo
    End Sub

#End Region

#Region "Propiedades"

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
    Public Property IdTipoMaterial() As String
        Get
            Return _idTipoMaterial
        End Get
        Set(ByVal value As String)
            _idTipoMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMaterial() As String
        Get
            Return _TipoMaterial
        End Get
        Set(ByVal value As String)
            _Material = value
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
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal materialTipoMaterial As e_MaterialTipoMaterial) As e_MaterialTipoMaterial Implements Ie_MaterialTipoMaterial.Obtener
        Return materialTipoMaterial
    End Function

End Class
