' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_VehiculoPilotoOperacion" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_VehiculoPilotoOperacion.svc o e_VehiculoPilotoOperacion.svc.vb en el Explorador de soluciones e inicie la depuración.

<DataContract()> _
Public Class e_VehiculoPilotoOperacion
    Implements Ie_VehiculoPilotoOperacion

    'Public Sub DoWork() Implements Ie_VehiculoPilotoOperacion.DoWork
    'End Sub
#Region "Propiedad"

    Private _id As String
    Private _idvehiculo As String
    Private _idpiloto As String
    Private _idactividadnegocio As String
    Private _idcliente As String
    Private _observacion As String
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _indvp As Integer
    Private _indhistorial As Integer
    Private _actual As Integer
    Private _activo As Boolean
    Private _usuariocrea As String
    Private _fechacreacion As Date


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
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
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
   Public Property IndVP() As Integer
        Get
            Return _indvp
        End Get
        Set(ByVal value As Integer)
            _indvp = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndHistorial() As Integer
        Get
            Return _indhistorial
        End Get
        Set(ByVal value As Integer)
            _indhistorial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Actual() As Integer
        Get
            Return _actual
        End Get
        Set(ByVal value As Integer)
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
    Public Property UsuarioCrea() As String
        Get
            Return _usuariocrea
        End Get
        Set(ByVal value As String)
            _usuariocrea = value
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
        IndHistorial = 0
        IndVP = 0
        Actual = 1
        Activo = 1
        IdActividadNegocio = ""
        IdPiloto = ""
        IdVehiculo = ""
        IdCliente = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
                   , ByVal ls_IdVehiculo As String _
              , ByVal ls_IdPiloto As String _
              , ByVal ls_IdActividadNegocio As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_Observacion As String _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ln_IndVP As Integer _
              , ByVal ln_IndHistorial As Integer _
              , ByVal lb_Actual As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ld_FechaCreacion As Date)
        _id = ls_Id
        _idvehiculo = ls_IdVehiculo
        _idpiloto = ls_IdPiloto
        _idactividadnegocio = ls_IdActividadNegocio
        _idcliente = ls_IdCliente
        _observacion = ls_Observacion
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _indvp = ln_IndVP
        _indhistorial = ln_IndHistorial
        _actual = lb_Actual
        _activo = lb_Activo
        _usuariocrea = ls_UsuarioCrea
        _fechacreacion = ld_FechaCreacion
    End Sub

#End Region

End Class
