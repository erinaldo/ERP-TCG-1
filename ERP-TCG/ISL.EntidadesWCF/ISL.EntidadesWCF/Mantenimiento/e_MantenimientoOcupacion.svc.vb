<DataContract()> _
Public Class e_MantenimientoOcupacion
    Implements Ie_MantenimientoOcupacion

#Region "Propiedad"
    Private _seleccion As Boolean
    Private _id As String
    Private _idocupacion As String
    Private _ocupacion As String
    Private _codocupacion As String
    Private _mantenimiento As String
    Private _cantidad As Integer
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
    Public Property IdMantenimiento() As String
        Get
            Return _mantenimiento
        End Get
        Set(ByVal value As String)
            _mantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOcupacion() As String
        Get
            Return _idocupacion
        End Get
        Set(ByVal value As String)
            _idocupacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            _ocupacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codocupacion
        End Get
        Set(ByVal value As String)
            _codocupacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
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
               , ByVal ls_IdOcupacion As String _
                , ByVal ls_Ocupacion As String _
                 , ByVal ls_Codigo As String _
              , ByVal ln_Cantidad As Integer _
              , ByVal ls_Activo As Boolean _
             )
        _id = ls_Id
        _idocupacion = ls_IdOcupacion
        _ocupacion = ls_Ocupacion
        _codocupacion = ls_Codigo
        _mantenimiento = ls_IdMantenimiento
        _cantidad = ln_Cantidad
        _activo = ls_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal mantenimientoOcupacion As e_MantenimientoOcupacion) As e_MantenimientoOcupacion Implements Ie_MantenimientoOcupacion.Obtener
        Return mantenimientoOcupacion
    End Function

End Class
