
<DataContract()> _
Public Class e_MenuItem
    Implements Ie_MenuItem

#Region "Propiedad"

    Private _id As String
    Private _idmenugrupo As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _activo As Boolean
    Private _orden As Integer
    Private _protegido As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdMenuGrupo() As String
        Get
            Return _idmenugrupo
        End Get
        Set(ByVal value As String)
            _idmenugrupo = value
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
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
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
    Public Property Orden() As Integer
        Get
            Return _orden
        End Get
        Set(ByVal value As Integer)
            _orden = value
        End Set
    End Property

    <DataMember()> _
    Public Property Protegido() As Boolean
        Get
            Return _protegido
        End Get
        Set(ByVal value As Boolean)
            _protegido = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        _id = ""
        _codigo = ""
        _nombre = ""
        _abreviatura = ""
        _activo = True
        _orden = 0
        _protegido = False
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMenuGrupo As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ln_Orden As Integer _
              , ByVal lb_Protegido As Boolean _
           )
        _id = ls_Id
        _idmenugrupo = ls_IdMenuGrupo
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _activo = lb_Activo
        _orden = ln_Orden
        _protegido = lb_Protegido
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_MenuItem
    ''' </summary>
    ''' <param name="menuItem"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal menuItem As e_MenuItem) As e_MenuItem Implements Ie_MenuItem.Obtener
        Return menuItem
    End Function

#End Region

End Class
