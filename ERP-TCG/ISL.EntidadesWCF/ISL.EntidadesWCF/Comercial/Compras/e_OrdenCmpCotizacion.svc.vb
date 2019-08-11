' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_OrdenCmpCotizacion" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_OrdenCmpCotizacion.svc o e_OrdenCmpCotizacion.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_OrdenCmpCotizacion
    Implements Ie_OrdenCmpCotizacion

#Region "Propiedad"

    Private _id As String
    Private _idordencompra As String
    Private _idcotizacion As String
    Private _activo As Boolean
    Private _idequipo As String
    Private _orometro As Double
    
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
    Public Property IdCotizacion() As String
        Get
            Return _idcotizacion
        End Get
        Set(ByVal value As String)
            _idcotizacion = value
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

    <DataMember()> _
    Public Property Orometro() As Double
        Get
            Return _orometro
        End Get
        Set(ByVal value As Double)
            _orometro = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        IdOrdenCompra = ""
        IdCotizacion = ""
        Orometro = 0
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdOrdenCompra As String _
              , ByVal ls_IdCotizacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdEquipo As String _
              , ByVal ld_Orometro As Double)
        _id = ls_Id
        _idordencompra = ls_IdOrdenCompra
        _idcotizacion = ls_IdCotizacion
        _activo = lb_Activo
        _idequipo = ls_IdEquipo
        _orometro = ld_Orometro
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal oe As e_OrdenCmpCotizacion) As e_OrdenCmpCotizacion Implements Ie_OrdenCmpCotizacion.Obtener
        Return oe
    End Function

#End Region

End Class
