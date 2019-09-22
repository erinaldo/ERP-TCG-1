' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "CuadreCajaBolsa" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CuadreCajaBolsa.svc o CuadreCajaBolsa.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_CuadreCajaBolsa
    Implements Ie_CuadreCajaBolsa

#Region "Propiedad"

    Private _id As String
    Private _idcuadrecaja As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _fecha As Date
    Private _importe As Double
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
    Public Property IdCuadreCaja() As String
        Get
            Return _idcuadrecaja
        End Get
        Set(ByVal value As String)
            _idcuadrecaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
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

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdCuadreCaja As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_Importe As Double _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idcuadrecaja = ls_IdCuadreCaja
        _idtrabajador = ls_IdTrabajador
        _trabajador = ls_Trabajador
        _fecha = ld_Fecha
        _importe = ln_Importe
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(cuadrecajabolsa As e_CuadreCajaBolsa) As e_CuadreCajaBolsa Implements Ie_CuadreCajaBolsa.Obtener
        Return cuadrecajabolsa
    End Function

End Class
