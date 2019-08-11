' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_CentroCostoUbicaciones" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_CentroCostoUbicaciones.svc o e_CentroCostoUbicaciones.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_CentroCostoUbicaciones
    Implements Ie_CentroCostoUbicaciones

    Public Sub DoWork() Implements Ie_CentroCostoUbicaciones.DoWork
    End Sub

#Region "Propiedad"

    Private _id As String
    Private _idcentrocosto As String
    Private _nombre As String
    Private _descripciondetallada As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public UsuarioCreacion As String

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
    Public Property IdCentroCosto() As String
        Get
            Return _idcentrocosto
        End Get
        Set(ByVal value As String)
            _idcentrocosto = value
        End Set
    End Property
    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    <DataMember()> _
    Public Property DescripcionDetallada() As String
        Get
            Return _descripciondetallada
        End Get
        Set(ByVal value As String)
            _descripciondetallada = value
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
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCentroCosto As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_DescripcionDetallada As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idcentrocosto = ls_IdCentroCosto
        _nombre = ls_Nombre
        _descripciondetallada = ls_DescripcionDetallada
        _activo = lb_Activo
    End Sub

#End Region

End Class
