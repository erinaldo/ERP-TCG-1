

<DataContract()> _
Public Class e_GuiaRemitente
    Implements Ie_GuiaRemitente

#Region "Propiedades"

    Private _id As String
    Private _serie As String
    Private _numero As String
    Private _idguiatransportista As String
    Private _nrogt As String
    Private _fecha As Date
    Private _activo As Boolean
    Private _viaje As String
    Private _glosa As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdViaje As String
    <DataMember()> _
    Public IdOperacion As String
    <DataMember()> _
    Public IdMovimientoDoc As String
    <DataMember()> _
    Public IdRemitente As String

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
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdGuiaTransportista() As String
        Get
            Return _idguiatransportista
        End Get
        Set(ByVal value As String)
            _idguiatransportista = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property GuiaTransportista() As String
        Get
            Return _nrogt
        End Get
        Set(ByVal value As String)
            _nrogt = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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
    Public Property Viaje() As String
        Get
            Return _viaje
        End Get
        Set(ByVal value As String)
            _viaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property


#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        Serie = ""
        Numero = ""
        IdRemitente = ""
        IdGuiaTransportista = ""
        IdViaje = ""
        IdOperacion = ""
        Glosa = ""
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ls_IdGuiaTransportista As String _
              , ByVal ls_GuiaTransportista As String _
              , ByVal ld_Fecha As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Viaje As String _
              , ByVal ls_Glosa As String)
        _id = ls_Id
        _serie = ls_Serie
        _numero = ls_Numero
        _idguiatransportista = ls_IdGuiaTransportista
        _nrogt = ls_GuiaTransportista
        _fecha = ld_Fecha
        _activo = lb_Activo
        _viaje = ls_Viaje
        _glosa = ls_Glosa
    End Sub

#End Region

    Public Function Obtener(ByVal guiaRemitente As e_GuiaRemitente) As e_GuiaRemitente Implements Ie_GuiaRemitente.Obtener
        Return guiaRemitente
    End Function

End Class


