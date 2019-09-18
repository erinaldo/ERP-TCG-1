' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_OperacionesProceso" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_OperacionesProceso.svc o e_OperacionesProceso.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_OperacionesProceso
    Implements Ie_OperacionesProceso

    Public Sub DoWork() Implements Ie_OperacionesProceso.DoWork
    End Sub

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _idcliente As String
    Private _idactividadnegocio As String
    Private _semana As Double
    Private _total As Double
    Private _costoadicional As Double
    Private _costototal As Double
    Private _observacion As String
    Private _idestado As String
    Private _fechacrea As Date
    Private _fechamodifica As Date
    Private _usuariocrea As String
    Private _usuariomodifica As String
    Private _activo As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public ListProcesoDetalle As New List(Of e_OperacionesProcesoDetalle)
    <DataMember()> _
    Public ListTarifaProceso As New List(Of e_ProcesarTarifasProceso)
    <DataMember()> _
    Public ListOperacionDetalle As New List(Of e_OperacionDetalle)

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
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
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
    Public Property Semana() As Double
        Get
            Return _semana
        End Get
        Set(ByVal value As Double)
            _semana = value
        End Set
    End Property
    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property
    <DataMember()> _
    Public Property CostoAdicional() As Double
        Get
            Return _costoadicional
        End Get
        Set(ByVal value As Double)
            _costoadicional = value
        End Set
    End Property
    <DataMember()> _
    Public Property CostoTotal() As Double
        Get
            Return _costototal
        End Get
        Set(ByVal value As Double)
            _costototal = value
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
    <DataMember()>
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaCrea() As Date
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
    Public Property UsuarioCrea() As String
        Get
            Return _usuariocrea
        End Get
        Set(ByVal value As String)
            _usuariocrea = value
        End Set
    End Property
    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
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

#End Region
#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        Id = ""
        Codigo = ""
        IdEstado = ""
        Activo = True
        FechaInicio = Date.Now
        FechaFin = Date.Now
        IdCliente = ""
        IdActividadNegocio = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ls_IdCliente As String _
              , ByVal ls_IdActividadNegocio As String _
              , ByVal ln_Semana As Double _
              , ByVal ln_Total As Double _
              , ByVal ln_CostoAdicional As Double _
              , ByVal ln_CostoTotal As Double _
              , ByVal ls_Observacion As String _
              , ByVal ls_IdEstado As String _
              , ByVal ld_FechaCrea As Date _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _idcliente = ls_IdCliente
        _idactividadnegocio = ls_IdActividadNegocio
        _semana = ln_Semana
        _total = ln_Total
        _costoadicional = ln_CostoAdicional
        _costototal = ln_CostoTotal
        _observacion = ls_Observacion
        _idestado = ls_IdEstado
        _fechacrea = ld_FechaCrea
        _fechamodifica = ld_FechaModifica
        _usuariocrea = ls_UsuarioCrea
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region
End Class
