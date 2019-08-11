' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_DetallePlanillaPiloto" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_DetallePlanillaPiloto.svc o e_DetallePlanillaPiloto.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_DetallePlanillaPiloto
    Implements Ie_DetallePlanillaPiloto

    Private _monto As Double
    Private _puesto As String
    Private _ruta As String
    Private _trabajador As String
    Private _fechaviaje As Date
    Private _tracto As String
    Private _tipo As String
    Private _viaje As String
    Private _cuenta As Integer
    
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public IdPlanilla As String
    <DataMember()> _
    Public IdTrabajador As String

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Puesto() As String
        Get
            Return _puesto
        End Get
        Set(ByVal value As String)
            _puesto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaViaje() As Date
        Get
            Return _fechaviaje
        End Get
        Set(ByVal value As Date)
            _fechaviaje = value
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
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
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
    Public Property Cuenta() As Integer
        Get
            Return _cuenta
        End Get
        Set(ByVal value As Integer)
            _cuenta = value
        End Set
    End Property

    Public Sub New()
        TipoOperacion = "D"
    End Sub

    Public Sub New(ByVal ls_Viaje As String _
          , ByVal ls_Tipo As String _
          , ByVal ls_Trabajador As String _
          , ByVal ls_Tracto As String _
          , ByVal ls_FechaViaje As Date _
          , ByVal ls_Ruta As String _
          , ByVal ls_Puesto As String _
          , ByVal ls_Monto As Double _
          , ByVal ls_Cuenta As Integer)
        _viaje = ls_Viaje
        _tipo = ls_Tipo
        _trabajador = ls_Trabajador
        _tracto = ls_Tracto
        _fechaviaje = ls_FechaViaje
        _ruta = ls_Ruta
        _puesto = ls_Puesto
        _monto = ls_Monto
        _cuenta = ls_Cuenta
    End Sub

    Public Function obtener(oeDetallePlanilla As e_DetallePlanillaPiloto) As e_DetallePlanillaPiloto Implements Ie_DetallePlanillaPiloto.obtener
        Return oeDetallePlanilla
    End Function

End Class
