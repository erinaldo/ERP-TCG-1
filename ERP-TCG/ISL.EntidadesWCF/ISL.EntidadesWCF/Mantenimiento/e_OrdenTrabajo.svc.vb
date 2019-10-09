<DataContract()> _
Public Class e_OrdenTrabajo
    Implements Ie_OrdenTrabajo


#Region "Declaracion de Variables"

    Private _id As String
    Private _nroot As String
    Private _estadoot As String
    Private _idestadoot As String
    Private _fechaprogramacionini As Date
    Private _fechaprogramacionfin As Date
    Private _fechaingresotaller As Date
    Private _fechainiciotrabajo As Date
    Private _fechafintrabajo As Date
    Private _fechatentativasalida As Date
    Private _calibracion As Boolean
    Private _glosa As String
    Private _auxilio As Boolean
    Private _siniestro As Boolean
    Private _indicadortipo As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _tipoorden As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    <DataMember()> _
    Public lstDetalleEquipoMantenimiento As New List(Of e_OrdenTrabajo_MantenimientoEquipo)
    <DataMember()> _
    Public lstDetalleMaterial As New List(Of e_OrdenTrabajo_Material)
    <DataMember()> _
    Public lstDetalleServicio As New List(Of e_OrdenTrabajo_Servicio)
    <DataMember()> _
    Public lstDetalleRecurso As New List(Of e_OrdenTrabajo_Recurso)
    <DataMember()> _
    Public lstDetalleActividad As New List(Of e_OrdenTrabajo_Actividad)
    <DataMember()> _
    Public lstRequerimiento As New List(Of e_Requerimiento)
    <DataMember()> _
    Public UsuarioTermina As String = ""
    <DataMember()> _
    Public PrefijoCentro As String = ""
    <DataMember()> _
    Public TrabajadorSolicita As String = ""
    <DataMember()> _
    Public oeOCOT As New e_OrdenCmp_OrdenTrb

    Private _equipo As String
    Private _tipomantenimiento As String
    Private _mantenimiento As String
    Private _SupervisorMant As String
    Private _JefeTaller As String
    Private _empresaexterna As String

#End Region

#Region "Propiedad"

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
    Public Property NroOT() As String
        Get
            Return _nroot
        End Get
        Set(ByVal value As String)
            _nroot = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstadoOT() As String
        Get
            Return _idestadoot
        End Get
        Set(ByVal value As String)
            _idestadoot = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoOT() As String
        Get
            Return _estadoot
        End Get
        Set(ByVal value As String)
            _estadoot = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaProgramacionIni() As Date
        Get
            Return _fechaprogramacionini
        End Get
        Set(ByVal value As Date)
            _fechaprogramacionini = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaProgramacionFin() As Date
        Get
            Return _fechaprogramacionfin
        End Get
        Set(ByVal value As Date)
            _fechaprogramacionfin = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngresoTaller() As Date
        Get
            Return _fechaingresotaller
        End Get
        Set(ByVal value As Date)
            _fechaingresotaller = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioTrabajo() As Date
        Get
            Return _fechainiciotrabajo
        End Get
        Set(ByVal value As Date)
            _fechainiciotrabajo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFinTrabajo() As Date
        Get
            Return _fechafintrabajo
        End Get
        Set(ByVal value As Date)
            _fechafintrabajo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaTentativaSalida() As Date
        Get
            Return _fechatentativasalida
        End Get
        Set(ByVal value As Date)
            _fechatentativasalida = value
        End Set
    End Property

    <DataMember()> _
    Public Property Calibracion() As Boolean
        Get
            Return _calibracion
        End Get
        Set(ByVal value As Boolean)
            _calibracion = value
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
    Public Property IdJefeTaller() As String
        Get
            Return _JefeTaller
        End Get
        Set(ByVal value As String)
            _JefeTaller = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSupervisorMant() As String
        Get
            Return _SupervisorMant
        End Get
        Set(ByVal value As String)
            _SupervisorMant = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresaExterna() As String
        Get
            Return _empresaexterna
        End Get
        Set(ByVal value As String)
            _empresaexterna = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndicadorTipo() As String
        Get
            Return _indicadortipo
        End Get
        Set(ByVal value As String)
            _indicadortipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Auxilio() As Boolean
        Get
            Return _auxilio
        End Get
        Set(ByVal value As Boolean)
            _auxilio = value
        End Set
    End Property


    <DataMember()> _
Public Property Siniestro() As Boolean
        Get
            Return _siniestro
        End Get
        Set(ByVal value As Boolean)
            _siniestro = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
    Public Property IdEquipo() As String
        Get
            Return _equipo
        End Get
        Set(ByVal value As String)
            _equipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoMantenimiento() As String
        Get
            Return _tipomantenimiento
        End Get
        Set(ByVal value As String)
            _tipomantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMantenimiento() As String
        Get
            Return _mantenimiento
        End Get
        Set(ByVal value As String)
            _mantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoOrden() As String
        Get
            Return _tipoorden
        End Get
        Set(ByVal value As String)
            _tipoorden = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _nroot = ""
        _idestadoot = ""
        _estadoot = ""
        _indicadortipo = "I"
        _fechaprogramacionfin = "01/01/1900"
        _fechaprogramacionini = "01/01/1900"
        _fechaingresotaller = "01/01/1900"
        _fechainiciotrabajo = "01/01/1900"
        _fechafintrabajo = "01/01/1900"
        _fechatentativasalida = "01/01/1900"
        _JefeTaller = ""
        _SupervisorMant = ""
        _empresaexterna = ""
        _glosa = ""
        _activo = True
        _auxilio = False
        _calibracion = False
        _usuariocreacion = ""
        _fechacreacion = "01/01/1900"
        _tipoorden = "0"
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_NroOT As String _
              , ByVal ls_IdEstadoOT As String _
              , ByVal ls_EstadoOT As String _
              , ByVal lb_IndicadorTipo As String _
              , ByVal ld_FechaProgramacionIni As Date _
              , ByVal ld_FechaIngresoTaller As Date _
              , ByVal ld_FechaInicioTrabajo As Date _
              , ByVal ld_FechaFinTrabajo As Date _
              , ByVal ld_FechaTentativaSalida As Date _
              , ByVal ls_IdJefeTaller As String _
              , ByVal ls_SupervisorMant As String _
              , ByVal ls_Glosa As String _
              , ByVal lb_Auxilio As Boolean _
              , ByVal lb_Calibracion As Boolean _
              , ByVal ls_IdEmpresaExterna As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Siniestro As Boolean _
              , ByVal ls_TipoOrden As String _
              )
        _id = ls_Id
        _nroot = ls_NroOT
        _idestadoot = ls_IdEstadoOT
        _estadoot = ls_EstadoOT
        _indicadortipo = lb_IndicadorTipo
        _fechaprogramacionini = ld_FechaProgramacionIni
        _fechaingresotaller = ld_FechaIngresoTaller
        _fechainiciotrabajo = ld_FechaInicioTrabajo
        _fechafintrabajo = ld_FechaFinTrabajo
        _fechatentativasalida = ld_FechaTentativaSalida
        _JefeTaller = ls_IdJefeTaller
        _SupervisorMant = ls_SupervisorMant
        _empresaexterna = ls_IdEmpresaExterna
        _glosa = ls_Glosa
        _activo = lb_Activo
        _auxilio = lb_Auxilio
        _siniestro = lb_Siniestro
        _calibracion = lb_Calibracion
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _tipoorden = ls_TipoOrden
    End Sub

#End Region

    Public Function Obtener(ByVal ordenTrabajo As e_OrdenTrabajo) As e_OrdenTrabajo Implements Ie_OrdenTrabajo.Obtener
        Return ordenTrabajo
    End Function

End Class
