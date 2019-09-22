

<DataContract()> _
Public Class e_Alerta
    Implements Ie_Alerta

#Region "Declaracion de Variables"

    Private _id As String
    Private _usuariocreacion As String
    Private _idactividadnegocio As String
    Private _fechacreacion As Date
    Private _estado As String
    Private _activo As Boolean
    Private _nombrecompleto As String
    Private _actividadnegocio As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

    <DataMember()> _
    Public leDetalle As New List(Of e_AlertaDetalle)
    <DataMember()> _
    Public leDestino As New List(Of e_AlertaDestino)

    <DataMember()> _
    Public WithEvents oeAlertaDetalle As New e_AlertaDetalle

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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdActividadNegocio() As String
        Get
            Return _idactividadnegocio
        End Get
        Set(ByVal value As String)
            _idactividadnegocio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ActividadNegocio() As String
        Get
            Return _actividadnegocio
        End Get
        Set(ByVal value As String)
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
    Public Property Glosa() As String
        Get
            Return oeAlertaDetalle.Glosa
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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
    Public Property NombreCompleto() As String
        Get
            Return _nombrecompleto
        End Get
        Set(ByVal value As String)
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _estado = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _idactividadnegocio = String.Empty
        _nombrecompleto = String.Empty
        TipoOperacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_NombreCompleto As String _
              , ByVal ls_IdActividadNegocio As String _
              , ByVal ls_ActividadNegocio As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_Glosa As String _
              , ByVal lb_Email As Boolean _
              , ByVal lb_Sonora As Boolean _
              , ByVal lb_Visual As Boolean _
              , ByVal ls_Estado As String _
              , ByVal ls_IdAlertaDetalle As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _usuariocreacion = ls_UsuarioCreacion
        _nombrecompleto = ls_NombreCompleto
        _idactividadnegocio = ls_IdActividadNegocio
        _actividadnegocio = ls_ActividadNegocio
        _fechacreacion = ld_FechaCreacion
        oeAlertaDetalle.Glosa = ls_Glosa
        oeAlertaDetalle.Email = lb_Email
        oeAlertaDetalle.Sonora = lb_Sonora
        oeAlertaDetalle.Visual = lb_Visual
        oeAlertaDetalle.Id = ls_IdAlertaDetalle
        _estado = ls_Estado
        _activo = lb_Activo
    End Sub

    Private Sub oeAlertaDetalle_DatoCambio() Handles oeAlertaDetalle.DatoCambiado
        Modificado = True
    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Alerta
    ''' </summary>
    ''' <param name="alerta"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal alerta As e_Alerta) As e_Alerta Implements Ie_Alerta.Obtener
        Return alerta
    End Function

#End Region

End Class


