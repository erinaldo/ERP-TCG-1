' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_MovimientoActivoFijo" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_MovimientoActivoFijo.svc o e_MovimientoActivoFijo.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_MovimientoActivoFijo
    Implements Ie_MovimientoActivoFijo

    Public Sub DoWork() Implements Ie_MovimientoActivoFijo.DoWork
    End Sub

#Region "Propiedad"

    Private _id As String
    Private _idactivofijo As String
    Private _idubicacionorigen As String
    Private _idubicaciondestino As String
    Private _fechatraslado As Date
    Private _descripcion As String
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""

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
    Public Property IdActivoFijo() As String
        Get
            Return _idactivofijo
        End Get
        Set(ByVal value As String)
            _idactivofijo = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdUbicacionOrigen() As String
        Get
            Return _idubicacionorigen
        End Get
        Set(ByVal value As String)
            _idubicacionorigen = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdUbicacionDestino() As String
        Get
            Return _idubicaciondestino
        End Get
        Set(ByVal value As String)
            _idubicaciondestino = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaTraslado() As Date
        Get
            Return _fechatraslado
        End Get
        Set(ByVal value As Date)
            _fechatraslado = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
        TipoOperacion = ""
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdActivoFijo As String _
              , ByVal ls_IdUbicacionOrigen As String _
              , ByVal ls_IdUbicacionDestino As String _
              , ByVal ld_FechaTraslado As Date _
              , ByVal ls_Descripcion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String)
        _id = ls_Id
        _idactivofijo = ls_IdActivoFijo
        _idubicacionorigen = ls_IdUbicacionOrigen
        _idubicaciondestino = ls_IdUbicacionDestino
        _fechatraslado = ld_FechaTraslado
        _descripcion = ls_Descripcion
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

End Class
