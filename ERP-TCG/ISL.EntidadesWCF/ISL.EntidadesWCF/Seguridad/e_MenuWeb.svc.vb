
<DataContract()> _
Public Class e_MenuWeb
    Implements Ie_MenuWeb

#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal idMenu As String, ByVal titulo As String, ByVal parentId As String, ByVal uRL As String, ByVal activo As Boolean, ByVal descripcion As String, ByVal esReporte As Boolean, ByVal protegido As Boolean)
        _idmenu = idMenu
        _titulo = titulo
        _parentid = parentId
        _url = uRL
        _activo = activo
        _descripcion = descripcion
        _esReporte = esReporte
        _protegido = protegido
    End Sub

#End Region

#Region "Propiedades"

    Private _idmenu As String
    <DataMember()> _
    Public Property IdMenu() As String
        Get
            Return _idmenu
        End Get
        Set(ByVal value As String)
            _idmenu = value
        End Set
    End Property

    Private _titulo As String
    <DataMember()> _
    Public Property Titulo() As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
        End Set
    End Property

    Private _parentid As String
    <DataMember()> _
    Public Property ParentId() As String
        Get
            Return _parentid
        End Get
        Set(ByVal value As String)
            _parentid = value
        End Set
    End Property

    Private _url As String
    <DataMember()> _
    Public Property URL() As String
        Get
            Return _url
        End Get
        Set(ByVal value As String)
            _url = value
        End Set
    End Property

    Private _activo As Boolean
    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    Private _descripcion As String
    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _esReporte As Boolean
    <DataMember()> _
    Public Property EsReporte() As Boolean
        Get
            Return _esReporte
        End Get
        Set(ByVal value As Boolean)
            _esReporte = value
        End Set
    End Property

    Private _protegido As Boolean
    <DataMember()> _
    Public Property Protegido() As Boolean
        Get
            Return _protegido
        End Get
        Set(ByVal value As Boolean)
            _protegido = value
        End Set
    End Property


    Private _tipoOperacion As String
    <DataMember()> _
    Public Property TipoOperacion() As String
        Get
            Return _tipoOperacion
        End Get
        Set(ByVal value As String)
            _tipoOperacion = value
        End Set
    End Property


#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_MenuWeb
    ''' </summary>
    ''' <param name="menuWeb"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal menuWeb As e_MenuWeb) As e_MenuWeb Implements Ie_MenuWeb.Obtener
        Return menuWeb
    End Function

#End Region

End Class
