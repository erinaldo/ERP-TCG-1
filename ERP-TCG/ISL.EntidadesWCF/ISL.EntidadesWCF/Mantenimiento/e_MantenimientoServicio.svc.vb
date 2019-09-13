<DataContract()> _
Public Class e_MantenimientoServicio
    Implements Ie_MantenimientoServicio

#Region "Propiedad"
    Private _seleccion As Boolean
    Private _id As String
    Private _mantenimiento As String
    Private _idservicio As String
    Private _servicio As String
    Private _codservicio As String
    Private _idtiposervicio As String
    Private _equipo As String
    Private _cantidad As Double
    Private _costo As Double
    Private _descripcion As String
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
    Public Property IdMantenimiento() As String
        Get
            Return _mantenimiento
        End Get
        Set(ByVal value As String)
            _mantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdServicio() As String
        Get
            Return _idservicio
        End Get
        Set(ByVal value As String)
            _idservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codservicio
        End Get
        Set(ByVal value As String)
            _codservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Servicio() As String
        Get
            Return _servicio
        End Get
        Set(ByVal value As String)
            _servicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCategoriaServicio() As String
        Get
            Return _idtiposervicio
        End Get
        Set(ByVal value As String)
            _idtiposervicio = value
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
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Costo() As Double
        Get
            Return _costo
        End Get
        Set(ByVal value As Double)
            _costo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
              , ByVal ls_IdServicio As String _
              , ByVal ls_CodigoServicio As String _
              , ByVal ls_Servicio As String _
              , ByVal ls_IdEquipo As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_Costo As Double _
              , ByVal ls_Descripcion As String _
              , ByVal ls_Activo As String _
           )
        _id = ls_Id
        _mantenimiento = ls_IdMantenimiento
        _idservicio = ls_IdServicio
        _servicio = ls_Servicio
        _codservicio = ls_CodigoServicio
        _equipo = ls_IdEquipo
        _cantidad = ln_Cantidad
        _costo = ln_Costo
        _descripcion = ls_Descripcion
        _activo = ls_Activo
        _seleccion = lb_Seleccion
    End Sub

#End Region

    Public Function Obtener(ByVal mantenimientoServicio As e_MantenimientoServicio) As e_MantenimientoServicio Implements Ie_MantenimientoServicio.Obtener
        Return mantenimientoServicio
    End Function

End Class
