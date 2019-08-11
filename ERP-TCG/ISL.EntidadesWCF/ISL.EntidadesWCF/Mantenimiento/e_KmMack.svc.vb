' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_KmMack" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_KmMack.svc o e_KmMack.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_KmMack
    Implements Ie_KmMack

#Region "Declaración de variables"

    Private _Id As String
    Private _Codigo As String
    Private _IdEstado As String
    Private _Estado As String
    Private _Fecha As Date
    Private _CostoKm As Double
    Private _TipoCambio As Double
    Private _Serie As String
    Private _Numero As String
    Private _Total As Double
    Private _FechaCreacion As Date
    Private _UsuarioCreacion As String
    Private _Activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public loKmMackDet As List(Of e_KmMackDet)

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _Codigo = "0000"
        _IdEstado = ""
        _Estado = ""
        _Fecha = #1/1/1901#
        _CostoKm = 0
        _TipoCambio = 0
        _Serie = ""
        _Numero = ""
        _Total = 0
        _FechaCreacion = #1/1/1901#
        _UsuarioCreacion = ""
        _Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_CostoKm As Double _
              , ByVal ln_TipoCambio As Double _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ln_Total As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _Id = ls_Id
        _Codigo = IIf(ls_Codigo.Trim = "", "0", ls_Codigo.Trim)
        _IdEstado = ls_IdEstado
        _Estado = ls_Estado
        _Fecha = ld_Fecha
        _CostoKm = ln_CostoKm
        _TipoCambio = ln_TipoCambio
        _Serie = ls_Serie
        _Numero = ls_Numero
        _Total = ln_Total
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
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _IdEstado
        End Get
        Set(ByVal value As String)
            _IdEstado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoKm() As Double
        Get
            Return _CostoKm
        End Get
        Set(ByVal value As Double)
            _CostoKm = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCambio() As Double
        Get
            Return _TipoCambio
        End Get
        Set(ByVal value As Double)
            _TipoCambio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _Serie
        End Get
        Set(ByVal value As String)
            _Serie = value
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _Numero
        End Get
        Set(ByVal value As String)
            _Numero = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _Total
        End Get
        Set(ByVal value As Double)
            _Total = value
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

    Public Function Obtener(KmMack As e_KmMack) As e_KmMack Implements Ie_KmMack.Obtener
        Return KmMack
    End Function

#End Region

End Class
