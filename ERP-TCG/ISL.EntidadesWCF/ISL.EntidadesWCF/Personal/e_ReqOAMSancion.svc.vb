' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ReqOAMSancion" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ReqOAMSancion.svc o e_ReqOAMSancion.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ReqOAMSancion
    Implements Ie_ReqOAMSancion

#Region "Propiedad"

    Private _id As String
    Private _idrequerimientomaterial As String
    Private _idordenasignacionmaterial As String
    Private _idsancion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Event DatoCambiado()

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
    Public Property IdRequerimientoMaterial() As String
        Get
            Return _idrequerimientomaterial
        End Get
        Set(ByVal value As String)
            _idrequerimientomaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrdenAsignacionMaterial() As String
        Get
            Return _idordenasignacionmaterial
        End Get
        Set(ByVal value As String)
            _idordenasignacionmaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdSancion() As String
        Get
            Return _idsancion
        End Get
        Set(ByVal value As String)
            _idsancion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdRequerimientoMaterial As String _
              , ByVal ls_IdOrdenAsignacionMaterial As String _
              , ByVal ls_IdSancion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idrequerimientomaterial = ls_IdRequerimientoMaterial
        _idordenasignacionmaterial = ls_IdOrdenAsignacionMaterial
        _idsancion = ls_IdSancion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal sancion As e_ReqOAMSancion) As e_ReqOAMSancion Implements Ie_ReqOAMSancion.Obtener
        Return sancion
    End Function

End Class
