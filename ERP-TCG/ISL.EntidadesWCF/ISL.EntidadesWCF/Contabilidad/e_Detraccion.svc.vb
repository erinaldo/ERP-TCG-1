' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Detraccion" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Detraccion.svc o e_Detraccion.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_Detraccion
    Implements Ie_Detraccion


#Region "Declaración de variables"

    Private _Id As String
    Private _IdAdquirienteProveedor As String
    Private _AdquirienteProveedor As String
    Private _RUC As String
    Private _NroLote As String
    Private _Tipo As Integer
    Private _NombreTipo As String
    Private _Estado As New e_Estado
    Private _Total As Double
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _Activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public IdPeriodo As String
    <DataMember()> _
    Public Ejercicio As Integer
    <DataMember()> _
    Public TipoCambio As Decimal
    <DataMember()> _
    Public IdCtaBancoSoles As String
    <DataMember()> _
    Public loDetraccionDet As List(Of e_DetraccionDetalle)
    <DataMember()> _
    Public loDocumento As List(Of e_MovimientoDocumento)

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdAdquirienteProveedor = ""
        _AdquirienteProveedor = ""
        _RUC = ""
        _NombreTipo = ""
        _Estado.Id = ""
        _Estado.Nombre = ""
        _NroLote = ""
        _Tipo = 0
        _Total = 0
        _UsuarioCreacion = ""
        _FechaCreacion = #1/1/1901#
        _Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAdquirienteProveedor As String _
              , ByVal ls_AdqPro As String _
              , ByVal ls_RUC As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ls_NroLote As String _
              , ByVal ln_Tipo As Integer _
              , ByVal ls_Tipo As String _
              , ByVal ln_Total As Double _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
           )
        _Id = ls_Id
        _IdAdquirienteProveedor = ls_IdAdquirienteProveedor
        _AdquirienteProveedor = ls_AdqPro
        _RUC = ls_RUC
        _Estado.Id = ls_IdEstado
        _Estado.Nombre = ls_Estado
        _NroLote = ls_NroLote
        _Tipo = ln_Tipo
        _NombreTipo = ls_Tipo
        _Total = ln_Total
        _UsuarioCreacion = ls_UsuarioCreacion
        _FechaCreacion = ld_FechaCreacion
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
    Public Property IdAdquirienteProveedor() As String
        Get
            Return _IdAdquirienteProveedor
        End Get
        Set(ByVal value As String)
            _IdAdquirienteProveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property AdquirienteProveedor() As String
        Get
            Return _AdquirienteProveedor
        End Get
        Set(ByVal value As String)
            _AdquirienteProveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property RUC() As String
        Get
            Return _RUC
        End Get
        Set(ByVal value As String)
            _RUC = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _Estado.Id
        End Get
        Set(ByVal value As String)
            _Estado.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _Estado.Nombre
        End Get
        Set(ByVal value As String)
            _Estado.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroLote() As String
        Get
            Return _NroLote
        End Get
        Set(ByVal value As String)
            _NroLote = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As Integer
        Get
            Return _Tipo
        End Get
        Set(ByVal value As Integer)
            _Tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreTipo() As String
        Get
            Return _NombreTipo
        End Get
        Set(ByVal value As String)
            _NombreTipo = value
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

#Region "Métodos"

    Public Function Obtener(ByVal detraccion As e_Detraccion) As e_Detraccion Implements Ie_Detraccion.Obtener
        Return detraccion
    End Function

#End Region

End Class
