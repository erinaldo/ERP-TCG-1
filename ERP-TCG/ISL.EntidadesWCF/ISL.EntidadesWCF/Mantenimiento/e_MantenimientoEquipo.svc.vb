<DataContract()> _
Public Class e_MantenimientoEquipo
    Implements Ie_MantenimientoEquipo

#Region "Propiedad"
    Private _seleccion As Boolean
    Private _Id As String
    Private _idMantenimiento As String
    Private _Mantenimiento As String
    Private _idtipoMantenimiento As String
    Private _tipoMantenimiento As String
    Private _idEquipo As String
    Private _Equipo As String
    Private _codEquipo As String
    Private _idmarca As String
    Private _marca As String
    Private _idmodelo As String
    Private _modelo As String
    Private _idvehiculo As String
    Private _CantidadMedida As Double
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _tipovehiculo As String

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
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMantenimiento() As String
        Get
            Return _idMantenimiento
        End Get
        Set(ByVal value As String)
            _idMantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Mantenimiento() As String
        Get
            Return _Mantenimiento
        End Get
        Set(ByVal value As String)
            _Mantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoMantenimiento() As String
        Get
            Return _idtipoMantenimiento
        End Get
        Set(ByVal value As String)
            _idtipoMantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMantenimiento() As String
        Get
            Return _tipoMantenimiento
        End Get
        Set(ByVal value As String)
            _tipoMantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEquipo() As String
        Get
            Return _idEquipo
        End Get
        Set(ByVal value As String)
            _idEquipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codEquipo
        End Get
        Set(ByVal value As String)
            _codEquipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Equipo() As String
        Get
            Return _Equipo
        End Get
        Set(ByVal value As String)
            _Equipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMarca() As String
        Get
            Return _idmarca
        End Get
        Set(ByVal value As String)
            _idmarca = value
        End Set
    End Property

    <DataMember()> _
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdModelo() As String
        Get
            Return _idmodelo
        End Get
        Set(ByVal value As String)
            _idmodelo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
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
   Public Property TipoVehiculo() As String
        Get
            Return _tipovehiculo
        End Get
        Set(ByVal value As String)
            _tipovehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMedida() As Double
        Get
            Return _CantidadMedida
        End Get
        Set(ByVal value As Double)
            _CantidadMedida = value
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

    Public Sub New(ByVal lb_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_IdMantenimiento As String _
              , ByVal ls_Mantenimiento As String _
              , ByVal ls_TipoMantenimiento As String _
              , ByVal ls_IdEquipo As String _
              , ByVal ls_CodigoEquipo As String _
              , ByVal ls_Equipo As String _
              , ByVal ls_IdMarca As String _
              , ByVal ls_Marca As String _
              , ByVal ls_IdModelo As String _
              , ByVal ls_Modelo As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ln_CantidadMedida As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_TipoVehiculo As String _
                          )
        _Id = ls_Id
        _idMantenimiento = ls_IdMantenimiento
        _Mantenimiento = ls_Mantenimiento
        _tipoMantenimiento = ls_TipoMantenimiento
        _idEquipo = ls_IdEquipo
        _codEquipo = ls_CodigoEquipo
        _Equipo = ls_Equipo
        _idmarca = ls_IdMarca
        _marca = ls_Marca
        _idmodelo = ls_IdModelo
        _modelo = ls_Modelo
        _idvehiculo = ls_IdVehiculo
        _CantidadMedida = ln_CantidadMedida
        _activo = lb_Activo
        _seleccion = lb_Seleccion
        _tipovehiculo = ls_TipoVehiculo

    End Sub

#End Region

    Public Function Obtener(ByVal mantenimientoEquipo As e_MantenimientoEquipo) As e_MantenimientoEquipo Implements Ie_MantenimientoEquipo.Obtener
        Return mantenimientoEquipo
    End Function

End Class
