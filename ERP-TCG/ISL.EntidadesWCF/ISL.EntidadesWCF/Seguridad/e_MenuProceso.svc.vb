
''' <summary>
''' Clase: Menú Proceso
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_MenuProceso
    Implements Ie_MenuProceso

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _activo As Boolean
    Private _explorador As Boolean
    Private _protegido As Boolean
    Private _orden As Integer
    Private _fechacreacion As DateTime
    Private _usuariocreacion As String

    <DataMember()> _
    Public leMenuGrupo As New List(Of e_MenuGrupo)
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
#End Region

#Region "Propiedad"

    ''' <summary>
    ''' Id Proceso
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    ''' <summary>
    ''' Codigo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    ''' <summary>
    ''' Abreviatura
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
        End Set
    End Property


    ''' <summary>
    ''' Porteccion al Proceso
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Protegido() As Boolean
        Get
            Return _protegido
        End Get
        Set(ByVal value As Boolean)
            _protegido = value
        End Set
    End Property

    <DataMember()> _
    Public Property Explorador() As Boolean
        Get
            Return _explorador
        End Get
        Set(ByVal value As Boolean)
            _explorador = value
        End Set
    End Property

    ''' <summary>
    ''' Orden de Proceso
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Orden() As Integer
        Get
            Return _orden
        End Get
        Set(ByVal value As Integer)
            _orden = value
        End Set
    End Property

    ''' <summary>
    ''' Activo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
        _protegido = False
        _explorador = False
        _orden = 0
        _activo = True
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
    End Sub

    Public Sub New( _
              ByVal Id As String _
              , ByVal Codigo As String _
              , ByVal Nombre As String _
              , ByVal Abreviatura As String _
              , ByVal Protegido As Boolean _
              , ByVal Explorador As Boolean _
              , ByVal Orden As Integer _
            , ByVal Activo As Boolean _
            , ByVal UsuarioCreacion As String _
           )
        _id = Id
        _codigo = Codigo
        _nombre = Nombre
        _abreviatura = Abreviatura
        _protegido = Protegido
        _explorador = Explorador
        _orden = Orden
        _activo = Activo
        _usuariocreacion = UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_MenuProceso
    ''' </summary>
    ''' <param name="menuProceso"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal menuProceso As e_MenuProceso) As e_MenuProceso Implements Ie_MenuProceso.Obtener
        Return menuProceso
    End Function

#End Region

End Class
