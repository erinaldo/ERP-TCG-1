' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_CuadreCajaGasto" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_CuadreCajaGasto.svc o e_CuadreCajaGasto.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_CuadreCajaGasto
    Implements Ie_CuadreCajaGasto

#Region "Propiedad"

    Private _id As String
    Private _idcuadrecaja As String
    Private _tipodocumento As New e_TipoDocumento
    Private _fecha As Date
    Private _importe As Double
    Private _glosa As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
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
    Public Property IdTipoDocumento() As String
        Get
            Return _tipodocumento.Id
        End Get
        Set(ByVal value As String)
            _tipodocumento.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocumento() As String
        Get
            Return _tipodocumento.Nombre
        End Get
        Set(ByVal value As String)
            _tipodocumento.Nombre = value
            RaiseEvent DatoCambiado()
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
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
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
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_TipoDocumento As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_Importe As Double _
              , ByVal ls_Glosa As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idcuadrecaja = ls_IdCuadreCaja
        _tipodocumento.Id = ls_IdTipoDocumento
        _tipodocumento.Nombre = ls_TipoDocumento
        _fecha = ld_Fecha
        _importe = ln_Importe
        _glosa = ls_Glosa
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(cuadrecajagasto As e_CuadreCajaGasto) As e_CuadreCajaGasto Implements Ie_CuadreCajaGasto.Obtener
        Return cuadrecajagasto
    End Function

End Class
