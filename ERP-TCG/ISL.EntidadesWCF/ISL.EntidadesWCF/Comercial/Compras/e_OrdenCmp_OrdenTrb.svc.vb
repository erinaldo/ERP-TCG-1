' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_OrdenCmp_OrdenTrb" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_OrdenCmp_OrdenTrb.svc o e_OrdenCmp_OrdenTrb.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_OrdenCmp_OrdenTrb
    Implements Ie_OrdenCmp_OrdenTrb

#Region "Propiedad"

    Private _id As String
    Private _idordencompra As String
    Private _idordentrabajo As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property IdOrdenCompra() As String
        Get
            Return _idordencompra
        End Get
        Set(ByVal value As String)
            _idordencompra = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrdenTrabajo() As String
        Get
            Return _idordentrabajo
        End Get
        Set(ByVal value As String)
            _idordentrabajo = value
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
        Id = ""
        IdOrdenCompra = ""
        IdOrdenTrabajo = ""
        Activo = True
        TipoOperacion = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdOrdenCompra As String _
              , ByVal ls_IdOrdenTrabajo As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idordencompra = ls_IdOrdenCompra
        _idordentrabajo = ls_IdOrdenTrabajo
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ocot As e_OrdenCmp_OrdenTrb) As e_OrdenCmp_OrdenTrb Implements Ie_OrdenCmp_OrdenTrb.Obtener
        Return ocot
    End Function

End Class
