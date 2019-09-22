<DataContract()> _
Public Class e_MantenimientoActividad
    Implements Ie_MantenimientoActividad

#Region "Propiedad"
    Private _seleccion As Boolean
    Private _id As String
    Private _idactividad As String
    Private _actividad As String
    Private _codactividad As String
    Private _idmantenimiento As String
    Private _cantidadhoras As Date
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""

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
    Public Property IdActividad() As String
        Get
            Return _idactividad
        End Get
        Set(ByVal value As String)
            _idactividad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Actividad() As String
        Get
            Return _actividad
        End Get
        Set(ByVal value As String)
            _actividad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codactividad
        End Get
        Set(ByVal value As String)
            _codactividad = value
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
    Public Property CantidadHoras() As Date
        Get
            Return _cantidadhoras
        End Get
        Set(ByVal value As Date)
            _cantidadhoras = value
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
        _id = ""
        _idactividad = ""
        _actividad = ""
        _codactividad = ""
        _idmantenimiento = ""
        _cantidadhoras = "01/01/1901"
        _activo = True

    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_IdMantenimiento As String _
              , ByVal ls_IdActividad As String _
              , ByVal ls_Actividad As String _
              , ByVal ls_Codigo As String _
              , ByVal ln_CantidadHoras As Date _
              , ByVal lb_Activo As Boolean _
                )
        _id = ls_Id
        _idactividad = ls_IdActividad
        _actividad = ls_Actividad
        _codactividad = ls_Codigo
        _idmantenimiento = ls_IdMantenimiento
        _cantidadhoras = ln_CantidadHoras
        _activo = lb_Activo
        _seleccion = lb_Seleccion
    End Sub

#End Region

    Public Function Obtener(ByVal mantenimientoActividad As e_MantenimientoActividad) As e_MantenimientoActividad Implements Ie_MantenimientoActividad.Obtener
        Return mantenimientoActividad
    End Function

End Class
