<DataContract()> _
Public Class e_Viaje
    Implements Ie_Viaje

#Region "Propiedad"

    Private _Seleccion As Boolean
    Private _id As String
    Private _codigo As String
    Private _idoperacion As String
    Private _operacion As String
    Private _idorigen As String
    Private _origen As String
    Private _iddestino As String
    Private _destino As String
    Private _idescala As String
    Private _escala As String
    Private _indescala As Integer
    Private _viajevacio As Integer
    Private _viajeretorno As Integer
    Private _idpiloto As String
    Private _piloto As String
    Private _dispiloto As Boolean
    Private _idcopiloto As String
    Private _copiloto As String
    Private _discopiloto As Boolean
    Private _idayudante As String
    Private _ayudante As String
    Private _disayudante As Boolean
    Private _idtracto As String
    Private _tracto As String
    Private _idtipovehiculo As String
    Private _tipovehiculo As String
    Private _idcarreta As String
    Private _carreta As String
    Private _idestado As String
    Private _estado As String
    Private _fecha As DateTime
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _cliente As String
    Private _GlosaEscala As String
    Private _carga As Integer
    Private _UsuarioModifica As String
    Private _UsuarioSeguimiento As String
    Private _IncidenciaOperaciones As String
    Private _IncidenciaSeguimiento As String
    Private _Turno As Integer
    Private _DiaNoche As Integer
    Private _PesoToneladas As Decimal
    Private _TotalFlete As Decimal
    Private _Zona As String
    Private _CargaMaterial As String
    Private _IndFecha As Integer
    Private _PorcentajeFlete As Decimal

    Private _llegadaorigen As Date
    Private _ingresocomplejoorigen As Date
    Private _cargaorigen As Date
    Private _terminocargaorigen As Date
    Private _impresionguiaorigen As Date
    Private _salidaorigen As Date
    Private _llegadaaproximadadestino As Date
    Private _llegadadestino As Date
    Private _ingresodestino As Date
    Private _descargadestino As Date
    Private _terminodescargadestino As Date
    Private _salidadestino As Date
    Private _Flota As String

    Private _cantidad As Decimal
    Private _fleteunitario As Decimal
    Private _IncluyeIgv As Boolean
    Private _capacidad As Decimal
    Private _produccion As Decimal

    Private _fechacrea As Date
    Private _fechamodifica As Date

    Private _IndPlanilla As Integer
    Private _IdCentro As String
    Private _Subtotal As Decimal
    Private _Consolidado As Decimal
    Private _IdTercero As String

    Private _TipoCambio As Decimal
    Private _TotalFleteConv As Decimal
    Private _MonedaOp As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String

    Public Event DatoCambiado()
    'Public Delegate Sub DatoCambiadoEventHandler()
    'Public Event DatoCambiado As DatoCambiadoEventHandler
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    Private _KmTractoOrigen As Decimal
    Private _KmTractoDestino As Decimal
    Private _KmCarretaOrigen As Decimal
    Private _KmCarretaDestino As Decimal
    Private _Tesoreria As String
    Private _IndCarga As Integer

    <DataMember()> _
    Public IndMotriz As Integer
    <DataMember()> _
    Public Centro As String
    <DataMember()> _
    Public Serie As String
    <DataMember()> _
    Public Numero As String
    <DataMember()> _
    Public Remitente As String

    <DataMember()> _
    Public IndFacturado As Integer
    <DataMember()> _
    Public IndGrtConfirmada As Integer
    <DataMember()> _
    Public IndDocumentos As Integer
    <DataMember()> _
    Public IndGrtPerdido As Integer
    <DataMember()> _
    Public IndFormato As Integer

    <DataMember()> _
    Public IdDespachoOperaciones As String

    <DataMember()> _
    Public Property Comisionista As String
    <DataMember()> _
    Public Property Comision As Decimal

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperacion() As String
        Get
            Return _idoperacion
        End Get
        Set(ByVal value As String)
            _idoperacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Operacion() As String
        Get
            Return _operacion
        End Get
        Set(ByVal value As String)
            _operacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrigen() As String
        Get
            Return _idorigen
        End Get
        Set(ByVal value As String)
            _idorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDestino() As String
        Get
            Return _iddestino
        End Get
        Set(ByVal value As String)
            _iddestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property Destino() As String
        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEscala() As String
        Get
            Return _idescala
        End Get
        Set(ByVal value As String)
            _idescala = value
        End Set
    End Property

    <DataMember()> _
    Public Property Escala() As String
        Get
            Return _escala
        End Get
        Set(ByVal value As String)
            _escala = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndEscala() As Integer
        Get
            Return _indescala
        End Get
        Set(ByVal value As Integer)
            _indescala = value
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
    Public Property ViajeRetorno() As Integer
        Get
            Return _viajeretorno
        End Get
        Set(ByVal value As Integer)
            _viajeretorno = value
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

    <DataMember()> _
    Public Property DisponibleP() As Boolean
        Get
            Return _dispiloto
        End Get
        Set(ByVal value As Boolean)
            _dispiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCopiloto() As String
        Get
            Return _idcopiloto
        End Get
        Set(ByVal value As String)
            _idcopiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Copiloto() As String
        Get
            Return _copiloto
        End Get
        Set(ByVal value As String)
            _copiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property DisponibleC() As Boolean
        Get
            Return _discopiloto
        End Get
        Set(ByVal value As Boolean)
            _discopiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAyudante() As String
        Get
            Return _idayudante
        End Get
        Set(ByVal value As String)
            _idayudante = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ayudante() As String
        Get
            Return _ayudante
        End Get
        Set(ByVal value As String)
            _ayudante = value
        End Set
    End Property

    <DataMember()> _
    Public Property DisponibleA() As Boolean
        Get
            Return _disayudante
        End Get
        Set(ByVal value As Boolean)
            _disayudante = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoVehiculo() As String
        Get
            Return _idtipovehiculo
        End Get
        Set(ByVal value As String)
            _idtipovehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _tipovehiculo
        End Get
        Set(ByVal value As String)
            _tipovehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTracto() As String
        Get
            Return _idtracto
        End Get
        Set(ByVal value As String)
            _idtracto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tracto() As String
        Get
            Return _tracto
        End Get
        Set(ByVal value As String)
            _tracto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCarreta() As String
        Get
            Return _idcarreta
        End Get
        Set(ByVal value As String)
            _idcarreta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Carreta() As String
        Get
            Return _carreta
        End Get
        Set(ByVal value As String)
            _carreta = value
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
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
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
    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
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
    Public Property Cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property GlosaEscala() As String
        Get
            Return _GlosaEscala
        End Get
        Set(ByVal value As String)
            _GlosaEscala = value
        End Set
    End Property

    <DataMember()> _
    Public Property Carga() As Integer
        Get
            Return _carga
        End Get
        Set(ByVal value As Integer)
            _carga = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioSeguimiento() As String
        Get
            Return _UsuarioSeguimiento
        End Get
        Set(ByVal value As String)
            _UsuarioSeguimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property LlegadaOrigen() As Date
        Get
            Return _llegadaorigen
        End Get
        Set(ByVal value As Date)
            _llegadaorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoComplejoOrigen() As Date
        Get
            Return _ingresocomplejoorigen
        End Get
        Set(ByVal value As Date)
            _ingresocomplejoorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CargaOrigen() As Date
        Get
            Return _cargaorigen
        End Get
        Set(ByVal value As Date)
            _cargaorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TerminoCargaOrigen() As Date
        Get
            Return _terminocargaorigen
        End Get
        Set(ByVal value As Date)
            _terminocargaorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ImpresionGuiaOrigen() As Date
        Get
            Return _impresionguiaorigen
        End Get
        Set(ByVal value As Date)
            _impresionguiaorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SalidaOrigen() As Date
        Get
            Return _salidaorigen
        End Get
        Set(ByVal value As Date)
            _salidaorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property LlegadaAproximadaDestino() As Date
        Get
            Return _llegadaaproximadadestino
        End Get
        Set(ByVal value As Date)
            _llegadaaproximadadestino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property LlegadaDestino() As Date
        Get
            Return _llegadadestino
        End Get
        Set(ByVal value As Date)
            _llegadadestino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoDestino() As Date
        Get
            Return _ingresodestino
        End Get
        Set(ByVal value As Date)
            _ingresodestino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DescargaDestino() As Date
        Get
            Return _descargadestino
        End Get
        Set(ByVal value As Date)
            _descargadestino = value
            RaiseEvent DatoCambiado()
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
    Public Property SalidaDestino() As Date
        Get
            Return _salidadestino
        End Get
        Set(ByVal value As Date)
            _salidadestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flota() As String
        Get
            Return _Flota
        End Get
        Set(ByVal value As String)
            _Flota = value
        End Set
    End Property

    <DataMember()> _
    Public Property IncidenciaOperaciones() As String
        Get
            Return _IncidenciaOperaciones
        End Get
        Set(ByVal value As String)
            _IncidenciaOperaciones = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IncidenciaSeguimiento() As String
        Get
            Return _IncidenciaSeguimiento
        End Get
        Set(ByVal value As String)
            _IncidenciaSeguimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Turno() As Integer
        Get
            Return _Turno
        End Get
        Set(ByVal value As Integer)
            _Turno = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiaNoche() As Integer
        Get
            Return _DiaNoche
        End Get
        Set(ByVal value As Integer)
            _DiaNoche = value
        End Set
    End Property

    <DataMember()> _
    Public Property PesoToneladas() As Decimal
        Get
            Return _PesoToneladas
        End Get
        Set(ByVal value As Decimal)
            _PesoToneladas = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalFlete() As Decimal
        Get
            Return _TotalFlete
        End Get
        Set(ByVal value As Decimal)
            _TotalFlete = value
        End Set
    End Property

    <DataMember()> _
    Public Property Zona() As String
        Get
            Return _Zona
        End Get
        Set(ByVal value As String)
            _Zona = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmTractoOrigen() As Decimal
        Get
            Return _KmTractoOrigen
        End Get
        Set(ByVal value As Decimal)
            _KmTractoOrigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmTractoDestino() As Decimal
        Get
            Return _KmTractoDestino
        End Get
        Set(ByVal value As Decimal)
            _KmTractoDestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmCarretaOrigen() As Decimal
        Get
            Return _KmCarretaOrigen
        End Get
        Set(ByVal value As Decimal)
            _KmCarretaOrigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmCarretaDestino() As Decimal
        Get
            Return _KmCarretaDestino
        End Get
        Set(ByVal value As Decimal)
            _KmCarretaDestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tesoreria() As String
        Get
            Return _Tesoreria
        End Get
        Set(ByVal value As String)
            _Tesoreria = value
        End Set
    End Property

    <DataMember()> _
    Public Property CargaMaterial() As String
        Get
            Return _CargaMaterial
        End Get
        Set(ByVal value As String)
            _CargaMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndFecha() As Integer
        Get
            Return _IndFecha
        End Get
        Set(ByVal value As Integer)
            _IndFecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeFlete() As Decimal
        Get
            Return _PorcentajeFlete
        End Get
        Set(ByVal value As Decimal)
            _PorcentajeFlete = value
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
    Public Property FleteUnitario() As Decimal
        Get
            Return _fleteunitario
        End Get
        Set(ByVal value As Decimal)
            _fleteunitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IncluyeIgv() As Decimal
        Get
            Return _IncluyeIgv
        End Get
        Set(ByVal value As Decimal)
            _IncluyeIgv = value
        End Set
    End Property

    <DataMember()> _
    Public Property Capacidad() As Decimal
        Get
            Return _capacidad
        End Get
        Set(ByVal value As Decimal)
            _capacidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCarga() As Integer
        Get
            Return _IndCarga
        End Get
        Set(ByVal value As Integer)
            _IndCarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property Produccion() As Decimal
        Get
            Return _produccion
        End Get
        Set(ByVal value As Decimal)
            _produccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacrea
        End Get
        Set(ByVal value As Date)
            _fechacrea = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndPlanilla() As Integer
        Get
            Return _IndPlanilla
        End Get
        Set(ByVal value As Integer)
            _IndPlanilla = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _IdCentro
        End Get
        Set(ByVal value As String)
            _IdCentro = value
        End Set
    End Property
    Public Property Subtotal() As Decimal
        Get
            Return _Subtotal
        End Get
        Set(ByVal value As Decimal)
            _Subtotal = value
        End Set
    End Property
    Public Property Consolidado() As Decimal
        Get
            Return _Consolidado
        End Get
        Set(ByVal value As Decimal)
            _Consolidado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTercero() As String
        Get
            Return _IdTercero
        End Get
        Set(ByVal value As String)
            _IdTercero = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCambio() As Decimal
        Get
            Return _TipoCambio
        End Get
        Set(ByVal value As Decimal)
            _TipoCambio = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalFleteConv() As Decimal
        Get
            Return _TotalFleteConv
        End Get
        Set(ByVal value As Decimal)
            _TotalFleteConv = value
        End Set
    End Property

    <DataMember()> _
    Public Property MonedaOp() As String
        Get
            Return _MonedaOp
        End Get
        Set(ByVal value As String)
            _MonedaOp = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        Id = ""
        IdEstado = ""
        Activo = True
        UsuarioCreacion = ""
        Zona = ""
        GlosaEscala = ""
        IncidenciaOperaciones = ""
        IncidenciaSeguimiento = ""
        IdOrigen = ""
        IdDestino = ""
        ViajeVacio = 2
        ViajeRetorno = 1
        Centro = ""
        Serie = ""
        Numero = ""
        Remitente = ""
        IndMotriz = -1
        IdTracto = ""
        FechaDesde = ""
        FechaHasta = ""
        TipoOperacion = ""
        Codigo = ""
        Fecha = Now.Date
        DisponibleP = True
        FleteUnitario = 0
        TotalFlete = 0
        Capacidad = 0
        IndCarga = 1
        IncluyeIgv = 0
        Cantidad = 0
        Produccion = 0
        IdOperacion = ""
        IdDespachoOperaciones = ""
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
        _codigo = ls_CodViaje
        _fecha = ld_Fecha
        _idpiloto = ls_IdPiloto
        _piloto = ls_Piloto
        _idorigen = lb_SOrigen
        _iddestino = lb_SDestino
    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean, _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdOperacion As String _
              , ByVal ls_Operacion As String _
              , ByVal ls_IdOrigen As String _
              , ByVal ls_Origen As String _
              , ByVal ls_IdDestino As String _
              , ByVal ls_Destino As String _
              , ByVal ls_IdEscala As String _
              , ByVal ls_Escala As String _
              , ByVal lb_IndEscala As Integer _
              , ByVal lb_ViajeVacio As Integer _
              , ByVal lb_ViajeRetorno As Integer _
              , ByVal ls_IdPiloto As String _
              , ByVal ls_Piloto As String _
              , ByVal lb_DisponibleP As Boolean _
              , ByVal ls_IdCopiloto As String _
              , ByVal ls_Copiloto As String _
              , ByVal lb_DisponibleC As Boolean _
              , ByVal ls_IdAyudante As String _
              , ByVal ls_Ayudante As String _
              , ByVal lb_DisponibleA As Boolean _
              , ByVal ls_IdTracto As String _
              , ByVal ls_Tracto As String _
              , ByVal ls_IdTipoVehiculo As String _
              , ByVal ls_TipoVehiculo As String _
              , ByVal ls_IdCarreta As String _
              , ByVal ls_Carreta As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Cliente As String _
              , ByVal ls_CargaMaterial As String _
              , ByVal ls_GlosaEscala As String _
              , ByVal li_Carga As Integer _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ls_UsuarioSeguimiento As String _
              , ByVal ld_LlegadaOrigen As Date _
              , ByVal ld_IngresoComplejoOrigen As Date _
              , ByVal ld_CargaOrigen As Date _
              , ByVal ld_TerminoCargaOrigen As Date _
              , ByVal ld_ImpresionGuiaOrigen As Date _
              , ByVal ld_SalidaOrigen As Date _
              , ByVal ld_LlegadaAproximadaDestino As Date _
              , ByVal ld_LlegadaDestino As Date _
              , ByVal ld_IngresoDestino As Date _
              , ByVal ld_DescargaDestino As Date _
              , ByVal ld_TerminoDescargaDestino As Date _
              , ByVal ld_SalidaDestino As Date _
              , ByVal ls_Flota As String _
              , ByVal ls_IncidenciaOperaciones As String _
              , ByVal ls_IncidenciaSeguimiento As String _
              , ByVal lb_Turno As Integer _
              , ByVal lb_DiaNoche As Integer _
              , ByVal lb_PesoToneladas As Decimal _
              , ByVal lb_TotalFlete As Decimal _
              , ByVal ls_Zona As String _
              , ByVal lb_KmTractoOrigen As Decimal _
              , ByVal lb_KmTractoDestino As Decimal _
              , ByVal lb_KmCarretaOrigen As Decimal _
              , ByVal lb_KmCarretaDestino As Decimal _
              , ByVal ls_Tesoreria As String _
              , ByVal lb_IndFecha As Integer _
              , ByVal lb_PorcentajeFlete As Decimal _
              , ByVal ld_Cantidad As Decimal _
              , ByVal ld_FleteUnitario As Decimal _
              , ByVal lb_IncluyeIgv As Boolean _
              , ByVal ld_Capacidad As Decimal _
              , ByVal li_IndCarga As Integer _
              , ByVal ld_Produccion As Decimal _
              , ByVal ld_FechaCrea As Date _
              , ByVal ld_FechaModifica As Date _
              , ByVal li_IndPlanilla As Integer _
              , ByVal ls_IdCentro As String)
        _Seleccion = lb_Seleccion
        _id = ls_Id
        _codigo = ls_Codigo
        _idoperacion = ls_IdOperacion
        _operacion = ls_Operacion
        _idorigen = ls_IdOrigen
        _origen = ls_Origen
        _iddestino = ls_IdDestino
        _destino = ls_Destino
        _idescala = ls_IdEscala
        _escala = ls_Escala
        _indescala = lb_IndEscala
        _viajevacio = lb_ViajeVacio
        _viajeretorno = lb_ViajeRetorno
        _idpiloto = ls_IdPiloto
        _piloto = ls_Piloto
        _dispiloto = lb_DisponibleP
        _idcopiloto = ls_IdCopiloto
        _copiloto = ls_Copiloto
        _discopiloto = lb_DisponibleC
        _idayudante = ls_IdAyudante
        _ayudante = ls_Ayudante
        _disayudante = lb_DisponibleA
        _idtracto = ls_IdTracto
        _tracto = ls_Tracto
        _idtipovehiculo = ls_IdTipoVehiculo
        _tipovehiculo = ls_TipoVehiculo
        _idcarreta = ls_IdCarreta
        _carreta = ls_Carreta
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _fecha = ld_Fecha
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _cliente = ls_Cliente
        _CargaMaterial = ls_CargaMaterial
        _GlosaEscala = ls_GlosaEscala
        _carga = li_Carga
        _UsuarioModifica = ls_UsuarioModifica
        _UsuarioSeguimiento = ls_UsuarioSeguimiento
        _llegadaorigen = ld_LlegadaOrigen
        _ingresocomplejoorigen = ld_IngresoComplejoOrigen
        _cargaorigen = ld_CargaOrigen
        _terminocargaorigen = ld_TerminoCargaOrigen
        _impresionguiaorigen = ld_ImpresionGuiaOrigen
        _salidaorigen = ld_SalidaOrigen
        _llegadaaproximadadestino = ld_LlegadaAproximadaDestino
        _llegadadestino = ld_LlegadaDestino
        _ingresodestino = ld_IngresoDestino
        _descargadestino = ld_DescargaDestino
        _terminodescargadestino = ld_TerminoDescargaDestino
        _salidadestino = ld_SalidaDestino
        _Flota = ls_Flota
        _IncidenciaOperaciones = ls_IncidenciaOperaciones
        _IncidenciaSeguimiento = ls_IncidenciaSeguimiento
        _Turno = lb_Turno
        _DiaNoche = lb_DiaNoche
        _PesoToneladas = lb_PesoToneladas
        _TotalFlete = lb_TotalFlete
        _Zona = ls_Zona
        _KmTractoOrigen = lb_KmTractoOrigen
        _KmTractoDestino = lb_KmTractoDestino
        _KmCarretaOrigen = lb_KmCarretaOrigen
        _KmCarretaDestino = lb_KmCarretaDestino
        _Tesoreria = ls_Tesoreria
        _IndFecha = lb_IndFecha
        _PorcentajeFlete = lb_PorcentajeFlete
        _cantidad = ld_Cantidad
        _fleteunitario = ld_FleteUnitario
        _IncluyeIgv = lb_IncluyeIgv
        _capacidad = ld_Capacidad
        _IndCarga = li_IndCarga
        _produccion = ld_Produccion
        _fechacrea = ld_FechaCrea
        _fechamodifica = ld_FechaModifica
        _IndPlanilla = li_IndPlanilla
        _IdCentro = ls_IdCentro

    End Sub

#End Region

    Public Function Obtener(ByVal viaje As e_Viaje) As e_Viaje Implements Ie_Viaje.Obtener
        Return viaje
    End Function

    Public Function CalcularTotalFlete(ByVal FleteUnitario As Double, ByVal Igv As Double) As Double Implements Ie_Viaje.CalcularTotalFlete

        Return (FleteUnitario * Igv) + FleteUnitario
    End Function

End Class


