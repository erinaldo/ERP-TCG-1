<DataContract()> _
Public Class e_FamiliaMaterial
    Implements Ie_FamiliaMaterial

#Region "Declaración de variables"
    Private _Id As String
    Private _Codigo As String = String.Empty
    Private _Nombre As String
    Private _Activo As Boolean
    <DataMember()> _
    Public Modificado As Boolean = False
    Private _TipoMaterial As New e_TipoMaterial
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public UsuarioCreacion As String
#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Sub New(ByVal Id As String, _
            ByVal Codigo As String, _
            ByVal Nombre As String, _
            ByVal Activo As Boolean, _
            ByVal IdTipoMaterial As String, _
            ByVal TipoMaterial As String)
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Activo = Activo
        _TipoMaterial.Id = IdTipoMaterial
        _TipoMaterial.Nombre = TipoMaterial
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
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
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
    Public Property IdTipoMaterial() As String
        Get
            Return _TipoMaterial.Id
        End Get
        Set(ByVal value As String)
            _TipoMaterial.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMaterial() As String
        Get
            Return _TipoMaterial.Nombre
        End Get
        Set(ByVal value As String)
            _TipoMaterial.Nombre = value
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal familiaMaterial As e_FamiliaMaterial) As e_FamiliaMaterial Implements Ie_FamiliaMaterial.Obtener
        Return familiaMaterial
    End Function

End Class
