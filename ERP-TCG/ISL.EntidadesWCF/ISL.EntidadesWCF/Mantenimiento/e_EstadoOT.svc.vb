<DataContract()> _
Public Class e_EstadoOT
    Implements Ie_EstadoOT

#Region "Propiedad"

    Private _id As String
    Private _nombre As String
    Private _activo As Boolean
    Private _usuariocrea As String
    Private _fechacrea As Date

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
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
            Return _usuariocrea
        End Get
        Set(ByVal value As String)
            _usuariocrea = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Nombre As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCrea As String _
                      )
        _id = ls_Id
        _nombre = ls_Nombre
        _activo = lb_Activo
        _usuariocrea = ls_UsuarioCrea
    End Sub

#End Region

    Public Function Obtener(ByVal estadoOT As e_EstadoOT) As e_EstadoOT Implements Ie_EstadoOT.Obtener
        Return estadoOT
    End Function

End Class
