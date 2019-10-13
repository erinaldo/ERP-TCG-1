' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_RendimientoCombustible" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_RendimientoCombustible.svc o e_RendimientoCombustible.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_RendimientoCombustible
    Implements Ie_RendimientoCombustible

#Region "Declaración de variables"

    Private _Id As String
    Private _IdTipoVehiculo As String
    Private _IdFlota As String
    Private _IdUnidadMedida As String
    Private _Peso As Double
    Private _Rendimiento As Double
    Private _Activo As Boolean
    Private _UsuarioCreacion As String
    Private _UsuarioModificacion As String
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Propiedades"

    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    Public Property IdTipoVehiculo() As String
        Get
            Return _IdTipoVehiculo
        End Get
        Set(ByVal value As String)
            _IdTipoVehiculo = value
        End Set
    End Property

    Public Property IdFlota() As String
        Get
            Return _IdFlota
        End Get
        Set(ByVal value As String)
            _IdFlota = value
        End Set
    End Property

    Public Property IdUnidadMedida() As String
        Get
            Return _IdUnidadMedida
        End Get
        Set(ByVal value As String)
            _IdUnidadMedida = value
        End Set
    End Property

    Public Property Peso() As Double
        Get
            Return _Peso
        End Get
        Set(ByVal value As Double)
            _Peso = value
        End Set
    End Property

    Public Property Rendimiento() As Double
        Get
            Return _Rendimiento
        End Get
        Set(ByVal value As Double)
            _Rendimiento = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    Public Property UsuarioModificacion() As String
        Get
            Return _UsuarioModificacion
        End Get
        Set(ByVal value As String)
            _UsuarioModificacion = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdTipoVehiculo = ""
        _IdFlota = ""
        _IdUnidadMedida = ""
        _Peso = 0
        _Rendimiento = 0
        _Activo = True
        _UsuarioCreacion = ""
        _UsuarioModificacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTipoVehiculo As String _
              , ByVal ls_IdFlota As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ln_Peso As Double _
              , ByVal ln_Rendimiento As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_UsuarioModificacion As String _
           )
        _Id = ls_Id
        _IdTipoVehiculo = ls_IdTipoVehiculo
        _IdFlota = ls_IdFlota
        _IdUnidadMedida = ls_IdUnidadMedida
        _Peso = ln_Peso
        _Rendimiento = ln_Rendimiento
        _Activo = lb_Activo
        _UsuarioCreacion = ls_UsuarioCreacion
        _UsuarioModificacion = ls_UsuarioModificacion
    End Sub

#End Region

#Region "Método"

    Public Function Obtener(ByVal rendimientocombustible As e_RendimientoCombustible) As e_RendimientoCombustible Implements Ie_RendimientoCombustible.Obtener
        Return rendimientocombustible
    End Function

#End Region

End Class
