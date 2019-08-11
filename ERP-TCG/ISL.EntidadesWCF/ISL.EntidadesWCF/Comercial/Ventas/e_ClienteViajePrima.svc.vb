' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ClienteViajePrima" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ClienteViajePrima.svc o e_ClienteViajePrima.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ClienteViajePrima
    Implements Ie_ClienteViajePrima

#Region "Propiedad"

    Private _id As String
    Private _periodo As New e_Periodo
    Private _tipocambio As Double
    Private _totalviajes As Integer
    Private _primatotal As Double
    Private _observacion As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public loViaPriCon As New List(Of e_ClienteViajePrimaCon)
    <DataMember()> _
    Public loViaPriDet As New List(Of e_ClienteViajePrimaDet)

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
    Public Property IdPeriodo() As String
        Get
            Return _periodo.Id
        End Get
        Set(ByVal value As String)
            _periodo.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Periodo() As String
        Get
            Return _periodo.Codigo
        End Get
        Set(ByVal value As String)
            _periodo.Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TotalViajes() As Integer
        Get
            Return _totalviajes
        End Get
        Set(ByVal value As Integer)
            _totalviajes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PrimaTotal() As Double
        Get
            Return _primatotal
        End Get
        Set(ByVal value As Double)
            _primatotal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
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
        TipoOperacion = ""
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_Periodo As String _
              , ByVal ln_TipoCambio As Double _
              , ByVal ln_TotalViajes As Integer _
              , ByVal ln_PrimaTotal As Double _
              , ByVal ls_Observacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _periodo.Id = ls_IdPeriodo
        _periodo.Codigo = ls_Periodo
        _tipocambio = ln_TipoCambio
        _totalviajes = ln_TotalViajes
        _primatotal = ln_PrimaTotal
        _observacion = ls_Observacion
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal clienteviajeprima As e_ClienteViajePrima) As e_ClienteViajePrima Implements Ie_ClienteViajePrima.Obtener
        Return clienteviajeprima
    End Function

#End Region

End Class
