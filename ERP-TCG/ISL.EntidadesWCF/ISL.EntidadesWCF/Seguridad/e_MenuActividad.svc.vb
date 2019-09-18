
<DataContract()> _
Public Class e_MenuActividad
    Implements Ie_MenuActividad

#Region "Declaracion de Variables"

    Private _id As String
    Private _idactividadnegocio As String
    Private _idprocesonegocio As String
    Private _idmenugrupo As String
    Private _menugrupo As String
    Private _idmenuproceso As String
    Private _idmenuitem As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _orden As Integer
    Private _protegido As Boolean
    Private _explorer As Boolean
    Private _imagen As String
    Private _tamano As Boolean
    Private _texto As Boolean
    Private _formulario As String
    Private _form As String
    Private _menu As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public Padre As String
    <DataMember()> _
    Public NombrePadre As String
    <DataMember()> _
    Public MultiInstancia As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leSubMenu As New List(Of e_MenuActividad)
    <DataMember()>
    Public PrefijoID As String = ""
    Private _menuproceso As String

#End Region

#Region "Propiedad"


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
    Public Property IdActividadNegocio() As String
        Get
            Return _idactividadnegocio
        End Get
        Set(ByVal value As String)
            _idactividadnegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property MenuProceso() As String
        Get
            Return _menuproceso
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <DataMember()> _
    Public Property IdProcesoNegocio() As String
        Get
            Return _idprocesonegocio
        End Get
        Set(ByVal value As String)
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
    Public Property MenuGrupo() As String
        Get
            Return _menugrupo
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <DataMember()> _
    Public Property IdMenuProceso() As String
        Get
            Return _idmenuproceso
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <DataMember()> _
    Public Property IdMenuItem() As String
        Get
            Return _idmenuitem
        End Get
        Set(ByVal value As String)
            _idmenuitem = value
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

    <DataMember()> _
    Public Property Explorer() As Boolean
        Get
            Return _explorer
        End Get
        Set(ByVal value As Boolean)
            _explorer = value
        End Set
    End Property

    <DataMember()> _
    Public Property Imagen() As String
        Get
            Return _imagen
        End Get
        Set(ByVal value As String)
            _imagen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tamano() As Boolean
        Get
            Return _tamano
        End Get
        Set(ByVal value As Boolean)
            _tamano = value
        End Set
    End Property

    <DataMember()> _
    Public Property Texto() As Boolean
        Get
            Return _texto
        End Get
        Set(ByVal value As Boolean)
            _texto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Formulario() As String
        Get
            Return _formulario
        End Get
        Set(ByVal value As String)
            _formulario = value
        End Set
    End Property

    <DataMember()> _
    Public Property Form() As String
        Get
            Return _form
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <DataMember()> _
    Public Property Menu() As Integer
        Get
            Return _menu
        End Get
        Set(ByVal value As Integer)
            _menu = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As String
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As String)
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _codigo = ""
        _nombre = ""
        _abreviatura = ""
        _idmenuitem = ""
        _menu = 0
        _activo = True
        _protegido = False
        _orden = 0
        _explorer = False
        _tamano = False
        _texto = True
        _imagen = ""
        _formulario = ""
        _form = ""
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _menuproceso = ""
        TipoOperacion = ""

    End Sub

    Public Sub New( _
              ByVal Id As String _
              , ByVal IdActividadNegocio As String _
              , ByVal MenuProceso As String _
              , ByVal IdProcesoNegocio As String _
              , ByVal IdMenuGrupo As String _
              , ByVal MenuGrupo As String _
              , ByVal IdMenuProceso As String _
              , ByVal Codigo As String _
              , ByVal Nombre As String _
              , ByVal Abreviatura As String _
              , ByVal Orden As Integer _
              , ByVal Protegido As Boolean _
              , ByVal Explorer As Boolean _
              , ByVal Imagen As String _
              , ByVal Tamano As Boolean _
              , ByVal Texto As Boolean _
              , ByVal Formulario As String _
              , ByVal Form As String _
              , ByVal Menu As Integer _
              , ByVal IdMenuItem As String _
              , ByVal lsPadre As String _
              , ByVal lsNombrePadre As String _
              , ByVal lsMultiInstancia As String _
              , ByVal UsuarioCreacion As String _
              , ByVal Activo As Boolean _
           )
        _id = Id
        _idactividadnegocio = IdActividadNegocio
        _menuproceso = MenuProceso
        _idprocesonegocio = IdProcesoNegocio
        _idmenugrupo = IdMenuGrupo
        _menugrupo = MenuGrupo
        _idmenuproceso = IdMenuProceso
        _codigo = Codigo
        _nombre = Nombre
        _abreviatura = Abreviatura
        _orden = Orden
        _protegido = Protegido
        _explorer = Explorer
        _imagen = Imagen
        _tamano = Tamano
        _texto = Texto
        _formulario = Formulario
        _menu = Menu
        _idmenuitem = IdMenuItem
        Padre = lsPadre
        NombrePadre = lsNombrePadre
        MultiInstancia = lsMultiInstancia
        _usuariocreacion = UsuarioCreacion
        _activo = Activo
        _form = Form
    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_MenuActividad
    ''' </summary>
    ''' <param name="menuActividad"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal menuActividad As e_MenuActividad) As e_MenuActividad Implements Ie_MenuActividad.Obtener
        Return menuActividad
    End Function

#End Region

End Class
