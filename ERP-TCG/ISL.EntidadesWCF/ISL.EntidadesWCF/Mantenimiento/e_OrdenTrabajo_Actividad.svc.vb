<DataContract()> _
Public Class e_OrdenTrabajo_Actividad
    Implements Ie_OrdenTrabajo_Actividad

#Region "Propiedad"

    Private _id As String
    Private _actividad As String
    Private _ordentrabajo As String
    Private _mantenimientoequipo As String
    Private _cantidaddias As Integer
    Private _cantidadhoras As Integer
    Private _cantidadminutos As Integer
    Private _activo As Boolean
    Private _usuariocreacion As String

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
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdActividad() As String
        Get
            Return _actividad
        End Get
        Set(ByVal value As String)
            _actividad = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrdenTrabajo() As String
        Get
            Return _ordentrabajo
        End Get
        Set(ByVal value As String)
            _ordentrabajo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMantenimientoEquipo() As String
        Get
            Return _mantenimientoequipo
        End Get
        Set(ByVal value As String)
            _mantenimientoequipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadDias() As Integer
        Get
            Return _cantidaddias
        End Get
        Set(ByVal value As Integer)
            _cantidaddias = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadHoras() As Integer
        Get
            Return _cantidadhoras
        End Get
        Set(ByVal value As Integer)
            _cantidadhoras = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMinutos() As Integer
        Get
            Return _cantidadminutos
        End Get
        Set(ByVal value As Integer)
            _cantidadminutos = value
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

#End Region

#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdActividad As String _
              , ByVal ls_IdOrdenTrabajo As String _
              , ByVal ls_IdMantenimientoEquipo As String _
              , ByVal ln_CantidadHoras As Integer _
              , ByVal lb_Activo As Boolean _
             )
        _id = ls_Id
        _actividad = ls_IdActividad
        _ordentrabajo = ls_IdOrdenTrabajo
        _mantenimientoequipo = ls_IdMantenimientoEquipo
        _cantidadhoras = ln_CantidadHoras
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal ordenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As e_OrdenTrabajo_Actividad Implements Ie_OrdenTrabajo_Actividad.Obtener
        Return ordenTrabajo_Actividad
    End Function

End Class
