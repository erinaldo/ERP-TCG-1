<DataContract()> _
Public Class e_Seguimiento
    Implements Ie_Seguimiento

#Region "Propiedad"

    Private _id As String
    Private _idviaje As String
    Private _llegadaorigen As Date
    Private _indllegadaorigen As Integer
    Private _ingresocomplejoorigen As Date
    Private _indingresocomplejoorigen As Integer
    Private _cargaorigen As Date
    Private _indcargaorigen As Integer
    Private _terminocargaorigen As Date
    Private _indterminocargaorigen As Integer
    Private _impresionguiaorigen As Date
    Private _indimpresionguiaorigen As Integer
    Private _salidaorigen As Date
    Private _indsalidaorigen As Integer
    Private _llegadaaproximadadestino As Date
    Private _indllegadaaproximadadestino As Integer
    Private _llegadadestino As Date
    Private _indllegadadestino As Integer
    Private _ingresodestino As Date
    Private _indingresodestino As Integer
    Private _descargadestino As Date
    Private _inddescargadestino As Integer
    Private _terminodescargadestino As Date
    Private _indterminodescargadestino As Integer
    Private _salidadestino As Date
    Private _indsalidadestino As Integer
    Private _kmtractoorigen As Decimal
    Private _kmtractodestino As Decimal
    Private _kmcarretaorigen As Decimal
    Private _kmcarretadestino As Decimal
    Private _horasrecorreorigen As Decimal
    Private _horasrecorredestino As Decimal
    Private _pesotoneladas As Decimal
    Private _idestado As String
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _observacion As String
    Private _Incidencia As String
    Private _idpiloto As String
    Private _piloto As String
    Private _viajevacio As Integer
    Private _cantidad As Decimal
    Private _idClienteLugar As String
    Private _pilotoconf As Integer
    Private _copilotoconf As Integer
    Private _tractoconf As Integer
    Private _carretaconf As Integer
    Private _clienteconf As Integer
    Private _IndFallaOP As Integer
    Private _FechaFalla As Date
    Private _GlosaFalla As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdOperacion As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()> _
    Public IdTracto As String
    <DataMember()> _
    Public IdCarreta As String

    Public Event DatoCambiado()

    <DataMember()> _
    Public IngresoGRT As Boolean

    <DataMember()> _
    Public GuiaTransportista As New List(Of e_GuiaTransportista)
    <DataMember()> _
    Public GuiaRemitente As New List(Of e_GuiaRemitente)
    <DataMember()> _
    Public OperacionDetalle As New List(Of e_OperacionDetalle)
    <DataMember()> _
    Public GuiaTransportistaInterrumpida As New List(Of e_GuiaTransportistaInterrumpida)

    <DataMember()> _
    Public IncidenciaAutentificadas As New e_IncidenciasAutentificadas

    <DataMember()> _
    Public oeListaBitacora As New List(Of e_Bitacora)

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
    Public Property IdViaje() As String
        Get
            Return _idviaje
        End Get
        Set(ByVal value As String)
            _idviaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property LlegadaOrigen() As Date
        Get
            Return _llegadaorigen
        End Get
        Set(ByVal value As Date)
            _llegadaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndLlegadaOrigen() As Integer
        Get
            Return _indllegadaorigen
        End Get
        Set(ByVal value As Integer)
            _indllegadaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoComplejoOrigen() As Date
        Get
            Return _ingresocomplejoorigen
        End Get
        Set(ByVal value As Date)
            _ingresocomplejoorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndIngresoComplejoOrigen() As Integer
        Get
            Return _indingresocomplejoorigen
        End Get
        Set(ByVal value As Integer)
            _indingresocomplejoorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property CargaOrigen() As Date
        Get
            Return _cargaorigen
        End Get
        Set(ByVal value As Date)
            _cargaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCargaOrigen() As Integer
        Get
            Return _indcargaorigen
        End Get
        Set(ByVal value As Integer)
            _indcargaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property TerminoCargaOrigen() As Date
        Get
            Return _terminocargaorigen
        End Get
        Set(ByVal value As Date)
            _terminocargaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTerminoCargaOrigen() As Integer
        Get
            Return _indterminocargaorigen
        End Get
        Set(ByVal value As Integer)
            _indterminocargaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property ImpresionGuiaOrigen() As Date
        Get
            Return _impresionguiaorigen
        End Get
        Set(ByVal value As Date)
            _impresionguiaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndImpresionGuiaOrigen() As Integer
        Get
            Return _indimpresionguiaorigen
        End Get
        Set(ByVal value As Integer)
            _indimpresionguiaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property SalidaOrigen() As Date
        Get
            Return _salidaorigen
        End Get
        Set(ByVal value As Date)
            _salidaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndSalidaOrigen() As Integer
        Get
            Return _indsalidaorigen
        End Get
        Set(ByVal value As Integer)
            _indsalidaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property LlegadaAproximadaDestino() As Date
        Get
            Return _llegadaaproximadadestino
        End Get
        Set(ByVal value As Date)
            _llegadaaproximadadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndLlegadaAproximadaDestino() As Integer
        Get
            Return _indllegadaaproximadadestino
        End Get
        Set(ByVal value As Integer)
            _indllegadaaproximadadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property LlegadaDestino() As Date
        Get
            Return _llegadadestino
        End Get
        Set(ByVal value As Date)
            _llegadadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndLlegadaDestino() As Integer
        Get
            Return _indllegadadestino
        End Get
        Set(ByVal value As Integer)
            _indllegadadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoDestino() As Date
        Get
            Return _ingresodestino
        End Get
        Set(ByVal value As Date)
            _ingresodestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndIngresoDestino() As Integer
        Get
            Return _indingresodestino
        End Get
        Set(ByVal value As Integer)
            _indingresodestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property DescargaDestino() As Date
        Get
            Return _descargadestino
        End Get
        Set(ByVal value As Date)
            _descargadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndDescargaDestino() As Integer
        Get
            Return _inddescargadestino
        End Get
        Set(ByVal value As Integer)
            _inddescargadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property TerminoDescargaDestino() As Date
        Get
            Return _terminodescargadestino
        End Get
        Set(ByVal value As Date)
            _terminodescargadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTerminoDescargaDestino() As Integer
        Get
            Return _indterminodescargadestino
        End Get
        Set(ByVal value As Integer)
            _indterminodescargadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property SalidaDestino() As Date
        Get
            Return _salidadestino
        End Get
        Set(ByVal value As Date)
            _salidadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndSalidaDestino() As Integer
        Get
            Return _indsalidadestino
        End Get
        Set(ByVal value As Integer)
            _indsalidadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmTractoOrigen() As Decimal
        Get
            Return _kmtractoorigen
        End Get
        Set(ByVal value As Decimal)
            _kmtractoorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmTractoDestino() As Decimal
        Get
            Return _kmtractodestino
        End Get
        Set(ByVal value As Decimal)
            _kmtractodestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmCarretaOrigen() As Decimal
        Get
            Return _kmcarretaorigen
        End Get
        Set(ByVal value As Decimal)
            _kmcarretaorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmCarretaDestino() As Decimal
        Get
            Return _kmcarretadestino
        End Get
        Set(ByVal value As Decimal)
            _kmcarretadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property HorasRecorreOrigen() As Decimal
        Get
            Return _horasrecorreorigen
        End Get
        Set(ByVal value As Decimal)
            _horasrecorreorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property HorasRecorreDestino() As Decimal
        Get
            Return _horasrecorredestino
        End Get
        Set(ByVal value As Decimal)
            _horasrecorredestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
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
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
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

    Private _CodViaje As String
    <DataMember()> _
    Public Property CodViaje() As String
        Get
            Return _CodViaje
        End Get
        Set(ByVal value As String)
            _CodViaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdPiloto() As String
        Get
            Return _idpiloto
        End Get
        Set(ByVal value As String)
            _idpiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Piloto() As String
        Get
            Return _piloto
        End Get
        Set(ByVal value As String)
            _piloto = value
        End Set
    End Property

    Private _idVehiculo As String
    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idVehiculo
        End Get
        Set(ByVal value As String)
            _idVehiculo = value
        End Set
    End Property

    Private _cantidadkm As Decimal
    <DataMember()> _
    Public Property CantKm() As Decimal
        Get
            Return _cantidadkm
        End Get
        Set(ByVal value As Decimal)
            _cantidadkm = value
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
    Public Property ViajeVacio() As Integer
        Get
            Return _viajevacio
        End Get
        Set(ByVal value As Integer)
            _viajevacio = value
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
    Public Property IdClienteLugar() As String
        Get
            Return _idClienteLugar
        End Get
        Set(ByVal value As String)
            _idClienteLugar = value
        End Set
    End Property

    <DataMember()> _
    Public Property PilotoConf() As Integer
        Get
            Return _pilotoconf
        End Get
        Set(ByVal value As Integer)
            _pilotoconf = value
        End Set
    End Property

    <DataMember()> _
    Public Property CopilotoConf() As Integer
        Get
            Return _copilotoconf
        End Get
        Set(ByVal value As Integer)
            _copilotoconf = value
        End Set
    End Property

    <DataMember()> _
    Public Property TractoConf() As Integer
        Get
            Return _tractoconf
        End Get
        Set(ByVal value As Integer)
            _tractoconf = value
        End Set
    End Property

    <DataMember()> _
    Public Property CarretaConf() As Integer
        Get
            Return _carretaconf
        End Get
        Set(ByVal value As Integer)
            _carretaconf = value
        End Set
    End Property

    <DataMember()> _
    Public Property ClienteConf() As Integer
        Get
            Return _clienteconf
        End Get
        Set(ByVal value As Integer)
            _clienteconf = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndFallaOP() As Integer
        Get
            Return _IndFallaOP
        End Get
        Set(ByVal value As Integer)
            _IndFallaOP = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFalla() As Date
        Get
            Return _FechaFalla
        End Get
        Set(ByVal value As Date)
            _FechaFalla = value
        End Set
    End Property

    <DataMember()> _
    Public Property GlosaFalla() As String
        Get
            Return _GlosaFalla
        End Get
        Set(ByVal value As String)
            _GlosaFalla = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
        Incidencia = ""
        TipoOperacion = ""
        Id = ""
        IdViaje = ""
        IdOperacion = ""
        IngresoGRT = False
        IdClienteLugar = ""
        IndFallaOP = 0
        FechaFalla = Now.Date

    End Sub
    Public Sub New(ByVal ls_Id As String _
                  , ByVal ls_CodViaje As String _
                  , ByVal ld_Fecha As Date _
                  , ByVal ls_IdPiloto As String _
                  , ByVal ls_Piloto As String _
                  , ByVal lb_SOrigen As String _
                  , ByVal lb_SDestino As String _
                  )
        _id = ls_Id
        _CodViaje = ls_CodViaje
        _llegadadestino = ld_Fecha
        _idpiloto = ls_IdPiloto
        _piloto = ls_Piloto
        _kmtractoorigen = lb_SOrigen
        _kmtractodestino = lb_SDestino

    End Sub


    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdViaje As String _
              , ByVal ld_LlegadaOrigen As Date _
              , ByVal ln_IndLlegadaOrigen As Integer _
              , ByVal ld_IngresoComplejoOrigen As Date _
              , ByVal ln_IndIngresoComplejoOrigen As Integer _
              , ByVal ld_CargaOrigen As Date _
              , ByVal ln_IndCargaOrigen As Integer _
              , ByVal ld_TerminoCargaOrigen As Date _
              , ByVal ln_IndTerminoCargaOrigen As Integer _
              , ByVal ld_ImpresionGuiaOrigen As Date _
              , ByVal ln_IndImpresionGuiaOrigen As Integer _
              , ByVal ld_SalidaOrigen As Date _
              , ByVal ln_IndSalidaOrigen As Integer _
              , ByVal ld_LlegadaAproximadaDestino As Date _
              , ByVal ln_IndLlegadaAproximadaDestino As Integer _
              , ByVal ld_LlegadaDestino As Date _
              , ByVal ln_IndLlegadaDestino As Integer _
              , ByVal ld_IngresoDestino As Date _
              , ByVal ln_IndIngresoDestino As Integer _
              , ByVal ld_DescargaDestino As Date _
              , ByVal ln_IndDescargaDestino As Integer _
              , ByVal ld_TerminoDescargaDestino As Date _
              , ByVal ln_IndTerminoDescargaDestino As Integer _
              , ByVal ld_SalidaDestino As Date _
              , ByVal ln_IndSalidaDestino As Integer _
              , ByVal ln_KmTractoOrigen As Decimal _
              , ByVal ln_KmTractoDestino As Decimal _
              , ByVal ln_KmCarretaOrigen As Decimal _
              , ByVal ln_KmCarretaDestino As Decimal _
              , ByVal ln_HorasRecorreorigen As Decimal _
              , ByVal ln_HorasRecorredestino As Decimal _
              , ByVal ls_IdEstado As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Observacion As String _
              , ByVal ls_Incidencia As String _
              , ByVal ln_PesoToneladas As Decimal _
              , ByVal lb_ViajeVacio As Integer _
              , ByVal ln_cantidad As Decimal _
              , ByVal ls_idClienteLugar As String _
              , ByVal li_pilotoconf As Integer _
              , ByVal li_copilotoconf As Integer _
              , ByVal li_tractoconf As Integer _
              , ByVal li_carretaconf As Integer _
              , ByVal li_clienteconf As Integer _
              , ByVal li_IndFallaOP As Integer _
              , ByVal ld_FechaFalla As Date _
              , ByVal ls_GlosaFalla As String)

        _id = ls_Id
        _idviaje = ls_IdViaje
        _llegadaorigen = ld_LlegadaOrigen
        _indllegadaorigen = ln_IndLlegadaOrigen
        _ingresocomplejoorigen = ld_IngresoComplejoOrigen
        _indingresocomplejoorigen = ln_IndIngresoComplejoOrigen
        _cargaorigen = ld_CargaOrigen
        _indcargaorigen = ln_IndCargaOrigen
        _terminocargaorigen = ld_TerminoCargaOrigen
        _indterminocargaorigen = ln_IndTerminoCargaOrigen
        _impresionguiaorigen = ld_ImpresionGuiaOrigen
        _indimpresionguiaorigen = ln_IndImpresionGuiaOrigen
        _salidaorigen = ld_SalidaOrigen
        _indsalidaorigen = ln_IndSalidaOrigen
        _llegadaaproximadadestino = ld_LlegadaAproximadaDestino
        _indllegadaaproximadadestino = ln_IndLlegadaAproximadaDestino
        _llegadadestino = ld_LlegadaDestino
        _indllegadadestino = ln_IndLlegadaDestino
        _ingresodestino = ld_IngresoDestino
        _indingresodestino = ln_IndIngresoDestino
        _descargadestino = ld_DescargaDestino
        _inddescargadestino = ln_IndDescargaDestino
        _terminodescargadestino = ld_TerminoDescargaDestino
        _indterminodescargadestino = ln_IndTerminoDescargaDestino
        _salidadestino = ld_SalidaDestino
        _indsalidadestino = ln_IndSalidaDestino
        _kmtractoorigen = ln_KmTractoOrigen
        _kmtractodestino = ln_KmTractoDestino
        _kmcarretaorigen = ln_KmCarretaOrigen
        _kmcarretadestino = ln_KmCarretaDestino
        _horasrecorreorigen = ln_HorasRecorreorigen
        _horasrecorredestino = ln_HorasRecorredestino
        _idestado = ls_IdEstado
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _observacion = ls_Observacion
        _Incidencia = ls_Incidencia
        _pesotoneladas = ln_PesoToneladas
        _viajevacio = lb_ViajeVacio
        _cantidad = ln_cantidad
        _idClienteLugar = ls_idClienteLugar
        _pilotoconf = li_pilotoconf
        _copilotoconf = li_copilotoconf
        _tractoconf = li_tractoconf
        _carretaconf = li_carretaconf
        _clienteconf = li_clienteconf
        _IndFallaOP = li_IndFallaOP
        _FechaFalla = ld_FechaFalla
        _GlosaFalla = ls_GlosaFalla
    End Sub

#End Region

    Public Function Obtener(ByVal seguimiento As e_Seguimiento) As e_Seguimiento Implements Ie_Seguimiento.Obtener
        Return seguimiento
    End Function

End Class


