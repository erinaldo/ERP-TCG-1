' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ZonaProceso" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ZonaProceso.svc o e_ZonaProceso.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_ZonaProceso
    Implements Ie_ZonaProceso

    'Public Sub DoWork() Implements Ie_ZonaProceso.DoWork
    'End Sub
#Region "Propiedad"

    Private _id As String
    Private _idactividadnegocio As String
    Private _idcliente As String
    Private _idzona As String
    Private _monto As Decimal
    Private _costofijo As Decimal
    Private _semana As Decimal
    Private _observacion As String
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _actual As Boolean
    Private _fechacreacion As Date
    Private _activo As Boolean
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property IdActividadNegocio() As String
        Get
            Return _idactividadnegocio
        End Get
        Set(ByVal value As String)
            _idactividadnegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Zona() As String
        Get
            Return _idzona
        End Get
        Set(ByVal value As String)
            _idzona = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoFijo() As Decimal
        Get
            Return _costofijo
        End Get
        Set(ByVal value As Decimal)
            _costofijo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Semana() As Decimal
        Get
            Return _semana
        End Get
        Set(ByVal value As Decimal)
            _semana = value
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
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _fechafin
        End Get
        Set(ByVal value As Date)
            _fechafin = value
        End Set
    End Property

    <DataMember()> _
        Public Property Actual() As Boolean
        Get
            Return _actual
        End Get
        Set(ByVal value As Boolean)
            _actual = value
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
    Public Property FechaCreacion() As String
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As String)
            _fechacreacion = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        Id = ""
        Actual = 1
        IdActividadNegocio = ""
        IdCliente = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
                  , ByVal ls_IdActividadNegocio As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_IdZona As String _
              , ByVal ld_Monto As Decimal _
              , ByVal ld_CostoFijo As Decimal _
              , ByVal ld_Semana As Decimal _
              , ByVal ls_Observacion As String _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Actual As Boolean _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idactividadnegocio = ls_IdActividadNegocio
        _idcliente = ls_IdCliente
        _idzona = ls_IdZona
        _monto = ld_Monto
        _costofijo = ld_CostoFijo
        _semana = ld_Semana
        _observacion = ls_Observacion
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _fechacreacion = ld_FechaCreacion
        _actual = lb_Actual
        _activo = lb_Activo
    End Sub

#End Region
End Class
