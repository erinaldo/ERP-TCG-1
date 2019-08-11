<DataContract()> _
Public Class e_Actividad
    Implements Ie_Actividad

#Region "Propiedad"
    Private _seleccion As Boolean
    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _activo As Boolean
    Private _descripcion As String
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

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
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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

    Public Sub New(ByVal lb_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Descripcion As String _
                               )
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _activo = lb_Activo
        _descripcion = ls_Descripcion
        _seleccion = lb_Seleccion
    End Sub

#End Region

    Public Function Obtener(ByVal actividad As e_Actividad) As e_Actividad Implements Ie_Actividad.Obtener
        Return actividad
    End Function

End Class
