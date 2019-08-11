<DataContract()> _
Public Class e_ConfiguracionTabla
    Implements Ie_ConfiguracionTabla

#Region "Declaracion de Variables"

    Private _id As String
    Private _esquema As String
    Private _codigo As String
    Private _nombre As String
    Private _descripcion As String
    Private _maestra As Integer
    Private _limpiar As Integer
    Private _insertar As Integer
    Private _actualizar As Integer
    Private _nroorden As Integer
    Private _indtipo As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String = ""
    <DataMember()> _
    Public CargaCompleta As Boolean = True
    <DataMember()> _
    Public leColumna As New List(Of e_ConfiguracionColumna)
    <DataMember()> _
    Public leDato As New List(Of e_ConfiguracionDato)
    <DataMember()> _
    Public dsCDato As New Data.DataTable

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
    Public Property Esquema() As String
        Get
            Return _esquema
        End Get
        Set(ByVal value As String)
            _esquema = value
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
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Maestra() As Integer
        Get
            Return _maestra
        End Get
        Set(ByVal value As Integer)
            _maestra = value
        End Set
    End Property

    <DataMember()> _
    Public Property Limpiar() As Integer
        Get
            Return _limpiar
        End Get
        Set(ByVal value As Integer)
            _limpiar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Insertar() As Integer
        Get
            Return _insertar
        End Get
        Set(ByVal value As Integer)
            _insertar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Actualizar() As Integer
        Get
            Return _actualizar
        End Get
        Set(ByVal value As Integer)
            _actualizar = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroOrden() As Integer
        Get
            Return _nroorden
        End Get
        Set(ByVal value As Integer)
            _nroorden = value
        End Set
    End Property

    Public Property IndTipo() As Integer
        Get
            Return _IndTipo
        End Get
        Set(ByVal value As Integer)
            _IndTipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
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

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
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

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _esquema = String.Empty
        _codigo = String.Empty
        _nombre = String.Empty
        _descripcion = String.Empty
        _maestra = -1
        _limpiar = -1
        _insertar = -1
        _actualizar = -1
        _nroorden = 0
        _indtipo = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_Esquema As String _
          , ByVal ls_Codigo As String _
          , ByVal ls_Nombre As String _
          , ByVal ls_Descripcion As String _
          , ByVal lb_Maestra As Boolean _
          , ByVal lb_Limpiar As Boolean _
          , ByVal lb_Insertar As Boolean _
          , ByVal lb_Actualizar As Boolean _
          , ByVal ln_NroOrden As Integer _
          , ByVal ln_IndTipo As Integer _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _id = ls_Id
        _esquema = ls_Esquema
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _descripcion = ls_Descripcion
        _maestra = IIf(lb_Maestra = False, 0, 1)
        _limpiar = IIf(lb_Limpiar = False, 0, 1)
        _insertar = IIf(lb_Insertar = False, 0, 1)
        _actualizar = IIf(lb_Actualizar = False, 0, 1)
        _nroorden = ln_NroOrden
        _indtipo = ln_IndTipo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(configuraciontabla As e_ConfiguracionTabla) As e_ConfiguracionTabla Implements Ie_ConfiguracionTabla.Obtener
        Return configuraciontabla
    End Function

#End Region

End Class
