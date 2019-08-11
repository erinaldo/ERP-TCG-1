

<DataContract()> _
Public Class e_CategoriaOcupacion
    Implements Ie_CategoriaOcupacion

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
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

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
             )
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_CategoriaOcupacion
    ''' </summary>
    ''' <param name="categoriaOcupacion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal categoriaOcupacion As e_CategoriaOcupacion) As e_CategoriaOcupacion Implements Ie_CategoriaOcupacion.Obtener
        Return categoriaOcupacion
    End Function

#End Region

End Class


