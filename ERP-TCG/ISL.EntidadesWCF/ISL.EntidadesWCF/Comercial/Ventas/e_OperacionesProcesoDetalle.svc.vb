' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_OperacionesProcesoDetalle" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_OperacionesProcesoDetalle.svc o e_OperacionesProcesoDetalle.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_OperacionesProcesoDetalle
    Implements Ie_OperacionesProcesoDetalle

    Public Sub DoWork() Implements Ie_OperacionesProcesoDetalle.DoWork
    End Sub
#Region "Propiedad"

    Private _id As String
    Private _idoperacionproceso As String
    Private _idviaje As String
    Private _idoperaciondetalle As String
    Private _viaje As String
    Private _semana As String
    Private _tracto As String
    Private _carreta As String
    Private _dia As String
    Private _fecha As Date
    Private _origen As String
    Private _destino As String
    Private _zona As String
    Private _ntransporte As String
    Private _glosa As String
    Private _tipocarga As String
    Private _km As Double
    Private _factor As Double
    Private _costoviaje As Double
    Private _fleteunitario As Double
    Private _flete As Double
    Private _observacion As String
    Private _activo As Boolean
    Private _viajeretorno As Boolean
    Private _viajevacio As Boolean
    <DataMember()> _
    Public TipoOperacion As String

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
    Public Property IdOperacionProceso() As String
        Get
            Return _idoperacionproceso
        End Get
        Set(ByVal value As String)
            _idoperacionproceso = value
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
    Public Property IdOperacionDetalle() As String
        Get
            Return _idoperaciondetalle
        End Get
        Set(ByVal value As String)
            _idoperaciondetalle = value
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
    Public Property Semana() As String
        Get
            Return _semana
        End Get
        Set(ByVal value As String)
            _semana = value
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
    Public Property Carreta() As String
        Get
            Return _carreta
        End Get
        Set(ByVal value As String)
            _carreta = value
        End Set
    End Property
    <DataMember()> _
    Public Property Dia() As String
        Get
            Return _dia
        End Get
        Set(ByVal value As String)
            _dia = value
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
    Public Property Origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
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
    Public Property Zona() As String
        Get
            Return _zona
        End Get
        Set(ByVal value As String)
            _zona = value
        End Set
    End Property
    <DataMember()> _
    Public Property NTransporte() As String
        Get
            Return _ntransporte
        End Get
        Set(ByVal value As String)
            _ntransporte = value
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
    Public Property TipoCarga() As String
        Get
            Return _tipocarga
        End Get
        Set(ByVal value As String)
            _tipocarga = value
        End Set
    End Property
    <DataMember()> _
    Public Property KM() As Double
        Get
            Return _km
        End Get
        Set(ByVal value As Double)
            _km = value
        End Set
    End Property
    <DataMember()> _
    Public Property Factor() As Double
        Get
            Return _factor
        End Get
        Set(ByVal value As Double)
            _factor = value
        End Set
    End Property
    <DataMember()> _
    Public Property CostoViaje() As Double
        Get
            Return _costoviaje
        End Get
        Set(ByVal value As Double)
            _costoviaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property FleteUnitario() As Double
        Get
            Return _fleteunitario
        End Get
        Set(ByVal value As Double)
            _fleteunitario = value
        End Set
    End Property
    <DataMember()> _
    Public Property Flete() As Double
        Get
            Return _flete
        End Get
        Set(ByVal value As Double)
            _flete = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property
    <DataMember()> _
    Public Property ViajeRetorno() As Boolean
        Get
            Return _viajeretorno
        End Get
        Set(ByVal value As Boolean)
            _viajeretorno = value
        End Set
    End Property
    <DataMember()> _
    Public Property ViajeVacio() As Boolean
        Get
            Return _viajevacio
        End Get
        Set(ByVal value As Boolean)
            _viajevacio = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        Id = ""
        IdOperacionProceso = ""
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdOperacionProceso As String _
              , ByVal ls_IdViaje As String _
              , ByVal ls_IdOperacionDetalle As String _
              , ByVal ls_Viaje As String _
              , ByVal ls_Semana As String _
              , ByVal ls_Tracto As String _
              , ByVal ls_Carreta As String _
              , ByVal ls_Dia As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Origen As String _
              , ByVal ls_Destino As String _
              , ByVal ls_Zona As String _
              , ByVal ls_NTransporte As String _
              , ByVal ls_Glosa As String _
              , ByVal ls_TipoCarga As String _
              , ByVal ln_KM As Double _
              , ByVal ln_Factor As Double _
              , ByVal ln_CostoViaje As Double _
              , ByVal ln_FleteUnitario As Double _
              , ByVal ln_Flete As Double _
              , ByVal ls_Observacion As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idoperacionproceso = ls_IdOperacionProceso
        _idviaje = ls_IdViaje
        _idoperaciondetalle = ls_IdOperacionDetalle
        _viaje = ls_Viaje
        _semana = ls_Semana
        _tracto = ls_Tracto
        _carreta = ls_Carreta
        _dia = ls_Dia
        _fecha = ld_Fecha
        _origen = ls_Origen
        _destino = ls_Destino
        _zona = ls_Zona
        _ntransporte = ls_NTransporte
        _glosa = ls_Glosa
        _tipocarga = ls_TipoCarga
        _km = ln_KM
        _factor = ln_Factor
        _costoviaje = ln_CostoViaje
        _fleteunitario = ln_FleteUnitario
        _flete = ln_Flete
        _observacion = ls_Observacion
        _activo = lb_Activo
    End Sub

#End Region

End Class
