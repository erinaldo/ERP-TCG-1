' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_TiempoServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_TiempoServicio.svc o e_TiempoServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_CalculaTiempoServicio
    Implements Ie_CalculaTiempoServicio

    Private _tiemposerviciototal As String
    Private _dtcantidaddias As Integer
    Private _dttiempototal As String
    Private _fechainiciodt As Date
    Private _fechainiciovt As Date
    Private _fechainiciocts As Date
    Private _fechainiciogt As Date
    Private _gtcantidaddias As Integer
    Private _gtcantidadmeses As Integer
    Private _gttiempototal As String
    Private _vtdiasvacaciones As Integer
    Private _vtcantidaddias As Integer
    Private _vtcandidadmeses As Integer
    Private _vtcantidadaños As Integer
    Private _vttiempototal As String
    Private _ctscantidaddias As Integer
    Private _ctscantidadmeses As Integer
    Private _ctstiempototal As String
    Private _porcentajeafp As Double
    Private _adelantos As Double
    Private _bonificacionproduccion As Double
    Private _6togratificacion As Double

    Private _vtfaltas As Integer
    Private _dtfaltas As Integer
    Private _ctsfaltas As Integer
    Private _gtfaltas As Integer
    Private _retencion5ta As Double
    Private _descuentos As Double
    Private _promediohorasextras As Double
    
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()> _
    Public FechaCese As Date
    <DataMember()> _
    Public IdTrabajador As String
    <DataMember()> _
    Public IdPeriodo As String
    Dim _diastrabajadostotal As String

    <DataMember()> _
    Public Property DTCantidadDias() As Integer
        Get
            Return _dtcantidaddias
        End Get
        Set(ByVal value As Integer)
            _dtcantidaddias = value
        End Set
    End Property

    <DataMember()> _
    Public Property DTTiempoTotal() As String
        Get
            Return _dttiempototal
        End Get
        Set(ByVal value As String)
            _dttiempototal = value
        End Set
    End Property

    <DataMember()> _
    Public Property VTDiasVacaciones() As Integer
        Get
            Return _vtdiasvacaciones
        End Get
        Set(ByVal value As Integer)
            _vtdiasvacaciones = value
        End Set
    End Property

    <DataMember()> _
    Public Property GTCantidadDias() As Integer
        Get
            Return _gtcantidaddias
        End Get
        Set(ByVal value As Integer)
            _gtcantidaddias = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioVT() As Date
        Get
            Return _fechainiciovt
        End Get
        Set(ByVal value As Date)
            _fechainiciovt = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonificacionProduccion() As Double
        Get
            Return _bonificacionproduccion
        End Get
        Set(ByVal value As Double)
            _bonificacionproduccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property ToGratificacion() As Double
        Get
            Return _6togratificacion
        End Get
        Set(ByVal value As Double)
            _6togratificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioDT() As Date
        Get
            Return _fechainiciodt
        End Get
        Set(ByVal value As Date)
            _fechainiciodt = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioCTS() As Date
        Get
            Return _fechainiciocts
        End Get
        Set(ByVal value As Date)
            _fechainiciocts = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioGT() As Date
        Get
            Return _fechainiciogt
        End Get
        Set(ByVal value As Date)
            _fechainiciogt = value
        End Set
    End Property

    <DataMember()> _
    Public Property GTCantidadMeses() As Integer
        Get
            Return _gtcantidadmeses
        End Get
        Set(ByVal value As Integer)
            _gtcantidadmeses = value
        End Set
    End Property

    <DataMember()> _
    Public Property Adelantos() As Double
        Get
            Return _adelantos
        End Get
        Set(ByVal value As Double)
            _adelantos = value
        End Set
    End Property

    <DataMember()> _
    Public Property GTTiempoTotal() As String
        Get
            Return _gttiempototal
        End Get
        Set(ByVal value As String)
            _gttiempototal = value
        End Set
    End Property

    <DataMember()> _
    Public Property VTCantidadDias() As Integer
        Get
            Return _vtcantidaddias
        End Get
        Set(ByVal value As Integer)
            _vtcantidaddias = value
        End Set
    End Property

    <DataMember()> _
    Public Property VTCantidadMeses() As Integer
        Get
            Return _vtcandidadmeses
        End Get
        Set(ByVal value As Integer)
            _vtcandidadmeses = value
        End Set
    End Property

    <DataMember()> _
    Public Property VTCantidadAños() As Integer
        Get
            Return _vtcantidadaños
        End Get
        Set(ByVal value As Integer)
            _vtcantidadaños = value
        End Set
    End Property

    <DataMember()> _
    Public Property VTTiempoTotal() As String
        Get
            Return _vttiempototal
        End Get
        Set(ByVal value As String)
            _vttiempototal = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeAFP() As Double
        Get
            Return _porcentajeafp
        End Get
        Set(ByVal value As Double)
            _porcentajeafp = value
        End Set
    End Property

    <DataMember()> _
    Public Property CTSCantidadDias() As Integer
        Get
            Return _ctscantidaddias
        End Get
        Set(ByVal value As Integer)
            _ctscantidaddias = value
        End Set
    End Property

    <DataMember()> _
    Public Property CTSCantidadMeses() As Integer
        Get
            Return _ctscantidadmeses
        End Get
        Set(ByVal value As Integer)
            _ctscantidadmeses = value
        End Set
    End Property

    <DataMember()> _
    Public Property CTSTiempoTotal() As String
        Get
            Return _ctstiempototal
        End Get
        Set(ByVal value As String)
            _ctstiempototal = value
        End Set
    End Property

    <DataMember()> _
    Public Property TiempoServicioTotal() As String
        Get
            Return _tiemposerviciototal
        End Get
        Set(ByVal value As String)
            _tiemposerviciototal = value
        End Set
    End Property

    <DataMember()> _
    Public Property GTfaltas() As Integer
        Get
            Return _gtfaltas
        End Get
        Set(ByVal value As Integer)
            _gtfaltas = value
        End Set
    End Property

    <DataMember()> _
    Public Property DTfaltas() As Integer
        Get
            Return _dtfaltas
        End Get
        Set(ByVal value As Integer)
            _dtfaltas = value
        End Set
    End Property

    <DataMember()> _
    Public Property CTSfaltas() As Integer
        Get
            Return _ctsfaltas
        End Get
        Set(ByVal value As Integer)
            _ctsfaltas = value
        End Set
    End Property

    <DataMember()> _
    Public Property VTfaltas() As Integer
        Get
            Return _vtfaltas
        End Get
        Set(ByVal value As Integer)
            _vtfaltas = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descuentos() As Double
        Get
            Return _descuentos
        End Get
        Set(ByVal value As Double)
            _descuentos = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion5ta() As Double
        Get
            Return _retencion5ta
        End Get
        Set(ByVal value As Double)
            _retencion5ta = value
        End Set
    End Property

    <DataMember()> _
    Public Property PromedioHorasExtras() As Double
        Get
            Return _promediohorasextras
        End Get
        Set(ByVal value As Double)
            _promediohorasextras = value
        End Set
    End Property



    Public Sub New()
        FechaInicio = Date.Parse("01/01/1901")
        FechaCese = Date.Parse("01/01/1901")
        FechaInicioCTS = Date.Parse("01/01/1901")
        FechaInicioGT = Date.Parse("01/01/1901")
        FechaInicioVT = Date.Parse("01/01/1901")
        FechaInicioDT = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal ls_TiempoServicioTotal As String _
                   , ByVal ld_dtFechaInicio As Date _
                   , ByVal li_dtCantidadDias As Integer _
                   , ByVal ls_dtTiempoTotal As String _
                   , ByVal ld_gtFechaInicio As Date _
                   , ByVal li_gtCantidadDias As Integer _
                   , ByVal li_gtCantidadMeses As Integer _
                   , ByVal ls_gtTiempoTotal As String _
                   , ByVal ld_vtFechaInicio As Date _
                   , ByVal li_vtDiasVacaciones As Integer _
                   , ByVal li_vtCantidadDias As Integer _
                   , ByVal li_vtCantidadMeses As Integer _
                   , ByVal li_vtCantidadAños As Integer _
                   , ByVal ls_vtTiempoTotal As String _
                   , ByVal ld_ctsFechaInicio As Date _
                   , ByVal li_ctsCantidadDias As Integer _
                   , ByVal li_ctsCantidadMeses As Integer _
                   , ByVal ls_ctsTiempoTotal As String _
                   , ByVal ld_PorcentajeAFP As Double _
                   , ByVal ld_Adelantos As Double _
                   , ByVal ld_BonificacionProduccion As Double _
                   , ByVal ld_6toGratificacion As Double)
        _tiemposerviciototal = ls_TiempoServicioTotal
        _fechainiciodt = ld_dtFechaInicio
        _dtcantidaddias = li_dtCantidadDias
        _dttiempototal = ls_dtTiempoTotal
        _fechainiciocts = ld_ctsFechaInicio
        _fechainiciogt = ld_gtFechaInicio
        _fechainiciovt = ld_vtFechaInicio
        _gtcantidaddias = li_gtCantidadDias
        _gtcantidadmeses = li_gtCantidadMeses
        _gttiempototal = ls_gtTiempoTotal
        _vtdiasvacaciones = li_vtDiasVacaciones
        _vtcantidaddias = li_vtCantidadDias
        _vtcandidadmeses = li_vtCantidadMeses
        _vtcantidadaños = li_vtCantidadAños
        _vttiempototal = ls_vtTiempoTotal
        _ctscantidaddias = li_ctsCantidadDias
        _ctscantidadmeses = li_ctsCantidadMeses
        _ctstiempototal = ls_ctsTiempoTotal
        _porcentajeafp = ld_PorcentajeAFP
        _adelantos = ld_Adelantos
        _bonificacionproduccion = ld_BonificacionProduccion
        _6togratificacion = ld_6toGratificacion
    End Sub

    Public Function Obtener(ByVal calculatiemposervicio As e_CalculaTiempoServicio) As e_CalculaTiempoServicio Implements Ie_CalculaTiempoServicio.Obtener
        Return calculatiemposervicio
    End Function

End Class
