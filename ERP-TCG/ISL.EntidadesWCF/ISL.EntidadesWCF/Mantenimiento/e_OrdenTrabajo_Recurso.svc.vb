<DataContract()> _
Public Class e_OrdenTrabajo_Recurso
    Implements Ie_OrdenTrabajo_Recurso

#Region "Propiedad"

    Private _id As String
    Private _ocupaciontrabajador As String
    Private _ordentrabajo As String
    Private _mantenimientoequipo As String
    Private _cantidadhoras As Date
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property IdOcupacionTrabajador() As String
        Get
            Return _ocupaciontrabajador
        End Get
        Set(ByVal value As String)
            _ocupaciontrabajador = value
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
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdOcupacionTrabajador As String _
              , ByVal ls_IdOrdenTrabajo As String _
              , ByVal ls_IdMantenimientoEquipo As String _
              , ByVal ln_CantidadHoras As Date _
              , ByVal ls_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _ocupaciontrabajador = ls_IdOcupacionTrabajador
        _ordentrabajo = ls_IdOrdenTrabajo
        _mantenimientoequipo = ls_IdMantenimientoEquipo
        _cantidadhoras = ln_CantidadHoras
        _activo = ls_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal ordenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As e_OrdenTrabajo_Recurso Implements Ie_OrdenTrabajo_Recurso.Obtener
        Return ordenTrabajo_Recurso
    End Function

End Class
