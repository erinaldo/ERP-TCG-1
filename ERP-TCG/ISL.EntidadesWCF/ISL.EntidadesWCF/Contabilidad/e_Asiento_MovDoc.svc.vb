<DataContract()> _
Public Class e_Asiento_MovDoc
    Implements Ie_Asiento_MovDoc

#Region "Propiedad"

    Private _id As String
    Private _idasiento As String
    Private _idmovimientodocumento As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdAsiento() As String
        Get
            Return _idasiento
        End Get
        Set(ByVal value As String)
            _idasiento = value
            RaiseEvent DatoCambiado()
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
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAsiento As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idasiento = ls_IdAsiento
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _activo = lb_Activo
        TipoOperacion = ""
    End Sub

#End Region

    Public Function Obtener(ByVal asiento_MovDoc As e_Asiento_MovDoc) As e_Asiento_MovDoc Implements Ie_Asiento_MovDoc.Obtener
        Return asiento_MovDoc
    End Function

End Class
