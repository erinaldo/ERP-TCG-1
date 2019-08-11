' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_KmMackDet" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_KmMackDet.svc o e_KmMackDet.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_KmMackDet
    Implements Ie_KmMackDet

#Region "Declaración de variables"

    Private _Id As String
    Private _IdKmMack As String
    Private _IdEquipo As String
    Private _Equipo As String
    Private _KmInicial As Double
    Private _KmFinal As Double
    Private _KmTotal As Double
    Private _Importe As Double
    Private _FechaCreacion As Date
    Private _UsuarioCreacion As String
    Private _Activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdKmMack = ""
        _IdEquipo = ""
        _Equipo = ""
        _KmInicial = 0
        _KmFinal = 0
        _KmTotal = 0
        _Importe = 0
        _FechaCreacion = #1/1/1901#
        _UsuarioCreacion = ""
        _Activo = True
    End Sub

    Public Sub New( _
               ls_Id As String _
              , ByVal ls_IdKmMack As String _
              , ByVal ls_IdEquipo As String _
              , ByVal ls_Equipo As String _
              , ByVal ln_KmInicial As Double _
              , ByVal ln_KmFinal As Double _
              , ByVal ln_KmTotal As Double _
              , ByVal ln_Importe As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _Id = ls_Id
        _IdKmMack = ls_IdKmMack
        _IdEquipo = ls_IdEquipo
        _Equipo = ls_Equipo
        _KmInicial = ln_KmInicial
        _KmFinal = ln_KmFinal
        _KmTotal = ln_KmTotal
        _Importe = ln_Importe
        _FechaCreacion = ld_FechaCreacion
        _UsuarioCreacion = ls_UsuarioCreacion
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
    Public Property IdKmMack() As String
        Get
            Return _IdKmMack
        End Get
        Set(ByVal value As String)
            _IdKmMack = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEquipo() As String
        Get
            Return _IdEquipo
        End Get
        Set(ByVal value As String)
            _IdEquipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Equipo() As String
        Get
            Return _Equipo
        End Get
        Set(ByVal value As String)
            _Equipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmInicial() As Double
        Get
            Return _KmInicial
        End Get
        Set(ByVal value As Double)
            _KmInicial = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmFinal() As Double
        Get
            Return _KmFinal
        End Get
        Set(ByVal value As Double)
            _KmFinal = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmTotal() As Double
        Get
            Return _KmTotal
        End Get
        Set(ByVal value As Double)
            _KmTotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _Importe
        End Get
        Set(ByVal value As Double)
            _Importe = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
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

    Public Function Obtener(KmMack As e_KmMackDet) As e_KmMackDet Implements Ie_KmMackDet.Obtener
        Return KmMack
    End Function

#End Region

End Class
