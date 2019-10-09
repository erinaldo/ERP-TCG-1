' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_VehiculoEstado" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_VehiculoEstado.svc o e_VehiculoEstado.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_VehiculoEstado
    Implements Ie_VehiculoEstado

    Public Sub DoWork() Implements Ie_VehiculoEstado.DoWork
    End Sub

#Region "Variables"

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Private _Id As String
    Private _IdVehiculo As String
    Private _Indicador As Integer
    Private _Observacion As String
    Private _FechaInicio As Date
    Private _FechaFin As Date
    Private _UsuarioCrea As String
    Private _FechaCrea As Date
    Private _Actual As Boolean
    Private _Activo As Boolean
#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
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
    Public Property Indicador() As Integer
        Get
            Return _Indicador
        End Get
        Set(ByVal value As Integer)
            _Indicador = value
        End Set
    End Property
    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
        End Set
    End Property
    <DataMember()> _
    Public Property UsuarioCrea() As String
        Get
            Return _UsuarioCrea
        End Get
        Set(ByVal value As String)
            _UsuarioCrea = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
        End Set
    End Property
    <DataMember()> _
    Public Property Actual() As Boolean
        Get
            Return _Actual
        End Get
        Set(ByVal value As Boolean)
            _Actual = value
        End Set
    End Property
    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Id = ""
        IdVehiculo = ""
        Indicador = 0
        Observacion = ""
        FechaInicio = #1/1/1901#
        FechaFin = #1/1/1901#
        UsuarioCrea = ""
        FechaCrea = #1/1/1901#
        Actual = False
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ln_Indicador As Integer _
              , ByVal ls_Observacion As String _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ld_FechaCrea As Date _
              , ByVal lb_Actual As Boolean _
              , ByVal lb_Activo As Boolean)
        _Id = ls_Id
        _IdVehiculo = ls_IdVehiculo
        _Indicador = ln_Indicador
        _Observacion = ls_Observacion
        _FechaInicio = ld_FechaInicio
        _FechaFin = ld_FechaFin
        _UsuarioCrea = ls_UsuarioCrea
        _FechaCrea = ld_FechaCrea
        _Actual = lb_Actual
        _Activo = lb_Activo
    End Sub

#End Region

End Class
