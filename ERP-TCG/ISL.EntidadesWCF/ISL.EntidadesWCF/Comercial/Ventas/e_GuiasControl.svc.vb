

<DataContract()> _
Public Class e_GuiasControl
    Implements Ie_GuiasControl

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Activo = True
        Id = ""
        IdVehiculo = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_PlacaAntigua As String _
              , ByVal ls_PlacaActual As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Correlativo As String _
              , ByVal ls_Observacion As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_StockGuias As Integer _
              , ByVal ls_StockTalonarios As Integer _
              , ByVal ls_Flota As String)
        _id = ls_Id
        _placaAntigua = ls_PlacaAntigua
        _placaActual = ls_PlacaActual
        _idvehiculo = ls_IdVehiculo
        _serie = ls_Serie
        _correlativo = ls_Correlativo
        _observacion = ls_Observacion
        _usuariocreacion = ls_UsuarioCreacion
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
        _StockGuias = ls_StockGuias
        _StockTalonarios = ls_StockTalonarios
        _flota = ls_Flota
    End Sub

#End Region

#Region "Propiedad"

    Private _id As String
    Private _placaAntigua As String
    Private _placaActual As String
    Private _idvehiculo As String
    Private _serie As String
    Private _correlativo As String
    Private _observacion As String
    Private _usuariocreacion As String
    Private _usuariomodifica As String
    Private _flota As String
    Private _activo As Boolean
    Private _StockGuias As Integer
    Private _StockTalonarios As Integer
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public GuiasTalanonarios As New List(Of e_GuiasTalonarios)

    Public Event DatoCambiado()

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
    Public Property PlacaAntigua() As String
        Get
            Return _placaAntigua
        End Get
        Set(ByVal value As String)
            _placaAntigua = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PlacaActual() As String
        Get
            Return _placaActual
        End Get
        Set(ByVal value As String)
            _placaActual = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Correlativo() As String
        Get
            Return _correlativo
        End Get
        Set(ByVal value As String)
            _correlativo = value
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
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
   Public Property Flota() As String
        Get
            Return _flota
        End Get
        Set(ByVal value As String)
            _flota = value
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

    <DataMember()> _
    Public Property StockGuias() As Integer
        Get
            Return _StockGuias
        End Get
        Set(ByVal value As Integer)
            _StockGuias = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property StockTalonarios() As Integer
        Get
            Return _StockTalonarios
        End Get
        Set(ByVal value As Integer)
            _StockTalonarios = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal guiasControl As e_GuiasControl) As e_GuiasControl Implements Ie_GuiasControl.Obtener
        Return guiasControl
    End Function

End Class


