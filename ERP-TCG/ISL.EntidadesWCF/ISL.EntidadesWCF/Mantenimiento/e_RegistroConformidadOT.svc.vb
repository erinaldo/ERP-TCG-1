<DataContract()> _
Public Class e_RegistroConformidadOT
    Implements Ie_RegistroConformidadOT

#Region "Propiedad"

    Private _id As String
    Private _glosa As String
    Private _indicador As String
    Private _fechaconfirmo As Date
    Private _usuarioconfirmo As String
    Private _activo As Boolean
    <DataMember()> _
    Public lstDetalleRegConformidadOT As New List(Of e_DetalleRegConformidadOT)
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()>
    Public FechaFin As Date
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Public Event DatoCambiado()


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
   Public Property Indicador() As String
        Get
            Return _indicador
        End Get
        Set(ByVal value As String)
            _indicador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaConfirmo() As Date
        Get
            Return _fechaconfirmo
        End Get
        Set(ByVal value As Date)
            _fechaconfirmo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioConfirmo() As String
        Get
            Return _usuarioconfirmo
        End Get
        Set(ByVal value As String)
            _usuarioconfirmo = value
            RaiseEvent DatoCambiado()
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

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Indicador As String _
              , ByVal ls_Glosa As String _
              , ByVal ld_FechaConfirmo As Date _
              , ByVal ls_UsuarioConfirmo As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _indicador = ls_Indicador
        _glosa = ls_Glosa
        _fechaconfirmo = ld_FechaConfirmo
        _usuarioconfirmo = ls_UsuarioConfirmo
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal registroConformidadOT As e_RegistroConformidadOT) As e_RegistroConformidadOT Implements Ie_RegistroConformidadOT.Obtener
        Return registroConformidadOT
    End Function

End Class
