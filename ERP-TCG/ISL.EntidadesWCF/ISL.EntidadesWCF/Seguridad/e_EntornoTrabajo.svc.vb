
<DataContract()> _
Public Class e_EntornoTrabajo
    Implements Ie_EntornoTrabajo

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""

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
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

        _id = ""
        _codigo = ""
        _nombre = ""
        _activo = True
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""

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

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_EntornoTrabajo
    ''' </summary>
    ''' <param name="entornoTrabajo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal entornoTrabajo As e_EntornoTrabajo) As e_EntornoTrabajo Implements Ie_EntornoTrabajo.Obtener
        Return entornoTrabajo
    End Function

#End Region

End Class
