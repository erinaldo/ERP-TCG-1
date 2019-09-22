


<DataContract()> _
Public Class e_GuiaTransportista
    Implements Ie_GuiaTransportista

#Region "Propiedades"

    Private _id As String
    Private _serie As String
    Private _numero As String
    Private _idseguimiento As String
    Private _idremitente As String
    Private _remitente As String
    Private _iddireccionlugarpartida As String
    Private _iddestinatario As String
    Private _destinatario As String
    Private _iddireccionlugarllegada As String
    Private _idmotivodocumentotraslado As String
    Private _glosa As String
    Private _fecha As Date
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _viaje As String
    Private _Incidencia As String
    Private _IdOperacionDetalle As String
    Private _pesotoneladas As Decimal
    Private _cantidad As Decimal
    Private _IndFacturado As Integer
    Private _IndGrtConfirmada As Integer
    Private _IndDocumentos As Integer
    Private _IndGrtPerdido As Integer
    Private _IdVehiculo As String
    Private _IndGuiaTercero As Boolean
    Private _IdPilotoTercero As String

    Private _IdSubContrata As String
    Private _SubSerie As String
    Private _SubNumero As String
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdViaje As String
    <DataMember()> _
    Public IdOperacion As String = ""
    <DataMember()> _
    Public IdMovimientoDoc As String = ""
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public GuiaTransportista As New List(Of e_GuiaTransportista)
    <DataMember()> _
    Public GuiaRemitente As New List(Of e_GuiaRemitente)
    <DataMember()> _
    Public GuiaTransportistaInterrumpida As New List(Of e_GuiaTransportistaInterrumpida)
    <DataMember()> _
    Public OperacionDetalle As New List(Of e_OperacionDetalle)

    <DataMember()> _
    Public oeListaBitacora As New List(Of e_Bitacora)

    <DataMember()> _
Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String

    <DataMember()> _
    Public Inicial As String
    <DataMember()> _
    Public Final As String

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
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSeguimiento() As String
        Get
            Return _idseguimiento
        End Get
        Set(ByVal value As String)
            _idseguimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Remitente() As String
        Get
            Return _remitente
        End Get
        Set(ByVal value As String)
            _remitente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRemitente() As String
        Get
            Return _idremitente
        End Get
        Set(ByVal value As String)
            _idremitente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDireccionLugarPartida() As String
        Get
            Return _iddireccionlugarpartida
        End Get
        Set(ByVal value As String)
            _iddireccionlugarpartida = value
        End Set
    End Property

    <DataMember()> _
    Public Property Destinatario() As String
        Get
            Return _destinatario
        End Get
        Set(ByVal value As String)
            _destinatario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDestinatario() As String
        Get
            Return _iddestinatario
        End Get
        Set(ByVal value As String)
            _iddestinatario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDireccionLugarLlegada() As String
        Get
            Return _iddireccionlugarllegada
        End Get
        Set(ByVal value As String)
            _iddireccionlugarllegada = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMotivoDocumentoTraslado() As String
        Get
            Return _idmotivodocumentotraslado
        End Get
        Set(ByVal value As String)
            _idmotivodocumentotraslado = value
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

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
    Public Property Viaje() As String
        Get
            Return _viaje
        End Get
        Set(ByVal value As String)
            _viaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubSerie() As String
        Get
            Return _SubSerie
        End Get
        Set(ByVal value As String)
            _SubSerie = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubNumero() As String
        Get
            Return _SubNumero
        End Get
        Set(ByVal value As String)
            _SubNumero = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubContrata() As String
        Get
            Return _IdSubContrata
        End Get
        Set(ByVal value As String)
            _IdSubContrata = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperacionDetalle() As String
        Get
            Return _IdOperacionDetalle
        End Get
        Set(ByVal value As String)
            _IdOperacionDetalle = value
        End Set
    End Property

    <DataMember()> _
    Public Property Incidencia() As String
        Get
            Return _Incidencia
        End Get
        Set(ByVal value As String)
            _Incidencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property PesoToneladas() As Decimal
        Get
            Return _pesotoneladas
        End Get
        Set(ByVal value As Decimal)
            _pesotoneladas = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndFacturado() As Integer
        Get
            Return _IndFacturado
        End Get
        Set(ByVal value As Integer)
            _IndFacturado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndGrtConfirmada() As Boolean
        Get
            Return _IndGrtConfirmada
        End Get
        Set(ByVal value As Boolean)
            _IndGrtConfirmada = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _IdVehiculo
        End Get
        Set(ByVal value As String)
            _IdVehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndDocumentos() As Boolean
        Get
            Return _IndDocumentos
        End Get
        Set(ByVal value As Boolean)
            _IndDocumentos = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndGrtPerdido() As Boolean
        Get
            Return _IndGrtPerdido
        End Get
        Set(ByVal value As Boolean)
            _IndGrtPerdido = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Decimal
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Decimal)
            _cantidad = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndGuiaTercero() As Boolean
        Get
            Return _IndGuiaTercero
        End Get
        Set(ByVal value As Boolean)
            _IndGuiaTercero = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPilotoTercero() As String
        Get
            Return _IdPilotoTercero
        End Get
        Set(ByVal value As String)
            _IdPilotoTercero = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
        Id = ""
        TipoOperacion = ""
        Serie = ""
        Numero = ""
        Activo = True
        IndDocumentos = 0
        IndFacturado = 0
        IndGrtConfirmada = 0
        IndGrtPerdido = 0
        Fecha = Date.Today
        FechaDesde = ""
        FechaHasta = ""
        IdRemitente = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ls_IdSeguimiento As String _
              , ByVal ls_IdRemitente As String _
              , ByVal ls_IdDireccionLugarPartida As String _
              , ByVal ls_IdDestinatario As String _
              , ByVal ls_IdDireccionLugarLlegada As String _
              , ByVal ls_IdMotivoDocumentoTraslado As String _
              , ByVal ls_Glosa As String _
              , ByVal ld_Fecha As Date _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Viaje As String _
              , ByVal ls_IdSubContrata As String _
              , ByVal ls_SubSerie As String _
              , ByVal ls_SubNumero As String _
              , ByVal ls_IdOperacionDetalle As String _
              , ByVal ls_Incidencia As String _
              , ByVal ln_PesoToneladas As Decimal _
              , ByVal lb_IndFacturado As Integer _
              , ByVal lb_IndGrtConfirmada As Boolean _
              , ByVal lb_IndDocumentos As Boolean _
              , ByVal lb_IndGrtPerdido As Boolean _
              , ByVal ln_Cantidad As Decimal)
        _id = ls_Id
        _serie = ls_Serie
        _numero = ls_Numero
        _idseguimiento = ls_IdSeguimiento
        _idremitente = ls_IdRemitente
        _iddireccionlugarpartida = ls_IdDireccionLugarPartida
        _iddestinatario = ls_IdDestinatario
        _iddireccionlugarllegada = ls_IdDireccionLugarLlegada
        _idmotivodocumentotraslado = ls_IdMotivoDocumentoTraslado
        _glosa = ls_Glosa
        _fecha = ld_Fecha
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _viaje = ls_Viaje
        _IdSubContrata = ls_IdSubContrata
        _SubSerie = ls_SubSerie
        _SubNumero = ls_SubNumero
        _IdOperacionDetalle = ls_IdOperacionDetalle
        _Incidencia = ls_Incidencia
        _pesotoneladas = ln_PesoToneladas
        _IndFacturado = lb_IndFacturado
        _IndGrtConfirmada = lb_IndGrtConfirmada
        _IndDocumentos = lb_IndDocumentos
        _IndGrtPerdido = lb_IndGrtPerdido
        _cantidad = ln_Cantidad
    End Sub

#End Region

    Public Function Obtener(ByVal guiaTransportista As e_GuiaTransportista) As e_GuiaTransportista Implements Ie_GuiaTransportista.Obtener
        Return guiaTransportista
    End Function

End Class


