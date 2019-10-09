
<DataContract()> _
Public Class e_Formulario
    Implements Ie_Formulario

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _descripcion As String
    Private _ruta As String
    Private _padre As Boolean
    Private _idpadre As String
    Private _nombrepadre As String
    Private _multiinstancia As Boolean
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Padre() As Boolean
        Get
            Return _padre
        End Get
        Set(ByVal value As Boolean)
            _padre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPadre() As String
        Get
            Return _idpadre
        End Get
        Set(ByVal value As String)
            _idpadre = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombrePadre() As String
        Get
            Return _nombrepadre
        End Get
        Set(ByVal value As String)
            _nombrepadre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Multiinstancia() As Boolean
        Get
            Return _multiinstancia
        End Get
        Set(ByVal value As Boolean)
            _multiinstancia = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
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

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _codigo = ""
        _nombre = ""
        _descripcion = ""
        _ruta = ""
        _padre = False
        _idpadre = ""
        _nombrepadre = ""
        _multiinstancia = False
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _activo = True
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Descripcion As String _
              , ByVal ls_Ruta As String _
              , ByVal lb_Padre As Boolean _
              , ByVal ls_IdPadre As String _
              , ByVal ls_NombrePadre As String _
              , ByVal lb_MultiInstancia As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _descripcion = ls_Descripcion
        _ruta = ls_Ruta
        _padre = lb_Padre
        _idpadre = ls_IdPadre
        _nombrepadre = ls_NombrePadre
        _multiinstancia = lb_MultiInstancia
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Formulario
    ''' </summary>
    ''' <param name="formulario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal formulario As e_Formulario) As e_Formulario Implements Ie_Formulario.Obtener
        Return formulario
    End Function

#End Region

End Class
