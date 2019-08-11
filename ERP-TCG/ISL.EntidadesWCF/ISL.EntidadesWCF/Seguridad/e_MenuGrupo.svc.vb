
<DataContract()> _
Public Class e_MenuGrupo
    Implements Ie_MenuGrupo

#Region "Declaración de variables"

    Private _id As String
    Private _idmenuproceso As String ' New e_MenuProceso
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _activo As Boolean
    Private _orden As Integer
    Private _protegido As Integer
    Private _fechacreacion As DateTime
    Private _usuariocreacion As String
    Private _menuproceso As String

    <DataMember()> _
    Public leMenuActividad As New List(Of e_MenuActividad)
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

#End Region

#Region "Propiedades"

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
    Public Property IdMenuProceso() As String
        Get
            Return _idmenuproceso
        End Get
        Set(ByVal value As String)
            _idmenuproceso = value
        End Set
    End Property

    <DataMember()> _
    Public Property Menuproceso() As String
        Get
            Return _menuproceso
        End Get
        Set(ByVal value As String)
            _menuproceso = value
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
    Public Property Protegido() As Integer
        Get
            Return _protegido
        End Get
        Set(ByVal value As Integer)
            _protegido = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As DateTime
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As DateTime)
            _fechacreacion = value
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
        _id = ""
        _codigo = ""
        _nombre = ""
        _abreviatura = ""
        _activo = True
        _orden = 0
        _protegido = -1
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
    End Sub

    Public Sub New( _
              ByVal Id As String _
              , ByVal IdMenuProceso As String _
              , ByVal MenuProceso As String _
              , ByVal Codigo As String _
              , ByVal Nombre As String _
              , ByVal Abreviatura As String _
              , ByVal Orden As Integer _
              , ByVal Protegido As Boolean _
               , ByVal Activo As Boolean _
              , ByVal UsuarioCreacion As String _
           )
        _id = Id
        _idmenuproceso = IdMenuProceso
        _menuproceso = MenuProceso
        _codigo = Codigo
        _nombre = Nombre
        _abreviatura = Abreviatura
        _orden = Orden
        _protegido = IIf(Protegido, 1, 0)
        _activo = Activo
        _usuariocreacion = UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_MenuGrupo
    ''' </summary>
    ''' <param name="menuGrupo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal menuGrupo As e_MenuGrupo) As e_MenuGrupo Implements Ie_MenuGrupo.Obtener
        Return menuGrupo
    End Function

#End Region

End Class
