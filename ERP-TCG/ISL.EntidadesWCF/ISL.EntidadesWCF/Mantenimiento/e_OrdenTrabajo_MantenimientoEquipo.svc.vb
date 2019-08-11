<DataContract()> _
Public Class e_OrdenTrabajo_MantenimientoEquipo
    Implements Ie_OrdenTrabajo_MantenimientoEquipo

#Region "Propiedad"
    Private _seleccion As Boolean
    Private _id As String
    Private _ordentrabajo As String
    Private _mantenimientoequipo As String
    Private _idequipo As String
    Private _equipo As String
    Private _idmantenimiento As String
    Private _mantenimiento As String
    Private _tipomantenimiento As String
    Private _odometro As Double
    Private _horometro As Double
    Private _trabajador As String
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
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
    Public Property IdMantenimiento() As String
        Get
            Return _idmantenimiento
        End Get
        Set(ByVal value As String)
            _idmantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Mantenimiento() As String
        Get
            Return _mantenimiento
        End Get
        Set(ByVal value As String)
            _mantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMantenimiento() As String
        Get
            Return _tipomantenimiento
        End Get
        Set(ByVal value As String)
            _tipomantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEquipo() As String
        Get
            Return _idequipo
        End Get
        Set(ByVal value As String)
            _idequipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Equipo() As String
        Get
            Return _equipo
        End Get
        Set(ByVal value As String)
            _equipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Odometro() As Double
        Get
            Return _odometro
        End Get
        Set(ByVal value As Double)
            _odometro = value
        End Set
    End Property

    <DataMember()> _
    Public Property Horometro() As Double
        Get
            Return _horometro
        End Get
        Set(ByVal value As Double)
            _horometro = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajadorResponsable() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
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
    Sub New()

    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_IdOrdenTrabajo As String _
              , ByVal ls_IdMantenimientoEquipo As String _
              , ByVal ls_IdMantenimiento As String _
              , ByVal ls_Mantenimiento As String _
              , ByVal ls_TipoMantenimiento As String _
              , ByVal ls_IdEquipo As String _
              , ByVal ls_Equipo As String _
              , ByVal ln_Odometro As Double _
              , ByVal ln_Horometro As Double _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _ordentrabajo = ls_IdOrdenTrabajo
        _mantenimientoequipo = ls_IdMantenimientoEquipo
        _idmantenimiento = ls_IdMantenimiento
        _mantenimiento = ls_Mantenimiento
        _tipomantenimiento = ls_TipoMantenimiento
        _idequipo = ls_IdEquipo
        _equipo = ls_Equipo
        _odometro = ln_Odometro
        _horometro = ln_Horometro
        _activo = lb_Activo
        _seleccion = lb_Seleccion
    End Sub

#End Region

    Public Function Obtener(ByVal ordenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As e_OrdenTrabajo_MantenimientoEquipo Implements Ie_OrdenTrabajo_MantenimientoEquipo.Obtener
        Return ordenTrabajo_MantenimientoEquipo
    End Function

End Class
