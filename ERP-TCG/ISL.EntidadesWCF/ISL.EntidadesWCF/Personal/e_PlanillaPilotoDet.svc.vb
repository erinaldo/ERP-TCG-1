' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_PlanillaPilotoDet" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_PlanillaPilotoDet.svc o e_PlanillaPilotoDet.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_PlanillaPilotoDet
    Implements Ie_PlanillaPilotoDet

#Region "Propiedad"

    Private _id As String
    Private _idplanillapiloto As New e_PlanillaPiloto
    Private _idtrabajador As New e_Trabajador
    Private _tipotrabajador As Integer
    Private _trabajador As String
    Private _dni As String
    Private _montototal As Double
    Private _cuenta As Integer
    Private _tipo As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
    Public Property IdPlanillaPiloto() As String
        Get
            Return _idplanillapiloto.Id
        End Get
        Set(ByVal value As String)
            _idplanillapiloto.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cuenta() As Integer
        Get
            Return _cuenta
        End Get
        Set(ByVal value As Integer)
            _cuenta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador.Id
        End Get
        Set(ByVal value As String)
            _idtrabajador.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoTrabajador() As Integer
        Get
            Return _tipotrabajador
        End Get
        Set(ByVal value As Integer)
            _tipotrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
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
    Public Property MontoTotal() As Double
        Get
            Return _montototal
        End Get
        Set(ByVal value As Double)
            _montototal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
        Cuenta = 0
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdPlanillaPiloto As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal li_TipoTrabajador As Integer _
              , ByVal ls_dni As String _
              , ByVal ln_MontoTotal As Double _
              , ByVal li_Cuenta As Integer _
              , ByVal li_Tipo As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idplanillapiloto.Id = ls_IdPlanillaPiloto
        _idtrabajador.Id = ls_IdTrabajador
        _tipotrabajador = li_TipoTrabajador
        _trabajador = ls_Trabajador
        _dni = ls_dni
        _montototal = ln_MontoTotal
        _cuenta = li_Cuenta
        _tipo = li_Tipo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(planillapilotoDet As e_PlanillaPilotoDet) As e_PlanillaPilotoDet Implements Ie_PlanillaPilotoDet.Obtener
        Return planillapilotoDet
    End Function

End Class
