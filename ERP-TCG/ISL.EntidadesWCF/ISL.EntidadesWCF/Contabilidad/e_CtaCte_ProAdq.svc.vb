' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_CtaCte_ProAdq" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_CtaCte_ProAdq.svc o e_CtaCte_ProAdq.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_CtaCte_ProAdq
    Implements Ie_CtaCte_ProAdq
    Implements IEquatable(Of e_CtaCte_ProAdq)

#Region "Declaración de variables"

    Private _Id As String
    Private _IdClienteProveedor As String
    Private _Empresa As String
    Private _Cuenta As String
    Private _indclipro As Integer
    Private _TipoEmpresa As String
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _Activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdClienteProveedor = ""
        _Cuenta = ""
        _Empresa = ""
        _indclipro = 0
        _TipoEmpresa = ""
        _UsuarioCreacion = ""
        _FechaCreacion = Date.Parse("01/01/1901")
        _Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdClienteProveedor As String _
              , ByVal ls_Empresa As String _
              , ByVal ls_Cuenta As String _
              , ByVal li_IndCliPro As Integer _
              , ByVal ls_TipoEmpresa As String _
              , ByVal ls_Usuario As String _
              , ByVal ld_FechaCreacion As String _
              , ByVal lb_Activo As Boolean)
        _Id = ls_Id
        _IdClienteProveedor = ls_IdClienteProveedor
        _Empresa = ls_Empresa
        _Cuenta = ls_Cuenta
        _indclipro = li_IndCliPro
        _TipoEmpresa = ls_TipoEmpresa
        _UsuarioCreacion = ls_Usuario
        _Activo = lb_Activo
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdClienteProveedor() As String
        Get
            Return _IdClienteProveedor
        End Get
        Set(ByVal value As String)
            _IdClienteProveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property Empresa() As String
        Get
            Return _Empresa
        End Get
        Set(ByVal value As String)
            _Empresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cuenta() As String
        Get
            Return _Cuenta
        End Get
        Set(ByVal value As String)
            _Cuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCliPro() As Integer
        Get
            Return _indclipro
        End Get
        Set(ByVal value As Integer)
            _indclipro = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoEmpresa() As String
        Get
            Return _TipoEmpresa
        End Get
        Set(ByVal value As String)
            _TipoEmpresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal ctacte As e_CtaCte_ProAdq) As e_CtaCte_ProAdq Implements Ie_CtaCte_ProAdq.Obtener
        Return ctacte
    End Function

    Public Function Equals1(other As e_CtaCte_ProAdq) As Boolean Implements IEquatable(Of e_CtaCte_ProAdq).Equals
        If Me.Id.Trim = other.Id.Trim Then Return True
        Return False
    End Function

#End Region

End Class
