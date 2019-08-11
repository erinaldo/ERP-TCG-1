<DataContract()> _
Public Class e_DetalleDoc_GuiaTrans
    Implements Ie_DetalleDoc_GuiaTrans

#Region "Declaracion de Variables"

    Private _id As String
    Private _iddetalledoc As String
    Private _idguiatrans As String
    Private _idestado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property IdDetalleDoc() As String
        Get
            Return _iddetalledoc
        End Get
        Set(ByVal value As String)
            _iddetalledoc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdGuiaTrans() As String
        Get
            Return _idguiatrans
        End Get
        Set(ByVal value As String)
            _idguiatrans = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
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
              , ByVal ls_IdDetalleDoc As String _
              , ByVal ls_IdGuiaTrans As String _
              , ByVal ls_IdEstado As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _iddetalledoc = ls_IdDetalleDoc
        _idguiatrans = ls_IdGuiaTrans
        _idestado = ls_IdEstado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal detalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As e_DetalleDoc_GuiaTrans Implements Ie_DetalleDoc_GuiaTrans.Obtener
        Return detalleDoc_GuiaTrans
    End Function

End Class
