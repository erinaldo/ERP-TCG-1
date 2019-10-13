

<DataContract()> _
Public Class e_GuiaTransportistaInterrumpida
    Implements Ie_GuiaTransportistaInterrumpida

#Region "Propiedades"

    Private _id As String
    Private _idseguimiento As String
    Private _idguiatransportista As String
    Private _nrogt As String
    Private _idmotivotrasladointerrumpido As String
    Private _glosa As String
    Private _fecha As Date
    Private _activo As Boolean
    Private _viaje As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdOperacion As String
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
    Public Property IdSeguimiento() As String
        Get
            Return _idseguimiento
        End Get
        Set(ByVal value As String)
            _idseguimiento = value
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
    Public Property IdMotivoTrasladoInterrumpido() As String
        Get
            Return _idmotivotrasladointerrumpido
        End Get
        Set(ByVal value As String)
            _idmotivotrasladointerrumpido = value
            RaiseEvent DatoCambiado()
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

#End Region

#Region "Constructor"

    Public Sub New()
        Id = ""
        TipoOperacion = ""
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdSeguimiento As String _
              , ByVal ls_IdGuiaTransportista As String _
               , ByVal ls_GuiaTransportista As String _
              , ByVal ls_IdMotivoTrasladoInterrumpido As String _
              , ByVal ls_Glosa As String _
              , ByVal ld_Fecha As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Viaje As String)
        _id = ls_Id
        _idseguimiento = ls_IdSeguimiento
        _idguiatransportista = ls_IdGuiaTransportista
        _nrogt = ls_GuiaTransportista
        _idmotivotrasladointerrumpido = ls_IdMotivoTrasladoInterrumpido
        _glosa = ls_Glosa
        _fecha = ld_Fecha
        _activo = lb_Activo
        _viaje = ls_Viaje
    End Sub

#End Region

    Public Function Obtener(ByVal guiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As e_GuiaTransportistaInterrumpida Implements Ie_GuiaTransportistaInterrumpida.Obtener
        Return guiaTransportistaInterrumpida
    End Function

End Class


