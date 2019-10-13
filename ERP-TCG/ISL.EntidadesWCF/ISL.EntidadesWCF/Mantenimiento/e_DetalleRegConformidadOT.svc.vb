<DataContract()> _
Public Class e_DetalleRegConformidadOT
    Implements Ie_DetalleRegConformidadOT

#Region "Propiedad"

    Private _id As String
    Private _idot As String
    Private _idregconformidadot As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date

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
    Public Property IdOT() As String
        Get
            Return _idot
        End Get
        Set(ByVal value As String)
            _idot = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdRegConformidadOT() As String
        Get
            Return _idregconformidadot
        End Get
        Set(ByVal value As String)
            _idregconformidadot = value
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

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
              , ByVal ls_IdOT As String _
              , ByVal ls_IdRegConformidadOT As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
           )
        _id = ls_Id
        _idot = ls_IdOT
        _idregconformidadot = ls_IdRegConformidadOT
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal detalleRegConformidadOT As e_DetalleRegConformidadOT) As e_DetalleRegConformidadOT Implements Ie_DetalleRegConformidadOT.Obtener
        Return detalleRegConformidadOT
    End Function

End Class
