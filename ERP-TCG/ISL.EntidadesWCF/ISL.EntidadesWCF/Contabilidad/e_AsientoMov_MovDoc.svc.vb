<DataContract()> _
Public Class e_AsientoMov_MovDoc
    Implements Ie_AsientoMov_MovDoc

#Region "Propiedad"

    Private _id As String
    Private _idmovimientodocumento As String
    Private _idasientomovimiento As String
    Private _activo As Boolean
    Private _IdCuentaxCyP As String

    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public Fecha As Date
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
    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAsientoMovimiento() As String
        Get
            Return _idasientomovimiento
        End Get
        Set(ByVal value As String)
            _idasientomovimiento = value
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
    Public Property IdCuentaxCyP() As String
        Get
            Return _IdCuentaxCyP
        End Get
        Set(ByVal value As String)
            _IdCuentaxCyP = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
        _idmovimientodocumento = String.Empty

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ls_IdAsientoMovimiento As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdCuentaxCyP As String _
           )
        _id = ls_Id
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _idasientomovimiento = ls_IdAsientoMovimiento
        _activo = lb_Activo
        IdCuentaxCyP = ls_IdCuentaxCyP
    End Sub

#End Region

    Public Function Obtener(ByVal asientoMov_MovDoc As e_AsientoMov_MovDoc) As e_AsientoMov_MovDoc Implements Ie_AsientoMov_MovDoc.Obtener
        Return asientoMov_MovDoc
    End Function

End Class
